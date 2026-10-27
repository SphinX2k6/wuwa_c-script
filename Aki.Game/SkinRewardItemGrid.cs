using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02002A36 RID: 10806
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinRewardItemGrid : LoopScrollSmallItemGrid<SkinRewardData>
{
	// Token: 0x060167F9 RID: 92153 RVA: 0x005B4147 File Offset: 0x005B2347
	protected override void OnRefresh(SkinRewardData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x060167FA RID: 92154 RVA: 0x005B4154 File Offset: 0x005B2354
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

	// Token: 0x060167FB RID: 92155 RVA: 0x005B4207 File Offset: 0x005B2407
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x060167FC RID: 92156 RVA: 0x005B420A File Offset: 0x005B240A
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, false, null);
		Action<int> onClickRecommendSkinButtonCallback = this.OnClickRecommendSkinButtonCallback;
		if (onClickRecommendSkinButtonCallback == null)
		{
			return;
		}
		onClickRecommendSkinButtonCallback(this.ConfigId);
	}

	// Token: 0x0400A705 RID: 42757
	private int ConfigId;

	// Token: 0x0400A706 RID: 42758
	[Nullable(2)]
	public Action<int> OnClickRecommendSkinButtonCallback;
}
