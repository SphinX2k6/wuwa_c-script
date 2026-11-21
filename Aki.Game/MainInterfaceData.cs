using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014C8 RID: 5320
[NullableContext(1)]
[Nullable(0)]
public class MainInterfaceData
{
	// Token: 0x0600D4E5 RID: 54501 RVA: 0x003F5164 File Offset: 0x003F3364
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

	// Token: 0x0600D4E6 RID: 54502 RVA: 0x003F5210 File Offset: 0x003F3410
	public void AddItemRewardInfo(ItemRewardInfo addItem)
	{
		if (addItem == null)
		{
			return;
		}
		this.WaitList.Add(addItem);
	}

	// Token: 0x0600D4E7 RID: 54503 RVA: 0x003F5224 File Offset: 0x003F3424
	public void SortWaitList()
	{
		this.WaitList.RemoveAll((ItemRewardInfo x) => x == null);
		this.WaitList.Sort((ItemRewardInfo aRewardInfo, ItemRewardInfo bRewardInfo) => bRewardInfo.Quality - aRewardInfo.Quality);
	}

	// Token: 0x0600D4E8 RID: 54504 RVA: 0x003F5286 File Offset: 0x003F3486
	public void Clear()
	{
	}

	// Token: 0x04007791 RID: 30609
	public List<ItemRewardInfo> WaitList = new List<ItemRewardInfo>();
}
