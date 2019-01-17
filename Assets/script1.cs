using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public float speed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         /* if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity=new Vector2(0,5);

        } else if(Input.GetKeyDown(KeyCode.A))
        {

        }
        else if(Input.GetKeyDown(KeyCode.D))
        {

        }*/
        float horiz=Input.GetAxis("Horizontal");
        float vert=Input.GetAxis("Vertical");
        Debug.Log("x: "+horiz+" y:"+vert);
        Vector2 newVelocity=new Vector2(horiz,vert);
        //GetComponent<Rigidbody2D>().velocity=new Vector2(0,5);
        GetComponent<Rigidbody2D>().velocity=newVelocity*speed;//new Vector2(horiz,vert);
        //move my char based on those button presses
    }
}
