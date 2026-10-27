using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001DC RID: 476
	public class LauncherSdk : IStaticVariableResetter
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x0004D06C File Offset: 0x0004B26C
		static LauncherSdk()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherSdk.CreateStaticDefaultValue), new Action(LauncherSdk.ResetStaticDefaultValue));
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0004D08B File Offset: 0x0004B28B
		public static bool canUseSdk()
		{
			return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		[NullableContext(1)]
		public static LauncherSdkBase Get()
		{
			Platform instance = Platform.Instance;
			if (LauncherSdk.LauncherSdkInstance != null)
			{
				return LauncherSdk.LauncherSdkInstance;
			}
			if (!LauncherSdk.canUseSdk())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkBase();
			}
			else if (instance.IsAndroidPlatform())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkAndroid();
			}
			else if (instance.IsIOSPlatform())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkIosGlobal();
			}
			else if (instance.IsOpenHarmonyPlatform())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkOpenHarmony();
			}
			else if (instance.IsWindowsOnlyPlatform())
			{
				if (instance.CloudGamePlatform == ECloudGamePlatform.Android.ToEnumString() || instance.CloudGamePlatform == ECloudGamePlatform.IOS.ToEnumString() || instance.CloudGamePlatform == ECloudGamePlatform.Mac.ToEnumString() || instance.CloudGamePlatform == ECloudGamePlatform.Windows.ToEnumString())
				{
					LauncherSdk.LauncherSdkInstance = new LauncherSdkCloud();
				}
				else
				{
					LauncherSdk.LauncherSdkInstance = (LauncherSdk.IsGlobalSdk() ? new LauncherSdkWindowsGlobal() : new LauncherSdkWindows());
				}
			}
			else if (instance.IsMacPlatform())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkMacGlobal();
			}
			else if (instance.IsXboxPlatform())
			{
				LauncherSdk.LauncherSdkInstance = new LauncherSdkXboxGlobal();
			}
			if (LauncherSdk.LauncherSdkInstance == null)
			{
				LauncherLog.Instance.Error("LauncherSdkInstance is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				LauncherSdk.LauncherSdkInstance = new LauncherSdkBase();
			}
			return LauncherSdk.LauncherSdkInstance;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0004D209 File Offset: 0x0004B409
		public static void Init()
		{
			LauncherSdk.Get().Init();
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0004D215 File Offset: 0x0004B415
		public static bool IsGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN" || (PlatformSdkManagerNew.Instance.IsSdkOn && PlatformSdkConfig.Instance.IsGlobal);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0004D24C File Offset: 0x0004B44C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0004D24E File Offset: 0x0004B44E
		public static void ResetStaticDefaultValue()
		{
			LauncherSdk.LauncherSdkInstance = null;
		}

		// Token: 0x040007EA RID: 2026
		[Nullable(2)]
		private static LauncherSdkBase LauncherSdkInstance;
	}
}
