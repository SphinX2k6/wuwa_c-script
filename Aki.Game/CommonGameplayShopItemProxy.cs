using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001824 RID: 6180
[NullableContext(1)]
[Nullable(0)]
public class CommonGameplayShopItemProxy : AbstractGameplayShopItemProxy
{
	// Token: 0x0600F2ED RID: 62189 RVA: 0x00473CD4 File Offset: 0x00471ED4
	public virtual void UpdatePriceData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		IPriceData priceData = this.GoodsData.GetPriceData();
		base.CurrencyId = priceData.CurrencyId;
		string nowPriceTextColor = "FFEF6FFF";
		if (priceData.OwnNumber() < priceData.NowPrice)
		{
			nowPriceTextColor = "F55E66FF";
		}
		base.NowPriceTextColor = nowPriceTextColor;
		if (priceData.NowPrice == 0)
		{
			base.CurrencyIconVisible = false;
			base.NowPriceTextData.SetData(new TableTextArgNew("ShopDiscountLabel_4", Array.Empty<object>()));
		}
		else
		{
			base.CurrencyIconVisible = true;
			base.NowPriceTextData.SetContent(priceData.NowPrice.ToString());
		}
		int? originalPrice = priceData.OriginalPrice;
		base.OriginalPriceVisible = (originalPrice != null && priceData.InDiscountTime);
		if (base.OriginalPriceVisible)
		{
			base.OriginalPriceTextData.SetContent("<s>" + originalPrice.ToString() + "</s>");
		}
	}

	// Token: 0x0600F2EE RID: 62190 RVA: 0x00473DC1 File Offset: 0x00471FC1
	public virtual void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemNameTextData.SetContent(this.GoodsData.GetGoodsData().GetGoodsName(LanguageSystem.Instance.PackageLanguage));
	}

	// Token: 0x0600F2EF RID: 62191 RVA: 0x00473DF4 File Offset: 0x00471FF4
	public void UpdateDiscountData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.DiscountItemVisible = this.GoodsData.HasDiscount();
		if (base.DiscountItemVisible)
		{
			base.DiscountTextData.SetContent(StringUtils.Format("-{0}%", new string[]
			{
				this.GoodsData.GetDiscount().ToString()
			}));
		}
	}

	// Token: 0x0600F2F0 RID: 62192 RVA: 0x00473E54 File Offset: 0x00472054
	public void UpdateLockData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.LockItemVisible = !this.GoodsData.IfCanBuy();
		if (base.LockItemVisible)
		{
			base.LockTextData.SetData(new TableTextArgNew(this.GoodsData.GetConditionTextId(), Array.Empty<object>()));
		}
	}

	// Token: 0x0600F2F1 RID: 62193 RVA: 0x00473EA8 File Offset: 0x004720A8
	public virtual void UpdateSoldOutData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.SoldOutItemVisible = (this.GoodsData.IsLimitGoods() && this.GoodsData.IsSoldOut());
		if (base.SoldOutItemVisible)
		{
			if (this.GoodsData.CheckIfMonthCardItem())
			{
				base.SoldOutTextData.SetData(new TableTextArgNew("MonthlyCardMax", Array.Empty<object>()));
				return;
			}
			base.SoldOutTextData.SetData(new TableTextArgNew("SoldOut", Array.Empty<object>()));
		}
	}

	// Token: 0x0600F2F2 RID: 62194 RVA: 0x00473F2C File Offset: 0x0047212C
	public virtual void UpdateQualityData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		CSharpScript.Game.Module.PayShop.IItemData itemData = this.GoodsData.GetItemData();
		if (itemData == null)
		{
			return;
		}
		string payShopItemQualitySpriteByItemIdAndQuality = PayShopModel.Instance.GetPayShopItemQualitySpriteByItemIdAndQuality(itemData.ItemId, itemData.Quality);
		base.QualitySpritePath = payShopItemQualitySpriteByItemIdAndQuality;
	}

	// Token: 0x0600F2F3 RID: 62195 RVA: 0x00473F70 File Offset: 0x00472170
	public virtual void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x0600F2F4 RID: 62196 RVA: 0x00473F94 File Offset: 0x00472194
	public virtual void UpdateBuyLimitCountText()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string shopTipsText = this.GoodsData.GetShopTipsText();
		if (shopTipsText != null && !StringUtils.IsEmpty(shopTipsText))
		{
			base.BuyLimitCountTextVisible = true;
			base.BuyLimitCountTextData.SetContent(shopTipsText);
			return;
		}
		base.BuyLimitCountTextVisible = false;
	}

	// Token: 0x0600F2F5 RID: 62197 RVA: 0x00473FDC File Offset: 0x004721DC
	public virtual void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.RedDotVisible = this.GoodsData.GetIfNeedRemind();
	}

	// Token: 0x0600F2F6 RID: 62198 RVA: 0x00473FF8 File Offset: 0x004721F8
	public void UpdateLabel()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int discountLabel = this.GoodsData.GetDiscountLabel();
		base.LabelVisible = (discountLabel > 0 && this.GoodsData.InLabelShowTime());
		if (base.LabelVisible)
		{
			string shopDiscountLabel = PayShopConfig.Instance.GetShopDiscountLabel(discountLabel);
			base.LabelTextData.SetData(new TableTextArgNew(shopDiscountLabel, Array.Empty<object>()));
		}
	}

	// Token: 0x0600F2F7 RID: 62199 RVA: 0x0047405C File Offset: 0x0047225C
	public virtual void UpdateLeftTime()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.GoodsData.GetCountDownData();
		EPayCountTimeType item = countDownData.Item1;
		CommonDefine.IPayShowCountDownRemainTime item2 = countDownData.Item2;
		base.LeftTimeItemVisible = (item2 != null && item != EPayCountTimeType.Resell);
		if (base.LeftTimeItemVisible)
		{
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item2 as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				base.LeftTimeTextData.SetContent(payShowCountDownRemainTime.Value);
				return;
			}
			CommonDefine.IRemainTime remainTime = item2 as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				base.LeftTimeTextData.SetData(new TableTextArgNew(remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue)));
			}
		}
	}

	// Token: 0x0600F2F8 RID: 62200 RVA: 0x004740F4 File Offset: 0x004722F4
	public void UpdateReSell()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string resellText = this.GoodsData.GetResellText();
		base.ReSellItemVisible = (resellText != null && !StringUtils.IsEmpty(resellText));
		if (base.ReSellItemVisible)
		{
			string textById = TextConfig.Instance.GetTextById(resellText);
			base.ReSellTextData.SetContent(textById);
		}
	}

	// Token: 0x0600F2F9 RID: 62201 RVA: 0x0047414B File Offset: 0x0047234B
	public void UpdateRaycastTarget()
	{
		base.RaycastTarget = true;
	}

	// Token: 0x0600F2FA RID: 62202 RVA: 0x00474154 File Offset: 0x00472354
	public virtual void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = true;
	}

	// Token: 0x0600F2FB RID: 62203 RVA: 0x0047415D File Offset: 0x0047235D
	public override void OnBuyButtonClick()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		GameplayShopUtil.OpenExchangePopView(this.GoodsData);
	}

	// Token: 0x0600F2FC RID: 62204 RVA: 0x00474174 File Offset: 0x00472374
	public virtual void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
	{
		this.GoodsData = payShopGoods;
		this.UpdatePriceData();
		this.UpdateItemName();
		this.UpdateDiscountData();
		this.UpdateLockData();
		this.UpdateSoldOutData();
		this.UpdateQualityData();
		this.UpdateItemIconData();
		this.UpdateBuyLimitCountText();
		this.UpdateRedDot();
		this.UpdateLabel();
		this.UpdateLeftTime();
		this.UpdateReSell();
		this.UpdateRaycastTarget();
		this.UpdateBottomBgVisible();
	}

	// Token: 0x040088C7 RID: 35015
	private const string NORMALCOLOR = "FFEF6FFF";

	// Token: 0x040088C8 RID: 35016
	private const string REDCOLOR = "F55E66FF";

	// Token: 0x040088C9 RID: 35017
	[Nullable(2)]
	public PayShopGoods GoodsData;
}
