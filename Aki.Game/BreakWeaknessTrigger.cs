using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FFB RID: 12283
[NullableContext(1)]
[Nullable(0)]
public class BreakWeaknessTrigger : Trigger
{
	// Token: 0x0601A068 RID: 106600 RVA: 0x006D0D04 File Offset: 0x006CEF04
	[NullableContext(2)]
	public BreakWeaknessTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A069 RID: 106601 RVA: 0x006D0D15 File Offset: 0x006CEF15
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A06A RID: 106602 RVA: 0x006D0D30 File Offset: 0x006CEF30
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent));
		}
	}

	// Token: 0x0601A06B RID: 106603 RVA: 0x006D0D9C File Offset: 0x006CEF9C
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent));
		}
	}

	// Token: 0x0601A06C RID: 106604 RVA: 0x006D0E08 File Offset: 0x006CF008
	private void OnEvent(Entity attacker, Entity target, string targetSocket)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Attacker"] = attacker;
		dictionary["Target"] = target;
		dictionary["TargetSocket"] = targetSocket;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A06D RID: 106605 RVA: 0x006D0E69 File Offset: 0x006CF069
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4F1 RID: 50417
	protected ETriggerTargetType TargetType;
}
