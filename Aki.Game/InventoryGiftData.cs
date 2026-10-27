using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001FAF RID: 8111
[NullableContext(1)]
[Nullable(0)]
public class InventoryGiftData : UiPopViewData
{
	// Token: 0x0600FCC4 RID: 64708 RVA: 0x003D6264 File Offset: 0x003D4464
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

	// Token: 0x0400756A RID: 30058
	public int ConfigId;

	// Token: 0x0400756B RID: 30059
	public GiftItemData[] ItemList;

	// Token: 0x0400756C RID: 30060
	public GiftPackage GiftPackage;

	// Token: 0x0400756D RID: 30061
	public int? InitializedSelectedId;

	// Token: 0x0400756E RID: 30062
	public int? SelectedCount;
}
