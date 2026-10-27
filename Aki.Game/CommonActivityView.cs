using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001685 RID: 5765
[NullableContext(1)]
[Nullable(0)]
public class CommonActivityView : UiViewBase
{
	// Token: 0x0600A313 RID: 41747 RVA: 0x002405D8 File Offset: 0x0023E7D8
	public CommonActivityView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000DCA RID: 3530
	// (get) Token: 0x0600A314 RID: 41748 RVA: 0x00240658 File Offset: 0x0023E858
	private int CurrentSelectActivityId
	{
		get
		{
			int? currentSelectTabId = this.CurrentSelectTabId;
			int? num;
			if (currentSelectTabId == null)
			{
				IActivityCategoryTabData[] tabDataList = this.TabDataList;
				if (tabDataList == null)
				{
					num = null;
				}
				else
				{
					IActivityCategoryTabData activityCategoryTabData = tabDataList.FirstOrDefault<IActivityCategoryTabData>();
					num = ((activityCategoryTabData != null) ? activityCategoryTabData.Id : null);
				}
			}
			else
			{
				num = currentSelectTabId;
			}
			int? num2 = num;
			if (num2 == null)
			{
				return 0;
			}
			int result;
			if (!this.SelectActivityIdMap.TryGetValue((EActivityTimeType)num2.Value, out result))
			{
				return 0;
			}
			return result;
		}
	}

