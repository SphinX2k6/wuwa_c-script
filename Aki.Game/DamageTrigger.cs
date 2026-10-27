using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FE9 RID: 12265
[NullableContext(1)]
[Nullable(0)]
public class DamageTrigger : Trigger
{
	// Token: 0x06019FF2 RID: 106482 RVA: 0x006CDF72 File Offset: 0x006CC172
	[NullableContext(2)]
	public DamageTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FF3 RID: 106483 RVA: 0x006CDF84 File Offset: 0x006CC184
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.CalculateType = (ECalculationType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : 0.ToString());
	}

	// Token: 0x06019FF4 RID: 106484 RVA: 0x006CDFCC File Offset: 0x006CC1CC
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !TriggerEventHelper.HasWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.AddWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x06019FF5 RID: 106485 RVA: 0x006CE024 File Offset: 0x006CC224
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && TriggerEventHelper.HasWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.RemoveWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x06019FF6 RID: 106486 RVA: 0x006CE07C File Offset: 0x006CC27C
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
		Entity entity = attacker;
		if (FollowUtils.IsFollowShooterByEntity(entity))
		{
			entity = FollowUtils.ShouldForwardToFrontChar(entity);
		}
		int[] skillTypes = TriggerUtils.GetSkillTypes(req.SkillGenres);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = entity;
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
		dictionary["SkillDamageCountByVictim"] = req.SkillDamageCountByVictim.GetValueOrDefault(9999);
		string key = "BattleFlags";
		IReadOnlyList<string> battleFlags = req.BattleFlags;
		dictionary[key] = (((battleFlags != null) ? battleFlags.ToArray<string>() : null) ?? Array.Empty<string>());
		dictionary["CounterType"] = (int)req.CounterType.GetValueOrDefault();
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06019FF7 RID: 106487 RVA: 0x006CE244 File Offset: 0x006CC444
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4C7 RID: 50375
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4C8 RID: 50376
	protected ECalculationType CalculateType;
}
