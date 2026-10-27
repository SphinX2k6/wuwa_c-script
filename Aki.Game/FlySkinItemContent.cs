using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002378 RID: 9080
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FlySkinItemContent : GridProxyAbstract<FlySkinItemContentData>
{
	// Token: 0x06012230 RID: 74288 RVA: 0x00474A54 File Offset: 0x00472C54
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

	// Token: 0x06012231 RID: 74289 RVA: 0x00474CB0 File Offset: 0x00472EB0
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

	// Token: 0x06012232 RID: 74290 RVA: 0x00474D84 File Offset: 0x00472F84
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

	// Token: 0x06012233 RID: 74291 RVA: 0x00474E18 File Offset: 0x00473018
	[NullableContext(1)]
	private void RefreshEffectItem(ShopFlySkinData data)
	{
		bool uiactive = data.GetFlySkinData().GetSkinGrade() == 1;
		base.GetItem(17).SetUIActive(uiactive);
		base.GetItem(16).SetUIActive(uiactive);
	}

	// Token: 0x06012234 RID: 74292 RVA: 0x00474E50 File Offset: 0x00473050
	[NullableContext(1)]
	private void RefreshRedDotState(ShopFlySkinData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x06012235 RID: 74293 RVA: 0x00474E78 File Offset: 0x00473078
	[NullableContext(1)]
	private void RefreshBuyLimitItemState(ShopFlySkinData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x06012236 RID: 74294 RVA: 0x00474E9C File Offset: 0x0047309C
	[NullableContext(1)]
	private void RefreshFinishBuyItemState(ShopFlySkinData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x06012237 RID: 74295 RVA: 0x00474EC4 File Offset: 0x004730C4
	[NullableContext(1)]
	private void RefreshRoleTexture(ShopFlySkinData data)
	{
		string previewTextureInPayShop = data.GetPreviewTextureInPayShop();
		base.SetTextureByPath(previewTextureInPayShop, base.GetTexture(1), null, null);
	}

	// Token: 0x06012238 RID: 74296 RVA: 0x00474EF0 File Offset: 0x004730F0
	private void RefreshWeaponTexture()
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x06012239 RID: 74297 RVA: 0x00474F04 File Offset: 0x00473104
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

	// Token: 0x0601223A RID: 74298 RVA: 0x00474F98 File Offset: 0x00473198
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

	// Token: 0x0601223B RID: 74299 RVA: 0x00474FFC File Offset: 0x004731FC
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

	// Token: 0x0601223C RID: 74300 RVA: 0x0047505C File Offset: 0x0047325C
	[NullableContext(1)]
	private void RefreshBuyLimitText(ShopFlySkinData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x0601223D RID: 74301 RVA: 0x00475084 File Offset: 0x00473284
	[NullableContext(1)]
	private void RefreshSubNameText(ShopFlySkinData data)
	{
		string name = data.GetPayShopGoods().GetItemData().Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
	}

	// Token: 0x0601223E RID: 74302 RVA: 0x004750BC File Offset: 0x004732BC
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

	// Token: 0x0601223F RID: 74303 RVA: 0x00475148 File Offset: 0x00473348
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

	// Token: 0x06012240 RID: 74304 RVA: 0x00475194 File Offset: 0x00473394
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

	// Token: 0x06012241 RID: 74305 RVA: 0x004751F8 File Offset: 0x004733F8
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

	// Token: 0x06012242 RID: 74306 RVA: 0x0047525C File Offset: 0x0047345C
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

	// Token: 0x0400891F RID: 35103
	private FlySkinItemContentData CurrentShopFlySkinData;

	// Token: 0x04008920 RID: 35104
	private int CurrentIndex;

	// Token: 0x02008914 RID: 35092
	[NullableContext(0)]
	private enum ESkinItemComponent
	{
		// Token: 0x0402C8BE RID: 182462
		BuyButton,
		// Token: 0x0402C8BF RID: 182463
		RoleTexture,
		// Token: 0x0402C8C0 RID: 182464
		TextureWeapon,
		// Token: 0x0402C8C1 RID: 182465
		BuyLimitText,
		// Token: 0x0402C8C2 RID: 182466
		SubNameText,
		// Token: 0x0402C8C3 RID: 182467
		NowPrice,
		// Token: 0x0402C8C4 RID: 182468
		BeforePrice,
		// Token: 0x0402C8C5 RID: 182469
		DiscountItem,
		// Token: 0x0402C8C6 RID: 182470
		DiscountText,
		// Token: 0x0402C8C7 RID: 182471
		TimeText,
		// Token: 0x0402C8C8 RID: 182472
		BuyItemIcon,
		// Token: 0x0402C8C9 RID: 182473
		LimitBuyItem,
		// Token: 0x0402C8CA RID: 182474
		FinishBuyItem,
		// Token: 0x0402C8CB RID: 182475
		NewItem,
		// Token: 0x0402C8CC RID: 182476
		TextureBg,
		// Token: 0x0402C8CD RID: 182477
		TextureTopBg,
		// Token: 0x0402C8CE RID: 182478
		EffectBItem,
		// Token: 0x0402C8CF RID: 182479
		EffectAItem,
		// Token: 0x0402C8D0 RID: 182480
		ExtraItemRoot = 21,
		// Token: 0x0402C8D1 RID: 182481
		TextureExtraReward,
		// Token: 0x0402C8D2 RID: 182482
		TextExtraReward,
		// Token: 0x0402C8D3 RID: 182483
		ItemTypeIcon = 25,
		// Token: 0x0402C8D4 RID: 182484
		TextureTypeIcon,
		// Token: 0x0402C8D5 RID: 182485
		ItemExtraReward
	}
}
