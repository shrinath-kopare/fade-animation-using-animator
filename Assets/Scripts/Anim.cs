using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour {
    public GameObject cg;
    public RuntimeAnimatorController animator;
    void Start () {
        cg.gameObject.AddComponent<Animator>();
        cg.gameObject.GetComponent<Animator>().runtimeAnimatorController = animator;
    }
	
    void OnGUI() {
        if (GUI.Button(new Rect(10, 70, 50, 30), "Fade")){
            cg.gameObject.GetComponent<Animator>().SetTrigger("fade");
        }
    }
}
