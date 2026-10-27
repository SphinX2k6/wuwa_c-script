using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FF8 RID: 12280
[NullableContext(1)]
[Nullable(0)]
public class ShowTargetTrigger : Trigger
{
	// Token: 0x0601A04F RID: 106575 RVA: 0x006D0588 File Offset: 0x006CE788
	[NullableContext(2)]
	public ShowTargetTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A050 RID: 106576 RVA: 0x006D0599 File Offset: 0x006CE799
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A051 RID: 106577 RVA: 0x006D05B4 File Offset: 0x006CE7B4
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601A052 RID: 106578 RVA: 0x006D0618 File Offset: 0x006CE818
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601A053 RID: 106579 RVA: 0x006D067C File Offset: 0x006CE87C
	private void OnEvent(int targetId, string targetSocket, bool isHardLock)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["ShowTarget"] = EntitySystem.Instance.Get(targetId);
		dictionary["TargetSocket"] = targetSocket;
		dictionary["IsHardLock"] = isHardLock;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A054 RID: 106580 RVA: 0x006D06E7 File Offset: 0x006CE8E7
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4EB RID: 50411
	protected ETriggerTargetType TargetType;
}
