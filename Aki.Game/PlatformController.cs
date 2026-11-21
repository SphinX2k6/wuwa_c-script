using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02001AD1 RID: 6865
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PlatformController : ControllerBase
{
	// Token: 0x06011083 RID: 69763 RVA: 0x005013DA File Offset: 0x004FF5DA
	protected override bool OnInit()
	{
		this.ControlScreenSaver(false);
		this.InitDeviceInfo();
		this.BindInput();
		return true;
	}

	// Token: 0x06011084 RID: 69764 RVA: 0x005013F0 File Offset: 0x004FF5F0
	protected override bool OnClear()
	{
		this.UnBindInput();
		return true;
	}

	// Token: 0x06011085 RID: 69765 RVA: 0x005013F9 File Offset: 0x004FF5F9
	private void BindInput()
	{
		InputDistributeController.Instance.BindAxis("MouseMove", new TInputHandle<float>(this.OnMouseAxisInput));
	}

	// Token: 0x06011086 RID: 69766 RVA: 0x00501416 File Offset: 0x004FF616
	private void UnBindInput()
	{
		InputDistributeController.Instance.UnBindAxis("MouseMove", new TInputHandle<float>(this.OnMouseAxisInput));
	}

	// Token: 0x06011087 RID: 69767 RVA: 0x00501433 File Offset: 0x004FF633
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

	// Token: 0x06011088 RID: 69768 RVA: 0x00501468 File Offset: 0x004FF668
	private void InitDeviceInfo()
	{
		if (!Info.Instance.IsPcPlatform())
		{
			PlatformModel.Instance.RefreshPlatformByDevice("InitDeviceInfo");
		}
	}

	// Token: 0x06011089 RID: 69769 RVA: 0x00501488 File Offset: 0x004FF688
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

	// Token: 0x0601108A RID: 69770 RVA: 0x005014CC File Offset: 0x004FF6CC
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

	// Token: 0x0601108B RID: 69771 RVA: 0x005015C4 File Offset: 0x004FF7C4
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
		int localResourceQualityTier = (int)HotFixManager.LocalResourceQualityTier;
		if (localResourceQualityTier == 0)
		{
			localResourceQualityTier = (int)HotFixManager.GetLocalResourceQualityTier();
		}
		clientBasicInfo.QualityVersion = localResourceQualityTier;
		return clientBasicInfo;
	}

	// Token: 0x17001984 RID: 6532
	// (get) Token: 0x0601108C RID: 69772 RVA: 0x00501783 File Offset: 0x004FF983
	public static PlatformController Instance
	{
		get
		{
			return PlatformController._Instance;
		}
	}

	// Token: 0x0601108D RID: 69773 RVA: 0x0050178A File Offset: 0x004FF98A
	public static PlatformController GetOrCreateInstance()
	{
		if (PlatformController._Instance == null)
		{
			PlatformController.CreateInstance();
		}
		return PlatformController._Instance;
	}

	// Token: 0x0601108E RID: 69774 RVA: 0x0050179E File Offset: 0x004FF99E
	public static bool CreateInstance()
	{
		if (PlatformController._Instance != null)
		{
			return true;
		}
		PlatformController._Instance = new PlatformController();
		return true;
	}

	// Token: 0x0601108F RID: 69775 RVA: 0x005017B4 File Offset: 0x004FF9B4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011090 RID: 69776 RVA: 0x005017B6 File Offset: 0x004FF9B6
	public static void ResetStaticDefaultValue()
	{
		PlatformController._Instance = null;
	}

	// Token: 0x06011091 RID: 69777 RVA: 0x005017BE File Offset: 0x004FF9BE
	static PlatformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformController.CreateStaticDefaultValue), new Action(PlatformController.ResetStaticDefaultValue));
	}

	// Token: 0x040095F6 RID: 38390
	[Nullable(2)]
	private static PlatformController _Instance;
}
