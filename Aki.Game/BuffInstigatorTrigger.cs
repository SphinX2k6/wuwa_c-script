using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FF1 RID: 12273
[NullableContext(1)]
[Nullable(0)]
public class BuffInstigatorTrigger : Trigger
{
	// Token: 0x0601A023 RID: 106531 RVA: 0x006CF24E File Offset: 0x006CD44E
	[NullableContext(2)]
	public BuffInstigatorTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A024 RID: 106532 RVA: 0x006CF26C File Offset: 0x006CD46C
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.ListenBuffIds.Clear();
		string[] array = ((triggerParams.Length > 1) ? triggerParams[1] : string.Empty).Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			long num;
			if (long.TryParse(array[i], out num) && num > 0L)
			{
				this.ListenBuffIds.Add(num);
			}
		}
		this.NotIncludeBornBuff = (((triggerParams.Length > 2) ? triggerParams[2] : "0") == "1");
		string[] array2 = ((triggerParams.Length > 3) ? triggerParams[3] : string.Empty).Split('#', StringSplitOptions.None);
		for (int j = 0; j < array2.Length; j++)
		{
			int num2;
			if (int.TryParse(array2[j], out num2) && num2 > 0)
			{
				foreach (long item in BuffController.GetBuffIdsByGroup(num2))
				{
					this.ListenBuffIds.Add(item);
				}
			}
		}
	}

	// Token: 0x0601A025 RID: 106533 RVA: 0x006CF370 File Offset: 0x006CD570
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Add(target, EAbilityEventName.AddBuffToOthers, key, new Action<long, Entity, Entity, bool?>(this.OnEvent));
			}
		}
	}

	// Token: 0x0601A026 RID: 106534 RVA: 0x006CF3F8 File Offset: 0x006CD5F8
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Remove(target, EAbilityEventName.AddBuffToOthers, key, new Action<long, Entity, Entity, bool?>(this.OnEvent));
			}
		}
	}

	// Token: 0x0601A027 RID: 106535 RVA: 0x006CF480 File Offset: 0x006CD680
	private void OnEvent(long buffId, Entity victim, Entity attacker, bool? bornBuff)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (this.NotIncludeBornBuff && bornBuff.GetValueOrDefault())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["BuffId"] = buffId;
		dictionary["Victim"] = victim;
		dictionary["Attacker"] = attacker;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A028 RID: 106536 RVA: 0x006CF4F3 File Offset: 0x006CD6F3
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D3 RID: 50387
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4D4 RID: 50388
	protected readonly HashSet<long> ListenBuffIds = new HashSet<long>();

	// Token: 0x0400C4D5 RID: 50389
	protected bool NotIncludeBornBuff;
}
