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

// Token: 0x02000994 RID: 2452
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunView : UiTickViewBase
{
	// Token: 0x06006BDB RID: 27611 RVA: 0x00217524 File Offset: 0x00215724
	public ActivityRunView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006BDC RID: 27612 RVA: 0x00217584 File Offset: 0x00215784
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

	// Token: 0x06006BDD RID: 27613 RVA: 0x00217844 File Offset: 0x00215A44
	private void InitCaptionItem()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.CaptionItem.SetHelpCallBack(new Action(this.OnClickMoreButton));
		this.CaptionItem.SetTitle(this.CurrentActivity.GetTitle());
	}

	// Token: 0x06006BDE RID: 27614 RVA: 0x002178A8 File Offset: 0x00215AA8
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

	// Token: 0x06006BDF RID: 27615 RVA: 0x00217984 File Offset: 0x00215B84
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSelectActivityRunChallengeItem, new Action(this.OnSelectActivityRunChallengeItem));
		EventSystem.Instance.Add<ActivityRunCycleItem>(EEventName.OnClickActivityRunChallenge, new Action<ActivityRunCycleItem>(this.OnClickActivityRunChallenge));
		EventSystem.Instance.Add<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06006BE0 RID: 27616 RVA: 0x00217A04 File Offset: 0x00215C04
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectActivityRunChallengeItem, new Action(this.OnSelectActivityRunChallengeItem));
		EventSystem.Instance.Remove<ActivityRunCycleItem>(EEventName.OnClickActivityRunChallenge, new Action<ActivityRunCycleItem>(this.OnClickActivityRunChallenge));
		EventSystem.Instance.Remove<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06006BE1 RID: 27617 RVA: 0x00217A84 File Offset: 0x00215C84
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

	// Token: 0x06006BE2 RID: 27618 RVA: 0x00217ADF File Offset: 0x00215CDF
	private void OnSelectActivityRunChallengeItem()
	{
		this.RefreshTaskScroller();
		this.RefreshConfirmButton();
		this.RefreshPointText();
		this.RefreshContainer();
		this.RefreshCountDownText();
		this.PlaySwitchAnimation();
	}

	// Token: 0x06006BE3 RID: 27619 RVA: 0x00217B08 File Offset: 0x00215D08
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

	// Token: 0x06006BE4 RID: 27620 RVA: 0x00217B54 File Offset: 0x00215D54
	private void RefreshConfirmButton()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		base.GetButton(6).RootUIComp.Get().SetUIActive(activityRunData.GetIsShow());
	}

	// Token: 0x06006BE5 RID: 27621 RVA: 0x00217B9C File Offset: 0x00215D9C
	private void PlaySwitchAnimation()
	{
		if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
		{
			this.UiViewSequence.ReplaySequence("Switch");
			return;
		}
		this.UiViewSequence.PlaySequence("Switch", false, null);
	}

	// Token: 0x06006BE6 RID: 27622 RVA: 0x00217BE6 File Offset: 0x00215DE6
	private void OnClickActivityRunChallenge(ActivityRunCycleItem item)
	{
		this.ExhibitionView.ScrollToGridIndex(item.GridIndex, true);
	}

	// Token: 0x06006BE7 RID: 27623 RVA: 0x00217BFA File Offset: 0x00215DFA
	private void OnGetRunActivityReward(int i)
	{
		LoopScrollView<ActivityRunCycleItem, int> exhibitionView = this.ExhibitionView;
		if (exhibitionView == null)
		{
			return;
		}
		exhibitionView.RefreshAllGridProxies();
	}

	// Token: 0x06006BE8 RID: 27624 RVA: 0x00217C0C File Offset: 0x00215E0C
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

	// Token: 0x06006BE9 RID: 27625 RVA: 0x00217C7E File Offset: 0x00215E7E
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006BEA RID: 27626 RVA: 0x00217C87 File Offset: 0x00215E87
	private void OnClickMoreButton()
	{
		this.OpenHelpView();
	}

	// Token: 0x06006BEB RID: 27627 RVA: 0x00217C90 File Offset: 0x00215E90
	protected void OpenHelpView()
	{
		int helpId = this.CurrentActivity.GetHelpId();
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06006BEC RID: 27628 RVA: 0x00217CB4 File Offset: 0x00215EB4
	protected override void OnBeforeShow()
	{
		ActivityRunController.Instance.SelectDefaultChallengeId(this.CurrentActivity);
		this.RefreshActivityScroller();
		this.InitTimer();
	}

	// Token: 0x06006BED RID: 27629 RVA: 0x00217CD2 File Offset: 0x00215ED2
	private void InitTimer()
	{
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), 1000f, 1f, null, null, true);
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x00217D00 File Offset: 0x00215F00
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

	// Token: 0x06006BEF RID: 27631 RVA: 0x00217D78 File Offset: 0x00215F78
	private void RefreshCountDownText()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		if (!activityRunData.GetIsShow())
		{
			string remainTimeText = this.GetRemainTimeText(activityRunData.BeginOpenTime, "ActiveToOpenTime");
			base.GetText(10).SetText(remainTimeText, true);
		}
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x00217DC4 File Offset: 0x00215FC4
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

	// Token: 0x06006BF1 RID: 27633 RVA: 0x00217E5C File Offset: 0x0021605C
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

	// Token: 0x06006BF2 RID: 27634 RVA: 0x00217EC0 File Offset: 0x002160C0
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

	// Token: 0x06006BF3 RID: 27635 RVA: 0x00217EFC File Offset: 0x002160FC
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

	// Token: 0x06006BF4 RID: 27636 RVA: 0x0021801C File Offset: 0x0021621C
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
		RedDotController.Instance.UnBindRedDot(ERedDotName.ActivityRun);
	}

	// Token: 0x04004383 RID: 17283
	private const int TIMERGAP = 1000;

	// Token: 0x04004384 RID: 17284
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x04004385 RID: 17285
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRunData> ActivityRunDataArray;

	// Token: 0x04004386 RID: 17286
	[Nullable(2)]
	private ActivityRun CurrentActivity;

	// Token: 0x04004387 RID: 17287
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityRunItem, int> TaskScroller;

	// Token: 0x04004388 RID: 17288
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<ActivityRunCycleItem, int> ExhibitionView;

	// Token: 0x04004389 RID: 17289
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400438A RID: 17290
	private readonly Func<ActivityRunItem> CreateTaskItem = () => new ActivityRunItem();

	// Token: 0x0400438B RID: 17291
	private readonly Func<ActivityRunCycleItem> CreateActivityItem = () => new ActivityRunCycleItem();

	// Token: 0x0400438C RID: 17292
	private bool IsLastShow;

	// Token: 0x02006CA7 RID: 27815
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023B0F RID: 146191
		public const int CaptionItem = 0;

		// Token: 0x04023B10 RID: 146192
		public const int LeftScroller = 1;

		// Token: 0x04023B11 RID: 146193
		public const int LeftItem = 2;

		// Token: 0x04023B12 RID: 146194
		public const int PnlRight = 3;

		// Token: 0x04023B13 RID: 146195
		public const int BestPointText = 4;

		// Token: 0x04023B14 RID: 146196
		public const int BestTimeText = 5;

		// Token: 0x04023B15 RID: 146197
		public const int BtnConfirm = 6;

		// Token: 0x04023B16 RID: 146198
		public const int RightScroller = 7;

		// Token: 0x04023B17 RID: 146199
		public const int RightItem = 8;

		// Token: 0x04023B18 RID: 146200
		public const int LockContainer = 9;

		// Token: 0x04023B19 RID: 146201
		public const int LockText = 10;

		// Token: 0x04023B1A RID: 146202
		public const int BtnUp = 11;

		// Token: 0x04023B1B RID: 146203
		public const int BtnDown = 12;

		// Token: 0x04023B1C RID: 146204
		public const int UpRed = 13;

		// Token: 0x04023B1D RID: 146205
		public const int DownRed = 14;

		// Token: 0x04023B1E RID: 146206
		public const int BestPointTextTitle = 15;

		// Token: 0x04023B1F RID: 146207
		public const int BestTimeTextTitle = 16;

		// Token: 0x04023B20 RID: 146208
		public const int TxtFunc = 17;
	}
}
