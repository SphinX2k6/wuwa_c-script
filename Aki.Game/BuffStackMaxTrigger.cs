using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002554 RID: 9556
[NullableContext(1)]
[Nullable(0)]
public class BuffStackMaxTrigger : Trigger
{
	// Token: 0x060179B6 RID: 96694 RVA: 0x006F91CB File Offset: 0x006F73CB
	[NullableContext(2)]
	public BuffStackMaxTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060179B7 RID: 96695 RVA: 0x006F91F4 File Offset: 0x006F73F4
	public override void OnInitParams(string[] triggerParams)
	{
		this.HasValidConfig = true;
		this.ListenBuffId = -1L;
		ETriggerTargetType etriggerTargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		if (etriggerTargetType != ETriggerTargetType.Self && etriggerTargetType != ETriggerTargetType.LocalFormation && etriggerTargetType != ETriggerTargetType.AllFormation)
		{
			this.SetInvalidConfig(triggerParams);
			return;
		}
		this.TargetType = etriggerTargetType;
		long num;
		if (!long.TryParse((triggerParams.Length > 1) ? triggerParams[1] : string.Empty, out num) || num <= 0L)
		{
			this.SetInvalidConfig(triggerParams);
			return;
		}
		this.ListenBuffId = num;
		this.TriggerOnAdd = (Convert.ToInt32((triggerParams.Length > 2) ? triggerParams[2] : "0") == 0);
	}

	// Token: 0x060179B8 RID: 96696 RVA: 0x006F928C File Offset: 0x006F748C
	private unsafe void SetInvalidConfig(string[] triggerParams)
	{
		this.HasValidConfig = false;
		this.ListenBuffId = -1L;
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
		string message = "BuffStackMaxTrigger参数错误";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("triggerName", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("params", triggerParams);
		instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060179B9 RID: 96697 RVA: 0x006F9310 File Offset: 0x006F7510
	protected override void OnActive()
	{
		if (!this.HasValidConfig)
		{
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Add(target, EAbilityEventName.BuffStackMaxChanged, this.ListenBuffId, new Action<long, int, int, Entity>(this.OnEvent));
		}
		this.TryTriggerOnActive();
	}

	// Token: 0x060179BA RID: 96698 RVA: 0x006F936C File Offset: 0x006F756C
	protected override void OnInactive()
	{
		if (!this.HasValidConfig)
		{
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			AbilityEvent.Instance.Remove(target, EAbilityEventName.BuffStackMaxChanged, this.ListenBuffId, new Action<long, int, int, Entity>(this.OnEvent));
		}
	}

	// Token: 0x060179BB RID: 96699 RVA: 0x006F93C4 File Offset: 0x006F75C4
	private void TryTriggerOnActive()
	{
		if (!this.TriggerOnAdd)
		{
			return;
		}
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		if (entity == null || baseBuffComponent == null)
		{
			return;
		}
		int? num = baseBuffComponent.CalculateBuffStackMax(this.ListenBuffId);
		if (num == null || num.Value <= 0 || num.Value >= 2147483647)
		{
			return;
		}
		this.OnEvent(this.ListenBuffId, num.Value, num.Value, entity);
	}

	// Token: 0x060179BC RID: 96700 RVA: 0x006F944C File Offset: 0x006F764C
	private void OnEvent(long buffId, int oldValue, int newValue, Entity victim)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["BuffId"] = buffId;
		dictionary["Victim"] = victim;
		dictionary["OldValue"] = oldValue;
		dictionary["NewValue"] = newValue;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x060179BD RID: 96701 RVA: 0x006F94BF File Offset: 0x006F76BF
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8C0 RID: 51392
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8C1 RID: 51393
	protected long ListenBuffId = -1L;

	// Token: 0x0400C8C2 RID: 51394
	protected bool TriggerOnAdd = true;

	// Token: 0x0400C8C3 RID: 51395
	protected bool HasValidConfig = true;
}
