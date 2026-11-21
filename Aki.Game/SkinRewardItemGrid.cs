using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02001FB1 RID: 8113
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinRewardItemGrid : LoopScrollSmallItemGrid<SkinRewardData>
{
	// Token: 0x06014202 RID: 82434 RVA: 0x005DF2BB File Offset: 0x005DD4BB
	protected override void OnRefresh(SkinRewardData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x06014203 RID: 82435 RVA: 0x005DF2C8 File Offset: 0x005DD4C8
	public override void Refresh(SkinRewardData data, bool isSelected, int gridIndex)
	{
		TItem value = data.ItemData.Value;
		InventoryDefine.IGetItemData itemData = value.ItemData;
		int num = 0;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemData.ItemId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.VirtualItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.CommonItem)
		{
			num = value.Count;
		}
		this.ConfigId = itemData.ItemId;
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		propSmallItemGrid.IsReceivedVisible = new bool?(data.FinishState);
		string bottomText;
		if (num <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText;
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06014204 RID: 82436 RVA: 0x005DF37B File Offset: 0x005DD57B
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06014205 RID: 82437 RVA: 0x005DF37E File Offset: 0x005DD57E
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, false, null, false);
		Action<int> onClickRecommendSkinButtonCallback = this.OnClickRecommendSkinButtonCallback;
		if (onClickRecommendSkinButtonCallback == null)
		{
			return;
		}
		onClickRecommendSkinButtonCallback(this.ConfigId);
	}

	// Token: 0x0400AAF0 RID: 43760
	private int ConfigId;

	// Token: 0x0400AAF1 RID: 43761
	[Nullable(2)]
	public Action<int> OnClickRecommendSkinButtonCallback;
}
