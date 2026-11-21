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
	// Token: 0x0200368D RID: 13965
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class WuWaGoMonsterControllerBase<[Nullable(0)] TRole> : WuWaGoRoleController<TRole>, IWuWaGoMonsterController where TRole : WuWaGoRole
	{
		// Token: 0x060243DB RID: 148443 RVA: 0x00A40473 File Offset: 0x00A3E673
		protected WuWaGoMonsterControllerBase(TRole role, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(role, gameData, gameMode)
		{
		}

		// Token: 0x060243DC RID: 148444 RVA: 0x00A40489 File Offset: 0x00A3E689
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

		// Token: 0x060243DD RID: 148445 RVA: 0x00A404A8 File Offset: 0x00A3E6A8
		public override void OnEnterRunning()
		{
			this.RestoreAttackRangeFromBusy("WuWaGo.AttackRange.Running");
		}

		// Token: 0x060243DE RID: 148446 RVA: 0x00A404B8 File Offset: 0x00A3E6B8
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

		// Token: 0x060243DF RID: 148447 RVA: 0x00A40512 File Offset: 0x00A3E712
		protected override void OnBeforeExecuteAction()
		{
			this.HideAttackRangeForBusy("WuWaGo.AttackRange.Acting");
		}

		// Token: 0x060243E0 RID: 148448 RVA: 0x00A4051F File Offset: 0x00A3E71F
		protected override void OnAfterExecuteAction()
		{
			this.RestoreAttackRangeFromBusy("WuWaGo.AttackRange.Idle");
		}

		// Token: 0x060243E1 RID: 148449 RVA: 0x00A4052C File Offset: 0x00A3E72C
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

		// Token: 0x060243E2 RID: 148450 RVA: 0x00A40563 File Offset: 0x00A3E763
		public override void SyncRuntimePresentationAfterCoordinateChanged()
		{
			if (!EffectSystem.Instance.IsValid(this.AttackRangeEffectHandle))
			{
				return;
			}
			this.SyncAttackRangeEffectTransform();
		}

		// Token: 0x060243E3 RID: 148451 RVA: 0x00A4057E File Offset: 0x00A3E77E
		public override void HideAttackRangeEffect(string reason)
		{
			this.HideAttackRangeForBusy(reason);
		}

		// Token: 0x060243E4 RID: 148452 RVA: 0x00A40587 File Offset: 0x00A3E787
		public override void ShowAttackRangeEffect(string reason)
		{
			this.RestoreAttackRangeFromBusy(reason);
		}

		// Token: 0x060243E5 RID: 148453 RVA: 0x00A40590 File Offset: 0x00A3E790
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

		// Token: 0x060243E6 RID: 148454 RVA: 0x00A405E4 File Offset: 0x00A3E7E4
		public UniTask ExecutePostMovableFloorAttackJudgement()
		{
			WuWaGoMonsterControllerBase<TRole>.<ExecutePostMovableFloorAttackJudgement>d__15 <ExecutePostMovableFloorAttackJudgement>d__;
			<ExecutePostMovableFloorAttackJudgement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecutePostMovableFloorAttackJudgement>d__.<>4__this = this;
			<ExecutePostMovableFloorAttackJudgement>d__.<>1__state = -1;
			<ExecutePostMovableFloorAttackJudgement>d__.<>t__builder.Start<WuWaGoMonsterControllerBase<TRole>.<ExecutePostMovableFloorAttackJudgement>d__15>(ref <ExecutePostMovableFloorAttackJudgement>d__);
			return <ExecutePostMovableFloorAttackJudgement>d__.<>t__builder.Task;
		}

		// Token: 0x060243E7 RID: 148455 RVA: 0x00A40627 File Offset: 0x00A3E827
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

		// Token: 0x060243E8 RID: 148456 RVA: 0x00A40660 File Offset: 0x00A3E860
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

		// Token: 0x060243E9 RID: 148457 RVA: 0x00A406BC File Offset: 0x00A3E8BC
		private Rotator GetAttackRangeEffectRotator()
		{
			Rotator rotator = this.Role.Rotator;
			this.TempAttackRangeRotator.Set(rotator.Pitch, rotator.Yaw + 180f, rotator.Roll);
			return this.TempAttackRangeRotator;
		}

		// Token: 0x060243EA RID: 148458 RVA: 0x00A40704 File Offset: 0x00A3E904
		private UniTask SpawnAttackRangeEffect()
		{
			WuWaGoMonsterControllerBase<TRole>.<SpawnAttackRangeEffect>d__19 <SpawnAttackRangeEffect>d__;
			<SpawnAttackRangeEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnAttackRangeEffect>d__.<>4__this = this;
			<SpawnAttackRangeEffect>d__.<>1__state = -1;
			<SpawnAttackRangeEffect>d__.<>t__builder.Start<WuWaGoMonsterControllerBase<TRole>.<SpawnAttackRangeEffect>d__19>(ref <SpawnAttackRangeEffect>d__);
			return <SpawnAttackRangeEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060243EB RID: 148459 RVA: 0x00A40748 File Offset: 0x00A3E948
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

		// Token: 0x040142F5 RID: 82677
		private int AttackRangeEffectHandle;

		// Token: 0x040142F6 RID: 82678
		private int AttackRangeEffectRequestSeq;

		// Token: 0x040142F7 RID: 82679
		private readonly Rotator TempAttackRangeRotator = Rotator.Create();

		// Token: 0x040142F8 RID: 82680
		private bool IsAttackRangeHidden;
	}
}
