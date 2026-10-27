using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal
{
	// Token: 0x02004853 RID: 18515
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalController : ControllerBase
	{
		// Token: 0x0603071B RID: 198427 RVA: 0x00B3F47D File Offset: 0x00B3D67D
		protected override bool OnInit()
		{
			this.OnRegisterNetEvent();
			return true;
		}

		// Token: 0x0603071C RID: 198428 RVA: 0x00B3F486 File Offset: 0x00B3D686
		protected override bool OnClear()
		{
			this.OnUnRegisterNetEvent();
			return true;
		}

		// Token: 0x0603071D RID: 198429 RVA: 0x00B3F48F File Offset: 0x00B3D68F
		protected void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.AreaTerminalInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAreaTerminalInfoNotify));
		}

		// Token: 0x0603071E RID: 198430 RVA: 0x00B3F4AD File Offset: 0x00B3D6AD
		protected void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.AreaTerminalInfoNotify);
		}

		// Token: 0x0603071F RID: 198431 RVA: 0x00B3F4C0 File Offset: 0x00B3D6C0
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

		// Token: 0x06030720 RID: 198432 RVA: 0x00B3F5B4 File Offset: 0x00B3D7B4
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

		// Token: 0x06030721 RID: 198433 RVA: 0x00B3F618 File Offset: 0x00B3D818
		public void OpenTerminalOverviewView(int id = 0)
		{
			RegionalTerminalViewParams regionalTerminalViewParams = new RegionalTerminalViewParams();
			regionalTerminalViewParams.GameplayId = id;
			UiManager.Instance.OpenView(EUiViewName.RegionalTerminalOverviewView, regionalTerminalViewParams, null);
		}

		// Token: 0x17007910 RID: 30992
		// (get) Token: 0x06030722 RID: 198434 RVA: 0x00B3F643 File Offset: 0x00B3D843
		public static RegionalTerminalController Instance
		{
			get
			{
				return RegionalTerminalController._Instance;
			}
		}

		// Token: 0x06030723 RID: 198435 RVA: 0x00B3F64A File Offset: 0x00B3D84A
		public static RegionalTerminalController GetOrCreateInstance()
		{
			if (RegionalTerminalController._Instance == null)
			{
				RegionalTerminalController.CreateInstance();
			}
			return RegionalTerminalController._Instance;
		}

		// Token: 0x06030724 RID: 198436 RVA: 0x00B3F65E File Offset: 0x00B3D85E
		public static bool CreateInstance()
		{
			if (RegionalTerminalController._Instance != null)
			{
				return true;
			}
			RegionalTerminalController._Instance = new RegionalTerminalController();
			return true;
		}

		// Token: 0x06030725 RID: 198437 RVA: 0x00B3F674 File Offset: 0x00B3D874
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030726 RID: 198438 RVA: 0x00B3F676 File Offset: 0x00B3D876
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalController._Instance = null;
		}

		// Token: 0x06030727 RID: 198439 RVA: 0x00B3F67E File Offset: 0x00B3D87E
		static RegionalTerminalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalController.CreateStaticDefaultValue), new Action(RegionalTerminalController.ResetStaticDefaultValue));
		}

		// Token: 0x0401A081 RID: 106625
		[Nullable(2)]
		private static RegionalTerminalController _Instance;
	}
}
