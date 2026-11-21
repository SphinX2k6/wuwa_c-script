using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001F6B RID: 8043
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShopModel : ModelBase
{
	// Token: 0x17001E16 RID: 7702
	// (get) Token: 0x06013E47 RID: 81479 RVA: 0x005CC97C File Offset: 0x005CAB7C
	// (set) Token: 0x06013E48 RID: 81480 RVA: 0x005CC984 File Offset: 0x005CAB84
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

	// Token: 0x06013E49 RID: 81481 RVA: 0x005CC98D File Offset: 0x005CAB8D
	protected override bool OnInit()
	{
		this.ShopList = new Dictionary<int, Shop>();
		return true;
	}

	// Token: 0x06013E4A RID: 81482 RVA: 0x005CC99C File Offset: 0x005CAB9C
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

	// Token: 0x06013E4B RID: 81483 RVA: 0x005CC9C8 File Offset: 0x005CABC8
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

	// Token: 0x06013E4C RID: 81484 RVA: 0x005CC9E9 File Offset: 0x005CABE9
	public Aki.Config.ShopInfo? GetShopConfig(int shopId)
	{
		return new Aki.Config.ShopInfo?(ShopConfig.Instance.GetShopInfoConfig(shopId));
	}

	// Token: 0x06013E4D RID: 81485 RVA: 0x005CC9FC File Offset: 0x005CABFC
	public void UpdateShopListData(IEnumerable<Aki.Protocol.ShopInfo> shopInfoList)
	{
		foreach (Aki.Protocol.ShopInfo shopInfo in shopInfoList)
		{
			this.UpdateShopData(shopInfo);
		}
	}

	// Token: 0x06013E4E RID: 81486 RVA: 0x005CCA44 File Offset: 0x005CAC44
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
			shop.UpdateShopItemList(shopInfo.ItemInfoList);
		}
		EventSystem.Instance.Emit<int?>(EEventName.ShopUpdate, new int?(shopInfo.ShopId));
	}

	// Token: 0x06013E4F RID: 81487 RVA: 0x005CCAB0 File Offset: 0x005CACB0
	public void UpdateItemData(ShopBuyResponse shopBuyResponse)
	{
		ShopItemInfoNew shopItem = this.GetShopItem(shopBuyResponse.ShopId, shopBuyResponse.Id);
		if (shopItem == null)
		{
			return;
		}
		shopItem.BoughtCount = shopBuyResponse.BoughtCount;
	}

	// Token: 0x06013E50 RID: 81488 RVA: 0x005CCAE0 File Offset: 0x005CACE0
	public bool IsOpen(int shopId)
	{
		Aki.Config.ShopInfo? shopConfig = this.GetShopConfig(shopId);
		return shopConfig != null && FunctionModel.Instance.IsOpen(shopConfig.Value.OpenId);
	}

	// Token: 0x06013E51 RID: 81489 RVA: 0x005CCB1C File Offset: 0x005CAD1C
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

	// Token: 0x06013E52 RID: 81490 RVA: 0x005CCBE0 File Offset: 0x005CADE0
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

	// Token: 0x17001E17 RID: 7703
	// (get) Token: 0x06013E53 RID: 81491 RVA: 0x005CCC40 File Offset: 0x005CAE40
	public static ShopModel Instance
	{
		get
		{
			return ShopModel._Instance;
		}
	}

	// Token: 0x06013E54 RID: 81492 RVA: 0x005CCC47 File Offset: 0x005CAE47
	public static ShopModel GetOrCreateInstance()
	{
		if (ShopModel._Instance == null)
		{
			ShopModel.CreateInstance();
		}
		return ShopModel._Instance;
	}

	// Token: 0x06013E55 RID: 81493 RVA: 0x005CCC5B File Offset: 0x005CAE5B
	public static bool CreateInstance()
	{
		if (ShopModel._Instance != null)
		{
			return true;
		}
		ShopModel._Instance = new ShopModel();
		return true;
	}

	// Token: 0x06013E56 RID: 81494 RVA: 0x005CCC71 File Offset: 0x005CAE71
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013E57 RID: 81495 RVA: 0x005CCC73 File Offset: 0x005CAE73
	public static void ResetStaticDefaultValue()
	{
		ShopModel._Instance = null;
	}

	// Token: 0x06013E58 RID: 81496 RVA: 0x005CCC7B File Offset: 0x005CAE7B
	static ShopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopModel.CreateStaticDefaultValue), new Action(ShopModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A986 RID: 43398
	[Nullable(2)]
	public ShopItemFullInfo OpenItemInfo;

	// Token: 0x0400A987 RID: 43399
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Shop> ShopList;

	// Token: 0x0400A988 RID: 43400
	private string Version = "";

	// Token: 0x0400A989 RID: 43401
	public int InteractTarget;

	// Token: 0x0400A98A RID: 43402
	public long? CurrentInteractCreatureDataLongId;

	// Token: 0x0400A98B RID: 43403
	[Nullable(2)]
	private static ShopModel _Instance;
}
