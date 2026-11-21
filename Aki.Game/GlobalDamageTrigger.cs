using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x0200253F RID: 9535
[NullableContext(1)]
[Nullable(0)]
public class GlobalDamageTrigger : Trigger
{
	// Token: 0x0601792C RID: 96556 RVA: 0x006F6107 File Offset: 0x006F4307
	[NullableContext(2)]
	public GlobalDamageTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601792D RID: 96557 RVA: 0x006F6118 File Offset: 0x006F4318
	public override void OnInitParams(string[] triggerParams)
	{
		this.CalculateType = (ECalculationType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : 0.ToString());
		double num = Convert.ToDouble((triggerParams.Length > 1) ? triggerParams[1] : "0");
		this.DistSquared = num * num;
	}

	// Token: 0x0601792E RID: 96558 RVA: 0x006F6161 File Offset: 0x006F4361
	protected override void OnActive()
	{
		EventSystem.Instance.Add<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(EEventName.GlobalCharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
	}

	// Token: 0x0601792F RID: 96559 RVA: 0x006F617C File Offset: 0x006F437C
	protected override void OnInactive()
	{
		EventSystem.Instance.Remove<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(EEventName.GlobalCharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
	}

	// Token: 0x06017930 RID: 96560 RVA: 0x006F6198 File Offset: 0x006F4398
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
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		bool flag;
		if (ownerTriggerComp == null)
		{
			flag = true;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			flag = !((entity != null) ? new bool?(entity.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		CharacterTriggerComponent ownerTriggerComp2 = base.OwnerTriggerComp;
		global::Vector vector;
		if (ownerTriggerComp2 == null)
		{
			vector = null;
		}
		else
		{
			Entity entity2 = ownerTriggerComp2.Entity;
			if (entity2 == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent component = entity2.GetComponent<CharacterActorComponent>();
				vector = ((component != null) ? component.ActorLocationProxy : null);
			}
		}
		global::Vector vector2 = vector;
		CharacterActorComponent component2 = victim.GetComponent<CharacterActorComponent>();
		global::Vector vector3 = (component2 != null) ? component2.ActorLocationProxy : null;
		if (vector2 == null || vector3 == null)
		{
			return;
		}
		if (global::Vector.DistSquared(vector2, vector3) > this.DistSquared)
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
		dictionary["BattleFlags"] = TriggerUtils.GetBattleFlags(req.BattleFlags);
		dictionary["CounterType"] = (int)req.CounterType.GetValueOrDefault();
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06017931 RID: 96561 RVA: 0x006F63D1 File Offset: 0x006F45D1
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C891 RID: 51345
	protected ECalculationType CalculateType;

	// Token: 0x0400C892 RID: 51346
	protected double DistSquared;
}
