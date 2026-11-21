using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x0200254B RID: 9547
[NullableContext(1)]
[Nullable(0)]
public class BuffAddFailureTrigger : Trigger
{
	// Token: 0x06017977 RID: 96631 RVA: 0x006F7FD0 File Offset: 0x006F61D0
	[NullableContext(2)]
	public BuffAddFailureTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017978 RID: 96632 RVA: 0x006F8004 File Offset: 0x006F6204
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

	// Token: 0x06017979 RID: 96633 RVA: 0x006F8094 File Offset: 0x006F6294
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

	// Token: 0x0601797A RID: 96634 RVA: 0x006F811C File Offset: 0x006F631C
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

	// Token: 0x0601797B RID: 96635 RVA: 0x006F81A4 File Offset: 0x006F63A4
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

	// Token: 0x0601797C RID: 96636 RVA: 0x006F82D3 File Offset: 0x006F64D3
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8AC RID: 51372
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8AD RID: 51373
	protected readonly List<long> ListenBuffIds = new List<long>();

	// Token: 0x0400C8AE RID: 51374
	protected readonly List<long> ContextIds = new List<long>();

	// Token: 0x0400C8AF RID: 51375
	protected readonly List<int> VictimIds = new List<int>();

	// Token: 0x0400C8B0 RID: 51376
	protected const int ContextCapacity = 15;

	// Token: 0x0400C8B1 RID: 51377
	protected bool TriggerOncePerContext;
}
