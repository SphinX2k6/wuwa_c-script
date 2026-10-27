using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AC1 RID: 10945
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsActivitySubView : ActivitySubViewBase
{
	// Token: 0x06016C91 RID: 93329 RVA: 0x005C949C File Offset: 0x005C769C
	protected override void OnSetData()
	{
		this.ActivityData = (SurvivorsActivityData)this.ActivityBaseData;
	}

	// Token: 0x06016C92 RID: 93330 RVA: 0x005C94B0 File Offset: 0x005C76B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnBtnScore))
		};
	}

	// Token: 0x06016C93 RID: 93331 RVA: 0x005C9588 File Offset: 0x005C7788
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsActivitySubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsActivitySubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016C94 RID: 93332 RVA: 0x005C95CC File Offset: 0x005C77CC
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.TitleComponent.SetActivityBaseData(this.ActivityData);
		this.TitleComponent.SetTitleByText(this.ActivityData.GetTitle());
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		List<TItem> previewReward = this.ActivityData.GetPreviewReward(null);
		this.RewardListComponent.SetCommonTitle();
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
		this.OnRefreshView();
	}

	// Token: 0x06016C95 RID: 93333 RVA: 0x005C96E1 File Offset: 0x005C78E1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x06016C96 RID: 93334 RVA: 0x005C96FF File Offset: 0x005C78FF
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x06016C97 RID: 93335 RVA: 0x005C971D File Offset: 0x005C791D
	private void OnRefreshRedDot(int activityId)
	{
		if (this.ActivityData.Id != activityId)
		{
			return;
		}
		this.RefreshRewardInfo();
		this.RefreshRedDot();
	}

	// Token: 0x06016C98 RID: 93336 RVA: 0x005C973A File Offset: 0x005C793A
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshCondition();
	}

	// Token: 0x06016C99 RID: 93337 RVA: 0x005C974E File Offset: 0x005C794E
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06016C9A RID: 93338 RVA: 0x005C9756 File Offset: 0x005C7956
	private void RefreshRedDot()
	{
		base.GetItem(6).SetUIActive(this.ActivityData.GetRewardRedDotState());
		this.FunctionalComponent.SetFunctionRedDotVisible(this.ActivityData.GetActivityRedDotState());
	}

	// Token: 0x06016C9B RID: 93339 RVA: 0x005C9788 File Offset: 0x005C7988
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06016C9C RID: 93340 RVA: 0x005C97C4 File Offset: 0x005C79C4
	private void RefreshCondition()
	{
		this.RefreshRewardInfo();
		ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
		{
			UnlockBtnFunction = new Action(this.FunctionExecute)
		};
		this.FunctionalComponent.RefreshGeneralPerformance(parameters);
		bool levelUnlockRedDotState = this.ActivityData.GetLevelUnlockRedDotState();
		if (levelUnlockRedDotState)
		{
			this.FunctionalComponent.SetPanelTipByTextId("SurvivorsNewLevelUnlock", Array.Empty<string>());
		}
		this.FunctionalComponent.SetPanelTipVisible(levelUnlockRedDotState);
	}

	// Token: 0x06016C9D RID: 93341 RVA: 0x005C982C File Offset: 0x005C7A2C
	private void RefreshRewardInfo()
	{
		int finishedRewardTaskCount = this.ActivityData.GetFinishedRewardTaskCount();
		int count = this.ActivityData.RewardTaskMap.Count;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "SurvivorsReward", new <>z__ReadOnlyArray<object>(new object[]
		{
			finishedRewardTaskCount,
			count
		}));
	}

	// Token: 0x06016C9E RID: 93342 RVA: 0x005C9889 File Offset: 0x005C7A89
	private void OnBtnScore()
	{
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueRewardView, null, delegate(bool success, int viewId)
		{
			if (success && UiManager.Instance.IsViewShow(EUiViewName.CommonActivityView))
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06016C9F RID: 93343 RVA: 0x005C98BA File Offset: 0x005C7ABA
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityData.SaveCacheState(ESurvivorsActivitySaveFlags.ActivityOpen, 0, 0, 1))
			{
				this.ActivityData.RefreshActivityRedDot();
			}
			SurvivorsActivityData activityData = this.ActivityData;
			bool? flag = (activityData != null) ? new bool?(activityData.GetPreGuideQuestFinishState()) : null;
			if (flag == null || !flag.Value)
			{
				int unFinishPreGuideQuestId = this.ActivityData.GetUnFinishPreGuideQuestId();
				if (unFinishPreGuideQuestId > 0)
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				}
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueMainView, null, null);
		});
	}

	// Token: 0x0400A941 RID: 43329
	[Nullable(1)]
	private SurvivorsActivityData ActivityData;

	// Token: 0x0400A942 RID: 43330
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400A943 RID: 43331
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400A944 RID: 43332
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x0400A945 RID: 43333
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x020090EE RID: 37102
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402EF31 RID: 192305
		public const int TitleItem = 0;

		// Token: 0x0402EF32 RID: 192306
		public const int DescriptionItem = 1;

		// Token: 0x0402EF33 RID: 192307
		public const int RewardListItem = 2;

		// Token: 0x0402EF34 RID: 192308
		public const int FunctionArea = 3;

		// Token: 0x0402EF35 RID: 192309
		public const int BtnReward = 4;

		// Token: 0x0402EF36 RID: 192310
		public const int TxtReward = 5;

		// Token: 0x0402EF37 RID: 192311
		public const int BtnRewardRedDot = 6;
	}
}
