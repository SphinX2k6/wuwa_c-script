using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002547 RID: 9543
[NullableContext(1)]
[Nullable(0)]
public class BuffStackInstigatorTrigger : Trigger
{
	// Token: 0x0601795D RID: 96605 RVA: 0x006F7396 File Offset: 0x006F5596
	[NullableContext(2)]
	public BuffStackInstigatorTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601795E RID: 96606 RVA: 0x006F73BC File Offset: 0x006F55BC
	public override void OnInitParams(string[] triggerParams)
	{
		this.HasValidConfig = true;
		this.ListenBuffIds.Clear();
		ETriggerTargetType etriggerTargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		if (etriggerTargetType != ETriggerTargetType.Self && etriggerTargetType != ETriggerTargetType.LocalFormation && etriggerTargetType != ETriggerTargetType.AllFormation)
		{
			this.SetInvalidConfig(triggerParams);
			return;
		}
		this.TargetType = etriggerTargetType;
		string[] array = ((triggerParams.Length > 1) ? triggerParams[1] : string.Empty).Split('#', StringSplitOptions.None);
		if (array.Length == 0 || string.IsNullOrEmpty(array[0]))
		{
			this.SetInvalidConfig(triggerParams);
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			long num;
			if (!long.TryParse(array[i], out num) || num <= 0L)
			{
				this.SetInvalidConfig(triggerParams);
				return;
			}
			this.ListenBuffIds.Add(num);
		}
		if (this.ListenBuffIds.Count <= 0)
		{
			this.SetInvalidConfig(triggerParams);
		}
	}

	// Token: 0x0601795F RID: 96607 RVA: 0x006F7484 File Offset: 0x006F5684
	private unsafe void SetInvalidConfig(string[] triggerParams)
	{
		this.HasValidConfig = false;
		this.ListenBuffIds.Clear();
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
		string message = "BuffStackInstigatorTrigger参数错误";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("triggerName", this.GetDebugName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("params", triggerParams);
		instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06017960 RID: 96608 RVA: 0x006F750C File Offset: 0x006F570C
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
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Add(target, EAbilityEventName.BuffStackInstigatorChanged, key, new Action<long, int, int, Entity, Entity>(this.OnEvent));
			}
		}
	}

	// Token: 0x06017961 RID: 96609 RVA: 0x006F759C File Offset: 0x006F579C
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
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Remove(target, EAbilityEventName.BuffStackInstigatorChanged, key, new Action<long, int, int, Entity, Entity>(this.OnEvent));
			}
		}
	}

	// Token: 0x06017962 RID: 96610 RVA: 0x006F762C File Offset: 0x006F582C
	private void OnEvent(long buffId, int oldStack, int newStack, Entity victim, Entity attacker)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["BuffId"] = buffId;
		dictionary["OldStack"] = oldStack;
		dictionary["NewStack"] = newStack;
		dictionary["Victim"] = victim;
		dictionary["Attacker"] = attacker;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x06017963 RID: 96611 RVA: 0x006F76B1 File Offset: 0x006F58B1
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C89E RID: 51358
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C89F RID: 51359
	protected readonly HashSet<long> ListenBuffIds = new HashSet<long>();

	// Token: 0x0400C8A0 RID: 51360
	protected bool HasValidConfig = true;
}
