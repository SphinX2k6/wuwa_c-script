using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

// Token: 0x02000D60 RID: 3424
[NullableContext(1)]
[Nullable(0)]
public class SortResultData : IStaticVariableResetter
{
	// Token: 0x06008C96 RID: 35990 RVA: 0x002A9055 File Offset: 0x002A7255
	static SortResultData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SortResultData.CreateStaticDefaultValue), new Action(SortResultData.ResetStaticDefaultValue));
	}

	// Token: 0x06008C97 RID: 35991 RVA: 0x002A9074 File Offset: 0x002A7274
	public static void CreateStaticDefaultValue()
	{
		SortResultData.IncrementId = 0;
	}

	// Token: 0x06008C98 RID: 35992 RVA: 0x002A907C File Offset: 0x002A727C
	public static void ResetStaticDefaultValue()
	{
		SortResultData.IncrementId = 0;
	}

	// Token: 0x17000F72 RID: 3954
	// (get) Token: 0x06008C99 RID: 35993 RVA: 0x002A9084 File Offset: 0x002A7284
	public int ConfigId
	{
		get
		{
			return this.ConfigIdInternal;
		}
	}

	// Token: 0x06008C9A RID: 35994 RVA: 0x002A908C File Offset: 0x002A728C
	public SortResultData()
	{
		this.UniqueId = ++SortResultData.IncrementId;
	}

	// Token: 0x06008C9B RID: 35995 RVA: 0x002A90A7 File Offset: 0x002A72A7
	public void SetConfigId(int configId)
	{
		this.ConfigIdInternal = configId;
	}

	// Token: 0x06008C9C RID: 35996 RVA: 0x002A90B0 File Offset: 0x002A72B0
	public void SetSelectBaseSort(SortViewBaseSort baseSort)
	{
		this.SelectBaseSort = baseSort;
	}

	// Token: 0x06008C9D RID: 35997 RVA: 0x002A90B9 File Offset: 0x002A72B9
	public void SetSelectAttributeSort(Dictionary<int, string> attributeSort)
	{
		this.SelectAttributeSort = attributeSort;
	}

	// Token: 0x06008C9E RID: 35998 RVA: 0x002A90C2 File Offset: 0x002A72C2
	[NullableContext(2)]
	public SortViewBaseSort GetSelectBaseSort()
	{
		return this.SelectBaseSort;
	}

	// Token: 0x06008C9F RID: 35999 RVA: 0x002A90CA File Offset: 0x002A72CA
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, string> GetSelectAttributeSort()
	{
		return this.SelectAttributeSort;
	}

	// Token: 0x06008CA0 RID: 36000 RVA: 0x002A90D2 File Offset: 0x002A72D2
	public void SetIsAscending(bool value)
	{
		this.IsAscending = value;
	}

	// Token: 0x06008CA1 RID: 36001 RVA: 0x002A90DB File Offset: 0x002A72DB
	public bool GetIsAscending()
	{
		return this.IsAscending;
	}

	// Token: 0x06008CA2 RID: 36002 RVA: 0x002A90E4 File Offset: 0x002A72E4
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

	// Token: 0x06008CA3 RID: 36003 RVA: 0x002A91CC File Offset: 0x002A73CC
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

	// Token: 0x06008CA4 RID: 36004 RVA: 0x002A9278 File Offset: 0x002A7478
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

	// Token: 0x0400545C RID: 21596
	private int ConfigIdInternal;

	// Token: 0x0400545D RID: 21597
	[Nullable(2)]
	private SortViewBaseSort SelectBaseSort;

	// Token: 0x0400545E RID: 21598
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> SelectAttributeSort;

	// Token: 0x0400545F RID: 21599
	private bool IsAscending;

	// Token: 0x04005460 RID: 21600
	private static int IncrementId;

	// Token: 0x04005461 RID: 21601
	public readonly int UniqueId;
}
