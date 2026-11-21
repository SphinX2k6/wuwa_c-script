using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200069C RID: 1692
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewCollection : ActivitySubViewBase
{
	// Token: 0x17000A92 RID: 2706
	// (get) Token: 0x06004DDF RID: 19935 RVA: 0x001A4BD4 File Offset: 0x001A2DD4
	// (set) Token: 0x06004DE0 RID: 19936 RVA: 0x001A4BDC File Offset: 0x001A2DDC
	protected ActivityCollectionData ActivityData { get; set; }

	// Token: 0x17000A93 RID: 2707
	// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x001A4BE5 File Offset: 0x001A2DE5
	// (set) Token: 0x06004DE2 RID: 19938 RVA: 0x001A4BED File Offset: 0x001A2DED
	private ActivityTitleTypeA TitleComponent { get; set; }

	// Token: 0x17000A94 RID: 2708
	// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x001A4BF6 File Offset: 0x001A2DF6
	// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x001A4BFE File Offset: 0x001A2DFE
	private ActivityDescriptionTypeA DescriptionComponent { get; set; }

	// Token: 0x17000A95 RID: 2709
	// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x001A4C07 File Offset: 0x001A2E07
	// (set) Token: 0x06004DE6 RID: 19942 RVA: 0x001A4C0F File Offset: 0x001A2E0F
	private ActivityProgressComponents ProgressComponent { get; set; }

	// Token: 0x17000A96 RID: 2710
	// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x001A4C18 File Offset: 0x001A2E18
	// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x001A4C20 File Offset: 0x001A2E20
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000A97 RID: 2711
	// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x001A4C29 File Offset: 0x001A2E29
	// (set) Token: 0x06004DEA RID: 19946 RVA: 0x001A4C31 File Offset: 0x001A2E31
	private ActivityFunctionalArea FunctionalComponent { get; set; }

	// Token: 0x17000A98 RID: 2712
	// (get) Token: 0x06004DEB RID: 19947 RVA: 0x001A4C3A File Offset: 0x001A2E3A
	// (set) Token: 0x06004DEC RID: 19948 RVA: 0x001A4C42 File Offset: 0x001A2E42
	private bool IsQuestLockTimeShow { get; set; }

	// Token: 0x17000A99 RID: 2713
	// (get) Token: 0x06004DED RID: 19949 RVA: 0x001A4C4B File Offset: 0x001A2E4B
	// (set) Token: 0x06004DEE RID: 19950 RVA: 0x001A4C53 File Offset: 0x001A2E53
	private long QuestLockTime { get; set; }

	// Token: 0x06004DEF RID: 19951 RVA: 0x001A4C5C File Offset: 0x001A2E5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x001A4D49 File Offset: 0x001A2F49
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityCollectionData)this.ActivityBaseData;
	}

	// Token: 0x06004DF1 RID: 19953 RVA: 0x001A4D5C File Offset: 0x001A2F5C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewCollection.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewCollection.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x001A4DA0 File Offset: 0x001A2FA0
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityData);
		this.TitleComponent.SetTitleByText(this.ActivityData.GetTitle());
		this.DescriptionComponent.SetUiActive(false);
		this.RefreshRewardComponent();
		this.OnRefreshView();
	}

	// Token: 0x06004DF3 RID: 19955 RVA: 0x001A4DEC File Offset: 0x001A2FEC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x001A4E26 File Offset: 0x001A3026
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x001A4E60 File Offset: 0x001A3060
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityData.Id)
		{
			this.RefreshRedDot();
		}
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x001A4E78 File Offset: 0x001A3078
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		ICollectionQuestState collectionQuestState;
		if (this.ActivityData.QuestStateMap.TryGetValue(questId, out collectionQuestState))
		{
			this.RefreshData();
			this.RefreshProgressComponent();
			this.NewQuestCheck();
		}
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x001A4EAC File Offset: 0x001A30AC
	protected override void OnRefreshView()
	{
		this.RefreshData();
		this.RefreshTimerText();
		this.RefreshProgressComponent();
		this.RefreshFunctionalComponent();
		this.RefreshRedDot();
		this.NewQuestCheck();
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x001A4ED4 File Offset: 0x001A30D4
	private void NewQuestCheck()
	{
		if (this.ActivityData.IsHasNewQuestRedDot())
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectionAtivity_NewQuest", null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
		}
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x001A4F05 File Offset: 0x001A3105
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06004DFA RID: 19962 RVA: 0x001A4F0D File Offset: 0x001A310D
	private void RefreshData()
	{
		this.ActivityData.RefreshRewardData();
	}

	// Token: 0x06004DFB RID: 19963 RVA: 0x001A4F1C File Offset: 0x001A311C
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
		if (this.IsQuestLockTimeShow)
		{
			ActivityProgressComponents progressComponent = this.ProgressComponent;
			if (progressComponent == null)
			{
				return;
			}
			progressComponent.SetDescriptionByTextId("CollectionAtivity_AcceptQuestTime", new string[]
			{
				this.GetRemainQuestUnlockTime(this.QuestLockTime)
			});
		}
	}

	// Token: 0x06004DFC RID: 19964 RVA: 0x001A4F8C File Offset: 0x001A318C
	private void RefreshProgressComponent()
	{
		int item = this.ActivityData.GetCurrentProgress().Item1;
		int totalProgress = this.ActivityData.GetTotalProgress();
		int currentProgressQuestId = this.ActivityData.GetCurrentProgressQuestId();
		IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(currentProgressQuestId);
		string text = (questConfig != null) ? questConfig.TidName : null;
		string descriptionByText = (text != null) ? PublicUtil.Instance.GetConfigTextByKey(text) : "";
		ActivityProgressComponents progressComponent = this.ProgressComponent;
		if (progressComponent != null)
		{
			progressComponent.SetProgressPercent((float)item / ((float)totalProgress * 1f));
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Text_ItemShow_Text", null);
		ActivityProgressComponents progressComponent2 = this.ProgressComponent;
		if (progressComponent2 != null)
		{
			progressComponent2.SetProgressTextByText(StringUtils.Format(localTextNew, new string[]
			{
				item.ToString(),
				totalProgress.ToString()
			}));
		}
		ActivityProgressComponents progressComponent3 = this.ProgressComponent;
		if (progressComponent3 != null)
		{
			progressComponent3.SetTitleByTextId("CollectActivity_schedule", Array.Empty<string>());
		}
		switch (this.ActivityData.GetProgressState())
		{
		case ECollectionState.PreQuest:
		{
			string preShowGuideQuestName = this.ActivityData.GetPreShowGuideQuestName();
			ActivityProgressComponents progressComponent4 = this.ProgressComponent;
			if (progressComponent4 == null)
			{
				return;
			}
			progressComponent4.SetDescriptionByText(preShowGuideQuestName);
			return;
		}
		case ECollectionState.InQuest:
		{
			ICollectionQuestState collectionQuestState;
			this.ActivityData.QuestStateMap.TryGetValue(currentProgressQuestId, out collectionQuestState);
			if (collectionQuestState != null)
			{
				bool flag = (double)collectionQuestState.QuestUnlockStamp - TimeUtil.Instance.GetServerTime() < 0.0;
				if (collectionQuestState.QuestState == 2 || flag)
				{
					ActivityProgressComponents progressComponent5 = this.ProgressComponent;
					if (progressComponent5 != null)
					{
						progressComponent5.SetDescriptionByText(descriptionByText);
					}
					this.IsQuestLockTimeShow = false;
					return;
				}
				this.QuestLockTime = collectionQuestState.QuestUnlockStamp;
				ActivityProgressComponents progressComponent6 = this.ProgressComponent;
				if (progressComponent6 != null)
				{
					progressComponent6.SetDescriptionByTextId("CollectionAtivity_AcceptQuestTime", new string[]
					{
						this.GetRemainQuestUnlockTime(this.QuestLockTime)
					});
				}
				this.IsQuestLockTimeShow = true;
				return;
			}
			break;
		}
		case ECollectionState.Finished:
		{
			ActivityProgressComponents progressComponent7 = this.ProgressComponent;
			if (progressComponent7 == null)
			{
				return;
			}
			progressComponent7.SetDescriptionByTextId("CollectActivity_state_finish", Array.Empty<string>());
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06004DFD RID: 19965 RVA: 0x001A5168 File Offset: 0x001A3368
	[NullableContext(1)]
	private string GetRemainQuestUnlockTime(long endTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)endTime - serverTime, TimeUtil.Instance.Minute);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> questLockTimeTypeData = this.GetQuestLockTimeTypeData(num);
		CommonDefine.ICountDown countDownDataFormat = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(questLockTimeTypeData.Item1), new CommonDefine.ETimeType?(questLockTimeTypeData.Item2));
		return ((countDownDataFormat != null) ? countDownDataFormat.CountDownText : null) ?? "";
	}

	// Token: 0x06004DFE RID: 19966 RVA: 0x001A51D2 File Offset: 0x001A33D2
	[NullableContext(0)]
	private ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetQuestLockTimeTypeData(double remainTime)
	{
		if (remainTime > 86400.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		if (remainTime > 3600.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Hour);
		}
		return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Minute);
	}

	// Token: 0x06004DFF RID: 19967 RVA: 0x001A5204 File Offset: 0x001A3404
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06004E00 RID: 19968 RVA: 0x001A5260 File Offset: 0x001A3460
	private void RefreshFunctionalComponent()
	{
		bool flag = this.ActivityData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityData.ConditionGroupId, this.ActivityData.Id);
		}
		this.FunctionalComponent.SetRewardButtonVisible(flag);
		if (flag)
		{
			this.FunctionalComponent.SetRewardButtonFunction(new Action(this.OpenRewardPopUp));
		}
		this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		if (flag)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.JumpFunction));
		}
	}

	// Token: 0x06004E01 RID: 19969 RVA: 0x001A5320 File Offset: 0x001A3520
	private void RefreshRedDot()
	{
		bool rewardRedDotVisible = this.ActivityData.IsHasRewardRedPoint();
		this.FunctionalComponent.SetRewardRedDotVisible(rewardRedDotVisible);
		bool redDotVisible = this.ActivityData.IsHasNewQuestRedDot();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06004E02 RID: 19970 RVA: 0x001A5362 File Offset: 0x001A3562
	[NullableContext(1)]
	public override void PlaySubViewSequence(string name, bool blockClick = false)
	{
		this.RefreshBg();
	}

	// Token: 0x06004E03 RID: 19971 RVA: 0x001A536C File Offset: 0x001A356C
	private void RefreshBg()
	{
		int item = this.ActivityData.GetCurrentProgress().Item1;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Shape0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		if (this.LevelSequencePlayer.GetCurrentSequence() == text)
		{
			this.LevelSequencePlayer.ReplaySequenceByKey(text);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
	}

	// Token: 0x06004E04 RID: 19972 RVA: 0x001A53E8 File Offset: 0x001A35E8
	private void OpenRewardPopUp()
	{
		IActivityRewardViewData allRewardQuestDataList = this.ActivityData.GetAllRewardQuestDataList();
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, allRewardQuestDataList, null);
	}

	// Token: 0x06004E05 RID: 19973 RVA: 0x001A5412 File Offset: 0x001A3612
	private void JumpFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			switch (this.ActivityData.GetProgressState())
			{
			case ECollectionState.PreQuest:
			{
				ActivitySubViewCollection.<>c__DisplayClass55_0 CS$<>8__locals1 = new ActivitySubViewCollection.<>c__DisplayClass55_0();
				CS$<>8__locals1.preGuideQuestId = this.ActivityData.GetUnFinishPreGuideQuestId();
				if (!QuestNewModel.Instance.IsTrackingQuest(CS$<>8__locals1.preGuideQuestId))
				{
					QuestNewController.Instance.RequestTrackQuest(CS$<>8__locals1.preGuideQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, new Action(CS$<>8__locals1.<JumpFunction>g__JumpToQuest|1));
					return;
				}
				CS$<>8__locals1.<JumpFunction>g__JumpToQuest|1();
				return;
			}
			case ECollectionState.InQuest:
			{
				int item = this.ActivityData.GetCurrentProgress().Item1;
				GatherActivity activityCollectionConfig = ActivityCollectionConfig.Instance.GetActivityCollectionConfig(item + 1);
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkId = new int?(activityCollectionConfig.MarkId),
					MarkType = EMarkType.None,
					OpenFogId = new int?(0)
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
				int currentProgressQuestId = this.ActivityData.GetCurrentProgressQuestId();
				ActivityModel.Instance.SaveActivityData(this.ActivityData.Id, currentProgressQuestId, 0, 0, 0);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
				return;
			}
			case ECollectionState.Finished:
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_prompt_finish", null);
				ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
				return;
			}
			default:
				return;
			}
		});
	}

	// Token: 0x0200695B RID: 26971
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022B31 RID: 142129
		public const int TitleItem = 0;

		// Token: 0x04022B32 RID: 142130
		public const int DescriptionItem = 1;

		// Token: 0x04022B33 RID: 142131
		public const int ProgressItem = 2;

		// Token: 0x04022B34 RID: 142132
		public const int RewardListItem = 3;

		// Token: 0x04022B35 RID: 142133
		public const int FunctionArea = 4;

		// Token: 0x04022B36 RID: 142134
		public const int BgView = 5;
	}
}
