using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200232F RID: 9007
public class BattlePassSmallGridItem : CommonItemSmallItemGrid
{
	// Token: 0x06011D59 RID: 73049 RVA: 0x00464ED4 File Offset: 0x004630D4
	public void RefreshItem(TItem data, EBattlePassItemType type)
	{
		InventoryDefine.IGetItemData itemData = data.ItemData;
		int count = data.Count;
		this.ConfigId = itemData.ItemId;
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
		propSmallItemGrid.IsReceivedVisible = new bool?(type == EBattlePassItemType.HasGet);
		propSmallItemGrid.IsLockVisible = new bool?(type == EBattlePassItemType.Locked);
		propSmallItemGrid.IsReceivableVisible = new bool?(type == EBattlePassItemType.CanGet);
		PropSmallItemGrid parameters = propSmallItemGrid;
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06011D5A RID: 73050 RVA: 0x00464F7B File Offset: 0x0046317B
	protected override void OnExtendToggleClicked()
	{
	}
}
