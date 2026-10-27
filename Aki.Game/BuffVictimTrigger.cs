using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Utils;

// Token: 0x02002FF3 RID: 12275
[NullableContext(1)]
[Nullable(0)]
public class BuffVictimTrigger : Trigger
{
	// Token: 0x0601A030 RID: 106544 RVA: 0x006CF81C File Offset: 0x006CDA1C
	[NullableContext(2)]
	public BuffVictimTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A031 RID: 106545 RVA: 0x006CF838 File Offset: 0x006CDA38
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

	// Token: 0x0601A032 RID: 106546 RVA: 0x006CF904 File Offset: 0x006CDB04
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

	// Token: 0x0601A033 RID: 106547 RVA: 0x006CF944 File Offset: 0x006CDB44
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

	// Token: 0x0601A034 RID: 106548 RVA: 0x006CF9D0 File Offset: 0x006CDBD0
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

	// Token: 0x0601A035 RID: 106549 RVA: 0x006CFA5C File Offset: 0x006CDC5C
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

	// Token: 0x0601A036 RID: 106550 RVA: 0x006CFB43 File Offset: 0x006CDD43
	public override string GetDebugTriggerType()
	{
		return string.Empty;
	}

	// Token: 0x0400C4D9 RID: 50393
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4DA RID: 50394
	[Nullable(new byte[]
	{
		1,
		1,
		0
	})]
	protected readonly Dictionary<long, List<ValueTuple<int, int>>> ListenBuffIds = new Dictionary<long, List<ValueTuple<int, int>>>();

	// Token: 0x02009625 RID: 38437
	[NullableContext(0)]
	protected enum EBuffVictimListenIdType
	{
		// Token: 0x040302C8 RID: 197320
		BuffId,
		// Token: 0x040302C9 RID: 197321
		BuffGroupId
	}
}
