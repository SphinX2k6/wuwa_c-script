using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x020072E9 RID: 29417
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneCameraRotatorBase
	{
		// Token: 0x0604832C RID: 295724
		public abstract bool IsValid();

		// Token: 0x0604832D RID: 295725
		public abstract void ComputeExpectRotation();

		// Token: 0x0604832E RID: 295726
		public abstract void ApplyRotationLimit();

		// Token: 0x0604832F RID: 295727
		public abstract void ApplyRotationToCameraActor();

		// Token: 0x06048330 RID: 295728 RVA: 0x0128AA6A File Offset: 0x01288C6A
		public virtual void OnActivate()
		{
		}

		// Token: 0x06048331 RID: 295729 RVA: 0x0128AA6C File Offset: 0x01288C6C
		public virtual void OnDeactivate()
		{
		}

		// Token: 0x06048332 RID: 295730 RVA: 0x0128AA6E File Offset: 0x01288C6E
		[NullableContext(2)]
		public virtual void OnTick(SceneSubCamera subCamera, FightCameraLogicComponent fightCameraLogicComp, float deltaTime)
		{
			this.PrepareFrame(subCamera, fightCameraLogicComp, deltaTime);
			this.ComputeExpectRotation();
			this.ApplyRotationLimit();
			this.ApplyRotationToCameraActor();
		}

		// Token: 0x06048333 RID: 295731 RVA: 0x0128AA8C File Offset: 0x01288C8C
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

		// Token: 0x06048334 RID: 295732 RVA: 0x0128AB04 File Offset: 0x01288D04
		protected void ClearCameraGravityRoll()
		{
			this.WorkingQuat.RotateVector(Vector.ForwardVectorProxy, this.ScratchVector1);
			MathUtils.Instance.LookRotationForwardFirst(this.ScratchVector1, this.GravityUp, this.WorkingQuat);
		}

		// Token: 0x06048335 RID: 295733 RVA: 0x0128AB38 File Offset: 0x01288D38
		protected float ClampAngleByStartRotator(float angle, float startAngle, float minLimit, float maxLimit)
		{
			float currentValue = MathUtils.Instance.WrapAngle(angle - startAngle);
			float num = MathUtils.Instance.Clamp(currentValue, minLimit, maxLimit);
			return MathUtils.Instance.WrapAngle(num + startAngle);
		}

		// Token: 0x06048336 RID: 295734 RVA: 0x0128AB70 File Offset: 0x01288D70
		protected void ApplyRotatorInputLimits(SceneFixInputData fixInput, Rotator startRot)
		{
			this.WorkingRotator.Pitch = this.ClampAngleByStartRotator(this.WorkingRotator.Pitch, startRot.Pitch, fixInput.PitchLimitMin, fixInput.PitchLimitMax);
			this.WorkingRotator.Yaw = this.ClampAngleByStartRotator(this.WorkingRotator.Yaw, startRot.Yaw, fixInput.YawLimitMin, fixInput.YawLimitMax);
		}

		// Token: 0x06048337 RID: 295735 RVA: 0x0128ABDC File Offset: 0x01288DDC
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

		// Token: 0x06048338 RID: 295736 RVA: 0x0128AD04 File Offset: 0x01288F04
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

		// Token: 0x06048339 RID: 295737 RVA: 0x0128AEA0 File Offset: 0x012890A0
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

		// Token: 0x0402620B RID: 156171
		[Nullable(2)]
		protected SceneSubCamera SubCamera;

		// Token: 0x0402620C RID: 156172
		[Nullable(2)]
		protected FightCameraLogicComponent FightCameraLogicComp;

		// Token: 0x0402620D RID: 156173
		protected float DeltaTime;

		// Token: 0x0402620E RID: 156174
		protected bool IsNormalGravity = true;

		// Token: 0x0402620F RID: 156175
		protected readonly Vector GravityUp = Vector.Create(0.0, 0.0, 1.0);

		// Token: 0x04026210 RID: 156176
		protected readonly Rotator StartRotator = Rotator.Create();

		// Token: 0x04026211 RID: 156177
		protected readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026212 RID: 156178
		protected readonly Rotator WorkingRotator = Rotator.Create();

		// Token: 0x04026213 RID: 156179
		protected readonly Quat WorkingQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026214 RID: 156180
		protected readonly Rotator ScratchRotator = Rotator.Create();

		// Token: 0x04026215 RID: 156181
		protected readonly Quat ScratchQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026216 RID: 156182
		protected readonly Quat ScratchQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04026217 RID: 156183
		protected readonly Vector ScratchVector1 = Vector.Create();

		// Token: 0x04026218 RID: 156184
		protected readonly Vector ScratchVector2 = Vector.Create();

		// Token: 0x04026219 RID: 156185
		protected readonly Vector ScratchVector3 = Vector.Create();
	}
}
