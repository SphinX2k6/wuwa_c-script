using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200233F RID: 9023
[NullableContext(1)]
[Nullable(0)]
public class CommonGameplayShopItemProxy : AbstractGameplayShopItemProxy
{
	// Token: 0x06011E3D RID: 73277 RVA: 0x00466C0C File Offset: 0x00464E0C
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

	// Token: 0x06011E3E RID: 73278 RVA: 0x00466CF9 File Offset: 0x00464EF9
	public virtual void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemNameTextData.SetContent(this.GoodsData.GetGoodsData().GetGoodsName(LanguageSystem.Instance.PackageLanguage));
	}

	// Token: 0x06011E3F RID: 73279 RVA: 0x00466D2C File Offset: 0x00464F2C
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

	// Token: 0x06011E40 RID: 73280 RVA: 0x00466D8C File Offset: 0x00464F8C
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

	// Token: 0x06011E41 RID: 73281 RVA: 0x00466DE0 File Offset: 0x00464FE0
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

	// Token: 0x06011E42 RID: 73282 RVA: 0x00466E64 File Offset: 0x00465064
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

	// Token: 0x06011E43 RID: 73283 RVA: 0x00466EA8 File Offset: 0x004650A8
	public virtual void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x06011E44 RID: 73284 RVA: 0x00466ECC File Offset: 0x004650CC
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

	// Token: 0x06011E45 RID: 73285 RVA: 0x00466F14 File Offset: 0x00465114
	public virtual void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.RedDotVisible = this.GoodsData.GetIfNeedRemind();
	}

	// Token: 0x06011E46 RID: 73286 RVA: 0x00466F30 File Offset: 0x00465130
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

	// Token: 0x06011E47 RID: 73287 RVA: 0x00466F94 File Offset: 0x00465194
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

	// Token: 0x06011E48 RID: 73288 RVA: 0x0046702C File Offset: 0x0046522C
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

	// Token: 0x06011E49 RID: 73289 RVA: 0x00467083 File Offset: 0x00465283
	public void UpdateRaycastTarget()
	{
		base.RaycastTarget = true;
	}

	// Token: 0x06011E4A RID: 73290 RVA: 0x0046708C File Offset: 0x0046528C
	public virtual void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = true;
	}

	// Token: 0x06011E4B RID: 73291 RVA: 0x00467095 File Offset: 0x00465295
	public override void OnBuyButtonClick()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		GameplayShopUtil.OpenExchangePopView(this.GoodsData);
	}

	// Token: 0x06011E4C RID: 73292 RVA: 0x004670AC File Offset: 0x004652AC
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

	// Token: 0x04008784 RID: 34692
	private const string NORMALCOLOR = "FFEF6FFF";

	// Token: 0x04008785 RID: 34693
	private const string REDCOLOR = "F55E66FF";

	// Token: 0x04008786 RID: 34694
	[Nullable(2)]
	public PayShopGoods GoodsData;
}
