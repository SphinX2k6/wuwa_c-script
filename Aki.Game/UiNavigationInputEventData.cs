using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002223 RID: 8739
[NullableContext(1)]
[Nullable(0)]
public class UiNavigationInputEventData : IStaticVariableResetter
{
	// Token: 0x060158CF RID: 88271 RVA: 0x00640B69 File Offset: 0x0063ED69
	static UiNavigationInputEventData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationInputEventData.CreateStaticDefaultValue), new Action(UiNavigationInputEventData.ResetStaticDefaultValue));
	}

	// Token: 0x060158D0 RID: 88272 RVA: 0x00640B88 File Offset: 0x0063ED88
	public static void CreateStaticDefaultValue()
	{
		UiNavigationInputEventData.CurrentMaxEventId = 999;
		UiNavigationInputEventData.EmptyEventIdList = new List<int>();
		UiNavigationInputEventData.InUseInputEventDataMap = new Dictionary<int, Dictionary<TsUiNavigationBehaviorListener, int>>();
	}

	// Token: 0x060158D1 RID: 88273 RVA: 0x00640BA8 File Offset: 0x0063EDA8
	public static void ResetStaticDefaultValue()
	{
		UiNavigationInputEventData.CurrentMaxEventId = 999;
		UiNavigationInputEventData.EmptyEventIdList = null;
		UiNavigationInputEventData.InUseInputEventDataMap = null;
	}

	// Token: 0x060158D2 RID: 88274 RVA: 0x00640BC0 File Offset: 0x0063EDC0
	public static int ActivateInputEventDataOnce()
	{
		return UiNavigationInputEventData.CurrentMaxEventId;
	}

	// Token: 0x060158D3 RID: 88275 RVA: 0x00640BC8 File Offset: 0x0063EDC8
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

	// Token: 0x060158D4 RID: 88276 RVA: 0x00640C48 File Offset: 0x0063EE48
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

	// Token: 0x060158D5 RID: 88277 RVA: 0x00640C98 File Offset: 0x0063EE98
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

	// Token: 0x0400B651 RID: 46673
	protected static int CurrentMaxEventId;

	// Token: 0x0400B652 RID: 46674
	protected static List<int> EmptyEventIdList;

	// Token: 0x0400B653 RID: 46675
	protected static Dictionary<int, Dictionary<TsUiNavigationBehaviorListener, int>> InUseInputEventDataMap;
}
