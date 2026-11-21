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

// Token: 0x0200187E RID: 6270
[NullableContext(2)]
[Nullable(0)]
public class GiftPackageDetailsView : UiViewBase
{
	// Token: 0x0600F83C RID: 63548 RVA: 0x00489EBE File Offset: 0x004880BE
	[NullableContext(1)]
	public GiftPackageDetailsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F83D RID: 63549 RVA: 0x00489ED0 File Offset: 0x004880D0
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

	// Token: 0x0600F83E RID: 63550 RVA: 0x0048A190 File Offset: 0x00488390
	private void CancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F83F RID: 63551 RVA: 0x0048A19C File Offset: 0x0048839C
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

	// Token: 0x0600F840 RID: 63552 RVA: 0x0048A1F4 File Offset: 0x004883F4
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

	// Token: 0x0600F841 RID: 63553 RVA: 0x0048A2DC File Offset: 0x004884DC
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

	// Token: 0x0600F842 RID: 63554 RVA: 0x0048A3FC File Offset: 0x004885FC
	protected override UniTask OnCreateAsync()
	{
		GiftPackageDetailsView.<OnCreateAsync>d__17 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<GiftPackageDetailsView.<OnCreateAsync>d__17>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F843 RID: 63555 RVA: 0x0048A440 File Offset: 0x00488640
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

	// Token: 0x0600F844 RID: 63556 RVA: 0x0048A48B File Offset: 0x0048868B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
	}

	// Token: 0x0600F845 RID: 63557 RVA: 0x0048A4A9 File Offset: 0x004886A9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
	}

	// Token: 0x0600F846 RID: 63558 RVA: 0x0048A4C8 File Offset: 0x004886C8
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

	// Token: 0x0600F847 RID: 63559 RVA: 0x0048A5D4 File Offset: 0x004887D4
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

	// Token: 0x0600F848 RID: 63560 RVA: 0x0048A654 File Offset: 0x00488854
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

	// Token: 0x0600F849 RID: 63561 RVA: 0x0048A694 File Offset: 0x00488894
	private UniTask RefreshCurrency()
	{
		GiftPackageDetailsView.<RefreshCurrency>d__24 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<GiftPackageDetailsView.<RefreshCurrency>d__24>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x0600F84A RID: 63562 RVA: 0x0048A6D7 File Offset: 0x004888D7
	private void RefreshCloudGameTip()
	{
		base.GetItem(9).SetUIActive(this.Goods.HasCloudGameInfo() && !this.Goods.GetIfNeedExtraLimitText());
	}

	// Token: 0x0600F84B RID: 63563 RVA: 0x0048A704 File Offset: 0x00488904
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

	// Token: 0x0600F84C RID: 63564 RVA: 0x0048A82C File Offset: 0x00488A2C
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

	// Token: 0x0600F84D RID: 63565 RVA: 0x0048A8F7 File Offset: 0x00488AF7
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F84E RID: 63566 RVA: 0x0048A900 File Offset: 0x00488B00
	protected override void OnBeforeDestroy()
	{
		if (this.LoadedItem != null)
		{
			this.LoadedItem.Destroy(null);
		}
		this.RemoveResellTimer();
	}

	// Token: 0x0600F84F RID: 63567 RVA: 0x0048A91C File Offset: 0x00488B1C
	protected void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x0600F850 RID: 63568 RVA: 0x0048A940 File Offset: 0x00488B40
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

	// Token: 0x0600F851 RID: 63569 RVA: 0x0048AACD File Offset: 0x00488CCD
	private void SetResellItemShowState(bool state)
	{
		base.GetItem(7).SetUIActive(state);
		this.RefreshDisclaimerText(state);
	}

	// Token: 0x0600F852 RID: 63570 RVA: 0x0048AAE4 File Offset: 0x00488CE4
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

	// Token: 0x0600F853 RID: 63571 RVA: 0x0048AB34 File Offset: 0x00488D34
	protected bool IsEnoughMoney()
	{
		return this.GoodsData.IsDirect() || this.Goods.GetPriceData().Enough;
	}

	// Token: 0x0600F854 RID: 63572 RVA: 0x0048AB58 File Offset: 0x00488D58
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

	// Token: 0x04008AF3 RID: 35571
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

	// Token: 0x04008AF4 RID: 35572
	private PayShopItem PayShopItem;

	// Token: 0x04008AF5 RID: 35573
	private IGiftDisplayItem SkinItem;

	// Token: 0x04008AF6 RID: 35574
	protected PayShopGoods Goods;

	// Token: 0x04008AF7 RID: 35575
	protected PayShopGoodsData GoodsData;

	// Token: 0x04008AF8 RID: 35576
	protected TimerHandle ResellTimerId;

	// Token: 0x04008AF9 RID: 35577
	protected ButtonItem ConfirmBtn;

	// Token: 0x04008AFA RID: 35578
	private EItemFunctionType ItemType = EItemFunctionType.ManualOpenGift;

	// Token: 0x04008AFB RID: 35579
	private UiPanelBase LoadedItem;

	// Token: 0x04008AFC RID: 35580
	private int? Id;

	// Token: 0x02007AC3 RID: 31427
	[NullableContext(0)]
	private class EGiftPackageDetailsViewDefine
	{
		// Token: 0x04027CD8 RID: 163032
		public const int GiftItem = 0;

		// Token: 0x04027CD9 RID: 163033
		public const int GiftDetailItem = 1;

		// Token: 0x04027CDA RID: 163034
		public const int EndTimeItem = 2;

		// Token: 0x04027CDB RID: 163035
		public const int EndTimeText = 3;

		// Token: 0x04027CDC RID: 163036
		public const int CancelButton = 4;

		// Token: 0x04027CDD RID: 163037
		public const int ConfirmButton = 5;

		// Token: 0x04027CDE RID: 163038
		public const int InteractionGroup = 6;

		// Token: 0x04027CDF RID: 163039
		public const int ReSellItem = 7;

		// Token: 0x04027CE0 RID: 163040
		public const int ReSellText = 8;

		// Token: 0x04027CE1 RID: 163041
		public const int CloudGameTip = 9;

		// Token: 0x04027CE2 RID: 163042
		public const int ItemCouponTip = 10;

		// Token: 0x04027CE3 RID: 163043
		public const int TextCouponDiscount = 11;

		// Token: 0x04027CE4 RID: 163044
		public const int TextureCouponIcon = 12;

		// Token: 0x04027CE5 RID: 163045
		public const int DisclaimerPanel = 13;

		// Token: 0x04027CE6 RID: 163046
		public const int DisclaimerText = 14;

		// Token: 0x04027CE7 RID: 163047
		public const int ItemTotalTopUpTips = 15;

		// Token: 0x04027CE8 RID: 163048
		public const int TextTotalTopUpTips = 16;

		// Token: 0x04027CE9 RID: 163049
		public const int TextureTotalTopUpIcon = 17;
	}
}
