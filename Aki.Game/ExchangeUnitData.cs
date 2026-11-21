using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020014C0 RID: 5312
public class ExchangeUnitData
{
	// Token: 0x0600D497 RID: 54423 RVA: 0x003F3308 File Offset: 0x003F1508
	public void SetDataByItemId(int itemId, int? totalCount = null)
	{
		if (ItemConfig.Instance.GetConfig(itemId) != null)
		{
			this.ItemId = itemId;
			this.Name = ItemConfig.Instance.GetItemName(itemId);
			int? num = totalCount;
			int num2 = 0;
			this.TotalCount = ((num.GetValueOrDefault() > num2 & num != null) ? totalCount.Value : InventoryModel.Instance.GetItemCountByConfigId(itemId, 0));
		}
	}

	// Token: 0x04007770 RID: 30576
	public int ItemId;

	// Token: 0x04007771 RID: 30577
	[Nullable(1)]
	public string Name = "";

	// Token: 0x04007772 RID: 30578
	public int TotalCount = 999999999;
}
