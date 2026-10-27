using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000069 RID: 105
	public class LauncherDeviceTierLib : IStaticVariableResetter
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000E0CB File Offset: 0x0000C2CB
		static LauncherDeviceTierLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherDeviceTierLib.CreateStaticDefaultValue), new Action(LauncherDeviceTierLib.ResetStaticDefaultValue));
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000E0EA File Offset: 0x0000C2EA
		public static void CreateStaticDefaultValue()
		{
			LauncherDeviceTierLib.CommandLineTier = null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000E0F7 File Offset: 0x0000C2F7
		public static void ResetStaticDefaultValue()
		{
			LauncherDeviceTierLib.CommandLineTier = null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000E104 File Offset: 0x0000C304
		[NullableContext(1)]
		public static string TierToLabel(ETier tier)
		{
			switch (tier)
			{
			case ETier.SD:
				return "SD";
			case ETier.HD:
				return "HD";
			case ETier.UHD:
				return "UHD";
			}
			return "";
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000E135 File Offset: 0x0000C335
		[NullableContext(2)]
		public static ETier LabelToTier(string label)
		{
			if (label == "UHD")
			{
				return ETier.UHD;
			}
			if (label == "HD")
			{
				return ETier.HD;
			}
			if (!(label == "SD"))
			{
				return ETier.None;
			}
			return ETier.SD;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000E168 File Offset: 0x0000C368
		public static ETier GetCommandLineTier()
		{
			if (LauncherDeviceTierLib.CommandLineTier != null)
			{
				return LauncherDeviceTierLib.CommandLineTier.Value;
			}
			LauncherDeviceTierLib.CommandLineTier = new ETier?(ETier.None);
			Match match = Regex.Match(UKismetSystemLibrary.GetCommandLine(), "(?:^|\\s)-krqlv=(\\S+)", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				ETier etier = LauncherDeviceTierLib.LabelToTier(match.Groups[1].Value.ToUpper());
				if (etier != ETier.None)
				{
					LauncherDeviceTierLib.CommandLineTier = new ETier?(etier);
				}
				else
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "GetCommandLineTier-无法识别的档位参数";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("krqlv", match.Groups[1].Value);
					instance.Warn(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			return LauncherDeviceTierLib.CommandLineTier.Value;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000E21C File Offset: 0x0000C41C
		public unsafe static ETier GetActiveTier()
		{
			if (Platform.Instance.IsWindowsPlatform())
			{
				return LauncherDeviceTierLib.GetCommandLineTier();
			}
			if (Platform.Instance.IsOpenHarmonyPlatform())
			{
				return ETier.None;
			}
			if (!Platform.Instance.IsMobilePlatform())
			{
				return ETier.None;
			}
			if (BaseConfigController.Instance.GetPublicValue("UseSDK") != "1")
			{
				ETier commandLineTier = LauncherDeviceTierLib.GetCommandLineTier();
				ETier etier = (commandLineTier == ETier.None) ? ETier.HD : commandLineTier;
				LauncherLog instance = LauncherLog.Instance;
				string message = "GetActiveTier-非SDK移动端确定资源档位";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tier", LauncherDeviceTierLib.TierToLabel(etier));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("source", (commandLineTier == ETier.None) ? "默认HD" : "命令行");
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return etier;
			}
			int? deviceSaved = LauncherStorageLib.Instance.GetDeviceSaved<int?>(ELauncherStorageDeviceKey.ResourceQualityTier, null);
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "GetActiveTier-读取本地档位记录";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("saved", (ETier)((deviceSaved != null) ? deviceSaved.Value : 0));
			instance2.Info(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (deviceSaved == null)
			{
				return ETier.None;
			}
			ETier value = (ETier)deviceSaved.Value;
			if (value != ETier.SD && value != ETier.HD && value != ETier.UHD)
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "GetActiveTier-本地档位记录非法";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("saved", value);
				instance3.Warn(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return ETier.None;
			}
			return value;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E390 File Offset: 0x0000C590
		public static ETier GetHighestSupportTier()
		{
			List<ETier> deviceSupportTiers = LauncherDeviceTierLib.GetDeviceSupportTiers();
			if (deviceSupportTiers.Count == 0)
			{
				return LauncherDeviceTierLib.GetRecommendedTier();
			}
			ETier etier = deviceSupportTiers[0];
			foreach (ETier etier2 in deviceSupportTiers)
			{
				if (etier2 > etier)
				{
					etier = etier2;
				}
			}
			return etier;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		[NullableContext(1)]
		public static List<ETier> GetDeviceSupportTiers()
		{
			LauncherDeviceTierLib.EDeviceCategory edeviceCategory = LauncherDeviceTierLib.ComputeDeviceCategory();
			if (edeviceCategory == LauncherDeviceTierLib.EDeviceCategory.IOS_LOWEST || edeviceCategory == LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOWEST)
			{
				return new List<ETier>
				{
					ETier.SD
				};
			}
			return new List<ETier>
			{
				ETier.SD,
				ETier.HD
			};
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E438 File Offset: 0x0000C638
		public static ETier GetRecommendedTier()
		{
			switch (LauncherDeviceTierLib.ComputeDeviceCategory())
			{
			case LauncherDeviceTierLib.EDeviceCategory.IOS_LOWEST:
			case LauncherDeviceTierLib.EDeviceCategory.IOS_LOW:
			case LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOWEST:
			case LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOW:
			case LauncherDeviceTierLib.EDeviceCategory.PC_LOWEST:
			case LauncherDeviceTierLib.EDeviceCategory.PC_LOW:
				return ETier.SD;
			case LauncherDeviceTierLib.EDeviceCategory.IOS_MIDDLE:
			case LauncherDeviceTierLib.EDeviceCategory.IOS_HIGH:
			case LauncherDeviceTierLib.EDeviceCategory.IOS_VERY_HIGH:
			case LauncherDeviceTierLib.EDeviceCategory.ANDROID_MIDDLE:
			case LauncherDeviceTierLib.EDeviceCategory.ANDROID_HIGH:
			case LauncherDeviceTierLib.EDeviceCategory.ANDROID_VERY_HIGH:
			case LauncherDeviceTierLib.EDeviceCategory.PC_MIDDLE:
			case LauncherDeviceTierLib.EDeviceCategory.PC_HIGH:
				return ETier.HD;
			case LauncherDeviceTierLib.EDeviceCategory.PC_VERY_HIGH:
			case LauncherDeviceTierLib.EDeviceCategory.PC_HIGHEST:
				return ETier.UHD;
			default:
				return ETier.None;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000E49C File Offset: 0x0000C69C
		private static LauncherDeviceTierLib.EDeviceCategory ComputeDeviceCategory()
		{
			string a = KuroApplication.IniPlatformName();
			if (a == "IOS")
			{
				return LauncherDeviceTierLib.ComputeIosCategory();
			}
			if (a == "Android")
			{
				return LauncherDeviceTierLib.ComputeAndroidCategory();
			}
			if (a == "Windows")
			{
				return LauncherDeviceTierLib.ComputeWindowsCategory();
			}
			return LauncherDeviceTierLib.EDeviceCategory.OTHER;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		private static LauncherDeviceTierLib.EDeviceCategory ComputeIosCategory()
		{
			int deviceProfileDeviceScore = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileDeviceScore();
			LauncherDeviceTierLib.EDeviceCategory result = LauncherDeviceTierLib.EDeviceCategory.IOS_LOW;
			if (deviceProfileDeviceScore < 150)
			{
				result = LauncherDeviceTierLib.EDeviceCategory.IOS_LOWEST;
			}
			else if (deviceProfileDeviceScore > 250 && deviceProfileDeviceScore < 360)
			{
				result = LauncherDeviceTierLib.EDeviceCategory.IOS_MIDDLE;
			}
			else if (deviceProfileDeviceScore >= 360 && deviceProfileDeviceScore < 650)
			{
				result = LauncherDeviceTierLib.EDeviceCategory.IOS_HIGH;
			}
			else if (deviceProfileDeviceScore >= 650)
			{
				result = LauncherDeviceTierLib.EDeviceCategory.IOS_VERY_HIGH;
			}
			if (UKuroStaticLibrary.IsLowMemoryDevice())
			{
				result = LauncherDeviceTierLib.EDeviceCategory.IOS_LOWEST;
			}
			return result;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000E54C File Offset: 0x0000C74C
		private static LauncherDeviceTierLib.EDeviceCategory ComputeAndroidCategory()
		{
			string deviceProfileBaseProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileBaseProfileName();
			if (deviceProfileBaseProfileName == "Android_Lowest")
			{
				return LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOWEST;
			}
			if (deviceProfileBaseProfileName == "Android_Low")
			{
				return LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOW;
			}
			if (deviceProfileBaseProfileName == "Android_Mid")
			{
				return LauncherDeviceTierLib.EDeviceCategory.ANDROID_MIDDLE;
			}
			if (deviceProfileBaseProfileName == "Android_High")
			{
				return LauncherDeviceTierLib.EDeviceCategory.ANDROID_HIGH;
			}
			if (!(deviceProfileBaseProfileName == "Android_VeryHigh"))
			{
				return LauncherDeviceTierLib.EDeviceCategory.ANDROID_LOW;
			}
			return LauncherDeviceTierLib.EDeviceCategory.ANDROID_VERY_HIGH;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		private static LauncherDeviceTierLib.EDeviceCategory ComputeWindowsCategory()
		{
			string deviceProfileBaseProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileBaseProfileName();
			if (deviceProfileBaseProfileName != null)
			{
				switch (deviceProfileBaseProfileName.Length)
				{
				case 7:
					if (deviceProfileBaseProfileName == "Windows")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_HIGH;
					}
					break;
				case 11:
				{
					char c = deviceProfileBaseProfileName[8];
					if (c != 'L')
					{
						if (c == 'M')
						{
							if (deviceProfileBaseProfileName == "Windows_Mid")
							{
								return LauncherDeviceTierLib.EDeviceCategory.PC_MIDDLE;
							}
						}
					}
					else if (deviceProfileBaseProfileName == "Windows_Low")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_LOW;
					}
					break;
				}
				case 12:
					if (deviceProfileBaseProfileName == "Windows_High")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_HIGH;
					}
					break;
				case 14:
					if (deviceProfileBaseProfileName == "Windows_Lowest")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_LOWEST;
					}
					break;
				case 15:
					if (deviceProfileBaseProfileName == "Windows_Highest")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_HIGHEST;
					}
					break;
				case 16:
					if (deviceProfileBaseProfileName == "Windows_VeryHigh")
					{
						return LauncherDeviceTierLib.EDeviceCategory.PC_VERY_HIGH;
					}
					break;
				}
			}
			return LauncherDeviceTierLib.EDeviceCategory.PC_MIDDLE;
		}

		// Token: 0x040001BE RID: 446
		private const int IOS_LOWEST_SCORE = 150;

		// Token: 0x040001BF RID: 447
		private const int IOS_MIDDLE_SCORE_MIN = 250;

		// Token: 0x040001C0 RID: 448
		private const int IOS_MIDDLE_SCORE_MAX = 360;

		// Token: 0x040001C1 RID: 449
		private const int IOS_HIGH_SCORE = 360;

		// Token: 0x040001C2 RID: 450
		private const int IOS_VERY_HIGH_SCORE = 650;

		// Token: 0x040001C3 RID: 451
		private static ETier? CommandLineTier;

		// Token: 0x020002C3 RID: 707
		private enum EDeviceCategory
		{
			// Token: 0x04000AED RID: 2797
			IOS_LOWEST,
			// Token: 0x04000AEE RID: 2798
			IOS_LOW,
			// Token: 0x04000AEF RID: 2799
			IOS_MIDDLE,
			// Token: 0x04000AF0 RID: 2800
			IOS_HIGH,
			// Token: 0x04000AF1 RID: 2801
			IOS_VERY_HIGH,
			// Token: 0x04000AF2 RID: 2802
			ANDROID_LOWEST,
			// Token: 0x04000AF3 RID: 2803
			ANDROID_LOW,
			// Token: 0x04000AF4 RID: 2804
			ANDROID_MIDDLE,
			// Token: 0x04000AF5 RID: 2805
			ANDROID_HIGH,
			// Token: 0x04000AF6 RID: 2806
			ANDROID_VERY_HIGH,
			// Token: 0x04000AF7 RID: 2807
			PC_LOWEST,
			// Token: 0x04000AF8 RID: 2808
			PC_LOW,
			// Token: 0x04000AF9 RID: 2809
			PC_MIDDLE,
			// Token: 0x04000AFA RID: 2810
			PC_HIGH,
			// Token: 0x04000AFB RID: 2811
			PC_VERY_HIGH,
			// Token: 0x04000AFC RID: 2812
			PC_HIGHEST,
			// Token: 0x04000AFD RID: 2813
			OTHER
		}
	}
}
