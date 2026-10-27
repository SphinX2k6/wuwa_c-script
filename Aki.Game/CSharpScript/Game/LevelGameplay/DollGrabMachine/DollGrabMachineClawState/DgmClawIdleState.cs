using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F0C RID: 28428
	public class DgmClawIdleState : DgmClawBaseMoveState
	{
		// Token: 0x0604531E RID: 283422 RVA: 0x0111E184 File Offset: 0x0111C384
		[NullableContext(1)]
		public DgmClawIdleState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.NextStateMap.Add(EDollGrabMachineClawState.Release, () => this.Owner.IsMachineActive);
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => !this.Owner.IsMachineActive);
		}

		// Token: 0x0604531F RID: 283423 RVA: 0x0111E1D4 File Offset: 0x0111C3D4
		public override void Enter()
		{
			if (!this.IsFirstEnter && DollGrabModel.Instance.DollGrabMachineGlobalConfig != null)
			{
				this.IsFirstEnter = true;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				this.MoveSpeed = dollGrabMachineGlobalConfig.钩爪移动速度;
				this.RightMaxDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
				this.RightMinDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
				this.ForwardMaxDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
				this.ForwardMinDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
			}
		}

		// Token: 0x06045320 RID: 283424 RVA: 0x0111E2B0 File Offset: 0x0111C4B0
		public override void Update(float delta)
		{
			DollGrabMachineClawDirection clawMoveDirection = this.Owner.ClawMoveDirection;
			float num = clawMoveDirection.X * this.MoveSpeed * delta / 10f;
			float num2 = clawMoveDirection.Y * this.MoveSpeed * delta / 10f;
			if (MathUtils.Instance.IsNearlyZero((double)num, null) && MathUtils.Instance.IsNearlyZero((double)num2, null))
			{
				if (this.ClawMoveEventHandle > 0)
				{
					AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
					this.ClawMoveEventHandle = -1;
				}
				return;
			}
			Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			FVectorDouble fvectorDouble = this.ClawRootActor.D_K2_GetActorLocation();
			commonTempVector.FromUeVector(fvectorDouble);
			Vector commonTempVector2 = MathUtils.Instance.CommonTempVector2;
			MathUtils.Instance.InverseTransformPosition(this.OwnerLocation, this.OwnerRotation, this.OwnerScale, MathUtils.Instance.CommonTempVector, commonTempVector2);
			commonTempVector2.X += (double)num;
			commonTempVector2.Y += (double)num2;
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_move", this.ClawRootActor, null);
			}
			commonTempVector2.X = MathUtils.Instance.Clamp(commonTempVector2.X, (double)this.RightMinDistance, (double)this.RightMaxDistance);
			commonTempVector2.Y = MathUtils.Instance.Clamp(commonTempVector2.Y, (double)this.ForwardMinDistance, (double)this.ForwardMaxDistance);
			FHitResult fhitResult = null;
			this.ClawRootActor.D_K2_SetActorRelativeLocation(commonTempVector2.ToUeVector(false), false, ref fhitResult, false);
		}

		// Token: 0x06045321 RID: 283425 RVA: 0x0111E44C File Offset: 0x0111C64C
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x06045322 RID: 283426 RVA: 0x0111E484 File Offset: 0x0111C684
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x04024103 RID: 147715
		private float MoveSpeed;

		// Token: 0x04024104 RID: 147716
		private float RightMaxDistance;

		// Token: 0x04024105 RID: 147717
		private float RightMinDistance;

		// Token: 0x04024106 RID: 147718
		private float ForwardMaxDistance;

		// Token: 0x04024107 RID: 147719
		private float ForwardMinDistance;

		// Token: 0x04024108 RID: 147720
		private int ClawMoveEventHandle = -1;
	}
}
