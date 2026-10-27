using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.Selfie;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02007300 RID: 29440
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Selfie)]
	public class PhotoCameraSelfieComponent : PhotoCameraComponentBase
	{
		// Token: 0x0604840D RID: 295949 RVA: 0x012912B8 File Offset: 0x0128F4B8
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

		// Token: 0x0604840E RID: 295950 RVA: 0x01291308 File Offset: 0x0128F508
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

		// Token: 0x0604840F RID: 295951 RVA: 0x01291477 File Offset: 0x0128F677
		protected override void OnDeactivate()
		{
			this.LeaveSelfie();
		}

		// Token: 0x06048410 RID: 295952 RVA: 0x0129147F File Offset: 0x0128F67F
		protected override void OnDestroy()
		{
			this.LeaveSelfie();
		}

		// Token: 0x06048411 RID: 295953 RVA: 0x01291488 File Offset: 0x0128F688
		private void ApplyConfig(BP_PhotoCameraConfig_C config)
		{
			SPhotoCameraSelfieIkConfig selfieIkConfig = config.SelfieIkConfig;
			this.IkPointToCameraOffset.FromUeVector(selfieIkConfig.IkPointToCameraOffset);
			this.ApplyHandIkRotationConfig(selfieIkConfig);
			this.ApplyHeadIkConfig(selfieIkConfig);
		}

		// Token: 0x06048412 RID: 295954 RVA: 0x012914BC File Offset: 0x0128F6BC
		private void ApplyHandIkRotationConfig(SPhotoCameraSelfieIkConfig selfieIk)
		{
			FVector ikcameraRotationOffsetFromHandSpace = selfieIk.IKCameraRotationOffsetFromHandSpace;
			this.IkCameraRotationOffsetFromHandSpace.Set(ikcameraRotationOffsetFromHandSpace.X, ikcameraRotationOffsetFromHandSpace.Y, ikcameraRotationOffsetFromHandSpace.Z);
			this.IkCameraRotationOffsetFromHandSpace.Quaternion(this.HandRotationOffsetFromCameraSpace);
			this.HandRotationOffsetFromCameraSpace.Inverse(this.HandRotationOffsetFromCameraSpace);
		}

		// Token: 0x06048413 RID: 295955 RVA: 0x01291510 File Offset: 0x0128F710
		private void ApplyHeadIkConfig(SPhotoCameraSelfieIkConfig selfieIk)
		{
			this.HeadIkPitchLimit[0] = selfieIk.HeadIKPitchLimitMin;
			this.HeadIkPitchLimit[1] = selfieIk.HeadIKPitchLimitMax;
			this.HeadIkYawLimit[0] = selfieIk.HeadIKYawLimitMin;
			this.HeadIkYawLimit[1] = selfieIk.HeadIKYawLimitMax;
		}

		// Token: 0x06048414 RID: 295956 RVA: 0x0129154C File Offset: 0x0128F74C
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

		// Token: 0x06048415 RID: 295957 RVA: 0x012915D8 File Offset: 0x0128F7D8
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

		// Token: 0x06048416 RID: 295958 RVA: 0x01291620 File Offset: 0x0128F820
		private void LeaveSelfie()
		{
			if (this.SelfieLogicInstance.IsInSelfie())
			{
				this.SelfieLogicInstance.LeaveSelfie();
			}
		}

		// Token: 0x06048417 RID: 295959 RVA: 0x0129163A File Offset: 0x0128F83A
		public SelfieLogic GetSelfieLogic()
		{
			return this.SelfieLogicInstance;
		}

		// Token: 0x040262CA RID: 156362
		private readonly SelfieLogic SelfieLogicInstance = new SelfieLogic();

		// Token: 0x040262CB RID: 156363
		private readonly Quat CameraRotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262CC RID: 156364
		private readonly Rotator IkCameraRotationOffsetFromHandSpace = Rotator.Create();

		// Token: 0x040262CD RID: 156365
		private readonly Quat HandRotationOffsetFromCameraSpace = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262CE RID: 156366
		private readonly Quat HandWorldRotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040262CF RID: 156367
		private readonly Vector IkPointToCameraOffset = Vector.Create();

		// Token: 0x040262D0 RID: 156368
		private readonly Vector WorldIkOffset = Vector.Create();

		// Token: 0x040262D1 RID: 156369
		private readonly Vector IkPointWorldLocation = Vector.Create();

		// Token: 0x040262D2 RID: 156370
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x040262D3 RID: 156371
		private readonly float[] HeadIkPitchLimit = new float[2];

		// Token: 0x040262D4 RID: 156372
		private readonly float[] HeadIkYawLimit = new float[2];
	}
}
