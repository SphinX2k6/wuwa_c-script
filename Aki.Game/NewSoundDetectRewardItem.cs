using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x0200169A RID: 5786
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectRewardItem : LoopScrollSmallItemGrid<INewSoundDetectRewardItemData>
{
	// Token: 0x0600A544 RID: 42308 RVA: 0x0024EABC File Offset: 0x0024CCBC
	protected override void OnRefresh(INewSoundDetectRewardItemData data, bool isSelected, int gridIndex)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData.ItemData;
		int count = data.ItemData.Count;
		this.ConfigId = itemData.ItemId;
		bool haveFinish = data.HaveFinish;
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
		propSmallItemGrid.IsReceivedVisible = new bool?(haveFinish);
		propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
		string bottomText;
		if (count <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText;
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x0600A545 RID: 42309 RVA: 0x0024EB4E File Offset: 0x0024CD4E
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600A546 RID: 42310 RVA: 0x0024EB51 File Offset: 0x0024CD51
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x04004ACA RID: 19146
	private int ConfigId = -1;
}
