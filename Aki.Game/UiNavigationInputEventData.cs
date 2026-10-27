using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002CCA RID: 11466
[NullableContext(1)]
[Nullable(0)]
public class UiNavigationInputEventData : IStaticVariableResetter
{
	// Token: 0x06018052 RID: 98386 RVA: 0x0061AF6D File Offset: 0x0061916D
	static UiNavigationInputEventData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationInputEventData.CreateStaticDefaultValue), new Action(UiNavigationInputEventData.ResetStaticDefaultValue));
	}

	// Token: 0x06018053 RID: 98387 RVA: 0x0061AF8C File Offset: 0x0061918C
	public static void CreateStaticDefaultValue()
	{
		UiNavigationInputEventData.CurrentMaxEventId = 999;
		UiNavigationInputEventData.EmptyEventIdList = new List<int>();
		UiNavigationInputEventData.InUseInputEventDataMap = new Dictionary<int, Dictionary<TsUiNavigationBehaviorListener, int>>();
	}

	// Token: 0x06018054 RID: 98388 RVA: 0x0061AFAC File Offset: 0x006191AC
	public static void ResetStaticDefaultValue()
	{
		UiNavigationInputEventData.CurrentMaxEventId = 999;
		UiNavigationInputEventData.EmptyEventIdList = null;
		UiNavigationInputEventData.InUseInputEventDataMap = null;
	}

	// Token: 0x06018055 RID: 98389 RVA: 0x0061AFC4 File Offset: 0x006191C4
	public static int ActivateInputEventDataOnce()
	{
		return UiNavigationInputEventData.CurrentMaxEventId;
	}

	// Token: 0x06018056 RID: 98390 RVA: 0x0061AFCC File Offset: 0x006191CC
	public static int CreateInputEventData(int configId, TsUiNavigationBehaviorListener listener)
	{
		Dictionary<TsUiNavigationBehaviorListener, int> dictionary;
		if (!UiNavigationInputEventData.InUseInputEventDataMap.TryGetValue(configId, out dictionary))
		{
			dictionary = new Dictionary<TsUiNavigationBehaviorListener, int>();
			UiNavigationInputEventData.InUseInputEventDataMap[configId] = dictionary;
		}
		int num;
		if (dictionary.TryGetValue(listener, out num))
		{
			return num;
		}
		if (UiNavigationInputEventData.EmptyEventIdList.Count > 0)
		{
			num = UiNavigationInputEventData.EmptyEventIdList[0];
			UiNavigationInputEventData.EmptyEventIdList.RemoveAt(0);
			dictionary[listener] = num;
		}
		else
		{
			num = UiNavigationInputEventData.CurrentMaxEventId++;
			dictionary[listener] = num;
		}
		return num;
	}

	// Token: 0x06018057 RID: 98391 RVA: 0x0061B04C File Offset: 0x0061924C
	public static int RecycleInputEventData(int configId, TsUiNavigationBehaviorListener listener)
	{
		Dictionary<TsUiNavigationBehaviorListener, int> dictionary;
		if (!UiNavigationInputEventData.InUseInputEventDataMap.TryGetValue(configId, out dictionary) || !dictionary.ContainsKey(listener))
		{
			return 999;
		}
		int num;
		if (dictionary.TryGetValue(listener, out num))
		{
			dictionary.Remove(listener);
			UiNavigationInputEventData.EmptyEventIdList.Add(num);
			return num;
		}
		return 999;
	}

	// Token: 0x06018058 RID: 98392 RVA: 0x0061B09C File Offset: 0x0061929C
	public static List<int> TryClearUnValidData()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, Dictionary<TsUiNavigationBehaviorListener, int>> keyValuePair in UiNavigationInputEventData.InUseInputEventDataMap)
		{
			Dictionary<TsUiNavigationBehaviorListener, int> value = keyValuePair.Value;
			List<ValueTuple<TsUiNavigationBehaviorListener, int>> list2 = new List<ValueTuple<TsUiNavigationBehaviorListener, int>>();
			foreach (KeyValuePair<TsUiNavigationBehaviorListener, int> keyValuePair2 in value)
			{
				TsUiNavigationBehaviorListener key = keyValuePair2.Key;
				int value2 = keyValuePair2.Value;
				if (!key.IsValid() || !key.GetNavigationComponent().IsActive())
				{
					list2.Add(new ValueTuple<TsUiNavigationBehaviorListener, int>(key, value2));
				}
			}
			foreach (ValueTuple<TsUiNavigationBehaviorListener, int> valueTuple in list2)
			{
				value.Remove(valueTuple.Item1);
				UiNavigationInputEventData.EmptyEventIdList.Add(valueTuple.Item2);
				list.Add(valueTuple.Item2);
			}
		}
		return list;
	}

	// Token: 0x0400B2E5 RID: 45797
	protected static int CurrentMaxEventId;

	// Token: 0x0400B2E6 RID: 45798
	protected static List<int> EmptyEventIdList;

	// Token: 0x0400B2E7 RID: 45799
	protected static Dictionary<int, Dictionary<TsUiNavigationBehaviorListener, int>> InUseInputEventDataMap;
}
