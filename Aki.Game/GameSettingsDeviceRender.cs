using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Launcher;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

// Token: 0x02000285 RID: 645
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDeviceRender : Singleton
{
	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x0600272F RID: 10031 RVA: 0x000F0C7C File Offset: 0x000EEE7C
	[Nullable(2)]
	private Dictionary<int, DeviceRenderFeature> DeviceRenderFeatureCfgMap
	{
		[NullableContext(2)]
		get
		{
			if (this.DeviceRenderFeatureCfgMapInternal == null)
			{
				IReadOnlyList<DeviceRenderFeature> deviceRenderFeatureConfigListByDeviceId = GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)this.DeviceType);
				if (deviceRenderFeatureConfigListByDeviceId == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GameSettings;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "当前机型未定义RenderFeature";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deviceType", this.DeviceType.ToString());
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				this.DeviceRenderFeatureCfgMapInternal = new Dictionary<int, DeviceRenderFeature>();
				foreach (DeviceRenderFeature value in deviceRenderFeatureConfigListByDeviceId)
				{
					this.DeviceRenderFeatureCfgMapInternal[value.QualityType] = value;
				}
			}
			return this.DeviceRenderFeatureCfgMapInternal;
		}
	}

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x06002730 RID: 10032 RVA: 0x000F0D3C File Offset: 0x000EEF3C
	private int? RecommendQualityLv
	{
		get
		{
			if (this.RecommendQualityLvInternal == null)
			{
				IReadOnlyList<DeviceRenderFeature> deviceRenderFeatureConfigListByDeviceId = GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)this.DeviceType);
				if (deviceRenderFeatureConfigListByDeviceId == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GameSettings;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "当前机型未定义RenderFeature";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deviceType", this.DeviceType.ToString());
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				foreach (DeviceRenderFeature deviceRenderFeature in deviceRenderFeatureConfigListByDeviceId)
				{
					if (deviceRenderFeature.DefaultQuality == 1)
					{
						this.RecommendQualityLvInternal = new int?(deviceRenderFeature.QualityType);
						break;
					}
				}
			}
			return this.RecommendQualityLvInternal;
		}
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x06002731 RID: 10033 RVA: 0x000F0E0C File Offset: 0x000EF00C
	public EGameQualitySettingLevel GameQualitySettingLevel
	{
		get
		{
			return (EGameQualitySettingLevel)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.IMAGEQUALITY, 2, true);
		}
	}

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x06002732 RID: 10034 RVA: 0x000F0E1C File Offset: 0x000EF01C
	public int PhysicalGBRam
	{
		get
		{
			return this.DevicePhysicalGbRam;
		}
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06002733 RID: 10035 RVA: 0x000F0E24 File Offset: 0x000EF024
	private int[] FrameRateListAndroid
	{
		get
		{
			if (this.IsRedMagicLow())
			{
				return GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagicLow;
			}
			if (this.IsRedMagicHigh())
			{
				return GameSettingsDeviceRenderDefine.FrameRateListAndroidForRedMagic;
			}
			return GameSettingsDeviceRenderDefine.FrameRateListAndroid;
		}
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x000F0E47 File Offset: 0x000EF047
	private bool IsSpecificMobileGpuByProfile(string keyword, bool fullMatch)
	{
		if (this.ProfileNameCache == null)
		{
			this.ProfileNameCache = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileProfileName();
		}
		if (fullMatch)
		{
			return keyword == this.ProfileNameCache;
		}
		return this.ProfileNameCache.Contains(keyword);
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x000F0E78 File Offset: 0x000EF078
	public bool IsTargetBaseProfile(string keyword, bool fullMatch)
	{
		if (fullMatch)
		{
			return keyword == this.BaseProfileName;
		}
		return this.BaseProfileName.Contains(keyword);
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x000F0E98 File Offset: 0x000EF098
	public unsafe void InitializeBaseInfo()
	{
		this.DevicePhysicalGbRam = UKuroRenderingRuntimeBPPluginBPLibrary.GetPhysicalGBRam();
		this.DeviceVideoGbRam = ((UKuroStaticLibrary.GetVideoMemoryGB() > 0) ? (UKuroStaticLibrary.GetVideoMemoryGB() + 1) : 0);
		this.VendorName = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIVendorName();
		this.DeviceName = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDeviceName();
		this.BaseProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileBaseProfileName();
		this.DeviceScore = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileDeviceScore();
		this.RHIName = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIName();
		this.HardwareLevel = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceHardwareLevel();
		this.DriverDate = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDriverDate();
		this.DriverVersion = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDriverVersion();
		this.AdapterDriverVersion = UKuroRenderingRuntimeBPPluginBPLibrary.GetAdapterUserDriverVersion();
		this.WindowsVersion = UKuroRenderingRuntimeBPPluginBPLibrary.GetWindowsVersion();
		this.IsSSDDevice = UKuroRenderingRuntimeBPPluginBPLibrary.IsSSDDevice();
		this.IsAdreno = this.IsSpecificMobileGpuByProfile("Adreno", false);
		this.IsXuanJie = this.IsSpecificMobileGpuByProfile("Xiaomi_O1", true);
		this.MobileDeviceModel = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceModel();
		this.MobileDeviceMake = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceMake();
		this.CPUFrequency = UKuroRenderingRuntimeBPPluginBPLibrary.GetCPUFrequency();
		this.CPUCores = UKuroRenderingRuntimeBPPluginBPLibrary.GetCPUCores();
		this.CPUCoresIncludingHyperthreads = UKuroRenderingRuntimeBPPluginBPLibrary.GetCPUCoresIncludingHyperthreads();
		this.CPUBrand = UKuroRenderingRuntimeBPPluginBPLibrary.GetCPUBrand();
		this.IsSupportedAFME = UKismetRenderingLibrary.IsSupportedAFME();
		this.LowMemoryDeviceMark = UKismetSystemLibrary.GetConsoleVariableIntValue("memory.LowMemoryDeviceMark");
		if (UKuroFFXFSR3BlueprintLibrary.IsSupported())
		{
			UKuroFFXFSR3BlueprintLibrary.DumpAMDGPUInfos();
			if (this.IsFFXFISupported())
			{
				EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.TempDisableFFXFIWhenLoading));
				EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.RecoverFFXFITempStateWhenLoading));
				EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.TempDisableFFXFIWhenSeqC));
				EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.RecoverFFXFITempStateFromSeqC));
			}
		}
		if (Info.Instance.IsMobilePlatform() && this.IsVulkanRHI() == 0 && this.MobileDeviceMake.Contains("Xiaomi"))
		{
			this.IsBrokenGLPacingDevice = true;
		}
		if (Platform.Instance.IsMobilePlatform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.UseClusteredDeferredShading -1", null);
			if (this.IsVulkanRHI() != 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.LGUI.CreateMeshSectionOptTrans true", null);
			}
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.UseClusteredDeferredShading 2", null);
		}
		if (Platform.Instance.IsIOSPlatform())
		{
			this.DeviceType = EGameDeviceType.IOS_LOW;
			if (this.DeviceScore < 150)
			{
				this.DeviceType = EGameDeviceType.IOS_LOWEST;
			}
			else if (this.DeviceScore > 250 && this.DeviceScore < 360)
			{
				this.DeviceType = EGameDeviceType.IOS_MIDDLE;
			}
			else if (this.DeviceScore >= 360)
			{
				this.DeviceType = EGameDeviceType.IOS_HIGH;
			}
			else if (this.DeviceScore >= 650)
			{
				this.DeviceType = EGameDeviceType.IOS_VERY_HIGH;
			}
			if (UKuroStaticLibrary.IsLowMemoryDevice())
			{
				this.DeviceType = EGameDeviceType.IOS_LOWEST;
			}
		}
		else if (Platform.Instance.IsAndroidPlatform() || UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1)
		{
			if (this.BaseProfileName == "Android_Lowest")
			{
				this.DeviceType = EGameDeviceType.ANDROID_LOWEST;
			}
			else if (this.BaseProfileName == "Android_Low")
			{
				this.DeviceType = EGameDeviceType.ANDROID_LOW;
			}
			else if (this.BaseProfileName == "Android_Mid")
			{
				this.DeviceType = EGameDeviceType.ANDROID_MIDDLE;
			}
			else if (this.BaseProfileName == "Android_High")
			{
				this.DeviceType = EGameDeviceType.ANDROID_HIGH;
			}
			else if (this.BaseProfileName == "Android_VeryHigh")
			{
				this.DeviceType = EGameDeviceType.ANDROID_VERY_HIGH;
			}
			else
			{
				this.DeviceType = EGameDeviceType.ANDROID_LOW;
			}
			if (!this.IsHuaweiAndroid() && !this.IsMaliNewSocOrXclipseOrPowerVR())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.HZBOcclusion 2", null);
			}
		}
		else if (Platform.Instance.IsPs5Platform())
		{
			this.DeviceType = EGameDeviceType.PS;
		}
		else if (Platform.Instance.IsXSXPlatform())
		{
			this.DeviceType = EGameDeviceType.XBox;
		}
		else if (Platform.Instance.IsMacPlatform())
		{
			if (this.BaseProfileName == "Mac_Low")
			{
				this.DeviceType = EGameDeviceType.PC_LOWEST;
			}
			else if (this.BaseProfileName == "Mac_Mid")
			{
				this.DeviceType = EGameDeviceType.PC_LOW;
			}
			else if (this.BaseProfileName == "Mac_High")
			{
				this.DeviceType = EGameDeviceType.PC_LOW;
			}
			else if (this.BaseProfileName == "Mac_VeryHigh")
			{
				this.DeviceType = EGameDeviceType.PC_MIDDLE;
				this.DeviceScore = 550;
			}
			else
			{
				this.DeviceType = EGameDeviceType.PC_MIDDLE;
			}
		}
		else if (Platform.Instance.IsCloudGame())
		{
			this.DeviceType = EGameDeviceType.CLOUD_GAME;
		}
		else if (this.BaseProfileName == "Windows_Lowest")
		{
			this.DeviceType = EGameDeviceType.PC_LOWEST;
		}
		else if (this.BaseProfileName == "Windows_Low")
		{
			this.DeviceType = EGameDeviceType.PC_LOW;
		}
		else if (this.BaseProfileName == "Windows_Mid")
		{
			this.DeviceType = EGameDeviceType.PC_MIDDLE;
		}
		else if (this.BaseProfileName == "Windows_High")
		{
			this.DeviceType = EGameDeviceType.PC_HIGH;
		}
		else if (this.BaseProfileName == "Windows_VeryHigh")
		{
			this.DeviceType = EGameDeviceType.PC_VERY_HIGH;
		}
		else if (this.BaseProfileName == "Windows_Highest")
		{
			this.DeviceType = EGameDeviceType.PC_HIGHEST;
		}
		else if (this.BaseProfileName == "Windows")
		{
			this.DeviceType = EGameDeviceType.PC_HIGH;
		}
		else
		{
			this.DeviceType = EGameDeviceType.PC_MIDDLE;
		}
		this.UpdateQualityRange();
		int activeTier = (int)RemoteInfo.Instance.ActiveTier;
		if (PerfSightController.IsEnable)
		{
			UPerfSightHelper.PostEvent(839, activeTier.ToString());
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Render;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "初始化当前设备基本信息";
		<>y__InlineArray20<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray20<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("VendorName", this.VendorName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CPUBrand", this.CPUBrand);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DeviceName", this.DeviceName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BaseProfileName", this.BaseProfileName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("DriverDate", this.DriverDate);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("DriverVersion", this.DriverVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("AdapterDriverVersion", this.AdapterDriverVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("PhysicalGBRam", this.DevicePhysicalGbRam.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("VideoGbRam", this.DeviceVideoGbRam.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("DeviceScore", this.DeviceScore.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("RHIName", this.RHIName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("WindowsVersion", this.WindowsVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("IsSSDDevice", this.IsSSDDevice.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 13) = new ValueTuple<string, object>("HardwareLevel", this.HardwareLevel.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 14) = new ValueTuple<string, object>("DeviceType", this.DeviceType.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 15) = new ValueTuple<string, object>("ResourceQualityTier", activeTier.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 16) = new ValueTuple<string, object>("QualityRange", this.QualityRange.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 17) = new ValueTuple<string, object>("platform", Platform.Instance.Type.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 18) = new ValueTuple<string, object>("MobileDeviceModel", this.MobileDeviceModel);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 19) = new ValueTuple<string, object>("LowMemoryDeviceMark", this.LowMemoryDeviceMark.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray20<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 20));
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x000F16CB File Offset: 0x000EF8CB
	public void Initialize()
	{
		EventSystem.Instance.Emit(EEventName.AfterGameQualitySettingsManagerInitialize);
	}

	// Token: 0x06002738 RID: 10040 RVA: 0x000F16DD File Offset: 0x000EF8DD
	public void Clear()
	{
		this.CancelAllPerformanceLimit();
	}

	// Token: 0x06002739 RID: 10041 RVA: 0x000F16E8 File Offset: 0x000EF8E8
	public bool IsDriverNeedUpdate()
	{
		string pattern = "(\\d{1,2})-(\\d{1,2})-(\\d{4})";
		Match match = Regex.Match(this.DriverDate, pattern);
		return (match.Success && int.Parse(match.Groups[3].Value) < 2023) || !UKuroRenderingRuntimeBPPluginBPLibrary.GetDriverValid();
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x000F1738 File Offset: 0x000EF938
	public bool IsDriverNeedUpdateForRayTracing()
	{
		string pattern = "(\\d{1,2})-(\\d{1,2})-(\\d{4})";
		Match match = Regex.Match(this.DriverDate, pattern);
		if (match.Success)
		{
			int num = int.Parse(match.Groups[3].Value);
			int num2 = int.Parse(match.Groups[1].Value);
			int num3 = int.Parse(match.Groups[2].Value);
			if (num < 2024)
			{
				return true;
			}
			if (num == 2024 && num2 < 6)
			{
				return true;
			}
			if (num == 2024 && num2 == 6 && num3 < 4)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x000F17D4 File Offset: 0x000EF9D4
	public bool IsDriverNeedUpdateForRayTracingAMD9000()
	{
		string pattern = "(\\d{1,2})-(\\d{1,2})-(\\d{4})";
		Match match = Regex.Match(this.DriverDate, pattern);
		if (match.Success)
		{
			int num = int.Parse(match.Groups[3].Value);
			int num2 = int.Parse(match.Groups[1].Value);
			int num3 = int.Parse(match.Groups[2].Value);
			if (num < 2025)
			{
				return true;
			}
			if (num == 2025 && num2 < 10)
			{
				return true;
			}
			if (num == 2025 && num2 == 10 && num3 < 25)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x000F1871 File Offset: 0x000EFA71
	public bool IsDxr1_1NotSupported()
	{
		return UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.NotSupportedDxr1_1;
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x000F187C File Offset: 0x000EFA7C
	private void UpdateQualityRange()
	{
		EGameDeviceType egameDeviceType = this.DeviceType;
		this.RecommendQualityDeviceCap = null;
		if (egameDeviceType == EGameDeviceType.PC_HIGHEST && !GameSettingsManager.Instance.IsPcHighestDevice())
		{
			egameDeviceType = EGameDeviceType.PC_HIGH;
			this.RecommendQualityDeviceCap = new EGameQualitySettingLevel?(EGameQualitySettingLevel.High);
		}
		switch (egameDeviceType)
		{
		case EGameDeviceType.PC_LOWEST:
		case EGameDeviceType.PC_LOW:
		case EGameDeviceType.ANDROID_LOWEST:
		case EGameDeviceType.ANDROID_LOW:
		case EGameDeviceType.IOS_LOWEST:
		case EGameDeviceType.IOS_LOW:
			return;
		case EGameDeviceType.PC_MIDDLE:
		case EGameDeviceType.ANDROID_MIDDLE:
		case EGameDeviceType.ANDROID_HIGH:
		case EGameDeviceType.IOS_MIDDLE:
		case EGameDeviceType.IOS_HIGH:
			this.QualityRange = EGameQualityRange.One2Three;
			return;
		case EGameDeviceType.PC_HIGH:
			this.QualityRange = EGameQualityRange.One2Three;
			return;
		case EGameDeviceType.PC_VERY_HIGH:
		case EGameDeviceType.ANDROID_VERY_HIGH:
		case EGameDeviceType.IOS_VERY_HIGH:
			this.QualityRange = EGameQualityRange.Two2Four;
			return;
		case EGameDeviceType.PC_HIGHEST:
			this.QualityRange = EGameQualityRange.Three2Five;
			return;
		case (EGameDeviceType)17:
		case (EGameDeviceType)18:
		case (EGameDeviceType)19:
		case (EGameDeviceType)20:
		case (EGameDeviceType)26:
		case (EGameDeviceType)27:
		case (EGameDeviceType)28:
		case (EGameDeviceType)29:
		case (EGameDeviceType)30:
		case (EGameDeviceType)36:
		case (EGameDeviceType)37:
		case (EGameDeviceType)38:
		case (EGameDeviceType)39:
		case (EGameDeviceType)40:
			break;
		case EGameDeviceType.PS:
			this.QualityRange = EGameQualityRange.Zero2One;
			return;
		default:
			if (egameDeviceType == EGameDeviceType.CLOUD_GAME)
			{
				this.QualityRange = EGameQualityRange.One;
				return;
			}
			if (egameDeviceType == EGameDeviceType.XBox)
			{
				return;
			}
			break;
		}
		this.QualityRange = EGameQualityRange.Zero2Two;
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x000F1984 File Offset: 0x000EFB84
	public DeviceRenderFeature? GetDeviceRenderFeature(EGameQualitySettingLevel qualityLevel)
	{
		DeviceRenderFeature value;
		if (this.DeviceRenderFeatureCfgMap != null && this.DeviceRenderFeatureCfgMap.TryGetValue((int)qualityLevel, out value))
		{
			return new DeviceRenderFeature?(value);
		}
		if (GameSettingsManager.Instance.IsImageQualityUnlockedForTesting())
		{
			EGameDeviceType? imageQualityTestDeviceId = this.GetImageQualityTestDeviceId();
			IReadOnlyList<DeviceRenderFeature> readOnlyList = (imageQualityTestDeviceId == null) ? null : GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)imageQualityTestDeviceId.Value);
			if (readOnlyList != null)
			{
				foreach (DeviceRenderFeature value2 in readOnlyList)
				{
					if (value2.QualityType == (int)qualityLevel)
					{
						return new DeviceRenderFeature?(value2);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x000F1A3C File Offset: 0x000EFC3C
	public EGameDeviceType? GetImageQualityTestDeviceId()
	{
		if (!GameSettingsManager.Instance.CanUnlockImageQualityForTesting())
		{
			return null;
		}
		if (Info.Instance.IsIosPlatform())
		{
			return new EGameDeviceType?(EGameDeviceType.IOS_VERY_HIGH);
		}
		if (Info.Instance.IsMobilePlatform())
		{
			return new EGameDeviceType?(EGameDeviceType.ANDROID_VERY_HIGH);
		}
		if (this.DeviceType >= EGameDeviceType.IOS_LOWEST && this.DeviceType <= EGameDeviceType.IOS_VERY_HIGH)
		{
			return new EGameDeviceType?(EGameDeviceType.IOS_VERY_HIGH);
		}
		if (this.DeviceType >= EGameDeviceType.ANDROID_LOWEST && this.DeviceType <= EGameDeviceType.ANDROID_VERY_HIGH)
		{
			return new EGameDeviceType?(EGameDeviceType.ANDROID_VERY_HIGH);
		}
		return new EGameDeviceType?(EGameDeviceType.PC_MIDDLE);
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x000F1AC6 File Offset: 0x000EFCC6
	public DeviceRenderFeature? GetCurrentDeviceRenderFeature()
	{
		return this.GetDeviceRenderFeature(this.GameQualitySettingLevel);
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x000F1AD4 File Offset: 0x000EFCD4
	public DeviceRenderFeature? GetDefaultDeviceRenderFeature()
	{
		if (this.DeviceRenderFeatureCfgMap != null)
		{
			foreach (KeyValuePair<int, DeviceRenderFeature> keyValuePair in this.DeviceRenderFeatureCfgMap)
			{
				if (keyValuePair.Value.DefaultQuality == 1)
				{
					return new DeviceRenderFeature?(keyValuePair.Value);
				}
			}
		}
		return null;
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x000F1B58 File Offset: 0x000EFD58
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"superResolutionId",
		"qualityId",
		"qualityValue"
	})]
	public ValueTuple<EFunction, EFunction, int> MapSuperResolutionRecommendValue(EFunction superResolutionId, EFunction qualityId, int qualityValue)
	{
		int item = qualityValue;
		EFunction item2;
		EFunction item3;
		if (this.IsDlssGpuDevice())
		{
			item2 = EFunction.NVIDIADLSS;
			item3 = EFunction.NVIDIADLSSQUALITY;
			item = 99;
		}
		else if (this.IsXess2Supported())
		{
			item2 = EFunction.XESS2;
			item3 = EFunction.XESS2_QUALITY;
		}
		else if (this.IsFsr3Supported() && !this.IsFsr3FallbackToFsr())
		{
			item2 = EFunction.FSR3;
			item3 = EFunction.FSR3_QUALITY;
		}
		else
		{
			item2 = EFunction.FSR;
			item3 = EFunction.FSR;
			item = 1;
		}
		return new ValueTuple<EFunction, EFunction, int>(item2, item3, item);
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x000F1BC8 File Offset: 0x000EFDC8
	public Dictionary<EFunction, int> GetOtherChangedValue(DeviceRenderFeature targetCfg)
	{
		this.renderFeatureValueBuffer.Clear();
		this.renderFeatureValueBuffer[EFunction.HIGHESTFPS] = this.GetFrameIndexByList(targetCfg.FPS);
		this.renderFeatureValueBuffer[EFunction.SHADOWQUALITY] = targetCfg.ShadowQuality;
		this.renderFeatureValueBuffer[EFunction.NIAGARAQUALITY] = targetCfg.FxQuality;
		this.renderFeatureValueBuffer[EFunction.IMAGEDETAIL] = targetCfg.ImageDetail;
		this.renderFeatureValueBuffer[EFunction.ANTIALISING] = targetCfg.AntiAliasing;
		this.renderFeatureValueBuffer[EFunction.SCENEAO] = targetCfg.AO;
		this.renderFeatureValueBuffer[EFunction.VOLUMEFOG] = targetCfg.VolumeFog;
		this.renderFeatureValueBuffer[EFunction.VOLUMELIGHT] = targetCfg.VolumeLight;
		this.renderFeatureValueBuffer[EFunction.MOTIONBLUR] = targetCfg.MotionBlur;
		this.renderFeatureValueBuffer[EFunction.PCVSYNC] = targetCfg.VSync;
		this.renderFeatureValueBuffer[EFunction.MOBILERESOLUTION] = targetCfg.ScreenPercentage;
		this.renderFeatureValueBuffer[EFunction.NPCDENSITY] = targetCfg.NpcDensity;
		this.renderFeatureValueBuffer[EFunction.VegetationDensity] = targetCfg.VegetationDensity;
		this.renderFeatureValueBuffer[EFunction.BLOOM] = targetCfg.Bloom;
		this.renderFeatureValueBuffer[EFunction.SUPERRESOLUTION] = targetCfg.SuperResolution;
		this.renderFeatureValueBuffer[EFunction.RayTracing] = targetCfg.Raytracing;
		if (Info.Instance.IsPs5Platform())
		{
			this.renderFeatureValueBuffer[EFunction.PSSR] = 1;
		}
		return this.renderFeatureValueBuffer;
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x000F1D52 File Offset: 0x000EFF52
	private static MenuConfig GetRenderDistanceMenuConfig()
	{
		return GameSettingsManager.Instance.ValidApplyConfigMap[EFunction.LOADINGRANGESCALELEVEL];
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x000F1D68 File Offset: 0x000EFF68
	public static int GetRenderDistanceMaxStepIndex()
	{
		MenuConfig renderDistanceMenuConfig = GameSettingsDeviceRender.GetRenderDistanceMenuConfig();
		decimal d = (decimal)Math.Pow(10.0, (double)renderDistanceMenuConfig.Digits);
		decimal d2 = (decimal)renderDistanceMenuConfig.SliderRange(0);
		return (int)Math.Round(((decimal)renderDistanceMenuConfig.SliderRange(1) - d2) * d, MidpointRounding.AwayFromZero);
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x000F1DC9 File Offset: 0x000EFFC9
	public static int GetRenderDistanceBaseMaxStepIndex()
	{
		return GameSettingsDeviceRender.GetRenderDistanceMaxStepIndex() - 2;
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x000F1DD4 File Offset: 0x000EFFD4
	public static int GetRenderDistanceStepIndex(float value)
	{
		MenuConfig renderDistanceMenuConfig = GameSettingsDeviceRender.GetRenderDistanceMenuConfig();
		float num = renderDistanceMenuConfig.SliderRange(0);
		float max = renderDistanceMenuConfig.SliderRange(1);
		float value2 = MathUtils.Instance.Clamp(value, num, max);
		decimal d = (decimal)Math.Pow(10.0, (double)renderDistanceMenuConfig.Digits);
		return (int)Math.Round(((decimal)value2 - (decimal)num) * d, MidpointRounding.AwayFromZero);
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x000F1E44 File Offset: 0x000F0044
	public static float GetRenderDistanceValueByStepIndex(int stepIndex)
	{
		MenuConfig renderDistanceMenuConfig = GameSettingsDeviceRender.GetRenderDistanceMenuConfig();
		decimal d = (decimal)Math.Pow(10.0, (double)renderDistanceMenuConfig.Digits);
		return (float)Math.Round((decimal)renderDistanceMenuConfig.SliderRange(0) + stepIndex / d, renderDistanceMenuConfig.Digits, MidpointRounding.AwayFromZero);
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x000F1EA4 File Offset: 0x000F00A4
	public static float NormalizeRenderDistanceValue(float value)
	{
		return GameSettingsDeviceRender.GetRenderDistanceValueByStepIndex(GameSettingsDeviceRender.GetRenderDistanceStepIndex(value));
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x000F1EB1 File Offset: 0x000F00B1
	public static int GetRenderDistanceRecommendStepIndex(int index, int count)
	{
		if (count == 1)
		{
			return 0;
		}
		return (int)Math.Round((double)GameSettingsDeviceRender.GetRenderDistanceBaseMaxStepIndex() * (double)index / (double)(count - 1), MidpointRounding.AwayFromZero);
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x000F1ED0 File Offset: 0x000F00D0
	public static int GetRenderDistanceQualityIndex(int stepIndex, int count)
	{
		for (int i = count - 1; i >= 0; i--)
		{
			if (stepIndex >= GameSettingsDeviceRender.GetRenderDistanceRecommendStepIndex(i, count))
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x000F1EF8 File Offset: 0x000F00F8
	public float? GetRenderDistanceRecommendation(int quality)
	{
		IReadOnlyList<DeviceRenderFeature> renderDistanceFeatures = this.GetRenderDistanceFeatures();
		if (renderDistanceFeatures == null)
		{
			return null;
		}
		int index = 0;
		int num = 0;
		while (num < renderDistanceFeatures.Count && renderDistanceFeatures[num].QualityType <= quality)
		{
			index = num;
			num++;
		}
		return new float?(GameSettingsDeviceRender.GetRenderDistanceValueByStepIndex(GameSettingsDeviceRender.GetRenderDistanceRecommendStepIndex(index, renderDistanceFeatures.Count)));
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x000F1F57 File Offset: 0x000F0157
	public float? GetLoadingRangeScaleDefault(DeviceRenderFeature featureCfg)
	{
		return this.GetRenderDistanceRecommendation(featureCfg.QualityType);
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x000F1F68 File Offset: 0x000F0168
	public Dictionary<EFunction, float> GetOtherChangedFloatValue(DeviceRenderFeature targetCfg)
	{
		Dictionary<EFunction, float> dictionary = new Dictionary<EFunction, float>();
		if (GameSettingsManager.Instance.IsValid(EFunction.LOADINGRANGESCALELEVEL, false))
		{
			float? loadingRangeScaleDefault = this.GetLoadingRangeScaleDefault(targetCfg);
			if (loadingRangeScaleDefault != null)
			{
				dictionary[EFunction.LOADINGRANGESCALELEVEL] = loadingRangeScaleDefault.Value;
			}
		}
		return dictionary;
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x000F1FB4 File Offset: 0x000F01B4
	[NullableContext(2)]
	public IReadOnlyList<DeviceRenderFeature> GetRenderDistanceFeatures()
	{
		EGameDeviceType? egameDeviceType = GameSettingsManager.Instance.IsImageQualityUnlockedForTesting() ? this.GetImageQualityTestDeviceId() : null;
		if (this.RenderDistanceFeatures != null)
		{
			EGameDeviceType? egameDeviceType2 = this.RenderDistanceDeviceType;
			EGameDeviceType deviceType = this.DeviceType;
			if (egameDeviceType2.GetValueOrDefault() == deviceType & egameDeviceType2 != null)
			{
				egameDeviceType2 = this.RenderDistanceTestDeviceId;
				EGameDeviceType? egameDeviceType3 = egameDeviceType;
				if (egameDeviceType2.GetValueOrDefault() == egameDeviceType3.GetValueOrDefault() & egameDeviceType2 != null == (egameDeviceType3 != null))
				{
					goto IL_1CF;
				}
			}
		}
		IReadOnlyList<DeviceRenderFeature> deviceRenderFeatureConfigListByDeviceId = GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)this.DeviceType);
		if (deviceRenderFeatureConfigListByDeviceId == null || deviceRenderFeatureConfigListByDeviceId.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZD;
			string message = "渲染距离机型配置查询失败或无配置行";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deviceType", this.DeviceType.ToString());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		List<DeviceRenderFeature> list = new List<DeviceRenderFeature>(deviceRenderFeatureConfigListByDeviceId);
		if (egameDeviceType != null)
		{
			IReadOnlyList<DeviceRenderFeature> deviceRenderFeatureConfigListByDeviceId2 = GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)egameDeviceType.Value);
			if (deviceRenderFeatureConfigListByDeviceId2 != null)
			{
				HashSet<int> hashSet = new HashSet<int>();
				foreach (DeviceRenderFeature deviceRenderFeature in list)
				{
					hashSet.Add(deviceRenderFeature.QualityType);
				}
				foreach (DeviceRenderFeature item in deviceRenderFeatureConfigListByDeviceId2)
				{
					if (hashSet.Add(item.QualityType))
					{
						list.Add(item);
					}
				}
			}
		}
		list.Sort((DeviceRenderFeature left, DeviceRenderFeature right) => left.QualityType.CompareTo(right.QualityType));
		this.RenderDistanceFeatures = list;
		this.RenderDistanceDeviceType = new EGameDeviceType?(this.DeviceType);
		this.RenderDistanceTestDeviceId = egameDeviceType;
		IL_1CF:
		return this.RenderDistanceFeatures;
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000F21B4 File Offset: 0x000F03B4
	public bool IsIosAndAndroidHighDevice()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH || this.DeviceType == EGameDeviceType.IOS_MIDDLE || this.DeviceType == EGameDeviceType.IOS_HIGH || this.DeviceType == EGameDeviceType.IOS_VERY_HIGH;
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x000F21F4 File Offset: 0x000F03F4
	public bool IsAndroidPlatformNotLow()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOW || this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000F2220 File Offset: 0x000F0420
	public bool IsAndroidPlatformScreenBetter()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x000F2242 File Offset: 0x000F0442
	public bool IsAndroidPlatformScreenBad()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOWEST || this.DeviceType == EGameDeviceType.ANDROID_LOW;
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x000F225A File Offset: 0x000F045A
	public bool IsAndroidPlatformLowest()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOWEST;
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x000F2266 File Offset: 0x000F0466
	public bool IsAndroidPlatformLow()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOW;
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x000F2272 File Offset: 0x000F0472
	public bool IsAndroidPlatformAOValid()
	{
		return Platform.Instance.IsAndroidPlatform() && !this.IsAndroidPlatformScreenBad();
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x000F228B File Offset: 0x000F048B
	public bool IsIOSPlatformAOValid()
	{
		return Platform.Instance.IsIOSPlatform() && this.DeviceScore >= 230;
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x000F22AB File Offset: 0x000F04AB
	public bool IsOpenHarmonyPlatformAOValid()
	{
		return Platform.Instance.IsOpenHarmonyPlatform() && !this.IsAndroidPlatformScreenBad();
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x000F22C4 File Offset: 0x000F04C4
	public bool IsAndroidAdreno()
	{
		return this.IsAdreno;
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x000F22CC File Offset: 0x000F04CC
	public bool IsRedMagic()
	{
		return Platform.Instance.IsRedMagicDevice();
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x000F22D8 File Offset: 0x000F04D8
	public bool IsRedMagicLow()
	{
		return Platform.Instance.IsRedMagicDeviceLow();
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x000F22E4 File Offset: 0x000F04E4
	public bool IsRedMagicHigh()
	{
		return Platform.Instance.IsRedMagicDeviceHigh();
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x000F22F0 File Offset: 0x000F04F0
	public bool IsLowMemoryDevice()
	{
		return (Info.Instance.PlatformType == ESourcePlatformType.IOS && this.DevicePhysicalGbRam < 4) || (Info.Instance.PlatformType == ESourcePlatformType.Android && this.DevicePhysicalGbRam <= 4);
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x000F2323 File Offset: 0x000F0523
	public int GetD3D12Type()
	{
		if (this.RHIName.Contains("D3D12"))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x000F233A File Offset: 0x000F053A
	public int IsVulkanRHI()
	{
		if (this.RHIName.Contains("Vulkan"))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x000F2351 File Offset: 0x000F0551
	public int IsMetalCpp()
	{
		if (this.RHIName.Contains("MetalNew"))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06002761 RID: 10081 RVA: 0x000F2368 File Offset: 0x000F0568
	public bool IsQualcommGpu()
	{
		return this.DeviceName.Contains("Qualcomm(R) Adreno(TM)");
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x000F237C File Offset: 0x000F057C
	public bool IsMaliNewSocOrXclipseOrPowerVR()
	{
		return this.DeviceName.Contains("G710") || this.DeviceName.Contains("G715") || this.DeviceName.Contains("G720") || this.DeviceName.Contains("G610") || this.DeviceName.Contains("G615") || this.DeviceName.Contains("G620") || this.DeviceName.Contains("Xclipse") || this.DeviceName.Contains("BXM-8-256");
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x000F241C File Offset: 0x000F061C
	public bool IsHuaweiAndroid()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.DeviceName.Contains("Maleoon") && Platform.Instance.IsAndroidPlatform();
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x000F2478 File Offset: 0x000F0678
	private string GetMaleoonModel()
	{
		if (string.IsNullOrEmpty(this.DeviceName))
		{
			return string.Empty;
		}
		Match match = Regex.Match(this.DeviceName, "Maleoon\\s*(\\d+[A-Z]?)(?![A-Z0-9])", RegexOptions.IgnoreCase);
		if (match.Success)
		{
			return match.Groups[1].Value.ToUpperInvariant();
		}
		return string.Empty;
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x000F24D0 File Offset: 0x000F06D0
	private int GetOpenHarmonyMajorVersion()
	{
		string osversion = UKuroStaticLibrary.GetOSVersion();
		if (string.IsNullOrEmpty(osversion))
		{
			return 0;
		}
		Match match = Regex.Match(osversion, "(\\d+)\\.\\d+\\.\\d+");
		if (match.Success)
		{
			return int.Parse(match.Groups[1].Value);
		}
		return 0;
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x000F251C File Offset: 0x000F071C
	public bool IsMaleoonSuperResolutionSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return (maleoonModel == "935" || maleoonModel == "935A" || maleoonModel == "955" || maleoonModel == "955A") && this.GetOpenHarmonyMajorVersion() >= 7;
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x000F2584 File Offset: 0x000F0784
	public bool IsMaleoonRayTracingNormalSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return maleoonModel == "935" || maleoonModel == "935A";
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x000F25C0 File Offset: 0x000F07C0
	public bool IsMaleoonRayTracingSuperSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return maleoonModel == "955" || maleoonModel == "955A";
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x000F25FC File Offset: 0x000F07FC
	public bool IsNvidiaGPU()
	{
		return this.VendorName == "NVIDIA";
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x000F2610 File Offset: 0x000F0810
	public bool IsUltraGpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && this.DeviceName.Contains("RTX");
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x000F2665 File Offset: 0x000F0865
	public bool IsNvidia4060()
	{
		return this.IsNvidiaGPU() && this.DeviceName.Contains("4060");
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x000F2684 File Offset: 0x000F0884
	public bool IsNvidia5060AndAbove()
	{
		Match match = Regex.Match(this.DeviceName, "\\bRTX\\s*(50\\d{2})\\b", RegexOptions.IgnoreCase);
		if (!match.Success)
		{
			return false;
		}
		int num = int.Parse(match.Groups[1].Value);
		return this.IsNvidiaGPU() && num >= 5060;
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x000F26D9 File Offset: 0x000F08D9
	public bool IsNvidiaLaptopGPU()
	{
		return this.IsNvidiaGPU() && this.DeviceName.Contains("Laptop");
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x000F26F8 File Offset: 0x000F08F8
	public bool Is120FrameGPU()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameQualitySettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return ((this.VendorName == "AMD" || this.IsNvidiaGPU() || this.VendorName == "Intel") && this.DeviceScore > 1300) || (this.VendorName == "Intel" && UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported);
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x000F2788 File Offset: 0x000F0988
	public bool IsLaptopCPU_Old()
	{
		return this.CPUBrand.Contains("14900") || this.CPUBrand.Contains("14790") || this.CPUBrand.Contains("14700") || this.CPUBrand.Contains("14650") || this.CPUBrand.Contains("14600") || this.CPUBrand.Contains("14500") || this.CPUBrand.Contains("14490") || this.CPUBrand.Contains("14450") || this.CPUBrand.Contains("14400") || this.CPUBrand.Contains("13980") || this.CPUBrand.Contains("13950") || this.CPUBrand.Contains("13905") || this.CPUBrand.Contains("13900") || this.CPUBrand.Contains("13800") || this.CPUBrand.Contains("13790") || this.CPUBrand.Contains("13705") || this.CPUBrand.Contains("13700") || this.CPUBrand.Contains("13650") || this.CPUBrand.Contains("13620") || this.CPUBrand.Contains("13600") || this.CPUBrand.Contains("13500") || this.CPUBrand.Contains("13490") || this.CPUBrand.Contains("13450") || this.CPUBrand.Contains("13400") || this.CPUBrand.Contains("12950") || this.CPUBrand.Contains("12900") || this.CPUBrand.Contains("12850") || this.CPUBrand.Contains("12800") || this.CPUBrand.Contains("12700") || this.CPUBrand.Contains("12650") || this.CPUBrand.Contains("12600") || this.CPUBrand.Contains("12500") || this.CPUBrand.Contains("11980") || this.CPUBrand.Contains("11950") || this.CPUBrand.Contains("11900") || this.CPUBrand.Contains("11850") || this.CPUBrand.Contains("11800") || this.CPUBrand.Contains("11700") || this.CPUBrand.Contains("10980") || this.CPUBrand.Contains("10940") || this.CPUBrand.Contains("10920") || this.CPUBrand.Contains("10900") || this.CPUBrand.Contains("10885") || this.CPUBrand.Contains("10875") || this.CPUBrand.Contains("10870") || this.CPUBrand.Contains("10850") || this.CPUBrand.Contains("10700") || this.CPUBrand.Contains("9980") || this.CPUBrand.Contains("9940") || this.CPUBrand.Contains("9920") || this.CPUBrand.Contains("9900") || this.CPUBrand.Contains("9880") || this.CPUBrand.Contains("9820") || this.CPUBrand.Contains("9800") || this.CPUBrand.Contains("9-7900") || this.CPUBrand.Contains("7-7820") || this.CPUBrand.Contains("7-6900") || this.CPUBrand.Contains("9-185") || this.CPUBrand.Contains("7-165") || this.CPUBrand.Contains("7-155") || this.CPUBrand.Contains("5-135") || this.CPUBrand.Contains("5-125") || this.CPUBrand.Contains("9-3495") || this.CPUBrand.Contains("9-3475") || this.CPUBrand.Contains("7-3465") || this.CPUBrand.Contains("7-3455") || this.CPUBrand.Contains("7-3445") || this.CPUBrand.Contains("5-3435") || this.CPUBrand.Contains("5-3425") || this.CPUBrand.Contains("7-1270") || this.CPUBrand.Contains("7-1260") || this.CPUBrand.Contains("5-1250") || this.CPUBrand.Contains("5-1240") || this.CPUBrand.Contains("9700") || this.CPUBrand.Contains("9600") || this.CPUBrand.Contains("8945") || this.CPUBrand.Contains("8845") || this.CPUBrand.Contains("8840") || this.CPUBrand.Contains("8700") || this.CPUBrand.Contains("7980") || this.CPUBrand.Contains("7970") || this.CPUBrand.Contains("7960") || this.CPUBrand.Contains("7950") || this.CPUBrand.Contains("7945") || this.CPUBrand.Contains("7940") || this.CPUBrand.Contains("7900") || this.CPUBrand.Contains("7845") || this.CPUBrand.Contains("7840") || this.CPUBrand.Contains("7800") || this.CPUBrand.Contains("7745") || this.CPUBrand.Contains("7735") || this.CPUBrand.Contains("7700") || this.CPUBrand.Contains("6980") || this.CPUBrand.Contains("6900") || this.CPUBrand.Contains("6800") || this.CPUBrand.Contains("5980") || this.CPUBrand.Contains("5975") || this.CPUBrand.Contains("5965") || this.CPUBrand.Contains("5955") || this.CPUBrand.Contains("5950") || this.CPUBrand.Contains("5945") || this.CPUBrand.Contains("5900") || this.CPUBrand.Contains("5800") || this.CPUBrand.Contains("5700") || this.CPUBrand.Contains("4900") || this.CPUBrand.Contains("4800") || this.CPUBrand.Contains("4700") || this.CPUBrand.Contains("3975") || this.CPUBrand.Contains("3970") || this.CPUBrand.Contains("3960") || this.CPUBrand.Contains("3955") || this.CPUBrand.Contains("3950") || this.CPUBrand.Contains("3945") || this.CPUBrand.Contains("3900") || this.CPUBrand.Contains("3800") || this.CPUBrand.Contains("3700") || this.CPUBrand.Contains("2950") || this.CPUBrand.Contains("2920") || this.CPUBrand.Contains("2700") || this.CPUBrand.Contains("1950") || this.CPUBrand.Contains("1920") || this.CPUBrand.Contains("1900") || this.CPUBrand.Contains("1800") || this.CPUBrand.Contains("1700") || this.CPUBrand.Contains("Intel(R) Core(TM) i5-11600K") || this.CPUBrand.Contains("Intel(R) Core(TM) i5-12490F") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 9 28") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 9 27") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 7 26") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 7 25") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 5 24") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 5 23") || this.CPUBrand.Contains("AMD Ryzen 5 9") || this.CPUBrand.Contains("AMD Ryzen 7 9") || this.CPUBrand.Contains("AMD Ryzen 9 9") || this.CPUBrand.Contains("AMD Ryzen 5 8600") || this.CPUBrand.Contains("AMD Ryzen 7 7435H");
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x000F32BC File Offset: 0x000F14BC
	public bool IsLaptopCPU()
	{
		if (this.IsLaptopCPU_Old())
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "IsOldLaptopCPU", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		string text = this.CPUBrand.ToUpperInvariant();
		if (text.Contains("INTEL"))
		{
			bool flag = Regex.IsMatch(text, "\\b\\d+(HX|HK|H|P|U|Y|G1|G2|G3|G4|G5|G6|G7)\\b");
			bool flag2 = Regex.IsMatch(text, "\\b\\d+(K|F|KF|T)\\b");
			return flag && !flag2;
		}
		if (text.Contains("AMD"))
		{
			bool flag3 = Regex.IsMatch(text, "\\b\\d+(H|HS|HX|U)\\b");
			bool flag4 = Regex.IsMatch(text, "\\b(H|HS|HX|U)\\b");
			return flag3 || flag4;
		}
		return false;
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x000F3358 File Offset: 0x000F1558
	private bool IsFrameRate120IOSDevice()
	{
		return Info.Instance.PlatformType == ESourcePlatformType.IOS && this.DeviceScore > 500;
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x000F3376 File Offset: 0x000F1576
	private bool IsFrameRate120MacDevice()
	{
		return Info.Instance.PlatformType == ESourcePlatformType.Mac && this.DeviceScore > 500;
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x000F3394 File Offset: 0x000F1594
	private bool IsAMDX3DCPU()
	{
		return this.CPUBrand.Contains("AMD") && this.CPUBrand.Contains("X3D");
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x000F33BC File Offset: 0x000F15BC
	private unsafe bool IsFrameRate120Device()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Render;
		ELogAuthor author = ELogAuthor.YJL;
		string message = "判断IsFrameRate120Device";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CPUFrequency", this.CPUFrequency.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CPUCoresIncludingHyperthreads", this.CPUCoresIncludingHyperthreads.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AMDX3DCPU", this.IsAMDX3DCPU().ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsLaptopCPU", this.IsLaptopCPU().ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Is120FrameGPU", this.Is120FrameGPU().ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		return ((this.CPUFrequency >= 3000 && this.CPUCoresIncludingHyperthreads >= 16) || this.IsAMDX3DCPU() || this.IsLaptopCPU()) && this.Is120FrameGPU();
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x000F34D1 File Offset: 0x000F16D1
	public bool IsFrameRate120DeviceForAllDevice()
	{
		return (Info.Instance.IsPcOrGamepadPlatform() && this.IsFrameRate120Device()) || (Info.Instance.IsIosPlatform() && this.IsFrameRate120IOSDevice()) || (Info.Instance.IsMacPlatform() && this.IsFrameRate120MacDevice());
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x000F3511 File Offset: 0x000F1711
	public bool IsAndroidHighestResolutionDevice()
	{
		return this.DeviceScore >= 280;
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x000F3523 File Offset: 0x000F1723
	public bool IsAndroidHighResolutionDevice()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x000F3545 File Offset: 0x000F1745
	public bool IsMetalFxDevice()
	{
		return UKuroRenderingRuntimeBPPluginBPLibrary.IsSupportsMetalFx();
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x000F354C File Offset: 0x000F174C
	public bool IsPWSDKDevice()
	{
		return false;
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x000F354F File Offset: 0x000F174F
	public bool IsIRXActive()
	{
		return false;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x000F3552 File Offset: 0x000F1752
	public void TurnOffIRX()
	{
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x000F3554 File Offset: 0x000F1754
	public void TurnOnIRX()
	{
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x000F3556 File Offset: 0x000F1756
	public bool IsNvidiaDlessPluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.Enable") == 1;
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x000F3565 File Offset: 0x000F1765
	public bool IsNvidiaStreamlinePluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableBoolValue("r.Streamline.HasLoaded");
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x000F3571 File Offset: 0x000F1771
	public bool IsNvidiaDlssPluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.Enable") == 1;
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x000F3580 File Offset: 0x000F1780
	public bool IsDlssGpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && this.DeviceName.Contains("RTX");
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x000F35D8 File Offset: 0x000F17D8
	private int? GetRTXSeriesNumber(string deviceName)
	{
		if (string.IsNullOrEmpty(deviceName))
		{
			return null;
		}
		Match match = Regex.Match(deviceName, "RTX\\s*(\\d+)", RegexOptions.IgnoreCase);
		if (match.Success && match.Groups.Count > 1)
		{
			return new int?(int.Parse(match.Groups[1].Value));
		}
		return null;
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x000F3640 File Offset: 0x000F1840
	private int? GetAMDSeriesNumber(string deviceName)
	{
		if (string.IsNullOrEmpty(deviceName))
		{
			return null;
		}
		Match match = Regex.Match(deviceName, "RX\\s*(\\d+)", RegexOptions.IgnoreCase);
		if (match.Success && match.Groups.Count > 1)
		{
			return new int?(int.Parse(match.Groups[1].Value));
		}
		return null;
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x000F36A8 File Offset: 0x000F18A8
	public unsafe bool IsRayTracingGpuDevice()
	{
		string a = this.VendorName.ToLower();
		if (a == "intel")
		{
			bool flag = UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported;
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Render;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "Intel显卡，引擎底层检测不支持光追";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("deviceName", this.DeviceName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flag;
		}
		if (a == "amd")
		{
			int? amdseriesNumber = this.GetAMDSeriesNumber(this.DeviceName);
			if (amdseriesNumber == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Render;
				ELogAuthor author2 = ELogAuthor.WZ;
				string message2 = "非AMD RX系列，或者型号解析不出来，不能开启光追";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("deviceName", this.DeviceName);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (MathUtils.Instance.InRangeArray((double)amdseriesNumber.Value, new double[]
			{
				6700.0,
				6799.0
			}) || MathUtils.Instance.InRangeArray((double)amdseriesNumber.Value, new double[]
			{
				7600.0,
				7699.0
			}))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Render;
				ELogAuthor author3 = ELogAuthor.WZ;
				string message3 = "AMD RX 某些型号不支持光追";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("amdSeriesNumber", amdseriesNumber.Value.ToString());
				instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			if (MathUtils.Instance.InRangeArray((double)amdseriesNumber.Value, new double[]
			{
				9000.0,
				9999.0
			}) && this.IsDriverNeedUpdateForRayTracingAMD9000())
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Render;
				ELogAuthor author4 = ELogAuthor.WX;
				string message4 = "AMD 9000 驱动不支持光追";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("amdSeriesNumber", amdseriesNumber.Value.ToString());
				instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			bool flag2 = UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported;
			if (!flag2)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Render;
				ELogAuthor author5 = ELogAuthor.WZ;
				string message5 = "AMD显卡满足型号要求，但引擎底层检测不支持光追";
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("amdSeriesNumber", amdseriesNumber.Value.ToString());
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			}
			return flag2;
		}
		else
		{
			if (!(a == "nvidia"))
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Render;
				ELogAuthor author6 = ELogAuthor.WZ;
				string message6 = "不可识别的显卡类型，不能开启光追";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("vendorName", this.VendorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("deviceName", this.DeviceName);
				instance6.Warn(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (this.DeviceName.ToLower().Contains("titan rtx"))
			{
				bool flag3 = UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported;
				if (!flag3)
				{
					Log.Instance.Warn(ELogModule.Render, ELogAuthor.WZ, "NVIDIA Titan RTX，引擎底层检测不支持光追", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return flag3;
			}
			int? rtxseriesNumber = this.GetRTXSeriesNumber(this.DeviceName);
			if (rtxseriesNumber == null)
			{
				Log instance7 = Log.Instance;
				ELogModule module7 = ELogModule.Render;
				ELogAuthor author7 = ELogAuthor.WZ;
				string message7 = "非RTX系列，或者型号解析不出来，不能开启光追";
				ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("deviceName", this.DeviceName);
				instance7.Warn(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
				return false;
			}
			int? num = rtxseriesNumber;
			int num2 = 2070;
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				num = rtxseriesNumber;
				num2 = 3000;
				if (!(num.GetValueOrDefault() < num2 & num != null))
				{
					num = rtxseriesNumber;
					num2 = 3060;
					if (!(num.GetValueOrDefault() >= num2 & num != null))
					{
						goto IL_336;
					}
				}
				bool flag4 = UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported;
				if (!flag4)
				{
					Log instance8 = Log.Instance;
					ELogModule module8 = ELogModule.Render;
					ELogAuthor author8 = ELogAuthor.WZ;
					string message8 = "NVIDIA显卡满足型号要求，但引擎底层检测不支持光追";
					ValueTuple<string, object> valueTuple7 = new ValueTuple<string, object>("nvSeriesNumber", rtxseriesNumber.Value.ToString());
					instance8.Warn(module8, author8, message8, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple7));
				}
				return flag4;
			}
			IL_336:
			Log instance9 = Log.Instance;
			ELogModule module9 = ELogModule.Render;
			ELogAuthor author9 = ELogAuthor.WZ;
			string message9 = "NVIDIA RTX 型号未达到光追白名单要求";
			ValueTuple<string, object> valueTuple8 = new ValueTuple<string, object>("nvSeriesNumber", rtxseriesNumber.Value.ToString());
			instance9.Warn(module9, author9, message9, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple8));
			return false;
		}
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x000F3A84 File Offset: 0x000F1C84
	public bool IsRTX50()
	{
		int? rtxseriesNumber = this.GetRTXSeriesNumber(this.DeviceName);
		return rtxseriesNumber != null && rtxseriesNumber.Value > 5000;
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x000F3AB8 File Offset: 0x000F1CB8
	public bool IsShowRayTracingSetting()
	{
		if (this.IsRayTracingGpuDevice())
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.WZ, "允许显示光追设置：当前设备为支持光追的设备", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		if (UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.NotSupportedDxr1_1)
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.WZ, "允许显示光追设置：设备不支持 DXR 1.1", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		return false;
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x000F3B14 File Offset: 0x000F1D14
	public bool IsDlss3HardwareSchedulingDisabled()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (!this.IsNvidiaDlssPluginLoaded() || !this.IsNvidiaStreamlinePluginLoaded())
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.WX, "DlSS or Streamline尚未加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return UStreamlineLibraryDLSSG.QueryDLSSGSupport() == EStreamlineFeatureSupport.NotSupportedHardewareSchedulingDisabled;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000F3B82 File Offset: 0x000F1D82
	public bool IsDlssSupported()
	{
		return this.IsNvidiaDlssPluginLoaded() && UDLSSLibrary.IsDLSSSupported();
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000F3B94 File Offset: 0x000F1D94
	public bool IsDlss3GpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && (this.DeviceName.Contains("RTX 40") || this.DeviceName.Contains("RTX 50"));
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x000F3BFC File Offset: 0x000F1DFC
	public bool IsFsrDevice()
	{
		if (Platform.Instance.IsPs5Platform())
		{
			Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "PS5不支持Fsr", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		bool flag = this.IsDlssGpuDevice();
		bool flag2 = this.IsXess2Supported();
		bool flag3 = this.IsMetalFxDevice();
		bool flag4 = this.IsFsr3Supported() && UKuroFFXFSR3BlueprintLibrary.IsGlobalSwitchOn();
		return !flag && !flag2 && !flag3 && !flag4;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000F3C66 File Offset: 0x000F1E66
	public bool IsXess2Supported()
	{
		return UXeSSBlueprintLibrary.IsXeSSSupported();
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x000F3C6D File Offset: 0x000F1E6D
	public bool IsXeFGSupported()
	{
		return UXeFGBlueprintLibrary.IsXeFGSupported();
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x000F3C74 File Offset: 0x000F1E74
	public bool IsSteamDeck()
	{
		if (this.IsSteamDeckInternal == null)
		{
			this.IsSteamDeckInternal = new bool?(Environment.GetEnvironmentVariable("SteamDeck") == "1" || Environment.GetEnvironmentVariable("SteamOS") == "1");
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.DX;
			string message = "IsSteamDeck";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", (this.IsSteamDeckInternal.Value > false) ? 1 : 0);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return this.IsSteamDeckInternal.Value;
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x000F3D0A File Offset: 0x000F1F0A
	public bool IsFsr3Supported()
	{
		return !this.IsSteamDeck() && UKuroFFXFSR3BlueprintLibrary.IsSupported() && UKuroFFXFSR3BlueprintLibrary.SupportFSR3();
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x000F3D24 File Offset: 0x000F1F24
	public bool IsFFXFISupported()
	{
		return !this.IsSteamDeck() && UKuroFFXFSR3BlueprintLibrary.IsSupported() && UKuroFFXFSR3BlueprintLibrary.SupportFI();
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x000F3D3E File Offset: 0x000F1F3E
	public bool IsFsr3FallbackToFsr()
	{
		return this.IsFsr3Supported() && this.GetD3D12Type() <= 0;
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x000F3D58 File Offset: 0x000F1F58
	public bool IsVulkanDevice()
	{
		bool flag = UKismetSystemLibrary.IsVulkanAutoDetectMode();
		bool flag2 = UKuroRenderingRuntimeBPPluginBPLibrary.SupportVulkan();
		if (flag)
		{
			string mobileDeviceModel = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceModel();
			TArray<string> vulkanAllowedModels = UKismetSystemLibrary.GetVulkanAllowedModels();
			bool flag3 = false;
			for (int i = 0; i < vulkanAllowedModels.Num(); i++)
			{
				if (vulkanAllowedModels.Get(i).Contains(mobileDeviceModel))
				{
					flag3 = true;
					break;
				}
			}
			flag2 = (flag2 || flag3);
			TArray<string> vulkanBlockedModels = UKismetSystemLibrary.GetVulkanBlockedModels();
			bool flag4 = false;
			for (int j = 0; j < vulkanBlockedModels.Num(); j++)
			{
				if (vulkanBlockedModels.Get(j).Contains(mobileDeviceModel))
				{
					flag4 = true;
					break;
				}
			}
			flag2 = (flag2 && !flag4);
		}
		else
		{
			TArray<string> vulkanAllowedModels2 = UKismetSystemLibrary.GetVulkanAllowedModels();
			TArray<string> vulkanBlockedModels2 = UKismetSystemLibrary.GetVulkanBlockedModels();
			string mobileDeviceModel2 = UKuroRenderingRuntimeBPPluginBPLibrary.GetMobileDeviceModel();
			if (mobileDeviceModel2.Length != 0)
			{
				bool flag5 = false;
				for (int k = 0; k < vulkanAllowedModels2.Num(); k++)
				{
					if (vulkanAllowedModels2.Get(k).Contains(mobileDeviceModel2))
					{
						flag5 = true;
						break;
					}
				}
				bool flag6 = false;
				for (int l = 0; l < vulkanBlockedModels2.Num(); l++)
				{
					if (vulkanBlockedModels2.Get(l).Contains(mobileDeviceModel2))
					{
						flag6 = true;
						break;
					}
				}
				flag2 = (flag5 && !flag6);
			}
		}
		return flag2;
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x000F3E83 File Offset: 0x000F2083
	public bool IsEnableVolumeFog()
	{
		return this.EnableVolumeFog;
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x000F3E8B File Offset: 0x000F208B
	public void CloseVolumeFog()
	{
		this.EnableVolumeFog = false;
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.volumetricfog 0", null);
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000F3EA4 File Offset: 0x000F20A4
	public FIntPoint GetResolutionByList(int index)
	{
		List<FIntPoint> resolutionList = this.GetResolutionList();
		int index2 = MathUtils.Instance.Clamp(index, 0, resolutionList.Count - 1);
		return resolutionList[index2];
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x000F3ED4 File Offset: 0x000F20D4
	public List<FIntPoint> GetResolutionList()
	{
		List<FIntPoint> list = new List<FIntPoint>();
		if (list.Count == 0)
		{
			this.ResolutionListRef = new TArray<FIntPoint>();
			if (UKismetSystemLibrary.GetSupportedFullscreenResolutions(ref this.ResolutionListRef))
			{
				for (int i = this.ResolutionListRef.Num() - 1; i >= 0; i--)
				{
					FIntPoint item = this.ResolutionListRef.Get(i);
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				list.Add(UGameUserSettings.GetGameUserSettings().GetDesktopResolution());
				Log.Instance.Warn(ELogModule.Menu, ELogAuthor.ZJF, "获取分辨率列表失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				list.Sort(delegate(FIntPoint a, FIntPoint b)
				{
					if (a.X == b.X)
					{
						return b.Y.CompareTo(a.Y);
					}
					return b.X.CompareTo(a.X);
				});
			}
		}
		if (list.Count > 0 && list[0].X == 3620 && list[0].Y == 2036)
		{
			list.RemoveAt(0);
		}
		return list;
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x000F3FC8 File Offset: 0x000F21C8
	public unsafe int GetResolutionIndexByList(FIntPoint resolution)
	{
		List<FIntPoint> resolutionList = this.GetResolutionList();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < resolutionList.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(',');
			}
			FIntPoint fintPoint = resolutionList[i];
			stringBuilder.Append(fintPoint.X).Append('x').Append(fintPoint.Y);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Render;
		ELogAuthor author = ELogAuthor.WZ;
		string message = "获取分辨率索引时的列表";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("resolutionList", stringBuilder.ToString());
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "current resolution";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(resolution.X);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(resolution.Y);
		ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		int num = 0;
		foreach (FIntPoint fintPoint2 in resolutionList)
		{
			if (fintPoint2.Equals(resolution))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x000F4114 File Offset: 0x000F2314
	public FIntPoint GetDefaultScreenResolution()
	{
		if (this.DefaultResolution == null)
		{
			List<FIntPoint> resolutionList = this.GetResolutionList();
			if (resolutionList.Count > 0)
			{
				FIntPoint fintPoint = resolutionList[0];
				if (!this.IsUltraGpuDevice() && (fintPoint.X > 2000 || fintPoint.Y > 1100))
				{
					foreach (FIntPoint fintPoint2 in resolutionList)
					{
						if (fintPoint2.X < 2000 && fintPoint2.Y < 1100)
						{
							fintPoint = fintPoint2;
							break;
						}
					}
				}
				this.DefaultResolution = new FIntPoint?(fintPoint);
			}
			else
			{
				this.DefaultResolution = new FIntPoint?(UGameUserSettings.GetGameUserSettings().GetDesktopResolution());
			}
		}
		return this.DefaultResolution.Value;
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x000F41F4 File Offset: 0x000F23F4
	public int GetMobileResolutionByIndex(int index)
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			return (new int[]
			{
				70,
				80,
				85,
				100
			})[index];
		}
		if (this.IsAndroidPlatformLowest())
		{
			return (new int[]
			{
				60,
				80,
				85,
				90
			})[index];
		}
		if (this.IsAndroidHighestResolutionDevice())
		{
			return (new int[]
			{
				66,
				75,
				83,
				100
			})[index];
		}
		return (new int[]
		{
			80,
			90,
			100,
			100
		})[index];
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x000F4270 File Offset: 0x000F2470
	public unsafe int GetFrameIndexByList(int frameRate)
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.XSX)
		{
			return 0;
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			if (Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListIos, frameRate) >= 0)
			{
				return Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListIos, frameRate);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "[ios]当前帧数不在帧数列表中，返回0";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("frameRate", frameRate.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("list", string.Join<int>(",", GameSettingsDeviceRenderDefine.FrameRateListIos));
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		else if (Info.Instance.PlatformType == ESourcePlatformType.Android)
		{
			if (Array.IndexOf<int>(this.FrameRateListAndroid, frameRate) >= 0)
			{
				return Array.IndexOf<int>(this.FrameRateListAndroid, frameRate);
			}
			if (frameRate >= 40 && frameRate <= 45 && Array.IndexOf<int>(this.FrameRateListAndroid, 40) >= 0)
			{
				return Array.IndexOf<int>(this.FrameRateListAndroid, 40);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "[android]当前帧数不在帧数列表中，返回0";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("frameRate", frameRate.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("list", string.Join<int>(",", this.FrameRateListAndroid));
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return 0;
		}
		else if (Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony)
		{
			if (Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony, frameRate) >= 0)
			{
				return Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony, frameRate);
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GameSettings;
			ELogAuthor author3 = ELogAuthor.WZ;
			string message3 = "[openharmony]当前帧数不在帧数列表中，返回0";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("frameRate", frameRate.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("list", string.Join<int>(",", GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony));
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return 0;
		}
		else
		{
			if (Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListPc, frameRate) >= 0)
			{
				return Array.IndexOf<int>(GameSettingsDeviceRenderDefine.FrameRateListPc, frameRate);
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.GameSettings;
			ELogAuthor author4 = ELogAuthor.WZ;
			string message4 = "[pc]当前帧数不在帧数列表中，返回0";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("frameRate", frameRate.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("list", string.Join<int>(",", GameSettingsDeviceRenderDefine.FrameRateListAndroid));
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return 0;
		}
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x000F4500 File Offset: 0x000F2700
	public int GetFrameByList(int index)
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			int num = MathUtils.Instance.Clamp(index, 0, GameSettingsDeviceRenderDefine.FrameRateListIos.Length - 1);
			return GameSettingsDeviceRenderDefine.FrameRateListIos[num];
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.Android)
		{
			int num2 = MathUtils.Instance.Clamp(index, 0, this.FrameRateListAndroid.Length - 1);
			return this.FrameRateListAndroid[num2];
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.XSX)
		{
			int num3 = MathUtils.Instance.Clamp(index, 0, GameSettingsDeviceRenderDefine.FrameRateListXSX.Length - 1);
			return GameSettingsDeviceRenderDefine.FrameRateListXSX[num3];
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony)
		{
			int num4 = MathUtils.Instance.Clamp(index, 0, GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony.Length - 1);
			return GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony[num4];
		}
		int num5 = MathUtils.Instance.Clamp(index, 0, GameSettingsDeviceRenderDefine.FrameRateListPc.Length - 1);
		return GameSettingsDeviceRenderDefine.FrameRateListPc[num5];
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x000F45DC File Offset: 0x000F27DC
	public void ApplyDLSSG(int value)
	{
		try
		{
			if (value == 0)
			{
				UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.Off);
				Log.Instance.Info(ELogModule.Game, ELogAuthor.XSZ, "ApplyDLSSG 0", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else if (this.DLSSGEnable)
			{
				if (this.IsRTX50())
				{
					if (value == 1)
					{
						UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.On2X);
					}
					else if (value == 2)
					{
						UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.On3X);
					}
					else if (value == 3)
					{
						UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.On4X);
					}
					else if (value == 4)
					{
						UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.On5X);
					}
					else if (value == 5)
					{
						UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.On6X);
					}
				}
				else
				{
					UStreamlineLibraryDLSSG.SetDLSSGMode(EStreamlineDLSSGMode.Auto);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.XSZ;
				string message = "ApplyDLSSG";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Mode", this.DLSSGMode.ToString());
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.ApplyUnlimitedFrameRate(value != 0);
		}
		catch (Exception ex)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Game;
			ELogAuthor author2 = ELogAuthor.XSZ;
			string message2 = "Module Streamline not found";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", ex.Message);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x000F46EC File Offset: 0x000F28EC
	public unsafe void EnableDLSSG(int value)
	{
		this.DLSSGEnable = (value != 0);
		this.DLSSGMode = value;
		this.SetDLSSGRetainResourcesWhenOff(this.DLSSGEnable);
		if (value == 0)
		{
			UStreamlineLibraryReflex.SetReflexMode(EStreamlineReflexMode.Off);
			Log.Instance.Info(ELogModule.Game, ELogAuthor.XSZ, "SetReflexMode 0", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		else
		{
			UStreamlineLibraryReflex.SetReflexMode(EStreamlineReflexMode.Boost);
			Log.Instance.Info(ELogModule.Game, ELogAuthor.XSZ, "SetReflexMode 3", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.ApplyUnlimitedFrameRate(this.DLSSGEnable);
		if (this.DLSSGDisalbeTemporaryKeys.Count == 0)
		{
			this.ApplyDLSSG(this.DLSSGMode);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Game;
		ELogAuthor author = ELogAuthor.XSZ;
		string message = "EnableDLSSG";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mode", this.DLSSGMode.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DisalbeTemporaryKeys", this.DLSSGDisalbeTemporaryKeys.Count.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x000F47F3 File Offset: 0x000F29F3
	public bool IsEnableDLSSG()
	{
		return this.DLSSGEnable;
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x000F47FC File Offset: 0x000F29FC
	private void SetDLSSGRetainResourcesWhenOff(bool enable)
	{
		int value = (enable > false) ? 1 : 0;
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
		defaultInterpolatedStringHandler.AppendLiteral("r.Streamline.DLSSG.RetainResourcesWhenOff ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Game;
		ELogAuthor author = ELogAuthor.XSZ;
		string message = "SetDLSSGRetainResourcesWhenOff";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Value", value.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x000F486C File Offset: 0x000F2A6C
	public unsafe void TemporaryDisableDLSSG(string key)
	{
		if (this.IsDlss3GpuDevice() && this.IsNvidiaStreamlinePluginLoaded())
		{
			this.DLSSGDisalbeTemporaryKeys[key] = 1;
			if (this.DLSSGDisalbeTemporaryKeys.Count > 0)
			{
				this.ApplyDLSSG(0);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XSZ;
			string message = "disable DLSSG temploary";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("num", this.DLSSGDisalbeTemporaryKeys.Count.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x000F4918 File Offset: 0x000F2B18
	public unsafe void CancelTemporaryDisableDLSSG(string key)
	{
		if (this.IsDlss3GpuDevice() && this.IsNvidiaStreamlinePluginLoaded())
		{
			this.DLSSGDisalbeTemporaryKeys.Remove(key);
			if (this.DLSSGDisalbeTemporaryKeys.Count == 0 && this.IsEnableDLSSG())
			{
				this.ApplyDLSSG(this.DLSSGMode);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XSZ;
			string message = "recover DLSSG";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("num", this.DLSSGDisalbeTemporaryKeys.Count.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x000F49CE File Offset: 0x000F2BCE
	public void EnableAFME(int value)
	{
		this.AFMEEnable = (value != 0);
		this.ApplyAFME();
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x000F49E0 File Offset: 0x000F2BE0
	public void ApplyAFME()
	{
		if (this.AFMEDisalbeTemporaryKeys.Count <= 0 && this.AFMEEnable)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FEstimation.Option 0", null);
			this.AFMERunning = true;
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FEstimation.Option 1", null);
			this.AFMERunning = false;
		}
		this.ApplyFrameRate(this.FrameRateInternal);
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x000F4A44 File Offset: 0x000F2C44
	public void ApplyKuroFITranslucentEnhance(bool bEnable)
	{
		int value = (bEnable > false) ? 1 : 0;
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted("r.KuroFI.TranslucentLightingMode");
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x000F4A94 File Offset: 0x000F2C94
	public void ApplyKuroFISingleOcclusionBloomReplace(bool bEnable)
	{
		int value = (bEnable > false) ? 1 : 0;
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted("r.KuroFI.EnableSingleOcclusionBloomReplace");
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x000F4AE4 File Offset: 0x000F2CE4
	public unsafe void TemporaryDisableAFME(string key)
	{
		if (this.IsSupportedAFME)
		{
			bool flag = this.AFMEDisalbeTemporaryKeys.Count == 0;
			this.AFMEDisalbeTemporaryKeys[key] = 1;
			if (flag)
			{
				this.ApplyAFME();
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.ZJF;
			string message = "disable AFME temploary";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("num", this.AFMEDisalbeTemporaryKeys.Count.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ApplyAFME", flag.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x000F4BA4 File Offset: 0x000F2DA4
	public unsafe void CancelTemporaryDisableAFME(string key)
	{
		if (this.IsSupportedAFME && this.AFMEDisalbeTemporaryKeys.Count > 0)
		{
			this.AFMEDisalbeTemporaryKeys.Remove(key);
			bool flag = this.AFMEDisalbeTemporaryKeys.Count == 0;
			if (flag)
			{
				this.ApplyAFME();
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.ZJF;
			string message = "recover AFME";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("num", this.AFMEDisalbeTemporaryKeys.Count.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ApplyAFME", flag.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x000F4C78 File Offset: 0x000F2E78
	public void TemporaryDisableFrameGeneration(string key)
	{
		if (this.IsSupportedAFME)
		{
			this.TemporaryDisableAFME(key);
		}
		if (this.IsDlss3GpuDevice() && this.IsNvidiaStreamlinePluginLoaded())
		{
			this.TemporaryDisableDLSSG(key);
		}
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.UIView, false, key);
		}
		if (this.IsXess2Supported())
		{
			this.TemporaryDisableXefg(key);
		}
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000F4CCC File Offset: 0x000F2ECC
	public void EnableXeSS(bool value)
	{
		if (value)
		{
			this.XessEnabled++;
		}
		else
		{
			this.XessEnabled--;
		}
		if (this.XessEnabled > 0)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.XeSS.Enabled 1", null);
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.XeSS.Enabled 0", null);
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x000F4D24 File Offset: 0x000F2F24
	public void ApplyXefg(int mode)
	{
		bool flag = this.XessEnabled > 0 && mode > 0;
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
		defaultInterpolatedStringHandler.AppendLiteral("r.XeFG.MaxInterpolatedFrames ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(mode);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		if (flag)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.XeFG.Enabled 1", null);
		}
		else
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.XeFG.Enabled 0", null);
		}
		this.ApplyUnlimitedFrameRate(flag);
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x000F4D9E File Offset: 0x000F2F9E
	public void EnableXefg(int mode)
	{
		this.XefgMode = mode;
		if (this.XefgDisableTemporaryKeys.Count == 0)
		{
			this.ApplyXefg(mode);
		}
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x000F4DBC File Offset: 0x000F2FBC
	public unsafe void TemporaryDisableXefg(string key)
	{
		if (this.IsXess2Supported())
		{
			if (this.XefgDisableTemporaryKeys.Count == 0)
			{
				this.ApplyXefg(0);
			}
			this.XefgDisableTemporaryKeys[key] = this.XefgMode;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XSZ;
			string message = "disable Xefg temporary";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("num", this.XefgDisableTemporaryKeys.Count.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000F4E60 File Offset: 0x000F3060
	public unsafe void CancelTemporaryDisableXefg(string key)
	{
		if (!this.XefgDisableTemporaryKeys.ContainsKey(key) && key != "CursorVisialbe")
		{
			return;
		}
		if (this.IsXess2Supported())
		{
			this.XefgDisableTemporaryKeys.Remove(key);
			if (this.XefgDisableTemporaryKeys.Count == 0)
			{
				this.ApplyXefg(this.XefgMode);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XSZ;
			string message = "enable Xefg temporary";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", this.XefgMode.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("num", this.XefgDisableTemporaryKeys.Count.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x000F4F44 File Offset: 0x000F3144
	public void CancelTemporaryDisableFrameGeneration(string key)
	{
		if (this.IsSupportedAFME)
		{
			this.CancelTemporaryDisableAFME(key);
		}
		if (this.IsDlss3GpuDevice() && this.IsNvidiaStreamlinePluginLoaded())
		{
			this.CancelTemporaryDisableDLSSG(key);
		}
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.UIView, true, key);
		}
		if (this.IsXess2Supported())
		{
			this.CancelTemporaryDisableXefg(key);
		}
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x000F4F98 File Offset: 0x000F3198
	private EFFXFIApplyMode? GetFFXFIActiveTemporaryMode()
	{
		EFFXFIApplyMode? result = null;
		foreach (EFFXFIApplyMode effxfiapplyMode in this.FFXFIDisableTemporaryReasons.Values)
		{
			if (result == null || effxfiapplyMode < result.Value)
			{
				result = new EFFXFIApplyMode?(effxfiapplyMode);
			}
		}
		return result;
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x000F500C File Offset: 0x000F320C
	public void ToggleFFXFIStateTemporarily(EFFXFIApplyMode applyMode, bool bRecover, string key)
	{
		if (!this.IsFFXFISupported())
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)applyMode);
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(key);
		string key2 = defaultInterpolatedStringHandler.ToStringAndClear();
		EFFXFIApplyMode? ffxfiactiveTemporaryMode = this.GetFFXFIActiveTemporaryMode();
		if (bRecover)
		{
			if (!this.FFXFIDisableTemporaryReasons.Remove(key2))
			{
				return;
			}
		}
		else
		{
			this.FFXFIDisableTemporaryReasons[key2] = applyMode;
		}
		EFFXFIApplyMode? ffxfiactiveTemporaryMode2 = this.GetFFXFIActiveTemporaryMode();
		int fsr3FgSwitchState = GameSettingsUtils.GetFsr3FgSwitchState(EFFXFIApplyMode.Default);
		if (ffxfiactiveTemporaryMode2 == null)
		{
			GameSettingsUtils.LeaveTemporaryFFXFIApplyState();
			GameSettingsUtils.ApplyFsr3Fg((fsr3FgSwitchState != 0) ? 1 : 0, EFFXFIApplyMode.Default);
			return;
		}
		GameSettingsUtils.EnterTemporaryFFXFIApplyState();
		EFFXFIApplyMode? effxfiapplyMode = ffxfiactiveTemporaryMode;
		EFFXFIApplyMode? effxfiapplyMode2 = ffxfiactiveTemporaryMode2;
		if (!(effxfiapplyMode.GetValueOrDefault() == effxfiapplyMode2.GetValueOrDefault() & effxfiapplyMode != null == (effxfiapplyMode2 != null)))
		{
			GameSettingsUtils.ApplyFsr3Fg(0, ffxfiactiveTemporaryMode2.Value);
		}
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x000F50D9 File Offset: 0x000F32D9
	public void TempDisableFFXFIWhenLoading()
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.Loading, false, "Loading");
		}
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x000F50F0 File Offset: 0x000F32F0
	public void RecoverFFXFITempStateWhenLoading()
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.Loading, true, "Loading");
		}
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x000F5107 File Offset: 0x000F3307
	public void TempDisableFFXFIWhenSeqC(PlotInfo plotInfo)
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.SeqC, false, "PlotNetwork");
		}
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x000F511E File Offset: 0x000F331E
	public void RecoverFFXFITempStateFromSeqC(PlotResultInfo plotResultInfo)
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.SeqC, true, "PlotNetwork");
		}
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000F5138 File Offset: 0x000F3338
	public void ApplyFrameRate(int value)
	{
		int num = 0;
		int num2 = 0;
		if (value > 0)
		{
			int min = 24;
			int max = 120;
			this.FrameRateInternal = MathUtils.Instance.Clamp(value, min, max);
			this.FrameSecondsInternal = 1f / (float)this.FrameRateInternal;
			num = this.FrameRateInternal;
			if (this.FrameRateTemploary > 0)
			{
				num = this.FrameRateTemploary;
			}
			num2 = num;
			if (Info.Instance.IsMobilePlatform())
			{
				if (this.AFMERunning)
				{
					num *= 2;
				}
				TArray<int> supportedRefreshRates = UKuroRenderingRuntimeBPPluginBPLibrary.GetSupportedRefreshRates();
				List<int> list = new List<int>();
				for (int i = 0; i < supportedRefreshRates.Num(); i++)
				{
					list.Add(supportedRefreshRates.Get(i));
				}
				list.Sort((int a, int b) => a - b);
				int? num3 = null;
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j] >= num)
					{
						num3 = new int?(list[j]);
						break;
					}
				}
				num = ((num3 != null) ? num3.Value : list[list.Count - 1]);
				if (this.AFMERunning && num > 0)
				{
					num2 = Math.Min(num2, num / 2);
				}
			}
		}
		if (this.IsBrokenGLPacingDevice)
		{
			num = 60;
			if (Info.Instance.IsMobilePlatform() && this.AFMERunning)
			{
				num2 = 30;
			}
		}
		if (Info.Instance.IsAndroidPlatform() && this.AFMERunning && this.IsEnergySavingFrameInterpolationSupported())
		{
			num = 60;
			num2 = 30;
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "节能插帧-锁定帧数为30", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		gameUserSettings.SetFrameRateLimit((float)num2);
		if (Info.Instance.IsAndroidPlatform() || Info.Instance.IsOpenHarmonyPlatform())
		{
			gameUserSettings.SetFramePace(num);
		}
		gameUserSettings.ApplySettings(true);
		if (PerfSightController.IsEnable)
		{
			UPerfSightHelper.PostEvent(801, value.ToString());
		}
		EventSystem.Instance.Emit<int>(EEventName.SettingFrameRateChanged, num);
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000F5342 File Offset: 0x000F3542
	public int FrameRate
	{
		get
		{
			return this.FrameRateInternal;
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000F534A File Offset: 0x000F354A
	public float FrameSeconds
	{
		get
		{
			return this.FrameSecondsInternal;
		}
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000F5354 File Offset: 0x000F3554
	public void ApplyUnlimitedFrameRate(bool value)
	{
		if (value)
		{
			this.ApplyFrameRate(0);
		}
		else
		{
			this.ApplyFrameRate(this.FrameRateInternal);
		}
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.PCVSYNC, 0, false) == 1)
		{
			gameUserSettings.SetVSyncEnabled(!value);
			gameUserSettings.ApplySettings(true);
		}
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x000F53A4 File Offset: 0x000F35A4
	public int GetMaxRoleShadowNum()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x000F53D4 File Offset: 0x000F35D4
	public int GetMaxRoleShadowDistance()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x000F5404 File Offset: 0x000F3604
	public int GetMaxDecalShadowDistance()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x000F5434 File Offset: 0x000F3634
	public int IsMainPlayerUseRealRoleShadow()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		return GameSettingsDeviceRenderDefine.MainPlayerRealShadow[gameQualitySettingLevel];
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x000F544F File Offset: 0x000F364F
	public void SetFrameRateTemploary(int frameRate)
	{
		this.FrameRateTemploary = MathUtils.Instance.Clamp(frameRate, 24, 120);
		this.FrameSecondsInternal = 1f / (float)this.FrameRateTemploary;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x000F547C File Offset: 0x000F367C
	public void SetSequenceFrameRateLimit()
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			if (this.FrameRateInternal > 31)
			{
				this.SetFrameRateTemploary(30);
				this.ApplyFrameRate(this.FrameRateInternal);
			}
		}
		else if (Info.Instance.PlatformType == ESourcePlatformType.Android)
		{
			if (this.FrameRateInternal > 31)
			{
				this.SetFrameRateTemploary(30);
				this.ApplyFrameRate(this.FrameRateInternal);
			}
		}
		else if (Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony && this.FrameRateInternal > 31)
		{
			this.SetFrameRateTemploary(30);
			this.ApplyFrameRate(this.FrameRateInternal);
		}
		if (Info.Instance.IsMobilePlatform())
		{
			this.TryReduceCsmUpdateFrequency("Plot");
		}
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000F5528 File Offset: 0x000F3728
	public void CancleSequenceFrameRateLimit()
	{
		this.CancelFrameRateTemploary();
		this.ApplyFrameRate(this.FrameRateInternal);
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS || Info.Instance.PlatformType == ESourcePlatformType.Android || Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony)
		{
			this.TryRestoreCsmUpdateFrequency("Plot");
		}
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x000F557A File Offset: 0x000F377A
	public void CancelFrameRateTemploary()
	{
		this.FrameRateTemploary = 0;
		this.FrameSecondsInternal = 1f / (float)this.FrameRateInternal;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x000F5596 File Offset: 0x000F3796
	public void TryReduceCsmUpdateFrequency(string reason)
	{
		bool count = this.ReduceCsmReasonSet.Count != 0;
		this.ReduceCsmReasonSet.Add(reason);
		if (!count && this.ReduceCsmReasonSet.Count == 1)
		{
			this.ReduceCsmUpdateFrequency();
		}
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x000F55C6 File Offset: 0x000F37C6
	public void TryRestoreCsmUpdateFrequency(string reason)
	{
		if (this.ReduceCsmReasonSet.Remove(reason) && this.ReduceCsmReasonSet.Count == 0)
		{
			this.RestoreCsmUpdateFrequency();
		}
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000F55E9 File Offset: 0x000F37E9
	private void RestoreCsmUpdateFrequency()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CSMMode3EnableUpdateIntervalOverride 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.IOSCompilationTimeLimit 2.0", null);
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x000F560B File Offset: 0x000F380B
	private void ReduceCsmUpdateFrequency()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CSMMode3EnableUpdateIntervalOverride 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheMode3CacheUpdateIntervalsOverride \"3000,3000,3000,3000,3000,3000\"", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.IOSCompilationTimeLimit 0.1", null);
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x000F5640 File Offset: 0x000F3840
	public void RefreshPerformanceLimit(string reason)
	{
		int num = 0;
		int num2 = 0;
		foreach (KeyValuePair<string, IPerformanceLimitConfig> keyValuePair in this.PerformanceLimitRunning)
		{
			if (keyValuePair.Value.FrameLimit)
			{
				num++;
			}
			if (keyValuePair.Value.CacheWorldFrame)
			{
				num2++;
			}
		}
		if (!Info.Instance.IsPcOrGamepadPlatform())
		{
			if (num > 0)
			{
				this.SetFrameRateTemploary(30);
				this.ApplyFrameRate(this.FrameRateInternal);
			}
			else
			{
				this.CancelFrameRateTemploary();
				this.ApplyFrameRate(this.FrameRateInternal);
			}
		}
		if (num2 > 0 && this.InCacheSceneColorMode == 0)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.CacheSceneColor.Start", null);
			this.InCacheSceneColorMode = 1;
			return;
		}
		if (num2 == 0 && this.InCacheSceneColorMode == 1)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.CacheSceneColor.Stop", null);
			this.InCacheSceneColorMode = 0;
		}
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x000F5734 File Offset: 0x000F3934
	public void ApplyPerformanceLimit(string tag, bool cacheWorldFrame, bool frameLimit)
	{
		this.PerformanceLimitRunning[tag] = new PerformanceLimitConfig
		{
			FrameLimit = frameLimit,
			CacheWorldFrame = cacheWorldFrame
		};
		this.RefreshPerformanceLimit(tag);
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000F575C File Offset: 0x000F395C
	public void CancelPerformanceLimit(string tag)
	{
		if (!this.PerformanceLimitRunning.Remove(tag))
		{
			return;
		}
		this.RefreshPerformanceLimit(tag);
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000F5774 File Offset: 0x000F3974
	public void CancelAllPerformanceLimit()
	{
		this.PerformanceLimitRunning.Clear();
		this.CancelFrameRateTemploary();
		this.ApplyFrameRate(this.FrameRateInternal);
		this.RefreshPerformanceLimit("[CancelAll]");
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000F579E File Offset: 0x000F399E
	public void SetIsAutoAdjustImageQuality(bool isAutoAdjustImageQuality)
	{
		if (isAutoAdjustImageQuality)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoCoolUIEnable 1", null);
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoCoolUIEnable 0", null);
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x000F57C4 File Offset: 0x000F39C4
	public EGameQualitySettingLevel? GetRecommendQualityLv()
	{
		int? recommendQualityLv = this.RecommendQualityLv;
		EGameQualitySettingLevel? result = (recommendQualityLv != null) ? new EGameQualitySettingLevel?((EGameQualitySettingLevel)recommendQualityLv.GetValueOrDefault()) : null;
		if (result == null)
		{
			return null;
		}
		if (this.RecommendQualityDeviceCap != null && result.Value > this.RecommendQualityDeviceCap.Value)
		{
			result = new EGameQualitySettingLevel?(this.RecommendQualityDeviceCap.Value);
		}
		EGameQualitySettingLevel? maxQualityLevelByResourceTier = GameSettingsManager.Instance.GetMaxQualityLevelByResourceTier();
		if (maxQualityLevelByResourceTier != null && result.Value > maxQualityLevelByResourceTier.Value)
		{
			result = new EGameQualitySettingLevel?(maxQualityLevelByResourceTier.Value);
		}
		return result;
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x000F5872 File Offset: 0x000F3A72
	public EGameQualityRange GetQualityRange()
	{
		return this.QualityRange;
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000F587C File Offset: 0x000F3A7C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetCPUInformation()
	{
		string text = this.CPUBrand.ToLower();
		bool flag = true;
		if (text.Contains("intel"))
		{
			Match match = Regex.Match(this.CPUBrand, "i([0-9])-([0-9]{4,5})", RegexOptions.IgnoreCase);
			if (match.Success && match.Groups.Count >= 3)
			{
				int num = int.Parse(match.Groups[1].Value);
				string value = match.Groups[2].Value;
				int num2;
				if (value.Length == 4)
				{
					num2 = int.Parse(value[0].ToString());
				}
				else
				{
					num2 = int.Parse(value.Substring(0, 2));
				}
				if (num < 5 || num2 < 9)
				{
					flag = false;
				}
			}
		}
		else if (text.Contains("amd"))
		{
			Match match2 = Regex.Match(this.CPUBrand, "ryzen\\s+[3579]\\s+([0-9]{4})", RegexOptions.IgnoreCase);
			if (match2.Success && match2.Groups.Count >= 2 && int.Parse(match2.Groups[1].Value) < 2700)
			{
				flag = false;
			}
		}
		return new ValueTuple<string, bool>(this.CPUBrand, !flag);
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x000F59A8 File Offset: 0x000F3BA8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetGPUInformation()
	{
		string text = this.DeviceName.ToLower();
		bool flag = true;
		if (text.Contains("nvidia") || text.Contains("geforce"))
		{
			Match match = Regex.Match(this.DeviceName, "gtx\\s*(\\d{3,4})", RegexOptions.IgnoreCase);
			if (match.Success && match.Groups.Count >= 2 && int.Parse(match.Groups[1].Value) < 1060)
			{
				flag = false;
			}
		}
		else if (text.Contains("amd") || text.Contains("radeon"))
		{
			Match match2 = Regex.Match(this.DeviceName, "rx\\s*(\\d{3,4})", RegexOptions.IgnoreCase);
			if (match2.Success && match2.Groups.Count >= 2 && int.Parse(match2.Groups[1].Value) < 570)
			{
				flag = false;
			}
		}
		if (this.DeviceType == EGameDeviceType.PC_LOWEST)
		{
			flag = false;
		}
		return new ValueTuple<string, bool>(this.DeviceName, !flag);
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x000F5AA8 File Offset: 0x000F3CA8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetGraphicDriverVersion()
	{
		bool item = this.IsDriverNeedUpdate();
		return new ValueTuple<string, bool>(this.AdapterDriverVersion, item);
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x000F5AC8 File Offset: 0x000F3CC8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetGraphicAPI()
	{
		string item = this.RHIName;
		if (this.RHIName == "D3D11")
		{
			item = "DX11";
		}
		else if (this.RHIName == "D3D12")
		{
			item = "DX12";
		}
		bool flag = UKismetSystemLibrary.GetCommandLine().Contains("-dx11");
		bool item2 = this.RHIName == "D3D11" && !flag;
		return new ValueTuple<string, bool>(item, item2);
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000F5B40 File Offset: 0x000F3D40
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetMemoryInformation()
	{
		int num = (int)Math.Ceiling((double)this.DevicePhysicalGbRam / 4.0) * 4;
		bool flag = num >= 16;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("GB");
		return new ValueTuple<string, bool>(defaultInterpolatedStringHandler.ToStringAndClear(), !flag);
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x000F5BA0 File Offset: 0x000F3DA0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetVideoMemoryInformation()
	{
		if (this.DeviceVideoGbRam > 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DeviceVideoGbRam);
			defaultInterpolatedStringHandler.AppendLiteral("GB");
			return new ValueTuple<string, bool>(defaultInterpolatedStringHandler.ToStringAndClear(), false);
		}
		return new ValueTuple<string, bool>("", false);
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000F5BF4 File Offset: 0x000F3DF4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetGameInstallPath()
	{
		string text = this.IsSSDDevice ? ConfigMultiTextLang.GetLocalTextNew("DeviceInfo_InstallPath_SSD", null) : ConfigMultiTextLang.GetLocalTextNew("DeviceInfo_InstallPath_HDD", null);
		return new ValueTuple<string, bool>(text ?? "", string.IsNullOrEmpty(text));
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000F5C37 File Offset: 0x000F3E37
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetWindowsVersion()
	{
		return new ValueTuple<string, bool>(this.WindowsVersion, false);
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000F5C48 File Offset: 0x000F3E48
	public bool ShouldOverrideVegetationDitherDefaultValue()
	{
		return !(this.VendorName.ToLower() != "intel") && (this.DeviceName.Contains("A580") || this.DeviceName.Contains("A750") || this.DeviceName.Contains("A770"));
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x000F5CA4 File Offset: 0x000F3EA4
	public bool IsAutoExposureOn()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.AutoExposure") == 1;
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x000F5CB3 File Offset: 0x000F3EB3
	public bool IsEnergySavingFrameInterpolationSupported()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Mobile.EnergySavingFrameInterpolation") == 1;
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x000F5CC4 File Offset: 0x000F3EC4
	public void TemporarySetIntCVar(string Name, int Value)
	{
		if (!this.TemporaryIntCVars.ContainsKey(Name))
		{
			this.TemporaryIntCVars[Name] = UKismetSystemLibrary.GetConsoleVariableIntValue(Name);
		}
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
	}

	// Token: 0x060027D6 RID: 10198 RVA: 0x000F5D28 File Offset: 0x000F3F28
	public void TemporaryResetIntCVar(string Name)
	{
		if (this.TemporaryIntCVars.ContainsKey(Name))
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(Name);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TemporaryIntCVars[Name]);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			this.TemporaryIntCVars.Remove(Name);
		}
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000F5D92 File Offset: 0x000F3F92
	public static GameSettingsDeviceRender Instance
	{
		get
		{
			if (GameSettingsDeviceRender._instance == null)
			{
				GameSettingsDeviceRender._instance = new GameSettingsDeviceRender();
				GameSettingsDeviceRender._instance.OnInit();
			}
			return GameSettingsDeviceRender._instance;
		}
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x000F5DB5 File Offset: 0x000F3FB5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060027D9 RID: 10201 RVA: 0x000F5DB7 File Offset: 0x000F3FB7
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDeviceRender instance = GameSettingsDeviceRender._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsDeviceRender._instance = null;
	}

	// Token: 0x060027DA RID: 10202 RVA: 0x000F5DD0 File Offset: 0x000F3FD0
	static GameSettingsDeviceRender()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDeviceRender.CreateStaticDefaultValue), new Action(GameSettingsDeviceRender.ResetStaticDefaultValue));
	}

	// Token: 0x040026C0 RID: 9920
	private const string KuroFITranslucentLightingModeCVar = "r.KuroFI.TranslucentLightingMode";

	// Token: 0x040026C1 RID: 9921
	private const string KuroFIEnableSingleOcclusionBloomReplaceCVar = "r.KuroFI.EnableSingleOcclusionBloomReplace";

	// Token: 0x040026C2 RID: 9922
	[Nullable(2)]
	private Dictionary<int, DeviceRenderFeature> DeviceRenderFeatureCfgMapInternal;

	// Token: 0x040026C3 RID: 9923
	private int? RecommendQualityLvInternal;

	// Token: 0x040026C4 RID: 9924
	private int DevicePhysicalGbRam;

	// Token: 0x040026C5 RID: 9925
	public int DeviceVideoGbRam;

	// Token: 0x040026C6 RID: 9926
	public int CPUFrequency;

	// Token: 0x040026C7 RID: 9927
	public int CPUCores;

	// Token: 0x040026C8 RID: 9928
	public int CPUCoresIncludingHyperthreads;

	// Token: 0x040026C9 RID: 9929
	public string CPUBrand = "";

	// Token: 0x040026CA RID: 9930
	public bool IsSupportedAFME;

	// Token: 0x040026CB RID: 9931
	public string DriverDate = "Unknown";

	// Token: 0x040026CC RID: 9932
	public string DriverVersion = "Unknown";

	// Token: 0x040026CD RID: 9933
	public string AdapterDriverVersion = "Unknown";

	// Token: 0x040026CE RID: 9934
	public string WindowsVersion = "Unknown";

	// Token: 0x040026CF RID: 9935
	public bool IsSSDDevice;

	// Token: 0x040026D0 RID: 9936
	public bool IsAdreno;

	// Token: 0x040026D1 RID: 9937
	public bool IsXuanJie;

	// Token: 0x040026D2 RID: 9938
	private string MobileDeviceModel = "";

	// Token: 0x040026D3 RID: 9939
	private string MobileDeviceMake = "";

	// Token: 0x040026D4 RID: 9940
	private string VendorName = "";

	// Token: 0x040026D5 RID: 9941
	private string DeviceName = "";

	// Token: 0x040026D6 RID: 9942
	private string BaseProfileName = "";

	// Token: 0x040026D7 RID: 9943
	public int DeviceScore;

	// Token: 0x040026D8 RID: 9944
	public int LowMemoryDeviceMark;

	// Token: 0x040026D9 RID: 9945
	private bool IsBrokenGLPacingDevice;

	// Token: 0x040026DA RID: 9946
	private string RHIName = "";

	// Token: 0x040026DB RID: 9947
	private int HardwareLevel;

	// Token: 0x040026DC RID: 9948
	public EGameDeviceType DeviceType = EGameDeviceType.PC_HIGH;

	// Token: 0x040026DD RID: 9949
	private EGameQualityRange QualityRange = EGameQualityRange.One2Three;

	// Token: 0x040026DE RID: 9950
	private EGameQualitySettingLevel? RecommendQualityDeviceCap;

	// Token: 0x040026DF RID: 9951
	private bool EnableVolumeFog = true;

	// Token: 0x040026E0 RID: 9952
	private FIntPoint? DefaultResolution;

	// Token: 0x040026E1 RID: 9953
	private TArray<FIntPoint> ResolutionListRef;

	// Token: 0x040026E2 RID: 9954
	private int FrameRateTemploary;

	// Token: 0x040026E3 RID: 9955
	private int FrameRateInternal;

	// Token: 0x040026E4 RID: 9956
	private bool DLSSGEnable;

	// Token: 0x040026E5 RID: 9957
	private int DLSSGMode;

	// Token: 0x040026E6 RID: 9958
	private bool AFMEEnable;

	// Token: 0x040026E7 RID: 9959
	private bool AFMERunning;

	// Token: 0x040026E8 RID: 9960
	[Nullable(2)]
	private string ProfileNameCache;

	// Token: 0x040026E9 RID: 9961
	private float FrameSecondsInternal;

	// Token: 0x040026EA RID: 9962
	private readonly HashSet<string> ReduceCsmReasonSet = new HashSet<string>();

	// Token: 0x040026EB RID: 9963
	private int XessEnabled;

	// Token: 0x040026EC RID: 9964
	private int XefgMode;

	// Token: 0x040026ED RID: 9965
	private readonly Dictionary<string, int> XefgDisableTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x040026EE RID: 9966
	public Dictionary<string, IPerformanceLimitConfig> PerformanceLimitRunning = new Dictionary<string, IPerformanceLimitConfig>();

	// Token: 0x040026EF RID: 9967
	public int InCacheSceneColorMode;

	// Token: 0x040026F0 RID: 9968
	private readonly Dictionary<EFunction, int> renderFeatureValueBuffer = new Dictionary<EFunction, int>();

	// Token: 0x040026F1 RID: 9969
	[Nullable(2)]
	private List<DeviceRenderFeature> RenderDistanceFeatures;

	// Token: 0x040026F2 RID: 9970
	private EGameDeviceType? RenderDistanceDeviceType;

	// Token: 0x040026F3 RID: 9971
	private EGameDeviceType? RenderDistanceTestDeviceId;

	// Token: 0x040026F4 RID: 9972
	private const int RenderDistanceExtensionPositionCount = 2;

	// Token: 0x040026F5 RID: 9973
	private bool? IsSteamDeckInternal;

	// Token: 0x040026F6 RID: 9974
	private readonly Dictionary<string, int> DLSSGDisalbeTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x040026F7 RID: 9975
	private readonly Dictionary<string, int> AFMEDisalbeTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x040026F8 RID: 9976
	private readonly Dictionary<string, EFFXFIApplyMode> FFXFIDisableTemporaryReasons = new Dictionary<string, EFFXFIApplyMode>();

	// Token: 0x040026F9 RID: 9977
	private Dictionary<string, int> TemporaryIntCVars = new Dictionary<string, int>();

	// Token: 0x040026FA RID: 9978
	[Nullable(2)]
	private static GameSettingsDeviceRender _instance;
}
