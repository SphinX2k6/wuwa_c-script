using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002399 RID: 9113
[NullableContext(2)]
[Nullable(0)]
public class GiftPackageDetailsView : UiViewBase
{
	// Token: 0x0601238A RID: 74634 RVA: 0x0047CA7E File Offset: 0x0047AC7E
	[NullableContext(1)]
	public GiftPackageDetailsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601238B RID: 74635 RVA: 0x0047CA90 File Offset: 0x0047AC90
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.CancelClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601238C RID: 74636 RVA: 0x0047CD50 File Offset: 0x0047AF50
	private void CancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601238D RID: 74637 RVA: 0x0047CD5C File Offset: 0x0047AF5C
	private void ConfirmClick()
	{
		if (this.GoodsData.PayPackageType.GetValueOrDefault() == EPayGiftType.CdkGift)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CdkGiftBuyConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.DoConfirmPurchase);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.DoConfirmPurchase();
	}

	// Token: 0x0601238E RID: 74638 RVA: 0x0047CDB4 File Offset: 0x0047AFB4
	private void DoConfirmPurchase()
	{
		if (this.IsEnoughMoney() && this.GoodsData.IfPayGift())
		{
			PayGiftController.Instance.SdkPay(this.GoodsData.Id);
			base.CloseMe(null);
			return;
		}
		if (this.IsEnoughMoney() && !this.GoodsData.IfPayGift())
		{
			PayShopController.Instance.SendRequestPayShopBuy(this.GoodsData.Id, 1);
			base.CloseMe(null);
			return;
		}
		if (this.GoodsData.Price.Id == 4)
		{
			PayShopController.Instance.OpenPayShopViewToRecharge();
			base.CloseMe(null);
			return;
		}
		TableTextArgNew tableTextArgNew = new TableTextArgNew(InventoryConfig.Instance.GetItemConfig(this.GoodsData.Price.Id).Value.Name, Array.Empty<object>());
		ScrollingTipsController.Instance.ShowTipsById("ShopResourceNotEnough", new object[]
		{
			tableTextArgNew
		});
	}

	// Token: 0x0601238F RID: 74639 RVA: 0x0047CE9C File Offset: 0x0047B09C
	protected override void OnBeforeCreate()
	{
		ExchangePopData exchangePopData = (ExchangePopData)this.OpenParam;
		this.Goods = exchangePopData.PayShopGoods;
		this.GoodsData = this.Goods.GetGoodsData();
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.GoodsData.ItemId);
		this.Id = null;
		foreach (KeyValuePair<int, int> keyValuePair in itemConfigData.Parameters)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (!string.IsNullOrEmpty(Enum.GetName(typeof(EItemFunctionType), key)))
			{
				this.ItemType = (EItemFunctionType)key;
				this.Id = new int?(value);
				break;
			}
		}
		if (this.Id == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "检查道具ID的参数（Parameters）字段 是否 表示为正确的指向道具id的参数";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("道具ID", this.GoodsData.ItemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06012390 RID: 74640 RVA: 0x0047CFBC File Offset: 0x0047B1BC
	protected override UniTask OnCreateAsync()
	{
		GiftPackageDetailsView.<OnCreateAsync>d__17 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<GiftPackageDetailsView.<OnCreateAsync>d__17>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012391 RID: 74641 RVA: 0x0047D000 File Offset: 0x0047B200
	[NullableContext(1)]
	private UniTask InitItem(PayShopGoods data)
	{
		GiftPackageDetailsView.<InitItem>d__18 <InitItem>d__;
		<InitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItem>d__.<>4__this = this;
		<InitItem>d__.data = data;
		<InitItem>d__.<>1__state = -1;
		<InitItem>d__.<>t__builder.Start<GiftPackageDetailsView.<InitItem>d__18>(ref <InitItem>d__);
		return <InitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012392 RID: 74642 RVA: 0x0047D04B File Offset: 0x0047B24B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
	}

	// Token: 0x06012393 RID: 74643 RVA: 0x0047D069 File Offset: 0x0047B269
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
	}

	// Token: 0x06012394 RID: 74644 RVA: 0x0047D088 File Offset: 0x0047B288
	protected override void OnStart()
	{
		if (this.Id == null)
		{
			return;
		}
		this.ConfirmBtn = new ButtonItem(base.GetItem(5));
		this.ConfirmBtn.SetFunction(delegate(int _)
		{
			this.ConfirmClick();
		});
		UUIItem item = base.GetItem(1);
		if (this.ItemType == EItemFunctionType.AutoOpenMonthCard)
		{
			this.LoadedItem = new GiftPackageMonthlyCardItem(this.Id.Value, item);
		}
		else if (this.ItemType == EItemFunctionType.AutoOpenGift || this.ItemType == EItemFunctionType.ManualOpenGift)
		{
			this.LoadedItem = new GiftPackageSupplyPackItem(this.Id.Value, item, this.Goods);
		}
		PayShopItem payShopItem = this.PayShopItem;
		if (payShopItem != null)
		{
			UUIItem originalItem = payShopItem.GetOriginalItem();
			if (originalItem != null)
			{
				originalItem.SetUIParent(base.GetItem(0), false);
			}
		}
		IGiftDisplayItem skinItem = this.SkinItem;
		if (skinItem != null)
		{
			UUIItem originalItem2 = skinItem.GetOriginalItem();
			if (originalItem2 != null)
			{
				originalItem2.SetUIParent(base.GetItem(0), false);
			}
		}
		PayShopItem payShopItem2 = this.PayShopItem;
		if (payShopItem2 != null)
		{
			payShopItem2.SetActive(true);
		}
		IGiftDisplayItem skinItem2 = this.SkinItem;
		if (skinItem2 == null)
		{
			return;
		}
		skinItem2.SetActive(true);
	}

	// Token: 0x06012395 RID: 74645 RVA: 0x0047D194 File Offset: 0x0047B394
	protected override void OnBeforeShow()
	{
		PayShopItem payShopItem = this.PayShopItem;
		if (payShopItem != null)
		{
			payShopItem.HidePackageViewElement();
		}
		this.RefreshPayShopItemLeftTimeTextShowState();
		PayShopItem payShopItem2 = this.PayShopItem;
		if (payShopItem2 != null)
		{
			payShopItem2.Refresh(this.Goods, false, 0);
		}
		IGiftDisplayItem skinItem = this.SkinItem;
		if (skinItem != null)
		{
			skinItem.Refresh(this.Goods, false, 0);
		}
		this.SetInteractionGroup();
		this.RefreshReSellText();
		this.RefreshCurrency().Forget();
		this.RefreshCloudGameTip();
		this.RefreshItemCouponTip();
		this.RefreshTotalTopUpTips();
	}

	// Token: 0x06012396 RID: 74646 RVA: 0x0047D214 File Offset: 0x0047B414
	private void RefreshPayShopItemLeftTimeTextShowState()
	{
		int monthCardShopId = PayShopConfig.Instance.GetMonthCardShopId();
		PayShopGoods goods = this.Goods;
		if (goods != null && goods.GetGoodsId() == monthCardShopId)
		{
			PayShopItem payShopItem = this.PayShopItem;
			if (payShopItem == null)
			{
				return;
			}
			payShopItem.SetLeftTimeTextShowState(true);
		}
	}

	// Token: 0x06012397 RID: 74647 RVA: 0x0047D254 File Offset: 0x0047B454
	private UniTask RefreshCurrency()
	{
		GiftPackageDetailsView.<RefreshCurrency>d__24 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<GiftPackageDetailsView.<RefreshCurrency>d__24>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x06012398 RID: 74648 RVA: 0x0047D297 File Offset: 0x0047B497
	private void RefreshCloudGameTip()
	{
		base.GetItem(9).SetUIActive(this.Goods.HasCloudGameInfo() && !this.Goods.GetIfNeedExtraLimitText());
	}

	// Token: 0x06012399 RID: 74649 RVA: 0x0047D2C4 File Offset: 0x0047B4C4
	private void RefreshItemCouponTip()
	{
		UUIItem item = base.GetItem(10);
		UUITexture texture = base.GetTexture(12);
		UUIText text = base.GetText(11);
		CommonItemData availableCouponItem = this.Goods.GetAvailableCouponItem();
		if (availableCouponItem == null || this.Goods.IsDirect() || !this.Goods.GetPriceData().Enough || this.Goods.GetIfNeedExtraLimitText())
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		int availableCouponDiscount = this.Goods.GetAvailableCouponDiscount();
		int currencyId = this.Goods.GetPriceData().CurrencyId;
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(currencyId);
		string text2 = "<texture=" + ((itemConfig != null) ? itemConfig.GetValueOrDefault().IconSmall : null) + ",0.6/>";
		LguiUtil.Instance.SetLocalTextNew(text, "ItemInfo_50020_Tip", new <>z__ReadOnlyArray<object>(new object[]
		{
			availableCouponDiscount,
			text2
		}));
		base.SetTextureByPath(availableCouponItem.GetConfig().As<ItemInfo>().Value.IconSmall, texture, null, null);
	}

	// Token: 0x0601239A RID: 74650 RVA: 0x0047D3EC File Offset: 0x0047B5EC
	private void RefreshTotalTopUpTips()
	{
		UUIItem item = base.GetItem(15);
		TotalTopUpController instance = TotalTopUpController.Instance;
		TotalTopUpData totalTopUpData = (instance != null) ? instance.GetSingleActivityData() : null;
		if (totalTopUpData == null)
		{
			item.SetUIActive(false);
			return;
		}
		int num = 0;
		int num2;
		if (totalTopUpData.GoodsScoreMap != null && totalTopUpData.GoodsScoreMap.TryGetValue(this.GoodsData.Id, out num2))
		{
			num = num2;
		}
		if (num <= 0)
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		base.GetText(16).SetText(num.ToString(), true);
		UUITexture texture = base.GetTexture(17);
		TotalTopUpData totalTopUpData2 = totalTopUpData;
		string text = (totalTopUpData2.ViewConfig != null) ? totalTopUpData2.ViewConfig.GetValueOrDefault().ScoreIcon : null;
		if (!string.IsNullOrEmpty(text))
		{
			base.SetTextureByPath(text, texture, null, null);
		}
	}

	// Token: 0x0601239B RID: 74651 RVA: 0x0047D4B7 File Offset: 0x0047B6B7
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601239C RID: 74652 RVA: 0x0047D4C0 File Offset: 0x0047B6C0
	protected override void OnBeforeDestroy()
	{
		if (this.LoadedItem != null)
		{
			this.LoadedItem.Destroy(null);
		}
		this.RemoveResellTimer();
	}

	// Token: 0x0601239D RID: 74653 RVA: 0x0047D4DC File Offset: 0x0047B6DC
	protected void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x0601239E RID: 74654 RVA: 0x0047D500 File Offset: 0x0047B700
	private void RefreshReSellText()
	{
		this.RemoveResellTimer();
		string exchangePopViewResellText = this.Goods.GetExchangePopViewResellText();
		if (this.Goods.GetIfNeedExtraLimitText())
		{
			string extraLimitText = this.Goods.GetExtraLimitText();
			if (!string.IsNullOrEmpty(extraLimitText))
			{
				this.SetResellItemShowState(true);
				base.GetText(8).ShowTextNew(extraLimitText);
			}
			return;
		}
		if (!this.Goods.GetPriceData().Enough)
		{
			if (!string.IsNullOrEmpty(exchangePopViewResellText))
			{
				base.GetText(8).ShowTextNew(exchangePopViewResellText);
				return;
			}
			this.SetResellItemShowState(true);
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.Goods.GetPriceData().CurrencyId);
			if (itemConfigData != null)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.Goods.GetPriceData().CurrencyId, 0);
				int num = this.Goods.GetPriceData().NowPrice - itemCountByConfigId;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "CurrencyNotEnoughDetailed", new <>z__ReadOnlyArray<object>(new object[]
				{
					localTextNew,
					num
				}));
			}
			return;
		}
		else
		{
			ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Goods.GetCountDownData();
			if (countDownData.Item1 != EPayCountTimeType.Resell)
			{
				this.SetResellItemShowState(false);
				base.GetText(8).SetUIActive(false);
				return;
			}
			this.SetResellItemShowState(true);
			if (!string.IsNullOrEmpty(exchangePopViewResellText))
			{
				base.GetText(8).ShowTextNew(exchangePopViewResellText);
			}
			this.ResellTimerId = TimerSystem.RealTimeInstance.Delay(delegate(float _)
			{
				this.RefreshReSellText();
			}, (float)countDownData.Item3 * 1000f, null, null, true, 1f);
			return;
		}
	}

	// Token: 0x0601239F RID: 74655 RVA: 0x0047D68D File Offset: 0x0047B88D
	private void SetResellItemShowState(bool state)
	{
		base.GetItem(7).SetUIActive(state);
		this.RefreshDisclaimerText(state);
	}

	// Token: 0x060123A0 RID: 74656 RVA: 0x0047D6A4 File Offset: 0x0047B8A4
	private void RefreshDisclaimerText(bool resellItemShowState)
	{
		PayShopGoodsData goodsData = this.GoodsData;
		string text = (goodsData != null) ? goodsData.DisclaimerText : null;
		bool flag = !string.IsNullOrEmpty(text) && !resellItemShowState;
		base.GetItem(13).SetUIActive(flag);
		if (flag)
		{
			base.GetText(14).SetText(text, true);
		}
	}

	// Token: 0x060123A1 RID: 74657 RVA: 0x0047D6F4 File Offset: 0x0047B8F4
	protected bool IsEnoughMoney()
	{
		return this.GoodsData.IsDirect() || this.Goods.GetPriceData().Enough;
	}

	// Token: 0x060123A2 RID: 74658 RVA: 0x0047D718 File Offset: 0x0047B918
	protected void SetInteractionGroup()
	{
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(6);
		IPriceData priceData = this.Goods.GetPriceData();
		bool flag = priceData.CurrencyId != 4 && !priceData.Enough;
		if (this.Goods.IsLocked() || this.Goods.IsSoldOut() || !this.Goods.IfCanBuy() || flag)
		{
			interactionGroup.SetInteractable(false);
			return;
		}
		interactionGroup.SetInteractable(true);
		ButtonItem confirmBtn = this.ConfirmBtn;
		if (confirmBtn == null)
		{
			return;
		}
		confirmBtn.SetLocalTextNew(priceData.Enough ? "PrefabTextItem_2105804973_Text" : "CurrencyNotEnoughGo", Array.Empty<object>());
	}

	// Token: 0x040089AC RID: 35244
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly IGiftItemRegistryEntry[] GiftItemRegistry = new IGiftItemRegistryEntry[]
	{
		new IGiftItemRegistryEntry
		{
			Check = ((PayShopGoods data) => data.CheckIfRoleSkinGoods()),
			Resource = "UiItem_ShopSkinItem",
			Create = (() => new PayShopSkinItem())
		},
		new IGiftItemRegistryEntry
		{
			Check = ((PayShopGoods data) => data.CheckIfFlySkinGoods()),
			Resource = "UiItem_ShopSkinItem",
			Create = (() => new PayShopFlySkinItem())
		},
		new IGiftItemRegistryEntry
		{
			Check = ((PayShopGoods data) => data.CheckIfOrnamentGoods()),
			Resource = "UiItem_ShopSkinItem",
			Create = (() => new PayShopOrnamentItem())
		}
	};

	// Token: 0x040089AD RID: 35245
	private PayShopItem PayShopItem;

	// Token: 0x040089AE RID: 35246
	private IGiftDisplayItem SkinItem;

	// Token: 0x040089AF RID: 35247
	protected PayShopGoods Goods;

	// Token: 0x040089B0 RID: 35248
	protected PayShopGoodsData GoodsData;

	// Token: 0x040089B1 RID: 35249
	protected TimerHandle ResellTimerId;

	// Token: 0x040089B2 RID: 35250
	protected ButtonItem ConfirmBtn;

	// Token: 0x040089B3 RID: 35251
	private EItemFunctionType ItemType = EItemFunctionType.ManualOpenGift;

	// Token: 0x040089B4 RID: 35252
	private UiPanelBase LoadedItem;

	// Token: 0x040089B5 RID: 35253
	private int? Id;

	// Token: 0x02008938 RID: 35128
	[NullableContext(0)]
	private class EGiftPackageDetailsViewDefine
	{
		// Token: 0x0402C9BA RID: 182714
		public const int GiftItem = 0;

		// Token: 0x0402C9BB RID: 182715
		public const int GiftDetailItem = 1;

		// Token: 0x0402C9BC RID: 182716
		public const int EndTimeItem = 2;

		// Token: 0x0402C9BD RID: 182717
		public const int EndTimeText = 3;

		// Token: 0x0402C9BE RID: 182718
		public const int CancelButton = 4;

		// Token: 0x0402C9BF RID: 182719
		public const int ConfirmButton = 5;

		// Token: 0x0402C9C0 RID: 182720
		public const int InteractionGroup = 6;

		// Token: 0x0402C9C1 RID: 182721
		public const int ReSellItem = 7;

		// Token: 0x0402C9C2 RID: 182722
		public const int ReSellText = 8;

		// Token: 0x0402C9C3 RID: 182723
		public const int CloudGameTip = 9;

		// Token: 0x0402C9C4 RID: 182724
		public const int ItemCouponTip = 10;

		// Token: 0x0402C9C5 RID: 182725
		public const int TextCouponDiscount = 11;

		// Token: 0x0402C9C6 RID: 182726
		public const int TextureCouponIcon = 12;

		// Token: 0x0402C9C7 RID: 182727
		public const int DisclaimerPanel = 13;

		// Token: 0x0402C9C8 RID: 182728
		public const int DisclaimerText = 14;

		// Token: 0x0402C9C9 RID: 182729
		public const int ItemTotalTopUpTips = 15;

		// Token: 0x0402C9CA RID: 182730
		public const int TextTotalTopUpTips = 16;

		// Token: 0x0402C9CB RID: 182731
		public const int TextureTotalTopUpIcon = 17;
	}
}
