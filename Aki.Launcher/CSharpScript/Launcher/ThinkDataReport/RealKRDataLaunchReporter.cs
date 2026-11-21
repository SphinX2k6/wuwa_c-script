using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher.ThinkDataReport
{
	// Token: 0x02000102 RID: 258
	public class RealKRDataLaunchReporter
	{
		// Token: 0x0600089C RID: 2204 RVA: 0x00040978 File Offset: 0x0003EB78
		public unsafe static void InitializeInstance()
		{
			if (BaseConfigController.Instance.GetIosAuditFirstDownloadTipWithSkip())
			{
				return;
			}
			EntryJson entryJson = BaseConfigModel.Instance.EntryJson;
			ITDConfig itdconfig = (entryJson != null) ? entryJson.KDCfg : null;
			if (itdconfig != null)
			{
				RealKRDataLaunchReporter.InitializeDefaultInstanceWithUrlAppId((itdconfig != null) ? itdconfig.URL : null, (itdconfig != null) ? itdconfig.AppID : null);
				RealKRDataLaunchReporter.CalibrateInstanceTime();
				LauncherLog instance = LauncherLog.Instance;
				string message = "[KuroData] 启动创建KuroData实例";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Url", (itdconfig != null) ? itdconfig.URL : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AppID", (itdconfig != null) ? itdconfig.AppID : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Index", 0);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			LauncherLog.Instance.Error("[KuroData] CDN下发数据未配置KuroData上报相关配置，创建上报实例失败！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00040A6C File Offset: 0x0003EC6C
		[NullableContext(2)]
		private unsafe static void InitializeDefaultInstanceWithUrlAppId(string serverUrl = null, string appId = null)
		{
			bool flag = false;
			string text = null;
			string text2 = null;
			if (UKuroAnalytics.HasInstanceInitialized(0))
			{
				if (serverUrl != null)
				{
					text = UKuroAnalytics.GetServerUrl(0);
					if (text != serverUrl)
					{
						flag = true;
					}
				}
				if (appId != null)
				{
					text2 = UKuroAnalytics.GetAppId(0);
					if (text2 != appId)
					{
						flag = true;
					}
				}
				if (flag)
				{
					UKuroAnalytics.DestroyInstance(0, false);
				}
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "[KuroData] InitializeDefaultInstanceWithUrlAppId";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("needRemoveInstance", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldServerUrl", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("oldAppId", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("serverUrl", serverUrl);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AppId", appId);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			if (serverUrl != null && appId != null)
			{
				UKuroAnalytics.InitializeDefaultInsWithURL_Appid(serverUrl, appId, 1f, 1000, 10000f, true, 10f, true);
			}
			else
			{
				UKuroAnalytics.Initialize();
			}
			ThinkDataLaunchReporter.Instance.ClientVersion = BaseConfigController.Instance.GetVersionString();
			UKuroAnalytics.Logout(0);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00040BA0 File Offset: 0x0003EDA0
		private static void OnTimeCalibrateEnd(int index)
		{
			if (!UKuroAnalytics.HasInstanceTimeCalibrated(index))
			{
				LauncherLog.Instance.Info("[KuroData] KuroData上报时间校准失败，可以因为以下问题导致：1.CDN KuroData上报配置错误；2.网络原因连接不上。", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00040BD0 File Offset: 0x0003EDD0
		public static void CalibrateInstanceTime()
		{
			Action<int> callback;
			if ((callback = RealKRDataLaunchReporter.<>O.<0>__OnTimeCalibrateEnd) == null)
			{
				callback = (RealKRDataLaunchReporter.<>O.<0>__OnTimeCalibrateEnd = new Action<int>(RealKRDataLaunchReporter.OnTimeCalibrateEnd));
			}
			FKAOnTimeCalibrated fkaonTimeCalibrated = DelegateUtils.ToManualReleaseDelegate<FKAOnTimeCalibrated>(callback);
			UKuroAnalytics.CalibrateTime(fkaonTimeCalibrated, 0);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00040C06 File Offset: 0x0003EE06
		[NullableContext(1)]
		public static void Report(string key, string jsonLog)
		{
			FKuroAnalyticsForCSharp.Track(key, jsonLog, 0);
		}

		// Token: 0x020003A5 RID: 933
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040012FD RID: 4861
			public static Action<int> <0>__OnTimeCalibrateEnd;
		}
	}
}
