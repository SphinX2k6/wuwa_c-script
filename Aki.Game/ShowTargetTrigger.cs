using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x0200254D RID: 9549
[NullableContext(1)]
[Nullable(0)]
public class ShowTargetTrigger : Trigger
{
	// Token: 0x06017983 RID: 96643 RVA: 0x006F8424 File Offset: 0x006F6624
	[NullableContext(2)]
	public ShowTargetTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017984 RID: 96644 RVA: 0x006F8435 File Offset: 0x006F6635
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06017985 RID: 96645 RVA: 0x006F8450 File Offset: 0x006F6650
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && !EventSystem.Instance.HasWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent)))
		{
			EventSystem.Instance.AddWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x06017986 RID: 96646 RVA: 0x006F84B4 File Offset: 0x006F66B4
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null && EventSystem.Instance.HasWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent)))
		{
			EventSystem.Instance.RemoveWithTarget<int, string, bool>(target, EEventName.CharSetShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x06017987 RID: 96647 RVA: 0x006F8518 File Offset: 0x006F6718
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

	// Token: 0x06017988 RID: 96648 RVA: 0x006F8583 File Offset: 0x006F6783
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8B3 RID: 51379
	protected ETriggerTargetType TargetType;
}
