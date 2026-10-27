using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Launcher.InputDevice
{
	// Token: 0x020001D0 RID: 464
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDevice : Singleton
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0004B6A8 File Offset: 0x000498A8
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

		// Token: 0x06000C42 RID: 3138 RVA: 0x0004B770 File Offset: 0x00049970
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

		// Token: 0x06000C43 RID: 3139 RVA: 0x0004B838 File Offset: 0x00049A38
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

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004B974 File Offset: 0x00049B74
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

		// Token: 0x06000C45 RID: 3141 RVA: 0x0004BBC0 File Offset: 0x00049DC0
		private void SwitchInputControllerType(EInputControllerType inputControllerType)
		{
			this.SetInputControllerType(inputControllerType);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0004BBC9 File Offset: 0x00049DC9
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

		// Token: 0x06000C47 RID: 3143 RVA: 0x0004BC05 File Offset: 0x00049E05
		public void SwitchInputControllerTypeByMouseMove()
		{
			this.SwitchInputControllerType(EInputControllerType.Keyboard);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0004BC0E File Offset: 0x00049E0E
		public void RegisterInputChangeDelegate(Action<EInputControllerType, EInputControllerType> inputChangeDelegate)
		{
			this.InputChangeDelegateSet.Add(inputChangeDelegate);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0004BC1D File Offset: 0x00049E1D
		public void UnRegisterInputChangeDelegate(Action<EInputControllerType, EInputControllerType> inputChangeDelegate)
		{
			this.InputChangeDelegateSet.Remove(inputChangeDelegate);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0004BC2C File Offset: 0x00049E2C
		public bool IsInKeyBoard()
		{
			return this.TypeInternal == EInputControllerType.Keyboard;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0004BC37 File Offset: 0x00049E37
		public bool IsInTouch()
		{
			return this.TypeInternal == EInputControllerType.Touch;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0004BC42 File Offset: 0x00049E42
		public bool IsInGamepad()
		{
			return this.IsPsGamepad() || this.IsXboxGamepad() || this.IsBackBoneGamepad() || this.IsNsProGamepad();
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0004BC64 File Offset: 0x00049E64
		public bool IsPsGamepad()
		{
			return this.TypeInternal == EInputControllerType.PS4 || this.TypeInternal == EInputControllerType.PS5;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0004BC7A File Offset: 0x00049E7A
		public bool IsXboxGamepad()
		{
			return this.TypeInternal == EInputControllerType.XboxOne;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0004BC85 File Offset: 0x00049E85
		public bool IsBackBoneGamepad()
		{
			return this.TypeInternal == EInputControllerType.BackBone;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0004BC90 File Offset: 0x00049E90
		public bool IsNsProGamepad()
		{
			return this.TypeInternal == EInputControllerType.NsPro;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0004BC9B File Offset: 0x00049E9B
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

		// Token: 0x06000C52 RID: 3154 RVA: 0x0004BCBE File Offset: 0x00049EBE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0004BCC0 File Offset: 0x00049EC0
		public static void ResetStaticDefaultValue()
		{
			InputDevice instance = InputDevice._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputDevice._instance = null;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0004BCDC File Offset: 0x00049EDC
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

		// Token: 0x040007B9 RID: 1977
		public const string DualSenseWirelessController = "1356_3302";

		// Token: 0x040007BA RID: 1978
		public const string DualSenseEdgeWirelessController = "1356_3570";

		// Token: 0x040007BB RID: 1979
		public const string DualShock4_Cuhzct1x = "1356_1476";

		// Token: 0x040007BC RID: 1980
		public const string DualShock4_Cuhzct2x = "1356_2508";

		// Token: 0x040007BD RID: 1981
		public const string XboxController = "1118_2834";

		// Token: 0x040007BE RID: 1982
		public const string XboxEliteSeries2Controller = "1118_2816";

		// Token: 0x040007BF RID: 1983
		public const string XboxOneController2015 = "1118_733";

		// Token: 0x040007C0 RID: 1984
		public const string XboxOneWirelessController = "1118_736";

		// Token: 0x040007C1 RID: 1985
		public const string XboxOneEliteController = "1118_739";

		// Token: 0x040007C2 RID: 1986
		public const string XboxOneController = "1118_746";

		// Token: 0x040007C3 RID: 1987
		public const string XboxOneSController = "1118_765";

		// Token: 0x040007C4 RID: 1988
		public const string XboxWirelessAdapterForWindows = "1118_766";

		// Token: 0x040007C5 RID: 1989
		public const string BackboneOne = "13706_770";

		// Token: 0x040007C6 RID: 1990
		public const string NsPro = "1406_8201";

		// Token: 0x040007C7 RID: 1991
		public const string RazerDefault = "5426_*";

		// Token: 0x040007C8 RID: 1992
		public const string RazerWolverineV2Pro = "5426_4112";

		// Token: 0x040007C9 RID: 1993
		public const string RazerRaijuTournament = "5426_4103";

		// Token: 0x040007CA RID: 1994
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, EInputControllerType> deviceIdMap;

		// Token: 0x040007CB RID: 1995
		private EInputControllerType TypeInternal;

		// Token: 0x040007CC RID: 1996
		private readonly HashSet<Action<EInputControllerType, EInputControllerType>> InputChangeDelegateSet = new HashSet<Action<EInputControllerType, EInputControllerType>>();

		// Token: 0x040007CD RID: 1997
		[Nullable(2)]
		private static InputDevice _instance;
	}
}
