using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct LineBrim
{
    public Vector3 start;
    public Vector3 end;

    public LineBrim(Vector3 start, Vector3 end){
        this.start = start;
        this.end = end;
    }
}



public class DrawBezierCurve : MonoBehaviour
{
    public List<Transform> dots;
    public List<Vector3> posList;
    // public List<LineBrm> lid;
    public List<Vector3> temp;
	List<Vector3> t2 = new List<Vector3>();
    void Start()
    {
        Debug.Log("this is a test~");
        posList.Clear();
        temp.Clear();
        for(int i =0; i < dots.Count; i++) {
            //posList.Add(dots[i].position);
            temp.Add(dots[i].position);
        }
        
        for(int i = 0; i < 100; i++) {
            posList.Add(GetOne(i / 100.0f, temp));
        }
    }

    public Vector3 GetOne(float t, List<Vector3> temp2) {
		
		List<Vector3> li = new List<Vector3>();
		List<Vector3> t3 = new List<Vector3>();
		for(int i=0; i < temp2.Count;i++) {
			t3.Add(temp2[i]);
		}




		while(t3.Count > 2) {
			Debug.Log("ddddd");
			li.Clear();
			for(int j =0; j < t3.Count -1; j++) {
				Vector3 td = Vector3.Lerp(t3[j], t3[j+1], t);
				li.Add(td);
			}
			Debug.Log(li.Count);
			t3.Clear();
			for(int j =0; j < li.Count;j++) {
				t3.Add(li[j]);
			}
        } 

       Debug.Log(t3.Count);
       Vector3 dd = Vector3.Lerp(t3[0], t3[1], t);
		t3.Clear();
		return dd;
       
       

    }

    
    void Update()
    {
        
    }

    

    void drawBezier() {
        
    } 


    void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;
        for (int i =0; i< posList.Count-1;i++) {
          Gizmos.DrawLine(posList[i], posList[i+1]);
        }
        
    }

    
}
