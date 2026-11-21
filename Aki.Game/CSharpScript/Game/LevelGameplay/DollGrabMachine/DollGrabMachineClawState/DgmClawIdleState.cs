using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.GamePlay.DollGrab;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.DollGrabMachineClawState
{
	// Token: 0x0200608D RID: 24717
	public class DgmClawIdleState : DgmClawBaseMoveState
	{
		// Token: 0x0603B4CC RID: 242892 RVA: 0x010C8124 File Offset: 0x010C6324
		[NullableContext(1)]
		public DgmClawIdleState(SceneItemDollGrabMachineComponent owner, AActor clawActor, AActor clawRootActor, FTransformDouble ownerActorTransform) : base(owner, clawActor, clawRootActor, ownerActorTransform)
		{
			this.NextStateMap.Add(EDollGrabMachineClawState.Release, () => this.Owner.IsMachineActive);
			this.NextStateMap.Add(EDollGrabMachineClawState.Reset, () => !this.Owner.IsMachineActive);
		}

		// Token: 0x0603B4CD RID: 242893 RVA: 0x010C8174 File Offset: 0x010C6374
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

		// Token: 0x0603B4CE RID: 242894 RVA: 0x010C8250 File Offset: 0x010C6450
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

		// Token: 0x0603B4CF RID: 242895 RVA: 0x010C83EC File Offset: 0x010C65EC
		public override void Pause()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0603B4D0 RID: 242896 RVA: 0x010C8424 File Offset: 0x010C6624
		public override void Exit()
		{
			if (this.ClawMoveEventHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(this.ClawMoveEventHandle, EAudioActionType.Stop, null);
				this.ClawMoveEventHandle = -1;
			}
		}

		// Token: 0x0401F3B8 RID: 127928
		private float MoveSpeed;

		// Token: 0x0401F3B9 RID: 127929
		private float RightMaxDistance;

		// Token: 0x0401F3BA RID: 127930
		private float RightMinDistance;

		// Token: 0x0401F3BB RID: 127931
		private float ForwardMaxDistance;

		// Token: 0x0401F3BC RID: 127932
		private float ForwardMinDistance;

		// Token: 0x0401F3BD RID: 127933
		private int ClawMoveEventHandle = -1;
	}
}
