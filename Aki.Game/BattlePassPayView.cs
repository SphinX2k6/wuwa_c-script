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

// Token: 0x02002327 RID: 8999
[NullableContext(1)]
[Nullable(0)]
public class BattlePassPayView : UiViewBase
{
	// Token: 0x06011D0B RID: 72971 RVA: 0x004630D9 File Offset: 0x004612D9
	public BattlePassPayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011D0C RID: 72972 RVA: 0x004630E4 File Offset: 0x004612E4
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

	// Token: 0x06011D0D RID: 72973 RVA: 0x004633CC File Offset: 0x004615CC
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassPayView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassPayView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D0E RID: 72974 RVA: 0x00463408 File Offset: 0x00461608
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnReceiveBattlePassPaid, new Action(this.OnClickExitBtn));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.SdkPayEnd));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06011D0F RID: 72975 RVA: 0x0046347C File Offset: 0x0046167C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnReceiveBattlePassPaid, new Action(this.OnClickExitBtn));
		EventSystem.Instance.Remove(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.SdkPayEnd));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06011D10 RID: 72976 RVA: 0x004634EF File Offset: 0x004616EF
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

	// Token: 0x06011D11 RID: 72977 RVA: 0x00463513 File Offset: 0x00461713
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.SdkPayProductInformationView)
		{
			PlatformSdkManagerNew.Instance.GetPlatformSdk().HidePlayStationStoreIcon();
		}
	}

	// Token: 0x06011D12 RID: 72978 RVA: 0x00463531 File Offset: 0x00461731
	private void OnClickExitBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011D13 RID: 72979 RVA: 0x0046353A File Offset: 0x0046173A
	private void SdkPayEnd(ESdkDialogResult eSdkDialogResult)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x06011D14 RID: 72980 RVA: 0x00463551 File Offset: 0x00461751
	private void OnClickPrimaryPayBtn()
	{
		BattlePassController.Instance.PayPrimaryBattlePass();
	}

	// Token: 0x06011D15 RID: 72981 RVA: 0x0046355D File Offset: 0x0046175D
	private void OnClickHighPayBtn()
	{
		BattlePassController.Instance.PayHighBattlePass();
	}

	// Token: 0x06011D16 RID: 72982 RVA: 0x0046356C File Offset: 0x0046176C
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

	// Token: 0x06011D17 RID: 72983 RVA: 0x004635C0 File Offset: 0x004617C0
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

	// Token: 0x06011D18 RID: 72984 RVA: 0x004636BE File Offset: 0x004618BE
	protected override void OnBeforeShow()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x06011D19 RID: 72985 RVA: 0x004636D5 File Offset: 0x004618D5
	protected override void OnAfterShow()
	{
		this.QueryProductPriceAndRefresh().Forget();
	}

	// Token: 0x06011D1A RID: 72986 RVA: 0x004636E4 File Offset: 0x004618E4
	private UniTask QueryProductPriceAndRefresh()
	{
		BattlePassPayView.<QueryProductPriceAndRefresh>d__23 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<BattlePassPayView.<QueryProductPriceAndRefresh>d__23>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06011D1B RID: 72987 RVA: 0x00463728 File Offset: 0x00461928
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

	// Token: 0x06011D1C RID: 72988 RVA: 0x004637C8 File Offset: 0x004619C8
	private UniTask OpenThirdPartyMessageBox()
	{
		BattlePassPayView.<OpenThirdPartyMessageBox>d__25 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<BattlePassPayView.<OpenThirdPartyMessageBox>d__25>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x06011D1D RID: 72989 RVA: 0x00463803 File Offset: 0x00461A03
	private int[] GetNeedRequestGoodId()
	{
		return new int[]
		{
			BattlePassModel.Instance.GetPrimaryBattlePassGoodsId(),
			BattlePassModel.Instance.GetHighBattlePassGoodsId(),
			BattlePassModel.Instance.GetSupplyBattlePassGoodsId()
		};
	}

	// Token: 0x06011D1E RID: 72990 RVA: 0x00463832 File Offset: 0x00461A32
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06011D1F RID: 72991 RVA: 0x00463839 File Offset: 0x00461A39
	protected override void OnBeforeHide()
	{
		PlatformSdkManagerNew.Instance.GetPlatformSdk().HidePlayStationStoreIcon();
	}

	// Token: 0x06011D20 RID: 72992 RVA: 0x0046384C File Offset: 0x00461A4C
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

	// Token: 0x06011D21 RID: 72993 RVA: 0x004638B0 File Offset: 0x00461AB0
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

	// Token: 0x06011D22 RID: 72994 RVA: 0x004639C8 File Offset: 0x00461BC8
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

	// Token: 0x06011D23 RID: 72995 RVA: 0x00463A94 File Offset: 0x00461C94
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

	// Token: 0x06011D24 RID: 72996 RVA: 0x00463AF0 File Offset: 0x00461CF0
	[CompilerGenerated]
	internal static void <CheckSdkProductInfoConfirmIfCanShow>g__confirmCallback|24_0()
	{
		UiManager.Instance.CloseView(EUiViewName.BattlePassPayView, null);
	}

	// Token: 0x04008705 RID: 34565
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> PrimaryGridLayout;

	// Token: 0x04008706 RID: 34566
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> HighGridLayout;

	// Token: 0x04008707 RID: 34567
	[Nullable(2)]
	private List<TItem> PrimaryRewardList;

	// Token: 0x04008708 RID: 34568
	[Nullable(2)]
	private List<TItem> HighRewardList;

	// Token: 0x04008709 RID: 34569
	private long PassEndTime;

	// Token: 0x0400870A RID: 34570
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400870B RID: 34571
	private const int PLAYSTATIONICONPOSITION = 0;

	// Token: 0x020088A5 RID: 34981
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C68E RID: 181902
		ExitBtn,
		// Token: 0x0402C68F RID: 181903
		PrimaryGrid,
		// Token: 0x0402C690 RID: 181904
		PrimaryPrice,
		// Token: 0x0402C691 RID: 181905
		PrimaryPayBtn,
		// Token: 0x0402C692 RID: 181906
		HighGrid,
		// Token: 0x0402C693 RID: 181907
		HighPrice,
		// Token: 0x0402C694 RID: 181908
		HighPayBtn,
		// Token: 0x0402C695 RID: 181909
		TxtCountDown,
		// Token: 0x0402C696 RID: 181910
		DetailBtn,
		// Token: 0x0402C697 RID: 181911
		PrimaryBuyItem,
		// Token: 0x0402C698 RID: 181912
		HighBuyItem,
		// Token: 0x0402C699 RID: 181913
		PrimaryDoneItem,
		// Token: 0x0402C69A RID: 181914
		HighDoneItem,
		// Token: 0x0402C69B RID: 181915
		PrimaryCloudGameDesc,
		// Token: 0x0402C69C RID: 181916
		HighCloudGameDesc,
		// Token: 0x0402C69D RID: 181917
		CloudGameTip
	}
}
