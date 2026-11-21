using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002539 RID: 9529
[NullableContext(1)]
[Nullable(0)]
public class TeamAttributeChangedTrigger : Trigger
{
	// Token: 0x060178FD RID: 96509 RVA: 0x006F4D2F File Offset: 0x006F2F2F
	[NullableContext(2)]
	public TeamAttributeChangedTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060178FE RID: 96510 RVA: 0x006F4D47 File Offset: 0x006F2F47
	public override void OnInitParams(string[] triggerParams)
	{
		this.AttributeId = (EFormationAttributeId)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x060178FF RID: 96511 RVA: 0x006F4D64 File Offset: 0x006F2F64
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

	// Token: 0x06017900 RID: 96512 RVA: 0x006F4DBD File Offset: 0x006F2FBD
	protected override void OnInactive()
	{
		FormationAttributeController instance = FormationAttributeController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RemoveValueListener(this.AttributeId, new TValueListener(this.OnEvent));
	}

	// Token: 0x06017901 RID: 96513 RVA: 0x006F4DE0 File Offset: 0x006F2FE0
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

	// Token: 0x06017902 RID: 96514 RVA: 0x006F4E56 File Offset: 0x006F3056
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C87E RID: 51326
	protected EFormationAttributeId AttributeId = EFormationAttributeId.Strength;
}
