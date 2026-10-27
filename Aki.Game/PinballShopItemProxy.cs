using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x020013E8 RID: 5096
[NullableContext(1)]
[Nullable(0)]
public class PinballShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x17000C06 RID: 3078
	// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x001F2103 File Offset: 0x001F0303
	// (set) Token: 0x06008FE7 RID: 36839 RVA: 0x001F210B File Offset: 0x001F030B
	public override string BigItemIconTexturePath { get; set; } = "";

	// Token: 0x17000C07 RID: 3079
	// (get) Token: 0x06008FE8 RID: 36840 RVA: 0x001F2114 File Offset: 0x001F0314
	// (set) Token: 0x06008FE9 RID: 36841 RVA: 0x001F211C File Offset: 0x001F031C
	public override bool BigItemIconVisible { get; set; }

	// Token: 0x17000C08 RID: 3080
	// (get) Token: 0x06008FEA RID: 36842 RVA: 0x001F2125 File Offset: 0x001F0325
	// (set) Token: 0x06008FEB RID: 36843 RVA: 0x001F212D File Offset: 0x001F032D
	public override bool ItemBgItemVisible { get; set; } = true;

	// Token: 0x06008FEC RID: 36844 RVA: 0x001F2138 File Offset: 0x001F0338
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

	// Token: 0x06008FED RID: 36845 RVA: 0x001F217C File Offset: 0x001F037C
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x06008FEE RID: 36846 RVA: 0x001F21A0 File Offset: 0x001F03A0
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

	// Token: 0x06008FEF RID: 36847 RVA: 0x001F2224 File Offset: 0x001F0424
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

	// Token: 0x06008FF0 RID: 36848 RVA: 0x001F226C File Offset: 0x001F046C
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

	// Token: 0x06008FF1 RID: 36849 RVA: 0x001F22D0 File Offset: 0x001F04D0
	public new void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		bool ifNeedRemind = this.GoodsData.GetIfNeedRemind();
		base.RedDotVisible = ifNeedRemind;
	}

	// Token: 0x06008FF2 RID: 36850 RVA: 0x001F22FC File Offset: 0x001F04FC
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

	// Token: 0x06008FF3 RID: 36851 RVA: 0x001F2394 File Offset: 0x001F0594
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

	// Token: 0x06008FF4 RID: 36852 RVA: 0x001F23EC File Offset: 0x001F05EC
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

	// Token: 0x06008FF5 RID: 36853 RVA: 0x001F2428 File Offset: 0x001F0628
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
