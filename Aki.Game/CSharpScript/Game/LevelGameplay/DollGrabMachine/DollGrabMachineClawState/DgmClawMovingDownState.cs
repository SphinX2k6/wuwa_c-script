using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x02006F0D RID: 28429
	public class DgmClawMovingDownState : DgmClawBaseMoveState
	{
		// Token: 0x06045325 RID: 283429 RVA: 0x0111E4D8 File Offset: 0x0111C6D8
		[NullableContext(1)]
		public DgmClawMovingDownState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, AActor clawChainActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.ClawChainActor = clawChainActor;
			this.StateInternal = EDollGrabMachineClawState.MovingDown;
			this.NextStateMap.Add(EDollGrabMachineClawState.Grabbing, null);
		}

		// Token: 0x06045326 RID: 283430 RVA: 0x0111E508 File Offset: 0x0111C708
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

		// Token: 0x06045327 RID: 283431 RVA: 0x0111E57C File Offset: 0x0111C77C
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

		// Token: 0x06045328 RID: 283432 RVA: 0x0111E678 File Offset: 0x0111C878
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x06045329 RID: 283433 RVA: 0x0111E6B0 File Offset: 0x0111C8B0
		public override void Resume()
		{
			if (this.ClawMoveEventHandle < 0)
			{
				this.ClawMoveEventHandle = AudioSystem.Instance.PostEvent("play_nteract_crane_game_crane_up_down", this.ClawRootActor, null);
			}
		}

		// Token: 0x0604532A RID: 283434 RVA: 0x0111E6EC File Offset: 0x0111C8EC
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x04024109 RID: 147721
		private float DownMaxDistance;

		// Token: 0x0402410A RID: 147722
		private float CurrentDownDistance;

		// Token: 0x0402410B RID: 147723
		private float ChainScaleRatio;

		// Token: 0x0402410C RID: 147724
		[Nullable(2)]
		private readonly AActor ClawChainActor;

		// Token: 0x0402410D RID: 147725
		private float MoveSpeed;

		// Token: 0x0402410E RID: 147726
		private int ClawMoveEventHandle = -1;
	}
}
