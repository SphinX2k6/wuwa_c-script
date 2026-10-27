using System;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020014F2 RID: 5362
public class ScratchTicketRewardItemGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x060098D0 RID: 39120 RVA: 0x0021060D File Offset: 0x0020E80D
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		this._Refresh(data);
	}

	// Token: 0x060098D1 RID: 39121 RVA: 0x00210618 File Offset: 0x0020E818
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

	// Token: 0x060098D2 RID: 39122 RVA: 0x00210685 File Offset: 0x0020E885
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x060098D3 RID: 39123 RVA: 0x00210688 File Offset: 0x0020E888
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x0400433A RID: 17210
	private int ConfigId;
}
