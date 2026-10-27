using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002BAC RID: 11180
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class TimeOfDayController : UiControllerBase
{
	// Token: 0x06017294 RID: 94868 RVA: 0x005DEEB4 File Offset: 0x005DD0B4
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
		EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<string>(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06017295 RID: 94869 RVA: 0x005DEF48 File Offset: 0x005DD148
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06017296 RID: 94870 RVA: 0x005DEFDC File Offset: 0x005DD1DC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SceneDateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSceneDateNotify));
		Net.Instance.Register(ENotifyMessageId.SyncSceneTimeNotify, new Action<IMessage, Net.CallbackStatus>(this.SyncSceneTimeNotify));
		Net.Instance.Register(ENotifyMessageId.TimeLockInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerTimeLock));
		Net.Instance.Register(ENotifyMessageId.TimeResetNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeResetNotify));
	}

	// Token: 0x06017297 RID: 94871 RVA: 0x005DF05C File Offset: 0x005DD25C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SceneDateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SyncSceneTimeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TimeLockInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TimeResetNotify);
	}

	// Token: 0x06017298 RID: 94872 RVA: 0x005DF0AC File Offset: 0x005DD2AC
	protected override void OnTick(float delta)
	{
		if (!this.TimeInitState || !this.EnterGameFlag || this.LoadingFlag || this.UiAnimFlag || TimeOfDayModel.Instance.TimeRunLockState)
		{
			return;
		}
		this.TickDelta += (double)delta;
		this.TimeFlow(this.TickDelta);
		this.TickDelta = 0.0;
	}

	// Token: 0x06017299 RID: 94873 RVA: 0x005DF110 File Offset: 0x005DD310
	private void OnEnterGame()
	{
		this.EnterGameFlag = true;
	}

	// Token: 0x0601729A RID: 94874 RVA: 0x005DF119 File Offset: 0x005DD319
	private void OnBeforeLoadMap()
	{
		this.LoadingFlag = true;
	}

	// Token: 0x0601729B RID: 94875 RVA: 0x005DF122 File Offset: 0x005DD322
	private void OnWorldDoneAndCloseLoading()
	{
		this.LoadingFlag = false;
		this.SyncGlobalGameTime(TimeOfDayModel.Instance.GameTime.Second, false);
	}

	// Token: 0x0601729C RID: 94876 RVA: 0x005DF141 File Offset: 0x005DD341
	private void OnPauseGame(int flag)
	{
		if (flag == 1)
		{
			this.PauseTime();
			return;
		}
		if (flag == 0)
		{
			this.ResumeTimeScale(true);
		}
	}

	// Token: 0x0601729D RID: 94877 RVA: 0x005DF158 File Offset: 0x005DD358
	private void OnLoginSuccess(string account)
	{
		TimeOfDayModel.Instance.PlayerAccount = account;
	}

	// Token: 0x0601729E RID: 94878 RVA: 0x005DF168 File Offset: 0x005DD368
	private void TimeFlow(double realTimeMillionSecond)
	{
		float num = GameModeModel.Instance.IsMulti ? 1f : TimeOfDayModel.Instance.TimeScale;
		double num2 = TodDayTime.ConvertFromRealTimeSecond(realTimeMillionSecond / 1000.0 * (double)num);
		if (num2 <= 0.0)
		{
			return;
		}
		this.SetTimeInternal(TimeOfDayModel.Instance.GameTime.Second + num2, true);
	}

	// Token: 0x0601729F RID: 94879 RVA: 0x005DF1CC File Offset: 0x005DD3CC
	private bool CheckCanOpenView()
	{
		if (Global.BaseCharacter == null)
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YZY, "时间找不到角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (GameModeController.Instance.IsInInstance() && !RecallQuestModel.Instance.IsInRecallInstance())
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YZY, "时间在副本", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YZY, "时间在联机", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		foreach (FGameplayTag tag in TimeOfDayConfig.Instance.GetBanGameplayTags())
		{
			CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
			bool flag;
			if (characterActorComponent == null)
			{
				flag = false;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				bool? flag2;
				if (entity == null)
				{
					flag2 = null;
				}
				else
				{
					BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
					flag2 = ((component != null) ? new bool?(component.HasTag(tag.TagId())) : null);
				}
				bool? flag3 = flag2;
				flag = flag3.GetValueOrDefault();
			}
			if (flag)
			{
				Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YZY, "时间在BanTag", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		if (TimeOfDayModel.Instance.TimeRunLockState)
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "时间被锁定", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x060172A0 RID: 94880 RVA: 0x005DF348 File Offset: 0x005DD548
	private void SetTimeInternal(double second, bool needCheckSendTimeToServer = true)
	{
		double second2 = second % 86400.0;
		TimeOfDayModel.Instance.GameTime.Second = second2;
		this.SyncGlobalGameTime(second2, false);
		this.SyncAudioRTPCDayTime(second2);
		EventSystem.Instance.Emit(EEventName.TodTimeChange);
		if (needCheckSendTimeToServer && !TimeOfDayModel.Instance.TimeSynLockState)
		{
			this.CheckDayChangeOrNeedSyncTimeToServer(second);
		}
	}

	// Token: 0x060172A1 RID: 94881 RVA: 0x005DF3A8 File Offset: 0x005DD5A8
	private void CheckDayChangeOrNeedSyncTimeToServer(double second)
	{
		double num = second;
		if (num > 86400.0)
		{
			num = 0.0;
		}
		ETodDayState dayState = TimeOfDayModel.Instance.GameTime.DayState;
		if (this.TempDayState != dayState)
		{
			this.TempDayState = dayState;
			EventSystem.Instance.Emit(EEventName.DayStateChange);
		}
		if ((Time.Instance.Now - this.SyncTime > 2000.0 && num - this.LastSyncSecond > 60.0) || this.LastSyncSecond > num)
		{
			this.SyncServerGameTime(num);
		}
		double num2 = Math.Floor(second / 3600.0);
		if (num2 < this.LastHour)
		{
			double num3 = Math.Floor((second - num2 * 3600.0) / 60.0);
			this.ChangeSceneTimeDateRequest(1U, (int)num2, (int)num3, SceneDateUpdateReason.TimeFlowAuto, false);
		}
		this.RecordLastHour((int)num2);
	}

	// Token: 0x060172A2 RID: 94882 RVA: 0x005DF490 File Offset: 0x005DD690
	public void SyncServerGameTime(double second)
	{
		if (GlobalData.World == null || (GameModeModel.Instance.IsMulti && !CreatureModel.Instance.IsMyWorld()))
		{
			return;
		}
		double num = Math.Floor(second / 3600.0);
		double num2 = Math.Floor((second - num * 3600.0) / 60.0);
		this.ChangeSceneTimeDateRequest(0U, (int)num, (int)num2, SceneDateUpdateReason.TimeFlowAuto, false);
		this.LastSyncSecond = second;
		this.SyncTime = Time.Instance.Now;
	}

	// Token: 0x060172A3 RID: 94883 RVA: 0x005DF50F File Offset: 0x005DD70F
	public void SyncGlobalGameTime(double second, bool fromAnimNeed = false)
	{
		if (!this.IsSyncToEngine)
		{
			return;
		}
		if (GlobalData.World == null)
		{
			return;
		}
		if (LoginModel.Instance.HasLoginPromise())
		{
			return;
		}
		UKuroRenderingRuntimeBPPluginBPLibrary.SetGlobalGITime(GlobalData.World, (float)TodDayTime.ConvertToHour(second));
	}

	// Token: 0x060172A4 RID: 94884 RVA: 0x005DF544 File Offset: 0x005DD744
	private void SyncAudioRTPCDayTime(double second)
	{
		if (GlobalData.World == null)
		{
			return;
		}
		double num = this.SyncEnvironmentTime - second;
		if (num > 360.0 || num < -360.0)
		{
			AudioSystem.Instance.SetRtpcValue("time", (float)TodDayTime.ConvertToHour(second), null);
			AudioSystem.Instance.SetRtpcValue("time_local", TimeUtil.Instance.GetHoursFloat(), null);
			this.SyncEnvironmentTime = second;
		}
	}

	// Token: 0x060172A5 RID: 94885 RVA: 0x005DF5C2 File Offset: 0x005DD7C2
	public void ChangeTimeScale(float timeScale)
	{
		TimeOfDayModel.Instance.SetTimeScale(timeScale, true);
	}

	// Token: 0x060172A6 RID: 94886 RVA: 0x005DF5D0 File Offset: 0x005DD7D0
	public void PauseTime()
	{
		TimeOfDayModel.Instance.SetTimeScale(0f, true);
	}

	// Token: 0x060172A7 RID: 94887 RVA: 0x005DF5E2 File Offset: 0x005DD7E2
	public void ResumeTimeScale(bool forceNormal = true)
	{
		TimeOfDayModel.Instance.SetTimeScale(forceNormal ? 1f : TimeOfDayModel.Instance.OldTimeScale, true);
	}

	// Token: 0x060172A8 RID: 94888 RVA: 0x005DF603 File Offset: 0x005DD803
	public void ForcePauseTime()
	{
		this.PauseTime();
		TimeOfDayModel.Instance.FreezeTimeScale = true;
	}

	// Token: 0x060172A9 RID: 94889 RVA: 0x005DF616 File Offset: 0x005DD816
	public void ForceResumeTime()
	{
		TimeOfDayModel.Instance.FreezeTimeScale = false;
		this.ResumeTimeScale(true);
	}

	// Token: 0x060172AA RID: 94890 RVA: 0x005DF62A File Offset: 0x005DD82A
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TimeOfDaySecondView, new Func<EUiViewName, object, bool>(this.CanOpenView), "TimeOfDayController.CanOpenView");
	}

	// Token: 0x060172AB RID: 94891 RVA: 0x005DF64C File Offset: 0x005DD84C
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TimeOfDaySecondView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x060172AC RID: 94892 RVA: 0x005DF669 File Offset: 0x005DD869
	public bool CanOpenView(EUiViewName viewName, object param)
	{
		return this.CanOpenView(viewName);
	}

	// Token: 0x060172AD RID: 94893 RVA: 0x005DF674 File Offset: 0x005DD874
	public bool CanOpenView(EUiViewName viewName)
	{
		if (!WeatherModel.Instance.CanSwitchWeather())
		{
			Log.Instance.Info(ELogModule.Weather, ELogAuthor.LJ, "天气切换中途禁止切换时间", default(ReadOnlySpan<ValueTuple<string, object>>));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(new ConfirmBoxDataNew(EConfirmBoxConfigId.WeatherCentralCooldownTips));
			return false;
		}
		if (!this.CheckCanOpenView())
		{
			ScrollingTipsController.Instance.ShowTipsById("TimeOfDayCantOpenView", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x060172AE RID: 94894 RVA: 0x005DF6E4 File Offset: 0x005DD8E4
	public unsafe void SyncSceneTime(double hour, double minute, long passedRealMillionSecond, bool showUi = false)
	{
		TimeOfDayModel.Instance.SetPassSceneTime(TimeOfDayModel.Instance.GameTime.Second);
		double num = hour * 60.0 * 60.0;
		double num2 = TodDayTime.ConvertFromMinute(minute);
		double num3 = num + num2;
		double num4 = 0.0;
		if (GameModeModel.Instance.IsMulti)
		{
			num4 = TodDayTime.ConvertFromRealTimeSecond((double)MathUtils.Instance.LongToBigInt(passedRealMillionSecond) / 1000.0 * (double)TimeOfDayModel.Instance.TimeScale);
		}
		this.TimeInitState = true;
		double setTime = num3 + num4;
		if (showUi)
		{
			TOpenViewCallBack <>9__1;
			UiManager.Instance.ResetToBattleView(delegate(bool success)
			{
				if (success)
				{
					ITimeOfDaySecondViewParam timeOfDaySecondViewParam = new TimeOfDaySecondViewParam
					{
						SetTime = setTime
					};
					UiManager instance2 = UiManager.Instance;
					EUiViewName timeOfDaySecondView = EUiViewName.TimeOfDaySecondView;
					object param = timeOfDaySecondViewParam;
					TOpenViewCallBack finishCallback;
					if ((finishCallback = <>9__1) == null)
					{
						finishCallback = (<>9__1 = delegate(bool succeed, int viewId)
						{
							if (!succeed)
							{
								this.SetTimeInternal(setTime, false);
							}
						});
					}
					instance2.OpenView(timeOfDaySecondView, param, finishCallback);
					return;
				}
				this.SetTimeInternal(setTime, false);
			});
		}
		else
		{
			this.SetTimeInternal(setTime, false);
		}
		this.SetTimeInternal(setTime, false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeOfDay;
		ELogAuthor author = ELogAuthor.FZX;
		string message = "服务器同步Tod时间";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("second", setTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("showUi", showUi);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060172AF RID: 94895 RVA: 0x005DF820 File Offset: 0x005DDA20
	public void AdjustTime(double second, SceneDateUpdateReason reason, uint addDay = 0U, bool needEmitTs = true)
	{
		if (GlobalData.World == null || (GameModeModel.Instance.IsMulti && !CreatureModel.Instance.IsMyWorld()))
		{
			return;
		}
		TimeOfDayModel.Instance.CacheTimeRecords();
		double num = Math.Floor(second / 3600.0);
		double num2 = Math.Floor((second - num * 3600.0) / 60.0);
		this.ChangeSceneTimeDateRequest(addDay, (int)num, (int)num2, reason, needEmitTs);
		this.SetTimeInternal(second, false);
		this.LastSyncSecond = second;
		this.RecordLastHour((int)num);
		EventSystem.Instance.Emit(EEventName.AdjustTime);
	}

	// Token: 0x060172B0 RID: 94896 RVA: 0x005DF8BC File Offset: 0x005DDABC
	private void ChangeSceneTimeDateRequest(uint addDay, int hour, int minute, SceneDateUpdateReason reason, bool needEmitTs = false)
	{
		if (GlobalData.World == null || (GameModeModel.Instance.IsMulti && !CreatureModel.Instance.IsMyWorld()))
		{
			return;
		}
		UpdateSceneDateRequest updateSceneDateRequest = UpdateSceneDateRequest.Create();
		updateSceneDateRequest.Hour = hour;
		updateSceneDateRequest.Minute = minute;
		updateSceneDateRequest.Reason = reason;
		updateSceneDateRequest.AddDays = addDay;
		Net.Instance.Call(ERequestMessageId.UpdateSceneDateRequest, updateSceneDateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			UpdateSceneDateResponse updateSceneDateResponse = (UpdateSceneDateResponse)msg;
			if (updateSceneDateResponse == null)
			{
				return;
			}
			if (updateSceneDateResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(updateSceneDateResponse.ErrorCode, 18163, null, true, true);
				return;
			}
			TimeOfDayModel.Instance.SetCurrentDay(updateSceneDateResponse.CurrDate);
		}, 0);
	}

	// Token: 0x060172B1 RID: 94897 RVA: 0x005DF940 File Offset: 0x005DDB40
	public bool CheckInMinuteSpan(int startMinute, int endMinute)
	{
		TTodTimeSpan minuteSpan = new TTodTimeSpan(startMinute, endMinute);
		return TodDayTime.CheckInMinuteSpan(TimeOfDayModel.Instance.GameTime.Minute, minuteSpan);
	}

	// Token: 0x060172B2 RID: 94898 RVA: 0x005DF96A File Offset: 0x005DDB6A
	public void AdjustTimeByMinute(int minute, SceneDateUpdateReason reason)
	{
		this.AdjustTime(TodDayTime.ConvertFromMinute((double)minute), reason, 0U, true);
	}

	// Token: 0x060172B3 RID: 94899 RVA: 0x005DF97C File Offset: 0x005DDB7C
	private void OnSceneDateNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		SceneDateNotify sceneDateNotify = (SceneDateNotify)msg;
		TimeOfDayModel.Instance.SetCurrentDay(sceneDateNotify.CurrDate);
	}

	// Token: 0x060172B4 RID: 94900 RVA: 0x005DF9A4 File Offset: 0x005DDBA4
	private void SyncSceneTimeNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		SyncSceneTimeNotify syncSceneTimeNotify = (SyncSceneTimeNotify)msg;
		SceneTimeInfo timeInfo = syncSceneTimeNotify.TimeInfo;
		this.SyncSceneTime((double)timeInfo.Hour, (double)timeInfo.Minute, timeInfo.OwnerTimeClockTimeSpan, syncSceneTimeNotify.ShowUi);
	}

	// Token: 0x060172B5 RID: 94901 RVA: 0x005DF9E0 File Offset: 0x005DDBE0
	private void OnServerTimeLock([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		TimeLockInfoNotify timeLockInfoNotify = (TimeLockInfoNotify)msg;
		if (timeLockInfoNotify.IsLock)
		{
			TimeOfDayModel.Instance.TimeRunLockStateServer = true;
			TimeOfDayModel.Instance.TimeRunLockStateServer = true;
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "[TimeRunLockState] 服务器通知锁定时间", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		else
		{
			TimeOfDayModel.Instance.TimeRunLockStateServer = false;
			TimeOfDayModel.Instance.TimeRunLockStateServer = false;
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.FZX, "[TimeRunLockState] 服务器通知解锁时间", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		double num = (double)MathUtils.Instance.LongToNumber(timeLockInfoNotify.Hour);
		double num2 = (double)MathUtils.Instance.LongToNumber(timeLockInfoNotify.Minute);
		if (num != -1.0 && num2 != -1.0)
		{
			double second = TodDayTime.ConvertFromHourMinute(num, num2);
			this.SetTimeInternal(second, false);
		}
	}

	// Token: 0x060172B6 RID: 94902 RVA: 0x005DFAB0 File Offset: 0x005DDCB0
	private void OnTimeResetNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		TimeResetNotify timeResetNotify = (TimeResetNotify)msg;
		if (timeResetNotify.ResetId == 1)
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YYZ, "[TimeResetNotify] 收到服务器4点跨天通知,触发跨天事件", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.CrossDay);
			return;
		}
		if (timeResetNotify.ResetId == 4)
		{
			Log.Instance.Info(ELogModule.TimeOfDay, ELogAuthor.YYZ, "[TimeResetNotify] 收到服务器0点跨天通知,触发跨天事件", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.CrossDayZone);
		}
	}

	// Token: 0x060172B7 RID: 94903 RVA: 0x005DFB2F File Offset: 0x005DDD2F
	public void SetUiAnimFlag(bool value)
	{
		this.UiAnimFlag = value;
	}

	// Token: 0x060172B8 RID: 94904 RVA: 0x005DFB38 File Offset: 0x005DDD38
	public void RecordLastHour(int hour)
	{
		if (this.LastHour != (double)hour)
		{
			this.LastHour = (double)hour;
			EventSystem.Instance.Emit(EEventName.CrossHour);
		}
	}

	// Token: 0x060172B9 RID: 94905 RVA: 0x005DFB5C File Offset: 0x005DDD5C
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060172BA RID: 94906 RVA: 0x005DFB5F File Offset: 0x005DDD5F
	private void TsRequestAdjustTime(double second, int reason, int addDay)
	{
		this.AdjustTime(second, (SceneDateUpdateReason)reason, (uint)addDay, false);
	}

	// Token: 0x060172BB RID: 94907 RVA: 0x005DFB6B File Offset: 0x005DDD6B
	private void TsRequestLockTimeRunStateClient(bool state)
	{
		TimeOfDayModel.Instance.SetTimeRunLockStateClient(state, false);
	}

	// Token: 0x060172BC RID: 94908 RVA: 0x005DFB79 File Offset: 0x005DDD79
	private void TsRequestLockTimeSyncLockStateClient(bool state)
	{
		TimeOfDayModel.Instance.SetTimeSyncLockStateClient(state, false);
	}

	// Token: 0x060172BD RID: 94909 RVA: 0x005DFB88 File Offset: 0x005DDD88
	private void TsRequestSetTimeScale(string scale)
	{
		float value;
		if (float.TryParse(scale, out value))
		{
			TimeOfDayModel.Instance.SetTimeScale(value, false);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TimeOfDay;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "TsRequestSetTimeScale转换失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scale", scale);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060172BE RID: 94910 RVA: 0x005DFBD3 File Offset: 0x005DDDD3
	private void TsResponseTimeCanOpenViewState(bool state)
	{
		this.CanOpenViewState = state;
	}

	// Token: 0x060172BF RID: 94911 RVA: 0x005DFBDC File Offset: 0x005DDDDC
	private void TsResponseSyncServerGameTime(double currentDay)
	{
		TimeOfDayModel.Instance.SetCurrentDay(currentDay);
	}

	// Token: 0x060172C0 RID: 94912 RVA: 0x005DFBE9 File Offset: 0x005DDDE9
	private void TsOnTimeEnterGame()
	{
		this.OnEnterGame();
	}

	// Token: 0x060172C1 RID: 94913 RVA: 0x005DFBF1 File Offset: 0x005DDDF1
	private void TsOnTimeBeforeLoadMap()
	{
		this.OnBeforeLoadMap();
	}

	// Token: 0x060172C2 RID: 94914 RVA: 0x005DFBF9 File Offset: 0x005DDDF9
	private void TsOnTimeWorldDone()
	{
		this.OnWorldDoneAndCloseLoading();
	}

	// Token: 0x060172C3 RID: 94915 RVA: 0x005DFC01 File Offset: 0x005DDE01
	private void TsSyncSceneTime(int hour, int minute, int passedRealMillionSecond)
	{
		this.SyncSceneTime((double)hour, (double)minute, (long)passedRealMillionSecond, false);
	}

	// Token: 0x060172C4 RID: 94916 RVA: 0x005DFC10 File Offset: 0x005DDE10
	private void TsSyncUseClientLockState(bool state)
	{
		TimeOfDayModel.Instance.SetUseClientLockState(state);
	}

	// Token: 0x17001F47 RID: 8007
	// (get) Token: 0x060172C5 RID: 94917 RVA: 0x005DFC1D File Offset: 0x005DDE1D
	public static TimeOfDayController Instance
	{
		get
		{
			return TimeOfDayController._Instance;
		}
	}

	// Token: 0x060172C6 RID: 94918 RVA: 0x005DFC24 File Offset: 0x005DDE24
	public static TimeOfDayController GetOrCreateInstance()
	{
		if (TimeOfDayController._Instance == null)
		{
			TimeOfDayController.CreateInstance();
		}
		return TimeOfDayController._Instance;
	}

	// Token: 0x060172C7 RID: 94919 RVA: 0x005DFC38 File Offset: 0x005DDE38
	public static bool CreateInstance()
	{
		if (TimeOfDayController._Instance != null)
		{
			return true;
		}
		TimeOfDayController._Instance = new TimeOfDayController();
		return true;
	}

	// Token: 0x060172C8 RID: 94920 RVA: 0x005DFC4E File Offset: 0x005DDE4E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060172C9 RID: 94921 RVA: 0x005DFC50 File Offset: 0x005DDE50
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayController._Instance = null;
	}

	// Token: 0x060172CA RID: 94922 RVA: 0x005DFC58 File Offset: 0x005DDE58
	static TimeOfDayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayController.CreateStaticDefaultValue), new Action(TimeOfDayController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AD51 RID: 44369
	private const int SENDTIMEGAP = 2000;

	// Token: 0x0400AD52 RID: 44370
	public bool IsSyncToEngine = true;

	// Token: 0x0400AD53 RID: 44371
	private double TickDelta;

	// Token: 0x0400AD54 RID: 44372
	private ETodDayState TempDayState = ETodDayState.Count;

	// Token: 0x0400AD55 RID: 44373
	private double SyncEnvironmentTime;

	// Token: 0x0400AD56 RID: 44374
	private double LastSyncSecond;

	// Token: 0x0400AD57 RID: 44375
	private double SyncTime;

	// Token: 0x0400AD58 RID: 44376
	private double LastHour;

	// Token: 0x0400AD59 RID: 44377
	private bool EnterGameFlag;

	// Token: 0x0400AD5A RID: 44378
	private bool LoadingFlag;

	// Token: 0x0400AD5B RID: 44379
	private bool UiAnimFlag;

	// Token: 0x0400AD5C RID: 44380
	private bool TimeInitState;

	// Token: 0x0400AD5D RID: 44381
	private const double CheckTimeGap = 360.0;

	// Token: 0x0400AD5E RID: 44382
	private bool CanOpenViewState;

	// Token: 0x0400AD5F RID: 44383
	[Nullable(2)]
	private static TimeOfDayController _Instance;
}
