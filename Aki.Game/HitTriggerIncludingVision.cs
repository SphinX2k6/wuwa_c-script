using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002537 RID: 9527
[NullableContext(1)]
[Nullable(0)]
public class HitTriggerIncludingVision : Trigger
{
	// Token: 0x060178F0 RID: 96496 RVA: 0x006F4957 File Offset: 0x006F2B57
	[NullableContext(2)]
	public HitTriggerIncludingVision(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060178F1 RID: 96497 RVA: 0x006F4968 File Offset: 0x006F2B68
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x060178F2 RID: 96498 RVA: 0x006F4984 File Offset: 0x006F2B84
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent));
		}
	}

	// Token: 0x060178F3 RID: 96499 RVA: 0x006F49E8 File Offset: 0x006F2BE8
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget(target, EEventName.CharHitIncludingVision, new Action<HitInformation, HitContext>(this.OnEvent));
		}
	}

	// Token: 0x060178F4 RID: 96500 RVA: 0x006F4A4C File Offset: 0x006F2C4C
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

	// Token: 0x060178F5 RID: 96501 RVA: 0x006F4B0A File Offset: 0x006F2D0A
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C87B RID: 51323
	protected ETriggerTargetType TargetType;
}
