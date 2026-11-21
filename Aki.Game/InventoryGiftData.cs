using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001471 RID: 5233
[NullableContext(1)]
[Nullable(0)]
public class InventoryGiftData : UiPopViewData
{
	// Token: 0x0600D0EA RID: 53482 RVA: 0x003E1C18 File Offset: 0x003DFE18
	public InventoryGiftData(int configId, GiftItemData[] itemList, GiftPackage giftPackage, int? initSelectedId, int? selectedCount)
	{
		this.ConfigId = configId;
		int num = itemList.Length;
		this.ItemList = new GiftItemData[num];
		for (int i = 0; i < num; i++)
		{
			this.ItemList[i] = itemList[i];
		}
		this.GiftPackage = giftPackage;
		this.InitializedSelectedId = initSelectedId;
		this.SelectedCount = selectedCount;
	}

	// Token: 0x0400764C RID: 30284
	public int ConfigId;

	// Token: 0x0400764D RID: 30285
	public GiftItemData[] ItemList;

	// Token: 0x0400764E RID: 30286
	public GiftPackage GiftPackage;

	// Token: 0x0400764F RID: 30287
	public int? InitializedSelectedId;

	// Token: 0x04007650 RID: 30288
	public int? SelectedCount;
}
