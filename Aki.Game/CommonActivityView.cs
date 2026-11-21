using System;
using System.Collections.Generic;
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

// Token: 0x02000B3D RID: 2877
[NullableContext(1)]
[Nullable(0)]
public class CommonActivityView : UiViewBase
{
	// Token: 0x060076F1 RID: 30449 RVA: 0x0024A564 File Offset: 0x00248764
	public CommonActivityView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000DEB RID: 3563
	// (get) Token: 0x060076F2 RID: 30450 RVA: 0x0024A5E4 File Offset: 0x002487E4
	private int CurrentSelectActivityId
	{
		get
		{
			int? currentSelectTabId = this.CurrentSelectTabId;
			int? num;
			if (currentSelectTabId == null)
			{
				IActivityCategoryTabData[] tabDataList = this.TabDataList;
				num = ((tabDataList != null && tabDataList.Length > 0) ? tabDataList[0].Id : null);
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

	// Token: 0x060076F3 RID: 30451 RVA: 0x0024A650 File Offset: 0x00248850
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

	// Token: 0x060076F4 RID: 30452 RVA: 0x0024A97C File Offset: 0x00248B7C
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

	// Token: 0x060076F5 RID: 30453 RVA: 0x0024AAC4 File Offset: 0x00248CC4
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

	// Token: 0x060076F6 RID: 30454 RVA: 0x0024AC0C File Offset: 0x00248E0C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonActivityView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonActivityView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076F7 RID: 30455 RVA: 0x0024AC50 File Offset: 0x00248E50
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

	// Token: 0x060076F8 RID: 30456 RVA: 0x0024AD8C File Offset: 0x00248F8C
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
		List<int> list2 = new List<int>(list.Count);
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(list[i].Item1);
		}
		return list2;
	}

	// Token: 0x060076F9 RID: 30457 RVA: 0x0024AE58 File Offset: 0x00249058
	private ActivitySwitchToggle OnCreateCategoryItemView(IActivityCategoryTabData data, UUIItem uiItem, int index)
	{
		ActivitySwitchToggle activitySwitchToggle = new ActivitySwitchToggle();
		activitySwitchToggle.InitData(data);
		activitySwitchToggle.SetOnToggleClicked(new TOnToggleClickCb(this.ToggleActivityTypeClick));
		return activitySwitchToggle;
	}

	// Token: 0x060076FA RID: 30458 RVA: 0x0024AE78 File Offset: 0x00249078
	private void CreateLeftScrollView()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.SubViewTabLayout = new GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData>(scrollViewWithScrollbar, new Func<ActivityPageSelectContent>(this.InitTabItem), null, false, null);
	}

	// Token: 0x060076FB RID: 30459 RVA: 0x0024AEA8 File Offset: 0x002490A8
	private UniTask CreateViewSubComponents()
	{
		CommonActivityView.<CreateViewSubComponents>d__39 <CreateViewSubComponents>d__;
		<CreateViewSubComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateViewSubComponents>d__.<>4__this = this;
		<CreateViewSubComponents>d__.<>1__state = -1;
		<CreateViewSubComponents>d__.<>t__builder.Start<CommonActivityView.<CreateViewSubComponents>d__39>(ref <CreateViewSubComponents>d__);
		return <CreateViewSubComponents>d__.<>t__builder.Task;
	}

