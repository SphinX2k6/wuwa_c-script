using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x0200089C RID: 2204
[NullableContext(1)]
[Nullable(0)]
public class PinballShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x17000C26 RID: 3110
	// (get) Token: 0x0600637B RID: 25467 RVA: 0x001FAC41 File Offset: 0x001F8E41
	// (set) Token: 0x0600637C RID: 25468 RVA: 0x001FAC49 File Offset: 0x001F8E49
	public override string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x17000C27 RID: 3111
	// (get) Token: 0x0600637D RID: 25469 RVA: 0x001FAC52 File Offset: 0x001F8E52
	// (set) Token: 0x0600637E RID: 25470 RVA: 0x001FAC5A File Offset: 0x001F8E5A
	public override bool BigItemIconVisible { get; set; }

	// Token: 0x17000C28 RID: 3112
	// (get) Token: 0x0600637F RID: 25471 RVA: 0x001FAC63 File Offset: 0x001F8E63
	// (set) Token: 0x06006380 RID: 25472 RVA: 0x001FAC6B File Offset: 0x001F8E6B
	public override bool ItemBgItemVisible { get; set; } = true;

	// Token: 0x06006381 RID: 25473 RVA: 0x001FAC74 File Offset: 0x001F8E74
	public override void UpdateQualityData()
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

	// Token: 0x06006382 RID: 25474 RVA: 0x001FACB8 File Offset: 0x001F8EB8
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x001FACDC File Offset: 0x001F8EDC
	public override void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
		int num = (goodsData != null) ? goodsData.ItemId : 0;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(num)) == InventoryDefine.EItemDataType.PinballWeaponItem)
		{
			PinballWeaponConfig? pinballWeaponConfigById = PinballConfig.Instance.GetPinballWeaponConfigById(num);
			if (pinballWeaponConfigById != null)
			{
				base.ItemNameTextData.SetData(new TableTextArgNew(pinballWeaponConfigById.Value.Name, Array.Empty<object>()));
				return;
			}
		}
		base.UpdateItemName();
	}

	// Token: 0x06006384 RID: 25476 RVA: 0x001FAD60 File Offset: 0x001F8F60
	public new void UpdateBuyLimitCountText()
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

	// Token: 0x06006385 RID: 25477 RVA: 0x001FADA8 File Offset: 0x001F8FA8
	public new void UpdateLabel()
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

	// Token: 0x06006386 RID: 25478 RVA: 0x001FAE0C File Offset: 0x001F900C
	public new void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		bool ifNeedRemind = this.GoodsData.GetIfNeedRemind();
		base.RedDotVisible = ifNeedRemind;
	}

	// Token: 0x06006387 RID: 25479 RVA: 0x001FAE38 File Offset: 0x001F9038
	public new void UpdateLeftTime()
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

	// Token: 0x06006388 RID: 25480 RVA: 0x001FAED0 File Offset: 0x001F90D0
	public new void UpdateReSell()
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

	// Token: 0x06006389 RID: 25481 RVA: 0x001FAF28 File Offset: 0x001F9128
	public override void OnBuyButtonClick()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PinballShopExchangePopViewProxy pinballShopExchangePopViewProxy = new PinballShopExchangePopViewProxy();
		pinballShopExchangePopViewProxy.UpdateFromPayShopGoods(this.GoodsData);
		UiManager.Instance.OpenView(EUiViewName.PinballExchangePopView, pinballShopExchangePopViewProxy, null);
	}

	// Token: 0x0600638A RID: 25482 RVA: 0x001FAF64 File Offset: 0x001F9164
	public override void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
	{
		this.GoodsData = payShopGoods;
		this.UpdatePriceData();
		this.UpdateItemName();
		base.UpdateDiscountData();
		base.UpdateLockData();
		this.UpdateSoldOutData();
		this.UpdateQualityData();
		this.UpdateItemIconData();
		this.UpdateBuyLimitCountText();
		this.UpdateRedDot();
		this.UpdateLabel();
		this.UpdateLeftTime();
		this.UpdateReSell();
		base.UpdateRaycastTarget();
		this.UpdateBottomBgVisible();
	}
}
