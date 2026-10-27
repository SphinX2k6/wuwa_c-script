using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002375 RID: 9077
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinItemContent : GridProxyAbstract<SkinItemContentData>
{
	// Token: 0x06012214 RID: 74260 RVA: 0x00474074 File Offset: 0x00472274
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
			new ValueTuple<int, Type>(24, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBuyButton))
		};
	}

	// Token: 0x06012215 RID: 74261 RVA: 0x004742A0 File Offset: 0x004724A0
	private void OnClickBuyButton()
	{
		List<PayShopGoods> allData = this.CurrentShopSkinData.AllData;
		List<ShopSkinData> list = new List<ShopSkinData>();
		int count = allData.Count;
		for (int i = 0; i < count; i++)
		{
			ShopSkinData item = ShopSkinData.Create(allData[i]);
			list.Add(item);
		}
		SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.Create(list);
		skinBuyDetailViewData.SetIndex(this.CurrentIndex);
		skinBuyDetailViewData.SetPreviewTitle("RoleSkinShopTitle_Text");
		UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
	}

	// Token: 0x06012216 RID: 74262 RVA: 0x0047431C File Offset: 0x0047251C
	public override void Refresh(SkinItemContentData data, bool isSelected, int gridIndex)
	{
		ShopSkinData shopSkinData = data.ShopSkinData;
		this.CurrentShopSkinData = data;
		this.CurrentIndex = gridIndex;
		this.RefreshRoleTexture(shopSkinData);
		this.RefreshWeaponTexture(shopSkinData);
		this.RefreshBuyLimitText(shopSkinData);
		this.RefreshSubNameText(shopSkinData);
		this.RefreshNowPriceText(shopSkinData);
		this.RefreshSourcePriceText(shopSkinData);
		this.RefreshDiscountTimeText(shopSkinData);
		this.RefreshDiscountText(shopSkinData);
		this.RefreshBuyItemIcon(shopSkinData);
		this.RefreshBuyLimitItemState(shopSkinData);
		this.RefreshFinishBuyItemState(shopSkinData);
		this.RefreshRedDotState(shopSkinData);
		this.RefreshTextureBg(shopSkinData);
		this.RefreshTextureTopBg(shopSkinData);
		this.RefreshEffectItem(shopSkinData);
		this.RefreshCouponItem(shopSkinData);
	}

	// Token: 0x06012217 RID: 74263 RVA: 0x004743B0 File Offset: 0x004725B0
	private void RefreshEffectItem(ShopSkinData data)
	{
		bool uiactive = data.GetRoleSkinData().GetSuitWeaponSkinId() > 0;
		base.GetItem(17).SetUIActive(uiactive);
		base.GetItem(16).SetUIActive(uiactive);
	}

	// Token: 0x06012218 RID: 74264 RVA: 0x004743E8 File Offset: 0x004725E8
	private void RefreshRedDotState(ShopSkinData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x06012219 RID: 74265 RVA: 0x00474410 File Offset: 0x00472610
	private void RefreshBuyLimitItemState(ShopSkinData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x0601221A RID: 74266 RVA: 0x00474434 File Offset: 0x00472634
	private void RefreshFinishBuyItemState(ShopSkinData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x0601221B RID: 74267 RVA: 0x0047445C File Offset: 0x0047265C
	private void RefreshRoleTexture(ShopSkinData data)
	{
		string payShopPreviewRoleTexturePath = data.GetPayShopPreviewRoleTexturePath();
		base.SetTextureByPath(payShopPreviewRoleTexturePath, base.GetTexture(1), null, null);
	}

	// Token: 0x0601221C RID: 74268 RVA: 0x00474488 File Offset: 0x00472688
	private void RefreshWeaponTexture(ShopSkinData data)
	{
		string payShopPreviewBuyRoleSuitWeaponTexturePath = data.GetPayShopPreviewBuyRoleSuitWeaponTexturePath();
		if (!(payShopPreviewBuyRoleSuitWeaponTexturePath == ""))
		{
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(payShopPreviewBuyRoleSuitWeaponTexturePath, base.GetTexture(2), null, null);
			return;
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(false);
	}

	// Token: 0x0601221D RID: 74269 RVA: 0x004744E8 File Offset: 0x004726E8
	[NullableContext(2)]
	private void RefreshSourcePriceText(ShopSkinData data)
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

	// Token: 0x0601221E RID: 74270 RVA: 0x0047457C File Offset: 0x0047277C
	[NullableContext(2)]
	private void RefreshNowPriceText(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetText(5).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			string directPriceText = data.GetDirectPriceText();
			base.GetText(5).SetText(directPriceText, true);
			return;
		}
		int nowPrice = data.GetPriceData().NowPrice;
		base.GetText(5).SetText(nowPrice.ToString(), true);
	}

	// Token: 0x0601221F RID: 74271 RVA: 0x004745E0 File Offset: 0x004727E0
	[NullableContext(2)]
	private void RefreshBuyItemIcon(ShopSkinData data)
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

	// Token: 0x06012220 RID: 74272 RVA: 0x00474640 File Offset: 0x00472840
	private void RefreshBuyLimitText(ShopSkinData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x06012221 RID: 74273 RVA: 0x00474668 File Offset: 0x00472868
	private void RefreshSubNameText(ShopSkinData data)
	{
		string titleName = data.GetRoleSkinData().GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), titleName, Array.Empty<object>());
	}

	// Token: 0x06012222 RID: 74274 RVA: 0x00474698 File Offset: 0x00472898
	[NullableContext(2)]
	private void RefreshDiscountTimeText(ShopSkinData data)
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
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = discountTimeData as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime> payShowCountDownRemainTime2 = discountTimeData as CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>;
		if (payShowCountDownRemainTime2 != null)
		{
			LguiUtil.Instance.SetLocalText(text, payShowCountDownRemainTime2.Value.TextId, new <>z__ReadOnlySingleElementList<object>(payShowCountDownRemainTime2.Value.TimeValue));
		}
	}

	// Token: 0x06012223 RID: 74275 RVA: 0x00474734 File Offset: 0x00472934
	[NullableContext(2)]
	private void RefreshDiscountText(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetItem(7).SetUIActive(false);
			return;
		}
		string discountText = data.GetDiscountText();
		base.GetItem(24).SetUIActive(discountText != "");
		base.GetText(8).SetText(discountText, true);
	}

	// Token: 0x06012224 RID: 74276 RVA: 0x00474780 File Offset: 0x00472980
	[NullableContext(2)]
	private void RefreshTextureBg(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(14).SetUIActive(false);
			return;
		}
		string resourceId = (data.GetRoleSkinData().GetSuitWeaponSkinId() > 0) ? "T_ShopRoleItemBg1" : "T_ShopRoleItemBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(14), null, null);
	}

	// Token: 0x06012225 RID: 74277 RVA: 0x004747E4 File Offset: 0x004729E4
	[NullableContext(2)]
	private void RefreshTextureTopBg(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(15).SetUIActive(false);
			return;
		}
		string resourceId = (data.GetRoleSkinData().GetSuitWeaponSkinId() > 0) ? "T_ShopRoleItemTopBg1" : "T_ShopRoleItemTopBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(15), null, null);
	}

	// Token: 0x06012226 RID: 74278 RVA: 0x00474848 File Offset: 0x00472A48
	[NullableContext(2)]
	private void RefreshCouponItem(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetItem(18).SetUIActive(false);
			return;
		}
		CommonItemData availableCouponItem = data.GetCurrentGoodsData().GetAvailableCouponItem();
		if (availableCouponItem == null)
		{
			base.GetItem(18).SetUIActive(false);
			return;
		}
		base.GetItem(18).SetUIActive(true);
		int availableCouponDiscount = data.GetCurrentGoodsData().GetAvailableCouponDiscount();
		UUIText text = base.GetText(19);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(availableCouponDiscount);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.SetTextureByPath(availableCouponItem.GetConfig().As<ItemInfo>().Value.IconSmall, base.GetTexture(20), null, null);
	}

	// Token: 0x04008918 RID: 35096
	[Nullable(2)]
	private SkinItemContentData CurrentShopSkinData;

	// Token: 0x04008919 RID: 35097
	private int CurrentIndex;

	// Token: 0x02008912 RID: 35090
	[NullableContext(0)]
	private enum ESkinItemComponent
	{
		// Token: 0x0402C8A4 RID: 182436
		BuyButton,
		// Token: 0x0402C8A5 RID: 182437
		RoleTexture,
		// Token: 0x0402C8A6 RID: 182438
		TextureWeapon,
		// Token: 0x0402C8A7 RID: 182439
		BuyLimitText,
		// Token: 0x0402C8A8 RID: 182440
		SubNameText,
		// Token: 0x0402C8A9 RID: 182441
		NowPrice,
		// Token: 0x0402C8AA RID: 182442
		BeforePrice,
		// Token: 0x0402C8AB RID: 182443
		DiscountItem,
		// Token: 0x0402C8AC RID: 182444
		DiscountText,
		// Token: 0x0402C8AD RID: 182445
		TimeText,
		// Token: 0x0402C8AE RID: 182446
		BuyItemIcon,
		// Token: 0x0402C8AF RID: 182447
		LimitBuyItem,
		// Token: 0x0402C8B0 RID: 182448
		FinishBuyItem,
		// Token: 0x0402C8B1 RID: 182449
		NewItem,
		// Token: 0x0402C8B2 RID: 182450
		TextureBg,
		// Token: 0x0402C8B3 RID: 182451
		TextureTopBg,
		// Token: 0x0402C8B4 RID: 182452
		EffectBItem,
		// Token: 0x0402C8B5 RID: 182453
		EffectAItem,
		// Token: 0x0402C8B6 RID: 182454
		ItemCoupon,
		// Token: 0x0402C8B7 RID: 182455
		TextCoupon,
		// Token: 0x0402C8B8 RID: 182456
		TextureCoupon,
		// Token: 0x0402C8B9 RID: 182457
		DiscountTextRootItem = 24
	}
}
