using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FEB RID: 12267
[NullableContext(1)]
[Nullable(0)]
public class BeDamageTrigger : Trigger
{
	// Token: 0x06019FFE RID: 106494 RVA: 0x006CE52C File Offset: 0x006CC72C
	[NullableContext(2)]
	public BeDamageTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FFF RID: 106495 RVA: 0x006CE540 File Offset: 0x006CC740
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.CalculateType = (ECalculationType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : 0.ToString());
	}

	// Token: 0x0601A000 RID: 106496 RVA: 0x006CE588 File Offset: 0x006CC788
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !TriggerEventHelper.HasWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.AddWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x0601A001 RID: 106497 RVA: 0x006CE5E0 File Offset: 0x006CC7E0
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && TriggerEventHelper.HasWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.RemoveWithTarget(target, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x0601A002 RID: 106498 RVA: 0x006CE638 File Offset: 0x006CC838
	private void OnEvent(Entity attacker, Entity victim, RequirementPayload req, DamageResult result, FVectorDouble _)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		float damage = result.Damage;
		Damage damageData = result.DamageData;
		if (damageData.CalculateType != (int)this.CalculateType)
		{
			return;
		}
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
		dictionary["SkillDamageCount"] = req.SkillDamageCount.GetValueOrDefault(9999);
		dictionary["BulletDamageCount"] = req.BulletDamageCount.GetValueOrDefault(9999);
		string key = "BattleFlags";
		IReadOnlyList<string> battleFlags = req.BattleFlags;
		dictionary[key] = (((battleFlags != null) ? battleFlags.ToArray<string>() : null) ?? Array.Empty<string>());
		dictionary["CounterType"] = (int)req.CounterType.GetValueOrDefault();
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A003 RID: 106499 RVA: 0x006CE7EF File Offset: 0x006CC9EF
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4CB RID: 50379
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4CC RID: 50380
	protected ECalculationType CalculateType;
}
