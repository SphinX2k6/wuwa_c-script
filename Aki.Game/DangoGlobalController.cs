using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02000F2E RID: 3886
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DangoGlobalController : ControllerBase
{
	// Token: 0x06009B52 RID: 39762 RVA: 0x002E11FC File Offset: 0x002DF3FC
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

	// Token: 0x06009B53 RID: 39763 RVA: 0x002E1238 File Offset: 0x002DF438
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

	// Token: 0x06009B54 RID: 39764 RVA: 0x002E12B0 File Offset: 0x002DF4B0
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

	// Token: 0x1700107C RID: 4220
	// (get) Token: 0x06009B55 RID: 39765 RVA: 0x002E1433 File Offset: 0x002DF633
	public static DangoGlobalController Instance
	{
		get
		{
			return DangoGlobalController._Instance;
		}
	}

	// Token: 0x06009B56 RID: 39766 RVA: 0x002E143A File Offset: 0x002DF63A
	public static DangoGlobalController GetOrCreateInstance()
	{
		if (DangoGlobalController._Instance == null)
		{
			DangoGlobalController.CreateInstance();
		}
		return DangoGlobalController._Instance;
	}

	// Token: 0x06009B57 RID: 39767 RVA: 0x002E144E File Offset: 0x002DF64E
	public static bool CreateInstance()
	{
		if (DangoGlobalController._Instance != null)
		{
			return true;
		}
		DangoGlobalController._Instance = new DangoGlobalController();
		return true;
	}

	// Token: 0x06009B58 RID: 39768 RVA: 0x002E1464 File Offset: 0x002DF664
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009B59 RID: 39769 RVA: 0x002E1466 File Offset: 0x002DF666
	public static void ResetStaticDefaultValue()
	{
		DangoGlobalController._Instance = null;
	}

	// Token: 0x06009B5A RID: 39770 RVA: 0x002E146E File Offset: 0x002DF66E
	static DangoGlobalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoGlobalController.CreateStaticDefaultValue), new Action(DangoGlobalController.ResetStaticDefaultValue));
	}

	// Token: 0x04005CB5 RID: 23733
	[Nullable(2)]
	private static DangoGlobalController _Instance;
}
