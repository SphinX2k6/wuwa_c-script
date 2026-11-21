using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.ThinkDataReport;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Launcher
{
	// Token: 0x0200005B RID: 91
	[NullableContext(1)]
	[Nullable(0)]
	public class HotPatchLogReport : Singleton
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000C953 File Offset: 0x0000AB53
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Nullable(2)]
		public UWorld World
		{
			[NullableContext(2)]
			get
			{
				return this.WorldInternal;
			}
			[NullableContext(2)]
			set
			{
				this.WorldInternal = value;
				if (value != null)
				{
					UKuroPlayerPrefsSystem ukuroPlayerPrefsSystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(value, UKuroPlayerPrefsSystem.StaticClass()) as UKuroPlayerPrefsSystem;
					if (ukuroPlayerPrefsSystem != null && ukuroPlayerPrefsSystem.IsValid())
					{
						string @string = ukuroPlayerPrefsSystem.GetString("LoginDeviceId", UKismetGuidLibrary.NewGuid().ToString());
						ukuroPlayerPrefsSystem.SetString("LoginDeviceId", @string);
						this.DeviceIdInternal = @string;
						LauncherLog instance = LauncherLog.Instance;
						string message = "launcher login device id";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", @string);
						instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						ukuroPlayerPrefsSystem.Save();
					}
					this.VersionInternal = UKuroLauncherLibrary.GetAppVersion() + "(" + BaseConfigController.Instance.GetPackageConfigOrDefault(TBuildInfoKey.Changelist, "") + ")";
					this.PlatformInternal = KuroApplication.IniPlatformName();
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C95B File Offset: 0x0000AB5B
		public string DeviceId
		{
			get
			{
				return this.DeviceIdInternal ?? "";
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public string Platform
		{
			get
			{
				return this.PlatformInternal ?? "";
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000C97D File Offset: 0x0000AB7D
		public string Version
		{
			get
			{
				return this.VersionInternal ?? "";
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C98E File Offset: 0x0000AB8E
		public void Init(string traceId)
		{
			this.StartupTraceId = traceId;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000C998 File Offset: 0x0000AB98
		private string GetReportNetStatus()
		{
			if (this.PlatformInternal == "Android" || this.PlatformInternal == "IOS" || this.PlatformInternal == "OpenHarmony")
			{
				ENetworkType networkConnectionType = (ENetworkType)UKuroLauncherLibrary.GetNetworkConnectionType();
				if (networkConnectionType == ENetworkType.WiFi)
				{
					return "Wifi";
				}
				if (networkConnectionType == ENetworkType.Cell)
				{
					return "Stream";
				}
				return "Other";
			}
			else
			{
				if (this.PlatformInternal == "Windows" || this.PlatformInternal == "Mac" || this.PlatformInternal == "Linux")
				{
					return "Wired";
				}
				return "Other";
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		[NullableContext(2)]
		public void Report(HotPatchLog data)
		{
			if (data == null)
			{
				return;
			}
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			data.device_id = this.DeviceIdInternal;
			data.event_time = num.ToString();
			data.l_trigger_time = new long?(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
			data.s_version = (this.VersionInternal ?? "");
			data.net_status = this.GetReportNetStatus();
			data.client_platform = (this.PlatformInternal ?? "");
			if (HotPatchKuroSdk.Instance.CanUseSdk())
			{
				data.s_device_id = UKuroSDKManager.GetBasicInfo().DeviceId;
				if (!this.IsSet)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "launcher sdk device id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", data.s_device_id);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.IsSet = true;
				}
			}
			data.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify(data, null));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public void Report(HotPatchLog data)
		{
			if (data == null)
			{
				return;
			}
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			data.device_id = this.DeviceIdInternal;
			data.event_time = num.ToString();
			data.l_trigger_time = new long?(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
			data.s_version = (this.VersionInternal ?? "");
			data.net_status = this.GetReportNetStatus();
			data.client_platform = (this.PlatformInternal ?? "");
			if (HotPatchKuroSdk.Instance.CanUseSdk())
			{
				data.s_device_id = UKuroSDKManager.GetBasicInfo().DeviceId;
				if (!this.IsSet)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "launcher sdk device id";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", data.s_device_id);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.IsSet = true;
				}
			}
			data.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify(data, null));
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public void Report(PakKeyLog data)
		{
			if (data == null)
			{
				return;
			}
			long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			data.device_id = (this.DeviceIdInternal ?? "");
			data.event_time = num.ToString();
			data.l_trigger_time = new long?(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
			data.s_version = (this.VersionInternal ?? "");
			data.net_status = this.GetReportNetStatus();
			data.client_platform = (this.PlatformInternal ?? "");
			data.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify(data, null));
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000CD14 File Offset: 0x0000AF14
		public void ReportLogin(int stepId, string stepResult)
		{
			LoginLogEvent loginLogEvent = new LoginLogEvent();
			loginLogEvent.i_step_id = stepId.ToString();
			loginLogEvent.s_step_result = stepResult;
			if (this.WorldInternal != null)
			{
				loginLogEvent.f_time = UGameplayStatics.GetTimeSeconds(this.WorldInternal).ToString();
			}
			loginLogEvent.event_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			loginLogEvent.device_id = this.DeviceIdInternal;
			loginLogEvent.s_tag = this.UniqueId;
			loginLogEvent.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			ThinkDataLaunchReporter.Instance.Report("c" + loginLogEvent.event_id, LauncherJson.Stringify(loginLogEvent, null));
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public void ReportAppLinksEvent(string deepvalue, string source)
		{
			AppLinksLog appLinksLog = new AppLinksLog();
			appLinksLog.s_step_id = "launch_by_deeplink";
			appLinksLog.s_deepvalue = deepvalue;
			appLinksLog.s_source = source;
			appLinksLog.event_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			appLinksLog.device_id = this.DeviceIdInternal;
			appLinksLog.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			appLinksLog.client_platform = (this.PlatformInternal ?? "");
			ThinkDataLaunchReporter.Instance.Report("c" + appLinksLog.event_id, LauncherJson.Stringify(appLinksLog, null));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000CE59 File Offset: 0x0000B059
		public void ReportHotPatchLog(HotPatchLogData data)
		{
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify(data, null));
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public void ReportNetworkDetection(LauncherNetworkDetectionBaseLog logData)
		{
			logData.device_id = (this.DeviceIdInternal ?? "");
			logData.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			logData.client_platform = (this.PlatformInternal ?? "");
			logData.event_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			ThinkDataLaunchReporter.Instance.Report("c" + logData.event_id, LauncherJson.Stringify(logData, null) ?? "");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000CF08 File Offset: 0x0000B108
		public void ReportVersionFirstDownloadType(bool typeIsAdd, int diffSpace, int allSpace, int needSpace)
		{
			LauncherVersionFirstDownloadTypeLog launcherVersionFirstDownloadTypeLog = new LauncherVersionFirstDownloadTypeLog();
			launcherVersionFirstDownloadTypeLog.i_download_type = (typeIsAdd ? 2 : 1);
			launcherVersionFirstDownloadTypeLog.i_required_space_add = diffSpace;
			launcherVersionFirstDownloadTypeLog.i_required_space_all = allSpace;
			launcherVersionFirstDownloadTypeLog.i_required_space = needSpace;
			ThinkDataLaunchReporter.Instance.Report("c" + launcherVersionFirstDownloadTypeLog.event_id, LauncherJson.Stringify(launcherVersionFirstDownloadTypeLog, null));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000CF60 File Offset: 0x0000B160
		public void ReportLoginProcessLink(string traceId, string userId, string userName, string loginStep, int errorCode)
		{
			LoginProcessLink loginProcessLink = new LoginProcessLink();
			loginProcessLink.s_trace_id = traceId;
			loginProcessLink.s_user_id = userId;
			loginProcessLink.s_user_name = userName;
			loginProcessLink.s_app_version = UKuroLauncherLibrary.GetAppVersion();
			loginProcessLink.s_launcher_version = (LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.LauncherPatchVersion, "") ?? "");
			loginProcessLink.s_resource_version = (LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, "") ?? "");
			loginProcessLink.s_client_version = BaseConfigController.Instance.GetVersionString();
			loginProcessLink.i_error_code = errorCode;
			loginProcessLink.s_cpu_info = UKuroStaticLibrary.GetDeviceCPU();
			loginProcessLink.s_device_info = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDeviceName();
			loginProcessLink.s_driver_date = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDriverDate();
			if (HotPatchKuroSdk.Instance.CanUseSdk())
			{
				loginProcessLink.s_device_id = UKuroSDKManager.GetBasicInfo().DeviceId;
			}
			loginProcessLink.s_command_line = KuroApplication.GetCommandLine();
			loginProcessLink.s_login_step = loginStep;
			int num = (int)HotFixManager.LocalResourceQualityTier;
			if (num == 0)
			{
				num = (int)LauncherDeviceTierLib.GetActiveTier();
			}
			loginProcessLink.s_quality_version = num;
			ThinkDataLaunchReporter.Instance.Report("c" + loginProcessLink.event_id, LauncherJson.Stringify(loginProcessLink, null));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000D070 File Offset: 0x0000B270
		[NullableContext(2)]
		public unsafe void ReportKeyListConfig(PakKeyLog data, long timeOffset)
		{
			if (data == null)
			{
				return;
			}
			long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			data.device_id = (this.DeviceId ?? "");
			data.event_time = ((num + timeOffset) / 1000L).ToString();
			data.l_trigger_time = new long?(num + timeOffset);
			data.s_version = this.Version;
			data.net_status = this.GetReportNetStatus();
			data.client_platform = this.Platform;
			LauncherLog instance = LauncherLog.Instance;
			string message = "ReportKeyListConfig";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("device_id", data.device_id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("event_time", data.event_time);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("timeOffset", timeOffset);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			data.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify(data, null));
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000D198 File Offset: 0x0000B398
		[NullableContext(2)]
		public unsafe void ReportStartupTiming(EStartupTimingStep step, string stepResult = null)
		{
			if (!UKuroLauncherLibrary.IsFirstIntoLauncher())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "二次启动不上报LOG";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Step", step);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("stepResult", stepResult);
				instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (string.IsNullOrEmpty(this.StartupTraceId))
			{
				return;
			}
			try
			{
				int i_cost_time = (int)UKuroStaticLibrary.GetTimeSinceGameStartInSeconds();
				string text = this.StartupDeviceId;
				if (string.IsNullOrEmpty(text))
				{
					text = this.DeviceId;
					if (PlatformSdkManagerNew.Instance.IsSdkOn)
					{
						string deviceId = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetDeviceId();
						if (!string.IsNullOrEmpty(deviceId))
						{
							text = deviceId;
						}
					}
					else if (LauncherSdk.canUseSdk())
					{
						FBasicInfo basicInfo = UKuroSDKManager.GetBasicInfo();
						string text2 = (basicInfo != null) ? basicInfo.DeviceId : null;
						if (!string.IsNullOrEmpty(text2))
						{
							text = text2;
						}
					}
					this.StartupDeviceId = text;
				}
				string appVersion = UKuroLauncherLibrary.GetAppVersion();
				StartupTimingLog startupTimingLog = new StartupTimingLog();
				startupTimingLog.s_step_id = step.ToString();
				startupTimingLog.s_step_result = stepResult;
				startupTimingLog.i_cost_time = i_cost_time;
				startupTimingLog.os = KuroApplication.IniPlatformName();
				string s_device_info;
				if ((s_device_info = this.StartupDeviceInfo) == null)
				{
					s_device_info = (this.StartupDeviceInfo = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDeviceName());
				}
				startupTimingLog.s_device_info = s_device_info;
				string s_cpu_info;
				if ((s_cpu_info = this.StartupCpuInfo) == null)
				{
					s_cpu_info = (this.StartupCpuInfo = UKuroStaticLibrary.GetDeviceCPU());
				}
				startupTimingLog.s_cpu_info = s_cpu_info;
				startupTimingLog.s_trace_id = this.StartupTraceId;
				startupTimingLog.s_user_id = this.StartupUserId;
				startupTimingLog.s_device_id = text;
				startupTimingLog.i_vulkan = ((CSharpScript.Launcher.Platform.Platform.Instance.IsAndroidPlatform() && UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIName().Contains("Vulkan")) ? 1 : 0);
				startupTimingLog.s_appversion = appVersion;
				startupTimingLog.s_launcher_version = (LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.LauncherPatchVersion, appVersion) ?? appVersion);
				startupTimingLog.s_resource_version = (LauncherStorageLib.Instance.GetDeviceSaved<string>(ELauncherStorageDeviceKey.PatchVersion, appVersion) ?? appVersion);
				string text3 = LauncherJson.Stringify(startupTimingLog, null);
				if (text3 != null)
				{
					ThinkDataLaunchReporter.Instance.Report("c17", text3);
				}
			}
			catch (Exception item)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "启动耗时埋点上报失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("step", step);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("exception", item);
				instance2.Warn(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000D414 File Offset: 0x0000B614
		public static HotPatchLogReport Instance
		{
			get
			{
				if (HotPatchLogReport._instance == null)
				{
					HotPatchLogReport._instance = new HotPatchLogReport();
					HotPatchLogReport._instance.OnInit();
				}
				return HotPatchLogReport._instance;
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000D437 File Offset: 0x0000B637
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D439 File Offset: 0x0000B639
		public static void ResetStaticDefaultValue()
		{
			HotPatchLogReport instance = HotPatchLogReport._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchLogReport._instance = null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D452 File Offset: 0x0000B652
		static HotPatchLogReport()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchLogReport.CreateStaticDefaultValue), new Action(HotPatchLogReport.ResetStaticDefaultValue));
		}

		// Token: 0x04000189 RID: 393
		[Nullable(2)]
		private readonly string UniqueId;

		// Token: 0x0400018A RID: 394
		[Nullable(2)]
		private string DeviceIdInternal;

		// Token: 0x0400018B RID: 395
		[Nullable(2)]
		private string VersionInternal;

		// Token: 0x0400018C RID: 396
		[Nullable(2)]
		private string PlatformInternal;

		// Token: 0x0400018D RID: 397
		[Nullable(2)]
		private UWorld WorldInternal;

		// Token: 0x0400018E RID: 398
		private bool IsSet;

		// Token: 0x0400018F RID: 399
		private string StartupTraceId = "";

		// Token: 0x04000190 RID: 400
		public string StartupUserId = "";

		// Token: 0x04000191 RID: 401
		[Nullable(2)]
		private string StartupCpuInfo;

		// Token: 0x04000192 RID: 402
		[Nullable(2)]
		private string StartupDeviceInfo;

		// Token: 0x04000193 RID: 403
		private string StartupDeviceId = "";

		// Token: 0x04000194 RID: 404
		[Nullable(2)]
		private static HotPatchLogReport _instance;
	}
}
