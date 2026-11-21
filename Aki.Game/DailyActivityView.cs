using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EBC RID: 3772
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityView : UiTabViewBase
{
	// Token: 0x060096B3 RID: 38579 RVA: 0x002CA270 File Offset: 0x002C8470
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060096B4 RID: 38580 RVA: 0x002CA4D4 File Offset: 0x002C86D4
	protected override UniTask OnBeforeStartAsync()
	{
		DailyActivityView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DailyActivityView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060096B5 RID: 38581 RVA: 0x002CA518 File Offset: 0x002C8718
	protected override void OnStart()
	{
		this.TaskLoopView = new LoopScrollView<DailyActivityTaskItem, DailyActiveTaskData>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<DailyActivityTaskItem>(this.CreateDailyTaskItem), false);
		this.MainTabLayout = new GenericLayout<DailyActivityMainTabItem, DailyActivityDefine.IDailyActivityMainTabData>(base.GetHorizontalLayout(5), new Func<DailyActivityMainTabItem>(this.CreateMainTabItem), (AUIBaseActor)base.GetItem(6).GetOwner(), false, true);
		this.WeeklyChallengeLoopView = new LoopScrollView<WeeklyChallengeItem, WeeklyChallengeTaskData>(base.GetLoopScrollViewComponent(7), (AUIBaseActor)base.GetItem(8).GetOwner(), new Func<WeeklyChallengeItem>(this.CreateWeeklyChallengeItem), true);
		this.StartLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.RewardPopup = new CommonRewardPopup(this.RootItem);
	}

	// Token: 0x060096B6 RID: 38582 RVA: 0x002CA5D8 File Offset: 0x002C87D8
	protected override void OnBeforeDestroy()
	{
		DailyActivityRewardPanel dailyPanelProgress = this.DailyPanelProgress;
		if (dailyPanelProgress != null)
		{
			dailyPanelProgress.Destroy(null);
		}
		this.DailyPanelProgress = null;
		DailyActivityRewardPanel weeklyPanelProgress = this.WeeklyPanelProgress;
		if (weeklyPanelProgress != null)
		{
			weeklyPanelProgress.Destroy(null);
		}
		this.WeeklyPanelProgress = null;
		LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
		if (startLevelSequencePlayer != null)
		{
			startLevelSequencePlayer.Clear();
		}
		this.StartLevelSequencePlayer = null;
		this.RewardPopup = null;
		this.TaskDataList = new List<DailyActiveTaskData>();
		this.WeeklyTaskDataList = new List<WeeklyChallengeTaskData>();
	}

	// Token: 0x060096B7 RID: 38583 RVA: 0x002CA64C File Offset: 0x002C884C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DailyActivityRefresh, new Action(this.OnDailyActivityRefresh));
		EventSystem.Instance.Add(EEventName.DailyActivityTaskUpdate, new Action(this.OnDailyTaskChangeRefresh));
		EventSystem.Instance.Add<int>(EEventName.DailyActivityValueChange, new Action<int>(this.OnDailyValueChange));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.DailyActivityRewardTake, new Action<IReadOnlyList<int>>(this.OnDailyRewardTake));
		EventSystem.Instance.Add(EEventName.DailyUpdateNotify, new Action(this.OnDailyUpdate));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRefresh, new Action(this.OnWeeklyChallengeRefresh));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeScoreChanged, new Action(this.OnWeeklyScoreChanged));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRewardStateChanged, new Action(this.OnWeeklyRewardStateChanged));
		EventSystem.Instance.Add(EEventName.RefreshActivityRewardPopUp, new Action(this.OnRewardPopUpChange));
	}

	// Token: 0x060096B8 RID: 38584 RVA: 0x002CA758 File Offset: 0x002C8958
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DailyActivityRefresh, new Action(this.OnDailyActivityRefresh));
		EventSystem.Instance.Remove(EEventName.DailyActivityTaskUpdate, new Action(this.OnDailyTaskChangeRefresh));
		EventSystem.Instance.Remove<int>(EEventName.DailyActivityValueChange, new Action<int>(this.OnDailyValueChange));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.DailyActivityRewardTake, new Action<IReadOnlyList<int>>(this.OnDailyRewardTake));
		EventSystem.Instance.Remove(EEventName.DailyUpdateNotify, new Action(this.OnDailyUpdate));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRefresh, new Action(this.OnWeeklyChallengeRefresh));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeScoreChanged, new Action(this.OnWeeklyScoreChanged));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRewardStateChanged, new Action(this.OnWeeklyRewardStateChanged));
		EventSystem.Instance.Remove(EEventName.RefreshActivityRewardPopUp, new Action(this.OnRewardPopUpChange));
	}

	// Token: 0x060096B9 RID: 38585 RVA: 0x002CA864 File Offset: 0x002C8A64
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, 27);
		this.InitDailyActivityPanel();
		this.RefreshDoubleExpPanel();
		this.RefreshDailyCountDown(true);
		LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
		if (startLevelSequencePlayer != null)
		{
			startLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, delegate(RewardTakeComponent component)
		{
			component.SetDataCallback(delegate
			{
				if (this.CurrentMainTab == DailyActivityDefine.EDailyActivityMainTab.Weekly)
				{
					return WeeklyChallengeModel.Instance.GetLastNotTaken();
				}
				return DailyActivityModel.Instance.GetLastNotTaken();
			});
		});
	}

	// Token: 0x060096BA RID: 38586 RVA: 0x002CA8D0 File Offset: 0x002C8AD0
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		DailyActivityView.<OnBeforeShowAsyncImplement>d__21 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<DailyActivityView.<OnBeforeShowAsyncImplement>d__21>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060096BB RID: 38587 RVA: 0x002CA913 File Offset: 0x002C8B13
	protected override void OnBeforeHide()
	{
		this.RewardPopup.SetActive(false);
	}

	// Token: 0x060096BC RID: 38588 RVA: 0x002CA921 File Offset: 0x002C8B21
	protected override void OnTickUiTabViewBase(float deltaTime)
	{
		this.DailyPanelProgress.OnTickRefresh(deltaTime);
		this.WeeklyPanelProgress.OnTickRefresh(deltaTime);
		this.RefreshDailyCountDown(false);
		this.RefreshDoubleExpPanel();
	}

	// Token: 0x060096BD RID: 38589 RVA: 0x002CA948 File Offset: 0x002C8B48
	private void RefreshDoubleExpPanel()
	{
		UUIItem item = base.GetItem(16);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.CurrentMainTab == DailyActivityDefine.EDailyActivityMainTab.Daily && DailyActivityModel.Instance.IsUnionExpDoubleBonusActive());
	}

	// Token: 0x060096BE RID: 38590 RVA: 0x002CA974 File Offset: 0x002C8B74
	private void RefreshDailyCountDown(bool forceRefresh = false)
	{
		long num = (this.CurrentMainTab == DailyActivityDefine.EDailyActivityMainTab.Weekly) ? WeeklyChallengeModel.Instance.WeeklyEndTime : DailyActivityModel.Instance.DayEndTime;
		if (num == 0L && this.CountDownString != "")
		{
			this.CountDownString = "";
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num2 = Math.Max((double)num - serverTime, 0.0);
		string text = "";
		string text2;
		if (num2 <= TimeUtil.Instance.Minute)
		{
			text2 = "Text_RefreshText_Text01";
		}
		else
		{
			CommonDefine.ETimeType value = (num2 >= 86400.0) ? CommonDefine.ETimeType.Day : ((num2 >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
			CommonDefine.ETimeType value2 = (num2 >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num2 >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
			text = (TimeUtil.Instance.GetCountDownDataFormat2(num2, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2)).CountDownText ?? "");
			text2 = "Text_RefreshText_Text";
		}
		string text3 = text2 + "_" + text;
		if (this.CountDownString != text3 || forceRefresh)
		{
			this.CountDownString = text3;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), text2, new <>z__ReadOnlySingleElementList<object>(text));
	}

	// Token: 0x060096BF RID: 38591 RVA: 0x002CAAB8 File Offset: 0x002C8CB8
	private void OnDailyUpdate()
	{
		UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
		EUiViewName? euiViewName;
		if (topView == null)
		{
			euiViewName = null;
		}
		else
		{
			UiViewInfo viewInfo = topView.ViewInfo;
			euiViewName = ((viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
		}
		if (euiViewName != EUiViewName.AdventureGuideView)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DailyActivityRefresh);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060096C0 RID: 38592 RVA: 0x002CAB34 File Offset: 0x002C8D34
	private List<DailyActivityDefine.IDailyActivityMainTabData> BuildTabDataList()
	{
		List<DailyActivityDefine.IDailyActivityMainTabData> list = new List<DailyActivityDefine.IDailyActivityMainTabData>();
		if (FunctionModel.Instance.IsOpen(EFunctionType.DailyActivity))
		{
			Dictionary<int, DailyActivityDefine.IActivityGoalData> dailyActivityGoalMap = DailyActivityModel.Instance.DailyActivityGoalMap;
			bool flag = dailyActivityGoalMap.Count > 0;
			if (flag)
			{
				using (Dictionary<int, DailyActivityDefine.IActivityGoalData>.ValueCollection.Enumerator enumerator = dailyActivityGoalMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.State != EDailyActiveState.FinishedAndTaken)
						{
							flag = false;
							break;
						}
					}
				}
			}
			list.Add(new DailyActivityDefine.DailyActivityMainTabData
			{
				TabType = DailyActivityDefine.EDailyActivityMainTab.Daily,
				IsFinished = flag
			});
		}
		if (FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge) && WeeklyChallengeModel.Instance.WeeklyConfigId != 0)
		{
			IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> weeklyGoalMap = WeeklyChallengeModel.Instance.WeeklyGoalMap;
			bool flag2 = weeklyGoalMap.Count > 0;
			if (flag2)
			{
				using (IEnumerator<DailyActivityDefine.IActivityGoalData> enumerator2 = weeklyGoalMap.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.State != EDailyActiveState.FinishedAndTaken)
						{
							flag2 = false;
							break;
						}
					}
				}
			}
			list.Add(new DailyActivityDefine.DailyActivityMainTabData
			{
				TabType = DailyActivityDefine.EDailyActivityMainTab.Weekly,
				IsFinished = flag2
			});
		}
		return list;
	}

	// Token: 0x060096C1 RID: 38593 RVA: 0x002CAC70 File Offset: 0x002C8E70
	private void RefreshMainTabData()
	{
		this.MainTabLayout.RefreshByDataDirectlySync(this.BuildTabDataList());
	}

	// Token: 0x060096C2 RID: 38594 RVA: 0x002CAC84 File Offset: 0x002C8E84
	private UniTask InitTabViewAsync()
	{
		DailyActivityView.<InitTabViewAsync>d__29 <InitTabViewAsync>d__;
		<InitTabViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabViewAsync>d__.<>4__this = this;
		<InitTabViewAsync>d__.<>1__state = -1;
		<InitTabViewAsync>d__.<>t__builder.Start<DailyActivityView.<InitTabViewAsync>d__29>(ref <InitTabViewAsync>d__);
		return <InitTabViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060096C3 RID: 38595 RVA: 0x002CACC8 File Offset: 0x002C8EC8
	private void ApplyMainTabPanels(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		this.CurrentMainTab = tab;
		if (tab == DailyActivityDefine.EDailyActivityMainTab.Daily)
		{
			this.MarkTabOpened(tab);
		}
		bool flag = tab == DailyActivityDefine.EDailyActivityMainTab.Daily;
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(13);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (!flag)
		{
			this.InitWeeklyActivityPanel();
			this.RefreshWeeklyLoopView();
		}
		else if (this.TaskDataList != null)
		{
			this.PlayTaskLoopAnim();
		}
		this.RefreshDailyCountDown(true);
		this.RefreshDoubleExpPanel();
	}

	// Token: 0x060096C4 RID: 38596 RVA: 0x002CAD44 File Offset: 0x002C8F44
	private void MarkTabOpened(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		long num = (tab == DailyActivityDefine.EDailyActivityMainTab.Daily) ? DailyActivityModel.Instance.DayEndTime : WeeklyChallengeModel.Instance.WeeklyEndTime;
		if (num <= 0L)
		{
			return;
		}
		if ((long)DailyActivityModel.Instance.GetFirstOpenTabTime(tab).GetValueOrDefault() == num)
		{
			return;
		}
		DailyActivityModel.Instance.SetFirstOpenTabTime(tab, (int)num);
		EventSystem.Instance.Emit<int>(EEventName.DailyActivityMainTabOpened, (int)tab);
	}

	// Token: 0x060096C5 RID: 38597 RVA: 0x002CADA8 File Offset: 0x002C8FA8
	private void OnMainTabClick(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		if (tab == this.CurrentMainTab)
		{
			return;
		}
		GenericLayout<DailyActivityMainTabItem, DailyActivityDefine.IDailyActivityMainTabData> mainTabLayout = this.MainTabLayout;
		if (mainTabLayout != null)
		{
			mainTabLayout.SelectGridProxyByKey(tab, false);
		}
		this.ApplyMainTabPanels(tab);
	}

	// Token: 0x060096C6 RID: 38598 RVA: 0x002CADD3 File Offset: 0x002C8FD3
	private DailyActivityMainTabItem CreateMainTabItem()
	{
		return new DailyActivityMainTabItem
		{
			OnToggleCallBack = new Action<DailyActivityDefine.EDailyActivityMainTab>(this.OnMainTabClick)
		};
	}

	// Token: 0x060096C7 RID: 38599 RVA: 0x002CADEC File Offset: 0x002C8FEC
	private void PlayTaskLoopAnim()
	{
		UUIInturnAnimController uuiinturnAnimController = base.GetLoopScrollViewComponent(0).Content.Get().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
		if (uuiinturnAnimController == null)
		{
			return;
		}
		uuiinturnAnimController.Play("", -1, false);
	}

	// Token: 0x060096C8 RID: 38600 RVA: 0x002CAE34 File Offset: 0x002C9034
	private void RefreshDailyTaskView()
	{
		UiAsyncTask task = new UiAsyncTask("Refresh", delegate()
		{
			DailyActivityView.<<RefreshDailyTaskView>b__35_0>d <<RefreshDailyTaskView>b__35_0>d;
			<<RefreshDailyTaskView>b__35_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshDailyTaskView>b__35_0>d.<>4__this = this;
			<<RefreshDailyTaskView>b__35_0>d.<>1__state = -1;
			<<RefreshDailyTaskView>b__35_0>d.<>t__builder.Start<DailyActivityView.<<RefreshDailyTaskView>b__35_0>d>(ref <<RefreshDailyTaskView>b__35_0>d);
			return <<RefreshDailyTaskView>b__35_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060096C9 RID: 38601 RVA: 0x002CAE64 File Offset: 0x002C9064
	private UniTask RefreshDailyTaskViewAsync()
	{
		DailyActivityView.<RefreshDailyTaskViewAsync>d__36 <RefreshDailyTaskViewAsync>d__;
		<RefreshDailyTaskViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDailyTaskViewAsync>d__.<>4__this = this;
		<RefreshDailyTaskViewAsync>d__.<>1__state = -1;
		<RefreshDailyTaskViewAsync>d__.<>t__builder.Start<DailyActivityView.<RefreshDailyTaskViewAsync>d__36>(ref <RefreshDailyTaskViewAsync>d__);
		return <RefreshDailyTaskViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060096CA RID: 38602 RVA: 0x002CAEA8 File Offset: 0x002C90A8
	private void DailyTaskReward()
	{
		UiAsyncTask task = new UiAsyncTask("Refresh", delegate()
		{
			DailyActivityView.<<DailyTaskReward>b__37_0>d <<DailyTaskReward>b__37_0>d;
			<<DailyTaskReward>b__37_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<DailyTaskReward>b__37_0>d.<>4__this = this;
			<<DailyTaskReward>b__37_0>d.<>1__state = -1;
			<<DailyTaskReward>b__37_0>d.<>t__builder.Start<DailyActivityView.<<DailyTaskReward>b__37_0>d>(ref <<DailyTaskReward>b__37_0>d);
			return <<DailyTaskReward>b__37_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060096CB RID: 38603 RVA: 0x002CAED8 File Offset: 0x002C90D8
	private UniTask DailyTaskRewardImplAsync()
	{
		DailyActivityView.<DailyTaskRewardImplAsync>d__38 <DailyTaskRewardImplAsync>d__;
		<DailyTaskRewardImplAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DailyTaskRewardImplAsync>d__.<>4__this = this;
		<DailyTaskRewardImplAsync>d__.<>1__state = -1;
		<DailyTaskRewardImplAsync>d__.<>t__builder.Start<DailyActivityView.<DailyTaskRewardImplAsync>d__38>(ref <DailyTaskRewardImplAsync>d__);
		return <DailyTaskRewardImplAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060096CC RID: 38604 RVA: 0x002CAF1C File Offset: 0x002C911C
	private void InitDailyActivityPanel()
	{
		base.GetText(3).SetText("0", true);
		this.CurrentActivityValue = (float)DailyActivityModel.Instance.ActivityValue;
		base.GetText(2).SetText(this.CurrentActivityValue.ToString(), true);
		this.DailyPanelProgress.Init();
	}

	// Token: 0x060096CD RID: 38605 RVA: 0x002CAF70 File Offset: 0x002C9170
	private float SetDailyActivityValue()
	{
		int activityValue = DailyActivityModel.Instance.ActivityValue;
		base.GetText(2).SetText(activityValue.ToString(), true);
		if ((float)activityValue > this.CurrentActivityValue)
		{
			if (this.UiViewSequence.HasSequenceNameInPlaying("Refresh"))
			{
				this.UiViewSequence.ReplaySequence("Refresh");
			}
			else
			{
				this.UiViewSequence.PlaySequence("Refresh", false, null);
			}
		}
		this.CurrentActivityValue = (float)activityValue;
		return (float)activityValue;
	}

	// Token: 0x060096CE RID: 38606 RVA: 0x002CAFF0 File Offset: 0x002C91F0
	private void RefreshDailyActivityPanel()
	{
		float value = this.SetDailyActivityValue();
		this.DailyPanelProgress.RefreshProgressBarDynamic(value);
	}

	// Token: 0x060096CF RID: 38607 RVA: 0x002CB010 File Offset: 0x002C9210
	private void OnDailyActivityRefresh()
	{
		this.RefreshDailyTaskView();
		this.SetDailyActivityValue();
		this.DailyPanelProgress.Init();
		if (this.CurrentMainTab == DailyActivityDefine.EDailyActivityMainTab.Daily)
		{
			this.MarkTabOpened(DailyActivityDefine.EDailyActivityMainTab.Daily);
		}
		this.RefreshMainTabData();
	}

	// Token: 0x060096D0 RID: 38608 RVA: 0x002CB040 File Offset: 0x002C9240
	private void OnDailyTaskChangeRefresh()
	{
		this.RefreshDailyTaskView();
	}

	// Token: 0x060096D1 RID: 38609 RVA: 0x002CB048 File Offset: 0x002C9248
	private void OnDailyValueChange(int value)
	{
		this.RefreshDailyActivityPanel();
		this.RefreshMainTabData();
	}

	// Token: 0x060096D2 RID: 38610 RVA: 0x002CB056 File Offset: 0x002C9256
	private void OnDailyRewardTake(IReadOnlyList<int> _)
	{
		this.RefreshMainTabData();
	}

	// Token: 0x060096D3 RID: 38611 RVA: 0x002CB05E File Offset: 0x002C925E
	private DailyActivityTaskItem CreateDailyTaskItem()
	{
		DailyActivityTaskItem dailyActivityTaskItem = new DailyActivityTaskItem();
		dailyActivityTaskItem.SetClickReceiveCb(new Action(this.DailyTaskReward));
		return dailyActivityTaskItem;
	}

	// Token: 0x060096D4 RID: 38612 RVA: 0x002CB078 File Offset: 0x002C9278
	private void OnRewardPopUpChange()
	{
		RewardPopupData rewardData = DailyActivityModel.Instance.RewardData;
		this.RewardPopup.Refresh(rewardData);
	}

	// Token: 0x060096D5 RID: 38613 RVA: 0x002CB09C File Offset: 0x002C929C
	private void InitWeeklyActivityPanel()
	{
		base.GetText(10).SetText("0", true);
		int weeklyCurrentScore = WeeklyChallengeModel.Instance.WeeklyCurrentScore;
		base.GetText(9).SetText(weeklyCurrentScore.ToString(), true);
		this.WeeklyPanelProgress.Init();
	}

	// Token: 0x060096D6 RID: 38614 RVA: 0x002CB0E7 File Offset: 0x002C92E7
	private WeeklyChallengeItem CreateWeeklyChallengeItem()
	{
		return new WeeklyChallengeItem();
	}

	// Token: 0x060096D7 RID: 38615 RVA: 0x002CB0F0 File Offset: 0x002C92F0
	private List<WeeklyChallengeTaskData> BuildWeeklyChallengeTaskDataList()
	{
		List<int> list = WeeklyChallengeModel.Instance.WeeklyPlayIds ?? new List<int>();
		List<WeeklyChallengeTaskData> list2 = new List<WeeklyChallengeTaskData>();
		foreach (int num in list)
		{
			WeeklyFrameHelp? playConfigById = WeeklyChallengeConfig.Instance.GetPlayConfigById(num);
			if (playConfigById != null)
			{
				int unlockCondition = playConfigById.Value.UnlockCondition;
				bool isUnlocked = unlockCondition <= 0 || LevelGeneralController.Instance.CheckCondition(unlockCondition.ToString(), null, true, Array.Empty<object>());
				list2.Add(new WeeklyChallengeTaskData
				{
					ConfigId = num,
					IsUnlocked = isUnlocked
				});
			}
		}
		list2.Sort(delegate(WeeklyChallengeTaskData a, WeeklyChallengeTaskData b)
		{
			WeeklyFrameHelp? playConfigById2 = WeeklyChallengeConfig.Instance.GetPlayConfigById(a.ConfigId);
			WeeklyFrameHelp? playConfigById3 = WeeklyChallengeConfig.Instance.GetPlayConfigById(b.ConfigId);
			int num2 = ((playConfigById3 != null) ? playConfigById3.GetValueOrDefault().Sort : 0) - ((playConfigById2 != null) ? playConfigById2.GetValueOrDefault().Sort : 0);
			if (num2 != 0)
			{
				return num2;
			}
			return b.ConfigId - a.ConfigId;
		});
		if (list2.Count < 3)
		{
			for (int i = list2.Count; i < 3; i++)
			{
				list2.Add(new WeeklyChallengeTaskData
				{
					ConfigId = 0,
					IsUnlocked = false
				});
			}
		}
		return list2;
	}

	// Token: 0x060096D8 RID: 38616 RVA: 0x002CB210 File Offset: 0x002C9410
	private void RefreshWeeklyLoopView()
	{
		UiAsyncTask task = new UiAsyncTask("RefreshWeekly", delegate()
		{
			DailyActivityView.<<RefreshWeeklyLoopView>b__51_0>d <<RefreshWeeklyLoopView>b__51_0>d;
			<<RefreshWeeklyLoopView>b__51_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshWeeklyLoopView>b__51_0>d.<>4__this = this;
			<<RefreshWeeklyLoopView>b__51_0>d.<>1__state = -1;
			<<RefreshWeeklyLoopView>b__51_0>d.<>t__builder.Start<DailyActivityView.<<RefreshWeeklyLoopView>b__51_0>d>(ref <<RefreshWeeklyLoopView>b__51_0>d);
			return <<RefreshWeeklyLoopView>b__51_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060096D9 RID: 38617 RVA: 0x002CB240 File Offset: 0x002C9440
	private UniTask RefreshWeeklyLoopViewAsync()
	{
		DailyActivityView.<RefreshWeeklyLoopViewAsync>d__52 <RefreshWeeklyLoopViewAsync>d__;
		<RefreshWeeklyLoopViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshWeeklyLoopViewAsync>d__.<>4__this = this;
		<RefreshWeeklyLoopViewAsync>d__.<>1__state = -1;
		<RefreshWeeklyLoopViewAsync>d__.<>t__builder.Start<DailyActivityView.<RefreshWeeklyLoopViewAsync>d__52>(ref <RefreshWeeklyLoopViewAsync>d__);
		return <RefreshWeeklyLoopViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060096DA RID: 38618 RVA: 0x002CB283 File Offset: 0x002C9483
	private void OnWeeklyChallengeRefresh()
	{
		this.RefreshWeeklyLoopView();
		if (this.CurrentMainTab == DailyActivityDefine.EDailyActivityMainTab.Weekly)
		{
			this.WeeklyPanelProgress.Init();
		}
		this.RefreshMainTabData();
	}

	// Token: 0x060096DB RID: 38619 RVA: 0x002CB2A8 File Offset: 0x002C94A8
	private void OnWeeklyScoreChanged()
	{
		if (this.CurrentMainTab != DailyActivityDefine.EDailyActivityMainTab.Weekly)
		{
			return;
		}
		int weeklyCurrentScore = WeeklyChallengeModel.Instance.WeeklyCurrentScore;
		base.GetText(9).SetText(weeklyCurrentScore.ToString(), true);
		this.WeeklyPanelProgress.RefreshProgressBarDynamic((float)weeklyCurrentScore);
	}

	// Token: 0x060096DC RID: 38620 RVA: 0x002CB2EC File Offset: 0x002C94EC
	private void OnWeeklyRewardStateChanged()
	{
		this.RefreshMainTabData();
		if (this.CurrentMainTab != DailyActivityDefine.EDailyActivityMainTab.Weekly)
		{
			return;
		}
		this.WeeklyPanelProgress.Init();
	}

	// Token: 0x060096DD RID: 38621 RVA: 0x002CB30C File Offset: 0x002C950C
	[NullableContext(2)]
	private UUIItem GetActivityMainTabByIndex(int index)
	{
		if (this.MainTabLayout == null)
		{
			return null;
		}
		DailyActivityMainTabItem layoutItemByIndex = this.MainTabLayout.GetLayoutItemByIndex(index);
		if (layoutItemByIndex == null)
		{
			return null;
		}
		return layoutItemByIndex.GetRootItem();
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x002CB33C File Offset: 0x002C953C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length >= 2)
		{
			string a = configParams[0].ToString();
			int num = int.Parse(configParams[1]);
			if (a == "Task")
			{
				UUIItem gridByDisplayIndex = this.TaskLoopView.GetGridByDisplayIndex(num);
				if (gridByDisplayIndex != null)
				{
					return new UUIItem[]
					{
						gridByDisplayIndex,
						gridByDisplayIndex
					};
				}
			}
			else if (a == "Gift")
			{
				UUIItem rewardItemByIndex = this.DailyPanelProgress.GetRewardItemByIndex(num);
				if (rewardItemByIndex != null)
				{
					return new UUIItem[]
					{
						rewardItemByIndex,
						rewardItemByIndex
					};
				}
			}
			else if (a == "ActivityMainTab")
			{
				UUIItem activityMainTabByIndex = this.GetActivityMainTabByIndex(num);
				if (activityMainTabByIndex == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					activityMainTabByIndex,
					activityMainTabByIndex
				};
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Guide;
		ELogAuthor author = ELogAuthor.JT;
		string message = "聚焦引导extraParam项配置有误";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x04005A92 RID: 23186
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<DailyActivityTaskItem, DailyActiveTaskData> TaskLoopView;

	// Token: 0x04005A93 RID: 23187
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<DailyActiveTaskData> TaskDataList;

	// Token: 0x04005A94 RID: 23188
	[Nullable(2)]
	private DailyActivityRewardPanel DailyPanelProgress;

	// Token: 0x04005A95 RID: 23189
	[Nullable(2)]
	private DailyActivityRewardPanel WeeklyPanelProgress;

	// Token: 0x04005A96 RID: 23190
	[Nullable(2)]
	private CommonRewardPopup RewardPopup;

	// Token: 0x04005A97 RID: 23191
	[Nullable(2)]
	private string CountDownString;

	// Token: 0x04005A98 RID: 23192
	[Nullable(2)]
	private LevelSequencePlayer StartLevelSequencePlayer;

	// Token: 0x04005A99 RID: 23193
	private float CurrentActivityValue;

	// Token: 0x04005A9A RID: 23194
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DailyActivityMainTabItem, DailyActivityDefine.IDailyActivityMainTabData> MainTabLayout;

	// Token: 0x04005A9B RID: 23195
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<WeeklyChallengeItem, WeeklyChallengeTaskData> WeeklyChallengeLoopView;

	// Token: 0x04005A9C RID: 23196
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<WeeklyChallengeTaskData> WeeklyTaskDataList;

	// Token: 0x04005A9D RID: 23197
	private DailyActivityDefine.EDailyActivityMainTab CurrentMainTab = DailyActivityDefine.EDailyActivityMainTab.Daily;

	// Token: 0x04005A9E RID: 23198
	private readonly DailyActivityRewardAdapter DailyRewardAdapter = new DailyActivityRewardAdapter();

	// Token: 0x04005A9F RID: 23199
	private readonly WeeklyActivityRewardAdapter WeeklyRewardAdapter = new WeeklyActivityRewardAdapter();
}
