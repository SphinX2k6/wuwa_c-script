using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchPushSdk
{
	// Token: 0x020001D5 RID: 469
	public class HotPatchPushSdk
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x0004E603 File Offset: 0x0004C803
		public static bool IfCanUsePush()
		{
			return false;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0004E608 File Offset: 0x0004C808
		public static void StartPush()
		{
			if (!HotPatchPushSdk.IfCanUsePush())
			{
				LauncherLog.Instance.Info("不可使用push push 初始化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			string publicValue = BaseConfigController.Instance.GetPublicValue("PushAppId");
			string publicValue2 = BaseConfigController.Instance.GetPublicValue("PushAppKey");
			string publicValue3 = BaseConfigController.Instance.GetPublicValue("PushAppSecret");
			LauncherLog.Instance.Debug("push appId" + publicValue, default(ReadOnlySpan<ValueTuple<string, object>>));
			LauncherLog.Instance.Debug("push appKey" + publicValue2, default(ReadOnlySpan<ValueTuple<string, object>>));
			LauncherLog.Instance.Debug("push appSecret" + publicValue3, default(ReadOnlySpan<ValueTuple<string, object>>));
			if (LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.NotFirstTimeOpenPush, false))
			{
				LauncherStorageLib.Instance.GetGlobal<bool>(ELauncherStorageGlobalKey.CachePushOpenState, false);
				return;
			}
			LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.NotFirstTimeOpenPush, true);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
		[NullableContext(1)]
		public static void SendLocalPush(string title, string desc, string exData)
		{
			if (!HotPatchPushSdk.IfCanUsePush())
			{
				LauncherLog.Instance.Info("SendLocalPush", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0004E714 File Offset: 0x0004C914
		[Conditional("KURO_PUSH_SDK")]
		public static void TurnOnPush()
		{
			if (!HotPatchPushSdk.IfCanUsePush())
			{
				return;
			}
			UKuroPushSdkStaticLibrary.TurnOnPush();
			LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.CachePushOpenState, true);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004E730 File Offset: 0x0004C930
		[Conditional("KURO_PUSH_SDK")]
		public static void TurnOffPush()
		{
			if (!HotPatchPushSdk.IfCanUsePush())
			{
				return;
			}
			UKuroPushSdkStaticLibrary.TurnOffPush();
			LauncherStorageLib.Instance.SetGlobal<bool>(ELauncherStorageGlobalKey.CachePushOpenState, false);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0004E74C File Offset: 0x0004C94C
		public static bool GetPushState()
		{
			HotPatchPushSdk.IfCanUsePush();
			return false;
		}
	}
}
