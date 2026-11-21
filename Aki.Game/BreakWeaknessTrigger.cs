using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002550 RID: 9552
[NullableContext(1)]
[Nullable(0)]
public class BreakWeaknessTrigger : Trigger
{
	// Token: 0x0601799C RID: 96668 RVA: 0x006F8BA0 File Offset: 0x006F6DA0
	[NullableContext(2)]
	public BreakWeaknessTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601799D RID: 96669 RVA: 0x006F8BB1 File Offset: 0x006F6DB1
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601799E RID: 96670 RVA: 0x006F8BCC File Offset: 0x006F6DCC
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent));
		}
	}

	// Token: 0x0601799F RID: 96671 RVA: 0x006F8C38 File Offset: 0x006F6E38
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<Entity, Entity, string>(target, EEventName.TriggerBreakWeakness, new Action<Entity, Entity, string>(this.OnEvent));
		}
	}

	// Token: 0x060179A0 RID: 96672 RVA: 0x006F8CA4 File Offset: 0x006F6EA4
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

	// Token: 0x060179A1 RID: 96673 RVA: 0x006F8D05 File Offset: 0x006F6F05
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8B9 RID: 51385
	protected ETriggerTargetType TargetType;
}
