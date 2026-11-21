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
	// Token: 0x020063C0 RID: 25536
	[NullableContext(1)]
	[Nullable(0)]
	public class GameSettingsUtils : IStaticVariableResetter
	{
		// Token: 0x0603DE9D RID: 253597 RVA: 0x011F9178 File Offset: 0x011F7378
		static GameSettingsUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsUtils.CreateStaticDefaultValue), new Action(GameSettingsUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0603DE9E RID: 253598 RVA: 0x011F9197 File Offset: 0x011F7397
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
			GameSettingsUtils.GrassLODDistanceScaleCache = null;
		}

		// Token: 0x0603DE9F RID: 253599 RVA: 0x011F91D0 File Offset: 0x011F73D0
		public static void ResetStaticDefaultValue()
		{
			GameSettingsUtils.NvidiaSuperSamplingQualityCache = null;
			GameSettingsUtils.KuroLocalRenderSettingIndexCache = null;
			GameSettingsUtils.XessEnabled = false;
			GameSettingsUtils.Fsr3FgEnable = false;
			GameSettingsUtils.Fsr3FgApplyMode = EFFXFIApplyMode.Default;
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = false;
			GameSettingsUtils.Fsr3FgSwitchStates = null;
			GameSettingsUtils.GrassLODDistanceScaleCache = null;
			GameSettingsUtils.DistanceConfig = null;
			GameSettingsUtils.AppliedDistanceQuality = null;
			GameSettingsUtils.HasAppliedRenderDistance = false;
		}

		// Token: 0x0603DEA0 RID: 253600 RVA: 0x011F9234 File Offset: 0x011F7434
		public static bool ApplyVolume(float value, string volumeTag)
		{
			UAkGameplayStatics.SetRTPCValue(null, value, 0, null, FNameUtil.GetDynamicFName(volumeTag).Value);
			return true;
		}

		// Token: 0x0603DEA1 RID: 253601 RVA: 0x011F925C File Offset: 0x011F745C
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
				UPerfSightHelper.PostEvent(841, GameSettingsDeviceRender.Instance.IsMetalCpp().ToString());
			}
			FCrashSightProxy.SetCustomData("DX12", GameSettingsDeviceRender.Instance.GetD3D12Type().ToString());
			FCrashSightProxy.SetCustomData("Vulkan", GameSettingsDeviceRender.Instance.IsVulkanRHI().ToString());
			FCrashSightProxy.SetCustomData("Metal-cpp", GameSettingsDeviceRender.Instance.IsMetalCpp().ToString());
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
			GameSettingsUtils.RestoreGrassLodDistanceBase();
			bool flag = Info.Instance.IsPcOrGamepadPlatform();
			bool flag2 = Info.Instance.IsMobilePlatform();
			bool flag3 = Info.Instance.IsPs5Platform();
			bool flag4 = Info.Instance.IsXboxPlatform() && !Info.Instance.IsWinGDKPlatform();
			int? num = null;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.GameSettings;
			ELogAuthor author2 = ELogAuthor.WZ;
			string message2 = "ApplyImageQualityOnly: ";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isPcOrGamepadPlatform", flag.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isMobilePlatform", flag2.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("isPs5Platform", flag3.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("isXboxConsolePlatform", flag4.ToString());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (flag)
			{
				if (flag3 || flag4)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.GameSettings;
					ELogAuthor author3 = ELogAuthor.ZYT;
					string message3 = "优先应用的画质等级[done]@[Console]";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("platform", flag3 ? "PS5" : "Xbox");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("menuQualityLevel", value);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("gameQualitySettingLevel", value);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					gameUserSettings.SetGameQualitySettingLevel((float)value);
					if (flag3)
					{
						num = new int?(value);
					}
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
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("quality level", value);
					instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				gameUserSettings.ApplySettings(true);
				if (num != null)
				{
					GameSettingsUtils.ApplyPs5RenderResolution(num.Value);
				}
			}
			else if (flag2)
			{
				gameUserSettings.SetMobileGameQualitySettingLevel((float)value);
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.GameSettings;
				ELogAuthor author5 = ELogAuthor.WZ;
				string message5 = "优先应用的画质等级[done]@[移动端平台]";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("quality level", value);
				instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
			GameSettingsUtils.ReApplyMaterialQualityLevel(new int?(value));
			GameSettingsUtils.RefreshDistanceSettingsAfterQuality(value);
			return true;
		}

		// Token: 0x0603DEA2 RID: 253602 RVA: 0x011F9670 File Offset: 0x011F7870
		private unsafe static void ApplyPs5RenderResolution(int gameQualitySettingLevel)
		{
			string consoleModelName = UKuroStaticLibrary.GetConsoleModelName();
			bool flag = consoleModelName == "PS5PRO";
			int num = (flag && gameQualitySettingLevel == 1) ? 50 : 77;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.ScreenPercentage ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.ZYT;
			string message = "PS5渲染分辨率配置";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("consoleModelName", consoleModelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isPs5Pro", flag.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("gameQualitySettingLevel", gameQualitySettingLevel);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("qualityMode", (gameQualitySettingLevel == 1) ? "性能优先" : "画质优先");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("screenPercentage", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x0603DEA3 RID: 253603 RVA: 0x011F978A File Offset: 0x011F798A
		public static void SetIsCustomImageQuality(bool value)
		{
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsCustomImageQuality, value);
		}

		// Token: 0x0603DEA4 RID: 253604 RVA: 0x011F9798 File Offset: 0x011F7998
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

		// Token: 0x0603DEA5 RID: 253605 RVA: 0x011F97F4 File Offset: 0x011F79F4
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

		// Token: 0x0603DEA6 RID: 253606 RVA: 0x011F9874 File Offset: 0x011F7A74
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

		// Token: 0x0603DEA7 RID: 253607 RVA: 0x011F98C9 File Offset: 0x011F7AC9
		public static bool ApplyResourceStandard(int value)
		{
			return true;
		}

		// Token: 0x0603DEA8 RID: 253608 RVA: 0x011F98CC File Offset: 0x011F7ACC
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

		// Token: 0x0603DEA9 RID: 253609 RVA: 0x011F9954 File Offset: 0x011F7B54
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

		// Token: 0x0603DEAA RID: 253610 RVA: 0x011F9A00 File Offset: 0x011F7C00
		public static bool ApplyHighestFps(int value)
		{
			int frameByList = GameSettingsDeviceRender.Instance.GetFrameByList(value);
			GameSettingsDeviceRender.Instance.ApplyFrameRate(frameByList);
			return true;
		}

		// Token: 0x0603DEAB RID: 253611 RVA: 0x011F9A28 File Offset: 0x011F7C28
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

		// Token: 0x0603DEAC RID: 253612 RVA: 0x011F9B14 File Offset: 0x011F7D14
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

		// Token: 0x0603DEAD RID: 253613 RVA: 0x011F9E18 File Offset: 0x011F8018
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

		// Token: 0x0603DEAE RID: 253614 RVA: 0x011F9EB8 File Offset: 0x011F80B8
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

		// Token: 0x0603DEAF RID: 253615 RVA: 0x011FA05C File Offset: 0x011F825C
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

		// Token: 0x0603DEB0 RID: 253616 RVA: 0x011FA0D8 File Offset: 0x011F82D8
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

		// Token: 0x0603DEB1 RID: 253617 RVA: 0x011FA1E4 File Offset: 0x011F83E4
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

		// Token: 0x0603DEB2 RID: 253618 RVA: 0x011FA224 File Offset: 0x011F8424
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

		// Token: 0x0603DEB3 RID: 253619 RVA: 0x011FA254 File Offset: 0x011F8454
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

		// Token: 0x0603DEB4 RID: 253620 RVA: 0x011FA40C File Offset: 0x011F860C
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

		// Token: 0x0603DEB5 RID: 253621 RVA: 0x011FA42F File Offset: 0x011F862F
		public static bool ApplyNvidiaReflex(int value)
		{
			return true;
		}

		// Token: 0x0603DEB6 RID: 253622 RVA: 0x011FA434 File Offset: 0x011F8634
		public static bool ApplyHdrEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.HDR.EnableHDROutput ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x0603DEB7 RID: 253623 RVA: 0x011FA474 File Offset: 0x011F8674
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
			if (Info.Instance.IsGamepadPlatform())
			{
				return false;
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

		// Token: 0x0603DEB8 RID: 253624 RVA: 0x011FA5E4 File Offset: 0x011F87E4
		public static bool ApplyXessEnable(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.XeSS.Enabled ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x0603DEB9 RID: 253625 RVA: 0x011FA624 File Offset: 0x011F8824
		public static bool ApplyXessQuality(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.XeSS.Quality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x0603DEBA RID: 253626 RVA: 0x011FA664 File Offset: 0x011F8864
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

		// Token: 0x0603DEBB RID: 253627 RVA: 0x011FA6AC File Offset: 0x011F88AC
		public static bool ApplyXess2Fg(int value)
		{
			GameSettingsDeviceRender.Instance.EnableXefg(value);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(827, value.ToString());
			}
			return true;
		}

		// Token: 0x0603DEBC RID: 253628 RVA: 0x011FA6D4 File Offset: 0x011F88D4
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

		// Token: 0x0603DEBD RID: 253629 RVA: 0x011FA72C File Offset: 0x011F892C
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

		// Token: 0x0603DEBE RID: 253630 RVA: 0x011FA7BC File Offset: 0x011F89BC
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

		// Token: 0x0603DEBF RID: 253631 RVA: 0x011FA864 File Offset: 0x011F8A64
		public static bool IsFsr3FgEnable()
		{
			return GameSettingsUtils.Fsr3FgEnable;
		}

		// Token: 0x0603DEC0 RID: 253632 RVA: 0x011FA86B File Offset: 0x011F8A6B
		public static EFFXFIApplyMode GetFsr3FgApplyMode()
		{
			return GameSettingsUtils.Fsr3FgApplyMode;
		}

		// Token: 0x0603DEC1 RID: 253633 RVA: 0x011FA874 File Offset: 0x011F8A74
		public static int GetFsr3FgSwitchState(EFFXFIApplyMode mode)
		{
			int result;
			if (!GameSettingsUtils.Fsr3FgSwitchStates.TryGetValue((int)mode, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603DEC2 RID: 253634 RVA: 0x011FA893 File Offset: 0x011F8A93
		public static bool IsTemporaryFFXFIApplyMode(EFFXFIApplyMode mode)
		{
			return mode > EFFXFIApplyMode.Default;
		}

		// Token: 0x0603DEC3 RID: 253635 RVA: 0x011FA899 File Offset: 0x011F8A99
		public static bool IsInTemporaryFFXFIApplyState()
		{
			return GameSettingsUtils.Fsr3FgInTemporaryApplyState;
		}

		// Token: 0x0603DEC4 RID: 253636 RVA: 0x011FA8A0 File Offset: 0x011F8AA0
		public static void EnterTemporaryFFXFIApplyState()
		{
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = true;
		}

		// Token: 0x0603DEC5 RID: 253637 RVA: 0x011FA8A8 File Offset: 0x011F8AA8
		public static void LeaveTemporaryFFXFIApplyState()
		{
			GameSettingsUtils.Fsr3FgInTemporaryApplyState = false;
		}

		// Token: 0x0603DEC6 RID: 253638 RVA: 0x011FA8B0 File Offset: 0x011F8AB0
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

		// Token: 0x0603DEC7 RID: 253639 RVA: 0x011FA914 File Offset: 0x011F8B14
		public unsafe static bool ApplyPssrEnable(int value, EGameSettingsApplyReason reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.ZYT;
			string message = "ApplyPssrEnable";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("r.SIE.PSSR.Enable", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.SIE.PSSR.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x0603DEC8 RID: 253640 RVA: 0x011FA9B4 File Offset: 0x011F8BB4
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

		// Token: 0x0603DEC9 RID: 253641 RVA: 0x011FAA44 File Offset: 0x011F8C44
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

		// Token: 0x0603DECA RID: 253642 RVA: 0x011FAA9A File Offset: 0x011F8C9A
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

		// Token: 0x0603DECB RID: 253643 RVA: 0x011FAAB8 File Offset: 0x011F8CB8
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

		// Token: 0x0603DECC RID: 253644 RVA: 0x011FABC4 File Offset: 0x011F8DC4
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

		// Token: 0x0603DECD RID: 253645 RVA: 0x011FAC6C File Offset: 0x011F8E6C
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

		// Token: 0x0603DECE RID: 253646 RVA: 0x011FAD1C File Offset: 0x011F8F1C
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

		// Token: 0x0603DECF RID: 253647 RVA: 0x011FAD98 File Offset: 0x011F8F98
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

		// Token: 0x0603DED0 RID: 253648 RVA: 0x011FB001 File Offset: 0x011F9201
		public static bool ApplySuperResolution(int value)
		{
			return false;
		}

		// Token: 0x0603DED1 RID: 253649 RVA: 0x011FB004 File Offset: 0x011F9204
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

		// Token: 0x0603DED2 RID: 253650 RVA: 0x011FB078 File Offset: 0x011F9278
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

		// Token: 0x0603DED3 RID: 253651 RVA: 0x011FB15C File Offset: 0x011F935C
		public static void ApplyHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBaseYawSensitivity((double)value);
		}

		// Token: 0x0603DED4 RID: 253652 RVA: 0x011FB16F File Offset: 0x011F936F
		public static void ApplyVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBasePitchSensitivity((double)value);
		}

		// Token: 0x0603DED5 RID: 253653 RVA: 0x011FB182 File Offset: 0x011F9382
		public static void ApplyAimHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingYawSensitivity((double)value);
		}

		// Token: 0x0603DED6 RID: 253654 RVA: 0x011FB195 File Offset: 0x011F9395
		public static void ApplyAimVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingPitchSensitivity((double)value);
		}

		// Token: 0x0603DED7 RID: 253655 RVA: 0x011FB1A8 File Offset: 0x011F93A8
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

		// Token: 0x0603DED8 RID: 253656 RVA: 0x011FB218 File Offset: 0x011F9418
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
			return true;
		}

		// Token: 0x0603DED9 RID: 253657 RVA: 0x011FB270 File Offset: 0x011F9470
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

		// Token: 0x0603DEDA RID: 253658 RVA: 0x011FB29C File Offset: 0x011F949C
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

		// Token: 0x0603DEDB RID: 253659 RVA: 0x011FB30B File Offset: 0x011F950B
		public static void ApplyMobileHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBaseYawSensitivity((double)value);
		}

		// Token: 0x0603DEDC RID: 253660 RVA: 0x011FB31E File Offset: 0x011F951E
		public static void ApplyMobileVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraBasePitchSensitivity((double)value);
		}

		// Token: 0x0603DEDD RID: 253661 RVA: 0x011FB331 File Offset: 0x011F9531
		public static void ApplyMobileAimHorizontalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingYawSensitivity((double)value);
		}

		// Token: 0x0603DEDE RID: 253662 RVA: 0x011FB344 File Offset: 0x011F9544
		public static void ApplyMobileAimVerticalViewSensitivity(float value)
		{
			CameraModel.Instance.MainModel.SetCameraAimingPitchSensitivity((double)value);
		}

		// Token: 0x0603DEDF RID: 253663 RVA: 0x011FB357 File Offset: 0x011F9557
		public static void ApplyCommonSpringArmLength(float value)
		{
			CameraModel.Instance.MainModel.CameraSettingNormalAdditionArmLength = (double)value;
		}

		// Token: 0x0603DEE0 RID: 253664 RVA: 0x011FB36A File Offset: 0x011F956A
		public static void ApplyFightSpringArmLength(float value)
		{
			CameraModel.Instance.MainModel.CameraSettingFightAdditionArmLength = (double)value;
		}

		// Token: 0x0603DEE1 RID: 253665 RVA: 0x011FB37D File Offset: 0x011F957D
		public static void ApplyResetFocusEnable(int value)
		{
			CameraModel.Instance.MainModel.IsEnableResetFocus = (value == 1);
		}

		// Token: 0x0603DEE2 RID: 253666 RVA: 0x011FB392 File Offset: 0x011F9592
		public static void ApplyIsSidestepCameraEnable(int value)
		{
			CameraModel.Instance.MainModel.IsEnableSidestepCamera = (value == 1);
		}

		// Token: 0x0603DEE3 RID: 253667 RVA: 0x011FB3A7 File Offset: 0x011F95A7
		public static void ApplyIsSoftLockCameraEnable(int value)
		{
			CameraModel.Instance.MainModel.SetSettingSoftLockState(value == 1);
		}

		// Token: 0x0603DEE4 RID: 253668 RVA: 0x011FB3BC File Offset: 0x011F95BC
		public static bool ApplyJoystickShakeStrength(int value)
		{
			GameSettingsUtils.ApplyJoystickShakeInternal((EGlobalKuroForceFeedbackType)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.JoystickShakeType, 0, true), value);
			return true;
		}

		// Token: 0x0603DEE5 RID: 253669 RVA: 0x011FB3D4 File Offset: 0x011F95D4
		public static bool ApplyJoystickShakeType(int value)
		{
			int currentValueSafely = GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.JoystickShakeStrength, 0, true);
			GameSettingsUtils.ApplyJoystickShakeInternal((EGlobalKuroForceFeedbackType)value, currentValueSafely);
			return true;
		}

		// Token: 0x0603DEE6 RID: 253670 RVA: 0x011FB3F9 File Offset: 0x011F95F9
		private static void ApplyJoystickShakeInternal(EGlobalKuroForceFeedbackType joystickShakeType, int joystickShakeStrength)
		{
			ABasePlayerController.SetKuroForceFeedbackConfig(joystickShakeType, joystickShakeStrength);
		}

		// Token: 0x0603DEE7 RID: 253671 RVA: 0x011FB402 File Offset: 0x011F9602
		public static void ApplyWalkOrRunRate(float value)
		{
			RoleGaitStatic.SetWalkOrRunRateForRocker(value);
		}

		// Token: 0x0603DEE8 RID: 253672 RVA: 0x011FB40A File Offset: 0x011F960A
		public static void ApplyJoystickMode(int value)
		{
			BattleUiModel.Instance.SetIsDynamicJoystick(value == 1);
		}

		// Token: 0x0603DEE9 RID: 253673 RVA: 0x011FB41A File Offset: 0x011F961A
		public static void ApplyAutoSwitchSkillButtonMode(int value)
		{
			BattleUiModel.Instance.SetIsAutoSwitchSkillButtonMode(value == 0);
		}

		// Token: 0x0603DEEA RID: 253674 RVA: 0x011FB42A File Offset: 0x011F962A
		public static void ApplyAimAssistEnable(int value)
		{
			CameraModel instance = CameraModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.MainModel.SetAimAssistEnable(value == 1);
		}

		// Token: 0x0603DEEB RID: 253675 RVA: 0x011FB444 File Offset: 0x011F9644
		public static void ApplyKeyboardLockEnemyMode(int value)
		{
			FormationDataController.Instance.SetKeyboardLockEnemyMode((ELockEnemyMode)value);
		}

		// Token: 0x0603DEEC RID: 253676 RVA: 0x011FB454 File Offset: 0x011F9654
		public static void ApplyHorizontalViewRevert(int value)
		{
			IReadOnlyList<AxisRevert> axisRevertConfigListByRevertType = MenuBaseConfig.Instance.GetAxisRevertConfigListByRevertType(0);
			if (axisRevertConfigListByRevertType == null)
			{
				return;
			}
			GameSettingsUtils.ApplyAxisRevert(value == 1, axisRevertConfigListByRevertType);
		}

		// Token: 0x0603DEED RID: 253677 RVA: 0x011FB47C File Offset: 0x011F967C
		public static void ApplyVerticalViewRevert(int value)
		{
			IReadOnlyList<AxisRevert> axisRevertConfigListByRevertType = MenuBaseConfig.Instance.GetAxisRevertConfigListByRevertType(1);
			if (axisRevertConfigListByRevertType == null)
			{
				return;
			}
			GameSettingsUtils.ApplyAxisRevert(value == 1, axisRevertConfigListByRevertType);
		}

		// Token: 0x0603DEEE RID: 253678 RVA: 0x011FB4A4 File Offset: 0x011F96A4
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

		// Token: 0x0603DEEF RID: 253679 RVA: 0x011FB4EC File Offset: 0x011F96EC
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

		// Token: 0x0603DEF0 RID: 253680 RVA: 0x011FB6C8 File Offset: 0x011F98C8
		public static void ApplyGamepadLockEnemyMode(int value)
		{
			FormationDataController.Instance.SetGamepadLockEnemyMode((ELockEnemyMode)value);
		}

		// Token: 0x0603DEF1 RID: 253681 RVA: 0x011FB6D5 File Offset: 0x011F98D5
		public static void ApplyEnemyHitDisplayMode(int value)
		{
			BulletModel.Instance.OpenHitMaterial = (value == 1);
		}

		// Token: 0x0603DEF2 RID: 253682 RVA: 0x011FB6E8 File Offset: 0x011F98E8
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

		// Token: 0x0603DEF3 RID: 253683 RVA: 0x011FB71A File Offset: 0x011F991A
		public static void ApplyAutoAdjustImageQuality(int value)
		{
			GameSettingsDeviceRender.Instance.SetIsAutoAdjustImageQuality(value == 1);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(824, value.ToString());
			}
		}

		// Token: 0x0603DEF4 RID: 253684 RVA: 0x011FB742 File Offset: 0x011F9942
		public static void ApplyShowDamage(int value)
		{
			DamageUiManager.Instance.SetDamageViewVisible(value == 1);
		}

		// Token: 0x0603DEF5 RID: 253685 RVA: 0x011FB752 File Offset: 0x011F9952
		public static void ApplyDynamicBones(int value)
		{
			CreatureController.Instance.SetKawaiiEnable(value);
		}

		// Token: 0x0603DEF6 RID: 253686 RVA: 0x011FB760 File Offset: 0x011F9960
		public static void ApplyDolbyAtmos(int value)
		{
			AudioSystem.Instance.SetRtpcValue("dolby_atmos", (float)value, null);
		}

		// Token: 0x0603DEF7 RID: 253687 RVA: 0x011FB787 File Offset: 0x011F9987
		public static bool ApplyUiPureMode(int value)
		{
			if (value == 1)
			{
				BattleUiControl.Instance.TryOpenPureMode();
				return false;
			}
			return BattleUiControl.Instance.TryClosePureMode();
		}

		// Token: 0x0603DEF8 RID: 253688 RVA: 0x011FB7A4 File Offset: 0x011F99A4
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

		// Token: 0x0603DEF9 RID: 253689 RVA: 0x011FB8E0 File Offset: 0x011F9AE0
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

		// Token: 0x0603DEFA RID: 253690 RVA: 0x011FB980 File Offset: 0x011F9B80
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

		// Token: 0x0603DEFB RID: 253691 RVA: 0x011FBA0C File Offset: 0x011F9C0C
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

		// Token: 0x0603DEFC RID: 253692 RVA: 0x011FBA80 File Offset: 0x011F9C80
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

		// Token: 0x0603DEFD RID: 253693 RVA: 0x011FBB10 File Offset: 0x011F9D10
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

		// Token: 0x0603DEFE RID: 253694 RVA: 0x011FBB9F File Offset: 0x011F9D9F
		public static void ApplySkinDamageMode(int value)
		{
			CharacterSkinDamageComponent.EnableSkinDamage = (value == 1);
			EventSystem.Instance.Emit(EEventName.OnResetSkinDamageMode);
		}

		// Token: 0x0603DEFF RID: 253695 RVA: 0x011FBBBC File Offset: 0x011F9DBC
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

		// Token: 0x0603DF00 RID: 253696 RVA: 0x011FBC1D File Offset: 0x011F9E1D
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

		// Token: 0x0603DF01 RID: 253697 RVA: 0x011FBC4A File Offset: 0x011F9E4A
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

		// Token: 0x0603DF02 RID: 253698 RVA: 0x011FBC77 File Offset: 0x011F9E77
		public static bool ApplyVulkan(int value)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetVulkanPromotion(value > 0);
			return true;
		}

		// Token: 0x0603DF03 RID: 253699 RVA: 0x011FBC84 File Offset: 0x011F9E84
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

		// Token: 0x0603DF04 RID: 253700 RVA: 0x011FBD28 File Offset: 0x011F9F28
		public static bool ApplyVegetationDither(int value)
		{
			FName parameterName = new FName("FoliageDitherState");
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetGlobalShaderParameters(), parameterName, (value > 0) ? 1f : 0f);
			return true;
		}

		// Token: 0x0603DF05 RID: 253701 RVA: 0x011FBD68 File Offset: 0x011F9F68
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

		// Token: 0x0603DF06 RID: 253702 RVA: 0x011FBDD4 File Offset: 0x011F9FD4
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

		// Token: 0x0603DF07 RID: 253703 RVA: 0x011FBEB0 File Offset: 0x011FA0B0
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

		// Token: 0x0603DF08 RID: 253704 RVA: 0x011FBF44 File Offset: 0x011FA144
		public static bool ApplyEyeProtectionTemp(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionTemperature(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x0603DF09 RID: 253705 RVA: 0x011FBF54 File Offset: 0x011FA154
		public static bool ApplyEyeProtectionStrength(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionStrength(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x0603DF0A RID: 253706 RVA: 0x011FBF64 File Offset: 0x011FA164
		public static bool ApplyEyeProtectionBrightness(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionBrightness(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x0603DF0B RID: 253707 RVA: 0x011FBF74 File Offset: 0x011FA174
		public static bool ApplyEyeProtectionTexture(float value, int mode)
		{
			UKuroGISystem.ApplyEyeProtectionTexture(GlobalData.World, value, (float)mode);
			return true;
		}

		// Token: 0x0603DF0C RID: 253708 RVA: 0x011FBF84 File Offset: 0x011FA184
		public static bool ApplyAutoExposure(int value)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Kuro.AutoExposurePlayerCustom ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			return true;
		}

		// Token: 0x0603DF0D RID: 253709 RVA: 0x011FBFC2 File Offset: 0x011FA1C2
		public static void ApplyAdjustiveGamePadTrigger(int value)
		{
			UTriggerEffectBPLibrary.SetTriggerEffectState(Global.CharacterController, value == 1);
		}

		// Token: 0x0603DF0E RID: 253710 RVA: 0x011FBFD2 File Offset: 0x011FA1D2
		public static float MapGamepadDeadZoneUiToEngine(int uiValue)
		{
			if (Info.Instance.IsIosPlatform())
			{
				return (float)(uiValue - 10) * 0.01f;
			}
			return (float)uiValue / 100f * 0.9f;
		}

		// Token: 0x0603DF0F RID: 253711 RVA: 0x011FBFFA File Offset: 0x011FA1FA
		public static void ApplyGamepadLeftStickDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_LeftX,
				EKey.Gamepad_LeftY
			});
		}

		// Token: 0x0603DF10 RID: 253712 RVA: 0x011FC020 File Offset: 0x011FA220
		public static void ApplyGamepadRightStickDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_RightX,
				EKey.Gamepad_RightY
			});
		}

		// Token: 0x0603DF11 RID: 253713 RVA: 0x011FC046 File Offset: 0x011FA246
		public static void ApplyGamepadLeftTriggerDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_LeftTriggerAxis
			});
		}

		// Token: 0x0603DF12 RID: 253714 RVA: 0x011FC060 File Offset: 0x011FA260
		public static void ApplyGamepadRightTriggerDeadZone(int uiValue)
		{
			GameSettingsUtils.ApplyGamepadDeadZoneToKeys(uiValue, new EKey[]
			{
				EKey.Gamepad_RightTriggerAxis
			});
		}

		// Token: 0x0603DF13 RID: 253715 RVA: 0x011FC07C File Offset: 0x011FA27C
		private static void ApplyGamepadDeadZoneToKeys(int uiValue, EKey[] keys)
		{
			float deadZone = GameSettingsUtils.MapGamepadDeadZoneUiToEngine(uiValue);
			int playerIndex = 0;
			foreach (EKey key in keys)
			{
				UKuroStaticLibrary.SetInputKeyDeadZone(Global.CharacterController, playerIndex, new FKey
				{
					KeyName = new FName(key)
				}, deadZone);
			}
		}

		// Token: 0x0603DF14 RID: 253716 RVA: 0x011FC0CE File Offset: 0x011FA2CE
		public static void ApplyMotorAutoLongPressSpeedUp(int value)
		{
			BattleUiModel.Instance.MotorcycleData.AutoNitrogenSettingEnable = (value == 1);
		}

		// Token: 0x0603DF15 RID: 253717 RVA: 0x011FC0E3 File Offset: 0x011FA2E3
		public static void ApplyMotorAutoAcceleratorSettingEnable(int value)
		{
			BattleUiModel.Instance.MotorcycleData.AutoAcceleratorSettingEnable = (value == 1);
		}

		// Token: 0x0603DF16 RID: 253718 RVA: 0x011FC0F8 File Offset: 0x011FA2F8
		public static void ApplyMotorDriftAcceleratorSettingEnable(int value)
		{
			BattleUiModel.Instance.MotorcycleData.DriftAcceleratorSettingEnable = (value == 1);
		}

		// Token: 0x0603DF17 RID: 253719 RVA: 0x011FC10D File Offset: 0x011FA30D
		public static void ApplyMotorHudVisible(int value)
		{
			BattleUiModel.Instance.MotorcycleData.SetHudVisible(value == 0, "设置系统设置");
		}

		// Token: 0x0603DF18 RID: 253720 RVA: 0x011FC127 File Offset: 0x011FA327
		public static void ApplyMotorIsDynamicJoystick(int value)
		{
			BattleUiModel.Instance.MotorcycleData.SetIsDynamicJoystick(value == 1);
		}

		// Token: 0x0603DF19 RID: 253721 RVA: 0x011FC13C File Offset: 0x011FA33C
		public static void ApplyUiBrightness(float value)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.PeakBrightness);
			UKuroGISystem.ApplyHDRMetaData(GlobalData.World, value, (float)dataCacheOrCurValue.GetValueOrDefault());
		}

		// Token: 0x0603DF1A RID: 253722 RVA: 0x011FC16C File Offset: 0x011FA36C
		public static void ApplyPeakBrightness(float value)
		{
			int? dataCacheOrCurValue = MenuModel.Instance.GetDataCacheOrCurValue(EFunction.UiBrightness);
			UKuroGISystem.ApplyHDRMetaData(GlobalData.World, (float)dataCacheOrCurValue.GetValueOrDefault(), value);
		}

		// Token: 0x0603DF1B RID: 253723 RVA: 0x011FC19C File Offset: 0x011FA39C
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

		// Token: 0x0603DF1C RID: 253724 RVA: 0x011FC204 File Offset: 0x011FA404
		[NullableContext(2)]
		private static GameSettingsUtils.RenderDistanceConfig GetRenderDistanceConfig()
		{
			IReadOnlyList<DeviceRenderFeature> renderDistanceFeatures = GameSettingsDeviceRender.Instance.GetRenderDistanceFeatures();
			if (renderDistanceFeatures == null)
			{
				return null;
			}
			if (GameSettingsUtils.DistanceConfig == null || GameSettingsUtils.DistanceConfig.SourceFeatures != renderDistanceFeatures)
			{
				GameSettingsUtils.RenderDistanceConfig renderDistanceConfig = new GameSettingsUtils.RenderDistanceConfig();
				renderDistanceConfig.Load(renderDistanceFeatures);
				GameSettingsUtils.DistanceConfig = renderDistanceConfig;
			}
			return GameSettingsUtils.DistanceConfig;
		}

		// Token: 0x0603DF1D RID: 253725 RVA: 0x011FC24B File Offset: 0x011FA44B
		private static string GetRenderDistanceGrassVariable()
		{
			if (!Info.Instance.IsPcOrGamepadPlatform())
			{
				return "r.Kuro.Foliage.MobileGrassCullDistanceMax";
			}
			return "r.Kuro.Foliage.GrassCullDistanceMax";
		}

		// Token: 0x0603DF1E RID: 253726 RVA: 0x011FC264 File Offset: 0x011FA464
		private unsafe static void RestoreGrassLodDistanceBase()
		{
			if (GameSettingsUtils.GrassLODDistanceScaleCache == null)
			{
				return;
			}
			float value = GameSettingsUtils.GrassLODDistanceScaleCache.Value;
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("foliage.LODDistanceScale", value);
			GameSettingsUtils.GrassLODDistanceScaleCache = null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZD;
			string message = "RenderDistance.GrassLOD.Restore";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LodTarget", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LodActual", UKismetSystemLibrary.GetConsoleVariableFloatValue("foliage.LODDistanceScale"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603DF1F RID: 253727 RVA: 0x011FC308 File Offset: 0x011FA508
		private unsafe static void ApplyGrassLODDistance(int stepIndex)
		{
			int num = Math.Max(stepIndex - GameSettingsDeviceRender.GetRenderDistanceBaseMaxStepIndex(), 0);
			if (num == 0)
			{
				GameSettingsUtils.RestoreGrassLodDistanceBase();
				return;
			}
			if (GameSettingsUtils.GrassLODDistanceScaleCache == null)
			{
				GameSettingsUtils.GrassLODDistanceScaleCache = new float?(UKismetSystemLibrary.GetConsoleVariableFloatValue("foliage.LODDistanceScale"));
			}
			float num2 = Info.Instance.IsPcOrGamepadPlatform() ? 0.3f : 0.15f;
			float num3 = GameSettingsUtils.GrassLODDistanceScaleCache.Value + num2 * (float)num;
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("foliage.LODDistanceScale", num3);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZD;
			string message = "RenderDistance.GrassLOD";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("StepIndex", stepIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExtensionLevel", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("LodBase", GameSettingsUtils.GrassLODDistanceScaleCache.Value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LodTarget", num3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("LodActual", UKismetSystemLibrary.GetConsoleVariableFloatValue("foliage.LODDistanceScale"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x0603DF20 RID: 253728 RVA: 0x011FC44C File Offset: 0x011FA64C
		private static GameSettingsUtils.RenderDistanceValues CalculateRenderDistanceValues(GameSettingsUtils.RenderDistanceConfig config, float value)
		{
			int renderDistanceStepIndex = GameSettingsDeviceRender.GetRenderDistanceStepIndex(value);
			int renderDistanceBaseMaxStepIndex = GameSettingsDeviceRender.GetRenderDistanceBaseMaxStepIndex();
			GameSettingsUtils.RenderDistanceValues baseValues = config.GetBaseValues(renderDistanceStepIndex);
			if (renderDistanceStepIndex <= renderDistanceBaseMaxStepIndex)
			{
				return baseValues;
			}
			int renderDistanceMaxStepIndex = GameSettingsDeviceRender.GetRenderDistanceMaxStepIndex();
			float num = (float)(renderDistanceStepIndex - renderDistanceBaseMaxStepIndex) / (float)(renderDistanceMaxStepIndex - renderDistanceBaseMaxStepIndex);
			GameSettingsUtils.RenderDistanceValues maximumValues = config.MaximumValues;
			return new GameSettingsUtils.RenderDistanceValues(baseValues.GrassCull + (maximumValues.GrassCull - baseValues.GrassCull) * num, baseValues.LoadingRange + (maximumValues.LoadingRange - baseValues.LoadingRange) * num, baseValues.PlannedLoadingRange + (maximumValues.PlannedLoadingRange - baseValues.PlannedLoadingRange) * num);
		}

		// Token: 0x0603DF21 RID: 253729 RVA: 0x011FC4DC File Offset: 0x011FA6DC
		private unsafe static void ApplyWpDistanceValues(GameSettingsUtils.RenderDistanceValues values)
		{
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("wp.Runtime.LoadingRangeScale", values.LoadingRange);
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("wp.Runtime.PlannedLoadingRangeScale", values.PlannedLoadingRange);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZD;
			string message = "RenderDistance.WP";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LoadingTarget", values.LoadingRange);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LoadingActual", UKismetSystemLibrary.GetConsoleVariableFloatValue("wp.Runtime.LoadingRangeScale"));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PlannedTarget", values.PlannedLoadingRange);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PlannedActual", UKismetSystemLibrary.GetConsoleVariableFloatValue("wp.Runtime.PlannedLoadingRangeScale"));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0603DF22 RID: 253730 RVA: 0x011FC5C0 File Offset: 0x011FA7C0
		public unsafe static bool ApplyLoadingRangeScale(float value)
		{
			if (!GameSettingsManager.Instance.IsValid(EFunction.LOADINGRANGESCALELEVEL, false))
			{
				return false;
			}
			GameSettingsUtils.RenderDistanceConfig renderDistanceConfig = GameSettingsUtils.GetRenderDistanceConfig();
			if (renderDistanceConfig == null)
			{
				return false;
			}
			float num = GameSettingsDeviceRender.NormalizeRenderDistanceValue(value);
			int renderDistanceStepIndex = GameSettingsDeviceRender.GetRenderDistanceStepIndex(num);
			GameSettingsUtils.RenderDistanceValues renderDistanceValues = GameSettingsUtils.CalculateRenderDistanceValues(renderDistanceConfig, num);
			string renderDistanceGrassVariable = GameSettingsUtils.GetRenderDistanceGrassVariable();
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float(renderDistanceGrassVariable, renderDistanceValues.GrassCull);
			GameSettingsUtils.ApplyWpDistanceValues(renderDistanceValues);
			GameSettingsUtils.ApplyGrassLODDistance(renderDistanceStepIndex);
			GameSettingsUtils.HasAppliedRenderDistance = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GameSettings;
			ELogAuthor author = ELogAuthor.TZD;
			string message = "RenderDistance.Grass";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Slider", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GrassVariable", renderDistanceGrassVariable);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("GrassTarget", renderDistanceValues.GrassCull);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("GrassActual", UKismetSystemLibrary.GetConsoleVariableFloatValue(renderDistanceGrassVariable));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return true;
		}

		// Token: 0x0603DF23 RID: 253731 RVA: 0x011FC6C4 File Offset: 0x011FA8C4
		public static void RefreshDistanceSettingsAfterQuality(int quality)
		{
			GameSettingsUtils.AppliedDistanceQuality = new int?(quality);
			if (!GameSettingsManager.Instance.IsValid(EFunction.LOADINGRANGESCALELEVEL, false))
			{
				return;
			}
			float? renderDistanceRecommendation = GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(quality);
			if (renderDistanceRecommendation == null)
			{
				return;
			}
			GameSettingsUtils.ApplyLoadingRangeScale(GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.LOADINGRANGESCALELEVEL, renderDistanceRecommendation.Value, false));
		}

		// Token: 0x0603DF24 RID: 253732 RVA: 0x011FC724 File Offset: 0x011FA924
		public static void ReApplyLoadingRangeScale()
		{
			if (!GameSettingsManager.Instance.IsValid(EFunction.LOADINGRANGESCALELEVEL, false))
			{
				return;
			}
			GameSettingsUtils.RenderDistanceConfig renderDistanceConfig = GameSettingsUtils.GetRenderDistanceConfig();
			if (renderDistanceConfig == null)
			{
				return;
			}
			int quality = GameSettingsUtils.AppliedDistanceQuality ?? ((int)GameSettingsDeviceRender.Instance.GameQualitySettingLevel);
			float? renderDistanceRecommendation = GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(quality);
			if (renderDistanceRecommendation == null)
			{
				return;
			}
			float currentValueSafelyFloat = GameSettingsManager.Instance.GetCurrentValueSafelyFloat(EFunction.LOADINGRANGESCALELEVEL, renderDistanceRecommendation.Value, false);
			GameSettingsUtils.ApplyWpDistanceValues(GameSettingsUtils.CalculateRenderDistanceValues(renderDistanceConfig, currentValueSafelyFloat));
			GameSettingsUtils.HasAppliedRenderDistance = true;
		}

		// Token: 0x0603DF25 RID: 253733 RVA: 0x011FC7B4 File Offset: 0x011FA9B4
		public static void RestoreDistanceQualityDefaults()
		{
			GameSettingsUtils.RestoreGrassLodDistanceBase();
			if (!GameSettingsUtils.HasAppliedRenderDistance)
			{
				return;
			}
			GameSettingsUtils.RenderDistanceConfig renderDistanceConfig = GameSettingsUtils.GetRenderDistanceConfig();
			if (renderDistanceConfig == null)
			{
				return;
			}
			int quality = GameSettingsUtils.AppliedDistanceQuality ?? ((int)GameSettingsDeviceRender.Instance.GameQualitySettingLevel);
			float? renderDistanceRecommendation = GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(quality);
			if (renderDistanceRecommendation == null)
			{
				return;
			}
			int renderDistanceStepIndex = GameSettingsDeviceRender.GetRenderDistanceStepIndex(renderDistanceRecommendation.Value);
			GameSettingsUtils.RenderDistanceValues baseValues = renderDistanceConfig.GetBaseValues(renderDistanceStepIndex);
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float(GameSettingsUtils.GetRenderDistanceGrassVariable(), baseValues.GrassCull);
			GameSettingsUtils.ApplyWpDistanceValues(baseValues);
			GameSettingsUtils.HasAppliedRenderDistance = false;
		}

		// Token: 0x04020E23 RID: 134691
		private static int? NvidiaSuperSamplingQualityCache;

		// Token: 0x04020E24 RID: 134692
		private static int? KuroLocalRenderSettingIndexCache;

		// Token: 0x04020E25 RID: 134693
		private static bool XessEnabled;

		// Token: 0x04020E26 RID: 134694
		private static bool Fsr3FgEnable;

		// Token: 0x04020E27 RID: 134695
		private static EFFXFIApplyMode Fsr3FgApplyMode;

		// Token: 0x04020E28 RID: 134696
		[Nullable(2)]
		private static Dictionary<int, int> Fsr3FgSwitchStates;

		// Token: 0x04020E29 RID: 134697
		private static bool Fsr3FgInTemporaryApplyState;

		// Token: 0x04020E2A RID: 134698
		private const string GrassKey = "r.Kuro.Foliage.GrassCullDistanceMax";

		// Token: 0x04020E2B RID: 134699
		private const string MobileGrassKey = "r.Kuro.Foliage.MobileGrassCullDistanceMax";

		// Token: 0x04020E2C RID: 134700
		private const string GrassLodKey = "foliage.LODDistanceScale";

		// Token: 0x04020E2D RID: 134701
		private const string LoadingKey = "wp.Runtime.LoadingRangeScale";

		// Token: 0x04020E2E RID: 134702
		private const string PlannedKey = "wp.Runtime.PlannedLoadingRangeScale";

		// Token: 0x04020E2F RID: 134703
		[Nullable(2)]
		private static GameSettingsUtils.RenderDistanceConfig DistanceConfig;

		// Token: 0x04020E30 RID: 134704
		private static int? AppliedDistanceQuality;

		// Token: 0x04020E31 RID: 134705
		private static bool HasAppliedRenderDistance;

		// Token: 0x04020E32 RID: 134706
		private static float? GrassLODDistanceScaleCache;

		// Token: 0x0200BB75 RID: 47989
		[NullableContext(0)]
		private readonly struct RenderDistanceValues
		{
			// Token: 0x0604896C RID: 297324 RVA: 0x01621B36 File Offset: 0x0161FD36
			public RenderDistanceValues(float grassCull, float loadingRange, float plannedLoadingRange)
			{
				this.GrassCull = grassCull;
				this.LoadingRange = loadingRange;
				this.PlannedLoadingRange = plannedLoadingRange;
			}

			// Token: 0x04039A1C RID: 236060
			public readonly float GrassCull;

			// Token: 0x04039A1D RID: 236061
			public readonly float LoadingRange;

			// Token: 0x04039A1E RID: 236062
			public readonly float PlannedLoadingRange;
		}

		// Token: 0x0200BB76 RID: 47990
		[NullableContext(2)]
		[Nullable(0)]
		private sealed class RenderDistanceConfig
		{
			// Token: 0x17007A80 RID: 31360
			// (get) Token: 0x0604896D RID: 297325 RVA: 0x01621B4D File Offset: 0x0161FD4D
			// (set) Token: 0x0604896E RID: 297326 RVA: 0x01621B55 File Offset: 0x0161FD55
			public IReadOnlyList<DeviceRenderFeature> SourceFeatures { get; private set; }

			// Token: 0x17007A81 RID: 31361
			// (get) Token: 0x0604896F RID: 297327 RVA: 0x01621B5E File Offset: 0x0161FD5E
			// (set) Token: 0x06048970 RID: 297328 RVA: 0x01621B66 File Offset: 0x0161FD66
			public GameSettingsUtils.RenderDistanceValues MaximumValues { get; private set; }

			// Token: 0x06048971 RID: 297329 RVA: 0x01621B70 File Offset: 0x0161FD70
			[NullableContext(1)]
			public void Load(IReadOnlyList<DeviceRenderFeature> configs)
			{
				float num = Info.Instance.IsMacPlatform() ? 0.85f : 1f;
				this.BaseValues.Clear();
				foreach (DeviceRenderFeature deviceRenderFeature in configs)
				{
					float grassCull = (float)deviceRenderFeature.GrassCullDistance * num;
					float loadingRange = (float)deviceRenderFeature.LoadingRangeScale / 100f * num;
					float plannedLoadingRange = (float)deviceRenderFeature.PlannedLoadingRangeScale / 100f * num;
					this.BaseValues.Add(new GameSettingsUtils.RenderDistanceValues(grassCull, loadingRange, plannedLoadingRange));
				}
				DeviceRenderFeature deviceRenderFeature2 = configs[configs.Count - 1];
				this.MaximumValues = new GameSettingsUtils.RenderDistanceValues((float)deviceRenderFeature2.GrassCullDistanceMax * num, (float)deviceRenderFeature2.LoadingRangeScaleMax / 100f * num, (float)deviceRenderFeature2.PlannedLoadingRangeScaleMax / 100f * num);
				this.SourceFeatures = configs;
			}

			// Token: 0x06048972 RID: 297330 RVA: 0x01621C68 File Offset: 0x0161FE68
			public GameSettingsUtils.RenderDistanceValues GetBaseValues(int stepIndex)
			{
				int count = this.BaseValues.Count;
				int renderDistanceQualityIndex = GameSettingsDeviceRender.GetRenderDistanceQualityIndex(stepIndex, count);
				GameSettingsUtils.RenderDistanceValues renderDistanceValues = this.BaseValues[renderDistanceQualityIndex];
				int renderDistanceRecommendStepIndex = GameSettingsDeviceRender.GetRenderDistanceRecommendStepIndex(renderDistanceQualityIndex, count);
				if (renderDistanceQualityIndex == count - 1 || stepIndex == renderDistanceRecommendStepIndex)
				{
					return renderDistanceValues;
				}
				int index = renderDistanceQualityIndex + 1;
				GameSettingsUtils.RenderDistanceValues renderDistanceValues2 = this.BaseValues[index];
				int renderDistanceRecommendStepIndex2 = GameSettingsDeviceRender.GetRenderDistanceRecommendStepIndex(index, count);
				float num = (float)(stepIndex - renderDistanceRecommendStepIndex) / (float)(renderDistanceRecommendStepIndex2 - renderDistanceRecommendStepIndex);
				return new GameSettingsUtils.RenderDistanceValues(renderDistanceValues.GrassCull + (renderDistanceValues2.GrassCull - renderDistanceValues.GrassCull) * num, renderDistanceValues.LoadingRange + (renderDistanceValues2.LoadingRange - renderDistanceValues.LoadingRange) * num, renderDistanceValues.PlannedLoadingRange + (renderDistanceValues2.PlannedLoadingRange - renderDistanceValues.PlannedLoadingRange) * num);
			}

			// Token: 0x04039A1F RID: 236063
			[Nullable(1)]
			private readonly List<GameSettingsUtils.RenderDistanceValues> BaseValues = new List<GameSettingsUtils.RenderDistanceValues>();
		}
	}
}
