using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006091 RID: 24721
	public class DgmClawResetState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4EA RID: 242922 RVA: 0x010C8E5D File Offset: 0x010C705D
		[NullableContext(1)]
		public DgmClawResetState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.Reset;
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, null);
			this.OriginalPosition = this.ClawRootActor.D_K2_GetActorLocation();
		}

		// Token: 0x0603B4EB RID: 242923 RVA: 0x010C8E90 File Offset: 0x010C7090
		public override void Enter()
		{
			FVectorDouble fvectorDouble = this.ClawRootActor.D_K2_GetActorLocation();
			double num = this.OriginalPosition.X - fvectorDouble.X;
			double num2 = this.OriginalPosition.Y - fvectorDouble.Y;
			this.ResetTime = DollGrabModel.Instance.DollGrabMachineGlobalConfig.钩爪复位时间 * 1000f;
			this.RightMoveSpeed = (float)num / this.ResetTime;
			this.UpMoveSpeed = (float)num2 / this.ResetTime;
		}

		// Token: 0x0603B4EC RID: 242924 RVA: 0x010C8F08 File Offset: 0x010C7108
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

		// Token: 0x0401F3D5 RID: 127957
		private float ResetTime;

		// Token: 0x0401F3D6 RID: 127958
		private readonly FVectorDouble OriginalPosition;

		// Token: 0x0401F3D7 RID: 127959
		private float RightMoveSpeed;

		// Token: 0x0401F3D8 RID: 127960
		private float UpMoveSpeed;
	}
}
