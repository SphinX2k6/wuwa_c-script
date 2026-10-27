using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Utils;

// Token: 0x02002FF9 RID: 12281
[NullableContext(1)]
[Nullable(0)]
public class ClearShowTargetTrigger : Trigger
{
	// Token: 0x0601A055 RID: 106581 RVA: 0x006D06EE File Offset: 0x006CE8EE
	[NullableContext(2)]
	public ClearShowTargetTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A056 RID: 106582 RVA: 0x006D06FF File Offset: 0x006CE8FF
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A057 RID: 106583 RVA: 0x006D071C File Offset: 0x006CE91C
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			EventSystem.Instance.AddWithTarget<int, string, bool>(target, EEventName.CharEndShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601A058 RID: 106584 RVA: 0x006D0764 File Offset: 0x006CE964
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			EventSystem.Instance.RemoveWithTarget<int, string, bool>(target, EEventName.CharEndShowTarget, new Action<int, string, bool>(this.OnEvent));
		}
	}

	// Token: 0x0601A059 RID: 106585 RVA: 0x006D07AC File Offset: 0x006CE9AC
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

	// Token: 0x0601A05A RID: 106586 RVA: 0x006D0817 File Offset: 0x006CEA17
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4EC RID: 50412
	protected ETriggerTargetType TargetType;
}
