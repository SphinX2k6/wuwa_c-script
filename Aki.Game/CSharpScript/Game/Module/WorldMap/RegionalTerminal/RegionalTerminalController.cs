using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal
{
	// Token: 0x02003784 RID: 14212
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalController : ControllerBase
	{
		// Token: 0x06024EEA RID: 151274 RVA: 0x00A6F6C1 File Offset: 0x00A6D8C1
		protected override bool OnInit()
		{
			this.OnRegisterNetEvent();
			return true;
		}

		// Token: 0x06024EEB RID: 151275 RVA: 0x00A6F6CA File Offset: 0x00A6D8CA
		protected override bool OnClear()
		{
			this.OnUnRegisterNetEvent();
			return true;
		}

		// Token: 0x06024EEC RID: 151276 RVA: 0x00A6F6D3 File Offset: 0x00A6D8D3
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.AreaTerminalInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAreaTerminalInfoNotify));
		}

		// Token: 0x06024EED RID: 151277 RVA: 0x00A6F6F1 File Offset: 0x00A6D8F1
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.AreaTerminalInfoNotify);
		}

		// Token: 0x06024EEE RID: 151278 RVA: 0x00A6F704 File Offset: 0x00A6D904
		[NullableContext(2)]
		private void OnAreaTerminalInfoNotify(IMessage msg, Net.CallbackStatus callbackStatus)
		{
			AreaTerminalInfoNotify areaTerminalInfoNotify = (AreaTerminalInfoNotify)msg;
			RegionalTerminalModel.Instance.InitGameplayPin(areaTerminalInfoNotify.PinIds);
			foreach (AreaTerminalFuncConditionInfo areaTerminalFuncConditionInfo in areaTerminalInfoNotify.AreaTerminalFuncConditionInfos)
			{
				RegionalTerminalModel.Instance.UpdateFuncIdConditionFinishedState(areaTerminalFuncConditionInfo.FuncId, areaTerminalFuncConditionInfo.FinishConditionIds);
			}
			if (areaTerminalInfoNotify.AreaMapGroup.Count > 0)
			{
				foreach (int unlockAreaMapGroupId in areaTerminalInfoNotify.AreaMapGroup)
				{
					RegionalTerminalModel.Instance.SetUnlockAreaMapGroupId(unlockAreaMapGroupId);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[RegionalTerminal] UnlockAreaMapGroup";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Ids", areaTerminalInfoNotify.AreaMapGroup);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06024EEF RID: 151279 RVA: 0x00A6F7F8 File Offset: 0x00A6D9F8
		[NullableContext(2)]
		public void RequestTerminalPinOperation(int gameplayId, bool isPin, Action<bool> callback = null)
		{
			AreaTerminalPinOperationRequest areaTerminalPinOperationRequest = new AreaTerminalPinOperationRequest();
			areaTerminalPinOperationRequest.Id = gameplayId;
			areaTerminalPinOperationRequest.OpType = isPin;
			Net.Instance.Call(ERequestMessageId.AreaTerminalPinOperationRequest, areaTerminalPinOperationRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				AreaTerminalPinOperationResponse areaTerminalPinOperationResponse = (AreaTerminalPinOperationResponse)msg;
				if (areaTerminalPinOperationResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (areaTerminalPinOperationResponse.Code != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(areaTerminalPinOperationResponse.Code, EResponseMessageId.AreaTerminalPinOperationResponse, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					RegionalTerminalModel.Instance.UpdateGameplayPin(gameplayId, isPin);
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06024EF0 RID: 151280 RVA: 0x00A6F85C File Offset: 0x00A6DA5C
		public void OpenTerminalOverviewView(int id = 0)
		{
			RegionalTerminalViewParams regionalTerminalViewParams = new RegionalTerminalViewParams();
			regionalTerminalViewParams.GameplayId = id;
			UiManager.Instance.OpenView(EUiViewName.RegionalTerminalOverviewView, regionalTerminalViewParams, null);
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x06024EF1 RID: 151281 RVA: 0x00A6F887 File Offset: 0x00A6DA87
		public static RegionalTerminalController Instance
		{
			get
			{
				return RegionalTerminalController._Instance;
			}
		}

		// Token: 0x06024EF2 RID: 151282 RVA: 0x00A6F88E File Offset: 0x00A6DA8E
		public static RegionalTerminalController GetOrCreateInstance()
		{
			if (RegionalTerminalController._Instance == null)
			{
				RegionalTerminalController.CreateInstance();
			}
			return RegionalTerminalController._Instance;
		}

		// Token: 0x06024EF3 RID: 151283 RVA: 0x00A6F8A2 File Offset: 0x00A6DAA2
		public static bool CreateInstance()
		{
			if (RegionalTerminalController._Instance != null)
			{
				return true;
			}
			RegionalTerminalController._Instance = new RegionalTerminalController();
			return true;
		}

		// Token: 0x06024EF4 RID: 151284 RVA: 0x00A6F8B8 File Offset: 0x00A6DAB8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06024EF5 RID: 151285 RVA: 0x00A6F8BA File Offset: 0x00A6DABA
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalController._Instance = null;
		}

		// Token: 0x06024EF6 RID: 151286 RVA: 0x00A6F8C2 File Offset: 0x00A6DAC2
		static RegionalTerminalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalController.CreateStaticDefaultValue), new Action(RegionalTerminalController.ResetStaticDefaultValue));
		}

		// Token: 0x04014735 RID: 83765
		[Nullable(2)]
		private static RegionalTerminalController _Instance;
	}
}
