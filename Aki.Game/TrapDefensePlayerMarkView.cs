using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x020011F0 RID: 4592
[NullableContext(1)]
[Nullable(0)]
public class TrapDefensePlayerMarkView : TrapDefenseMarkView
{
	// Token: 0x0600B65C RID: 46684 RVA: 0x0035DFBC File Offset: 0x0035C1BC
	public TrapDefensePlayerMarkView(int markId, UUISprite playerSight) : base(markId)
	{
		this.PlayerSight = playerSight;
		this.NeedUpdatePositionInner = true;
	}

	// Token: 0x0600B65D RID: 46685 RVA: 0x0035E012 File Offset: 0x0035C212
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B65E RID: 46686 RVA: 0x0035E038 File Offset: 0x0035C238
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

	// Token: 0x0600B65F RID: 46687 RVA: 0x0035E15C File Offset: 0x0035C35C
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

	// Token: 0x04006986 RID: 27014
	private const float PLAYER_ROTATE_UPDATE_THRESHOLD = 10f;

	// Token: 0x04006987 RID: 27015
	private FRotator TempSightRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x04006988 RID: 27016
	private FRotator TempPlayerRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x04006989 RID: 27017
	private readonly UUISprite PlayerSight;

	// Token: 0x020074BC RID: 29884
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x04025FBA RID: 155578
		public const int PlayerItem = 0;
	}
}
