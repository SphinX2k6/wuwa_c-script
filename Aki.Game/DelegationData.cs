using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007D1 RID: 2001
[NullableContext(1)]
[Nullable(0)]
public class DelegationData
{
	// Token: 0x06005B62 RID: 23394 RVA: 0x001D882B File Offset: 0x001D6A2B
	public DelegationData(int id, int bestEvaluateLevel, bool isVisible)
	{
		this.Id = id;
		this.BestEvaluateLevelInternal = bestEvaluateLevel;
		this.IsVisible = isVisible;
	}

	// Token: 0x06005B63 RID: 23395 RVA: 0x001D8848 File Offset: 0x001D6A48
	public List<IItemData> GetConsumeList()
	{
		List<IItemData> list = new List<IItemData>();
		foreach (DicIntInt dicIntInt in BusinessConfig.Instance.GetDelegationConfig(this.Id).ConsumeIter())
		{
			list.Add(new ItemData
			{
				ItemId = dicIntInt.Key,
				Count = dicIntInt.Value
			});
		}
		return list;
	}

	// Token: 0x06005B64 RID: 23396 RVA: 0x001D88CC File Offset: 0x001D6ACC
	public List<int> GetRecommendList()
	{
		List<int> list = new List<int>();
		foreach (DicIntInt dicIntInt in BusinessConfig.Instance.GetDelegationConfig(this.Id).CapacityMapIter())
		{
			list.Add(dicIntInt.Key);
		}
		return list;
	}

	// Token: 0x06005B65 RID: 23397 RVA: 0x001D8938 File Offset: 0x001D6B38
	public string GetLockText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(BusinessConfig.Instance.GetDelegationConfig(this.Id).UnlockCondition), null);
	}

	// Token: 0x06005B66 RID: 23398 RVA: 0x001D8968 File Offset: 0x001D6B68
	public bool HasBestEvaluate()
	{
		return this.BestEvaluateLevelInternal > 0;
	}

	// Token: 0x06005B67 RID: 23399 RVA: 0x001D8973 File Offset: 0x001D6B73
	public void SetBestEvaluateLevel(int value)
	{
		if (this.BestEvaluateLevelInternal > value)
		{
			return;
		}
		this.BestEvaluateLevelInternal = value;
	}

	// Token: 0x17000BAF RID: 2991
	// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001D8986 File Offset: 0x001D6B86
	public int BestEvaluateLevel
	{
		get
		{
			return this.BestEvaluateLevelInternal;
		}
	}

	// Token: 0x06005B69 RID: 23401 RVA: 0x001D8990 File Offset: 0x001D6B90
	public int GetNotEnoughConsumeItemId()
	{
		foreach (IItemData itemData in this.GetConsumeList())
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(itemData.ItemId, 0) < itemData.Count)
			{
				return itemData.ItemId;
			}
		}
		return -1;
	}

	// Token: 0x04003D23 RID: 15651
	public readonly int Id;

	// Token: 0x04003D24 RID: 15652
	private int BestEvaluateLevelInternal;

	// Token: 0x04003D25 RID: 15653
	public readonly bool IsVisible;
}
