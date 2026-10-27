using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x020072E6 RID: 29414
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraBlendToTargetRotator : SceneCameraRotatorBase
	{
		// Token: 0x06048317 RID: 295703 RVA: 0x0128A058 File Offset: 0x01288258
		public override bool IsValid()
		{
			return !this.Finished;
		}

		// Token: 0x06048318 RID: 295704 RVA: 0x0128A063 File Offset: 0x01288263
		public override void OnActivate()
		{
			this.BlendElapsed = 0f;
			this.Finished = false;
		}

		// Token: 0x06048319 RID: 295705 RVA: 0x0128A078 File Offset: 0x01288278
		public override void ComputeExpectRotation()
		{
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				this.Finished = true;
				return;
			}
			if (this.BlendDuration <= 0f)
			{
				this.WorkingQuat.DeepCopy(this.BlendTargetQuat);
				this.Finished = true;
				return;
			}
			this.BlendElapsed += this.DeltaTime;
			float num = MathUtils.Instance.Clamp(this.BlendElapsed / this.BlendDuration, 0f, 1f);
			Quat.Slerp(this.BlendStartQuat, this.BlendTargetQuat, num, this.WorkingQuat);
			if (num >= 1f)
			{
				this.Finished = true;
			}
		}

		// Token: 0x0604831A RID: 295706 RVA: 0x0128A130 File Offset: 0x01288330
		public override void ApplyRotationLimit()
		{
			if (!this.IsNormalGravity || this.CapturedFixInputData == null)
			{
				return;
			}
			this.WorkingQuat.Rotator(this.WorkingRotator);
			base.ApplyRotatorInputLimits(this.CapturedFixInputData, this.StartRotator);
			this.WorkingRotator.Quaternion(this.WorkingQuat);
		}

		// Token: 0x0604831B RID: 295707 RVA: 0x0128A184 File Offset: 0x01288384
		public override void ApplyRotationToCameraActor()
		{
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				this.Finished = true;
				return;
			}
			if (!this.IsNormalGravity)
			{
				base.ClearCameraGravityRoll();
			}
			this.WorkingQuat.Rotator(this.WorkingRotator);
			base.WriteCameraRotation();
		}

		// Token: 0x0604831C RID: 295708 RVA: 0x0128A1E0 File Offset: 0x012883E0
		public unsafe bool InitFromLookAtTarget(SceneSubCamera subCamera, FightCameraLogicComponent fightCameraLogicComp, Vector targetPosition, float blendDurationMs)
		{
			BP_CineCamera_C camera = subCamera.Camera;
			if (camera == null || !camera.IsValid())
			{
				return false;
			}
			this.PrepareFrame(subCamera, fightCameraLogicComp, 0f);
			this.ScratchVector1.DeepCopy(targetPosition);
			Vector scratchVector = this.ScratchVector2;
			FVectorDouble fvectorDouble = camera.D_K2_GetActorLocation();
			scratchVector.DeepCopy(fvectorDouble);
			this.ScratchVector1.SubtractionEqual(this.ScratchVector2);
			if (MathUtils.Instance.IsNearlyZero(this.ScratchVector1.SizeSquared(), null))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "尝试让相机看向一个与相机位置重合的点，危险操作已被阻止";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetPosition", targetPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cameraLocation", this.ScratchVector2);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			MathUtils.Instance.LookRotationForwardFirst(this.ScratchVector1, this.GravityUp, this.WorkingQuat);
			if (!this.IsNormalGravity)
			{
				float pitchMin = -90f;
				float pitchMax = 90f;
				float yawMin = -180f;
				float yawMax = 180f;
				if (subCamera.CanAcceptInput && subCamera.FixInputData != null)
				{
					pitchMin = subCamera.FixInputData.PitchLimitMin;
					pitchMax = subCamera.FixInputData.PitchLimitMax;
					yawMin = subCamera.FixInputData.YawLimitMin;
					yawMax = subCamera.FixInputData.YawLimitMax;
				}
				base.FixCameraPitchInSpecialGravity(pitchMin, pitchMax);
				base.FixCameraYawInSpecialGravity(yawMin, yawMax);
				base.ClearCameraGravityRoll();
			}
			this.BlendTargetQuat.DeepCopy(this.WorkingQuat);
			Rotator scratchRotator = this.ScratchRotator;
			FRotator frotator = camera.K2_GetActorRotation();
			scratchRotator.DeepCopy(frotator);
			this.ScratchRotator.Quaternion(this.BlendStartQuat);
			if (this.IsNormalGravity && subCamera.CanAcceptInput && subCamera.FixInputData != null)
			{
				this.WorkingQuat.DeepCopy(this.BlendTargetQuat);
				this.WorkingQuat.Rotator(this.WorkingRotator);
				base.ApplyRotatorInputLimits(subCamera.FixInputData, this.StartRotator);
				this.WorkingRotator.Quaternion(this.BlendTargetQuat);
				this.CapturedFixInputData = new SceneFixInputData();
				this.CapturedFixInputData.DeepCopy(subCamera.FixInputData);
			}
			else
			{
				this.CapturedFixInputData = null;
			}
			this.BlendDuration = blendDurationMs;
			this.BlendElapsed = 0f;
			this.Finished = false;
			return true;
		}

		// Token: 0x040261F9 RID: 156153
		[Nullable(2)]
		private SceneFixInputData CapturedFixInputData;

		// Token: 0x040261FA RID: 156154
		private readonly Quat BlendStartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040261FB RID: 156155
		private readonly Quat BlendTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040261FC RID: 156156
		private float BlendDuration;

		// Token: 0x040261FD RID: 156157
		private float BlendElapsed;

		// Token: 0x040261FE RID: 156158
		private bool Finished;
	}
}
