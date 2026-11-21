using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x0200646C RID: 25708
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneCameraRotatorBase
	{
		// Token: 0x0603E778 RID: 255864
		public abstract bool IsValid();

		// Token: 0x0603E779 RID: 255865
		public abstract void ComputeExpectRotation();

		// Token: 0x0603E77A RID: 255866
		public abstract void ApplyRotationLimit();

		// Token: 0x0603E77B RID: 255867
		public abstract void ApplyRotationToCameraActor();

		// Token: 0x0603E77C RID: 255868 RVA: 0x0122D416 File Offset: 0x0122B616
		public virtual void OnActivate()
		{
		}

		// Token: 0x0603E77D RID: 255869 RVA: 0x0122D418 File Offset: 0x0122B618
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x0603E77E RID: 255870 RVA: 0x0122D41A File Offset: 0x0122B61A
		[NullableContext(2)]
		public virtual void OnTick(SceneSubCamera subCamera, FightCameraLogicComponent fightCameraLogicComp, float deltaTime)
		{
			this.PrepareFrame(subCamera, fightCameraLogicComp, deltaTime);
			this.ComputeExpectRotation();
			this.ApplyRotationLimit();
			this.ApplyRotationToCameraActor();
		}

		// Token: 0x0603E77F RID: 255871 RVA: 0x0122D438 File Offset: 0x0122B638
		[NullableContext(2)]
		public virtual void PrepareFrame(SceneSubCamera subCamera, FightCameraLogicComponent fightCameraLogicComp, float deltaTime)
		{
			this.SubCamera = subCamera;
			this.FightCameraLogicComp = fightCameraLogicComp;
			this.DeltaTime = deltaTime;
			if (subCamera == null || fightCameraLogicComp == null)
			{
				return;
			}
			this.IsNormalGravity = fightCameraLogicComp.IsInNormalGravityMode();
			this.StartRotator.DeepCopy(subCamera.StartRotation);
			this.StartRotator.Quaternion(this.StartQuat);
			this.GravityUp.DeepCopy(this.IsNormalGravity ? Vector.UpVectorProxy : fightCameraLogicComp.GravityUp);
		}

		// Token: 0x0603E780 RID: 255872 RVA: 0x0122D4B0 File Offset: 0x0122B6B0
		protected void ClearCameraGravityRoll()
		{
			this.WorkingQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector1);
			MathUtils.Instance.LookRotationForwardFirst(this.ScratchVector1, this.GravityUp, this.WorkingQuat);
		}

		// Token: 0x0603E781 RID: 255873 RVA: 0x0122D4E4 File Offset: 0x0122B6E4
		protected float ClampAngleByStartRotator(float angle, float startAngle, float minLimit, float maxLimit)
		{
			float currentValue = MathUtils.Instance.WrapAngle(angle - startAngle);
			float num = MathUtils.Instance.Clamp(currentValue, minLimit, maxLimit);
			return MathUtils.Instance.WrapAngle(num + startAngle);
		}

		// Token: 0x0603E782 RID: 255874 RVA: 0x0122D51C File Offset: 0x0122B71C
		protected void ApplyRotatorInputLimits(SceneFixInputData fixInput, Rotator startRot)
		{
			this.WorkingRotator.Pitch = this.ClampAngleByStartRotator(this.WorkingRotator.Pitch, startRot.Pitch, fixInput.PitchLimitMin, fixInput.PitchLimitMax);
			this.WorkingRotator.Yaw = this.ClampAngleByStartRotator(this.WorkingRotator.Yaw, startRot.Yaw, fixInput.YawLimitMin, fixInput.YawLimitMax);
		}

		// Token: 0x0603E783 RID: 255875 RVA: 0x0122D588 File Offset: 0x0122B788
		protected void FixCameraPitchInSpecialGravity(float pitchMin, float pitchMax)
		{
			this.StartQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector1);
			float num = (float)Math.Asin((double)MathUtils.Instance.Clamp((float)this.ScratchVector1.DotProduct(this.GravityUp), -1f, 1f)) * 57.29578f;
			this.WorkingQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector2);
			float num2 = (float)Math.Asin((double)MathUtils.Instance.Clamp((float)this.ScratchVector2.DotProduct(this.GravityUp), -1f, 1f)) * 57.29578f;
			float num3 = MathUtils.Instance.WrapAngle(num2 - num);
			float num4 = MathUtils.Instance.Clamp(num3, pitchMin, pitchMax);
			if ((double)Math.Abs(num4 - num3) > 0.0001)
			{
				float inPitch = num4 - num3;
				this.ScratchRotator.Set(inPitch, 0f, 0f);
				this.ScratchRotator.Quaternion(this.ScratchQuat1);
				this.WorkingQuat.Multiply(this.ScratchQuat1, this.ScratchQuat2);
				this.WorkingQuat.DeepCopy(this.ScratchQuat2);
			}
		}

		// Token: 0x0603E784 RID: 255876 RVA: 0x0122D6B0 File Offset: 0x0122B8B0
		protected void FixCameraYawInSpecialGravity(float yawMin, float yawMax)
		{
			this.StartQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector1);
			float num = (float)this.ScratchVector1.DotProduct(this.GravityUp);
			this.GravityUp.Multiply((double)num, this.ScratchVector3);
			this.ScratchVector1.SubtractionEqual(this.ScratchVector3);
			this.ScratchVector1.Normalize(9.99999993922529E-09);
			this.WorkingQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector2);
			float num2 = (float)this.ScratchVector2.DotProduct(this.GravityUp);
			this.GravityUp.Multiply((double)num2, this.ScratchVector3);
			this.ScratchVector2.SubtractionEqual(this.ScratchVector3);
			this.ScratchVector2.Normalize(9.99999993922529E-09);
			float num3 = (float)MathUtils.Instance.GetAngleByVectorDot(this.ScratchVector1, this.ScratchVector2);
			this.ScratchVector1.CrossProduct(this.ScratchVector2, this.ScratchVector3);
			float num4 = (this.ScratchVector3.DotProduct(this.GravityUp) >= 0.0) ? 1f : -1f;
			float num5 = num3 * num4;
			float num6 = MathUtils.Instance.Clamp(num5, yawMin, yawMax);
			if ((double)Math.Abs(num6 - num5) > 0.0001)
			{
				float num7 = num6 - num5;
				Quat.ConstructorByAxisAngle(this.GravityUp, num7 * 0.017453292f, this.ScratchQuat1);
				this.ScratchQuat1.Multiply(this.WorkingQuat, this.ScratchQuat2);
				this.WorkingQuat.DeepCopy(this.ScratchQuat2);
			}
		}

		// Token: 0x0603E785 RID: 255877 RVA: 0x0122D854 File Offset: 0x0122BA54
		protected void WriteCameraRotation()
		{
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				return;
			}
			bp_CineCamera_C.K2_SetActorRotation(this.WorkingRotator.ToUeRotator(), false);
		}

		// Token: 0x040214F6 RID: 136438
		[Nullable(2)]
		protected SceneSubCamera SubCamera;

		// Token: 0x040214F7 RID: 136439
		[Nullable(2)]
		protected FightCameraLogicComponent FightCameraLogicComp;

		// Token: 0x040214F8 RID: 136440
		protected float DeltaTime;

		// Token: 0x040214F9 RID: 136441
		protected bool IsNormalGravity = true;

		// Token: 0x040214FA RID: 136442
		protected readonly Vector GravityUp = Vector.Create(0.0, 0.0, 1.0);

		// Token: 0x040214FB RID: 136443
		protected readonly Rotator StartRotator = Rotator.Create();

		// Token: 0x040214FC RID: 136444
		protected readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040214FD RID: 136445
		protected readonly Rotator WorkingRotator = Rotator.Create();

		// Token: 0x040214FE RID: 136446
		protected readonly Quat WorkingQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040214FF RID: 136447
		protected readonly Rotator ScratchRotator = Rotator.Create();

		// Token: 0x04021500 RID: 136448
		protected readonly Quat ScratchQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021501 RID: 136449
		protected readonly Quat ScratchQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04021502 RID: 136450
		protected readonly Vector ScratchVector1 = Vector.Create();

		// Token: 0x04021503 RID: 136451
		protected readonly Vector ScratchVector2 = Vector.Create();

		// Token: 0x04021504 RID: 136452
		protected readonly Vector ScratchVector3 = Vector.Create();
	}
}
