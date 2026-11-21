using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200076C RID: 1900
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewLoopTower : ActivitySubViewBase
{
	// Token: 0x06005737 RID: 22327 RVA: 0x001C945C File Offset: 0x001C765C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickTowerShopBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickTowerRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x001C960D File Offset: 0x001C780D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardBtnRedDot));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x001C9647 File Offset: 0x001C7847
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(this.RefreshRewardBtnRedDot));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x001C9681 File Offset: 0x001C7881
	protected override void OnSetData()
	{
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x001C9684 File Offset: 0x001C7884
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewLoopTower.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewLoopTower.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x001C96C8 File Offset: 0x001C78C8
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.DescriptionComponent.SetContentByTextId(this.ActivityBaseData.LocalConfig.Value.Desc, Array.Empty<string>());
		this.RefreshRewardComponent();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		if (StringUtils.IsEmpty(this.ActivityRemainTimeText))
		{
			this.ActivityRemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		}
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x001C9763 File Offset: 0x001C7963
	protected override void OnBeforeShow()
	{
		this.OnRefreshView();
		this.RefreshNewSeasonTip();
		EventSystem.Instance.Emit(EEventName.RedDotTowerReward);
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!TowerModel.Instance.GetLoopTowerIsClickShop());
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x001C979F File Offset: 0x001C799F
	protected override void OnRefreshView()
	{
		TowerModel.Instance.CurrentSelectDifficulties = 3;
		this.RefreshRewardBtnRedDot();
		this.RefreshTimerText();
		this.RefreshFunctionalComponent();
		this.RefreshStarNumber();
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x001C97C4 File Offset: 0x001C79C4
	private void RefreshRewardBtnRedDot()
	{
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(TowerModel.Instance.CanGetRewardByDifficulties(3));
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x001C97E4 File Offset: 0x001C79E4
	private void OnRefreshCommonActivityRedDot(int activityId)
	{
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.RefreshRewardBtnRedDot();
	}

	// Token: 0x06005741 RID: 22337 RVA: 0x001C982C File Offset: 0x001C7A2C
	protected override void OnTimer(float gap)
	{
		if (!this.NeedTick)
		{
			return;
		}
		this.RefreshTimerText();
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x001C9840 File Offset: 0x001C7A40
	private void RefreshTimerText()
	{
		double num = (double)MathUtils.Instance.LongToNumber(TowerModel.Instance.TowerEndTime.GetValueOrDefault());
		double serverTime = TimeUtil.Instance.GetServerTime();
		if (num - serverTime <= 0.0)
		{
			ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			this.NeedTick = false;
			return;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)num, this.ActivityRemainTimeText);
		this.TitleComponent.SetTimeTextByText(remainTimeText);
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x001C98B4 File Offset: 0x001C7AB4
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06005744 RID: 22340 RVA: 0x001C9900 File Offset: 0x001C7B00
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.JumpFunction));
		int loopTowerIsClickSeason = TowerModel.Instance.GetLoopTowerIsClickSeason();
		this.FunctionalComponent.SetFunctionRedDotVisible(loopTowerIsClickSeason < TowerModel.Instance.CurrentSeason);
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x001C996C File Offset: 0x001C7B6C
	private void RefreshNewSeasonTip()
	{
		int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.LoopTowerSeason, -1);
		int currentSeason = TowerModel.Instance.CurrentSeason;
		bool flag = player != currentSeason;
		ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
		if (functionalComponent != null)
		{
			functionalComponent.SetPanelTipVisible(flag);
		}
		if (flag)
		{
			ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
			if (functionalComponent2 != null)
			{
				functionalComponent2.SetPanelTipByTextId("CycleTowerNewPeriod", Array.Empty<string>());
			}
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.LoopTowerSeason, currentSeason);
		}
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x001C99D4 File Offset: 0x001C7BD4
	private void RefreshStarNumber()
	{
		TowerModel instance = TowerModel.Instance;
		int difficultyMaxStars = instance.GetDifficultyMaxStars(3, false);
		int difficultyAllStars = instance.GetDifficultyAllStars(3, false);
		base.GetText(6).SetText(difficultyMaxStars.ToString() + "/" + difficultyAllStars.ToString(), true);
	}

	// Token: 0x06005747 RID: 22343 RVA: 0x001C9A1C File Offset: 0x001C7C1C
	private void JumpFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			TowerController.Instance.OpenTowerView(false);
		});
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x001C9A4D File Offset: 0x001C7C4D
	private void OnClickTowerShopBtn()
	{
		TowerModel.Instance.SetLoopTowerIsClickShop(true);
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		PayShopController.Instance.OpenPayShopViewWithTab(PayShopDefine.EPayShopTabType.ActivityShop, 0);
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x001C9A7C File Offset: 0x001C7C7C
	private void OnClickTowerRewardBtn()
	{
		TowerModel instance = TowerModel.Instance;
		if (((instance != null) ? instance.GetDifficultyRewardProgress(3) : 0f) == 1f)
		{
			ScrollingTipsController.Instance.ShowTipsById("HaveAllReward", Array.Empty<object>());
		}
		UiManager.Instance.OpenView(EUiViewName.TowerRewardView, 3, delegate(bool success, int viewId)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
			if (viewByName == null)
			{
				return;
			}
			viewByName.AddChildViewById(viewId);
		});
	}

	// Token: 0x04003BD3 RID: 15315
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003BD4 RID: 15316
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003BD5 RID: 15317
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003BD6 RID: 15318
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003BD7 RID: 15319
	private bool NeedTick = true;

	// Token: 0x02006A5E RID: 27230
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023021 RID: 143393
		public const int TitleItem = 0;

		// Token: 0x04023022 RID: 143394
		public const int DescriptionItem = 1;

		// Token: 0x04023023 RID: 143395
		public const int RewardListItem = 2;

		// Token: 0x04023024 RID: 143396
		public const int FunctionArea = 3;

		// Token: 0x04023025 RID: 143397
		public const int TowerShopBtn = 4;

		// Token: 0x04023026 RID: 143398
		public const int TowerRewardBtn = 5;

		// Token: 0x04023027 RID: 143399
		public const int TowerProgressText = 6;

		// Token: 0x04023028 RID: 143400
		public const int ShopBtnRedDotItem = 7;

		// Token: 0x04023029 RID: 143401
		public const int RewardBtnRedDotItem = 8;
	}
}
