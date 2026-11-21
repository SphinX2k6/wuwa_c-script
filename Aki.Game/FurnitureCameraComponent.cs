using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02000425 RID: 1061
[NullableContext(2)]
[Nullable(0)]
public class FurnitureCameraComponent
{
	// Token: 0x060038AE RID: 14510 RVA: 0x0014A134 File Offset: 0x00148334
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

	// Token: 0x060038AF RID: 14511 RVA: 0x0014A21C File Offset: 0x0014841C
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

	// Token: 0x060038B0 RID: 14512 RVA: 0x0014A3C0 File Offset: 0x001485C0
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

	// Token: 0x060038B1 RID: 14513 RVA: 0x0014A44B File Offset: 0x0014864B
	public void ExitFurnitureCamera()
	{
		CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitFixSceneSubCamera(null, true);
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x0014A468 File Offset: 0x00148668
	public EFurnitureCameraMode GetCameraMode()
	{
		return this.CameraMode;
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x0014A470 File Offset: 0x00148670
	public IFurnitureCameraContext GetCameraContext()
	{
		return this.CameraContext;
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x0014A478 File Offset: 0x00148678
	public IFurnitureSlotContext GetSlotContext()
	{
		return this.SlotContext;
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x0014A480 File Offset: 0x00148680
	public IFurnitureAreaCameraContext GetAreaCameraContext()
	{
		return this.AreaCameraContext;
	}

	// Token: 0x04002E91 RID: 11921
	private EFurnitureCameraMode CameraMode;

	// Token: 0x04002E92 RID: 11922
	private IFurnitureCameraContext CameraContext;

	// Token: 0x04002E93 RID: 11923
	private IFurnitureSlotContext SlotContext;

	// Token: 0x04002E94 RID: 11924
	private IFurnitureAreaCameraContext AreaCameraContext;
}
