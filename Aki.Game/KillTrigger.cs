using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x02002FED RID: 12269
[NullableContext(1)]
[Nullable(0)]
public class KillTrigger : Trigger
{
	// Token: 0x0601A00B RID: 106507 RVA: 0x006CEAF3 File Offset: 0x006CCCF3
	[NullableContext(2)]
	public KillTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A00C RID: 106508 RVA: 0x006CEB04 File Offset: 0x006CCD04
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A00D RID: 106509 RVA: 0x006CEB20 File Offset: 0x006CCD20
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget(target, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x0601A00E RID: 106510 RVA: 0x006CEB84 File Offset: 0x006CCD84
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget(target, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharKillTarget, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEvent));
		}
	}

	// Token: 0x0601A00F RID: 106511 RVA: 0x006CEBE8 File Offset: 0x006CCDE8
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

	// Token: 0x0601A010 RID: 106512 RVA: 0x006CED09 File Offset: 0x006CCF09
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4CF RID: 50383
	protected ETriggerTargetType TargetType;
}
