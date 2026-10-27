using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200317B RID: 12667
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Burst02 : CodeSkillBase
{
	// Token: 0x0601B3E0 RID: 111584 RVA: 0x0076E47A File Offset: 0x0076C67A
	public CodeSkill_Feixue_Burst02(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B3E1 RID: 111585 RVA: 0x0076E484 File Offset: 0x0076C684
	public override void OnBegin(Skill skill)
	{
		this.ReceivedThreshold = false;
		this.Released = false;
		this.AttackTriggered = false;
		this.ChargeReleaseGateUsed = false;
		this.ActiveSkill = skill;
		if (!base.SkillComp.PlaySkillMontage(0, "", 0f, delegate(bool isInterrupted)
		{
			this.OnMontageCompleted(skill, isInterrupted);
		}, delegate(bool isInterrupted)
		{
			this.OnMontageBlendOut(skill, isInterrupted);
		}))
		{
			base.EndSelf(skill);
			return;
		}
		this.RegisterChargeEventListeners();
	}

	// Token: 0x0601B3E2 RID: 111586 RVA: 0x0076E510 File Offset: 0x0076C710
	public override void OnEnd(Skill skill)
	{
		this.RemoveChargeEventListeners();
		this.ActiveSkill = null;
	}

	// Token: 0x0601B3E3 RID: 111587 RVA: 0x0076E51F File Offset: 0x0076C71F
	private void OnMontageCompleted(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.TriggerBurstAttack(skill);
	}

	// Token: 0x0601B3E4 RID: 111588 RVA: 0x0076E533 File Offset: 0x0076C733
	private void OnMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			return;
		}
		this.TriggerBurstAttack(skill);
	}

	// Token: 0x0601B3E5 RID: 111589 RVA: 0x0076E540 File Offset: 0x0076C740
	private void RegisterChargeEventListeners()
	{
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		this.ReleaseEventTask = component.AddGameplayEventListenerOnce(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.大招松开"]), new TGameplayEventCallback(this.OnReleaseEvent));
		component.AddGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.大招阈值"], new TGameplayEventCallback(this.OnThresholdEvent));
		this.ThresholdListenerActive = true;
	}

	// Token: 0x0601B3E6 RID: 111590 RVA: 0x0076E5B4 File Offset: 0x0076C7B4
	private void RemoveChargeEventListeners()
	{
		IGameplayEventTask releaseEventTask = this.ReleaseEventTask;
		if (releaseEventTask != null)
		{
			releaseEventTask.EndTask();
		}
		this.ReleaseEventTask = null;
		if (!this.ThresholdListenerActive)
		{
			return;
		}
		this.ThresholdListenerActive = false;
		BaseAbilityComponent component = base.Entity.GetComponent<BaseAbilityComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveGameplayEventListener(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.事件相关.大招阈值"], new TGameplayEventCallback(this.OnThresholdEvent));
	}

	// Token: 0x0601B3E7 RID: 111591 RVA: 0x0076E619 File Offset: 0x0076C819
	private void OnReleaseEvent(int tagId, FGameplayEventData payload)
	{
		this.Released = true;
		if (this.ReceivedThreshold)
		{
			this.OnChargeGateReady();
		}
	}

	// Token: 0x0601B3E8 RID: 111592 RVA: 0x0076E630 File Offset: 0x0076C830
	private void OnThresholdEvent(int tagId, FGameplayEventData payload)
	{
		this.ReceivedThreshold = true;
		if (this.Released)
		{
			this.OnChargeGateReady();
			return;
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1TaidaonvMd10011.特殊机制.收刀叠层"]))
		{
			this.DoChargeBuffAndAttack();
		}
	}

	// Token: 0x0601B3E9 RID: 111593 RVA: 0x0076E684 File Offset: 0x0076C884
	private void OnChargeGateReady()
	{
		if (this.ChargeReleaseGateUsed)
		{
			return;
		}
		this.ChargeReleaseGateUsed = true;
		this.DoChargeBuffAndAttack();
	}

	// Token: 0x0601B3EA RID: 111594 RVA: 0x0076E69C File Offset: 0x0076C89C
	private void DoChargeBuffAndAttack()
	{
		Skill activeSkill = this.ActiveSkill;
		if (activeSkill == null)
		{
			return;
		}
		this.AddChargeBuff(activeSkill);
		this.TriggerBurstAttack(activeSkill);
	}

	// Token: 0x0601B3EB RID: 111595 RVA: 0x0076E6C4 File Offset: 0x0076C8C4
	private void AddChargeBuff(Skill skill)
	{
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
		if (component != null && num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				BaseBuffComponent baseBuffComponent = component;
				long buffId = 1108408002L;
				AddBuffParam addBuffParam = new AddBuffParam();
				addBuffParam.InstigatorId = num.Value;
				addBuffParam.OuterStackCount = new int?(1);
				addBuffParam.PreMessageId = skill.CombatMessageId;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
				defaultInterpolatedStringHandler.AppendLiteral("技能");
				defaultInterpolatedStringHandler.AppendFormatted<int>(skill.SkillId);
				defaultInterpolatedStringHandler.AppendLiteral("GA");
				UClass abilityClass = skill.AbilityClass;
				defaultInterpolatedStringHandler.AppendFormatted((abilityClass != null) ? abilityClass.GetName() : null);
				defaultInterpolatedStringHandler.AppendLiteral("的buff添加");
				addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
				baseBuffComponent.AddBuff(buffId, addBuffParam);
				return;
			}
		}
	}

	// Token: 0x0601B3EC RID: 111596 RVA: 0x0076E7BF File Offset: 0x0076C9BF
	private void TriggerBurstAttack(Skill skill)
	{
		if (this.AttackTriggered)
		{
			return;
		}
		this.AttackTriggered = true;
		if (!base.SkillComp.BeginSkill(1108131, new SkillParam
		{
			Reason = "CodeSkill_Feixue_Burst02"
		}))
		{
			base.EndSelf(skill);
		}
	}

	// Token: 0x0400D48F RID: 54415
	private const long CHARGE_BUFF_ID = 1108408002L;

	// Token: 0x0400D490 RID: 54416
	private const int BURST_ATTACK_SKILL_ID = 1108131;

	// Token: 0x0400D491 RID: 54417
	private const int BURST_MONTAGE_INDEX = 0;

	// Token: 0x0400D492 RID: 54418
	private bool ReceivedThreshold;

	// Token: 0x0400D493 RID: 54419
	private bool Released;

	// Token: 0x0400D494 RID: 54420
	private bool AttackTriggered;

	// Token: 0x0400D495 RID: 54421
	private bool ChargeReleaseGateUsed;

	// Token: 0x0400D496 RID: 54422
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D497 RID: 54423
	[Nullable(2)]
	private IGameplayEventTask ReleaseEventTask;

	// Token: 0x0400D498 RID: 54424
	private bool ThresholdListenerActive;
}
