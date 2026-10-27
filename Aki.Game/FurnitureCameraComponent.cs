using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02000F70 RID: 3952
[NullableContext(2)]
[Nullable(0)]
public class FurnitureCameraComponent
{
	// Token: 0x06006516 RID: 25878 RVA: 0x00141898 File Offset: 0x0013FA98
	public void EnterAreaCamera(int areaCameraId, IFurnitureCameraFadeInContext fadeInContext = null)
	{
		this.CameraMode = EFurnitureCameraMode.AreaCamera;
		FurnitureAreaCameraContext areaCameraContext = new FurnitureAreaCameraContext
		{
			AreaCameraId = areaCameraId
		};
		this.AreaCameraContext = areaCameraContext;
		SpringFestivalAreaCamera? areaCameraConfig = FurnitureConfig.Instance.GetAreaCameraConfig(areaCameraId);
		global::Vector vector = global::Vector.Create();
		vector.FromConfigVector(areaCameraConfig.Value.CameraLocation.Value);
		Aki.Config.Vector value = areaCameraConfig.Value.CameraRotator.Value;
		Rotator rot = Rotator.Create(value.Y, value.Z, value.X);
		FurnitureCameraContext cameraContext = new FurnitureCameraContext
		{
			Pos = vector,
			Rot = rot,
			Fov = (float)areaCameraConfig.Value.CameraFov
		};
		IFurnitureCameraFadeInContext furnitureCameraFadeInContext = fadeInContext;
		if (fadeInContext == null)
		{
			FurnitureCameraFadeInContext furnitureCameraFadeInContext2 = new FurnitureCameraFadeInContext();
			furnitureCameraFadeInContext2.FadeInTime = 0f;
			furnitureCameraFadeInContext = furnitureCameraFadeInContext2;
			furnitureCameraFadeInContext2.FadeInExp = 1f;
		}
		IFurnitureCameraFadeInContext fadeInContext2 = furnitureCameraFadeInContext;
		this.EnterCameraInternal(cameraContext, fadeInContext2);
	}

	// Token: 0x06006517 RID: 25879 RVA: 0x00141980 File Offset: 0x0013FB80
	[NullableContext(1)]
	public void EnterSlotCamera(IFurnitureSlotContext slotContext, [Nullable(2)] IFurnitureCameraFadeInContext fadeInContext = null)
	{
		this.CameraMode = EFurnitureCameraMode.SlotCamera;
		this.SlotContext = slotContext;
		int mapId = FurnitureModel.Instance.MapId;
		int slotEntityId = slotContext.SlotEntityId;
		FurnitureSlotComponent sceneSlotEntitySlotComponentData = FurnitureModel.Instance.GetSceneSlotEntitySlotComponentData(mapId, slotEntityId);
		if (sceneSlotEntitySlotComponentData == null)
		{
			return;
		}
		int subSlotIndex = slotContext.SubSlotIndex;
		bool flag = subSlotIndex == -1;
		IFurnitureCamera furnitureCamera = sceneSlotEntitySlotComponentData.FurnitureCamera;
		if (furnitureCamera == null)
		{
			return;
		}
		if (!flag)
		{
			IFurnitureSlot furnitureSlot = sceneSlotEntitySlotComponentData.Slots[subSlotIndex];
			IFurnitureCamera furnitureCamera2 = (furnitureSlot != null) ? furnitureSlot.SlotCamera : null;
			if (furnitureCamera2 != null)
			{
				furnitureCamera = furnitureCamera2;
			}
		}
		global::Vector vector = global::Vector.Create();
		vector.FromConfigVector(furnitureCamera.Pos);
		Rotator rot = Rotator.Create(furnitureCamera.Rot.Y.GetValueOrDefault(), furnitureCamera.Rot.Z.GetValueOrDefault(), furnitureCamera.Rot.X.GetValueOrDefault());
		int valueOrDefault = furnitureCamera.Fov.GetValueOrDefault(75);
		FurnitureCameraContext cameraContext = new FurnitureCameraContext
		{
			Pos = vector,
			Rot = rot,
			Fov = (float)valueOrDefault
		};
		IFurnitureCameraFadeInContext furnitureCameraFadeInContext = fadeInContext;
		if (furnitureCameraFadeInContext == null)
		{
			float? fadeInTime = furnitureCamera.FadeInTime;
			IBlendFunction fadeInCurve = furnitureCamera.FadeInCurve;
			float? num = (fadeInCurve != null) ? new float?(fadeInCurve.BlendExp) : null;
			bool flag2 = fadeInTime != null;
			bool flag3 = num != null;
			float? num2 = flag2 ? fadeInTime : new float?(0.5f);
			float? num3 = flag3 ? num : new float?(16f);
			furnitureCameraFadeInContext = new FurnitureCameraFadeInContext
			{
				FadeInTime = num2.Value,
				FadeInExp = num3.Value
			};
		}
		this.EnterCameraInternal(cameraContext, furnitureCameraFadeInContext);
	}

	// Token: 0x06006518 RID: 25880 RVA: 0x00141B24 File Offset: 0x0013FD24
	[NullableContext(1)]
	private void EnterCameraInternal(IFurnitureCameraContext cameraContext, IFurnitureCameraFadeInContext fadeInContext)
	{
		this.CameraContext = cameraContext;
		SceneCameraPlayerComponent playerComponent = CameraController.Instance.MainModel.SceneCamera.PlayerComponent;
		if (playerComponent == null)
		{
			return;
		}
		playerComponent.EnterFixSceneSubCamera(cameraContext.Pos, cameraContext.Rot, cameraContext.Fov, fadeInContext.FadeInTime, 0f, ESceneSubCameraType.Fix, null, new UnrealEngine.EViewTargetBlendFunction?(UnrealEngine.EViewTargetBlendFunction.VTBlend_EaseOut), new float?(fadeInContext.FadeInExp), new UnrealEngine.EViewTargetBlendFunction?(UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear), new float?(0f), new bool?(false), null, new bool?(false), null, "", null, null, null, false, false);
	}

	// Token: 0x06006519 RID: 25881 RVA: 0x00141BAF File Offset: 0x0013FDAF
	public void ExitFurnitureCamera()
	{
		CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitFixSceneSubCamera(null, true);
	}

	// Token: 0x0600651A RID: 25882 RVA: 0x00141BCC File Offset: 0x0013FDCC
	public EFurnitureCameraMode GetCameraMode()
	{
		return this.CameraMode;
	}

	// Token: 0x0600651B RID: 25883 RVA: 0x00141BD4 File Offset: 0x0013FDD4
	public IFurnitureCameraContext GetCameraContext()
	{
		return this.CameraContext;
	}

	// Token: 0x0600651C RID: 25884 RVA: 0x00141BDC File Offset: 0x0013FDDC
	public IFurnitureSlotContext GetSlotContext()
	{
		return this.SlotContext;
	}

	// Token: 0x0600651D RID: 25885 RVA: 0x00141BE4 File Offset: 0x0013FDE4
	public IFurnitureAreaCameraContext GetAreaCameraContext()
	{
		return this.AreaCameraContext;
	}

	// Token: 0x04002DF8 RID: 11768
	private EFurnitureCameraMode CameraMode;

	// Token: 0x04002DF9 RID: 11769
	private IFurnitureCameraContext CameraContext;

	// Token: 0x04002DFA RID: 11770
	private IFurnitureSlotContext SlotContext;

	// Token: 0x04002DFB RID: 11771
	private IFurnitureAreaCameraContext AreaCameraContext;
}
