using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200148B RID: 5259
public class MonthCardItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D28F RID: 53903 RVA: 0x003E789C File Offset: 0x003E5A9C
	public override bool IsMatch(int itemId)
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		return itemConfigData != null && (itemConfigData.Parameters.ContainsKey(13) || itemConfigData.Parameters.ContainsKey(14));
	}

	// Token: 0x0600D290 RID: 53904 RVA: 0x003E78D8 File Offset: 0x003E5AD8
	public override void OnUse(int itemId, int num)
	{
		ItemUseLogic.TryUseMonthCardItem(itemId, num);
	}
}
