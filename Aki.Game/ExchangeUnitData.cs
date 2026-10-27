using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02001FED RID: 8173
public class ExchangeUnitData
{
	// Token: 0x0601002F RID: 65583 RVA: 0x003E6D10 File Offset: 0x003E4F10
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

	// Token: 0x04007687 RID: 30343
	public int ItemId;

	// Token: 0x04007688 RID: 30344
	[Nullable(1)]
	public string Name = "";

	// Token: 0x04007689 RID: 30345
	public int TotalCount = 999999999;
}
