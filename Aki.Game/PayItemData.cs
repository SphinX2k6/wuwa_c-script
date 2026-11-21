using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x020017FF RID: 6143
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayItemData : PayShopUnionData<PayItemData>
{
	// Token: 0x0600F0D6 RID: 61654 RVA: 0x0046C1F4 File Offset: 0x0046A3F4
	public PayItemData()
	{
		this.CachePayShopItemBaseSt = null;
		this.PayId = 0;
		this.Amount = "";
		this.ProductId = "";
		this.PayItemId = 0;
		this.ItemId = 0;
		this.ItemCount = 0;
		this.BonusItemCount = 0;
		this.SpecialBonusItemCount = 0;
		this.CanSpecialBonus = false;
		this.StageImage = "";
		this.DisclaimerText = "";
	}

	// Token: 0x0600F0D7 RID: 61655 RVA: 0x0046C26C File Offset: 0x0046A46C
	public void Phrase(PayItemInfo payItem)
	{
		this.PayId = payItem.PayId;
		this.Amount = payItem.Amount;
		this.ProductId = payItem.ProductId;
		this.PayItemId = payItem.Id;
		this.ItemId = payItem.ItemId;
		this.ItemCount = payItem.ItemCount;
		this.ShopItemQuality = payItem.Quality;
		this.BonusItemCount = payItem.BonusItemCount;
		this.SpecialBonusItemCount = payItem.SpecialBonusItemCount;
		this.StageImage = payItem.StageImage;
		RechargeModel.Instance.SetRechargeInfo(this.PayId, this.Amount.ToString(), this.ProductId);
		this.CanSpecialBonus = payItem.CanSpecialBonus;
		this.DisclaimerText = payItem.ComplianceDetail;
		this.CachePayShopItemBaseSt = new PayShopItemBaseSt();
		this.CachePayShopItemBaseSt.PhrasePromPayItemData(this);
	}

	// Token: 0x0600F0D8 RID: 61656 RVA: 0x0046C341 File Offset: 0x0046A541
	[NullableContext(2)]
	public PayShopItemBaseSt ConvertPayItemDataToPayShopItemBaseSt()
	{
		PayShopItemBaseSt cachePayShopItemBaseSt = this.CachePayShopItemBaseSt;
		if (cachePayShopItemBaseSt != null)
		{
			cachePayShopItemBaseSt.Refresh(this);
		}
		return this.CachePayShopItemBaseSt;
	}

	// Token: 0x0600F0D9 RID: 61657 RVA: 0x0046C35C File Offset: 0x0046A55C
	public string GetPayItemShowName()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(this.ItemId).Name, null);
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("GoodsName"), null), new string[]
		{
			localTextNew,
			this.ItemCount.ToString()
		});
	}

	// Token: 0x0600F0DA RID: 61658 RVA: 0x0046C3B8 File Offset: 0x0046A5B8
	public string GetDirectPriceText()
	{
		KuroSdkModel instance = KuroSdkModel.Instance;
		string text = (instance != null) ? instance.GetQueryProductShowPrice(this.PayId.ToString()) : null;
		if (text != null)
		{
			return text;
		}
		return PayItemConfig.Instance.GetPayShow(this.PayId);
	}

	// Token: 0x0600F0DB RID: 61659 RVA: 0x0046C3F8 File Offset: 0x0046A5F8
	public bool GetIfCanShow()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		return !((platformSdk != null) ? new bool?(platformSdk.NeedConfirmSdkProductInfo()) : null).GetValueOrDefault() || PayItemModel.Instance.GetProductInfoByGoodsId(this.ProductId) != null;
	}

	// Token: 0x0600F0DC RID: 61660 RVA: 0x0046C448 File Offset: 0x0046A648
	public double GetGachaAverageCount()
	{
		int rechargeItemRate = PayItemConfig.Instance.GetRechargeItemRate();
		if (rechargeItemRate <= 0)
		{
			return 0.0;
		}
		return Math.Floor((double)(this.GetRewardItemCount() / (float)rechargeItemRate * 10f)) / 10.0;
	}

	// Token: 0x0600F0DD RID: 61661 RVA: 0x0046C490 File Offset: 0x0046A690
	public string GetGachaAveragePriceText()
	{
		double num = Math.Floor((double)(PayItemConfig.Instance.GetPayConf(this.PayId).Value.Amount * 10000f)) / 10000.0;
		int rechargeItemRate = PayItemConfig.Instance.GetRechargeItemRate();
		double value = Math.Ceiling(num / (double)(this.GetRewardItemCount() / (float)rechargeItemRate) * 100.0) / 100.0;
		string regionMainCurrency = PayItemConfig.Instance.GetRegionMainCurrency();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(value);
		defaultInterpolatedStringHandler.AppendFormatted(regionMainCurrency);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600F0DE RID: 61662 RVA: 0x0046C52F File Offset: 0x0046A72F
	private float GetRewardItemCount()
	{
		if (this.CanSpecialBonus)
		{
			return (float)(this.ItemCount + this.SpecialBonusItemCount);
		}
		return (float)(this.ItemCount + this.BonusItemCount);
	}

	// Token: 0x0600F0DF RID: 61663 RVA: 0x0046C556 File Offset: 0x0046A756
	public bool GetIfShowTotalTopUpScore()
	{
		return TotalTopUpController.Instance.GetRechargeItemScore(this.PayItemId) > 0;
	}

	// Token: 0x0600F0E0 RID: 61664 RVA: 0x0046C56C File Offset: 0x0046A76C
	public int GetQuality()
	{
		if (this.ShopItemQuality > 0)
		{
			return this.ShopItemQuality;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
		if (itemConfigData != null)
		{
			return itemConfigData.QualityId;
		}
		return 0;
	}

	// Token: 0x0600F0E1 RID: 61665 RVA: 0x0046C5A5 File Offset: 0x0046A7A5
	public EItemQualityType GetQualityType()
	{
		if (this.ShopItemQuality > 0)
		{
			return EItemQualityType.PayShop;
		}
		return EItemQualityType.Item;
	}

	// Token: 0x040087FC RID: 34812
	[Nullable(2)]
	private PayShopItemBaseSt CachePayShopItemBaseSt;

	// Token: 0x040087FD RID: 34813
	private int PayId;

	// Token: 0x040087FE RID: 34814
	public string Amount;

	// Token: 0x040087FF RID: 34815
	public string ProductId;

	// Token: 0x04008800 RID: 34816
	public int PayItemId;

	// Token: 0x04008801 RID: 34817
	public int ItemId;

	// Token: 0x04008802 RID: 34818
	public int ItemCount;

	// Token: 0x04008803 RID: 34819
	public int ShopItemQuality;

	// Token: 0x04008804 RID: 34820
	public int BonusItemCount;

	// Token: 0x04008805 RID: 34821
	public int SpecialBonusItemCount;

	// Token: 0x04008806 RID: 34822
	public bool CanSpecialBonus;

	// Token: 0x04008807 RID: 34823
	public string StageImage;

	// Token: 0x04008808 RID: 34824
	public string DisclaimerText;
}
