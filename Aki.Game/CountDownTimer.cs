using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GeneralLogicTree.View.CountDown;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001257 RID: 4695
public class CountDownTimer : LogicTreeTimerBase
{
	// Token: 0x0600BA10 RID: 47632 RVA: 0x0036E840 File Offset: 0x0036CA40
	[NullableContext(1)]
	public CountDownTimer(long treeIncId, int nodeId, ETimerType timerType, ETimerUiType uiType, string uiTitle, double intervalTime) : base(treeIncId, timerType.ToEnumString(), true, intervalTime)
	{
		this.NodeId = nodeId;
		this.UiType = uiType;
		this.UiTitle = uiTitle;
	}

	// Token: 0x0600BA11 RID: 47633 RVA: 0x0036E869 File Offset: 0x0036CA69
	public override void Destroy()
	{
		this.EndShowTimer();
		this.EventsRegistered = false;
		base.Destroy();
	}

	// Token: 0x0600BA12 RID: 47634 RVA: 0x0036E880 File Offset: 0x0036CA80
	protected void OnAddEvents()
	{
		if (this.EventsRegistered)
		{
			return;
		}
		EventSystem.Instance.Add<long, ETimerType, TimerSetType, int>(EEventName.GeneralLogicTreeTimerInfoChanged, new Action<long, ETimerType, TimerSetType, int>(this.OnTimerInfoChanged));
		EventSystem.Instance.Add(EEventName.FailRangeTimerStartShow, new Action(this.OnFailRangeTimerStartShow));
		EventSystem.Instance.Add(EEventName.FailRangeTimerEndShow, new Action(this.OnFailRangeTimerEndShow));
		this.EventsRegistered = true;
	}

