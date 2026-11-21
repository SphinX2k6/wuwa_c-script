using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006090 RID: 24720
	[NullableContext(2)]
	[Nullable(0)]
	public class DgmClawReleaseState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4E1 RID: 242913 RVA: 0x010C894C File Offset: 0x010C6B4C
		[NullableContext(1)]
		public DgmClawReleaseState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.Release;
			this.NextStateMap.Add(EDollGrabMachineClawState.MovingDown, () => !this.HadGrabbingActor);
			this.NextStateMap.Add(EDollGrabMachineClawState.Grabbing, () => this.HadGrabbingActor);
			if (DollGrabModel.Instance.DollGrabMachineGlobalConfig != null)
			{
				this.DelayExitTime = DollGrabModel.Instance.DollGrabMachineGlobalConfig.钩爪延迟合上时间 * 1000f;
			}
		}

		// Token: 0x0603B4E2 RID: 242914 RVA: 0x010C89CC File Offset: 0x010C6BCC
		public override void Enter()
		{
			if (!this.IsFirstEnter)
			{
				this.IsFirstEnter = true;
				this.SeqActor = this.Owner.ClawAnimSeqActor;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				if (dollGrabMachineGlobalConfig != null)
				{
					this.MoveSpeed = dollGrabMachineGlobalConfig.钩爪移动速度;
					this.RightMaxDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
					this.RightMinDistance = dollGrabMachineGlobalConfig.钩爪X轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪X轴起始偏移 * 100f;
					this.ForwardMaxDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * 0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
					this.ForwardMinDistance = dollGrabMachineGlobalConfig.钩爪Y轴移动距离限制 * 100f * -0.5f + dollGrabMachineGlobalConfig.钩爪Y轴起始偏移 * 100f;
				}
				this.Model = DollGrabModel.Instance;
			}
			if (this.SeqActor != null && this.SeqActor.SequencePlayer != null)
			{
				this.SeqActor.SequencePlayer.OnFinished.Add(new Action(this.OnSequenceFinished));
				this.SeqActor.SequencePlayer.Play();
			}
			this.HadGrabbingActor = this.Owner.HasGrabbingActor;
			this.CanMoveClaw = true;
			this.Model.ClawReleaseStateCanMoveTimeLeave = 0f;
			if (this.HadGrabbingActor && this.Model.ClawReleaseStateCanMoveTime > 0f)
			{
				this.CanMoveClaw = false;
				this.Model.ClawReleaseStateCanMoveTimeLeave = this.Model.ClawReleaseStateCanMoveTime;
			}
		}

		// Token: 0x0603B4E3 RID: 242915 RVA: 0x010C8B60 File Offset: 0x010C6D60
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
			if (!this.HadGrabbingActor || !this.CanMoveClaw)
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

		// Token: 0x0603B4E4 RID: 242916 RVA: 0x010C8D4C File Offset: 0x010C6F4C
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

		// Token: 0x0603B4E5 RID: 242917 RVA: 0x010C8DBC File Offset: 0x010C6FBC
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0603B4E6 RID: 242918 RVA: 0x010C8DF4 File Offset: 0x010C6FF4
		private void OnSequenceFinished()
		{
			if (this.DelayExitTime > 0f && this.HadGrabbingActor)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					this.End();
				}, this.DelayExitTime, null, null, true, 1f);
				return;
			}
			this.End();
		}

		// Token: 0x0401F3CA RID: 127946
		private AKuroLevelSequenceActor SeqActor;

		// Token: 0x0401F3CB RID: 127947
		private bool HadGrabbingActor;

		// Token: 0x0401F3CC RID: 127948
		private readonly float DelayExitTime;

		// Token: 0x0401F3CD RID: 127949
		private float MoveSpeed;

		// Token: 0x0401F3CE RID: 127950
		private float RightMaxDistance;

		// Token: 0x0401F3CF RID: 127951
		private float RightMinDistance;

		// Token: 0x0401F3D0 RID: 127952
		private float ForwardMaxDistance;

		// Token: 0x0401F3D1 RID: 127953
		private float ForwardMinDistance;

		// Token: 0x0401F3D2 RID: 127954
		private bool CanMoveClaw;

		// Token: 0x0401F3D3 RID: 127955
		private int ClawMoveEventHandle = -1;

		// Token: 0x0401F3D4 RID: 127956
		private DollGrabModel Model;
	}
}
