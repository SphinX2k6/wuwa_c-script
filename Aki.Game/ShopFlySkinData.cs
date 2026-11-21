using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F9B RID: 8091
[NullableContext(1)]
[Nullable(0)]
public class ShopFlySkinData
{
	// Token: 0x0601406B RID: 82027 RVA: 0x005D543B File Offset: 0x005D363B
	public static ShopFlySkinData Create(PayShopGoods data)
	{
		ShopFlySkinData shopFlySkinData = new ShopFlySkinData();
		shopFlySkinData.InitData(data);
		return shopFlySkinData;
	}

	// Token: 0x0601406C RID: 82028 RVA: 0x005D544C File Offset: 0x005D364C
	public void InitData(PayShopGoods data)
	{
		this.PayShopGoods = data;
		this.OtherRewardMap.Clear();
		GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(data.GetPackageRewardId());
		if (giftPackageConfig != null)
		{
			Dictionary<int, int> dictionary = giftPackageConfig.Value.Content();
			int count = dictionary.Count;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.FlySkinItem)
				{
					FlySkinConfig? flySkinConfig = SkinConfig.Instance.GetFlySkinConfig(key);
					if (flySkinConfig != null)
					{
						if (flySkinConfig.Value.SkinType == 0)
						{
							this.SoarWingSkinId = new int?(key);
						}
						else
						{
							this.ParaglidingSkinId = new int?(key);
						}
					}
				}
				else
				{
					this.OtherRewardMap.Add(key, keyValuePair.Value);
				}
			}
		}
	}

	// Token: 0x0601406D RID: 82029 RVA: 0x005D5558 File Offset: 0x005D3758
	public bool GetIfCanBuy()
	{
		if (!this.GetPayShopGoods().IfCanBuy())
		{
			return false;
		}
		if (this.GetPayShopGoods().GetGoodsData() != null && this.GetPayShopGoods().GetGoodsData().HasBuyLimit())
		{
			PayShopGoodsData goodsData = this.GetPayShopGoods().GetGoodsData();
			if (goodsData != null && goodsData.GetRemainingCount() == 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601406E RID: 82030 RVA: 0x005D55B2 File Offset: 0x005D37B2
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x0601406F RID: 82031 RVA: 0x005D55BA File Offset: 0x005D37BA
	public int GetItemId()
	{
		return this.SoarWingSkinId.Value;
	}

	// Token: 0x06014070 RID: 82032 RVA: 0x005D55C7 File Offset: 0x005D37C7
	public int GetSoarWingSkinId()
	{
		return this.SoarWingSkinId.Value;
	}

	// Token: 0x06014071 RID: 82033 RVA: 0x005D55D4 File Offset: 0x005D37D4
	public int GetParaglidingSkinId()
	{
		return this.ParaglidingSkinId.Value;
	}

	// Token: 0x06014072 RID: 82034 RVA: 0x005D55E4 File Offset: 0x005D37E4
	public List<TItem> GetAllReward()
	{
		List<TItem> list = new List<TItem>();
		InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(this.GetSoarWingSkinId(), 0);
		TItem item = new TItem(itemData, 1);
		list.Add(item);
		itemData = new InventoryDefine.GetItemData(this.GetParaglidingSkinId(), 0);
		item = new TItem(itemData, 1);
		list.Add(item);
		list.AddRange(this.GetOtherReward());
		return list;
	}

	// Token: 0x06014073 RID: 82035 RVA: 0x005D563C File Offset: 0x005D383C
	public List<TItem> GetOtherReward()
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in this.OtherRewardMap)
		{
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
			TItem item = new TItem(itemData, keyValuePair.Value);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06014074 RID: 82036 RVA: 0x005D56B4 File Offset: 0x005D38B4
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06014075 RID: 82037 RVA: 0x005D56BC File Offset: 0x005D38BC
	public string GetDiscountText()
	{
		PayShopGoods currentGoodsData = this.GetCurrentGoodsData();
		if (!currentGoodsData.HasDiscount())
		{
			return "";
		}
		int discount = currentGoodsData.GetDiscount();
		if (discount > 0)
		{
			return StringUtils.Format("-{0}%", new string[]
			{
				discount.ToString()
			});
		}
		return "";
	}

	// Token: 0x06014076 RID: 82038 RVA: 0x005D570C File Offset: 0x005D390C
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		PayShopGoods currentGoodsData = this.GetCurrentGoodsData();
		if (!currentGoodsData.HasDiscount())
		{
			return null;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = currentGoodsData.GetCountDownData();
		if (countDownData.Item1 == EPayCountTimeType.Discount)
		{
			return countDownData.Item2;
		}
		return null;
	}

	// Token: 0x06014077 RID: 82039 RVA: 0x005D5742 File Offset: 0x005D3942
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06014078 RID: 82040 RVA: 0x005D574F File Offset: 0x005D394F
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x06014079 RID: 82041 RVA: 0x005D575C File Offset: 0x005D395C
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0601407A RID: 82042 RVA: 0x005D5769 File Offset: 0x005D3969
	public FlySkinData GetFlySkinData()
	{
		return FlySkinModel.Instance.GetFlySkinData(this.GetItemId());
	}

	// Token: 0x0601407B RID: 82043 RVA: 0x005D577B File Offset: 0x005D397B
	public string GetPreviewTextureInPayShop()
	{
		return this.GetFlySkinData().GetPreviewTextureInPayShop();
	}

	// Token: 0x0601407C RID: 82044 RVA: 0x005D5788 File Offset: 0x005D3988
	public string GetPreviewTextureInPop()
	{
		return this.GetFlySkinData().GetPreviewTextureInPop();
	}

	// Token: 0x0400AA7F RID: 43647
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400AA80 RID: 43648
	private int? SoarWingSkinId;

	// Token: 0x0400AA81 RID: 43649
	private int? ParaglidingSkinId;

	// Token: 0x0400AA82 RID: 43650
	private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
}
