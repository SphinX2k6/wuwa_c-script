using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02002239 RID: 8761
public class MotorcycleRewardItemGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x06011181 RID: 70017 RVA: 0x0042B6D0 File Offset: 0x004298D0
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

	// Token: 0x06011182 RID: 70018 RVA: 0x0042B7F7 File Offset: 0x004299F7
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06011183 RID: 70019 RVA: 0x0042B7FA File Offset: 0x004299FA
	public void SetAllowClickBack(bool isAllow)
	{
		this.AllowClickBack = isAllow;
	}

	// Token: 0x06011184 RID: 70020 RVA: 0x0042B803 File Offset: 0x00429A03
	protected override void OnExtendToggleClicked()
	{
		if (!this.AllowClickBack)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x04008233 RID: 33331
	private int ConfigId;

	// Token: 0x04008234 RID: 33332
	private bool AllowClickBack = true;

	// Token: 0x04008235 RID: 33333
	[Nullable(2)]
	public Func<TItem, bool> ShowReceivedCallBack;
}
