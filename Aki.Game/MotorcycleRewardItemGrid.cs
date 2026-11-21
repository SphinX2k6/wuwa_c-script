using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x0200171D RID: 5917
public class MotorcycleRewardItemGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x0600E617 RID: 58903 RVA: 0x00438274 File Offset: 0x00436474
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.ConfigId = itemData.ItemId;
		MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(this.ConfigId);
		if (motorStickerConfig != null)
		{
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.IconPath = motorStickerConfig.Value.Icon;
			propSmallItemGrid.QualityId = new int?(motorStickerConfig.Value.QualityId);
			propSmallItemGrid.BottomText = ((count > 0) ? count.ToString() : "");
			Func<TItem, bool> showReceivedCallBack = this.ShowReceivedCallBack;
			propSmallItemGrid.IsReceivedVisible = new bool?(showReceivedCallBack != null && showReceivedCallBack(data));
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
			return;
		}
		PropSmallItemGrid propSmallItemGrid2 = new PropSmallItemGrid();
		propSmallItemGrid2.Data = data;
		propSmallItemGrid2.ItemConfigId = new int?(this.ConfigId);
		propSmallItemGrid2.BottomText = ((count > 0) ? count.ToString() : "");
		Func<TItem, bool> showReceivedCallBack2 = this.ShowReceivedCallBack;
		propSmallItemGrid2.IsReceivedVisible = new bool?(showReceivedCallBack2 != null && showReceivedCallBack2(data));
		PropSmallItemGrid parameters2 = propSmallItemGrid2;
		base.Apply<PropSmallItemGrid>(parameters2);
	}

	// Token: 0x0600E618 RID: 58904 RVA: 0x0043839B File Offset: 0x0043659B
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600E619 RID: 58905 RVA: 0x0043839E File Offset: 0x0043659E
	public void SetAllowClickBack(bool isAllow)
	{
		this.AllowClickBack = isAllow;
	}

	// Token: 0x0600E61A RID: 58906 RVA: 0x004383A7 File Offset: 0x004365A7
	protected override void OnExtendToggleClicked()
	{
		if (!this.AllowClickBack)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x04008371 RID: 33649
	private int ConfigId;

	// Token: 0x04008372 RID: 33650
	private bool AllowClickBack = true;

	// Token: 0x04008373 RID: 33651
	[Nullable(2)]
	public Func<TItem, bool> ShowReceivedCallBack;
}
