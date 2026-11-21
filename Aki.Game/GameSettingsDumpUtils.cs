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

// Token: 0x02000289 RID: 649
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsDumpUtils : Singleton
{
	// Token: 0x060027E1 RID: 10209 RVA: 0x000F6440 File Offset: 0x000F4640
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

	// Token: 0x060027E2 RID: 10210 RVA: 0x000F648C File Offset: 0x000F468C
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

	// Token: 0x060027E3 RID: 10211 RVA: 0x000F64E7 File Offset: 0x000F46E7
	public string DumpImageQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.KuroRenderQuality") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.GlobalLightQuality");
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x000F6504 File Offset: 0x000F4704
	public string DumpDisplayMode()
	{
		TEnumAsByte<EWindowMode> fullscreenMode = UGameUserSettings.GetGameUserSettings().GetFullscreenMode();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetFullscreenMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<TEnumAsByte<EWindowMode>>(fullscreenMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x000F6544 File Offset: 0x000F4744
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

	// Token: 0x060027E6 RID: 10214 RVA: 0x000F65A0 File Offset: 0x000F47A0
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

	// Token: 0x060027E7 RID: 10215 RVA: 0x000F65FC File Offset: 0x000F47FC
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

	// Token: 0x060027E8 RID: 10216 RVA: 0x000F667C File Offset: 0x000F487C
	public string DumpHighestFps()
	{
		float frameRateLimit = UGameUserSettings.GetGameUserSettings().GetFrameRateLimit();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetFrameRateLimit: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(frameRateLimit);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x000F66B9 File Offset: 0x000F48B9
	public string DumpShadowQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.ShadowQuality");
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x000F66C5 File Offset: 0x000F48C5
	public string DumpNiagaraQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("fx.Niagara.QualityLevel") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.DisableDistortion");
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x000F66E0 File Offset: 0x000F48E0
	public string DumpImageDetail()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ToonOutlineDrawDistancePc") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Streaming.ForceKuroRuntimeLODBias") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ToonOutlineDrawDistanceMobile") + GameSettingsDumpUtils.DumpConsoleVarNumber("foliage.DensityType") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.SceneObjMobileSSR") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.TreeRimLight") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoExposure") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Streaming.ForceKuroRuntimeLODBias");
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x000F676A File Offset: 0x000F496A
	public string DumpAntiAliasing()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.DefaultFeature.AntiAliasing");
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x000F6778 File Offset: 0x000F4978
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

	// Token: 0x060027EE RID: 10222 RVA: 0x000F6850 File Offset: 0x000F4A50
	public string DumpNpcDensity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CreatureController.CurrentCreatureDensityLevelExternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(CreatureController.Instance.CurrentCreatureDensityLevelExternal);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x000F6898 File Offset: 0x000F4A98
	public string DumpNvidiaDlss()
	{
		string str = "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Enable") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAASamples") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAAFilterSize") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR.SecondaryUpscale");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GameSettingsDeviceRender.IsEnableDLSSG: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(GameSettingsDeviceRender.Instance.IsEnableDLSSG());
		return str + defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x000F691C File Offset: 0x000F4B1C
	public string DumpNvidiaDlssFg()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GameSettingsDeviceRender.IsEnableDLSSG: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(GameSettingsDeviceRender.Instance.IsEnableDLSSG());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x000F6957 File Offset: 0x000F4B57
	public string DumpNvidiaDlssQuality()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Quality.Auto") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Quality");
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x000F697C File Offset: 0x000F4B7C
	public string DumpNvidiaDlssSharpness()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SetDLSSSharpness: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(UDLSSLibrary.GetDLSSSharpness());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x000F69B2 File Offset: 0x000F4BB2
	public string DumpNvidiaReflex()
	{
		return "[DumpNvidiaReflex]can not get setting value in engine";
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000F69B9 File Offset: 0x000F4BB9
	public string DumpHdr()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.HDR.EnableHDROutput");
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x000F69D0 File Offset: 0x000F4BD0
	public string DumpFsr()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAASamples") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR.PrimaryUpscale") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.ScreenPercentage") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.MipMapLODBias") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAACurrentFrameWeight") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.ClampTolerant") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.NGX.DLSS.Enable");
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x000F6A5A File Offset: 0x000F4C5A
	public string DumpXess()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x000F6A66 File Offset: 0x000F4C66
	public string DumpXessQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x000F6A72 File Offset: 0x000F4C72
	public string DumpXess2()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Enabled");
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x000F6A7E File Offset: 0x000F4C7E
	public string DumpXess2Fg()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeFG.Enabled");
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x000F6A8A File Offset: 0x000F4C8A
	public string DumpXess2Quality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.XeSS.Quality");
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x000F6A96 File Offset: 0x000F4C96
	public string DumpFsr3()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR3.Enabled");
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x000F6AA2 File Offset: 0x000F4CA2
	public string DumpFsr3Fg()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FI.Enabled");
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x000F6AAE File Offset: 0x000F4CAE
	public string DumpFsr3Quality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FidelityFX.FSR3.QualityMode");
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x000F6ABA File Offset: 0x000F4CBA
	public string DumpPssr()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.SIE.PSSR.Enable");
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x000F6AC6 File Offset: 0x000F4CC6
	public string DumpMetalFxEnable()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.MetalFxUpscale") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth");
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x000F6AE1 File Offset: 0x000F4CE1
	public string DumpIrx()
	{
		return "[DumpIrx]can not get setting value in engine";
	}

	// Token: 0x06002801 RID: 10241 RVA: 0x000F6AE8 File Offset: 0x000F4CE8
	public string DumpBloom()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.KuroBloomEnable");
	}

	// Token: 0x06002802 RID: 10242 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
	public string DumpVolumeFog()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.volumetricfog");
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x000F6B00 File Offset: 0x000F4D00
	public string DumpVolumeLight()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.lightShaftQuality") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.MobileLightShaft");
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x000F6B1B File Offset: 0x000F4D1B
	public string DumpMotionBlur()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.MotionBlur.Amount");
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x000F6B28 File Offset: 0x000F4D28
	public string DumpPcVsync()
	{
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsVSyncEnabled: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(gameUserSettings.IsVSyncEnabled());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x000F6B65 File Offset: 0x000F4D65
	public string DumpMobileResolution()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.SharpenLimitDepth") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.TemporalAA.Sharpness") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.ScreenPercentage");
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x000F6B99 File Offset: 0x000F4D99
	public string DumpTextLanguage()
	{
		return "LanguageSystem.PackageLanguage: " + LanguageSystem.Instance.PackageLanguage;
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x000F6BAF File Offset: 0x000F4DAF
	public string DumpVoiceLanguage()
	{
		return "LanguageSystem.PackageAudio: " + LanguageSystem.Instance.PackageAudio;
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x000F6BC8 File Offset: 0x000F4DC8
	public string DumpHorizontalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraBaseYawSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraBaseYawSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x000F6C08 File Offset: 0x000F4E08
	public string DumpVerticalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraBasePitchSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraBasePitchSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x000F6C48 File Offset: 0x000F4E48
	public string DumpAimHorizontalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraAimingYawSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraAimingYawSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x000F6C88 File Offset: 0x000F4E88
	public string DumpAimVerticalViewSensitivity()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraAimingPitchSensitivity: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraAimingPitchSensitivity);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x000F6CC8 File Offset: 0x000F4EC8
	public string DumpCameraShakeStrength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("ShakeModify: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(CameraModel.Instance.MainModel.ShakeModify);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x000F6D08 File Offset: 0x000F4F08
	public string DumpCommonSpringArmLength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraSettingNormalAdditionArmLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraSettingNormalAdditionArmLength);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x000F6D48 File Offset: 0x000F4F48
	public string DumpFightSpringArmLength()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CameraSettingFightAdditionArmLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CameraModel.Instance.MainModel.CameraSettingFightAdditionArmLength);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x000F6D88 File Offset: 0x000F4F88
	public string DumpResetFocusEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableResetFocus: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableResetFocus);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x000F6DC8 File Offset: 0x000F4FC8
	public string DumpIsSidestepCameraEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableSidestepCamera: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableSidestepCamera);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x000F6E08 File Offset: 0x000F5008
	public string DumpIsSoftLockCameraEnable()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral("IsEnableSoftLockCameraExternal: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.IsEnableSoftLockCameraExternal);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002813 RID: 10259 RVA: 0x000F6E48 File Offset: 0x000F5048
	public string DumpWalkOrRunRate()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetWalkOrRunRate: ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(RoleGaitStatic.GetWalkOrRunRate());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x000F6E80 File Offset: 0x000F5080
	public string DumpJoystickMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetIsDynamicJoystick: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BattleUiModel.Instance.GetIsDynamicJoystick());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x000F6EBC File Offset: 0x000F50BC
	public string DumpSkillButtonMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetIsAutoSwitchSkillButtonMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BattleUiModel.Instance.GetIsAutoSwitchSkillButtonMode());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x000F6EF8 File Offset: 0x000F50F8
	public string DumpAimAssist()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetAimAssistEnable: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CameraModel.Instance.MainModel.GetAimAssistEnable());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x000F6F38 File Offset: 0x000F5138
	public string DumpKeyboardLockEnemyMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DumpKeyboardLockEnemyMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ELockEnemyMode>(FormationDataModel.Instance.KeyboardLockEnemyMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x000F6F74 File Offset: 0x000F5174
	public string DumpGamepadLockEnemyMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DumpGamepadLockEnemyMode: ");
		defaultInterpolatedStringHandler.AppendFormatted<ELockEnemyMode>(FormationDataModel.Instance.GamepadLockEnemyMode);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x000F6FB0 File Offset: 0x000F51B0
	public string DumpEnemyHitDisplayMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral("OpenHitMaterial: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(BulletModel.Instance.OpenHitMaterial);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x000F6FEB File Offset: 0x000F51EB
	public string DumpAutoAdjustImageQuality()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoCoolUIEnable");
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x000F6FF8 File Offset: 0x000F51F8
	public string DumpShowDamage()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GetDamageViewVisible: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(DamageUiManager.Instance.GetDamageViewVisible());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x000F7034 File Offset: 0x000F5234
	public string DumpDynamicBones()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("KuroLodMask: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(CreatureModel.Instance.KuroLodMask);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x000F706F File Offset: 0x000F526F
	public string DumpRayTracing()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("sg.RayTracingQuality");
	}

	// Token: 0x0600281E RID: 10270 RVA: 0x000F707B File Offset: 0x000F527B
	public string DumpRayTracedReflection()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Lumen.Reflections.Allow");
	}

	// Token: 0x0600281F RID: 10271 RVA: 0x000F7087 File Offset: 0x000F5287
	public string DumpRayTracedGI()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Lumen.DiffuseIndirect.Allow");
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x000F7094 File Offset: 0x000F5294
	public string DumpTeammateFx()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
		defaultInterpolatedStringHandler.AppendLiteral("EffectEnvironment.DisableOtherEffect: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(EffectEnvironment.Instance.DisableOtherEffect);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x000F70CF File Offset: 0x000F52CF
	public string DumpSaturation()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Client.Saturation");
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x000F70DB File Offset: 0x000F52DB
	public string DumpContrast()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Client.Contrast");
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x000F70E8 File Offset: 0x000F52E8
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

	// Token: 0x06002824 RID: 10276 RVA: 0x000F718B File Offset: 0x000F538B
	public string DumpImageDisplayMode()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.ImageDisplayMode");
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x000F7197 File Offset: 0x000F5397
	public string DumpEyeProtection()
	{
		return "";
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x000F719E File Offset: 0x000F539E
	public string DumpEyeProtectionMode()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionMode");
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x000F71AA File Offset: 0x000F53AA
	public string DumpEyeProtectionTemp()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionTemp");
	}

	// Token: 0x06002828 RID: 10280 RVA: 0x000F71B6 File Offset: 0x000F53B6
	public string DumpEyeProtectionStrength()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionStrength");
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x000F71C2 File Offset: 0x000F53C2
	public string DumpEyeProtectionBrightness()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionBrightness");
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x000F71CE File Offset: 0x000F53CE
	public string DumpEyeProtectionTexture()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.EyeProtectionTexture");
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x000F71DC File Offset: 0x000F53DC
	public string DumpSkinDamageMode()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CharacterSkinDamageComponent.EnableSkinDamage: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(CharacterSkinDamageComponent.EnableSkinDamage);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x000F7212 File Offset: 0x000F5412
	public string DumpAdrenoFME()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.FEstimation.Option");
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000F7220 File Offset: 0x000F5420
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

	// Token: 0x0600282E RID: 10286 RVA: 0x000F7284 File Offset: 0x000F5484
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

	// Token: 0x0600282F RID: 10287 RVA: 0x000F72E8 File Offset: 0x000F54E8
	public string DumpVulkan()
	{
		return "" + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.VulkanSetting") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.DefaultVulkanSetting") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Android.DisableVulkanSupport") + GameSettingsDumpUtils.DumpConsoleVarNumber("r.Mobile.FlushSceneColorRendering");
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x000F7338 File Offset: 0x000F5538
	public string DumpWaterInteract()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SceneBattleInteractModel.Open: ");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(SceneBattleInteractModel.Instance.Open);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x000F7373 File Offset: 0x000F5573
	public string DumpVegetationDither()
	{
		return "";
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x000F737A File Offset: 0x000F557A
	public string DumpVegetationDensity()
	{
		return "";
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x000F7381 File Offset: 0x000F5581
	public string DumpAutoExposure()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.AutoExposurePlayerCustom");
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x000F7390 File Offset: 0x000F5590
	public string DumpLoadingRangeScaleLevel()
	{
		return string.Concat(new string[]
		{
			GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.Foliage.GrassCullDistanceMax"),
			"; ",
			GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.Foliage.MobileGrassCullDistanceMax"),
			"; ",
			GameSettingsDumpUtils.DumpConsoleVarNumber("wp.Runtime.LoadingRangeScale"),
			"; ",
			GameSettingsDumpUtils.DumpConsoleVarNumber("wp.Runtime.PlannedLoadingRangeScale"),
			"; ",
			GameSettingsDumpUtils.DumpConsoleVarNumber("foliage.LODDistanceScale")
		});
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x000F740A File Offset: 0x000F560A
	public string DumpHarmonySuperResolution()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.HarmonySuperResolution");
	}

	// Token: 0x06002836 RID: 10294 RVA: 0x000F7416 File Offset: 0x000F5616
	public string DumpHarmonyRayTracingBoost()
	{
		return GameSettingsDumpUtils.DumpConsoleVarNumber("r.Kuro.HarmonyRayTracingBoost");
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06002837 RID: 10295 RVA: 0x000F7422 File Offset: 0x000F5622
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

	// Token: 0x06002838 RID: 10296 RVA: 0x000F7445 File Offset: 0x000F5645
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x000F7447 File Offset: 0x000F5647
	public static void ResetStaticDefaultValue()
	{
		GameSettingsDumpUtils instance = GameSettingsDumpUtils._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsDumpUtils._instance = null;
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x000F7460 File Offset: 0x000F5660
	static GameSettingsDumpUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsDumpUtils.CreateStaticDefaultValue), new Action(GameSettingsDumpUtils.ResetStaticDefaultValue));
	}

	// Token: 0x04002728 RID: 10024
	[Nullable(2)]
	private static GameSettingsDumpUtils _instance;
}