	// Token: 0x0600A315 RID: 41749 RVA: 0x002406CC File Offset: 0x0023E8CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIDynScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickBack));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickTopRedDot));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickBottomRedDot));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A316 RID: 41750 RVA: 0x002409F8 File Offset: 0x0023EBF8
	protected override void OnAddEventListener()
	{
		this.BindToggleRedDot();
		EventSystem.Instance.Add(EEventName.ActivityViewChange, new Action<int>(this.ActivityViewChange));
		EventSystem.Instance.Add(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefresh));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityUpdate));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityUpdate));
		EventSystem.Instance.Add(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		EventSystem.Instance.Add<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, new Action<bool, EActivityViewState, bool?>(this.UpdateListShowState));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new Action<IReadOnlyList<int>>(this.OnSetActivityViewCurrency));
		EventSystem.Instance.Add(EEventName.ChangeActivityViewNeedBlurState, new Action<bool>(this.OnChangeActivityViewNeedBlurState));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotUpdate));
		EventSystem.Instance.Add(EEventName.RefreshActivityRecommendRedDot, new Action(this.RefreshRecommendEntryRedDot));
		EventSystem.Instance.Add(EEventName.OnServerStorageInfoInited, new Action(this.RefreshRecommendEntryRedDot));
	}

	// Token: 0x0600A317 RID: 41751 RVA: 0x00240B40 File Offset: 0x0023ED40
	protected override void OnRemoveEventListener()
	{
		this.UnBindToggleRedDot();
		EventSystem.Instance.Remove(EEventName.ActivityViewChange, new Action<int>(this.ActivityViewChange));
		EventSystem.Instance.Remove(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityViewRefresh));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityUpdate));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityOpen, new Action<IReadOnlySet<int>>(this.OnActivityUpdate));
		EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		EventSystem.Instance.Remove<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, new Action<bool, EActivityViewState, bool?>(this.UpdateListShowState));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new Action<IReadOnlyList<int>>(this.OnSetActivityViewCurrency));
		EventSystem.Instance.Remove(EEventName.ChangeActivityViewNeedBlurState, new Action<bool>(this.OnChangeActivityViewNeedBlurState));
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRedDotUpdate));
		EventSystem.Instance.Remove(EEventName.RefreshActivityRecommendRedDot, new Action(this.RefreshRecommendEntryRedDot));
		EventSystem.Instance.Remove(EEventName.OnServerStorageInfoInited, new Action(this.RefreshRecommendEntryRedDot));
	}

	// Token: 0x0600A318 RID: 41752 RVA: 0x00240C88 File Offset: 0x0023EE88
	protected override UniTask OnBeforeStartAsync()
	{
		CommonActivityView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonActivityView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A319 RID: 41753 RVA: 0x00240CCC File Offset: 0x0023EECC
	private void InitTabDataList()
	{
		List<IActivityCategoryTabData> list = new List<IActivityCategoryTabData>();
		List<int> sortTabList = this.GetSortTabList();
		if (sortTabList == null)
		{
			return;
		}
		List<ActivityBaseData> currentShowingActivities = ActivityModel.Instance.GetCurrentShowingActivities();
		foreach (int id in sortTabList)
		{
			ActivityFilter? activityFilter = ActivityConfig.Instance.GetActivityFilter(id);
			if (activityFilter != null)
			{
				ActivityFilter value = activityFilter.Value;
				List<ActivityBaseData> list2 = this.FilterActivitiesByTabId(currentShowingActivities, value.Id);
				if (list2.Count != 0)
				{
					if (list.Count > 0 && value.Id == 999)
					{
						list.Add(new ActivityCategoryTabData
						{
							IsLineType = true
						});
					}
					list.Add(new ActivityCategoryTabData
					{
						Id = new int?(value.Id),
						TextId = value.FilterName,
						IsLineType = false,
						IconPath = value.FilterIcon,
						Activities = list2
					});
				}
			}
		}
		this.TabDataList = list.ToArray();
		DynamicScrollView<ActivitySwitchToggle, ActivitySwitchToggleDynamicItem, IActivityCategoryTabData> categoryScrollView = this.CategoryScrollView;
		if (categoryScrollView == null)
		{
			return;
		}
		categoryScrollView.RefreshByData(this.TabDataList, false, false);
	}

	// Token: 0x0600A31A RID: 41754 RVA: 0x00240E08 File Offset: 0x0023F008
	[NullableContext(2)]
	private List<int> GetSortTabList()
	{
		IReadOnlyList<ActivityFilter> allActivityFilter = ActivityConfig.Instance.GetAllActivityFilter();
		if (allActivityFilter == null)
		{
			return null;
		}
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		foreach (ActivityFilter activityFilter in allActivityFilter)
		{
			list.Add(new ValueTuple<int, int>(activityFilter.Id, activityFilter.SortId));
		}
		list.Sort(([TupleElementNames(new string[]
		{
			"Id",
			"SortId"
		})] ValueTuple<int, int> a, [TupleElementNames(new string[]
		{
			"Id",
			"SortId"
		})] ValueTuple<int, int> b) => a.Item2.CompareTo(b.Item2));
		return (from item in list
		select item.Item1).ToList<int>();
	}

	// Token: 0x0600A31B RID: 41755 RVA: 0x00240EC8 File Offset: 0x0023F0C8
	private ActivitySwitchToggle OnCreateCategoryItemView(IActivityCategoryTabData data, UUIItem uiItem, int index)
	{
		ActivitySwitchToggle activitySwitchToggle = new ActivitySwitchToggle();
		activitySwitchToggle.InitData(data);
		activitySwitchToggle.SetOnToggleClicked(new TOnToggleClickCb(this.ToggleActivityTypeClick));
		return activitySwitchToggle;
	}

	// Token: 0x0600A31C RID: 41756 RVA: 0x00240EE8 File Offset: 0x0023F0E8
	private void CreateLeftScrollView()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.SubViewTabLayout = new GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData>(scrollViewWithScrollbar, new Func<ActivityPageSelectContent>(this.InitTabItem), null, false, null);
	}

	// Token: 0x0600A31D RID: 41757 RVA: 0x00240F18 File Offset: 0x0023F118
	private UniTask CreateViewSubComponents()
	{
		CommonActivityView.<CreateViewSubComponents>d__39 <CreateViewSubComponents>d__;
		<CreateViewSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateViewSubComponents>d__.<>4__this = this;
		<CreateViewSubComponents>d__.<>1__state = -1;
		<CreateViewSubComponents>d__.<>t__builder.Start<CommonActivityView.<CreateViewSubComponents>d__39>(ref <CreateViewSubComponents>d__);
		return <CreateViewSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x0600A31E RID: 41758 RVA: 0x00240F5C File Offset: 0x0023F15C
	protected override void OnStart()
	{
		EActivityViewOpenType openType = EActivityViewOpenType.Other;
		object[] array = this.OpenParam as object[];
		if (array != null && array.Length != 0)
		{
			openType = (EActivityViewOpenType)array[0];
			if (array.Length > 1)
			{
				int num = (int)array[1];
			}
			if (array.Length > 2)
			{
				this.SubViewOpenParam = array[2];
			}
		}
		ActivityModel.Instance.SendActivityViewOpenLogData(openType);
		this.ViewSaveStateSequence = ActivityViewStateSequence.Value[EActivityViewState.Side].ToList<string>();
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetTitleLocalText("Activity_Title");
		}
		this.SetDebugText();
		this.InitTabDataList();
	}

	// Token: 0x0600A31F RID: 41759 RVA: 0x00240FE8 File Offset: 0x0023F1E8
	protected override void OnBeforeShow()
	{
		if (this.CurrentSelectTabId == null)
		{
			int num = 0;
			object[] array = this.OpenParam as object[];
			if (array != null && array.Length != 0)
			{
				EActivityViewOpenType eactivityViewOpenType = (EActivityViewOpenType)array[0];
				if (array.Length > 1)
				{
					num = (int)array[1];
				}
			}
			int? num2 = null;
			List<int> list = new List<int>();
			foreach (IActivityCategoryTabData activityCategoryTabData in this.TabDataList)
			{
				if (!activityCategoryTabData.IsLineType)
				{
					foreach (ActivityBaseData activityBaseData in activityCategoryTabData.Activities)
					{
						list.Add(activityBaseData.Id);
						if (activityBaseData.Id == num)
						{
							num2 = activityCategoryTabData.Id;
						}
					}
				}
			}
			if (num2 == null && num == 0)
			{
				num2 = ActivityModel.Instance.GetDefaultOpenTabId(this.TabDataList);
			}
			int? num3 = num2;
			int? num4;
			if (num3 == null)
			{
				IActivityCategoryTabData[] tabDataList2 = this.TabDataList;
				if (tabDataList2 == null)
				{
					num4 = null;
				}
				else
				{
					IActivityCategoryTabData activityCategoryTabData2 = tabDataList2.FirstOrDefault<IActivityCategoryTabData>();
					num4 = ((activityCategoryTabData2 != null) ? activityCategoryTabData2.Id : null);
				}
			}
			else
			{
				num4 = num3;
			}
			num2 = num4;
			if (num2 == null)
			{
				return;
			}
			if (ActivityModel.Instance.GetDebugPermanentFilterVisible())
			{
				if (num2.GetValueOrDefault() != 999)
				{
					this.CurrentPermanentFilterId = ActivityModel.Instance.GetActivityPermanentFilterId();
				}
				this.InitPermanentFilter();
			}
			this.BindRedDotIds(list.ToArray());
			this.BtnRedDot.Item1 = base.GetButton(11).RootUIComp;
			this.BtnRedDot.Item2 = base.GetButton(12).RootUIComp;
			this.SelectActivityIdMap[(EActivityTimeType)num2.Value] = num;
			this.SelectTabType(num2.Value, true);
		}
		using (List<ActivityBaseData>.Enumerator enumerator = this.ActivityDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.CheckIfInShowTime())
				{
					ActivityController.Instance.RequestActivityData().ContinueWith(delegate(bool _)
					{
						this.OnActivityUpdate(null);
					});
					return;
				}
			}
		}
		this.RefreshRedDot(null);
		this.RefreshIndexRedDot();
		this.RefreshRecommendEntryRedDot();
		if (!this.IsViewFirstShow)
		{
			this.RefreshAllBubbleAndCheckTimer();
		}
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
		if (subViewTabLayout != null)
		{
			subViewTabLayout.BindScrollValueChange(new Action<FVector2D>(this.OnScrollUpdateRedDot));
		}
		ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
		if (currentShowingActivitySubView != null)
		{
			currentShowingActivitySubView.RefreshView();
		}
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("CommonActivityView");
		this.IsViewFirstShow = false;
	}

	// Token: 0x0600A320 RID: 41760 RVA: 0x0024129C File Offset: 0x0023F49C
	protected override UniTask OnBeforeHideAsync()
	{
		CommonActivityView.<OnBeforeHideAsync>d__42 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<CommonActivityView.<OnBeforeHideAsync>d__42>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A321 RID: 41761 RVA: 0x002412E0 File Offset: 0x0023F4E0
	protected override void OnBeforeDestroy()
	{
		ActivityController.Instance.DisableRefreshTimer();
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
		if (subViewTabLayout != null)
		{
			subViewTabLayout.UnBindScrollValueChange();
		}
		if (this.CategoryScrollView != null)
		{
			this.CategoryScrollView.ClearChildren();
			this.CategoryScrollView = null;
		}
		foreach (ActivityCaptionDecorationTagBase activityCaptionDecorationTagBase in this.CaptionDecorationTagCache.Values)
		{
			activityCaptionDecorationTagBase.Destroy(null);
		}
		this.CaptionDecorationTagCache.Clear();
	}

	// Token: 0x0600A322 RID: 41762 RVA: 0x00241378 File Offset: 0x0023F578
	protected override void OnAfterDestroy()
	{
		ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
		if (currentShowingActivitySubView != null)
		{
			currentShowingActivitySubView.Destroy(null);
		}
		if (this.ActivitySubViewCache != null)
		{
			this.ActivitySubViewCache.Enable = false;
			this.ActivitySubViewCache.Clear();
		}
	}

	// Token: 0x0600A323 RID: 41763 RVA: 0x002413AB File Offset: 0x0023F5AB
	private ActivitySubViewBase CreateActivitySubView(ActivityBaseData activityData)
	{
		return ActivityManager.GetActivityController(activityData.Type).CreateSubPageComponent(activityData);
	}

	// Token: 0x0600A324 RID: 41764 RVA: 0x002413BE File Offset: 0x0023F5BE
	private void OnEvictActivitySubView(ActivitySubViewBase uiItem)
	{
		if (uiItem.IsShowOrShowing)
		{
			uiItem.Hide(null);
		}
		uiItem.Destroy(null);
	}

	// Token: 0x0600A325 RID: 41765 RVA: 0x002413D6 File Offset: 0x0023F5D6
	private void OnClickTopRedDot()
	{
		if (this.ItemRedDot.Item1 != null)
		{
			GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
			if (subViewTabLayout == null)
			{
				return;
			}
			subViewTabLayout.ScrollTo(this.ItemRedDot.Item1, false);
		}
	}

	// Token: 0x0600A326 RID: 41766 RVA: 0x00241401 File Offset: 0x0023F601
	private void OnClickBottomRedDot()
	{
		if (this.ItemRedDot.Item2 != null)
		{
			GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
			if (subViewTabLayout == null)
			{
				return;
			}
			subViewTabLayout.ScrollTo(this.ItemRedDot.Item2, false);
		}
	}

	// Token: 0x0600A327 RID: 41767 RVA: 0x0024142C File Offset: 0x0023F62C
	private void OnClickBack()
	{
		this.UpdateListShowState(true, EActivityViewState.Side, null);
	}

	// Token: 0x0600A328 RID: 41768 RVA: 0x0024144A File Offset: 0x0023F64A
	private void OnClickActivityRecommend()
	{
		ActivityNewPlayerSupportActivityV2Controller.ReportEntranceClick(ENewPlayerSupportEntrance.ActivityRecommend);
		ActivityRecommendModel.Instance.MarkEntryFirstClickRead();
		ButtonItem recommendBtnItem = this.RecommendBtnItem;
		if (recommendBtnItem != null)
		{
			recommendBtnItem.SetRedDotVisible(false);
		}
		ActivityRecommendController.Instance.OpenView();
	}

	// Token: 0x0600A329 RID: 41769 RVA: 0x00241478 File Offset: 0x0023F678
	private void RefreshRecommendEntryRedDot()
	{
		bool redDotVisible = ActivityRecommendModel.Instance.IsEntryFirstClickRedDotShow();
		ButtonItem recommendBtnItem = this.RecommendBtnItem;
		if (recommendBtnItem == null)
		{
			return;
		}
		recommendBtnItem.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x0600A32A RID: 41770 RVA: 0x002414A1 File Offset: 0x0023F6A1
	private void OpenHelpView()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x0600A32B RID: 41771 RVA: 0x002414B3 File Offset: 0x0023F6B3
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A32C RID: 41772 RVA: 0x002414BC File Offset: 0x0023F6BC
	private void ToggleActivityTypeClick(IActivityCategoryTabData data, UUIExtendToggle toggle, EToggleState state)
	{
		int? id = data.Id;
		int? currentSelectTabId = this.CurrentSelectTabId;
		if (id.GetValueOrDefault() == currentSelectTabId.GetValueOrDefault() & id != null == (currentSelectTabId != null))
		{
			UUIExtendToggle currentCategoryToggle = this.CurrentCategoryToggle;
			if (currentCategoryToggle == null)
			{
				return;
			}
			currentCategoryToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		else
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (!string.IsNullOrEmpty(data.TextId))
			{
				PopupCaptionItem captionItem = this.CaptionItem;
				if (captionItem != null)
				{
					captionItem.SetTitleLocalText(data.TextId);
				}
			}
			UUIExtendToggle currentCategoryToggle2 = this.CurrentCategoryToggle;
			if (currentCategoryToggle2 != null)
			{
				currentCategoryToggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentCategoryToggle = toggle;
			this.SetActivityTabId(data.Id.Value, true);
			return;
		}
	}

	// Token: 0x0600A32D RID: 41773 RVA: 0x0024156C File Offset: 0x0023F76C
	private void SetActivityTabId(int tabId, bool manual = true)
	{
		this.CurrentSelectTabId = new int?(tabId);
		if (ActivityModel.Instance.GetDebugPermanentFilterVisible())
		{
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(tabId == 999);
			}
		}
		else
		{
			UUIItem item2 = base.GetItem(13);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		base.GetItem(8).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
		UUIItem item3 = this.BtnRedDot.Item1;
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = this.BtnRedDot.Item2;
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		this.IsInRefreshTabItem = true;
		TTimerAction <>9__1;
		this.RefreshTabPageItem(tabId, false).ContinueWith(delegate()
		{
			string sequenceName = manual ? "SwitchModel" : "SwitchList";
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName(sequenceName, true, null, false);
			}
			this.GetItem(8).SetUIActive(true);
			this.GetItem(9).SetUIActive(true);
			this.RefreshIndexRedDot();
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					this.IsInRefreshTabItem = false;
					this.RefreshIndexRedDot();
					this.OnScrollUpdateRedDot(default(FVector2D));
				});
			}
			gameplayTimeInstance.Delay(action, 100f, null, null, true, 1f);
		});
	}

	// Token: 0x0600A32E RID: 41774 RVA: 0x00241640 File Offset: 0x0023F840
	private void SelectTabType(int tabId, bool bFireEvent)
	{
		IActivityCategoryTabData[] tabDataList = this.TabDataList;
		int? num = (tabDataList != null) ? new int?(tabDataList.ToList<IActivityCategoryTabData>().FindIndex(delegate(IActivityCategoryTabData x)
		{
			int? id = x.Id;
			int tabId2 = tabId;
			return id.GetValueOrDefault() == tabId2 & id != null;
		})) : null;
		if (num == null || num.GetValueOrDefault() == -1)
		{
			return;
		}
		DynamicScrollView<ActivitySwitchToggle, ActivitySwitchToggleDynamicItem, IActivityCategoryTabData> categoryScrollView = this.CategoryScrollView;
		ActivitySwitchToggle activitySwitchToggle = (categoryScrollView != null) ? categoryScrollView.GetScrollItemFromIndex(num.Value) : null;
		if (activitySwitchToggle == null)
		{
			return;
		}
		activitySwitchToggle.OnSelected(bFireEvent);
	}

	// Token: 0x0600A32F RID: 41775 RVA: 0x002416C4 File Offset: 0x0023F8C4
	private ActivityPageSelectContent InitTabItem()
	{
		ActivityPageSelectContent activityPageSelectContent = new ActivityPageSelectContent();
		activityPageSelectContent.BindCanToggleExecuteChange(new Func<int, bool, bool>(this.CanToggleExecuteChange));
		activityPageSelectContent.BindToggleClick(new Action<ActivityBaseData, bool>(this.ToggleClick));
		return activityPageSelectContent;
	}

	// Token: 0x0600A330 RID: 41776 RVA: 0x002416EF File Offset: 0x0023F8EF
	private bool CanToggleExecuteChange(int id, bool toggleState)
	{
		return true;
	}

	// Token: 0x0600A331 RID: 41777 RVA: 0x002416F2 File Offset: 0x0023F8F2
	private void ToggleClick(ActivityBaseData data, bool toggleState)
	{
		if (toggleState)
		{
			this.SelectOnActivity(data, true);
		}
	}

	// Token: 0x0600A332 RID: 41778 RVA: 0x00241700 File Offset: 0x0023F900
	private UniTask SelectOnActivity(ActivityBaseData data, bool playSwitchAnim)
	{
		CommonActivityView.<SelectOnActivity>d__60 <SelectOnActivity>d__;
		<SelectOnActivity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectOnActivity>d__.<>4__this = this;
		<SelectOnActivity>d__.data = data;
		<SelectOnActivity>d__.playSwitchAnim = playSwitchAnim;
		<SelectOnActivity>d__.<>1__state = -1;
		<SelectOnActivity>d__.<>t__builder.Start<CommonActivityView.<SelectOnActivity>d__60>(ref <SelectOnActivity>d__);
		return <SelectOnActivity>d__.<>t__builder.Task;
	}

	// Token: 0x0600A333 RID: 41779 RVA: 0x00241753 File Offset: 0x0023F953
	private void BindToggleRedDot()
	{
	}

	// Token: 0x0600A334 RID: 41780 RVA: 0x00241755 File Offset: 0x0023F955
	private void UnBindToggleRedDot()
	{
	}

	// Token: 0x0600A335 RID: 41781 RVA: 0x00241757 File Offset: 0x0023F957
	private void OnActivityRedDotUpdate(int activityId)
	{
		this.RefreshRedDot(new int?(activityId));
		this.RefreshIndexRedDot();
		this.RefreshBubbleAndCheckTimer(activityId);
	}

	// Token: 0x0600A336 RID: 41782 RVA: 0x00241774 File Offset: 0x0023F974
	public void BindRedDotIds(int[] redDotIds)
	{
		foreach (int value in redDotIds)
		{
			this.RefreshRedDot(new int?(value));
		}
	}

	// Token: 0x0600A337 RID: 41783 RVA: 0x002417A4 File Offset: 0x0023F9A4
	private void RefreshRedDot(int? activityId = null)
	{
		if (activityId != null)
		{
			bool activityRedDotState = ActivityModel.Instance.GetActivityRedDotState(activityId.Value);
			this.RedDotStateMap[activityId.Value] = activityRedDotState;
			return;
		}
		foreach (ActivityBaseData activityBaseData in this.ActivityDataList)
		{
			bool activityRedDotState2 = ActivityModel.Instance.GetActivityRedDotState(activityBaseData.Id);
			this.RedDotStateMap[activityBaseData.Id] = activityRedDotState2;
		}
	}

	// Token: 0x0600A338 RID: 41784 RVA: 0x00241844 File Offset: 0x0023FA44
	private void RefreshIndexRedDot()
	{
		if (this.IsInRefreshTabItem || this.IsHideTabSidebar)
		{
			this.ItemRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);
			return;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < this.ActivityDataList.Count; i++)
		{
			int id = this.ActivityDataList[i].Id;
			bool flag;
			if (this.RedDotStateMap.TryGetValue(id, out flag) && flag)
			{
				list.Add(i);
			}
		}
		if (list.Count <= 0)
		{
			this.ItemRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);
			return;
		}
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
		UUIItem item = (subViewTabLayout != null) ? subViewTabLayout.GetItemByIndex(list[0]) : null;
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout2 = this.SubViewTabLayout;
		this.ItemRedDot = new ValueTuple<UUIItem, UUIItem>(item, (subViewTabLayout2 != null) ? subViewTabLayout2.GetItemByIndex(list[list.Count - 1]) : null);
	}

	// Token: 0x0600A339 RID: 41785 RVA: 0x00241914 File Offset: 0x0023FB14
	private void RefreshBubbleAndCheckTimer(int activityId)
	{
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
		ActivityPageSelectContent activityPageSelectContent;
		if (subViewTabLayout == null)
		{
			activityPageSelectContent = null;
		}
		else
		{
			GenericLayout<ActivityPageSelectContent, ActivityBaseData> genericLayout = subViewTabLayout.GetGenericLayout();
			activityPageSelectContent = ((genericLayout != null) ? genericLayout.GetLayoutItemByKey(activityId) : null);
		}
		ActivityPageSelectContent activityPageSelectContent2 = activityPageSelectContent;
		if (activityPageSelectContent2 == null)
		{
			return;
		}
		activityPageSelectContent2.RefreshBubbleAndCheckTimer();
	}

	// Token: 0x0600A33A RID: 41786 RVA: 0x00241950 File Offset: 0x0023FB50
	private void RefreshAllBubbleAndCheckTimer()
	{
		GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> subViewTabLayout = this.SubViewTabLayout;
		List<ActivityPageSelectContent> list;
		if (subViewTabLayout == null)
		{
			list = null;
		}
		else
		{
			GenericLayout<ActivityPageSelectContent, ActivityBaseData> genericLayout = subViewTabLayout.GetGenericLayout();
			list = ((genericLayout != null) ? genericLayout.GetLayoutItemList() : null);
		}
		List<ActivityPageSelectContent> list2 = list;
		if (list2 == null)
		{
			return;
		}
		foreach (ActivityPageSelectContent activityPageSelectContent in list2)
		{
			activityPageSelectContent.RefreshBubbleAndCheckTimer();
		}
	}

	// Token: 0x0600A33B RID: 41787 RVA: 0x002419C0 File Offset: 0x0023FBC0
	private void OnScrollUpdateRedDot(FVector2D _)
	{
		ValueTuple<UUIItem, UUIItem> itemRedDot = this.ItemRedDot;
		if (itemRedDot.Item1 != null && itemRedDot.Item2 != null)
		{
			EOutOfBoundsType eoutOfBoundsType = this.SubViewTabLayout.IsItemInViewport(itemRedDot.Item1, 0.1f);
			EOutOfBoundsType eoutOfBoundsType2 = this.SubViewTabLayout.IsItemInViewport(itemRedDot.Item2, 0.1f);
			this.BtnRedDot.Item1.SetUIActive(eoutOfBoundsType == EOutOfBoundsType.OutOfBegin);
			this.BtnRedDot.Item2.SetUIActive(eoutOfBoundsType2 == EOutOfBoundsType.OutOfEnd);
			return;
		}
		UUIItem item = this.BtnRedDot.Item1;
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = this.BtnRedDot.Item2;
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600A33C RID: 41788 RVA: 0x00241A68 File Offset: 0x0023FC68
	private void OnSetActivityViewCurrency(IReadOnlyList<int> itemConfigList)
	{
		if (itemConfigList.Count <= 0)
		{
			return;
		}
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCurrencyItemVisible(true);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 == null)
		{
			return;
		}
		captionItem2.SetCurrencyItemList(itemConfigList.ToArray<int>()).Forget();
	}

	// Token: 0x0600A33D RID: 41789 RVA: 0x00241AA1 File Offset: 0x0023FCA1
	public UUIItem GetCaptionItemToggleRootItem()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return null;
		}
		return captionItem.GetToggleRootItem();
	}

	// Token: 0x0600A33E RID: 41790 RVA: 0x00241AB4 File Offset: 0x0023FCB4
	[NullableContext(2)]
	public UUIItem GetCaptionItemTitleIconRootItem()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return null;
		}
		return captionItem.GetTitleIconRootItem();
	}

	// Token: 0x0600A33F RID: 41791 RVA: 0x00241AC7 File Offset: 0x0023FCC7
	private void OnChangeActivityViewNeedBlurState(bool state)
	{
		UiBehaviourUiBlur uiBlurBehaviour = this.UiBlurBehaviour;
		if (uiBlurBehaviour == null)
		{
			return;
		}
		uiBlurBehaviour.ChangeNeedBlurState(state);
	}

	// Token: 0x0600A340 RID: 41792 RVA: 0x00241ADC File Offset: 0x0023FCDC
	private UniTask RefreshTabPageItem(int tabId, bool playSwitchAnim)
	{
		CommonActivityView.<RefreshTabPageItem>d__74 <RefreshTabPageItem>d__;
		<RefreshTabPageItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabPageItem>d__.<>4__this = this;
		<RefreshTabPageItem>d__.tabId = tabId;
		<RefreshTabPageItem>d__.playSwitchAnim = playSwitchAnim;
		<RefreshTabPageItem>d__.<>1__state = -1;
		<RefreshTabPageItem>d__.<>t__builder.Start<CommonActivityView.<RefreshTabPageItem>d__74>(ref <RefreshTabPageItem>d__);
		return <RefreshTabPageItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A341 RID: 41793 RVA: 0x00241B30 File Offset: 0x0023FD30
	private void ActivityViewChange(int activityId)
	{
		if (activityId <= 0)
		{
			return;
		}
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId);
		if (activityById == null)
		{
			return;
		}
		if (!activityById.CheckIfInShowTime())
		{
			return;
		}
		int? num = null;
		if (activityById.TimeType == EActivityTimeType.TimeLimit)
		{
			num = new int?(activityById.LocalConfig.Value.FilterTabType);
		}
		else
		{
			num = new int?(999);
		}
		this.SelectActivityIdMap[(EActivityTimeType)num.Value] = activityById.Id;
		int? num2 = num;
		int? currentSelectTabId = this.CurrentSelectTabId;
		if (!(num2.GetValueOrDefault() == currentSelectTabId.GetValueOrDefault() & num2 != null == (currentSelectTabId != null)))
		{
			this.SelectTabType(num.Value, true);
			return;
		}
		this.RefreshTabPageItem(this.CurrentSelectTabId.Value, true);
	}

	// Token: 0x0600A342 RID: 41794 RVA: 0x00241BFA File Offset: 0x0023FDFA
	private void OnActivityViewRefresh(int activityId)
	{
		if (this.CurrentSelectActivityId != activityId)
		{
			return;
		}
		ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
		if (currentShowingActivitySubView == null)
		{
			return;
		}
		currentShowingActivitySubView.RefreshView();
	}

	// Token: 0x0600A343 RID: 41795 RVA: 0x00241C18 File Offset: 0x0023FE18
	private UniTask RefreshActivityContent(bool playSwitchAnim)
	{
		CommonActivityView.<RefreshActivityContent>d__77 <RefreshActivityContent>d__;
		<RefreshActivityContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshActivityContent>d__.<>4__this = this;
		<RefreshActivityContent>d__.playSwitchAnim = playSwitchAnim;
		<RefreshActivityContent>d__.<>1__state = -1;
		<RefreshActivityContent>d__.<>t__builder.Start<CommonActivityView.<RefreshActivityContent>d__77>(ref <RefreshActivityContent>d__);
		return <RefreshActivityContent>d__.<>t__builder.Task;
	}

	// Token: 0x0600A344 RID: 41796 RVA: 0x00241C64 File Offset: 0x0023FE64
	private void RefreshMainView(ActivityBaseData activityData)
	{
		this.HelpId = activityData.GetHelpId();
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetHelpBtnActive(this.HelpId != 0);
		}
		ActivityTipsButton tipsButton = this.TipsButton;
		if (tipsButton != null)
		{
			tipsButton.SetActive(activityData.LocalConfig.Value.ShowPermanentTips);
		}
		bool hideTabSidebar = activityData.LocalConfig.Value.HideTabSidebar;
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(!hideTabSidebar);
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(!hideTabSidebar);
		}
		this.IsHideTabSidebar = hideTabSidebar;
		this.RefreshTabIcon();
	}

	// Token: 0x0600A345 RID: 41797 RVA: 0x00241D10 File Offset: 0x0023FF10
	private UniTask RefreshCaptionDecorationTag(int activityId)
	{
		CommonActivityView.<RefreshCaptionDecorationTag>d__79 <RefreshCaptionDecorationTag>d__;
		<RefreshCaptionDecorationTag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCaptionDecorationTag>d__.<>4__this = this;
		<RefreshCaptionDecorationTag>d__.activityId = activityId;
		<RefreshCaptionDecorationTag>d__.<>1__state = -1;
		<RefreshCaptionDecorationTag>d__.<>t__builder.Start<CommonActivityView.<RefreshCaptionDecorationTag>d__79>(ref <RefreshCaptionDecorationTag>d__);
		return <RefreshCaptionDecorationTag>d__.<>t__builder.Task;
	}

	// Token: 0x0600A346 RID: 41798 RVA: 0x00241D5C File Offset: 0x0023FF5C
	private UniTask RefreshBg(ActivityBaseData activityData)
	{
		CommonActivityView.<RefreshBg>d__80 <RefreshBg>d__;
		<RefreshBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBg>d__.<>4__this = this;
		<RefreshBg>d__.activityData = activityData;
		<RefreshBg>d__.<>1__state = -1;
		<RefreshBg>d__.<>t__builder.Start<CommonActivityView.<RefreshBg>d__80>(ref <RefreshBg>d__);
		return <RefreshBg>d__.<>t__builder.Task;
	}

	// Token: 0x0600A347 RID: 41799 RVA: 0x00241DA8 File Offset: 0x0023FFA8
	private UniTask RefreshSubView(ActivityBaseData activityData, bool playSwitchAnim)
	{
		CommonActivityView.<RefreshSubView>d__81 <RefreshSubView>d__;
		<RefreshSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubView>d__.<>4__this = this;
		<RefreshSubView>d__.activityData = activityData;
		<RefreshSubView>d__.playSwitchAnim = playSwitchAnim;
		<RefreshSubView>d__.<>1__state = -1;
		<RefreshSubView>d__.<>t__builder.Start<CommonActivityView.<RefreshSubView>d__81>(ref <RefreshSubView>d__);
		return <RefreshSubView>d__.<>t__builder.Task;
	}

	// Token: 0x0600A348 RID: 41800 RVA: 0x00241DFC File Offset: 0x0023FFFC
	public void OnActivityUpdate(IReadOnlySet<int> _ = null)
	{
		Action value = delegate()
		{
			UiManager.Instance.ResetToBattleView(null);
		};
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
		confirmBoxDataNew.FunctionMap[1] = value;
		confirmBoxDataNew.FunctionMap[0] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A349 RID: 41801 RVA: 0x00241E57 File Offset: 0x00240057
	private void OnPlaySequenceEventByStringParam(string name)
	{
		ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
		if (currentShowingActivitySubView == null)
		{
			return;
		}
		currentShowingActivitySubView.PlaySubViewSequence(name, false);
	}

	// Token: 0x0600A34A RID: 41802 RVA: 0x00241E6C File Offset: 0x0024006C
	private void UpdateListShowState(bool show, EActivityViewState state = EActivityViewState.Side, bool? blockClick = null)
	{
		this.ViewSaveStateSequence = ActivityViewStateSequence.Value[state].ToList<string>();
		if (show != this.ListShowInternal)
		{
			this.ListShowInternal = show;
			this.UiViewSequence.PlaySequence(show ? this.ViewSaveStateSequence[0] : this.ViewSaveStateSequence[1], blockClick.GetValueOrDefault(), null);
			ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
			if (currentShowingActivitySubView != null)
			{
				currentShowingActivitySubView.OnCommonViewStateChange(show);
			}
		}
		this.RefreshTabIcon();
	}

	// Token: 0x0600A34B RID: 41803 RVA: 0x00241EF0 File Offset: 0x002400F0
	public void RefreshTabIcon()
	{
		Activity? localConfig = ActivityModel.Instance.GetActivityById(this.CurrentSelectActivityId).LocalConfig;
		string text = this.ListShowInternal ? localConfig.Value.TabResource : localConfig.Value.TabResource2;
		if (!string.IsNullOrEmpty(text))
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleIcon(text);
		}
	}

	// Token: 0x0600A34C RID: 41804 RVA: 0x00241F58 File Offset: 0x00240158
	private void SetDebugText()
	{
		UUIText text = base.GetText(10);
		if (!GlobalData.IsPlayInEditor)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
	}

	// Token: 0x0600A34D RID: 41805 RVA: 0x00241F84 File Offset: 0x00240184
	private void RefreshDebugText(int activityId, ActivityType activityType)
	{
		UUIText text = base.GetText(10);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
		defaultInterpolatedStringHandler.AppendLiteral("DebugId: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(activityId);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)activityType);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<ActivityType>(activityType);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600A34E RID: 41806 RVA: 0x00241FEC File Offset: 0x002401EC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "BackToBattleViewBtn")
		{
			UActorComponent componentInChildren = ULGUIBPLibrary.GetComponentInChildren(base.GetRootActor(), TsUiHomeHelper.StaticClass(), false);
			AActor aactor = (componentInChildren != null) ? componentInChildren.GetOwner() : null;
			if (aactor == null)
			{
				return null;
			}
			UUIButtonComponent uuibuttonComponent = ULGUIBPLibrary.GetComponentInChildren(aactor, UUIButtonComponent.StaticClass(), false) as UUIButtonComponent;
			UUIItem uuiitem = (uuibuttonComponent != null) ? uuibuttonComponent.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else if (a == "FirstRecommendActivityTog")
		{
			UUIItem uuiitem2 = null;
			for (int i = 0; i < this.ActivityDataList.Count; i++)
			{
				ActivityBaseData activityBaseData = this.ActivityDataList[i];
				if (activityBaseData.LocalConfig != null && activityBaseData.LocalConfig.GetValueOrDefault().IsTabEffectNotice)
				{
					uuiitem2 = this.SubViewTabLayout.GetItemByIndex(i);
					this.SubViewTabLayout.ScrollTo(uuiitem2, false);
					break;
				}
			}
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
		else
		{
			if (this.CurrentShowingActivitySubView == null)
			{
				return null;
			}
			return this.CurrentShowingActivitySubView.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
	}

	// Token: 0x0600A34F RID: 41807 RVA: 0x0024210D File Offset: 0x0024030D
	public bool IsPermanentTab(int tabId)
	{
		return tabId == 999;
	}

	// Token: 0x0600A350 RID: 41808 RVA: 0x00242118 File Offset: 0x00240318
	public List<ActivityBaseData> FilterActivitiesByTabId(List<ActivityBaseData> activities, int tabId)
	{
		bool isPermanentTab = this.IsPermanentTab(tabId);
		return activities.Where(delegate(ActivityBaseData act)
		{
			if (isPermanentTab)
			{
				return act.TimeType == EActivityTimeType.Permanent;
			}
			return act.TimeType == EActivityTimeType.TimeLimit && act.LocalConfig != null && act.LocalConfig.GetValueOrDefault().FilterTabType == tabId;
		}).ToList<ActivityBaseData>();
	}

	// Token: 0x0600A351 RID: 41809 RVA: 0x0024215C File Offset: 0x0024035C
	private void OnFilterDropDownSelect(int index, ActivityPermanentFilter data)
	{
		this.CurrentPermanentFilterId = data.Id;
		if (!this.IsPermanentTab(this.CurrentSelectTabId.Value))
		{
			return;
		}
		this.SetActivityTabId(this.CurrentSelectTabId.Value, false);
		ActivityModel.Instance.SetActivityPermanentFilterId(this.CurrentPermanentFilterId);
	}

	// Token: 0x0600A352 RID: 41810 RVA: 0x002421AC File Offset: 0x002403AC
	private void InitPermanentFilter()
	{
		IReadOnlyList<ActivityPermanentFilter> allActivityPermanentFilter = ActivityConfig.Instance.GetAllActivityPermanentFilter();
		if (allActivityPermanentFilter == null)
		{
			return;
		}
		IActivityCategoryTabData[] tabDataList = this.TabDataList;
		IActivityCategoryTabData activityCategoryTabData;
		if (tabDataList == null)
		{
			activityCategoryTabData = null;
		}
		else
		{
			activityCategoryTabData = tabDataList.FirstOrDefault((IActivityCategoryTabData x) => x.Id.GetValueOrDefault() == 999);
		}
		IActivityCategoryTabData activityCategoryTabData2 = activityCategoryTabData;
		List<ActivityPermanentFilter> list = new List<ActivityPermanentFilter>();
		list.Add(allActivityPermanentFilter.First((ActivityPermanentFilter cfg) => cfg.Id == 999));
		if (activityCategoryTabData2 != null)
		{
			List<ActivityBaseData> activities = activityCategoryTabData2.Activities;
			IEnumerable<int> enumerable;
			if (activities == null)
			{
				enumerable = null;
			}
			else
			{
				enumerable = from act in activities
				select act.LocalConfig.Value.PermanentFilterType;
			}
			HashSet<int> hashSet = new HashSet<int>(enumerable ?? Enumerable.Empty<int>());
			foreach (ActivityPermanentFilter item in allActivityPermanentFilter)
			{
				if (item.Id != 999 && hashSet.Contains(item.Id))
				{
					list.Add(item);
				}
			}
		}
		int num = list.FindIndex((ActivityPermanentFilter x) => x.Id == this.CurrentPermanentFilterId);
		if (num == -1)
		{
			num = 0;
		}
		this.FilterDropDown.InitScroll(list, delegate(ActivityPermanentFilter tabCfg)
		{
			ActivityPermanentFilter activityPermanentFilter = tabCfg;
			return new TableTextArgNew(activityPermanentFilter.FilterName, Array.Empty<object>());
		}, num, true);
	}

	// Token: 0x04004A20 RID: 18976
	private bool IsViewFirstShow = true;

	// Token: 0x04004A21 RID: 18977
	private bool ListShowInternal = true;

	// Token: 0x04004A22 RID: 18978
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004A23 RID: 18979
	private int HelpId;

	// Token: 0x04004A24 RID: 18980
	[Nullable(2)]
	private object SubViewOpenParam;

	// Token: 0x04004A25 RID: 18981
	[Nullable(2)]
	private ActivityTipsButton TipsButton;

	// Token: 0x04004A26 RID: 18982
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> SubViewTabLayout;

	// Token: 0x04004A27 RID: 18983
	private int? CurrentSelectTabId;

	// Token: 0x04004A28 RID: 18984
	private readonly Dictionary<EActivityTimeType, int> SelectActivityIdMap = new Dictionary<EActivityTimeType, int>();

	// Token: 0x04004A29 RID: 18985
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ActivitySwitchToggle, ActivitySwitchToggleDynamicItem, IActivityCategoryTabData> CategoryScrollView;

	// Token: 0x04004A2A RID: 18986
	[Nullable(2)]
	private UUIExtendToggle CurrentCategoryToggle;

	// Token: 0x04004A2B RID: 18987
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IActivityCategoryTabData[] TabDataList;

	// Token: 0x04004A2C RID: 18988
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, ActivityPermanentFilter> FilterDropDown;

	// Token: 0x04004A2D RID: 18989
	private int CurrentPermanentFilterId = 999;

	// Token: 0x04004A2E RID: 18990
	private bool IsInRefreshTabItem;

	// Token: 0x04004A2F RID: 18991
	private bool IsHideTabSidebar;

	// Token: 0x04004A30 RID: 18992
	private ECaptionDecorationFunc CurrentCaptionDecorationFunc;

	// Token: 0x04004A31 RID: 18993
	private readonly Dictionary<ECaptionDecorationFunc, ActivityCaptionDecorationTagBase> CaptionDecorationTagCache = new Dictionary<ECaptionDecorationFunc, ActivityCaptionDecorationTagBase>();

	// Token: 0x04004A32 RID: 18994
	[Nullable(2)]
	private ActivitySubViewBase CurrentShowingActivitySubView;

	// Token: 0x04004A33 RID: 18995
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Lru<ActivityBaseData, ActivitySubViewBase> ActivitySubViewCache;

	// Token: 0x04004A34 RID: 18996
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004A35 RID: 18997
	private List<ActivityBaseData> ActivityDataList = new List<ActivityBaseData>();

	// Token: 0x04004A36 RID: 18998
	private readonly Dictionary<int, bool> RedDotStateMap = new Dictionary<int, bool>();

	// Token: 0x04004A37 RID: 18999
	private List<string> ViewSaveStateSequence = new List<string>();

	// Token: 0x04004A38 RID: 19000
	[Nullable(new byte[]
	{
		0,
		2,
		2
	})]
	private ValueTuple<UUIItem, UUIItem> ItemRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);

	// Token: 0x04004A39 RID: 19001
	[Nullable(new byte[]
	{
		0,
		2,
		2
	})]
	private ValueTuple<UUIItem, UUIItem> BtnRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);

	// Token: 0x04004A3A RID: 19002
	[Nullable(2)]
	private ButtonItem RecommendBtnItem;

	// Token: 0x02007C42 RID: 31810
	[NullableContext(0)]
	private class EActivityComponents
	{
		// Token: 0x04028C5B RID: 167003
		public const int CaptionItem = 0;

		// Token: 0x04028C5C RID: 167004
		public const int TabScrollView = 1;

		// Token: 0x04028C5D RID: 167005
		public const int TabToggle = 2;

		// Token: 0x04028C5E RID: 167006
		public const int SubView = 3;

		// Token: 0x04028C5F RID: 167007
		public const int Panel = 4;

		// Token: 0x04028C60 RID: 167008
		public const int BgTexture = 5;

		// Token: 0x04028C61 RID: 167009
		public const int BtnBack = 6;

		// Token: 0x04028C62 RID: 167010
		public const int PanelTips = 7;

		// Token: 0x04028C63 RID: 167011
		public const int Content = 8;

		// Token: 0x04028C64 RID: 167012
		public const int TabLine = 9;

		// Token: 0x04028C65 RID: 167013
		public const int TxtDebugId = 10;

		// Token: 0x04028C66 RID: 167014
		public const int BtnTopRedDot = 11;

		// Token: 0x04028C67 RID: 167015
		public const int BtnBottomRedDot = 12;

		// Token: 0x04028C68 RID: 167016
		public const int PanelTop = 13;

		// Token: 0x04028C69 RID: 167017
		public const int DropdownA = 14;

		// Token: 0x04028C6A RID: 167018
		public const int DynamicTab = 15;

		// Token: 0x04028C6B RID: 167019
		public const int PanelTab = 16;

		// Token: 0x04028C6C RID: 167020
		public const int PanelSafe = 17;

		// Token: 0x04028C6D RID: 167021
		public const int BtnActivityRecommend = 18;
	}
}
