using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E1 RID: 481
	public class LauncherSdk : IStaticVariableResetter
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x0004F888 File Offset: 0x0004DA88
		static LauncherSdk()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherSdk.CreateStaticDefaultValue), new Action(LauncherSdk.ResetStaticDefaultValue));
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0004F8A7 File Offset: 0x0004DAA7
		public static bool canUseSdk()
		{
			return !PlatformSdkManagerNew.Instance.IsSdkOn && UKuroStaticLibrary.IsModuleLoaded("KuroSDK") && BaseConfigController.Instance.GetPublicValue("UseSDK") == "1";
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0004F8DC File Offset: 0x0004DADC
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

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0004FA25 File Offset: 0x0004DC25
		public static void Init()
		{
			LauncherSdk.Get().Init();
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0004FA31 File Offset: 0x0004DC31
		public static bool IsGlobalSdk()
		{
			return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN" || (PlatformSdkManagerNew.Instance.IsSdkOn && PlatformSdkConfig.Instance.IsGlobal);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0004FA68 File Offset: 0x0004DC68
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004FA6A File Offset: 0x0004DC6A
		public static void ResetStaticDefaultValue()
		{
			LauncherSdkBase launcherSdkInstance = LauncherSdk.LauncherSdkInstance;
			if (launcherSdkInstance != null)
			{
				launcherSdkInstance.ClearFoldStateChangeCallback();
			}
			LauncherSdk.LauncherSdkInstance = null;
		}

		// Token: 0x04000828 RID: 2088
		[Nullable(2)]
		private static LauncherSdkBase LauncherSdkInstance;
	}
}
