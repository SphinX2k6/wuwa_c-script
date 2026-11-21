using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200203D RID: 8253
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsActivitySubView : ActivitySubViewBase
{
	// Token: 0x060146C2 RID: 83650 RVA: 0x005F5FF0 File Offset: 0x005F41F0
	protected override void OnSetData()
	{
		this.ActivityData = (SurvivorsActivityData)this.ActivityBaseData;
	}

	// Token: 0x060146C3 RID: 83651 RVA: 0x005F6004 File Offset: 0x005F4204
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

	// Token: 0x060146C4 RID: 83652 RVA: 0x005F60DC File Offset: 0x005F42DC
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsActivitySubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsActivitySubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060146C5 RID: 83653 RVA: 0x005F6120 File Offset: 0x005F4320
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

	// Token: 0x060146C6 RID: 83654 RVA: 0x005F6235 File Offset: 0x005F4435
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x060146C7 RID: 83655 RVA: 0x005F6253 File Offset: 0x005F4453
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
	}

	// Token: 0x060146C8 RID: 83656 RVA: 0x005F6271 File Offset: 0x005F4471
	private void OnRefreshRedDot(int activityId)
	{
		if (this.ActivityData.Id != activityId)
		{
			return;
		}
		this.RefreshRewardInfo();
		this.RefreshRedDot();
	}

	// Token: 0x060146C9 RID: 83657 RVA: 0x005F628E File Offset: 0x005F448E
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		this.RefreshRedDot();
		this.RefreshCondition();
	}

	// Token: 0x060146CA RID: 83658 RVA: 0x005F62A2 File Offset: 0x005F44A2
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x060146CB RID: 83659 RVA: 0x005F62AA File Offset: 0x005F44AA
	private void RefreshRedDot()
	{
		base.GetItem(6).SetUIActive(this.ActivityData.GetRewardRedDotState());
		this.FunctionalComponent.SetFunctionRedDotVisible(this.ActivityData.GetActivityRedDotState());
	}

	// Token: 0x060146CC RID: 83660 RVA: 0x005F62DC File Offset: 0x005F44DC
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

	// Token: 0x060146CD RID: 83661 RVA: 0x005F6318 File Offset: 0x005F4518
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

	// Token: 0x060146CE RID: 83662 RVA: 0x005F6380 File Offset: 0x005F4580
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

	// Token: 0x060146CF RID: 83663 RVA: 0x005F63DD File Offset: 0x005F45DD
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

	// Token: 0x060146D0 RID: 83664 RVA: 0x005F640E File Offset: 0x005F460E
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

	// Token: 0x0400AD47 RID: 44359
	[Nullable(1)]
	private SurvivorsActivityData ActivityData;

	// Token: 0x0400AD48 RID: 44360
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400AD49 RID: 44361
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400AD4A RID: 44362
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x0400AD4B RID: 44363
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x02008332 RID: 33586
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402A637 RID: 173623
		public const int TitleItem = 0;

		// Token: 0x0402A638 RID: 173624
		public const int DescriptionItem = 1;

		// Token: 0x0402A639 RID: 173625
		public const int RewardListItem = 2;

		// Token: 0x0402A63A RID: 173626
		public const int FunctionArea = 3;

		// Token: 0x0402A63B RID: 173627
		public const int BtnReward = 4;

		// Token: 0x0402A63C RID: 173628
		public const int TxtReward = 5;

		// Token: 0x0402A63D RID: 173629
		public const int BtnRewardRedDot = 6;
	}
}
