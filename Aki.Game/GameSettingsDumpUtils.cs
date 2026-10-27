using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Render;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Util;
using UnrealEngine;

// Token: 0x02000DD7 RID: 3543
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDumpUtils : Singleton
{
	// Token: 0x0600545A RID: 21594 RVA: 0x000EF6F8 File Offset: 0x000ED8F8
	private static string DumpConsoleVarNumber(string command)
	{
		float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue(command);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted(command);
		defaultInterpolatedStringHandler.AppendLiteral(": ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(consoleVariableFloatValue);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x000EF744 File Offset: 0x000ED944
	public string DumpVolume(string volumeTag)
	{
		float value = 0f;
		AudioController.Instance.GetRTPCValue(ref value, volumeTag, null, null, 0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted(volumeTag);
		defaultInterpolatedStringHandler.AppendLiteral(": ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(value);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x000EF79F File Offset: 0x000ED99F
	public string DumpImageQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.KuroRenderQuality") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.GlobalLightQuality");
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x000EF7BC File Offset: 0x000ED9BC
	public string DumpDisplayMode()
	{
		TEnumAsByte<EWindowMode> fullscreenMode = UGameUserSettings.GetGameUserSettings().GetFullscreenMode();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetFullscreenMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<TEnumAsByte<EWindowMode>>(fullscreenMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x000EF7FC File Offset: 0x000ED9FC
	public string DumpResourceStandard()
	{
		ETier localResourceQualityTier = HotFixManager.LocalResourceQualityTier;
		string localResourceQualityTierLabel = HotFixManager.GetLocalResourceQualityTierLabel();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
		defaultInterpolatedStringHandler.AppendLiteral("ResourceStandard tier: ");
		defaultInterpolatedStringHandler.AppendFormatted<ETier>(localResourceQualityTier);
		defaultInterpolatedStringHandler.AppendLiteral(", label: ");
		defaultInterpolatedStringHandler.AppendFormatted(localResourceQualityTierLabel ?? "none");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x000EF858 File Offset: 0x000EDA58
	public string DumpResolution()
	{
		FIntPoint screenResolution = UGameUserSettings.GetGameUserSettings().GetScreenResolution();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
		defaultInterpolatedStringHandler.AppendLiteral("GetScreenResolution: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(screenResolution.X);
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(screenResolution.Y);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x000EF8B4 File Offset: 0x000EDAB4
	public string DumpBrightness()
	{
		string str = "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TonemapperGamma") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.LUT.Regenerate");
		float scalarParameterValue = UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowBrightnessMaterialParameterCollection(), RenderConfig.UIShowBrightness);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetScalarParameterValue_UIShowBrightness: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(scalarParameterValue);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return str + defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x000EF934 File Offset: 0x000EDB34
	public string DumpHighestFps()
	{
		float frameRateLimit = UGameUserSettings.GetGameUserSettings().GetFrameRateLimit();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetFrameRateLimit: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(frameRateLimit);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005462 RID: 21602 RVA: 0x000EF971 File Offset: 0x000EDB71
	public string DumpShadowQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.ShadowQuality");
	}

	// Token: 0x06005463 RID: 21603 RVA: 0x000EF97D File Offset: 0x000EDB7D
	public string DumpNiagaraQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("fx.Niagara.QualityLevel") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.DisableDistortion");
	}

	// Token: 0x06005464 RID: 21604 RVA: 0x000EF998 File Offset: 0x000EDB98
	public string DumpImageDetail()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ToonOutlineDrawDistancePc") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Streaming.ForceKuroRuntimeLODBias") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ToonOutlineDrawDistanceMobile") + GameSettingsDumpUtils.DumpConsoleVarNumber("foliage.DensityType") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.SceneObjMobileSSR") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.TreeRimLight") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoExposure") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Streaming.ForceKuroRuntimeLODBias");
	}

	// Token: 0x06005465 RID: 21605 RVA: 0x000EFA22 File Offset: 0x000EDC22
	public string DumpAntiAliasing()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.DefaultFeature.AntiAliasing");
	}

	// Token: 0x06005466 RID: 21606 RVA: 0x000EFA30 File Offset: 0x000EDC30
	public string DumpSceneAo()
	{
		string str = "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.AmbientOcclusionLevels") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.SSAO");
		float scalarParameterValue = UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), new FName("EnableMobileScreenAO"));
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetScalarParameterValue_EnableMobileScreenAO: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(scalarParameterValue);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		string str2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
		scalarParameterValue = UKismetMaterialLibrary.GetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), RenderConfig.GlobalGrassAO);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetScalarParameterValue_GlobalGrassAO: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(scalarParameterValue);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return str2 + defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005467 RID: 21607 RVA: 0x000EFB08 File Offset: 0x000EDD08
	public string DumpNpcDensity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CreatureController.CurrentCreatureDensityLevelExternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(CreatureController.Instance.CurrentCreatureDensityLevelExternal);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005468 RID: 21608 RVA: 0x000EFB50 File Offset: 0x000EDD50
	public string DumpNvidiaDlss()
	{
		string str = "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Enable") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAASamples") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAAFilterSize") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR.SecondaryUpscale");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GameSettingsDeviceRender.IsEnableDLSSG: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(GameSettingsDeviceRender.Instance.IsEnableDLSSG());
		return str + defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005469 RID: 21609 RVA: 0x000EFBD4 File Offset: 0x000EDDD4
	public string DumpNvidiaDlssFg()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GameSettingsDeviceRender.IsEnableDLSSG: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(GameSettingsDeviceRender.Instance.IsEnableDLSSG());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x000EFC0F File Offset: 0x000EDE0F
	public string DumpNvidiaDlssQuality()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Quality.Auto") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Quality");
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x000EFC34 File Offset: 0x000EDE34
	public string DumpNvidiaDlssSharpness()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SetDLSSSharpness: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(UDLSSLibrary.GetDLSSSharpness());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x000EFC6A File Offset: 0x000EDE6A
	public string DumpNvidiaReflex()
	{
		return "[DumpNvidiaReflex]can not get setting value in engine";
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x000EFC71 File Offset: 0x000EDE71
	public string DumpHdr()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.HDR.EnableHDROutput");
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x000EFC88 File Offset: 0x000EDE88
	public string DumpFsr()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAASamples") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR.PrimaryUpscale") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.ScreenPercentage") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.MipMapLODBias") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAACurrentFrameWeight") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.ClampTolerant") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Enable");
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x000EFD12 File Offset: 0x000EDF12
	public string DumpXess()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x000EFD1E File Offset: 0x000EDF1E
	public string DumpXessQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x06005471 RID: 21617 RVA: 0x000EFD2A File Offset: 0x000EDF2A
	public string DumpXess2()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x000EFD36 File Offset: 0x000EDF36
	public string DumpXess2Fg()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeFG.Enabled");
	}

	// Token: 0x06005473 RID: 21619 RVA: 0x000EFD42 File Offset: 0x000EDF42
	public string DumpXess2Quality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Quality");
	}

	// Token: 0x06005474 RID: 21620 RVA: 0x000EFD4E File Offset: 0x000EDF4E
	public string DumpFsr3()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR3.Enabled");
	}

	// Token: 0x06005475 RID: 21621 RVA: 0x000EFD5A File Offset: 0x000EDF5A
	public string DumpFsr3Fg()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FI.Enabled");
	}

	// Token: 0x06005476 RID: 21622 RVA: 0x000EFD66 File Offset: 0x000EDF66
	public string DumpFsr3Quality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR3.QualityMode");
	}

	// Token: 0x06005477 RID: 21623 RVA: 0x000EFD72 File Offset: 0x000EDF72
	public string DumpMetalFxEnable()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.MetalFxUpscale") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth");
	}

	// Token: 0x06005478 RID: 21624 RVA: 0x000EFD8D File Offset: 0x000EDF8D
	public string DumpIrx()
	{
		return "[DumpIrx]can not get setting value in engine";
	}

	// Token: 0x06005479 RID: 21625 RVA: 0x000EFD94 File Offset: 0x000EDF94
	public string DumpBloom()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.KuroBloomEnable");
	}

	// Token: 0x0600547A RID: 21626 RVA: 0x000EFDA0 File Offset: 0x000EDFA0
	public string DumpVolumeFog()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.volumetricfog");
	}

	// Token: 0x0600547B RID: 21627 RVA: 0x000EFDAC File Offset: 0x000EDFAC
	public string DumpVolumeLight()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.lightShaftQuality") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.MobileLightShaft");
	}

	// Token: 0x0600547C RID: 21628 RVA: 0x000EFDC7 File Offset: 0x000EDFC7
	public string DumpMotionBlur()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.MotionBlur.Amount");
	}

	// Token: 0x0600547D RID: 21629 RVA: 0x000EFDD4 File Offset: 0x000EDFD4
	public string DumpPcVsync()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsVSyncEnabled: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(gameUserSettings.IsVSyncEnabled());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600547E RID: 21630 RVA: 0x000EFE11 File Offset: 0x000EE011
	public string DumpMobileResolution()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.Sharpness") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.ScreenPercentage");
	}

	// Token: 0x0600547F RID: 21631 RVA: 0x000EFE45 File Offset: 0x000EE045
	public string DumpTextLanguage()
	{
		return "LanguageSystem.PackageLanguage: " + LanguageSystem.Instance.PackageLanguage;
	}

	// Token: 0x06005480 RID: 21632 RVA: 0x000EFE5B File Offset: 0x000EE05B
	public string DumpVoiceLanguage()
	{
		return "LanguageSystem.PackageAudio: " + LanguageSystem.Instance.PackageAudio;
	}

	// Token: 0x06005481 RID: 21633 RVA: 0x000EFE74 File Offset: 0x000EE074
	public string DumpHorizontalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraBaseYawSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraBaseYawSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005482 RID: 21634 RVA: 0x000EFEB4 File Offset: 0x000EE0B4
	public string DumpVerticalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraBasePitchSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraBasePitchSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005483 RID: 21635 RVA: 0x000EFEF4 File Offset: 0x000EE0F4
	public string DumpAimHorizontalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraAimingYawSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraAimingYawSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005484 RID: 21636 RVA: 0x000EFF34 File Offset: 0x000EE134
	public string DumpAimVerticalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraAimingPitchSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraAimingPitchSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005485 RID: 21637 RVA: 0x000EFF74 File Offset: 0x000EE174
	public string DumpCameraShakeStrength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("ShakeModify: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(CameraModel.Instance.MainModel.ShakeModify);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005486 RID: 21638 RVA: 0x000EFFB4 File Offset: 0x000EE1B4
	public string DumpCommonSpringArmLength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraSettingNormalAdditionArmLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraSettingNormalAdditionArmLength);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005487 RID: 21639 RVA: 0x000EFFF4 File Offset: 0x000EE1F4
	public string DumpFightSpringArmLength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraSettingFightAdditionArmLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraSettingFightAdditionArmLength);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005488 RID: 21640 RVA: 0x000F0034 File Offset: 0x000EE234
	public string DumpResetFocusEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableResetFocus: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableResetFocus);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005489 RID: 21641 RVA: 0x000F0074 File Offset: 0x000EE274
	public string DumpIsSidestepCameraEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableSidestepCamera: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableSidestepCamera);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548A RID: 21642 RVA: 0x000F00B4 File Offset: 0x000EE2B4
	public string DumpIsSoftLockCameraEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableSoftLockCameraExternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableSoftLockCameraExternal);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548B RID: 21643 RVA: 0x000F00F4 File Offset: 0x000EE2F4
	public string DumpWalkOrRunRate()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetWalkOrRunRate: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(RoleGaitStatic.GetWalkOrRunRate());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548C RID: 21644 RVA: 0x000F012C File Offset: 0x000EE32C
	public string DumpJoystickMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetIsDynamicJoystick: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BattleUiModel.Instance.GetIsDynamicJoystick());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x000F0168 File Offset: 0x000EE368
	public string DumpSkillButtonMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetIsAutoSwitchSkillButtonMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BattleUiModel.Instance.GetIsAutoSwitchSkillButtonMode());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x000F01A4 File Offset: 0x000EE3A4
	public string DumpAimAssist()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetAimAssistEnable: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.GetAimAssistEnable());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x000F01E4 File Offset: 0x000EE3E4
	public string DumpKeyboardLockEnemyMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DumpKeyboardLockEnemyMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ELockEnemyMode>(FormationDataModel.Instance.KeyboardLockEnemyMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x000F0220 File Offset: 0x000EE420
	public string DumpGamepadLockEnemyMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DumpGamepadLockEnemyMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ELockEnemyMode>(FormationDataModel.Instance.GamepadLockEnemyMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005491 RID: 21649 RVA: 0x000F025C File Offset: 0x000EE45C
	public string DumpEnemyHitDisplayMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral("OpenHitMaterial: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BulletModel.Instance.OpenHitMaterial);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005492 RID: 21650 RVA: 0x000F0297 File Offset: 0x000EE497
	public string DumpAutoAdjustImageQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoCoolUIEnable");
	}

	// Token: 0x06005493 RID: 21651 RVA: 0x000F02A4 File Offset: 0x000EE4A4
	public string DumpShowDamage()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetDamageViewVisible: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(DamageUiManager.Instance.GetDamageViewVisible());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x000F02E0 File Offset: 0x000EE4E0
	public string DumpDynamicBones()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("KuroLodMask: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(CreatureModel.Instance.KuroLodMask);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x000F031B File Offset: 0x000EE51B
	public string DumpRayTracing()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.RayTracingQuality");
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x000F0327 File Offset: 0x000EE527
	public string DumpRayTracedReflection()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Lumen.Reflections.Allow");
	}

	// Token: 0x06005497 RID: 21655 RVA: 0x000F0333 File Offset: 0x000EE533
	public string DumpRayTracedGI()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Lumen.DiffuseIndirect.Allow");
	}

	// Token: 0x06005498 RID: 21656 RVA: 0x000F0340 File Offset: 0x000EE540
	public string DumpTeammateFx()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
		defaultInterpolatedStringHandler.AppendLiteral("EffectEnvironment.DisableOtherEffect: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(EffectEnvironment.Instance.DisableOtherEffect);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x000F037B File Offset: 0x000EE57B
	public string DumpSaturation()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Client.Saturation");
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x000F0387 File Offset: 0x000EE587
	public string DumpContrast()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Client.Contrast");
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x000F0394 File Offset: 0x000EE594
	public string DumpFilter()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, 0);
		Dictionary<int, float[]> global2 = LocalStorage.GetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, null);
		float[] array;
		if (global2 == null || !global2.TryGetValue(global, out array) || array == null)
		{
			return "滤镜数据不完整，或者尚未初始化";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 4);
		defaultInterpolatedStringHandler.AppendLiteral("滤镜数据：Id：");
		defaultInterpolatedStringHandler.AppendFormatted<int>(global);
		defaultInterpolatedStringHandler.AppendLiteral(", x: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(array[0]);
		defaultInterpolatedStringHandler.AppendLiteral(", y: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(array[1]);
		defaultInterpolatedStringHandler.AppendLiteral(", intensity: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(array[2]);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600549C RID: 21660 RVA: 0x000F0437 File Offset: 0x000EE637
	public string DumpImageDisplayMode()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ImageDisplayMode");
	}

	// Token: 0x0600549D RID: 21661 RVA: 0x000F0443 File Offset: 0x000EE643
	public string DumpEyeProtection()
	{
		return "";
	}

	// Token: 0x0600549E RID: 21662 RVA: 0x000F044A File Offset: 0x000EE64A
	public string DumpEyeProtectionMode()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionMode");
	}

	// Token: 0x0600549F RID: 21663 RVA: 0x000F0456 File Offset: 0x000EE656
	public string DumpEyeProtectionTemp()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionTemp");
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x000F0462 File Offset: 0x000EE662
	public string DumpEyeProtectionStrength()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionStrength");
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x000F046E File Offset: 0x000EE66E
	public string DumpEyeProtectionBrightness()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionBrightness");
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x000F047A File Offset: 0x000EE67A
	public string DumpEyeProtectionTexture()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionTexture");
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x000F0488 File Offset: 0x000EE688
	public string DumpSkinDamageMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CharacterSkinDamageComponent.EnableSkinDamage: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CharacterSkinDamageComponent.EnableSkinDamage);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x000F04BE File Offset: 0x000EE6BE
	public string DumpAdrenoFME()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FEstimation.Option");
	}

	// Token: 0x060054A5 RID: 21669 RVA: 0x000F04CC File Offset: 0x000EE6CC
	public string DumpAutoRun()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("AutoMovingSettingEnable: ");
		BattleUiModel instance = BattleUiModel.Instance;
		bool? value;
		if (instance == null)
		{
			value = null;
		}
		else
		{
			BattleUiFormationData formationData = instance.FormationData;
			value = ((formationData != null) ? new bool?(formationData.AutoMovingSettingEnable) : null);
		}
		defaultInterpolatedStringHandler.AppendFormatted<bool?>(value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x000F0530 File Offset: 0x000EE730
	public string DumpAutoSprint()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("AutoSprintSettingEnable: ");
		BattleUiModel instance = BattleUiModel.Instance;
		bool? value;
		if (instance == null)
		{
			value = null;
		}
		else
		{
			BattleUiFormationData formationData = instance.FormationData;
			value = ((formationData != null) ? new bool?(formationData.AutoSprintSettingEnable) : null);
		}
		defaultInterpolatedStringHandler.AppendFormatted<bool?>(value);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060054A7 RID: 21671 RVA: 0x000F0594 File Offset: 0x000EE794
	public string DumpVulkan()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.VulkanSetting") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.DefaultVulkanSetting") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.DisableVulkanSupport") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.FlushSceneColorRendering");
	}

	// Token: 0x060054A8 RID: 21672 RVA: 0x000F05E4 File Offset: 0x000EE7E4
	public string DumpWaterInteract()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SceneBattleInteractModel.Open: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(SceneBattleInteractModel.Instance.Open);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x000F061F File Offset: 0x000EE81F
	public string DumpVegetationDither()
	{
		return "";
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x000F0626 File Offset: 0x000EE826
	public string DumpVegetationDensity()
	{
		return "";
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x000F062D File Offset: 0x000EE82D
	public string DumpAutoExposure()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoExposurePlayerCustom");
	}

	// Token: 0x060054AC RID: 21676 RVA: 0x000F0639 File Offset: 0x000EE839
	public string DumpLoadingRangeScaleLevel()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("wp.Runtime.PlannedLoadingRangeScaleExtra");
	}

	// Token: 0x060054AD RID: 21677 RVA: 0x000F0645 File Offset: 0x000EE845
	public string DumpHarmonySuperResolution()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.HarmonySuperResolution");
	}

	// Token: 0x060054AE RID: 21678 RVA: 0x000F0651 File Offset: 0x000EE851
	public string DumpHarmonyRayTracingBoost()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.HarmonyRayTracingBoost");
	}

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x060054AF RID: 21679 RVA: 0x000F065D File Offset: 0x000EE85D
	public static GameSettingsDumpUtils Instance
	{
		get
		{
			if (GameSettingsDumpUtils._instance == null)
			{
				GameSettingsDumpUtils._instance = new GameSettingsDumpUtils();
				GameSettingsDumpUtils._instance.OnInit();
			}
			return GameSettingsDumpUtils._instance;
		}
	}

	// Token: 0x060054B0 RID: 21680 RVA: 0x000F0680 File Offset: 0x000EE880
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060054B1 RID: 21681 RVA: 0x000F0682 File Offset: 0x000EE882
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDumpUtils instance = GameSettingsDumpUtils._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsDumpUtils._instance = null;
	}

	// Token: 0x060054B2 RID: 21682 RVA: 0x000F069B File Offset: 0x000EE89B
	static GameSettingsDumpUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDumpUtils.CreateStaticDefaultValue), new Action(GameSettingsDumpUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0400269D RID: 9885
	[Nullable(2)]
	private static GameSettingsDumpUtils _instance;
}
