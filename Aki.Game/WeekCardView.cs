using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023AE RID: 9134
[NullableContext(1)]
[Nullable(0)]
public class WeekCardView : UiTabViewBase
{
	// Token: 0x0601242C RID: 74796 RVA: 0x0047F1A8 File Offset: 0x0047D3A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickHelpButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601242D RID: 74797 RVA: 0x0047F3C0 File Offset: 0x0047D5C0
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveWeekCardDataEvent, new Action(this.OnReceiveMonthCardDataEvent));
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0601242E RID: 74798 RVA: 0x0047F420 File Offset: 0x0047D620
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveWeekCardDataEvent, new Action(this.OnReceiveMonthCardDataEvent));
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0601242F RID: 74799 RVA: 0x0047F480 File Offset: 0x0047D680
	protected override UniTask OnBeforeStartAsync()
	{
		WeekCardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeekCardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012430 RID: 74800 RVA: 0x0047F4C3 File Offset: 0x0047D6C3
	protected override void OnBeforeHide()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x06012431 RID: 74801 RVA: 0x0047F4DC File Offset: 0x0047D6DC
	protected override void OnAfterShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		WeekCardViewModel vm = this.Vm;
		if (vm == null)
		{
			return;
		}
		vm.OnAfterShow();
	}

	// Token: 0x06012432 RID: 74802 RVA: 0x0047F520 File Offset: 0x0047D720
	private bool CheckSdkProductInfoConfirmIfCanShow(int payGiftDataId)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (!((platformSdk != null) ? new bool?(platformSdk.NeedConfirmSdkProductInfo()) : null).GetValueOrDefault())
		{
			return true;
		}
		string productId = PayGiftModel.Instance.GetPayShopGoodsById(payGiftDataId).GetGetPayGiftData().ProductId;
		if (PayItemModel.Instance.GetProductInfoByGoodsId(productId) != null)
		{
			return true;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CannotFindSdkProduct);
		Action value = delegate()
		{
			UiManager.Instance.CloseView(EUiViewName.PayShopRootView, null);
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		this.OpenThirdPartyMessageBox().Forget();
		return false;
	}

	// Token: 0x06012433 RID: 74803 RVA: 0x0047F5DC File Offset: 0x0047D7DC
	private UniTask OpenThirdPartyMessageBox()
	{
		WeekCardView.<OpenThirdPartyMessageBox>d__15 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<WeekCardView.<OpenThirdPartyMessageBox>d__15>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x06012434 RID: 74804 RVA: 0x0047F618 File Offset: 0x0047D818
	private UniTask CreateCardItems()
	{
		WeekCardView.<CreateCardItems>d__16 <CreateCardItems>d__;
		<CreateCardItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCardItems>d__.<>4__this = this;
		<CreateCardItems>d__.<>1__state = -1;
		<CreateCardItems>d__.<>t__builder.Start<WeekCardView.<CreateCardItems>d__16>(ref <CreateCardItems>d__);
		return <CreateCardItems>d__.<>t__builder.Task;
	}

	// Token: 0x06012435 RID: 74805 RVA: 0x0047F65C File Offset: 0x0047D85C
	private UniTask CreateSendCostItem()
	{
		WeekCardView.<CreateSendCostItem>d__17 <CreateSendCostItem>d__;
		<CreateSendCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSendCostItem>d__.<>4__this = this;
		<CreateSendCostItem>d__.<>1__state = -1;
		<CreateSendCostItem>d__.<>t__builder.Start<WeekCardView.<CreateSendCostItem>d__17>(ref <CreateSendCostItem>d__);
		return <CreateSendCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012436 RID: 74806 RVA: 0x0047F69F File Offset: 0x0047D89F
	private void CreateTotalCostItem()
	{
		this.TotalRewardLayout = new GenericLayout<WeekCardCostGrid, IWeekCostData>(base.GetHorizontalLayout(5), () => new WeekCardCostGrid(), null, false, true);
	}

	// Token: 0x06012437 RID: 74807 RVA: 0x0047F6D8 File Offset: 0x0047D8D8
	private UniTask CreateBuyButton()
	{
		WeekCardView.<CreateBuyButton>d__19 <CreateBuyButton>d__;
		<CreateBuyButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBuyButton>d__.<>4__this = this;
		<CreateBuyButton>d__.<>1__state = -1;
		<CreateBuyButton>d__.<>t__builder.Start<WeekCardView.<CreateBuyButton>d__19>(ref <CreateBuyButton>d__);
		return <CreateBuyButton>d__.<>t__builder.Task;
	}

	// Token: 0x06012438 RID: 74808 RVA: 0x0047F71B File Offset: 0x0047D91B
	protected override void OnStart()
	{
		this.RefreshAllView();
	}

	// Token: 0x06012439 RID: 74809 RVA: 0x0047F723 File Offset: 0x0047D923
	private void RefreshAllView()
	{
		this.RefreshCountDown();
		this.RefreshWeekCardItems();
		this.RefreshBuyButton();
		this.RefreshTotalCost();
		this.RefreshSendCostItem();
		this.RefreshPrice();
		this.RefreshTitle();
		this.RefreshDiscountSprite();
	}

	// Token: 0x0601243A RID: 74810 RVA: 0x0047F758 File Offset: 0x0047D958
	private void RefreshDiscountSprite()
	{
		WeekCardViewModel vm = this.Vm;
		base.TrySetSpriteByPath((vm != null) ? vm.GetDiscountTexturePath() : null, base.GetSprite(12), false, null, null);
	}

	// Token: 0x0601243B RID: 74811 RVA: 0x0047F790 File Offset: 0x0047D990
	private bool RefreshCountDown()
	{
		WeekCardViewModel vm = this.Vm;
		double num = (vm != null) ? vm.GetCountDownLeftSec() : 0.0;
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((num > 0.0) ? num : 0.0);
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(4);
		WeekCardViewModel vm2 = this.Vm;
		instance.SetLocalTextNew(text, ((vm2 != null) ? vm2.GetCountDownTextKey() : null) ?? "", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
		WeekCardItem[] weekCardItems = this.WeekCardItems;
		for (int i = 0; i < weekCardItems.Length; i++)
		{
			weekCardItems[i].RefreshTime();
		}
		bool flag = num <= 0.0;
		bool result = flag && !this.CountDownExpired;
		this.CountDownExpired = flag;
		return result;
	}

	// Token: 0x0601243C RID: 74812 RVA: 0x0047F864 File Offset: 0x0047DA64
	private void RefreshWeekCardItems()
	{
		for (int i = 0; i < this.WeekCardItems.Length; i++)
		{
			WeekCardViewModel vm = this.Vm;
			WeekCardContentInfo weekCardContentInfo = (vm != null) ? vm.GetWeekCardContentInfo(i) : null;
			if (weekCardContentInfo != null)
			{
				this.WeekCardItems[i].Refresh(this.Vm, weekCardContentInfo);
			}
		}
	}

	// Token: 0x0601243D RID: 74813 RVA: 0x0047F8B0 File Offset: 0x0047DAB0
	private void RefreshBuyButton()
	{
		WeekCardViewModel vm = this.Vm;
		bool flag = vm != null && vm.IsBuy();
		this.BuyButton.SetEnableClick(!flag);
		ButtonItem buyButton = this.BuyButton;
		WeekCardViewModel vm2 = this.Vm;
		buyButton.SetLocalTextNew(((vm2 != null) ? vm2.GetBuyButtonText() : null) ?? "", Array.Empty<object>());
	}

	// Token: 0x0601243E RID: 74814 RVA: 0x0047F90A File Offset: 0x0047DB0A
	private void RefreshTotalCost()
	{
		GenericLayout<WeekCardCostGrid, IWeekCostData> totalRewardLayout = this.TotalRewardLayout;
		WeekCardViewModel vm = this.Vm;
		totalRewardLayout.RefreshByData(((vm != null) ? vm.GetTotalRewardData() : null) ?? new List<IWeekCostData>(), null, false);
	}

	// Token: 0x0601243F RID: 74815 RVA: 0x0047F934 File Offset: 0x0047DB34
	private void RefreshSendCostItem()
	{
		WeekCardViewModel vm = this.Vm;
		IWeekScoreData weekScoreData = (vm != null) ? vm.GetSendCostItemData() : null;
		if (weekScoreData == null)
		{
			this.SendCostItem.SetUiActive(false);
			return;
		}
		this.SendCostItem.SetUiActive(true);
		this.SendCostItem.Refresh(weekScoreData);
	}

	// Token: 0x06012440 RID: 74816 RVA: 0x0047F97C File Offset: 0x0047DB7C
	private void RefreshPrice()
	{
		UUIText text = base.GetText(9);
		WeekCardViewModel vm = this.Vm;
		text.SetText(((vm != null) ? vm.GetPrice() : null) ?? "", true);
	}

	// Token: 0x06012441 RID: 74817 RVA: 0x0047F9A8 File Offset: 0x0047DBA8
	private void RefreshTitle()
	{
		WeekCardViewModel vm = this.Vm;
		string text = (vm != null) ? vm.GetTitleTextKey() : null;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), text, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), text, Array.Empty<object>());
	}

	// Token: 0x06012442 RID: 74818 RVA: 0x0047FA01 File Offset: 0x0047DC01
	private void OnReceiveMonthCardDataEvent()
	{
		this.RefreshAllView();
	}

	// Token: 0x06012443 RID: 74819 RVA: 0x0047FA0C File Offset: 0x0047DC0C
	private void OnClickHelpButton()
	{
		WeekCardViewModel vm = this.Vm;
		int? num = (vm != null) ? vm.GetHelpGroupId() : null;
		if (num == null)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(num.Value);
	}

	// Token: 0x06012444 RID: 74820 RVA: 0x0047FA4F File Offset: 0x0047DC4F
	private void OnClickBuyButton(int _)
	{
		WeekCardViewModel vm = this.Vm;
		if (vm != null && vm.IsBuy())
		{
			return;
		}
		WeekCardViewModel vm2 = this.Vm;
		if (vm2 == null)
		{
			return;
		}
		vm2.OnBuy();
	}

	// Token: 0x06012445 RID: 74821 RVA: 0x0047FA76 File Offset: 0x0047DC76
	private void OnDiscountShopTimerRefresh()
	{
		if (this.RefreshCountDown())
		{
			this.TryEmitRefreshTips();
		}
	}

	// Token: 0x06012446 RID: 74822 RVA: 0x0047FA86 File Offset: 0x0047DC86
	private void CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult eSdkDialogResult)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x06012447 RID: 74823 RVA: 0x0047FA9D File Offset: 0x0047DC9D
	protected void TryEmitRefreshTips()
	{
		PayShopController.Instance.ClosePayShopGoodDetailPopView();
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, 1, true);
	}

	// Token: 0x040089E8 RID: 35304
	private readonly ButtonItem BuyButton = new ButtonItem(null);

	// Token: 0x040089E9 RID: 35305
	private readonly WeekCardItem[] WeekCardItems = new WeekCardItem[]
	{
		new WeekCardItem(),
		new WeekCardItem(),
		new WeekCardItem()
	};

	// Token: 0x040089EA RID: 35306
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeekCardCostGrid, IWeekCostData> TotalRewardLayout;

	// Token: 0x040089EB RID: 35307
	private readonly WeekCardScoreItem SendCostItem = new WeekCardScoreItem();

	// Token: 0x040089EC RID: 35308
	private EWeekCardKind Kind;

	// Token: 0x040089ED RID: 35309
	[Nullable(2)]
	private WeekCardViewModel Vm;

	// Token: 0x040089EE RID: 35310
	private bool CountDownExpired;

	// Token: 0x0200894A RID: 35146
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402CA0E RID: 182798
		public const int CardItem1 = 0;

		// Token: 0x0402CA0F RID: 182799
		public const int CardItem2 = 1;

		// Token: 0x0402CA10 RID: 182800
		public const int CardItem3 = 2;

		// Token: 0x0402CA11 RID: 182801
		public const int CostItemSend = 3;

		// Token: 0x0402CA12 RID: 182802
		public const int TextLeftTime = 4;

		// Token: 0x0402CA13 RID: 182803
		public const int PanelTotalReward = 5;

		// Token: 0x0402CA14 RID: 182804
		public const int CostItemTotal = 6;

		// Token: 0x0402CA15 RID: 182805
		public const int BtnBuy = 7;

		// Token: 0x0402CA16 RID: 182806
		public const int BtnHelp = 8;

		// Token: 0x0402CA17 RID: 182807
		public const int TextPrice = 9;

		// Token: 0x0402CA18 RID: 182808
		public const int TitleText = 10;

		// Token: 0x0402CA19 RID: 182809
		public const int TitleTextOutline = 11;

		// Token: 0x0402CA1A RID: 182810
		public const int SpriteDiscount = 12;
	}
}
