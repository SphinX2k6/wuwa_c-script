using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020026E8 RID: 9960
[NullableContext(1)]
[Nullable(0)]
public class CodeSkill_Feixue_Burst02 : CodeSkillBase
{
	// Token: 0x06018EE5 RID: 102117 RVA: 0x00795DDE File Offset: 0x00793FDE
	public CodeSkill_Feixue_Burst02(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018EE6 RID: 102118 RVA: 0x00795DE8 File Offset: 0x00793FE8
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

	// Token: 0x06018EE7 RID: 102119 RVA: 0x00795E74 File Offset: 0x00794074
	public override void OnEnd(Skill skill)
	{
		this.RemoveChargeEventListeners();
		this.ActiveSkill = null;
	}

	// Token: 0x06018EE8 RID: 102120 RVA: 0x00795E83 File Offset: 0x00794083
	private void OnMontageCompleted(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			base.EndSelf(skill);
			return;
		}
		this.TriggerBurstAttack(skill);
	}

	// Token: 0x06018EE9 RID: 102121 RVA: 0x00795E97 File Offset: 0x00794097
	private void OnMontageBlendOut(Skill skill, bool isInterrupted)
	{
		if (isInterrupted)
		{
			return;
		}
		this.TriggerBurstAttack(skill);
	}

	// Token: 0x06018EEA RID: 102122 RVA: 0x00795EA4 File Offset: 0x007940A4
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

	// Token: 0x06018EEB RID: 102123 RVA: 0x00795F18 File Offset: 0x00794118
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

	// Token: 0x06018EEC RID: 102124 RVA: 0x00795F7D File Offset: 0x0079417D
	private void OnReleaseEvent(int tagId, FGameplayEventData payload)
	{
		this.Released = true;
		if (this.ReceivedThreshold)
		{
			this.OnChargeGateReady();
		}
	}

	// Token: 0x06018EED RID: 102125 RVA: 0x00795F94 File Offset: 0x00794194
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

	// Token: 0x06018EEE RID: 102126 RVA: 0x00795FE8 File Offset: 0x007941E8
	private void OnChargeGateReady()
	{
		if (this.ChargeReleaseGateUsed)
		{
			return;
		}
		this.ChargeReleaseGateUsed = true;
		this.DoChargeBuffAndAttack();
	}

	// Token: 0x06018EEF RID: 102127 RVA: 0x00796000 File Offset: 0x00794200
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

	// Token: 0x06018EF0 RID: 102128 RVA: 0x00796028 File Offset: 0x00794228
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

	// Token: 0x06018EF1 RID: 102129 RVA: 0x00796123 File Offset: 0x00794323
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

	// Token: 0x0400D8F2 RID: 55538
	private const long CHARGE_BUFF_ID = 1108408002L;

	// Token: 0x0400D8F3 RID: 55539
	private const int BURST_ATTACK_SKILL_ID = 1108131;

	// Token: 0x0400D8F4 RID: 55540
	private const int BURST_MONTAGE_INDEX = 0;

	// Token: 0x0400D8F5 RID: 55541
	private bool ReceivedThreshold;

	// Token: 0x0400D8F6 RID: 55542
	private bool Released;

	// Token: 0x0400D8F7 RID: 55543
	private bool AttackTriggered;

	// Token: 0x0400D8F8 RID: 55544
	private bool ChargeReleaseGateUsed;

	// Token: 0x0400D8F9 RID: 55545
	[Nullable(2)]
	private Skill ActiveSkill;

	// Token: 0x0400D8FA RID: 55546
	[Nullable(2)]
	private IGameplayEventTask ReleaseEventTask;

	// Token: 0x0400D8FB RID: 55547
	private bool ThresholdListenerActive;
}
