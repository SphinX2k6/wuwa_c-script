using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FF5 RID: 8181
[NullableContext(1)]
[Nullable(0)]
public class MainInterfaceData
{
	// Token: 0x0601007D RID: 65661 RVA: 0x003E8B6C File Offset: 0x003E6D6C
	public void InsertItemRewardInfo(AddCountItemInfo[] addCountItemInfo)
	{
		foreach (AddCountItemInfo addCountItemInfo2 in addCountItemInfo)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(addCountItemInfo2.Id);
			if (itemConfigData != null && itemConfigData.ShowInBag)
			{
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemCount = new int?(addCountItemInfo2.Count);
				itemRewardInfo.ItemId = new int?(addCountItemInfo2.Id);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				this.WaitList.Add(itemRewardInfo);
			}
		}
		this.WaitList.Sort((ItemRewardInfo aRewardInfo, ItemRewardInfo bRewardInfo) => bRewardInfo.Quality - aRewardInfo.Quality);
	}

	// Token: 0x0601007E RID: 65662 RVA: 0x003E8C18 File Offset: 0x003E6E18
	public void AddItemRewardInfo(ItemRewardInfo addItem)
	{
		if (addItem == null)
		{
			return;
		}
		this.WaitList.Add(addItem);
	}

	// Token: 0x0601007F RID: 65663 RVA: 0x003E8C2C File Offset: 0x003E6E2C
	public void SortWaitList()
	{
		this.WaitList.RemoveAll((ItemRewardInfo x) => x == null);
		this.WaitList.Sort((ItemRewardInfo aRewardInfo, ItemRewardInfo bRewardInfo) => bRewardInfo.Quality - aRewardInfo.Quality);
	}

	// Token: 0x06010080 RID: 65664 RVA: 0x003E8C8E File Offset: 0x003E6E8E
	public void Clear()
	{
	}

	// Token: 0x040076A8 RID: 30376
	public List<ItemRewardInfo> WaitList = new List<ItemRewardInfo>();
}
