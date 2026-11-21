using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02000B52 RID: 2898
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundDetectRewardItem : LoopScrollSmallItemGrid<INewSoundDetectRewardItemData>
{
	// Token: 0x06007924 RID: 31012 RVA: 0x00258ED8 File Offset: 0x002570D8
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

	// Token: 0x06007925 RID: 31013 RVA: 0x00258F6A File Offset: 0x0025716A
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06007926 RID: 31014 RVA: 0x00258F6D File Offset: 0x0025716D
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x04004B71 RID: 19313
	private int ConfigId = -1;
}
