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

// Token: 0x02001893 RID: 6291
[NullableContext(1)]
[Nullable(0)]
public class WeekCardView : UiTabViewBase
{
	// Token: 0x0600F8DE RID: 63710 RVA: 0x0048C67C File Offset: 0x0048A87C
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

	// Token: 0x0600F8DF RID: 63711 RVA: 0x0048C894 File Offset: 0x0048AA94
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveWeekCardDataEvent, new Action(this.OnReceiveMonthCardDataEvent));
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0600F8E0 RID: 63712 RVA: 0x0048C8F4 File Offset: 0x0048AAF4
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveWeekCardDataEvent, new Action(this.OnReceiveMonthCardDataEvent));
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0600F8E1 RID: 63713 RVA: 0x0048C954 File Offset: 0x0048AB54
	protected override UniTask OnBeforeStartAsync()
	{
		WeekCardView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeekCardView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8E2 RID: 63714 RVA: 0x0048C997 File Offset: 0x0048AB97
	protected override void OnBeforeHide()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x0600F8E3 RID: 63715 RVA: 0x0048C9B0 File Offset: 0x0048ABB0
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

	// Token: 0x0600F8E4 RID: 63716 RVA: 0x0048C9F4 File Offset: 0x0048ABF4
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

	// Token: 0x0600F8E5 RID: 63717 RVA: 0x0048CAB0 File Offset: 0x0048ACB0
	private UniTask OpenThirdPartyMessageBox()
	{
		WeekCardView.<OpenThirdPartyMessageBox>d__15 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<WeekCardView.<OpenThirdPartyMessageBox>d__15>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8E6 RID: 63718 RVA: 0x0048CAEC File Offset: 0x0048ACEC
	private UniTask CreateCardItems()
	{
		WeekCardView.<CreateCardItems>d__16 <CreateCardItems>d__;
		<CreateCardItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCardItems>d__.<>4__this = this;
		<CreateCardItems>d__.<>1__state = -1;
		<CreateCardItems>d__.<>t__builder.Start<WeekCardView.<CreateCardItems>d__16>(ref <CreateCardItems>d__);
		return <CreateCardItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8E7 RID: 63719 RVA: 0x0048CB30 File Offset: 0x0048AD30
	private UniTask CreateSendCostItem()
	{
		WeekCardView.<CreateSendCostItem>d__17 <CreateSendCostItem>d__;
		<CreateSendCostItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSendCostItem>d__.<>4__this = this;
		<CreateSendCostItem>d__.<>1__state = -1;
		<CreateSendCostItem>d__.<>t__builder.Start<WeekCardView.<CreateSendCostItem>d__17>(ref <CreateSendCostItem>d__);
		return <CreateSendCostItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8E8 RID: 63720 RVA: 0x0048CB73 File Offset: 0x0048AD73
	private void CreateTotalCostItem()
	{
		this.TotalRewardLayout = new GenericLayout<WeekCardCostGrid, IWeekCostData>(base.GetHorizontalLayout(5), () => new WeekCardCostGrid(), null, false, true);
	}

	// Token: 0x0600F8E9 RID: 63721 RVA: 0x0048CBAC File Offset: 0x0048ADAC
	private UniTask CreateBuyButton()
	{
		WeekCardView.<CreateBuyButton>d__19 <CreateBuyButton>d__;
		<CreateBuyButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateBuyButton>d__.<>4__this = this;
		<CreateBuyButton>d__.<>1__state = -1;
		<CreateBuyButton>d__.<>t__builder.Start<WeekCardView.<CreateBuyButton>d__19>(ref <CreateBuyButton>d__);
		return <CreateBuyButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600F8EA RID: 63722 RVA: 0x0048CBEF File Offset: 0x0048ADEF
	protected override void OnStart()
	{
		this.RefreshAllView();
	}

	// Token: 0x0600F8EB RID: 63723 RVA: 0x0048CBF7 File Offset: 0x0048ADF7
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

	// Token: 0x0600F8EC RID: 63724 RVA: 0x0048CC2C File Offset: 0x0048AE2C
	private void RefreshDiscountSprite()
	{
		WeekCardViewModel vm = this.Vm;
		base.TrySetSpriteByPath((vm != null) ? vm.GetDiscountTexturePath() : null, base.GetSprite(12), false, null, null);
	}

	// Token: 0x0600F8ED RID: 63725 RVA: 0x0048CC64 File Offset: 0x0048AE64
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

	// Token: 0x0600F8EE RID: 63726 RVA: 0x0048CD38 File Offset: 0x0048AF38
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

	// Token: 0x0600F8EF RID: 63727 RVA: 0x0048CD84 File Offset: 0x0048AF84
	private void RefreshBuyButton()
	{
		WeekCardViewModel vm = this.Vm;
		bool flag = vm != null && vm.IsBuy();
		this.BuyButton.SetEnableClick(!flag);
		ButtonItem buyButton = this.BuyButton;
		WeekCardViewModel vm2 = this.Vm;
		buyButton.SetLocalTextNew(((vm2 != null) ? vm2.GetBuyButtonText() : null) ?? "", Array.Empty<object>());
	}

	// Token: 0x0600F8F0 RID: 63728 RVA: 0x0048CDDE File Offset: 0x0048AFDE
	private void RefreshTotalCost()
	{
		GenericLayout<WeekCardCostGrid, IWeekCostData> totalRewardLayout = this.TotalRewardLayout;
		WeekCardViewModel vm = this.Vm;
		totalRewardLayout.RefreshByData(((vm != null) ? vm.GetTotalRewardData() : null) ?? new List<IWeekCostData>(), null, false);
	}

	// Token: 0x0600F8F1 RID: 63729 RVA: 0x0048CE08 File Offset: 0x0048B008
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

	// Token: 0x0600F8F2 RID: 63730 RVA: 0x0048CE50 File Offset: 0x0048B050
	private void RefreshPrice()
	{
		UUIText text = base.GetText(9);
		WeekCardViewModel vm = this.Vm;
		text.SetText(((vm != null) ? vm.GetPrice() : null) ?? "", true);
	}

	// Token: 0x0600F8F3 RID: 63731 RVA: 0x0048CE7C File Offset: 0x0048B07C
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

	// Token: 0x0600F8F4 RID: 63732 RVA: 0x0048CED5 File Offset: 0x0048B0D5
	private void OnReceiveMonthCardDataEvent()
	{
		this.RefreshAllView();
	}

	// Token: 0x0600F8F5 RID: 63733 RVA: 0x0048CEE0 File Offset: 0x0048B0E0
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

	// Token: 0x0600F8F6 RID: 63734 RVA: 0x0048CF23 File Offset: 0x0048B123
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

	// Token: 0x0600F8F7 RID: 63735 RVA: 0x0048CF4A File Offset: 0x0048B14A
	private void OnDiscountShopTimerRefresh()
	{
		if (this.RefreshCountDown())
		{
			this.TryEmitRefreshTips();
		}
	}

	// Token: 0x0600F8F8 RID: 63736 RVA: 0x0048CF5A File Offset: 0x0048B15A
	private void CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult eSdkDialogResult)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x0600F8F9 RID: 63737 RVA: 0x0048CF71 File Offset: 0x0048B171
	protected void TryEmitRefreshTips()
	{
		PayShopController.Instance.ClosePayShopGoodDetailPopView();
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, 1, true);
	}

	// Token: 0x04008B2F RID: 35631
	private readonly ButtonItem BuyButton = new ButtonItem(null);

	// Token: 0x04008B30 RID: 35632
	private readonly WeekCardItem[] WeekCardItems = new WeekCardItem[]
	{
		new WeekCardItem(),
		new WeekCardItem(),
		new WeekCardItem()
	};

	// Token: 0x04008B31 RID: 35633
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeekCardCostGrid, IWeekCostData> TotalRewardLayout;

	// Token: 0x04008B32 RID: 35634
	private readonly WeekCardScoreItem SendCostItem = new WeekCardScoreItem();

	// Token: 0x04008B33 RID: 35635
	private EWeekCardKind Kind;

	// Token: 0x04008B34 RID: 35636
	[Nullable(2)]
	private WeekCardViewModel Vm;

	// Token: 0x04008B35 RID: 35637
	private bool CountDownExpired;

	// Token: 0x02007AD3 RID: 31443
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04027D29 RID: 163113
		public const int CardItem1 = 0;

		// Token: 0x04027D2A RID: 163114
		public const int CardItem2 = 1;

		// Token: 0x04027D2B RID: 163115
		public const int CardItem3 = 2;

		// Token: 0x04027D2C RID: 163116
		public const int CostItemSend = 3;

		// Token: 0x04027D2D RID: 163117
		public const int TextLeftTime = 4;

		// Token: 0x04027D2E RID: 163118
		public const int PanelTotalReward = 5;

		// Token: 0x04027D2F RID: 163119
		public const int CostItemTotal = 6;

		// Token: 0x04027D30 RID: 163120
		public const int BtnBuy = 7;

		// Token: 0x04027D31 RID: 163121
		public const int BtnHelp = 8;

		// Token: 0x04027D32 RID: 163122
		public const int TextPrice = 9;

		// Token: 0x04027D33 RID: 163123
		public const int TitleText = 10;

		// Token: 0x04027D34 RID: 163124
		public const int TitleTextOutline = 11;

		// Token: 0x04027D35 RID: 163125
		public const int SpriteDiscount = 12;
	}
}
