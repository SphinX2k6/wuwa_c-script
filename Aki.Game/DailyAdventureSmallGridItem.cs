using System;
using System.Runtime.CompilerServices;

// Token: 0x02001214 RID: 4628
public class DailyAdventureSmallGridItem : SmallItemGrid
{
	// Token: 0x06007BF4 RID: 31732 RVA: 0x001A2BE8 File Offset: 0x001A0DE8
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

	// Token: 0x06007BF5 RID: 31733 RVA: 0x001A2C8B File Offset: 0x001A0E8B
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06007BF6 RID: 31734 RVA: 0x001A2C8E File Offset: 0x001A0E8E
	protected override void OnExtendToggleClicked()
	{
	}

	// Token: 0x040038C7 RID: 14535
	private int ConfigId;
}
