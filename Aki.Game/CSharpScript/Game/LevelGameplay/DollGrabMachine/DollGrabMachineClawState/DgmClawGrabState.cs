using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F0B RID: 28427
	[NullableContext(2)]
	[Nullable(0)]
	public class DgmClawGrabState : DgmClawBaseMoveState
	{
		// Token: 0x06045315 RID: 283413 RVA: 0x0111DC44 File Offset: 0x0111BE44
		[NullableContext(1)]
		public DgmClawGrabState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.Grabbing;
			this.NextStateMap.Add(EDollGrabMachineClawState.MovingUp, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.MovingDown);
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.Release && (this.Owner.IsMachineActive || this.Owner.IsMachinePause));
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.Release && !this.Owner.IsMachineActive && !this.Owner.IsMachinePause);
		}

		// Token: 0x06045316 RID: 283414 RVA: 0x0111DCB4 File Offset: 0x0111BEB4
		public override void Enter()
		{
			if (!this.IsFirstEnter)
			{
				this.IsFirstEnter = true;
				this.SeqActor = this.Owner.ClawAnimSeqActor;
				this.Model = DollGrabModel.Instance;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = this.Model.DollGrabMachineGlobalConfig;
				if (dollGrabMachineGlobalConfig != null)
				{
					this.MoveSpeed = dollGrabMachineGlobalConfig.钩爪移动速度;
					this.RightMaxDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
					this.RightMinDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
					this.ForwardMaxDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
					this.ForwardMinDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
				}
			}
			if (this.SeqActor != null && this.SeqActor.SequencePlayer != null)
			{
				this.SeqActor.SequencePlayer.OnFinished.Add(new Action(this.OnSequenceFinished));
				this.SeqActor.SequencePlayer.PlayReverse();
			}
			this.CanMoveClaw = (this.Model.ClawReleaseStateCanMoveTimeLeave <= 0f);
		}

		// Token: 0x06045317 RID: 283415 RVA: 0x0111DE04 File Offset: 0x0111C004
		public override void Update(float delta)
		{
			if (this.Model.ClawReleaseStateCanMoveTimeLeave > 0f)
			{
				this.Model.ClawReleaseStateCanMoveTimeLeave -= delta;
				if (this.Model.ClawReleaseStateCanMoveTimeLeave <= 0f)
				{
					this.CanMoveClaw = true;
				}
			}
			if (this.Owner.LastClawState.GetValueOrDefault() != EDollGrabMachineClawState.Release || !this.CanMoveClaw)
			{
				return;
			}
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
			this.ClawRootActor.D_K2_SetActorRelativeLocation(commonTempVector2.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06045318 RID: 283416 RVA: 0x0111E000 File Offset: 0x0111C200
		public override void Exit()
		{
			if (this.SeqActor != null && this.SeqActor.SequencePlayer != null)
			{
				this.SeqActor.SequencePlayer.OnFinished.Remove(new Action(this.OnSequenceFinished));
			}
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x06045319 RID: 283417 RVA: 0x0111E070 File Offset: 0x0111C270
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0604531A RID: 283418 RVA: 0x0111E0A7 File Offset: 0x0111C2A7
		private void OnSequenceFinished()
		{
			this.Owner.CheckTouchGetItemInClawTrigger();
			this.End();
			if (this.Owner.IsMachineActive || this.Owner.IsMachinePause)
			{
				this.Owner.ChangeClawState(EDollGrabMachineClawState.Idle);
			}
		}

		// Token: 0x040240FA RID: 147706
		private AKuroLevelSequenceActor SeqActor;

		// Token: 0x040240FB RID: 147707
		private float MoveSpeed;

		// Token: 0x040240FC RID: 147708
		private float RightMaxDistance;

		// Token: 0x040240FD RID: 147709
		private float RightMinDistance;

		// Token: 0x040240FE RID: 147710
		private float ForwardMaxDistance;

		// Token: 0x040240FF RID: 147711
		private float ForwardMinDistance;

		// Token: 0x04024100 RID: 147712
		private DollGrabModel Model;

		// Token: 0x04024101 RID: 147713
		private bool CanMoveClaw;

		// Token: 0x04024102 RID: 147714
		private int ClawMoveEventHandle = -1;
	}
}
