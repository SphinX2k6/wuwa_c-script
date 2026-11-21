using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006483 RID: 25731
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Selfie)]
	public class PhotoCameraSelfieComponent : PhotoCameraComponentBase
	{
		// Token: 0x0603E859 RID: 256089 RVA: 0x01233C94 File Offset: 0x01231E94
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			if (next != PhotoCameraType.Selfie)
			{
				PhotoCameraType? photoCameraType = prev;
				PhotoCameraType photoCameraType2 = PhotoCameraType.Selfie;
				if (photoCameraType.GetValueOrDefault() == photoCameraType2 & photoCameraType != null)
				{
					this.LeaveSelfie();
				}
				return;
			}
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			this.ApplyConfig(currentConfig);
			this.EnterSelfie(currentConfig);
		}

		// Token: 0x0603E85A RID: 256090 RVA: 0x01233CE4 File Offset: 0x01231EE4
		protected override void OnTick(float deltaTime)
		{
			PhotoCameraType? currentMode = this.Host.CurrentMode;
			PhotoCameraType photoCameraType = PhotoCameraType.Selfie;
			if (!(currentMode.GetValueOrDefault() == photoCameraType & currentMode != null) || !this.SelfieLogicInstance.IsInSelfie())
			{
				return;
			}
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			if (currentConfig.IsOpenDebugChangeConfigPreview)
			{
				this.RefreshConfig(currentConfig);
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			virtualCamera.DesiredWorldRotation.Quaternion(this.CameraRotation);
			this.CameraRotation.Multiply(this.HandRotationOffsetFromCameraSpace, this.HandWorldRotation);
			this.CameraRotation.RotateVector(Vector.ForwardVectorProxy, this.CameraForward);
			this.CameraRotation.RotateVector(this.IkPointToCameraOffset, this.WorldIkOffset);
			virtualCamera.DesiredWorldLocation.Subtraction(this.WorldIkOffset, this.IkPointWorldLocation);
			TsBaseCharacter character = this.Host.Character;
			Vector vector;
			if (character == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorUpProxy : null);
			}
			Vector vector2 = vector;
			float cameraPitchInGravity = (vector2 != null) ? ((float)(Math.Asin(MathUtils.Instance.Clamp(this.CameraForward.DotProduct(vector2), -1.0, 1.0)) * 57.295780181884766)) : virtualCamera.DesiredWorldRotation.Pitch;
			this.SelfieLogicInstance.SetSightByCameraLocation(virtualCamera.DesiredWorldLocation);
			this.SelfieLogicInstance.SetLeftHandIkByCameraPose(this.IkPointWorldLocation, this.HandWorldRotation, cameraPitchInGravity);
		}

		// Token: 0x0603E85B RID: 256091 RVA: 0x01233E53 File Offset: 0x01232053
		protected override void OnDeactivate()
		{
			this.LeaveSelfie();
		}

		// Token: 0x0603E85C RID: 256092 RVA: 0x01233E5B File Offset: 0x0123205B
		protected override void OnDestroy()
		{
			this.LeaveSelfie();
		}

		// Token: 0x0603E85D RID: 256093 RVA: 0x01233E64 File Offset: 0x01232064
		private void ApplyConfig(BP_PhotoCameraConfig_C config)
		{
			SPhotoCameraSelfieIkConfig selfieIkConfig = config.SelfieIkConfig;
			this.IkPointToCameraOffset.FromUeVector(selfieIkConfig.IkPointToCameraOffset);
			this.ApplyHandIkRotationConfig(selfieIkConfig);
			this.ApplyHeadIkConfig(selfieIkConfig);
		}

		// Token: 0x0603E85E RID: 256094 RVA: 0x01233E98 File Offset: 0x01232098
		private void ApplyHandIkRotationConfig(SPhotoCameraSelfieIkConfig selfieIk)
		{
			FVector ikcameraRotationOffsetFromHandSpace = selfieIk.IKCameraRotationOffsetFromHandSpace;
			this.IkCameraRotationOffsetFromHandSpace.Set(ikcameraRotationOffsetFromHandSpace.X, ikcameraRotationOffsetFromHandSpace.Y, ikcameraRotationOffsetFromHandSpace.Z);
			this.IkCameraRotationOffsetFromHandSpace.Quaternion(this.HandRotationOffsetFromCameraSpace);
			this.HandRotationOffsetFromCameraSpace.Inverse(this.HandRotationOffsetFromCameraSpace);
		}

		// Token: 0x0603E85F RID: 256095 RVA: 0x01233EEC File Offset: 0x012320EC
		private void ApplyHeadIkConfig(SPhotoCameraSelfieIkConfig selfieIk)
		{
			this.HeadIkPitchLimit[0] = selfieIk.HeadIKPitchLimitMin;
			this.HeadIkPitchLimit[1] = selfieIk.HeadIKPitchLimitMax;
			this.HeadIkYawLimit[0] = selfieIk.HeadIKYawLimitMin;
			this.HeadIkYawLimit[1] = selfieIk.HeadIKYawLimitMax;
		}

		// Token: 0x0603E860 RID: 256096 RVA: 0x01233F28 File Offset: 0x01232128
		private void RefreshConfig(BP_PhotoCameraConfig_C config)
		{
			SPhotoCameraSelfieIkConfig selfieIkConfig = config.SelfieIkConfig;
			this.IkPointToCameraOffset.FromUeVector(selfieIkConfig.IkPointToCameraOffset);
			this.ApplyHandIkRotationConfig(selfieIkConfig);
			if (this.HeadIkPitchLimit[0] == selfieIkConfig.HeadIKPitchLimitMin && this.HeadIkPitchLimit[1] == selfieIkConfig.HeadIKPitchLimitMax && this.HeadIkYawLimit[0] == selfieIkConfig.HeadIKYawLimitMin && this.HeadIkYawLimit[1] == selfieIkConfig.HeadIKYawLimitMax)
			{
				return;
			}
			this.ApplyHeadIkConfig(selfieIkConfig);
			this.SelfieLogicInstance.UpdateSelfieSightLimit(this.HeadIkPitchLimit, this.HeadIkYawLimit);
		}

		// Token: 0x0603E861 RID: 256097 RVA: 0x01233FB4 File Offset: 0x012321B4
		private void EnterSelfie(BP_PhotoCameraConfig_C config)
		{
			TsBaseCharacter character = this.Host.Character;
			Entity entity = (character != null) ? character.GetEntityNoBlueprint() : null;
			if (entity == null)
			{
				return;
			}
			this.SelfieLogicInstance.EnterSelfie(entity, this.HeadIkPitchLimit, this.HeadIkYawLimit, config.CharacterMoveSpeed);
		}

		// Token: 0x0603E862 RID: 256098 RVA: 0x01233FFC File Offset: 0x012321FC
		private void LeaveSelfie()
		{
			if (this.SelfieLogicInstance.IsInSelfie())
			{
				this.SelfieLogicInstance.LeaveSelfie();
			}
		}

		// Token: 0x0603E863 RID: 256099 RVA: 0x01234016 File Offset: 0x01232216
		public SelfieLogic GetSelfieLogic()
		{
			return this.SelfieLogicInstance;
		}

		// Token: 0x040215B5 RID: 136629
		private readonly SelfieLogic SelfieLogicInstance = new SelfieLogic();

		// Token: 0x040215B6 RID: 136630
		private readonly Quat CameraRotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040215B7 RID: 136631
		private readonly Rotator IkCameraRotationOffsetFromHandSpace = Rotator.Create();

		// Token: 0x040215B8 RID: 136632
		private readonly Quat HandRotationOffsetFromCameraSpace = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040215B9 RID: 136633
		private readonly Quat HandWorldRotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040215BA RID: 136634
		private readonly Vector IkPointToCameraOffset = Vector.Create();

		// Token: 0x040215BB RID: 136635
		private readonly Vector WorldIkOffset = Vector.Create();

		// Token: 0x040215BC RID: 136636
		private readonly Vector IkPointWorldLocation = Vector.Create();

		// Token: 0x040215BD RID: 136637
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x040215BE RID: 136638
		private readonly float[] HeadIkPitchLimit = new float[2];

		// Token: 0x040215BF RID: 136639
		private readonly float[] HeadIkYawLimit = new float[2];
	}
}
