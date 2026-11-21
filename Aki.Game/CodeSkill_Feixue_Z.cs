using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026F2 RID: 9970
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Z : CodeSkillBase
{
	// Token: 0x06018F54 RID: 102228 RVA: 0x00797FEF File Offset: 0x007961EF
	public CodeSkill_Feixue_Z(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018F55 RID: 102229 RVA: 0x00798004 File Offset: 0x00796204
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

	// Token: 0x06018F56 RID: 102230 RVA: 0x007980B8 File Offset: 0x007962B8
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

	// Token: 0x06018F57 RID: 102231 RVA: 0x0079811C File Offset: 0x0079631C
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

	// Token: 0x06018F58 RID: 102232 RVA: 0x00798154 File Offset: 0x00796354
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

	// Token: 0x06018F59 RID: 102233 RVA: 0x007981B8 File Offset: 0x007963B8
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

	// Token: 0x06018F5A RID: 102234 RVA: 0x007981DE File Offset: 0x007963DE
	private void OnChargeStartBlendOut(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			return;
		}
		this.EnterChargeLoop(skill);
	}

	// Token: 0x06018F5B RID: 102235 RVA: 0x007981EC File Offset: 0x007963EC
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

	// Token: 0x06018F5C RID: 102236 RVA: 0x0079824F File Offset: 0x0079644F
	private void OnChargeLoopCompleted(Skill skill, bool isInterrupted)
	{
		if (isInterrupted && !this.EndAttack)
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x06018F5D RID: 102237 RVA: 0x00798264 File Offset: 0x00796464
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

	// Token: 0x06018F5E RID: 102238 RVA: 0x007982F8 File Offset: 0x007964F8
	private void RemoveChargeEventListeners()
	{
		foreach (IGameplayEventTask gameplayEventTask in this.ChargeEventTasks)
		{
			gameplayEventTask.EndTask();
		}
		this.ChargeEventTasks.Clear();
	}

	// Token: 0x06018F5F RID: 102239 RVA: 0x00798354 File Offset: 0x00796554
	private void OnThresholdEvent(int tagId, FGameplayEventData payload)
	{
		this.ReceivedThreshold = true;
		if (this.Released)
		{
			this.TryRelease();
		}
	}

	// Token: 0x06018F60 RID: 102240 RVA: 0x0079836B File Offset: 0x0079656B
	private void OnReleaseEvent(int tagId, FGameplayEventData payload)
	{
		this.Released = true;
		if (this.ReceivedThreshold)
		{
			this.TryRelease();
		}
	}

	// Token: 0x06018F61 RID: 102241 RVA: 0x00798384 File Offset: 0x00796584
	private void RegisterForegroundLostListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ForegroundLostTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.前台不受控制"]), new BaseTagComponent.TTagSwitchedCallback(this.OnForegroundLost), null) : null);
	}

	// Token: 0x06018F62 RID: 102242 RVA: 0x007983D0 File Offset: 0x007965D0
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

	// Token: 0x06018F63 RID: 102243 RVA: 0x007983FC File Offset: 0x007965FC
	private void RegisterEmptyStaminaAddedListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.EmptyStaminaAddedTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.禁止体力恢复.空体力惩罚"]), new BaseTagComponent.TTagSwitchedCallback(this.OnEmptyStaminaAdded), null) : null);
	}

	// Token: 0x06018F64 RID: 102244 RVA: 0x00798448 File Offset: 0x00796648
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

	// Token: 0x06018F65 RID: 102245 RVA: 0x0079846C File Offset: 0x0079666C
	private void CheckEmptyStaminaAlready()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.禁止体力恢复.空体力惩罚"]))
		{
			this.TryRelease();
		}
	}

	// Token: 0x06018F66 RID: 102246 RVA: 0x0079849C File Offset: 0x0079669C
	private void RegisterParrySuccessListener()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		this.ParrySuccessTask = ((component != null) ? component.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.弹反成功"]), new BaseTagComponent.TTagSwitchedCallback(this.OnParrySuccess), null) : null);
	}

	// Token: 0x06018F67 RID: 102247 RVA: 0x007984E8 File Offset: 0x007966E8
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

	// Token: 0x06018F68 RID: 102248 RVA: 0x0079850C File Offset: 0x0079670C
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

	// Token: 0x0400D946 RID: 55622
	private const int CHARGE_START_MONTAGE_INDEX = 0;

	// Token: 0x0400D947 RID: 55623
	private const int CHARGE_LOOP_MONTAGE_INDEX = 1;

	// Token: 0x0400D948 RID: 55624
	private const int RELEASE_MONTAGE_INDEX = 2;

	// Token: 0x0400D949 RID: 55625
	private const string PARRY_TIMESTOP_BULLET_ID = "1108106003";

	// Token: 0x0400D94A RID: 55626
	private const string PARRY_GP_BULLET_NAME = "绯雪神刀重击-GP子弹（无伤害）";

	// Token: 0x0400D94B RID: 55627
	private const string PARRY_GP_PARRY_BULLET_NAME = "绯雪神刀重击-GP拼刀子弹（无伤害）";

	// Token: 0x0400D94C RID: 55628
	private CodeSkill_Feixue_Z.EChargePhase Phase;

	// Token: 0x0400D94D RID: 55629
	private bool ReceivedThreshold;

	// Token: 0x0400D94E RID: 55630
	private bool Released;

	// Token: 0x0400D94F RID: 55631
	private bool EndAttack;

	// Token: 0x0400D950 RID: 55632
	private bool ReleaseTriggered;

	// Token: 0x0400D951 RID: 55633
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D952 RID: 55634
	private readonly List<IGameplayEventTask> ChargeEventTasks = new List<IGameplayEventTask>();

	// Token: 0x0400D953 RID: 55635
	[Nullable(2)]
	private ITagTask ForegroundLostTask;

	// Token: 0x0400D954 RID: 55636
	[Nullable(2)]
	private ITagTask EmptyStaminaAddedTask;

	// Token: 0x0400D955 RID: 55637
	[Nullable(2)]
	private ITagTask ParrySuccessTask;

	// Token: 0x020088FD RID: 35069
	[NullableContext(0)]
	private enum EChargePhase
	{
		// Token: 0x0402BBD8 RID: 179160
		None,
		// Token: 0x0402BBD9 RID: 179161
		ChargeStart,
		// Token: 0x0402BBDA RID: 179162
		ChargeLoop,
		// Token: 0x0402BBDB RID: 179163
		Release
	}
}
