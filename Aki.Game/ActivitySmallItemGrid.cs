using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020009FF RID: 2559
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivitySmallItemGrid : LoopScrollSmallItemGrid<IItemGridData>
{
	// Token: 0x06006F8C RID: 28556 RVA: 0x002251FF File Offset: 0x002233FF
	protected override void OnRefresh(IItemGridData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06006F8D RID: 28557 RVA: 0x00225208 File Offset: 0x00223408
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

	// Token: 0x06006F8E RID: 28558 RVA: 0x00225293 File Offset: 0x00223493
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x00225296 File Offset: 0x00223496
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x0400450C RID: 17676
	private int ConfigId;
}