	// Token: 0x060076FC RID: 30460 RVA: 0x0024AEEC File Offset: 0x002490EC
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
		this.ViewSaveStateSequence = new List<string>(ActivityViewStateSequence.Value[EActivityViewState.Side]);
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetTitleLocalText("Activity_Title");
		}
		this.SetDebugText();
		this.InitTabDataList();
	}

	// Token: 0x060076FD RID: 30461 RVA: 0x0024AF78 File Offset: 0x00249178
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
				num4 = ((tabDataList2 != null && tabDataList2.Length > 0) ? tabDataList2[0].Id : null);
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

	// Token: 0x060076FE RID: 30462 RVA: 0x0024B224 File Offset: 0x00249424
	protected override UniTask OnBeforeHideAsync()
	{
		CommonActivityView.<OnBeforeHideAsync>d__42 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<CommonActivityView.<OnBeforeHideAsync>d__42>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076FF RID: 30463 RVA: 0x0024B268 File Offset: 0x00249468
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

	// Token: 0x06007700 RID: 30464 RVA: 0x0024B300 File Offset: 0x00249500
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

	// Token: 0x06007701 RID: 30465 RVA: 0x0024B333 File Offset: 0x00249533
	private ActivitySubViewBase CreateActivitySubView(ActivityBaseData activityData)
	{
		return ActivityManager.GetActivityController(activityData.Type).CreateSubPageComponent(activityData);
	}

	// Token: 0x06007702 RID: 30466 RVA: 0x0024B346 File Offset: 0x00249546
	private void OnEvictActivitySubView(ActivitySubViewBase uiItem)
	{
		if (uiItem.IsShowOrShowing)
		{
			uiItem.Hide(null);
		}
		uiItem.Destroy(null);
	}

	// Token: 0x06007703 RID: 30467 RVA: 0x0024B35E File Offset: 0x0024955E
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

	// Token: 0x06007704 RID: 30468 RVA: 0x0024B389 File Offset: 0x00249589
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

	// Token: 0x06007705 RID: 30469 RVA: 0x0024B3B4 File Offset: 0x002495B4
	private void OnClickBack()
	{
		this.UpdateListShowState(true, EActivityViewState.Side, null);
	}

	// Token: 0x06007706 RID: 30470 RVA: 0x0024B3D2 File Offset: 0x002495D2
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

	// Token: 0x06007707 RID: 30471 RVA: 0x0024B400 File Offset: 0x00249600
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

	// Token: 0x06007708 RID: 30472 RVA: 0x0024B429 File Offset: 0x00249629
	private void OpenHelpView()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x06007709 RID: 30473 RVA: 0x0024B43B File Offset: 0x0024963B
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600770A RID: 30474 RVA: 0x0024B444 File Offset: 0x00249644
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

	// Token: 0x0600770B RID: 30475 RVA: 0x0024B4F4 File Offset: 0x002496F4
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

	// Token: 0x0600770C RID: 30476 RVA: 0x0024B5C8 File Offset: 0x002497C8
	private void SelectTabType(int tabId, bool bFireEvent)
	{
		int? num = null;
		if (this.TabDataList != null)
		{
			for (int i = 0; i < this.TabDataList.Length; i++)
			{
				int? id = this.TabDataList[i].Id;
				if (id.GetValueOrDefault() == tabId & id != null)
				{
					num = new int?(i);
					break;
				}
			}
		}
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

	// Token: 0x0600770D RID: 30477 RVA: 0x0024B661 File Offset: 0x00249861
	private ActivityPageSelectContent InitTabItem()
	{
		ActivityPageSelectContent activityPageSelectContent = new ActivityPageSelectContent();
		activityPageSelectContent.BindCanToggleExecuteChange(new Func<int, bool, bool>(this.CanToggleExecuteChange));
		activityPageSelectContent.BindToggleClick(new Action<ActivityBaseData, bool>(this.ToggleClick));
		return activityPageSelectContent;
	}

	// Token: 0x0600770E RID: 30478 RVA: 0x0024B68C File Offset: 0x0024988C
	private bool CanToggleExecuteChange(int id, bool toggleState)
	{
		return true;
	}

	// Token: 0x0600770F RID: 30479 RVA: 0x0024B68F File Offset: 0x0024988F
	private void ToggleClick(ActivityBaseData data, bool toggleState)
	{
		if (toggleState)
		{
			this.SelectOnActivity(data, true);
		}
	}

	// Token: 0x06007710 RID: 30480 RVA: 0x0024B6A0 File Offset: 0x002498A0
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

	// Token: 0x06007711 RID: 30481 RVA: 0x0024B6F3 File Offset: 0x002498F3
	private void BindToggleRedDot()
	{
	}

	// Token: 0x06007712 RID: 30482 RVA: 0x0024B6F5 File Offset: 0x002498F5
	private void UnBindToggleRedDot()
	{
	}

	// Token: 0x06007713 RID: 30483 RVA: 0x0024B6F7 File Offset: 0x002498F7
	private void OnActivityRedDotUpdate(int activityId)
	{
		this.RefreshRedDot(new int?(activityId));
		this.RefreshIndexRedDot();
		this.RefreshBubbleAndCheckTimer(activityId);
	}

	// Token: 0x06007714 RID: 30484 RVA: 0x0024B714 File Offset: 0x00249914
	public void BindRedDotIds(int[] redDotIds)
	{
		foreach (int value in redDotIds)
		{
			this.RefreshRedDot(new int?(value));
		}
	}

	// Token: 0x06007715 RID: 30485 RVA: 0x0024B744 File Offset: 0x00249944
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

	// Token: 0x06007716 RID: 30486 RVA: 0x0024B7E4 File Offset: 0x002499E4
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

	// Token: 0x06007717 RID: 30487 RVA: 0x0024B8B4 File Offset: 0x00249AB4
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

	// Token: 0x06007718 RID: 30488 RVA: 0x0024B8F0 File Offset: 0x00249AF0
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

	// Token: 0x06007719 RID: 30489 RVA: 0x0024B960 File Offset: 0x00249B60
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

	// Token: 0x0600771A RID: 30490 RVA: 0x0024BA08 File Offset: 0x00249C08
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
		int[] array = new int[itemConfigList.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = itemConfigList[i];
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 == null)
		{
			return;
		}
		captionItem2.SetCurrencyItemList(array).Forget();
	}

	// Token: 0x0600771B RID: 30491 RVA: 0x0024BA6B File Offset: 0x00249C6B
	public UUIItem GetCaptionItemToggleRootItem()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return null;
		}
		return captionItem.GetToggleRootItem();
	}

	// Token: 0x0600771C RID: 30492 RVA: 0x0024BA7E File Offset: 0x00249C7E
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

	// Token: 0x0600771D RID: 30493 RVA: 0x0024BA91 File Offset: 0x00249C91
	private void OnChangeActivityViewNeedBlurState(bool state)
	{
		UiBehaviourUiBlur uiBlurBehaviour = this.UiBlurBehaviour;
		if (uiBlurBehaviour == null)
		{
			return;
		}
		uiBlurBehaviour.ChangeNeedBlurState(state);
	}

	// Token: 0x0600771E RID: 30494 RVA: 0x0024BAA4 File Offset: 0x00249CA4
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

	// Token: 0x0600771F RID: 30495 RVA: 0x0024BAF8 File Offset: 0x00249CF8
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

	// Token: 0x06007720 RID: 30496 RVA: 0x0024BBC2 File Offset: 0x00249DC2
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

	// Token: 0x06007721 RID: 30497 RVA: 0x0024BBE0 File Offset: 0x00249DE0
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

	// Token: 0x06007722 RID: 30498 RVA: 0x0024BC2C File Offset: 0x00249E2C
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

	// Token: 0x06007723 RID: 30499 RVA: 0x0024BCD8 File Offset: 0x00249ED8
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

	// Token: 0x06007724 RID: 30500 RVA: 0x0024BD24 File Offset: 0x00249F24
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

	// Token: 0x06007725 RID: 30501 RVA: 0x0024BD70 File Offset: 0x00249F70
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

	// Token: 0x06007726 RID: 30502 RVA: 0x0024BDC4 File Offset: 0x00249FC4
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

	// Token: 0x06007727 RID: 30503 RVA: 0x0024BE1F File Offset: 0x0024A01F
	private void OnPlaySequenceEventByStringParam(string name)
	{
		ActivitySubViewBase currentShowingActivitySubView = this.CurrentShowingActivitySubView;
		if (currentShowingActivitySubView == null)
		{
			return;
		}
		currentShowingActivitySubView.PlaySubViewSequence(name, false);
	}

	// Token: 0x06007728 RID: 30504 RVA: 0x0024BE34 File Offset: 0x0024A034
	private void UpdateListShowState(bool show, EActivityViewState state = EActivityViewState.Side, bool? blockClick = null)
	{
		this.ViewSaveStateSequence = new List<string>(ActivityViewStateSequence.Value[state]);
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

	// Token: 0x06007729 RID: 30505 RVA: 0x0024BEB8 File Offset: 0x0024A0B8
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

	// Token: 0x0600772A RID: 30506 RVA: 0x0024BF20 File Offset: 0x0024A120
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

	// Token: 0x0600772B RID: 30507 RVA: 0x0024BF4C File Offset: 0x0024A14C
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

	// Token: 0x0600772C RID: 30508 RVA: 0x0024BFB4 File Offset: 0x0024A1B4
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

	// Token: 0x0600772D RID: 30509 RVA: 0x0024C0D5 File Offset: 0x0024A2D5
	public bool IsPermanentTab(int tabId)
	{
		return tabId == 999;
	}

	// Token: 0x0600772E RID: 30510 RVA: 0x0024C0E0 File Offset: 0x0024A2E0
	public List<ActivityBaseData> FilterActivitiesByTabId(List<ActivityBaseData> activities, int tabId)
	{
		bool flag = this.IsPermanentTab(tabId);
		List<ActivityBaseData> list = new List<ActivityBaseData>(activities.Count);
		foreach (ActivityBaseData activityBaseData in activities)
		{
			bool flag2;
			if (!flag)
			{
				if (activityBaseData.TimeType == EActivityTimeType.TimeLimit)
				{
					ActivityBaseData activityBaseData2 = activityBaseData;
					flag2 = (activityBaseData2.LocalConfig != null && activityBaseData2.LocalConfig.GetValueOrDefault().FilterTabType == tabId);
				}
				else
				{
					flag2 = false;
				}
			}
			else
			{
				flag2 = (activityBaseData.TimeType == EActivityTimeType.Permanent);
			}
			if (flag2)
			{
				list.Add(activityBaseData);
			}
		}
		return list;
	}

	// Token: 0x0600772F RID: 30511 RVA: 0x0024C184 File Offset: 0x0024A384
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

	// Token: 0x06007730 RID: 30512 RVA: 0x0024C1D4 File Offset: 0x0024A3D4
	private void InitPermanentFilter()
	{
		IReadOnlyList<ActivityPermanentFilter> allActivityPermanentFilter = ActivityConfig.Instance.GetAllActivityPermanentFilter();
		if (allActivityPermanentFilter == null)
		{
			return;
		}
		IActivityCategoryTabData activityCategoryTabData = null;
		if (this.TabDataList != null)
		{
			for (int i = 0; i < this.TabDataList.Length; i++)
			{
				if (this.TabDataList[i].Id.GetValueOrDefault() == 999)
				{
					activityCategoryTabData = this.TabDataList[i];
					break;
				}
			}
		}
		List<ActivityPermanentFilter> list = new List<ActivityPermanentFilter>();
		int num = -1;
		for (int j = 0; j < allActivityPermanentFilter.Count; j++)
		{
			if (allActivityPermanentFilter[j].Id == 999)
			{
				num = j;
				break;
			}
		}
		if (num < 0)
		{
			throw new InvalidOperationException("Sequence contains no matching element");
		}
		list.Add(allActivityPermanentFilter[num]);
		if (activityCategoryTabData != null)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<ActivityBaseData> activities = activityCategoryTabData.Activities;
			if (activities != null)
			{
				foreach (ActivityBaseData activityBaseData in activities)
				{
					hashSet.Add(activityBaseData.LocalConfig.Value.PermanentFilterType);
				}
			}
			foreach (ActivityPermanentFilter item in allActivityPermanentFilter)
			{
				if (item.Id != 999 && hashSet.Contains(item.Id))
				{
					list.Add(item);
				}
			}
		}
		int num2 = list.FindIndex((ActivityPermanentFilter x) => x.Id == this.CurrentPermanentFilterId);
		if (num2 == -1)
		{
			num2 = 0;
		}
		this.FilterDropDown.InitScroll(list, delegate(ActivityPermanentFilter tabCfg)
		{
			ActivityPermanentFilter activityPermanentFilter = tabCfg;
			return new TableTextArgNew(activityPermanentFilter.FilterName, Array.Empty<object>());
		}, num2, true);
	}

	// Token: 0x04004AC7 RID: 19143
	private bool IsViewFirstShow = true;

	// Token: 0x04004AC8 RID: 19144
	private bool ListShowInternal = true;

	// Token: 0x04004AC9 RID: 19145
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004ACA RID: 19146
	private int HelpId;

	// Token: 0x04004ACB RID: 19147
	[Nullable(2)]
	private object SubViewOpenParam;

	// Token: 0x04004ACC RID: 19148
	[Nullable(2)]
	private ActivityTipsButton TipsButton;

	// Token: 0x04004ACD RID: 19149
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivityPageSelectContent, ActivityBaseData> SubViewTabLayout;

	// Token: 0x04004ACE RID: 19150
	private int? CurrentSelectTabId;

	// Token: 0x04004ACF RID: 19151
	private readonly Dictionary<EActivityTimeType, int> SelectActivityIdMap = new Dictionary<EActivityTimeType, int>();

	// Token: 0x04004AD0 RID: 19152
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ActivitySwitchToggle, ActivitySwitchToggleDynamicItem, IActivityCategoryTabData> CategoryScrollView;

	// Token: 0x04004AD1 RID: 19153
	[Nullable(2)]
	private UUIExtendToggle CurrentCategoryToggle;

	// Token: 0x04004AD2 RID: 19154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IActivityCategoryTabData[] TabDataList;

	// Token: 0x04004AD3 RID: 19155
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, ActivityPermanentFilter> FilterDropDown;

	// Token: 0x04004AD4 RID: 19156
	private int CurrentPermanentFilterId = 999;

	// Token: 0x04004AD5 RID: 19157
	private bool IsInRefreshTabItem;

	// Token: 0x04004AD6 RID: 19158
	private bool IsHideTabSidebar;

	// Token: 0x04004AD7 RID: 19159
	private ECaptionDecorationFunc CurrentCaptionDecorationFunc;

	// Token: 0x04004AD8 RID: 19160
	private readonly Dictionary<ECaptionDecorationFunc, ActivityCaptionDecorationTagBase> CaptionDecorationTagCache = new Dictionary<ECaptionDecorationFunc, ActivityCaptionDecorationTagBase>();

	// Token: 0x04004AD9 RID: 19161
	[Nullable(2)]
	private ActivitySubViewBase CurrentShowingActivitySubView;

	// Token: 0x04004ADA RID: 19162
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Lru<ActivityBaseData, ActivitySubViewBase> ActivitySubViewCache;

	// Token: 0x04004ADB RID: 19163
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004ADC RID: 19164
	private List<ActivityBaseData> ActivityDataList = new List<ActivityBaseData>();

	// Token: 0x04004ADD RID: 19165
	private readonly Dictionary<int, bool> RedDotStateMap = new Dictionary<int, bool>();

	// Token: 0x04004ADE RID: 19166
	private List<string> ViewSaveStateSequence = new List<string>();

	// Token: 0x04004ADF RID: 19167
	[Nullable(new byte[]
	{
		0,
		2,
		2
	})]
	private ValueTuple<UUIItem, UUIItem> ItemRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);

	// Token: 0x04004AE0 RID: 19168
	[Nullable(new byte[]
	{
		0,
		2,
		2
	})]
	private ValueTuple<UUIItem, UUIItem> BtnRedDot = new ValueTuple<UUIItem, UUIItem>(null, null);

	// Token: 0x04004AE1 RID: 19169
	[Nullable(2)]
	private ButtonItem RecommendBtnItem;

	// Token: 0x02006DC9 RID: 28105
	[NullableContext(0)]
	private class EActivityComponents
	{
		// Token: 0x04023F8C RID: 147340
		public const int CaptionItem = 0;

		// Token: 0x04023F8D RID: 147341
		public const int TabScrollView = 1;

		// Token: 0x04023F8E RID: 147342
		public const int TabToggle = 2;

		// Token: 0x04023F8F RID: 147343
		public const int SubView = 3;

		// Token: 0x04023F90 RID: 147344
		public const int Panel = 4;

		// Token: 0x04023F91 RID: 147345
		public const int BgTexture = 5;

		// Token: 0x04023F92 RID: 147346
		public const int BtnBack = 6;

		// Token: 0x04023F93 RID: 147347
		public const int PanelTips = 7;

		// Token: 0x04023F94 RID: 147348
		public const int Content = 8;

		// Token: 0x04023F95 RID: 147349
		public const int TabLine = 9;

		// Token: 0x04023F96 RID: 147350
		public const int TxtDebugId = 10;

		// Token: 0x04023F97 RID: 147351
		public const int BtnTopRedDot = 11;

		// Token: 0x04023F98 RID: 147352
		public const int BtnBottomRedDot = 12;

		// Token: 0x04023F99 RID: 147353
		public const int PanelTop = 13;

		// Token: 0x04023F9A RID: 147354
		public const int DropdownA = 14;

		// Token: 0x04023F9B RID: 147355
		public const int DynamicTab = 15;

		// Token: 0x04023F9C RID: 147356
		public const int PanelTab = 16;

		// Token: 0x04023F9D RID: 147357
		public const int PanelSafe = 17;

		// Token: 0x04023F9E RID: 147358
		public const int BtnActivityRecommend = 18;
	}
}
