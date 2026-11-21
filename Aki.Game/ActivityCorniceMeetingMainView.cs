using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020006A9 RID: 1705
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingMainView : UiViewBase
{
	// Token: 0x06004E65 RID: 20069 RVA: 0x001A68CB File Offset: 0x001A4ACB
	public ActivityCorniceMeetingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004E66 RID: 20070 RVA: 0x001A68E0 File Offset: 0x001A4AE0
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

	// Token: 0x06004E67 RID: 20071 RVA: 0x001A6AF8 File Offset: 0x001A4CF8
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

	// Token: 0x06004E68 RID: 20072 RVA: 0x001A6B6C File Offset: 0x001A4D6C
	protected override void OnStart()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		this.CurrentActivity = currentActivityData.GetLevelEntryData(currentActivityData.GetDefaultSelectLevelPlayId());
		this.RewardLayout = new GenericLayout<ActivityCorniceMeetingRewardItem, ActivityCorniceMeetingRewardItemData>(base.GetVerticalLayout(4), new Func<ActivityCorniceMeetingRewardItem>(this.CreateTaskItem), null, false, true);
		this.TabLoopScrollView = new LoopScrollView<ActivityCorniceMeetingTabItem, int>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityCorniceMeetingTabItem>(this.CreateActivityItem), false);
		this.InitCaptionItem();
		this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimerRefresh), 1000f, 1f, null, null, true);
	}

	// Token: 0x06004E69 RID: 20073 RVA: 0x001A6C16 File Offset: 0x001A4E16
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingController.Instance.GetCurrentActivityData().Id);
	}

	// Token: 0x06004E6A RID: 20074 RVA: 0x001A6C38 File Offset: 0x001A4E38
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnClickActivityCorniceMeetingTab, new Action<int>(this.OnClickActivityCorniceMeetingTab));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Add<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(this.RefreshTabState));
	}

	// Token: 0x06004E6B RID: 20075 RVA: 0x001A6C9C File Offset: 0x001A4E9C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickActivityCorniceMeetingTab, new Action<int>(this.OnClickActivityCorniceMeetingTab));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		EventSystem.Instance.Remove(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(this.RefreshTabState));
	}

	// Token: 0x06004E6C RID: 20076 RVA: 0x001A6D00 File Offset: 0x001A4F00
	private void RefreshTabState(int i)
	{
		int selectedGridIndex = this.TabLoopScrollView.GetSelectedGridIndex();
		this.TabLoopScrollView.RefreshGridProxy(selectedGridIndex);
	}

	// Token: 0x06004E6D RID: 20077 RVA: 0x001A6D28 File Offset: 0x001A4F28
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

	// Token: 0x06004E6E RID: 20078 RVA: 0x001A6D8C File Offset: 0x001A4F8C
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

	// Token: 0x06004E6F RID: 20079 RVA: 0x001A6DE1 File Offset: 0x001A4FE1
	protected override void OnBeforeShow()
	{
		this.RefreshLoopScrollView();
		this.RefreshRewardView();
		this.RefreshContainer();
		this.RefreshBestScore();
	}

	// Token: 0x06004E70 RID: 20080 RVA: 0x001A6DFC File Offset: 0x001A4FFC
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

	// Token: 0x06004E71 RID: 20081 RVA: 0x001A6E58 File Offset: 0x001A5058
	private void InitCaptionItem()
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickMoreButton));
		this.CaptionItem.SetTitle(currentActivityData.GetTitle());
	}

	// Token: 0x06004E72 RID: 20082 RVA: 0x001A6EC4 File Offset: 0x001A50C4
	private ActivityCorniceMeetingTabItem CreateActivityItem()
	{
		ActivityCorniceMeetingTabItem activityCorniceMeetingTabItem = new ActivityCorniceMeetingTabItem();
		this.TabItemProxyList.Add(activityCorniceMeetingTabItem);
		return activityCorniceMeetingTabItem;
	}

	// Token: 0x06004E73 RID: 20083 RVA: 0x001A6EE4 File Offset: 0x001A50E4
	private ActivityCorniceMeetingRewardItem CreateTaskItem()
	{
		return new ActivityCorniceMeetingRewardItem();
	}

	// Token: 0x06004E74 RID: 20084 RVA: 0x001A6EEB File Offset: 0x001A50EB
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06004E75 RID: 20085 RVA: 0x001A6EF4 File Offset: 0x001A50F4
	private void OnClickMoreButton()
	{
		int helpId = ActivityCorniceMeetingController.Instance.GetCurrentActivityData().GetHelpId();
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06004E76 RID: 20086 RVA: 0x001A6F1C File Offset: 0x001A511C
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

	// Token: 0x06004E77 RID: 20087 RVA: 0x001A6F84 File Offset: 0x001A5184
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

	// Token: 0x06004E78 RID: 20088 RVA: 0x001A6FE0 File Offset: 0x001A51E0
	private string GetRemainTimeText(float dataTime, string timeText)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double remainTime = (double)((int)dataTime) - serverTime;
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById(timeText), null).Replace("{0}", remainTimeDataFormat.CountDownText);
	}

	// Token: 0x06004E79 RID: 20089 RVA: 0x001A702C File Offset: 0x001A522C
	private void RefreshRewardView()
	{
		List<int> rewardList = this.CurrentActivity.GetRewardList();
		List<ActivityCorniceMeetingRewardItemData> list = new List<ActivityCorniceMeetingRewardItemData>(rewardList.Count);
		for (int i = 0; i < rewardList.Count; i++)
		{
			list.Add(new ActivityCorniceMeetingRewardItemData
			{
				RewardId = rewardList[i],
				OnClickFinishBtnCb = new Action(this.OnClickGetReward)
			});
		}
		this.RewardLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06004E7A RID: 20090 RVA: 0x001A709C File Offset: 0x001A529C
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

	// Token: 0x06004E7B RID: 20091 RVA: 0x001A7158 File Offset: 0x001A5358
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

	// Token: 0x06004E7C RID: 20092 RVA: 0x001A71C0 File Offset: 0x001A53C0
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

	// Token: 0x06004E7D RID: 20093 RVA: 0x001A7234 File Offset: 0x001A5434
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

	// Token: 0x06004E7E RID: 20094 RVA: 0x001A7318 File Offset: 0x001A5518
	[CompilerGenerated]
	private void <OnActivityClose>g__confirmCallback|15_0()
	{
		base.CloseMe(null);
	}

	// Token: 0x040038DA RID: 14554
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040038DB RID: 14555
	[Nullable(2)]
	private ActivityCorniceMeetingLevelEntryData CurrentActivity;

	// Token: 0x040038DC RID: 14556
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ActivityCorniceMeetingTabItem, int> TabLoopScrollView;

	// Token: 0x040038DD RID: 14557
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityCorniceMeetingRewardItem, ActivityCorniceMeetingRewardItemData> RewardLayout;

	// Token: 0x040038DE RID: 14558
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x040038DF RID: 14559
	private readonly List<ActivityCorniceMeetingTabItem> TabItemProxyList = new List<ActivityCorniceMeetingTabItem>();

	// Token: 0x040038E0 RID: 14560
	private bool IsLastShow;

	// Token: 0x02006963 RID: 26979
	[NullableContext(0)]
	private class EActivityCorniceMeetingMainViewComponents
	{
		// Token: 0x04022B4F RID: 142159
		public const int CaptionItem = 0;

		// Token: 0x04022B50 RID: 142160
		public const int LoopScrollViewItem = 1;

		// Token: 0x04022B51 RID: 142161
		public const int LoopScrollItem = 2;

		// Token: 0x04022B52 RID: 142162
		public const int PanelLock = 3;

		// Token: 0x04022B53 RID: 142163
		public const int PanelRewardLayout = 4;

		// Token: 0x04022B54 RID: 142164
		public const int TxtBestScore = 5;

		// Token: 0x04022B55 RID: 142165
		public const int TxtBestTime = 6;

		// Token: 0x04022B56 RID: 142166
		public const int BtnChallenge = 7;

		// Token: 0x04022B57 RID: 142167
		public const int LockText = 8;

		// Token: 0x04022B58 RID: 142168
		public const int PanelTime = 9;

		// Token: 0x04022B59 RID: 142169
		public const int PreRedDotItem = 10;

		// Token: 0x04022B5A RID: 142170
		public const int NextRedDotItem = 11;

		// Token: 0x04022B5B RID: 142171
		public const int PanelScore = 12;
	}
}
