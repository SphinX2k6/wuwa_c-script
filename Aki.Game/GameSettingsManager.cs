using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x0200028D RID: 653
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsManager : Singleton
{
	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x06002844 RID: 10308 RVA: 0x000F7868 File Offset: 0x000F5A68
	public unsafe Dictionary<EFunction, MenuConfig> ValidApplyConfigMap
	{
		get
		{
			if (this.ValidApplyConfigMapInternal == null)
			{
				this.ValidApplyConfigMapInternal = new Dictionary<EFunction, MenuConfig>();
				IReadOnlyList<MenuConfig> menuBaseConfig = MenuBaseConfig.Instance.GetMenuBaseConfig();
				if (menuBaseConfig == null)
				{
					return this.ValidApplyConfigMapInternal;
				}
				foreach (MenuConfig menuConfig in menuBaseConfig)
				{
					bool item = this.CheckConfigValidByCheckList(menuConfig).Item1;
					if (item)
					{
						if (!this.IsButtonSetting(menuConfig) && !Enum.IsDefined(typeof(EFunction), menuConfig.FunctionId))
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.GameSettings;
							ELogAuthor author = ELogAuthor.WZ;
							string message = "存在未注册在EFunction中的功能（非按键），视作该功能不存在";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cfg id", menuConfig.Id);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cfg FunctionId", menuConfig.FunctionId);
							instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						else if (this.ValidApplyConfigMapInternal.ContainsKey((EFunction)menuConfig.FunctionId))
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.GameSettings;
							ELogAuthor author2 = ELogAuthor.WZ;
							string message2 = "可应用的选项出现冲突，请认真检查配置【CheckList】";
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("出现冲突的functionId", menuConfig.FunctionId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("已保存的设置id", this.ValidApplyConfigMapInternal[(EFunction)menuConfig.FunctionId].Id);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("发生冲突的设置id", menuConfig.Id);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
						}
						else
						{
							this.ValidApplyConfigMapInternal[(EFunction)menuConfig.FunctionId] = menuConfig;
						}
					}
				}
			}
			return this.ValidApplyConfigMapInternal;
		}
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x000F7A70 File Offset: 0x000F5C70
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, string> CheckConfigValidByCheckList(MenuConfig cfg)
	{
		ValueTuple<bool, string> valueTuple = this.CheckPlatform(cfg);
		bool item = valueTuple.Item1;
		string item2 = valueTuple.Item2;
		if (!item)
		{
			return new ValueTuple<bool, string>(false, "CheckPlatform:" + item2);
		}
		ValueTuple<bool, string> valueTuple2 = this.CheckDeviceVendor(cfg.FunctionId);
		bool item3 = valueTuple2.Item1;
		string item4 = valueTuple2.Item2;
		if (!item3)
		{
			return new ValueTuple<bool, string>(false, "CheckDeviceVendor:" + item4);
		}
		ValueTuple<bool, string> valueTuple3 = this.CheckDeviceExtraConditions(cfg);
		bool item5 = valueTuple3.Item1;
		string item6 = valueTuple3.Item2;
		if (!item5)
		{
			return new ValueTuple<bool, string>(false, "CheckDeviceExtra:" + item6);
		}
		return new ValueTuple<bool, string>(true, "NONE");
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x000F7B0D File Offset: 0x000F5D0D
	public bool CanUnlockImageQualityForTesting()
	{
		return false;
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x000F7B10 File Offset: 0x000F5D10
	public bool IsImageQualityUnlockedForTesting()
	{
		return false;
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x000F7B13 File Offset: 0x000F5D13
	public bool IsShowMobileVeryHighOption()
	{
		return GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.ANDROID_VERY_HIGH || GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.IOS_VERY_HIGH;
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x000F7B33 File Offset: 0x000F5D33
	public bool IsShowPcVeryHighOption()
	{
		if (GameSettingsDeviceRender.Instance.IsNvidiaLaptopGPU())
		{
			if (GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.PC_HIGH)
			{
				return true;
			}
		}
		else if (GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.PC_VERY_HIGH)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x000F7B62 File Offset: 0x000F5D62
	public bool IsShowVeryHighOption()
	{
		if (Info.Instance.IsPcPlatform())
		{
			return this.IsShowPcVeryHighOption();
		}
		return Info.Instance.IsMobilePlatform() && this.IsShowMobileVeryHighOption();
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x000F7B8C File Offset: 0x000F5D8C
	public bool IsShowPcHighestOption()
	{
		if (!GameSettingsDeviceRender.Instance.IsFrameRate120DeviceForAllDevice())
		{
			return false;
		}
		if (GameSettingsDeviceRender.Instance.IsNvidiaLaptopGPU())
		{
			if (GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.PC_VERY_HIGH)
			{
				return true;
			}
		}
		else if (GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.PC_HIGHEST)
		{
			return true;
		}
		return GameSettingsDeviceRender.Instance.IsNvidia5060AndAbove();
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x000F7BE2 File Offset: 0x000F5DE2
	public bool IsPcHighestDevice()
	{
		return GameSettingsDeviceRender.Instance.DeviceType == EGameDeviceType.PC_HIGHEST && GameSettingsDeviceRender.Instance.IsFrameRate120DeviceForAllDevice();
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x000F7BFE File Offset: 0x000F5DFE
	private ETier GetResourceQualityTierForSettings()
	{
		return HotFixManager.LocalResourceQualityTier;
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x000F7C08 File Offset: 0x000F5E08
	public EGameQualitySettingLevel? GetMaxQualityLevelByResourceTier()
	{
		if (this.IsImageQualityUnlockedForTesting() || !HotFixManager.IsTierEnabled())
		{
			return null;
		}
		ETier resourceQualityTierForSettings = this.GetResourceQualityTierForSettings();
		if (Info.Instance.IsPcPlatform())
		{
			switch (resourceQualityTierForSettings)
			{
			case ETier.SD:
				return new EGameQualitySettingLevel?(EGameQualitySettingLevel.Middle);
			case ETier.HD:
				return new EGameQualitySettingLevel?(EGameQualitySettingLevel.VeryHigh);
			case ETier.UHD:
				return new EGameQualitySettingLevel?(EGameQualitySettingLevel.Highest);
			default:
				return null;
			}
		}
		else
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				return null;
			}
			if (resourceQualityTierForSettings == ETier.SD)
			{
				return new EGameQualitySettingLevel?(EGameQualitySettingLevel.Middle);
			}
			if (resourceQualityTierForSettings != ETier.HD)
			{
				return null;
			}
			return new EGameQualitySettingLevel?(EGameQualitySettingLevel.VeryHigh);
		}
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x000F7CB0 File Offset: 0x000F5EB0
	public unsafe EGameQualitySettingLevel ClampQualityByResourceTier(EGameQualitySettingLevel quality)
	{
		EGameQualitySettingLevel? maxQualityLevelByResourceTier = this.GetMaxQualityLevelByResourceTier();
		if (maxQualityLevelByResourceTier == null || quality <= maxQualityLevelByResourceTier.Value)
		{
			return quality;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[画质预设刷新] 推荐画质超过资源档位上限，夹降";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("quality", quality);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cap", maxQualityLevelByResourceTier.Value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return maxQualityLevelByResourceTier.Value;
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x000F7D48 File Offset: 0x000F5F48
	public int? GetMaxImageDetailByResourceTier()
	{
		if (this.IsImageQualityUnlockedForTesting() || !HotFixManager.IsTierEnabled())
		{
			return null;
		}
		ETier resourceQualityTierForSettings = this.GetResourceQualityTierForSettings();
		if (Info.Instance.IsPcPlatform())
		{
			switch (resourceQualityTierForSettings)
			{
			case ETier.SD:
				return new int?(1);
			case ETier.HD:
				return new int?(2);
			case ETier.UHD:
				return null;
			default:
				return null;
			}
		}
		else
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				return null;
			}
			if (resourceQualityTierForSettings == ETier.SD)
			{
				return new int?(1);
			}
			if (resourceQualityTierForSettings != ETier.HD)
			{
				return null;
			}
			return null;
		}
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x000F7DF4 File Offset: 0x000F5FF4
	private unsafe void ClampImageDetailByResourceTier(EGameSettingsInitSourceType sourceType)
	{
		int? maxImageDetailByResourceTier = this.GetMaxImageDetailByResourceTier();
		if (maxImageDetailByResourceTier == null)
		{
			return;
		}
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.IMAGEDETAIL);
		if (valueOrDefault == null)
		{
			return;
		}
		OneOf<int, float, double>? cachedValueBySourceType = valueOrDefault.GetCachedValueBySourceType(sourceType);
		if (cachedValueBySourceType == null)
		{
			return;
		}
		int num = GameSettingsManager.OneOfToInt(cachedValueBySourceType.Value);
		if (num <= maxImageDetailByResourceTier.Value)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[画面细节] 推荐画质联动的画面细节超过资源档位上限，夹降";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cached", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cap", maxImageDetailByResourceTier.Value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		valueOrDefault.RefreshCacheValue(maxImageDetailByResourceTier.Value, sourceType);
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x000F7EC8 File Offset: 0x000F60C8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private ValueTuple<bool, string> CheckDeviceExtraConditions(MenuConfig cfg)
	{
		string device = cfg.Device;
		if (device == "isShowHighest")
		{
			return new ValueTuple<bool, string>(this.IsShowPcHighestOption(), "isShowHighest");
		}
		if (device == "isShowVeryHigh")
		{
			return new ValueTuple<bool, string>(!this.IsShowPcHighestOption() && this.IsShowVeryHighOption(), "isShowVeryHigh");
		}
		if (device == "isBelowVeryHigh")
		{
			return new ValueTuple<bool, string>(!this.IsShowPcHighestOption() && !this.IsShowVeryHighOption(), "isBelowVeryHigh");
		}
		if (device == "isNotAndroidVeryHigh")
		{
			return new ValueTuple<bool, string>(!Info.Instance.IsAndroidPlatform() || !GameSettingsDeviceRender.Instance.IsAndroidHighestResolutionDevice(), "isNotAndroidVeryHigh");
		}
		if (device == "isAndroidVeryHigh")
		{
			return new ValueTuple<bool, string>(Info.Instance.IsAndroidPlatform() && GameSettingsDeviceRender.Instance.IsAndroidHighestResolutionDevice(), "isAndroidVeryHigh");
		}
		if (device == "isLowMemory")
		{
			return new ValueTuple<bool, string>(UKuroStaticLibrary.IsLowMemoryDevice(), "isLowMemory");
		}
		if (device == "isNotLowMemory")
		{
			return new ValueTuple<bool, string>(!UKuroStaticLibrary.IsLowMemoryDevice(), "isNotLowMemory");
		}
		if (device == "isNot120Frame")
		{
			return new ValueTuple<bool, string>(!GameSettingsDeviceRender.Instance.IsFrameRate120DeviceForAllDevice(), "isNot120Frame");
		}
		if (device == "is120Frame")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsFrameRate120DeviceForAllDevice(), "is120Frame");
		}
		if (device == "isCloudGame")
		{
			return new ValueTuple<bool, string>(Platform.Instance.IsCloudGame(), "isCloudGame");
		}
		if (device == "isNotCloudGame")
		{
			return new ValueTuple<bool, string>(!Platform.Instance.IsCloudGame(), "isNotCloudGame");
		}
		if (device == "isNotColudGameNotOpenHarmony")
		{
			return new ValueTuple<bool, string>(!Platform.Instance.IsCloudGame() && !Platform.Instance.IsOpenHarmonyPlatform(), "isNotColudGameAndOpenHarmony");
		}
		if (device == "isOpenHarmony")
		{
			return new ValueTuple<bool, string>(Platform.Instance.IsOpenHarmonyPlatform(), "isOpenHarmony");
		}
		if (device == "isNotOpenHarmony")
		{
			return new ValueTuple<bool, string>(!Platform.Instance.IsOpenHarmonyPlatform(), "isNotOpenHarmony");
		}
		if (device == "isAutoAdjustImageQuality")
		{
			return new ValueTuple<bool, string>(Platform.Instance.IsPcPlatform() || Platform.Instance.IsAndroidPlatform() || Platform.Instance.IsOpenHarmonyPlatform(), "isAutoAdjustImageQuality");
		}
		if (device == "isMac")
		{
			return new ValueTuple<bool, string>(Info.Instance.IsMacPlatform(), "isMac");
		}
		if (device == "isNotMac")
		{
			return new ValueTuple<bool, string>(!Info.Instance.IsMacPlatform(), "isNotMac");
		}
		if (device == "isNotMobile")
		{
			return new ValueTuple<bool, string>(!Info.Instance.IsMobilePlatform(), "isNotMobile");
		}
		if (device == "isMetalSupport")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsMetalFxDevice(), "isMetalSupport");
		}
		if (device == "isRedMagicLow")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsRedMagicLow(), "isRedMagicLow");
		}
		if (device == "isRedMagicHigh")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsRedMagicHigh(), "isRedMagicHigh");
		}
		if (device == "isNotRedMagic")
		{
			return new ValueTuple<bool, string>(!GameSettingsDeviceRender.Instance.IsRedMagic(), "isNotRedMagic");
		}
		if (device == "isNotGrayscale")
		{
			return new ValueTuple<bool, string>(ResourceDiffUpdaterManager.Instance.IsGrayBoxHit(), "isNotGrayscale");
		}
		if (device == "isNotClearPack")
		{
			return new ValueTuple<bool, string>(VideoResUpdate.Instance.IsVideoClearGrayBoxHit(), "isNotClearPack");
		}
		if (device == "is50Series")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsRTX50(), "is50Series");
		}
		if (device == "isNot50Series")
		{
			return new ValueTuple<bool, string>(!GameSettingsDeviceRender.Instance.IsRTX50(), "isNot50Series");
		}
		if (device == "isWindows")
		{
			return new ValueTuple<bool, string>(Info.Instance.IsWindowsPlatform() && !Platform.Instance.IsCloudGame(), "isWindows");
		}
		if (device == "isNotWindows")
		{
			return new ValueTuple<bool, string>(!Info.Instance.IsWindowsPlatform() || Platform.Instance.IsCloudGame(), "isNotWindows");
		}
		if (device == "isEnergySavingFrameGen")
		{
			return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsEnergySavingFrameInterpolationSupported(), "isEnergySavingFrameGen");
		}
		if (device == "isNotEnergySavingFrameGen")
		{
			return new ValueTuple<bool, string>(!GameSettingsDeviceRender.Instance.IsEnergySavingFrameInterpolationSupported(), "isNotEnergySavingFrameGen");
		}
		if (device == "isNotIOS")
		{
			return new ValueTuple<bool, string>(!Info.Instance.IsIosPlatform(), "isNotIOS");
		}
		if (device == "WindowsAndMobile")
		{
			return new ValueTuple<bool, string>((Info.Instance.IsWindowsPlatform() && !Platform.Instance.IsCloudGame()) || Info.Instance.IsMobilePlatform(), "WindowsAndMobile");
		}
		if (device == "isSubPackageHigh")
		{
			return new ValueTuple<bool, string>(HotFixManager.IsTierEnabled() && HotFixManager.IsMobileHighEndDevice(), "isSubPackageHigh");
		}
		if (device == "HarmonyOSSuperResolution")
		{
			return new ValueTuple<bool, string>(OpenHarmonySdkController.GetOrCreateInstance().CanUse() && GameSettingsDeviceRender.Instance.IsMaleoonSuperResolutionSupported(), "HarmonyOSSuperResolution");
		}
		if (device == "HarmonyOSRayTracingNormal")
		{
			return new ValueTuple<bool, string>(OpenHarmonySdkController.GetOrCreateInstance().CanUse() && GameSettingsDeviceRender.Instance.IsMaleoonRayTracingNormalSupported(), "HarmonyOSRayTracingNormal");
		}
		if (device == "HarmonyOSRayTracingSuper")
		{
			return new ValueTuple<bool, string>(OpenHarmonySdkController.GetOrCreateInstance().CanUse() && GameSettingsDeviceRender.Instance.IsMaleoonRayTracingSuperSupported(), "HarmonyOSRayTracingSuper");
		}
		return new ValueTuple<bool, string>(true, "DEFAULT");
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x000F8490 File Offset: 0x000F6690
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private ValueTuple<bool, string> CheckDeviceVendor(int functionId)
	{
		bool item = GameSettingsDeviceRender.Instance.IsDlssGpuDevice() && GameSettingsDeviceRender.Instance.IsDlssSupported();
		bool flag = GameSettingsDeviceRender.Instance.IsFsrDevice();
		bool item2 = GameSettingsDeviceRender.Instance.IsPWSDKDevice();
		bool flag2 = GameSettingsDeviceRender.Instance.IsDlss3GpuDevice() && GameSettingsDeviceRender.Instance.IsDlssSupported();
		bool item3 = GameSettingsDeviceRender.Instance.IsVulkanDevice();
		bool flag3 = GameSettingsDeviceRender.Instance.GetD3D12Type() > 0;
		bool item4 = false;
		bool flag4 = GameSettingsDeviceRender.Instance.IsXess2Supported();
		bool flag5 = GameSettingsDeviceRender.Instance.IsXeFGSupported();
		bool flag6 = UKuroFFXFSR3BlueprintLibrary.IsGlobalSwitchOn();
		bool flag7 = GameSettingsDeviceRender.Instance.IsFsr3Supported();
		bool flag8 = GameSettingsDeviceRender.Instance.IsFFXFISupported();
		bool flag9 = GameSettingsDeviceRender.Instance.IsFsr3FallbackToFsr();
		bool flag10 = GameSettingsDeviceRender.Instance.IsShowRayTracingSetting();
		bool flag11 = this.GetCurrentValueSafely(EFunction.RayTracing, 0, true) > 0;
		bool item5 = UKuroRenderingRuntimeBPPluginBPLibrary.GetLumenGISupported() && flag10 && flag11;
		bool item6 = UKuroRenderingRuntimeBPPluginBPLibrary.GetLumenReflectionsSupported() && flag10 && flag11;
		bool item7 = UKuroRenderingRuntimeBPPluginBPLibrary.GetRayTracingShadowsSupported() && flag10 && flag11;
		bool item8 = UKismetRenderingLibrary.IsSupportedAFME();
		if (functionId <= 831)
		{
			if (functionId <= 76)
			{
				if (functionId == 58)
				{
					return new ValueTuple<bool, string>(!Info.Instance.IsMobilePlatform() || GameSettingsDeviceRender.Instance.IsAndroidPlatformAOValid() || GameSettingsDeviceRender.Instance.IsIOSPlatformAOValid() || GameSettingsDeviceRender.Instance.IsOpenHarmonyPlatformAOValid(), "EFunction.SCENEAO");
				}
				if (functionId == 63)
				{
					return new ValueTuple<bool, string>(!Info.Instance.IsMacPlatform(), "EFunction.VOLUMEFOG");
				}
				if (functionId == 76)
				{
					return new ValueTuple<bool, string>(UKuroAudioStatics.IsDolbyAtmosGameSupported(), "EFunction.DOLBYATOMS");
				}
			}
			else
			{
				switch (functionId)
				{
				case 81:
					return new ValueTuple<bool, string>(item, "EFunction.NVIDIADLSS");
				case 82:
					return new ValueTuple<bool, string>(flag2 && flag3, "EFunction.NVIDIADLSSFG");
				case 83:
				case 86:
					break;
				case 84:
					return new ValueTuple<bool, string>(item, "EFunction.NVIDIADLSSSHARPNESS");
				case 85:
					return new ValueTuple<bool, string>(item, "EFunction.NVIDIAREFLEX");
				case 87:
					return new ValueTuple<bool, string>(flag || flag9, "EFunction.FSR");
				default:
					switch (functionId)
					{
					case 125:
						return new ValueTuple<bool, string>(item4, "EFunction.XESS");
					case 126:
						return new ValueTuple<bool, string>(item4, "EFunction.XESS_QUALITY");
					case 127:
						return new ValueTuple<bool, string>(GameSettingsDeviceRender.Instance.IsMetalFxDevice(), "EFunction.METALFX");
					case 128:
						return new ValueTuple<bool, string>(item2, "EFunction.IRX");
					default:
						if (functionId == 831)
						{
							return new ValueTuple<bool, string>(item, "EFunction.NVIDIADLSSQUALITY");
						}
						break;
					}
					break;
				}
			}
		}
		else if (functionId <= 20340)
		{
			switch (functionId)
			{
			case 20026:
				return new ValueTuple<bool, string>(flag10, "EFunction.RayTracing");
			case 20027:
				return new ValueTuple<bool, string>(item6, "EFunction.RayTracedReflection");
			case 20028:
				return new ValueTuple<bool, string>(item5, "EFunction.RayTracedGI");
			case 20029:
				return new ValueTuple<bool, string>(item7, "EFunction.RayTracedShadow");
			case 20030:
			case 20031:
				break;
			case 20032:
				return new ValueTuple<bool, string>(item8, "EFunction.AdrenoFME");
			default:
				if (functionId == 20310 || functionId == 20340)
				{
					return new ValueTuple<bool, string>(flag4, "EFunction.XESS2");
				}
				break;
			}
		}
		else if (functionId <= 20351)
		{
			if (functionId == 20341)
			{
				return new ValueTuple<bool, string>(flag4 && flag5, "EFunction.XESS2_FG");
			}
			if (functionId - 20350 <= 1)
			{
				return new ValueTuple<bool, string>(flag7 && flag3 && flag6, "EFunction.FSR3");
			}
		}
		else
		{
			if (functionId == 20352)
			{
				return new ValueTuple<bool, string>(flag8 && flag3 && flag6, "EFunction.FSR3_FG");
			}
			if (functionId == 20360)
			{
				return new ValueTuple<bool, string>(item3, "EFunction.Vulkan");
			}
		}
		return new ValueTuple<bool, string>(true, "DEFAULT");
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x000F8834 File Offset: 0x000F6A34
	private bool CheckConsoleHide(MenuConfig config)
	{
		return config.FunctionId != 10 || ((config.Ps5Hide != 1 || !Info.Instance.IsPs5Platform() || config.SpecifyHideConsolesLength > 0) && (config.XboxHide != 1 || !Info.Instance.IsXSXPlatform() || config.SpecifyHideConsolesLength > 0));
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x000F8894 File Offset: 0x000F6A94
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private ValueTuple<bool, string> CheckPlatform(MenuConfig menuCfg)
	{
		EMenuConfigPlatform platform = (EMenuConfigPlatform)menuCfg.Platform;
		switch (platform)
		{
		case EMenuConfigPlatform.NORMAL:
			return new ValueTuple<bool, string>(this.CheckConsoleHide(menuCfg), "EMenuConfigPlatform.NORMAL");
		case EMenuConfigPlatform.PC_OR_PS:
			return new ValueTuple<bool, string>(Info.Instance.IsPcOrGamepadPlatform() && !Platform.Instance.IsCloudGame(), "EMenuConfigPlatform.PC_OR_PS");
		case EMenuConfigPlatform.MOBILE:
			return new ValueTuple<bool, string>(Info.Instance.IsMobilePlatform() || Info.Instance.IsOpenHarmonyPlatform() || Platform.Instance.IsCloudGame(), "EMenuConfigPlatform.MOBILE");
		case EMenuConfigPlatform.ANDROID:
			return new ValueTuple<bool, string>(Info.Instance.IsAndroidPlatform() || Info.Instance.IsOpenHarmonyPlatform(), "EMenuConfigPlatform.ANDROID");
		case EMenuConfigPlatform.IOS:
			return new ValueTuple<bool, string>(Info.Instance.IsIosPlatform(), "EMenuConfigPlatform.IOS");
		case EMenuConfigPlatform.PlayStation:
			return new ValueTuple<bool, string>(Info.Instance.IsPs5Platform(), "EMenuConfigPlatform.PlayStation");
		case EMenuConfigPlatform.PC_ONLY:
			return new ValueTuple<bool, string>(Info.Instance.IsPcPlatform(), "EMenuConfigPlatform.PC_ONLY");
		case EMenuConfigPlatform.XBOX_ONLY:
			return new ValueTuple<bool, string>(Info.Instance.IsXboxPlatform(), "EMenuConfigPlatform.XBOX_ONLY");
		case EMenuConfigPlatform.WinGDK_ONLY:
			return new ValueTuple<bool, string>(Info.Instance.IsWinGDKPlatform(), "EMenuConfigPlatform.WinGDK_ONLY");
		default:
			if (platform != EMenuConfigPlatform.NONE)
			{
				return new ValueTuple<bool, string>(false, "DEFAULT");
			}
			return new ValueTuple<bool, string>(true, "EMenuConfigPlatform.NONE");
		}
	}

	// Token: 0x06002856 RID: 10326 RVA: 0x000F89F0 File Offset: 0x000F6BF0
	public bool IsButtonSetting(MenuConfig menuCfg)
	{
		return menuCfg.Platform != 99 && (menuCfg.MainType == 3 && menuCfg.Platform != 2 && menuCfg.FunctionId != 129) && menuCfg.FunctionId != 134;
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x000F8A40 File Offset: 0x000F6C40
	private void AssignCacheValueByDeviceRenderFeature(DeviceRenderFeature targetCfg, EGameSettingsInitSourceType sourceType)
	{
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.IMAGEQUALITY);
		if (valueOrDefault != null)
		{
			valueOrDefault.CacheValue(targetCfg.QualityType, sourceType);
		}
		foreach (KeyValuePair<EFunction, int> keyValuePair in GameSettingsDeviceRender.Instance.GetOtherChangedValue(targetCfg))
		{
			EFunction efunction;
			int num;
			keyValuePair.Deconstruct(out efunction, out num);
			EFunction efunction2 = efunction;
			int num2 = num;
			if (efunction2 != EFunction.RayTracing)
			{
				if (efunction2 == EFunction.SUPERRESOLUTION)
				{
					if (Info.Instance.IsWindowsPlatform())
					{
						EFunction efunction3 = EFunction.SUPERRESOLUTION;
						EFunction efunction4 = EFunction.SUPERRESOLUTION;
						int num3 = num2;
						ValueTuple<EFunction, EFunction, int> valueTuple = GameSettingsDeviceRender.Instance.MapSuperResolutionRecommendValue(efunction3, efunction4, num3);
						efunction3 = valueTuple.Item1;
						efunction4 = valueTuple.Item2;
						num3 = valueTuple.Item3;
						GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(efunction3);
						if (valueOrDefault2 != null)
						{
							valueOrDefault2.CacheValue(1, sourceType);
						}
						GameSettingsInitValueSource valueOrDefault3 = this.ValidInitValueSourceCache.GetValueOrDefault(efunction4);
						if (valueOrDefault3 != null)
						{
							valueOrDefault3.CacheValue(num3, sourceType);
						}
					}
				}
				else
				{
					GameSettingsInitValueSource valueOrDefault4 = this.ValidInitValueSourceCache.GetValueOrDefault(efunction2);
					if (valueOrDefault4 != null)
					{
						valueOrDefault4.CacheValue(num2, sourceType);
					}
				}
			}
		}
		foreach (KeyValuePair<EFunction, float> keyValuePair2 in GameSettingsDeviceRender.Instance.GetOtherChangedFloatValue(targetCfg))
		{
			EFunction efunction;
			float num4;
			keyValuePair2.Deconstruct(out efunction, out num4);
			EFunction key = efunction;
			float value = num4;
			GameSettingsInitValueSource valueOrDefault5 = this.ValidInitValueSourceCache.GetValueOrDefault(key);
			if (valueOrDefault5 != null)
			{
				valueOrDefault5.CacheValue(value, sourceType);
			}
		}
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x000F8BF8 File Offset: 0x000F6DF8
	private unsafe void AssignCacheValueByTransferViewSensitivity(EFunction functionId)
	{
		int? global = LocalStorage.GetGlobal<int?>((ELocalStorageGlobalKey)GameSettingsDefine.function2GameSettings.GetValueOrDefault(functionId).GetCallbackOrGlobalKey, null);
		if (global != null)
		{
			int? num = global;
			int num2 = 50;
			if (num.GetValueOrDefault() < num2 & num != null)
			{
				int num3 = (int)Math.Floor(22.22 + 0.555 * (double)global.Value);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Menu;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "[ViewSensitivity]转化视角灵敏度";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)functionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", global);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("newValue", num3);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(functionId);
				if (valueOrDefault == null)
				{
					return;
				}
				valueOrDefault.CacheValue(num3, EGameSettingsInitSourceType.InitOverride);
			}
		}
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x000F8D10 File Offset: 0x000F6F10
	private void AssignCacheValueByPlayerMenuInfo(Dictionary<int, double> data, EFunction functionId, EGameSettingsInitSourceType reason)
	{
		double num;
		if (!data.TryGetValue((int)functionId, out num))
		{
			return;
		}
		if (this.IsFloatSetting(functionId))
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(functionId);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.CacheValue((float)num, reason);
			return;
		}
		else
		{
			GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(functionId);
			if (valueOrDefault2 == null)
			{
				return;
			}
			valueOrDefault2.CacheValue((int)num, reason);
			return;
		}
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x000F8D70 File Offset: 0x000F6F70
	private void CacheInitDataFromOverride()
	{
		this.CacheOverrideForViewSensitivity();
		this.CacheOverrideForDisplayMode();
		this.CacheOverrideForCloudGame();
		this.CacheOverrideForDlssQuality();
		this.CacheOverrideForDlssFrameGenerate();
		this.CacheOverrideForResetBrightness();
		this.CacheOverrideForNpcDensity();
		this.CacheOverrideForHdr();
		this.CacheOverrideForMotorRoundJoyStick();
		this.CacheOverrideForMobileShadowQuality();
		this.CacheOverrideForVulkanRefresh();
		this.CacheOverrideForResourceTierQualityCap();
		this.CacheOverrideForImageDetailByResourceTier();
		GameSettingsManager.CacheOverrideForRecommendImageQualityRelated();
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000F8DD0 File Offset: 0x000F6FD0
	private unsafe void CacheOverrideForResourceTierQualityCap()
	{
		EGameQualitySettingLevel? maxQualityLevelByResourceTier = this.GetMaxQualityLevelByResourceTier();
		if (maxQualityLevelByResourceTier == null)
		{
			return;
		}
		int? global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.ImageQuality, null);
		DeviceRenderFeature? deviceRenderFeature;
		int? num = (global != null) ? global : ((GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature() != null) ? new int?(deviceRenderFeature.GetValueOrDefault().QualityType) : null);
		if (num == null || num.Value <= (int)maxQualityLevelByResourceTier.Value)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[画质预设刷新] 画质超过资源档位上限，夹降";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cachedQuality", num.Value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cap", (int)maxQualityLevelByResourceTier.Value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		DeviceRenderFeature? deviceRenderFeature2 = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(maxQualityLevelByResourceTier.Value);
		if (deviceRenderFeature2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "[画质预设刷新] 档位上限画质对应的渲染Feature不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cap", (int)maxQualityLevelByResourceTier.Value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		GameSettingsManager.Instance.AssignCacheValueByDeviceRenderFeature(deviceRenderFeature2.Value, EGameSettingsInitSourceType.InitOverride);
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x000F8F2C File Offset: 0x000F712C
	private unsafe void CacheOverrideForImageDetailByResourceTier()
	{
		int? maxImageDetailByResourceTier = this.GetMaxImageDetailByResourceTier();
		if (maxImageDetailByResourceTier == null)
		{
			return;
		}
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.IMAGEDETAIL);
		if (valueOrDefault == null)
		{
			return;
		}
		int? global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.ImageDetail, null);
		DeviceRenderFeature? deviceRenderFeature;
		int? num = (global != null) ? global : ((GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature() != null) ? new int?(deviceRenderFeature.GetValueOrDefault().ImageDetail) : null);
		if (num == null || num.Value <= maxImageDetailByResourceTier.Value)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[画面细节] 超过资源档位上限，夹降";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cached", num.Value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cap", maxImageDetailByResourceTier.Value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		valueOrDefault.CacheValue(maxImageDetailByResourceTier.Value, EGameSettingsInitSourceType.InitOverride);
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x000F904C File Offset: 0x000F724C
	private void CacheOverrideForViewSensitivity()
	{
		if (!LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsConvertAllViewSensitivity, false))
		{
			if (Info.Instance.IsPcPlatform())
			{
				Log.Instance.Info(ELogModule.Menu, ELogAuthor.WZ, " [ViewSensitivity]转化Pc视角灵敏度", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.AssignCacheValueByTransferViewSensitivity(EFunction.HorizontalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.VerticalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.AimHorizontalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.AimVerticalViewSensitivity);
			}
			if (Info.Instance.IsMobilePlatform())
			{
				Log.Instance.Info(ELogModule.Menu, ELogAuthor.WZ, "[ViewSensitivity]转化Mobile视角灵敏度", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.AssignCacheValueByTransferViewSensitivity(EFunction.MobileHorizontalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.MobileVerticalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.MobileAimHorizontalViewSensitivity);
				this.AssignCacheValueByTransferViewSensitivity(EFunction.MobileAimVerticalViewSensitivity);
			}
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsConvertAllViewSensitivity, true);
		}
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x000F90FF File Offset: 0x000F72FF
	private void CacheOverrideForDisplayMode()
	{
		if (UKismetSystemLibrary.GetCommandLine().Contains("-windowed"))
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.DISPLAYMODE);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.CacheValue(1, EGameSettingsInitSourceType.InitOverride);
		}
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x000F9130 File Offset: 0x000F7330
	private unsafe void CacheOverrideForCloudGame()
	{
		if (!Platform.Instance.IsCloudGame())
		{
			return;
		}
		DeviceRenderFeature? defaultDeviceRenderFeature = GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature();
		if (defaultDeviceRenderFeature == null)
		{
			Log.Instance.Error(ELogModule.GameSettings, ELogAuthor.WZ, "云游戏时不能获得渲染Feature预设值", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		else
		{
			this.AssignCacheValueByDeviceRenderFeature(defaultDeviceRenderFeature.Value, EGameSettingsInitSourceType.CloudOverride);
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 1", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality -1", null);
		if (!CloudGameManagerLauncher.Instance.IsPreLaunch)
		{
			return;
		}
		if (CloudGameManager.Instance.ScreenWidth != 0)
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetScreenResolution(new FIntPoint(CloudGameManager.Instance.ScreenWidth, CloudGameManager.Instance.ScreenHeight));
			gameUserSettings.ApplySettings(true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "初始化游戏设置 - 云游戏预启动分辨率设置";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CloudGameManager.ScreenWidth", CloudGameManager.Instance.ScreenWidth);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CloudGameManager.ScreenHeight", CloudGameManager.Instance.ScreenHeight);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x000F9264 File Offset: 0x000F7464
	public unsafe void ApplyCloudGameResolution()
	{
		if (!CloudGameManagerLauncher.Instance.IsPreLaunch)
		{
			return;
		}
		if (CloudGameManager.Instance.ScreenWidth != 0)
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetScreenResolution(new FIntPoint(CloudGameManager.Instance.ScreenWidth, CloudGameManager.Instance.ScreenHeight));
			gameUserSettings.ApplySettings(true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CloudGame;
		ELogAuthor author = ELogAuthor.TL;
		string message = "初始化游戏设置 - 云游戏预启动分辨率设置";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CloudGameManager.ScreenWidth", CloudGameManager.Instance.ScreenWidth);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CloudGameManager.ScreenHeight", CloudGameManager.Instance.ScreenHeight);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x000F9328 File Offset: 0x000F7528
	private void CacheOverrideForDlssQuality()
	{
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(EFunction.NVIDIADLSSQUALITY);
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.NVIDIADLSSQUALITY);
		if (valueOrNull == null || valueOrDefault == null)
		{
			return;
		}
		int optionsDefault = valueOrNull.Value.OptionsDefault;
		if (!LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.HasRefreshNvidiaDlssQuality, false))
		{
			valueOrDefault.CacheValue(optionsDefault, EGameSettingsInitSourceType.InitOverride);
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.HasRefreshNvidiaDlssQuality, true);
		}
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x000F939C File Offset: 0x000F759C
	private void CacheOverrideForDlssFrameGenerate()
	{
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(EFunction.NVIDIADLSSFG);
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.NVIDIADLSSFG);
		if (valueOrNull == null || valueOrDefault == null)
		{
			return;
		}
		int optionsDefault = valueOrNull.Value.OptionsDefault;
		if (GameSettingsDeviceRender.Instance.IsDlss3HardwareSchedulingDisabled())
		{
			valueOrDefault.CacheValue(optionsDefault, EGameSettingsInitSourceType.InitOverride);
			return;
		}
		int? currentValue = this.GetCurrentValue(EFunction.NVIDIADLSS, false, true);
		int num = 0;
		if (currentValue.GetValueOrDefault() == num & currentValue != null)
		{
			valueOrDefault.CacheValue(0, EGameSettingsInitSourceType.InitOverride);
		}
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x000F9430 File Offset: 0x000F7630
	private void CacheOverrideForRecommendImageQuality()
	{
		if (RecommendQualityModel.Instance.IsNeedApply)
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.IMAGEQUALITY);
			EGameQualitySettingLevel egameQualitySettingLevel = this.ClampQualityByResourceTier(RecommendQualityModel.Instance.NeedApplyQuality);
			if (valueOrDefault != null)
			{
				valueOrDefault.CacheValue((int)egameQualitySettingLevel, EGameSettingsInitSourceType.RecommendQualityOverride);
			}
			DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(egameQualitySettingLevel);
			if (deviceRenderFeature != null)
			{
				this.AssignCacheValueByDeviceRenderFeature(deviceRenderFeature.Value, EGameSettingsInitSourceType.RecommendQualityOverride);
				this.ClampImageDetailByResourceTier(EGameSettingsInitSourceType.RecommendQualityOverride);
			}
			RecommendQualityModel.Instance.IsNeedApply = false;
		}
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x000F94B0 File Offset: 0x000F76B0
	public unsafe static void CacheOverrideForRecommendImageQualityRelated()
	{
		bool? global = LocalStorage.GetGlobal<bool?>(ELocalStorageGlobalKey.IsUsingQualityPreset, null);
		bool? flag = global;
		bool flag2 = false;
		if (flag.GetValueOrDefault() == flag2 & flag != null)
		{
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "[画质预设刷新] 本地保存了不使用画质预设", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int? cachedQuality = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.ImageQuality, null);
		if (cachedQuality == null)
		{
			return;
		}
		bool isConsoleQualityMigration = false;
		if ((Info.Instance.IsPs5Platform() || Info.Instance.IsXSXPlatform()) && !GameSettingsManager.Instance.IsLocalStorageValueValid(EFunction.IMAGEQUALITY, (double)cachedQuality.Value))
		{
			DeviceRenderFeature? deviceRenderFeature;
			int? cachedQuality2 = (GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature() != null) ? new int?(deviceRenderFeature.GetValueOrDefault().QualityType) : null;
			if (cachedQuality2 == null || !GameSettingsManager.Instance.IsLocalStorageValueValid(EFunction.IMAGEQUALITY, (double)cachedQuality2.Value))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameSettings;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "[画质预设刷新] 主机老存档画质非法且机型默认画质不可用";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("cachedQuality", cachedQuality.Value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("defaultQuality", cachedQuality2.GetValueOrDefault(-1));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.TZJ;
			string message2 = "[画质预设刷新] 主机老存档画质非法，按机型默认画质处理";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("cachedQuality", cachedQuality.Value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("defaultQuality", cachedQuality2.Value);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			cachedQuality = cachedQuality2;
			isConsoleQualityMigration = true;
		}
		if (global == null)
		{
			bool flag3 = GameSettingsManager.Instance.CheckIsMatchQualityRecommend((EGameQualitySettingLevel)cachedQuality.Value, delegate(EFunction functionId)
			{
				if (isConsoleQualityMigration && GameSettingsManager.IsHiddenOnCurrentConsole(functionId))
				{
					return null;
				}
				object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(functionId).GetCallbackOrGlobalKey;
				if (getCallbackOrGlobalKey is ELocalStorageGlobalKey)
				{
					return LocalStorage.GetGlobal<int?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
				}
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.GameSettings;
				ELogAuthor author5 = ELogAuthor.TZJ;
				string message5 = "[画质预设刷新] 画质预设判断逻辑不适用当前配置";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("functionId", (int)functionId);
				instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return null;
			});
			flag3 = (flag3 && GameSettingsManager.Instance.CheckIsMatchFloatRenderRecommend((EGameQualitySettingLevel)cachedQuality.Value, delegate(EFunction functionId)
			{
				float? global2 = LocalStorage.GetGlobal<float?>((ELocalStorageGlobalKey)GameSettingsDefine.function2GameSettings.GetValueOrDefault(functionId).GetCallbackOrGlobalKey, null);
				if (global2 == null && functionId == EFunction.LOADINGRANGESCALELEVEL)
				{
					return GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(cachedQuality.Value);
				}
				return global2;
			}));
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.GameSettings;
			ELogAuthor author3 = ELogAuthor.TZJ;
			string message3 = "[画质预设刷新] 本地未保存是否使用画质预设，比较本地画质与推荐画质是否匹配";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isMatchRecommendQuality", flag3);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			GameSettingsManager.SetIsUsingQualityPreset(flag3);
			global = new bool?(flag3);
		}
		flag = global;
		flag2 = false;
		if (flag.GetValueOrDefault() == flag2 & flag != null)
		{
			return;
		}
		Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "[画质预设刷新] 应用推荐画质", default(ReadOnlySpan<ValueTuple<string, object>>));
		EGameQualitySettingLevel egameQualitySettingLevel = GameSettingsManager.Instance.ClampQualityByResourceTier((EGameQualitySettingLevel)cachedQuality.Value);
		DeviceRenderFeature? deviceRenderFeature2 = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(egameQualitySettingLevel);
		if (deviceRenderFeature2 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.GameSettings;
			ELogAuthor author4 = ELogAuthor.TZJ;
			string message4 = "[画质预设刷新] 推荐画质对应的渲染Feature不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("cachedQuality", (int)egameQualitySettingLevel);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		GameSettingsManager.Instance.AssignCacheValueByDeviceRenderFeature(deviceRenderFeature2.Value, EGameSettingsInitSourceType.InitOverride);
		GameSettingsManager.Instance.ClampImageDetailByResourceTier(EGameSettingsInitSourceType.InitOverride);
	}

	// Token: 0x06002865 RID: 10341 RVA: 0x000F9810 File Offset: 0x000F7A10
	private static bool IsHiddenOnCurrentConsole(EFunction functionId)
	{
		MenuConfig? valueOrNull = GameSettingsManager.Instance.ValidApplyConfigMap.GetValueOrNull(functionId);
		if (valueOrNull == null)
		{
			return false;
		}
		MenuConfig value = valueOrNull.Value;
		if ((!Info.Instance.IsPs5Platform() || value.Ps5Hide != 1) && (!Info.Instance.IsXSXPlatform() || value.XboxHide != 1))
		{
			return false;
		}
		if (value.SpecifyHideConsolesLength <= 0)
		{
			return true;
		}
		string consoleModelName = UKuroStaticLibrary.GetConsoleModelName();
		using (IEnumerator<string> enumerator = value.SpecifyHideConsolesIter().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == consoleModelName)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x000F98D4 File Offset: 0x000F7AD4
	public static void SetIsUsingQualityPreset(bool isUsingQualityPreset)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GameSettings;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "[画质预设刷新] 设置是否使用画质预设";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isUsingQualityPreset", isUsingQualityPreset);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsUsingQualityPreset, isUsingQualityPreset);
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x000F991C File Offset: 0x000F7B1C
	private bool IsVulkanCanaryTestDevice()
	{
		return false;
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x000F992C File Offset: 0x000F7B2C
	private void CacheOverrideForVulkan()
	{
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.Vulkan);
		if (valueOrDefault == null)
		{
			return;
		}
		int? currentValue = this.GetCurrentValue(EFunction.Vulkan, false, true);
		if (currentValue == null)
		{
			return;
		}
		valueOrDefault.CacheValue(currentValue.Value, EGameSettingsInitSourceType.InitOverride);
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x000F997C File Offset: 0x000F7B7C
	private void CacheOverrideForResetBrightness()
	{
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(EFunction.BRIGHTNESS);
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.BRIGHTNESS);
		if (valueOrNull == null || valueOrDefault == null)
		{
			return;
		}
		int optionsDefault = valueOrNull.Value.OptionsDefault;
		if (!LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.HasResetBrightness, false))
		{
			valueOrDefault.CacheValue(optionsDefault, EGameSettingsInitSourceType.InitOverride);
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.HasResetBrightness, true);
		}
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x000F99E8 File Offset: 0x000F7BE8
	private void CacheOverrideForNpcDensity()
	{
		if (UKuroStaticLibrary.IsLowMemoryDevice())
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.NPCDENSITY);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.CacheValue(0, EGameSettingsInitSourceType.LowMemoryOverride);
		}
	}

	// Token: 0x0600286B RID: 10347 RVA: 0x000F9A1C File Offset: 0x000F7C1C
	private void CacheOverrideForHdr()
	{
		if (!UKuroGISystem.CheckWindowsSupportHDR())
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.HDR);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.CacheValue(0, EGameSettingsInitSourceType.InitOverride);
		}
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x000F9A54 File Offset: 0x000F7C54
	private void CacheOverrideForMotorRoundJoyStick()
	{
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.MotorIsDynamicJoystick);
		GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.MotorMobileButtonLayout);
		GameSettingsInitValueSource valueOrDefault3 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.JoystickMode);
		if (valueOrDefault == null || valueOrDefault2 == null || valueOrDefault3 == null)
		{
			return;
		}
		if (LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.MotorMobileButtonLayout, 0) == 1)
		{
			return;
		}
		int? global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.JoystickMode, null);
		if (global == null)
		{
			return;
		}
		valueOrDefault.CacheValue(global.Value, EGameSettingsInitSourceType.InitOverride);
	}

	// Token: 0x0600286D RID: 10349 RVA: 0x000F9ADC File Offset: 0x000F7CDC
	private void CacheOverrideForMobileShadowQuality()
	{
		if (!Info.Instance.IsMobilePlatform())
		{
			return;
		}
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(EFunction.SHADOWQUALITY);
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.SHADOWQUALITY);
		if (valueOrNull == null || valueOrDefault == null)
		{
			return;
		}
		MenuConfig value = valueOrNull.Value;
		if (LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.HasResetMobileShadowQuality, false))
		{
			return;
		}
		int[] optionsValueArray = value.GetOptionsValueArray();
		bool flag = false;
		bool flag2 = false;
		if (optionsValueArray != null)
		{
			for (int i = 0; i < optionsValueArray.Length; i++)
			{
				if (optionsValueArray[i] == 2)
				{
					flag = true;
				}
				if (optionsValueArray[i] == 3)
				{
					flag2 = true;
				}
			}
		}
		if (!flag || !flag2)
		{
			Log.Instance.Error(ELogModule.GameSettings, ELogAuthor.TZJ, "移动端阴影质量重置逻辑不适用当前配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.ShadowQuality, null).GetValueOrDefault() == 3)
		{
			valueOrDefault.CacheValue(2, EGameSettingsInitSourceType.InitOverride);
		}
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.HasResetMobileShadowQuality, true);
	}

	// Token: 0x0600286E RID: 10350 RVA: 0x000F9BCC File Offset: 0x000F7DCC
	private unsafe void CacheOverrideForVulkanRefresh()
	{
		if (!Platform.Instance.IsAndroidPlatform() || !this.ValidInitValueSourceCache.ContainsKey(EFunction.Vulkan))
		{
			return;
		}
		int num = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.VulkanSettingRefreshRevision");
		int num2 = (UKismetSystemLibrary.GetConsoleVariableIntValue("r.Android.DefaultVulkanSetting") > 0) ? 1 : 0;
		string item = "ini";
		EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
		Dictionary<string, VulkanSettingConfig> dictionary = (cdnReturnConfigInfo != null) ? cdnReturnConfigInfo.VulkanSettings : null;
		string deviceProfileProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileProfileName();
		VulkanSettingConfig vulkanSettingConfig;
		if (dictionary != null && dictionary.TryGetValue(deviceProfileProfileName, out vulkanSettingConfig))
		{
			bool flag = vulkanSettingConfig != null;
			if (flag)
			{
				int? num3 = vulkanSettingConfig.DefaultValue;
				bool flag2;
				if (num3 != null)
				{
					int valueOrDefault = num3.GetValueOrDefault();
					if (valueOrDefault <= 1)
					{
						flag2 = true;
						goto IL_A4;
					}
				}
				flag2 = false;
				IL_A4:
				flag = flag2;
			}
			if (flag)
			{
				int? num3 = vulkanSettingConfig.Revision;
				if (num3 != null && num3.GetValueOrDefault() > 0)
				{
					if (vulkanSettingConfig.Revision.Value > num)
					{
						num = vulkanSettingConfig.Revision.Value;
						num2 = vulkanSettingConfig.DefaultValue.Value;
						item = "server";
						goto IL_1A4;
					}
					goto IL_1A4;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "Vulkan服务器配置无效，使用INI配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("profileName", deviceProfileProfileName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("defaultValue", (vulkanSettingConfig != null) ? vulkanSettingConfig.DefaultValue : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("revision", (vulkanSettingConfig != null) ? vulkanSettingConfig.Revision : null);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		IL_1A4:
		int valueOrDefault2 = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.VulkanRefreshRevision, null).GetValueOrDefault();
		if (valueOrDefault2 >= num)
		{
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.GameSettings;
		ELogAuthor author2 = ELogAuthor.WZ;
		string message2 = "Vulkan设置按版本号刷新为默认值";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("source", item);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("profileName", deviceProfileProfileName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("revision", valueOrDefault2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("targetRevision", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("defaultValue", num2);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
		this.ForceSaveValue(EFunction.Vulkan, num2);
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.VulkanRefreshRevision, num);
	}

	// Token: 0x0600286F RID: 10351 RVA: 0x000F9E6C File Offset: 0x000F806C
	private void CacheInitDataFromRenderFeatureOverride()
	{
		if (GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature() == null)
		{
			return;
		}
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.RayTracing);
		if (valueOrDefault == null)
		{
			return;
		}
		valueOrDefault.CacheValue(0, EGameSettingsInitSourceType.RenderFeatureDefaultConfigOverride);
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x000F9EB0 File Offset: 0x000F80B0
	private bool IsLocalStorageValueValid(EFunction functionId, double value)
	{
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(functionId);
		if (valueOrNull == null || valueOrNull.Value.SetType != 2)
		{
			return true;
		}
		int[] optionsValueArray = valueOrNull.Value.GetOptionsValueArray();
		if (optionsValueArray == null)
		{
			return false;
		}
		for (int i = 0; i < optionsValueArray.Length; i++)
		{
			if ((double)optionsValueArray[i] == value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x000F9F14 File Offset: 0x000F8114
	private void CacheInitDataFromLocalStorage()
	{
		foreach (KeyValuePair<EFunction, GameSettingsInitValueSource> keyValuePair in this.ValidInitValueSourceCache)
		{
			EFunction efunction;
			GameSettingsInitValueSource gameSettingsInitValueSource;
			keyValuePair.Deconstruct(out efunction, out gameSettingsInitValueSource);
			EFunction efunction2 = efunction;
			GameSettingsInitValueSource gameSettingsInitValueSource2 = gameSettingsInitValueSource;
			object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(efunction2).GetCallbackOrGlobalKey;
			if (getCallbackOrGlobalKey is ELocalStorageGlobalKey)
			{
				if (this.IsFloatSetting(efunction2))
				{
					float? global = LocalStorage.GetGlobal<float?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
					if (global != null && this.IsLocalStorageValueValid(efunction2, (double)global.Value))
					{
						gameSettingsInitValueSource2.CacheValue(global.Value, EGameSettingsInitSourceType.LocalStorage);
					}
				}
				else
				{
					int? global2 = LocalStorage.GetGlobal<int?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
					if (global2 != null && this.IsLocalStorageValueValid(efunction2, (double)global2.Value))
					{
						gameSettingsInitValueSource2.CacheValue(global2.Value, EGameSettingsInitSourceType.LocalStorage);
					}
				}
			}
		}
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x000FA02C File Offset: 0x000F822C
	public void RefreshLoginOverrideCache()
	{
		foreach (KeyValuePair<EFunction, GameSettingsInitValueSource> keyValuePair in this.ValidInitValueSourceCache)
		{
			EFunction key = keyValuePair.Key;
			GameSettingsInitValueSource value = keyValuePair.Value;
			object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(key).GetCallbackOrGlobalKey;
			if (getCallbackOrGlobalKey is ELocalStorageGlobalKey)
			{
				if (this.IsFloatSetting(key))
				{
					float? global = LocalStorage.GetGlobal<float?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
					if (global != null && this.IsLocalStorageValueValid(key, (double)global.Value))
					{
						value.RefreshCacheValue(global.Value, EGameSettingsInitSourceType.LoginOverride);
					}
				}
				else
				{
					int? global2 = LocalStorage.GetGlobal<int?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
					if (global2 != null && this.IsLocalStorageValueValid(key, (double)global2.Value))
					{
						value.RefreshCacheValue(global2.Value, EGameSettingsInitSourceType.LoginOverride);
					}
				}
			}
		}
		Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.TZJ, "已刷新LoginOverride", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06002873 RID: 10355 RVA: 0x000FA164 File Offset: 0x000F8364
	public void OverrideLoginCacheValue(EFunction id, int value)
	{
		GameSettingsInitValueSource gameSettingsInitValueSource;
		if (!this.ValidInitValueSourceCache.TryGetValue(id, out gameSettingsInitValueSource))
		{
			return;
		}
		gameSettingsInitValueSource.RefreshCacheValue(value, EGameSettingsInitSourceType.LoginOverride);
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x000FA190 File Offset: 0x000F8390
	public void OverrideLoginCacheValue(EFunction id, float value)
	{
		GameSettingsInitValueSource gameSettingsInitValueSource;
		if (!this.ValidInitValueSourceCache.TryGetValue(id, out gameSettingsInitValueSource))
		{
			return;
		}
		gameSettingsInitValueSource.RefreshCacheValue(value, EGameSettingsInitSourceType.LoginOverride);
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x000FA1BC File Offset: 0x000F83BC
	public static bool HasImageQualityOrSubSettingLoginOverride()
	{
		GameSettingsInitValueSource valueOrDefault = GameSettingsManager.Instance.ValidInitValueSourceCache.GetValueOrDefault(EFunction.IMAGEQUALITY);
		if (valueOrDefault != null && valueOrDefault.HasCachedSource(EGameSettingsInitSourceType.LoginOverride))
		{
			return true;
		}
		EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
		if (recommendQualityLv == null)
		{
			return false;
		}
		DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(recommendQualityLv.Value);
		if (deviceRenderFeature == null)
		{
			return false;
		}
		foreach (KeyValuePair<EFunction, int> keyValuePair in GameSettingsDeviceRender.Instance.GetOtherChangedValue(deviceRenderFeature.Value))
		{
			EFunction efunction;
			int num;
			keyValuePair.Deconstruct(out efunction, out num);
			EFunction key = efunction;
			GameSettingsInitValueSource valueOrDefault2 = GameSettingsManager.Instance.ValidInitValueSourceCache.GetValueOrDefault(key);
			if (valueOrDefault2 != null && valueOrDefault2.HasCachedSource(EGameSettingsInitSourceType.LoginOverride))
			{
				return true;
			}
		}
		foreach (KeyValuePair<EFunction, float> keyValuePair2 in GameSettingsDeviceRender.Instance.GetOtherChangedFloatValue(deviceRenderFeature.Value))
		{
			EFunction efunction;
			float num2;
			keyValuePair2.Deconstruct(out efunction, out num2);
			EFunction key2 = efunction;
			GameSettingsInitValueSource valueOrDefault3 = GameSettingsManager.Instance.ValidInitValueSourceCache.GetValueOrDefault(key2);
			if (valueOrDefault3 != null && valueOrDefault3.HasCachedSource(EGameSettingsInitSourceType.LoginOverride))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x000FA320 File Offset: 0x000F8520
	private void CacheInitDataFrom1Dot3()
	{
		int? global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.TextLanguage, null);
		if (global != null)
		{
			GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.TEXTLANGUAGE);
			if (valueOrDefault != null)
			{
				valueOrDefault.CacheValue(global.Value, EGameSettingsInitSourceType.From1Dot3);
			}
		}
		global = LocalStorage.GetGlobal<int?>(ELocalStorageGlobalKey.VoiceLanguage, null);
		if (global != null)
		{
			GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.VOICELANGUAGE);
			if (valueOrDefault2 == null)
			{
				return;
			}
			valueOrDefault2.CacheValue(global.Value, EGameSettingsInitSourceType.From1Dot3);
		}
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x000FA3AC File Offset: 0x000F85AC
	private void CacheInitDataFrom1Dot2()
	{
		Dictionary<int, double> dictionary = LauncherGameSettingLib.Instance.LoadPlayMenuInfo();
		if (dictionary == null)
		{
			return;
		}
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.MASTERVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.VOICEVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.MUSICVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.SFXVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.AMBVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.UIVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot2);
		int? currentValue = this.GetCurrentValue(EFunction.HIGHESTFPS, true, true);
		if (currentValue != null)
		{
			int? num = currentValue;
			int num2 = 10;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.HIGHESTFPS);
				if (valueOrDefault == null)
				{
					return;
				}
				valueOrDefault.CacheValue(GameSettingsDeviceRender.Instance.GetFrameIndexByList(currentValue.Value), EGameSettingsInitSourceType.From1Dot2);
			}
		}
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x000FA45C File Offset: 0x000F865C
	private void CacheInitDataFrom1Dot1()
	{
		Dictionary<EFunction, double?> dictionary = new Dictionary<EFunction, double?>();
		GameQualityData global = LocalStorage.GetGlobal<GameQualityData>(ELocalStorageGlobalKey.GameQualitySetting, null);
		if (global != null)
		{
			Dictionary<EFunction, double?> dictionary2 = dictionary;
			EFunction key = EFunction.IMAGEQUALITY;
			int? num = global.KeyQualityLevel;
			double? value;
			if (num == null)
			{
				double? num2 = null;
				value = num2;
			}
			else
			{
				value = new double?((double)num.GetValueOrDefault());
			}
			dictionary2[key] = value;
			Dictionary<EFunction, double?> dictionary3 = dictionary;
			EFunction key2 = EFunction.DISPLAYMODE;
			num = global.KeyPcWindowMode;
			double? value2;
			if (num == null)
			{
				double? num2 = null;
				value2 = num2;
			}
			else
			{
				value2 = new double?((double)num.GetValueOrDefault());
			}
			dictionary3[key2] = value2;
			Dictionary<EFunction, double?> dictionary4 = dictionary;
			EFunction key3 = EFunction.BRIGHTNESS;
			num = global.KeyBrightness;
			double? value3;
			if (num == null)
			{
				double? num2 = null;
				value3 = num2;
			}
			else
			{
				value3 = new double?((double)num.GetValueOrDefault());
			}
			dictionary4[key3] = value3;
			Dictionary<EFunction, double?> dictionary5 = dictionary;
			EFunction key4 = EFunction.FSR;
			num = global.KeyFsrEnable;
			double? value4;
			if (num == null)
			{
				double? num2 = null;
				value4 = num2;
			}
			else
			{
				value4 = new double?((double)num.GetValueOrDefault());
			}
			dictionary5[key4] = value4;
			dictionary[EFunction.XESS] = new double?((double)global.KeyXessEnable.GetValueOrDefault(1));
			dictionary[EFunction.XESS_QUALITY] = new double?((double)global.KeyXessQuality.GetValueOrDefault(2));
			Dictionary<EFunction, double?> dictionary6 = dictionary;
			EFunction key5 = EFunction.METALFX;
			num = global.KeyMetalFxEnable;
			double? value5;
			if (num == null)
			{
				double? num2 = null;
				value5 = num2;
			}
			else
			{
				value5 = new double?((double)num.GetValueOrDefault());
			}
			dictionary6[key5] = value5;
			dictionary[EFunction.IRX] = new double?((double)global.KeyIrxEnable.GetValueOrDefault(1));
			Dictionary<EFunction, double?> dictionary7 = dictionary;
			EFunction key6 = EFunction.HorizontalViewSensitivity;
			num = global.HorizontalViewSensitivity;
			double? value6;
			if (num == null)
			{
				double? num2 = null;
				value6 = num2;
			}
			else
			{
				value6 = new double?((double)num.GetValueOrDefault());
			}
			dictionary7[key6] = value6;
			Dictionary<EFunction, double?> dictionary8 = dictionary;
			EFunction key7 = EFunction.VerticalViewSensitivity;
			num = global.VerticalViewSensitivity;
			double? value7;
			if (num == null)
			{
				double? num2 = null;
				value7 = num2;
			}
			else
			{
				value7 = new double?((double)num.GetValueOrDefault());
			}
			dictionary8[key7] = value7;
			Dictionary<EFunction, double?> dictionary9 = dictionary;
			EFunction key8 = EFunction.AimHorizontalViewSensitivity;
			num = global.AimHorizontalViewSensitivity;
			double? value8;
			if (num == null)
			{
				double? num2 = null;
				value8 = num2;
			}
			else
			{
				value8 = new double?((double)num.GetValueOrDefault());
			}
			dictionary9[key8] = value8;
			Dictionary<EFunction, double?> dictionary10 = dictionary;
			EFunction key9 = EFunction.AimVerticalViewSensitivity;
			num = global.AimVerticalViewSensitivity;
			double? value9;
			if (num == null)
			{
				double? num2 = null;
				value9 = num2;
			}
			else
			{
				value9 = new double?((double)num.GetValueOrDefault());
			}
			dictionary10[key9] = value9;
			Dictionary<EFunction, double?> dictionary11 = dictionary;
			EFunction key10 = EFunction.MobileHorizontalViewSensitivity;
			num = global.MobileHorizontalViewSensitivity;
			double? value10;
			if (num == null)
			{
				double? num2 = null;
				value10 = num2;
			}
			else
			{
				value10 = new double?((double)num.GetValueOrDefault());
			}
			dictionary11[key10] = value10;
			Dictionary<EFunction, double?> dictionary12 = dictionary;
			EFunction key11 = EFunction.MobileVerticalViewSensitivity;
			num = global.MobileVerticalViewSensitivity;
			double? value11;
			if (num == null)
			{
				double? num2 = null;
				value11 = num2;
			}
			else
			{
				value11 = new double?((double)num.GetValueOrDefault());
			}
			dictionary12[key11] = value11;
			Dictionary<EFunction, double?> dictionary13 = dictionary;
			EFunction key12 = EFunction.MobileAimHorizontalViewSensitivity;
			num = global.MobileAimHorizontalViewSensitivity;
			double? value12;
			if (num == null)
			{
				double? num2 = null;
				value12 = num2;
			}
			else
			{
				value12 = new double?((double)num.GetValueOrDefault());
			}
			dictionary13[key12] = value12;
			Dictionary<EFunction, double?> dictionary14 = dictionary;
			EFunction key13 = EFunction.MobileAimVerticalViewSensitivity;
			num = global.MobileAimVerticalViewSensitivity;
			double? value13;
			if (num == null)
			{
				double? num2 = null;
				value13 = num2;
			}
			else
			{
				value13 = new double?((double)num.GetValueOrDefault());
			}
			dictionary14[key13] = value13;
			Dictionary<EFunction, double?> dictionary15 = dictionary;
			EFunction key14 = EFunction.CommonSpringArmLength;
			num = global.CommonSpringArmLength;
			double? value14;
			if (num == null)
			{
				double? num2 = null;
				value14 = num2;
			}
			else
			{
				value14 = new double?((double)num.GetValueOrDefault());
			}
			dictionary15[key14] = value14;
			Dictionary<EFunction, double?> dictionary16 = dictionary;
			EFunction key15 = EFunction.FightSpringArmLength;
			num = global.FightSpringArmLength;
			double? value15;
			if (num == null)
			{
				double? num2 = null;
				value15 = num2;
			}
			else
			{
				value15 = new double?((double)num.GetValueOrDefault());
			}
			dictionary16[key15] = value15;
			Dictionary<EFunction, double?> dictionary17 = dictionary;
			EFunction key16 = EFunction.ResetFocusEnable;
			num = global.IsResetFocusEnable;
			double? value16;
			if (num == null)
			{
				double? num2 = null;
				value16 = num2;
			}
			else
			{
				value16 = new double?((double)num.GetValueOrDefault());
			}
			dictionary17[key16] = value16;
			Dictionary<EFunction, double?> dictionary18 = dictionary;
			EFunction key17 = EFunction.IsSidestepCameraEnable;
			num = global.IsSidestepCameraEnable;
			double? value17;
			if (num == null)
			{
				double? num2 = null;
				value17 = num2;
			}
			else
			{
				value17 = new double?((double)num.GetValueOrDefault());
			}
			dictionary18[key17] = value17;
			Dictionary<EFunction, double?> dictionary19 = dictionary;
			EFunction key18 = EFunction.IsSoftLockCameraEnable;
			num = global.IsSoftLockCameraEnable;
			double? value18;
			if (num == null)
			{
				double? num2 = null;
				value18 = num2;
			}
			else
			{
				value18 = new double?((double)num.GetValueOrDefault());
			}
			dictionary19[key18] = value18;
			Dictionary<EFunction, double?> dictionary20 = dictionary;
			EFunction key19 = EFunction.JoystickShakeStrength;
			num = global.JoystickShakeStrength;
			double? value19;
			if (num == null)
			{
				double? num2 = null;
				value19 = num2;
			}
			else
			{
				value19 = new double?((double)num.GetValueOrDefault());
			}
			dictionary20[key19] = value19;
			Dictionary<EFunction, double?> dictionary21 = dictionary;
			EFunction key20 = EFunction.JoystickShakeType;
			num = global.JoystickShakeType;
			double? value20;
			if (num == null)
			{
				double? num2 = null;
				value20 = num2;
			}
			else
			{
				value20 = new double?((double)num.GetValueOrDefault());
			}
			dictionary21[key20] = value20;
			Dictionary<EFunction, double?> dictionary22 = dictionary;
			EFunction key21 = EFunction.JoystickMode;
			num = global.JoystickMode;
			double? value21;
			if (num == null)
			{
				double? num2 = null;
				value21 = num2;
			}
			else
			{
				value21 = new double?((double)num.GetValueOrDefault());
			}
			dictionary22[key21] = value21;
			Dictionary<EFunction, double?> dictionary23 = dictionary;
			EFunction key22 = EFunction.SkillButtonMode;
			num = global.IsAutoSwitchSkillButtonMode;
			double? value22;
			if (num == null)
			{
				double? num2 = null;
				value22 = num2;
			}
			else
			{
				value22 = new double?((double)num.GetValueOrDefault());
			}
			dictionary23[key22] = value22;
			Dictionary<EFunction, double?> dictionary24 = dictionary;
			EFunction key23 = EFunction.AimAssist;
			num = global.AimAssistEnable;
			double? value23;
			if (num == null)
			{
				double? num2 = null;
				value23 = num2;
			}
			else
			{
				value23 = new double?((double)num.GetValueOrDefault());
			}
			dictionary24[key23] = value23;
			Dictionary<EFunction, double?> dictionary25 = dictionary;
			EFunction key24 = EFunction.HorizontalViewRevert;
			num = global.HorizontalViewRevert;
			double? value24;
			if (num == null)
			{
				double? num2 = null;
				value24 = num2;
			}
			else
			{
				value24 = new double?((double)num.GetValueOrDefault());
			}
			dictionary25[key24] = value24;
			Dictionary<EFunction, double?> dictionary26 = dictionary;
			EFunction key25 = EFunction.VerticalViewRevert;
			num = global.VerticalViewRevert;
			double? value25;
			if (num == null)
			{
				double? num2 = null;
				value25 = num2;
			}
			else
			{
				value25 = new double?((double)num.GetValueOrDefault());
			}
			dictionary26[key25] = value25;
			if (global.WalkOrRunRate != null)
			{
				GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.WalkOrRunRate);
				if (valueOrDefault != null)
				{
					valueOrDefault.CacheValue(global.WalkOrRunRate.Value, EGameSettingsInitSourceType.From1Dot1);
				}
			}
			Dictionary<EFunction, double?> dictionary27 = dictionary;
			EFunction key26 = EFunction.CameraShakeStrength;
			float? global2 = LocalStorage.GetGlobal<float?>(ELocalStorageGlobalKey.CameraShakeStrength, null);
			double? value26;
			if (global2 == null)
			{
				double? num2 = null;
				value26 = num2;
			}
			else
			{
				value26 = new double?((double)global2.GetValueOrDefault());
			}
			dictionary27[key26] = value26;
		}
		Dictionary<int, double> global3 = LocalStorage.GetGlobal<Dictionary<int, double>>(ELocalStorageGlobalKey.MenuData, null);
		if (global3 != null)
		{
			dictionary[EFunction.CameraShakeStrength] = global3.GetValueOrNull(93);
			dictionary[EFunction.MASTERVOLUMEFUNCTION] = global3.GetValueOrNull(1);
			dictionary[EFunction.VOICEVOLUMEFUNCTION] = global3.GetValueOrNull(2);
			dictionary[EFunction.MUSICVOLUMEFUNCTION] = global3.GetValueOrNull(3);
			dictionary[EFunction.SFXVOLUMEFUNCTION] = global3.GetValueOrNull(4);
			dictionary[EFunction.AMBVOLUMEFUNCTION] = global3.GetValueOrNull(69);
			dictionary[EFunction.UIVOLUMEFUNCTION] = global3.GetValueOrNull(70);
			dictionary[EFunction.RESOLUTION] = global3.GetValueOrNull(6);
			dictionary[EFunction.TEXTLANGUAGE] = global3.GetValueOrNull(51);
			dictionary[EFunction.VOICELANGUAGE] = global3.GetValueOrNull(52);
			dictionary[EFunction.ADVICESETTING] = global3.GetValueOrNull(59);
			dictionary[EFunction.GENDERSETTING] = global3.GetValueOrNull(88);
		}
		foreach (KeyValuePair<EFunction, double?> keyValuePair in dictionary)
		{
			double? num2;
			EFunction efunction;
			keyValuePair.Deconstruct(out efunction, out num2);
			EFunction key27 = efunction;
			double? num3 = num2;
			if (num3 != null)
			{
				GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(key27);
				if (valueOrDefault2 != null)
				{
					valueOrDefault2.CacheValue(num3.Value, EGameSettingsInitSourceType.From1Dot1);
				}
			}
		}
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x000FAB50 File Offset: 0x000F8D50
	private void CacheInitDataFrom1Dot0()
	{
		Dictionary<int, double> dictionary = LauncherGameSettingLib.Instance.LoadPlayMenuInfo();
		if (dictionary == null)
		{
			return;
		}
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.CameraShakeStrength, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.MASTERVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.VOICEVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.MUSICVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.SFXVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.AMBVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.UIVOLUMEFUNCTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.RESOLUTION, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.TEXTLANGUAGE, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.VOICELANGUAGE, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.ADVICESETTING, EGameSettingsInitSourceType.From1Dot0);
		this.AssignCacheValueByPlayerMenuInfo(dictionary, EFunction.GENDERSETTING, EGameSettingsInitSourceType.From1Dot0);
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x000FABE0 File Offset: 0x000F8DE0
	private void CacheInitDataFromRenderFeatureDefault()
	{
		DeviceRenderFeature? defaultDeviceRenderFeature = GameSettingsDeviceRender.Instance.GetDefaultDeviceRenderFeature();
		if (defaultDeviceRenderFeature == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "当前机型没有设置默认画质";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("当前机型", GameSettingsDeviceRender.Instance.DeviceType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AssignCacheValueByDeviceRenderFeature(defaultDeviceRenderFeature.Value, EGameSettingsInitSourceType.RenderFeatureDefaultConfig);
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000FAC4C File Offset: 0x000F8E4C
	private void CacheInitDataFromCustomOverrideDefault()
	{
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.KeyboardLockEnemyMode);
		if (valueOrDefault != null)
		{
			valueOrDefault.CacheValue(1, EGameSettingsInitSourceType.CustomOverrideDefault);
		}
		GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.GamepadLockEnemyMode);
		if (valueOrDefault2 != null)
		{
			valueOrDefault2.CacheValue(1, EGameSettingsInitSourceType.CustomOverrideDefault);
		}
		int num = 0;
		MenuConfig? valueOrNull = this.ValidApplyConfigMap.GetValueOrNull(EFunction.VegetationDither);
		if (valueOrNull != null)
		{
			num = valueOrNull.Value.OptionsDefault;
		}
		GameSettingsInitValueSource valueOrDefault3 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.VegetationDither);
		if (valueOrDefault3 == null)
		{
			return;
		}
		valueOrDefault3.CacheValue(GameSettingsDeviceRender.Instance.ShouldOverrideVegetationDitherDefaultValue() ? 0 : num, EGameSettingsInitSourceType.CustomOverrideDefault);
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x000FACFC File Offset: 0x000F8EFC
	private void CacheInitDataFromUserSettingIni()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		int value = (gameUserSettings == null) ? 2 : GameSettingsDeviceRender.Instance.GetResolutionIndexByList(gameUserSettings.GetScreenResolution());
		GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.RESOLUTION);
		if (valueOrDefault != null)
		{
			valueOrDefault.CacheValue(value, EGameSettingsInitSourceType.UserSettingIni);
		}
		TEnumAsByte<EWindowMode>? tenumAsByte = (gameUserSettings != null) ? new TEnumAsByte<EWindowMode>?(gameUserSettings.GetFullscreenMode()) : null;
		if (tenumAsByte != null)
		{
			switch (tenumAsByte.Value)
			{
			case EWindowMode.Fullscreen:
			{
				GameSettingsInitValueSource valueOrDefault2 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.DISPLAYMODE);
				if (valueOrDefault2 != null)
				{
					valueOrDefault2.CacheValue(0, EGameSettingsInitSourceType.UserSettingIni);
				}
				break;
			}
			case EWindowMode.WindowedFullscreen:
			{
				GameSettingsInitValueSource valueOrDefault3 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.DISPLAYMODE);
				if (valueOrDefault3 != null)
				{
					valueOrDefault3.CacheValue(0, EGameSettingsInitSourceType.UserSettingIni);
				}
				break;
			}
			case EWindowMode.Windowed:
			{
				GameSettingsInitValueSource valueOrDefault4 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.DISPLAYMODE);
				if (valueOrDefault4 != null)
				{
					valueOrDefault4.CacheValue(1, EGameSettingsInitSourceType.UserSettingIni);
				}
				break;
			}
			}
		}
		LanguageSystem.Instance.FirstTimeSetLanguage(GlobalData.World);
		int languageIdByCode = this.GetLanguageIdByCode(LanguageSystem.Instance.PackageLanguage);
		ESpeechType speechTypeByLanguageType = this.GetSpeechTypeByLanguageType(languageIdByCode);
		GameSettingsInitValueSource valueOrDefault5 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.TEXTLANGUAGE);
		if (valueOrDefault5 != null)
		{
			valueOrDefault5.CacheValue(languageIdByCode, EGameSettingsInitSourceType.UserSettingIni);
		}
		GameSettingsInitValueSource valueOrDefault6 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.VOICELANGUAGE);
		if (valueOrDefault6 != null)
		{
			valueOrDefault6.CacheValue((int)speechTypeByLanguageType, EGameSettingsInitSourceType.UserSettingIni);
		}
		int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Android.VulkanSetting");
		GameSettingsInitValueSource valueOrDefault7 = this.ValidInitValueSourceCache.GetValueOrDefault(EFunction.Vulkan);
		if (valueOrDefault7 == null)
		{
			return;
		}
		valueOrDefault7.CacheValue((((consoleVariableIntValue >= 0) ? consoleVariableIntValue : UKismetSystemLibrary.GetConsoleVariableIntValue("r.Android.DefaultVulkanSetting")) > 0) ? 1 : 0, EGameSettingsInitSourceType.UserSettingIni);
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x000FAEA4 File Offset: 0x000F90A4
	private void CacheInitDataFromConfigDefault()
	{
		foreach (KeyValuePair<EFunction, MenuConfig> keyValuePair in this.ValidApplyConfigMap)
		{
			EFunction efunction;
			MenuConfig menuConfig;
			keyValuePair.Deconstruct(out efunction, out menuConfig);
			EFunction key = efunction;
			MenuConfig menuConfig2 = menuConfig;
			OneOf<int, float, double>? oneOf = null;
			switch (menuConfig2.SetType)
			{
			case 1:
				oneOf = new OneOf<int, float, double>?(menuConfig2.SliderDefault);
				break;
			case 2:
				oneOf = new OneOf<int, float, double>?(menuConfig2.OptionsDefault);
				break;
			case 4:
				oneOf = new OneOf<int, float, double>?(menuConfig2.OptionsDefault);
				break;
			case 5:
				oneOf = new OneOf<int, float, double>?(menuConfig2.OptionsDefault);
				break;
			}
			if (oneOf != null)
			{
				GameSettingsInitValueSource valueOrDefault = this.ValidInitValueSourceCache.GetValueOrDefault(key);
				if (valueOrDefault != null)
				{
					valueOrDefault.CacheValue(oneOf.Value, EGameSettingsInitSourceType.GameSettingDefaultConfig);
				}
			}
		}
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x000FAFB4 File Offset: 0x000F91B4
	private void CacheOverrideForLoadingRangeScale()
	{
		GameSettingsInitValueSource gameSettingsInitValueSource;
		if (!this.ValidInitValueSourceCache.TryGetValue(EFunction.LOADINGRANGESCALELEVEL, out gameSettingsInitValueSource))
		{
			return;
		}
		OneOf<int, float, double>? initValue = this.GetInitValue(EFunction.IMAGEQUALITY, false);
		if (initValue == null)
		{
			return;
		}
		float? renderDistanceRecommendation = GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(GameSettingsManager.OneOfToInt(initValue.Value));
		if (renderDistanceRecommendation == null)
		{
			return;
		}
		gameSettingsInitValueSource.RefreshCacheValue(renderDistanceRecommendation.Value, EGameSettingsInitSourceType.RenderFeatureDefaultConfigOverride);
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x000FB020 File Offset: 0x000F9220
	private int GetLanguageIdByCode(string code)
	{
		global::LanguageDefine languageDefineByCode = LanguageSystem.Instance.GetLanguageDefineByCode(code);
		if (languageDefineByCode == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Menu;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "LanguageSystem 未定义此语种";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("非法值", code);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return this.GetLanguageIdByCode("en");
		}
		return languageDefineByCode.LanguageType;
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x000FB075 File Offset: 0x000F9275
	private ESpeechType GetSpeechTypeByLanguageType(int languageType)
	{
		return LanguageSystem.Instance.GetSpeechTypeByLanguageType((ELanguageType)languageType);
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x000FB082 File Offset: 0x000F9282
	public bool IsValid(EFunction id, bool allowRebuild = true)
	{
		return (allowRebuild || this.ValidApplyConfigMapInternal != null) && this.ValidApplyConfigMap.ContainsKey(id);
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x000FB0A0 File Offset: 0x000F92A0
	public void Initialize()
	{
		this.ValidInitValueSourceCache.Clear();
		foreach (KeyValuePair<EFunction, MenuConfig> keyValuePair in this.ValidApplyConfigMap)
		{
			EFunction efunction;
			MenuConfig menuConfig;
			keyValuePair.Deconstruct(out efunction, out menuConfig);
			EFunction efunction2 = efunction;
			MenuConfig menuCfg = menuConfig;
			if (!this.IsButtonSetting(menuCfg))
			{
				this.ValidInitValueSourceCache[efunction2] = new GameSettingsInitValueSource(efunction2);
			}
		}
		this.CacheInitDataFromOverride();
		this.CacheInitDataFromLocalStorage();
		this.CacheInitDataFrom1Dot3();
		this.CacheInitDataFrom1Dot2();
		this.CacheInitDataFrom1Dot1();
		this.CacheInitDataFrom1Dot0();
		this.CacheInitDataFromRenderFeatureOverride();
		this.CacheInitDataFromRenderFeatureDefault();
		this.CacheInitDataFromCustomOverrideDefault();
		this.CacheInitDataFromUserSettingIni();
		this.CacheInitDataFromConfigDefault();
		this.CacheOverrideForLoadingRangeScale();
		if (this.IsValid(EFunction.DISPLAYMODE, true) && this.IsValid(EFunction.RESOLUTION, true))
		{
			OneOf<int, float, double>? initValue = this.GetInitValue(EFunction.DISPLAYMODE, false);
			if (initValue != null)
			{
				this.ApplyValue(EFunction.DISPLAYMODE, (T1)initValue.Value, EGameSettingsApplyReason.WhenGameStart);
			}
			OneOf<int, float, double>? initValue2 = this.GetInitValue(EFunction.RESOLUTION, true);
			if (initValue2 != null && initValue != null && (T1)initValue.Value == 1)
			{
				this.ApplyValue(EFunction.RESOLUTION, (T1)initValue2.Value, EGameSettingsApplyReason.WhenGameStart);
			}
		}
		OneOf<int, float, double>? initValue3 = this.GetInitValue(EFunction.TEXTLANGUAGE, true);
		if (this.IsValid(EFunction.TEXTLANGUAGE, true) && initValue3 != null)
		{
			this.ApplyValue(EFunction.TEXTLANGUAGE, (T1)initValue3.Value, EGameSettingsApplyReason.WhenGameStart);
		}
		OneOf<int, float, double>? initValue4 = this.GetInitValue(EFunction.VOICELANGUAGE, true);
		if (this.IsValid(EFunction.VOICELANGUAGE, true) && initValue4 != null)
		{
			this.ApplyValue(EFunction.VOICELANGUAGE, (T1)initValue4.Value, EGameSettingsApplyReason.WhenGameStart);
		}
		if (this.IsValid(EFunction.Vulkan, true) && !LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.VulkanChangeFlag, false) && this.IsVulkanCanaryTestDevice())
		{
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WZ, "通过灰度测试的设备，强制开启Vulkan", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ForceSaveValue(EFunction.Vulkan, 1);
			this.ForceApplyValue(EFunction.Vulkan, 1, EGameSettingsApplyReason.WhenGameStart);
		}
		if (Info.Instance.IsPcPlatform() && !GameSettingsDeviceRender.Instance.IsShowRayTracingSetting())
		{
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WZ, "不满足光追条件，强制关闭光追", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ForceSaveValue(EFunction.RayTracing, 0);
			this.ForceSaveValue(EFunction.RayTracedReflection, 0);
			this.ForceSaveValue(EFunction.RayTracedGI, 0);
			this.ForceSaveValue(EFunction.RayTracedShadow, 0);
			this.ForceApplyValue(EFunction.RayTracing, 0, EGameSettingsApplyReason.WhenGameStart);
			this.ForceApplyValue(EFunction.RayTracedReflection, 0, EGameSettingsApplyReason.WhenGameStart);
			this.ForceApplyValue(EFunction.RayTracedGI, 0, EGameSettingsApplyReason.WhenGameStart);
			this.ForceApplyValue(EFunction.RayTracedShadow, 0, EGameSettingsApplyReason.WhenGameStart);
		}
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x000FB35C File Offset: 0x000F955C
	public void HandleInitDataOnOpenLoading()
	{
		this.CacheOverrideForRecommendImageQuality();
		this.CacheOverrideForVulkan();
		this.CacheOverrideForLoadingRangeScale();
		foreach (KeyValuePair<EFunction, GameSettingsInitValueSource> keyValuePair in this.ValidInitValueSourceCache)
		{
			EFunction efunction;
			GameSettingsInitValueSource gameSettingsInitValueSource;
			keyValuePair.Deconstruct(out efunction, out gameSettingsInitValueSource);
			EFunction id = efunction;
			OneOf<int, float, double>? initValue = this.GetInitValue(id, true);
			if (initValue != null)
			{
				if (this.IsFloatSetting(id))
				{
					this.SaveValueFloat(id, GameSettingsManager.OneOfToFloat(initValue.Value));
				}
				else
				{
					this.SaveValue(id, GameSettingsManager.OneOfToInt(initValue.Value));
				}
			}
		}
		foreach (KeyValuePair<EFunction, GameSettingsInitValueSource> keyValuePair in this.ValidInitValueSourceCache)
		{
			EFunction efunction;
			GameSettingsInitValueSource gameSettingsInitValueSource;
			keyValuePair.Deconstruct(out efunction, out gameSettingsInitValueSource);
			EFunction efunction2 = efunction;
			if (efunction2 != EFunction.LOADINGRANGESCALELEVEL)
			{
				OneOf<int, float, double>? initValue2 = this.GetInitValue(efunction2, true);
				if (initValue2 != null)
				{
					if (this.IsFloatSetting(efunction2))
					{
						this.HandleValueChangeFloat(efunction2, GameSettingsManager.OneOfToFloat(initValue2.Value), EGameSettingsApplyReason.WhenLoading);
					}
					else
					{
						this.HandleValueChange(efunction2, GameSettingsManager.OneOfToInt(initValue2.Value), EGameSettingsApplyReason.WhenLoading);
					}
				}
			}
		}
		if (this.ValidInitValueSourceCache.ContainsKey(EFunction.LOADINGRANGESCALELEVEL))
		{
			OneOf<int, float, double>? initValue3 = this.GetInitValue(EFunction.LOADINGRANGESCALELEVEL, true);
			if (initValue3 != null)
			{
				this.HandleValueChangeFloat(EFunction.LOADINGRANGESCALELEVEL, GameSettingsManager.OneOfToFloat(initValue3.Value), EGameSettingsApplyReason.WhenLoading);
			}
		}
		this.InitializeQualityPresetStateIfMissing();
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x000FB4F0 File Offset: 0x000F96F0
	[NullableContext(0)]
	private static int OneOfToInt(OneOf<int, float, double> value)
	{
		if (value.IsT1)
		{
			return value.AsT1;
		}
		if (value.IsT2)
		{
			return (int)value.AsT2;
		}
		if (value.IsT3)
		{
			return (int)value.AsT3;
		}
		return 0;
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x000FB528 File Offset: 0x000F9728
	[NullableContext(0)]
	private static float OneOfToFloat(OneOf<int, float, double> value)
	{
		if (value.IsT1)
		{
			return (float)value.AsT1;
		}
		if (value.IsT2)
		{
			return value.AsT2;
		}
		if (value.IsT3)
		{
			return (float)value.AsT3;
		}
		return 0f;
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x000FB564 File Offset: 0x000F9764
	public bool IsFloatSetting(EFunction id)
	{
		IGameSettings valueOrDefault = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id);
		return valueOrDefault != null && valueOrDefault.ValueType == EGameSettingsValueType.Float;
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x000FB57F File Offset: 0x000F977F
	public void Clear()
	{
		this.ValidApplyConfigMapInternal = null;
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x000FB588 File Offset: 0x000F9788
	public int? GetCurrentValue(EFunction id, bool isLog = true, bool allowRebuild = true)
	{
		if (!this.IsValid(id, allowRebuild))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【GetCurrent】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IGameSettings valueOrDefault = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id);
		if (valueOrDefault == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "【GetCurrent】当前选项未能获取IGameSettings句柄";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		object getCallbackOrGlobalKey = valueOrDefault.GetCallbackOrGlobalKey;
		Func<int> func = getCallbackOrGlobalKey as Func<int>;
		if (func != null)
		{
			return new int?(func());
		}
		int? global = LocalStorage.GetGlobal<int?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
		if (global == null)
		{
			return null;
		}
		return new int?(global.Value);
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x000FB678 File Offset: 0x000F9878
	private void InitializeQualityPresetStateIfMissing()
	{
		if (LocalStorage.GetGlobal<bool?>(ELocalStorageGlobalKey.IsUsingQualityPreset, null) != null)
		{
			return;
		}
		int? currentValue = this.GetCurrentValue(EFunction.IMAGEQUALITY, false, true);
		if (currentValue == null)
		{
			return;
		}
		EGameQualitySettingLevel value = (EGameQualitySettingLevel)currentValue.Value;
		if (GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(value) == null)
		{
			return;
		}
		if (this.ValidApplyConfigMap.ContainsKey(EFunction.LOADINGRANGESCALELEVEL) && GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(currentValue.Value) == null)
		{
			return;
		}
		GameSettingsManager.SetIsUsingQualityPreset(this.CheckIsMatchQualityRecommend(value, (EFunction functionId) => this.GetCurrentValue(functionId, false, true)) && this.CheckIsMatchFloatRenderRecommend(value, (EFunction functionId) => this.GetCurrentValueFloat(functionId, false, true)));
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x000FB738 File Offset: 0x000F9938
	public unsafe int GetCurrentValueSafely(EFunction id, int defaultValue = 0, bool allowRebuild = true)
	{
		int? num = this.GetCurrentValue(id, false, allowRebuild);
		if (num != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "【GetCurrentValueSafely】使用【Current】";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return num.Value;
		}
		OneOf<int, float, double>? initValue = this.GetInitValue(id, false);
		int? num2;
		if (initValue == null)
		{
			num2 = null;
		}
		else
		{
			num2 = new int?(initValue.GetValueOrDefault().Match<int>((int i) => i, (float f) => (int)f, (double d) => (int)d));
		}
		num = num2;
		if (num != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "【GetCurrentValueSafely】使用【Init】";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("value", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return num.Value;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameSettings;
		ELogAuthor author3 = ELogAuthor.WZ;
		string message3 = "【GetCurrentValueSafely】当前选项不能正确获取数据来源, 使用【缺省值】";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("functionId", (int)id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("defaultValue", defaultValue);
		instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
		return defaultValue;
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x000FB924 File Offset: 0x000F9B24
	[NullableContext(0)]
	public OneOf<int, float, double>? GetInitValue(EFunction id, bool isLog = true)
	{
		GameSettingsInitValueSource gameSettingsInitValueSource;
		if (!this.ValidInitValueSourceCache.TryGetValue(id, out gameSettingsInitValueSource))
		{
			if (isLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameSettings;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "【GetInitValue】当前选项不能正确获取数据来源";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		return gameSettingsInitValueSource.ValidInitValue;
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x000FB984 File Offset: 0x000F9B84
	private bool ApplyValue(EFunction id, int value, EGameSettingsApplyReason reason)
	{
		if (!this.IsValid(id, true))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【应用】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Func<int, EGameSettingsApplyReason, bool> applyCallback = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).ApplyCallback;
		if (applyCallback == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "[ApplyValue]该设置项不必应用";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}
		return applyCallback(value, reason);
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x000FBA1C File Offset: 0x000F9C1C
	private bool ForceApplyValue(EFunction id, int value, EGameSettingsApplyReason reason)
	{
		Func<int, EGameSettingsApplyReason, bool> applyCallback = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).ApplyCallback;
		if (applyCallback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "[ForceApplyValue]该设置项不必应用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		return applyCallback(value, reason);
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x000FBA78 File Offset: 0x000F9C78
	private unsafe bool SaveValue(EFunction id, int value)
	{
		if (!this.IsValid(id, true))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【Save】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).GetCallbackOrGlobalKey;
		if (getCallbackOrGlobalKey is Func<int>)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "getter不必【Save】LocalStorage";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		LocalStorage.SetGlobal<int>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, value);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameSettings;
		ELogAuthor author3 = ELogAuthor.WZ;
		string message3 = "设置项【Save】成功";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000FBB78 File Offset: 0x000F9D78
	public unsafe bool ForceSaveValue(EFunction id, int value)
	{
		object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).GetCallbackOrGlobalKey;
		if (getCallbackOrGlobalKey is Func<int>)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "getter不必【Force Save】LocalStorage";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		LocalStorage.SetGlobal<int>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, value);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.GameSettings;
		ELogAuthor author2 = ELogAuthor.WZ;
		string message2 = "设置项【Force Save】成功";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x06002890 RID: 10384 RVA: 0x000FBC40 File Offset: 0x000F9E40
	private unsafe void EnsureLanguagePairSaved(EFunction id)
	{
		EFunction efunction = EFunction.TEXTLANGUAGE;
		if (id == EFunction.TEXTLANGUAGE)
		{
			efunction = EFunction.VOICELANGUAGE;
		}
		else if (id != EFunction.VOICELANGUAGE)
		{
			return;
		}
		if (!this.IsValid(efunction, true))
		{
			return;
		}
		if (this.GetCurrentValue(efunction, false, true) != null)
		{
			return;
		}
		OneOf<int, float, double>? initValue = this.GetInitValue(efunction, false);
		if (initValue == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "登录界面态：配对语言项无法取得初始值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pairedFunctionId", (int)efunction);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int num = GameSettingsManager.OneOfToInt(initValue.Value);
		this.SaveValue(efunction, num);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.GameSettings;
		ELogAuthor author2 = ELogAuthor.TZJ;
		string message2 = "登录界面态：补齐配对语言项落盘";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("pairedFunctionId", (int)efunction);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pairedValue", num);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x000FBD58 File Offset: 0x000F9F58
	public unsafe void HandleValueChange(EFunction id, int value, EGameSettingsApplyReason reason)
	{
		if (this.IsFloatSetting(id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "小数设置项不能通过整数接口修改";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.HandleValueChangeCore(id, value, reason);
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x000FBDD8 File Offset: 0x000F9FD8
	public void HandleNumericValueChange(EFunction id, float value, EGameSettingsApplyReason reason)
	{
		if (this.IsFloatSetting(id))
		{
			this.HandleValueChangeFloat(id, value, reason);
			return;
		}
		this.HandleValueChange(id, (int)value, reason);
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x000FBDF8 File Offset: 0x000F9FF8
	private unsafe void HandleValueChangeCore(EFunction id, int value, EGameSettingsApplyReason reason)
	{
		bool flag = reason == EGameSettingsApplyReason.WhenUi && !this.IsGameSettingsAppliedOnOpenLoading;
		if (flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "【HandleValueChange】登录界面态：覆盖 InitValueSourceCache";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OverrideLoginCacheValue(id, value);
		}
		if (this.ApplyValue(id, value, reason))
		{
			this.SaveValue(id, value);
			if (flag)
			{
				this.EnsureLanguagePairSaved(id);
			}
			EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, id);
			Action<int, EGameSettingsApplyReason> handleDoneCallback = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).HandleDoneCallback;
			if (handleDoneCallback != null)
			{
				handleDoneCallback(value, reason);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "设置项【Handle】成功";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameSettings;
		ELogAuthor author3 = ELogAuthor.WZ;
		string message3 = "【HandleValueChange】设置项应用失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
		instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x000FBF80 File Offset: 0x000FA180
	public float? GetCurrentValueFloat(EFunction id, bool isLog = true, bool allowRebuild = true)
	{
		if (!this.IsValid(id, allowRebuild))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【GetCurrent】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IGameSettings valueOrDefault = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id);
		if (valueOrDefault == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "【GetCurrent】当前选项未能获取IGameSettings句柄";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		object getCallbackOrGlobalKey = valueOrDefault.GetCallbackOrGlobalKey;
		Func<float> func = getCallbackOrGlobalKey as Func<float>;
		if (func != null)
		{
			return new float?(func());
		}
		Func<int> func2 = getCallbackOrGlobalKey as Func<int>;
		if (func2 != null)
		{
			return new float?((float)func2());
		}
		float? global = LocalStorage.GetGlobal<float?>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, null);
		if (global == null)
		{
			if (isLog)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.GameSettings;
				ELogAuthor author3 = ELogAuthor.WZ;
				string message3 = "【GetCurrent】当前选项未被保存在LocalStorage中";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("functionId", (int)id);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			return null;
		}
		return new float?(global.Value);
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x000FC0B8 File Offset: 0x000FA2B8
	public float GetCurrentValueSafelyFloat(EFunction id, float defaultValue = 0f, bool allowRebuild = true)
	{
		float? currentValueFloat = this.GetCurrentValueFloat(id, false, allowRebuild);
		if (currentValueFloat != null)
		{
			return currentValueFloat.Value;
		}
		OneOf<int, float, double>? initValue = this.GetInitValue(id, false);
		float? num;
		if (initValue == null)
		{
			num = null;
		}
		else
		{
			num = new float?(initValue.GetValueOrDefault().Match<float>((int i) => (float)i, (float f) => f, (double d) => (float)d));
		}
		float? num2 = num;
		if (num2 != null)
		{
			return num2.Value;
		}
		return defaultValue;
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x000FC184 File Offset: 0x000FA384
	private bool ApplyValueFloat(EFunction id, float value, EGameSettingsApplyReason reason)
	{
		if (!this.IsValid(id, true))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【应用】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Func<float, EGameSettingsApplyReason, bool> applyCallbackFloat = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).ApplyCallbackFloat;
		if (applyCallbackFloat == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "[ApplyValue]该设置项不必应用";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return true;
		}
		return applyCallbackFloat(value, reason);
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x000FC21C File Offset: 0x000FA41C
	private unsafe bool SaveValueFloat(EFunction id, float value)
	{
		if (!this.IsValid(id, true))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WZ;
			string message = "在【Save】一个不符合条件的值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		object getCallbackOrGlobalKey = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).GetCallbackOrGlobalKey;
		if (getCallbackOrGlobalKey is Delegate)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "getter不必【Save】LocalStorage";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("functionId", (int)id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (id == EFunction.LOADINGRANGESCALELEVEL)
		{
			value = GameSettingsDeviceRender.NormalizeRenderDistanceValue(value);
		}
		LocalStorage.SetGlobal<float>((ELocalStorageGlobalKey)getCallbackOrGlobalKey, value);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameSettings;
		ELogAuthor author3 = ELogAuthor.WZ;
		string message3 = "设置项【Save】成功";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x000FC32C File Offset: 0x000FA52C
	public unsafe void HandleValueChangeFloat(EFunction id, float value, EGameSettingsApplyReason reason)
	{
		if (!this.IsFloatSetting(id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "整数设置项不能通过小数接口修改";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (id == EFunction.LOADINGRANGESCALELEVEL && this.IsValid(id, true))
		{
			value = GameSettingsDeviceRender.NormalizeRenderDistanceValue(value);
		}
		this.HandleValueChangeFloatCore(id, value, reason);
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x000FC3C8 File Offset: 0x000FA5C8
	private unsafe void HandleValueChangeFloatCore(EFunction id, float value, EGameSettingsApplyReason reason)
	{
		if (reason == EGameSettingsApplyReason.WhenUi && !this.IsGameSettingsAppliedOnOpenLoading)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "【HandleValueChange】登录界面态：覆盖 InitValueSourceCache";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OverrideLoginCacheValue(id, value);
		}
		if (this.ApplyValueFloat(id, value, reason))
		{
			this.SaveValueFloat(id, value);
			EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, id);
			Action<float, EGameSettingsApplyReason> handleDoneCallbackFloat = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).HandleDoneCallbackFloat;
			if (handleDoneCallbackFloat != null)
			{
				handleDoneCallbackFloat(value, reason);
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "设置项【Handle】成功";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", (int)id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.GameSettings;
		ELogAuthor author3 = ELogAuthor.WZ;
		string message3 = "【HandleValueChange】设置项应用失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("functionId", (int)id);
		instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x000FC544 File Offset: 0x000FA744
	public bool ReApply(EFunction id, EGameSettingsApplyReason reason = EGameSettingsApplyReason.AnyTime, bool isLog = true)
	{
		if (this.IsFloatSetting(id))
		{
			float currentValueSafelyFloat = this.GetCurrentValueSafelyFloat(id, 0f, true);
			return this.ApplyValueFloat(id, currentValueSafelyFloat, reason);
		}
		int currentValueSafely = this.GetCurrentValueSafely(id, 0, true);
		return this.ApplyValue(id, currentValueSafely, reason);
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x000FC585 File Offset: 0x000FA785
	[NullableContext(2)]
	public string DumpValue(EFunction id)
	{
		Func<string> dumpCallback = GameSettingsDefine.function2GameSettings.GetValueOrDefault(id).DumpCallback;
		if (dumpCallback == null)
		{
			return null;
		}
		return dumpCallback();
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x000FC5A4 File Offset: 0x000FA7A4
	public string GetAudioCodeById(int type)
	{
		global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(type);
		if (languageDefineByType == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Menu;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "LanguageSystem 未定义此语种";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("非法值", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "en";
		}
		return languageDefineByType.AudioCode;
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x000FC5F8 File Offset: 0x000FA7F8
	public string GetLanguageCodeById(int type)
	{
		global::LanguageDefine languageDefineByType = LanguageSystem.Instance.GetLanguageDefineByType(type);
		if (languageDefineByType == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Menu;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "LanguageSystem 未定义此语种";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("非法值", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "en";
		}
		return languageDefineByType.LanguageCode;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x000FC64C File Offset: 0x000FA84C
	public unsafe bool CheckIsMatchQualityRecommend(EGameQualitySettingLevel quality, Func<EFunction, int?> valueGetter)
	{
		DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(quality);
		if (deviceRenderFeature == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WLJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(103, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[GameSettingsManager::CheckIsMatchQualityRecommend] no device render feature for quality=");
			defaultInterpolatedStringHandler.AppendFormatted<EGameQualitySettingLevel>(quality);
			defaultInterpolatedStringHandler.AppendLiteral(", return false");
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		DeviceRenderFeature value = deviceRenderFeature.Value;
		foreach (KeyValuePair<EFunction, int> keyValuePair in GameSettingsDeviceRender.Instance.GetOtherChangedValue(value))
		{
			EFunction efunction;
			int num;
			keyValuePair.Deconstruct(out efunction, out num);
			EFunction efunction2 = efunction;
			int num2 = num;
			if ((efunction2 != EFunction.MOBILERESOLUTION || Info.Instance.IsMobilePlatform()) && (efunction2 != EFunction.PCVSYNC || Info.Instance.IsPcOrGamepadPlatform()) && (efunction2 != EFunction.VOLUMEFOG || !Info.Instance.IsMacPlatform()) && (efunction2 != EFunction.NPCDENSITY || !UKuroStaticLibrary.IsLowMemoryDevice()) && efunction2 != EFunction.RayTracing && efunction2 != EFunction.AnisoLevel)
			{
				if (efunction2 == EFunction.SUPERRESOLUTION)
				{
					if (Info.Instance.IsWindowsPlatform())
					{
						EFunction efunction3 = EFunction.SUPERRESOLUTION;
						EFunction efunction4 = EFunction.SUPERRESOLUTION;
						int num3 = num2;
						ValueTuple<EFunction, EFunction, int> valueTuple = GameSettingsDeviceRender.Instance.MapSuperResolutionRecommendValue(efunction3, efunction4, num3);
						efunction3 = valueTuple.Item1;
						efunction4 = valueTuple.Item2;
						num3 = valueTuple.Item3;
						if (valueGetter(efunction3).GetValueOrDefault() == 0)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.GameSettings;
							ELogAuthor author2 = ELogAuthor.TZJ;
							string message = "画质相关项被手动修改过：未开启超级分辨率";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("superResolutionId", efunction3);
							instance2.Info(module2, author2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
							return false;
						}
						int valueOrDefault = valueGetter(efunction4).GetValueOrDefault();
						if (num3 != valueOrDefault)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.GameSettings;
							ELogAuthor author3 = ELogAuthor.TZJ;
							string message2 = "画质相关项被手动修改过：超级分辨率质量档位";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("superResolutionId", efunction3);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("qualityId", efunction4);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("target value", num3);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("current value", valueOrDefault);
							instance3.Info(module3, author3, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
							return false;
						}
					}
				}
				else
				{
					int? num4 = valueGetter(efunction2);
					if (num4 != null)
					{
						int num5 = num2;
						int? num6 = num4;
						if (!(num5 == num6.GetValueOrDefault() & num6 != null))
						{
							Log instance4 = Log.Instance;
							ELogModule module4 = ELogModule.GameSettings;
							ELogAuthor author4 = ELogAuthor.TZJ;
							string message3 = "画质相关项被手动修改过";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("functionId", (int)efunction2);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("target value", num2);
							instance4.Info(module4, author4, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x000FC988 File Offset: 0x000FAB88
	public bool CheckIsMatchFloatRenderRecommend(EGameQualitySettingLevel quality, Func<EFunction, float?> valueGetter)
	{
		DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(quality);
		if (deviceRenderFeature == null)
		{
			return false;
		}
		foreach (KeyValuePair<EFunction, float> keyValuePair in GameSettingsDeviceRender.Instance.GetOtherChangedFloatValue(deviceRenderFeature.Value))
		{
			EFunction efunction;
			float num;
			keyValuePair.Deconstruct(out efunction, out num);
			EFunction efunction2 = efunction;
			float num2 = num;
			if (this.ValidApplyConfigMap.ContainsKey(efunction2))
			{
				float? num3 = valueGetter(efunction2);
				if (num3 == null)
				{
					return false;
				}
				if (efunction2 == EFunction.LOADINGRANGESCALELEVEL)
				{
					if (GameSettingsDeviceRender.GetRenderDistanceStepIndex(num3.Value) != GameSettingsDeviceRender.GetRenderDistanceStepIndex(num2))
					{
						return false;
					}
				}
				else if (Math.Abs(num3.Value - num2) > 0.0001f)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000FCA70 File Offset: 0x000FAC70
	public static GameSettingsManager Instance
	{
		get
		{
			if (GameSettingsManager._instance == null)
			{
				GameSettingsManager._instance = new GameSettingsManager();
				GameSettingsManager._instance.OnInit();
			}
			return GameSettingsManager._instance;
		}
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x000FCA93 File Offset: 0x000FAC93
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x000FCA95 File Offset: 0x000FAC95
	public static void ResetStaticDefaultValue()
	{
		GameSettingsManager instance = GameSettingsManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsManager._instance = null;
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x000FCAAE File Offset: 0x000FACAE
	static GameSettingsManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsManager.CreateStaticDefaultValue), new Action(GameSettingsManager.ResetStaticDefaultValue));
	}

	// Token: 0x04002738 RID: 10040
	private readonly Dictionary<EFunction, GameSettingsInitValueSource> ValidInitValueSourceCache = new Dictionary<EFunction, GameSettingsInitValueSource>();

	// Token: 0x04002739 RID: 10041
	public bool IsGameSettingsAppliedOnOpenLoading;

	// Token: 0x0400273A RID: 10042
	[Nullable(2)]
	private Dictionary<EFunction, MenuConfig> ValidApplyConfigMapInternal;

	// Token: 0x0400273B RID: 10043
	[Nullable(2)]
	private static GameSettingsManager _instance;
}
