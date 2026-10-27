using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A20 RID: 10784
[NullableContext(1)]
[Nullable(0)]
public class ShopFlySkinData
{
	// Token: 0x06016665 RID: 91749 RVA: 0x005AA45F File Offset: 0x005A865F
	public static ShopFlySkinData Create(PayShopGoods data)
	{
		ShopFlySkinData shopFlySkinData = new ShopFlySkinData();
		shopFlySkinData.InitData(data);
		return shopFlySkinData;
	}

	// Token: 0x06016666 RID: 91750 RVA: 0x005AA470 File Offset: 0x005A8670
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

	// Token: 0x06016667 RID: 91751 RVA: 0x005AA57C File Offset: 0x005A877C
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

	// Token: 0x06016668 RID: 91752 RVA: 0x005AA5D6 File Offset: 0x005A87D6
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06016669 RID: 91753 RVA: 0x005AA5DE File Offset: 0x005A87DE
	public int GetItemId()
	{
		return this.SoarWingSkinId.Value;
	}

	// Token: 0x0601666A RID: 91754 RVA: 0x005AA5EB File Offset: 0x005A87EB
	public int GetSoarWingSkinId()
	{
		return this.SoarWingSkinId.Value;
	}

	// Token: 0x0601666B RID: 91755 RVA: 0x005AA5F8 File Offset: 0x005A87F8
	public int GetParaglidingSkinId()
	{
		return this.ParaglidingSkinId.Value;
	}

	// Token: 0x0601666C RID: 91756 RVA: 0x005AA608 File Offset: 0x005A8808
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

	// Token: 0x0601666D RID: 91757 RVA: 0x005AA660 File Offset: 0x005A8860
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

	// Token: 0x0601666E RID: 91758 RVA: 0x005AA6D8 File Offset: 0x005A88D8
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x0601666F RID: 91759 RVA: 0x005AA6E0 File Offset: 0x005A88E0
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

	// Token: 0x06016670 RID: 91760 RVA: 0x005AA730 File Offset: 0x005A8930
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

	// Token: 0x06016671 RID: 91761 RVA: 0x005AA766 File Offset: 0x005A8966
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06016672 RID: 91762 RVA: 0x005AA773 File Offset: 0x005A8973
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x06016673 RID: 91763 RVA: 0x005AA780 File Offset: 0x005A8980
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x06016674 RID: 91764 RVA: 0x005AA78D File Offset: 0x005A898D
	public FlySkinData GetFlySkinData()
	{
		return FlySkinModel.Instance.GetFlySkinData(this.GetItemId());
	}

	// Token: 0x06016675 RID: 91765 RVA: 0x005AA79F File Offset: 0x005A899F
	public string GetPreviewTextureInPayShop()
	{
		return this.GetFlySkinData().GetPreviewTextureInPayShop();
	}

	// Token: 0x06016676 RID: 91766 RVA: 0x005AA7AC File Offset: 0x005A89AC
	public string GetPreviewTextureInPop()
	{
		return this.GetFlySkinData().GetPreviewTextureInPop();
	}

	// Token: 0x0400A696 RID: 42646
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400A697 RID: 42647
	private int? SoarWingSkinId;

	// Token: 0x0400A698 RID: 42648
	private int? ParaglidingSkinId;

	// Token: 0x0400A699 RID: 42649
	private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
}
