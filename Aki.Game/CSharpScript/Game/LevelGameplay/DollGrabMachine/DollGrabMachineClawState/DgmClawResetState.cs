using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F10 RID: 28432
	public class DgmClawResetState : DgmClawBaseMoveState
	{
		// Token: 0x0604533C RID: 283452 RVA: 0x0111EEBD File Offset: 0x0111D0BD
		[NullableContext(1)]
		public DgmClawResetState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.Reset;
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, null);
			this.OriginalPosition = this.ClawRootActor.D_K2_GetActorLocation();
		}

		// Token: 0x0604533D RID: 283453 RVA: 0x0111EEF0 File Offset: 0x0111D0F0
		public override void Enter()
		{
			FVectorDouble fvectorDouble = this.ClawRootActor.D_K2_GetActorLocation();
			double num = this.OriginalPosition.X - fvectorDouble.X;
			double num2 = this.OriginalPosition.Y - fvectorDouble.Y;
			this.ResetTime = DollGrabModel.Instance.DollGrabMachineGlobalConfig.钩爪复位时间 * 1000f;
			this.RightMoveSpeed = (float)num / this.ResetTime;
			this.UpMoveSpeed = (float)num2 / this.ResetTime;
		}

		// Token: 0x0604533E RID: 283454 RVA: 0x0111EF68 File Offset: 0x0111D168
		public override void Update(float deltaTime)
		{
			base.Update(deltaTime);
			float num = this.RightMoveSpeed * deltaTime;
			float num2 = this.UpMoveSpeed * deltaTime;
			Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			FVectorDouble fvectorDouble = this.ClawRootActor.D_K2_GetActorLocation();
			commonTempVector.FromUeVector(fvectorDouble);
			MathUtils.Instance.CommonTempVector.X += (double)num;
			MathUtils.Instance.CommonTempVector.Y += (double)num2;
			this.ResetTime -= deltaTime;
			if (this.ResetTime <= 0f || (MathUtils.Instance.IsNearlyZero((double)num, null) && MathUtils.Instance.IsNearlyZero((double)num2, null)))
			{
				this.ClawRootActor.D_K2_SetActorLocation(this.OriginalPosition, false, ref WorldGlobal.SweepHitResult, true);
				this.End();
				this.Owner.ChangeClawState(EDollGrabMachineClawState.Idle);
				return;
			}
			this.ClawRootActor.D_K2_SetActorLocation(MathUtils.Instance.CommonTempVector.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, true);
		}

		// Token: 0x04024120 RID: 147744
		private float ResetTime;

		// Token: 0x04024121 RID: 147745
		private readonly FVectorDouble OriginalPosition;

		// Token: 0x04024122 RID: 147746
		private float RightMoveSpeed;

		// Token: 0x04024123 RID: 147747
		private float UpMoveSpeed;
	}
}
