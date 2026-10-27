using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x0200475C RID: 18268
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class WuWaGoMonsterControllerBase<[Nullable(0)] TRole> : WuWaGoRoleController<TRole>, IWuWaGoMonsterController where TRole : WuWaGoRole
	{
		// Token: 0x0602FC11 RID: 195601 RVA: 0x00B104B3 File Offset: 0x00B0E6B3
		protected WuWaGoMonsterControllerBase(TRole role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(role, gameData, gameMode)
		{
		}

		// Token: 0x0602FC12 RID: 195602 RVA: 0x00B104C9 File Offset: 0x00B0E6C9
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			this.SpawnAttackRangeEffect();
			this.HideAttackRangeForBusy("WuWaGo.AttackRange.Intro");
			return true;
		}

		// Token: 0x0602FC13 RID: 195603 RVA: 0x00B104E8 File Offset: 0x00B0E6E8
		public override void OnEnterRunning()
		{
			this.RestoreAttackRangeFromBusy("WuWaGo.AttackRange.Running");
		}

		// Token: 0x0602FC14 RID: 195604 RVA: 0x00B104F8 File Offset: 0x00B0E6F8
		protected override void OnDestroy()
		{
			base.OnDestroy();
			this.AttackRangeEffectRequestSeq++;
			if (EffectSystem.Instance.IsValid(this.AttackRangeEffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.AttackRangeEffectHandle, "WuWaGo.AttackRange.Clear", true, null);
			}
			this.AttackRangeEffectHandle = 0;
		}

		// Token: 0x0602FC15 RID: 195605 RVA: 0x00B10552 File Offset: 0x00B0E752
		protected override void OnBeforeExecuteAction()
		{
			this.HideAttackRangeForBusy("WuWaGo.AttackRange.Acting");
		}

		// Token: 0x0602FC16 RID: 195606 RVA: 0x00B1055F File Offset: 0x00B0E75F
		protected override void OnAfterExecuteAction()
		{
			this.RestoreAttackRangeFromBusy("WuWaGo.AttackRange.Idle");
		}

		// Token: 0x0602FC17 RID: 195607 RVA: 0x00B1056C File Offset: 0x00B0E76C
		public override void OnRollbackRestore()
		{
			base.OnRollbackRestore();
			this.SyncAttackRangeEffectTransform();
			if (this.Role.IsDead)
			{
				this.HideAttackRangeForBusy("WuWaGo.AttackRange.RollbackRestoreDead");
				return;
			}
			this.RestoreAttackRangeFromBusy("WuWaGo.AttackRange.RollbackRestore");
		}

		// Token: 0x0602FC18 RID: 195608 RVA: 0x00B105A3 File Offset: 0x00B0E7A3
		public override void SyncRuntimePresentationAfterCoordinateChanged()
		{
			if (!EffectSystem.Instance.IsValid(this.AttackRangeEffectHandle))
			{
				return;
			}
			this.SyncAttackRangeEffectTransform();
		}

		// Token: 0x0602FC19 RID: 195609 RVA: 0x00B105BE File Offset: 0x00B0E7BE
		public override void HideAttackRangeEffect(string reason)
		{
			this.HideAttackRangeForBusy(reason);
		}

		// Token: 0x0602FC1A RID: 195610 RVA: 0x00B105C7 File Offset: 0x00B0E7C7
		public override void ShowAttackRangeEffect(string reason)
		{
			this.RestoreAttackRangeFromBusy(reason);
		}

		// Token: 0x0602FC1B RID: 195611 RVA: 0x00B105D0 File Offset: 0x00B0E7D0
		[NullableContext(2)]
		public override UniTask TakeAttack(bool playBeHitAnim, UAnimMontage deathMontage = null)
		{
			WuWaGoMonsterControllerBase<TRole>.<TakeAttack>d__14 <TakeAttack>d__;
			<TakeAttack>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TakeAttack>d__.<>4__this = this;
			<TakeAttack>d__.playBeHitAnim = playBeHitAnim;
			<TakeAttack>d__.deathMontage = deathMontage;
			<TakeAttack>d__.<>1__state = -1;
			<TakeAttack>d__.<>t__builder.Start<WuWaGoMonsterControllerBase<TRole>.<TakeAttack>d__14>(ref <TakeAttack>d__);
			return <TakeAttack>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC1C RID: 195612 RVA: 0x00B10624 File Offset: 0x00B0E824
		public UniTask ExecutePostMovableFloorAttackJudgement()
		{
			WuWaGoMonsterControllerBase<TRole>.<ExecutePostMovableFloorAttackJudgement>d__15 <ExecutePostMovableFloorAttackJudgement>d__;
			<ExecutePostMovableFloorAttackJudgement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePostMovableFloorAttackJudgement>d__.<>4__this = this;
			<ExecutePostMovableFloorAttackJudgement>d__.<>1__state = -1;
			<ExecutePostMovableFloorAttackJudgement>d__.<>t__builder.Start<WuWaGoMonsterControllerBase<TRole>.<ExecutePostMovableFloorAttackJudgement>d__15>(ref <ExecutePostMovableFloorAttackJudgement>d__);
			return <ExecutePostMovableFloorAttackJudgement>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC1D RID: 195613 RVA: 0x00B10667 File Offset: 0x00B0E867
		private void HideAttackRangeForBusy(string reason)
		{
			if (this.IsAttackRangeHidden)
			{
				return;
			}
			this.IsAttackRangeHidden = true;
			if (!EffectSystem.Instance.IsValid(this.AttackRangeEffectHandle))
			{
				return;
			}
			EffectSystem.Instance.SetEffectHidden(this.AttackRangeEffectHandle, true, reason, false);
		}

		// Token: 0x0602FC1E RID: 195614 RVA: 0x00B106A0 File Offset: 0x00B0E8A0
		private void RestoreAttackRangeFromBusy(string reason)
		{
			if (!this.IsAttackRangeHidden)
			{
				return;
			}
			if (this.Role.IsDead)
			{
				return;
			}
			this.IsAttackRangeHidden = false;
			if (!EffectSystem.Instance.IsValid(this.AttackRangeEffectHandle))
			{
				return;
			}
			this.SyncAttackRangeEffectTransform();
			EffectSystem.Instance.SetEffectHidden(this.AttackRangeEffectHandle, false, reason, false);
		}

		// Token: 0x0602FC1F RID: 195615 RVA: 0x00B106FC File Offset: 0x00B0E8FC
		private Rotator GetAttackRangeEffectRotator()
		{
			Rotator rotator = this.Role.Rotator;
			this.TempAttackRangeRotator.Set(rotator.Pitch, rotator.Yaw + 180f, rotator.Roll);
			return this.TempAttackRangeRotator;
		}

		// Token: 0x0602FC20 RID: 195616 RVA: 0x00B10744 File Offset: 0x00B0E944
		private UniTask SpawnAttackRangeEffect()
		{
			WuWaGoMonsterControllerBase<TRole>.<SpawnAttackRangeEffect>d__19 <SpawnAttackRangeEffect>d__;
			<SpawnAttackRangeEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnAttackRangeEffect>d__.<>4__this = this;
			<SpawnAttackRangeEffect>d__.<>1__state = -1;
			<SpawnAttackRangeEffect>d__.<>t__builder.Start<WuWaGoMonsterControllerBase<TRole>.<SpawnAttackRangeEffect>d__19>(ref <SpawnAttackRangeEffect>d__);
			return <SpawnAttackRangeEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC21 RID: 195617 RVA: 0x00B10788 File Offset: 0x00B0E988
		private void SyncAttackRangeEffectTransform()
		{
			AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(this.AttackRangeEffectHandle);
			if (sureEffectActor == null || !sureEffectActor.IsValid())
			{
				return;
			}
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			if (originTransform == null)
			{
				return;
			}
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, this.Role.Coordinate, null);
			Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			originTransform.GetRotation().Multiply(this.GetAttackRangeEffectRotator().Quaternion(null), quat);
			sureEffectActor.D_K2_SetActorLocationAndRotation(worldPositionByCoordinate.ToUeVector(false), quat.Rotator(null).ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x04019C45 RID: 105541
		private int AttackRangeEffectHandle;

		// Token: 0x04019C46 RID: 105542
		private int AttackRangeEffectRequestSeq;

		// Token: 0x04019C47 RID: 105543
		private readonly Rotator TempAttackRangeRotator = Rotator.Create();

		// Token: 0x04019C48 RID: 105544
		private bool IsAttackRangeHidden;
	}
}
