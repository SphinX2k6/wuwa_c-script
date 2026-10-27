using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02000F23 RID: 3875
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementGridItem : LoopScrollSmallItemGrid<AchievementGridItemData>
{
	// Token: 0x06006222 RID: 25122 RVA: 0x00132C9E File Offset: 0x00130E9E
	protected override void OnRefresh(AchievementGridItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
	}

	// Token: 0x06006223 RID: 25123 RVA: 0x00132CA9 File Offset: 0x00130EA9
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x00132CAC File Offset: 0x00130EAC
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x00132CC0 File Offset: 0x00130EC0
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

	// Token: 0x04002C92 RID: 11410
	private int ConfigId;
}
