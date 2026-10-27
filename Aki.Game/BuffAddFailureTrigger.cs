using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FF6 RID: 12278
[NullableContext(1)]
[Nullable(0)]
public class BuffAddFailureTrigger : Trigger
{
	// Token: 0x0601A043 RID: 106563 RVA: 0x006D0134 File Offset: 0x006CE334
	[NullableContext(2)]
	public BuffAddFailureTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A044 RID: 106564 RVA: 0x006D0168 File Offset: 0x006CE368
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.ListenBuffIds.Clear();
		string[] array = ((triggerParams.Length > 1) ? triggerParams[1] : string.Empty).Split('#', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			long item;
			if (long.TryParse(array[i], out item))
			{
				this.ListenBuffIds.Add(item);
			}
		}
		this.TriggerOncePerContext = (Convert.ToInt32((triggerParams.Length > 2) ? triggerParams[2] : "0") == 1);
	}

	// Token: 0x0601A045 RID: 106565 RVA: 0x006D01F8 File Offset: 0x006CE3F8
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Add(target, EAbilityEventName.AddBuffFailure, key, new Action<long, Entity, Entity, int, long?>(this.OnEvent));
			}
		}
	}

	// Token: 0x0601A046 RID: 106566 RVA: 0x006D0280 File Offset: 0x006CE480
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds)
			{
				AbilityEvent.Instance.Remove(target, EAbilityEventName.AddBuffFailure, key, new Action<long, Entity, Entity, int, long?>(this.OnEvent));
			}
		}
	}

	// Token: 0x0601A047 RID: 106567 RVA: 0x006D0308 File Offset: 0x006CE508
	private void OnEvent(long buffId, Entity victim, Entity attacker, int stackCount, long? bulletContextId)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		if (this.TriggerOncePerContext)
		{
			long checkContext = bulletContextId.GetValueOrDefault();
			int num = this.ContextIds.FindIndex((long v) => v == checkContext);
			if (num == -1)
			{
				this.ContextIds.Add(checkContext);
				this.VictimIds.Add(victim.Id);
				if (this.ContextIds.Count > 15)
				{
					this.ContextIds.RemoveAt(0);
					this.VictimIds.RemoveAt(0);
				}
			}
			else if (this.VictimIds[num] != victim.Id)
			{
				return;
			}
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["BuffId"] = buffId;
		dictionary["Victim"] = victim;
		dictionary["Attacker"] = attacker;
		dictionary["StackCount"] = stackCount;
		string key = "Listener";
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		dictionary[key] = ((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null);
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601A048 RID: 106568 RVA: 0x006D0437 File Offset: 0x006CE637
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4E4 RID: 50404
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4E5 RID: 50405
	protected readonly List<long> ListenBuffIds = new List<long>();

	// Token: 0x0400C4E6 RID: 50406
	protected readonly List<long> ContextIds = new List<long>();

	// Token: 0x0400C4E7 RID: 50407
	protected readonly List<int> VictimIds = new List<int>();

	// Token: 0x0400C4E8 RID: 50408
	protected const int ContextCapacity = 15;

	// Token: 0x0400C4E9 RID: 50409
	protected bool TriggerOncePerContext;
}
