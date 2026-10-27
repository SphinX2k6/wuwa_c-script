using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020029EF RID: 10735
[NullableContext(1)]
[Nullable(0)]
public class Shop
{
	// Token: 0x17001DBC RID: 7612
	// (get) Token: 0x0601643A RID: 91194 RVA: 0x005A18C1 File Offset: 0x0059FAC1
	public uint UpdateTime
	{
		get
		{
			return this.InnerUpdateTime;
		}
	}

	// Token: 0x0601643B RID: 91195 RVA: 0x005A18C9 File Offset: 0x0059FAC9
	public Shop(ShopInfo shopInfo)
	{
		this.InnerUpdateTime = shopInfo.UpdateTime;
		this.ItemList = new Dictionary<int, ShopItemInfoNew>();
		this.UpdateShopItemList(shopInfo.ItemInfoList.ToList<ShopItemInfoNew>());
	}

	// Token: 0x0601643C RID: 91196 RVA: 0x005A18F9 File Offset: 0x0059FAF9
	public void UpdateRefreshTime(uint refreshTime)
	{
		this.InnerUpdateTime = refreshTime;
	}

	// Token: 0x0601643D RID: 91197 RVA: 0x005A1904 File Offset: 0x0059FB04
	public void UpdateShopItemList(List<ShopItemInfoNew> itemInfoList)
	{
		this.ItemList.Clear();
		foreach (ShopItemInfoNew shopItemInfoNew in itemInfoList)
		{
			this.ItemList[shopItemInfoNew.Id] = shopItemInfoNew;
		}
	}

	// Token: 0x0601643E RID: 91198 RVA: 0x005A1968 File Offset: 0x0059FB68
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

	// Token: 0x0601643F RID: 91199 RVA: 0x005A1988 File Offset: 0x0059FB88
	public Dictionary<int, ShopItemInfoNew> GetItemList()
	{
		return this.ItemList;
	}

	// Token: 0x0400A59A RID: 42394
	private uint InnerUpdateTime;

	// Token: 0x0400A59B RID: 42395
	private readonly Dictionary<int, ShopItemInfoNew> ItemList;
}
