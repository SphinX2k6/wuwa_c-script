using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x0200231A RID: 8986
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayItemData : PayShopUnionData<PayItemData>
{
	// Token: 0x06011C26 RID: 72742 RVA: 0x0045F190 File Offset: 0x0045D390
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

	// Token: 0x06011C27 RID: 72743 RVA: 0x0045F208 File Offset: 0x0045D408
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

	// Token: 0x06011C28 RID: 72744 RVA: 0x0045F2DD File Offset: 0x0045D4DD
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

	// Token: 0x06011C29 RID: 72745 RVA: 0x0045F2F8 File Offset: 0x0045D4F8
	public string GetPayItemShowName()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(this.ItemId).Name, null);
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("GoodsName"), null), new string[]
		{
			localTextNew,
			this.ItemCount.ToString()
		});
	}

	// Token: 0x06011C2A RID: 72746 RVA: 0x0045F354 File Offset: 0x0045D554
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

	// Token: 0x06011C2B RID: 72747 RVA: 0x0045F394 File Offset: 0x0045D594
	public bool GetIfCanShow()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		return !((platformSdk != null) ? new bool?(platformSdk.NeedConfirmSdkProductInfo()) : null).GetValueOrDefault() || PayItemModel.Instance.GetProductInfoByGoodsId(this.ProductId) != null;
	}

	// Token: 0x06011C2C RID: 72748 RVA: 0x0045F3E4 File Offset: 0x0045D5E4
	public double GetGachaAverageCount()
	{
		int rechargeItemRate = PayItemConfig.Instance.GetRechargeItemRate();
		if (rechargeItemRate <= 0)
		{
			return 0.0;
		}
		return Math.Floor((double)(this.GetRewardItemCount() / (float)rechargeItemRate * 10f)) / 10.0;
	}

	// Token: 0x06011C2D RID: 72749 RVA: 0x0045F42C File Offset: 0x0045D62C
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

	// Token: 0x06011C2E RID: 72750 RVA: 0x0045F4CB File Offset: 0x0045D6CB
	private float GetRewardItemCount()
	{
		if (this.CanSpecialBonus)
		{
			return (float)(this.ItemCount + this.SpecialBonusItemCount);
		}
		return (float)(this.ItemCount + this.BonusItemCount);
	}

	// Token: 0x06011C2F RID: 72751 RVA: 0x0045F4F2 File Offset: 0x0045D6F2
	public bool GetIfShowTotalTopUpScore()
	{
		return TotalTopUpController.Instance.GetRechargeItemScore(this.PayItemId) > 0;
	}

	// Token: 0x06011C30 RID: 72752 RVA: 0x0045F508 File Offset: 0x0045D708
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

	// Token: 0x06011C31 RID: 72753 RVA: 0x0045F541 File Offset: 0x0045D741
	public EItemQualityType GetQualityType()
	{
		if (this.ShopItemQuality > 0)
		{
			return EItemQualityType.PayShop;
		}
		return EItemQualityType.Item;
	}

	// Token: 0x040086B9 RID: 34489
	[Nullable(2)]
	private PayShopItemBaseSt CachePayShopItemBaseSt;

	// Token: 0x040086BA RID: 34490
	private int PayId;

	// Token: 0x040086BB RID: 34491
	public string Amount;

	// Token: 0x040086BC RID: 34492
	public string ProductId;

	// Token: 0x040086BD RID: 34493
	public int PayItemId;

	// Token: 0x040086BE RID: 34494
	public int ItemId;

	// Token: 0x040086BF RID: 34495
	public int ItemCount;

	// Token: 0x040086C0 RID: 34496
	public int ShopItemQuality;

	// Token: 0x040086C1 RID: 34497
	public int BonusItemCount;

	// Token: 0x040086C2 RID: 34498
	public int SpecialBonusItemCount;

	// Token: 0x040086C3 RID: 34499
	public bool CanSpecialBonus;

	// Token: 0x040086C4 RID: 34500
	public string StageImage;

	// Token: 0x040086C5 RID: 34501
	public string DisclaimerText;
}
