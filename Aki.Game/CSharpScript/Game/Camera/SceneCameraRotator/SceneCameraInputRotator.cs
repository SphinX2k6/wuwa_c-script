using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x020072E8 RID: 29416
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraInputRotator : SceneCameraRotatorBase
	{
		// Token: 0x06048324 RID: 295716 RVA: 0x0128A67C File Offset: 0x0128887C
		public SceneCameraInputRotator(SceneFixInputData fixInputData)
		{
			this.CapturedFixInputData.DeepCopy(fixInputData);
			CameraModel instance = CameraModel.Instance;
			this.MobileDensityYawScale = instance.MobileDensityYawScale;
			this.MobileDensityPitchScale = instance.MobileDensityPitchScale;
		}

		// Token: 0x06048325 RID: 295717 RVA: 0x0128A6C4 File Offset: 0x012888C4
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x06048326 RID: 295718 RVA: 0x0128A6C8 File Offset: 0x012888C8
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

		// Token: 0x06048327 RID: 295719 RVA: 0x0128A828 File Offset: 0x01288A28
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

		// Token: 0x06048328 RID: 295720 RVA: 0x0128A899 File Offset: 0x01288A99
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

		// Token: 0x06048329 RID: 295721 RVA: 0x0128A8D4 File Offset: 0x01288AD4
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

		// Token: 0x0604832A RID: 295722 RVA: 0x0128AA25 File Offset: 0x01288C25
		private static bool IsInTouch()
		{
			return Info.Instance.IsInTouch() || (Info.Instance.IsInGamepad() && ControlScreenModel.Instance.IsTouching);
		}

		// Token: 0x0604832B RID: 295723 RVA: 0x0128AA4D File Offset: 0x01288C4D
		private static bool IsInGamepad()
		{
			return Info.Instance.IsInGamepad() && !ControlScreenModel.Instance.IsTouching;
		}

		// Token: 0x04026201 RID: 156161
		private const float DEFAULT_FPS = 60f;

		// Token: 0x04026202 RID: 156162
		private const float TOUCH_DEFAULT_PARAM = 3f;

		// Token: 0x04026203 RID: 156163
		private const float DEFAULT_DPI = 180f;

		// Token: 0x04026204 RID: 156164
		private const float DEFAULT_GAMEPAD_INPUT_RATE = 1f;

		// Token: 0x04026205 RID: 156165
		private readonly SceneFixInputData CapturedFixInputData = new SceneFixInputData();

		// Token: 0x04026206 RID: 156166
		private readonly float MobileDensityYawScale;

		// Token: 0x04026207 RID: 156167
		private readonly float MobileDensityPitchScale;

		// Token: 0x04026208 RID: 156168
		private float PitchRotateSpeed;

		// Token: 0x04026209 RID: 156169
		private float YawRotateSpeed;

		// Token: 0x0402620A RID: 156170
		private bool CurrentFrameHasCameraRotationInput;
	}
}
