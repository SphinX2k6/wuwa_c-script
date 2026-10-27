using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011F5 RID: 4597
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingMainView : UiViewBase
{
	// Token: 0x06007ACE RID: 31438 RVA: 0x0019DC23 File Offset: 0x0019BE23
	public ActivityCorniceMeetingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007ACF RID: 31439 RVA: 0x0019DC38 File Offset: 0x0019BE38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickBtnChallenge));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007AD0 RID: 31440 RVA: 0x0019DE50 File Offset: 0x0019C050
	private void OnClickBtnChallenge()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		if (!currentActivityData.GetIsShow(currentActivityData.CurrentSelectLevelPlayId))
		{
			return;
		}
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(currentActivityData.CurrentSelectLevelPlayId);
		if (levelEntryData == null)
		{
			return;
		}
		int markId = levelEntryData.GetMarkId();
		WorldMapViewOpenParams data = new WorldMapViewOpenParams
		{
			MarkId = new int?(markId),
			MarkType = EMarkType.CorniceMeeting,
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
	}

	// Token: 0x06007AD1 RID: 31441 RVA: 0x0019DEC4 File Offset: 0x0019C0C4
	protected override void OnStart()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		this.CurrentActivity = currentActivityData.GetLevelEntryData(currentActivityData.GetDefaultSelectLevelPlayId());
		this.RewardLayout = new GenericLayout<ActivityCorniceMeetingRewardItem, ActivityCorniceMeetingRewardItemData>(base.GetVerticalLayout(4), new Func<ActivityCorniceMeetingRewardItem>(this.CreateTaskItem), null, false, true);
		this.TabLoopScrollView = new LoopScrollView<ActivityCorniceMeetingTabItem, int>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityCorniceMeetingTabItem>(this.CreateActivityItem), false);
		this.InitCaptionItem();
		this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), 1000f, 1f, null, null, true);
	}

	// Token: 0x06007AD2 RID: 31442 RVA: 0x0019DF6E File Offset: 0x0019C16E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingController.Instance.GetCurrentActivityData().Id);
	}

	// Token: 0x06007AD3 RID: 31443 RVA: 0x0019DF90 File Offset: 0x0019C190
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnClickActivityCorniceMeetingTab, new Action<int>(this.OnClickActivityCorniceMeetingTab));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Add<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(this.RefreshTabState));
	}

	// Token: 0x06007AD4 RID: 31444 RVA: 0x0019DFF4 File Offset: 0x0019C1F4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickActivityCorniceMeetingTab, new Action<int>(this.OnClickActivityCorniceMeetingTab));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Remove(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(this.RefreshTabState));
	}

	// Token: 0x06007AD5 RID: 31445 RVA: 0x0019E058 File Offset: 0x0019C258
	private void RefreshTabState(int i)
	{
		int selectedGridIndex = this.TabLoopScrollView.GetSelectedGridIndex();
		this.TabLoopScrollView.RefreshGridProxy(selectedGridIndex);
	}

	// Token: 0x06007AD6 RID: 31446 RVA: 0x0019E080 File Offset: 0x0019C280
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (closeActivities.Contains(ActivityCorniceMeetingController.Instance.ActivityId))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.<OnActivityClose>g__confirmCallback|15_0);
			confirmBoxDataNew.FunctionMap[0] = new Action(this.<OnActivityClose>g__confirmCallback|15_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x06007AD7 RID: 31447 RVA: 0x0019E0E4 File Offset: 0x0019C2E4
	private void OnClickActivityCorniceMeetingTab(int levelPlayId)
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		currentActivityData.CurrentSelectLevelPlayId = levelPlayId;
		this.CurrentActivity = currentActivityData.GetLevelEntryData(levelPlayId);
		this.RefreshRewardView();
		this.RefreshContainer();
		this.RefreshBestScore();
		base.PlaySequenceAsync("Switch", true, false, null);
	}

	// Token: 0x06007AD8 RID: 31448 RVA: 0x0019E139 File Offset: 0x0019C339
	protected override void OnBeforeShow()
	{
		this.RefreshLoopScrollView();
		this.RefreshRewardView();
		this.RefreshContainer();
		this.RefreshBestScore();
	}

	// Token: 0x06007AD9 RID: 31449 RVA: 0x0019E154 File Offset: 0x0019C354
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
		RedDotController.Instance.UnBindRedDot(ERedDotName.ActivityCorniceMeeting);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingController.Instance.GetCurrentActivityData().Id);
	}

	// Token: 0x06007ADA RID: 31450 RVA: 0x0019E1B0 File Offset: 0x0019C3B0
	private void InitCaptionItem()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickMoreButton));
		this.CaptionItem.SetTitle(currentActivityData.GetTitle());
	}

	// Token: 0x06007ADB RID: 31451 RVA: 0x0019E21C File Offset: 0x0019C41C
	private ActivityCorniceMeetingTabItem CreateActivityItem()
	{
		ActivityCorniceMeetingTabItem activityCorniceMeetingTabItem = new ActivityCorniceMeetingTabItem();
		this.TabItemProxyList.Add(activityCorniceMeetingTabItem);
		return activityCorniceMeetingTabItem;
	}

	// Token: 0x06007ADC RID: 31452 RVA: 0x0019E23C File Offset: 0x0019C43C
	private ActivityCorniceMeetingRewardItem CreateTaskItem()
	{
		return new ActivityCorniceMeetingRewardItem();
	}

	// Token: 0x06007ADD RID: 31453 RVA: 0x0019E243 File Offset: 0x0019C443
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007ADE RID: 31454 RVA: 0x0019E24C File Offset: 0x0019C44C
	private void OnClickMoreButton()
	{
		int helpId = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetHelpId();
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06007ADF RID: 31455 RVA: 0x0019E274 File Offset: 0x0019C474
	private void OnTimerRefresh(float _)
	{
		this.RefreshCountDownText();
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		bool isShow = currentActivityData.GetIsShow(currentActivityData.CurrentSelectLevelPlayId);
		if (isShow && this.IsLastShow != isShow)
		{
			int selectedGridIndex = this.TabLoopScrollView.GetSelectedGridIndex();
			this.TabLoopScrollView.RefreshGridProxy(selectedGridIndex);
			this.RefreshBestScore();
			this.RefreshContainer();
		}
		this.IsLastShow = isShow;
	}

	// Token: 0x06007AE0 RID: 31456 RVA: 0x0019E2DC File Offset: 0x0019C4DC
	private void RefreshCountDownText()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		if (!currentActivityData.GetIsShow(currentActivityData.CurrentSelectLevelPlayId))
		{
			ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(currentActivityData.CurrentSelectLevelPlayId);
			string remainTimeText = this.GetRemainTimeText((float)(levelEntryData.UnlockTime / 1000L), "ActiveToOpenTime");
			base.GetText(8).SetText(remainTimeText, true);
		}
	}

	// Token: 0x06007AE1 RID: 31457 RVA: 0x0019E338 File Offset: 0x0019C538
	private string GetRemainTimeText(float dataTime, string timeText)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = (double)((int)dataTime) - serverTime;
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById(timeText), null).Replace("{0}", remainTimeDataFormat.CountDownText);
	}

	// Token: 0x06007AE2 RID: 31458 RVA: 0x0019E384 File Offset: 0x0019C584
	private void RefreshRewardView()
	{
		List<ActivityCorniceMeetingRewardItemData> data = (from item in this.CurrentActivity.GetRewardList()
		select new ActivityCorniceMeetingRewardItemData
		{
			RewardId = item,
			OnClickFinishBtnCb = new Action(this.OnClickGetReward)
		}).ToList<ActivityCorniceMeetingRewardItemData>();
		this.RewardLayout.RefreshByData(data, null, false);
	}

	// Token: 0x06007AE3 RID: 31459 RVA: 0x0019E3C4 File Offset: 0x0019C5C4
	private void OnClickGetReward()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		int levelPlayId = this.TabItemProxyList[this.TabLoopScrollView.GetSelectedGridIndex()].LevelPlayId;
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(levelPlayId);
		if (levelEntryData == null)
		{
			return;
		}
		List<int> rewardList = levelEntryData.GetRewardList();
		for (int i = 0; i < rewardList.Count; i++)
		{
			if (currentActivityData.GetRewardState(levelPlayId, i) == ECorniceMeetingRewardState.Finished)
			{
				if (dictionary.ContainsKey(levelPlayId))
				{
					dictionary[levelPlayId].Add(i);
				}
				else
				{
					dictionary[levelPlayId] = new List<int>
					{
						i
					};
				}
			}
		}
		ActivityCorniceMeetingController.Instance.MultiCorniceMeetingRewardRequest(currentActivityData.Id, dictionary, delegate
		{
			this.RefreshRewardView();
			this.RefreshLoopScrollView();
		});
	}

	// Token: 0x06007AE4 RID: 31460 RVA: 0x0019E480 File Offset: 0x0019C680
	private void RefreshLoopScrollView()
	{
		ActivityCorniceMeetingData activityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		List<int> levelPlayIdList = activityData.GetLevelPlayIdList(true);
		this.TabLoopScrollView.BindOnScrollValueChanged(delegate(FVector2D progress)
		{
			bool uiactive = false;
			bool uiactive2 = false;
			for (int i = 0; i < this.TabItemProxyList.Count; i++)
			{
				ActivityCorniceMeetingTabItem activityCorniceMeetingTabItem = this.TabItemProxyList[i];
				if (activityCorniceMeetingTabItem != null)
				{
					ActivityCorniceMeetingLevelEntryData levelEntryData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetLevelEntryData(activityCorniceMeetingTabItem.LevelPlayId);
					if (levelEntryData != null)
					{
						if (levelEntryData.GetRedDot() && i < this.TabLoopScrollView.GetDisplayGridStartIndex())
						{
							uiactive = true;
						}
						if (levelEntryData.GetRedDot() && i > this.TabLoopScrollView.GetDisplayGridEndIndex())
						{
							uiactive2 = true;
						}
					}
				}
			}
			this.GetItem(10).SetUIActive(uiactive);
			this.GetItem(11).SetUIActive(uiactive2);
		});
		this.TabLoopScrollView.RefreshByData(levelPlayIdList, false, delegate
		{
			LoopScrollView<ActivityCorniceMeetingTabItem, int> tabLoopScrollView = this.TabLoopScrollView;
			if (tabLoopScrollView == null)
			{
				return;
			}
			tabLoopScrollView.SelectGridProxy(activityData.GetSelectLevelPlayIdIndex(), false);
		}, false);
	}

	// Token: 0x06007AE5 RID: 31461 RVA: 0x0019E4E8 File Offset: 0x0019C6E8
	private void RefreshContainer()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		bool isShow = currentActivityData.GetIsShow(currentActivityData.CurrentSelectLevelPlayId);
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
		if (verticalLayout != null)
		{
			verticalLayout.RootUIComp.Get().SetUIActive(isShow);
		}
		base.GetItem(3).SetUIActive(!isShow);
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(isShow);
	}

	// Token: 0x06007AE6 RID: 31462 RVA: 0x0019E55C File Offset: 0x0019C75C
	private void RefreshBestScore()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(currentActivityData.CurrentSelectLevelPlayId);
		string timeString = TimeUtil.Instance.GetTimeString((double)levelEntryData.RemainTime);
		if (levelEntryData != null && levelEntryData.MaxScore == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "ActivityCorniceMeetingScoreNoRecord", Array.Empty<object>());
		}
		else
		{
			int maxScore = levelEntryData.MaxScore;
			int num = (levelEntryData != null) ? levelEntryData.GetMaxScoreConfig() : 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Text_ItemCost_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				((maxScore > num) ? num : maxScore).ToString(),
				num.ToString()
			}));
		}
		base.GetItem(9).SetUIActive(levelEntryData.IsAllFinished());
		base.GetText(6).SetText(timeString, true);
		base.GetItem(12).SetUIActive(levelEntryData.IsUnlock());
	}

	// Token: 0x06007AE7 RID: 31463 RVA: 0x0019E640 File Offset: 0x0019C840
	[CompilerGenerated]
	private void <OnActivityClose>g__confirmCallback|15_0()
	{
		base.CloseMe(null);
	}

	// Token: 0x04003841 RID: 14401
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003842 RID: 14402
	[Nullable(2)]
	private ActivityCorniceMeetingLevelEntryData CurrentActivity;

	// Token: 0x04003843 RID: 14403
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ActivityCorniceMeetingTabItem, int> TabLoopScrollView;

	// Token: 0x04003844 RID: 14404
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityCorniceMeetingRewardItem, ActivityCorniceMeetingRewardItemData> RewardLayout;

	// Token: 0x04003845 RID: 14405
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04003846 RID: 14406
	private readonly List<ActivityCorniceMeetingTabItem> TabItemProxyList = new List<ActivityCorniceMeetingTabItem>();

	// Token: 0x04003847 RID: 14407
	private bool IsLastShow;

	// Token: 0x020077D8 RID: 30680
	[NullableContext(0)]
	private class EActivityCorniceMeetingMainViewComponents
	{
		// Token: 0x0402781D RID: 161821
		public const int CaptionItem = 0;

		// Token: 0x0402781E RID: 161822
		public const int LoopScrollViewItem = 1;

		// Token: 0x0402781F RID: 161823
		public const int LoopScrollItem = 2;

		// Token: 0x04027820 RID: 161824
		public const int PanelLock = 3;

		// Token: 0x04027821 RID: 161825
		public const int PanelRewardLayout = 4;

		// Token: 0x04027822 RID: 161826
		public const int TxtBestScore = 5;

		// Token: 0x04027823 RID: 161827
		public const int TxtBestTime = 6;

		// Token: 0x04027824 RID: 161828
		public const int BtnChallenge = 7;

		// Token: 0x04027825 RID: 161829
		public const int LockText = 8;

		// Token: 0x04027826 RID: 161830
		public const int PanelTime = 9;

		// Token: 0x04027827 RID: 161831
		public const int PreRedDotItem = 10;

		// Token: 0x04027828 RID: 161832
		public const int NextRedDotItem = 11;

		// Token: 0x04027829 RID: 161833
		public const int PanelScore = 12;
	}
}
