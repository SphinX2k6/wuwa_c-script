using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200079E RID: 1950
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMoonChasing : ActivitySubViewBase
{
	// Token: 0x17000B99 RID: 2969
	// (get) Token: 0x06005952 RID: 22866 RVA: 0x001D0AC6 File Offset: 0x001CECC6
	protected new ActivityMoonChasingData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as ActivityMoonChasingData;
		}
	}

	// Token: 0x06005953 RID: 22867 RVA: 0x001D0AD4 File Offset: 0x001CECD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x06005954 RID: 22868 RVA: 0x001D0BC9 File Offset: 0x001CEDC9
	protected override void OnSetData()
	{
	}

	// Token: 0x06005955 RID: 22869 RVA: 0x001D0BCC File Offset: 0x001CEDCC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMoonChasing.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMoonChasing.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x001D0C10 File Offset: 0x001CEE10
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
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
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetActive(previewReward.Count > 0);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		base.GetItem(4).SetUIActive(false);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.JumpFunction));
		this.QuestPanelTips.SetActive(false);
		this.QuestPanelTips.SetRewardButtonFunction(new Action(this.PreStageQuestJump));
	}

	// Token: 0x06005957 RID: 22871 RVA: 0x001D0D69 File Offset: 0x001CEF69
	protected override void OnRefreshView()
	{
		this.RefreshFunctionalComponent();
		this.RefreshQuestTips();
		this.RefreshButton();
		this.RefreshRedDot();
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x001D0D83 File Offset: 0x001CEF83
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x001D0D8B File Offset: 0x001CEF8B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x001D0DA9 File Offset: 0x001CEFA9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600595B RID: 22875 RVA: 0x001D0DC8 File Offset: 0x001CEFC8
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIItem guideUiItem = base.GetGuideUiItem("0");
		if (guideUiItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			guideUiItem,
			guideUiItem
		};
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x001D0DF4 File Offset: 0x001CEFF4
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityBaseData.Id)
		{
			this.RefreshRedDot();
		}
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x001D0E0C File Offset: 0x001CF00C
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

	// Token: 0x0600595E RID: 22878 RVA: 0x001D0E48 File Offset: 0x001CF048
	private void RefreshQuestTips()
	{
		bool flag = this.ActivityBaseData.IsPreStageQuestFinished();
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		this.QuestPanelTips.SetActive(!flag && !preGuideQuestFinishState);
		if (flag)
		{
			return;
		}
		TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(this.ActivityBaseData.Id);
		this.QuestPanelTips.SetContentByTextId(activityMoonChasingConfig.Value.StageQuestTips, Array.Empty<string>());
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x001D0EBC File Offset: 0x001CF0BC
	private void RefreshButton()
	{
		int handbookUnlockCount = MoonChasingModel.Instance.GetHandbookUnlockCount();
		int count = MoonChasingBuildingModel.Instance.GetAllBuildingData().Count;
		this.HandbookBtn.SetText(handbookUnlockCount.ToString() + "/" + count.ToString());
		int targetTotalCount = MoonChasingRewardModel.Instance.TargetTotalCount;
		int num = Math.Min(targetTotalCount, MoonChasingRewardModel.Instance.TargetGetCount);
		this.RewardBtn.SetText(num.ToString() + "/" + targetTotalCount.ToString());
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x001D0F46 File Offset: 0x001CF146
	private void PreStageQuestJump()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetPreStageQuestId(), null);
	}

	// Token: 0x06005961 RID: 22881 RVA: 0x001D0F68 File Offset: 0x001CF168
	private void RefreshFunctionalComponent()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		EMoonChasingActivityFlow activityFlowState = this.ActivityBaseData.ActivityFlowState;
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
		this.FunctionalComponent.SetRewardButtonVisible(false);
		base.GetItem(6).SetUIActive(false);
		this.RewardBtn.SetActive(this.ActivityBaseData.PermanentTargetOn && flag && preGuideQuestFinishState);
		this.HandbookBtn.SetActive(flag && preGuideQuestFinishState && activityFlowState == EMoonChasingActivityFlow.Activity);
		this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		string showText = "Moonfiesta_Skip";
		if (activityFlowState == EMoonChasingActivityFlow.Close)
		{
			showText = "Moonfiesta_Memory";
		}
		else if (!preGuideQuestFinishState)
		{
			showText = "JumpToQuestText";
		}
		this.FunctionalComponent.FunctionButton.SetShowText(showText);
	}

	// Token: 0x06005962 RID: 22882 RVA: 0x001D1053 File Offset: 0x001CF253
	private void RefreshRedDot()
	{
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(this.ActivityBaseData.IsHasMoonChasingRedDot());
		this.HandbookBtn.BindRedDot(ERedDotName.MoonChasingHandbook, 0);
		this.RewardBtn.BindRedDot(ERedDotName.MoonChasingRewardAndShop, 0);
	}

	// Token: 0x06005963 RID: 22883 RVA: 0x001D1094 File Offset: 0x001CF294
	private void SkipToReward()
	{
		if (this.ActivityBaseData.PermanentTargetOn)
		{
			bool canAccomplishTask = this.ActivityBaseData.ActivityFlowState == EMoonChasingActivityFlow.Activity;
			MoonChasingController.Instance.OpenRewardView(canAccomplishTask);
		}
	}

	// Token: 0x06005964 RID: 22884 RVA: 0x001D10C8 File Offset: 0x001CF2C8
	private void SkipToHandbook()
	{
		MoonChasingController.Instance.OpenHandbookView();
	}

	// Token: 0x06005965 RID: 22885 RVA: 0x001D10D4 File Offset: 0x001CF2D4
	protected void OpenRewardPopUp()
	{
		if (!this.ActivityBaseData.LimitTimeRewardOn)
		{
			return;
		}
		IActivityRewardViewData allRewardData = this.ActivityBaseData.GetAllRewardData();
		if (allRewardData == null)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, allRewardData, null);
	}

	// Token: 0x06005966 RID: 22886 RVA: 0x001D1110 File Offset: 0x001CF310
	private void JumpFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.ActivityBaseData.ActivityFlowState == EMoonChasingActivityFlow.Close)
			{
				MoonChasingController.Instance.OpenMemoryEntranceView();
				return;
			}
			if (this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(this.ActivityBaseData.Id);
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkId = new int?(activityMoonChasingConfig.Value.FocusMarkId),
					MarkType = EMarkType.SmallTeleport
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
				return;
			}
			if (!this.ActivityBaseData.IsPreStageQuestFinished())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingJumpPreQuest);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
		});
	}

	// Token: 0x04003C96 RID: 15510
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003C97 RID: 15511
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003C98 RID: 15512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003C99 RID: 15513
	private ActivityFunctionalArea FunctionalComponent;

	// Token: 0x04003C9A RID: 15514
	private ActivityQuestTipsItem QuestPanelTips;

	// Token: 0x04003C9B RID: 15515
	private ButtonItem HandbookBtn;

	// Token: 0x04003C9C RID: 15516
	private ButtonItem RewardBtn;

	// Token: 0x02006A95 RID: 27285
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402312F RID: 143663
		public const int TitleItem = 0;

		// Token: 0x04023130 RID: 143664
		public const int DescriptionItem = 1;

		// Token: 0x04023131 RID: 143665
		public const int RewardListItem = 2;

		// Token: 0x04023132 RID: 143666
		public const int FunctionArea = 3;

		// Token: 0x04023133 RID: 143667
		public const int PermanentTargetItem = 4;

		// Token: 0x04023134 RID: 143668
		public const int PermanentButton = 5;

		// Token: 0x04023135 RID: 143669
		public const int PermanentButtonRedDot = 6;

		// Token: 0x04023136 RID: 143670
		public const int QuestPanelTips = 7;

		// Token: 0x04023137 RID: 143671
		public const int ButtonReward = 8;

		// Token: 0x04023138 RID: 143672
		public const int ButtonHandbook = 9;
	}
}
