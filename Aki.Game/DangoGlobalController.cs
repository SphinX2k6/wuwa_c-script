using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02001A6F RID: 6767
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DangoGlobalController : ControllerBase
{
	// Token: 0x0600C742 RID: 51010 RVA: 0x002D610C File Offset: 0x002D430C
	public void InitGlobalConfig(string configPath, [Nullable(2)] Action<bool> callback = null)
	{
		ResourceSystem.Instance.LoadAsync<BP_DangoGlobalConfig_C>(configPath, delegate([Nullable(2)] BP_DangoGlobalConfig_C result, string _)
		{
			if (result == null || !result.IsValid())
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else
			{
				DangoGlobalConfig config = DangoGlobalConfig.Create(result);
				DangoGlobalModel.Instance.Config = config;
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(true);
				return;
			}
		}, ResourceSystem.EResourceLoadPriority.Default, "Ui.DangoUi");
	}

	// Token: 0x0600C743 RID: 51011 RVA: 0x002D6148 File Offset: 0x002D4348
	public void ApplyDangoMoveCamera(Vector lookAtPosition)
	{
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
		ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Free;
		if ((cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) && config != null)
		{
			CameraController.Instance.MainModel.FreeCamera.LogicComponent.ApplyCameraBlend(lookAtPosition, null, (float)config.MovingCameraArmLength, config.MovingCameraBlendTime, config.MovingCameraCurve, config.MovingCameraFov, null);
		}
	}

	// Token: 0x0600C744 RID: 51012 RVA: 0x002D61C0 File Offset: 0x002D43C0
	public void ApplyDangoBeforeMoveCamera(Vector lookAtPosition, [Nullable(2)] Action callback = null)
	{
		DangoGlobalConfig config = DangoGlobalModel.Instance.Config;
		ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
		ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Free;
		bool flag = cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		ACameraActor cameraActor = CameraController.Instance.MainModel.FreeCamera.DisplayComponent.CameraActor;
		if (config == null || !flag || cameraActor == null || !cameraActor.IsValid())
		{
			if (callback != null)
			{
				callback();
			}
			return;
		}
		int beforeMoveCameraArmLength = config.BeforeMoveCameraArmLength;
		Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		Vector vector = Vector.Create();
		Vector vector2 = Vector.Create();
		quat.FromUeQuat(cameraActor.K2_GetActorQuaternion());
		quat.RotateVector(Vector.ForwardVectorProxy, vector2);
		vector2.MultiplyEqual((double)(-(double)beforeMoveCameraArmLength));
		vector2.AdditionEqual(lookAtPosition);
		Vector vector3 = vector;
		FVectorDouble fvectorDouble = cameraActor.D_K2_GetActorLocation();
		vector3.FromUeVector(fvectorDouble);
		double num = Vector.Dist(vector2, vector);
		if (num < (double)config.BeforeMoveCameraTriggerDistance)
		{
			if (callback != null)
			{
				callback();
			}
			return;
		}
		float blendTime;
		if (num > (double)config.BeforeMoveCameraFarDistance)
		{
			blendTime = config.BeforeMoveCameraBlendTimeFar;
		}
		else
		{
			blendTime = (float)MathUtils.Instance.RangeClamp(num, (double)config.BeforeMoveCameraCloseDistanceEdgeMin, (double)config.BeforeMoveCameraCloseDistanceEdgeMax, (double)config.BeforeMoveCameraBlendTimeCloseMin, (double)config.BeforeMoveCameraBlendTimeCloseMax);
		}
		CameraController.Instance.MainModel.FreeCamera.LogicComponent.ApplyCameraBlend(lookAtPosition, null, (float)beforeMoveCameraArmLength, blendTime, config.BeforeMoveCameraCurve, config.BeforeMoveCameraFov, callback);
	}

	// Token: 0x17001057 RID: 4183
	// (get) Token: 0x0600C745 RID: 51013 RVA: 0x002D6343 File Offset: 0x002D4543
	public static DangoGlobalController Instance
	{
		get
		{
			return DangoGlobalController._Instance;
		}
	}

	// Token: 0x0600C746 RID: 51014 RVA: 0x002D634A File Offset: 0x002D454A
	public static DangoGlobalController GetOrCreateInstance()
	{
		if (DangoGlobalController._Instance == null)
		{
			DangoGlobalController.CreateInstance();
		}
		return DangoGlobalController._Instance;
	}

	// Token: 0x0600C747 RID: 51015 RVA: 0x002D635E File Offset: 0x002D455E
	public static bool CreateInstance()
	{
		if (DangoGlobalController._Instance != null)
		{
			return true;
		}
		DangoGlobalController._Instance = new DangoGlobalController();
		return true;
	}

	// Token: 0x0600C748 RID: 51016 RVA: 0x002D6374 File Offset: 0x002D4574
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C749 RID: 51017 RVA: 0x002D6376 File Offset: 0x002D4576
	public static void ResetStaticDefaultValue()
	{
		DangoGlobalController._Instance = null;
	}

	// Token: 0x0600C74A RID: 51018 RVA: 0x002D637E File Offset: 0x002D457E
	static DangoGlobalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoGlobalController.CreateStaticDefaultValue), new Action(DangoGlobalController.ResetStaticDefaultValue));
	}

	// Token: 0x04005BE6 RID: 23526
	[Nullable(2)]
	private static DangoGlobalController _Instance;
}
