using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FF2 RID: 12274
[NullableContext(1)]
[Nullable(0)]
public class BuffStackInstigatorTrigger : Trigger
{
	// Token: 0x0601A029 RID: 106537 RVA: 0x006CF4FA File Offset: 0x006CD6FA
	[NullableContext(2)]
	public BuffStackInstigatorTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A02A RID: 106538 RVA: 0x006CF520 File Offset: 0x006CD720
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

	// Token: 0x0601A02B RID: 106539 RVA: 0x006CF5E8 File Offset: 0x006CD7E8
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

	// Token: 0x0601A02C RID: 106540 RVA: 0x006CF670 File Offset: 0x006CD870
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

	// Token: 0x0601A02D RID: 106541 RVA: 0x006CF700 File Offset: 0x006CD900
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

	// Token: 0x0601A02E RID: 106542 RVA: 0x006CF790 File Offset: 0x006CD990
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

	// Token: 0x0601A02F RID: 106543 RVA: 0x006CF815 File Offset: 0x006CDA15
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D6 RID: 50390
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4D7 RID: 50391
	protected readonly HashSet<long> ListenBuffIds = new HashSet<long>();

	// Token: 0x0400C4D8 RID: 50392
	protected bool HasValidConfig = true;
}
