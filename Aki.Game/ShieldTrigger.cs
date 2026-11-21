using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x0200254C RID: 9548
[NullableContext(1)]
[Nullable(0)]
public class ShieldTrigger : Trigger
{
	// Token: 0x0601797D RID: 96637 RVA: 0x006F82DA File Offset: 0x006F64DA
	[NullableContext(2)]
	public ShieldTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601797E RID: 96638 RVA: 0x006F82EB File Offset: 0x006F64EB
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
	}

	// Token: 0x0601797F RID: 96639 RVA: 0x006F8308 File Offset: 0x006F6508
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Add(target, EAbilityEventName.ShieldChange, 0L, new Action<Entity, float, float, int, int>(this.OnEvent));
		}
	}

	// Token: 0x06017980 RID: 96640 RVA: 0x006F8350 File Offset: 0x006F6550
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Remove(target, EAbilityEventName.ShieldChange, 0L, new Action<Entity, float, float, int, int>(this.OnEvent));
		}
	}

	// Token: 0x06017981 RID: 96641 RVA: 0x006F8398 File Offset: 0x006F6598
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

	// Token: 0x06017982 RID: 96642 RVA: 0x006F841D File Offset: 0x006F661D
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8B2 RID: 51378
	protected ETriggerTargetType TargetType;
}
