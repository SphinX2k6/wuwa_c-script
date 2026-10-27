using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02000DD3 RID: 3539
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDeviceRender : Singleton
{
	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x060053B8 RID: 21432 RVA: 0x000EA61C File Offset: 0x000E881C
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

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x060053B9 RID: 21433 RVA: 0x000EA6DC File Offset: 0x000E88DC
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

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x060053BA RID: 21434 RVA: 0x000EA7AC File Offset: 0x000E89AC
	public EGameQualitySettingLevel GameQualitySettingLevel
	{
		get
		{
			return (EGameQualitySettingLevel)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.IMAGEQUALITY, 2, true);
		}
	}

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x060053BB RID: 21435 RVA: 0x000EA7BC File Offset: 0x000E89BC
	public int PhysicalGBRam
	{
		get
		{
			return this.DevicePhysicalGbRam;
		}
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x060053BC RID: 21436 RVA: 0x000EA7C4 File Offset: 0x000E89C4
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

	// Token: 0x060053BD RID: 21437 RVA: 0x000EA7E7 File Offset: 0x000E89E7
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

	// Token: 0x060053BE RID: 21438 RVA: 0x000EA818 File Offset: 0x000E8A18
	public bool IsTargetBaseProfile(string keyword, bool fullMatch)
	{
		if (fullMatch)
		{
			return keyword == this.BaseProfileName;
		}
		return this.BaseProfileName.Contains(keyword);
	}

	// Token: 0x060053BF RID: 21439 RVA: 0x000EA838 File Offset: 0x000E8A38
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

	// Token: 0x060053C0 RID: 21440 RVA: 0x000EB052 File Offset: 0x000E9252
	public void Initialize()
	{
		EventSystem.Instance.Emit(EEventName.AfterGameQualitySettingsManagerInitialize);
	}

	// Token: 0x060053C1 RID: 21441 RVA: 0x000EB064 File Offset: 0x000E9264
	public void Clear()
	{
		this.CancelAllPerformanceLimit();
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x000EB06C File Offset: 0x000E926C
	public bool IsDriverNeedUpdate()
	{
		string pattern = "(\\d{1,2})-(\\d{1,2})-(\\d{4})";
		Match match = Regex.Match(this.DriverDate, pattern);
		return (match.Success && int.Parse(match.Groups[3].Value) < 2023) || !UKuroRenderingRuntimeBPPluginBPLibrary.GetDriverValid();
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x000EB0BC File Offset: 0x000E92BC
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

	// Token: 0x060053C4 RID: 21444 RVA: 0x000EB158 File Offset: 0x000E9358
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

	// Token: 0x060053C5 RID: 21445 RVA: 0x000EB1F5 File Offset: 0x000E93F5
	public bool IsDxr1_1NotSupported()
	{
		return UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.NotSupportedDxr1_1;
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x000EB200 File Offset: 0x000E9400
	private void UpdateQualityRange()
	{
		EGameDeviceType deviceType = this.DeviceType;
		switch (deviceType)
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
			if (GameSettingsManager.Instance.IsPcHighestDevice())
			{
				this.QualityRange = EGameQualityRange.Three2Five;
				return;
			}
			this.QualityRange = EGameQualityRange.Two2Four;
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
			if (deviceType == EGameDeviceType.CLOUD_GAME)
			{
				this.QualityRange = EGameQualityRange.One;
				return;
			}
			if (deviceType == EGameDeviceType.XBox)
			{
				return;
			}
			break;
		}
		this.QualityRange = EGameQualityRange.Zero2Two;
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x000EB2F0 File Offset: 0x000E94F0
	public DeviceRenderFeature? GetDeviceRenderFeature(EGameQualitySettingLevel qualityLevel)
	{
		if (this.DeviceRenderFeatureCfgMap == null)
		{
			return null;
		}
		DeviceRenderFeature value;
		if (!this.DeviceRenderFeatureCfgMap.TryGetValue((int)qualityLevel, out value))
		{
			return null;
		}
		return new DeviceRenderFeature?(value);
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x000EB330 File Offset: 0x000E9530
	public DeviceRenderFeature? GetCurrentDeviceRenderFeature()
	{
		if (this.DeviceRenderFeatureCfgMap == null)
		{
			return null;
		}
		DeviceRenderFeature value;
		if (!this.DeviceRenderFeatureCfgMap.TryGetValue((int)this.GameQualitySettingLevel, out value))
		{
			return null;
		}
		return new DeviceRenderFeature?(value);
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x000EB374 File Offset: 0x000E9574
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

	// Token: 0x060053CA RID: 21450 RVA: 0x000EB3F8 File Offset: 0x000E95F8
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

	// Token: 0x060053CB RID: 21451 RVA: 0x000EB468 File Offset: 0x000E9668
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
		this.renderFeatureValueBuffer[EFunction.LOADINGRANGESCALELEVEL] = 0;
		return this.renderFeatureValueBuffer;
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x000EB5E6 File Offset: 0x000E97E6
	public bool IsIosAndAndroidHighDevice()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH || this.DeviceType == EGameDeviceType.IOS_MIDDLE || this.DeviceType == EGameDeviceType.IOS_HIGH || this.DeviceType == EGameDeviceType.IOS_VERY_HIGH;
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x000EB626 File Offset: 0x000E9826
	public bool IsAndroidPlatformNotLow()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOW || this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x000EB652 File Offset: 0x000E9852
	public bool IsAndroidPlatformScreenBetter()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x000EB674 File Offset: 0x000E9874
	public bool IsAndroidPlatformScreenBad()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOWEST || this.DeviceType == EGameDeviceType.ANDROID_LOW;
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x000EB68C File Offset: 0x000E988C
	public bool IsAndroidPlatformLowest()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOWEST;
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x000EB698 File Offset: 0x000E9898
	public bool IsAndroidPlatformLow()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_LOW;
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x000EB6A4 File Offset: 0x000E98A4
	public bool IsAndroidPlatformAOValid()
	{
		return Platform.Instance.IsAndroidPlatform() && !this.IsAndroidPlatformScreenBad();
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x000EB6BD File Offset: 0x000E98BD
	public bool IsIOSPlatformAOValid()
	{
		return Platform.Instance.IsIOSPlatform() && this.DeviceScore >= 230;
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x000EB6DD File Offset: 0x000E98DD
	public bool IsOpenHarmonyPlatformAOValid()
	{
		return Platform.Instance.IsOpenHarmonyPlatform() && !this.IsAndroidPlatformScreenBad();
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x000EB6F6 File Offset: 0x000E98F6
	public bool IsAndroidAdreno()
	{
		return this.IsAdreno;
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x000EB6FE File Offset: 0x000E98FE
	public bool IsRedMagic()
	{
		return Platform.Instance.IsRedMagicDevice();
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x000EB70A File Offset: 0x000E990A
	public bool IsRedMagicLow()
	{
		return Platform.Instance.IsRedMagicDeviceLow();
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x000EB716 File Offset: 0x000E9916
	public bool IsRedMagicHigh()
	{
		return Platform.Instance.IsRedMagicDeviceHigh();
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x000EB722 File Offset: 0x000E9922
	public bool IsLowMemoryDevice()
	{
		return (Info.Instance.PlatformType == ESourcePlatformType.IOS && this.DevicePhysicalGbRam < 4) || (Info.Instance.PlatformType == ESourcePlatformType.Android && this.DevicePhysicalGbRam <= 4);
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x000EB755 File Offset: 0x000E9955
	public int GetD3D12Type()
	{
		if (this.RHIName.Contains("D3D12"))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x000EB76C File Offset: 0x000E996C
	public int IsVulkanRHI()
	{
		if (this.RHIName.Contains("Vulkan"))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x000EB783 File Offset: 0x000E9983
	public bool IsQualcommGpu()
	{
		return this.DeviceName.Contains("Qualcomm(R) Adreno(TM)");
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x000EB798 File Offset: 0x000E9998
	public bool IsMaliNewSocOrXclipseOrPowerVR()
	{
		return this.DeviceName.Contains("G710") || this.DeviceName.Contains("G715") || this.DeviceName.Contains("G720") || this.DeviceName.Contains("G610") || this.DeviceName.Contains("G615") || this.DeviceName.Contains("G620") || this.DeviceName.Contains("Xclipse") || this.DeviceName.Contains("BXM-8-256");
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x000EB838 File Offset: 0x000E9A38
	public bool IsHuaweiAndroid()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.DeviceName.Contains("Maleoon") && Platform.Instance.IsAndroidPlatform();
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x000EB894 File Offset: 0x000E9A94
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

	// Token: 0x060053E0 RID: 21472 RVA: 0x000EB8EC File Offset: 0x000E9AEC
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

	// Token: 0x060053E1 RID: 21473 RVA: 0x000EB938 File Offset: 0x000E9B38
	public bool IsMaleoonSuperResolutionSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return (maleoonModel == "935" || maleoonModel == "935A" || maleoonModel == "955" || maleoonModel == "955A") && this.GetOpenHarmonyMajorVersion() >= 7;
	}

	// Token: 0x060053E2 RID: 21474 RVA: 0x000EB9A0 File Offset: 0x000E9BA0
	public bool IsMaleoonRayTracingNormalSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return maleoonModel == "935" || maleoonModel == "935A";
	}

	// Token: 0x060053E3 RID: 21475 RVA: 0x000EB9DC File Offset: 0x000E9BDC
	public bool IsMaleoonRayTracingSuperSupported()
	{
		if (!Platform.Instance.IsOpenHarmonyPlatform())
		{
			return false;
		}
		string maleoonModel = this.GetMaleoonModel();
		return maleoonModel == "955" || maleoonModel == "955A";
	}

	// Token: 0x060053E4 RID: 21476 RVA: 0x000EBA18 File Offset: 0x000E9C18
	public bool IsNvidiaGPU()
	{
		return this.VendorName == "NVIDIA";
	}

	// Token: 0x060053E5 RID: 21477 RVA: 0x000EBA2C File Offset: 0x000E9C2C
	public bool IsUltraGpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && this.DeviceName.Contains("RTX");
	}

	// Token: 0x060053E6 RID: 21478 RVA: 0x000EBA81 File Offset: 0x000E9C81
	public bool IsNvidia4060()
	{
		return this.IsNvidiaGPU() && this.DeviceName.Contains("4060");
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x000EBAA0 File Offset: 0x000E9CA0
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

	// Token: 0x060053E8 RID: 21480 RVA: 0x000EBAF5 File Offset: 0x000E9CF5
	public bool IsNvidiaLaptopGPU()
	{
		return this.IsNvidiaGPU() && this.DeviceName.Contains("Laptop");
	}

	// Token: 0x060053E9 RID: 21481 RVA: 0x000EBB14 File Offset: 0x000E9D14
	public bool Is120FrameGPU()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameQualitySettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return ((this.VendorName == "AMD" || this.IsNvidiaGPU() || this.VendorName == "Intel") && this.DeviceScore > 1300) || (this.VendorName == "Intel" && UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingSupportedType() == URayTracingSupport.Supported);
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x000EBBA4 File Offset: 0x000E9DA4
	public bool IsLaptopCPU_Old()
	{
		return this.CPUBrand.Contains("14900") || this.CPUBrand.Contains("14790") || this.CPUBrand.Contains("14700") || this.CPUBrand.Contains("14650") || this.CPUBrand.Contains("14600") || this.CPUBrand.Contains("14500") || this.CPUBrand.Contains("14490") || this.CPUBrand.Contains("14450") || this.CPUBrand.Contains("14400") || this.CPUBrand.Contains("13980") || this.CPUBrand.Contains("13950") || this.CPUBrand.Contains("13905") || this.CPUBrand.Contains("13900") || this.CPUBrand.Contains("13800") || this.CPUBrand.Contains("13790") || this.CPUBrand.Contains("13705") || this.CPUBrand.Contains("13700") || this.CPUBrand.Contains("13650") || this.CPUBrand.Contains("13620") || this.CPUBrand.Contains("13600") || this.CPUBrand.Contains("13500") || this.CPUBrand.Contains("13490") || this.CPUBrand.Contains("13450") || this.CPUBrand.Contains("13400") || this.CPUBrand.Contains("12950") || this.CPUBrand.Contains("12900") || this.CPUBrand.Contains("12850") || this.CPUBrand.Contains("12800") || this.CPUBrand.Contains("12700") || this.CPUBrand.Contains("12650") || this.CPUBrand.Contains("12600") || this.CPUBrand.Contains("12500") || this.CPUBrand.Contains("11980") || this.CPUBrand.Contains("11950") || this.CPUBrand.Contains("11900") || this.CPUBrand.Contains("11850") || this.CPUBrand.Contains("11800") || this.CPUBrand.Contains("11700") || this.CPUBrand.Contains("10980") || this.CPUBrand.Contains("10940") || this.CPUBrand.Contains("10920") || this.CPUBrand.Contains("10900") || this.CPUBrand.Contains("10885") || this.CPUBrand.Contains("10875") || this.CPUBrand.Contains("10870") || this.CPUBrand.Contains("10850") || this.CPUBrand.Contains("10700") || this.CPUBrand.Contains("9980") || this.CPUBrand.Contains("9940") || this.CPUBrand.Contains("9920") || this.CPUBrand.Contains("9900") || this.CPUBrand.Contains("9880") || this.CPUBrand.Contains("9820") || this.CPUBrand.Contains("9800") || this.CPUBrand.Contains("9-7900") || this.CPUBrand.Contains("7-7820") || this.CPUBrand.Contains("7-6900") || this.CPUBrand.Contains("9-185") || this.CPUBrand.Contains("7-165") || this.CPUBrand.Contains("7-155") || this.CPUBrand.Contains("5-135") || this.CPUBrand.Contains("5-125") || this.CPUBrand.Contains("9-3495") || this.CPUBrand.Contains("9-3475") || this.CPUBrand.Contains("7-3465") || this.CPUBrand.Contains("7-3455") || this.CPUBrand.Contains("7-3445") || this.CPUBrand.Contains("5-3435") || this.CPUBrand.Contains("5-3425") || this.CPUBrand.Contains("7-1270") || this.CPUBrand.Contains("7-1260") || this.CPUBrand.Contains("5-1250") || this.CPUBrand.Contains("5-1240") || this.CPUBrand.Contains("9700") || this.CPUBrand.Contains("9600") || this.CPUBrand.Contains("8945") || this.CPUBrand.Contains("8845") || this.CPUBrand.Contains("8840") || this.CPUBrand.Contains("8700") || this.CPUBrand.Contains("7980") || this.CPUBrand.Contains("7970") || this.CPUBrand.Contains("7960") || this.CPUBrand.Contains("7950") || this.CPUBrand.Contains("7945") || this.CPUBrand.Contains("7940") || this.CPUBrand.Contains("7900") || this.CPUBrand.Contains("7845") || this.CPUBrand.Contains("7840") || this.CPUBrand.Contains("7800") || this.CPUBrand.Contains("7745") || this.CPUBrand.Contains("7735") || this.CPUBrand.Contains("7700") || this.CPUBrand.Contains("6980") || this.CPUBrand.Contains("6900") || this.CPUBrand.Contains("6800") || this.CPUBrand.Contains("5980") || this.CPUBrand.Contains("5975") || this.CPUBrand.Contains("5965") || this.CPUBrand.Contains("5955") || this.CPUBrand.Contains("5950") || this.CPUBrand.Contains("5945") || this.CPUBrand.Contains("5900") || this.CPUBrand.Contains("5800") || this.CPUBrand.Contains("5700") || this.CPUBrand.Contains("4900") || this.CPUBrand.Contains("4800") || this.CPUBrand.Contains("4700") || this.CPUBrand.Contains("3975") || this.CPUBrand.Contains("3970") || this.CPUBrand.Contains("3960") || this.CPUBrand.Contains("3955") || this.CPUBrand.Contains("3950") || this.CPUBrand.Contains("3945") || this.CPUBrand.Contains("3900") || this.CPUBrand.Contains("3800") || this.CPUBrand.Contains("3700") || this.CPUBrand.Contains("2950") || this.CPUBrand.Contains("2920") || this.CPUBrand.Contains("2700") || this.CPUBrand.Contains("1950") || this.CPUBrand.Contains("1920") || this.CPUBrand.Contains("1900") || this.CPUBrand.Contains("1800") || this.CPUBrand.Contains("1700") || this.CPUBrand.Contains("Intel(R) Core(TM) i5-11600K") || this.CPUBrand.Contains("Intel(R) Core(TM) i5-12490F") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 9 28") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 9 27") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 7 26") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 7 25") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 5 24") || this.CPUBrand.Contains("Intel(R) Core(TM) Ultra 5 23") || this.CPUBrand.Contains("AMD Ryzen 5 9") || this.CPUBrand.Contains("AMD Ryzen 7 9") || this.CPUBrand.Contains("AMD Ryzen 9 9") || this.CPUBrand.Contains("AMD Ryzen 5 8600") || this.CPUBrand.Contains("AMD Ryzen 7 7435H");
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x000EC6D8 File Offset: 0x000EA8D8
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

	// Token: 0x060053EC RID: 21484 RVA: 0x000EC774 File Offset: 0x000EA974
	private bool IsFrameRate120IOSDevice()
	{
		return Info.Instance.PlatformType == ESourcePlatformType.IOS && this.DeviceScore > 500;
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x000EC792 File Offset: 0x000EA992
	private bool IsFrameRate120MacDevice()
	{
		return Info.Instance.PlatformType == ESourcePlatformType.Mac && this.DeviceScore > 500;
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x000EC7B0 File Offset: 0x000EA9B0
	private bool IsAMDX3DCPU()
	{
		return this.CPUBrand.Contains("AMD") && this.CPUBrand.Contains("X3D");
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x000EC7D8 File Offset: 0x000EA9D8
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

	// Token: 0x060053F0 RID: 21488 RVA: 0x000EC8ED File Offset: 0x000EAAED
	public bool IsFrameRate120DeviceForAllDevice()
	{
		return (Info.Instance.IsPcOrGamepadPlatform() && this.IsFrameRate120Device()) || (Info.Instance.IsIosPlatform() && this.IsFrameRate120IOSDevice()) || (Info.Instance.IsMacPlatform() && this.IsFrameRate120MacDevice());
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x000EC92D File Offset: 0x000EAB2D
	public bool IsAndroidHighestResolutionDevice()
	{
		return this.DeviceScore >= 280;
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x000EC93F File Offset: 0x000EAB3F
	public bool IsAndroidHighResolutionDevice()
	{
		return this.DeviceType == EGameDeviceType.ANDROID_MIDDLE || this.DeviceType == EGameDeviceType.ANDROID_HIGH || this.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH;
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x000EC961 File Offset: 0x000EAB61
	public bool IsMetalFxDevice()
	{
		return UKuroRenderingRuntimeBPPluginBPLibrary.IsSupportsMetalFx();
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x000EC968 File Offset: 0x000EAB68
	public bool IsPWSDKDevice()
	{
		return false;
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x000EC96B File Offset: 0x000EAB6B
	public bool IsIRXActive()
	{
		return false;
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x000EC96E File Offset: 0x000EAB6E
	public void TurnOffIRX()
	{
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x000EC970 File Offset: 0x000EAB70
	public void TurnOnIRX()
	{
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x000EC972 File Offset: 0x000EAB72
	public bool IsNvidiaDlessPluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.Enable") == 1;
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x000EC981 File Offset: 0x000EAB81
	public bool IsNvidiaStreamlinePluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableBoolValue("r.Streamline.HasLoaded");
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x000EC98D File Offset: 0x000EAB8D
	public bool IsNvidiaDlssPluginLoaded()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.Enable") == 1;
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x000EC99C File Offset: 0x000EAB9C
	public bool IsDlssGpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && this.DeviceName.Contains("RTX");
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x000EC9F4 File Offset: 0x000EABF4
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

	// Token: 0x060053FD RID: 21501 RVA: 0x000ECA5C File Offset: 0x000EAC5C
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

	// Token: 0x060053FE RID: 21502 RVA: 0x000ECAC4 File Offset: 0x000EACC4
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

	// Token: 0x060053FF RID: 21503 RVA: 0x000ECEA0 File Offset: 0x000EB0A0
	public bool IsRTX50()
	{
		int? rtxseriesNumber = this.GetRTXSeriesNumber(this.DeviceName);
		return rtxseriesNumber != null && rtxseriesNumber.Value > 5000;
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x000ECED4 File Offset: 0x000EB0D4
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

	// Token: 0x06005401 RID: 21505 RVA: 0x000ECF30 File Offset: 0x000EB130
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

	// Token: 0x06005402 RID: 21506 RVA: 0x000ECF9E File Offset: 0x000EB19E
	public bool IsDlssSupported()
	{
		return this.IsNvidiaDlssPluginLoaded() && UDLSSLibrary.IsDLSSSupported();
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x000ECFB0 File Offset: 0x000EB1B0
	public bool IsDlss3GpuDevice()
	{
		if (string.IsNullOrEmpty(this.VendorName))
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.ZJF, "GameSettingsManager尚未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return this.IsNvidiaGPU() && (this.DeviceName.Contains("RTX 40") || this.DeviceName.Contains("RTX 50"));
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x000ED018 File Offset: 0x000EB218
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

	// Token: 0x06005405 RID: 21509 RVA: 0x000ED082 File Offset: 0x000EB282
	public bool IsXess2Supported()
	{
		return UXeSSBlueprintLibrary.IsXeSSSupported();
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x000ED089 File Offset: 0x000EB289
	public bool IsXeFGSupported()
	{
		return UXeFGBlueprintLibrary.IsXeFGSupported();
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x000ED090 File Offset: 0x000EB290
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

	// Token: 0x06005408 RID: 21512 RVA: 0x000ED126 File Offset: 0x000EB326
	public bool IsFsr3Supported()
	{
		return !this.IsSteamDeck() && UKuroFFXFSR3BlueprintLibrary.IsSupported() && UKuroFFXFSR3BlueprintLibrary.SupportFSR3();
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x000ED140 File Offset: 0x000EB340
	public bool IsFFXFISupported()
	{
		return !this.IsSteamDeck() && UKuroFFXFSR3BlueprintLibrary.IsSupported() && UKuroFFXFSR3BlueprintLibrary.SupportFI();
	}

	// Token: 0x0600540A RID: 21514 RVA: 0x000ED15A File Offset: 0x000EB35A
	public bool IsFsr3FallbackToFsr()
	{
		return this.IsFsr3Supported() && this.GetD3D12Type() <= 0;
	}

	// Token: 0x0600540B RID: 21515 RVA: 0x000ED174 File Offset: 0x000EB374
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

	// Token: 0x0600540C RID: 21516 RVA: 0x000ED29F File Offset: 0x000EB49F
	public bool IsEnableVolumeFog()
	{
		return this.EnableVolumeFog;
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x000ED2A7 File Offset: 0x000EB4A7
	public void CloseVolumeFog()
	{
		this.EnableVolumeFog = false;
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.volumetricfog 0", null);
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x000ED2C0 File Offset: 0x000EB4C0
	public FIntPoint GetResolutionByList(int index)
	{
		List<FIntPoint> resolutionList = this.GetResolutionList();
		int index2 = MathUtils.Instance.Clamp(index, 0, resolutionList.Count - 1);
		return resolutionList[index2];
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x000ED2F0 File Offset: 0x000EB4F0
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

	// Token: 0x06005410 RID: 21520 RVA: 0x000ED3E4 File Offset: 0x000EB5E4
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

	// Token: 0x06005411 RID: 21521 RVA: 0x000ED530 File Offset: 0x000EB730
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

	// Token: 0x06005412 RID: 21522 RVA: 0x000ED610 File Offset: 0x000EB810
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

	// Token: 0x06005413 RID: 21523 RVA: 0x000ED68C File Offset: 0x000EB88C
	public unsafe int GetFrameIndexByList(int frameRate)
	{
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			if (GameSettingsDeviceRenderDefine.FrameRateListIos.Contains(frameRate))
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
			if (this.FrameRateListAndroid.Contains(frameRate))
			{
				return Array.IndexOf<int>(this.FrameRateListAndroid, frameRate);
			}
			if (frameRate >= 40 && frameRate <= 45 && this.FrameRateListAndroid.Contains(40))
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
			if (GameSettingsDeviceRenderDefine.FrameRateListOpenHarmony.Contains(frameRate))
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
			if (GameSettingsDeviceRenderDefine.FrameRateListPc.Contains(frameRate))
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

	// Token: 0x06005414 RID: 21524 RVA: 0x000ED908 File Offset: 0x000EBB08
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

	// Token: 0x06005415 RID: 21525 RVA: 0x000ED9E4 File Offset: 0x000EBBE4
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

	// Token: 0x06005416 RID: 21526 RVA: 0x000EDAF4 File Offset: 0x000EBCF4
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

	// Token: 0x06005417 RID: 21527 RVA: 0x000EDBFB File Offset: 0x000EBDFB
	public bool IsEnableDLSSG()
	{
		return this.DLSSGEnable;
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x000EDC04 File Offset: 0x000EBE04
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

	// Token: 0x06005419 RID: 21529 RVA: 0x000EDC74 File Offset: 0x000EBE74
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

	// Token: 0x0600541A RID: 21530 RVA: 0x000EDD20 File Offset: 0x000EBF20
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

	// Token: 0x0600541B RID: 21531 RVA: 0x000EDDD6 File Offset: 0x000EBFD6
	public void EnableAFME(int value)
	{
		this.AFMEEnable = (value != 0);
		this.ApplyAFME();
	}

	// Token: 0x0600541C RID: 21532 RVA: 0x000EDDE8 File Offset: 0x000EBFE8
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

	// Token: 0x0600541D RID: 21533 RVA: 0x000EDE4C File Offset: 0x000EC04C
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

	// Token: 0x0600541E RID: 21534 RVA: 0x000EDE9C File Offset: 0x000EC09C
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

	// Token: 0x0600541F RID: 21535 RVA: 0x000EDEEC File Offset: 0x000EC0EC
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

	// Token: 0x06005420 RID: 21536 RVA: 0x000EDFAC File Offset: 0x000EC1AC
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

	// Token: 0x06005421 RID: 21537 RVA: 0x000EE080 File Offset: 0x000EC280
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

	// Token: 0x06005422 RID: 21538 RVA: 0x000EE0D4 File Offset: 0x000EC2D4
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

	// Token: 0x06005423 RID: 21539 RVA: 0x000EE12C File Offset: 0x000EC32C
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

	// Token: 0x06005424 RID: 21540 RVA: 0x000EE1A6 File Offset: 0x000EC3A6
	public void EnableXefg(int mode)
	{
		this.XefgMode = mode;
		if (this.XefgDisableTemporaryKeys.Count == 0)
		{
			this.ApplyXefg(mode);
		}
	}

	// Token: 0x06005425 RID: 21541 RVA: 0x000EE1C4 File Offset: 0x000EC3C4
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

	// Token: 0x06005426 RID: 21542 RVA: 0x000EE268 File Offset: 0x000EC468
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

	// Token: 0x06005427 RID: 21543 RVA: 0x000EE34C File Offset: 0x000EC54C
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

	// Token: 0x06005428 RID: 21544 RVA: 0x000EE3A0 File Offset: 0x000EC5A0
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

	// Token: 0x06005429 RID: 21545 RVA: 0x000EE414 File Offset: 0x000EC614
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

	// Token: 0x0600542A RID: 21546 RVA: 0x000EE4E1 File Offset: 0x000EC6E1
	public void TempDisableFFXFIWhenLoading()
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.Loading, false, "Loading");
		}
	}

	// Token: 0x0600542B RID: 21547 RVA: 0x000EE4F8 File Offset: 0x000EC6F8
	public void RecoverFFXFITempStateWhenLoading()
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.Loading, true, "Loading");
		}
	}

	// Token: 0x0600542C RID: 21548 RVA: 0x000EE50F File Offset: 0x000EC70F
	public void TempDisableFFXFIWhenSeqC(PlotInfo plotInfo)
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.SeqC, false, "PlotNetwork");
		}
	}

	// Token: 0x0600542D RID: 21549 RVA: 0x000EE526 File Offset: 0x000EC726
	public void RecoverFFXFITempStateFromSeqC(PlotResultInfo plotResultInfo)
	{
		if (this.IsFFXFISupported())
		{
			this.ToggleFFXFIStateTemporarily(EFFXFIApplyMode.SeqC, true, "PlotNetwork");
		}
	}

	// Token: 0x0600542E RID: 21550 RVA: 0x000EE540 File Offset: 0x000EC740
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

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x0600542F RID: 21551 RVA: 0x000EE74A File Offset: 0x000EC94A
	public int FrameRate
	{
		get
		{
			return this.FrameRateInternal;
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06005430 RID: 21552 RVA: 0x000EE752 File Offset: 0x000EC952
	public float FrameSeconds
	{
		get
		{
			return this.FrameSecondsInternal;
		}
	}

	// Token: 0x06005431 RID: 21553 RVA: 0x000EE75C File Offset: 0x000EC95C
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

	// Token: 0x06005432 RID: 21554 RVA: 0x000EE7AC File Offset: 0x000EC9AC
	public int GetMaxRoleShadowNum()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxRoleShadowNumWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x06005433 RID: 21555 RVA: 0x000EE7DC File Offset: 0x000EC9DC
	public int GetMaxRoleShadowDistance()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxRoleShadowDistanceWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x06005434 RID: 21556 RVA: 0x000EE80C File Offset: 0x000ECA0C
	public int GetMaxDecalShadowDistance()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			return GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityPc[gameQualitySettingLevel];
		}
		return GameSettingsDeviceRenderDefine.MaxDecalShadowDistanceWithGameGraphQualityMobile[gameQualitySettingLevel];
	}

	// Token: 0x06005435 RID: 21557 RVA: 0x000EE83C File Offset: 0x000ECA3C
	public int IsMainPlayerUseRealRoleShadow()
	{
		int gameQualitySettingLevel = (int)this.GameQualitySettingLevel;
		return GameSettingsDeviceRenderDefine.MainPlayerRealShadow[gameQualitySettingLevel];
	}

	// Token: 0x06005436 RID: 21558 RVA: 0x000EE857 File Offset: 0x000ECA57
	public void SetFrameRateTemploary(int frameRate)
	{
		this.FrameRateTemploary = MathUtils.Instance.Clamp(frameRate, 24, 120);
		this.FrameSecondsInternal = 1f / (float)this.FrameRateTemploary;
	}

	// Token: 0x06005437 RID: 21559 RVA: 0x000EE884 File Offset: 0x000ECA84
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

	// Token: 0x06005438 RID: 21560 RVA: 0x000EE930 File Offset: 0x000ECB30
	public void CancleSequenceFrameRateLimit()
	{
		this.CancelFrameRateTemploary();
		this.ApplyFrameRate(this.FrameRateInternal);
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS || Info.Instance.PlatformType == ESourcePlatformType.Android || Info.Instance.PlatformType == ESourcePlatformType.OpenHarmony)
		{
			this.TryRestoreCsmUpdateFrequency("Plot");
		}
	}

	// Token: 0x06005439 RID: 21561 RVA: 0x000EE982 File Offset: 0x000ECB82
	public void CancelFrameRateTemploary()
	{
		this.FrameRateTemploary = 0;
		this.FrameSecondsInternal = 1f / (float)this.FrameRateInternal;
	}

	// Token: 0x0600543A RID: 21562 RVA: 0x000EE99E File Offset: 0x000ECB9E
	public void TryReduceCsmUpdateFrequency(string reason)
	{
		bool count = this.ReduceCsmReasonSet.Count != 0;
		this.ReduceCsmReasonSet.Add(reason);
		if (!count && this.ReduceCsmReasonSet.Count == 1)
		{
			this.ReduceCsmUpdateFrequency();
		}
	}

	// Token: 0x0600543B RID: 21563 RVA: 0x000EE9CE File Offset: 0x000ECBCE
	public void TryRestoreCsmUpdateFrequency(string reason)
	{
		if (this.ReduceCsmReasonSet.Remove(reason) && this.ReduceCsmReasonSet.Count == 0)
		{
			this.RestoreCsmUpdateFrequency();
		}
	}

	// Token: 0x0600543C RID: 21564 RVA: 0x000EE9F1 File Offset: 0x000ECBF1
	private void RestoreCsmUpdateFrequency()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CSMMode3EnableUpdateIntervalOverride 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.IOSCompilationTimeLimit 2.0", null);
	}

	// Token: 0x0600543D RID: 21565 RVA: 0x000EEA13 File Offset: 0x000ECC13
	private void ReduceCsmUpdateFrequency()
	{
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CSMMode3EnableUpdateIntervalOverride 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheMode3CacheUpdateIntervalsOverride \"3000,3000,3000,3000,3000,3000\"", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.PSO.IOSCompilationTimeLimit 0.1", null);
	}

	// Token: 0x0600543E RID: 21566 RVA: 0x000EEA48 File Offset: 0x000ECC48
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

	// Token: 0x0600543F RID: 21567 RVA: 0x000EEB3C File Offset: 0x000ECD3C
	public void ApplyPerformanceLimit(string tag, bool cacheWorldFrame, bool frameLimit)
	{
		this.PerformanceLimitRunning[tag] = new PerformanceLimitConfig
		{
			FrameLimit = frameLimit,
			CacheWorldFrame = cacheWorldFrame
		};
		this.RefreshPerformanceLimit(tag);
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x000EEB64 File Offset: 0x000ECD64
	public void CancelPerformanceLimit(string tag)
	{
		if (!this.PerformanceLimitRunning.Remove(tag))
		{
			return;
		}
		this.RefreshPerformanceLimit(tag);
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x000EEB7C File Offset: 0x000ECD7C
	public void CancelAllPerformanceLimit()
	{
		this.PerformanceLimitRunning.Clear();
		this.CancelFrameRateTemploary();
		this.ApplyFrameRate(this.FrameRateInternal);
		this.RefreshPerformanceLimit("[CancelAll]");
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x000EEBA6 File Offset: 0x000ECDA6
	public void SetIsAutoAdjustImageQuality(bool isAutoAdjustImageQuality)
	{
		if (isAutoAdjustImageQuality)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoCoolUIEnable 1", null);
			return;
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoCoolUIEnable 0", null);
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x000EEBCC File Offset: 0x000ECDCC
	public EGameQualitySettingLevel? GetRecommendQualityLv()
	{
		int? recommendQualityLv = this.RecommendQualityLv;
		if (recommendQualityLv == null)
		{
			return null;
		}
		return new EGameQualitySettingLevel?((EGameQualitySettingLevel)recommendQualityLv.GetValueOrDefault());
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x000EEBFF File Offset: 0x000ECDFF
	public EGameQualityRange GetQualityRange()
	{
		return this.QualityRange;
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x000EEC08 File Offset: 0x000ECE08
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

	// Token: 0x06005446 RID: 21574 RVA: 0x000EED34 File Offset: 0x000ECF34
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

	// Token: 0x06005447 RID: 21575 RVA: 0x000EEE34 File Offset: 0x000ED034
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

	// Token: 0x06005448 RID: 21576 RVA: 0x000EEE54 File Offset: 0x000ED054
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

	// Token: 0x06005449 RID: 21577 RVA: 0x000EEECC File Offset: 0x000ED0CC
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

	// Token: 0x0600544A RID: 21578 RVA: 0x000EEF2C File Offset: 0x000ED12C
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

	// Token: 0x0600544B RID: 21579 RVA: 0x000EEF80 File Offset: 0x000ED180
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

	// Token: 0x0600544C RID: 21580 RVA: 0x000EEFC3 File Offset: 0x000ED1C3
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, bool> GetWindowsVersion()
	{
		return new ValueTuple<string, bool>(this.WindowsVersion, false);
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x000EEFD4 File Offset: 0x000ED1D4
	public bool ShouldOverrideVegetationDitherDefaultValue()
	{
		return !(this.VendorName.ToLower() != "intel") && (this.DeviceName.Contains("A580") || this.DeviceName.Contains("A750") || this.DeviceName.Contains("A770"));
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x000EF030 File Offset: 0x000ED230
	public bool IsAutoExposureOn()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.AutoExposure") == 1;
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x000EF03F File Offset: 0x000ED23F
	public bool IsEnergySavingFrameInterpolationSupported()
	{
		return UKismetSystemLibrary.GetConsoleVariableIntValue("r.Mobile.EnergySavingFrameInterpolation") == 1;
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06005450 RID: 21584 RVA: 0x000EF04E File Offset: 0x000ED24E
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

	// Token: 0x06005451 RID: 21585 RVA: 0x000EF071 File Offset: 0x000ED271
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x000EF073 File Offset: 0x000ED273
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDeviceRender instance = GameSettingsDeviceRender._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsDeviceRender._instance = null;
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x000EF08C File Offset: 0x000ED28C
	static GameSettingsDeviceRender()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDeviceRender.CreateStaticDefaultValue), new Action(GameSettingsDeviceRender.ResetStaticDefaultValue));
	}

	// Token: 0x0400263B RID: 9787
	private const string KuroFITranslucentLightingModeCVar = "r.KuroFI.TranslucentLightingMode";

	// Token: 0x0400263C RID: 9788
	private const string KuroFIEnableSingleOcclusionBloomReplaceCVar = "r.KuroFI.EnableSingleOcclusionBloomReplace";

	// Token: 0x0400263D RID: 9789
	[Nullable(2)]
	private Dictionary<int, DeviceRenderFeature> DeviceRenderFeatureCfgMapInternal;

	// Token: 0x0400263E RID: 9790
	private int? RecommendQualityLvInternal;

	// Token: 0x0400263F RID: 9791
	private int DevicePhysicalGbRam;

	// Token: 0x04002640 RID: 9792
	public int DeviceVideoGbRam;

	// Token: 0x04002641 RID: 9793
	public int CPUFrequency;

	// Token: 0x04002642 RID: 9794
	public int CPUCores;

	// Token: 0x04002643 RID: 9795
	public int CPUCoresIncludingHyperthreads;

	// Token: 0x04002644 RID: 9796
	public string CPUBrand = "";

	// Token: 0x04002645 RID: 9797
	public bool IsSupportedAFME;

	// Token: 0x04002646 RID: 9798
	public string DriverDate = "Unknown";

	// Token: 0x04002647 RID: 9799
	public string DriverVersion = "Unknown";

	// Token: 0x04002648 RID: 9800
	public string AdapterDriverVersion = "Unknown";

	// Token: 0x04002649 RID: 9801
	public string WindowsVersion = "Unknown";

	// Token: 0x0400264A RID: 9802
	public bool IsSSDDevice;

	// Token: 0x0400264B RID: 9803
	public bool IsAdreno;

	// Token: 0x0400264C RID: 9804
	public bool IsXuanJie;

	// Token: 0x0400264D RID: 9805
	private string MobileDeviceModel = "";

	// Token: 0x0400264E RID: 9806
	private string MobileDeviceMake = "";

	// Token: 0x0400264F RID: 9807
	private string VendorName = "";

	// Token: 0x04002650 RID: 9808
	private string DeviceName = "";

	// Token: 0x04002651 RID: 9809
	private string BaseProfileName = "";

	// Token: 0x04002652 RID: 9810
	public int DeviceScore;

	// Token: 0x04002653 RID: 9811
	public int LowMemoryDeviceMark;

	// Token: 0x04002654 RID: 9812
	private bool IsBrokenGLPacingDevice;

	// Token: 0x04002655 RID: 9813
	private string RHIName = "";

	// Token: 0x04002656 RID: 9814
	private int HardwareLevel;

	// Token: 0x04002657 RID: 9815
	public EGameDeviceType DeviceType = EGameDeviceType.PC_HIGH;

	// Token: 0x04002658 RID: 9816
	private EGameQualityRange QualityRange = EGameQualityRange.One2Three;

	// Token: 0x04002659 RID: 9817
	private bool EnableVolumeFog = true;

	// Token: 0x0400265A RID: 9818
	private FIntPoint? DefaultResolution;

	// Token: 0x0400265B RID: 9819
	private TArray<FIntPoint> ResolutionListRef;

	// Token: 0x0400265C RID: 9820
	private int FrameRateTemploary;

	// Token: 0x0400265D RID: 9821
	private int FrameRateInternal;

	// Token: 0x0400265E RID: 9822
	private bool DLSSGEnable;

	// Token: 0x0400265F RID: 9823
	private int DLSSGMode;

	// Token: 0x04002660 RID: 9824
	private bool AFMEEnable;

	// Token: 0x04002661 RID: 9825
	private bool AFMERunning;

	// Token: 0x04002662 RID: 9826
	[Nullable(2)]
	private string ProfileNameCache;

	// Token: 0x04002663 RID: 9827
	private float FrameSecondsInternal;

	// Token: 0x04002664 RID: 9828
	private readonly HashSet<string> ReduceCsmReasonSet = new HashSet<string>();

	// Token: 0x04002665 RID: 9829
	private int XessEnabled;

	// Token: 0x04002666 RID: 9830
	private int XefgMode;

	// Token: 0x04002667 RID: 9831
	private readonly Dictionary<string, int> XefgDisableTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x04002668 RID: 9832
	public Dictionary<string, IPerformanceLimitConfig> PerformanceLimitRunning = new Dictionary<string, IPerformanceLimitConfig>();

	// Token: 0x04002669 RID: 9833
	public int InCacheSceneColorMode;

	// Token: 0x0400266A RID: 9834
	private readonly Dictionary<EFunction, int> renderFeatureValueBuffer = new Dictionary<EFunction, int>();

	// Token: 0x0400266B RID: 9835
	private bool? IsSteamDeckInternal;

	// Token: 0x0400266C RID: 9836
	private readonly Dictionary<string, int> DLSSGDisalbeTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x0400266D RID: 9837
	private readonly Dictionary<string, int> AFMEDisalbeTemporaryKeys = new Dictionary<string, int>();

	// Token: 0x0400266E RID: 9838
	private readonly Dictionary<string, EFFXFIApplyMode> FFXFIDisableTemporaryReasons = new Dictionary<string, EFFXFIApplyMode>();

	// Token: 0x0400266F RID: 9839
	[Nullable(2)]
	private static GameSettingsDeviceRender _instance;
}
