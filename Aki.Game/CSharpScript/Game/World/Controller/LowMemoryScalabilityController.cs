using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02004538 RID: 17720
	[NullableContext(1)]
	[Nullable(0)]
	public class LowMemoryScalabilityController : ControllerBase
	{
		// Token: 0x1700753F RID: 30015
		// (get) Token: 0x0602DC92 RID: 187538 RVA: 0x00A85A7D File Offset: 0x00A83C7D
		private bool IsMobileLowMemoryDevice
		{
			get
			{
				return Info.Instance.IsLowMemoryDevice;
			}
		}

		// Token: 0x0602DC93 RID: 187539 RVA: 0x00A85A8C File Offset: 0x00A83C8C
		protected override bool OnInit()
		{
			if (!this.IsMobileLowMemoryDevice)
			{
				return true;
			}
			EventSystem.Instance.Add(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			EventSystem.Instance.Add(EEventName.OnManuallyClearStreamingPool, new Action(this.OnManuallyClearStreamingPool));
			EventSystem.Instance.Add(EEventName.OnManuallyResetStreamingPool, new Action(this.OnManuallyResetStreamingPool));
			EventSystem.Instance.Add<float>(EEventName.LoadingRangeScaleChanged, new Action<float>(this.OnLoadingRangeScaleChanged));
			if (this.IsMobileLowMemoryDevice)
			{
				this.InitMobileLowMemorySettings();
			}
			return true;
		}

		// Token: 0x0602DC94 RID: 187540 RVA: 0x00A85B5C File Offset: 0x00A83D5C
		protected override bool OnClear()
		{
			if (!this.IsMobileLowMemoryDevice)
			{
				return true;
			}
			EventSystem.Instance.Remove(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
			EventSystem.Instance.Remove(EEventName.OnManuallyClearStreamingPool, new Action(this.OnManuallyClearStreamingPool));
			EventSystem.Instance.Remove(EEventName.OnManuallyResetStreamingPool, new Action(this.OnManuallyResetStreamingPool));
			EventSystem.Instance.Remove<float>(EEventName.LoadingRangeScaleChanged, new Action<float>(this.OnLoadingRangeScaleChanged));
			UKuroBodySetupLibrary.EmptyClearWpBodySetupBlackList();
			return true;
		}

		// Token: 0x0602DC95 RID: 187541 RVA: 0x00A85C24 File Offset: 0x00A83E24
		private void InitMobileLowMemorySettings()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.XY, "Init Mobile Low Memory Settings", default(ReadOnlySpan<ValueTuple<string, object>>));
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.UnloadHLODCellWhenAllHLODActorHidden 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.EnableHLODCellMappingOptimization 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroSurfaceRipple.Enable 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroInstanceGrassInteraction.Enabled 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroWeaponEnvInteraction.Enabled 0", null);
		}

		// Token: 0x0602DC96 RID: 187542 RVA: 0x00A85C9D File Offset: 0x00A83E9D
		private void OnEndTravelMap()
		{
			this.ScaleStreamingTextureOnEndTravelMap();
			this.OptimizeStreamingOnEndTravelMap();
			this.OptimizeStreamingGridRangeOnEndTravelMap();
		}

		// Token: 0x0602DC97 RID: 187543 RVA: 0x00A85CB4 File Offset: 0x00A83EB4
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

		// Token: 0x0602DC98 RID: 187544 RVA: 0x00A85D04 File Offset: 0x00A83F04
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

		// Token: 0x0602DC99 RID: 187545 RVA: 0x00A85D58 File Offset: 0x00A83F58
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

		// Token: 0x0602DC9A RID: 187546 RVA: 0x00A85E5D File Offset: 0x00A8405D
		private void OptimizeStreamingOnEndTravelMap()
		{
			if (this.IsSpecialLowMemoryMap())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "s.ContinuouslyIncrementalGCWhileLevelsPendingPurge 1", null);
			}
			if (!GameSettingsManager.Instance.ReApply(EFunction.LOADINGRANGESCALELEVEL, EGameSettingsApplyReason.AnyTime, false))
			{
				this.OnLoadingRangeScaleChanged(1f);
			}
		}

		// Token: 0x0602DC9B RID: 187547 RVA: 0x00A85E95 File Offset: 0x00A84095
		private void OnWorldDone()
		{
			this.OnEndTravelMap();
			WorldController.Instance.ManuallyResetStreamingPool();
		}

		// Token: 0x0602DC9C RID: 187548 RVA: 0x00A85EA7 File Offset: 0x00A840A7
		private void OnChangeArea(int? preAreaId, int curAreaId)
		{
			this.OnWorldDone();
		}

		// Token: 0x0602DC9D RID: 187549 RVA: 0x00A85EB0 File Offset: 0x00A840B0
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

		// Token: 0x0602DC9E RID: 187550 RVA: 0x00A85F34 File Offset: 0x00A84134
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

		// Token: 0x0602DC9F RID: 187551 RVA: 0x00A85FE4 File Offset: 0x00A841E4
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

		// Token: 0x0602DCA0 RID: 187552 RVA: 0x00A86092 File Offset: 0x00A84292
		private void OnLoadingRangeScaleChanged(float value)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "wp.Runtime.PlannedLoadingRangeScaleExtra 0", null);
		}

		// Token: 0x17007540 RID: 30016
		// (get) Token: 0x0602DCA1 RID: 187553 RVA: 0x00A860A4 File Offset: 0x00A842A4
		public static LowMemoryScalabilityController Instance
		{
			get
			{
				return LowMemoryScalabilityController._Instance;
			}
		}

		// Token: 0x0602DCA2 RID: 187554 RVA: 0x00A860AB File Offset: 0x00A842AB
		public static LowMemoryScalabilityController GetOrCreateInstance()
		{
			if (LowMemoryScalabilityController._Instance == null)
			{
				LowMemoryScalabilityController.CreateInstance();
			}
			return LowMemoryScalabilityController._Instance;
		}

		// Token: 0x0602DCA3 RID: 187555 RVA: 0x00A860BF File Offset: 0x00A842BF
		public static bool CreateInstance()
		{
			if (LowMemoryScalabilityController._Instance != null)
			{
				return true;
			}
			LowMemoryScalabilityController._Instance = new LowMemoryScalabilityController();
			return true;
		}

		// Token: 0x0602DCA4 RID: 187556 RVA: 0x00A860D5 File Offset: 0x00A842D5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCA5 RID: 187557 RVA: 0x00A860D7 File Offset: 0x00A842D7
		public static void ResetStaticDefaultValue()
		{
			LowMemoryScalabilityController._Instance = null;
		}

		// Token: 0x0602DCA6 RID: 187558 RVA: 0x00A860E0 File Offset: 0x00A842E0
		static LowMemoryScalabilityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LowMemoryScalabilityController.CreateStaticDefaultValue), new Action(LowMemoryScalabilityController.ResetStaticDefaultValue));
		}

		// Token: 0x04018739 RID: 100153
		private const int XUEYUAN_MAPID = 906;

		// Token: 0x0401873A RID: 100154
		private const int WXSG_MAPID = 912;

		// Token: 0x0401873B RID: 100155
		private const int MAIN_WORLD_MAPID = 8;

		// Token: 0x0401873C RID: 100156
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

		// Token: 0x0401873D RID: 100157
		private const float LARGE_BUILDING_TEXTURE_FACTOR = 0.5f;

		// Token: 0x0401873E RID: 100158
		private const float LARGE_BUILDING_TEXTURE_FACTOR_LOW_MEMORY = 0.2f;

		// Token: 0x0401873F RID: 100159
		private const float HUGE_BUILDING_TEXTURE_FACTOR = 0.3f;

		// Token: 0x04018740 RID: 100160
		private const float HUGE_BUILDING_TEXTURE_FACTOR_LOW_MEMORY = 0.15f;

		// Token: 0x04018741 RID: 100161
		private const float HUGE_ROC_TEXTURE_FACTOR = 0.3f;

		// Token: 0x04018742 RID: 100162
		private const float HUGE_ROC_TEXTURE_FACTOR_LOW_MEMORY = 0.15f;

		// Token: 0x04018743 RID: 100163
		private const int UNCLASSIFIED_TEXTURE_FACTOR = 1;

		// Token: 0x04018744 RID: 100164
		private const float UNCLASSIFIED_TEXTURE_FACTOR_LOW_MEMORY = 0.8f;

		// Token: 0x04018745 RID: 100165
		private const int IOS_STREAMING_POOL_SIZE_LOW_MEMORY = 100;

		// Token: 0x04018746 RID: 100166
		private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_LOW_MEMORY = 50;

		// Token: 0x04018747 RID: 100167
		private const int IOS_STREAMING_POOL_SIZE_IN_LOADING_LOW_MEMORY = 50;

		// Token: 0x04018748 RID: 100168
		private const int IOS_STREAMING_POOL_SIZE_FOR_MESHES_IN_LOADING_LOW_MEMORY = 20;

		// Token: 0x04018749 RID: 100169
		[Nullable(2)]
		private static LowMemoryScalabilityController _Instance;
	}
}
