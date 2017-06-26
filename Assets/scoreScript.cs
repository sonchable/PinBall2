using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {

		score = 0;
		SetScore ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter( Collision other){

		string yourTag = other.gameObject.tag;

		if (yourTag == "SmallStarTag") {
			score += 10;
		} else if (yourTag == "LargeStarTag") {
			score += 30;
		} else if (yourTag == "SmallCloudTag") {
			score += 15;
		} else if (yourTag == "LargeCloudTag") {
			score += 50;
		}

		SetScore ();
	}

	void SetScore (){
		scoreText.text = string.Format ("Score:{0}", score);
	}

}
