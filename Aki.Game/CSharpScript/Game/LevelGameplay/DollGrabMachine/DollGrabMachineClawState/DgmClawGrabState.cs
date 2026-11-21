using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x0200608C RID: 24716
	[NullableContext(2)]
	[Nullable(0)]
	public class DgmClawGrabState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4C3 RID: 242883 RVA: 0x010C7BE4 File Offset: 0x010C5DE4
		[NullableContext(1)]
		public DgmClawGrabState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.Grabbing;
			this.NextStateMap.Add(EDollGrabMachineClawState.MovingUp, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.MovingDown);
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.Release && (this.Owner.IsMachineActive || this.Owner.IsMachinePause));
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => this.Owner.LastClawState.GetValueOrDefault() == EDollGrabMachineClawState.Release && !this.Owner.IsMachineActive && !this.Owner.IsMachinePause);
		}

		// Token: 0x0603B4C4 RID: 242884 RVA: 0x010C7C54 File Offset: 0x010C5E54
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

		// Token: 0x0603B4C5 RID: 242885 RVA: 0x010C7DA4 File Offset: 0x010C5FA4
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

		// Token: 0x0603B4C6 RID: 242886 RVA: 0x010C7FA0 File Offset: 0x010C61A0
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

		// Token: 0x0603B4C7 RID: 242887 RVA: 0x010C8010 File Offset: 0x010C6210
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0603B4C8 RID: 242888 RVA: 0x010C8047 File Offset: 0x010C6247
		private void OnSequenceFinished()
		{
			this.Owner.CheckTouchGetItemInClawTrigger();
			this.End();
			if (this.Owner.IsMachineActive || this.Owner.IsMachinePause)
			{
				this.Owner.ChangeClawState(EDollGrabMachineClawState.Idle);
			}
		}

		// Token: 0x0401F3AF RID: 127919
		private AKuroLevelSequenceActor SeqActor;

		// Token: 0x0401F3B0 RID: 127920
		private float MoveSpeed;

		// Token: 0x0401F3B1 RID: 127921
		private float RightMaxDistance;

		// Token: 0x0401F3B2 RID: 127922
		private float RightMinDistance;

		// Token: 0x0401F3B3 RID: 127923
		private float ForwardMaxDistance;

		// Token: 0x0401F3B4 RID: 127924
		private float ForwardMinDistance;

		// Token: 0x0401F3B5 RID: 127925
		private DollGrabModel Model;

		// Token: 0x0401F3B6 RID: 127926
		private bool CanMoveClaw;

		// Token: 0x0401F3B7 RID: 127927
		private int ClawMoveEventHandle = -1;
	}
}
