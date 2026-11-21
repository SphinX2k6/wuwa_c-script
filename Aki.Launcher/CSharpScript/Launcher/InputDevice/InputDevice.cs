using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher.InputDevice
{
	// Token: 0x020001D4 RID: 468
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDevice : Singleton
	{
		// Token: 0x06000C78 RID: 3192 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		public void Initialize()
		{
			switch (Platform.Instance.Type)
			{
			case EPlatformType.Android:
			case EPlatformType.IOS:
			case EPlatformType.OpenHarmony:
				this.TypeInternal = EInputControllerType.Touch;
				goto IL_79;
			case EPlatformType.Linux:
			case EPlatformType.Mac:
			case EPlatformType.Windows:
				this.TypeInternal = EInputControllerType.Keyboard;
				goto IL_79;
			case EPlatformType.PS4:
				this.TypeInternal = EInputControllerType.PS4;
				goto IL_79;
			case EPlatformType.PS5:
				this.TypeInternal = EInputControllerType.PS5;
				goto IL_79;
			case EPlatformType.XboxOne:
				this.TypeInternal = EInputControllerType.XboxOne;
				goto IL_79;
			}
			this.TypeInternal = EInputControllerType.Keyboard;
			IL_79:
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]初始化输入类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlatformType", this.TypeInternal);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (!Platform.Instance.IsPcPlatform())
			{
				this.RefreshPlatformByDevice();
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0004DF84 File Offset: 0x0004C184
		private unsafe void SetInputControllerType(EInputControllerType inputControllerType)
		{
			if (this.TypeInternal == inputControllerType)
			{
				return;
			}
			EInputControllerType typeInternal = this.TypeInternal;
			this.TypeInternal = inputControllerType;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]设置输入方式";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("lastInputController", typeInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InputController", this.TypeInternal);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			foreach (Action<EInputControllerType, EInputControllerType> action in this.InputChangeDelegateSet)
			{
				action(typeInternal, inputControllerType);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0004E04C File Offset: 0x0004C24C
		private EInputControllerType? GetCurrentDeviceInputController()
		{
			TArray<FRegisteredDeviceInfo> registeredDevices = URawInputFunctionLibrary.GetRegisteredDevices();
			if (registeredDevices == null || registeredDevices.Num() == 0)
			{
				return null;
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
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				EInputControllerType value;
				if (InputDevice.deviceIdMap.TryGetValue(text, out value))
				{
					return new EInputControllerType?(value);
				}
				foreach (KeyValuePair<string, EInputControllerType> keyValuePair in InputDevice.deviceIdMap)
				{
					int num = keyValuePair.Key.IndexOf("_*", StringComparison.Ordinal);
					if (num > 0 && num == keyValuePair.Key.Length - 2)
					{
						string value2 = keyValuePair.Key.Substring(0, num);
						if (text.StartsWith(value2))
						{
							return new EInputControllerType?(keyValuePair.Value);
						}
					}
				}
			}
			return new EInputControllerType?(EInputControllerType.XboxOne);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0004E188 File Offset: 0x0004C388
		private bool RefreshPlatformByDevice()
		{
			if (Platform.Instance.IsPs5Platform())
			{
				this.SwitchInputControllerType(EInputControllerType.PS5);
				return true;
			}
			if (Platform.Instance.IsPcPlatform())
			{
				EInputControllerType? currentDeviceInputController = this.GetCurrentDeviceInputController();
				if (currentDeviceInputController != null)
				{
					this.SwitchInputControllerType(currentDeviceInputController.Value);
					return true;
				}
			}
			string currentActiveGamepadName = UKismetSystemLibrary.GetCurrentActiveGamepadName();
			LauncherLog instance = LauncherLog.Instance;
			string message = "[PlatformSdkNew]当前激活的手柄";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("设备名", currentActiveGamepadName);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Platform.Instance.IsAndroidPlatform())
			{
				if (currentActiveGamepadName == "None")
				{
					return false;
				}
				EInputControllerType inputControllerType;
				if (InputDevice.deviceIdMap.TryGetValue(currentActiveGamepadName, out inputControllerType))
				{
					this.SwitchInputControllerType(inputControllerType);
					return true;
				}
				foreach (KeyValuePair<string, EInputControllerType> keyValuePair in InputDevice.deviceIdMap)
				{
					int num = keyValuePair.Key.IndexOf("_*", StringComparison.Ordinal);
					if (num > 0 && num == keyValuePair.Key.Length - 2)
					{
						string value = keyValuePair.Key.Substring(0, num);
						if (currentActiveGamepadName.StartsWith(value))
						{
							this.SwitchInputControllerType(keyValuePair.Value);
							return true;
						}
					}
				}
				return false;
			}
			else if (Platform.Instance.IsIOSPlatform())
			{
				if (currentActiveGamepadName == "None")
				{
					return false;
				}
				if (currentActiveGamepadName.Contains("Xbox"))
				{
					this.SwitchInputControllerType(EInputControllerType.XboxOne);
					return true;
				}
				if (currentActiveGamepadName.Contains("DualShock"))
				{
					this.SwitchInputControllerType(EInputControllerType.PS5);
					return true;
				}
				if (currentActiveGamepadName.Contains("BackBoneOne"))
				{
					this.SwitchInputControllerType(EInputControllerType.BackBone);
					return true;
				}
				if (currentActiveGamepadName.Contains("nspro"))
				{
					this.SwitchInputControllerType(EInputControllerType.NsPro);
					return true;
				}
				return false;
			}
			else
			{
				if (!Platform.Instance.IsOpenHarmonyPlatform())
				{
					return false;
				}
				if (currentActiveGamepadName == "None")
				{
					return false;
				}
				if (currentActiveGamepadName.Contains("Pro Controller"))
				{
					this.SwitchInputControllerType(EInputControllerType.NsPro);
					return true;
				}
				if (currentActiveGamepadName.Contains("Backbone"))
				{
					this.SwitchInputControllerType(EInputControllerType.BackBone);
					return true;
				}
				if (currentActiveGamepadName.Contains("PS5") || currentActiveGamepadName.Contains("DualSense"))
				{
					this.SwitchInputControllerType(EInputControllerType.PS5);
					return true;
				}
				if (currentActiveGamepadName.Contains("PS4"))
				{
					this.SwitchInputControllerType(EInputControllerType.PS4);
					return true;
				}
				this.SwitchInputControllerType(EInputControllerType.XboxOne);
				return true;
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0004E3D4 File Offset: 0x0004C5D4
		private void SwitchInputControllerType(EInputControllerType inputControllerType)
		{
			this.SetInputControllerType(inputControllerType);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0004E3DD File Offset: 0x0004C5DD
		public void SwitchInputControllerTypeByKey(FKey key)
		{
			if (UKismetInputLibrary.Key_IsGamepadKey(key))
			{
				if (!this.RefreshPlatformByDevice())
				{
					this.SwitchInputControllerType(EInputControllerType.XboxOne);
					return;
				}
			}
			else
			{
				if (UKismetInputLibrary.Key_IsKeyboardKey(key) || UKismetInputLibrary.Key_IsMouseButton(key))
				{
					this.SwitchInputControllerType(EInputControllerType.Keyboard);
					return;
				}
				this.SwitchInputControllerType(EInputControllerType.Touch);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0004E419 File Offset: 0x0004C619
		public void SwitchInputControllerTypeByMouseMove()
		{
			this.SwitchInputControllerType(EInputControllerType.Keyboard);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0004E422 File Offset: 0x0004C622
		public void RegisterInputChangeDelegate(Action<EInputControllerType, EInputControllerType> inputChangeDelegate)
		{
			this.InputChangeDelegateSet.Add(inputChangeDelegate);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0004E431 File Offset: 0x0004C631
		public void UnRegisterInputChangeDelegate(Action<EInputControllerType, EInputControllerType> inputChangeDelegate)
		{
			this.InputChangeDelegateSet.Remove(inputChangeDelegate);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0004E440 File Offset: 0x0004C640
		public bool IsInKeyBoard()
		{
			return this.TypeInternal == EInputControllerType.Keyboard;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0004E44B File Offset: 0x0004C64B
		public bool IsInTouch()
		{
			return this.TypeInternal == EInputControllerType.Touch;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0004E456 File Offset: 0x0004C656
		public bool IsInGamepad()
		{
			return this.IsPsGamepad() || this.IsXboxGamepad() || this.IsBackBoneGamepad() || this.IsNsProGamepad();
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0004E478 File Offset: 0x0004C678
		public bool IsPsGamepad()
		{
			return this.TypeInternal == EInputControllerType.PS4 || this.TypeInternal == EInputControllerType.PS5;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0004E48E File Offset: 0x0004C68E
		public bool IsXboxGamepad()
		{
			return this.TypeInternal == EInputControllerType.XboxOne;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0004E499 File Offset: 0x0004C699
		public bool IsBackBoneGamepad()
		{
			return this.TypeInternal == EInputControllerType.BackBone;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
		public bool IsNsProGamepad()
		{
			return this.TypeInternal == EInputControllerType.NsPro;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0004E4AF File Offset: 0x0004C6AF
		public static InputDevice Instance
		{
			get
			{
				if (InputDevice._instance == null)
				{
					InputDevice._instance = new InputDevice();
					InputDevice._instance.OnInit();
				}
				return InputDevice._instance;
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0004E4D2 File Offset: 0x0004C6D2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		public static void ResetStaticDefaultValue()
		{
			InputDevice instance = InputDevice._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputDevice._instance = null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004E4F0 File Offset: 0x0004C6F0
		static InputDevice()
		{
			Dictionary<string, EInputControllerType> dictionary = new Dictionary<string, EInputControllerType>();
			dictionary["1356_3302"] = EInputControllerType.PS4;
			dictionary["1356_3570"] = EInputControllerType.PS4;
			dictionary["1356_1476"] = EInputControllerType.PS4;
			dictionary["1356_2508"] = EInputControllerType.PS4;
			dictionary["1118_2834"] = EInputControllerType.XboxOne;
			dictionary["1118_2816"] = EInputControllerType.XboxOne;
			dictionary["1118_733"] = EInputControllerType.XboxOne;
			dictionary["1118_736"] = EInputControllerType.XboxOne;
			dictionary["1118_739"] = EInputControllerType.XboxOne;
			dictionary["1118_746"] = EInputControllerType.XboxOne;
			dictionary["1118_765"] = EInputControllerType.XboxOne;
			dictionary["1118_766"] = EInputControllerType.XboxOne;
			dictionary["13706_770"] = EInputControllerType.BackBone;
			dictionary["1406_8201"] = EInputControllerType.NsPro;
			dictionary["5426_*"] = EInputControllerType.XboxOne;
			dictionary["5426_4112"] = EInputControllerType.PS5;
			dictionary["5426_4103"] = EInputControllerType.PS5;
			InputDevice.deviceIdMap = dictionary;
			StaticVariableRegister.RegisterAndExecute(new Action(InputDevice.CreateStaticDefaultValue), new Action(InputDevice.ResetStaticDefaultValue));
		}

		// Token: 0x040007F6 RID: 2038
		public const string DualSenseWirelessController = "1356_3302";

		// Token: 0x040007F7 RID: 2039
		public const string DualSenseEdgeWirelessController = "1356_3570";

		// Token: 0x040007F8 RID: 2040
		public const string DualShock4_Cuhzct1x = "1356_1476";

		// Token: 0x040007F9 RID: 2041
		public const string DualShock4_Cuhzct2x = "1356_2508";

		// Token: 0x040007FA RID: 2042
		public const string XboxController = "1118_2834";

		// Token: 0x040007FB RID: 2043
		public const string XboxEliteSeries2Controller = "1118_2816";

		// Token: 0x040007FC RID: 2044
		public const string XboxOneController2015 = "1118_733";

		// Token: 0x040007FD RID: 2045
		public const string XboxOneWirelessController = "1118_736";

		// Token: 0x040007FE RID: 2046
		public const string XboxOneEliteController = "1118_739";

		// Token: 0x040007FF RID: 2047
		public const string XboxOneController = "1118_746";

		// Token: 0x04000800 RID: 2048
		public const string XboxOneSController = "1118_765";

		// Token: 0x04000801 RID: 2049
		public const string XboxWirelessAdapterForWindows = "1118_766";

		// Token: 0x04000802 RID: 2050
		public const string BackboneOne = "13706_770";

		// Token: 0x04000803 RID: 2051
		public const string NsPro = "1406_8201";

		// Token: 0x04000804 RID: 2052
		public const string RazerDefault = "5426_*";

		// Token: 0x04000805 RID: 2053
		public const string RazerWolverineV2Pro = "5426_4112";

		// Token: 0x04000806 RID: 2054
		public const string RazerRaijuTournament = "5426_4103";

		// Token: 0x04000807 RID: 2055
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, EInputControllerType> deviceIdMap;

		// Token: 0x04000808 RID: 2056
		private EInputControllerType TypeInternal;

		// Token: 0x04000809 RID: 2057
		private readonly HashSet<Action<EInputControllerType, EInputControllerType>> InputChangeDelegateSet = new HashSet<Action<EInputControllerType, EInputControllerType>>();

		// Token: 0x0400080A RID: 2058
		[Nullable(2)]
		private static InputDevice _instance;
	}
}
