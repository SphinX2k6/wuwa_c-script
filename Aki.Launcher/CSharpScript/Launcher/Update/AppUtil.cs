using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000088 RID: 136
	[NullableContext(1)]
	[Nullable(0)]
	public class AppUtil
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0002F793 File Offset: 0x0002D993
		public static void SetWorldContext(UObject worldContext)
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002F798 File Offset: 0x0002D998
		public static void QuitGame(string reason = "")
		{
			if (Platform.Instance.IsPs5Platform())
			{
				LauncherLog.Instance.Error("Ps平台不允许主动退出", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (Platform.Instance.IsCloudGameRunningHotPatch())
			{
				KuroApplication.ExitWithCode(false, reason, 1);
				return;
			}
			KuroApplication.ExitWithReason(false, reason);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public unsafe static void QuitGameOnPatchSuccess(string reason = "", bool hasUpdate = true)
		{
			if (!Platform.Instance.IsCloudGameRunningHotPatch())
			{
				return;
			}
			int num = hasUpdate ? 0 : 2;
			LauncherLog instance = LauncherLog.Instance;
			string message = "[ExitCode] QuitGameOnPatchSuccess";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("hasUpdate", hasUpdate);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("exitCode", num);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			KuroApplication.ExitWithCode(false, reason, num);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002F884 File Offset: 0x0002DA84
		public unsafe static ENetworkType GetNetworkConnectionType()
		{
			string text = KuroApplication.IniPlatformName();
			if (text != "Android" && text != "IOS" && text != "OpenHarmony")
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "当前非安卓、鸿蒙、ios平台, 网络类型无法判断, 默认Ethernet";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("platform", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("networkType", ENetworkType.Ethernet);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return ENetworkType.Ethernet;
			}
			return (ENetworkType)UKuroLauncherLibrary.GetNetworkConnectionType();
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0002F919 File Offset: 0x0002DB19
		public static bool IsPioneerApp()
		{
			return BaseConfigController.Instance.GetPublicValue("AppTag") == "Pioneer";
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0002F934 File Offset: 0x0002DB34
		public static string GetAppVersion()
		{
			return UKuroLauncherLibrary.GetAppVersion();
		}

		// Token: 0x040002FE RID: 766
		private const string PIONEER_APP_TAG = "Pioneer";
	}
}
