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

// Token: 0x02001482 RID: 5250
[NullableContext(1)]
[Nullable(0)]
public class RegressBpPayView : UiViewBase
{
	// Token: 0x06009494 RID: 38036 RVA: 0x001FFF9C File Offset: 0x001FE19C
	public RegressBpPayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009495 RID: 38037 RVA: 0x001FFFA8 File Offset: 0x001FE1A8
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

	// Token: 0x06009496 RID: 38038 RVA: 0x002000F0 File Offset: 0x001FE2F0
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpPayView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpPayView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009497 RID: 38039 RVA: 0x00200133 File Offset: 0x001FE333
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06009498 RID: 38040 RVA: 0x00200151 File Offset: 0x001FE351
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06009499 RID: 38041 RVA: 0x0020016F File Offset: 0x001FE36F
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600949A RID: 38042 RVA: 0x00200178 File Offset: 0x001FE378
	protected override void OnBeforeShow()
	{
		this.StartTimer();
		this.RefreshTitle();
		this.RefreshRewardLayout();
		this.RefreshPayInfo();
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0600949B RID: 38043 RVA: 0x002001A0 File Offset: 0x001FE3A0
	protected override void OnBeforeHide()
	{
		this.ClearTimer();
	}

	// Token: 0x0600949C RID: 38044 RVA: 0x002001A8 File Offset: 0x001FE3A8
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		this.RewardLayout = null;
	}

	// Token: 0x0600949D RID: 38045 RVA: 0x002001B7 File Offset: 0x001FE3B7
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600949E RID: 38046 RVA: 0x002001C0 File Offset: 0x001FE3C0
	private void OnClickBtnGold()
	{
		int payGiftId = 46;
		PayGiftController.Instance.SdkPay(payGiftId);
	}

	// Token: 0x0600949F RID: 38047 RVA: 0x002001DB File Offset: 0x001FE3DB
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060094A0 RID: 38048 RVA: 0x002001E4 File Offset: 0x001FE3E4
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

	// Token: 0x060094A1 RID: 38049 RVA: 0x0020026C File Offset: 0x001FE46C
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

	// Token: 0x060094A2 RID: 38050 RVA: 0x0020033F File Offset: 0x001FE53F
	private void StartTimer()
	{
		this.ClearTimer();
		this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x060094A3 RID: 38051 RVA: 0x00200378 File Offset: 0x001FE578
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

	// Token: 0x060094A4 RID: 38052 RVA: 0x002003C7 File Offset: 0x001FE5C7
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x060094A5 RID: 38053 RVA: 0x002003CF File Offset: 0x001FE5CF
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.TimerHandle))
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x040041D9 RID: 16857
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040041DA RID: 16858
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02007AA8 RID: 31400
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040285B5 RID: 165301
		public const int BtnMask = 0;

		// Token: 0x040285B6 RID: 165302
		public const int BtnClose = 1;

		// Token: 0x040285B7 RID: 165303
		public const int TxtTime = 2;

		// Token: 0x040285B8 RID: 165304
		public const int TxtTitle = 3;

		// Token: 0x040285B9 RID: 165305
		public const int TxtDesc = 4;

		// Token: 0x040285BA RID: 165306
		public const int PanelGrid = 5;

		// Token: 0x040285BB RID: 165307
		public const int ItemReward = 6;

		// Token: 0x040285BC RID: 165308
		public const int TxtCost = 7;

		// Token: 0x040285BD RID: 165309
		public const int TxtDiscount = 8;

		// Token: 0x040285BE RID: 165310
		public const int BtnGold = 9;

		// Token: 0x040285BF RID: 165311
		public const int PanelRedDot = 10;
	}
}
