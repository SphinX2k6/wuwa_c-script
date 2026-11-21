using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Ui.HotFix;

// Token: 0x02000281 RID: 641
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDefine : IStaticVariableResetter
{
	// Token: 0x06002712 RID: 10002 RVA: 0x000EC216 File Offset: 0x000EA416
	static GameSettingsDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDefine.CreateStaticDefaultValue), new Action(GameSettingsDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x000EC238 File Offset: 0x000EA438
	public static void CreateStaticDefaultValue()
	{
		GameSettingsDefine.gameSettingsInitSourceTypePriority = new EGameSettingsInitSourceType[]
		{
			EGameSettingsInitSourceType.CloudOverride,
			EGameSettingsInitSourceType.RecommendQualityOverride,
			EGameSettingsInitSourceType.LoginOverride,
			EGameSettingsInitSourceType.LowMemoryOverride,
			EGameSettingsInitSourceType.InitOverride,
			EGameSettingsInitSourceType.LocalStorage,
			EGameSettingsInitSourceType.From1Dot3,
			EGameSettingsInitSourceType.From1Dot2,
			EGameSettingsInitSourceType.From1Dot1,
			EGameSettingsInitSourceType.From1Dot0,
			EGameSettingsInitSourceType.RenderFeatureDefaultConfigOverride,
			EGameSettingsInitSourceType.RenderFeatureDefaultConfig,
			EGameSettingsInitSourceType.CustomOverrideDefault,
			EGameSettingsInitSourceType.UserSettingIni,
			EGameSettingsInitSourceType.GameSettingDefaultConfig
		};
		GameSettingsDefine gameSettingsDefine = new GameSettingsDefine();
		GameSettingsDefine.function2GameSettings = new Dictionary<EFunction, IGameSettings>
		{
			{
				EFunction.MASTERVOLUMEFUNCTION,
				gameSettingsDefine.masterVolume
			},
			{
				EFunction.VOICEVOLUMEFUNCTION,
				gameSettingsDefine.voiceVolume
			},
			{
				EFunction.MUSICVOLUMEFUNCTION,
				gameSettingsDefine.musicVolume
			},
			{
				EFunction.SFXVOLUMEFUNCTION,
				gameSettingsDefine.sfxVolume
			},
			{
				EFunction.UIVOLUMEFUNCTION,
				gameSettingsDefine.uiVolume
			},
			{
				EFunction.AMBVOLUMEFUNCTION,
				gameSettingsDefine.ambVolume
			},
			{
				EFunction.BackendVolume,
				gameSettingsDefine.backendVolume
			},
			{
				EFunction.IMAGEQUALITY,
				gameSettingsDefine.imageQuality
			},
			{
				EFunction.DISPLAYMODE,
				gameSettingsDefine.displayMode
			},
			{
				EFunction.RESOURCESTANDARD,
				gameSettingsDefine.resourceStandard
			},
			{
				EFunction.RESOLUTION,
				gameSettingsDefine.resolution
			},
			{
				EFunction.BRIGHTNESS,
				gameSettingsDefine.brightness
			},
			{
				EFunction.HIGHESTFPS,
				gameSettingsDefine.highestFps
			},
			{
				EFunction.SHADOWQUALITY,
				gameSettingsDefine.shadowQuality
			},
			{
				EFunction.NIAGARAQUALITY,
				gameSettingsDefine.niagaraQuality
			},
			{
				EFunction.IMAGEDETAIL,
				gameSettingsDefine.imageDetail
			},
			{
				EFunction.ANTIALISING,
				gameSettingsDefine.antiAliasing
			},
			{
				EFunction.SCENEAO,
				gameSettingsDefine.sceneAo
			},
			{
				EFunction.NPCDENSITY,
				gameSettingsDefine.npcDensity
			},
			{
				EFunction.NVIDIADLSS,
				gameSettingsDefine.nvidiaDlss
			},
			{
				EFunction.NVIDIADLSSFG,
				gameSettingsDefine.nvidiaDlssFg
			},
			{
				EFunction.NVIDIADLSSQUALITY,
				gameSettingsDefine.nvidiaDlssQuality
			},
			{
				EFunction.NVIDIADLSSSHARPNESS,
				gameSettingsDefine.nvidiaDlssSharpness
			},
			{
				EFunction.NVIDIAREFLEX,
				gameSettingsDefine.nvidiaReflex
			},
			{
				EFunction.HDR,
				gameSettingsDefine.hdr
			},
			{
				EFunction.FSR,
				gameSettingsDefine.fsr
			},
			{
				EFunction.XESS,
				gameSettingsDefine.xess
			},
			{
				EFunction.XESS_QUALITY,
				gameSettingsDefine.xessQuality
			},
			{
				EFunction.XESS2,
				gameSettingsDefine.xess2
			},
			{
				EFunction.XESS2_FG,
				gameSettingsDefine.xess2Fg
			},
			{
				EFunction.XESS2_QUALITY,
				gameSettingsDefine.xess2Quality
			},
			{
				EFunction.FSR3,
				gameSettingsDefine.fsr3
			},
			{
				EFunction.FSR3_FG,
				gameSettingsDefine.fsr3Fg
			},
			{
				EFunction.FSR3_QUALITY,
				gameSettingsDefine.fsr3Quality
			},
			{
				EFunction.PSSR,
				gameSettingsDefine.pssr
			},
			{
				EFunction.METALFX,
				gameSettingsDefine.metalFxEnable
			},
			{
				EFunction.IRX,
				gameSettingsDefine.irx
			},
			{
				EFunction.BLOOM,
				gameSettingsDefine.bloom
			},
			{
				EFunction.VOLUMEFOG,
				gameSettingsDefine.volumeFog
			},
			{
				EFunction.VOLUMELIGHT,
				gameSettingsDefine.volumeLight
			},
			{
				EFunction.MOTIONBLUR,
				gameSettingsDefine.motionBlur
			},
			{
				EFunction.PCVSYNC,
				gameSettingsDefine.pcvSync
			},
			{
				EFunction.MOBILERESOLUTION,
				gameSettingsDefine.mobileResolution
			},
			{
				EFunction.SUPERRESOLUTION,
				gameSettingsDefine.superResolution
			},
			{
				EFunction.TEXTLANGUAGE,
				gameSettingsDefine.textLanguage
			},
			{
				EFunction.VOICELANGUAGE,
				gameSettingsDefine.voiceLanguage
			},
			{
				EFunction.VOICEPACKMANAGER,
				gameSettingsDefine.voicePackManager
			},
			{
				EFunction.VOICEROLECUSTOM,
				gameSettingsDefine.voiceRoleCustomManager
			},
			{
				EFunction.ADVICESETTING,
				gameSettingsDefine.adviceSetting
			},
			{
				EFunction.GENDERSETTING,
				gameSettingsDefine.genderSetting
			},
			{
				EFunction.HorizontalViewSensitivity,
				gameSettingsDefine.horizontalViewSensitivity
			},
			{
				EFunction.VerticalViewSensitivity,
				gameSettingsDefine.verticalViewSensitivity
			},
			{
				EFunction.AimHorizontalViewSensitivity,
				gameSettingsDefine.aimHorizontalViewSensitivity
			},
			{
				EFunction.AimVerticalViewSensitivity,
				gameSettingsDefine.aimVerticalViewSensitivity
			},
			{
				EFunction.CameraShakeStrength,
				gameSettingsDefine.cameraShakeStrength
			},
			{
				EFunction.MobileHorizontalViewSensitivity,
				gameSettingsDefine.mobileHorizontalViewSensitivity
			},
			{
				EFunction.MobileVerticalViewSensitivity,
				gameSettingsDefine.mobileVerticalViewSensitivity
			},
			{
				EFunction.MobileAimHorizontalViewSensitivity,
				gameSettingsDefine.mobileAimHorizontalViewSensitivity
			},
			{
				EFunction.MobileAimVerticalViewSensitivity,
				gameSettingsDefine.mobileAimVerticalViewSensitivity
			},
			{
				EFunction.CommonSpringArmLength,
				gameSettingsDefine.commonSpringArmLength
			},
			{
				EFunction.FightSpringArmLength,
				gameSettingsDefine.fightSpringArmLength
			},
			{
				EFunction.ResetFocusEnable,
				gameSettingsDefine.resetFocusEnable
			},
			{
				EFunction.IsSidestepCameraEnable,
				gameSettingsDefine.isSidestepCameraEnable
			},
			{
				EFunction.IsSoftLockCameraEnable,
				gameSettingsDefine.isSoftLockCameraEnable
			},
			{
				EFunction.JoystickShakeStrength,
				gameSettingsDefine.joystickShakeStrength
			},
			{
				EFunction.JoystickShakeType,
				gameSettingsDefine.joystickShakeType
			},
			{
				EFunction.WalkOrRunRate,
				gameSettingsDefine.walkOrRunRate
			},
			{
				EFunction.LogUpload,
				gameSettingsDefine.logUploadSetting
			},
			{
				EFunction.JoystickMode,
				gameSettingsDefine.joystickMode
			},
			{
				EFunction.MobileButtonCustom,
				gameSettingsDefine.mobileButtonCustom
			},
			{
				EFunction.SkillButtonMode,
				gameSettingsDefine.skillButtonMode
			},
			{
				EFunction.CdKey,
				gameSettingsDefine.cdKey
			},
			{
				EFunction.UserCenterDomestic,
				gameSettingsDefine.userCenterDomestic
			},
			{
				EFunction.TermsOfUseDomestic,
				gameSettingsDefine.termsOfUseDomestic
			},
			{
				EFunction.PrivacyPolicyDomestic,
				gameSettingsDefine.privacyPolicyDomestic
			},
			{
				EFunction.ChildrenPrivacy,
				gameSettingsDefine.childrenPrivacy
			},
			{
				EFunction.ThirdPartyInfo,
				gameSettingsDefine.thirdPartyInfo
			},
			{
				EFunction.TermsOfUseOverSeas,
				gameSettingsDefine.termsOfUseOverSeas
			},
			{
				EFunction.PrivacyPolicyOverSeas,
				gameSettingsDefine.privacyPolicyOverSeas
			},
			{
				EFunction.PrivacyPolicySetting,
				gameSettingsDefine.privacyPolicySetting
			},
			{
				EFunction.License,
				gameSettingsDefine.licenseSetting
			},
			{
				EFunction.UserCenterOverseas,
				gameSettingsDefine.userCenterOverseas
			},
			{
				EFunction.PushMode,
				gameSettingsDefine.pushMode
			},
			{
				EFunction.AimAssist,
				gameSettingsDefine.aimAssist
			},
			{
				EFunction.KeyboardLockEnemyMode,
				gameSettingsDefine.keyboardLockEnemyMode
			},
			{
				EFunction.HorizontalViewRevert,
				gameSettingsDefine.horizontalViewRevert
			},
			{
				EFunction.VerticalViewRevert,
				gameSettingsDefine.verticalViewRevert
			},
			{
				EFunction.SkillLockEnemyMode,
				gameSettingsDefine.skillLockEnemyMode
			},
			{
				EFunction.GamepadLockEnemyMode,
				gameSettingsDefine.gamepadLockEnemyMode
			},
			{
				EFunction.EnemyHitDisplayMode,
				gameSettingsDefine.enemyHitDisplayMode
			},
			{
				EFunction.PlayStationOnly,
				gameSettingsDefine.playStationOnly
			},
			{
				EFunction.MobileGamepadMode,
				gameSettingsDefine.mobileGamepadMode
			},
			{
				EFunction.AutoAdjustImageQuality,
				gameSettingsDefine.autoAdjustImageQuality
			},
			{
				EFunction.ShowDamage,
				gameSettingsDefine.showDamage
			},
			{
				EFunction.DynamicBones,
				gameSettingsDefine.dynamicBones
			},
			{
				EFunction.UIPureMode,
				gameSettingsDefine.uiPureMode
			},
			{
				EFunction.FlyControlMode,
				gameSettingsDefine.flyControlMode
			},
			{
				EFunction.DOLBYATOMS,
				gameSettingsDefine.dolbyAtmos
			},
			{
				EFunction.FlowAdaptation,
				gameSettingsDefine.flowAdaptation
			},
			{
				EFunction.RayTracing,
				gameSettingsDefine.rayTracing
			},
			{
				EFunction.RayTracedReflection,
				gameSettingsDefine.rayTracedReflection
			},
			{
				EFunction.RayTracedGI,
				gameSettingsDefine.rayTracedGI
			},
			{
				EFunction.RayTracedShadow,
				gameSettingsDefine.rayTracedShadow
			},
			{
				EFunction.TeammateFx,
				gameSettingsDefine.teammateFx
			},
			{
				EFunction.Saturation,
				gameSettingsDefine.saturation
			},
			{
				EFunction.Contrast,
				gameSettingsDefine.contrast
			},
			{
				EFunction.Filter,
				gameSettingsDefine.filter
			},
			{
				EFunction.SkinDamageMode,
				gameSettingsDefine.skinDamageMode
			},
			{
				EFunction.AdrenoFME,
				gameSettingsDefine.adrenoFME
			},
			{
				EFunction.BasicGraphicSetting,
				gameSettingsDefine.basicGraphicSetting
			},
			{
				EFunction.Vulkan,
				gameSettingsDefine.vulkan
			},
			{
				EFunction.ResDownLoad,
				gameSettingsDefine.resDownLoad
			},
			{
				EFunction.ResClear,
				gameSettingsDefine.resClear
			},
			{
				EFunction.AutoRun,
				gameSettingsDefine.autoRun
			},
			{
				EFunction.AutoSprint,
				gameSettingsDefine.autoSprint
			},
			{
				EFunction.ShowOtherName,
				gameSettingsDefine.showOtherName
			},
			{
				EFunction.WaterInteract,
				gameSettingsDefine.waterInteract
			},
			{
				EFunction.VegetationDither,
				gameSettingsDefine.vegetationDither
			},
			{
				EFunction.VegetationDensity,
				gameSettingsDefine.vegetationDensity
			},
			{
				EFunction.ImageDisplayMode,
				gameSettingsDefine.imageDisplayMode
			},
			{
				EFunction.EyeProtection,
				gameSettingsDefine.eyeProtection
			},
			{
				EFunction.EyeProtectionMode,
				gameSettingsDefine.eyeProtectionMode
			},
			{
				EFunction.EyeProtectionTemp,
				gameSettingsDefine.eyeProtectionTemp
			},
			{
				EFunction.EyeProtectionStrength,
				gameSettingsDefine.eyeProtectionStrength
			},
			{
				EFunction.EyeProtectionBrightness,
				gameSettingsDefine.eyeProtectionBrightness
			},
			{
				EFunction.EyeProtectionTexture,
				gameSettingsDefine.eyeProtectionTexture
			},
			{
				EFunction.VersionCheck,
				gameSettingsDefine.versionCheck
			},
			{
				EFunction.AutoExposure,
				gameSettingsDefine.autoExposure
			},
			{
				EFunction.HarmonySuperResolution,
				gameSettingsDefine.harmonySuperResolution
			},
			{
				EFunction.HarmonyRayTracingBoost,
				gameSettingsDefine.harmonyRayTracingBoost
			},
			{
				EFunction.HarmonyRayTracingBoostAdvanced,
				gameSettingsDefine.harmonyRayTracingBoostAdvanced
			},
			{
				EFunction.AdjustiveGamePadTrigger,
				gameSettingsDefine.adjustiveGamePadTrigger
			},
			{
				EFunction.GamepadLeftStickDeadZone,
				gameSettingsDefine.gamepadLeftStickDeadZone
			},
			{
				EFunction.GamepadRightStickDeadZone,
				gameSettingsDefine.gamepadRightStickDeadZone
			},
			{
				EFunction.GamepadLeftTriggerDeadZone,
				gameSettingsDefine.gamepadLeftTriggerDeadZone
			},
			{
				EFunction.GamepadRightTriggerDeadZone,
				gameSettingsDefine.gamepadRightTriggerDeadZone
			},
			{
				EFunction.MotorAutoLongPressSpeedUp,
				gameSettingsDefine.motorAccleratePressType
			},
			{
				EFunction.MotorAutoAcceleratorSettingEnable,
				gameSettingsDefine.motorAutoAcceleratorSettingEnable
			},
			{
				EFunction.MotorDriftAcceleratorSettingEnable,
				gameSettingsDefine.motorDriftAcceleratorSettingEnable
			},
			{
				EFunction.MotorDriftModel,
				gameSettingsDefine.motorDriftModel
			},
			{
				EFunction.MotorHudVisible,
				gameSettingsDefine.motorHudVisible
			},
			{
				EFunction.SubTitleOption,
				gameSettingsDefine.subTitleOption
			},
			{
				EFunction.MotorIsDynamicJoystick,
				gameSettingsDefine.motorTouchFixedPosition
			},
			{
				EFunction.MotorMobileButtonCustom,
				gameSettingsDefine.motorMobileButtonCustom
			},
			{
				EFunction.MotorMobileButtonLayout,
				gameSettingsDefine.motorMobileButtonLayout
			},
			{
				EFunction.DeviceInfo,
				gameSettingsDefine.deviceInfo
			},
			{
				EFunction.UiBrightness,
				gameSettingsDefine.uiBrightness
			},
			{
				EFunction.PeakBrightness,
				gameSettingsDefine.peakBrightness
			},
			{
				EFunction.LOADINGRANGESCALELEVEL,
				gameSettingsDefine.loadingRangeScaleLevel
			},
			{
				EFunction.MotorFlyControlMode,
				gameSettingsDefine.motorFlyControlMode
			},
			{
				EFunction.AnisoLevel,
				gameSettingsDefine.anisoLevel
			},
			{
				EFunction.XboxOnly,
				gameSettingsDefine.xboxOnly
			}
		};
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000ECBAB File Offset: 0x000EADAB
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDefine.gameSettingsInitSourceTypePriority = null;
		GameSettingsDefine.function2GameSettings = null;
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x000ECBBC File Offset: 0x000EADBC
	public GameSettingsDefine()
	{
		GameSettings gameSettings = new GameSettings();
		gameSettings.GameSettingId = EFunction.MASTERVOLUMEFUNCTION;
		gameSettings.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MasterVolume;
		gameSettings.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_master"));
		gameSettings.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_master"));
		this.masterVolume = gameSettings;
		GameSettings gameSettings2 = new GameSettings();
		gameSettings2.GameSettingId = EFunction.VOICEVOLUMEFUNCTION;
		gameSettings2.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VoiceVolume;
		gameSettings2.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_voice"));
		gameSettings2.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_voice"));
		this.voiceVolume = gameSettings2;
		GameSettings gameSettings3 = new GameSettings();
		gameSettings3.GameSettingId = EFunction.MUSICVOLUMEFUNCTION;
		gameSettings3.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MusicVolume;
		gameSettings3.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_music"));
		gameSettings3.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_music"));
		this.musicVolume = gameSettings3;
		GameSettings gameSettings4 = new GameSettings();
		gameSettings4.GameSettingId = EFunction.SFXVOLUMEFUNCTION;
		gameSettings4.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SFXVolume;
		gameSettings4.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_sfx"));
		gameSettings4.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_sfx"));
		this.sfxVolume = gameSettings4;
		GameSettings gameSettings5 = new GameSettings();
		gameSettings5.GameSettingId = EFunction.UIVOLUMEFUNCTION;
		gameSettings5.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.UIVolume;
		gameSettings5.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_sfx_ui"));
		gameSettings5.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_sfx_ui"));
		this.uiVolume = gameSettings5;
		GameSettings gameSettings6 = new GameSettings();
		gameSettings6.GameSettingId = EFunction.AMBVOLUMEFUNCTION;
		gameSettings6.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AMBVolume;
		gameSettings6.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolume((float)value, "volume_sfx_amb"));
		gameSettings6.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_sfx_amb"));
		this.ambVolume = gameSettings6;
		GameSettings gameSettings7 = new GameSettings();
		gameSettings7.GameSettingId = EFunction.BackendVolume;
		gameSettings7.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.BackendVolume;
		gameSettings7.DumpCallback = (() => "");
		this.backendVolume = gameSettings7;
		GameSettings gameSettings8 = new GameSettings();
		gameSettings8.GameSettingId = EFunction.IMAGEQUALITY;
		gameSettings8.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ImageQuality;
		gameSettings8.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			bool result = GameSettingsUtils.ApplyImageQualityOnly(value);
			GameSettingsUtils.ApplySceneLightQuality(value);
			return result;
		};
		gameSettings8.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit<int>(EEventName.SetImageQualityWithValue, value);
			EventSystem.Instance.Emit(EEventName.SetImageQuality);
		};
		gameSettings8.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpImageQuality());
		this.imageQuality = gameSettings8;
		GameSettings gameSettings9 = new GameSettings();
		gameSettings9.GameSettingId = EFunction.LOADINGRANGESCALELEVEL;
		gameSettings9.ValueType = EGameSettingsValueType.Float;
		gameSettings9.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RenderDistanceSliderLevel;
		gameSettings9.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyLoadingRangeScale(value));
		gameSettings9.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpLoadingRangeScaleLevel());
		this.loadingRangeScaleLevel = gameSettings9;
		GameSettings gameSettings10 = new GameSettings();
		gameSettings10.GameSettingId = EFunction.DISPLAYMODE;
		gameSettings10.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PcWindowMode;
		gameSettings10.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyDisplayMode(value));
		gameSettings10.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpDisplayMode());
		this.displayMode = gameSettings10;
		GameSettings gameSettings11 = new GameSettings();
		gameSettings11.GameSettingId = EFunction.RESOURCESTANDARD;
		gameSettings11.GetCallbackOrGlobalKey = new Func<int>(() => new int?((int)HotFixManager.LocalResourceQualityTier).GetValueOrDefault());
		gameSettings11.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyResourceStandard(value));
		gameSettings11.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpResourceStandard());
		this.resourceStandard = gameSettings11;
		GameSettings gameSettings12 = new GameSettings();
		gameSettings12.GameSettingId = EFunction.RESOLUTION;
		gameSettings12.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PcResolutionIndex;
		gameSettings12.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyResolution(value));
		gameSettings12.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpResolution());
		this.resolution = gameSettings12;
		GameSettings gameSettings13 = new GameSettings();
		gameSettings13.GameSettingId = EFunction.BRIGHTNESS;
		gameSettings13.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Brightness;
		gameSettings13.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyBrightness((float)value));
		gameSettings13.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpBrightness());
		this.brightness = gameSettings13;
		GameSettings gameSettings14 = new GameSettings();
		gameSettings14.GameSettingId = EFunction.HIGHESTFPS;
		gameSettings14.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.CustomFrameRate;
		gameSettings14.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHighestFps(value));
		gameSettings14.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHighestFps());
		this.highestFps = gameSettings14;
		GameSettings gameSettings15 = new GameSettings();
		gameSettings15.GameSettingId = EFunction.SHADOWQUALITY;
		gameSettings15.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ShadowQuality;
		gameSettings15.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyShadowQuality(value));
		gameSettings15.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpShadowQuality());
		this.shadowQuality = gameSettings15;
		GameSettings gameSettings16 = new GameSettings();
		gameSettings16.GameSettingId = EFunction.NIAGARAQUALITY;
		gameSettings16.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NiagaraQuality;
		gameSettings16.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNiagaraQuality(value));
		gameSettings16.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit(EEventName.SetNiagaraQuality);
		};
		gameSettings16.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNiagaraQuality());
		this.niagaraQuality = gameSettings16;
		GameSettings gameSettings17 = new GameSettings();
		gameSettings17.GameSettingId = EFunction.IMAGEDETAIL;
		gameSettings17.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ImageDetail;
		gameSettings17.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyImageDetail(value));
		gameSettings17.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpImageDetail());
		this.imageDetail = gameSettings17;
		GameSettings gameSettings18 = new GameSettings();
		gameSettings18.GameSettingId = EFunction.ANTIALISING;
		gameSettings18.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AntiAliasing;
		gameSettings18.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAntiAliasing(value));
		gameSettings18.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAntiAliasing());
		this.antiAliasing = gameSettings18;
		GameSettings gameSettings19 = new GameSettings();
		gameSettings19.GameSettingId = EFunction.SCENEAO;
		gameSettings19.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SceneAo;
		gameSettings19.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplySceneAo(value, null));
		gameSettings19.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSceneAo());
		this.sceneAo = gameSettings19;
		GameSettings gameSettings20 = new GameSettings();
		gameSettings20.GameSettingId = EFunction.NPCDENSITY;
		gameSettings20.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NpcDensity;
		gameSettings20.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNpcDensity(value));
		gameSettings20.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNpcDensity());
		this.npcDensity = gameSettings20;
		GameSettings gameSettings21 = new GameSettings();
		gameSettings21.GameSettingId = EFunction.NVIDIADLSS;
		gameSettings21.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NvidiaSuperSamplingEnable;
		Func<int, EGameSettingsApplyReason, bool> applyCallback;
		if ((applyCallback = GameSettingsDefine.<>O.<0>__ApplyNvidiaSuperSamplingEnable) == null)
		{
			applyCallback = (GameSettingsDefine.<>O.<0>__ApplyNvidiaSuperSamplingEnable = new Func<int, EGameSettingsApplyReason, bool>(GameSettingsUtils.ApplyNvidiaSuperSamplingEnable));
		}
		gameSettings21.ApplyCallback = applyCallback;
		gameSettings21.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNvidiaDlss());
		this.nvidiaDlss = gameSettings21;
		GameSettings gameSettings22 = new GameSettings();
		gameSettings22.GameSettingId = EFunction.NVIDIADLSSFG;
		gameSettings22.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NvidiaSuperSamplingFrameGenerate;
		gameSettings22.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNvidiaSuperSamplingFrameGenerate(value));
		gameSettings22.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit<int>(EEventName.SetDLSSFGWithValue, value);
		};
		gameSettings22.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNvidiaDlssFg());
		this.nvidiaDlssFg = gameSettings22;
		GameSettings gameSettings23 = new GameSettings();
		gameSettings23.GameSettingId = EFunction.NVIDIADLSSQUALITY;
		gameSettings23.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NvidiaSuperSamplingQuality;
		gameSettings23.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNvidiaSuperSamplingQuality(value));
		gameSettings23.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNvidiaDlssQuality());
		this.nvidiaDlssQuality = gameSettings23;
		GameSettings gameSettings24 = new GameSettings();
		gameSettings24.GameSettingId = EFunction.NVIDIADLSSSHARPNESS;
		gameSettings24.ValueType = EGameSettingsValueType.Float;
		gameSettings24.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NvidiaSuperSamplingSharpness;
		gameSettings24.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNvidiaSuperSamplingSharpness(value));
		gameSettings24.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNvidiaDlssSharpness());
		this.nvidiaDlssSharpness = gameSettings24;
		GameSettings gameSettings25 = new GameSettings();
		gameSettings25.GameSettingId = EFunction.NVIDIAREFLEX;
		gameSettings25.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.NvidiaReflex;
		gameSettings25.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyNvidiaReflex(value));
		gameSettings25.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpNvidiaReflex());
		this.nvidiaReflex = gameSettings25;
		GameSettings gameSettings26 = new GameSettings();
		gameSettings26.GameSettingId = EFunction.HDR;
		gameSettings26.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Hdr;
		gameSettings26.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHdrEnable(value));
		gameSettings26.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHdr());
		this.hdr = gameSettings26;
		GameSettings gameSettings27 = new GameSettings();
		gameSettings27.GameSettingId = EFunction.FSR;
		gameSettings27.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FsrEnable;
		gameSettings27.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyFsrEnable(value));
		gameSettings27.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFsr());
		this.fsr = gameSettings27;
		GameSettings gameSettings28 = new GameSettings();
		gameSettings28.GameSettingId = EFunction.XESS;
		gameSettings28.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.XessEnable;
		gameSettings28.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyXessEnable(value));
		gameSettings28.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpXess());
		this.xess = gameSettings28;
		GameSettings gameSettings29 = new GameSettings();
		gameSettings29.GameSettingId = EFunction.XESS_QUALITY;
		gameSettings29.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.XessQuality;
		gameSettings29.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyXessQuality(value));
		gameSettings29.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpXessQuality());
		this.xessQuality = gameSettings29;
		GameSettings gameSettings30 = new GameSettings();
		gameSettings30.GameSettingId = EFunction.XESS2;
		gameSettings30.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Xess2Enable;
		gameSettings30.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyXess2Enable(value));
		gameSettings30.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpXess2());
		this.xess2 = gameSettings30;
		GameSettings gameSettings31 = new GameSettings();
		gameSettings31.GameSettingId = EFunction.XESS2_FG;
		gameSettings31.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Xess2Fg;
		gameSettings31.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyXess2Fg(value));
		gameSettings31.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpXess2Fg());
		this.xess2Fg = gameSettings31;
		GameSettings gameSettings32 = new GameSettings();
		gameSettings32.GameSettingId = EFunction.XESS2_QUALITY;
		gameSettings32.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Xess2Quality;
		gameSettings32.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyXess2Quality(value));
		gameSettings32.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpXess2Quality());
		this.xess2Quality = gameSettings32;
		GameSettings gameSettings33 = new GameSettings();
		gameSettings33.GameSettingId = EFunction.FSR3;
		gameSettings33.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Fsr3Enable;
		gameSettings33.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyFsr3Enable(value));
		gameSettings33.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFsr3());
		this.fsr3 = gameSettings33;
		GameSettings gameSettings34 = new GameSettings();
		gameSettings34.GameSettingId = EFunction.FSR3_FG;
		gameSettings34.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Fsr3Fg;
		gameSettings34.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyFsr3Fg(value, EFFXFIApplyMode.Default));
		gameSettings34.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFsr3Fg());
		this.fsr3Fg = gameSettings34;
		GameSettings gameSettings35 = new GameSettings();
		gameSettings35.GameSettingId = EFunction.FSR3_QUALITY;
		gameSettings35.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Fsr3Quality;
		gameSettings35.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyFsr3Quality(value));
		gameSettings35.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFsr3Quality());
		this.fsr3Quality = gameSettings35;
		GameSettings gameSettings36 = new GameSettings();
		gameSettings36.GameSettingId = EFunction.PSSR;
		gameSettings36.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PssrEnable;
		gameSettings36.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyPssrEnable(value, reason));
		gameSettings36.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpPssr());
		this.pssr = gameSettings36;
		GameSettings gameSettings37 = new GameSettings();
		gameSettings37.GameSettingId = EFunction.METALFX;
		gameSettings37.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MetalFxEnable;
		gameSettings37.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMetalFxEnable(value));
		gameSettings37.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMetalFxEnable());
		this.metalFxEnable = gameSettings37;
		GameSettings gameSettings38 = new GameSettings();
		gameSettings38.GameSettingId = EFunction.IRX;
		gameSettings38.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IrxEnable;
		gameSettings38.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyIrxEnable(value));
		gameSettings38.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIrx());
		this.irx = gameSettings38;
		GameSettings gameSettings39 = new GameSettings();
		gameSettings39.GameSettingId = EFunction.BLOOM;
		gameSettings39.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.BloomEnable;
		gameSettings39.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyBloomEnable(value));
		gameSettings39.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpBloom());
		this.bloom = gameSettings39;
		GameSettings gameSettings40 = new GameSettings();
		gameSettings40.GameSettingId = EFunction.VOLUMEFOG;
		gameSettings40.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VolumeFog;
		gameSettings40.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolumeFog(value));
		gameSettings40.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolumeFog());
		this.volumeFog = gameSettings40;
		GameSettings gameSettings41 = new GameSettings();
		gameSettings41.GameSettingId = EFunction.VOLUMELIGHT;
		gameSettings41.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VolumeLight;
		gameSettings41.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolumeLight(value));
		gameSettings41.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolumeLight());
		this.volumeLight = gameSettings41;
		GameSettings gameSettings42 = new GameSettings();
		gameSettings42.GameSettingId = EFunction.MOTIONBLUR;
		gameSettings42.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotionBlur;
		gameSettings42.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMotionBlur((float)value));
		gameSettings42.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMotionBlur());
		this.motionBlur = gameSettings42;
		GameSettings gameSettings43 = new GameSettings();
		gameSettings43.GameSettingId = EFunction.PCVSYNC;
		gameSettings43.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PcVsync;
		gameSettings43.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyPcVsync(value));
		gameSettings43.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpPcVsync());
		this.pcvSync = gameSettings43;
		GameSettings gameSettings44 = new GameSettings();
		gameSettings44.GameSettingId = EFunction.MOBILERESOLUTION;
		gameSettings44.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileResolution;
		gameSettings44.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMobileResolution(value));
		gameSettings44.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMobileResolution());
		this.mobileResolution = gameSettings44;
		GameSettings gameSettings45 = new GameSettings();
		gameSettings45.GameSettingId = EFunction.SUPERRESOLUTION;
		gameSettings45.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SuperResolution;
		gameSettings45.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings45.DumpCallback = (() => "[DumpVoicePackManager]this is just a null entry");
		this.superResolution = gameSettings45;
		GameSettings gameSettings46 = new GameSettings();
		gameSettings46.GameSettingId = EFunction.TEXTLANGUAGE;
		gameSettings46.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.TextLanguage;
		gameSettings46.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenGameStart)
			{
				return GameSettingsUtils.ApplyTextLanguageOnGameStart(value);
			}
			return GameSettingsUtils.ApplyTextLanguage(value);
		};
		gameSettings46.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpTextLanguage());
		this.textLanguage = gameSettings46;
		GameSettings gameSettings47 = new GameSettings();
		gameSettings47.GameSettingId = EFunction.VOICELANGUAGE;
		gameSettings47.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VoiceLanguage;
		gameSettings47.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyLanguageAudio(value));
		gameSettings47.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVoiceLanguage());
		this.voiceLanguage = gameSettings47;
		GameSettings gameSettings48 = new GameSettings();
		gameSettings48.GameSettingId = EFunction.VOICEPACKMANAGER;
		gameSettings48.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings48.DumpCallback = (() => "[DumpVoicePackManager]this is just a switch entry");
		this.voicePackManager = gameSettings48;
		GameSettings gameSettings49 = new GameSettings();
		gameSettings49.GameSettingId = EFunction.VOICEROLECUSTOM;
		gameSettings49.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings49.DumpCallback = (() => "[DumpVoicePackManager]this is just a switch entry");
		this.voiceRoleCustomManager = gameSettings49;
		GameSettings gameSettings50 = new GameSettings();
		gameSettings50.GameSettingId = EFunction.ADVICESETTING;
		gameSettings50.GetCallbackOrGlobalKey = new Func<int>(() => (AdviceModel.Instance.GetAdviceShowSetting() > false) ? 1 : 0);
		gameSettings50.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				AdviceController.Instance.RequestSetAdviceShowState(value == 1);
			}
			return false;
		};
		gameSettings50.DumpCallback = (() => "[DumpAdviceSetting]same to getter");
		this.adviceSetting = gameSettings50;
		GameSettings gameSettings51 = new GameSettings();
		gameSettings51.GameSettingId = EFunction.GENDERSETTING;
		gameSettings51.GetCallbackOrGlobalKey = new Func<int>(delegate()
		{
			int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
			if (curSelectMainRoleId == null)
			{
				return 0;
			}
			MainRoleConfig? mainRoleById = RoleConfig.Instance.GetMainRoleById(curSelectMainRoleId.Value);
			if (mainRoleById == null)
			{
				return 0;
			}
			return mainRoleById.Value.Gender;
		});
		gameSettings51.DumpCallback = (() => "[DumpGenderSetting]same to getter");
		this.genderSetting = gameSettings51;
		GameSettings gameSettings52 = new GameSettings();
		gameSettings52.GameSettingId = EFunction.HorizontalViewSensitivity;
		gameSettings52.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HorizontalViewSensitivity;
		gameSettings52.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Platform.Instance.IsCloudGame())
			{
				GameSettingsUtils.ApplyMobileHorizontalViewSensitivity((float)value);
			}
			else
			{
				GameSettingsUtils.ApplyHorizontalViewSensitivity((float)value);
			}
			return true;
		};
		gameSettings52.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHorizontalViewSensitivity());
		this.horizontalViewSensitivity = gameSettings52;
		GameSettings gameSettings53 = new GameSettings();
		gameSettings53.GameSettingId = EFunction.VerticalViewSensitivity;
		gameSettings53.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VerticalViewSensitivity;
		gameSettings53.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Platform.Instance.IsCloudGame())
			{
				GameSettingsUtils.ApplyMobileVerticalViewSensitivity((float)value);
			}
			else
			{
				GameSettingsUtils.ApplyVerticalViewSensitivity((float)value);
			}
			return true;
		};
		gameSettings53.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVerticalViewSensitivity());
		this.verticalViewSensitivity = gameSettings53;
		GameSettings gameSettings54 = new GameSettings();
		gameSettings54.GameSettingId = EFunction.AimHorizontalViewSensitivity;
		gameSettings54.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimHorizontalViewSensitivity;
		gameSettings54.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Platform.Instance.IsCloudGame())
			{
				GameSettingsUtils.ApplyMobileAimHorizontalViewSensitivity((float)value);
			}
			else
			{
				GameSettingsUtils.ApplyAimHorizontalViewSensitivity((float)value);
			}
			return true;
		};
		gameSettings54.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimHorizontalViewSensitivity());
		this.aimHorizontalViewSensitivity = gameSettings54;
		GameSettings gameSettings55 = new GameSettings();
		gameSettings55.GameSettingId = EFunction.AimVerticalViewSensitivity;
		gameSettings55.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimVerticalViewSensitivity;
		gameSettings55.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Platform.Instance.IsCloudGame())
			{
				GameSettingsUtils.ApplyMobileAimVerticalViewSensitivity((float)value);
			}
			else
			{
				GameSettingsUtils.ApplyAimVerticalViewSensitivity((float)value);
			}
			return true;
		};
		gameSettings55.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimVerticalViewSensitivity());
		this.aimVerticalViewSensitivity = gameSettings55;
		GameSettings gameSettings56 = new GameSettings();
		gameSettings56.GameSettingId = EFunction.CameraShakeStrength;
		gameSettings56.ValueType = EGameSettingsValueType.Float;
		gameSettings56.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.CameraShakeStrength;
		gameSettings56.ApplyCallbackFloat = delegate(float value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyCameraShakeStrength(value);
			return true;
		};
		gameSettings56.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpCameraShakeStrength());
		this.cameraShakeStrength = gameSettings56;
		GameSettings gameSettings57 = new GameSettings();
		gameSettings57.GameSettingId = EFunction.MobileHorizontalViewSensitivity;
		gameSettings57.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileHorizontalViewSensitivity;
		gameSettings57.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileHorizontalViewSensitivity((float)value);
			return true;
		};
		gameSettings57.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHorizontalViewSensitivity());
		this.mobileHorizontalViewSensitivity = gameSettings57;
		GameSettings gameSettings58 = new GameSettings();
		gameSettings58.GameSettingId = EFunction.MobileVerticalViewSensitivity;
		gameSettings58.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileVerticalViewSensitivity;
		gameSettings58.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileVerticalViewSensitivity((float)value);
			return true;
		};
		gameSettings58.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVerticalViewSensitivity());
		this.mobileVerticalViewSensitivity = gameSettings58;
		GameSettings gameSettings59 = new GameSettings();
		gameSettings59.GameSettingId = EFunction.MobileAimHorizontalViewSensitivity;
		gameSettings59.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileAimHorizontalViewSensitivity;
		gameSettings59.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileAimHorizontalViewSensitivity((float)value);
			return true;
		};
		gameSettings59.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimHorizontalViewSensitivity());
		this.mobileAimHorizontalViewSensitivity = gameSettings59;
		GameSettings gameSettings60 = new GameSettings();
		gameSettings60.GameSettingId = EFunction.MobileAimVerticalViewSensitivity;
		gameSettings60.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileAimVerticalViewSensitivity;
		gameSettings60.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileAimVerticalViewSensitivity((float)value);
			return true;
		};
		gameSettings60.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimVerticalViewSensitivity());
		this.mobileAimVerticalViewSensitivity = gameSettings60;
		GameSettings gameSettings61 = new GameSettings();
		gameSettings61.GameSettingId = EFunction.CommonSpringArmLength;
		gameSettings61.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.CommonSpringArmLength;
		gameSettings61.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyCommonSpringArmLength((float)value);
			return true;
		};
		gameSettings61.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpCommonSpringArmLength());
		this.commonSpringArmLength = gameSettings61;
		GameSettings gameSettings62 = new GameSettings();
		gameSettings62.GameSettingId = EFunction.FightSpringArmLength;
		gameSettings62.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FightSpringArmLength;
		gameSettings62.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyFightSpringArmLength((float)value);
			return true;
		};
		gameSettings62.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFightSpringArmLength());
		this.fightSpringArmLength = gameSettings62;
		GameSettings gameSettings63 = new GameSettings();
		gameSettings63.GameSettingId = EFunction.ResetFocusEnable;
		gameSettings63.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsResetFocusEnable;
		gameSettings63.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyResetFocusEnable(value);
			return true;
		};
		gameSettings63.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpResetFocusEnable());
		this.resetFocusEnable = gameSettings63;
		GameSettings gameSettings64 = new GameSettings();
		gameSettings64.GameSettingId = EFunction.IsSidestepCameraEnable;
		gameSettings64.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsSidestepCameraEnable;
		gameSettings64.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyIsSidestepCameraEnable(value);
			return true;
		};
		gameSettings64.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIsSidestepCameraEnable());
		this.isSidestepCameraEnable = gameSettings64;
		GameSettings gameSettings65 = new GameSettings();
		gameSettings65.GameSettingId = EFunction.IsSoftLockCameraEnable;
		gameSettings65.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsSoftLockCameraEnable;
		gameSettings65.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyIsSoftLockCameraEnable(value);
			return true;
		};
		gameSettings65.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIsSoftLockCameraEnable());
		this.isSoftLockCameraEnable = gameSettings65;
		GameSettings gameSettings66 = new GameSettings();
		gameSettings66.GameSettingId = EFunction.JoystickShakeStrength;
		gameSettings66.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickShakeStrength;
		gameSettings66.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyJoystickShakeStrength(value));
		gameSettings66.DumpCallback = (() => "[DumpJoystickShakeStrength]no way to dump");
		this.joystickShakeStrength = gameSettings66;
		GameSettings gameSettings67 = new GameSettings();
		gameSettings67.GameSettingId = EFunction.JoystickShakeType;
		gameSettings67.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickShakeType;
		gameSettings67.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyJoystickShakeType(value));
		gameSettings67.DumpCallback = (() => "[DumpJoystickShakeType]no way to dump");
		this.joystickShakeType = gameSettings67;
		GameSettings gameSettings68 = new GameSettings();
		gameSettings68.GameSettingId = EFunction.WalkOrRunRate;
		gameSettings68.ValueType = EGameSettingsValueType.Float;
		gameSettings68.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.WalkOrRunRate;
		gameSettings68.ApplyCallbackFloat = delegate(float value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyWalkOrRunRate(value);
			return true;
		};
		gameSettings68.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpWalkOrRunRate());
		this.walkOrRunRate = gameSettings68;
		GameSettings gameSettings69 = new GameSettings();
		gameSettings69.GameSettingId = EFunction.JoystickMode;
		gameSettings69.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickMode;
		gameSettings69.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyJoystickMode(value);
			return true;
		};
		gameSettings69.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpJoystickMode());
		this.joystickMode = gameSettings69;
		GameSettings gameSettings70 = new GameSettings();
		gameSettings70.GameSettingId = EFunction.MobileButtonCustom;
		gameSettings70.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings70.DumpCallback = (() => "[mobileButtonCustom]this is just a switch entry");
		this.mobileButtonCustom = gameSettings70;
		GameSettings gameSettings71 = new GameSettings();
		gameSettings71.GameSettingId = EFunction.SkillButtonMode;
		gameSettings71.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsAutoSwitchSkillButtonMode;
		gameSettings71.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAutoSwitchSkillButtonMode(value);
			return true;
		};
		gameSettings71.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSkillButtonMode());
		this.skillButtonMode = gameSettings71;
		GameSettings gameSettings72 = new GameSettings();
		gameSettings72.GameSettingId = EFunction.CdKey;
		gameSettings72.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings72.DumpCallback = (() => "[DumpCdKey]this is just a switch entry");
		this.cdKey = gameSettings72;
		GameSettings gameSettings73 = new GameSettings();
		gameSettings73.GameSettingId = EFunction.ResDownLoad;
		gameSettings73.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings73.DumpCallback = (() => "[resDownLoad]SubPackageDownLoad");
		this.resDownLoad = gameSettings73;
		GameSettings gameSettings74 = new GameSettings();
		gameSettings74.GameSettingId = EFunction.ResClear;
		gameSettings74.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings74.DumpCallback = (() => "[resClear]SubPackageDownLoadClear");
		this.resClear = gameSettings74;
		GameSettings gameSettings75 = new GameSettings();
		gameSettings75.GameSettingId = EFunction.PushMode;
		gameSettings75.GetCallbackOrGlobalKey = new Func<int>(() => (KuroPushController.Instance.GetPushState() > false) ? 1 : 0);
		gameSettings75.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				GameSettingsUtils.ApplyPushEnableState(value, new EGameSettingsApplyReason?(reason));
				return true;
			}
			return false;
		};
		gameSettings75.DumpCallback = (() => "[DumpPushMode]same to getter");
		this.pushMode = gameSettings75;
		GameSettings gameSettings76 = new GameSettings();
		gameSettings76.GameSettingId = EFunction.AimAssist;
		gameSettings76.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimAssistEnable;
		gameSettings76.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAimAssistEnable(value);
			return true;
		};
		gameSettings76.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimAssist());
		this.aimAssist = gameSettings76;
		GameSettings gameSettings77 = new GameSettings();
		gameSettings77.GameSettingId = EFunction.KeyboardLockEnemyMode;
		gameSettings77.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.KeyboardLockEnemyMode;
		gameSettings77.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyKeyboardLockEnemyMode(value);
			return true;
		};
		gameSettings77.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpKeyboardLockEnemyMode());
		this.keyboardLockEnemyMode = gameSettings77;
		GameSettings gameSettings78 = new GameSettings();
		gameSettings78.GameSettingId = EFunction.HorizontalViewRevert;
		gameSettings78.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HorizontalViewRevert;
		gameSettings78.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Info.Instance.IsInGamepad())
			{
				GameSettingsUtils.ApplyHorizontalViewRevert(value);
			}
			return true;
		};
		gameSettings78.DumpCallback = (() => "[DumpHorizontalViewRevert]no way to dump");
		this.horizontalViewRevert = gameSettings78;
		GameSettings gameSettings79 = new GameSettings();
		gameSettings79.GameSettingId = EFunction.VerticalViewRevert;
		gameSettings79.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VerticalViewRevert;
		gameSettings79.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Info.Instance.IsInGamepad())
			{
				GameSettingsUtils.ApplyVerticalViewRevert(value);
			}
			return true;
		};
		gameSettings79.DumpCallback = (() => "[DumpVerticalViewRevert]no way to dump");
		this.verticalViewRevert = gameSettings79;
		GameSettings gameSettings80 = new GameSettings();
		gameSettings80.GameSettingId = EFunction.SkillLockEnemyMode;
		gameSettings80.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SkillLockEnemyMode;
		gameSettings80.DumpCallback = (() => "[DumpSkillLockEnemyMode]same to getter");
		this.skillLockEnemyMode = gameSettings80;
		GameSettings gameSettings81 = new GameSettings();
		gameSettings81.GameSettingId = EFunction.GamepadLockEnemyMode;
		gameSettings81.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLockEnemyMode;
		gameSettings81.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLockEnemyMode(value);
			return true;
		};
		gameSettings81.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpGamepadLockEnemyMode());
		this.gamepadLockEnemyMode = gameSettings81;
		GameSettings gameSettings82 = new GameSettings();
		gameSettings82.GameSettingId = EFunction.EnemyHitDisplayMode;
		gameSettings82.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EnemyHitDisplayMode;
		gameSettings82.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyEnemyHitDisplayMode(value);
			return true;
		};
		gameSettings82.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEnemyHitDisplayMode());
		this.enemyHitDisplayMode = gameSettings82;
		GameSettings gameSettings83 = new GameSettings();
		gameSettings83.GameSettingId = EFunction.MobileGamepadMode;
		gameSettings83.GetCallbackOrGlobalKey = new Func<int>(() => (PlatformModel.Instance.IsGamepadAttached() > false) ? 1 : 0);
		gameSettings83.DumpCallback = (() => "[DumpMobileGamepadMode]same to getter");
		this.mobileGamepadMode = gameSettings83;
		GameSettings gameSettings84 = new GameSettings();
		gameSettings84.GameSettingId = EFunction.AutoAdjustImageQuality;
		gameSettings84.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoAdjustImageQuality;
		gameSettings84.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAutoAdjustImageQuality(value);
			return true;
		};
		gameSettings84.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoAdjustImageQuality());
		this.autoAdjustImageQuality = gameSettings84;
		GameSettings gameSettings85 = new GameSettings();
		gameSettings85.GameSettingId = EFunction.ShowDamage;
		gameSettings85.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ShowDamage;
		gameSettings85.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyShowDamage(value);
			return true;
		};
		gameSettings85.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpShowDamage());
		this.showDamage = gameSettings85;
		GameSettings gameSettings86 = new GameSettings();
		gameSettings86.GameSettingId = EFunction.DynamicBones;
		gameSettings86.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.DynamicBones;
		gameSettings86.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyDynamicBones(value);
			return true;
		};
		gameSettings86.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpDynamicBones());
		this.dynamicBones = gameSettings86;
		GameSettings gameSettings87 = new GameSettings();
		gameSettings87.GameSettingId = EFunction.UIPureMode;
		gameSettings87.GetCallbackOrGlobalKey = new Func<int>(delegate()
		{
			if (BattleUiModel.Instance.PureModeData == null || !BattleUiModel.Instance.PureModeData.IsOpen)
			{
				return 0;
			}
			return 1;
		});
		gameSettings87.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyUiPureMode(value));
		gameSettings87.DumpCallback = (() => "[DumpUiPureMode]same to getter");
		this.uiPureMode = gameSettings87;
		GameSettings gameSettings88 = new GameSettings();
		gameSettings88.GameSettingId = EFunction.FlyControlMode;
		gameSettings88.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FlyControlMode;
		gameSettings88.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings88.DumpCallback = (() => "[DumpFlyControlMode]same to getter");
		this.flyControlMode = gameSettings88;
		GameSettings gameSettings89 = new GameSettings();
		gameSettings89.GameSettingId = EFunction.DOLBYATOMS;
		gameSettings89.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.DolbyAtmos;
		gameSettings89.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyDolbyAtmos(value);
			return true;
		};
		gameSettings89.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_dolby_atmos"));
		this.dolbyAtmos = gameSettings89;
		GameSettings gameSettings90 = new GameSettings();
		gameSettings90.GameSettingId = EFunction.FlowAdaptation;
		gameSettings90.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FlowAdaptation;
		gameSettings90.DumpCallback = (() => "[DumpFlowAdaptation]same to getter");
		this.flowAdaptation = gameSettings90;
		GameSettings gameSettings91 = new GameSettings();
		gameSettings91.GameSettingId = EFunction.RayTracing;
		gameSettings91.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracing;
		gameSettings91.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracing(value));
		gameSettings91.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracing());
		gameSettings91.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit<int>(EEventName.SetRayTracingWithValue, value);
		};
		this.rayTracing = gameSettings91;
		GameSettings gameSettings92 = new GameSettings();
		gameSettings92.GameSettingId = EFunction.RayTracedReflection;
		gameSettings92.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedReflection;
		gameSettings92.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedReflection(value));
		gameSettings92.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracedReflection());
		this.rayTracedReflection = gameSettings92;
		GameSettings gameSettings93 = new GameSettings();
		gameSettings93.GameSettingId = EFunction.RayTracedGI;
		gameSettings93.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedGI;
		gameSettings93.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedGI(value));
		gameSettings93.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracedGI());
		this.rayTracedGI = gameSettings93;
		GameSettings gameSettings94 = new GameSettings();
		gameSettings94.GameSettingId = EFunction.RayTracedShadow;
		gameSettings94.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedShadow;
		gameSettings94.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedShadow(value));
		gameSettings94.DumpCallback = (() => "[DumpRayTracedShadow]not implemented");
		this.rayTracedShadow = gameSettings94;
		GameSettings gameSettings95 = new GameSettings();
		gameSettings95.GameSettingId = EFunction.TeammateFx;
		gameSettings95.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.TeammateFx;
		gameSettings95.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EffectEnvironment.Instance.DisableOtherEffect = (value == 0);
			return true;
		};
		gameSettings95.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpTeammateFx());
		this.teammateFx = gameSettings95;
		GameSettings gameSettings96 = new GameSettings();
		gameSettings96.GameSettingId = EFunction.Saturation;
		gameSettings96.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SaturationNew;
		gameSettings96.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplySaturationClient(value));
		gameSettings96.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSaturation());
		this.saturation = gameSettings96;
		GameSettings gameSettings97 = new GameSettings();
		gameSettings97.GameSettingId = EFunction.Contrast;
		gameSettings97.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ContrastNew;
		gameSettings97.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyContrastClient(value));
		gameSettings97.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpContrast());
		this.contrast = gameSettings97;
		GameSettings gameSettings98 = new GameSettings();
		gameSettings98.GameSettingId = EFunction.Filter;
		gameSettings98.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings98.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFilter());
		this.filter = gameSettings98;
		GameSettings gameSettings99 = new GameSettings();
		gameSettings99.GameSettingId = EFunction.SkinDamageMode;
		gameSettings99.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SkinDamageMode;
		gameSettings99.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplySkinDamageMode(value);
			return true;
		};
		gameSettings99.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSkinDamageMode());
		this.skinDamageMode = gameSettings99;
		GameSettings gameSettings100 = new GameSettings();
		gameSettings100.GameSettingId = EFunction.PlayStationOnly;
		gameSettings100.GetCallbackOrGlobalKey = new Func<int>(() => (KuroSdkModel.Instance.PlayStationPlayOnlyState > false) ? 1 : 0);
		gameSettings100.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				KuroSdkController.Instance.RequestChangeServerPlayStationPlayOnlyState(value == 1);
			}
			return false;
		};
		gameSettings100.DumpCallback = (() => "[DumpPlayStationOnly]same to getter");
		this.playStationOnly = gameSettings100;
		GameSettings gameSettings101 = new GameSettings();
		gameSettings101.GameSettingId = EFunction.AdrenoFME;
		gameSettings101.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AfmeSince2Dot3;
		gameSettings101.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAFMEOption(value);
			return true;
		};
		gameSettings101.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAdrenoFME());
		this.adrenoFME = gameSettings101;
		GameSettings gameSettings102 = new GameSettings();
		gameSettings102.GameSettingId = EFunction.UserCenterDomestic;
		gameSettings102.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings102.DumpCallback = (() => "[DumpUserCenterDomestic]this is just a switch entry");
		this.userCenterDomestic = gameSettings102;
		GameSettings gameSettings103 = new GameSettings();
		gameSettings103.GameSettingId = EFunction.UserCenterOverseas;
		gameSettings103.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings103.DumpCallback = (() => "[userCenterOverseas]this is just a switch entry");
		this.userCenterOverseas = gameSettings103;
		GameSettings gameSettings104 = new GameSettings();
		gameSettings104.GameSettingId = EFunction.PrivacyPolicyDomestic;
		gameSettings104.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings104.DumpCallback = (() => "[privacyPolicyDomestic]this is just a switch entry");
		this.privacyPolicyDomestic = gameSettings104;
		GameSettings gameSettings105 = new GameSettings();
		gameSettings105.GameSettingId = EFunction.PrivacyPolicyOverSeas;
		gameSettings105.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings105.DumpCallback = (() => "[privacyPolicyOverSeas]this is just a switch entry");
		this.privacyPolicyOverSeas = gameSettings105;
		GameSettings gameSettings106 = new GameSettings();
		gameSettings106.GameSettingId = EFunction.TermsOfUseDomestic;
		gameSettings106.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings106.DumpCallback = (() => "[termsOfUseDomestic]this is just a switch entry");
		this.termsOfUseDomestic = gameSettings106;
		GameSettings gameSettings107 = new GameSettings();
		gameSettings107.GameSettingId = EFunction.TermsOfUseOverSeas;
		gameSettings107.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings107.DumpCallback = (() => "[termsOfUseOverSeas]this is just a switch entry");
		this.termsOfUseOverSeas = gameSettings107;
		GameSettings gameSettings108 = new GameSettings();
		gameSettings108.GameSettingId = EFunction.ChildrenPrivacy;
		gameSettings108.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings108.DumpCallback = (() => "[childrenPrivacy]this is just a switch entry");
		this.childrenPrivacy = gameSettings108;
		GameSettings gameSettings109 = new GameSettings();
		gameSettings109.GameSettingId = EFunction.ThirdPartyInfo;
		gameSettings109.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings109.DumpCallback = (() => "[thirdPartyInfo]this is just a switch entry");
		this.thirdPartyInfo = gameSettings109;
		GameSettings gameSettings110 = new GameSettings();
		gameSettings110.GameSettingId = EFunction.PrivacyPolicySetting;
		gameSettings110.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings110.DumpCallback = (() => "[privacyPolicySetting]this is just a switch entry");
		this.privacyPolicySetting = gameSettings110;
		GameSettings gameSettings111 = new GameSettings();
		gameSettings111.GameSettingId = EFunction.License;
		gameSettings111.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings111.DumpCallback = (() => "[license]this is just a switch entry");
		this.licenseSetting = gameSettings111;
		GameSettings gameSettings112 = new GameSettings();
		gameSettings112.GameSettingId = EFunction.LogUpload;
		gameSettings112.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings112.DumpCallback = (() => "[logUpload]this is just a switch entry");
		this.logUploadSetting = gameSettings112;
		GameSettings gameSettings113 = new GameSettings();
		gameSettings113.GameSettingId = EFunction.BasicGraphicSetting;
		gameSettings113.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings113.DumpCallback = (() => "[basicGraphicSetting]this is just a switch entry");
		this.basicGraphicSetting = gameSettings113;
		GameSettings gameSettings114 = new GameSettings();
		gameSettings114.GameSettingId = EFunction.AutoRun;
		gameSettings114.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoRun;
		gameSettings114.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoRun(value));
		gameSettings114.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoRun());
		this.autoRun = gameSettings114;
		GameSettings gameSettings115 = new GameSettings();
		gameSettings115.GameSettingId = EFunction.AutoSprint;
		gameSettings115.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoSprint;
		gameSettings115.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoSprint(value));
		gameSettings115.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoSprint());
		this.autoSprint = gameSettings115;
		GameSettings gameSettings116 = new GameSettings();
		gameSettings116.GameSettingId = EFunction.Vulkan;
		gameSettings116.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Vulkan;
		gameSettings116.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVulkan(value));
		gameSettings116.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi || reason == EGameSettingsApplyReason.WhenGameStart)
			{
				LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.VulkanChangeFlag, true);
			}
		};
		gameSettings116.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVulkan());
		this.vulkan = gameSettings116;
		GameSettings gameSettings117 = new GameSettings();
		gameSettings117.GameSettingId = EFunction.ShowOtherName;
		gameSettings117.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ShowOtherName;
		gameSettings117.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit(EEventName.RefreshPlayerInfoVisible);
		};
		gameSettings117.DumpCallback = (() => "[DumpAdviceSetting]same to getter");
		this.showOtherName = gameSettings117;
		GameSettings gameSettings118 = new GameSettings();
		gameSettings118.GameSettingId = EFunction.WaterInteract;
		gameSettings118.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.WaterInteract;
		gameSettings118.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyWaterInteract(value));
		gameSettings118.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpWaterInteract());
		this.waterInteract = gameSettings118;
		GameSettings gameSettings119 = new GameSettings();
		gameSettings119.GameSettingId = EFunction.VegetationDither;
		gameSettings119.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VegetationDither;
		gameSettings119.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVegetationDither(value));
		gameSettings119.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVegetationDither());
		this.vegetationDither = gameSettings119;
		GameSettings gameSettings120 = new GameSettings();
		gameSettings120.GameSettingId = EFunction.VegetationDensity;
		gameSettings120.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VegetationDensity;
		gameSettings120.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVegetationDensity(value));
		gameSettings120.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVegetationDensity());
		this.vegetationDensity = gameSettings120;
		GameSettings gameSettings121 = new GameSettings();
		gameSettings121.GameSettingId = EFunction.VersionCheck;
		gameSettings121.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings121.DumpCallback = (() => "");
		this.versionCheck = gameSettings121;
		GameSettings gameSettings122 = new GameSettings();
		gameSettings122.GameSettingId = EFunction.ImageDisplayMode;
		gameSettings122.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ImageDisplayMode;
		gameSettings122.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyImageDisplayMode(value));
		gameSettings122.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpImageDisplayMode());
		this.imageDisplayMode = gameSettings122;
		GameSettings gameSettings123 = new GameSettings();
		gameSettings123.GameSettingId = EFunction.EyeProtection;
		gameSettings123.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtection;
		gameSettings123.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtection());
		this.eyeProtection = gameSettings123;
		GameSettings gameSettings124 = new GameSettings();
		gameSettings124.GameSettingId = EFunction.EyeProtectionMode;
		gameSettings124.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionMode;
		gameSettings124.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionMode(value));
		gameSettings124.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionMode());
		this.eyeProtectionMode = gameSettings124;
		GameSettings gameSettings125 = new GameSettings();
		gameSettings125.GameSettingId = EFunction.EyeProtectionTemp;
		gameSettings125.ValueType = EGameSettingsValueType.Float;
		gameSettings125.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionTemp;
		gameSettings125.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionTemp(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings125.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionTemp());
		this.eyeProtectionTemp = gameSettings125;
		GameSettings gameSettings126 = new GameSettings();
		gameSettings126.GameSettingId = EFunction.EyeProtectionStrength;
		gameSettings126.ValueType = EGameSettingsValueType.Float;
		gameSettings126.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionStrength;
		gameSettings126.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionStrength(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings126.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionStrength());
		this.eyeProtectionStrength = gameSettings126;
		GameSettings gameSettings127 = new GameSettings();
		gameSettings127.GameSettingId = EFunction.EyeProtectionBrightness;
		gameSettings127.ValueType = EGameSettingsValueType.Float;
		gameSettings127.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionBrightness;
		gameSettings127.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionBrightness(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings127.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionBrightness());
		this.eyeProtectionBrightness = gameSettings127;
		GameSettings gameSettings128 = new GameSettings();
		gameSettings128.GameSettingId = EFunction.EyeProtectionTexture;
		gameSettings128.ValueType = EGameSettingsValueType.Float;
		gameSettings128.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionTexture;
		gameSettings128.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionTexture(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings128.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionTexture());
		this.eyeProtectionTexture = gameSettings128;
		GameSettings gameSettings129 = new GameSettings();
		gameSettings129.GameSettingId = EFunction.AutoExposure;
		gameSettings129.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoExposure;
		gameSettings129.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoExposure(value));
		gameSettings129.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoExposure());
		this.autoExposure = gameSettings129;
		GameSettings gameSettings130 = new GameSettings();
		gameSettings130.GameSettingId = EFunction.HarmonySuperResolution;
		gameSettings130.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonySuperResolution;
		gameSettings130.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonySuperResolution(value));
		gameSettings130.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonySuperResolution());
		this.harmonySuperResolution = gameSettings130;
		GameSettings gameSettings131 = new GameSettings();
		gameSettings131.GameSettingId = EFunction.HarmonyRayTracingBoost;
		gameSettings131.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonyRayTracingBoost;
		gameSettings131.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonyRayTracingBoost(value));
		gameSettings131.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonyRayTracingBoost());
		this.harmonyRayTracingBoost = gameSettings131;
		GameSettings gameSettings132 = new GameSettings();
		gameSettings132.GameSettingId = EFunction.HarmonyRayTracingBoostAdvanced;
		gameSettings132.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonyRayTracingBoostAdvanced;
		gameSettings132.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonyRayTracingBoost(value));
		gameSettings132.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonyRayTracingBoost());
		this.harmonyRayTracingBoostAdvanced = gameSettings132;
		GameSettings gameSettings133 = new GameSettings();
		gameSettings133.GameSettingId = EFunction.AdjustiveGamePadTrigger;
		gameSettings133.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AdjustiveGamePadTrigger;
		gameSettings133.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAdjustiveGamePadTrigger(value);
			return true;
		};
		gameSettings133.DumpCallback = (() => "[AdjustiveGamePadTrigger]same to getter");
		this.adjustiveGamePadTrigger = gameSettings133;
		GameSettings gameSettings134 = new GameSettings();
		gameSettings134.GameSettingId = EFunction.GamepadLeftStickDeadZone;
		gameSettings134.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLeftStickDeadZone;
		gameSettings134.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLeftStickDeadZone(value);
			return true;
		};
		gameSettings134.DumpCallback = (() => "[GamepadLeftStickDeadZone]same to getter");
		this.gamepadLeftStickDeadZone = gameSettings134;
		GameSettings gameSettings135 = new GameSettings();
		gameSettings135.GameSettingId = EFunction.GamepadRightStickDeadZone;
		gameSettings135.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadRightStickDeadZone;
		gameSettings135.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadRightStickDeadZone(value);
			return true;
		};
		gameSettings135.DumpCallback = (() => "[GamepadRightStickDeadZone]same to getter");
		this.gamepadRightStickDeadZone = gameSettings135;
		GameSettings gameSettings136 = new GameSettings();
		gameSettings136.GameSettingId = EFunction.GamepadLeftTriggerDeadZone;
		gameSettings136.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLeftTriggerDeadZone;
		gameSettings136.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLeftTriggerDeadZone(value);
			return true;
		};
		gameSettings136.DumpCallback = (() => "[GamepadLeftTriggerDeadZone]same to getter");
		this.gamepadLeftTriggerDeadZone = gameSettings136;
		GameSettings gameSettings137 = new GameSettings();
		gameSettings137.GameSettingId = EFunction.GamepadRightTriggerDeadZone;
		gameSettings137.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadRightTriggerDeadZone;
		gameSettings137.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadRightTriggerDeadZone(value);
			return true;
		};
		gameSettings137.DumpCallback = (() => "[GamepadRightTriggerDeadZone]same to getter");
		this.gamepadRightTriggerDeadZone = gameSettings137;
		GameSettings gameSettings138 = new GameSettings();
		gameSettings138.GameSettingId = EFunction.MotorAutoLongPressSpeedUp;
		gameSettings138.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorAutoLongPressSpeedUp;
		gameSettings138.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorAutoLongPressSpeedUp(value);
			return true;
		};
		gameSettings138.DumpCallback = (() => "[MotorAutoLongPressSpeedUp]same to getter");
		this.motorAccleratePressType = gameSettings138;
		GameSettings gameSettings139 = new GameSettings();
		gameSettings139.GameSettingId = EFunction.MotorAutoAcceleratorSettingEnable;
		gameSettings139.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorAutoAcceleratorSettingEnable;
		gameSettings139.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorAutoAcceleratorSettingEnable(value);
			return true;
		};
		gameSettings139.DumpCallback = (() => "[MotorAutoAcceleratorSettingEnable]same to getter");
		this.motorAutoAcceleratorSettingEnable = gameSettings139;
		GameSettings gameSettings140 = new GameSettings();
		gameSettings140.GameSettingId = EFunction.MotorDriftAcceleratorSettingEnable;
		gameSettings140.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorDriftAcceleratorSettingEnable;
		gameSettings140.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorDriftAcceleratorSettingEnable(value);
			return true;
		};
		gameSettings140.DumpCallback = (() => "[MotorDriftAcceleratorSettingEnable]same to getter");
		this.motorDriftAcceleratorSettingEnable = gameSettings140;
		GameSettings gameSettings141 = new GameSettings();
		gameSettings141.GameSettingId = EFunction.MotorDriftModel;
		gameSettings141.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorDriftModel;
		gameSettings141.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings141.DumpCallback = (() => "[MotorDriftAcceleratorSettingEnable]same to getter");
		this.motorDriftModel = gameSettings141;
		GameSettings gameSettings142 = new GameSettings();
		gameSettings142.GameSettingId = EFunction.MotorHudVisible;
		gameSettings142.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorHudVisible;
		gameSettings142.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorHudVisible(value);
			return true;
		};
		gameSettings142.DumpCallback = (() => "[MotorHudVisible]same to getter");
		this.motorHudVisible = gameSettings142;
		GameSettings gameSettings143 = new GameSettings();
		gameSettings143.GameSettingId = EFunction.SubTitleOption;
		gameSettings143.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SubTitleOption;
		gameSettings143.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings143.DumpCallback = (() => "[SubTitleOption]same to getter");
		this.subTitleOption = gameSettings143;
		GameSettings gameSettings144 = new GameSettings();
		gameSettings144.GameSettingId = EFunction.MotorIsDynamicJoystick;
		gameSettings144.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorIsDynamicJoystick;
		gameSettings144.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorIsDynamicJoystick(value);
			return true;
		};
		gameSettings144.DumpCallback = (() => "[MotorIsDynamicJoystick]same to getter");
		this.motorTouchFixedPosition = gameSettings144;
		GameSettings gameSettings145 = new GameSettings();
		gameSettings145.GameSettingId = EFunction.MotorMobileButtonCustom;
		gameSettings145.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings145.DumpCallback = (() => "[motorMobileButtonCustom]this is just a switch entry");
		this.motorMobileButtonCustom = gameSettings145;
		GameSettings gameSettings146 = new GameSettings();
		gameSettings146.GameSettingId = EFunction.MotorMobileButtonLayout;
		gameSettings146.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorMobileButtonLayout;
		gameSettings146.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			bool value2 = value == 0;
			BattleUiModel.Instance.JoystickData.RefreshMotorMobileButtonLayout(new bool?(value2));
			return true;
		};
		gameSettings146.DumpCallback = (() => "[MotorMobileButtonLayout]same to getter");
		this.motorMobileButtonLayout = gameSettings146;
		GameSettings gameSettings147 = new GameSettings();
		gameSettings147.GameSettingId = EFunction.DeviceInfo;
		gameSettings147.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings147.DumpCallback = (() => "");
		this.deviceInfo = gameSettings147;
		GameSettings gameSettings148 = new GameSettings();
		gameSettings148.GameSettingId = EFunction.UiBrightness;
		gameSettings148.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.UiBrightness;
		gameSettings148.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyUiBrightness((float)value);
			return true;
		};
		gameSettings148.DumpCallback = (() => "[UiBrightness]same to getter");
		this.uiBrightness = gameSettings148;
		GameSettings gameSettings149 = new GameSettings();
		gameSettings149.GameSettingId = EFunction.PeakBrightness;
		gameSettings149.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PeakBrightness;
		gameSettings149.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyPeakBrightness((float)value);
			return true;
		};
		gameSettings149.DumpCallback = (() => "[PeakBrightness]same to getter");
		this.peakBrightness = gameSettings149;
		GameSettings gameSettings150 = new GameSettings();
		gameSettings150.GameSettingId = EFunction.MotorFlyControlMode;
		gameSettings150.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorFlyControlMode;
		gameSettings150.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings150.DumpCallback = (() => "[MotorFlyControlMode]same to getter");
		this.motorFlyControlMode = gameSettings150;
		GameSettings gameSettings151 = new GameSettings();
		gameSettings151.GameSettingId = EFunction.AnisoLevel;
		gameSettings151.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AnisoLevel;
		gameSettings151.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAnisoLevel(value);
			return true;
		};
		gameSettings151.DumpCallback = (() => "[anisoLevel]Anisotropic Level");
		this.anisoLevel = gameSettings151;
		GameSettings gameSettings152 = new GameSettings();
		gameSettings152.GameSettingId = EFunction.XboxOnly;
		gameSettings152.GetCallbackOrGlobalKey = new Func<int>(() => (KuroSdkModel.Instance.XboxPlayOnlyState > false) ? 1 : 0);
		gameSettings152.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				KuroSdkController.Instance.RequestChangeServerXboxPlayOnlyState(value == 1);
			}
			return false;
		};
		gameSettings152.DumpCallback = (() => "[DumpXboxOnly]same to getter");
		this.xboxOnly = gameSettings152;
		base..ctor();
	}

	// Token: 0x0400260D RID: 9741
	public const int HEAVY_SCENEVULUME_INDEX_START = 30;

	// Token: 0x0400260E RID: 9742
	public const int HEAVY_SCENEVULUME_INDEX_END = 39;

	// Token: 0x0400260F RID: 9743
	public const int NPC_DENSITY_THRESHOLD = 1;

	// Token: 0x04002610 RID: 9744
	public const int NPC_DENSITY_PC_THRESHOLD = 1;

	// Token: 0x04002611 RID: 9745
	public const int WINDOWS_RESOLUTION_INDEX = 2;

	// Token: 0x04002612 RID: 9746
	public const int MAIN_TYPE_OF_KEY_SETTING = 3;

	// Token: 0x04002613 RID: 9747
	[Nullable(2)]
	public static EGameSettingsInitSourceType[] gameSettingsInitSourceTypePriority;

	// Token: 0x04002614 RID: 9748
	public GameSettings masterVolume;

	// Token: 0x04002615 RID: 9749
	public GameSettings voiceVolume;

	// Token: 0x04002616 RID: 9750
	public GameSettings musicVolume;

	// Token: 0x04002617 RID: 9751
	public GameSettings sfxVolume;

	// Token: 0x04002618 RID: 9752
	public GameSettings uiVolume;

	// Token: 0x04002619 RID: 9753
	public GameSettings ambVolume;

	// Token: 0x0400261A RID: 9754
	public GameSettings backendVolume;

	// Token: 0x0400261B RID: 9755
	public GameSettings imageQuality;

	// Token: 0x0400261C RID: 9756
	public GameSettings loadingRangeScaleLevel;

	// Token: 0x0400261D RID: 9757
	public GameSettings displayMode;

	// Token: 0x0400261E RID: 9758
	public GameSettings resourceStandard;

	// Token: 0x0400261F RID: 9759
	public GameSettings resolution;

	// Token: 0x04002620 RID: 9760
	public GameSettings brightness;

	// Token: 0x04002621 RID: 9761
	public GameSettings highestFps;

	// Token: 0x04002622 RID: 9762
	public GameSettings shadowQuality;

	// Token: 0x04002623 RID: 9763
	public GameSettings niagaraQuality;

	// Token: 0x04002624 RID: 9764
	public GameSettings imageDetail;

	// Token: 0x04002625 RID: 9765
	public GameSettings antiAliasing;

	// Token: 0x04002626 RID: 9766
	public GameSettings sceneAo;

	// Token: 0x04002627 RID: 9767
	public GameSettings npcDensity;

	// Token: 0x04002628 RID: 9768
	public GameSettings nvidiaDlss;

	// Token: 0x04002629 RID: 9769
	public GameSettings nvidiaDlssFg;

	// Token: 0x0400262A RID: 9770
	public GameSettings nvidiaDlssQuality;

	// Token: 0x0400262B RID: 9771
	public GameSettings nvidiaDlssSharpness;

	// Token: 0x0400262C RID: 9772
	public GameSettings nvidiaReflex;

	// Token: 0x0400262D RID: 9773
	public GameSettings hdr;

	// Token: 0x0400262E RID: 9774
	public GameSettings fsr;

	// Token: 0x0400262F RID: 9775
	public GameSettings xess;

	// Token: 0x04002630 RID: 9776
	public GameSettings xessQuality;

	// Token: 0x04002631 RID: 9777
	public GameSettings xess2;

	// Token: 0x04002632 RID: 9778
	public GameSettings xess2Fg;

	// Token: 0x04002633 RID: 9779
	public GameSettings xess2Quality;

	// Token: 0x04002634 RID: 9780
	public GameSettings fsr3;

	// Token: 0x04002635 RID: 9781
	public GameSettings fsr3Fg;

	// Token: 0x04002636 RID: 9782
	public GameSettings fsr3Quality;

	// Token: 0x04002637 RID: 9783
	public GameSettings pssr;

	// Token: 0x04002638 RID: 9784
	public GameSettings metalFxEnable;

	// Token: 0x04002639 RID: 9785
	public GameSettings irx;

	// Token: 0x0400263A RID: 9786
	public GameSettings bloom;

	// Token: 0x0400263B RID: 9787
	public GameSettings volumeFog;

	// Token: 0x0400263C RID: 9788
	public GameSettings volumeLight;

	// Token: 0x0400263D RID: 9789
	public GameSettings motionBlur;

	// Token: 0x0400263E RID: 9790
	public GameSettings pcvSync;

	// Token: 0x0400263F RID: 9791
	public GameSettings mobileResolution;

	// Token: 0x04002640 RID: 9792
	public GameSettings superResolution;

	// Token: 0x04002641 RID: 9793
	public GameSettings textLanguage;

	// Token: 0x04002642 RID: 9794
	public GameSettings voiceLanguage;

	// Token: 0x04002643 RID: 9795
	public GameSettings voicePackManager;

	// Token: 0x04002644 RID: 9796
	public GameSettings voiceRoleCustomManager;

	// Token: 0x04002645 RID: 9797
	public GameSettings adviceSetting;

	// Token: 0x04002646 RID: 9798
	public GameSettings genderSetting;

	// Token: 0x04002647 RID: 9799
	public GameSettings horizontalViewSensitivity;

	// Token: 0x04002648 RID: 9800
	public GameSettings verticalViewSensitivity;

	// Token: 0x04002649 RID: 9801
	public GameSettings aimHorizontalViewSensitivity;

	// Token: 0x0400264A RID: 9802
	public GameSettings aimVerticalViewSensitivity;

	// Token: 0x0400264B RID: 9803
	public GameSettings cameraShakeStrength;

	// Token: 0x0400264C RID: 9804
	public GameSettings mobileHorizontalViewSensitivity;

	// Token: 0x0400264D RID: 9805
	public GameSettings mobileVerticalViewSensitivity;

	// Token: 0x0400264E RID: 9806
	public GameSettings mobileAimHorizontalViewSensitivity;

	// Token: 0x0400264F RID: 9807
	public GameSettings mobileAimVerticalViewSensitivity;

	// Token: 0x04002650 RID: 9808
	public GameSettings commonSpringArmLength;

	// Token: 0x04002651 RID: 9809
	public GameSettings fightSpringArmLength;

	// Token: 0x04002652 RID: 9810
	public GameSettings resetFocusEnable;

	// Token: 0x04002653 RID: 9811
	public GameSettings isSidestepCameraEnable;

	// Token: 0x04002654 RID: 9812
	public GameSettings isSoftLockCameraEnable;

	// Token: 0x04002655 RID: 9813
	public GameSettings joystickShakeStrength;

	// Token: 0x04002656 RID: 9814
	public GameSettings joystickShakeType;

	// Token: 0x04002657 RID: 9815
	public GameSettings walkOrRunRate;

	// Token: 0x04002658 RID: 9816
	public GameSettings joystickMode;

	// Token: 0x04002659 RID: 9817
	public GameSettings mobileButtonCustom;

	// Token: 0x0400265A RID: 9818
	public GameSettings skillButtonMode;

	// Token: 0x0400265B RID: 9819
	public GameSettings cdKey;

	// Token: 0x0400265C RID: 9820
	public GameSettings resDownLoad;

	// Token: 0x0400265D RID: 9821
	public GameSettings resClear;

	// Token: 0x0400265E RID: 9822
	public GameSettings pushMode;

	// Token: 0x0400265F RID: 9823
	public GameSettings aimAssist;

	// Token: 0x04002660 RID: 9824
	public GameSettings keyboardLockEnemyMode;

	// Token: 0x04002661 RID: 9825
	public GameSettings horizontalViewRevert;

	// Token: 0x04002662 RID: 9826
	public GameSettings verticalViewRevert;

	// Token: 0x04002663 RID: 9827
	public GameSettings skillLockEnemyMode;

	// Token: 0x04002664 RID: 9828
	public GameSettings gamepadLockEnemyMode;

	// Token: 0x04002665 RID: 9829
	public GameSettings enemyHitDisplayMode;

	// Token: 0x04002666 RID: 9830
	public GameSettings mobileGamepadMode;

	// Token: 0x04002667 RID: 9831
	public GameSettings autoAdjustImageQuality;

	// Token: 0x04002668 RID: 9832
	public GameSettings showDamage;

	// Token: 0x04002669 RID: 9833
	public GameSettings dynamicBones;

	// Token: 0x0400266A RID: 9834
	public GameSettings uiPureMode;

	// Token: 0x0400266B RID: 9835
	public GameSettings flyControlMode;

	// Token: 0x0400266C RID: 9836
	public GameSettings dolbyAtmos;

	// Token: 0x0400266D RID: 9837
	public GameSettings flowAdaptation;

	// Token: 0x0400266E RID: 9838
	public GameSettings rayTracing;

	// Token: 0x0400266F RID: 9839
	public GameSettings rayTracedReflection;

	// Token: 0x04002670 RID: 9840
	public GameSettings rayTracedGI;

	// Token: 0x04002671 RID: 9841
	public GameSettings rayTracedShadow;

	// Token: 0x04002672 RID: 9842
	public GameSettings teammateFx;

	// Token: 0x04002673 RID: 9843
	public GameSettings saturation;

	// Token: 0x04002674 RID: 9844
	public GameSettings contrast;

	// Token: 0x04002675 RID: 9845
	public GameSettings filter;

	// Token: 0x04002676 RID: 9846
	public GameSettings skinDamageMode;

	// Token: 0x04002677 RID: 9847
	public GameSettings playStationOnly;

	// Token: 0x04002678 RID: 9848
	public GameSettings adrenoFME;

	// Token: 0x04002679 RID: 9849
	public GameSettings userCenterDomestic;

	// Token: 0x0400267A RID: 9850
	public GameSettings userCenterOverseas;

	// Token: 0x0400267B RID: 9851
	public GameSettings privacyPolicyDomestic;

	// Token: 0x0400267C RID: 9852
	public GameSettings privacyPolicyOverSeas;

	// Token: 0x0400267D RID: 9853
	public GameSettings termsOfUseDomestic;

	// Token: 0x0400267E RID: 9854
	public GameSettings termsOfUseOverSeas;

	// Token: 0x0400267F RID: 9855
	public GameSettings childrenPrivacy;

	// Token: 0x04002680 RID: 9856
	public GameSettings thirdPartyInfo;

	// Token: 0x04002681 RID: 9857
	public GameSettings privacyPolicySetting;

	// Token: 0x04002682 RID: 9858
	public GameSettings licenseSetting;

	// Token: 0x04002683 RID: 9859
	public GameSettings logUploadSetting;

	// Token: 0x04002684 RID: 9860
	public GameSettings basicGraphicSetting;

	// Token: 0x04002685 RID: 9861
	public GameSettings autoRun;

	// Token: 0x04002686 RID: 9862
	public GameSettings autoSprint;

	// Token: 0x04002687 RID: 9863
	public GameSettings vulkan;

	// Token: 0x04002688 RID: 9864
	public GameSettings showOtherName;

	// Token: 0x04002689 RID: 9865
	public GameSettings waterInteract;

	// Token: 0x0400268A RID: 9866
	public GameSettings vegetationDither;

	// Token: 0x0400268B RID: 9867
	public GameSettings vegetationDensity;

	// Token: 0x0400268C RID: 9868
	public GameSettings versionCheck;

	// Token: 0x0400268D RID: 9869
	public GameSettings imageDisplayMode;

	// Token: 0x0400268E RID: 9870
	public GameSettings eyeProtection;

	// Token: 0x0400268F RID: 9871
	public GameSettings eyeProtectionMode;

	// Token: 0x04002690 RID: 9872
	public GameSettings eyeProtectionTemp;

	// Token: 0x04002691 RID: 9873
	public GameSettings eyeProtectionStrength;

	// Token: 0x04002692 RID: 9874
	public GameSettings eyeProtectionBrightness;

	// Token: 0x04002693 RID: 9875
	public GameSettings eyeProtectionTexture;

	// Token: 0x04002694 RID: 9876
	public GameSettings autoExposure;

	// Token: 0x04002695 RID: 9877
	public GameSettings harmonySuperResolution;

	// Token: 0x04002696 RID: 9878
	public GameSettings harmonyRayTracingBoost;

	// Token: 0x04002697 RID: 9879
	public GameSettings harmonyRayTracingBoostAdvanced;

	// Token: 0x04002698 RID: 9880
	public GameSettings adjustiveGamePadTrigger;

	// Token: 0x04002699 RID: 9881
	public GameSettings gamepadLeftStickDeadZone;

	// Token: 0x0400269A RID: 9882
	public GameSettings gamepadRightStickDeadZone;

	// Token: 0x0400269B RID: 9883
	public GameSettings gamepadLeftTriggerDeadZone;

	// Token: 0x0400269C RID: 9884
	public GameSettings gamepadRightTriggerDeadZone;

	// Token: 0x0400269D RID: 9885
	public GameSettings motorAccleratePressType;

	// Token: 0x0400269E RID: 9886
	public GameSettings motorAutoAcceleratorSettingEnable;

	// Token: 0x0400269F RID: 9887
	public GameSettings motorDriftAcceleratorSettingEnable;

	// Token: 0x040026A0 RID: 9888
	public GameSettings motorDriftModel;

	// Token: 0x040026A1 RID: 9889
	public GameSettings motorHudVisible;

	// Token: 0x040026A2 RID: 9890
	public GameSettings subTitleOption;

	// Token: 0x040026A3 RID: 9891
	public GameSettings motorTouchFixedPosition;

	// Token: 0x040026A4 RID: 9892
	public GameSettings motorMobileButtonCustom;

	// Token: 0x040026A5 RID: 9893
	public GameSettings motorMobileButtonLayout;

	// Token: 0x040026A6 RID: 9894
	public GameSettings deviceInfo;

	// Token: 0x040026A7 RID: 9895
	public GameSettings uiBrightness;

	// Token: 0x040026A8 RID: 9896
	public GameSettings peakBrightness;

	// Token: 0x040026A9 RID: 9897
	public GameSettings motorFlyControlMode;

	// Token: 0x040026AA RID: 9898
	public GameSettings anisoLevel;

	// Token: 0x040026AB RID: 9899
	public GameSettings xboxOnly;

	// Token: 0x040026AC RID: 9900
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EFunction, IGameSettings> function2GameSettings;

	// Token: 0x02006609 RID: 26121
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021C31 RID: 138289
		[Nullable(0)]
		public static Func<int, EGameSettingsApplyReason, bool> <0>__ApplyNvidiaSuperSamplingEnable;
	}
}
