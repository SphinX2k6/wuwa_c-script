using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F0E RID: 28430
	public class DgmClawMovingUpState : DgmClawBaseMoveState
	{
		// Token: 0x0604532B RID: 283435 RVA: 0x0111E724 File Offset: 0x0111C924
		[NullableContext(1)]
		public DgmClawMovingUpState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, AActor clawChainActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.MovingUp;
			this.ClawChainActor = clawChainActor;
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, () => this.Owner.IsMachineActive);
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => !this.Owner.IsMachineActive);
		}

		// Token: 0x0604532C RID: 283436 RVA: 0x0111E784 File Offset: 0x0111C984
		public override void Enter()
		{
			if (!this.IsFirstEnter && DollGrabModel.Instance.DollGrabMachineGlobalConfig != null)
			{
				this.IsFirstEnter = true;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				this.MoveSpeed = dollGrabMachineGlobalConfig.钩爪上升速度;
				this.ChainScaleRatio = dollGrabMachineGlobalConfig.钩爪锁链缩放比例;
				this.UpMaxDistance = dollGrabMachineGlobalConfig.钩爪下探距离限制 * 100f;
			}
			this.CurrentUpDistance = 0f;
		}

		// Token: 0x0604532D RID: 283437 RVA: 0x0111E7EC File Offset: 0x0111C9EC
		public override void Update(float delta)
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
			float num = this.MoveSpeed * delta / 10f;
			this.CurrentUpDistance += num;
			bool flag = this.CurrentUpDistance >= this.UpMaxDistance;
			if (flag)
			{
				num -= this.CurrentUpDistance - this.UpMaxDistance;
			}
			MathUtils.Instance.CommonTempVector.Set(0.0, 0.0, (double)num);
			float num2 = num / this.ChainScaleRatio;
			FVectorDouble newScale3D = this.ClawChainActor.D_GetActorScale3D();
			newScale3D.Z -= (double)num2;
			this.ClawChainActor.D_SetActorScale3D(newScale3D);
			FHitResult fhitResult = null;
			this.ClawActor.K2_AddActorWorldOffset(MathUtils.Instance.CommonTempVector.ToUeVectorOld(), false, ref fhitResult, false);
			if (flag)
			{
				this.End();
			}
		}

		// Token: 0x0604532E RID: 283438 RVA: 0x0111E8E4 File Offset: 0x0111CAE4
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0604532F RID: 283439 RVA: 0x0111E91C File Offset: 0x0111CB1C
		public override void Resume()
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
		}

		// Token: 0x06045330 RID: 283440 RVA: 0x0111E958 File Offset: 0x0111CB58
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0402410F RID: 147727
		[Nullable(2)]
		private readonly AActor ClawChainActor;

		// Token: 0x04024110 RID: 147728
		private float ChainScaleRatio;

		// Token: 0x04024111 RID: 147729
		private float UpMaxDistance;

		// Token: 0x04024112 RID: 147730
		private float CurrentUpDistance;

		// Token: 0x04024113 RID: 147731
		private float MoveSpeed;

		// Token: 0x04024114 RID: 147732
		private int ClawMoveEventHandle = -1;
	}
}
