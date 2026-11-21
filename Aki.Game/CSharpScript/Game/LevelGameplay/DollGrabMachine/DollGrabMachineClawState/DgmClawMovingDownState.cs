using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x0200608E RID: 24718
	public class DgmClawMovingDownState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4D3 RID: 242899 RVA: 0x010C8478 File Offset: 0x010C6678
		[NullableContext(1)]
		public DgmClawMovingDownState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, AActor clawChainActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.ClawChainActor = clawChainActor;
			this.StateInternal = EDollGrabMachineClawState.MovingDown;
			this.NextStateMap.Add(EDollGrabMachineClawState.Grabbing, null);
		}

		// Token: 0x0603B4D4 RID: 242900 RVA: 0x010C84A8 File Offset: 0x010C66A8
		public override void Enter()
		{
			if (!this.IsFirstEnter && DollGrabModel.Instance.DollGrabMachineGlobalConfig != null)
			{
				this.IsFirstEnter = true;
				BP_DollGrabMachineGlobalConfig_C dollGrabMachineGlobalConfig = DollGrabModel.Instance.DollGrabMachineGlobalConfig;
				this.MoveSpeed = dollGrabMachineGlobalConfig.钩爪下探速度;
				this.ChainScaleRatio = dollGrabMachineGlobalConfig.钩爪锁链缩放比例;
				this.DownMaxDistance = dollGrabMachineGlobalConfig.钩爪下探距离限制 * 100f;
			}
			this.Owner.StartClawTriggerOverlap();
			this.CurrentDownDistance = 0f;
		}

		// Token: 0x0603B4D5 RID: 242901 RVA: 0x010C851C File Offset: 0x010C671C
		public override void Update(float delta)
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
			float num = this.MoveSpeed * delta / 10f;
			this.CurrentDownDistance += num;
			if (this.CurrentDownDistance >= this.DownMaxDistance)
			{
				num -= this.CurrentDownDistance - this.DownMaxDistance;
			}
			MathUtils.Instance.CommonTempVector.Set(0.0, 0.0, (double)(-(double)num));
			float num2 = num / this.ChainScaleRatio;
			FVectorDouble newScale3D = this.ClawChainActor.D_GetActorScale3D();
			newScale3D.Z += (double)num2;
			this.ClawChainActor.D_SetActorScale3D(newScale3D);
			FHitResult fhitResult = null;
			this.ClawActor.K2_AddActorWorldOffset(MathUtils.Instance.CommonTempVector.ToUeVectorOld(), false, ref fhitResult, false);
			if (this.CurrentDownDistance >= this.DownMaxDistance)
			{
				this.End();
			}
		}

		// Token: 0x0603B4D6 RID: 242902 RVA: 0x010C8618 File Offset: 0x010C6818
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0603B4D7 RID: 242903 RVA: 0x010C8650 File Offset: 0x010C6850
		public override void Resume()
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
		}

		// Token: 0x0603B4D8 RID: 242904 RVA: 0x010C868C File Offset: 0x010C688C
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0401F3BE RID: 127934
		private float DownMaxDistance;

		// Token: 0x0401F3BF RID: 127935
		private float CurrentDownDistance;

		// Token: 0x0401F3C0 RID: 127936
		private float ChainScaleRatio;

		// Token: 0x0401F3C1 RID: 127937
		[Nullable(2)]
		private readonly AActor ClawChainActor;

		// Token: 0x0401F3C2 RID: 127938
		private float MoveSpeed;

		// Token: 0x0401F3C3 RID: 127939
		private int ClawMoveEventHandle = -1;
	}
}
