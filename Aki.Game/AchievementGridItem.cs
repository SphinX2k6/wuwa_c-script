using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020003D8 RID: 984
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementGridItem : LoopScrollSmallItemGrid<AchievementGridItemData>
{
	// Token: 0x060035BA RID: 13754 RVA: 0x0013B5C2 File Offset: 0x001397C2
	protected override void OnRefresh(AchievementGridItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x060035BB RID: 13755 RVA: 0x0013B5CD File Offset: 0x001397CD
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x060035BC RID: 13756 RVA: 0x0013B5D0 File Offset: 0x001397D0
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x060035BD RID: 13757 RVA: 0x0013B5E8 File Offset: 0x001397E8
	public override void Refresh(AchievementGridItemData data, bool isSelected, int gridIndex)
	{
		if (data != null && data.Data != null)
		{
			InventoryDefine.IGetItemData itemData = data.Data.Value.ItemData;
			int count = data.Data.Value.Count;
			this.ConfigId = itemData.ItemId;
			bool getRewardState = data.GetRewardState;
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			SmallItemGridBase smallItemGridBase = propSmallItemGrid;
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
			smallItemGridBase.BottomText = bottomText;
			propSmallItemGrid.IsReceivedVisible = new bool?(getRewardState);
			base.Apply<PropSmallItemGrid>(propSmallItemGrid);
		}
	}

	// Token: 0x04002D2B RID: 11563
	private int ConfigId;
}
