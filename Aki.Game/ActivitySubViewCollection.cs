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

// Token: 0x020011E8 RID: 4584
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewCollection : ActivitySubViewBase
{
	// Token: 0x17000A72 RID: 2674
	// (get) Token: 0x06007A48 RID: 31304 RVA: 0x0019BF28 File Offset: 0x0019A128
	// (set) Token: 0x06007A49 RID: 31305 RVA: 0x0019BF30 File Offset: 0x0019A130
	protected ActivityCollectionData ActivityData { get; set; }

	// Token: 0x17000A73 RID: 2675
	// (get) Token: 0x06007A4A RID: 31306 RVA: 0x0019BF39 File Offset: 0x0019A139
	// (set) Token: 0x06007A4B RID: 31307 RVA: 0x0019BF41 File Offset: 0x0019A141
	private ActivityTitleTypeA TitleComponent { get; set; }

	// Token: 0x17000A74 RID: 2676
	// (get) Token: 0x06007A4C RID: 31308 RVA: 0x0019BF4A File Offset: 0x0019A14A
	// (set) Token: 0x06007A4D RID: 31309 RVA: 0x0019BF52 File Offset: 0x0019A152
	private ActivityDescriptionTypeA DescriptionComponent { get; set; }

	// Token: 0x17000A75 RID: 2677
	// (get) Token: 0x06007A4E RID: 31310 RVA: 0x0019BF5B File Offset: 0x0019A15B
	// (set) Token: 0x06007A4F RID: 31311 RVA: 0x0019BF63 File Offset: 0x0019A163
	private ActivityProgressComponents ProgressComponent { get; set; }

	// Token: 0x17000A76 RID: 2678
	// (get) Token: 0x06007A50 RID: 31312 RVA: 0x0019BF6C File Offset: 0x0019A16C
	// (set) Token: 0x06007A51 RID: 31313 RVA: 0x0019BF74 File Offset: 0x0019A174
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

	// Token: 0x17000A77 RID: 2679
	// (get) Token: 0x06007A52 RID: 31314 RVA: 0x0019BF7D File Offset: 0x0019A17D
	// (set) Token: 0x06007A53 RID: 31315 RVA: 0x0019BF85 File Offset: 0x0019A185
	private ActivityFunctionalArea FunctionalComponent { get; set; }

	// Token: 0x17000A78 RID: 2680
	// (get) Token: 0x06007A54 RID: 31316 RVA: 0x0019BF8E File Offset: 0x0019A18E
	// (set) Token: 0x06007A55 RID: 31317 RVA: 0x0019BF96 File Offset: 0x0019A196
	private bool IsQuestLockTimeShow { get; set; }

	// Token: 0x17000A79 RID: 2681
	// (get) Token: 0x06007A56 RID: 31318 RVA: 0x0019BF9F File Offset: 0x0019A19F
	// (set) Token: 0x06007A57 RID: 31319 RVA: 0x0019BFA7 File Offset: 0x0019A1A7
	private long QuestLockTime { get; set; }

	// Token: 0x06007A58 RID: 31320 RVA: 0x0019BFB0 File Offset: 0x0019A1B0
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

	// Token: 0x06007A59 RID: 31321 RVA: 0x0019C09D File Offset: 0x0019A29D
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityCollectionData)this.ActivityBaseData;
	}

	// Token: 0x06007A5A RID: 31322 RVA: 0x0019C0B0 File Offset: 0x0019A2B0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewCollection.<OnBeforeStartAsync>d__35 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewCollection.<OnBeforeStartAsync>d__35>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007A5B RID: 31323 RVA: 0x0019C0F4 File Offset: 0x0019A2F4
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityData);
		this.TitleComponent.SetTitleByText(this.ActivityData.GetTitle());
		this.DescriptionComponent.SetUiActive(false);
		this.RefreshRewardComponent();
		this.OnRefreshView();
	}

	// Token: 0x06007A5C RID: 31324 RVA: 0x0019C140 File Offset: 0x0019A340
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06007A5D RID: 31325 RVA: 0x0019C17A File Offset: 0x0019A37A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06007A5E RID: 31326 RVA: 0x0019C1B4 File Offset: 0x0019A3B4
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityData.Id)
		{
			this.RefreshRedDot();
		}
	}

	// Token: 0x06007A5F RID: 31327 RVA: 0x0019C1CC File Offset: 0x0019A3CC
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

	// Token: 0x06007A60 RID: 31328 RVA: 0x0019C200 File Offset: 0x0019A400
	protected override void OnRefreshView()
	{
		this.RefreshData();
		this.RefreshTimerText();
		this.RefreshProgressComponent();
		this.RefreshFunctionalComponent();
		this.RefreshRedDot();
		this.NewQuestCheck();
	}

	// Token: 0x06007A61 RID: 31329 RVA: 0x0019C228 File Offset: 0x0019A428
	private void NewQuestCheck()
	{
		if (this.ActivityData.IsHasNewQuestRedDot())
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectionAtivity_NewQuest", null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
		}
	}

	// Token: 0x06007A62 RID: 31330 RVA: 0x0019C259 File Offset: 0x0019A459
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06007A63 RID: 31331 RVA: 0x0019C261 File Offset: 0x0019A461
	private void RefreshData()
	{
		this.ActivityData.RefreshRewardData();
	}

	// Token: 0x06007A64 RID: 31332 RVA: 0x0019C270 File Offset: 0x0019A470
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

	// Token: 0x06007A65 RID: 31333 RVA: 0x0019C2E0 File Offset: 0x0019A4E0
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

	// Token: 0x06007A66 RID: 31334 RVA: 0x0019C4BC File Offset: 0x0019A6BC
	[NullableContext(1)]
	private string GetRemainQuestUnlockTime(long endTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)endTime - serverTime, TimeUtil.Instance.Minute);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> questLockTimeTypeData = this.GetQuestLockTimeTypeData(num);
		CommonDefine.ICountDown countDownDataFormat = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(questLockTimeTypeData.Item1), new CommonDefine.ETimeType?(questLockTimeTypeData.Item2));
		return ((countDownDataFormat != null) ? countDownDataFormat.CountDownText : null) ?? "";
	}

	// Token: 0x06007A67 RID: 31335 RVA: 0x0019C526 File Offset: 0x0019A726
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

	// Token: 0x06007A68 RID: 31336 RVA: 0x0019C558 File Offset: 0x0019A758
	private void RefreshRewardComponent()
	{
		List<TItem> previewReward = this.ActivityData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06007A69 RID: 31337 RVA: 0x0019C5B4 File Offset: 0x0019A7B4
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

	// Token: 0x06007A6A RID: 31338 RVA: 0x0019C674 File Offset: 0x0019A874
	private void RefreshRedDot()
	{
		bool rewardRedDotVisible = this.ActivityData.IsHasRewardRedPoint();
		this.FunctionalComponent.SetRewardRedDotVisible(rewardRedDotVisible);
		bool redDotVisible = this.ActivityData.IsHasNewQuestRedDot();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06007A6B RID: 31339 RVA: 0x0019C6B6 File Offset: 0x0019A8B6
	[NullableContext(1)]
	public override void PlaySubViewSequence(string name, bool blockClick = false)
	{
		this.RefreshBg();
	}

	// Token: 0x06007A6C RID: 31340 RVA: 0x0019C6C0 File Offset: 0x0019A8C0
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

	// Token: 0x06007A6D RID: 31341 RVA: 0x0019C73C File Offset: 0x0019A93C
	private void OpenRewardPopUp()
	{
		IActivityRewardViewData allRewardQuestDataList = this.ActivityData.GetAllRewardQuestDataList();
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, allRewardQuestDataList, null);
	}

	// Token: 0x06007A6E RID: 31342 RVA: 0x0019C766 File Offset: 0x0019A966
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

	// Token: 0x020077D0 RID: 30672
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040277FF RID: 161791
		public const int TitleItem = 0;

		// Token: 0x04027800 RID: 161792
		public const int DescriptionItem = 1;

		// Token: 0x04027801 RID: 161793
		public const int ProgressItem = 2;

		// Token: 0x04027802 RID: 161794
		public const int RewardListItem = 3;

		// Token: 0x04027803 RID: 161795
		public const int FunctionArea = 4;

		// Token: 0x04027804 RID: 161796
		public const int BgView = 5;
	}
}