	// Token: 0x0600BA13 RID: 47635 RVA: 0x0036E8F4 File Offset: 0x0036CAF4
	protected void OnRemoveEvents()
	{
		if (!this.EventsRegistered)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.GeneralLogicTreeTimerInfoChanged, new Action<long, ETimerType, TimerSetType, int>(this.OnTimerInfoChanged));
		EventSystem.Instance.Remove(EEventName.FailRangeTimerStartShow, new Action(this.OnFailRangeTimerStartShow));
		EventSystem.Instance.Remove(EEventName.FailRangeTimerEndShow, new Action(this.OnFailRangeTimerEndShow));
		this.EventsRegistered = false;
	}

	// Token: 0x0600BA14 RID: 47636 RVA: 0x0036E968 File Offset: 0x0036CB68
	private void OnTimerInfoChanged(long treeIncId, ETimerType timerType, TimerSetType setType, int seconds)
	{
		if (treeIncId == 0L || treeIncId != this.TreeId || this.InnerTimerType != timerType.ToEnumString())
		{
			return;
		}
		int num = seconds * 1000;
		switch (setType)
		{
		case TimerSetType.Add:
			this.TimerEndTime += (double)num;
			break;
		case TimerSetType.Sub:
			this.TimerEndTime -= (double)num;
			break;
		case TimerSetType.Set:
			this.TimerEndTime = TimeUtil.Instance.GetServerTimeStamp() + (double)num;
			break;
		}
		this.NotifyTimerUiChange(this.GetRemainTime());
	}

	// Token: 0x0600BA15 RID: 47637 RVA: 0x0036E9F4 File Offset: 0x0036CBF4
	protected override void OnTick(float delta)
	{
		double serverStopTimeStamp = TimeUtil.Instance.GetServerStopTimeStamp();
		double num = serverStopTimeStamp - this.LastTickTime;
		this.LastTickTime = serverStopTimeStamp;
		this.TimerRunningDelta += num;
		double remainTime = this.GetRemainTime();
		if (remainTime < 0.0)
		{
			this.RequestTimerEnd();
			return;
		}
		if (this.UiType != ETimerUiType.HideUi)
		{
			this.NotifyTimerUiChange(remainTime);
		}
	}

	// Token: 0x0600BA16 RID: 47638 RVA: 0x0036EA54 File Offset: 0x0036CC54
	private void RequestTimerEnd()
	{
		if (this.RequestedEnd)
		{
			return;
		}
		this.RequestedEnd = true;
		this.EndShowTimer();
		GeneralLogicTreeController.Instance.RequestTimerEnd(this.TreeId, base.TimerType);
	}

	// Token: 0x0600BA17 RID: 47639 RVA: 0x0036EA84 File Offset: 0x0036CC84
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		if (endTime == 0.0)
		{
			return;
		}
		this.TimerEndTime = endTime;
		this.TimerPauseTime = pauseTime;
		this.TimerStartTime = TimeUtil.Instance.GetServerStopTimeStamp();
		this.TimerRunningDelta = 0.0;
		this.LastTickTime = this.TimerStartTime;
		GeneralLogicTreeModel.Instance.SetTimerUiOwnerId(this.TreeId);
		if (this.UiType != ETimerUiType.HideUi)
		{
			this.TryOpenCountDownUi();
		}
		this.OnAddEvents();
	}

	// Token: 0x0600BA18 RID: 47640 RVA: 0x0036EAFC File Offset: 0x0036CCFC
	public override void EndShowTimer()
	{
		this.OnRemoveEvents();
		this.TryCloseCountDownUi();
	}

	// Token: 0x0600BA19 RID: 47641 RVA: 0x0036EB0C File Offset: 0x0036CD0C
	private void TryOpenCountDownUi()
	{
		Dictionary<ETimerUiType, int> countDownTimerViewMap = GeneralLogicTreeModel.Instance.CountDownTimerViewMap;
		int? num = (countDownTimerViewMap != null) ? countDownTimerViewMap.GetValueOrNull(this.UiType) : null;
		if (num == null)
		{
			this.OpenCountDownUi();
			return;
		}
		if (num.Value == this.NodeId)
		{
			this.NotifyTimerUiChange(this.GetRemainTime());
			return;
		}
		Dictionary<ETimerUiType, List<ValueTuple<int, Action>>> countDownTimerFuncMap = GeneralLogicTreeModel.Instance.CountDownTimerFuncMap;
		if (countDownTimerFuncMap != null)
		{
			List<ValueTuple<int, Action>> list;
			if (!countDownTimerFuncMap.TryGetValue(this.UiType, out list))
			{
				list = (countDownTimerFuncMap[this.UiType] = new List<ValueTuple<int, Action>>());
			}
			list.Add(new ValueTuple<int, Action>(this.NodeId, new Action(this.TryOpenCountDownUi)));
		}
	}

	// Token: 0x0600BA1A RID: 47642 RVA: 0x0036EBB8 File Offset: 0x0036CDB8
	private void TryCloseCountDownUi()
	{
		Dictionary<ETimerUiType, int> countDownTimerViewMap = GeneralLogicTreeModel.Instance.CountDownTimerViewMap;
		int? num = (countDownTimerViewMap != null) ? new int?(countDownTimerViewMap.GetValueOrDefault(this.UiType)) : null;
		if (num == null)
		{
			return;
		}
		int? num2 = num;
		int nodeId = this.NodeId;
		if (num2.GetValueOrDefault() == nodeId & num2 != null)
		{
			this.NotifyTimerUiChange(0.0);
			return;
		}
		Dictionary<ETimerUiType, List<ValueTuple<int, Action>>> countDownTimerFuncMap = GeneralLogicTreeModel.Instance.CountDownTimerFuncMap;
		List<ValueTuple<int, Action>> list = (countDownTimerFuncMap != null) ? countDownTimerFuncMap.GetValueOrDefault(this.UiType) : null;
		if (list == null || list.Count == 0)
		{
			return;
		}
		int num3 = list.IndexOf((ValueTuple<int, Action> x) => x.Item1 == this.NodeId);
		if (num3 > 0)
		{
			list.RemoveAt(num3);
		}
		if (list.Count == 0)
		{
			Dictionary<ETimerUiType, List<ValueTuple<int, Action>>> countDownTimerFuncMap2 = GeneralLogicTreeModel.Instance.CountDownTimerFuncMap;
			if (countDownTimerFuncMap2 == null)
			{
				return;
			}
			countDownTimerFuncMap2.Remove(this.UiType);
		}
	}

	// Token: 0x0600BA1B RID: 47643 RVA: 0x0036EC94 File Offset: 0x0036CE94
	private void OpenNextCountDownUi()
	{
		Dictionary<ETimerUiType, int> countDownTimerViewMap = GeneralLogicTreeModel.Instance.CountDownTimerViewMap;
		if (countDownTimerViewMap != null)
		{
			countDownTimerViewMap.Remove(this.UiType);
		}
		Dictionary<ETimerUiType, List<ValueTuple<int, Action>>> countDownTimerFuncMap = GeneralLogicTreeModel.Instance.CountDownTimerFuncMap;
		List<ValueTuple<int, Action>> list = (countDownTimerFuncMap != null) ? countDownTimerFuncMap.GetValueOrDefault(this.UiType) : null;
		if (list == null || list.Count == 0)
		{
			return;
		}
		ValueTuple<int, Action> valueTuple;
		if (list.TryPop(out valueTuple))
		{
			valueTuple.Item2();
		}
		if (list.Count == 0)
		{
			Dictionary<ETimerUiType, List<ValueTuple<int, Action>>> countDownTimerFuncMap2 = GeneralLogicTreeModel.Instance.CountDownTimerFuncMap;
			if (countDownTimerFuncMap2 == null)
			{
				return;
			}
			countDownTimerFuncMap2.Remove(this.UiType);
		}
	}

	// Token: 0x0600BA1C RID: 47644 RVA: 0x0036ED20 File Offset: 0x0036CF20
	private unsafe void OpenCountDownUi()
	{
		double remainTime = this.GetRemainTime();
		if (remainTime <= 0.0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GamePlayTimer;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "倒计时剩余时间不足";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("开始时间", this.TimerStartTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("结束时间", this.TimerEndTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("treeIncId", this.TreeId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		Dictionary<ETimerUiType, int> countDownTimerViewMap = GeneralLogicTreeModel.Instance.CountDownTimerViewMap;
		if (countDownTimerViewMap != null)
		{
			countDownTimerViewMap[this.UiType] = this.NodeId;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.GamePlayTimer;
		ELogAuthor author2 = ELogAuthor.YSQ;
		string message2 = "倒计时开始";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("开始时间", this.TimerStartTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("结束时间", this.TimerEndTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("treeIncId", this.TreeId);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		switch (this.UiType)
		{
		case ETimerUiType.Default:
			this.OpenDefaultPromptCountDown(remainTime);
			return;
		case ETimerUiType.CountDownChallengeBlackCoast:
			this.OpenChallengeCountDown(remainTime);
			return;
		case ETimerUiType.HideUi:
			break;
		case ETimerUiType.CountDownChallengeSlashAndTower:
			this.OpenShipTowerCountDown(remainTime);
			return;
		case ETimerUiType.GreatSwordChallenge:
			this.OpenGreatSwordCountDown(remainTime);
			return;
		case ETimerUiType.StoveCoreFall:
			this.OpenMotorcycleCountDown(remainTime);
			return;
		case ETimerUiType.RebeccaChallenge:
			this.OpenCyberpunkCountDown(remainTime);
			break;
		default:
			return;
		}
	}

	// Token: 0x0600BA1D RID: 47645 RVA: 0x0036EED4 File Offset: 0x0036D0D4
	private void OpenDefaultPromptCountDown(double remainTime)
	{
		GenericPrompt? promptInfo = GenericPromptConfig.Instance.GetPromptInfo(19);
		string[] array = new string[3];
		double num = Math.Floor(remainTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
		double num2 = Math.Floor(remainTime % TimeUtil.Instance.Minute);
		double num3 = Math.Floor((remainTime - Math.Floor(remainTime)) * 100.0);
		string[] array2 = array;
		int num4 = 0;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num < 10.0) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<double>(num);
		array2[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
		string[] array3 = array;
		int num5 = 1;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num2 < 10.0) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<double>(num2);
		array3[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
		string[] array4 = array;
		int num6 = 2;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted((num3 < 10.0) ? "0" : "");
		defaultInterpolatedStringHandler.AppendFormatted<double>(num3);
		array4[num6] = defaultInterpolatedStringHandler.ToStringAndClear();
		if (UiManager.Instance.GetViewByName(EUiViewName.CountDownFloatTips) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			GenericPromptController.Instance.ShowPromptByItsType<object>((EPromptSubViewType)promptInfo.Value.TypeId, null, null, null, array, new int?(19), null, null, null, false, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA1E RID: 47646 RVA: 0x0036F044 File Offset: 0x0036D244
	private void OpenChallengeCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.CountDownChallenge) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			ChallengeCountDownViewParams param = new ChallengeCountDownViewParams(this.TimerEndTime, this.UiTitle);
			UiManager.Instance.OpenView(EUiViewName.CountDownChallenge, param, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA1F RID: 47647 RVA: 0x0036F098 File Offset: 0x0036D298
	private void OpenShipTowerCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.ShipTowerCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			UiManager.Instance.OpenView(EUiViewName.ShipTowerCountDownView, new ShipTowerCountDownView.Params
			{
				EndTime = this.TimerEndTime
			}, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA20 RID: 47648 RVA: 0x0036F0EC File Offset: 0x0036D2EC
	private void OpenGreatSwordCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.GreatSwordCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			ChallengeCountDownViewParams param = new ChallengeCountDownViewParams(this.TimerEndTime, this.UiTitle);
			UiManager.Instance.OpenView(EUiViewName.GreatSwordCountDownView, param, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA21 RID: 47649 RVA: 0x0036F140 File Offset: 0x0036D340
	private void OpenMotorcycleCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.MotorcycleCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleCountDownView, null, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA22 RID: 47650 RVA: 0x0036F178 File Offset: 0x0036D378
	private void OpenCyberpunkCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.CyberpunkCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			SimpleLogicTreeCountDownViewParam param = new SimpleLogicTreeCountDownViewParam
			{
				Title = this.UiTitle
			};
			UiManager.Instance.OpenView(EUiViewName.CyberpunkCountDownView, param, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x0036F1CC File Offset: 0x0036D3CC
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - (this.TimerStartTime + this.TimerRunningDelta)) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(Math.Max(val, 0.0), val2);
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x0036F240 File Offset: 0x0036D440
	private void NotifyTimerUiChange(double remainTime)
	{
		if (!GeneralLogicTreeModel.Instance.IsTimerUiOwner(this.TreeId))
		{
			return;
		}
		EUiViewName euiViewName = EUiViewName.CountDownFloatTips;
		switch (this.UiType)
		{
		case ETimerUiType.Default:
			euiViewName = EUiViewName.CountDownFloatTips;
			break;
		case ETimerUiType.CountDownChallengeBlackCoast:
			euiViewName = EUiViewName.CountDownChallenge;
			break;
		case ETimerUiType.CountDownChallengeSlashAndTower:
			euiViewName = EUiViewName.ShipTowerCountDownView;
			break;
		case ETimerUiType.GreatSwordChallenge:
			euiViewName = EUiViewName.GreatSwordCountDownView;
			break;
		case ETimerUiType.StoveCoreFall:
			euiViewName = EUiViewName.MotorcycleCountDownView;
			break;
		case ETimerUiType.RebeccaChallenge:
			euiViewName = EUiViewName.CyberpunkCountDownView;
			break;
		}
		UiViewBase viewByName = UiManager.Instance.GetViewByName(euiViewName);
		if (viewByName == null)
		{
			this.OpenNextCountDownUi();
			return;
		}
		if (remainTime != 0.0)
		{
			EventSystem.Instance.Emit<double, double>(EEventName.OnGamePlayCdChanged, remainTime, this.TimerEndTime);
			return;
		}
		if (viewByName.ClosePromise != null)
		{
			this.OpenNextCountDownUi();
			return;
		}
		GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
		UiManager.Instance.CloseView(euiViewName, delegate(bool success)
		{
			if (success)
			{
				GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
				this.OpenNextCountDownUi();
			}
		});
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x0036F32A File Offset: 0x0036D52A
	private void OnFailRangeTimerStartShow()
	{
		this.TryCloseCountDownUi();
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x0036F332 File Offset: 0x0036D532
	private void OnFailRangeTimerEndShow()
	{
		this.TryOpenCountDownUi();
	}

	// Token: 0x04006B3F RID: 27455
	private const int GENERAL_TIP_ID = 19;

	// Token: 0x04006B40 RID: 27456
	private const int ONE_HUNDRED = 100;

	// Token: 0x04006B41 RID: 27457
	private double TimerEndTime;

	// Token: 0x04006B42 RID: 27458
	private double TimerPauseTime;

	// Token: 0x04006B43 RID: 27459
	private double TimerStartTime;

	// Token: 0x04006B44 RID: 27460
	private double TimerRunningDelta;

	// Token: 0x04006B45 RID: 27461
	private bool RequestedEnd;

	// Token: 0x04006B46 RID: 27462
	private double LastTickTime;

	// Token: 0x04006B47 RID: 27463
	private readonly ETimerUiType UiType;

	// Token: 0x04006B48 RID: 27464
	private readonly int NodeId;

	// Token: 0x04006B49 RID: 27465
	[Nullable(2)]
	private readonly string UiTitle;

	// Token: 0x04006B4A RID: 27466
	private bool EventsRegistered;
}
