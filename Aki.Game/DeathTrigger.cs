using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002541 RID: 9537
[NullableContext(1)]
[Nullable(0)]
public class DeathTrigger : Trigger
{
	// Token: 0x06017938 RID: 96568 RVA: 0x006F6692 File Offset: 0x006F4892
	[NullableContext(2)]
	public DeathTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017939 RID: 96569 RVA: 0x006F66A3 File Offset: 0x006F48A3
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.ListenDeathType = (DeathTrigger.EListenDeathType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
	}

	// Token: 0x0601793A RID: 96570 RVA: 0x006F66DC File Offset: 0x006F48DC
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

	// Token: 0x0601793B RID: 96571 RVA: 0x006F6790 File Offset: 0x006F4990
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

	// Token: 0x0601793C RID: 96572 RVA: 0x006F6844 File Offset: 0x006F4A44
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

	// Token: 0x0601793D RID: 96573 RVA: 0x006F6965 File Offset: 0x006F4B65
	private void OnDeathBefore()
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		base.EvaluateAndExecute(new Dictionary<string, TFormulaValue>());
	}

	// Token: 0x0601793E RID: 96574 RVA: 0x006F6988 File Offset: 0x006F4B88
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C895 RID: 51349
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C896 RID: 51350
	protected DeathTrigger.EListenDeathType ListenDeathType;

	// Token: 0x02008845 RID: 34885
	[NullableContext(0)]
	protected enum EListenDeathType
	{
		// Token: 0x0402B952 RID: 178514
		DamageDeath,
		// Token: 0x0402B953 RID: 178515
		AllDeath
	}
}
