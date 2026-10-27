using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A21 RID: 10785
[NullableContext(1)]
[Nullable(0)]
public class ShopMotorSkinData
{
	// Token: 0x06016678 RID: 91768 RVA: 0x005AA7CC File Offset: 0x005A89CC
	public static ShopMotorSkinData Create(PayShopGoods data)
	{
		ShopMotorSkinData shopMotorSkinData = new ShopMotorSkinData();
		shopMotorSkinData.InitData(data);
		return shopMotorSkinData;
	}

	// Token: 0x06016679 RID: 91769 RVA: 0x005AA7DC File Offset: 0x005A89DC
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

	// Token: 0x0601667A RID: 91770 RVA: 0x005AA8E0 File Offset: 0x005A8AE0
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

	// Token: 0x0601667B RID: 91771 RVA: 0x005AA934 File Offset: 0x005A8B34
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x0601667C RID: 91772 RVA: 0x005AA93C File Offset: 0x005A8B3C
	public int GetItemId()
	{
		return this.PayShopGoods.GetPackageRewardId();
	}

	// Token: 0x0601667D RID: 91773 RVA: 0x005AA94C File Offset: 0x005A8B4C
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

	// Token: 0x0601667E RID: 91774 RVA: 0x005AA99C File Offset: 0x005A8B9C
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

	// Token: 0x0601667F RID: 91775 RVA: 0x005AAA14 File Offset: 0x005A8C14
	public TItem? GetOtherReward()
	{
		if (this.OtherReward == null)
		{
			return null;
		}
		return new TItem?(new TItem(new InventoryDefine.GetItemData(this.OtherReward.ItemId, 0), this.OtherReward.Count));
	}

	// Token: 0x06016680 RID: 91776 RVA: 0x005AAA59 File Offset: 0x005A8C59
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06016681 RID: 91777 RVA: 0x005AAA64 File Offset: 0x005A8C64
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

	// Token: 0x06016682 RID: 91778 RVA: 0x005AAAB4 File Offset: 0x005A8CB4
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

	// Token: 0x06016683 RID: 91779 RVA: 0x005AAAEA File Offset: 0x005A8CEA
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06016684 RID: 91780 RVA: 0x005AAAF7 File Offset: 0x005A8CF7
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x06016685 RID: 91781 RVA: 0x005AAB04 File Offset: 0x005A8D04
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x06016686 RID: 91782 RVA: 0x005AAB11 File Offset: 0x005A8D11
	public MotorSkinData GetMotorSkinData()
	{
		return new MotorSkinData(this.GiftPackageId);
	}

	// Token: 0x0400A69A RID: 42650
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400A69B RID: 42651
	private readonly Dictionary<int, int> MainRewardMap = new Dictionary<int, int>();

	// Token: 0x0400A69C RID: 42652
	private int GiftPackageId;

	// Token: 0x0400A69D RID: 42653
	[Nullable(2)]
	private global::IItemData OtherReward;
}
