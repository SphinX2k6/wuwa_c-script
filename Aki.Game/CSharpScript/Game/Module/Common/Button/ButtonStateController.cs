using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Common.Button
{
	// Token: 0x02004B67 RID: 19303
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ButtonStateController : ControllerBase
	{
		// Token: 0x060303CF RID: 197583 RVA: 0x00D71888 File Offset: 0x00D6FA88
		protected override bool OnInit()
		{
			Dictionary<ButtonType, ModelBase> dictionary = new Dictionary<ButtonType, ModelBase>();
			dictionary[ButtonType.Home] = HomeBtnModel.Instance;
			this.ButtonTypeMap = dictionary;
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x060303D0 RID: 197584 RVA: 0x00D718C0 File Offset: 0x00D6FAC0
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

		// Token: 0x060303D1 RID: 197585 RVA: 0x00D71917 File Offset: 0x00D6FB17
		private void OnWorldDone()
		{
			this.RequestBtnState();
			this.InitTimer();
		}

		// Token: 0x060303D2 RID: 197586 RVA: 0x00D71925 File Offset: 0x00D6FB25
		private void CancelTimer()
		{
			if (this.CheckStateTimer != null)
			{
				TimerSystem.RealTimeInstance.Remove(this.CheckStateTimer);
				this.CheckStateTimer = null;
			}
		}

		// Token: 0x060303D3 RID: 197587 RVA: 0x00D71947 File Offset: 0x00D6FB47
		private void InitTimer()
		{
			this.CancelTimer();
			this.CheckStateTimer = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnCheckStateTimer), 120000f, 1f, null, null, true);
		}

		// Token: 0x060303D4 RID: 197588 RVA: 0x00D71978 File Offset: 0x00D6FB78
		private void OnCheckStateTimer(float _)
		{
			this.RequestBtnState();
		}

		// Token: 0x060303D5 RID: 197589 RVA: 0x00D71980 File Offset: 0x00D6FB80
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

		// Token: 0x170060A2 RID: 24738
		// (get) Token: 0x060303D6 RID: 197590 RVA: 0x00D71A58 File Offset: 0x00D6FC58
		public static ButtonStateController Instance
		{
			get
			{
				return ButtonStateController._Instance;
			}
		}

		// Token: 0x060303D7 RID: 197591 RVA: 0x00D71A5F File Offset: 0x00D6FC5F
		public static ButtonStateController GetOrCreateInstance()
		{
			if (ButtonStateController._Instance == null)
			{
				ButtonStateController.CreateInstance();
			}
			return ButtonStateController._Instance;
		}

		// Token: 0x060303D8 RID: 197592 RVA: 0x00D71A73 File Offset: 0x00D6FC73
		public static bool CreateInstance()
		{
			if (ButtonStateController._Instance != null)
			{
				return true;
			}
			ButtonStateController._Instance = new ButtonStateController();
			return true;
		}

		// Token: 0x060303D9 RID: 197593 RVA: 0x00D71A89 File Offset: 0x00D6FC89
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060303DA RID: 197594 RVA: 0x00D71A8B File Offset: 0x00D6FC8B
		public static void ResetStaticDefaultValue()
		{
			ButtonStateController._Instance = null;
		}

		// Token: 0x060303DB RID: 197595 RVA: 0x00D71A93 File Offset: 0x00D6FC93
		static ButtonStateController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ButtonStateController.CreateStaticDefaultValue), new Action(ButtonStateController.ResetStaticDefaultValue));
		}

		// Token: 0x04019923 RID: 104739
		private const int CheckGap = 120000;

		// Token: 0x04019924 RID: 104740
		[Nullable(2)]
		private TimerHandle CheckStateTimer;

		// Token: 0x04019925 RID: 104741
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<ButtonType, ModelBase> ButtonTypeMap;

		// Token: 0x04019926 RID: 104742
		private double LastServerTime;

		// Token: 0x04019927 RID: 104743
		[Nullable(2)]
		private static ButtonStateController _Instance;
	}
}
