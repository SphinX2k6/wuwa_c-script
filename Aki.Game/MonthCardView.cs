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

// Token: 0x02001835 RID: 6197
[NullableContext(2)]
[Nullable(0)]
public class MonthCardView : UiTabViewBase
{
	// Token: 0x0600F4A3 RID: 62627 RVA: 0x00476AA8 File Offset: 0x00474CA8
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

	// Token: 0x0600F4A4 RID: 62628 RVA: 0x00476CC0 File Offset: 0x00474EC0
	protected override UniTask OnBeforeStartAsync()
	{
		MonthCardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MonthCardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4A5 RID: 62629 RVA: 0x00476D04 File Offset: 0x00474F04
	private UniTask BuildRewardItems()
	{
		MonthCardView.<BuildRewardItems>d__9 <BuildRewardItems>d__;
		<BuildRewardItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BuildRewardItems>d__.<>4__this = this;
		<BuildRewardItems>d__.<>1__state = -1;
		<BuildRewardItems>d__.<>t__builder.Start<MonthCardView.<BuildRewardItems>d__9>(ref <BuildRewardItems>d__);
		return <BuildRewardItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4A6 RID: 62630 RVA: 0x00476D47 File Offset: 0x00474F47
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult.No);
	}

	// Token: 0x0600F4A7 RID: 62631 RVA: 0x00476D58 File Offset: 0x00474F58
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

	// Token: 0x0600F4A8 RID: 62632 RVA: 0x00476E54 File Offset: 0x00475054
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

	// Token: 0x0600F4A9 RID: 62633 RVA: 0x00476EDC File Offset: 0x004750DC
	private UniTask OpenThirdPartyMessageBox()
	{
		MonthCardView.<OpenThirdPartyMessageBox>d__13 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<MonthCardView.<OpenThirdPartyMessageBox>d__13>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4AA RID: 62634 RVA: 0x00476F18 File Offset: 0x00475118
	private void RefreshPrice()
	{
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		base.GetText(3).SetText(payShopGoodsById.GetDirectPriceText(), true);
	}

	// Token: 0x0600F4AB RID: 62635 RVA: 0x00476F48 File Offset: 0x00475148
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

	// Token: 0x0600F4AC RID: 62636 RVA: 0x00476FA7 File Offset: 0x004751A7
	protected override void OnBeforeHide()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x0600F4AD RID: 62637 RVA: 0x00476FBD File Offset: 0x004751BD
	protected override void OnBeforeDestroy()
	{
		ButtonAndTextItem buyButtonItem = this.BuyButtonItem;
		if (buyButtonItem != null)
		{
			buyButtonItem.Destroy(null);
		}
		this.BuyButtonItem = null;
	}

	// Token: 0x0600F4AE RID: 62638 RVA: 0x00476FD8 File Offset: 0x004751D8
	private void OnClickedHelpButton()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x0600F4AF RID: 62639 RVA: 0x00476FE8 File Offset: 0x004751E8
	private void OnClickedBuyButton()
	{
		if (!this.CanBuyMonthCard)
		{
			return;
		}
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		PayGiftController.Instance.SdkPay(payShopGoodsById.GetGoodsData().Id);
	}

	// Token: 0x0600F4B0 RID: 62640 RVA: 0x00477020 File Offset: 0x00475220
	private void OnReceiveMonthCardData()
	{
		this.RefreshView();
	}

	// Token: 0x0600F4B1 RID: 62641 RVA: 0x00477028 File Offset: 0x00475228
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnReceiveMonthCardData));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0600F4B2 RID: 62642 RVA: 0x0047705F File Offset: 0x0047525F
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveMonthCardDataEvent, new Action(this.OnReceiveMonthCardData));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new <>f__AnonymousDelegate2<ESdkDialogResult>(this.CheckIfNeedShowPlayStationStoreIcon));
	}

	// Token: 0x0600F4B3 RID: 62643 RVA: 0x00477096 File Offset: 0x00475296
	private void CheckIfNeedShowPlayStationStoreIcon(ESdkDialogResult eSdkDialogResult = ESdkDialogResult.No)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x0600F4B4 RID: 62644 RVA: 0x004770B0 File Offset: 0x004752B0
	protected override void OnAfterShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		MonthCardModel.Instance.RefreshNextShowPayButtonRedDotTime();
		this.QueryProductPriceAndRefresh().Forget();
	}

	// Token: 0x0600F4B5 RID: 62645 RVA: 0x004770FC File Offset: 0x004752FC
	private UniTask QueryProductPriceAndRefresh()
	{
		MonthCardView.<QueryProductPriceAndRefresh>d__25 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<MonthCardView.<QueryProductPriceAndRefresh>d__25>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4B6 RID: 62646 RVA: 0x00477140 File Offset: 0x00475340
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

	// Token: 0x0600F4B7 RID: 62647 RVA: 0x0047719C File Offset: 0x0047539C
	public void RefreshView()
	{
		this.RefreshRemainDays();
		this.RefreshBuyInfo();
	}

	// Token: 0x0600F4B8 RID: 62648 RVA: 0x004771AC File Offset: 0x004753AC
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

	// Token: 0x0600F4BA RID: 62650 RVA: 0x0047725B File Offset: 0x0047545B
	[CompilerGenerated]
	internal static void <CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|12_0()
	{
		UiManager.Instance.CloseView(EUiViewName.PayShopRootView, null);
	}

	// Token: 0x04008934 RID: 35124
	private ButtonAndTextItem BuyButtonItem;

	// Token: 0x04008935 RID: 35125
	private GetItemPanel OnceRewardItem;

	// Token: 0x04008936 RID: 35126
	private GetItemPanel DailyRewardItem;

	// Token: 0x04008937 RID: 35127
	private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

	// Token: 0x04008938 RID: 35128
	private bool CanBuyMonthCard;

	// Token: 0x04008939 RID: 35129
	private const int MONTH_CARD_HELP_ID = 9;

	// Token: 0x02007A54 RID: 31316
	[NullableContext(0)]
	private enum EMonthlyCardComponents
	{
		// Token: 0x04027A77 RID: 162423
		TextReceived,
		// Token: 0x04027A78 RID: 162424
		TextRemaining,
		// Token: 0x04027A79 RID: 162425
		ButtonHelp,
		// Token: 0x04027A7A RID: 162426
		TextPrice,
		// Token: 0x04027A7B RID: 162427
		ButtonBuy,
		// Token: 0x04027A7C RID: 162428
		OnceRewardItem,
		// Token: 0x04027A7D RID: 162429
		DailyRewardItem,
		// Token: 0x04027A7E RID: 162430
		TextRepeatBuy,
		// Token: 0x04027A7F RID: 162431
		PanelBuyLimit,
		// Token: 0x04027A80 RID: 162432
		TextDesc,
		// Token: 0x04027A81 RID: 162433
		CloudGameDesc,
		// Token: 0x04027A82 RID: 162434
		CloudGameIcon,
		// Token: 0x04027A83 RID: 162435
		TotalTopUpTagRoot
	}
}
