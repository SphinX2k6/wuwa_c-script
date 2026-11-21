using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000936 RID: 2358
[NullableContext(1)]
[Nullable(0)]
public class RegressBpPayView : UiViewBase
{
	// Token: 0x06006829 RID: 26665 RVA: 0x00208F00 File Offset: 0x00207100
	public RegressBpPayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600682A RID: 26666 RVA: 0x00208F0C File Offset: 0x0020710C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnClose)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnGold))
		};
	}

	// Token: 0x0600682B RID: 26667 RVA: 0x00209054 File Offset: 0x00207254
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpPayView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpPayView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600682C RID: 26668 RVA: 0x00209097 File Offset: 0x00207297
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600682D RID: 26669 RVA: 0x002090B5 File Offset: 0x002072B5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600682E RID: 26670 RVA: 0x002090D3 File Offset: 0x002072D3
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600682F RID: 26671 RVA: 0x002090DC File Offset: 0x002072DC
	protected override void OnBeforeShow()
	{
		this.StartTimer();
		this.RefreshTitle();
		this.RefreshRewardLayout();
		this.RefreshPayInfo();
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x06006830 RID: 26672 RVA: 0x00209104 File Offset: 0x00207304
	protected override void OnBeforeHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06006831 RID: 26673 RVA: 0x0020910C File Offset: 0x0020730C
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		this.RewardLayout = null;
	}

	// Token: 0x06006832 RID: 26674 RVA: 0x0020911B File Offset: 0x0020731B
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006833 RID: 26675 RVA: 0x00209124 File Offset: 0x00207324
	private void OnClickBtnGold()
	{
		int payGiftId = 46;
		PayGiftController.Instance.SdkPay(payGiftId);
	}

	// Token: 0x06006834 RID: 26676 RVA: 0x0020913F File Offset: 0x0020733F
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06006835 RID: 26677 RVA: 0x00209148 File Offset: 0x00207348
	private void RefreshRewardLayout()
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		int? num = (activityData != null) ? new int?(activityData.Id) : null;
		if (num == null)
		{
			return;
		}
		RegressDisposableReward? regressDisposableReward = ActivityRegressConfig.Instance.GetRegressDisposableReward(num.Value);
		if (regressDisposableReward == null)
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(regressDisposableReward.Value.HighRewardPreviewId);
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout == null)
		{
			return;
		}
		rewardLayout.RefreshByData(dropPackagePreviewItemList, null, false);
	}

	// Token: 0x06006836 RID: 26678 RVA: 0x002091D0 File Offset: 0x002073D0
	private void RefreshPayInfo()
	{
		UUIText text = base.GetText(7);
		UUIText text2 = base.GetText(8);
		if (text == null || text2 == null)
		{
			return;
		}
		PayGiftModel instance = PayGiftModel.Instance;
		PayPackageData payPackageData = (instance != null) ? instance.GetPayGiftDataById(46) : null;
		if (payPackageData == null)
		{
			text.SetText("", true);
			text2.SetUIActive(false);
			return;
		}
		PayShopGoods payShopGoods = payPackageData.GetPayShopGoods();
		bool flag = payShopGoods.IsDirect();
		IPriceData priceData = payShopGoods.GetPriceData();
		if (flag)
		{
			text.SetText(payShopGoods.GetDirectPriceText(), true);
		}
		else
		{
			text.SetText(priceData.NowPrice.ToString(), true);
		}
		int? originalPrice = priceData.OriginalPrice;
		if (originalPrice == null)
		{
			text2.SetUIActive(false);
			return;
		}
		text2.SetUIActive(true);
		text2.SetText("<s>" + originalPrice.Value.ToString() + "</s>", true);
	}

	// Token: 0x06006837 RID: 26679 RVA: 0x002092A3 File Offset: 0x002074A3
	private void StartTimer()
	{
		this.ClearTimer();
		this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06006838 RID: 26680 RVA: 0x002092DC File Offset: 0x002074DC
	private void RefreshTitle()
	{
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(2).SetUIActive(item);
		if (item)
		{
			base.GetText(2).SetText(item2, true);
		}
	}

	// Token: 0x06006839 RID: 26681 RVA: 0x0020932B File Offset: 0x0020752B
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x0600683A RID: 26682 RVA: 0x00209333 File Offset: 0x00207533
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.TimerHandle))
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x04004271 RID: 17009
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04004272 RID: 17010
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02006C2C RID: 27692
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040238CF RID: 145615
		public const int BtnMask = 0;

		// Token: 0x040238D0 RID: 145616
		public const int BtnClose = 1;

		// Token: 0x040238D1 RID: 145617
		public const int TxtTime = 2;

		// Token: 0x040238D2 RID: 145618
		public const int TxtTitle = 3;

		// Token: 0x040238D3 RID: 145619
		public const int TxtDesc = 4;

		// Token: 0x040238D4 RID: 145620
		public const int PanelGrid = 5;

		// Token: 0x040238D5 RID: 145621
		public const int ItemReward = 6;

		// Token: 0x040238D6 RID: 145622
		public const int TxtCost = 7;

		// Token: 0x040238D7 RID: 145623
		public const int TxtDiscount = 8;

		// Token: 0x040238D8 RID: 145624
		public const int BtnGold = 9;

		// Token: 0x040238D9 RID: 145625
		public const int PanelRedDot = 10;
	}
}
