using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x02001D2E RID: 7470
[NullableContext(1)]
[Nullable(0)]
public class TrapDefensePlayerMarkView : TrapDefenseMarkView
{
	// Token: 0x0600E23F RID: 57919 RVA: 0x0035258C File Offset: 0x0035078C
	public TrapDefensePlayerMarkView(int markId, UUISprite playerSight) : base(markId)
	{
		this.PlayerSight = playerSight;
		this.NeedUpdatePositionInner = true;
	}

	// Token: 0x0600E240 RID: 57920 RVA: 0x003525E2 File Offset: 0x003507E2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600E241 RID: 57921 RVA: 0x00352608 File Offset: 0x00350808
	public override void UpdatePosition(float scale, Vector2D centerOffset)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return;
		}
		CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		TrapDefenseMarkItem markData = base.GetMarkData();
		if (markData == null)
		{
			return;
		}
		Vector uiPosition = markData.UiPosition;
		Vector2D vector2D = Vector2D.Create(uiPosition.X, uiPosition.Y);
		Vector2D vector2D2 = Vector2D.Create();
		vector2D.Multiply((double)scale, vector2D2).Subtraction(centerOffset, vector2D2);
		Vector2D value = vector2D2;
		UUIItem[] relativeItems = new UUISprite[]
		{
			this.PlayerSight
		};
		base.SetAnchorOffset(value, relativeItems);
		UUIItem item = base.GetItem(0);
		float num = -(component.ActorRotationProxy.Yaw + 90f);
		if (Math.Abs(this.TempPlayerRotator.Yaw - num) > 10f)
		{
			this.TempPlayerRotator.Yaw = num;
			item.SetUIRelativeRotation(this.TempPlayerRotator);
		}
		float desiredYaw = -(CameraModel.Instance.MainModel.CameraRotator.Yaw + 90f);
		this.TempSightRotator.Yaw = this.ClampCameraYaw(desiredYaw);
		this.PlayerSight.SetUIRelativeRotation(this.TempSightRotator);
	}

	// Token: 0x0600E242 RID: 57922 RVA: 0x0035272C File Offset: 0x0035092C
	private float ClampCameraYaw(float desiredYaw)
	{
		ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
		ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
		if ((cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) && CameraModel.Instance.MainModel.FightCamera != null && CameraModel.Instance.MainModel.FightCamera.LogicComponent != null)
		{
			VirtualCamera currentCamera = CameraModel.Instance.MainModel.FightCamera.LogicComponent.CurrentCamera;
			float yawLimitMin = currentCamera.YawLimitMin;
			float num = (currentCamera.YawLimitMax - yawLimitMin) % 360f;
			if (MathUtils.Instance.IsNearlyZero((double)num, null) || MathUtils.Instance.IsNearlyEqual((double)num, 360.0, null))
			{
				return MathUtils.Instance.Clamp(MathUtils.Instance.WrapAngle(desiredYaw), currentCamera.WorldYawMin, currentCamera.WorldYawMax);
			}
		}
		return desiredYaw;
	}

	// Token: 0x040068A7 RID: 26791
	private const float PLAYER_ROTATE_UPDATE_THRESHOLD = 10f;

	// Token: 0x040068A8 RID: 26792
	private FRotator TempSightRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x040068A9 RID: 26793
	private FRotator TempPlayerRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x040068AA RID: 26794
	private readonly UUISprite PlayerSight;

	// Token: 0x02008333 RID: 33587
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x0402AC92 RID: 175250
		public const int PlayerItem = 0;
	}
}
