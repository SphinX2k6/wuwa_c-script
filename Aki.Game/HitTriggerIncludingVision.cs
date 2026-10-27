using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FE2 RID: 12258
[NullableContext(1)]
[Nullable(0)]
public class HitTriggerIncludingVision : Trigger
{
	// Token: 0x06019FBC RID: 106428 RVA: 0x006CCAB7 File Offset: 0x006CACB7
	[NullableContext(2)]
	public HitTriggerIncludingVision(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FBD RID: 106429 RVA: 0x006CCAC8 File Offset: 0x006CACC8
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06019FBE RID: 106430 RVA: 0x006CCAE4 File Offset: 0x006CACE4
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent));
		}
	}

	// Token: 0x06019FBF RID: 106431 RVA: 0x006CCB48 File Offset: 0x006CAD48
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent));
		}
	}

	// Token: 0x06019FC0 RID: 106432 RVA: 0x006CCBAC File Offset: 0x006CADAC
	private void OnEvent(HitInformation _, HitContext c)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		int[] skillTypes = TriggerUtils.GetSkillTypes(c.SkillGenres);
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = c.Attacker;
		dictionary["Victim"] = c.Target;
		dictionary["SkillID"] = c.SkillId;
		dictionary["SkillTypes"] = skillTypes;
		dictionary["BulletID"] = Convert.ToInt64(c.BulletId);
		dictionary["CounterType"] = (int)c.CounterAttackType;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06019FC1 RID: 106433 RVA: 0x006CCC6A File Offset: 0x006CAE6A
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B3 RID: 50355
	protected ETriggerTargetType TargetType;
}
