using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Render;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.GameSettings
{
	// Token: 0x02007241 RID: 29249
	[NullableContext(1)]
	[Nullable(0)]
	public class GameSettingsUtils : IStaticVariableResetter
	{
		// Token: 0x06047AF0 RID: 293616 RVA: 0x01258DFE File Offset: 0x01256FFE
		static GameSettingsUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsUtils.CreateStaticDefaultValue), new Action(GameSettingsUtils.ResetStaticDefaultValue));
		}

		// Token: 0x06047AF1 RID: 293617 RVA: 0x01258E20 File Offset: 0x01257020
		public static void CreateStaticDefaultValue()
		{
			GameSettingsUtils.Fsr3FgSwitchStates = new Dictionary<int, int>
			{
				{
					0,
					0
				},
				{
					1,
					0
				},
				{
					3,
					0
				},
				{
					4,
					0
				}
			};
			GameSettingsUtils.GrassCullDistanceCache = null;
			GameSettingsUtils.GrassMobileCullDistanceCache = null;
			GameSettingsUtils.GrassLODDistanceScaleCache = null;
		}

		// Token: 0x06047AF2 RID: 293618 RVA: 0x01258E78 File Offset: 0x01257078
		public static void ResetStaticDefaultValue()
		{
			GameSettingsUtils.NvidiaSuperSamplingQualityCache = null;
			GameSettingsUtils.KuroLocalRenderSettingIndexCache = null;
			GameSettingsUtils.XessEnabled = false;
			GameSettingsUtils.Fsr3FgEnable = false;
			GameSettingsUtils.Fsr3FgApplyMode = EFFXFIApplyMode.Default;
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = false;
			GameSettingsUtils.Fsr3FgSwitchStates = null;
			GameSettingsUtils.GrassCullDistanceCache = null;
			GameSettingsUtils.GrassMobileCullDistanceCache = null;
			GameSettingsUtils.GrassLODDistanceScaleCache = null;
		}

		// Token: 0x06047AF3 RID: 293619 RVA: 0x01258EDC File Offset: 0x012570DC
		public static bool ApplyVolume(float value, string volumeTag)
		{
			UAkGameplayStatics.SetRTPCValue(null, value, 0, null, FNameUtil.GetDynamicFName(volumeTag).Value);
			return true;
		}

		// Token: 0x06047AF4 RID: 293620 RVA: 0x01258F04 File Offset: 0x01257104
		public unsafe static bool ApplyImageQualityOnly(int value)
		{
			if (UKuroRenderingRuntimeBPPluginBPLibrary.GetCVarFloat("r.Kuro.Movie.EnableCGMovieRendering") > 0f)
			{
				Log.Instance.Info(ELogModule.Render, ELogAuthor.HCS, "当前在movie 渲染模式下不应用配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(800, value.ToString());
				UPerfSightHelper.PostEvent(814, GameSettingsDeviceRender.Instance.GetD3D12Type().ToString());
				UPerfSightHelper.PostEvent(815, GameSettingsDeviceRender.Instance.CPUFrequency.ToString());
				UPerfSightHelper.PostEvent(816, GameSettingsDeviceRender.Instance.CPUCoresIncludingHyperthreads.ToString());
				UPerfSightHelper.PostEvent(825, GameSettingsDeviceRender.Instance.IsVulkanRHI().ToString());
			}
			FCrashSightProxy.SetCustomData("DX12", GameSettingsDeviceRender.Instance.GetD3D12Type().ToString());
			FCrashSightProxy.SetCustomData("Vulkan", GameSettingsDeviceRender.Instance.IsVulkanRHI().ToString());
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (gameUserSettings == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GameSettings;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "GetGameUserSettings失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("qualityLevel", value);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			bool flag = Info.Instance.IsPcOrGamepadPlatform();
			bool flag2 = Info.Instance.IsMobilePlatform();
			bool flag3 = Info.Instance.IsPs5Platform() || (Info.Instance.IsXboxPlatform() && !Info.Instance.IsWinGDKPlatform());
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "ApplyImageQualityOnly: ";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isPcOrGamepadPlatform", flag.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isMobilePlatform", flag2.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isSingleImageQualityOption", flag3.ToString());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (flag)
			{
				if (flag3)
				{
					int num;
					if (value == 3)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.GameSettings;
					ELogAuthor author3 = ELogAuthor.ZYT;
					string message3 = "优先应用的画质等级[done]@[PS5/XSX]";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PS5/XSX quality level", num);
					instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					gameUserSettings.SetGameQualitySettingLevel((float)num);
				}
				else
				{
					gameUserSettings.SetGameQualitySettingLevel((float)value);
					if (Info.Instance.IsMacPlatform())
					{
						if (value > 2)
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 70", null);
						}
						else if (value == 2)
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 65", null);
						}
						else if (value == 1)
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 60", null);
						}
						else if (value == 0)
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 55", null);
						}
					}
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.GameSettings;
					ELogAuthor author4 = ELogAuthor.WZ;
					string message4 = "优先应用的画质等级[done]@[Pc或手柄平台]";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("quality level", value);
					instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
				gameUserSettings.ApplySettings(true);
			}
			else if (flag2)
			{
				gameUserSettings.SetMobileGameQualitySettingLevel((float)value);
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.GameSettings;
				ELogAuthor author5 = ELogAuthor.WZ;
				string message5 = "优先应用的画质等级[done]@[移动端平台]";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("quality level", value);
				instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			}
			GameSettingsUtils.ReApplyMaterialQualityLevel(new int?(value));
			GameSettingsUtils.GrassCullDistanceCache = new float?(UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.Foliage.GrassCullDistanceMax"));
			GameSettingsUtils.GrassMobileCullDistanceCache = new float?(UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.Foliage.MobileGrassCullDistanceMax"));
			GameSettingsUtils.GrassLODDistanceScaleCache = new float?(UKismetSystemLibrary.GetConsoleVariableFloatValue("foliage.LODDistanceScale"));
			return true;
		}

		// Token: 0x06047AF5 RID: 293621 RVA: 0x01259277 File Offset: 0x01257477
		public static void SetIsCustomImageQuality(bool value)
		{
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsCustomImageQuality, value);
		}

		// Token: 0x06047AF6 RID: 293622 RVA: 0x01259284 File Offset: 0x01257484
		public static bool ReApplyMaterialQualityLevel(int? value = null)
		{
			int? num = value;
			int? num2 = (num != null) ? num : GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true);
			if (num2 == null)
			{
				return false;
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), new FName("KuroMaterialQualityLevel"), (float)num2.Value);
			return true;
		}

		// Token: 0x06047AF7 RID: 293623 RVA: 0x012592E0 File Offset: 0x012574E0
		public static bool ApplyShadowQuality(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("sg.ShadowQuality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (GameSettingsManager.Instance.IsValid(EFunction.SCENEAO, true))
			{
				GameSettingsUtils.ApplySceneAo(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.SCENEAO, 0, true), new int?(value));
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(808, value.ToString());
			}
			return true;
		}

		// Token: 0x06047AF8 RID: 293624 RVA: 0x01259360 File Offset: 0x01257560
		public static bool ApplyDisplayMode(int value)
		{
			EWindowMode[] array = new EWindowMode[]
			{
				EWindowMode.WindowedFullscreen,
				EWindowMode.Windowed
			};
			int num = MathUtils.Instance.Clamp(value, 0, array.Length - 1);
			EWindowMode fullscreenMode = array[num];
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetFullscreenMode(fullscreenMode);
			gameUserSettings.ApplySettings(true);
			EventSystem.Instance.Emit(EEventName.SetDisplayMode);
			return true;
		}

		// Token: 0x06047AF9 RID: 293625 RVA: 0x012593B5 File Offset: 0x012575B5
		public static bool ApplyResourceStandard(int value)
		{
			return true;
		}

		// Token: 0x06047AFA RID: 293626 RVA: 0x012593B8 File Offset: 0x012575B8
		public static bool ApplyResolution(int value)
		{
			FIntPoint resolutionByList = GameSettingsDeviceRender.Instance.GetResolutionByList(value);
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetScreenResolution(resolutionByList);
			gameUserSettings.ApplySettings(true);
			if (PerfSightController.IsEnable)
			{
				int num = 1;
				if (resolutionByList.X > 4000)
				{
					num = 4;
				}
				else if (resolutionByList.X > 3000)
				{
					num = 3;
				}
				else if (resolutionByList.X > 2000)
				{
					num = 2;
				}
				UPerfSightHelper.PostEvent(803, num.ToString());
			}
			EventSystem.Instance.Emit(EEventName.SetResolution);
			return true;
		}

		// Token: 0x06047AFB RID: 293627 RVA: 0x01259440 File Offset: 0x01257640
		public static bool ApplyBrightness(float value)
		{
			float num;
			if (value < 0f)
			{
				num = MathUtils.Instance.Lerp(1.5f, 2.2f, value + 1f);
			}
			else
			{
				num = MathUtils.Instance.Lerp(2.2f, 3.5f, value);
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.TonemapperGamma ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.LUT.Regenerate 1", null);
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetUiShowBrightnessMaterialParameterCollection(), RenderConfig.UIShowBrightness, num);
			return true;
		}

		// Token: 0x06047AFC RID: 293628 RVA: 0x012594EC File Offset: 0x012576EC
		public static bool ApplyHighestFps(int value)
		{
			int frameByList = GameSettingsDeviceRender.Instance.GetFrameByList(value);
			GameSettingsDeviceRender.Instance.ApplyFrameRate(frameByList);
			return true;
		}

		// Token: 0x06047AFD RID: 293629 RVA: 0x01259514 File Offset: 0x01257714
		public static bool ApplyNiagaraQuality(int value)
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				bool flag = GameSettingsDeviceRender.Instance.IsIosAndAndroidHighDevice();
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.DisableDistortion ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 0 && flag) ? 0 : 1);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("fx.Niagara.QualityLevel ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 0) ? 1 : 0);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			else
			{
				int value2 = value + 1;
				UObject world3 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("fx.Niagara.QualityLevel ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			gameUserSettings.ApplySettings(true);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(807, value.ToString());
			}
			return true;
		}

		// Token: 0x06047AFE RID: 293630 RVA: 0x01259600 File Offset: 0x01257800
		public unsafe static bool ApplyImageDetail(int value)
		{
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(805, value.ToString());
			}
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.ToonOutlineDrawDistanceMobile ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 1) ? 500 : 500);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				int value2 = MathUtils.Instance.Clamp(value, 0, 2);
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("foliage.DensityType ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				bool flag = GameSettingsDeviceRender.Instance.IsAndroidPlatformScreenBetter();
				UObject world3 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Mobile.SceneObjMobileSSR ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 2 && flag) ? 1 : 0);
				UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				bool flag2 = GameSettingsDeviceRender.Instance.IsAndroidPlatformNotLow();
				UObject world4 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Mobile.TreeRimLight ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 2 && flag2) ? 1 : 0);
				UKismetSystemLibrary.ExecuteConsoleCommand(world4, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				AWorldSettings aworldSettings = GlobalData.World.GetWorld().K2_GetWorldSettings();
				int num = MathUtils.Instance.Clamp(value, 0, 2) + 1;
				if (aworldSettings != null && aworldSettings.bEnableWorldPartition)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GameSettings;
					ELogAuthor author = ELogAuthor.ZYT;
					string message = "UpdateFoliageDataLayer";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("foliageDataLayerValue", num);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					UKuroRenderingRuntimeBPPluginBPLibrary.UpdateFoliageDataLayer(GlobalData.World, num);
				}
				bool flag3 = flag && GameSettingsDeviceRender.Instance.IsAndroidAdreno();
				UObject world5 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.AutoExposure ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 2 && flag3) ? 1 : 0);
				UKismetSystemLibrary.ExecuteConsoleCommand(world5, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UStreamableRenderAsset.SetKuroStreamingQualityLevel(value);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.GameSettings;
				ELogAuthor author2 = ELogAuthor.LQX;
				string message2 = "SetKuroStreamingQualityLevel";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("streamingQualityLevel", value);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			else
			{
				UObject world6 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.ToonOutlineDrawDistancePc ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value > 1) ? 4000 : 2000);
				UKismetSystemLibrary.ExecuteConsoleCommand(world6, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				int videoMemoryGB = UKuroStaticLibrary.GetVideoMemoryGB();
				int num2;
				if (videoMemoryGB <= 2)
				{
					num2 = ((value < 2) ? 0 : (value - 1));
				}
				else
				{
					num2 = ((value == 0) ? 0 : (value + 1));
				}
				UStreamableRenderAsset.SetKuroStreamingQualityLevel(num2);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.GameSettings;
				ELogAuthor author3 = ELogAuthor.LQX;
				string message3 = "SetKuroStreamingQualityLevel";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("videoMemoryGB", videoMemoryGB);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("streamingQualityLevel", num2);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return true;
		}

		// Token: 0x06047AFF RID: 293631 RVA: 0x01259904 File Offset: 0x01257B04
		public static bool ApplyAntiAliasing(int value)
		{
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.DefaultFeature.AntiAliasing ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value == 0) ? 0 : 2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			else
			{
				UObject world2 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.DefaultFeature.AntiAliasing ");
				defaultInterpolatedStringHandler.AppendFormatted<int>((value == 0) ? 0 : 2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(802, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B00 RID: 293632 RVA: 0x012599A4 File Offset: 0x01257BA4
		public static bool ApplySceneAo(int value, int? shadowQualityOverride = null)
		{
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				int value2 = (value > 0) ? -1 : 0;
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.AmbientOcclusionLevels ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				RenderDataManager.Instance.SetGrassAo((float)value);
				if (value > 1)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DistanceFieldAO 1", null);
					UObject world2 = GlobalData.World;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
					defaultInterpolatedStringHandler.AppendLiteral("r.DistanceFieldAOQuality ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.DistanceFieldAO 0", null);
				}
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(810, value.ToString());
				}
			}
			else
			{
				bool flag = GameSettingsDeviceRender.Instance.IsAndroidPlatformAOValid() || GameSettingsDeviceRender.Instance.IsIOSPlatformAOValid() || GameSettingsDeviceRender.Instance.IsOpenHarmonyPlatformAOValid();
				int num = ((shadowQualityOverride ?? GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.SHADOWQUALITY, 0, true)) > 0 && flag) ? value : 0;
				UObject world3 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Mobile.SSAO ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), new FName("EnableMobileScreenAO"), (float)num);
				RenderDataManager.Instance.SetGrassAo((float)num);
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(810, num.ToString());
				}
			}
			return true;
		}

		// Token: 0x06047B01 RID: 293633 RVA: 0x01259B48 File Offset: 0x01257D48
		public static bool ApplyNpcDensity(int value)
		{
			int num = value;
			int kuroRenderQualityLocalIndex = GameSettingsController.Instance.KuroRenderQualityLocalIndex;
			if (kuroRenderQualityLocalIndex >= 30 && kuroRenderQualityLocalIndex <= 39 && num > 1)
			{
				num = 1;
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.ZYT, "KuroLocalRenderSettingIndex Change npcDensity 2", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (UKuroStaticLibrary.IsLowMemoryDevice() && num > 1)
			{
				num = 1;
			}
			CreatureController.Instance.RefreshDensityLevel(num);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(806, num.ToString());
			}
			return true;
		}

		// Token: 0x06047B02 RID: 293634 RVA: 0x01259BC4 File Offset: 0x01257DC4
		public static bool ApplyNvidiaSuperSamplingEnable(int value, EGameSettingsApplyReason reason)
		{
			if (Info.Instance.IsPs5Platform())
			{
				return false;
			}
			if (!GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				return false;
			}
			if (GameSettingsDeviceRender.Instance.IsNvidiaDlessPluginLoaded())
			{
				if (value == 1)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 1", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAASamples 8", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAAFilterSize 1", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.SecondaryUpscale 0", null);
					GameSettingsManager.Instance.ReApply(EFunction.NVIDIADLSSFG, EGameSettingsApplyReason.AnyTime, false);
					GameSettingsManager.Instance.ReApply(EFunction.NVIDIAREFLEX, EGameSettingsApplyReason.AnyTime, false);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAASamples 4", null);
					GameSettingsUtils.ApplyNvidiaSuperSamplingFrameGenerate(0);
				}
				if (reason != EGameSettingsApplyReason.WhenLoading)
				{
					GameSettingsManager.Instance.ReApply(EFunction.PCVSYNC, reason, false);
				}
				if (GameSettingsDeviceRender.Instance.InCacheSceneColorMode == 1)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.CacheSceneColor.Start", null);
				}
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(804, value.ToString());
				}
			}
			return true;
		}

		// Token: 0x06047B03 RID: 293635 RVA: 0x01259CD0 File Offset: 0x01257ED0
		public static bool ApplyNvidiaSuperSamplingFrameGenerate(int value)
		{
			if (!GameSettingsDeviceRender.Instance.IsDlss3GpuDevice())
			{
				return false;
			}
			if (GameSettingsDeviceRender.Instance.IsNvidiaStreamlinePluginLoaded())
			{
				GameSettingsDeviceRender.Instance.EnableDLSSG(value);
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(820, value.ToString());
				}
			}
			return true;
		}

		// Token: 0x06047B04 RID: 293636 RVA: 0x01259D10 File Offset: 0x01257F10
		public static bool ApplyPcVsync(int value)
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			gameUserSettings.SetVSyncEnabled(value == 1);
			gameUserSettings.ApplySettings(true);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(834, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B05 RID: 293637 RVA: 0x01259D40 File Offset: 0x01257F40
		public static bool ApplyNvidiaSuperSamplingQuality(int value)
		{
			if (!GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				return false;
			}
			int kuroRenderQualityLocalIndex = GameSettingsController.Instance.KuroRenderQualityLocalIndex;
			int? num = GameSettingsUtils.NvidiaSuperSamplingQualityCache;
			int num2 = value;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				num = GameSettingsUtils.KuroLocalRenderSettingIndexCache;
				num2 = kuroRenderQualityLocalIndex;
				if (num.GetValueOrDefault() == num2 & num != null)
				{
					return false;
				}
			}
			GameSettingsUtils.KuroLocalRenderSettingIndexCache = new int?(kuroRenderQualityLocalIndex);
			GameSettingsUtils.NvidiaSuperSamplingQualityCache = new int?(value);
			if (GameSettingsDeviceRender.Instance.IsNvidiaDlssPluginLoaded())
			{
				if (value == 99)
				{
					if (kuroRenderQualityLocalIndex >= 30 && kuroRenderQualityLocalIndex <= 39)
					{
						FIntPoint screenResolution = UGameUserSettings.GetGameUserSettings().GetScreenResolution();
						int x = screenResolution.X;
						int y = screenResolution.Y;
						if (x > 3000 || y > 3000)
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality.Auto 0", null);
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality -2", null);
							Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.ZYT, "KuroLocalRenderSettingIndex Change DLSS.Quality -2", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						else
						{
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality.Auto 0", null);
							UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality -1", null);
							Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.ZYT, "KuroLocalRenderSettingIndex Change DLSS.Quality -1", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
					}
					else
					{
						UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality.Auto 1", null);
					}
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Quality.Auto 0", null);
					UObject world = GlobalData.World;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
					defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Quality ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				}
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(812, value.ToString());
				}
			}
			return true;
		}

		// Token: 0x06047B06 RID: 293638 RVA: 0x01259EF8 File Offset: 0x012580F8
		public static bool ApplyNvidiaSuperSamplingSharpness(float value)
		{
			if (!GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				return false;
			}
			if (GameSettingsDeviceRender.Instance.IsNvidiaDlssPluginLoaded())
			{
				UDLSSLibrary.SetDLSSSharpness(value);
			}
			return true;
		}

		// Token: 0x06047B07 RID: 293639 RVA: 0x01259F1B File Offset: 0x0125811B
		public static bool ApplyNvidiaReflex(int value)
		{
			return true;
		}

		// Token: 0x06047B08 RID: 293640 RVA: 0x01259F20 File Offset: 0x01258120
		public static bool ApplyHdrEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.HDR.EnableHDROutput ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B09 RID: 293641 RVA: 0x01259F60 File Offset: 0x01258160
		public static bool ApplyFsrEnable(int value)
		{
			if (GameSettingsDeviceRender.Instance.IsDlssGpuDevice())
			{
				return false;
			}
			if (GameSettingsDeviceRender.Instance.IsMetalFxDevice())
			{
				return false;
			}
			if (Info.Instance.IsXSXPlatform())
			{
				return false;
			}
			if (Info.Instance.IsGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAASamples 4", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.PrimaryUpscale 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 77", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MipMapLODBias -0.3765", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAACurrentFrameWeight 0.09", null);
				return true;
			}
			if (!Info.Instance.IsPcPlatform())
			{
				if (value == 1)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.RCAS.Enabled 1", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.ClampTolerant 0", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.SharpenLimitDepth 10", null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.RCAS.Enabled 0", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.ClampTolerant 2", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.SharpenLimitDepth -1", null);
				}
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAASamples 4", null);
				if (value == 1)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.PrimaryUpscale 1", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 77", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MipMapLODBias -0.3765", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAACurrentFrameWeight 0.09", null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FidelityFX.FSR.PrimaryUpscale 0", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ScreenPercentage 100", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MipMapLODBias 0.0", null);
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAACurrentFrameWeight 0.25", null);
				}
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(813, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B0A RID: 293642 RVA: 0x0125A130 File Offset: 0x01258330
		public static bool ApplyXessEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.XeSS.Enabled ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B0B RID: 293643 RVA: 0x0125A170 File Offset: 0x01258370
		public static bool ApplyXessQuality(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.XeSS.Quality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B0C RID: 293644 RVA: 0x0125A1B0 File Offset: 0x012583B0
		public static bool ApplyXess2Enable(int value)
		{
			bool flag = value != 0;
			if (flag != GameSettingsUtils.XessEnabled)
			{
				GameSettingsUtils.XessEnabled = flag;
				GameSettingsDeviceRender.Instance.EnableXeSS(GameSettingsUtils.XessEnabled);
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(830, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B0D RID: 293645 RVA: 0x0125A1F8 File Offset: 0x012583F8
		public static bool ApplyXess2Fg(int value)
		{
			GameSettingsDeviceRender.Instance.EnableXefg(value);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(827, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B0E RID: 293646 RVA: 0x0125A220 File Offset: 0x01258420
		public static bool ApplyXess2Quality(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.XeSS.Quality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value + 2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(831, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B0F RID: 293647 RVA: 0x0125A278 File Offset: 0x01258478
		public static bool ApplyFsr3Enable(int value)
		{
			if (!UKuroFFXFSR3BlueprintLibrary.IsGlobalSwitchOn())
			{
				return false;
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.FidelityFX.FSR3.Enabled ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.TemporalAA.Upsampling ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(832, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B10 RID: 293648 RVA: 0x0125A308 File Offset: 0x01258508
		public static bool ApplyFsr3Fg(int value, EFFXFIApplyMode mode)
		{
			if (!UKuroFFXFSR3BlueprintLibrary.IsGlobalSwitchOn())
			{
				return false;
			}
			if (!GameSettingsDeviceRender.Instance.IsFFXFISupported())
			{
				return false;
			}
			GameSettingsUtils.Fsr3FgApplyMode = mode;
			GameSettingsUtils.Fsr3FgSwitchStates[(int)mode] = value;
			GameSettingsUtils.Fsr3FgEnable = (value != 0);
			if (GameSettingsUtils.IsInTemporaryFFXFIApplyState() && !GameSettingsUtils.IsTemporaryFFXFIApplyMode(mode))
			{
				return true;
			}
			GameSettingsDeviceRender.Instance.ApplyUnlimitedFrameRate(GameSettingsUtils.Fsr3FgEnable);
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.FidelityFX.FI.Enabled ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(826, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B11 RID: 293649 RVA: 0x0125A3B0 File Offset: 0x012585B0
		public static bool IsFsr3FgEnable()
		{
			return GameSettingsUtils.Fsr3FgEnable;
		}

		// Token: 0x06047B12 RID: 293650 RVA: 0x0125A3B7 File Offset: 0x012585B7
		public static EFFXFIApplyMode GetFsr3FgApplyMode()
		{
			return GameSettingsUtils.Fsr3FgApplyMode;
		}

		// Token: 0x06047B13 RID: 293651 RVA: 0x0125A3C0 File Offset: 0x012585C0
		public static int GetFsr3FgSwitchState(EFFXFIApplyMode mode)
		{
			int result;
			if (!GameSettingsUtils.Fsr3FgSwitchStates.TryGetValue((int)mode, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06047B14 RID: 293652 RVA: 0x0125A3DF File Offset: 0x012585DF
		public static bool IsTemporaryFFXFIApplyMode(EFFXFIApplyMode mode)
		{
			return mode > EFFXFIApplyMode.Default;
		}

		// Token: 0x06047B15 RID: 293653 RVA: 0x0125A3E5 File Offset: 0x012585E5
		public static bool IsInTemporaryFFXFIApplyState()
		{
			return GameSettingsUtils.Fsr3FgInTemporaryApplyState;
		}

		// Token: 0x06047B16 RID: 293654 RVA: 0x0125A3EC File Offset: 0x012585EC
		public static void EnterTemporaryFFXFIApplyState()
		{
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = true;
		}

		// Token: 0x06047B17 RID: 293655 RVA: 0x0125A3F4 File Offset: 0x012585F4
		public static void LeaveTemporaryFFXFIApplyState()
		{
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = false;
		}

		// Token: 0x06047B18 RID: 293656 RVA: 0x0125A3FC File Offset: 0x012585FC
		public static bool ApplyFsr3Quality(int value)
		{
			if (!UKuroFFXFSR3BlueprintLibrary.IsGlobalSwitchOn())
			{
				return false;
			}
			int value2 = 2 - value;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.FidelityFX.FSR3.QualityMode ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(833, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B19 RID: 293657 RVA: 0x0125A460 File Offset: 0x01258660
		public static bool ApplyMetalFxEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.MetalFxUpscale ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.TemporalAA.SharpenLimitDepth ");
			defaultInterpolatedStringHandler.AppendFormatted<int>((value == 1) ? 20 : -1);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(818, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B1A RID: 293658 RVA: 0x0125A4F0 File Offset: 0x012586F0
		public static bool ApplyBloomEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.KuroBloomEnable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(811, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B1B RID: 293659 RVA: 0x0125A546 File Offset: 0x01258746
		public static bool ApplyIrxEnable(int value)
		{
			if (value == 1)
			{
				GameSettingsDeviceRender.Instance.TurnOnIRX();
			}
			else
			{
				GameSettingsDeviceRender.Instance.TurnOffIRX();
			}
			return true;
		}

		// Token: 0x06047B1C RID: 293660 RVA: 0x0125A564 File Offset: 0x01258764
		public static bool ApplySceneLightQuality(int value)
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				int[] array = new int[]
				{
					4,
					4,
					4,
					4,
					5,
					5
				};
				int num = MathUtils.Instance.Clamp(value, 0, array.Length - 1);
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.GlobalLightQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(array[num]);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				return true;
			}
			if (GameSettingsDeviceRender.Instance.IsIosAndAndroidHighDevice())
			{
				int[] array2 = new int[]
				{
					1,
					2,
					3,
					4,
					4
				};
				UObject world2 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.GlobalLightQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(array2[value]);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			else
			{
				int[] array3 = new int[]
				{
					1,
					2,
					3,
					3,
					3
				};
				UObject world3 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.GlobalLightQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(array3[value]);
				UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			return true;
		}

		// Token: 0x06047B1D RID: 293661 RVA: 0x0125A670 File Offset: 0x01258870
		public static bool ApplyVolumeFog(int value)
		{
			if (!GameSettingsDeviceRender.Instance.IsEnableVolumeFog())
			{
				return false;
			}
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				int value2 = (value > 0) ? 1 : 0;
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.volumetricfog ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.VRS.VolumeCloudQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				if (PerfSightController.IsEnable)
				{
					UPerfSightHelper.PostEvent(809, value.ToString());
				}
			}
			return true;
		}

		// Token: 0x06047B1E RID: 293662 RVA: 0x0125A718 File Offset: 0x01258918
		public static bool ApplyVolumeLight(int value)
		{
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.lightShaftQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			if (Info.Instance.IsMobilePlatform())
			{
				bool flag = GameSettingsDeviceRender.Instance.IsIosAndAndroidHighDevice();
				UObject world2 = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.MobileLightShaft ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(flag ? value : 0);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(835, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B1F RID: 293663 RVA: 0x0125A7C8 File Offset: 0x012589C8
		public static bool ApplyMotionBlur(float value)
		{
			CameraModel instance = CameraModel.Instance;
			double num = (instance != null) ? instance.MainModel.MotionBlurModifier : 0.2;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.MotionBlur.Amount ");
			defaultInterpolatedStringHandler.AppendFormatted<double>((double)value * num);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(836, ((int)value).ToString());
			}
			return true;
		}

		// Token: 0x06047B20 RID: 293664 RVA: 0x0125A844 File Offset: 0x01258A44
		public unsafe static bool ApplyMobileResolution(int value)
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				return false;
			}
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				if (value == 0)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.SharpenLimitDepth 50", null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.SharpenLimitDepth -1", null);
				}
				if (GameSettingsDeviceRender.Instance.IsAndroidPlatformScreenBetter())
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.Sharpness 0.5", null);
				}
				if (GameSettingsDeviceRender.Instance.IsAndroidPlatformScreenBad())
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.TemporalAA.Sharpness 0.1", null);
				}
			}
			if (GameSettingsDeviceRender.Instance.InCacheSceneColorMode == 1)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.CacheSceneColor.Start", null);
			}
			int num = GameSettingsDeviceRender.Instance.GetMobileResolutionByIndex(value);
			float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.MobileContentScaleFactor");
			float consoleVariableFloatValue2 = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.SecondaryScreenPercentage.GameViewport");
			float num2 = 1f;
			FVector2D physicalScreenResolutionV = UKuroScreenBlueprintFunctionLibrary.GetPhysicalScreenResolutionV2();
			float x = physicalScreenResolutionV.X;
			float y = physicalScreenResolutionV.Y;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (GameSettingsDeviceRender.Instance.IsAndroidHighResolutionDevice() && y > 0f)
			{
				if (y > x && y < 1280f * consoleVariableFloatValue)
				{
					num2 = 1280f * consoleVariableFloatValue / y;
				}
				else if (y < x && y < 720f * consoleVariableFloatValue)
				{
					num2 = 720f * consoleVariableFloatValue / y;
				}
				float num3 = Math.Min(consoleVariableFloatValue2 * num2, 100f);
				UObject world = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.SecondaryScreenPercentage.GameViewport ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(num3);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.ZJF;
				string message = "分辨率校正";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("deviceScaleCorrect", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("secondaryScreenPercentage", consoleVariableFloatValue2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("newSecondaryScreenPercentage", num3);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			if (GameSettingsDeviceRender.Instance.GetDefaultScreenResolution().Y < 750 && consoleVariableFloatValue2 < 70f)
			{
				num = (int)Math.Min((float)num * 1.5f, 100f);
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(803, value.ToString());
			}
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.ScreenPercentage ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B21 RID: 293665 RVA: 0x0125AAAD File Offset: 0x01258CAD
		public static bool ApplySuperResolution(int value)
		{
			return false;
		}

		// Token: 0x06047B22 RID: 293666 RVA: 0x0125AAB0 File Offset: 0x01258CB0
		public static bool ApplyHarmonySuperResolution(int value)
		{
			if (value > 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.HmsXegSpatialUpscale.Enabled 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.HmsXegSpatialUpscale.Method 1", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.HmsXegSpatialUpscale.Enabled 0", null);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.LQX;
			string message = "鸿蒙智能超级分辨率";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x06047B23 RID: 293667 RVA: 0x0125AB24 File Offset: 0x01258D24
		public static bool ApplyHarmonyRayTracingBoost(int value)
		{
			if (value <= 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ohosrt.enabled 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.RTReflection 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.CharacterPlanarReflection 0", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ohosrt.enabled 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.RTReflection 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Mobile.CharacterPlanarReflection 1", null);
				float value2 = (value >= 2) ? 1f : 0.75f;
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Mobile.GenRayBufferPass.ResolutionScale ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.LQX;
			string message = "鸿蒙光线追踪";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x06047B24 RID: 293668 RVA: 0x0125AC08 File Offset: 0x01258E08
		public static void ApplyHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBaseYawSensitivity((double)value);
		}

		// Token: 0x06047B25 RID: 293669 RVA: 0x0125AC1B File Offset: 0x01258E1B
		public static void ApplyVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBasePitchSensitivity((double)value);
		}

		// Token: 0x06047B26 RID: 293670 RVA: 0x0125AC2E File Offset: 0x01258E2E
		public static void ApplyAimHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingYawSensitivity((double)value);
		}

		// Token: 0x06047B27 RID: 293671 RVA: 0x0125AC41 File Offset: 0x01258E41
		public static void ApplyAimVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingPitchSensitivity((double)value);
		}

		// Token: 0x06047B28 RID: 293672 RVA: 0x0125AC54 File Offset: 0x01258E54
		public static void ApplyCameraShakeStrength(float value)
		{
			float num = 0f;
			if (Info.Instance.IsMobilePlatform())
			{
				num = value;
			}
			else
			{
				switch ((int)value)
				{
				case 0:
					num = MenuModel.Instance.LowShake;
					break;
				case 1:
					num = MenuModel.Instance.MiddleShake;
					break;
				case 2:
					num = MenuModel.Instance.HighShake;
					break;
				}
			}
			CameraModel.Instance.MainModel.SetCameraShakeModify((double)num);
		}

		// Token: 0x06047B29 RID: 293673 RVA: 0x0125ACC4 File Offset: 0x01258EC4
		public static bool ApplyTextLanguage(int value)
		{
			string languageCodeById = GameSettingsManager.Instance.GetLanguageCodeById(value);
			if (string.IsNullOrEmpty(languageCodeById))
			{
				return false;
			}
			string packageLanguage = LanguageSystem.Instance.PackageLanguage;
			LanguageSystem.Instance.PackageLanguage = languageCodeById;
			KuroSdkController.Instance.PostKuroSdkEvent(EKuroSdkEventKey.KuroNotiLanguage);
			EventSystem.Instance.Emit<string, string>(EEventName.TextLanguageChange, packageLanguage, languageCodeById);
			EventSystemBridge.EmitToJavaScript<int>(2577U, 0, value);
			return true;
		}

		// Token: 0x06047B2A RID: 293674 RVA: 0x0125AD28 File Offset: 0x01258F28
		public static bool ApplyTextLanguageOnGameStart(int value)
		{
			string languageCodeById = GameSettingsManager.Instance.GetLanguageCodeById(value);
			if (languageCodeById == null)
			{
				return false;
			}
			LanguageSystem.Instance.PackageLanguage = languageCodeById;
			return true;
		}

		// Token: 0x06047B2B RID: 293675 RVA: 0x0125AD54 File Offset: 0x01258F54
		public static bool ApplyLanguageAudio(int value)
		{
			string audioCodeById = GameSettingsManager.Instance.GetAudioCodeById(value);
			if (string.IsNullOrEmpty(audioCodeById))
			{
				return false;
			}
			LanguageSystem.Instance.SetPackageAudio(audioCodeById, GlobalData.World);
			if (LocalStorage.HasPlayerId() && RoleLangCustomModel.Instance != null)
			{
				if (!RoleLangCustomModel.Instance.CanSetCustom)
				{
					RoleLangCustomModel.Instance.CanSetCustom = true;
					RoleLangCustomModel.Instance.CheckAndApplyPlayerVoiceAll();
				}
				else
				{
					RoleLangCustomModel.Instance.ApplyPlayerVoiceAll();
				}
			}
			return true;
		}

		// Token: 0x06047B2C RID: 293676 RVA: 0x0125ADC3 File Offset: 0x01258FC3
		public static void ApplyMobileHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBaseYawSensitivity((double)value);
		}

		// Token: 0x06047B2D RID: 293677 RVA: 0x0125ADD6 File Offset: 0x01258FD6
		public static void ApplyMobileVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBasePitchSensitivity((double)value);
		}

		// Token: 0x06047B2E RID: 293678 RVA: 0x0125ADE9 File Offset: 0x01258FE9
		public static void ApplyMobileAimHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingYawSensitivity((double)value);
		}

		// Token: 0x06047B2F RID: 293679 RVA: 0x0125ADFC File Offset: 0x01258FFC
		public static void ApplyMobileAimVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingPitchSensitivity((double)value);
		}

		// Token: 0x06047B30 RID: 293680 RVA: 0x0125AE0F File Offset: 0x0125900F
		public static void ApplyCommonSpringArmLength(float value)
		{
			CameraModel.Instance.MainModel.CameraSettingNormalAdditionArmLength = (double)value;
		}

		// Token: 0x06047B31 RID: 293681 RVA: 0x0125AE22 File Offset: 0x01259022
		public static void ApplyFightSpringArmLength(float value)
		{
			CameraModel.Instance.MainModel.CameraSettingFightAdditionArmLength = (double)value;
		}

		// Token: 0x06047B32 RID: 293682 RVA: 0x0125AE35 File Offset: 0x01259035
		public static void ApplyResetFocusEnable(int value)
		{
			CameraModel.Instance.MainModel.IsEnableResetFocus = (value == 1);
		}

		// Token: 0x06047B33 RID: 293683 RVA: 0x0125AE4A File Offset: 0x0125904A
		public static void ApplyIsSidestepCameraEnable(int value)
		{
			CameraModel.Instance.MainModel.IsEnableSidestepCamera = (value == 1);
		}

		// Token: 0x06047B34 RID: 293684 RVA: 0x0125AE5F File Offset: 0x0125905F
		public static void ApplyIsSoftLockCameraEnable(int value)
		{
			CameraModel.Instance.MainModel.SetSettingSoftLockState(value == 1);
		}

		// Token: 0x06047B35 RID: 293685 RVA: 0x0125AE74 File Offset: 0x01259074
		public static bool ApplyJoystickShakeStrength(int value)
		{
			GameSettingsUtils.ApplyJoystickShakeInternal((EGlobalKuroForceFeedbackType)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.JoystickShakeType, 0, true), value);
			return true;
		}

		// Token: 0x06047B36 RID: 293686 RVA: 0x0125AE8C File Offset: 0x0125908C
		public static bool ApplyJoystickShakeType(int value)
		{
			int currentValueSafely = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.JoystickShakeStrength, 0, true);
			GameSettingsUtils.ApplyJoystickShakeInternal((EGlobalKuroForceFeedbackType)value, currentValueSafely);
			return true;
		}

		// Token: 0x06047B37 RID: 293687 RVA: 0x0125AEB1 File Offset: 0x012590B1
		private static void ApplyJoystickShakeInternal(EGlobalKuroForceFeedbackType joystickShakeType, int joystickShakeStrength)
		{
			ABasePlayerController.SetKuroForceFeedbackConfig(joystickShakeType, joystickShakeStrength);
		}

		// Token: 0x06047B38 RID: 293688 RVA: 0x0125AEBA File Offset: 0x012590BA
		public static void ApplyWalkOrRunRate(float value)
		{
			RoleGaitStatic.SetWalkOrRunRateForRocker(value);
		}

		// Token: 0x06047B39 RID: 293689 RVA: 0x0125AEC2 File Offset: 0x012590C2
		public static void ApplyJoystickMode(int value)
		{
			BattleUiModel.Instance.SetIsDynamicJoystick(value == 1);
		}

		// Token: 0x06047B3A RID: 293690 RVA: 0x0125AED2 File Offset: 0x012590D2
		public static void ApplyAutoSwitchSkillButtonMode(int value)
		{
			BattleUiModel.Instance.SetIsAutoSwitchSkillButtonMode(value == 0);
		}

		// Token: 0x06047B3B RID: 293691 RVA: 0x0125AEE2 File Offset: 0x012590E2
		public static void ApplyAimAssistEnable(int value)
		{
			CameraModel instance = CameraModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.MainModel.SetAimAssistEnable(value == 1);
		}

		// Token: 0x06047B3C RID: 293692 RVA: 0x0125AEFC File Offset: 0x012590FC
		public static void ApplyKeyboardLockEnemyMode(int value)
		{
			FormationDataController.Instance.SetKeyboardLockEnemyMode((ELockEnemyMode)value);
		}

		// Token: 0x06047B3D RID: 293693 RVA: 0x0125AF0C File Offset: 0x0125910C
		public static void ApplyHorizontalViewRevert(int value)
		{
			IReadOnlyList<AxisRevert> axisRevertConfigListByRevertType = MenuBaseConfig.Instance.GetAxisRevertConfigListByRevertType(0);
			if (axisRevertConfigListByRevertType == null)
			{
				return;
			}
			GameSettingsUtils.ApplyAxisRevert(value == 1, axisRevertConfigListByRevertType);
		}

		// Token: 0x06047B3E RID: 293694 RVA: 0x0125AF34 File Offset: 0x01259134
		public static void ApplyVerticalViewRevert(int value)
		{
			IReadOnlyList<AxisRevert> axisRevertConfigListByRevertType = MenuBaseConfig.Instance.GetAxisRevertConfigListByRevertType(1);
			if (axisRevertConfigListByRevertType == null)
			{
				return;
			}
			GameSettingsUtils.ApplyAxisRevert(value == 1, axisRevertConfigListByRevertType);
		}

		// Token: 0x06047B3F RID: 293695 RVA: 0x0125AF5C File Offset: 0x0125915C
		public static void RefreshViewRevertState(EInputControllerMainType mainType)
		{
			int value = 0;
			int value2 = 0;
			if (mainType == EInputControllerMainType.Gamepad)
			{
				value = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.HorizontalViewRevert, 0, true);
				value2 = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.VerticalViewRevert, 0, true);
			}
			GameSettingsUtils.ApplyHorizontalViewRevert(value);
			GameSettingsUtils.ApplyVerticalViewRevert(value2);
		}

		// Token: 0x06047B40 RID: 293696 RVA: 0x0125AFA4 File Offset: 0x012591A4
		private static void ApplyAxisRevert(bool bRevert, IReadOnlyList<AxisRevert> axisRevertConfigList)
		{
			foreach (AxisRevert axisRevert in axisRevertConfigList)
			{
				string axisName = axisRevert.AxisName;
				InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
				if (axisBinding != null)
				{
					IEnumerable<DicStringInt> enumerable = axisRevert.RevertInfoIter();
					Dictionary<EInputBindingType, Dictionary<string, InputAxisKey>> allInputAxisKeyMap = axisBinding.GetAllInputAxisKeyMap();
					if (allInputAxisKeyMap != null)
					{
						foreach (KeyValuePair<EInputBindingType, Dictionary<string, InputAxisKey>> keyValuePair in allInputAxisKeyMap)
						{
							EInputBindingType key = keyValuePair.Key;
							Dictionary<string, InputAxisKey> value = keyValuePair.Value;
							Dictionary<string, float> dictionary = new Dictionary<string, float>();
							foreach (DicStringInt dicStringInt in enumerable)
							{
								string key2 = dicStringInt.Key;
								int value2 = dicStringInt.Value;
								InputAxisKey inputAxisKey;
								if (value.TryGetValue(key2, out inputAxisKey))
								{
									float value3 = 0f;
									float scale = inputAxisKey.Scale;
									if (value2 == 0)
									{
										if (bRevert)
										{
											value3 = ((scale > 0f) ? (-scale) : scale);
										}
										else
										{
											value3 = ((scale > 0f) ? scale : (-scale));
										}
									}
									if (value2 == 1)
									{
										if (bRevert)
										{
											value3 = ((scale > 0f) ? scale : (-scale));
										}
										else
										{
											value3 = ((scale > 0f) ? (-scale) : scale);
										}
									}
									dictionary[key2] = value3;
								}
							}
							if (dictionary.Count > 0)
							{
								axisBinding.SetKeys(dictionary, key);
							}
						}
					}
				}
			}
		}

		// Token: 0x06047B41 RID: 293697 RVA: 0x0125B180 File Offset: 0x01259380
		public static void ApplyGamepadLockEnemyMode(int value)
		{
			FormationDataController.Instance.SetGamepadLockEnemyMode((ELockEnemyMode)value);
		}

		// Token: 0x06047B42 RID: 293698 RVA: 0x0125B18D File Offset: 0x0125938D
		public static void ApplyEnemyHitDisplayMode(int value)
		{
			BulletModel.Instance.OpenHitMaterial = (value == 1);
		}

		// Token: 0x06047B43 RID: 293699 RVA: 0x0125B1A0 File Offset: 0x012593A0
		public static void ApplyPushEnableState(int value, EGameSettingsApplyReason? reason = null)
		{
			if (value == 0)
			{
				KuroPushController.Instance.TurnOffPush();
				return;
			}
			bool checkPermissionState = reason.GetValueOrDefault() == EGameSettingsApplyReason.WhenUi;
			KuroPushController.Instance.TurnOnPush(checkPermissionState);
		}

		// Token: 0x06047B44 RID: 293700 RVA: 0x0125B1D2 File Offset: 0x012593D2
		public static void ApplyAutoAdjustImageQuality(int value)
		{
			GameSettingsDeviceRender.Instance.SetIsAutoAdjustImageQuality(value == 1);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(824, value.ToString());
			}
		}

		// Token: 0x06047B45 RID: 293701 RVA: 0x0125B1FA File Offset: 0x012593FA
		public static void ApplyShowDamage(int value)
		{
			DamageUiManager.Instance.SetDamageViewVisible(value == 1);
		}

		// Token: 0x06047B46 RID: 293702 RVA: 0x0125B20A File Offset: 0x0125940A
		public static void ApplyDynamicBones(int value)
		{
			CreatureController.Instance.SetKawaiiEnable(value);
		}

		// Token: 0x06047B47 RID: 293703 RVA: 0x0125B218 File Offset: 0x01259418
		public static void ApplyDolbyAtmos(int value)
		{
			AudioSystem.Instance.SetRtpcValue("dolby_atmos", (float)value, null);
		}

		// Token: 0x06047B48 RID: 293704 RVA: 0x0125B23F File Offset: 0x0125943F
		public static bool ApplyUiPureMode(int value)
		{
			if (value == 1)
			{
				BattleUiControl.Instance.TryOpenPureMode();
				return false;
			}
			return BattleUiControl.Instance.TryClosePureMode();
		}

		// Token: 0x06047B49 RID: 293705 RVA: 0x0125B25C File Offset: 0x0125945C
		public unsafe static bool ApplyRayTracing(int value)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (value > 0)
			{
				UObject world = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("sg.RayTracingQuality ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			string path = UBlueprintPathsLibrary.ProjectSavedDir() + "SaveGames/RTX.json";
			if (UKuroStaticLibrary.FileExists(path))
			{
				UKuroStaticLibrary.DeleteFile(path, false, false, false);
			}
			UKuroRenderingRuntimeBPPluginBPLibrary.SetRayTracingEnable(value > 0);
			bool flag = !GameSettingsDeviceRender.Instance.IsNvidiaGPU() || GameSettingsDeviceRender.Instance.IsDlss3GpuDevice();
			bool flag2 = value > 0 && flag;
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.MegaLights.Allowed ");
			defaultInterpolatedStringHandler.AppendFormatted<int>((flag2 > false) ? 1 : 0);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.WX;
			string message = "MegaLights 开关";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rayTracing", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("allowMegaLights", flag2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(821, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B4A RID: 293706 RVA: 0x0125B398 File Offset: 0x01259598
		public static bool ApplyRayTracedReflection(int value)
		{
			if (value > 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Lumen.Reflections.Allow 1", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追反射开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Lumen.Reflections.Allow 0", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追反射关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(822, value.ToString());
			}
			EventSystem.Instance.Emit<bool>(EEventName.UpdateRayTraceReflection, value > 0);
			return true;
		}

		// Token: 0x06047B4B RID: 293707 RVA: 0x0125B438 File Offset: 0x01259638
		public static bool ApplyRayTracedGI(int value)
		{
			if (value > 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Lumen.DiffuseIndirect.Allow 1", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追全局光照开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Lumen.DiffuseIndirect.Allow 0", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追全局光照关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(823, value.ToString());
			}
			return true;
		}

		// Token: 0x06047B4C RID: 293708 RVA: 0x0125B4C4 File Offset: 0x012596C4
		public static bool ApplyRayTracedShadow(int value)
		{
			if (value > 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.RayTracing.Shadows 1", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追阴影开启", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.RayTracing.Shadows 0", null);
				Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.WX, "光追阴影关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}

		// Token: 0x06047B4D RID: 293709 RVA: 0x0125B538 File Offset: 0x01259738
		public static bool ApplySaturationClient(int value)
		{
			float value2 = 1f;
			if (value <= 50)
			{
				value2 = MathUtils.Instance.Lerp(0f, 1f, (float)(value * 2) / 100f);
			}
			if (value > 50)
			{
				value2 = MathUtils.Instance.Lerp(1f, 2f, (float)((value - 50) * 2) / 100f);
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Client.Saturation ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B4E RID: 293710 RVA: 0x0125B5C8 File Offset: 0x012597C8
		public static bool ApplyContrastClient(int value)
		{
			float value2 = 1f;
			if (value <= 50)
			{
				value2 = MathUtils.Instance.Lerp(0.5f, 1f, (float)(value * 2) / 100f);
			}
			if (value > 50)
			{
				value2 = MathUtils.Instance.Lerp(1f, 2f, (float)((value - 50) * 2) / 100f);
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Client.Contrast ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B4F RID: 293711 RVA: 0x0125B657 File Offset: 0x01259857
		public static void ApplySkinDamageMode(int value)
		{
			CharacterSkinDamageComponent.EnableSkinDamage = (value == 1);
			EventSystem.Instance.Emit(EEventName.OnResetSkinDamageMode);
		}

		// Token: 0x06047B50 RID: 293712 RVA: 0x0125B674 File Offset: 0x01259874
		public static void ApplyAFMEOption(int value)
		{
			GameSettingsDeviceRender.Instance.EnableAFME(value);
			if (PerfSightController.IsEnable)
			{
				if (UKismetSystemLibrary.GetConsoleVariableIntValue("r.KuroFI.Enable") == 1)
				{
					UPerfSightHelper.PostEvent(829, (value != 0) ? "1" : "0");
					return;
				}
				UPerfSightHelper.PostEvent(828, (value != 0) ? "1" : "0");
			}
		}

		// Token: 0x06047B51 RID: 293713 RVA: 0x0125B6D5 File Offset: 0x012598D5
		public static bool ApplyAutoRun(int value)
		{
			if (BattleUiModel.Instance == null)
			{
				return false;
			}
			if (BattleUiModel.Instance.FormationData == null)
			{
				return false;
			}
			BattleUiModel.Instance.FormationData.AutoMovingSettingEnable = (value > 0);
			return true;
		}

		// Token: 0x06047B52 RID: 293714 RVA: 0x0125B702 File Offset: 0x01259902
		public static bool ApplyAutoSprint(int value)
		{
			if (BattleUiModel.Instance == null)
			{
				return false;
			}
			if (BattleUiModel.Instance.FormationData == null)
			{
				return false;
			}
			BattleUiModel.Instance.FormationData.AutoSprintSettingEnable = (value > 0);
			return true;
		}

		// Token: 0x06047B53 RID: 293715 RVA: 0x0125B72F File Offset: 0x0125992F
		public static bool ApplyVulkan(int value)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetVulkanPromotion(value > 0);
			return true;
		}

		// Token: 0x06047B54 RID: 293716 RVA: 0x0125B73C File Offset: 0x0125993C
		public static bool ApplyWaterInteract(int value)
		{
			if (value == 0)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MarchingCubes.EnablePrePass 0", null);
			}
			else
			{
				HashSet<string> hashSet = new HashSet<string>();
				hashSet.Add("Windows_AMD_Graphics");
				hashSet.Add("Windows_IntelARCB570");
				hashSet.Add("Windows_IntelARCA770");
				hashSet.Add("Windows_IntelARCMiddle");
				hashSet.Add("Windows_Intel");
				string deviceProfileProfileName = UKuroRenderingRuntimeBPPluginBPLibrary.GetDeviceProfileProfileName();
				if (!hashSet.Contains(deviceProfileProfileName))
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MarchingCubes.EnablePrePass 1", null);
				}
			}
			SceneBattleInteractModel.Instance.Open = (value > 0);
			EventSystem.Instance.Emit<int>(EEventName.SetEnvironmentInteraction, value);
			return true;
		}

		// Token: 0x06047B55 RID: 293717 RVA: 0x0125B7E0 File Offset: 0x012599E0
		public static bool ApplyVegetationDither(int value)
		{
			FName parameterName = new FName("FoliageDitherState");
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), parameterName, (value > 0) ? 1f : 0f);
			return true;
		}

		// Token: 0x06047B56 RID: 293718 RVA: 0x0125B820 File Offset: 0x01259A20
		public static bool ApplyVegetationDensity(int value)
		{
			switch (value)
			{
			case 0:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "foliage.DensityScale 0.6", null);
				break;
			case 1:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "foliage.DensityScale 0.7", null);
				break;
			case 2:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "foliage.DensityScale 0.8", null);
				break;
			case 3:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "foliage.DensityScale 1", null);
				break;
			}
			return true;
		}

		// Token: 0x06047B57 RID: 293719 RVA: 0x0125B88C File Offset: 0x01259A8C
		public static bool ApplyImageDisplayMode(int value)
		{
			switch (value)
			{
			case 0:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
				break;
			case 1:
				if (FilterSettingController.Instance.IsFilterSettingChange())
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 1", null);
				}
				else
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
				}
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
				break;
			case 2:
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 0", null);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 0", null);
				break;
			}
			return true;
		}

		// Token: 0x06047B58 RID: 293720 RVA: 0x0125B968 File Offset: 0x01259B68
		public static bool ApplyEyeProtectionMode(int value)
		{
			UKuroGISystem.ApplyEyeProtectionEnvironment(GlobalData.World, (float)value);
			if (value == 2)
			{
				float currentValueSafelyFloat = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionTemp, 0f, true);
				float currentValueSafelyFloat2 = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionStrength, 0f, true);
				float currentValueSafelyFloat3 = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionBrightness, 0f, true);
				float currentValueSafelyFloat4 = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.EyeProtectionTexture, 0f, true);
				GameSettingsUtils.ApplyEyeProtectionTemp(currentValueSafelyFloat, value);
				GameSettingsUtils.ApplyEyeProtectionStrength(currentValueSafelyFloat2, value);
				GameSettingsUtils.ApplyEyeProtectionBrightness(currentValueSafelyFloat3, value);
				GameSettingsUtils.ApplyEyeProtectionTexture(currentValueSafelyFloat4, value);
			}
			return true;
		}

		// Token: 0x06047B59 RID: 293721 RVA: 0x0125B9FC File Offset: 0x01259BFC
		public static bool ApplyEyeProtectionTemp(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionTemperature(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x06047B5A RID: 293722 RVA: 0x0125BA0C File Offset: 0x01259C0C
		public static bool ApplyEyeProtectionStrength(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionStrength(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x06047B5B RID: 293723 RVA: 0x0125BA1C File Offset: 0x01259C1C
		public static bool ApplyEyeProtectionBrightness(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionBrightness(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x06047B5C RID: 293724 RVA: 0x0125BA2C File Offset: 0x01259C2C
		public static bool ApplyEyeProtectionTexture(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionTexture(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x06047B5D RID: 293725 RVA: 0x0125BA3C File Offset: 0x01259C3C
		public static bool ApplyAutoExposure(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.AutoExposurePlayerCustom ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x06047B5E RID: 293726 RVA: 0x0125BA7A File Offset: 0x01259C7A
		public static void ApplyAdjustiveGamePadTrigger(int value)
		{
			UTriggerEffectBPLibrary.SetTriggerEffectState(Global.CharacterController, value == 1);
		}

		// Token: 0x06047B5F RID: 293727 RVA: 0x0125BA8A File Offset: 0x01259C8A
		public static float MapGamepadDeadZoneUiToEngine(int uiValue)
		{
			if (Info.Instance.IsIosPlatform())
			{
				return (float)(uiValue - 10) * 0.01f;
			}
			return (float)uiValue / 100f * 0.9f;
		}

		// Token: 0x06047B60 RID: 293728 RVA: 0x0125BAB2 File Offset: 0x01259CB2
		public static void ApplyGamepadLeftStickDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_LeftX,
				EKey.Gamepad_LeftY
			});
		}

		// Token: 0x06047B61 RID: 293729 RVA: 0x0125BAD8 File Offset: 0x01259CD8
		public static void ApplyGamepadRightStickDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_RightX,
				EKey.Gamepad_RightY
			});
		}

		// Token: 0x06047B62 RID: 293730 RVA: 0x0125BAFE File Offset: 0x01259CFE
		public static void ApplyGamepadLeftTriggerDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_LeftTriggerAxis
			});
		}

		// Token: 0x06047B63 RID: 293731 RVA: 0x0125BB18 File Offset: 0x01259D18
		public static void ApplyGamepadRightTriggerDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_RightTriggerAxis
			});
		}

		// Token: 0x06047B64 RID: 293732 RVA: 0x0125BB34 File Offset: 0x01259D34
		private static void ApplyGamepadDeadZoneToKeys(int uiValue, EKey[] keys)
		{
			float deadZone = GameSettingsUtils.MapGamepadDeadZoneUiToEngine(uiValue);
			int playerIndex = 0;
			foreach (EKey key in keys)
			{
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey(new FName(key)), deadZone);
			}
		}

		// Token: 0x06047B65 RID: 293733 RVA: 0x0125BB80 File Offset: 0x01259D80
		public static void ApplyMotorAutoLongPressSpeedUp(int value)
		{
			BattleUiModel.Instance.MotorcycleData.AutoNitrogenSettingEnable = (value == 1);
		}

		// Token: 0x06047B66 RID: 293734 RVA: 0x0125BB95 File Offset: 0x01259D95
		public static void ApplyMotorAutoAcceleratorSettingEnable(int value)
		{
			BattleUiModel.Instance.MotorcycleData.AutoAcceleratorSettingEnable = (value == 1);
		}

		// Token: 0x06047B67 RID: 293735 RVA: 0x0125BBAA File Offset: 0x01259DAA
		public static void ApplyMotorDriftAcceleratorSettingEnable(int value)
		{
			BattleUiModel.Instance.MotorcycleData.DriftAcceleratorSettingEnable = (value == 1);
		}

		// Token: 0x06047B68 RID: 293736 RVA: 0x0125BBBF File Offset: 0x01259DBF
		public static void ApplyMotorHudVisible(int value)
		{
			BattleUiModel.Instance.MotorcycleData.SetHudVisible(value == 0, "设置系统设置");
		}

		// Token: 0x06047B69 RID: 293737 RVA: 0x0125BBD9 File Offset: 0x01259DD9
		public static void ApplyMotorIsDynamicJoystick(int value)
		{
			BattleUiModel.Instance.MotorcycleData.SetIsDynamicJoystick(value == 1);
		}

		// Token: 0x06047B6A RID: 293738 RVA: 0x0125BBF0 File Offset: 0x01259DF0
		public static void ApplyUiBrightness(float value)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.PeakBrightness);
			UKuroGISystem.ApplyHDRMetaData(GlobalData.World, value, (float)dataCacheOrCurValue.GetValueOrDefault());
		}

		// Token: 0x06047B6B RID: 293739 RVA: 0x0125BC20 File Offset: 0x01259E20
		public static void ApplyPeakBrightness(float value)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.UiBrightness);
			UKuroGISystem.ApplyHDRMetaData(GlobalData.World, (float)dataCacheOrCurValue.GetValueOrDefault(), value);
		}

		// Token: 0x06047B6C RID: 293740 RVA: 0x0125BC50 File Offset: 0x01259E50
		public static void ApplyAnisoLevel(int value)
		{
			switch (value)
			{
			case 0:
				UKuroRenderingRuntimeBPPluginBPLibrary.SetAnisoLevel(1);
				break;
			case 1:
				UKuroRenderingRuntimeBPPluginBPLibrary.SetAnisoLevel(2);
				break;
			case 2:
				UKuroRenderingRuntimeBPPluginBPLibrary.SetAnisoLevel(4);
				break;
			case 3:
				UKuroRenderingRuntimeBPPluginBPLibrary.SetAnisoLevel(8);
				break;
			case 4:
				UKuroRenderingRuntimeBPPluginBPLibrary.SetAnisoLevel(16);
				break;
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(837, value.ToString());
			}
		}

		// Token: 0x06047B6D RID: 293741 RVA: 0x0125BCB8 File Offset: 0x01259EB8
		public unsafe static bool ApplyLoadingRangeScaleLevel(int value)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY);
			if (dataCacheOrCurValue == null)
			{
				return false;
			}
			DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature((EGameQualitySettingLevel)dataCacheOrCurValue.Value);
			if (deviceRenderFeature == null)
			{
				return false;
			}
			int loadingRangeScale = deviceRenderFeature.Value.LoadingRangeScale;
			float num = (float)(loadingRangeScale - 100) / 2f;
			float num2 = MathUtils.Instance.Clamp(100f + num * (float)value, 100f, (float)loadingRangeScale) / 100f;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
			defaultInterpolatedStringHandler.AppendLiteral("wp.Runtime.PlannedLoadingRangeScaleExtra ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
			defaultInterpolatedStringHandler.AppendLiteral("wp.Runtime.LoadingRangeScaleExtra ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (GameSettingsUtils.GrassCullDistanceCache != null && GameSettingsUtils.GrassMobileCullDistanceCache != null && GameSettingsUtils.GrassLODDistanceScaleCache != null)
			{
				if (Info.Instance.IsPcOrGamepadPlatform())
				{
					float num3 = GameSettingsUtils.GrassCullDistanceCache.Value * num2;
					UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("r.Kuro.Foliage.GrassCullDistanceMax", num3);
					float num4 = GameSettingsUtils.GrassLODDistanceScaleCache.Value + 0.3f * (float)value;
					UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("foliage.LODDistanceScale", num4);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GameSettings;
					ELogAuthor author = ELogAuthor.LQX;
					string message = "ApplyLoadingRangeScaleLevel";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("grassCullDistance", num3);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("grassLODDistanceScale", num4);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					float num5 = GameSettingsUtils.GrassMobileCullDistanceCache.Value * num2;
					UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("r.Kuro.Foliage.MobileGrassCullDistanceMax", num5);
					float num6 = GameSettingsUtils.GrassLODDistanceScaleCache.Value + 0.15f * (float)value;
					UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("foliage.LODDistanceScale", num6);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.GameSettings;
					ELogAuthor author2 = ELogAuthor.LQX;
					string message2 = "ApplyLoadingRangeScaleLevel";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("grassCullDistance", num5);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("grassLODDistanceScale", num6);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
			EventSystem.Instance.Emit<float>(EEventName.LoadingRangeScaleChanged, num2);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(838, value.ToString());
			}
			return true;
		}

		// Token: 0x04025B6B RID: 154475
		private static int? NvidiaSuperSamplingQualityCache;

		// Token: 0x04025B6C RID: 154476
		private static int? KuroLocalRenderSettingIndexCache;

		// Token: 0x04025B6D RID: 154477
		private static bool XessEnabled;

		// Token: 0x04025B6E RID: 154478
		private static bool Fsr3FgEnable;

		// Token: 0x04025B6F RID: 154479
		private static EFFXFIApplyMode Fsr3FgApplyMode;

		// Token: 0x04025B70 RID: 154480
		[Nullable(2)]
		private static Dictionary<int, int> Fsr3FgSwitchStates;

		// Token: 0x04025B71 RID: 154481
		private static bool Fsr3FgInTemporaryApplyState;

		// Token: 0x04025B72 RID: 154482
		private static float? GrassCullDistanceCache;

		// Token: 0x04025B73 RID: 154483
		private static float? GrassMobileCullDistanceCache;

		// Token: 0x04025B74 RID: 154484
		private static float? GrassLODDistanceScaleCache;
	}
}
