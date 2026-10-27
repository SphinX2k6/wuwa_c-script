using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002350 RID: 9040
[NullableContext(2)]
[Nullable(0)]
public class MonthCardView : UiTabViewBase
{
	// Token: 0x06011FF3 RID: 73715 RVA: 0x004699E0 File Offset: 0x00467BE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedHelpButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011FF4 RID: 73716 RVA: 0x00469BF8 File Offset: 0x00467DF8
	protected override UniTask OnBeforeStartAsync()
	{
		MonthCardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MonthCardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011FF5 RID: 73717 RVA: 0x00469C3C File Offset: 0x00467E3C
	private UniTask BuildRewardItems()
	{
		MonthCardView.<BuildRewardItems>d__9 <BuildRewardItems>d__;
		<BuildRewardItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BuildRewardItems>d__.<>4__this = this;
		<BuildRewardItems>d__.<>1__state = -1;
		<BuildRewardItems>d__.<>t__builder.Start<MonthCardView.<BuildRewardItems>d__9>(ref <BuildRewardItems>d__);
		return <BuildRewardItems>d__.<>t__builder.Task;
	}

	// Token: 0x06011FF6 RID: 73718 RVA: 0x00469C7F File Offset: 0x00467E7F
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult.No);
	}

	// Token: 0x06011FF7 RID: 73719 RVA: 0x00469C90 File Offset: 0x00467E90
	protected override void OnStart()
	{
		this.BuyButtonItem = new ButtonAndTextItem(base.GetItem(4));
		this.BuyButtonItem.BindCallback(new Action(this.OnClickedBuyButton));
		TItem? localOnceReward = MonthCardModel.Instance.LocalOnceReward;
		TItem? localDailyReward = MonthCardModel.Instance.LocalDailyReward;
		this.OnceRewardItem.Refresh(localOnceReward.Value.ItemData.ItemId, localOnceReward.Value.Count);
		this.DailyRewardItem.Refresh(localDailyReward.Value.ItemData.ItemId, localDailyReward.Value.Count);
		this.OnReceiveMonthCardData();
		this.RefreshPrice();
		this.RefreshCloudGameInfo();
		base.GetText(9).ShowTextNew("MonthCardDes_1");
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Loop", false, null, false);
		TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
		if (totalTopUpTagItem == null)
		{
			return;
		}
		totalTopUpTagItem.RefreshByGoodsId(42);
	}

	// Token: 0x06011FF8 RID: 73720 RVA: 0x00469D8C File Offset: 0x00467F8C
	private bool CheckSdkProductInfoConfirmIfCanShow()
	{
		if (!PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedConfirmSdkProductInfo())
		{
			return true;
		}
		string productId = PayGiftModel.Instance.GetPayShopGoodsById(42).GetGetPayGiftData().ProductId;
		if (PayItemModel.Instance.GetProductInfoByGoodsId(productId) != null)
		{
			return true;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CannotFindSdkProduct);
		confirmBoxDataNew.FunctionMap.Add(1, new Action(MonthCardView.<CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|12_0));
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		this.OpenThirdPartyMessageBox().Forget();
		return false;
	}

	// Token: 0x06011FF9 RID: 73721 RVA: 0x00469E14 File Offset: 0x00468014
	private UniTask OpenThirdPartyMessageBox()
	{
		MonthCardView.<OpenThirdPartyMessageBox>d__13 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<MonthCardView.<OpenThirdPartyMessageBox>d__13>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x06011FFA RID: 73722 RVA: 0x00469E50 File Offset: 0x00468050
	private void RefreshPrice()
	{
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		base.GetText(3).SetText(payShopGoodsById.GetDirectPriceText(), true);
	}

	// Token: 0x06011FFB RID: 73723 RVA: 0x00469E80 File Offset: 0x00468080
	private void RefreshCloudGameInfo()
	{
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		bool flag = payShopGoodsById.HasCloudGameInfo();
		UUIText text = base.GetText(10);
		UUITexture texture = base.GetTexture(11);
		text.SetUIActive(flag);
		texture.SetUIActive(flag);
		if (flag)
		{
			text.SetText(payShopGoodsById.GetCloudGameDesc(), true);
			base.SetTextureShowUntilLoaded(payShopGoodsById.GetCloudGameIcon(), texture, null);
		}
	}

	// Token: 0x06011FFC RID: 73724 RVA: 0x00469EDF File Offset: 0x004680DF
	protected override void OnBeforeHide()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x06011FFD RID: 73725 RVA: 0x00469EF5 File Offset: 0x004680F5
	protected override void OnBeforeDestroy()
	{
		ButtonAndTextItem buyButtonItem = this.BuyButtonItem;
		if (buyButtonItem != null)
		{
			buyButtonItem.Destroy(null);
		}
		this.BuyButtonItem = null;
	}

	// Token: 0x06011FFE RID: 73726 RVA: 0x00469F10 File Offset: 0x00468110
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x06011FFF RID: 73727 RVA: 0x00469F20 File Offset: 0x00468120
	private void OnClickedBuyButton()
	{
		if (!this.CanBuyMonthCard)
		{
			return;
		}
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		PayGiftController.Instance.SdkPay(payShopGoodsById.GetGoodsData().Id);
	}

	// Token: 0x06012000 RID: 73728 RVA: 0x00469F58 File Offset: 0x00468158
	private void OnReceiveMonthCardData()
	{
		this.RefreshView();
	}

	// Token: 0x06012001 RID: 73729 RVA: 0x00469F60 File Offset: 0x00468160
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnReceiveMonthCardData));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x06012002 RID: 73730 RVA: 0x00469F97 File Offset: 0x00468197
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnReceiveMonthCardData));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new <>f__AnonymousDelegate2<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x06012003 RID: 73731 RVA: 0x00469FCE File Offset: 0x004681CE
	private void CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult eSdkDialogResult = ESdkDialogResult.No)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x06012004 RID: 73732 RVA: 0x00469FE8 File Offset: 0x004681E8
	protected override void OnAfterShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		MonthCardModel.Instance.RefreshNextShowPayButtonRedDotTime();
		this.QueryProductPriceAndRefresh().Forget();
	}

	// Token: 0x06012005 RID: 73733 RVA: 0x0046A034 File Offset: 0x00468234
	private UniTask QueryProductPriceAndRefresh()
	{
		MonthCardView.<QueryProductPriceAndRefresh>d__25 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<MonthCardView.<QueryProductPriceAndRefresh>d__25>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06012006 RID: 73734 RVA: 0x0046A078 File Offset: 0x00468278
	private void RefreshRemainDays()
	{
		bool flag = MonthCardModel.Instance.GetRemainDays() >= 0;
		base.GetItem(0).SetUIActive(flag);
		base.GetText(1).SetUIActive(flag);
		if (flag)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(MonthCardModel.Instance.GetRemainDayText("f55e66"), true);
		}
	}

	// Token: 0x06012007 RID: 73735 RVA: 0x0046A0D4 File Offset: 0x004682D4
	public void RefreshView()
	{
		this.RefreshRemainDays();
		this.RefreshBuyInfo();
	}

	// Token: 0x06012008 RID: 73736 RVA: 0x0046A0E4 File Offset: 0x004682E4
	private void RefreshBuyInfo()
	{
		bool flag = MonthCardModel.Instance.IsRemainDayInMaxLimit();
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(7);
		if (flag)
		{
			this.CanBuyMonthCard = true;
			this.BuyButtonItem.RefreshEnable(true);
			this.BuyButtonItem.SetActive(true);
			item2.SetUIActive(true);
			item.SetUIActive(false);
			TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
			if (totalTopUpTagItem == null)
			{
				return;
			}
			totalTopUpTagItem.RefreshByGoodsId(42);
			return;
		}
		else
		{
			this.CanBuyMonthCard = false;
			this.BuyButtonItem.RefreshEnable(false);
			this.BuyButtonItem.SetActive(false);
			item2.SetUIActive(false);
			item.SetUIActive(true);
			TotalTopUpPayAdditiveTagItem totalTopUpTagItem2 = this.TotalTopUpTagItem;
			if (totalTopUpTagItem2 == null)
			{
				return;
			}
			totalTopUpTagItem2.SetUiActive(false);
			return;
		}
	}

	// Token: 0x0601200A RID: 73738 RVA: 0x0046A193 File Offset: 0x00468393
	[CompilerGenerated]
	internal static void <CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|12_0()
	{
		UiManager.Instance.CloseView(EUiViewName.PayShopRootView, null);
	}

	// Token: 0x040087F1 RID: 34801
	private ButtonAndTextItem BuyButtonItem;

	// Token: 0x040087F2 RID: 34802
	private GetItemPanel OnceRewardItem;

	// Token: 0x040087F3 RID: 34803
	private GetItemPanel DailyRewardItem;

	// Token: 0x040087F4 RID: 34804
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x040087F5 RID: 34805
	private bool CanBuyMonthCard;

	// Token: 0x040087F6 RID: 34806
	private const int MONTH_CARD_HELP_ID = 9;

	// Token: 0x020088CB RID: 35019
	[NullableContext(0)]
	private enum EMonthlyCardComponents
	{
		// Token: 0x0402C763 RID: 182115
		TextReceived,
		// Token: 0x0402C764 RID: 182116
		TextRemaining,
		// Token: 0x0402C765 RID: 182117
		ButtonHelp,
		// Token: 0x0402C766 RID: 182118
		TextPrice,
		// Token: 0x0402C767 RID: 182119
		ButtonBuy,
		// Token: 0x0402C768 RID: 182120
		OnceRewardItem,
		// Token: 0x0402C769 RID: 182121
		DailyRewardItem,
		// Token: 0x0402C76A RID: 182122
		TextRepeatBuy,
		// Token: 0x0402C76B RID: 182123
		PanelBuyLimit,
		// Token: 0x0402C76C RID: 182124
		TextDesc,
		// Token: 0x0402C76D RID: 182125
		CloudGameDesc,
		// Token: 0x0402C76E RID: 182126
		CloudGameIcon,
		// Token: 0x0402C76F RID: 182127
		TotalTopUpTagRoot
	}
}
