using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Common.Button
{
	// Token: 0x02005B87 RID: 23431
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ButtonStateController : ControllerBase
	{
		// Token: 0x0603B482 RID: 242818 RVA: 0x00E2131C File Offset: 0x00E1F51C
		protected override bool OnInit()
		{
			Dictionary<ButtonType, ModelBase> dictionary = new Dictionary<ButtonType, ModelBase>();
			dictionary[ButtonType.Home] = HomeBtnModel.Instance;
			this.ButtonTypeMap = dictionary;
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x0603B483 RID: 242819 RVA: 0x00E21354 File Offset: 0x00E1F554
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			this.CancelTimer();
			Dictionary<ButtonType, ModelBase> buttonTypeMap = this.ButtonTypeMap;
			if (buttonTypeMap != null)
			{
				buttonTypeMap.Clear();
			}
			this.ButtonTypeMap = null;
			this.LastServerTime = 0.0;
			return true;
		}

		// Token: 0x0603B484 RID: 242820 RVA: 0x00E213AB File Offset: 0x00E1F5AB
		private void OnWorldDone()
		{
			this.RequestBtnState();
			this.InitTimer();
		}

		// Token: 0x0603B485 RID: 242821 RVA: 0x00E213B9 File Offset: 0x00E1F5B9
		private void CancelTimer()
		{
			if (this.CheckStateTimer != null)
			{
				TimerSystem.RealTimeInstance.Remove(this.CheckStateTimer);
				this.CheckStateTimer = null;
			}
		}

		// Token: 0x0603B486 RID: 242822 RVA: 0x00E213DB File Offset: 0x00E1F5DB
		private void InitTimer()
		{
			this.CancelTimer();
			this.CheckStateTimer = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnCheckStateTimer), 120000f, 1f, null, null, true);
		}

		// Token: 0x0603B487 RID: 242823 RVA: 0x00E2140C File Offset: 0x00E1F60C
		private void OnCheckStateTimer(float _)
		{
			this.RequestBtnState();
		}

		// Token: 0x0603B488 RID: 242824 RVA: 0x00E21414 File Offset: 0x00E1F614
		public unsafe void RequestBtnState()
		{
			if (this.ButtonTypeMap == null)
			{
				return;
			}
			if (Time.Instance.ServerTimeStamp - this.LastServerTime <= 120000.0)
			{
				return;
			}
			this.LastServerTime = Time.Instance.ServerTimeStamp;
			Log.Instance.Info(ELogModule.HomeBtn, ELogAuthor.CB, "向服务器请求按钮状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			ButtonIsEnableRequest buttonIsEnableRequest = ButtonIsEnableRequest.Create();
			foreach (ButtonType item in this.ButtonTypeMap.Keys)
			{
				buttonIsEnableRequest.Types_.Add(item);
			}
			Net.Instance.Call(ERequestMessageId.ButtonIsEnableRequest, buttonIsEnableRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ButtonIsEnableResponse buttonIsEnableResponse = (ButtonIsEnableResponse)msg;
				if (buttonIsEnableResponse == null)
				{
					return;
				}
				if (buttonIsEnableResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(buttonIsEnableResponse.ErrorCode, EResponseMessageId.ButtonIsEnableResponse, null, true, true);
					return;
				}
				foreach (ButtonEnableResult buttonEnableResult in buttonIsEnableResponse.Result)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.HomeBtn;
					ELogAuthor author = ELogAuthor.CB;
					string message = "服务器下发按钮状态";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", buttonEnableResult.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Enable", buttonEnableResult.Enable);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					ModelBase target;
					if (this.ButtonTypeMap.TryGetValue(buttonEnableResult.Type, out target))
					{
						EventSystem.Instance.EmitWithTarget<bool>(target, EEventName.BtnStateUpdate, buttonEnableResult.Enable);
					}
				}
			}, 0);
		}

		// Token: 0x17008CD0 RID: 36048
		// (get) Token: 0x0603B489 RID: 242825 RVA: 0x00E214EC File Offset: 0x00E1F6EC
		public static ButtonStateController Instance
		{
			get
			{
				return ButtonStateController._Instance;
			}
		}

		// Token: 0x0603B48A RID: 242826 RVA: 0x00E214F3 File Offset: 0x00E1F6F3
		public static ButtonStateController GetOrCreateInstance()
		{
			if (ButtonStateController._Instance == null)
			{
				ButtonStateController.CreateInstance();
			}
			return ButtonStateController._Instance;
		}

		// Token: 0x0603B48B RID: 242827 RVA: 0x00E21507 File Offset: 0x00E1F707
		public static bool CreateInstance()
		{
			if (ButtonStateController._Instance != null)
			{
				return true;
			}
			ButtonStateController._Instance = new ButtonStateController();
			return true;
		}

		// Token: 0x0603B48C RID: 242828 RVA: 0x00E2151D File Offset: 0x00E1F71D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B48D RID: 242829 RVA: 0x00E2151F File Offset: 0x00E1F71F
		public static void ResetStaticDefaultValue()
		{
			ButtonStateController._Instance = null;
		}

		// Token: 0x0603B48E RID: 242830 RVA: 0x00E21527 File Offset: 0x00E1F727
		static ButtonStateController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ButtonStateController.CreateStaticDefaultValue), new Action(ButtonStateController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE72 RID: 126578
		private const int CheckGap = 120000;

		// Token: 0x0401EE73 RID: 126579
		[Nullable(2)]
		private TimerHandle CheckStateTimer;

		// Token: 0x0401EE74 RID: 126580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<ButtonType, ModelBase> ButtonTypeMap;

		// Token: 0x0401EE75 RID: 126581
		private double LastServerTime;

		// Token: 0x0401EE76 RID: 126582
		[Nullable(2)]
		private static ButtonStateController _Instance;
	}
}
