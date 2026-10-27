using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

// Token: 0x020025E8 RID: 9704
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PlatformModel : ModelBase
{
	// Token: 0x06013BB3 RID: 80819 RVA: 0x004F2B94 File Offset: 0x004F0D94
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

	// Token: 0x06013BB4 RID: 80820 RVA: 0x004F2C0C File Offset: 0x004F0E0C
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.InitializeLguiEventSystemActor, new Action(this.OnNotifyCppInputControllerChange));
		Info.Instance.ClearInputTypeChangeFunc();
		Info.Instance.ClearShowTypeChangeFunc();
		Info.Instance.ClearInputMainTypeChangeFunc();
		return true;
	}

	// Token: 0x06013BB5 RID: 80821 RVA: 0x004F2C4C File Offset: 0x004F0E4C
	private void InputTypeChangeFunc(EInputControllerType last, EInputControllerType now)
	{
		this.NotifyAudioStateChange();
		this.NotifyCppInputControllerChange();
		TsCharacterController characterController = Global.CharacterController;
		if (characterController != null && (now == EInputControllerType.PS4 || now == EInputControllerType.PS5))
		{
			UTriggerEffectBPLibrary.SetPadColor(characterController, FColor.FromHex("#0000FF"));
		}
		else
		{
			UTriggerEffectBPLibrary.ResetPadColor(Global.CharacterController);
		}
		EventSystem.Instance.Emit<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, last, now);
	}

	// Token: 0x06013BB6 RID: 80822 RVA: 0x004F2CA4 File Offset: 0x004F0EA4
	private void ShowTypeChangeFunc(EOperationType last, EOperationType now)
	{
		EventSystem.Instance.Emit<EOperationType, EOperationType>(EEventName.ShowTypeChange, last, now);
	}

	// Token: 0x06013BB7 RID: 80823 RVA: 0x004F2CB8 File Offset: 0x004F0EB8
	private void InputMainTypeChangeFunc(EInputControllerMainType last, EInputControllerMainType now)
	{
		EventSystem.Instance.Emit<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, last, now);
	}

	// Token: 0x06013BB8 RID: 80824 RVA: 0x004F2CCC File Offset: 0x004F0ECC
	private void OnNotifyCppInputControllerChange()
	{
		this.NotifyCppInputControllerChange();
	}

	// Token: 0x06013BB9 RID: 80825 RVA: 0x004F2CD4 File Offset: 0x004F0ED4
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

	// Token: 0x06013BBA RID: 80826 RVA: 0x004F2D3C File Offset: 0x004F0F3C
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

	// Token: 0x06013BBB RID: 80827 RVA: 0x004F2DB4 File Offset: 0x004F0FB4
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

	// Token: 0x06013BBC RID: 80828 RVA: 0x004F2E5C File Offset: 0x004F105C
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

	// Token: 0x06013BBD RID: 80829 RVA: 0x004F2EAC File Offset: 0x004F10AC
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

	// Token: 0x06013BBE RID: 80830 RVA: 0x004F2F18 File Offset: 0x004F1118
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

	// Token: 0x06013BBF RID: 80831 RVA: 0x004F2F80 File Offset: 0x004F1180
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

	// Token: 0x06013BC0 RID: 80832 RVA: 0x004F3027 File Offset: 0x004F1227
	public void OnPressAnyKey(FKey key)
	{
		if (Info.Instance.IsMobileInputModel())
		{
			this.HandlePressAnyKeyInMobile(key);
			return;
		}
		this.HandlePressAnyKeyInNotMobile(key);
	}

	// Token: 0x06013BC1 RID: 80833 RVA: 0x004F3044 File Offset: 0x004F1244
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

	// Token: 0x06013BC2 RID: 80834 RVA: 0x004F30DA File Offset: 0x004F12DA
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

	// Token: 0x06013BC3 RID: 80835 RVA: 0x004F310C File Offset: 0x004F130C
	public bool IsKeyFromGamepadKey(string keyName)
	{
		return !keyName.Contains("Android") && !keyName.Contains("OpenHarmony") && InputSettings.Instance.IsGamepadKey(keyName);
	}

	// Token: 0x06013BC4 RID: 80836 RVA: 0x004F3138 File Offset: 0x004F1338
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

	// Token: 0x06013BC5 RID: 80837 RVA: 0x004F32C4 File Offset: 0x004F14C4
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

	// Token: 0x06013BC6 RID: 80838 RVA: 0x004F3337 File Offset: 0x004F1537
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

	// Token: 0x06013BC7 RID: 80839 RVA: 0x004F3370 File Offset: 0x004F1570
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

	// Token: 0x1700194D RID: 6477
	// (get) Token: 0x06013BC8 RID: 80840 RVA: 0x004F33BA File Offset: 0x004F15BA
	public static PlatformModel Instance
	{
		get
		{
			return PlatformModel._Instance;
		}
	}

	// Token: 0x06013BC9 RID: 80841 RVA: 0x004F33C1 File Offset: 0x004F15C1
	public static PlatformModel GetOrCreateInstance()
	{
		if (PlatformModel._Instance == null)
		{
			PlatformModel.CreateInstance();
		}
		return PlatformModel._Instance;
	}

	// Token: 0x06013BCA RID: 80842 RVA: 0x004F33D5 File Offset: 0x004F15D5
	public static bool CreateInstance()
	{
		if (PlatformModel._Instance != null)
		{
			return true;
		}
		PlatformModel._Instance = new PlatformModel();
		return true;
	}

	// Token: 0x06013BCB RID: 80843 RVA: 0x004F33EB File Offset: 0x004F15EB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013BCC RID: 80844 RVA: 0x004F33ED File Offset: 0x004F15ED
	public static void ResetStaticDefaultValue()
	{
		PlatformModel._Instance = null;
	}

	// Token: 0x06013BCD RID: 80845 RVA: 0x004F33F5 File Offset: 0x004F15F5
	static PlatformModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformModel.CreateStaticDefaultValue), new Action(PlatformModel.ResetStaticDefaultValue));
	}

	// Token: 0x040094B3 RID: 38067
	public bool LastGamepadAttachedState;

	// Token: 0x040094B4 RID: 38068
	[Nullable(2)]
	private static PlatformModel _Instance;
}
