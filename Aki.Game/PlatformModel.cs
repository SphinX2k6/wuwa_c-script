using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

// Token: 0x02001AD3 RID: 6867
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PlatformModel : ModelBase
{
	// Token: 0x06011095 RID: 69781 RVA: 0x005018E0 File Offset: 0x004FFAE0
	protected override bool OnInit()
	{
		Info.Instance.SetInputTypeChangeFunc(new TInputTypeChange(this.InputTypeChangeFunc));
		Info.Instance.SetShowTypeChangeFunc(new TShowTypeChange(this.ShowTypeChangeFunc));
		Info.Instance.SetInputMainTypeChangeFunc(new TInputMainTypeChange(this.InputMainTypeChangeFunc));
		this.NotifyAudioStateChange();
		this.NotifyCppInputControllerChange();
		EventSystem.Instance.Add(EEventName.InitializeLguiEventSystemActor, new Action(this.OnNotifyCppInputControllerChange));
		return true;
	}

	// Token: 0x06011096 RID: 69782 RVA: 0x00501958 File Offset: 0x004FFB58
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.InitializeLguiEventSystemActor, new Action(this.OnNotifyCppInputControllerChange));
		Info.Instance.ClearInputTypeChangeFunc();
		Info.Instance.ClearShowTypeChangeFunc();
		Info.Instance.ClearInputMainTypeChangeFunc();
		return true;
	}

	// Token: 0x06011097 RID: 69783 RVA: 0x00501998 File Offset: 0x004FFB98
	private void InputTypeChangeFunc(EInputControllerType last, EInputControllerType now)
	{
		this.NotifyAudioStateChange();
		this.NotifyCppInputControllerChange();
		TsCharacterController characterController = Global.CharacterController;
		if (Info.Instance.CheckIsPsGamepad(now))
		{
			if (characterController != null)
			{
				UTriggerEffectBPLibrary.SetPadColor(characterController, FColor.FromHex("#0000FF"));
			}
			GamepadController.Instance.SetLightBar("Normal");
			UKuroAudioStatics.SetDualSenseSpeakerRouteEnabled(true);
		}
		else
		{
			GamepadController.Instance.ClearLightBar();
			UTriggerEffectBPLibrary.ResetPadColor(Global.CharacterController);
			UKuroAudioStatics.SetDualSenseSpeakerRouteEnabled(false);
		}
		EventSystem.Instance.Emit<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, last, now);
	}

	// Token: 0x06011098 RID: 69784 RVA: 0x00501A1B File Offset: 0x004FFC1B
	private void ShowTypeChangeFunc(EOperationType last, EOperationType now)
	{
		EventSystem.Instance.Emit<EOperationType, EOperationType>(EEventName.ShowTypeChange, last, now);
	}

	// Token: 0x06011099 RID: 69785 RVA: 0x00501A2F File Offset: 0x004FFC2F
	private void InputMainTypeChangeFunc(EInputControllerMainType last, EInputControllerMainType now)
	{
		EventSystem.Instance.Emit<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, last, now);
	}

	// Token: 0x0601109A RID: 69786 RVA: 0x00501A43 File Offset: 0x004FFC43
	private void OnNotifyCppInputControllerChange()
	{
		this.NotifyCppInputControllerChange();
	}

	// Token: 0x0601109B RID: 69787 RVA: 0x00501A4C File Offset: 0x004FFC4C
	private void NotifyAudioStateChange()
	{
		if (Info.Instance.IsInGamepad())
		{
			AudioSystem.Instance.SetState("input_controller_type", "gamepad", true);
			return;
		}
		if (Info.Instance.IsInKeyBoard())
		{
			AudioSystem.Instance.SetState("input_controller_type", "Keyboard", true);
			return;
		}
		AudioSystem.Instance.SetState("input_controller_type", "touch", true);
	}

	// Token: 0x0601109C RID: 69788 RVA: 0x00501AB4 File Offset: 0x004FFCB4
	private void NotifyCppInputControllerChange()
	{
		EInputKeyType currentInputKeyType = EInputKeyType.None;
		if (Info.Instance.IsInKeyBoard())
		{
			currentInputKeyType = EInputKeyType.KeyboardOrMouse;
		}
		else if (Info.Instance.IsInGamepad())
		{
			currentInputKeyType = EInputKeyType.Gamepad;
		}
		else if (Info.Instance.IsInTouch())
		{
			currentInputKeyType = EInputKeyType.Touch;
		}
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor != null && lguiEventSystemActor.IsValid())
		{
			lguiEventSystemActor.SetCurrentInputKeyType(currentInputKeyType);
		}
		ABasePlayerController.SetUseSonyGamepadState(Info.Instance.IsPsGamepad());
		ABasePlayerController.SetUseGamepadState(Info.Instance.IsInGamepad());
	}

	// Token: 0x0601109D RID: 69789 RVA: 0x00501B2C File Offset: 0x004FFD2C
	private EInputControllerType GetCurrentPcDeviceInputController()
	{
		TArray<FRegisteredDeviceInfo> registeredDevices = URawInputFunctionLibrary.GetRegisteredDevices();
		if (registeredDevices == null || registeredDevices.Num() == 0)
		{
			Log.Instance.Info(ELogModule.Platform, ELogAuthor.CWC, "RegisteredDevices为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return EInputControllerType.None;
		}
		for (int i = 0; i < registeredDevices.Num(); i++)
		{
			FRegisteredDeviceInfo fregisteredDeviceInfo = registeredDevices.Get(i);
			int vendorID = fregisteredDeviceInfo.VendorID;
			int productID = fregisteredDeviceInfo.ProductID;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(vendorID);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(productID);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			EInputControllerType result;
			if (PlatformDefine.DeviceIdMap.TryGetValue(key, out result))
			{
				return result;
			}
		}
		return EInputControllerType.XboxOne;
	}

	// Token: 0x0601109E RID: 69790 RVA: 0x00501BD4 File Offset: 0x004FFDD4
	private EInputControllerType GetCurrentMacDeviceInputController()
	{
		string currentActiveGamepadName = UKismetSystemLibrary.GetCurrentActiveGamepadName();
		if (currentActiveGamepadName.Contains("xbox"))
		{
			return EInputControllerType.XboxOne;
		}
		if (currentActiveGamepadName.Contains("ps4"))
		{
			return EInputControllerType.PS4;
		}
		if (currentActiveGamepadName.Contains("ps5"))
		{
			return EInputControllerType.PS5;
		}
		if (currentActiveGamepadName.Contains("nspro"))
		{
			return EInputControllerType.NsPro;
		}
		return EInputControllerType.XboxOne;
	}

	// Token: 0x0601109F RID: 69791 RVA: 0x00501C24 File Offset: 0x004FFE24
	private EInputControllerType GetCurrentCloudGamePadInputType()
	{
		ICloudGamePadInfo cloudGamePadInfo = CloudGameManager.Instance.CloudGamePadInfo;
		if (cloudGamePadInfo == null)
		{
			return EInputControllerType.None;
		}
		int vendorId = cloudGamePadInfo.VendorId;
		int productId = cloudGamePadInfo.ProductId;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(vendorId);
		defaultInterpolatedStringHandler.AppendLiteral("_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(productId);
		string key = defaultInterpolatedStringHandler.ToStringAndClear();
		EInputControllerType result;
		if (PlatformDefine.DeviceIdMap.TryGetValue(key, out result))
		{
			return result;
		}
		return EInputControllerType.XboxOne;
	}

	// Token: 0x060110A0 RID: 69792 RVA: 0x00501C90 File Offset: 0x004FFE90
	private void HandlePressAnyKeyInMobile(FKey key)
	{
		if (this.IsKeyFromGamepadKey(key.KeyName.ToString()))
		{
			EInputControllerType currentDeviceInputController = this.GetCurrentDeviceInputController();
			if (currentDeviceInputController != EInputControllerType.None)
			{
				MobileSwitchInputController.Instance.SwitchToGamepad(new EInputControllerType?(currentDeviceInputController), "PressAnyKey");
				return;
			}
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "有手柄按钮输入但是识别不到对应的手柄设备", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x060110A1 RID: 69793 RVA: 0x00501CF8 File Offset: 0x004FFEF8
	private void HandlePressAnyKeyInNotMobile(FKey key)
	{
		if (UKismetInputLibrary.Key_IsGamepadKey(key))
		{
			if (!this.RefreshPlatformByDevice("PressAnyKey"))
			{
				Info.Instance.SwitchInputControllerType(EInputControllerType.XboxOne, "PressAnyKey");
				return;
			}
		}
		else
		{
			if (UKismetInputLibrary.Key_IsKeyboardKey(key) || UKismetInputLibrary.Key_IsMouseButton(key))
			{
				Info.Instance.SwitchInputControllerType(EInputControllerType.Keyboard, "PressAnyKey");
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Platform;
			ELogAuthor author = ELogAuthor.CB;
			string message = "HandlePressAnyKeyInNotMobile:Touch";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key.KeyName.ToString());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Info.Instance.SwitchInputControllerType(EInputControllerType.Touch, "PressAnyKey");
		}
	}

	// Token: 0x060110A2 RID: 69794 RVA: 0x00501D9F File Offset: 0x004FFF9F
	public void OnPressAnyKey(FKey key)
	{
		if (Info.Instance.IsMobileInputModel())
		{
			this.HandlePressAnyKeyInMobile(key);
			return;
		}
		this.HandlePressAnyKeyInNotMobile(key);
	}

	// Token: 0x060110A3 RID: 69795 RVA: 0x00501DBC File Offset: 0x004FFFBC
	public bool RefreshPlatformByDevice(string reason)
	{
		if (Info.Instance.IsPs5Platform())
		{
			Info.Instance.SwitchInputControllerType(EInputControllerType.PS5, reason);
			return true;
		}
		if (!CloudGameManager.Instance.IsCloudGame)
		{
			if (Info.Instance.IsWindowsPlatform())
			{
				EInputControllerType currentPcDeviceInputController = this.GetCurrentPcDeviceInputController();
				if (currentPcDeviceInputController != EInputControllerType.None)
				{
					Info.Instance.SwitchInputControllerType(currentPcDeviceInputController, reason);
					return true;
				}
			}
			if (Info.Instance.IsMacPlatform())
			{
				EInputControllerType currentMacDeviceInputController = this.GetCurrentMacDeviceInputController();
				if (currentMacDeviceInputController != EInputControllerType.None)
				{
					Info.Instance.SwitchInputControllerType(currentMacDeviceInputController, reason);
					return true;
				}
			}
			return false;
		}
		EInputControllerType currentCloudGamePadInputType = this.GetCurrentCloudGamePadInputType();
		if (currentCloudGamePadInputType != EInputControllerType.None)
		{
			Info.Instance.SwitchInputControllerType(currentCloudGamePadInputType, reason);
			return true;
		}
		return false;
	}

	// Token: 0x060110A4 RID: 69796 RVA: 0x00501E52 File Offset: 0x00500052
	public NetStatusType GetNetStatus()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			if (UMobilePatchingLibrary.HasActiveWiFiConnection())
			{
				return NetStatusType.Wifi;
			}
			if (UKuroLauncherLibrary.GetNetworkConnectionType() == 3)
			{
				return NetStatusType.Stream;
			}
			return NetStatusType.Other;
		}
		else
		{
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				return NetStatusType.Wired;
			}
			return NetStatusType.Other;
		}
	}

	// Token: 0x060110A5 RID: 69797 RVA: 0x00501E84 File Offset: 0x00500084
	public bool IsKeyFromGamepadKey(string keyName)
	{
		return !keyName.Contains("Android") && !keyName.Contains("OpenHarmony") && InputSettings.Instance.IsGamepadKey(keyName);
	}

	// Token: 0x060110A6 RID: 69798 RVA: 0x00501EB0 File Offset: 0x005000B0
	public EInputControllerType GetCurrentDeviceInputController()
	{
		if (Platform.Instance.IsPcPlatform())
		{
			if (CloudGameManager.Instance.IsCloudGame)
			{
				return this.GetCloudGameInputController();
			}
			return this.GetCurrentPcDeviceInputController();
		}
		else
		{
			string currentActiveGamepadName = UKismetSystemLibrary.GetCurrentActiveGamepadName();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MobileInputSwitch;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "当前激活的手柄";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("设备名", currentActiveGamepadName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Platform.Instance.IsAndroidPlatform())
			{
				if (currentActiveGamepadName == "None")
				{
					return EInputControllerType.None;
				}
				EInputControllerType result;
				if (PlatformDefine.DeviceIdMap.TryGetValue(currentActiveGamepadName, out result))
				{
					return result;
				}
				foreach (KeyValuePair<string, EInputControllerType> keyValuePair in PlatformDefine.DeviceIdMap)
				{
					int num = keyValuePair.Key.IndexOfAny(new char[]
					{
						'*',
						'_'
					});
					if (num > 0)
					{
						string value = keyValuePair.Key.Substring(0, num);
						if (currentActiveGamepadName.StartsWith(value))
						{
							return keyValuePair.Value;
						}
					}
				}
				return EInputControllerType.XboxOne;
			}
			else if (Platform.Instance.IsIOSPlatform())
			{
				if (currentActiveGamepadName == "None")
				{
					return EInputControllerType.None;
				}
				if (currentActiveGamepadName.Contains("Xbox"))
				{
					return EInputControllerType.XboxOne;
				}
				if (currentActiveGamepadName.Contains("DualShock"))
				{
					return EInputControllerType.PS5;
				}
				if (currentActiveGamepadName.Contains("BackBoneOne"))
				{
					return EInputControllerType.BackBone;
				}
				if (currentActiveGamepadName.Contains("nspro"))
				{
					return EInputControllerType.NsPro;
				}
				return EInputControllerType.XboxOne;
			}
			else
			{
				if (Platform.Instance.IsOpenHarmonyPlatform())
				{
					return this.GetOpenHarmonyDeviceInputController(currentActiveGamepadName);
				}
				return EInputControllerType.None;
			}
		}
	}

	// Token: 0x060110A7 RID: 69799 RVA: 0x0050203C File Offset: 0x0050023C
	private EInputControllerType GetOpenHarmonyDeviceInputController(string deviceName)
	{
		if (deviceName == "None" || deviceName == "")
		{
			return EInputControllerType.None;
		}
		if (deviceName.Contains("Pro Controller"))
		{
			return EInputControllerType.NsPro;
		}
		if (deviceName.Contains("Backbone"))
		{
			return EInputControllerType.BackBone;
		}
		if (deviceName.Contains("PS5") || deviceName.Contains("DualSense"))
		{
			return EInputControllerType.PS5;
		}
		if (deviceName.Contains("PS4"))
		{
			return EInputControllerType.PS4;
		}
		return EInputControllerType.XboxOne;
	}

	// Token: 0x060110A8 RID: 69800 RVA: 0x005020AF File Offset: 0x005002AF
	public bool IsGamepadAttached()
	{
		if (!Platform.Instance.IsPcPlatform())
		{
			return UKismetSystemLibrary.IsGamepadAttached();
		}
		if (!string.IsNullOrEmpty(Platform.Instance.CloudGamePlatform))
		{
			return this.GetCurrentCloudGamePadInputType() > EInputControllerType.None;
		}
		return this.GetCurrentPcDeviceInputController() > EInputControllerType.None;
	}

	// Token: 0x060110A9 RID: 69801 RVA: 0x005020E8 File Offset: 0x005002E8
	public EInputControllerType GetCloudGameInputController()
	{
		EInputControllerType currentCloudGamePadInputType = this.GetCurrentCloudGamePadInputType();
		if (currentCloudGamePadInputType != EInputControllerType.None)
		{
			return currentCloudGamePadInputType;
		}
		if (Platform.Instance.CloudGamePlatform == ECloudGamePlatform.Mac.ToEnumString() || Platform.Instance.CloudGamePlatform == ECloudGamePlatform.Windows.ToEnumString())
		{
			return EInputControllerType.Keyboard;
		}
		return EInputControllerType.Touch;
	}

	// Token: 0x17001985 RID: 6533
	// (get) Token: 0x060110AA RID: 69802 RVA: 0x00502132 File Offset: 0x00500332
	public static PlatformModel Instance
	{
		get
		{
			return PlatformModel._Instance;
		}
	}

	// Token: 0x060110AB RID: 69803 RVA: 0x00502139 File Offset: 0x00500339
	public static PlatformModel GetOrCreateInstance()
	{
		if (PlatformModel._Instance == null)
		{
			PlatformModel.CreateInstance();
		}
		return PlatformModel._Instance;
	}

	// Token: 0x060110AC RID: 69804 RVA: 0x0050214D File Offset: 0x0050034D
	public static bool CreateInstance()
	{
		if (PlatformModel._Instance != null)
		{
			return true;
		}
		PlatformModel._Instance = new PlatformModel();
		return true;
	}

	// Token: 0x060110AD RID: 69805 RVA: 0x00502163 File Offset: 0x00500363
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060110AE RID: 69806 RVA: 0x00502165 File Offset: 0x00500365
	public static void ResetStaticDefaultValue()
	{
		PlatformModel._Instance = null;
	}

	// Token: 0x060110AF RID: 69807 RVA: 0x0050216D File Offset: 0x0050036D
	static PlatformModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformModel.CreateStaticDefaultValue), new Action(PlatformModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400960A RID: 38410
	public bool LastGamepadAttachedState;

	// Token: 0x0400960B RID: 38411
	[Nullable(2)]
	private static PlatformModel _Instance;
}
