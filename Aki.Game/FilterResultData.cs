using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FilterDefine;

// Token: 0x02000D0B RID: 3339
[NullableContext(1)]
[Nullable(0)]
public class FilterResultData : IStaticVariableResetter
{
	// Token: 0x06008A40 RID: 35392 RVA: 0x0029DEFA File Offset: 0x0029C0FA
	static FilterResultData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterResultData.CreateStaticDefaultValue), new Action(FilterResultData.ResetStaticDefaultValue));
	}

	// Token: 0x06008A41 RID: 35393 RVA: 0x0029DF19 File Offset: 0x0029C119
	public static void CreateStaticDefaultValue()
	{
		FilterResultData.IncrementId = 0;
	}

	// Token: 0x06008A42 RID: 35394 RVA: 0x0029DF21 File Offset: 0x0029C121
	public static void ResetStaticDefaultValue()
	{
		FilterResultData.IncrementId = 0;
	}

	// Token: 0x17000F51 RID: 3921
	// (get) Token: 0x06008A43 RID: 35395 RVA: 0x0029DF29 File Offset: 0x0029C129
	public int ConfigId
	{
		get
		{
			return this.ConfigIdInternal;
		}
	}

	// Token: 0x06008A44 RID: 35396 RVA: 0x0029DF31 File Offset: 0x0029C131
	public FilterResultData()
	{
		this.UniqueId = ++FilterResultData.IncrementId;
	}

	// Token: 0x06008A45 RID: 35397 RVA: 0x0029DF5E File Offset: 0x0029C15E
	public void SetConfigId(int configId)
	{
		this.ConfigIdInternal = configId;
	}

	// Token: 0x06008A46 RID: 35398 RVA: 0x0029DF68 File Offset: 0x0029C168
	public void AddSingleRuleData(FilterDefine.EFilterType filterType, int key, string value)
	{
		Dictionary<int, string> dictionary;
		if (!this.SelectRuleMap.TryGetValue(filterType, out dictionary))
		{
			dictionary = new Dictionary<int, string>();
		}
		dictionary[key] = value;
		this.SelectRuleMap[filterType] = dictionary;
	}

	// Token: 0x06008A47 RID: 35399 RVA: 0x0029DFA0 File Offset: 0x0029C1A0
	public void SetSelectRuleData(FilterDefine.EFilterType filterType, Dictionary<int, string> filterIdSet)
	{
		this.SelectRuleMap[filterType] = filterIdSet;
	}

	// Token: 0x06008A48 RID: 35400 RVA: 0x0029DFAF File Offset: 0x0029C1AF
	public void SetRuleData(Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> data)
	{
		this.SelectRuleMap = data;
	}

	// Token: 0x06008A49 RID: 35401 RVA: 0x0029DFB8 File Offset: 0x0029C1B8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, string> GetSelectRuleDataById(FilterDefine.EFilterType filterType)
	{
		Dictionary<int, string> result;
		if (this.SelectRuleMap.TryGetValue(filterType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06008A4A RID: 35402 RVA: 0x0029DFD8 File Offset: 0x0029C1D8
	public Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> GetSelectRuleData()
	{
		return this.SelectRuleMap;
	}

	// Token: 0x06008A4B RID: 35403 RVA: 0x0029DFE0 File Offset: 0x0029C1E0
	public void ClearSelectRuleData()
	{
		this.SelectRuleMap.Clear();
	}

	// Token: 0x06008A4C RID: 35404 RVA: 0x0029DFF0 File Offset: 0x0029C1F0
	public string ShowAllFilterContent()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (Dictionary<int, string> dictionary in this.SelectRuleMap.Values)
		{
			foreach (KeyValuePair<int, string> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				int mainAttributeCost = PhantomBattleModel.Instance.GetMainAttributeCost(key);
				string value2 = value;
				if (mainAttributeCost != 0)
				{
					string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("PhantomFilterCostSuffix");
					value2 = value + StringUtils.Format(configTextByKey, new string[]
					{
						mainAttributeCost.ToString()
					});
				}
				stringBuilder.Append(value2);
				stringBuilder.Append(',');
			}
		}
		stringBuilder.Length = ((stringBuilder.Length > 0) ? (stringBuilder.Length - 1) : 0);
		return stringBuilder.ToString();
	}

	// Token: 0x06008A4D RID: 35405 RVA: 0x0029E10C File Offset: 0x0029C30C
	public FilterStorageData ConvertToStorageData()
	{
		Dictionary<FilterDefine.EFilterType, List<int>> dictionary = new Dictionary<FilterDefine.EFilterType, List<int>>();
		foreach (KeyValuePair<FilterDefine.EFilterType, Dictionary<int, string>> keyValuePair in this.SelectRuleMap)
		{
			List<int> list = new List<int>();
			foreach (int item in keyValuePair.Value.Keys)
			{
				list.Add(item);
			}
			dictionary.Add(keyValuePair.Key, list);
		}
		return new FilterStorageData
		{
			ConfigId = this.ConfigId,
			SelectRuleMap = dictionary
		};
	}

	// Token: 0x0400531A RID: 21274
	private static int IncrementId;

	// Token: 0x0400531B RID: 21275
	private int ConfigIdInternal;

	// Token: 0x0400531C RID: 21276
	private Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> SelectRuleMap = new Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>();

	// Token: 0x0400531D RID: 21277
	public readonly int UniqueId = -1;
}
