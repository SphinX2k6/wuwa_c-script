using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001860 RID: 6240
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OrnamentItemContent : GridProxyAbstract<OrnamentItemContentData>
{
	// Token: 0x0600F6FC RID: 63228 RVA: 0x00482650 File Offset: 0x00480850
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUIText)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBuyButton))
		};
	}

	// Token: 0x0600F6FD RID: 63229 RVA: 0x00482920 File Offset: 0x00480B20
	protected override UniTask OnBeforeStartAsync()
	{
		OrnamentItemContent.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OrnamentItemContent.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F6FE RID: 63230 RVA: 0x00482964 File Offset: 0x00480B64
	private void OnClickBuyButton()
	{
		if (this.CurrentOrnamentData == null)
		{
			return;
		}
		PayShopGoods payShopGoods = this.CurrentOrnamentData.GetPayShopGoods();
		if (payShopGoods != null)
		{
			payShopGoods.SaveRemindState((long)TimeUtil.Instance.GetServerTime());
		}
		if (this.CurrentOrnamentData != null)
		{
			this.RefreshRedDotState(this.CurrentOrnamentData);
		}
		RoleOrnamentShowViewParams param = new RoleOrnamentShowViewParams
		{
			OrnamentId = this.CurrentOrnamentData.GetItemId(),
			BuyDetailData = this.CurrentOrnamentData
		};
		UiManager.Instance.OpenView(EUiViewName.RoleOrnamentShowView, param, null);
	}

	// Token: 0x0600F6FF RID: 63231 RVA: 0x004829E4 File Offset: 0x00480BE4
	[NullableContext(1)]
	public override void Refresh(OrnamentItemContentData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.CurrentOrnamentData = data.ShopRoleOrnamentData;
		this.RefreshRoleTexture(this.CurrentOrnamentData);
		this.RefreshBuyLimitText(this.CurrentOrnamentData);
		this.RefreshSubNameText(this.CurrentOrnamentData);
		this.RefreshNowPriceText(this.CurrentOrnamentData);
		this.RefreshSourcePriceText(this.CurrentOrnamentData);
		this.RefreshDiscountText(this.CurrentOrnamentData);
		this.RefreshBuyItemIcon(this.CurrentOrnamentData);
		this.RefreshBuyLimitItemState(this.CurrentOrnamentData);
		this.RefreshFinishBuyItemState(this.CurrentOrnamentData);
		this.RefreshRedDotState(this.CurrentOrnamentData);
		this.RefreshDiscountTimeText(this.CurrentOrnamentData);
		this.RefreshTextureBg(this.CurrentOrnamentData);
		this.RefreshTextureTopBg(this.CurrentOrnamentData);
		this.RefreshEffectItem(this.CurrentOrnamentData);
		this.RefreshExtraReward(this.CurrentOrnamentData);
		this.RefreshCouponItem(this.CurrentOrnamentData);
		this.RefreshSellTimeText(this.CurrentOrnamentData);
		this.RefreshTotalTopUpTag(this.CurrentOrnamentData);
	}

	// Token: 0x0600F700 RID: 63232 RVA: 0x00482ADC File Offset: 0x00480CDC
	private void RefreshTotalTopUpTag(ShopRoleOrnamentData data)
	{
		if (this.TotalTopUpTagItem == null)
		{
			return;
		}
		if (data == null || !data.GetIfCanBuy())
		{
			this.TotalTopUpTagItem.SetUiActive(false);
			return;
		}
		this.TotalTopUpTagItem.RefreshByGoodsId(data.GetCurrentGoodsData().GetGoodsId());
	}

	// Token: 0x0600F701 RID: 63233 RVA: 0x00482B15 File Offset: 0x00480D15
	[NullableContext(1)]
	private void RefreshEffectItem(ShopRoleOrnamentData data)
	{
		base.GetItem(17).SetUIActive(false);
		base.GetItem(16).SetUIActive(false);
	}

	// Token: 0x0600F702 RID: 63234 RVA: 0x00482B34 File Offset: 0x00480D34
	private void RefreshExtraReward(ShopRoleOrnamentData data)
	{
		UUIItem item = base.GetItem(21);
		if (data == null)
		{
			item.SetUIActive(false);
			return;
		}
		List<TItem> otherReward = data.GetOtherReward();
		TItem? titem = (otherReward.Count > 0) ? new TItem?(otherReward[0]) : null;
		if (titem == null)
		{
			item.SetUIActive(false);
			return;
		}
		int itemId = titem.Value.ItemData.ItemId;
		int count = titem.Value.Count;
		base.GetItem(27).SetUIActive(true);
		item.SetUIActive(true);
		base.SetItemIcon(base.GetTexture(22), itemId, null, null);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(count);
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		base.GetText(23).SetText(newText, true);
	}

	// Token: 0x0600F703 RID: 63235 RVA: 0x00482C18 File Offset: 0x00480E18
	[NullableContext(1)]
	private void RefreshRedDotState(ShopRoleOrnamentData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x0600F704 RID: 63236 RVA: 0x00482C40 File Offset: 0x00480E40
	[NullableContext(1)]
	private void RefreshBuyLimitItemState(ShopRoleOrnamentData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x0600F705 RID: 63237 RVA: 0x00482C64 File Offset: 0x00480E64
	[NullableContext(1)]
	private void RefreshFinishBuyItemState(ShopRoleOrnamentData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x0600F706 RID: 63238 RVA: 0x00482C8C File Offset: 0x00480E8C
	private void RefreshRoleTexture(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetTexture(1).SetUIActive(false);
			return;
		}
		string previewTextureInPayShop = data.GetPreviewTextureInPayShop();
		base.SetTextureByPath(previewTextureInPayShop, base.GetTexture(1), null, null);
	}

	// Token: 0x0600F707 RID: 63239 RVA: 0x00482CCC File Offset: 0x00480ECC
	private void RefreshSourcePriceText(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetText(6).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			base.GetText(6).SetUIActive(false);
			return;
		}
		int? originalPrice = data.GetPriceData().OriginalPrice;
		if (originalPrice == null)
		{
			base.GetText(6).SetUIActive(false);
			return;
		}
		base.GetText(6).SetUIActive(true);
		base.GetText(6).SetText("<s>" + originalPrice.ToString() + "</s>", true);
	}

	// Token: 0x0600F708 RID: 63240 RVA: 0x00482D60 File Offset: 0x00480F60
	private void RefreshNowPriceText(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetText(5).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			base.GetText(5).SetText(data.GetDirectPriceText(), true);
			return;
		}
		base.GetText(5).SetText(data.GetPriceData().NowPrice.ToString(), true);
	}

	// Token: 0x0600F709 RID: 63241 RVA: 0x00482DC0 File Offset: 0x00480FC0
	private void RefreshBuyItemIcon(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetTexture(10).SetUIActive(false);
			return;
		}
		bool ifDirect = data.GetIfDirect();
		base.GetTexture(10).SetUIActive(!ifDirect);
		if (!ifDirect)
		{
			IPriceData priceData = data.GetPriceData();
			base.SetItemIcon(base.GetTexture(10), priceData.CurrencyId, null, null);
		}
	}

	// Token: 0x0600F70A RID: 63242 RVA: 0x00482E20 File Offset: 0x00481020
	[NullableContext(1)]
	private void RefreshBuyLimitText(ShopRoleOrnamentData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x0600F70B RID: 63243 RVA: 0x00482E48 File Offset: 0x00481048
	[NullableContext(1)]
	private void RefreshSubNameText(ShopRoleOrnamentData data)
	{
		string titleName = data.GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), titleName, Array.Empty<object>());
	}

	// Token: 0x0600F70C RID: 63244 RVA: 0x00482E74 File Offset: 0x00481074
	private void RefreshDiscountText(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetItem(7).SetUIActive(false);
			return;
		}
		string discountText = data.GetDiscountText();
		base.GetItem(7).SetUIActive(discountText != "");
		base.GetText(8).SetText(discountText, true);
	}

	// Token: 0x0600F70D RID: 63245 RVA: 0x00482EC0 File Offset: 0x004810C0
	private void RefreshTextureBg(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetTexture(14).SetUIActive(false);
			return;
		}
		string resourceId = "T_ShopRoleItemBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(14), null, null);
	}

	// Token: 0x0600F70E RID: 63246 RVA: 0x00482F0C File Offset: 0x0048110C
	private void RefreshTextureTopBg(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetTexture(15).SetUIActive(false);
			return;
		}
		string resourceId = "T_ShopRoleItemTopBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(15), null, null);
	}

	// Token: 0x0600F70F RID: 63247 RVA: 0x00482F58 File Offset: 0x00481158
	private void RefreshDiscountTimeText(ShopRoleOrnamentData data)
	{
		if (data == null)
		{
			base.GetItem(7).SetUIActive(false);
			return;
		}
		object discountTimeData = data.GetDiscountTimeData();
		if (discountTimeData == null)
		{
			base.GetItem(7).SetUIActive(false);
			return;
		}
		base.GetItem(7).SetUIActive(true);
		UUIText text = base.GetText(9);
		LguiUtil.Instance.SetLocalText(text, ((CommonDefine.IRemainTime)discountTimeData).TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.IRemainTime)discountTimeData).TimeValue));
	}

	// Token: 0x0600F710 RID: 63248 RVA: 0x00482FD0 File Offset: 0x004811D0
	private void RefreshCouponItem(ShopRoleOrnamentData data)
	{
		UUIItem item = base.GetItem(18);
		if (data == null)
		{
			item.SetUIActive(false);
			return;
		}
		CommonItemData availableCouponItem = data.GetCurrentGoodsData().GetAvailableCouponItem();
		if (availableCouponItem == null)
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		int availableCouponDiscount = data.GetCurrentGoodsData().GetAvailableCouponDiscount();
		UUIText text = base.GetText(19);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(availableCouponDiscount);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.SetTextureByPath(availableCouponItem.GetConfig().As<ItemInfo>().Value.IconSmall, base.GetTexture(20), null, null);
	}

	// Token: 0x0600F711 RID: 63249 RVA: 0x00483084 File Offset: 0x00481284
	private void RefreshSellTimeText(ShopRoleOrnamentData data)
	{
		UUIText text = base.GetText(9);
		if (data == null)
		{
			text.SetUIActive(false);
			return;
		}
		PayShopGoods currentGoodsData = data.GetCurrentGoodsData();
		if (currentGoodsData.HasDiscount())
		{
			return;
		}
		if (!currentGoodsData.InUnPermanentSellTime())
		{
			text.SetUIActive(false);
			return;
		}
		base.GetItem(24).SetUIActive(false);
		base.GetItem(7).SetUIActive(true);
		text.SetUIActive(true);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = (CommonDefine.PayShowCountDownRemainTime<string>)currentGoodsData.GetEndTimeRemainData();
		text.SetText(payShowCountDownRemainTime.Value, true);
	}

	// Token: 0x04008A6B RID: 35435
	private OrnamentItemContentData CurrentData;

	// Token: 0x04008A6C RID: 35436
	private ShopRoleOrnamentData CurrentOrnamentData;

	// Token: 0x04008A6D RID: 35437
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x02007AA0 RID: 31392
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027BF2 RID: 162802
		BuyButton,
		// Token: 0x04027BF3 RID: 162803
		RoleTexture,
		// Token: 0x04027BF4 RID: 162804
		TextureWeapon,
		// Token: 0x04027BF5 RID: 162805
		BuyLimitText,
		// Token: 0x04027BF6 RID: 162806
		SubNameText,
		// Token: 0x04027BF7 RID: 162807
		NowPrice,
		// Token: 0x04027BF8 RID: 162808
		BeforePrice,
		// Token: 0x04027BF9 RID: 162809
		DiscountItem,
		// Token: 0x04027BFA RID: 162810
		DiscountText,
		// Token: 0x04027BFB RID: 162811
		TimeText,
		// Token: 0x04027BFC RID: 162812
		BuyItemIcon,
		// Token: 0x04027BFD RID: 162813
		LimitBuyItem,
		// Token: 0x04027BFE RID: 162814
		FinishBuyItem,
		// Token: 0x04027BFF RID: 162815
		NewItem,
		// Token: 0x04027C00 RID: 162816
		TextureBg,
		// Token: 0x04027C01 RID: 162817
		TextureTopBg,
		// Token: 0x04027C02 RID: 162818
		EffectBItem,
		// Token: 0x04027C03 RID: 162819
		EffectAItem,
		// Token: 0x04027C04 RID: 162820
		ItemCoupon,
		// Token: 0x04027C05 RID: 162821
		TextCoupon,
		// Token: 0x04027C06 RID: 162822
		TextureCoupon,
		// Token: 0x04027C07 RID: 162823
		ExtraItemRoot,
		// Token: 0x04027C08 RID: 162824
		TextureExtraReward,
		// Token: 0x04027C09 RID: 162825
		TextExtraReward,
		// Token: 0x04027C0A RID: 162826
		ItemDiscountSprite,
		// Token: 0x04027C0B RID: 162827
		ItemTypeRoot,
		// Token: 0x04027C0C RID: 162828
		TextureItemType,
		// Token: 0x04027C0D RID: 162829
		ItemRewardRoot,
		// Token: 0x04027C0E RID: 162830
		ItemTagRoot
	}
}
