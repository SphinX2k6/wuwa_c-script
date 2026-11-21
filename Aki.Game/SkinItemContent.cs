using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200185A RID: 6234
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SkinItemContent : GridProxyAbstract<SkinItemContentData>
{
	// Token: 0x0600F6C4 RID: 63172 RVA: 0x004811F4 File Offset: 0x0047F3F4
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

	// Token: 0x0600F6C5 RID: 63173 RVA: 0x00481420 File Offset: 0x0047F620
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

	// Token: 0x0600F6C6 RID: 63174 RVA: 0x0048149C File Offset: 0x0047F69C
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

	// Token: 0x0600F6C7 RID: 63175 RVA: 0x00481530 File Offset: 0x0047F730
	private void RefreshEffectItem(ShopSkinData data)
	{
		bool uiactive = data.GetRoleSkinData().GetSuitWeaponSkinId() > 0;
		base.GetItem(17).SetUIActive(uiactive);
		base.GetItem(16).SetUIActive(uiactive);
	}

	// Token: 0x0600F6C8 RID: 63176 RVA: 0x00481568 File Offset: 0x0047F768
	private void RefreshRedDotState(ShopSkinData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x0600F6C9 RID: 63177 RVA: 0x00481590 File Offset: 0x0047F790
	private void RefreshBuyLimitItemState(ShopSkinData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x0600F6CA RID: 63178 RVA: 0x004815B4 File Offset: 0x0047F7B4
	private void RefreshFinishBuyItemState(ShopSkinData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x0600F6CB RID: 63179 RVA: 0x004815DC File Offset: 0x0047F7DC
	private void RefreshRoleTexture(ShopSkinData data)
	{
		string payShopPreviewRoleTexturePath = data.GetPayShopPreviewRoleTexturePath();
		base.SetTextureByPath(payShopPreviewRoleTexturePath, base.GetTexture(1), null, null);
	}

	// Token: 0x0600F6CC RID: 63180 RVA: 0x00481608 File Offset: 0x0047F808
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

	// Token: 0x0600F6CD RID: 63181 RVA: 0x00481668 File Offset: 0x0047F868
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

	// Token: 0x0600F6CE RID: 63182 RVA: 0x004816FC File Offset: 0x0047F8FC
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

	// Token: 0x0600F6CF RID: 63183 RVA: 0x00481760 File Offset: 0x0047F960
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

	// Token: 0x0600F6D0 RID: 63184 RVA: 0x004817C0 File Offset: 0x0047F9C0
	private void RefreshBuyLimitText(ShopSkinData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x0600F6D1 RID: 63185 RVA: 0x004817E8 File Offset: 0x0047F9E8
	private void RefreshSubNameText(ShopSkinData data)
	{
		string titleName = data.GetRoleSkinData().GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), titleName, Array.Empty<object>());
	}

	// Token: 0x0600F6D2 RID: 63186 RVA: 0x00481818 File Offset: 0x0047FA18
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

	// Token: 0x0600F6D3 RID: 63187 RVA: 0x004818B4 File Offset: 0x0047FAB4
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

	// Token: 0x0600F6D4 RID: 63188 RVA: 0x00481900 File Offset: 0x0047FB00
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

	// Token: 0x0600F6D5 RID: 63189 RVA: 0x00481964 File Offset: 0x0047FB64
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

	// Token: 0x0600F6D6 RID: 63190 RVA: 0x004819C8 File Offset: 0x0047FBC8
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

	// Token: 0x04008A5D RID: 35421
	[Nullable(2)]
	private SkinItemContentData CurrentShopSkinData;

	// Token: 0x04008A5E RID: 35422
	private int CurrentIndex;

	// Token: 0x02007A9C RID: 31388
	[NullableContext(0)]
	private enum ESkinItemComponent
	{
		// Token: 0x04027BBC RID: 162748
		BuyButton,
		// Token: 0x04027BBD RID: 162749
		RoleTexture,
		// Token: 0x04027BBE RID: 162750
		TextureWeapon,
		// Token: 0x04027BBF RID: 162751
		BuyLimitText,
		// Token: 0x04027BC0 RID: 162752
		SubNameText,
		// Token: 0x04027BC1 RID: 162753
		NowPrice,
		// Token: 0x04027BC2 RID: 162754
		BeforePrice,
		// Token: 0x04027BC3 RID: 162755
		DiscountItem,
		// Token: 0x04027BC4 RID: 162756
		DiscountText,
		// Token: 0x04027BC5 RID: 162757
		TimeText,
		// Token: 0x04027BC6 RID: 162758
		BuyItemIcon,
		// Token: 0x04027BC7 RID: 162759
		LimitBuyItem,
		// Token: 0x04027BC8 RID: 162760
		FinishBuyItem,
		// Token: 0x04027BC9 RID: 162761
		NewItem,
		// Token: 0x04027BCA RID: 162762
		TextureBg,
		// Token: 0x04027BCB RID: 162763
		TextureTopBg,
		// Token: 0x04027BCC RID: 162764
		EffectBItem,
		// Token: 0x04027BCD RID: 162765
		EffectAItem,
		// Token: 0x04027BCE RID: 162766
		ItemCoupon,
		// Token: 0x04027BCF RID: 162767
		TextCoupon,
		// Token: 0x04027BD0 RID: 162768
		TextureCoupon,
		// Token: 0x04027BD1 RID: 162769
		DiscountTextRootItem = 24
	}
}
