using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020029F0 RID: 10736
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShopModel : ModelBase
{
	// Token: 0x17001DBD RID: 7613
	// (get) Token: 0x06016440 RID: 91200 RVA: 0x005A1990 File Offset: 0x0059FB90
	// (set) Token: 0x06016441 RID: 91201 RVA: 0x005A1998 File Offset: 0x0059FB98
	public string VersionId
	{
		get
		{
			return this.Version;
		}
		set
		{
			this.Version = value;
		}
	}

	// Token: 0x06016442 RID: 91202 RVA: 0x005A19A1 File Offset: 0x0059FBA1
	protected override bool OnInit()
	{
		this.ShopList = new Dictionary<int, Shop>();
		return true;
	}

	// Token: 0x06016443 RID: 91203 RVA: 0x005A19B0 File Offset: 0x0059FBB0
	[NullableContext(2)]
	public Shop GetShopInfo(int shopId)
	{
		if (this.ShopList == null)
		{
			return null;
		}
		Shop result;
		if (this.ShopList.TryGetValue(shopId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06016444 RID: 91204 RVA: 0x005A19DC File Offset: 0x0059FBDC
	[NullableContext(2)]
	public ShopItemInfoNew GetShopItem(int shopId, int id)
	{
		Shop shopInfo = this.GetShopInfo(shopId);
		if (shopInfo == null)
		{
			return null;
		}
		return shopInfo.GetItemInfo(id);
	}

	// Token: 0x06016445 RID: 91205 RVA: 0x005A19FD File Offset: 0x0059FBFD
	public Aki.Config.ShopInfo? GetShopConfig(int shopId)
	{
		return new Aki.Config.ShopInfo?(ShopConfig.Instance.GetShopInfoConfig(shopId));
	}

	// Token: 0x06016446 RID: 91206 RVA: 0x005A1A10 File Offset: 0x0059FC10
	public void UpdateShopListData(List<Aki.Protocol.ShopInfo> shopInfoList)
	{
		foreach (Aki.Protocol.ShopInfo shopInfo in shopInfoList)
		{
			this.UpdateShopData(shopInfo);
		}
	}

	// Token: 0x06016447 RID: 91207 RVA: 0x005A1A60 File Offset: 0x0059FC60
	public void UpdateShopData(Aki.Protocol.ShopInfo shopInfo)
	{
		Shop shop = this.GetShopInfo(shopInfo.ShopId);
		if (shop == null)
		{
			shop = new Shop(shopInfo);
			this.ShopList.Add(shopInfo.ShopId, shop);
		}
		else
		{
			shop.UpdateRefreshTime(shopInfo.UpdateTime);
			shop.UpdateShopItemList(shopInfo.ItemInfoList.ToList<ShopItemInfoNew>());
		}
		EventSystem.Instance.Emit<int?>(EEventName.ShopUpdate, new int?(shopInfo.ShopId));
	}

	// Token: 0x06016448 RID: 91208 RVA: 0x005A1AD0 File Offset: 0x0059FCD0
	public void UpdateItemData(ShopBuyResponse shopBuyResponse)
	{
		ShopItemInfoNew shopItem = this.GetShopItem(shopBuyResponse.ShopId, shopBuyResponse.Id);
		if (shopItem == null)
		{
			return;
		}
		shopItem.BoughtCount = shopBuyResponse.BoughtCount;
	}

	// Token: 0x06016449 RID: 91209 RVA: 0x005A1B00 File Offset: 0x0059FD00
	public bool IsOpen(int shopId)
	{
		Aki.Config.ShopInfo? shopConfig = this.GetShopConfig(shopId);
		return shopConfig != null && FunctionModel.Instance.IsOpen(shopConfig.Value.OpenId);
	}

	// Token: 0x0601644A RID: 91210 RVA: 0x005A1B3C File Offset: 0x0059FD3C
	public List<ShopItemFullInfo> GetShopItemList(int shopId)
	{
		this.GetShopInfo(shopId);
		Shop shopInfo = this.GetShopInfo(shopId);
		List<ShopItemFullInfo> list = new List<ShopItemFullInfo>();
		if (shopInfo == null)
		{
			return list;
		}
		foreach (KeyValuePair<int, ShopItemInfoNew> keyValuePair in shopInfo.GetItemList())
		{
			ShopItemInfoNew value = keyValuePair.Value;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(value.ItemId);
			if (itemConfigData != null)
			{
				ShopItemFullInfo item = new ShopItemFullInfo(itemConfigData, value, shopId);
				list.Add(item);
			}
		}
		list.Sort(delegate(ShopItemFullInfo a, ShopItemFullInfo b)
		{
			if (a.IsOutOfStock() != b.IsOutOfStock())
			{
				if (!a.IsOutOfStock())
				{
					return -1;
				}
				return 1;
			}
			else if (a.IsInteractive() != b.IsInteractive())
			{
				if (!a.IsInteractive())
				{
					return 1;
				}
				return -1;
			}
			else if (a.IsUnlocked() != b.IsUnlocked())
			{
				if (!a.IsUnlocked())
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.SortIndex != b.SortIndex)
				{
					return a.SortIndex - b.SortIndex;
				}
				return a.Id.CompareTo(b.Id);
			}
		});
		return list;
	}

	// Token: 0x0601644B RID: 91211 RVA: 0x005A1C00 File Offset: 0x0059FE00
	[NullableContext(2)]
	public ShopItemFullInfo GetShopItemFullInfoByShopIdAndItemId(int shopId, int itemId)
	{
		foreach (ShopItemFullInfo shopItemFullInfo in this.GetShopItemList(shopId))
		{
			if (shopItemFullInfo.Id == itemId)
			{
				return shopItemFullInfo;
			}
		}
		return null;
	}

	// Token: 0x17001DBE RID: 7614
	// (get) Token: 0x0601644C RID: 91212 RVA: 0x005A1C60 File Offset: 0x0059FE60
	public static ShopModel Instance
	{
		get
		{
			return ShopModel._Instance;
		}
	}

	// Token: 0x0601644D RID: 91213 RVA: 0x005A1C67 File Offset: 0x0059FE67
	public static ShopModel GetOrCreateInstance()
	{
		if (ShopModel._Instance == null)
		{
			ShopModel.CreateInstance();
		}
		return ShopModel._Instance;
	}

	// Token: 0x0601644E RID: 91214 RVA: 0x005A1C7B File Offset: 0x0059FE7B
	public static bool CreateInstance()
	{
		if (ShopModel._Instance != null)
		{
			return true;
		}
		ShopModel._Instance = new ShopModel();
		return true;
	}

	// Token: 0x0601644F RID: 91215 RVA: 0x005A1C91 File Offset: 0x0059FE91
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016450 RID: 91216 RVA: 0x005A1C93 File Offset: 0x0059FE93
	public static void ResetStaticDefaultValue()
	{
		ShopModel._Instance = null;
	}

	// Token: 0x06016451 RID: 91217 RVA: 0x005A1C9B File Offset: 0x0059FE9B
	static ShopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopModel.CreateStaticDefaultValue), new Action(ShopModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A59C RID: 42396
	[Nullable(2)]
	public ShopItemFullInfo OpenItemInfo;

	// Token: 0x0400A59D RID: 42397
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Shop> ShopList;

	// Token: 0x0400A59E RID: 42398
	private string Version = "";

	// Token: 0x0400A59F RID: 42399
	public int InteractTarget;

	// Token: 0x0400A5A0 RID: 42400
	public long? CurrentInteractCreatureDataLongId;

	// Token: 0x0400A5A1 RID: 42401
	[Nullable(2)]
	private static ShopModel _Instance;
}
