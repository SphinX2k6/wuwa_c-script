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

// Token: 0x02002128 RID: 8488
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class TimeOfDayController : UiControllerBase
{
	// Token: 0x06014CC5 RID: 85189 RVA: 0x0060BA88 File Offset: 0x00609C88
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
		EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Add<string>(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06014CC6 RID: 85190 RVA: 0x0060BB1C File Offset: 0x00609D1C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
		EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
		EventSystem.Instance.Remove(EEventName.LoginSuccess, new Action<string>(this.OnLoginSuccess));
		EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06014CC7 RID: 85191 RVA: 0x0060BBB0 File Offset: 0x00609DB0
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SceneDateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSceneDateNotify));
		Net.Instance.Register(ENotifyMessageId.SyncSceneTimeNotify, new Action<IMessage, Net.CallbackStatus>(this.SyncSceneTimeNotify));
		Net.Instance.Register(ENotifyMessageId.TimeLockInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnServerTimeLock));
		Net.Instance.Register(ENotifyMessageId.TimeResetNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimeResetNotify));
	}

	// Token: 0x06014CC8 RID: 85192 RVA: 0x0060BC30 File Offset: 0x00609E30
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SceneDateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SyncSceneTimeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TimeLockInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TimeResetNotify);
	}

	// Token: 0x06014CC9 RID: 85193 RVA: 0x0060BC80 File Offset: 0x00609E80
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

	// Token: 0x06014CCA RID: 85194 RVA: 0x0060BCE4 File Offset: 0x00609EE4
	private void OnEnterGame()
	{
		this.EnterGameFlag = true;
	}

	// Token: 0x06014CCB RID: 85195 RVA: 0x0060BCED File Offset: 0x00609EED
	private void OnBeforeLoadMap()
	{
		this.LoadingFlag = true;
	}

	// Token: 0x06014CCC RID: 85196 RVA: 0x0060BCF6 File Offset: 0x00609EF6
	private void OnWorldDoneAndCloseLoading()
	{
		this.LoadingFlag = false;
		this.SyncGlobalGameTime(TimeOfDayModel.Instance.GameTime.Second, false);
	}

	// Token: 0x06014CCD RID: 85197 RVA: 0x0060BD15 File Offset: 0x00609F15
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

	// Token: 0x06014CCE RID: 85198 RVA: 0x0060BD2C File Offset: 0x00609F2C
	private void OnLoginSuccess(string account)
	{
		TimeOfDayModel.Instance.PlayerAccount = account;
	}

	// Token: 0x06014CCF RID: 85199 RVA: 0x0060BD3C File Offset: 0x00609F3C
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

	// Token: 0x06014CD0 RID: 85200 RVA: 0x0060BDA0 File Offset: 0x00609FA0
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

	// Token: 0x06014CD1 RID: 85201 RVA: 0x0060BF1C File Offset: 0x0060A11C
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

	// Token: 0x06014CD2 RID: 85202 RVA: 0x0060BF7C File Offset: 0x0060A17C
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

	// Token: 0x06014CD3 RID: 85203 RVA: 0x0060C064 File Offset: 0x0060A264
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

	// Token: 0x06014CD4 RID: 85204 RVA: 0x0060C0E3 File Offset: 0x0060A2E3
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

	// Token: 0x06014CD5 RID: 85205 RVA: 0x0060C118 File Offset: 0x0060A318
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

	// Token: 0x06014CD6 RID: 85206 RVA: 0x0060C196 File Offset: 0x0060A396
	public void ChangeTimeScale(float timeScale)
	{
		TimeOfDayModel.Instance.SetTimeScale(timeScale, true);
	}

	// Token: 0x06014CD7 RID: 85207 RVA: 0x0060C1A4 File Offset: 0x0060A3A4
	public void PauseTime()
	{
		TimeOfDayModel.Instance.SetTimeScale(0f, true);
	}

	// Token: 0x06014CD8 RID: 85208 RVA: 0x0060C1B6 File Offset: 0x0060A3B6
	public void ResumeTimeScale(bool forceNormal = true)
	{
		TimeOfDayModel.Instance.SetTimeScale(forceNormal ? 1f : TimeOfDayModel.Instance.OldTimeScale, true);
	}

	// Token: 0x06014CD9 RID: 85209 RVA: 0x0060C1D7 File Offset: 0x0060A3D7
	public void ForcePauseTime()
	{
		this.PauseTime();
		TimeOfDayModel.Instance.FreezeTimeScale = true;
	}

	// Token: 0x06014CDA RID: 85210 RVA: 0x0060C1EA File Offset: 0x0060A3EA
	public void ForceResumeTime()
	{
		TimeOfDayModel.Instance.FreezeTimeScale = false;
		this.ResumeTimeScale(true);
	}

	// Token: 0x06014CDB RID: 85211 RVA: 0x0060C1FE File Offset: 0x0060A3FE
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TimeOfDaySecondView, new Func<EUiViewName, object, bool>(this.CanOpenView), "TimeOfDayController.CanOpenView");
	}

	// Token: 0x06014CDC RID: 85212 RVA: 0x0060C220 File Offset: 0x0060A420
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TimeOfDaySecondView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x06014CDD RID: 85213 RVA: 0x0060C23D File Offset: 0x0060A43D
	public bool CanOpenView(EUiViewName viewName, object param)
	{
		return this.CanOpenView(viewName);
	}

	// Token: 0x06014CDE RID: 85214 RVA: 0x0060C248 File Offset: 0x0060A448
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

	// Token: 0x06014CDF RID: 85215 RVA: 0x0060C2B8 File Offset: 0x0060A4B8
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

	// Token: 0x06014CE0 RID: 85216 RVA: 0x0060C3F4 File Offset: 0x0060A5F4
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

	// Token: 0x06014CE1 RID: 85217 RVA: 0x0060C490 File Offset: 0x0060A690
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(updateSceneDateResponse.ErrorCode, 24289, null, true, true);
				return;
			}
			TimeOfDayModel.Instance.SetCurrentDay(updateSceneDateResponse.CurrDate);
		}, 0);
	}

	// Token: 0x06014CE2 RID: 85218 RVA: 0x0060C514 File Offset: 0x0060A714
	public bool CheckInMinuteSpan(int startMinute, int endMinute)
	{
		TTodTimeSpan minuteSpan = new TTodTimeSpan(startMinute, endMinute);
		return TodDayTime.CheckInMinuteSpan(TimeOfDayModel.Instance.GameTime.Minute, minuteSpan);
	}

	// Token: 0x06014CE3 RID: 85219 RVA: 0x0060C53E File Offset: 0x0060A73E
	public void AdjustTimeByMinute(int minute, SceneDateUpdateReason reason)
	{
		this.AdjustTime(TodDayTime.ConvertFromMinute((double)minute), reason, 0U, true);
	}

	// Token: 0x06014CE4 RID: 85220 RVA: 0x0060C550 File Offset: 0x0060A750
	private void OnSceneDateNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		SceneDateNotify sceneDateNotify = (SceneDateNotify)msg;
		TimeOfDayModel.Instance.SetCurrentDay(sceneDateNotify.CurrDate);
	}

	// Token: 0x06014CE5 RID: 85221 RVA: 0x0060C578 File Offset: 0x0060A778
	private void SyncSceneTimeNotify([Nullable(2)] IMessage msg, Net.CallbackStatus status)
	{
		SyncSceneTimeNotify syncSceneTimeNotify = (SyncSceneTimeNotify)msg;
		SceneTimeInfo timeInfo = syncSceneTimeNotify.TimeInfo;
		this.SyncSceneTime((double)timeInfo.Hour, (double)timeInfo.Minute, timeInfo.OwnerTimeClockTimeSpan, syncSceneTimeNotify.ShowUi);
	}

	// Token: 0x06014CE6 RID: 85222 RVA: 0x0060C5B4 File Offset: 0x0060A7B4
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

	// Token: 0x06014CE7 RID: 85223 RVA: 0x0060C684 File Offset: 0x0060A884
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

	// Token: 0x06014CE8 RID: 85224 RVA: 0x0060C703 File Offset: 0x0060A903
	public void SetUiAnimFlag(bool value)
	{
		this.UiAnimFlag = value;
	}

	// Token: 0x06014CE9 RID: 85225 RVA: 0x0060C70C File Offset: 0x0060A90C
	public void RecordLastHour(int hour)
	{
		if (this.LastHour != (double)hour)
		{
			this.LastHour = (double)hour;
			EventSystem.Instance.Emit(EEventName.CrossHour);
		}
	}

	// Token: 0x06014CEA RID: 85226 RVA: 0x0060C730 File Offset: 0x0060A930
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06014CEB RID: 85227 RVA: 0x0060C733 File Offset: 0x0060A933
	private void TsRequestAdjustTime(double second, int reason, int addDay)
	{
		this.AdjustTime(second, (SceneDateUpdateReason)reason, (uint)addDay, false);
	}

	// Token: 0x06014CEC RID: 85228 RVA: 0x0060C73F File Offset: 0x0060A93F
	private void TsRequestLockTimeRunStateClient(bool state)
	{
		TimeOfDayModel.Instance.SetTimeRunLockStateClient(state, false);
	}

	// Token: 0x06014CED RID: 85229 RVA: 0x0060C74D File Offset: 0x0060A94D
	private void TsRequestLockTimeSyncLockStateClient(bool state)
	{
		TimeOfDayModel.Instance.SetTimeSyncLockStateClient(state, false);
	}

	// Token: 0x06014CEE RID: 85230 RVA: 0x0060C75C File Offset: 0x0060A95C
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

	// Token: 0x06014CEF RID: 85231 RVA: 0x0060C7A7 File Offset: 0x0060A9A7
	private void TsResponseTimeCanOpenViewState(bool state)
	{
		this.CanOpenViewState = state;
	}

	// Token: 0x06014CF0 RID: 85232 RVA: 0x0060C7B0 File Offset: 0x0060A9B0
	private void TsResponseSyncServerGameTime(double currentDay)
	{
		TimeOfDayModel.Instance.SetCurrentDay(currentDay);
	}

	// Token: 0x06014CF1 RID: 85233 RVA: 0x0060C7BD File Offset: 0x0060A9BD
	private void TsOnTimeEnterGame()
	{
		this.OnEnterGame();
	}

	// Token: 0x06014CF2 RID: 85234 RVA: 0x0060C7C5 File Offset: 0x0060A9C5
	private void TsOnTimeBeforeLoadMap()
	{
		this.OnBeforeLoadMap();
	}

	// Token: 0x06014CF3 RID: 85235 RVA: 0x0060C7CD File Offset: 0x0060A9CD
	private void TsOnTimeWorldDone()
	{
		this.OnWorldDoneAndCloseLoading();
	}

	// Token: 0x06014CF4 RID: 85236 RVA: 0x0060C7D5 File Offset: 0x0060A9D5
	private void TsSyncSceneTime(int hour, int minute, int passedRealMillionSecond)
	{
		this.SyncSceneTime((double)hour, (double)minute, (long)passedRealMillionSecond, false);
	}

	// Token: 0x06014CF5 RID: 85237 RVA: 0x0060C7E4 File Offset: 0x0060A9E4
	private void TsSyncUseClientLockState(bool state)
	{
		TimeOfDayModel.Instance.SetUseClientLockState(state);
	}

	// Token: 0x17001F9F RID: 8095
	// (get) Token: 0x06014CF6 RID: 85238 RVA: 0x0060C7F1 File Offset: 0x0060A9F1
	public static TimeOfDayController Instance
	{
		get
		{
			return TimeOfDayController._Instance;
		}
	}

	// Token: 0x06014CF7 RID: 85239 RVA: 0x0060C7F8 File Offset: 0x0060A9F8
	public static TimeOfDayController GetOrCreateInstance()
	{
		if (TimeOfDayController._Instance == null)
		{
			TimeOfDayController.CreateInstance();
		}
		return TimeOfDayController._Instance;
	}

	// Token: 0x06014CF8 RID: 85240 RVA: 0x0060C80C File Offset: 0x0060AA0C
	public static bool CreateInstance()
	{
		if (TimeOfDayController._Instance != null)
		{
			return true;
		}
		TimeOfDayController._Instance = new TimeOfDayController();
		return true;
	}

	// Token: 0x06014CF9 RID: 85241 RVA: 0x0060C822 File Offset: 0x0060AA22
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014CFA RID: 85242 RVA: 0x0060C824 File Offset: 0x0060AA24
	public static void ResetStaticDefaultValue()
	{
		TimeOfDayController._Instance = null;
	}

	// Token: 0x06014CFB RID: 85243 RVA: 0x0060C82C File Offset: 0x0060AA2C
	static TimeOfDayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeOfDayController.CreateStaticDefaultValue), new Action(TimeOfDayController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B158 RID: 45400
	private const int SENDTIMEGAP = 2000;

	// Token: 0x0400B159 RID: 45401
	public bool IsSyncToEngine = true;

	// Token: 0x0400B15A RID: 45402
	private double TickDelta;

	// Token: 0x0400B15B RID: 45403
	private ETodDayState TempDayState = ETodDayState.Count;

	// Token: 0x0400B15C RID: 45404
	private double SyncEnvironmentTime;

	// Token: 0x0400B15D RID: 45405
	private double LastSyncSecond;

	// Token: 0x0400B15E RID: 45406
	private double SyncTime;

	// Token: 0x0400B15F RID: 45407
	private double LastHour;

	// Token: 0x0400B160 RID: 45408
	private bool EnterGameFlag;

	// Token: 0x0400B161 RID: 45409
	private bool LoadingFlag;

	// Token: 0x0400B162 RID: 45410
	private bool UiAnimFlag;

	// Token: 0x0400B163 RID: 45411
	private bool TimeInitState;

	// Token: 0x0400B164 RID: 45412
	private const double CheckTimeGap = 360.0;

	// Token: 0x0400B165 RID: 45413
	private bool CanOpenViewState;

	// Token: 0x0400B166 RID: 45414
	[Nullable(2)]
	private static TimeOfDayController _Instance;
}
