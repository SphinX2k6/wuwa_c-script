using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200131D RID: 4893
[NullableContext(1)]
[Nullable(0)]
public class DelegationData
{
	// Token: 0x060087C7 RID: 34759 RVA: 0x001CF9BF File Offset: 0x001CDBBF
	public DelegationData(int id, int bestEvaluateLevel, bool isVisible)
	{
		this.Id = id;
		this.BestEvaluateLevelInternal = bestEvaluateLevel;
		this.IsVisible = isVisible;
	}

	// Token: 0x060087C8 RID: 34760 RVA: 0x001CF9DC File Offset: 0x001CDBDC
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

	// Token: 0x060087C9 RID: 34761 RVA: 0x001CFA60 File Offset: 0x001CDC60
	public List<int> GetRecommendList()
	{
		List<int> list = new List<int>();
		foreach (DicIntInt dicIntInt in BusinessConfig.Instance.GetDelegationConfig(this.Id).CapacityMapIter())
		{
			list.Add(dicIntInt.Key);
		}
		return list;
	}

	// Token: 0x060087CA RID: 34762 RVA: 0x001CFACC File Offset: 0x001CDCCC
	public string GetLockText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(BusinessConfig.Instance.GetDelegationConfig(this.Id).UnlockCondition), null);
	}

	// Token: 0x060087CB RID: 34763 RVA: 0x001CFAFC File Offset: 0x001CDCFC
	public bool HasBestEvaluate()
	{
		return this.BestEvaluateLevelInternal > 0;
	}

	// Token: 0x060087CC RID: 34764 RVA: 0x001CFB07 File Offset: 0x001CDD07
	public void SetBestEvaluateLevel(int value)
	{
		if (this.BestEvaluateLevelInternal > value)
		{
			return;
		}
		this.BestEvaluateLevelInternal = value;
	}

	// Token: 0x17000B8F RID: 2959
	// (get) Token: 0x060087CD RID: 34765 RVA: 0x001CFB1A File Offset: 0x001CDD1A
	public int BestEvaluateLevel
	{
		get
		{
			return this.BestEvaluateLevelInternal;
		}
	}

	// Token: 0x060087CE RID: 34766 RVA: 0x001CFB24 File Offset: 0x001CDD24
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

	// Token: 0x04003C8B RID: 15499
	public readonly int Id;

	// Token: 0x04003C8C RID: 15500
	private int BestEvaluateLevelInternal;

	// Token: 0x04003C8D RID: 15501
	public readonly bool IsVisible;
}
