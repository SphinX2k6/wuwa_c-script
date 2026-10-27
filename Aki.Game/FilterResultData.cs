using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FilterDefine;

// Token: 0x02001852 RID: 6226
[NullableContext(1)]
[Nullable(0)]
public class FilterResultData : IStaticVariableResetter
{
	// Token: 0x0600B657 RID: 46679 RVA: 0x002937EA File Offset: 0x002919EA
	static FilterResultData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FilterResultData.CreateStaticDefaultValue), new Action(FilterResultData.ResetStaticDefaultValue));
	}

	// Token: 0x0600B658 RID: 46680 RVA: 0x00293809 File Offset: 0x00291A09
	public static void CreateStaticDefaultValue()
	{
		FilterResultData.IncrementId = 0;
	}

	// Token: 0x0600B659 RID: 46681 RVA: 0x00293811 File Offset: 0x00291A11
	public static void ResetStaticDefaultValue()
	{
		FilterResultData.IncrementId = 0;
	}

	// Token: 0x17000F2E RID: 3886
	// (get) Token: 0x0600B65A RID: 46682 RVA: 0x00293819 File Offset: 0x00291A19
	public int ConfigId
	{
		get
		{
			return this.ConfigIdInternal;
		}
	}

	// Token: 0x0600B65B RID: 46683 RVA: 0x00293821 File Offset: 0x00291A21
	public FilterResultData()
	{
		this.UniqueId = ++FilterResultData.IncrementId;
	}

	// Token: 0x0600B65C RID: 46684 RVA: 0x0029384E File Offset: 0x00291A4E
	public void SetConfigId(int configId)
	{
		this.ConfigIdInternal = configId;
	}

	// Token: 0x0600B65D RID: 46685 RVA: 0x00293858 File Offset: 0x00291A58
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

	// Token: 0x0600B65E RID: 46686 RVA: 0x00293890 File Offset: 0x00291A90
	public void SetSelectRuleData(FilterDefine.EFilterType filterType, Dictionary<int, string> filterIdSet)
	{
		this.SelectRuleMap[filterType] = filterIdSet;
	}

	// Token: 0x0600B65F RID: 46687 RVA: 0x0029389F File Offset: 0x00291A9F
	public void SetRuleData(Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> data)
	{
		this.SelectRuleMap = data;
	}

	// Token: 0x0600B660 RID: 46688 RVA: 0x002938A8 File Offset: 0x00291AA8
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

	// Token: 0x0600B661 RID: 46689 RVA: 0x002938C8 File Offset: 0x00291AC8
	public Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> GetSelectRuleData()
	{
		return this.SelectRuleMap;
	}

	// Token: 0x0600B662 RID: 46690 RVA: 0x002938D0 File Offset: 0x00291AD0
	public void ClearSelectRuleData()
	{
		this.SelectRuleMap.Clear();
	}

	// Token: 0x0600B663 RID: 46691 RVA: 0x002938E0 File Offset: 0x00291AE0
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

	// Token: 0x0600B664 RID: 46692 RVA: 0x002939FC File Offset: 0x00291BFC
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

	// Token: 0x0400526F RID: 21103
	private static int IncrementId;

	// Token: 0x04005270 RID: 21104
	private int ConfigIdInternal;

	// Token: 0x04005271 RID: 21105
	private Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> SelectRuleMap = new Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>();

	// Token: 0x04005272 RID: 21106
	public readonly int UniqueId = -1;
}
