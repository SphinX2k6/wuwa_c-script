using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200185D RID: 6237
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinItemContent : GridProxyAbstract<FlySkinItemContentData>
{
	// Token: 0x0600F6E0 RID: 63200 RVA: 0x00481BD4 File Offset: 0x0047FDD4
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
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUIText)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUITexture)),
			new ValueTuple<int, Type>(27, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBuyButton))
		};
	}

	// Token: 0x0600F6E1 RID: 63201 RVA: 0x00481E30 File Offset: 0x00480030
	private void OnClickBuyButton()
	{
		List<PayShopGoods> allData = this.CurrentShopFlySkinData.AllData;
		List<ShopFlySkinData> list = new List<ShopFlySkinData>();
		int count = allData.Count;
		for (int i = 0; i < count; i++)
		{
			ShopFlySkinData item = ShopFlySkinData.Create(allData[i]);
			list.Add(item);
		}
		FlySkinBuyDetailViewData flySkinBuyDetailViewData = FlySkinBuyDetailViewData.Create(list);
		flySkinBuyDetailViewData.SetIndex(this.CurrentIndex);
		flySkinBuyDetailViewData.SetPreviewTitle("FlySkinShopTitle_Text");
		PayShopGoods payShopGoods = list[this.CurrentIndex].GetPayShopGoods();
		OnClickPayShopItemLogEvent onClickPayShopItemLogEvent = new OnClickPayShopItemLogEvent();
		onClickPayShopItemLogEvent.i_id = payShopGoods.GetGoodsId();
		onClickPayShopItemLogEvent.i_shop_id = (int)payShopGoods.PayShopId;
		onClickPayShopItemLogEvent.i_tab_id = payShopGoods.GetGoodsData().TabId;
		LogReportController.Instance.LogReport(onClickPayShopItemLogEvent);
		UiManager.Instance.OpenView(EUiViewName.FlySkinBuyDetailView, flySkinBuyDetailViewData, null);
	}

	// Token: 0x0600F6E2 RID: 63202 RVA: 0x00481F04 File Offset: 0x00480104
	[NullableContext(1)]
	public override void Refresh(FlySkinItemContentData data, bool isSelected, int gridIndex)
	{
		ShopFlySkinData shopFlySkinData = data.ShopFlySkinData;
		this.CurrentShopFlySkinData = data;
		this.CurrentIndex = gridIndex;
		this.RefreshRoleTexture(shopFlySkinData);
		this.RefreshWeaponTexture();
		this.RefreshBuyLimitText(shopFlySkinData);
		this.RefreshSubNameText(shopFlySkinData);
		this.RefreshNowPriceText(shopFlySkinData);
		this.RefreshSourcePriceText(shopFlySkinData);
		this.RefreshDiscountTimeText(shopFlySkinData);
		this.RefreshDiscountText(shopFlySkinData);
		this.RefreshBuyItemIcon(shopFlySkinData);
		this.RefreshBuyLimitItemState(shopFlySkinData);
		this.RefreshFinishBuyItemState(shopFlySkinData);
		this.RefreshRedDotState(shopFlySkinData);
		this.RefreshTextureBg(shopFlySkinData);
		this.RefreshTextureTopBg(shopFlySkinData);
		this.RefreshEffectItem(shopFlySkinData);
		this.RefreshExtraReward(shopFlySkinData);
	}

	// Token: 0x0600F6E3 RID: 63203 RVA: 0x00481F98 File Offset: 0x00480198
	[NullableContext(1)]
	private void RefreshEffectItem(ShopFlySkinData data)
	{
		bool uiactive = data.GetFlySkinData().GetSkinGrade() == 1;
		base.GetItem(17).SetUIActive(uiactive);
		base.GetItem(16).SetUIActive(uiactive);
	}

	// Token: 0x0600F6E4 RID: 63204 RVA: 0x00481FD0 File Offset: 0x004801D0
	[NullableContext(1)]
	private void RefreshRedDotState(ShopFlySkinData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x0600F6E5 RID: 63205 RVA: 0x00481FF8 File Offset: 0x004801F8
	[NullableContext(1)]
	private void RefreshBuyLimitItemState(ShopFlySkinData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x0600F6E6 RID: 63206 RVA: 0x0048201C File Offset: 0x0048021C
	[NullableContext(1)]
	private void RefreshFinishBuyItemState(ShopFlySkinData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x0600F6E7 RID: 63207 RVA: 0x00482044 File Offset: 0x00480244
	[NullableContext(1)]
	private void RefreshRoleTexture(ShopFlySkinData data)
	{
		string previewTextureInPayShop = data.GetPreviewTextureInPayShop();
		base.SetTextureByPath(previewTextureInPayShop, base.GetTexture(1), null, null);
	}

	// Token: 0x0600F6E8 RID: 63208 RVA: 0x00482070 File Offset: 0x00480270
	private void RefreshWeaponTexture()
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x0600F6E9 RID: 63209 RVA: 0x00482084 File Offset: 0x00480284
	private void RefreshSourcePriceText(ShopFlySkinData data)
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

	// Token: 0x0600F6EA RID: 63210 RVA: 0x00482118 File Offset: 0x00480318
	private void RefreshNowPriceText(ShopFlySkinData data)
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

	// Token: 0x0600F6EB RID: 63211 RVA: 0x0048217C File Offset: 0x0048037C
	private void RefreshBuyItemIcon(ShopFlySkinData data)
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

	// Token: 0x0600F6EC RID: 63212 RVA: 0x004821DC File Offset: 0x004803DC
	[NullableContext(1)]
	private void RefreshBuyLimitText(ShopFlySkinData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x0600F6ED RID: 63213 RVA: 0x00482204 File Offset: 0x00480404
	[NullableContext(1)]
	private void RefreshSubNameText(ShopFlySkinData data)
	{
		string name = data.GetPayShopGoods().GetItemData().Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
	}

	// Token: 0x0600F6EE RID: 63214 RVA: 0x0048223C File Offset: 0x0048043C
	private void RefreshDiscountTimeText(ShopFlySkinData data)
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
		string text2 = discountTimeData as string;
		if (text2 != null)
		{
			text.SetText(text2, true);
			return;
		}
		CommonDefine.IRemainTime remainTime = discountTimeData as CommonDefine.IRemainTime;
		if (remainTime != null)
		{
			LguiUtil.Instance.SetLocalText(text, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
		}
	}

	// Token: 0x0600F6EF RID: 63215 RVA: 0x004822C8 File Offset: 0x004804C8
	private void RefreshDiscountText(ShopFlySkinData data)
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

	// Token: 0x0600F6F0 RID: 63216 RVA: 0x00482314 File Offset: 0x00480514
	private void RefreshTextureBg(ShopFlySkinData data)
	{
		if (data == null)
		{
			base.GetTexture(14).SetUIActive(false);
			return;
		}
		string resourceId = (data.GetFlySkinData().GetSkinGrade() == 1) ? "T_ShopRoleItemBg1" : "T_ShopRoleItemBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(14), null, null);
	}

	// Token: 0x0600F6F1 RID: 63217 RVA: 0x00482378 File Offset: 0x00480578
	private void RefreshTextureTopBg(ShopFlySkinData data)
	{
		if (data == null)
		{
			base.GetTexture(15).SetUIActive(false);
			return;
		}
		string resourceId = (data.GetFlySkinData().GetSkinGrade() == 1) ? "T_ShopRoleItemTopBg1" : "T_ShopRoleItemTopBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(15), null, null);
	}

	// Token: 0x0600F6F2 RID: 63218 RVA: 0x004823DC File Offset: 0x004805DC
	private void RefreshExtraReward(ShopFlySkinData data)
	{
		UUITexture texture = base.GetTexture(26);
		UUIItem item = base.GetItem(25);
		texture.SetUIActive(true);
		item.SetUIActive(true);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_UiShopSkinIcon_Fly");
		base.SetTextureByPath(resourcePath, texture, null, null);
		UUIItem item2 = base.GetItem(21);
		if (data == null)
		{
			item2.SetUIActive(false);
			return;
		}
		List<TItem> otherReward = data.GetOtherReward();
		TItem? titem = (otherReward.Count > 0) ? new TItem?(otherReward[0]) : null;
		if (titem == null)
		{
			item2.SetUIActive(false);
			return;
		}
		int itemId = titem.Value.ItemData.ItemId;
		int count = titem.Value.Count;
		base.GetItem(27).SetUIActive(true);
		item2.SetUIActive(true);
		base.SetItemIcon(base.GetTexture(22), itemId, null, null);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(count);
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		base.GetText(23).SetText(newText, true);
	}

	// Token: 0x04008A64 RID: 35428
	private FlySkinItemContentData CurrentShopFlySkinData;

	// Token: 0x04008A65 RID: 35429
	private int CurrentIndex;

	// Token: 0x02007A9E RID: 31390
	[NullableContext(0)]
	private enum ESkinItemComponent
	{
		// Token: 0x04027BD6 RID: 162774
		BuyButton,
		// Token: 0x04027BD7 RID: 162775
		RoleTexture,
		// Token: 0x04027BD8 RID: 162776
		TextureWeapon,
		// Token: 0x04027BD9 RID: 162777
		BuyLimitText,
		// Token: 0x04027BDA RID: 162778
		SubNameText,
		// Token: 0x04027BDB RID: 162779
		NowPrice,
		// Token: 0x04027BDC RID: 162780
		BeforePrice,
		// Token: 0x04027BDD RID: 162781
		DiscountItem,
		// Token: 0x04027BDE RID: 162782
		DiscountText,
		// Token: 0x04027BDF RID: 162783
		TimeText,
		// Token: 0x04027BE0 RID: 162784
		BuyItemIcon,
		// Token: 0x04027BE1 RID: 162785
		LimitBuyItem,
		// Token: 0x04027BE2 RID: 162786
		FinishBuyItem,
		// Token: 0x04027BE3 RID: 162787
		NewItem,
		// Token: 0x04027BE4 RID: 162788
		TextureBg,
		// Token: 0x04027BE5 RID: 162789
		TextureTopBg,
		// Token: 0x04027BE6 RID: 162790
		EffectBItem,
		// Token: 0x04027BE7 RID: 162791
		EffectAItem,
		// Token: 0x04027BE8 RID: 162792
		ExtraItemRoot = 21,
		// Token: 0x04027BE9 RID: 162793
		TextureExtraReward,
		// Token: 0x04027BEA RID: 162794
		TextExtraReward,
		// Token: 0x04027BEB RID: 162795
		ItemTypeIcon = 25,
		// Token: 0x04027BEC RID: 162796
		TextureTypeIcon,
		// Token: 0x04027BED RID: 162797
		ItemExtraReward
	}
}
