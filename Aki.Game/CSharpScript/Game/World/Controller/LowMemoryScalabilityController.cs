using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Manager;
using CSharpScript.Game.Module.Area;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003460 RID: 13408
	[NullableContext(1)]
	[Nullable(0)]
	public class LowMemoryScalabilityController : ControllerBase
	{
		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x0602236F RID: 140143 RVA: 0x009B0F35 File Offset: 0x009AF135
		private bool IsMobileLowMemoryDevice
		{
			get
			{
				return Info.Instance.IsLowMemoryDevice;
			}
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x009B0F44 File Offset: 0x009AF144
		protected override bool OnInit()
		{
			if (!this.IsMobileLowMemoryDevice)
			{
				return true;
			}
			this.bEnableChaoYueHuiQuality = Info.Instance.IsMobilePlatform();
			if (this.bEnableChaoYueHuiQuality)
			{
				this.bCanRefreshChaoYueHuiQuality = true;
				EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearChaoYueHuiWorld));
				EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.OnChaoYueHuiMapReady));
				EventSystem.Instance.Add(EEventName.WorldPartitionDataLayerStateUpdated, new Action(this.OnDataLayerStateUpdated));
			}
			EventSystem.Instance.Add(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			EventSystem.Instance.Add(EEventName.OnManuallyClearStreamingPool, new Action(this.OnManuallyClearStreamingPool));
			EventSystem.Instance.Add(EEventName.OnManuallyResetStreamingPool, new Action(this.OnManuallyResetStreamingPool));
			if (this.IsMobileLowMemoryDevice)
			{
				this.InitMobileLowMemorySettings();
				this.ApplyLowMemoryPlannedLoadingRange();
			}
			return true;
		}

		// Token: 0x06022371 RID: 140145 RVA: 0x009B106C File Offset: 0x009AF26C
		protected override bool OnClear()
		{
			if (!this.IsMobileLowMemoryDevice)
			{
				return true;
			}
			if (this.bEnableChaoYueHuiQuality)
			{
				this.OnClearChaoYueHuiWorld();
				EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearChaoYueHuiWorld));
				EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.OnChaoYueHuiMapReady));
				EventSystem.Instance.Remove(EEventName.WorldPartitionDataLayerStateUpdated, new Action(this.OnDataLayerStateUpdated));
				this.bEnableChaoYueHuiQuality = false;
			}
			EventSystem.Instance.Remove(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			EventSystem.Instance.Remove(EEventName.OnManuallyClearStreamingPool, new Action(this.OnManuallyClearStreamingPool));
			EventSystem.Instance.Remove(EEventName.OnManuallyResetStreamingPool, new Action(this.OnManuallyResetStreamingPool));
			UKuroBodySetupLibrary.EmptyClearWpBodySetupBlackList();
			return true;
		}

		// Token: 0x06022372 RID: 140146 RVA: 0x009B117C File Offset: 0x009AF37C
		private void InitMobileLowMemorySettings()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.XY, "Init Mobile Low Memory Settings", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.UnloadHLODCellWhenAllHLODActorHidden 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.EnableHLODCellMappingOptimization 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroSurfaceRipple.Enable 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroInstanceGrassInteraction.Enabled 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroWeaponEnvInteraction.Enabled 0", null);
		}

		// Token: 0x06022373 RID: 140147 RVA: 0x009B11F5 File Offset: 0x009AF3F5
		private void OnEndTravelMap()
		{
			this.ScaleStreamingTextureOnEndTravelMap();
			this.OptimizeStreamingOnEndTravelMap();
			this.OptimizeStreamingGridRangeOnEndTravelMap();
		}

		// Token: 0x06022374 RID: 140148 RVA: 0x009B120C File Offset: 0x009AF40C
		public bool IsSpecialLowMemoryMap()
		{
			int mapId = GameModeModel.Instance.MapConfig.MapId;
			HashSet<int> hashSet;
			if (!LowMemoryScalabilityController.LowMemoryMapAreas.TryGetValue(mapId, out hashSet))
			{
				return false;
			}
			if (hashSet == null)
			{
				return true;
			}
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
			return hashSet.Contains(currentAreaId);
		}

		// Token: 0x06022375 RID: 140149 RVA: 0x009B125C File Offset: 0x009AF45C
		public static bool IsMengZhouMap()
		{
			int mapId = GameModeModel.Instance.MapConfig.MapId;
			if (mapId != 8)
			{
				return false;
			}
			HashSet<int> hashSet;
			if (!LowMemoryScalabilityController.LowMemoryMapAreas.TryGetValue(mapId, out hashSet))
			{
				return false;
			}
			if (hashSet == null)
			{
				return false;
			}
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
			return hashSet.Contains(currentAreaId);
		}

		// Token: 0x06022376 RID: 140150 RVA: 0x009B12B0 File Offset: 0x009AF4B0
		private void ScaleStreamingTextureOnEndTravelMap()
		{
			float value = 0.5f;
			float value2 = 0.3f;
			float value3 = 0.3f;
			float value4 = 1f;
			if (this.IsSpecialLowMemoryMap())
			{
				value = 0.2f;
				value2 = 0.15f;
				value3 = 0.15f;
				value4 = 0.8f;
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.GroupBoost.LargeBuildingTextureFactor ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.GroupBoost.HugeBuildingTextureFactor ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value2);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world3 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.GroupBoost.HugeRocTextureFactor ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value3);
			UKismetSystemLibrary.ExecuteConsoleCommand(world3, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world4 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.GroupBoost.UnclassifiedTextureFactor ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(value4);
			UKismetSystemLibrary.ExecuteConsoleCommand(world4, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x009B13B5 File Offset: 0x009AF5B5
		private void OptimizeStreamingOnEndTravelMap()
		{
			if (this.IsSpecialLowMemoryMap())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "s.ContinuouslyIncrementalGCWhileLevelsPendingPurge 1", null);
			}
			this.ApplyLowMemoryPlannedLoadingRange();
		}

		// Token: 0x06022378 RID: 140152 RVA: 0x009B13D5 File Offset: 0x009AF5D5
		private void OnWorldDone()
		{
			this.OnEndTravelMap();
			WorldController.Instance.ManuallyResetStreamingPool();
			if (this.bEnableChaoYueHuiQuality)
			{
				this.RefreshChaoYueHuiQuality();
			}
		}

		// Token: 0x06022379 RID: 140153 RVA: 0x009B13F5 File Offset: 0x009AF5F5
		private void OnChangeArea(int? preAreaId, int curAreaId)
		{
			this.OnWorldDone();
		}

		// Token: 0x0602237A RID: 140154 RVA: 0x009B1400 File Offset: 0x009AF600
		private void OptimizeStreamingGridRangeOnEndTravelMap()
		{
			if (!UKuroStaticLibrary.IsLowMemoryDevice())
			{
				return;
			}
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
			{
				if (LowMemoryScalabilityController.IsMengZhouMap())
				{
					Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "Enter MengZhouMap Set Grid_Collision Range 150", default(ReadOnlySpan<ValueTuple<string, object>>));
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideGridLoadingRanges Grid_StaticMesh_3m=35;Grid_StaticMesh_6m=50;Grid_StaticMesh_12m=50;Grid_Collision=150;Grid_HLOD_6400=0;Grid_CustomSSSuperFar=1500;Grid_CustomSSuperFar=500;Grid_CustomSuperFar=200;Grid_Imposter_400=10;Grid_Imposter_800=10;Grid_Imposter_1600=10;", null);
					return;
				}
				Log.Instance.Info(ELogModule.World, ELogAuthor.WLJ, "Leave MengZhouMap Resume Grid_Collision Range", default(ReadOnlySpan<ValueTuple<string, object>>));
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.OverrideGridLoadingRanges Grid_StaticMesh_3m=35;Grid_StaticMesh_6m=50;Grid_StaticMesh_12m=50;", null);
			}
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x009B1482 File Offset: 0x009AF682
		private void OnDataLayerStateUpdated()
		{
			this.RefreshChaoYueHuiQuality();
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x009B148C File Offset: 0x009AF68C
		private unsafe void RefreshChaoYueHuiQuality()
		{
			if (this.bCanRefreshChaoYueHuiQuality && ModelManager.Instance.IsInit)
			{
				UWorld world = GlobalData.World;
				if (world != null && world.IsValid() && AreaModel.Instance.AreaInfo != null)
				{
					if (!GameModeModel.Instance.UseWorldPartition || !LowMemoryScalabilityController.IsMengZhouMap() || !UKuroRenderingRuntimeBPPluginBPLibrary.IsWorldPartitionDataLayerEnable(GlobalData.World, FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_37ZCZYH01") ?? FName.NAME_None))
					{
						this.RestoreChaoYueHuiQuality();
						return;
					}
					if (this.QualityValuesBeforeChaoYueHui != null || !GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
					{
						return;
					}
					Dictionary<string, float> dictionary = new Dictionary<string, float>();
					foreach (string text in LowMemoryScalabilityController.ChaoYueHuiQualityCVars)
					{
						dictionary.Add(text, UKismetSystemLibrary.GetConsoleVariableFloatValue(text));
					}
					this.QualityValuesBeforeChaoYueHui = dictionary;
					foreach (string text2 in LowMemoryScalabilityController.ChaoYueHuiQualityCVars)
					{
						float num = (text2 == "r.ScreenPercentage") ? 60f : 0f;
						UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text2 + " " + num.ToString(CultureInfo.InvariantCulture), null);
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.World;
					ELogAuthor author = ELogAuthor.RY;
					string message = "朝月会低内存设置：应用主画质与独立画质组降级";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dataLayer", "DataLayerRuntime_DLTask_37ZCZYH01");
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("originalValues", string.Join<KeyValuePair<string, float>>(", ", dictionary));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetResolution", 60f);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
			}
		}

		// Token: 0x0602237D RID: 140157 RVA: 0x009B1658 File Offset: 0x009AF858
		private void RestoreChaoYueHuiQuality()
		{
			if (this.QualityValuesBeforeChaoYueHui != null)
			{
				UWorld world = GlobalData.World;
				if (world != null && world.IsValid())
				{
					Dictionary<string, float> qualityValuesBeforeChaoYueHui = this.QualityValuesBeforeChaoYueHui;
					foreach (string text in LowMemoryScalabilityController.ChaoYueHuiQualityCVars)
					{
						UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text + " " + qualityValuesBeforeChaoYueHui[text].ToString(CultureInfo.InvariantCulture), null);
					}
					this.QualityValuesBeforeChaoYueHui = null;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.World;
					ELogAuthor author = ELogAuthor.RY;
					string message = "朝月会低内存设置：恢复主画质与独立画质组";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("originalValues", string.Join<KeyValuePair<string, float>>(", ", qualityValuesBeforeChaoYueHui));
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
			}
		}

		// Token: 0x0602237E RID: 140158 RVA: 0x009B1709 File Offset: 0x009AF909
		private void OnClearChaoYueHuiWorld()
		{
			this.bCanRefreshChaoYueHuiQuality = false;
			this.RestoreChaoYueHuiQuality();
		}

		// Token: 0x0602237F RID: 140159 RVA: 0x009B1718 File Offset: 0x009AF918
		private void OnChaoYueHuiMapReady()
		{
			this.RestoreChaoYueHuiQuality();
			this.bCanRefreshChaoYueHuiQuality = true;
		}

		// Token: 0x06022380 RID: 140160 RVA: 0x009B1728 File Offset: 0x009AF928
		private void OnManuallyClearStreamingPool()
		{
			if (this.IsSpecialLowMemoryMap() && this.IsMobileLowMemoryDevice && Info.Instance.PlatformType == ESourcePlatformType.IOS)
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.XY, "ManuallyClearStreamingPool In IOS Low Memory for Special Map", default(ReadOnlySpan<ValueTuple<string, object>>));
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSize ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(50);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSizeForMeshes ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(20);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
		}

		// Token: 0x06022381 RID: 140161 RVA: 0x009B17D8 File Offset: 0x009AF9D8
		private void OnManuallyResetStreamingPool()
		{
			if (this.IsSpecialLowMemoryMap() && this.IsMobileLowMemoryDevice && Info.Instance.PlatformType == ESourcePlatformType.IOS)
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.XY, "ManuallyResetStreamingPool In IOS Low Memory for Special Map", default(ReadOnlySpan<ValueTuple<string, object>>));
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSize ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(100);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.PoolSizeForMeshes ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(50);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
		}

		// Token: 0x06022382 RID: 140162 RVA: 0x009B1886 File Offset: 0x009AFA86
		private void ApplyLowMemoryPlannedLoadingRange()
		{
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("wp.Runtime.PlannedLoadingRangeScaleExtra", 0f);
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x06022383 RID: 140163 RVA: 0x009B1897 File Offset: 0x009AFA97
		public static LowMemoryScalabilityController Instance
		{
			get
			{
				return LowMemoryScalabilityController._Instance;
			}
		}

		// Token: 0x06022384 RID: 140164 RVA: 0x009B189E File Offset: 0x009AFA9E
		public static LowMemoryScalabilityController GetOrCreateInstance()
		{
			if (LowMemoryScalabilityController._Instance == null)
			{
				LowMemoryScalabilityController.CreateInstance();
			}
			return LowMemoryScalabilityController._Instance;
		}

		// Token: 0x06022385 RID: 140165 RVA: 0x009B18B2 File Offset: 0x009AFAB2
		public static bool CreateInstance()
		{
			if (LowMemoryScalabilityController._Instance != null)
			{
				return true;
			}
			LowMemoryScalabilityController._Instance = new LowMemoryScalabilityController();
			return true;
		}

		// Token: 0x06022386 RID: 140166 RVA: 0x009B18C8 File Offset: 0x009AFAC8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022387 RID: 140167 RVA: 0x009B18CA File Offset: 0x009AFACA
		public static void ResetStaticDefaultValue()
		{
			LowMemoryScalabilityController._Instance = null;
		}

		// Token: 0x06022388 RID: 140168 RVA: 0x009B18D4 File Offset: 0x009AFAD4
		static LowMemoryScalabilityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LowMemoryScalabilityController.CreateStaticDefaultValue), new Action(LowMemoryScalabilityController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D6C RID: 77164
		private const int XUEYUAN_MAPID = 906;

		// Token: 0x04012D6D RID: 77165
		private const int WXSG_MAPID = 912;

		// Token: 0x04012D6E RID: 77166
		private const int MAIN_WORLD_MAPID = 8;

		// Token: 0x04012D6F RID: 77167
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, HashSet<int>> LowMemoryMapAreas = new Dictionary<int, HashSet<int>>
		{
			{
				906,
				null
			},
			{
				912,
				null
			},
			{
				8,
				new HashSet<int>
				{
					44001,
					44002,
					44003,
					44004
				}
			}
		};

		// Token: 0x04012D70 RID: 77168
		private const float LARGE_BUILDING_TEXTURE_FACTOR = 0.5f;

		// Token: 0x04012D71 RID: 77169
		private const float LARGE_BUILDING_TEXTURE_FACTOR_LOW_MEMORY = 0.2f;

		// Token: 0x04012D72 RID: 77170
		private const float HUGE_BUILDING_TEXTURE_FACTOR = 0.3f;

		// Token: 0x04012D73 RID: 77171
		private const float HUGE_BUILDING_TEXTURE_FACTOR_LOW_MEMORY = 0.15f;

		// Token: 0x04012D74 RID: 77172
		private const float HUGE_ROC_TEXTURE_FACTOR = 0.3f;

		// Token: 0x04012D75 RID: 77173
		private const float HUGE_ROC_TEXTURE_FACTOR_LOW_MEMORY = 0.15f;

		// Token: 0x04012D76 RID: 77174
		private const int UNCLASSIFIED_TEXTURE_FACTOR = 1;

		// Token: 0x04012D77 RID: 77175
		private const float UNCLASSIFIED_TEXTURE_FACTOR_LOW_MEMORY = 0.8f;

		// Token: 0x04012D78 RID: 77176
		private const int IOS_STREAMING_POOL_SIZE_LOW_MEMORY = 100;

		// Token: 0x04012D79 RID: 77177
		private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_LOW_MEMORY = 50;

		// Token: 0x04012D7A RID: 77178
		private const int IOS_STREAMING_POOL_SIZE_IN_LOADING_LOW_MEMORY = 50;

		// Token: 0x04012D7B RID: 77179
		private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_IN_LOADING_LOW_MEMORY = 20;

		// Token: 0x04012D7C RID: 77180
		private const string CHAO_YUE_HUI_DATA_LAYER = "DataLayerRuntime_DLTask_37ZCZYH01";

		// Token: 0x04012D7D RID: 77181
		private const string RENDER_QUALITY_CVAR = "sg.KuroRenderQuality";

		// Token: 0x04012D7E RID: 77182
		private const float CHAO_YUE_HUI_SCREEN_PERCENTAGE = 60f;

		// Token: 0x04012D7F RID: 77183
		[StaticVariableRuleIgnore]
		private static readonly string[] ChaoYueHuiQualityCVars = new string[]
		{
			"sg.KuroRenderQuality",
			"sg.PostProcessQuality",
			"sg.EffectsQuality",
			"sg.ShadowQuality",
			"r.ScreenPercentage"
		};

		// Token: 0x04012D80 RID: 77184
		private bool bEnableChaoYueHuiQuality;

		// Token: 0x04012D81 RID: 77185
		private bool bCanRefreshChaoYueHuiQuality;

		// Token: 0x04012D82 RID: 77186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, float> QualityValuesBeforeChaoYueHui;

		// Token: 0x04012D83 RID: 77187
		[Nullable(2)]
		private static LowMemoryScalabilityController _Instance;
	}
}
