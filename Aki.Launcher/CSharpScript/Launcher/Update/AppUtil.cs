using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000085 RID: 133
	[NullableContext(1)]
	[Nullable(0)]
	public class AppUtil
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x0002E22B File Offset: 0x0002C42B
		public static void SetWorldContext(UObject worldContext)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002E230 File Offset: 0x0002C430
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

		// Token: 0x060004BE RID: 1214 RVA: 0x0002E280 File Offset: 0x0002C480
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

		// Token: 0x060004BF RID: 1215 RVA: 0x0002E31C File Offset: 0x0002C51C
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

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002E3B1 File Offset: 0x0002C5B1
		public static bool IsPioneerApp()
		{
			return BaseConfigController.Instance.GetPublicValue("AppTag") == "Pioneer";
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		public static string GetAppVersion()
		{
			return UKuroLauncherLibrary.GetAppVersion();
		}

		// Token: 0x040002D0 RID: 720
		private const string PIONEER_APP_TAG = "Pioneer";
	}
}
