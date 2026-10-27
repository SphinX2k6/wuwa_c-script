using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

// Token: 0x020018A7 RID: 6311
[NullableContext(1)]
[Nullable(0)]
public class SortResultData : IStaticVariableResetter
{
	// Token: 0x0600B8AD RID: 47277 RVA: 0x0029E935 File Offset: 0x0029CB35
	static SortResultData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortResultData.CreateStaticDefaultValue), new Action(SortResultData.ResetStaticDefaultValue));
	}

	// Token: 0x0600B8AE RID: 47278 RVA: 0x0029E954 File Offset: 0x0029CB54
	public static void CreateStaticDefaultValue()
	{
		SortResultData.IncrementId = 0;
	}

	// Token: 0x0600B8AF RID: 47279 RVA: 0x0029E95C File Offset: 0x0029CB5C
	public static void ResetStaticDefaultValue()
	{
		SortResultData.IncrementId = 0;
	}

	// Token: 0x17000F4F RID: 3919
	// (get) Token: 0x0600B8B0 RID: 47280 RVA: 0x0029E964 File Offset: 0x0029CB64
	public int ConfigId
	{
		get
		{
			return this.ConfigIdInternal;
		}
	}

	// Token: 0x0600B8B1 RID: 47281 RVA: 0x0029E96C File Offset: 0x0029CB6C
	public SortResultData()
	{
		this.UniqueId = ++SortResultData.IncrementId;
	}

	// Token: 0x0600B8B2 RID: 47282 RVA: 0x0029E987 File Offset: 0x0029CB87
	public void SetConfigId(int configId)
	{
		this.ConfigIdInternal = configId;
	}

	// Token: 0x0600B8B3 RID: 47283 RVA: 0x0029E990 File Offset: 0x0029CB90
	public void SetSelectBaseSort(SortViewBaseSort baseSort)
	{
		this.SelectBaseSort = baseSort;
	}

	// Token: 0x0600B8B4 RID: 47284 RVA: 0x0029E999 File Offset: 0x0029CB99
	public void SetSelectAttributeSort(Dictionary<int, string> attributeSort)
	{
		this.SelectAttributeSort = attributeSort;
	}

	// Token: 0x0600B8B5 RID: 47285 RVA: 0x0029E9A2 File Offset: 0x0029CBA2
	[NullableContext(2)]
	public SortViewBaseSort GetSelectBaseSort()
	{
		return this.SelectBaseSort;
	}

	// Token: 0x0600B8B6 RID: 47286 RVA: 0x0029E9AA File Offset: 0x0029CBAA
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, string> GetSelectAttributeSort()
	{
		return this.SelectAttributeSort;
	}

	// Token: 0x0600B8B7 RID: 47287 RVA: 0x0029E9B2 File Offset: 0x0029CBB2
	public void SetIsAscending(bool value)
	{
		this.IsAscending = value;
	}

	// Token: 0x0600B8B8 RID: 47288 RVA: 0x0029E9BB File Offset: 0x0029CBBB
	public bool GetIsAscending()
	{
		return this.IsAscending;
	}

	// Token: 0x0600B8B9 RID: 47289 RVA: 0x0029E9C4 File Offset: 0x0029CBC4
	public HashSet<int> GetAllSelectRuleSet()
	{
		HashSet<int> hashSet = new HashSet<int>();
		Sort? sortConfig = SortConfig.Instance.GetSortConfig(this.ConfigId);
		foreach (int item in sortConfig.Value.FrontSortList())
		{
			hashSet.Add(item);
		}
		hashSet.Add(this.SelectBaseSort.RuleId);
		if (this.SelectAttributeSort != null)
		{
			foreach (int item2 in this.SelectAttributeSort.Keys)
			{
				hashSet.Add(item2);
			}
		}
		foreach (int item3 in sortConfig.Value.LastSortList())
		{
			hashSet.Add(item3);
		}
		return hashSet;
	}

	// Token: 0x0600B8BA RID: 47290 RVA: 0x0029EAAC File Offset: 0x0029CCAC
	public string ShowAllSortContent()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(this.SelectBaseSort.RuleName);
		stringBuilder.Append(',');
		if (this.SelectAttributeSort != null)
		{
			foreach (string value in this.SelectAttributeSort.Values)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(',');
			}
		}
		stringBuilder.Length = ((stringBuilder.Length > 0) ? (stringBuilder.Length - 1) : 0);
		return stringBuilder.ToString();
	}

	// Token: 0x0600B8BB RID: 47291 RVA: 0x0029EB58 File Offset: 0x0029CD58
	public SortStorageData ConvertToStorageData()
	{
		SortStorageData sortStorageData = new SortStorageData
		{
			ConfigId = this.ConfigId,
			IsAscending = this.IsAscending
		};
		SortViewBaseSort selectBaseSort = this.GetSelectBaseSort();
		if (selectBaseSort != null)
		{
			sortStorageData.SelectBaseSort = new int?(selectBaseSort.RuleId);
		}
		Dictionary<int, string> selectAttributeSort = this.GetSelectAttributeSort();
		if (selectAttributeSort != null)
		{
			List<int> selectAttributeSort2 = new List<int>(selectAttributeSort.Keys);
			sortStorageData.SelectAttributeSort = selectAttributeSort2;
		}
		return sortStorageData;
	}

	// Token: 0x040053B1 RID: 21425
	private int ConfigIdInternal;

	// Token: 0x040053B2 RID: 21426
	[Nullable(2)]
	private SortViewBaseSort SelectBaseSort;

	// Token: 0x040053B3 RID: 21427
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> SelectAttributeSort;

	// Token: 0x040053B4 RID: 21428
	private bool IsAscending;

	// Token: 0x040053B5 RID: 21429
	private static int IncrementId;

	// Token: 0x040053B6 RID: 21430
	public readonly int UniqueId;
}
