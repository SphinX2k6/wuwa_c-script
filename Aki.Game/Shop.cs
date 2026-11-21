using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001F6A RID: 8042
[NullableContext(1)]
[Nullable(0)]
public class Shop
{
	// Token: 0x17001E15 RID: 7701
	// (get) Token: 0x06013E41 RID: 81473 RVA: 0x005CC8B5 File Offset: 0x005CAAB5
	public uint UpdateTime
	{
		get
		{
			return this.InnerUpdateTime;
		}
	}

	// Token: 0x06013E42 RID: 81474 RVA: 0x005CC8BD File Offset: 0x005CAABD
	public Shop(ShopInfo shopInfo)
	{
		this.InnerUpdateTime = shopInfo.UpdateTime;
		this.ItemList = new Dictionary<int, ShopItemInfoNew>();
		this.UpdateShopItemList(shopInfo.ItemInfoList);
	}

	// Token: 0x06013E43 RID: 81475 RVA: 0x005CC8E8 File Offset: 0x005CAAE8
	public void UpdateRefreshTime(uint refreshTime)
	{
		this.InnerUpdateTime = refreshTime;
	}

	// Token: 0x06013E44 RID: 81476 RVA: 0x005CC8F4 File Offset: 0x005CAAF4
	public void UpdateShopItemList(IEnumerable<ShopItemInfoNew> itemInfoList)
	{
		this.ItemList.Clear();
		foreach (ShopItemInfoNew shopItemInfoNew in itemInfoList)
		{
			this.ItemList[shopItemInfoNew.Id] = shopItemInfoNew;
		}
	}

	// Token: 0x06013E45 RID: 81477 RVA: 0x005CC954 File Offset: 0x005CAB54
	[NullableContext(2)]
	public ShopItemInfoNew GetItemInfo(int id)
	{
		ShopItemInfoNew result;
		if (this.ItemList.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06013E46 RID: 81478 RVA: 0x005CC974 File Offset: 0x005CAB74
	public Dictionary<int, ShopItemInfoNew> GetItemList()
	{
		return this.ItemList;
	}

	// Token: 0x0400A984 RID: 43396
	private uint InnerUpdateTime;

	// Token: 0x0400A985 RID: 43397
	private readonly Dictionary<int, ShopItemInfoNew> ItemList;
}
