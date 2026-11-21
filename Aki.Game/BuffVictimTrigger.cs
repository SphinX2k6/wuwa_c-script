using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002548 RID: 9544
[NullableContext(1)]
[Nullable(0)]
public class BuffVictimTrigger : Trigger
{
	// Token: 0x06017964 RID: 96612 RVA: 0x006F76B8 File Offset: 0x006F58B8
	[NullableContext(2)]
	public BuffVictimTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x06017965 RID: 96613 RVA: 0x006F76D4 File Offset: 0x006F58D4
	public override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.ListenBuffIds.Clear();
		for (int i = 1; i < triggerParams.Length; i++)
		{
			string[] array = triggerParams[i].Split('#', StringSplitOptions.None);
			if (array.Length >= 3)
			{
				int direction = Convert.ToInt32(array[0]);
				int threshold = Convert.ToInt32(array[2]);
				if (Convert.ToInt32((array.Length > 3) ? array[3] : "0") == 0)
				{
					long buffId = Convert.ToInt64(array[1]);
					this.AddBuffIdToListen(buffId, direction, threshold);
				}
				else
				{
					foreach (long buffId2 in BuffController.GetBuffIdsByGroup(Convert.ToInt32(array[1])))
					{
						this.AddBuffIdToListen(buffId2, direction, threshold);
					}
				}
			}
		}
	}

	// Token: 0x06017966 RID: 96614 RVA: 0x006F77A0 File Offset: 0x006F59A0
	private void AddBuffIdToListen(long buffId, int direction, int threshold)
	{
		List<ValueTuple<int, int>> list;
		if (!this.ListenBuffIds.TryGetValue(buffId, out list))
		{
			list = new List<ValueTuple<int, int>>();
			this.ListenBuffIds[buffId] = list;
		}
		list.Add(new ValueTuple<int, int>(direction, threshold));
	}

	// Token: 0x06017967 RID: 96615 RVA: 0x006F77E0 File Offset: 0x006F59E0
	protected override void OnActive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds.Keys)
			{
				AbilityEvent.Instance.Add(target, EAbilityEventName.BuffStackChanged, key, new Action<long, int, int, Entity>(this.OnEvent));
			}
		}
	}

	// Token: 0x06017968 RID: 96616 RVA: 0x006F786C File Offset: 0x006F5A6C
	protected override void OnInactive()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		object target = TriggerUtils.GetTarget((ownerTriggerComp != null) ? ownerTriggerComp.Entity : null, this.TargetType);
		if (target != null)
		{
			foreach (long key in this.ListenBuffIds.Keys)
			{
				AbilityEvent.Instance.Remove(target, EAbilityEventName.BuffStackChanged, key, new Action<long, int, int, Entity>(this.OnEvent));
			}
		}
	}

	// Token: 0x06017969 RID: 96617 RVA: 0x006F78F8 File Offset: 0x006F5AF8
	private void OnEvent(long buffId, int oldStack, int newStack, Entity victim)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		List<ValueTuple<int, int>> list;
		if (!this.ListenBuffIds.TryGetValue(buffId, out list))
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < list.Count; i++)
		{
			int item = list[i].Item1;
			int item2 = list[i].Item2;
			if ((item == 0 && newStack >= item2 && oldStack < item2) || (item == 1 && newStack <= item2 && oldStack > item2) || (item == 2 && newStack >= item2) || (item == 3 && newStack <= item2))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["BuffId"] = buffId;
		dictionary["OldStack"] = oldStack;
		dictionary["NewStack"] = newStack;
		dictionary["Victim"] = victim;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x0601796A RID: 96618 RVA: 0x006F79DF File Offset: 0x006F5BDF
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C8A1 RID: 51361
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8A2 RID: 51362
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	protected readonly Dictionary<long, List<ValueTuple<int, int>>> ListenBuffIds = new Dictionary<long, List<ValueTuple<int, int>>>();

	// Token: 0x02008846 RID: 34886
	[NullableContext(0)]
	protected enum EBuffVictimListenIdType
	{
		// Token: 0x0402B955 RID: 178517
		BuffId,
		// Token: 0x0402B956 RID: 178518
		BuffGroupId
	}
}
