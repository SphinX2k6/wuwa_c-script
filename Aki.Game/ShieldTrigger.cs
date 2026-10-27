using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FF7 RID: 12279
[NullableContext(1)]
[Nullable(0)]
public class ShieldTrigger : Trigger
{
	// Token: 0x0601A049 RID: 106569 RVA: 0x006D043E File Offset: 0x006CE63E
	[NullableContext(2)]
	public ShieldTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A04A RID: 106570 RVA: 0x006D044F File Offset: 0x006CE64F
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601A04B RID: 106571 RVA: 0x006D046C File Offset: 0x006CE66C
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Add(target, EAbilityEventName.ShieldChange, 0L, new Action<Entity, float, float, int, int>(this.OnEvent));
		}
	}

	// Token: 0x0601A04C RID: 106572 RVA: 0x006D04B4 File Offset: 0x006CE6B4
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Remove(target, EAbilityEventName.ShieldChange, 0L, new Action<Entity, float, float, int, int>(this.OnEvent));
		}
	}

	// Token: 0x0601A04D RID: 106573 RVA: 0x006D04FC File Offset: 0x006CE6FC
	private void OnEvent(Entity victim, float oldShieldValue, float newShieldValue, int updateType, int shieldId)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["Victim"] = victim;
		dictionary["OldShieldValue"] = oldShieldValue;
		dictionary["NewShieldValue"] = newShieldValue;
		dictionary["UpdateType"] = updateType;
		dictionary["ShieldId"] = shieldId;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A04E RID: 106574 RVA: 0x006D0581 File Offset: 0x006CE781
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4EA RID: 50410
	protected ETriggerTargetType TargetType;
}
