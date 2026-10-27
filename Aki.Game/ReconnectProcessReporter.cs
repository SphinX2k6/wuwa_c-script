using System;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

// Token: 0x02002749 RID: 10057
public static class ReconnectProcessReporter
{
	// Token: 0x06014A10 RID: 84496 RVA: 0x005380A4 File Offset: 0x005362A4
	public static void ReportReconnectProcess(EReconnectProcessStep reconvStep, ErrorCode code = ErrorCode.Success)
	{
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		ReconvProcessLink reconvProcessLink = new ReconvProcessLink();
		reconvProcessLink.s_trace_id = ReConnectModel.Instance.ReconvTraceId;
		int? num;
		reconvProcessLink.s_player_id = (((PlayerInfoModel.Instance.GetId() != null) ? num.GetValueOrDefault().ToString() : null) ?? "0");
		reconvProcessLink.s_user_id = (((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "");
		reconvProcessLink.s_user_name = (((sdkLoginConfig != null) ? sdkLoginConfig.UserName : null) ?? LoginModel.Instance.GetAccount());
		reconvProcessLink.s_reconv_step = reconvStep.ToString();
		reconvProcessLink.s_app_version = UKuroLauncherLibrary.GetAppVersion();
		reconvProcessLink.s_launcher_version = LocalStorage.GetDeviceSaved<string>(ELocalStorageDeviceKey.LauncherPatchVersion, reconvProcessLink.s_app_version);
		reconvProcessLink.s_resource_version = LocalStorage.GetDeviceSaved<string>(ELocalStorageDeviceKey.PatchVersion, reconvProcessLink.s_app_version);
		reconvProcessLink.s_client_version = BaseConfigController.Instance.GetVersionString();
		reconvProcessLink.i_error_code = (int)code;
		LogReportController.Instance.LogReport(reconvProcessLink);
	}
}
