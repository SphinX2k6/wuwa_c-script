using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003185 RID: 12677
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Z : CodeSkillBase
{
	// Token: 0x0601B44F RID: 111695 RVA: 0x0077068B File Offset: 0x0076E88B
	public CodeSkill_Feixue_Z(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B450 RID: 111696 RVA: 0x007706A0 File Offset: 0x0076E8A0
	public override void OnBegin(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_Z.EChargePhase.None;
		this.ReceivedThreshold = false;
		this.Released = false;
		this.EndAttack = false;
		this.ReleaseTriggered = false;
		this.ActiveSkill = skill;
		this.Phase = CodeSkill_Feixue_Z.EChargePhase.ChargeStart;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.OnChargeStartCompleted(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnChargeStartBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.RegisterForegroundLostListener();
		this.RegisterChargeEventListeners();
		this.RegisterEmptyStaminaAddedListener();
		this.CheckEmptyStaminaAlready();
		this.RegisterParrySuccessListener();
	}

	// Token: 0x0601B451 RID: 111697 RVA: 0x00770754 File Offset: 0x0076E954
	public override void OnEnd(Skill skill)
	{
		this.RemoveChargeEventListeners();
		ITagTask foregroundLostTask = this.ForegroundLostTask;
		if (foregroundLostTask != null)
		{
			foregroundLostTask.EndTask();
		}
		this.ForegroundLostTask = null;
		ITagTask emptyStaminaAddedTask = this.EmptyStaminaAddedTask;
		if (emptyStaminaAddedTask != null)
		{
			emptyStaminaAddedTask.EndTask();
		}
		this.EmptyStaminaAddedTask = null;
		ITagTask parrySuccessTask = this.ParrySuccessTask;
		if (parrySuccessTask != null)
		{
			parrySuccessTask.EndTask();
		}
		this.ParrySuccessTask = null;
		this.ActiveSkill = null;
	}

	// Token: 0x0601B452 RID: 111698 RVA: 0x007707B8 File Offset: 0x0076E9B8
	private void TryRelease()
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill == null || this.ReleaseTriggered)
		{
			return;
		}
		this.ReleaseTriggered = true;
		this.EndAttack = true;
		this.PlayReleaseMontage(activeSkill);
	}

	// Token: 0x0601B453 RID: 111699 RVA: 0x007707F0 File Offset: 0x0076E9F0
	private void PlayReleaseMontage(Skill skill)
	{
		this.Phase = CodeSkill_Feixue_Z.EChargePhase.Release;
		if (!base.SkillComp.PlaySkillMontage(2, "", 0f, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}, delegate(bool isInterrupted)
		{
			this.EndSelf(skill);
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B454 RID: 111700 RVA: 0x00770854 File Offset: 0x0076EA54
	private void OnChargeStartCompleted(Skill skill, bool isInterrupted)
	{
		if (this.Phase != CodeSkill_Feixue_Z.EChargePhase.ChargeStart)
		{
			return;
		}
		if (isInterrupted)
		{
			if (!this.EndAttack)
			{
				base.EndSelf(skill);
			}
			return;
		}
		this.EnterChargeLoop(skill);
	}

	// Token: 0x0601B455 RID: 111701 RVA: 0x0077087A File Offset: 0x0076EA7A
	private void OnChargeStartBlendOut(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			return;
		}
		this.EnterChargeLoop(skill);
	}

	// Token: 0x0601B456 RID: 111702 RVA: 0x00770888 File Offset: 0x0076EA88
	private void EnterChargeLoop(Skill skill)
	{
		if (this.Phase != CodeSkill_Feixue_Z.EChargePhase.ChargeStart)
		{
			return;
		}
		this.Phase = CodeSkill_Feixue_Z.EChargePhase.ChargeLoop;
		if (!base.SkillComp.PlaySkillMontage(1, "", 0f, delegate(bool isInterrupted)
		{
			this.OnChargeLoopCompleted(skill, isInterrupted);
		}, null))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B457 RID: 111703 RVA: 0x007708EB File Offset: 0x0076EAEB
	private void OnChargeLoopCompleted(Skill skill, bool isInterrupted)
	{
		if (isInterrupted && !this.EndAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0601B458 RID: 111704 RVA: 0x00770900 File Offset: 0x0076EB00
	private void RegisterChargeEventListeners()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		IGameplayEventTask gameplayEventTask = (component != null) ? component.AddGameplayEventListenerOnce(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.重击阈值"]), new TGameplayEventCallback(this.OnThresholdEvent)) : null;
		if (gameplayEventTask != null)
		{
			this.ChargeEventTasks.Add(gameplayEventTask);
		}
		IGameplayEventTask gameplayEventTask2 = (component != null) ? component.AddGameplayEventListenerOnce(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.重击松开"]), new TGameplayEventCallback(this.OnReleaseEvent)) : null;
		if (gameplayEventTask2 != null)
		{
			this.ChargeEventTasks.Add(gameplayEventTask2);
		}
	}

	// Token: 0x0601B459 RID: 111705 RVA: 0x00770994 File Offset: 0x0076EB94
	private void RemoveChargeEventListeners()
	{
		foreach (IGameplayEventTask gameplayEventTask in this.ChargeEventTasks)
		{
			gameplayEventTask.EndTask();
		}
		this.ChargeEventTasks.Clear();
	}

	// Token: 0x0601B45A RID: 111706 RVA: 0x007709F0 File Offset: 0x0076EBF0
	private void OnThresholdEvent(int tagId, FGameplayEventData payload)
	{
		this.ReceivedThreshold = true;
		if (this.Released)
		{
			this.TryRelease();
		}
	}

	// Token: 0x0601B45B RID: 111707 RVA: 0x00770A07 File Offset: 0x0076EC07
	private void OnReleaseEvent(int tagId, FGameplayEventData payload)
	{
		this.Released = true;
		if (this.ReceivedThreshold)
		{
			this.TryRelease();
		}
	}

	// Token: 0x0601B45C RID: 111708 RVA: 0x00770A20 File Offset: 0x0076EC20
	private void RegisterForegroundLostListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ForegroundLostTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForegroundLost), null) : null);
	}

	// Token: 0x0601B45D RID: 111709 RVA: 0x00770A6C File Offset: 0x0076EC6C
	private void OnForegroundLost(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill != null && !this.EndAttack)
		{
			base.EndSelf(activeSkill);
		}
	}

	// Token: 0x0601B45E RID: 111710 RVA: 0x00770A98 File Offset: 0x0076EC98
	private void RegisterEmptyStaminaAddedListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.EmptyStaminaAddedTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.禁止体力恢复.空体力惩罚"]), new BaseTagComponent.TTagSwitchedCallback(this.OnEmptyStaminaAdded), null) : null);
	}

	// Token: 0x0601B45F RID: 111711 RVA: 0x00770AE4 File Offset: 0x0076ECE4
	private void OnEmptyStaminaAdded(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		ITagTask emptyStaminaAddedTask = this.EmptyStaminaAddedTask;
		if (emptyStaminaAddedTask != null)
		{
			emptyStaminaAddedTask.EndTask();
		}
		this.EmptyStaminaAddedTask = null;
		this.TryRelease();
	}

	// Token: 0x0601B460 RID: 111712 RVA: 0x00770B08 File Offset: 0x0076ED08
	private void CheckEmptyStaminaAlready()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.禁止体力恢复.空体力惩罚"]))
		{
			this.TryRelease();
		}
	}

	// Token: 0x0601B461 RID: 111713 RVA: 0x00770B38 File Offset: 0x0076ED38
	private void RegisterParrySuccessListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParrySuccessTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParrySuccess), null) : null);
	}

	// Token: 0x0601B462 RID: 111714 RVA: 0x00770B84 File Offset: 0x0076ED84
	private void OnParrySuccess(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			return;
		}
		ITagTask parrySuccessTask = this.ParrySuccessTask;
		if (parrySuccessTask != null)
		{
			parrySuccessTask.EndTask();
		}
		this.ParrySuccessTask = null;
		this.SpawnParryTimestopBullet();
	}

	// Token: 0x0601B463 RID: 111715 RVA: 0x00770BA8 File Offset: 0x0076EDA8
	private void SpawnParryTimestopBullet()
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill == null)
		{
			return;
		}
		long? skillContextId = BulletUtil.GetSkillContextId(base.Entity, activeSkill.SkillId);
		BulletController.Instance.CreateBulletCustomTarget(base.Entity, "1108106003", null, new BulletController.BulletCreateParams
		{
			SkillId = activeSkill.SkillId,
			SkillContextId = skillContextId,
			SyncType = EBulletSyncType.SyncCreate,
			BattleContext = activeSkill.BattleContext
		}, skillContextId, EBulletCreateSource.Skill);
		int id = base.Entity.Id;
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪神刀重击-GP子弹（无伤害）"), false, 0, 0f);
		BulletController.Instance.DestroySpecifiedBullet(id, new FName("绯雪神刀重击-GP拼刀子弹（无伤害）"), false, 0, 0f);
	}

	// Token: 0x0400D4E3 RID: 54499
	private const int CHARGE_START_MONTAGE_INDEX = 0;

	// Token: 0x0400D4E4 RID: 54500
	private const int CHARGE_LOOP_MONTAGE_INDEX = 1;

	// Token: 0x0400D4E5 RID: 54501
	private const int RELEASE_MONTAGE_INDEX = 2;

	// Token: 0x0400D4E6 RID: 54502
	private const string PARRY_TIMESTOP_BULLET_ID = "1108106003";

	// Token: 0x0400D4E7 RID: 54503
	private const string PARRY_GP_BULLET_NAME = "绯雪神刀重击-GP子弹（无伤害）";

	// Token: 0x0400D4E8 RID: 54504
	private const string PARRY_GP_PARRY_BULLET_NAME = "绯雪神刀重击-GP拼刀子弹（无伤害）";

	// Token: 0x0400D4E9 RID: 54505
	private CodeSkill_Feixue_Z.EChargePhase Phase;

	// Token: 0x0400D4EA RID: 54506
	private bool ReceivedThreshold;

	// Token: 0x0400D4EB RID: 54507
	private bool Released;

	// Token: 0x0400D4EC RID: 54508
	private bool EndAttack;

	// Token: 0x0400D4ED RID: 54509
	private bool ReleaseTriggered;

	// Token: 0x0400D4EE RID: 54510
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D4EF RID: 54511
	private readonly List<IGameplayEventTask> ChargeEventTasks = new List<IGameplayEventTask>();

	// Token: 0x0400D4F0 RID: 54512
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D4F1 RID: 54513
	[Nullable(2)]
	private ITagTask EmptyStaminaAddedTask;

	// Token: 0x0400D4F2 RID: 54514
	[Nullable(2)]
	private ITagTask ParrySuccessTask;

	// Token: 0x020096D7 RID: 38615
	[NullableContext(0)]
	private enum EChargePhase
	{
		// Token: 0x04030543 RID: 197955
		None,
		// Token: 0x04030544 RID: 197956
		ChargeStart,
		// Token: 0x04030545 RID: 197957
		ChargeLoop,
		// Token: 0x04030546 RID: 197958
		Release
	}
}
