using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02003793 RID: 14227
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class WeatherController : ControllerBase
	{
		// Token: 0x06024FC1 RID: 151489 RVA: 0x00A73209 File Offset: 0x00A71409
		protected override bool OnInit()
		{
			this.OnAddEvents();
			this.OnRegisterNetEvent();
			this.InitTimer();
			return true;
		}

		// Token: 0x06024FC2 RID: 151490 RVA: 0x00A7321E File Offset: 0x00A7141E
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.OnUnRegisterNetEvent();
			this.DestroyWeatherActor();
			this.CancelTimer();
			return true;
		}

		// Token: 0x06024FC3 RID: 151491 RVA: 0x00A7323C File Offset: 0x00A7143C
		protected void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
			EventSystem.Instance.Add(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFuncOpenSet));
		}

		// Token: 0x06024FC4 RID: 151492 RVA: 0x00A7330C File Offset: 0x00A7150C
		protected void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.EnterGameSuccess, new Action(this.OnEnterGame));
			EventSystem.Instance.Remove(EEventName.BeforeLoadMap, new Action(this.OnBeforeLoadMap));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFuncOpenSet));
		}

		// Token: 0x06024FC5 RID: 151493 RVA: 0x00A733DA File Offset: 0x00A715DA
		private void InitTimer()
		{
			this.CheckUiSceneTimer = TimerSystem.Instance.Forever(new TTimerAction(this.CheckActiveState), 300f, 1f, null, null, true);
		}

		// Token: 0x06024FC6 RID: 151494 RVA: 0x00A73405 File Offset: 0x00A71605
		private void CancelTimer()
		{
			if (this.CheckUiSceneTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckUiSceneTimer);
				this.CheckUiSceneTimer = null;
			}
		}

		// Token: 0x06024FC7 RID: 151495 RVA: 0x00A73427 File Offset: 0x00A71627
		private void CheckActiveState(float _)
		{
			WeatherModel.Instance.GetWorldWeatherActor().SetActorState(!GlobalData.IsUiSceneOpen);
		}

		// Token: 0x06024FC8 RID: 151496 RVA: 0x00A73440 File Offset: 0x00A71640
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.WeatherNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWeatherNotify));
			Net.Instance.Register(ENotifyMessageId.WeatherControlUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				WeatherControlUnlockNotify weatherControlUnlockNotify = (WeatherControlUnlockNotify)msg;
				this.OnWeatherSwitchUnlock(weatherControlUnlockNotify.WeatherSwitchId);
			});
		}

		// Token: 0x06024FC9 RID: 151497 RVA: 0x00A7347A File Offset: 0x00A7167A
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.WeatherNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeatherControlUnlockNotify);
		}

		// Token: 0x06024FCA RID: 151498 RVA: 0x00A7349C File Offset: 0x00A7169C
		private void OnEnterGame()
		{
		}

		// Token: 0x06024FCB RID: 151499 RVA: 0x00A7349E File Offset: 0x00A7169E
		private void OnBeforeLoadMap()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x06024FCC RID: 151500 RVA: 0x00A734AF File Offset: 0x00A716AF
		private void OnWorldDone()
		{
			this.BackToWorldWeather();
			RenderDataManager.Instance.SyncForbidWeather();
		}

		// Token: 0x06024FCD RID: 151501 RVA: 0x00A734C1 File Offset: 0x00A716C1
		private void OnTeleportComplete(TeleportContext teleportContext)
		{
			this.BackToWorldWeather();
		}

		// Token: 0x06024FCE RID: 151502 RVA: 0x00A734C9 File Offset: 0x00A716C9
		private void BackToWorldWeather()
		{
			if (!GameModeController.Instance.IsInInstance() && WeatherModel.Instance.CurrentWeatherId != 0)
			{
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(WeatherModel.Instance.CurrentWeatherId, 0f);
			}
		}

		// Token: 0x06024FCF RID: 151503 RVA: 0x00A73501 File Offset: 0x00A71701
		private void DestroyWeatherActor()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x06024FD0 RID: 151504 RVA: 0x00A73514 File Offset: 0x00A71714
		public void RequestChangeWeather(int weatherId, ChangeWeatherReason? reason = null)
		{
			ChangeWeatherRequest changeWeatherRequest = ChangeWeatherRequest.Create();
			changeWeatherRequest.WeatherId = weatherId;
			if (reason != null)
			{
				changeWeatherRequest.Reason = reason.Value;
			}
			Net.Instance.Call(ERequestMessageId.ChangeWeatherRequest, changeWeatherRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ChangeWeatherResponse changeWeatherResponse = (ChangeWeatherResponse)msg;
				if (changeWeatherResponse == null)
				{
					return;
				}
				if (changeWeatherResponse.ErrorCode != ErrorCode.Success)
				{
					if (reason.GetValueOrDefault() == ChangeWeatherReason.ClientSkill)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.GHY;
						string message = "AN[切换天气] 触发切换天气失败";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", changeWeatherResponse.ErrorCode);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					ErrorCodeController.Instance.OpenErrorCodeTipView(changeWeatherResponse.ErrorCode, 19397, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06024FD1 RID: 151505 RVA: 0x00A73576 File Offset: 0x00A71776
		public void ChangeCurrentWeather(int weatherId, float changeTime)
		{
			if (WeatherModel.Instance.CurrentWeatherId != weatherId)
			{
				WeatherModel.Instance.SetCurrentWeatherId(weatherId);
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(weatherId, changeTime);
			}
			EventSystem.Instance.Emit(EEventName.WeatherChange);
		}

		// Token: 0x06024FD2 RID: 151506 RVA: 0x00A735B4 File Offset: 0x00A717B4
		private void OnWeatherNotify(IMessage msg, Net.CallbackStatus _)
		{
			WeatherNotify weatherNotify = (WeatherNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "OnWeatherNotify";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("WeatherNotify", weatherNotify);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (weatherNotify.IsClient)
			{
				this.ChangeCurrentWeather(weatherNotify.WeatherId, 1f);
				return;
			}
			this.ChangeCurrentWeather(weatherNotify.WeatherId, 10f);
		}

		// Token: 0x06024FD3 RID: 151507 RVA: 0x00A7361D File Offset: 0x00A7181D
		public void TestChangeWeather(int weatherId)
		{
			WeatherModel.Instance.SetCurrentWeatherId(weatherId);
			WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(weatherId, 10f);
		}

		// Token: 0x06024FD4 RID: 151508 RVA: 0x00A7363F File Offset: 0x00A7183F
		public void StopWeather()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x06024FD5 RID: 151509 RVA: 0x00A73650 File Offset: 0x00A71850
		public void BanWeather()
		{
			WeatherModel.Instance.GetWorldWeatherActor().BanWeather();
		}

		// Token: 0x06024FD6 RID: 151510 RVA: 0x00A73664 File Offset: 0x00A71864
		public void TryOpenWeatherCentralMainView(int? weatherConfigId = null)
		{
			if (!TimeOfDayController.Instance.CanOpenView(EUiViewName.TimeOfDayView))
			{
				return;
			}
			this.RequestWeatherControlInfoAsync().ContinueWith(delegate(bool result)
			{
				if (result)
				{
					UiManager.Instance.OpenView(EUiViewName.WeatherCentralMainView, weatherConfigId, null);
				}
			}).Forget();
		}

		// Token: 0x06024FD7 RID: 151511 RVA: 0x00A736AC File Offset: 0x00A718AC
		[NullableContext(0)]
		public UniTask<bool> RequestWeatherControlInfoAsync()
		{
			WeatherController.<RequestWeatherControlInfoAsync>d__26 <RequestWeatherControlInfoAsync>d__;
			<RequestWeatherControlInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestWeatherControlInfoAsync>d__.<>1__state = -1;
			<RequestWeatherControlInfoAsync>d__.<>t__builder.Start<WeatherController.<RequestWeatherControlInfoAsync>d__26>(ref <RequestWeatherControlInfoAsync>d__);
			return <RequestWeatherControlInfoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024FD8 RID: 151512 RVA: 0x00A736E8 File Offset: 0x00A718E8
		[NullableContext(0)]
		public UniTask<bool> RequestWeatherControlInfoWithoutCheckAsync()
		{
			WeatherController.<RequestWeatherControlInfoWithoutCheckAsync>d__27 <RequestWeatherControlInfoWithoutCheckAsync>d__;
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>1__state = -1;
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder.Start<WeatherController.<RequestWeatherControlInfoWithoutCheckAsync>d__27>(ref <RequestWeatherControlInfoWithoutCheckAsync>d__);
			return <RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024FD9 RID: 151513 RVA: 0x00A73724 File Offset: 0x00A71924
		public UniTask RequestSwitchWeather(int weatherSwitchConfigId)
		{
			WeatherController.<RequestSwitchWeather>d__28 <RequestSwitchWeather>d__;
			<RequestSwitchWeather>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestSwitchWeather>d__.weatherSwitchConfigId = weatherSwitchConfigId;
			<RequestSwitchWeather>d__.<>1__state = -1;
			<RequestSwitchWeather>d__.<>t__builder.Start<WeatherController.<RequestSwitchWeather>d__28>(ref <RequestSwitchWeather>d__);
			return <RequestSwitchWeather>d__.<>t__builder.Task;
		}

		// Token: 0x06024FDA RID: 151514 RVA: 0x00A73767 File Offset: 0x00A71967
		private void OnFunctionOpenUpdate(EFunctionType funcId, bool isOpen)
		{
			if (!isOpen)
			{
				return;
			}
			if (funcId != EFunctionType.WeatherCentral)
			{
				return;
			}
			this.TryOpenWeatherUnlockTips();
			this.RequestWeatherControlInfoWithoutCheckAsync().Forget<bool>();
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06024FDB RID: 151515 RVA: 0x00A73797 File Offset: 0x00A71997
		private void TryOpenWeatherUnlockTips()
		{
			UiManager.Instance.OpenView(EUiViewName.WeatherUnlockTips, null, null);
		}

		// Token: 0x06024FDC RID: 151516 RVA: 0x00A737AA File Offset: 0x00A719AA
		private void OnFuncOpenSet(EFunctionType funcType, bool isOpen)
		{
			if (!isOpen)
			{
				return;
			}
			if (funcType != EFunctionType.WeatherCentral)
			{
				return;
			}
			this.RequestWeatherControlInfoWithoutCheckAsync().Forget<bool>();
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06024FDD RID: 151517 RVA: 0x00A737D4 File Offset: 0x00A719D4
		private void OnWeatherSwitchUnlock(int weatherSwitchConfigId)
		{
			WeatherModel.Instance.AddUnlockedWeatherSwitchConfigId(weatherSwitchConfigId);
		}

		// Token: 0x06024FDE RID: 151518 RVA: 0x00A737E4 File Offset: 0x00A719E4
		private void OnWorldDoneAndCloseLoading()
		{
			int? targetWeatherSwitchConfigId = WeatherModel.Instance.TargetWeatherSwitchConfigId;
			if (targetWeatherSwitchConfigId != null)
			{
				this.TryOpenWeatherCentralMainView(targetWeatherSwitchConfigId);
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x06024FDF RID: 151519 RVA: 0x00A7380C File Offset: 0x00A71A0C
		[Nullable(1)]
		public static WeatherController Instance
		{
			[NullableContext(1)]
			get
			{
				return WeatherController._Instance;
			}
		}

		// Token: 0x06024FE0 RID: 151520 RVA: 0x00A73813 File Offset: 0x00A71A13
		[NullableContext(1)]
		public static WeatherController GetOrCreateInstance()
		{
			if (WeatherController._Instance == null)
			{
				WeatherController.CreateInstance();
			}
			return WeatherController._Instance;
		}

		// Token: 0x06024FE1 RID: 151521 RVA: 0x00A73827 File Offset: 0x00A71A27
		public static bool CreateInstance()
		{
			if (WeatherController._Instance != null)
			{
				return true;
			}
			WeatherController._Instance = new WeatherController();
			return true;
		}

		// Token: 0x06024FE2 RID: 151522 RVA: 0x00A7383D File Offset: 0x00A71A3D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06024FE3 RID: 151523 RVA: 0x00A7383F File Offset: 0x00A71A3F
		public static void ResetStaticDefaultValue()
		{
			WeatherController._Instance = null;
		}

		// Token: 0x06024FE4 RID: 151524 RVA: 0x00A73847 File Offset: 0x00A71A47
		static WeatherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherController.CreateStaticDefaultValue), new Action(WeatherController.ResetStaticDefaultValue));
		}

		// Token: 0x0401478D RID: 83853
		public const int CHANGE_WEATHER_SMOOTH_TIME = 10;

		// Token: 0x0401478E RID: 83854
		public const int CHANGE_WEATHER_SMOOTH_TIME_QUICK = 1;

		// Token: 0x0401478F RID: 83855
		public const int CHECKGAP = 300;

		// Token: 0x04014790 RID: 83856
		private TimerHandle CheckUiSceneTimer;

		// Token: 0x04014791 RID: 83857
		private static WeatherController _Instance;
	}
}
