using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FEC RID: 12268
[NullableContext(1)]
[Nullable(0)]
public class DeathTrigger : Trigger
{
	// Token: 0x0601A004 RID: 106500 RVA: 0x006CE7F6 File Offset: 0x006CC9F6
	[NullableContext(2)]
	public DeathTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A005 RID: 106501 RVA: 0x006CE807 File Offset: 0x006CCA07
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.ListenDeathType = (DeathTrigger.EListenDeathType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x0601A006 RID: 106502 RVA: 0x006CE840 File Offset: 0x006CCA40
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if (this.ListenDeathType == DeathTrigger.EListenDeathType.DamageDeath && !EventSystem.Instance.HasWithTarget(target, EEventName.CharBeKilled, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharBeKilled, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
			return;
		}
		if (this.ListenDeathType == DeathTrigger.EListenDeathType.AllDeath && !EventSystem.Instance.HasWithTarget(target, EEventName.CharOnRoleDeadBefore, new Action(this.OnDeathBefore)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharOnRoleDeadBefore, new Action(this.OnDeathBefore));
		}
	}

	// Token: 0x0601A007 RID: 106503 RVA: 0x006CE8F4 File Offset: 0x006CCAF4
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target == null)
		{
			return;
		}
		if (this.ListenDeathType == DeathTrigger.EListenDeathType.DamageDeath && EventSystem.Instance.HasWithTarget(target, EEventName.CharBeKilled, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharBeKilled, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
			return;
		}
		if (this.ListenDeathType == DeathTrigger.EListenDeathType.AllDeath && EventSystem.Instance.HasWithTarget(target, EEventName.CharOnRoleDeadBefore, new Action(this.OnDeathBefore)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharOnRoleDeadBefore, new Action(this.OnDeathBefore));
		}
	}

	// Token: 0x0601A008 RID: 106504 RVA: 0x006CE9A8 File Offset: 0x006CCBA8
	private void OnEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble hitPos)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		float damage = result.Damage;
		Damage damageData = result.DamageData;
		int[] skillTypes = TriggerUtils.GetSkillTypes(req.SkillGenres);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = attacker;
		dictionary["Victim"] = victim;
		dictionary["DamageID"] = damageData.Id;
		dictionary["SkillID"] = req.SkillId.GetValueOrDefault();
		dictionary["SkillTypes"] = skillTypes;
		dictionary["DamageType"] = damageData.Type;
		dictionary["DamageSubType"] = damageData.SubType();
		dictionary["ElementType"] = (int)result.Element;
		dictionary["DamageValue"] = -damage;
		dictionary["IsCritical"] = req.IsCritical.GetValueOrDefault();
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A009 RID: 106505 RVA: 0x006CEAC9 File Offset: 0x006CCCC9
	private void OnDeathBefore()
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
	}

	// Token: 0x0601A00A RID: 106506 RVA: 0x006CEAEC File Offset: 0x006CCCEC
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4CD RID: 50381
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4CE RID: 50382
	protected DeathTrigger.EListenDeathType ListenDeathType;

	// Token: 0x02009624 RID: 38436
	[NullableContext(0)]
	protected enum EListenDeathType
	{
		// Token: 0x040302C5 RID: 197317
		DamageDeath,
		// Token: 0x040302C6 RID: 197318
		AllDeath
	}
}
