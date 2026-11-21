using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001F9C RID: 8092
[NullableContext(1)]
[Nullable(0)]
public class ShopMotorSkinData
{
	// Token: 0x0601407E RID: 82046 RVA: 0x005D57A8 File Offset: 0x005D39A8
	public static ShopMotorSkinData Create(PayShopGoods data)
	{
		ShopMotorSkinData shopMotorSkinData = new ShopMotorSkinData();
		shopMotorSkinData.InitData(data);
		return shopMotorSkinData;
	}

	// Token: 0x0601407F RID: 82047 RVA: 0x005D57B8 File Offset: 0x005D39B8
	public void InitData(PayShopGoods data)
	{
		this.PayShopGoods = data;
		this.MainRewardMap.Clear();
		GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(data.GetPackageRewardId());
		if (giftPackageConfig != null)
		{
			this.GiftPackageId = data.GetPackageRewardId();
			MotorSkinShow? motorSkinShowConfig = SkinConfig.Instance.GetMotorSkinShowConfig(this.GiftPackageId);
			if (motorSkinShowConfig != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
				{
					int key = keyValuePair.Key;
					if (key == motorSkinShowConfig.Value.FreeItem)
					{
						this.OtherReward = new global::ItemData
						{
							ItemId = key,
							Count = keyValuePair.Value
						};
					}
					else
					{
						this.MainRewardMap[key] = keyValuePair.Value;
					}
				}
			}
		}
	}

	// Token: 0x06014080 RID: 82048 RVA: 0x005D58BC File Offset: 0x005D3ABC
	public bool GetIfCanBuy()
	{
		if (!this.GetPayShopGoods().IfCanBuy())
		{
			return false;
		}
		PayShopGoodsData goodsData = this.GetPayShopGoods().GetGoodsData();
		if (goodsData != null && goodsData.HasBuyLimit())
		{
			PayShopGoodsData goodsData2 = this.GetPayShopGoods().GetGoodsData();
			if (goodsData2 != null && goodsData2.GetRemainingCount() == 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014081 RID: 82049 RVA: 0x005D5910 File Offset: 0x005D3B10
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06014082 RID: 82050 RVA: 0x005D5918 File Offset: 0x005D3B18
	public int GetItemId()
	{
		return this.PayShopGoods.GetPackageRewardId();
	}

	// Token: 0x06014083 RID: 82051 RVA: 0x005D5928 File Offset: 0x005D3B28
	public List<TItem> GetAllReward()
	{
		List<TItem> list = new List<TItem>();
		list.AddRange(this.GetMainReward());
		if (this.OtherReward != null)
		{
			list.Add(new TItem(new InventoryDefine.GetItemData(this.OtherReward.ItemId, 0), this.OtherReward.Count));
		}
		return list;
	}

	// Token: 0x06014084 RID: 82052 RVA: 0x005D5978 File Offset: 0x005D3B78
	public List<TItem> GetMainReward()
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in this.MainRewardMap)
		{
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
			TItem item = new TItem(itemData, keyValuePair.Value);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06014085 RID: 82053 RVA: 0x005D59F0 File Offset: 0x005D3BF0
	public TItem? GetOtherReward()
	{
		if (this.OtherReward == null)
		{
			return null;
		}
		return new TItem?(new TItem(new InventoryDefine.GetItemData(this.OtherReward.ItemId, 0), this.OtherReward.Count));
	}

	// Token: 0x06014086 RID: 82054 RVA: 0x005D5A35 File Offset: 0x005D3C35
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06014087 RID: 82055 RVA: 0x005D5A40 File Offset: 0x005D3C40
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

	// Token: 0x06014088 RID: 82056 RVA: 0x005D5A90 File Offset: 0x005D3C90
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

	// Token: 0x06014089 RID: 82057 RVA: 0x005D5AC6 File Offset: 0x005D3CC6
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x0601408A RID: 82058 RVA: 0x005D5AD3 File Offset: 0x005D3CD3
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x0601408B RID: 82059 RVA: 0x005D5AE0 File Offset: 0x005D3CE0
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0601408C RID: 82060 RVA: 0x005D5AED File Offset: 0x005D3CED
	public MotorSkinData GetMotorSkinData()
	{
		return new MotorSkinData(this.GiftPackageId);
	}

	// Token: 0x0400AA83 RID: 43651
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400AA84 RID: 43652
	private readonly Dictionary<int, int> MainRewardMap = new Dictionary<int, int>();

	// Token: 0x0400AA85 RID: 43653
	private int GiftPackageId;

	// Token: 0x0400AA86 RID: 43654
	[Nullable(2)]
	private global::IItemData OtherReward;
}
