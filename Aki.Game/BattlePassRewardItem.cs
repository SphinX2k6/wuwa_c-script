using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001811 RID: 6161
public class BattlePassRewardItem
{
	// Token: 0x0600F1ED RID: 61933 RVA: 0x00471548 File Offset: 0x0046F748
	public BattlePassRewardItem(int itemId, int itemCount, EBattlePassItemType itemType = EBattlePassItemType.Locked)
	{
		this.Item = new TItem?(new TItem(new InventoryDefine.GetItemData(itemId, 0), itemCount));
		this.ItemType = new EBattlePassItemType?(itemType);
	}

	// Token: 0x0400885C RID: 34908
	public TItem? Item;

	// Token: 0x0400885D RID: 34909
	public EBattlePassItemType? ItemType;
}
