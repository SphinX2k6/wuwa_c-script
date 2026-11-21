using System;
using System.Runtime.CompilerServices;

// Token: 0x020006C8 RID: 1736
public class DailyAdventureSmallGridItem : SmallItemGrid
{
	// Token: 0x06004F8A RID: 20362 RVA: 0x001AB860 File Offset: 0x001A9A60
	[NullableContext(1)]
	public void Refresh(IItemGridData data, bool isReceivableVisible, bool isLock)
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
		propSmallItemGrid.IsReceivableVisible = new bool?(isReceivableVisible);
		propSmallItemGrid.IsLockVisible = new bool?(isLock);
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06004F8B RID: 20363 RVA: 0x001AB903 File Offset: 0x001A9B03
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06004F8C RID: 20364 RVA: 0x001AB906 File Offset: 0x001A9B06
	protected override void OnExtendToggleClicked()
	{
	}

	// Token: 0x04003960 RID: 14688
	private int ConfigId;
}
