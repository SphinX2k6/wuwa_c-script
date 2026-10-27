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

// Token: 0x02000DCF RID: 3535
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDefine : IStaticVariableResetter
{
	// Token: 0x0600539B RID: 21403 RVA: 0x000E5C42 File Offset: 0x000E3E42
	static GameSettingsDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDefine.CreateStaticDefaultValue), new Action(GameSettingsDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x000E5C64 File Offset: 0x000E3E64
	public static void CreateStaticDefaultValue()
	{
		GameSettingsDefine.gameSettingsInitSourceTypePriority = new EGameSettingsInitSourceType[]
		{
			EGameSettingsInitSourceType.CloudOverride,
			EGameSettingsInitSourceType.RecommendQualityOverride,
			EGameSettingsInitSourceType.LoginOverride,
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

	// Token: 0x0600539D RID: 21405 RVA: 0x000E65C6 File Offset: 0x000E47C6
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDefine.gameSettingsInitSourceTypePriority = null;
		GameSettingsDefine.function2GameSettings = null;
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x000E65D4 File Offset: 0x000E47D4
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
		gameSettings9.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.LoadingRangeScaleLevel;
		gameSettings9.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyLoadingRangeScaleLevel(value));
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
		gameSettings36.GameSettingId = EFunction.METALFX;
		gameSettings36.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MetalFxEnable;
		gameSettings36.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMetalFxEnable(value));
		gameSettings36.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMetalFxEnable());
		this.metalFxEnable = gameSettings36;
		GameSettings gameSettings37 = new GameSettings();
		gameSettings37.GameSettingId = EFunction.IRX;
		gameSettings37.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IrxEnable;
		gameSettings37.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyIrxEnable(value));
		gameSettings37.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIrx());
		this.irx = gameSettings37;
		GameSettings gameSettings38 = new GameSettings();
		gameSettings38.GameSettingId = EFunction.BLOOM;
		gameSettings38.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.BloomEnable;
		gameSettings38.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyBloomEnable(value));
		gameSettings38.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpBloom());
		this.bloom = gameSettings38;
		GameSettings gameSettings39 = new GameSettings();
		gameSettings39.GameSettingId = EFunction.VOLUMEFOG;
		gameSettings39.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VolumeFog;
		gameSettings39.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolumeFog(value));
		gameSettings39.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolumeFog());
		this.volumeFog = gameSettings39;
		GameSettings gameSettings40 = new GameSettings();
		gameSettings40.GameSettingId = EFunction.VOLUMELIGHT;
		gameSettings40.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VolumeLight;
		gameSettings40.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVolumeLight(value));
		gameSettings40.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolumeLight());
		this.volumeLight = gameSettings40;
		GameSettings gameSettings41 = new GameSettings();
		gameSettings41.GameSettingId = EFunction.MOTIONBLUR;
		gameSettings41.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotionBlur;
		gameSettings41.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMotionBlur((float)value));
		gameSettings41.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMotionBlur());
		this.motionBlur = gameSettings41;
		GameSettings gameSettings42 = new GameSettings();
		gameSettings42.GameSettingId = EFunction.PCVSYNC;
		gameSettings42.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PcVsync;
		gameSettings42.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyPcVsync(value));
		gameSettings42.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpPcVsync());
		this.pcvSync = gameSettings42;
		GameSettings gameSettings43 = new GameSettings();
		gameSettings43.GameSettingId = EFunction.MOBILERESOLUTION;
		gameSettings43.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileResolution;
		gameSettings43.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyMobileResolution(value));
		gameSettings43.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpMobileResolution());
		this.mobileResolution = gameSettings43;
		GameSettings gameSettings44 = new GameSettings();
		gameSettings44.GameSettingId = EFunction.SUPERRESOLUTION;
		gameSettings44.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SuperResolution;
		gameSettings44.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings44.DumpCallback = (() => "[DumpVoicePackManager]this is just a null entry");
		this.superResolution = gameSettings44;
		GameSettings gameSettings45 = new GameSettings();
		gameSettings45.GameSettingId = EFunction.TEXTLANGUAGE;
		gameSettings45.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.TextLanguage;
		gameSettings45.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenGameStart)
			{
				return GameSettingsUtils.ApplyTextLanguageOnGameStart(value);
			}
			return GameSettingsUtils.ApplyTextLanguage(value);
		};
		gameSettings45.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpTextLanguage());
		this.textLanguage = gameSettings45;
		GameSettings gameSettings46 = new GameSettings();
		gameSettings46.GameSettingId = EFunction.VOICELANGUAGE;
		gameSettings46.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VoiceLanguage;
		gameSettings46.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyLanguageAudio(value));
		gameSettings46.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVoiceLanguage());
		this.voiceLanguage = gameSettings46;
		GameSettings gameSettings47 = new GameSettings();
		gameSettings47.GameSettingId = EFunction.VOICEPACKMANAGER;
		gameSettings47.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings47.DumpCallback = (() => "[DumpVoicePackManager]this is just a switch entry");
		this.voicePackManager = gameSettings47;
		GameSettings gameSettings48 = new GameSettings();
		gameSettings48.GameSettingId = EFunction.VOICEROLECUSTOM;
		gameSettings48.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings48.DumpCallback = (() => "[DumpVoicePackManager]this is just a switch entry");
		this.voiceRoleCustomManager = gameSettings48;
		GameSettings gameSettings49 = new GameSettings();
		gameSettings49.GameSettingId = EFunction.ADVICESETTING;
		gameSettings49.GetCallbackOrGlobalKey = new Func<int>(() => (AdviceModel.Instance.GetAdviceShowSetting() > false) ? 1 : 0);
		gameSettings49.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				AdviceController.Instance.RequestSetAdviceShowState(value == 1);
			}
			return false;
		};
		gameSettings49.DumpCallback = (() => "[DumpAdviceSetting]same to getter");
		this.adviceSetting = gameSettings49;
		GameSettings gameSettings50 = new GameSettings();
		gameSettings50.GameSettingId = EFunction.GENDERSETTING;
		gameSettings50.GetCallbackOrGlobalKey = new Func<int>(delegate()
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
		gameSettings50.DumpCallback = (() => "[DumpGenderSetting]same to getter");
		this.genderSetting = gameSettings50;
		GameSettings gameSettings51 = new GameSettings();
		gameSettings51.GameSettingId = EFunction.HorizontalViewSensitivity;
		gameSettings51.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HorizontalViewSensitivity;
		gameSettings51.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
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
		gameSettings51.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHorizontalViewSensitivity());
		this.horizontalViewSensitivity = gameSettings51;
		GameSettings gameSettings52 = new GameSettings();
		gameSettings52.GameSettingId = EFunction.VerticalViewSensitivity;
		gameSettings52.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VerticalViewSensitivity;
		gameSettings52.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
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
		gameSettings52.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVerticalViewSensitivity());
		this.verticalViewSensitivity = gameSettings52;
		GameSettings gameSettings53 = new GameSettings();
		gameSettings53.GameSettingId = EFunction.AimHorizontalViewSensitivity;
		gameSettings53.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimHorizontalViewSensitivity;
		gameSettings53.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
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
		gameSettings53.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimHorizontalViewSensitivity());
		this.aimHorizontalViewSensitivity = gameSettings53;
		GameSettings gameSettings54 = new GameSettings();
		gameSettings54.GameSettingId = EFunction.AimVerticalViewSensitivity;
		gameSettings54.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimVerticalViewSensitivity;
		gameSettings54.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
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
		gameSettings54.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimVerticalViewSensitivity());
		this.aimVerticalViewSensitivity = gameSettings54;
		GameSettings gameSettings55 = new GameSettings();
		gameSettings55.GameSettingId = EFunction.CameraShakeStrength;
		gameSettings55.ValueType = EGameSettingsValueType.Float;
		gameSettings55.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.CameraShakeStrength;
		gameSettings55.ApplyCallbackFloat = delegate(float value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyCameraShakeStrength(value);
			return true;
		};
		gameSettings55.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpCameraShakeStrength());
		this.cameraShakeStrength = gameSettings55;
		GameSettings gameSettings56 = new GameSettings();
		gameSettings56.GameSettingId = EFunction.MobileHorizontalViewSensitivity;
		gameSettings56.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileHorizontalViewSensitivity;
		gameSettings56.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileHorizontalViewSensitivity((float)value);
			return true;
		};
		gameSettings56.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHorizontalViewSensitivity());
		this.mobileHorizontalViewSensitivity = gameSettings56;
		GameSettings gameSettings57 = new GameSettings();
		gameSettings57.GameSettingId = EFunction.MobileVerticalViewSensitivity;
		gameSettings57.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileVerticalViewSensitivity;
		gameSettings57.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileVerticalViewSensitivity((float)value);
			return true;
		};
		gameSettings57.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVerticalViewSensitivity());
		this.mobileVerticalViewSensitivity = gameSettings57;
		GameSettings gameSettings58 = new GameSettings();
		gameSettings58.GameSettingId = EFunction.MobileAimHorizontalViewSensitivity;
		gameSettings58.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileAimHorizontalViewSensitivity;
		gameSettings58.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileAimHorizontalViewSensitivity((float)value);
			return true;
		};
		gameSettings58.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimHorizontalViewSensitivity());
		this.mobileAimHorizontalViewSensitivity = gameSettings58;
		GameSettings gameSettings59 = new GameSettings();
		gameSettings59.GameSettingId = EFunction.MobileAimVerticalViewSensitivity;
		gameSettings59.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MobileAimVerticalViewSensitivity;
		gameSettings59.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMobileAimVerticalViewSensitivity((float)value);
			return true;
		};
		gameSettings59.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimVerticalViewSensitivity());
		this.mobileAimVerticalViewSensitivity = gameSettings59;
		GameSettings gameSettings60 = new GameSettings();
		gameSettings60.GameSettingId = EFunction.CommonSpringArmLength;
		gameSettings60.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.CommonSpringArmLength;
		gameSettings60.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyCommonSpringArmLength((float)value);
			return true;
		};
		gameSettings60.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpCommonSpringArmLength());
		this.commonSpringArmLength = gameSettings60;
		GameSettings gameSettings61 = new GameSettings();
		gameSettings61.GameSettingId = EFunction.FightSpringArmLength;
		gameSettings61.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FightSpringArmLength;
		gameSettings61.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyFightSpringArmLength((float)value);
			return true;
		};
		gameSettings61.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFightSpringArmLength());
		this.fightSpringArmLength = gameSettings61;
		GameSettings gameSettings62 = new GameSettings();
		gameSettings62.GameSettingId = EFunction.ResetFocusEnable;
		gameSettings62.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsResetFocusEnable;
		gameSettings62.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyResetFocusEnable(value);
			return true;
		};
		gameSettings62.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpResetFocusEnable());
		this.resetFocusEnable = gameSettings62;
		GameSettings gameSettings63 = new GameSettings();
		gameSettings63.GameSettingId = EFunction.IsSidestepCameraEnable;
		gameSettings63.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsSidestepCameraEnable;
		gameSettings63.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyIsSidestepCameraEnable(value);
			return true;
		};
		gameSettings63.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIsSidestepCameraEnable());
		this.isSidestepCameraEnable = gameSettings63;
		GameSettings gameSettings64 = new GameSettings();
		gameSettings64.GameSettingId = EFunction.IsSoftLockCameraEnable;
		gameSettings64.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsSoftLockCameraEnable;
		gameSettings64.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyIsSoftLockCameraEnable(value);
			return true;
		};
		gameSettings64.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpIsSoftLockCameraEnable());
		this.isSoftLockCameraEnable = gameSettings64;
		GameSettings gameSettings65 = new GameSettings();
		gameSettings65.GameSettingId = EFunction.JoystickShakeStrength;
		gameSettings65.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickShakeStrength;
		gameSettings65.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyJoystickShakeStrength(value));
		gameSettings65.DumpCallback = (() => "[DumpJoystickShakeStrength]no way to dump");
		this.joystickShakeStrength = gameSettings65;
		GameSettings gameSettings66 = new GameSettings();
		gameSettings66.GameSettingId = EFunction.JoystickShakeType;
		gameSettings66.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickShakeType;
		gameSettings66.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyJoystickShakeType(value));
		gameSettings66.DumpCallback = (() => "[DumpJoystickShakeType]no way to dump");
		this.joystickShakeType = gameSettings66;
		GameSettings gameSettings67 = new GameSettings();
		gameSettings67.GameSettingId = EFunction.WalkOrRunRate;
		gameSettings67.ValueType = EGameSettingsValueType.Float;
		gameSettings67.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.WalkOrRunRate;
		gameSettings67.ApplyCallbackFloat = delegate(float value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyWalkOrRunRate(value);
			return true;
		};
		gameSettings67.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpWalkOrRunRate());
		this.walkOrRunRate = gameSettings67;
		GameSettings gameSettings68 = new GameSettings();
		gameSettings68.GameSettingId = EFunction.JoystickMode;
		gameSettings68.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.JoystickMode;
		gameSettings68.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyJoystickMode(value);
			return true;
		};
		gameSettings68.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpJoystickMode());
		this.joystickMode = gameSettings68;
		GameSettings gameSettings69 = new GameSettings();
		gameSettings69.GameSettingId = EFunction.MobileButtonCustom;
		gameSettings69.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings69.DumpCallback = (() => "[mobileButtonCustom]this is just a switch entry");
		this.mobileButtonCustom = gameSettings69;
		GameSettings gameSettings70 = new GameSettings();
		gameSettings70.GameSettingId = EFunction.SkillButtonMode;
		gameSettings70.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.IsAutoSwitchSkillButtonMode;
		gameSettings70.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAutoSwitchSkillButtonMode(value);
			return true;
		};
		gameSettings70.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSkillButtonMode());
		this.skillButtonMode = gameSettings70;
		GameSettings gameSettings71 = new GameSettings();
		gameSettings71.GameSettingId = EFunction.CdKey;
		gameSettings71.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings71.DumpCallback = (() => "[DumpCdKey]this is just a switch entry");
		this.cdKey = gameSettings71;
		GameSettings gameSettings72 = new GameSettings();
		gameSettings72.GameSettingId = EFunction.ResDownLoad;
		gameSettings72.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings72.DumpCallback = (() => "[resDownLoad]SubPackageDownLoad");
		this.resDownLoad = gameSettings72;
		GameSettings gameSettings73 = new GameSettings();
		gameSettings73.GameSettingId = EFunction.ResClear;
		gameSettings73.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings73.DumpCallback = (() => "[resClear]SubPackageDownLoadClear");
		this.resClear = gameSettings73;
		GameSettings gameSettings74 = new GameSettings();
		gameSettings74.GameSettingId = EFunction.PushMode;
		gameSettings74.GetCallbackOrGlobalKey = new Func<int>(() => (KuroPushController.Instance.GetPushState() > false) ? 1 : 0);
		gameSettings74.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				GameSettingsUtils.ApplyPushEnableState(value, new EGameSettingsApplyReason?(reason));
				return true;
			}
			return false;
		};
		gameSettings74.DumpCallback = (() => "[DumpPushMode]same to getter");
		this.pushMode = gameSettings74;
		GameSettings gameSettings75 = new GameSettings();
		gameSettings75.GameSettingId = EFunction.AimAssist;
		gameSettings75.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AimAssistEnable;
		gameSettings75.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAimAssistEnable(value);
			return true;
		};
		gameSettings75.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAimAssist());
		this.aimAssist = gameSettings75;
		GameSettings gameSettings76 = new GameSettings();
		gameSettings76.GameSettingId = EFunction.KeyboardLockEnemyMode;
		gameSettings76.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.KeyboardLockEnemyMode;
		gameSettings76.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyKeyboardLockEnemyMode(value);
			return true;
		};
		gameSettings76.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpKeyboardLockEnemyMode());
		this.keyboardLockEnemyMode = gameSettings76;
		GameSettings gameSettings77 = new GameSettings();
		gameSettings77.GameSettingId = EFunction.HorizontalViewRevert;
		gameSettings77.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HorizontalViewRevert;
		gameSettings77.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Info.Instance.IsInGamepad())
			{
				GameSettingsUtils.ApplyHorizontalViewRevert(value);
			}
			return true;
		};
		gameSettings77.DumpCallback = (() => "[DumpHorizontalViewRevert]no way to dump");
		this.horizontalViewRevert = gameSettings77;
		GameSettings gameSettings78 = new GameSettings();
		gameSettings78.GameSettingId = EFunction.VerticalViewRevert;
		gameSettings78.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VerticalViewRevert;
		gameSettings78.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (Info.Instance.IsInGamepad())
			{
				GameSettingsUtils.ApplyVerticalViewRevert(value);
			}
			return true;
		};
		gameSettings78.DumpCallback = (() => "[DumpVerticalViewRevert]no way to dump");
		this.verticalViewRevert = gameSettings78;
		GameSettings gameSettings79 = new GameSettings();
		gameSettings79.GameSettingId = EFunction.SkillLockEnemyMode;
		gameSettings79.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SkillLockEnemyMode;
		gameSettings79.DumpCallback = (() => "[DumpSkillLockEnemyMode]same to getter");
		this.skillLockEnemyMode = gameSettings79;
		GameSettings gameSettings80 = new GameSettings();
		gameSettings80.GameSettingId = EFunction.GamepadLockEnemyMode;
		gameSettings80.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLockEnemyMode;
		gameSettings80.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLockEnemyMode(value);
			return true;
		};
		gameSettings80.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpGamepadLockEnemyMode());
		this.gamepadLockEnemyMode = gameSettings80;
		GameSettings gameSettings81 = new GameSettings();
		gameSettings81.GameSettingId = EFunction.EnemyHitDisplayMode;
		gameSettings81.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EnemyHitDisplayMode;
		gameSettings81.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyEnemyHitDisplayMode(value);
			return true;
		};
		gameSettings81.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEnemyHitDisplayMode());
		this.enemyHitDisplayMode = gameSettings81;
		GameSettings gameSettings82 = new GameSettings();
		gameSettings82.GameSettingId = EFunction.MobileGamepadMode;
		gameSettings82.GetCallbackOrGlobalKey = new Func<int>(() => (PlatformModel.Instance.IsGamepadAttached() > false) ? 1 : 0);
		gameSettings82.DumpCallback = (() => "[DumpMobileGamepadMode]same to getter");
		this.mobileGamepadMode = gameSettings82;
		GameSettings gameSettings83 = new GameSettings();
		gameSettings83.GameSettingId = EFunction.AutoAdjustImageQuality;
		gameSettings83.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoAdjustImageQuality;
		gameSettings83.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAutoAdjustImageQuality(value);
			return true;
		};
		gameSettings83.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoAdjustImageQuality());
		this.autoAdjustImageQuality = gameSettings83;
		GameSettings gameSettings84 = new GameSettings();
		gameSettings84.GameSettingId = EFunction.ShowDamage;
		gameSettings84.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ShowDamage;
		gameSettings84.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyShowDamage(value);
			return true;
		};
		gameSettings84.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpShowDamage());
		this.showDamage = gameSettings84;
		GameSettings gameSettings85 = new GameSettings();
		gameSettings85.GameSettingId = EFunction.DynamicBones;
		gameSettings85.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.DynamicBones;
		gameSettings85.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyDynamicBones(value);
			return true;
		};
		gameSettings85.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpDynamicBones());
		this.dynamicBones = gameSettings85;
		GameSettings gameSettings86 = new GameSettings();
		gameSettings86.GameSettingId = EFunction.UIPureMode;
		gameSettings86.GetCallbackOrGlobalKey = new Func<int>(delegate()
		{
			if (BattleUiModel.Instance.PureModeData == null || !BattleUiModel.Instance.PureModeData.IsOpen)
			{
				return 0;
			}
			return 1;
		});
		gameSettings86.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyUiPureMode(value));
		gameSettings86.DumpCallback = (() => "[DumpUiPureMode]same to getter");
		this.uiPureMode = gameSettings86;
		GameSettings gameSettings87 = new GameSettings();
		gameSettings87.GameSettingId = EFunction.FlyControlMode;
		gameSettings87.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FlyControlMode;
		gameSettings87.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings87.DumpCallback = (() => "[DumpFlyControlMode]same to getter");
		this.flyControlMode = gameSettings87;
		GameSettings gameSettings88 = new GameSettings();
		gameSettings88.GameSettingId = EFunction.DOLBYATOMS;
		gameSettings88.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.DolbyAtmos;
		gameSettings88.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyDolbyAtmos(value);
			return true;
		};
		gameSettings88.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVolume("volume_dolby_atmos"));
		this.dolbyAtmos = gameSettings88;
		GameSettings gameSettings89 = new GameSettings();
		gameSettings89.GameSettingId = EFunction.FlowAdaptation;
		gameSettings89.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.FlowAdaptation;
		gameSettings89.DumpCallback = (() => "[DumpFlowAdaptation]same to getter");
		this.flowAdaptation = gameSettings89;
		GameSettings gameSettings90 = new GameSettings();
		gameSettings90.GameSettingId = EFunction.RayTracing;
		gameSettings90.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracing;
		gameSettings90.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracing(value));
		gameSettings90.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracing());
		gameSettings90.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit<int>(EEventName.SetRayTracingWithValue, value);
		};
		this.rayTracing = gameSettings90;
		GameSettings gameSettings91 = new GameSettings();
		gameSettings91.GameSettingId = EFunction.RayTracedReflection;
		gameSettings91.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedReflection;
		gameSettings91.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedReflection(value));
		gameSettings91.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracedReflection());
		this.rayTracedReflection = gameSettings91;
		GameSettings gameSettings92 = new GameSettings();
		gameSettings92.GameSettingId = EFunction.RayTracedGI;
		gameSettings92.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedGI;
		gameSettings92.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedGI(value));
		gameSettings92.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpRayTracedGI());
		this.rayTracedGI = gameSettings92;
		GameSettings gameSettings93 = new GameSettings();
		gameSettings93.GameSettingId = EFunction.RayTracedShadow;
		gameSettings93.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.RayTracedShadow;
		gameSettings93.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyRayTracedShadow(value));
		gameSettings93.DumpCallback = (() => "[DumpRayTracedShadow]not implemented");
		this.rayTracedShadow = gameSettings93;
		GameSettings gameSettings94 = new GameSettings();
		gameSettings94.GameSettingId = EFunction.TeammateFx;
		gameSettings94.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.TeammateFx;
		gameSettings94.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EffectEnvironment.Instance.DisableOtherEffect = (value == 0);
			return true;
		};
		gameSettings94.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpTeammateFx());
		this.teammateFx = gameSettings94;
		GameSettings gameSettings95 = new GameSettings();
		gameSettings95.GameSettingId = EFunction.Saturation;
		gameSettings95.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SaturationNew;
		gameSettings95.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplySaturationClient(value));
		gameSettings95.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSaturation());
		this.saturation = gameSettings95;
		GameSettings gameSettings96 = new GameSettings();
		gameSettings96.GameSettingId = EFunction.Contrast;
		gameSettings96.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ContrastNew;
		gameSettings96.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyContrastClient(value));
		gameSettings96.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpContrast());
		this.contrast = gameSettings96;
		GameSettings gameSettings97 = new GameSettings();
		gameSettings97.GameSettingId = EFunction.Filter;
		gameSettings97.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings97.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpFilter());
		this.filter = gameSettings97;
		GameSettings gameSettings98 = new GameSettings();
		gameSettings98.GameSettingId = EFunction.SkinDamageMode;
		gameSettings98.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SkinDamageMode;
		gameSettings98.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplySkinDamageMode(value);
			return true;
		};
		gameSettings98.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpSkinDamageMode());
		this.skinDamageMode = gameSettings98;
		GameSettings gameSettings99 = new GameSettings();
		gameSettings99.GameSettingId = EFunction.PlayStationOnly;
		gameSettings99.GetCallbackOrGlobalKey = new Func<int>(() => (KuroSdkModel.Instance.PlayStationPlayOnlyState > false) ? 1 : 0);
		gameSettings99.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				KuroSdkController.Instance.RequestChangeServerPlayStationPlayOnlyState(value == 1);
			}
			return false;
		};
		gameSettings99.DumpCallback = (() => "[DumpPlayStationOnly]same to getter");
		this.playStationOnly = gameSettings99;
		GameSettings gameSettings100 = new GameSettings();
		gameSettings100.GameSettingId = EFunction.AdrenoFME;
		gameSettings100.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AfmeSince2Dot3;
		gameSettings100.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAFMEOption(value);
			return true;
		};
		gameSettings100.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAdrenoFME());
		this.adrenoFME = gameSettings100;
		GameSettings gameSettings101 = new GameSettings();
		gameSettings101.GameSettingId = EFunction.UserCenterDomestic;
		gameSettings101.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings101.DumpCallback = (() => "[DumpUserCenterDomestic]this is just a switch entry");
		this.userCenterDomestic = gameSettings101;
		GameSettings gameSettings102 = new GameSettings();
		gameSettings102.GameSettingId = EFunction.UserCenterOverseas;
		gameSettings102.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings102.DumpCallback = (() => "[userCenterOverseas]this is just a switch entry");
		this.userCenterOverseas = gameSettings102;
		GameSettings gameSettings103 = new GameSettings();
		gameSettings103.GameSettingId = EFunction.PrivacyPolicyDomestic;
		gameSettings103.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings103.DumpCallback = (() => "[privacyPolicyDomestic]this is just a switch entry");
		this.privacyPolicyDomestic = gameSettings103;
		GameSettings gameSettings104 = new GameSettings();
		gameSettings104.GameSettingId = EFunction.PrivacyPolicyOverSeas;
		gameSettings104.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings104.DumpCallback = (() => "[privacyPolicyOverSeas]this is just a switch entry");
		this.privacyPolicyOverSeas = gameSettings104;
		GameSettings gameSettings105 = new GameSettings();
		gameSettings105.GameSettingId = EFunction.TermsOfUseDomestic;
		gameSettings105.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings105.DumpCallback = (() => "[termsOfUseDomestic]this is just a switch entry");
		this.termsOfUseDomestic = gameSettings105;
		GameSettings gameSettings106 = new GameSettings();
		gameSettings106.GameSettingId = EFunction.TermsOfUseOverSeas;
		gameSettings106.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings106.DumpCallback = (() => "[termsOfUseOverSeas]this is just a switch entry");
		this.termsOfUseOverSeas = gameSettings106;
		GameSettings gameSettings107 = new GameSettings();
		gameSettings107.GameSettingId = EFunction.ChildrenPrivacy;
		gameSettings107.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings107.DumpCallback = (() => "[childrenPrivacy]this is just a switch entry");
		this.childrenPrivacy = gameSettings107;
		GameSettings gameSettings108 = new GameSettings();
		gameSettings108.GameSettingId = EFunction.ThirdPartyInfo;
		gameSettings108.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings108.DumpCallback = (() => "[thirdPartyInfo]this is just a switch entry");
		this.thirdPartyInfo = gameSettings108;
		GameSettings gameSettings109 = new GameSettings();
		gameSettings109.GameSettingId = EFunction.PrivacyPolicySetting;
		gameSettings109.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings109.DumpCallback = (() => "[privacyPolicySetting]this is just a switch entry");
		this.privacyPolicySetting = gameSettings109;
		GameSettings gameSettings110 = new GameSettings();
		gameSettings110.GameSettingId = EFunction.License;
		gameSettings110.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings110.DumpCallback = (() => "[license]this is just a switch entry");
		this.licenseSetting = gameSettings110;
		GameSettings gameSettings111 = new GameSettings();
		gameSettings111.GameSettingId = EFunction.LogUpload;
		gameSettings111.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings111.DumpCallback = (() => "[logUpload]this is just a switch entry");
		this.logUploadSetting = gameSettings111;
		GameSettings gameSettings112 = new GameSettings();
		gameSettings112.GameSettingId = EFunction.BasicGraphicSetting;
		gameSettings112.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings112.DumpCallback = (() => "[basicGraphicSetting]this is just a switch entry");
		this.basicGraphicSetting = gameSettings112;
		GameSettings gameSettings113 = new GameSettings();
		gameSettings113.GameSettingId = EFunction.AutoRun;
		gameSettings113.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoRun;
		gameSettings113.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoRun(value));
		gameSettings113.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoRun());
		this.autoRun = gameSettings113;
		GameSettings gameSettings114 = new GameSettings();
		gameSettings114.GameSettingId = EFunction.AutoSprint;
		gameSettings114.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoSprint;
		gameSettings114.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoSprint(value));
		gameSettings114.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoSprint());
		this.autoSprint = gameSettings114;
		GameSettings gameSettings115 = new GameSettings();
		gameSettings115.GameSettingId = EFunction.Vulkan;
		gameSettings115.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.Vulkan;
		gameSettings115.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVulkan(value));
		gameSettings115.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi || reason == EGameSettingsApplyReason.WhenGameStart)
			{
				LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.VulkanChangeFlag, true);
			}
		};
		gameSettings115.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVulkan());
		this.vulkan = gameSettings115;
		GameSettings gameSettings116 = new GameSettings();
		gameSettings116.GameSettingId = EFunction.ShowOtherName;
		gameSettings116.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ShowOtherName;
		gameSettings116.HandleDoneCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			EventSystem.Instance.Emit(EEventName.RefreshPlayerInfoVisible);
		};
		gameSettings116.DumpCallback = (() => "[DumpAdviceSetting]same to getter");
		this.showOtherName = gameSettings116;
		GameSettings gameSettings117 = new GameSettings();
		gameSettings117.GameSettingId = EFunction.WaterInteract;
		gameSettings117.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.WaterInteract;
		gameSettings117.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyWaterInteract(value));
		gameSettings117.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpWaterInteract());
		this.waterInteract = gameSettings117;
		GameSettings gameSettings118 = new GameSettings();
		gameSettings118.GameSettingId = EFunction.VegetationDither;
		gameSettings118.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VegetationDither;
		gameSettings118.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVegetationDither(value));
		gameSettings118.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVegetationDither());
		this.vegetationDither = gameSettings118;
		GameSettings gameSettings119 = new GameSettings();
		gameSettings119.GameSettingId = EFunction.VegetationDensity;
		gameSettings119.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.VegetationDensity;
		gameSettings119.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyVegetationDensity(value));
		gameSettings119.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpVegetationDensity());
		this.vegetationDensity = gameSettings119;
		GameSettings gameSettings120 = new GameSettings();
		gameSettings120.GameSettingId = EFunction.VersionCheck;
		gameSettings120.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings120.DumpCallback = (() => "");
		this.versionCheck = gameSettings120;
		GameSettings gameSettings121 = new GameSettings();
		gameSettings121.GameSettingId = EFunction.ImageDisplayMode;
		gameSettings121.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.ImageDisplayMode;
		gameSettings121.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyImageDisplayMode(value));
		gameSettings121.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpImageDisplayMode());
		this.imageDisplayMode = gameSettings121;
		GameSettings gameSettings122 = new GameSettings();
		gameSettings122.GameSettingId = EFunction.EyeProtection;
		gameSettings122.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtection;
		gameSettings122.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtection());
		this.eyeProtection = gameSettings122;
		GameSettings gameSettings123 = new GameSettings();
		gameSettings123.GameSettingId = EFunction.EyeProtectionMode;
		gameSettings123.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionMode;
		gameSettings123.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionMode(value));
		gameSettings123.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionMode());
		this.eyeProtectionMode = gameSettings123;
		GameSettings gameSettings124 = new GameSettings();
		gameSettings124.GameSettingId = EFunction.EyeProtectionTemp;
		gameSettings124.ValueType = EGameSettingsValueType.Float;
		gameSettings124.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionTemp;
		gameSettings124.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionTemp(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings124.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionTemp());
		this.eyeProtectionTemp = gameSettings124;
		GameSettings gameSettings125 = new GameSettings();
		gameSettings125.GameSettingId = EFunction.EyeProtectionStrength;
		gameSettings125.ValueType = EGameSettingsValueType.Float;
		gameSettings125.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionStrength;
		gameSettings125.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionStrength(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings125.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionStrength());
		this.eyeProtectionStrength = gameSettings125;
		GameSettings gameSettings126 = new GameSettings();
		gameSettings126.GameSettingId = EFunction.EyeProtectionBrightness;
		gameSettings126.ValueType = EGameSettingsValueType.Float;
		gameSettings126.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionBrightness;
		gameSettings126.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionBrightness(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings126.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionBrightness());
		this.eyeProtectionBrightness = gameSettings126;
		GameSettings gameSettings127 = new GameSettings();
		gameSettings127.GameSettingId = EFunction.EyeProtectionTexture;
		gameSettings127.ValueType = EGameSettingsValueType.Float;
		gameSettings127.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.EyeProtectionTexture;
		gameSettings127.ApplyCallbackFloat = ((float value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyEyeProtectionTexture(value, GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true)));
		gameSettings127.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpEyeProtectionTexture());
		this.eyeProtectionTexture = gameSettings127;
		GameSettings gameSettings128 = new GameSettings();
		gameSettings128.GameSettingId = EFunction.AutoExposure;
		gameSettings128.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AutoExposure;
		gameSettings128.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyAutoExposure(value));
		gameSettings128.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpAutoExposure());
		this.autoExposure = gameSettings128;
		GameSettings gameSettings129 = new GameSettings();
		gameSettings129.GameSettingId = EFunction.HarmonySuperResolution;
		gameSettings129.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonySuperResolution;
		gameSettings129.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonySuperResolution(value));
		gameSettings129.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonySuperResolution());
		this.harmonySuperResolution = gameSettings129;
		GameSettings gameSettings130 = new GameSettings();
		gameSettings130.GameSettingId = EFunction.HarmonyRayTracingBoost;
		gameSettings130.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonyRayTracingBoost;
		gameSettings130.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonyRayTracingBoost(value));
		gameSettings130.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonyRayTracingBoost());
		this.harmonyRayTracingBoost = gameSettings130;
		GameSettings gameSettings131 = new GameSettings();
		gameSettings131.GameSettingId = EFunction.HarmonyRayTracingBoostAdvanced;
		gameSettings131.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.HarmonyRayTracingBoostAdvanced;
		gameSettings131.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => GameSettingsUtils.ApplyHarmonyRayTracingBoost(value));
		gameSettings131.DumpCallback = (() => GameSettingsDumpUtils.Instance.DumpHarmonyRayTracingBoost());
		this.harmonyRayTracingBoostAdvanced = gameSettings131;
		GameSettings gameSettings132 = new GameSettings();
		gameSettings132.GameSettingId = EFunction.AdjustiveGamePadTrigger;
		gameSettings132.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AdjustiveGamePadTrigger;
		gameSettings132.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAdjustiveGamePadTrigger(value);
			return true;
		};
		gameSettings132.DumpCallback = (() => "[AdjustiveGamePadTrigger]same to getter");
		this.adjustiveGamePadTrigger = gameSettings132;
		GameSettings gameSettings133 = new GameSettings();
		gameSettings133.GameSettingId = EFunction.GamepadLeftStickDeadZone;
		gameSettings133.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLeftStickDeadZone;
		gameSettings133.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLeftStickDeadZone(value);
			return true;
		};
		gameSettings133.DumpCallback = (() => "[GamepadLeftStickDeadZone]same to getter");
		this.gamepadLeftStickDeadZone = gameSettings133;
		GameSettings gameSettings134 = new GameSettings();
		gameSettings134.GameSettingId = EFunction.GamepadRightStickDeadZone;
		gameSettings134.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadRightStickDeadZone;
		gameSettings134.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadRightStickDeadZone(value);
			return true;
		};
		gameSettings134.DumpCallback = (() => "[GamepadRightStickDeadZone]same to getter");
		this.gamepadRightStickDeadZone = gameSettings134;
		GameSettings gameSettings135 = new GameSettings();
		gameSettings135.GameSettingId = EFunction.GamepadLeftTriggerDeadZone;
		gameSettings135.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadLeftTriggerDeadZone;
		gameSettings135.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadLeftTriggerDeadZone(value);
			return true;
		};
		gameSettings135.DumpCallback = (() => "[GamepadLeftTriggerDeadZone]same to getter");
		this.gamepadLeftTriggerDeadZone = gameSettings135;
		GameSettings gameSettings136 = new GameSettings();
		gameSettings136.GameSettingId = EFunction.GamepadRightTriggerDeadZone;
		gameSettings136.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.GamepadRightTriggerDeadZone;
		gameSettings136.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyGamepadRightTriggerDeadZone(value);
			return true;
		};
		gameSettings136.DumpCallback = (() => "[GamepadRightTriggerDeadZone]same to getter");
		this.gamepadRightTriggerDeadZone = gameSettings136;
		GameSettings gameSettings137 = new GameSettings();
		gameSettings137.GameSettingId = EFunction.MotorAutoLongPressSpeedUp;
		gameSettings137.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorAutoLongPressSpeedUp;
		gameSettings137.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorAutoLongPressSpeedUp(value);
			return true;
		};
		gameSettings137.DumpCallback = (() => "[MotorAutoLongPressSpeedUp]same to getter");
		this.motorAccleratePressType = gameSettings137;
		GameSettings gameSettings138 = new GameSettings();
		gameSettings138.GameSettingId = EFunction.MotorAutoAcceleratorSettingEnable;
		gameSettings138.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorAutoAcceleratorSettingEnable;
		gameSettings138.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorAutoAcceleratorSettingEnable(value);
			return true;
		};
		gameSettings138.DumpCallback = (() => "[MotorAutoAcceleratorSettingEnable]same to getter");
		this.motorAutoAcceleratorSettingEnable = gameSettings138;
		GameSettings gameSettings139 = new GameSettings();
		gameSettings139.GameSettingId = EFunction.MotorDriftAcceleratorSettingEnable;
		gameSettings139.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorDriftAcceleratorSettingEnable;
		gameSettings139.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorDriftAcceleratorSettingEnable(value);
			return true;
		};
		gameSettings139.DumpCallback = (() => "[MotorDriftAcceleratorSettingEnable]same to getter");
		this.motorDriftAcceleratorSettingEnable = gameSettings139;
		GameSettings gameSettings140 = new GameSettings();
		gameSettings140.GameSettingId = EFunction.MotorDriftModel;
		gameSettings140.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorDriftModel;
		gameSettings140.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings140.DumpCallback = (() => "[MotorDriftAcceleratorSettingEnable]same to getter");
		this.motorDriftModel = gameSettings140;
		GameSettings gameSettings141 = new GameSettings();
		gameSettings141.GameSettingId = EFunction.MotorHudVisible;
		gameSettings141.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorHudVisible;
		gameSettings141.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorHudVisible(value);
			return true;
		};
		gameSettings141.DumpCallback = (() => "[MotorHudVisible]same to getter");
		this.motorHudVisible = gameSettings141;
		GameSettings gameSettings142 = new GameSettings();
		gameSettings142.GameSettingId = EFunction.SubTitleOption;
		gameSettings142.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.SubTitleOption;
		gameSettings142.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings142.DumpCallback = (() => "[SubTitleOption]same to getter");
		this.subTitleOption = gameSettings142;
		GameSettings gameSettings143 = new GameSettings();
		gameSettings143.GameSettingId = EFunction.MotorIsDynamicJoystick;
		gameSettings143.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorIsDynamicJoystick;
		gameSettings143.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyMotorIsDynamicJoystick(value);
			return true;
		};
		gameSettings143.DumpCallback = (() => "[MotorIsDynamicJoystick]same to getter");
		this.motorTouchFixedPosition = gameSettings143;
		GameSettings gameSettings144 = new GameSettings();
		gameSettings144.GameSettingId = EFunction.MotorMobileButtonCustom;
		gameSettings144.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings144.DumpCallback = (() => "[motorMobileButtonCustom]this is just a switch entry");
		this.motorMobileButtonCustom = gameSettings144;
		GameSettings gameSettings145 = new GameSettings();
		gameSettings145.GameSettingId = EFunction.MotorMobileButtonLayout;
		gameSettings145.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorMobileButtonLayout;
		gameSettings145.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			bool value2 = value == 0;
			BattleUiModel.Instance.JoystickData.RefreshMotorMobileButtonLayout(new bool?(value2));
			return true;
		};
		gameSettings145.DumpCallback = (() => "[MotorMobileButtonLayout]same to getter");
		this.motorMobileButtonLayout = gameSettings145;
		GameSettings gameSettings146 = new GameSettings();
		gameSettings146.GameSettingId = EFunction.DeviceInfo;
		gameSettings146.GetCallbackOrGlobalKey = new Func<int>(() => 0);
		gameSettings146.DumpCallback = (() => "");
		this.deviceInfo = gameSettings146;
		GameSettings gameSettings147 = new GameSettings();
		gameSettings147.GameSettingId = EFunction.UiBrightness;
		gameSettings147.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.UiBrightness;
		gameSettings147.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyUiBrightness((float)value);
			return true;
		};
		gameSettings147.DumpCallback = (() => "[UiBrightness]same to getter");
		this.uiBrightness = gameSettings147;
		GameSettings gameSettings148 = new GameSettings();
		gameSettings148.GameSettingId = EFunction.PeakBrightness;
		gameSettings148.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.PeakBrightness;
		gameSettings148.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyPeakBrightness((float)value);
			return true;
		};
		gameSettings148.DumpCallback = (() => "[PeakBrightness]same to getter");
		this.peakBrightness = gameSettings148;
		GameSettings gameSettings149 = new GameSettings();
		gameSettings149.GameSettingId = EFunction.MotorFlyControlMode;
		gameSettings149.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.MotorFlyControlMode;
		gameSettings149.ApplyCallback = ((int value, EGameSettingsApplyReason reason) => true);
		gameSettings149.DumpCallback = (() => "[MotorFlyControlMode]same to getter");
		this.motorFlyControlMode = gameSettings149;
		GameSettings gameSettings150 = new GameSettings();
		gameSettings150.GameSettingId = EFunction.AnisoLevel;
		gameSettings150.GetCallbackOrGlobalKey = ELocalStorageGlobalKey.AnisoLevel;
		gameSettings150.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			GameSettingsUtils.ApplyAnisoLevel(value);
			return true;
		};
		gameSettings150.DumpCallback = (() => "[anisoLevel]Anisotropic Level");
		this.anisoLevel = gameSettings150;
		GameSettings gameSettings151 = new GameSettings();
		gameSettings151.GameSettingId = EFunction.XboxOnly;
		gameSettings151.GetCallbackOrGlobalKey = new Func<int>(() => (KuroSdkModel.Instance.XboxPlayOnlyState > false) ? 1 : 0);
		gameSettings151.ApplyCallback = delegate(int value, EGameSettingsApplyReason reason)
		{
			if (reason == EGameSettingsApplyReason.WhenUi)
			{
				KuroSdkController.Instance.RequestChangeServerXboxPlayOnlyState(value == 1);
			}
			return false;
		};
		gameSettings151.DumpCallback = (() => "[DumpXboxOnly]same to getter");
		this.xboxOnly = gameSettings151;
		base..ctor();
	}

	// Token: 0x04002589 RID: 9609
	public const int HEAVY_SCENEVULUME_INDEX_START = 30;

	// Token: 0x0400258A RID: 9610
	public const int HEAVY_SCENEVULUME_INDEX_END = 39;

	// Token: 0x0400258B RID: 9611
	public const int NPC_DENSITY_THRESHOLD = 1;

	// Token: 0x0400258C RID: 9612
	public const int NPC_DENSITY_PC_THRESHOLD = 1;

	// Token: 0x0400258D RID: 9613
	public const int WINDOWS_RESOLUTION_INDEX = 2;

	// Token: 0x0400258E RID: 9614
	public const int MAIN_TYPE_OF_KEY_SETTING = 3;

	// Token: 0x0400258F RID: 9615
	[Nullable(2)]
	public static EGameSettingsInitSourceType[] gameSettingsInitSourceTypePriority;

	// Token: 0x04002590 RID: 9616
	public GameSettings masterVolume;

	// Token: 0x04002591 RID: 9617
	public GameSettings voiceVolume;

	// Token: 0x04002592 RID: 9618
	public GameSettings musicVolume;

	// Token: 0x04002593 RID: 9619
	public GameSettings sfxVolume;

	// Token: 0x04002594 RID: 9620
	public GameSettings uiVolume;

	// Token: 0x04002595 RID: 9621
	public GameSettings ambVolume;

	// Token: 0x04002596 RID: 9622
	public GameSettings backendVolume;

	// Token: 0x04002597 RID: 9623
	public GameSettings imageQuality;

	// Token: 0x04002598 RID: 9624
	public GameSettings loadingRangeScaleLevel;

	// Token: 0x04002599 RID: 9625
	public GameSettings displayMode;

	// Token: 0x0400259A RID: 9626
	public GameSettings resourceStandard;

	// Token: 0x0400259B RID: 9627
	public GameSettings resolution;

	// Token: 0x0400259C RID: 9628
	public GameSettings brightness;

	// Token: 0x0400259D RID: 9629
	public GameSettings highestFps;

	// Token: 0x0400259E RID: 9630
	public GameSettings shadowQuality;

	// Token: 0x0400259F RID: 9631
	public GameSettings niagaraQuality;

	// Token: 0x040025A0 RID: 9632
	public GameSettings imageDetail;

	// Token: 0x040025A1 RID: 9633
	public GameSettings antiAliasing;

	// Token: 0x040025A2 RID: 9634
	public GameSettings sceneAo;

	// Token: 0x040025A3 RID: 9635
	public GameSettings npcDensity;

	// Token: 0x040025A4 RID: 9636
	public GameSettings nvidiaDlss;

	// Token: 0x040025A5 RID: 9637
	public GameSettings nvidiaDlssFg;

	// Token: 0x040025A6 RID: 9638
	public GameSettings nvidiaDlssQuality;

	// Token: 0x040025A7 RID: 9639
	public GameSettings nvidiaDlssSharpness;

	// Token: 0x040025A8 RID: 9640
	public GameSettings nvidiaReflex;

	// Token: 0x040025A9 RID: 9641
	public GameSettings hdr;

	// Token: 0x040025AA RID: 9642
	public GameSettings fsr;

	// Token: 0x040025AB RID: 9643
	public GameSettings xess;

	// Token: 0x040025AC RID: 9644
	public GameSettings xessQuality;

	// Token: 0x040025AD RID: 9645
	public GameSettings xess2;

	// Token: 0x040025AE RID: 9646
	public GameSettings xess2Fg;

	// Token: 0x040025AF RID: 9647
	public GameSettings xess2Quality;

	// Token: 0x040025B0 RID: 9648
	public GameSettings fsr3;

	// Token: 0x040025B1 RID: 9649
	public GameSettings fsr3Fg;

	// Token: 0x040025B2 RID: 9650
	public GameSettings fsr3Quality;

	// Token: 0x040025B3 RID: 9651
	public GameSettings metalFxEnable;

	// Token: 0x040025B4 RID: 9652
	public GameSettings irx;

	// Token: 0x040025B5 RID: 9653
	public GameSettings bloom;

	// Token: 0x040025B6 RID: 9654
	public GameSettings volumeFog;

	// Token: 0x040025B7 RID: 9655
	public GameSettings volumeLight;

	// Token: 0x040025B8 RID: 9656
	public GameSettings motionBlur;

	// Token: 0x040025B9 RID: 9657
	public GameSettings pcvSync;

	// Token: 0x040025BA RID: 9658
	public GameSettings mobileResolution;

	// Token: 0x040025BB RID: 9659
	public GameSettings superResolution;

	// Token: 0x040025BC RID: 9660
	public GameSettings textLanguage;

	// Token: 0x040025BD RID: 9661
	public GameSettings voiceLanguage;

	// Token: 0x040025BE RID: 9662
	public GameSettings voicePackManager;

	// Token: 0x040025BF RID: 9663
	public GameSettings voiceRoleCustomManager;

	// Token: 0x040025C0 RID: 9664
	public GameSettings adviceSetting;

	// Token: 0x040025C1 RID: 9665
	public GameSettings genderSetting;

	// Token: 0x040025C2 RID: 9666
	public GameSettings horizontalViewSensitivity;

	// Token: 0x040025C3 RID: 9667
	public GameSettings verticalViewSensitivity;

	// Token: 0x040025C4 RID: 9668
	public GameSettings aimHorizontalViewSensitivity;

	// Token: 0x040025C5 RID: 9669
	public GameSettings aimVerticalViewSensitivity;

	// Token: 0x040025C6 RID: 9670
	public GameSettings cameraShakeStrength;

	// Token: 0x040025C7 RID: 9671
	public GameSettings mobileHorizontalViewSensitivity;

	// Token: 0x040025C8 RID: 9672
	public GameSettings mobileVerticalViewSensitivity;

	// Token: 0x040025C9 RID: 9673
	public GameSettings mobileAimHorizontalViewSensitivity;

	// Token: 0x040025CA RID: 9674
	public GameSettings mobileAimVerticalViewSensitivity;

	// Token: 0x040025CB RID: 9675
	public GameSettings commonSpringArmLength;

	// Token: 0x040025CC RID: 9676
	public GameSettings fightSpringArmLength;

	// Token: 0x040025CD RID: 9677
	public GameSettings resetFocusEnable;

	// Token: 0x040025CE RID: 9678
	public GameSettings isSidestepCameraEnable;

	// Token: 0x040025CF RID: 9679
	public GameSettings isSoftLockCameraEnable;

	// Token: 0x040025D0 RID: 9680
	public GameSettings joystickShakeStrength;

	// Token: 0x040025D1 RID: 9681
	public GameSettings joystickShakeType;

	// Token: 0x040025D2 RID: 9682
	public GameSettings walkOrRunRate;

	// Token: 0x040025D3 RID: 9683
	public GameSettings joystickMode;

	// Token: 0x040025D4 RID: 9684
	public GameSettings mobileButtonCustom;

	// Token: 0x040025D5 RID: 9685
	public GameSettings skillButtonMode;

	// Token: 0x040025D6 RID: 9686
	public GameSettings cdKey;

	// Token: 0x040025D7 RID: 9687
	public GameSettings resDownLoad;

	// Token: 0x040025D8 RID: 9688
	public GameSettings resClear;

	// Token: 0x040025D9 RID: 9689
	public GameSettings pushMode;

	// Token: 0x040025DA RID: 9690
	public GameSettings aimAssist;

	// Token: 0x040025DB RID: 9691
	public GameSettings keyboardLockEnemyMode;

	// Token: 0x040025DC RID: 9692
	public GameSettings horizontalViewRevert;

	// Token: 0x040025DD RID: 9693
	public GameSettings verticalViewRevert;

	// Token: 0x040025DE RID: 9694
	public GameSettings skillLockEnemyMode;

	// Token: 0x040025DF RID: 9695
	public GameSettings gamepadLockEnemyMode;

	// Token: 0x040025E0 RID: 9696
	public GameSettings enemyHitDisplayMode;

	// Token: 0x040025E1 RID: 9697
	public GameSettings mobileGamepadMode;

	// Token: 0x040025E2 RID: 9698
	public GameSettings autoAdjustImageQuality;

	// Token: 0x040025E3 RID: 9699
	public GameSettings showDamage;

	// Token: 0x040025E4 RID: 9700
	public GameSettings dynamicBones;

	// Token: 0x040025E5 RID: 9701
	public GameSettings uiPureMode;

	// Token: 0x040025E6 RID: 9702
	public GameSettings flyControlMode;

	// Token: 0x040025E7 RID: 9703
	public GameSettings dolbyAtmos;

	// Token: 0x040025E8 RID: 9704
	public GameSettings flowAdaptation;

	// Token: 0x040025E9 RID: 9705
	public GameSettings rayTracing;

	// Token: 0x040025EA RID: 9706
	public GameSettings rayTracedReflection;

	// Token: 0x040025EB RID: 9707
	public GameSettings rayTracedGI;

	// Token: 0x040025EC RID: 9708
	public GameSettings rayTracedShadow;

	// Token: 0x040025ED RID: 9709
	public GameSettings teammateFx;

	// Token: 0x040025EE RID: 9710
	public GameSettings saturation;

	// Token: 0x040025EF RID: 9711
	public GameSettings contrast;

	// Token: 0x040025F0 RID: 9712
	public GameSettings filter;

	// Token: 0x040025F1 RID: 9713
	public GameSettings skinDamageMode;

	// Token: 0x040025F2 RID: 9714
	public GameSettings playStationOnly;

	// Token: 0x040025F3 RID: 9715
	public GameSettings adrenoFME;

	// Token: 0x040025F4 RID: 9716
	public GameSettings userCenterDomestic;

	// Token: 0x040025F5 RID: 9717
	public GameSettings userCenterOverseas;

	// Token: 0x040025F6 RID: 9718
	public GameSettings privacyPolicyDomestic;

	// Token: 0x040025F7 RID: 9719
	public GameSettings privacyPolicyOverSeas;

	// Token: 0x040025F8 RID: 9720
	public GameSettings termsOfUseDomestic;

	// Token: 0x040025F9 RID: 9721
	public GameSettings termsOfUseOverSeas;

	// Token: 0x040025FA RID: 9722
	public GameSettings childrenPrivacy;

	// Token: 0x040025FB RID: 9723
	public GameSettings thirdPartyInfo;

	// Token: 0x040025FC RID: 9724
	public GameSettings privacyPolicySetting;

	// Token: 0x040025FD RID: 9725
	public GameSettings licenseSetting;

	// Token: 0x040025FE RID: 9726
	public GameSettings logUploadSetting;

	// Token: 0x040025FF RID: 9727
	public GameSettings basicGraphicSetting;

	// Token: 0x04002600 RID: 9728
	public GameSettings autoRun;

	// Token: 0x04002601 RID: 9729
	public GameSettings autoSprint;

	// Token: 0x04002602 RID: 9730
	public GameSettings vulkan;

	// Token: 0x04002603 RID: 9731
	public GameSettings showOtherName;

	// Token: 0x04002604 RID: 9732
	public GameSettings waterInteract;

	// Token: 0x04002605 RID: 9733
	public GameSettings vegetationDither;

	// Token: 0x04002606 RID: 9734
	public GameSettings vegetationDensity;

	// Token: 0x04002607 RID: 9735
	public GameSettings versionCheck;

	// Token: 0x04002608 RID: 9736
	public GameSettings imageDisplayMode;

	// Token: 0x04002609 RID: 9737
	public GameSettings eyeProtection;

	// Token: 0x0400260A RID: 9738
	public GameSettings eyeProtectionMode;

	// Token: 0x0400260B RID: 9739
	public GameSettings eyeProtectionTemp;

	// Token: 0x0400260C RID: 9740
	public GameSettings eyeProtectionStrength;

	// Token: 0x0400260D RID: 9741
	public GameSettings eyeProtectionBrightness;

	// Token: 0x0400260E RID: 9742
	public GameSettings eyeProtectionTexture;

	// Token: 0x0400260F RID: 9743
	public GameSettings autoExposure;

	// Token: 0x04002610 RID: 9744
	public GameSettings harmonySuperResolution;

	// Token: 0x04002611 RID: 9745
	public GameSettings harmonyRayTracingBoost;

	// Token: 0x04002612 RID: 9746
	public GameSettings harmonyRayTracingBoostAdvanced;

	// Token: 0x04002613 RID: 9747
	public GameSettings adjustiveGamePadTrigger;

	// Token: 0x04002614 RID: 9748
	public GameSettings gamepadLeftStickDeadZone;

	// Token: 0x04002615 RID: 9749
	public GameSettings gamepadRightStickDeadZone;

	// Token: 0x04002616 RID: 9750
	public GameSettings gamepadLeftTriggerDeadZone;

	// Token: 0x04002617 RID: 9751
	public GameSettings gamepadRightTriggerDeadZone;

	// Token: 0x04002618 RID: 9752
	public GameSettings motorAccleratePressType;

	// Token: 0x04002619 RID: 9753
	public GameSettings motorAutoAcceleratorSettingEnable;

	// Token: 0x0400261A RID: 9754
	public GameSettings motorDriftAcceleratorSettingEnable;

	// Token: 0x0400261B RID: 9755
	public GameSettings motorDriftModel;

	// Token: 0x0400261C RID: 9756
	public GameSettings motorHudVisible;

	// Token: 0x0400261D RID: 9757
	public GameSettings subTitleOption;

	// Token: 0x0400261E RID: 9758
	public GameSettings motorTouchFixedPosition;

	// Token: 0x0400261F RID: 9759
	public GameSettings motorMobileButtonCustom;

	// Token: 0x04002620 RID: 9760
	public GameSettings motorMobileButtonLayout;

	// Token: 0x04002621 RID: 9761
	public GameSettings deviceInfo;

	// Token: 0x04002622 RID: 9762
	public GameSettings uiBrightness;

	// Token: 0x04002623 RID: 9763
	public GameSettings peakBrightness;

	// Token: 0x04002624 RID: 9764
	public GameSettings motorFlyControlMode;

	// Token: 0x04002625 RID: 9765
	public GameSettings anisoLevel;

	// Token: 0x04002626 RID: 9766
	public GameSettings xboxOnly;

	// Token: 0x04002627 RID: 9767
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<EFunction, IGameSettings> function2GameSettings;

	// Token: 0x02007478 RID: 29816
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040268F3 RID: 157939
		[Nullable(0)]
		public static Func<int, EGameSettingsApplyReason, bool> <0>__ApplyNvidiaSuperSamplingEnable;
	}
}
