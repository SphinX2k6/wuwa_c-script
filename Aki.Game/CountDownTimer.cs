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

// Token: 0x02001D95 RID: 7573
public class CountDownTimer : LogicTreeTimerBase
{
	// Token: 0x0600E5F2 RID: 58866 RVA: 0x00362BE0 File Offset: 0x00360DE0
	[NullableContext(1)]
	public CountDownTimer(long treeIncId, int nodeId, ETimerType timerType, ETimerUiType uiType, string uiTitle, double intervalTime) : base(treeIncId, timerType.ToEnumString(), true, intervalTime)
	{
		this.NodeId = nodeId;
		this.UiType = uiType;
		this.UiTitle = uiTitle;
	}

	// Token: 0x0600E5F3 RID: 58867 RVA: 0x00362C09 File Offset: 0x00360E09
	public override void Destroy()
	{
		this.EndShowTimer();
		this.EventsRegistered = false;
		base.Destroy();
	}

	// Token: 0x0600E5F4 RID: 58868 RVA: 0x00362C20 File Offset: 0x00360E20
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

	// Token: 0x0600E5F5 RID: 58869 RVA: 0x00362C94 File Offset: 0x00360E94
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

	// Token: 0x0600E5F6 RID: 58870 RVA: 0x00362D08 File Offset: 0x00360F08
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

	// Token: 0x0600E5F7 RID: 58871 RVA: 0x00362D94 File Offset: 0x00360F94
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

	// Token: 0x0600E5F8 RID: 58872 RVA: 0x00362DF4 File Offset: 0x00360FF4
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

	// Token: 0x0600E5F9 RID: 58873 RVA: 0x00362E24 File Offset: 0x00361024
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

	// Token: 0x0600E5FA RID: 58874 RVA: 0x00362E9C File Offset: 0x0036109C
	public override void EndShowTimer()
	{
		this.OnRemoveEvents();
		this.TryCloseCountDownUi();
	}

	// Token: 0x0600E5FB RID: 58875 RVA: 0x00362EAC File Offset: 0x003610AC
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

	// Token: 0x0600E5FC RID: 58876 RVA: 0x00362F58 File Offset: 0x00361158
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

	// Token: 0x0600E5FD RID: 58877 RVA: 0x00363034 File Offset: 0x00361234
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

	// Token: 0x0600E5FE RID: 58878 RVA: 0x003630C0 File Offset: 0x003612C0
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

	// Token: 0x0600E5FF RID: 58879 RVA: 0x00363274 File Offset: 0x00361474
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

	// Token: 0x0600E600 RID: 58880 RVA: 0x003633E4 File Offset: 0x003615E4
	private void OpenChallengeCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.CountDownChallenge) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			ChallengeCountDownViewParams param = new ChallengeCountDownViewParams(this.TimerEndTime, this.UiTitle);
			UiManager.Instance.OpenView(EUiViewName.CountDownChallenge, param, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600E601 RID: 58881 RVA: 0x00363438 File Offset: 0x00361638
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

	// Token: 0x0600E602 RID: 58882 RVA: 0x0036348C File Offset: 0x0036168C
	private void OpenGreatSwordCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.GreatSwordCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			ChallengeCountDownViewParams param = new ChallengeCountDownViewParams(this.TimerEndTime, this.UiTitle);
			UiManager.Instance.OpenView(EUiViewName.GreatSwordCountDownView, param, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600E603 RID: 58883 RVA: 0x003634E0 File Offset: 0x003616E0
	private void OpenMotorcycleCountDown(double remainTime)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.MotorcycleCountDownView) == null || GeneralLogicTreeModel.Instance.CountDownViewClosing)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleCountDownView, null, null);
		}
		this.NotifyTimerUiChange(remainTime);
	}

	// Token: 0x0600E604 RID: 58884 RVA: 0x00363518 File Offset: 0x00361718
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

	// Token: 0x0600E605 RID: 58885 RVA: 0x0036356C File Offset: 0x0036176C
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - (this.TimerStartTime + this.TimerRunningDelta)) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(Math.Max(val, 0.0), val2);
	}

	// Token: 0x0600E606 RID: 58886 RVA: 0x003635E0 File Offset: 0x003617E0
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

	// Token: 0x0600E607 RID: 58887 RVA: 0x003636CA File Offset: 0x003618CA
	private void OnFailRangeTimerStartShow()
	{
		this.TryCloseCountDownUi();
	}

	// Token: 0x0600E608 RID: 58888 RVA: 0x003636D2 File Offset: 0x003618D2
	private void OnFailRangeTimerEndShow()
	{
		this.TryOpenCountDownUi();
	}

	// Token: 0x04006A5E RID: 27230
	private const int GENERAL_TIP_ID = 19;

	// Token: 0x04006A5F RID: 27231
	private const int ONE_HUNDRED = 100;

	// Token: 0x04006A60 RID: 27232
	private double TimerEndTime;

	// Token: 0x04006A61 RID: 27233
	private double TimerPauseTime;

	// Token: 0x04006A62 RID: 27234
	private double TimerStartTime;

	// Token: 0x04006A63 RID: 27235
	private double TimerRunningDelta;

	// Token: 0x04006A64 RID: 27236
	private bool RequestedEnd;

	// Token: 0x04006A65 RID: 27237
	private double LastTickTime;

	// Token: 0x04006A66 RID: 27238
	private readonly ETimerUiType UiType;

	// Token: 0x04006A67 RID: 27239
	private readonly int NodeId;

	// Token: 0x04006A68 RID: 27240
	[Nullable(2)]
	private readonly string UiTitle;

	// Token: 0x04006A69 RID: 27241
	private bool EventsRegistered;
}
