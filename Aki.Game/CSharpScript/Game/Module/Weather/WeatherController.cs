using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02004862 RID: 18530
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class WeatherController : ControllerBase
	{
		// Token: 0x060307F1 RID: 198641 RVA: 0x00B42F8D File Offset: 0x00B4118D
		protected override bool OnInit()
		{
			this.OnAddEvents();
			this.OnRegisterNetEvent();
			this.InitTimer();
			return true;
		}

		// Token: 0x060307F2 RID: 198642 RVA: 0x00B42FA2 File Offset: 0x00B411A2
		protected override bool OnClear()
		{
			this.OnRemoveEvents();
			this.OnUnRegisterNetEvent();
			this.DestroyWeatherActor();
			this.CancelTimer();
			return true;
		}

		// Token: 0x060307F3 RID: 198643 RVA: 0x00B42FC0 File Offset: 0x00B411C0
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

		// Token: 0x060307F4 RID: 198644 RVA: 0x00B43090 File Offset: 0x00B41290
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

		// Token: 0x060307F5 RID: 198645 RVA: 0x00B4315E File Offset: 0x00B4135E
		private void InitTimer()
		{
			this.CheckUiSceneTimer = TimerSystem.Instance.Forever(new TTimerAction(this.CheckActiveState), 300f, 1f, null, null, true);
		}

		// Token: 0x060307F6 RID: 198646 RVA: 0x00B43189 File Offset: 0x00B41389
		private void CancelTimer()
		{
			if (this.CheckUiSceneTimer != null)
			{
				TimerSystem.Instance.Remove(this.CheckUiSceneTimer);
				this.CheckUiSceneTimer = null;
			}
		}

		// Token: 0x060307F7 RID: 198647 RVA: 0x00B431AB File Offset: 0x00B413AB
		private void CheckActiveState(float _)
		{
			WeatherModel.Instance.GetWorldWeatherActor().SetActorState(!GlobalData.IsUiSceneOpen);
		}

		// Token: 0x060307F8 RID: 198648 RVA: 0x00B431C4 File Offset: 0x00B413C4
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.WeatherNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWeatherNotify));
			Net.Instance.Register(ENotifyMessageId.WeatherControlUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				WeatherControlUnlockNotify weatherControlUnlockNotify = (WeatherControlUnlockNotify)msg;
				this.OnWeatherSwitchUnlock(weatherControlUnlockNotify.WeatherSwitchId);
			});
		}

		// Token: 0x060307F9 RID: 198649 RVA: 0x00B431FE File Offset: 0x00B413FE
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.WeatherNotify);
			Net.Instance.UnRegister(ENotifyMessageId.WeatherControlUnlockNotify);
		}

		// Token: 0x060307FA RID: 198650 RVA: 0x00B43220 File Offset: 0x00B41420
		private void OnEnterGame()
		{
		}

		// Token: 0x060307FB RID: 198651 RVA: 0x00B43222 File Offset: 0x00B41422
		private void OnBeforeLoadMap()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x060307FC RID: 198652 RVA: 0x00B43233 File Offset: 0x00B41433
		private void OnWorldDone()
		{
			this.BackToWorldWeather();
		}

		// Token: 0x060307FD RID: 198653 RVA: 0x00B4323B File Offset: 0x00B4143B
		private void OnTeleportComplete(TeleportContext teleportContext)
		{
			this.BackToWorldWeather();
		}

		// Token: 0x060307FE RID: 198654 RVA: 0x00B43243 File Offset: 0x00B41443
		private void BackToWorldWeather()
		{
			if (!GameModeController.Instance.IsInInstance() && WeatherModel.Instance.CurrentWeatherId != 0)
			{
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(WeatherModel.Instance.CurrentWeatherId, 0f);
			}
		}

		// Token: 0x060307FF RID: 198655 RVA: 0x00B4327B File Offset: 0x00B4147B
		private void DestroyWeatherActor()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x06030800 RID: 198656 RVA: 0x00B4328C File Offset: 0x00B4148C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(changeWeatherResponse.ErrorCode, 21042, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06030801 RID: 198657 RVA: 0x00B432EE File Offset: 0x00B414EE
		public void ChangeCurrentWeather(int weatherId, float changeTime)
		{
			if (WeatherModel.Instance.CurrentWeatherId != weatherId)
			{
				WeatherModel.Instance.SetCurrentWeatherId(weatherId);
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(weatherId, changeTime);
			}
			EventSystem.Instance.Emit(EEventName.WeatherChange);
		}

		// Token: 0x06030802 RID: 198658 RVA: 0x00B4332C File Offset: 0x00B4152C
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

		// Token: 0x06030803 RID: 198659 RVA: 0x00B43395 File Offset: 0x00B41595
		public void TestChangeWeather(int weatherId)
		{
			WeatherModel.Instance.SetCurrentWeatherId(weatherId);
			WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(weatherId, 10f);
		}

		// Token: 0x06030804 RID: 198660 RVA: 0x00B433B7 File Offset: 0x00B415B7
		public void StopWeather()
		{
			WeatherModel.Instance.GetWorldWeatherActor().Destroy();
		}

		// Token: 0x06030805 RID: 198661 RVA: 0x00B433C8 File Offset: 0x00B415C8
		public void BanWeather()
		{
			WeatherModel.Instance.GetWorldWeatherActor().BanWeather();
		}

		// Token: 0x06030806 RID: 198662 RVA: 0x00B433DC File Offset: 0x00B415DC
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

		// Token: 0x06030807 RID: 198663 RVA: 0x00B43424 File Offset: 0x00B41624
		[NullableContext(0)]
		public UniTask<bool> RequestWeatherControlInfoAsync()
		{
			WeatherController.<RequestWeatherControlInfoAsync>d__26 <RequestWeatherControlInfoAsync>d__;
			<RequestWeatherControlInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestWeatherControlInfoAsync>d__.<>1__state = -1;
			<RequestWeatherControlInfoAsync>d__.<>t__builder.Start<WeatherController.<RequestWeatherControlInfoAsync>d__26>(ref <RequestWeatherControlInfoAsync>d__);
			return <RequestWeatherControlInfoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030808 RID: 198664 RVA: 0x00B43460 File Offset: 0x00B41660
		[NullableContext(0)]
		public UniTask<bool> RequestWeatherControlInfoWithoutCheckAsync()
		{
			WeatherController.<RequestWeatherControlInfoWithoutCheckAsync>d__27 <RequestWeatherControlInfoWithoutCheckAsync>d__;
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>1__state = -1;
			<RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder.Start<WeatherController.<RequestWeatherControlInfoWithoutCheckAsync>d__27>(ref <RequestWeatherControlInfoWithoutCheckAsync>d__);
			return <RequestWeatherControlInfoWithoutCheckAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030809 RID: 198665 RVA: 0x00B4349C File Offset: 0x00B4169C
		public UniTask RequestSwitchWeather(int weatherSwitchConfigId)
		{
			WeatherController.<RequestSwitchWeather>d__28 <RequestSwitchWeather>d__;
			<RequestSwitchWeather>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestSwitchWeather>d__.weatherSwitchConfigId = weatherSwitchConfigId;
			<RequestSwitchWeather>d__.<>1__state = -1;
			<RequestSwitchWeather>d__.<>t__builder.Start<WeatherController.<RequestSwitchWeather>d__28>(ref <RequestSwitchWeather>d__);
			return <RequestSwitchWeather>d__.<>t__builder.Task;
		}

		// Token: 0x0603080A RID: 198666 RVA: 0x00B434DF File Offset: 0x00B416DF
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

		// Token: 0x0603080B RID: 198667 RVA: 0x00B4350F File Offset: 0x00B4170F
		private void TryOpenWeatherUnlockTips()
		{
			UiManager.Instance.OpenView(EUiViewName.WeatherUnlockTips, null, null);
		}

		// Token: 0x0603080C RID: 198668 RVA: 0x00B43522 File Offset: 0x00B41722
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

		// Token: 0x0603080D RID: 198669 RVA: 0x00B4354C File Offset: 0x00B4174C
		private void OnWeatherSwitchUnlock(int weatherSwitchConfigId)
		{
			WeatherModel.Instance.AddUnlockedWeatherSwitchConfigId(weatherSwitchConfigId);
		}

		// Token: 0x0603080E RID: 198670 RVA: 0x00B4355C File Offset: 0x00B4175C
		private void OnWorldDoneAndCloseLoading()
		{
			int? targetWeatherSwitchConfigId = WeatherModel.Instance.TargetWeatherSwitchConfigId;
			if (targetWeatherSwitchConfigId != null)
			{
				this.TryOpenWeatherCentralMainView(targetWeatherSwitchConfigId);
			}
		}

		// Token: 0x17007923 RID: 31011
		// (get) Token: 0x0603080F RID: 198671 RVA: 0x00B43584 File Offset: 0x00B41784
		[Nullable(1)]
		public static WeatherController Instance
		{
			[NullableContext(1)]
			get
			{
				return WeatherController._Instance;
			}
		}

		// Token: 0x06030810 RID: 198672 RVA: 0x00B4358B File Offset: 0x00B4178B
		[NullableContext(1)]
		public static WeatherController GetOrCreateInstance()
		{
			if (WeatherController._Instance == null)
			{
				WeatherController.CreateInstance();
			}
			return WeatherController._Instance;
		}

		// Token: 0x06030811 RID: 198673 RVA: 0x00B4359F File Offset: 0x00B4179F
		public static bool CreateInstance()
		{
			if (WeatherController._Instance != null)
			{
				return true;
			}
			WeatherController._Instance = new WeatherController();
			return true;
		}

		// Token: 0x06030812 RID: 198674 RVA: 0x00B435B5 File Offset: 0x00B417B5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030813 RID: 198675 RVA: 0x00B435B7 File Offset: 0x00B417B7
		public static void ResetStaticDefaultValue()
		{
			WeatherController._Instance = null;
		}

		// Token: 0x06030814 RID: 198676 RVA: 0x00B435BF File Offset: 0x00B417BF
		static WeatherController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherController.CreateStaticDefaultValue), new Action(WeatherController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A0D9 RID: 106713
		public const int CHANGE_WEATHER_SMOOTH_TIME = 10;

		// Token: 0x0401A0DA RID: 106714
		public const int CHANGE_WEATHER_SMOOTH_TIME_QUICK = 1;

		// Token: 0x0401A0DB RID: 106715
		public const int CHECKGAP = 300;

		// Token: 0x0401A0DC RID: 106716
		private TimerHandle CheckUiSceneTimer;

		// Token: 0x0401A0DD RID: 106717
		private static WeatherController _Instance;
	}
}
