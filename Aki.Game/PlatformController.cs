using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x020025E6 RID: 9702
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PlatformController : ControllerBase
{
	// Token: 0x06013BA1 RID: 80801 RVA: 0x004F26AA File Offset: 0x004F08AA
	protected override bool OnInit()
	{
		this.ControlScreenSaver(false);
		this.InitDeviceInfo();
		this.BindInput();
		return true;
	}

	// Token: 0x06013BA2 RID: 80802 RVA: 0x004F26C0 File Offset: 0x004F08C0
	protected override bool OnClear()
	{
		this.UnBindInput();
		return true;
	}

	// Token: 0x06013BA3 RID: 80803 RVA: 0x004F26C9 File Offset: 0x004F08C9
	private void BindInput()
	{
		InputDistributeController.Instance.BindAxis("MouseMove", new TInputHandle<float>(this.OnMouseAxisInput));
	}

	// Token: 0x06013BA4 RID: 80804 RVA: 0x004F26E6 File Offset: 0x004F08E6
	private void UnBindInput()
	{
		InputDistributeController.Instance.UnBindAxis("MouseMove", new TInputHandle<float>(this.OnMouseAxisInput));
	}

	// Token: 0x06013BA5 RID: 80805 RVA: 0x004F2703 File Offset: 0x004F0903
	private void OnMouseAxisInput(string axisName, float value, InputIdentification _)
	{
		if (value == 0f)
		{
			return;
		}
		if (Info.Instance.IsInKeyBoard())
		{
			return;
		}
		if (CloudGameManager.Instance.IsCloudGame)
		{
			return;
		}
		Info.Instance.SwitchInputControllerType(EInputControllerType.Keyboard, "MouseAxisInput");
	}

	// Token: 0x06013BA6 RID: 80806 RVA: 0x004F2738 File Offset: 0x004F0938
	private void InitDeviceInfo()
	{
		if (!Info.Instance.IsPcPlatform())
		{
			PlatformModel.Instance.RefreshPlatformByDevice("InitDeviceInfo");
		}
	}

	// Token: 0x06013BA7 RID: 80807 RVA: 0x004F2758 File Offset: 0x004F0958
	public void ControlScreenSaver(bool state)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Platform;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "控制屏幕";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UKismetSystemLibrary.ControlScreensaver(state);
	}

	// Token: 0x06013BA8 RID: 80808 RVA: 0x004F279C File Offset: 0x004F099C
	public unsafe void SendClientBasicInfo()
	{
		ClientBasicInfoRequest clientBasicInfoRequest = new ClientBasicInfoRequest();
		ClientBasicInfo clientBasicInfo = this.PackageClientBasicInfo();
		clientBasicInfoRequest.ClientBasicInfo = clientBasicInfo;
		Net.Instance.Call(ERequestMessageId.ClientBasicInfoRequest, clientBasicInfoRequest, null, 0);
		if (clientBasicInfo != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Platform;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "客户端上报一些设备基础信息";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CPU", clientBasicInfo.CPU);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeviceId", clientBasicInfo.DeviceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Model", clientBasicInfo.Model);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("NetStatus", clientBasicInfo.NetStatus);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Platform", clientBasicInfo.Platform);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}
	}

	// Token: 0x06013BA9 RID: 80809 RVA: 0x004F2894 File Offset: 0x004F0A94
	public ClientBasicInfo PackageClientBasicInfo()
	{
		ClientBasicInfo clientBasicInfo = new ClientBasicInfo();
		clientBasicInfo.NetStatus = PlatformModel.Instance.GetNetStatus();
		clientBasicInfo.Platform = KuroApplication.IniPlatformName();
		FBasicInfo basicInfo = KuroSdkModel.Instance.GetBasicInfo();
		clientBasicInfo.CPU = (((basicInfo != null) ? basicInfo.CPUModelName : null) ?? string.Empty);
		clientBasicInfo.DeviceId = (((basicInfo != null) ? basicInfo.DeviceId : null) ?? string.Empty);
		clientBasicInfo.Model = (((basicInfo != null) ? basicInfo.ModelName : null) ?? string.Empty);
		clientBasicInfo.DistinctId = UThinkingAnalytics.GetDeviceId(0);
		clientBasicInfo.Language = LanguageSystem.Instance.GetLanguageDefineByCode(LanguageSystem.Instance.PackageLanguage).LanguageType;
		clientBasicInfo.PkgId = (KuroSdkController.Instance.GetPackageId() ?? string.Empty);
		if (CloudGameManager.Instance.IsCloudGame)
		{
			clientBasicInfo.ServerTag = CloudGameManagerLauncher.Instance.ServerTag;
		}
		string macAddress = UKuroStaticLibrary.GetMacAddress();
		if (!StringUtils.IsEmpty(macAddress))
		{
			clientBasicInfo.MacAddress = macAddress;
		}
		PresetProperties presetProperties = LogReportModel.Instance.GetPresetProperties();
		clientBasicInfo.SystemLanguage = presetProperties.system_language;
		clientBasicInfo.OSVersion = presetProperties.os_version;
		clientBasicInfo.DeviceId2ShuShu = presetProperties.device_id;
		int num;
		clientBasicInfo.ScreenHeight = (int.TryParse(presetProperties.screen_height, out num) ? num : 0);
		int num2;
		clientBasicInfo.ScreenWidth = (int.TryParse(presetProperties.screen_width, out num2) ? num2 : 0);
		clientBasicInfo.DeviceInfo = (LoginModel.Instance.DeviceInfo() ?? string.Empty);
		clientBasicInfo.DriverDate = (LoginModel.Instance.DriverDate() ?? string.Empty);
		clientBasicInfo.ClientVersion = BaseConfigController.Instance.GetVersionString();
		return clientBasicInfo;
	}

	// Token: 0x1700194C RID: 6476
	// (get) Token: 0x06013BAA RID: 80810 RVA: 0x004F2A39 File Offset: 0x004F0C39
	public static PlatformController Instance
	{
		get
		{
			return PlatformController._Instance;
		}
	}

	// Token: 0x06013BAB RID: 80811 RVA: 0x004F2A40 File Offset: 0x004F0C40
	public static PlatformController GetOrCreateInstance()
	{
		if (PlatformController._Instance == null)
		{
			PlatformController.CreateInstance();
		}
		return PlatformController._Instance;
	}

	// Token: 0x06013BAC RID: 80812 RVA: 0x004F2A54 File Offset: 0x004F0C54
	public static bool CreateInstance()
	{
		if (PlatformController._Instance != null)
		{
			return true;
		}
		PlatformController._Instance = new PlatformController();
		return true;
	}

	// Token: 0x06013BAD RID: 80813 RVA: 0x004F2A6A File Offset: 0x004F0C6A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013BAE RID: 80814 RVA: 0x004F2A6C File Offset: 0x004F0C6C
	public static void ResetStaticDefaultValue()
	{
		PlatformController._Instance = null;
	}

	// Token: 0x06013BAF RID: 80815 RVA: 0x004F2A74 File Offset: 0x004F0C74
	static PlatformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformController.CreateStaticDefaultValue), new Action(PlatformController.ResetStaticDefaultValue));
	}

	// Token: 0x0400949F RID: 38047
	[Nullable(2)]
	private static PlatformController _Instance;
}
