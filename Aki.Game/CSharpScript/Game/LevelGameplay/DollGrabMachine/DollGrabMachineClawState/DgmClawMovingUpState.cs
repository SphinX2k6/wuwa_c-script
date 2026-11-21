using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x0200608F RID: 24719
	public class DgmClawMovingUpState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4D9 RID: 242905 RVA: 0x010C86C4 File Offset: 0x010C68C4
		[NullableContext(1)]
		public DgmClawMovingUpState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, AActor clawChainActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.StateInternal = EDollGrabMachineClawState.MovingUp;
			this.ClawChainActor = clawChainActor;
			this.NextStateMap.Add(EDollGrabMachineClawState.Idle, () => this.Owner.IsMachineActive);
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => !this.Owner.IsMachineActive);
		}

		// Token: 0x0603B4DA RID: 242906 RVA: 0x010C8724 File Offset: 0x010C6924
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

		// Token: 0x0603B4DB RID: 242907 RVA: 0x010C878C File Offset: 0x010C698C
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

		// Token: 0x0603B4DC RID: 242908 RVA: 0x010C8884 File Offset: 0x010C6A84
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0603B4DD RID: 242909 RVA: 0x010C88BC File Offset: 0x010C6ABC
		public override void Resume()
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
		}

		// Token: 0x0603B4DE RID: 242910 RVA: 0x010C88F8 File Offset: 0x010C6AF8
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0401F3C4 RID: 127940
		[Nullable(2)]
		private readonly AActor ClawChainActor;

		// Token: 0x0401F3C5 RID: 127941
		private float ChainScaleRatio;

		// Token: 0x0401F3C6 RID: 127942
		private float UpMaxDistance;

		// Token: 0x0401F3C7 RID: 127943
		private float CurrentUpDistance;

		// Token: 0x0401F3C8 RID: 127944
		private float MoveSpeed;

		// Token: 0x0401F3C9 RID: 127945
		private int ClawMoveEventHandle = -1;
	}
}
