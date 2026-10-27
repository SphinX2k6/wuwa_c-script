using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200232C RID: 9004
public class BattlePassRewardItem
{
	// Token: 0x06011D3D RID: 73021 RVA: 0x00464484 File Offset: 0x00462684
	public BattlePassRewardItem(int itemId, int itemCount, EBattlePassItemType itemType = EBattlePassItemType.Locked)
	{
		this.Item = new TItem?(new TItem(new InventoryDefine.GetItemData(itemId, 0), itemCount));
		this.ItemType = new EBattlePassItemType?(itemType);
	}

	// Token: 0x04008719 RID: 34585
	public TItem? Item;

	// Token: 0x0400871A RID: 34586
	public EBattlePassItemType? ItemType;
}
