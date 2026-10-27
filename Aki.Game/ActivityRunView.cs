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
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020014DC RID: 5340
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunView : UiTickViewBase
{
	// Token: 0x06009801 RID: 38913 RVA: 0x0020D7E4 File Offset: 0x0020B9E4
	public ActivityRunView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009802 RID: 38914 RVA: 0x0020D844 File Offset: 0x0020BA44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
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
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009803 RID: 38915 RVA: 0x0020DB04 File Offset: 0x0020BD04
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickMoreButton));
		this.CaptionItem.SetTitle(this.CurrentActivity.GetTitle());
	}

	// Token: 0x06009804 RID: 38916 RVA: 0x0020DB68 File Offset: 0x0020BD68
	protected override void OnStart()
	{
		this.CurrentActivity = (this.OpenParam as ActivityRun);
		this.ActivityRunDataArray = this.CurrentActivity.GetChallengeDataArray();
		this.InitCaptionItem();
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
		this.TaskScroller = new GenericLayout<ActivityRunItem, int>(verticalLayout, this.CreateTaskItem, null, false, true);
		UUILoopScrollViewComponent scrollView = base.GetItem(1).GetOwner().GetComponentByClass(UUILoopScrollViewComponent.StaticClass()) as UUILoopScrollViewComponent;
		this.ExhibitionView = new LoopScrollView<ActivityRunCycleItem, int>(scrollView, base.GetItem(2).GetOwner() as AUIBaseActor, this.CreateActivityItem, false);
		base.GetItem(2).SetUIActive(false);
		base.GetButton(11).RootUIComp.Get().SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06009805 RID: 38917 RVA: 0x0020DC44 File Offset: 0x0020BE44
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSelectActivityRunChallengeItem, new Action(this.OnSelectActivityRunChallengeItem));
		EventSystem.Instance.Add<ActivityRunCycleItem>(EEventName.OnClickActivityRunChallenge, new Action<ActivityRunCycleItem>(this.OnClickActivityRunChallenge));
		EventSystem.Instance.Add<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06009806 RID: 38918 RVA: 0x0020DCC4 File Offset: 0x0020BEC4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectActivityRunChallengeItem, new Action(this.OnSelectActivityRunChallengeItem));
		EventSystem.Instance.Remove<ActivityRunCycleItem>(EEventName.OnClickActivityRunChallenge, new Action<ActivityRunCycleItem>(this.OnClickActivityRunChallenge));
		EventSystem.Instance.Remove<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06009807 RID: 38919 RVA: 0x0020DD44 File Offset: 0x0020BF44
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (closeActivities.Contains(this.CurrentActivity.Id))
		{
			Action value = delegate()
			{
				base.CloseMe(null);
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[0] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x06009808 RID: 38920 RVA: 0x0020DD9F File Offset: 0x0020BF9F
	private void OnSelectActivityRunChallengeItem()
	{
		this.RefreshTaskScroller();
		this.RefreshConfirmButton();
		this.RefreshPointText();
		this.RefreshContainer();
		this.RefreshCountDownText();
		this.PlaySwitchAnimation();
	}

	// Token: 0x06009809 RID: 38921 RVA: 0x0020DDC8 File Offset: 0x0020BFC8
	private void RefreshContainer()
	{
		bool isShow = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId).GetIsShow();
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(isShow);
		}
		base.GetItem(9).SetUIActive(!isShow);
	}

	// Token: 0x0600980A RID: 38922 RVA: 0x0020DE14 File Offset: 0x0020C014
	private void RefreshConfirmButton()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		base.GetButton(6).RootUIComp.Get().SetUIActive(activityRunData.GetIsShow());
	}

	// Token: 0x0600980B RID: 38923 RVA: 0x0020DE5C File Offset: 0x0020C05C
	private void PlaySwitchAnimation()
	{
		if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
		{
			this.UiViewSequence.ReplaySequence("Switch");
			return;
		}
		this.UiViewSequence.PlaySequence("Switch", false, null);
	}

	// Token: 0x0600980C RID: 38924 RVA: 0x0020DEA6 File Offset: 0x0020C0A6
	private void OnClickActivityRunChallenge(ActivityRunCycleItem item)
	{
		this.ExhibitionView.ScrollToGridIndex(item.GridIndex, true);
	}

	// Token: 0x0600980D RID: 38925 RVA: 0x0020DEBA File Offset: 0x0020C0BA
	private void OnGetRunActivityReward(int i)
	{
		LoopScrollView<ActivityRunCycleItem, int> exhibitionView = this.ExhibitionView;
		if (exhibitionView == null)
		{
			return;
		}
		exhibitionView.RefreshAllGridProxies();
	}

	// Token: 0x0600980E RID: 38926 RVA: 0x0020DECC File Offset: 0x0020C0CC
	private void OnClickConfirmBtn()
	{
		if (!ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId).GetIsShow())
		{
			return;
		}
		int activityRunMarkId = ActivityRunConfig.Instance.GetActivityRunMarkId(ActivityRunModel.Instance.CurrentSelectChallengeId);
		WorldMapViewOpenParams data = new WorldMapViewOpenParams
		{
			MarkId = new int?(activityRunMarkId),
			MarkType = EMarkType.Parkour,
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
	}

	// Token: 0x0600980F RID: 38927 RVA: 0x0020DF3E File Offset: 0x0020C13E
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009810 RID: 38928 RVA: 0x0020DF47 File Offset: 0x0020C147
	private void OnClickMoreButton()
	{
		this.OpenHelpView();
	}

	// Token: 0x06009811 RID: 38929 RVA: 0x0020DF50 File Offset: 0x0020C150
	protected void OpenHelpView()
	{
		int helpId = this.CurrentActivity.GetHelpId();
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06009812 RID: 38930 RVA: 0x0020DF74 File Offset: 0x0020C174
	protected override void OnBeforeShow()
	{
		ActivityRunController.Instance.SelectDefaultChallengeId(this.CurrentActivity);
		this.RefreshActivityScroller();
		this.InitTimer();
	}

	// Token: 0x06009813 RID: 38931 RVA: 0x0020DF92 File Offset: 0x0020C192
	private void InitTimer()
	{
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), 1000f, 1f, null, null, true);
	}

	// Token: 0x06009814 RID: 38932 RVA: 0x0020DFC0 File Offset: 0x0020C1C0
	private void OnTimerRefresh(float deltaTime)
	{
		this.RefreshCountDownText();
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		bool isShow = activityRunData.GetIsShow();
		if (isShow && this.IsLastShow != isShow)
		{
			int selectedGridIndex = this.ExhibitionView.GetSelectedGridIndex();
			this.ExhibitionView.RefreshGridProxy(selectedGridIndex);
			this.RefreshTaskScroller();
			this.RefreshPointText();
			this.RefreshConfirmButton();
			this.RefreshContainer();
		}
		this.IsLastShow = isShow;
	}

	// Token: 0x06009815 RID: 38933 RVA: 0x0020E038 File Offset: 0x0020C238
	private void RefreshCountDownText()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (!activityRunData.GetIsShow())
		{
			string remainTimeText = this.GetRemainTimeText(activityRunData.BeginOpenTime, "ActiveToOpenTime");
			base.GetText(10).SetText(remainTimeText, true);
		}
	}

	// Token: 0x06009816 RID: 38934 RVA: 0x0020E084 File Offset: 0x0020C284
	private string GetRemainTimeText(long dataTime, string timeText)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = (double)dataTime - serverTime;
		if (num <= 10.0)
		{
			num = 10.0;
		}
		CommonDefine.ICountDown countDownData = TimeUtil.Instance.GetCountDownData(num, null, null);
		if (num >= 86400.0)
		{
			countDownData = TimeUtil.Instance.GetCountDownData(num, new CommonDefine.ETimeType?(CommonDefine.ETimeType.Day), new CommonDefine.ETimeType?(CommonDefine.ETimeType.Hour));
		}
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById(timeText), null).Replace("{0}", countDownData.CountDownText);
	}

	// Token: 0x06009817 RID: 38935 RVA: 0x0020E11C File Offset: 0x0020C31C
	private void RefreshActivityScroller()
	{
		int count = this.ActivityRunDataArray.Count;
		List<int> list = new List<int>();
		for (int i = 0; i < count; i++)
		{
			list.Add(this.ActivityRunDataArray[i].Id);
		}
		this.ExhibitionView.RefreshByDataAsync(list, false, false).ContinueWith(delegate()
		{
			this.ExhibitionView.SelectGridProxy(ActivityRunModel.Instance.GetStartViewSelectIndex(), true);
		});
	}

	// Token: 0x06009818 RID: 38936 RVA: 0x0020E180 File Offset: 0x0020C380
	private void RefreshTaskScroller()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		List<int> scoreArray = activityRunData.GetScoreArray();
		this.TaskScroller.RefreshByData(scoreArray, null, false);
	}

	// Token: 0x06009819 RID: 38937 RVA: 0x0020E1BC File Offset: 0x0020C3BC
	private void RefreshPointText()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(15), "ActiveRunMaxPoint", Array.Empty<object>());
		LguiUtil.Instance.SetLocalText(base.GetText(16), "ActiveRunMinTime", Array.Empty<object>());
		if (activityRunData.GetMiniTime() == 0)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("ActivityRunNoPoint"), null);
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(localTextNew, true);
			}
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.SetText(localTextNew, true);
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalText(base.GetText(15), "ActiveRunMaxPoint", Array.Empty<object>());
			UUIText text3 = base.GetText(4);
			if (text3 != null)
			{
				text3.SetText(activityRunData.GetMaxScore().ToString(), true);
			}
			string timeString = TimeUtil.Instance.GetTimeString((double)activityRunData.GetMiniTime());
			UUIText text4 = base.GetText(5);
			if (text4 != null)
			{
				text4.SetText(timeString.ToString(), true);
			}
		}
		base.GetText(17).ShowTextNew("ReadyToFightText");
	}

	// Token: 0x0600981A RID: 38938 RVA: 0x0020E2DC File Offset: 0x0020C4DC
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
		RedDotController.Instance.UnBindRedDot(ERedDotName.ActivityRun);
	}

	// Token: 0x040042DE RID: 17118
	private const int TIMERGAP = 1000;

	// Token: 0x040042DF RID: 17119
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x040042E0 RID: 17120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRunData> ActivityRunDataArray;

	// Token: 0x040042E1 RID: 17121
	[Nullable(2)]
	private ActivityRun CurrentActivity;

	// Token: 0x040042E2 RID: 17122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRunItem, int> TaskScroller;

	// Token: 0x040042E3 RID: 17123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ActivityRunCycleItem, int> ExhibitionView;

	// Token: 0x040042E4 RID: 17124
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040042E5 RID: 17125
	private readonly Func<ActivityRunItem> CreateTaskItem = () => new ActivityRunItem();

	// Token: 0x040042E6 RID: 17126
	private readonly Func<ActivityRunCycleItem> CreateActivityItem = () => new ActivityRunCycleItem();

	// Token: 0x040042E7 RID: 17127
	private bool IsLastShow;

	// Token: 0x02007B1B RID: 31515
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040287D1 RID: 165841
		public const int CaptionItem = 0;

		// Token: 0x040287D2 RID: 165842
		public const int LeftScroller = 1;

		// Token: 0x040287D3 RID: 165843
		public const int LeftItem = 2;

		// Token: 0x040287D4 RID: 165844
		public const int PnlRight = 3;

		// Token: 0x040287D5 RID: 165845
		public const int BestPointText = 4;

		// Token: 0x040287D6 RID: 165846
		public const int BestTimeText = 5;

		// Token: 0x040287D7 RID: 165847
		public const int BtnConfirm = 6;

		// Token: 0x040287D8 RID: 165848
		public const int RightScroller = 7;

		// Token: 0x040287D9 RID: 165849
		public const int RightItem = 8;

		// Token: 0x040287DA RID: 165850
		public const int LockContainer = 9;

		// Token: 0x040287DB RID: 165851
		public const int LockText = 10;

		// Token: 0x040287DC RID: 165852
		public const int BtnUp = 11;

		// Token: 0x040287DD RID: 165853
		public const int BtnDown = 12;

		// Token: 0x040287DE RID: 165854
		public const int UpRed = 13;

		// Token: 0x040287DF RID: 165855
		public const int DownRed = 14;

		// Token: 0x040287E0 RID: 165856
		public const int BestPointTextTitle = 15;

		// Token: 0x040287E1 RID: 165857
		public const int BestTimeTextTitle = 16;

		// Token: 0x040287E2 RID: 165858
		public const int TxtFunc = 17;
	}
}
