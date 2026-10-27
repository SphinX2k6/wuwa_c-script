using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FE4 RID: 12260
[NullableContext(1)]
[Nullable(0)]
public class TeamAttributeChangedTrigger : Trigger
{
	// Token: 0x06019FC9 RID: 106441 RVA: 0x006CCE8F File Offset: 0x006CB08F
	[NullableContext(2)]
	public TeamAttributeChangedTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06019FCA RID: 106442 RVA: 0x006CCEA7 File Offset: 0x006CB0A7
	public override void OnInitParams(string[] triggerParams)
	{
		this.AttributeId = (EFormationAttributeId)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x06019FCB RID: 106443 RVA: 0x006CCEC4 File Offset: 0x006CB0C4
	protected override void OnActive()
	{
		FormationAttributeController instance = FormationAttributeController.Instance;
		float num = (instance != null) ? instance.GetValue(this.AttributeId) : 0f;
		this.OnEvent(this.AttributeId, num, num);
		FormationAttributeController instance2 = FormationAttributeController.Instance;
		if (instance2 == null)
		{
			return;
		}
		instance2.AddValueListener(this.AttributeId, new TValueListener(this.OnEvent), null);
	}

	// Token: 0x06019FCC RID: 106444 RVA: 0x006CCF1D File Offset: 0x006CB11D
	protected override void OnInactive()
	{
		FormationAttributeController instance = FormationAttributeController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RemoveValueListener(this.AttributeId, new TValueListener(this.OnEvent));
	}

	// Token: 0x06019FCD RID: 106445 RVA: 0x006CCF40 File Offset: 0x006CB140
	protected void OnEvent(EFormationAttributeId attrId, float newValue, float oldValue)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["NewValue"] = newValue;
		dictionary["OldValue"] = oldValue;
		string key = "MaxValue";
		FormationAttributeController instance = FormationAttributeController.Instance;
		dictionary[key] = ((instance != null) ? instance.GetMax(attrId) : 0f);
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06019FCE RID: 106446 RVA: 0x006CCFB6 File Offset: 0x006CB1B6
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4B6 RID: 50358
	protected EFormationAttributeId AttributeId = EFormationAttributeId.Strength;
}
