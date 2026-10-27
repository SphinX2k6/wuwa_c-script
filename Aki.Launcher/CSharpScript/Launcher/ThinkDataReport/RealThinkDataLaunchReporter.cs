using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.ThinkDataReport
{
	// Token: 0x020000FD RID: 253
	public class RealThinkDataLaunchReporter
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x0003E334 File Offset: 0x0003C534
		public unsafe static void InitializeInstance()
		{
			if (BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
			{
				return;
			}
			EntryJson entryJson = BaseConfigModel.Instance.EntryJson;
			ITDConfig itdconfig = (entryJson != null) ? entryJson.TDCfg : null;
			if (itdconfig != null)
			{
				RealThinkDataLaunchReporter.InitializeDefaultInstanceWithUrlAppId((itdconfig != null) ? itdconfig.URL : null, (itdconfig != null) ? itdconfig.AppID : null);
				RealThinkDataLaunchReporter.CalibrateInstanceTime();
				LauncherLog instance = LauncherLog.Instance;
				string message = "[数数] 启动创建数数实例";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Url", (itdconfig != null) ? itdconfig.URL : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AppID", (itdconfig != null) ? itdconfig.AppID : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Index", 0);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			LauncherLog.Instance.Error("[数数] CDN下发数据未配置数数上报相关配置，创建上报实例失败！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003E428 File Offset: 0x0003C628
		[NullableContext(2)]
		private unsafe static void InitializeDefaultInstanceWithUrlAppId(string serverUrl = null, string appId = null)
		{
			bool flag = false;
			string text = null;
			string text2 = null;
			if (UThinkingAnalytics.HasInstanceInitialized(0))
			{
				if (serverUrl != null)
				{
					text = UThinkingAnalytics.GetServerUrl(0);
					if (text != serverUrl)
					{
						flag = true;
					}
				}
				if (appId != null)
				{
					text2 = UThinkingAnalytics.GetAppId(0);
					if (text2 != appId)
					{
						flag = true;
					}
				}
				if (flag)
				{
					UThinkingAnalytics.DestroyInstance(0, false);
				}
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "[数数] InitializeDefaultInstanceWithUrlAppId";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("needRemoveInstance", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldServerUrl", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("oldAppId", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("serverUrl", serverUrl);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AppId", appId);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (serverUrl != null && appId != null)
			{
				UThinkingAnalytics.InitializeDefaultInsWithURL_Appid(serverUrl, appId, 1f, 1000, 10000f, true, 10f, true);
			}
			else
			{
				UThinkingAnalytics.Initialize();
			}
			ThinkDataLaunchReporter.Instance.ClientVersion = BaseConfigController.Instance.GetVersionString();
			UThinkingAnalytics.Logout(0);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0003E55C File Offset: 0x0003C75C
		private static void OnTimeCalibrateEnd(int index)
		{
			if (!UThinkingAnalytics.HasInstanceTimeCalibrated(index))
			{
				LauncherLog.Instance.Info("[数数] 数数上报时间校准失败，可以因为以下问题导致：1.CDN数数上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0003E58C File Offset: 0x0003C78C
		public static void CalibrateInstanceTime()
		{
			Action<int> callback;
			if ((callback = RealThinkDataLaunchReporter.<>O.<0>__OnTimeCalibrateEnd) == null)
			{
				callback = (RealThinkDataLaunchReporter.<>O.<0>__OnTimeCalibrateEnd = new Action<int>(RealThinkDataLaunchReporter.OnTimeCalibrateEnd));
			}
			FOnTimeCalibrated fonTimeCalibrated = DelegateUtils.ToManualReleaseDelegate<FOnTimeCalibrated>(callback);
			UThinkingAnalytics.CalibrateTime(fonTimeCalibrated, 0);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0003E5C2 File Offset: 0x0003C7C2
		[NullableContext(1)]
		public static void Report(string key, string jsonLog)
		{
			FThinkingAnalyticsForCSharp.Track(key, jsonLog, 0);
		}

		// Token: 0x02000397 RID: 919
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001286 RID: 4742
			public static Action<int> <0>__OnTimeCalibrateEnd;
		}
	}
}
