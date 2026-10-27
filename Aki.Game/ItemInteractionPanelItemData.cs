using System;
using System.Runtime.CompilerServices;

// Token: 0x020018C8 RID: 6344
public class ItemInteractionPanelItemData
{
	// Token: 0x0600BA13 RID: 47635 RVA: 0x002A23A8 File Offset: 0x002A05A8
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

	// Token: 0x0600BA14 RID: 47636 RVA: 0x002A240E File Offset: 0x002A060E
	public void SetCurrentCount(int count)
	{
		this.CurrentCount = count;
	}

	// Token: 0x0600BA15 RID: 47637 RVA: 0x002A2417 File Offset: 0x002A0617
	public int GetCurrentCount()
	{
		return this.CurrentCount;
	}

	// Token: 0x0600BA16 RID: 47638 RVA: 0x002A241F File Offset: 0x002A061F
	public int GetItemCount()
	{
		return this.ItemCount;
	}

	// Token: 0x0600BA17 RID: 47639 RVA: 0x002A2427 File Offset: 0x002A0627
	public bool IsEnable()
	{
		return this.ItemCount >= this.NeedCount;
	}

	// Token: 0x0600BA18 RID: 47640 RVA: 0x002A243A File Offset: 0x002A063A
	public int GetQualityId()
	{
		return this.QualityId;
	}

	// Token: 0x04005448 RID: 21576
	public readonly int ItemConfigId;

	// Token: 0x04005449 RID: 21577
	private int CurrentCount;

	// Token: 0x0400544A RID: 21578
	private readonly int ItemCount;

	// Token: 0x0400544B RID: 21579
	private readonly int QualityId;

	// Token: 0x0400544C RID: 21580
	public int NeedCount;

	// Token: 0x0400544D RID: 21581
	public bool IsSelected;
}
