using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D81 RID: 3457
public class ItemInteractionPanelItemData
{
	// Token: 0x06008DFC RID: 36348 RVA: 0x002ACB00 File Offset: 0x002AAD00
	[NullableContext(1)]
	public ItemInteractionPanelItemData(IItemInteractionPanelItemInfo itemInfo, int quality)
	{
		this.ItemConfigId = itemInfo.ItemConfigId;
		this.CurrentCount = itemInfo.CurrentCount;
		int? needCount = itemInfo.NeedCount;
		if (needCount != null)
		{
			this.NeedCount = needCount.Value;
		}
		this.QualityId = quality;
		this.ItemCount = InventoryModel.Instance.GetItemCountByConfigId(this.ItemConfigId, 0);
	}

	// Token: 0x06008DFD RID: 36349 RVA: 0x002ACB66 File Offset: 0x002AAD66
	public void SetCurrentCount(int count)
	{
		this.CurrentCount = count;
	}

	// Token: 0x06008DFE RID: 36350 RVA: 0x002ACB6F File Offset: 0x002AAD6F
	public int GetCurrentCount()
	{
		return this.CurrentCount;
	}

	// Token: 0x06008DFF RID: 36351 RVA: 0x002ACB77 File Offset: 0x002AAD77
	public int GetItemCount()
	{
		return this.ItemCount;
	}

	// Token: 0x06008E00 RID: 36352 RVA: 0x002ACB7F File Offset: 0x002AAD7F
	public bool IsEnable()
	{
		return this.ItemCount >= this.NeedCount;
	}

	// Token: 0x06008E01 RID: 36353 RVA: 0x002ACB92 File Offset: 0x002AAD92
	public int GetQualityId()
	{
		return this.QualityId;
	}

	// Token: 0x040054F3 RID: 21747
	public readonly int ItemConfigId;

	// Token: 0x040054F4 RID: 21748
	private int CurrentCount;

	// Token: 0x040054F5 RID: 21749
	private readonly int ItemCount;

	// Token: 0x040054F6 RID: 21750
	private readonly int QualityId;

	// Token: 0x040054F7 RID: 21751
	public int NeedCount;

	// Token: 0x040054F8 RID: 21752
	public bool IsSelected;
}
