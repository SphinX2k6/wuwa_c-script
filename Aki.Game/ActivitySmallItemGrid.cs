using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02001547 RID: 5447
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivitySmallItemGrid : LoopScrollSmallItemGrid<IItemGridData>
{
	// Token: 0x06009BAE RID: 39854 RVA: 0x0021B44F File Offset: 0x0021964F
	protected override void OnRefresh(IItemGridData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06009BAF RID: 39855 RVA: 0x0021B458 File Offset: 0x00219658
	public void Refresh(IItemGridData data)
	{
		TItem item = data.Item;
		int count = item.Count;
		this.ConfigId = item.ItemData.ItemId;
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.Data = data;
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
		propSmallItemGrid.IsReceivedVisible = new bool?(data.HasClaimed);
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06009BB0 RID: 39856 RVA: 0x0021B4E3 File Offset: 0x002196E3
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06009BB1 RID: 39857 RVA: 0x0021B4E6 File Offset: 0x002196E6
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x04004466 RID: 17510
	private int ConfigId;
}
