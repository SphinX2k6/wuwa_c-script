using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.HotPatchPushSdk
{
	// Token: 0x020001D1 RID: 465
	public class HotPatchPushSdk
	{
		// Token: 0x06000C56 RID: 3158 RVA: 0x0004BDEF File Offset: 0x00049FEF
		public static bool IfCanUsePush()
		{
			return false;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0004BDF4 File Offset: 0x00049FF4
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

		// Token: 0x06000C58 RID: 3160 RVA: 0x0004BED4 File Offset: 0x0004A0D4
		[NullableContext(1)]
		public static void SendLocalPush(string title, string desc, string exData)
		{
			if (!HotPatchPushSdk.IfCanUsePush())
			{
				LauncherLog.Instance.Info("SendLocalPush", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0004BF00 File Offset: 0x0004A100
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

		// Token: 0x06000C5A RID: 3162 RVA: 0x0004BF1C File Offset: 0x0004A11C
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x0004BF38 File Offset: 0x0004A138
		public static bool GetPushState()
		{
			HotPatchPushSdk.IfCanUsePush();
			return false;
		}
	}
}
