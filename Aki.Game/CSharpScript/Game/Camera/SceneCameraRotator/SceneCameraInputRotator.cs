using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x0200646B RID: 25707
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraInputRotator : SceneCameraRotatorBase
	{
		// Token: 0x0603E770 RID: 255856 RVA: 0x0122D028 File Offset: 0x0122B228
		public SceneCameraInputRotator(SceneFixInputData fixInputData)
		{
			this.CapturedFixInputData.DeepCopy(fixInputData);
			CameraModel instance = CameraModel.Instance;
			this.MobileDensityYawScale = instance.MobileDensityYawScale;
			this.MobileDensityPitchScale = instance.MobileDensityPitchScale;
		}

		// Token: 0x0603E771 RID: 255857 RVA: 0x0122D070 File Offset: 0x0122B270
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x0603E772 RID: 255858 RVA: 0x0122D074 File Offset: 0x0122B274
		public override void ComputeExpectRotation()
		{
			this.ComputeCameraInput(this.FightCameraLogicComp);
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				return;
			}
			Rotator workingRotator = this.WorkingRotator;
			FRotator frotator = bp_CineCamera_C.K2_GetActorRotation();
			workingRotator.DeepCopy(frotator);
			if (this.IsNormalGravity)
			{
				if (this.CurrentFrameHasCameraRotationInput)
				{
					this.WorkingRotator.Pitch = MathUtils.Instance.WrapAngle(this.WorkingRotator.Pitch + this.PitchRotateSpeed);
					this.WorkingRotator.Yaw = MathUtils.Instance.WrapAngle(this.WorkingRotator.Yaw + this.YawRotateSpeed);
				}
				return;
			}
			this.WorkingRotator.Quaternion(this.WorkingQuat);
			if (!this.CurrentFrameHasCameraRotationInput)
			{
				return;
			}
			Quat.ConstructorByAxisAngle(this.GravityUp, this.YawRotateSpeed * 0.017453292f, this.ScratchQuat1);
			this.ScratchQuat1.Multiply(this.WorkingQuat, this.ScratchQuat2);
			this.WorkingQuat.DeepCopy(this.ScratchQuat2);
			this.ScratchRotator.Set(this.PitchRotateSpeed, 0f, 0f);
			this.ScratchRotator.Quaternion(this.ScratchQuat1);
			this.WorkingQuat.Multiply(this.ScratchQuat1, this.ScratchQuat2);
			this.WorkingQuat.DeepCopy(this.ScratchQuat2);
		}

		// Token: 0x0603E773 RID: 255859 RVA: 0x0122D1D4 File Offset: 0x0122B3D4
		public override void ApplyRotationLimit()
		{
			if (!this.IsNormalGravity)
			{
				if (this.CurrentFrameHasCameraRotationInput)
				{
					base.FixCameraPitchInSpecialGravity(this.CapturedFixInputData.PitchLimitMin, this.CapturedFixInputData.PitchLimitMax);
					base.FixCameraYawInSpecialGravity(this.CapturedFixInputData.YawLimitMin, this.CapturedFixInputData.YawLimitMax);
				}
				return;
			}
			if (!this.CurrentFrameHasCameraRotationInput)
			{
				return;
			}
			base.ApplyRotatorInputLimits(this.CapturedFixInputData, this.StartRotator);
		}

		// Token: 0x0603E774 RID: 255860 RVA: 0x0122D245 File Offset: 0x0122B445
		public override void ApplyRotationToCameraActor()
		{
			if (!this.IsNormalGravity)
			{
				base.ClearCameraGravityRoll();
				this.WorkingQuat.Rotator(this.WorkingRotator);
				base.WriteCameraRotation();
				return;
			}
			if (!this.CurrentFrameHasCameraRotationInput)
			{
				return;
			}
			base.WriteCameraRotation();
		}

		// Token: 0x0603E775 RID: 255861 RVA: 0x0122D280 File Offset: 0x0122B480
		[NullableContext(2)]
		private void ComputeCameraInput(FightCameraLogicComponent fightCameraLogicComp)
		{
			this.PitchRotateSpeed = 0f;
			this.YawRotateSpeed = 0f;
			this.CurrentFrameHasCameraRotationInput = false;
			if (fightCameraLogicComp == null)
			{
				return;
			}
			EntityHandle characterEntityHandle = fightCameraLogicComp.CharacterEntityHandle;
			if (characterEntityHandle == null || !characterEntityHandle.IsInit)
			{
				return;
			}
			WorldEntity entity = characterEntityHandle.Entity;
			CharacterInputComponent characterInputComponent = (entity != null) ? entity.GetComponent<CharacterInputComponent>() : null;
			if (characterInputComponent == null)
			{
				return;
			}
			ValueTuple<float, float> cameraInput = characterInputComponent.GetCameraInput();
			float num = cameraInput.Item1;
			float num2 = cameraInput.Item2;
			bool flag = (double)Math.Abs(num) >= 0.0001;
			bool flag2 = (double)Math.Abs(num2) >= 0.0001;
			this.CurrentFrameHasCameraRotationInput = (flag || flag2);
			if (SceneCameraInputRotator.IsInGamepad())
			{
				num *= 1f;
				num2 *= 1f;
			}
			else if (Info.Instance.IsInKeyBoard())
			{
				num *= CharacterModel.Instance.SelfCenteredTimeDilation;
				num2 *= CharacterModel.Instance.SelfCenteredTimeDilation;
				num /= 60f;
				num2 /= 60f;
			}
			else if (SceneCameraInputRotator.IsInTouch())
			{
				num *= 180f * this.MobileDensityYawScale;
				num2 *= 180f * this.MobileDensityPitchScale;
				num /= 3f;
				num2 /= 3f;
			}
			this.YawRotateSpeed = num * this.CapturedFixInputData.YawInputSpeed;
			this.PitchRotateSpeed = -num2 * this.CapturedFixInputData.PitchInputSpeed;
		}

		// Token: 0x0603E776 RID: 255862 RVA: 0x0122D3D1 File Offset: 0x0122B5D1
		private static bool IsInTouch()
		{
			return Info.Instance.IsInTouch() || (Info.Instance.IsInGamepad() && ControlScreenModel.Instance.IsTouching);
		}

		// Token: 0x0603E777 RID: 255863 RVA: 0x0122D3F9 File Offset: 0x0122B5F9
		private static bool IsInGamepad()
		{
			return Info.Instance.IsInGamepad() && !ControlScreenModel.Instance.IsTouching;
		}

		// Token: 0x040214EC RID: 136428
		private const float DEFAULT_FPS = 60f;

		// Token: 0x040214ED RID: 136429
		private const float TOUCH_DEFAULT_PARAM = 3f;

		// Token: 0x040214EE RID: 136430
		private const float DEFAULT_DPI = 180f;

		// Token: 0x040214EF RID: 136431
		private const float DEFAULT_GAMEPAD_INPUT_RATE = 1f;

		// Token: 0x040214F0 RID: 136432
		private readonly SceneFixInputData CapturedFixInputData = new SceneFixInputData();

		// Token: 0x040214F1 RID: 136433
		private readonly float MobileDensityYawScale;

		// Token: 0x040214F2 RID: 136434
		private readonly float MobileDensityPitchScale;

		// Token: 0x040214F3 RID: 136435
		private float PitchRotateSpeed;

		// Token: 0x040214F4 RID: 136436
		private float YawRotateSpeed;

		// Token: 0x040214F5 RID: 136437
		private bool CurrentFrameHasCameraRotationInput;
	}
}
