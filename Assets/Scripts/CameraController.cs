﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;
	public Vector3 cameraOffset;

	void LateUpdate ()
	{
		if (player != null)
		{
			transform.position = player.transform.position + cameraOffset;
		}
	}
}
