using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.ThinkDataReport;
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
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000C8E3 File Offset: 0x0000AAE3
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000C818 File Offset: 0x0000AA18
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
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C8EB File Offset: 0x0000AAEB
		public string DeviceId
		{
			get
			{
				return this.DeviceIdInternal ?? "";
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		public string Platform
		{
			get
			{
				return this.PlatformInternal ?? "";
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000C90D File Offset: 0x0000AB0D
		public string Version
		{
			get
			{
				return this.VersionInternal ?? "";
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C91E File Offset: 0x0000AB1E
		public void Init()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000C920 File Offset: 0x0000AB20
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

		// Token: 0x0600027E RID: 638 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
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
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify<HotPatchLog>(data, null));
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
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
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify<HotPatchLog>(data, null));
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000CBDC File Offset: 0x0000ADDC
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
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify<PakKeyLog>(data, null));
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000CC9C File Offset: 0x0000AE9C
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
			ThinkDataLaunchReporter.Instance.Report("c" + loginLogEvent.event_id, LauncherJson.Stringify<LoginLogEvent>(loginLogEvent, null));
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000CD48 File Offset: 0x0000AF48
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
			ThinkDataLaunchReporter.Instance.Report("c" + appLinksLog.event_id, LauncherJson.Stringify<AppLinksLog>(appLinksLog, null));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000CDE1 File Offset: 0x0000AFE1
		public void ReportHotPatchLog(HotPatchLogData data)
		{
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify<HotPatchLogData>(data, null));
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000CE04 File Offset: 0x0000B004
		public void ReportNetworkDetection(LauncherNetworkDetectionBaseLog logData)
		{
			logData.device_id = (this.DeviceIdInternal ?? "");
			logData.s_client_version = ThinkDataLaunchReporter.Instance.ClientVersion;
			logData.client_platform = (this.PlatformInternal ?? "");
			logData.event_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			ThinkDataLaunchReporter.Instance.Report("c" + logData.event_id, LauncherJson.Stringify<LauncherNetworkDetectionBaseLog>(logData, null) ?? "");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000CE90 File Offset: 0x0000B090
		public void ReportVersionFirstDownloadType(bool typeIsAdd, int diffSpace, int allSpace, int needSpace)
		{
			LauncherVersionFirstDownloadTypeLog launcherVersionFirstDownloadTypeLog = new LauncherVersionFirstDownloadTypeLog();
			launcherVersionFirstDownloadTypeLog.i_download_type = (typeIsAdd ? 2 : 1);
			launcherVersionFirstDownloadTypeLog.i_required_space_add = diffSpace;
			launcherVersionFirstDownloadTypeLog.i_required_space_all = allSpace;
			launcherVersionFirstDownloadTypeLog.i_required_space = needSpace;
			ThinkDataLaunchReporter.Instance.Report("c" + launcherVersionFirstDownloadTypeLog.event_id, LauncherJson.Stringify<LauncherVersionFirstDownloadTypeLog>(launcherVersionFirstDownloadTypeLog, null));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
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
			loginProcessLink.s_quality_version = (int)LauncherDeviceTierLib.GetActiveTier();
			ThinkDataLaunchReporter.Instance.Report("c" + loginProcessLink.event_id, LauncherJson.Stringify<LoginProcessLink>(loginProcessLink, null));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
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
			ThinkDataLaunchReporter.Instance.Report("c" + data.event_id, LauncherJson.Stringify<PakKeyLog>(data, null));
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000D115 File Offset: 0x0000B315
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

		// Token: 0x06000289 RID: 649 RVA: 0x0000D138 File Offset: 0x0000B338
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000D13A File Offset: 0x0000B33A
		public static void ResetStaticDefaultValue()
		{
			HotPatchLogReport instance = HotPatchLogReport._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotPatchLogReport._instance = null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D153 File Offset: 0x0000B353
		static HotPatchLogReport()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchLogReport.CreateStaticDefaultValue), new Action(HotPatchLogReport.ResetStaticDefaultValue));
		}

		// Token: 0x04000182 RID: 386
		[Nullable(2)]
		private readonly string UniqueId;

		// Token: 0x04000183 RID: 387
		[Nullable(2)]
		private string DeviceIdInternal;

		// Token: 0x04000184 RID: 388
		[Nullable(2)]
		private string VersionInternal;

		// Token: 0x04000185 RID: 389
		[Nullable(2)]
		private string PlatformInternal;

		// Token: 0x04000186 RID: 390
		[Nullable(2)]
		private UWorld WorldInternal;

		// Token: 0x04000187 RID: 391
		private bool IsSet;

		// Token: 0x04000188 RID: 392
		[Nullable(2)]
		private static HotPatchLogReport _instance;
	}
}
