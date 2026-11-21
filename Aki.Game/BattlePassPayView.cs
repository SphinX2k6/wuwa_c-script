using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200180C RID: 6156
[NullableContext(1)]
[Nullable(0)]
public class BattlePassPayView : UiViewBase
{
	// Token: 0x0600F1BB RID: 61883 RVA: 0x0047019D File Offset: 0x0046E39D
	public BattlePassPayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F1BC RID: 61884 RVA: 0x004701A8 File Offset: 0x0046E3A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickPrimaryPayBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickHighPayBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickExitBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F1BD RID: 61885 RVA: 0x00470490 File Offset: 0x0046E690
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassPayView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassPayView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1BE RID: 61886 RVA: 0x004704CC File Offset: 0x0046E6CC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnReceiveBattlePassPaid, new Action(this.OnClickExitBtn));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.SdkPayEnd));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600F1BF RID: 61887 RVA: 0x00470540 File Offset: 0x0046E740
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnReceiveBattlePassPaid, new Action(this.OnClickExitBtn));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.SdkPayEnd));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600F1C0 RID: 61888 RVA: 0x004705B3 File Offset: 0x0046E7B3
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.SdkPayProductInformationView)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.ShowPlayStationStoreIcon(0);
		}
	}

	// Token: 0x0600F1C1 RID: 61889 RVA: 0x004705D7 File Offset: 0x0046E7D7
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.SdkPayProductInformationView)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().HidePlayStationStoreIcon();
		}
	}

	// Token: 0x0600F1C2 RID: 61890 RVA: 0x004705F5 File Offset: 0x0046E7F5
	private void OnClickExitBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F1C3 RID: 61891 RVA: 0x004705FE File Offset: 0x0046E7FE
	private void SdkPayEnd(ESdkDialogResult eSdkDialogResult)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x0600F1C4 RID: 61892 RVA: 0x00470615 File Offset: 0x0046E815
	private void OnClickPrimaryPayBtn()
	{
		BattlePassController.Instance.PayPrimaryBattlePass();
	}

	// Token: 0x0600F1C5 RID: 61893 RVA: 0x00470621 File Offset: 0x0046E821
	private void OnClickHighPayBtn()
	{
		BattlePassController.Instance.PayHighBattlePass();
	}

	// Token: 0x0600F1C6 RID: 61894 RVA: 0x00470630 File Offset: 0x0046E830
	private void OnClickDetailBtn()
	{
		WeaponPreviewViewParam param = new WeaponPreviewViewParam
		{
			WeaponDataList = BattlePassModel.Instance.GetWeaponDataList().ToArray(),
			SelectedIndex = 0,
			WeaponObservers = (this.OpenParam as WeaponSkeletalObserverHandles)
		};
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x0600F1C7 RID: 61895 RVA: 0x00470684 File Offset: 0x0046E884
	protected override void OnStart()
	{
		this.PrimaryRewardList = new List<TItem>();
		this.HighRewardList = new List<TItem>();
		BattlePassConfig.Instance.GetBattlePassUnlockReward(EBattlePassUnlockType.Primary, this.PrimaryRewardList);
		BattlePassConfig.Instance.GetBattlePassUnlockReward(EBattlePassUnlockType.Upgrade, this.HighRewardList);
		this.PrimaryGridLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(1), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
		this.HighGridLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(4), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
		this.PrimaryGridLayout.RefreshByData(this.PrimaryRewardList, null, false);
		this.HighGridLayout.RefreshByData(this.HighRewardList, null, false);
		this.PassEndTime = BattlePassModel.Instance.GetBattlePassEndTime();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.RefreshLeftTime), 1000f, 1f, null, null, true);
		this.RefreshLeftTime(0f);
		this.RefreshButtonView();
		this.CheckSdkProductInfoConfirmIfCanShow();
	}

	// Token: 0x0600F1C8 RID: 61896 RVA: 0x00470782 File Offset: 0x0046E982
	protected override void OnBeforeShow()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x0600F1C9 RID: 61897 RVA: 0x00470799 File Offset: 0x0046E999
	protected override void OnAfterShow()
	{
		this.QueryProductPriceAndRefresh().Forget();
	}

	// Token: 0x0600F1CA RID: 61898 RVA: 0x004707A8 File Offset: 0x0046E9A8
	private UniTask QueryProductPriceAndRefresh()
	{
		BattlePassPayView.<QueryProductPriceAndRefresh>d__23 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<BattlePassPayView.<QueryProductPriceAndRefresh>d__23>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1CB RID: 61899 RVA: 0x004707EC File Offset: 0x0046E9EC
	private bool CheckSdkProductInfoConfirmIfCanShow()
	{
		if (PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedConfirmSdkProductInfo())
		{
			foreach (int id in this.GetNeedRequestGoodId())
			{
				string productId = PayGiftModel.Instance.GetPayGiftDataById(id).ProductId;
				if (PayItemModel.Instance.GetProductInfoByGoodsId(productId) == null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CannotFindSdkProduct);
					confirmBoxDataNew.FunctionMap.Add(1, new Action(BattlePassPayView.<CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|24_0));
					confirmBoxDataNew.IsEscViewTriggerCallBack = false;
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					this.OpenThirdPartyMessageBox().Forget();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600F1CC RID: 61900 RVA: 0x0047088C File Offset: 0x0046EA8C
	private UniTask OpenThirdPartyMessageBox()
	{
		BattlePassPayView.<OpenThirdPartyMessageBox>d__25 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<BattlePassPayView.<OpenThirdPartyMessageBox>d__25>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1CD RID: 61901 RVA: 0x004708C7 File Offset: 0x0046EAC7
	private int[] GetNeedRequestGoodId()
	{
		return new int[]
		{
			BattlePassModel.Instance.GetPrimaryBattlePassGoodsId(),
			BattlePassModel.Instance.GetHighBattlePassGoodsId(),
			BattlePassModel.Instance.GetSupplyBattlePassGoodsId()
		};
	}

	// Token: 0x0600F1CE RID: 61902 RVA: 0x004708F6 File Offset: 0x0046EAF6
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F1CF RID: 61903 RVA: 0x004708FD File Offset: 0x0046EAFD
	protected override void OnBeforeHide()
	{
		PlatformSdkManagerNew.Instance.GetPlatformSdk().HidePlayStationStoreIcon();
	}

	// Token: 0x0600F1D0 RID: 61904 RVA: 0x00470910 File Offset: 0x0046EB10
	protected override void OnBeforeDestroy()
	{
		this.PrimaryRewardList.Clear();
		this.PrimaryRewardList = null;
		this.HighRewardList.Clear();
		this.HighRewardList = null;
		this.PrimaryGridLayout = null;
		this.HighGridLayout = null;
		this.TimerHandle.Remove();
		this.TimerHandle = null;
		PlatformSdkManagerNew.Instance.GetPlatformSdk().HidePlayStationStoreIcon();
	}

	// Token: 0x0600F1D1 RID: 61905 RVA: 0x00470974 File Offset: 0x0046EB74
	private void RefreshButtonView()
	{
		BattlePassPayStatus payType = BattlePassModel.Instance.PayType;
		base.GetItem(9).SetUIActive(payType == BattlePassPayStatus.NoPaid);
		base.GetItem(11).SetUIActive(payType > BattlePassPayStatus.NoPaid);
		base.GetItem(10).SetUIActive(payType != BattlePassPayStatus.Advanced);
		base.GetItem(12).SetUIActive(payType == BattlePassPayStatus.Advanced);
		if (payType == BattlePassPayStatus.NoPaid)
		{
			PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(BattlePassModel.Instance.GetPrimaryBattlePassGoodsId());
			string text = (payShopGoodsById != null) ? payShopGoodsById.GetDirectPriceText() : null;
			base.GetText(2).SetText(text ?? "", true);
			PayShopGoods payShopGoodsById2 = PayGiftModel.Instance.GetPayShopGoodsById(BattlePassModel.Instance.GetHighBattlePassGoodsId());
			string text2 = (payShopGoodsById2 != null) ? payShopGoodsById2.GetDirectPriceText() : null;
			base.GetText(5).SetText(text2 ?? "", true);
		}
		else if (payType == BattlePassPayStatus.Paid)
		{
			PayShopGoods payShopGoodsById3 = PayGiftModel.Instance.GetPayShopGoodsById(BattlePassModel.Instance.GetSupplyBattlePassGoodsId());
			string text3 = (payShopGoodsById3 != null) ? payShopGoodsById3.GetDirectPriceText() : null;
			base.GetText(5).SetText(text3 ?? "", true);
		}
		this.RefreshCloudGameInfo();
	}

	// Token: 0x0600F1D2 RID: 61906 RVA: 0x00470A8C File Offset: 0x0046EC8C
	private void RefreshCloudGameInfo()
	{
		UUIText text = base.GetText(13);
		UUIText text2 = base.GetText(14);
		UUIItem item = base.GetItem(15);
		BattlePassPayStatus payType = BattlePassModel.Instance.PayType;
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(BattlePassModel.Instance.GetPrimaryBattlePassGoodsId());
		if (!payShopGoodsById.HasCloudGameInfo())
		{
			text.SetUIActive(false);
			text2.SetUIActive(false);
			item.SetUIActive(false);
			return;
		}
		int id = (payType == BattlePassPayStatus.Paid) ? BattlePassModel.Instance.GetSupplyBattlePassGoodsId() : BattlePassModel.Instance.GetHighBattlePassGoodsId();
		PayShopGoods payShopGoodsById2 = PayGiftModel.Instance.GetPayShopGoodsById(id);
		text.SetUIActive(payType != BattlePassPayStatus.Advanced);
		text2.SetUIActive(true);
		item.SetUIActive(true);
		text.SetText(payShopGoodsById.GetCloudGameDesc(), true);
		text2.SetText(payShopGoodsById2.GetCloudGameDesc(), true);
	}

	// Token: 0x0600F1D3 RID: 61907 RVA: 0x00470B58 File Offset: 0x0046ED58
	public void RefreshLeftTime(float _)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = (double)this.PassEndTime - serverTime;
		if (num < 0.0)
		{
			return;
		}
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(num);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Text_GachaRemainingTime_Text", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
	}

	// Token: 0x0600F1D4 RID: 61908 RVA: 0x00470BB4 File Offset: 0x0046EDB4
	[CompilerGenerated]
	internal static void <CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|24_0()
	{
		UiManager.Instance.CloseView(EUiViewName.BattlePassPayView, null);
	}

	// Token: 0x04008848 RID: 34888
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> PrimaryGridLayout;

	// Token: 0x04008849 RID: 34889
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> HighGridLayout;

	// Token: 0x0400884A RID: 34890
	[Nullable(2)]
	private List<TItem> PrimaryRewardList;

	// Token: 0x0400884B RID: 34891
	[Nullable(2)]
	private List<TItem> HighRewardList;

	// Token: 0x0400884C RID: 34892
	private long PassEndTime;

	// Token: 0x0400884D RID: 34893
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400884E RID: 34894
	private const int PLAYSTATIONICONPOSITION = 0;

	// Token: 0x02007A2E RID: 31278
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040279A2 RID: 162210
		ExitBtn,
		// Token: 0x040279A3 RID: 162211
		PrimaryGrid,
		// Token: 0x040279A4 RID: 162212
		PrimaryPrice,
		// Token: 0x040279A5 RID: 162213
		PrimaryPayBtn,
		// Token: 0x040279A6 RID: 162214
		HighGrid,
		// Token: 0x040279A7 RID: 162215
		HighPrice,
		// Token: 0x040279A8 RID: 162216
		HighPayBtn,
		// Token: 0x040279A9 RID: 162217
		TxtCountDown,
		// Token: 0x040279AA RID: 162218
		DetailBtn,
		// Token: 0x040279AB RID: 162219
		PrimaryBuyItem,
		// Token: 0x040279AC RID: 162220
		HighBuyItem,
		// Token: 0x040279AD RID: 162221
		PrimaryDoneItem,
		// Token: 0x040279AE RID: 162222
		HighDoneItem,
		// Token: 0x040279AF RID: 162223
		PrimaryCloudGameDesc,
		// Token: 0x040279B0 RID: 162224
		HighCloudGameDesc,
		// Token: 0x040279B1 RID: 162225
		CloudGameTip
	}
}
