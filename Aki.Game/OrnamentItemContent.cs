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

// Token: 0x0200237B RID: 9083
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OrnamentItemContent : GridProxyAbstract<OrnamentItemContentData>
{
	// Token: 0x0601224C RID: 74316 RVA: 0x004754D0 File Offset: 0x004736D0
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

	// Token: 0x0601224D RID: 74317 RVA: 0x004757A0 File Offset: 0x004739A0
	protected override UniTask OnBeforeStartAsync()
	{
		OrnamentItemContent.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OrnamentItemContent.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601224E RID: 74318 RVA: 0x004757E4 File Offset: 0x004739E4
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

	// Token: 0x0601224F RID: 74319 RVA: 0x00475864 File Offset: 0x00473A64
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

	// Token: 0x06012250 RID: 74320 RVA: 0x0047595C File Offset: 0x00473B5C
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

	// Token: 0x06012251 RID: 74321 RVA: 0x00475995 File Offset: 0x00473B95
	[NullableContext(1)]
	private void RefreshEffectItem(ShopRoleOrnamentData data)
	{
		base.GetItem(17).SetUIActive(false);
		base.GetItem(16).SetUIActive(false);
	}

	// Token: 0x06012252 RID: 74322 RVA: 0x004759B4 File Offset: 0x00473BB4
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

	// Token: 0x06012253 RID: 74323 RVA: 0x00475A98 File Offset: 0x00473C98
	[NullableContext(1)]
	private void RefreshRedDotState(ShopRoleOrnamentData data)
	{
		bool ifNeedRemind = data.GetCurrentGoodsData().GetIfNeedRemind();
		base.GetItem(13).SetUIActive(ifNeedRemind);
	}

	// Token: 0x06012254 RID: 74324 RVA: 0x00475AC0 File Offset: 0x00473CC0
	[NullableContext(1)]
	private void RefreshBuyLimitItemState(ShopRoleOrnamentData data)
	{
		bool ifCanBuy = data.GetIfCanBuy();
		base.GetItem(11).SetUIActive(ifCanBuy);
	}

	// Token: 0x06012255 RID: 74325 RVA: 0x00475AE4 File Offset: 0x00473CE4
	[NullableContext(1)]
	private void RefreshFinishBuyItemState(ShopRoleOrnamentData data)
	{
		bool uiactive = !data.GetIfCanBuy();
		base.GetItem(12).SetUIActive(uiactive);
	}

	// Token: 0x06012256 RID: 74326 RVA: 0x00475B0C File Offset: 0x00473D0C
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

	// Token: 0x06012257 RID: 74327 RVA: 0x00475B4C File Offset: 0x00473D4C
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

	// Token: 0x06012258 RID: 74328 RVA: 0x00475BE0 File Offset: 0x00473DE0
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

	// Token: 0x06012259 RID: 74329 RVA: 0x00475C40 File Offset: 0x00473E40
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

	// Token: 0x0601225A RID: 74330 RVA: 0x00475CA0 File Offset: 0x00473EA0
	[NullableContext(1)]
	private void RefreshBuyLimitText(ShopRoleOrnamentData data)
	{
		string shopTipsText = data.GetPayShopGoods().GetShopTipsText();
		base.GetText(3).SetText(shopTipsText, true);
	}

	// Token: 0x0601225B RID: 74331 RVA: 0x00475CC8 File Offset: 0x00473EC8
	[NullableContext(1)]
	private void RefreshSubNameText(ShopRoleOrnamentData data)
	{
		string titleName = data.GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), titleName, Array.Empty<object>());
	}

	// Token: 0x0601225C RID: 74332 RVA: 0x00475CF4 File Offset: 0x00473EF4
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

	// Token: 0x0601225D RID: 74333 RVA: 0x00475D40 File Offset: 0x00473F40
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

	// Token: 0x0601225E RID: 74334 RVA: 0x00475D8C File Offset: 0x00473F8C
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

	// Token: 0x0601225F RID: 74335 RVA: 0x00475DD8 File Offset: 0x00473FD8
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

	// Token: 0x06012260 RID: 74336 RVA: 0x00475E50 File Offset: 0x00474050
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

	// Token: 0x06012261 RID: 74337 RVA: 0x00475F04 File Offset: 0x00474104
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

	// Token: 0x04008926 RID: 35110
	private OrnamentItemContentData CurrentData;

	// Token: 0x04008927 RID: 35111
	private ShopRoleOrnamentData CurrentOrnamentData;

	// Token: 0x04008928 RID: 35112
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x02008916 RID: 35094
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402C8DA RID: 182490
		BuyButton,
		// Token: 0x0402C8DB RID: 182491
		RoleTexture,
		// Token: 0x0402C8DC RID: 182492
		TextureWeapon,
		// Token: 0x0402C8DD RID: 182493
		BuyLimitText,
		// Token: 0x0402C8DE RID: 182494
		SubNameText,
		// Token: 0x0402C8DF RID: 182495
		NowPrice,
		// Token: 0x0402C8E0 RID: 182496
		BeforePrice,
		// Token: 0x0402C8E1 RID: 182497
		DiscountItem,
		// Token: 0x0402C8E2 RID: 182498
		DiscountText,
		// Token: 0x0402C8E3 RID: 182499
		TimeText,
		// Token: 0x0402C8E4 RID: 182500
		BuyItemIcon,
		// Token: 0x0402C8E5 RID: 182501
		LimitBuyItem,
		// Token: 0x0402C8E6 RID: 182502
		FinishBuyItem,
		// Token: 0x0402C8E7 RID: 182503
		NewItem,
		// Token: 0x0402C8E8 RID: 182504
		TextureBg,
		// Token: 0x0402C8E9 RID: 182505
		TextureTopBg,
		// Token: 0x0402C8EA RID: 182506
		EffectBItem,
		// Token: 0x0402C8EB RID: 182507
		EffectAItem,
		// Token: 0x0402C8EC RID: 182508
		ItemCoupon,
		// Token: 0x0402C8ED RID: 182509
		TextCoupon,
		// Token: 0x0402C8EE RID: 182510
		TextureCoupon,
		// Token: 0x0402C8EF RID: 182511
		ExtraItemRoot,
		// Token: 0x0402C8F0 RID: 182512
		TextureExtraReward,
		// Token: 0x0402C8F1 RID: 182513
		TextExtraReward,
		// Token: 0x0402C8F2 RID: 182514
		ItemDiscountSprite,
		// Token: 0x0402C8F3 RID: 182515
		ItemTypeRoot,
		// Token: 0x0402C8F4 RID: 182516
		TextureItemType,
		// Token: 0x0402C8F5 RID: 182517
		ItemRewardRoot,
		// Token: 0x0402C8F6 RID: 182518
		ItemTagRoot
	}
}
