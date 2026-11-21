using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x0200253E RID: 9534
[NullableContext(1)]
[Nullable(0)]
public class DamageTrigger : Trigger
{
	// Token: 0x06017926 RID: 96550 RVA: 0x006F5E3E File Offset: 0x006F403E
	[NullableContext(2)]
	public DamageTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017927 RID: 96551 RVA: 0x006F5E50 File Offset: 0x006F4050
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.CalculateType = (ECalculationType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : 0.ToString());
	}

	// Token: 0x06017928 RID: 96552 RVA: 0x006F5E98 File Offset: 0x006F4098
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !TriggerEventHelper.HasWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.AddWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x06017929 RID: 96553 RVA: 0x006F5EF0 File Offset: 0x006F40F0
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && TriggerEventHelper.HasWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			TriggerEventHelper.RemoveWithTarget(target, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x0601792A RID: 96554 RVA: 0x006F5F48 File Offset: 0x006F4148
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
		dictionary["BattleFlags"] = TriggerUtils.GetBattleFlags(req.BattleFlags);
		dictionary["CounterType"] = (int)req.CounterType.GetValueOrDefault();
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601792B RID: 96555 RVA: 0x006F6100 File Offset: 0x006F4300
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C88F RID: 51343
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C890 RID: 51344
	protected ECalculationType CalculateType;
}
