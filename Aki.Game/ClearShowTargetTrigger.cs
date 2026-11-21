using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x0200254E RID: 9550
[NullableContext(1)]
[Nullable(0)]
public class ClearShowTargetTrigger : Trigger
{
	// Token: 0x06017989 RID: 96649 RVA: 0x006F858A File Offset: 0x006F678A
	[NullableContext(2)]
	public ClearShowTargetTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601798A RID: 96650 RVA: 0x006F859B File Offset: 0x006F679B
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601798B RID: 96651 RVA: 0x006F85B8 File Offset: 0x006F67B8
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			EventSystem.Instance.AddWithTarget<int, string, bool>(target, EEventName.CharEndShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601798C RID: 96652 RVA: 0x006F8600 File Offset: 0x006F6800
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			EventSystem.Instance.RemoveWithTarget<int, string, bool>(target, EEventName.CharEndShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601798D RID: 96653 RVA: 0x006F8648 File Offset: 0x006F6848
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

	// Token: 0x0601798E RID: 96654 RVA: 0x006F86B3 File Offset: 0x006F68B3
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8B4 RID: 51380
	protected ETriggerTargetType TargetType;
}
