using System;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020009AA RID: 2474
public class ScratchTicketRewardItemGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x06006CAA RID: 27818 RVA: 0x0021A2F9 File Offset: 0x002184F9
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		this._Refresh(data);
	}

	// Token: 0x06006CAB RID: 27819 RVA: 0x0021A304 File Offset: 0x00218504
	private void _Refresh(TItem data)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.ConfigId = itemData.ItemId;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(this.ConfigId),
			BottomText = count.ToString(),
			IsReceivedVisible = new bool?(count == 0)
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06006CAC RID: 27820 RVA: 0x0021A371 File Offset: 0x00218571
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06006CAD RID: 27821 RVA: 0x0021A374 File Offset: 0x00218574
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x040043DF RID: 17375
	private int ConfigId;
}
