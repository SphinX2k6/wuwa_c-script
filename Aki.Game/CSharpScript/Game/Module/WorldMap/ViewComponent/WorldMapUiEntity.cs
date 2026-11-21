using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue;
using CSharpScript.Game.Module.Map.View.SubView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036EA RID: 14058
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapUiEntity : MapEntity
	{
		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x06024941 RID: 149825 RVA: 0x00A552F9 File Offset: 0x00A534F9
		// (set) Token: 0x06024942 RID: 149826 RVA: 0x00A55301 File Offset: 0x00A53501
		[Nullable(2)]
		public UiViewBase OwnerView { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x06024943 RID: 149827 RVA: 0x00A5530A File Offset: 0x00A5350A
		// (set) Token: 0x06024944 RID: 149828 RVA: 0x00A55312 File Offset: 0x00A53512
		[Nullable(2)]
		public BaseMap Map
		{
			[NullableContext(2)]
			get
			{
				return this._mapInner;
			}
			[NullableContext(2)]
			set
			{
				this._mapInner = value;
				if (value == null)
				{
					return;
				}
				this.RecalculateMapSize();
			}
		}

		// Token: 0x06024945 RID: 149829 RVA: 0x00A55328 File Offset: 0x00A53528
		public void RecalculateMapSize()
		{
			MapTileMgr mapTileMgr = this.Map.MapTileMgr;
			Vector2D vector2D = (mapTileMgr != null) ? mapTileMgr.GetMapSizeOverride() : null;
			if (vector2D != null)
			{
				this.MapSize = vector2D;
				return;
			}
			UUIItem rootItem = this.Map.GetRootItem();
			this.MapSize = Vector2D.Create((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x06024946 RID: 149830 RVA: 0x00A55380 File Offset: 0x00A53580
		// (set) Token: 0x06024947 RID: 149831 RVA: 0x00A553B1 File Offset: 0x00A535B1
		public FVector2D ViewPortSize
		{
			get
			{
				return this.PropertyMap.TryGet(0, Vector2D.ZeroVector, true).AsT2;
			}
			set
			{
				this.PropertyMap.Set(0, value);
			}
		}

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x06024948 RID: 149832 RVA: 0x00A553CC File Offset: 0x00A535CC
		// (set) Token: 0x06024949 RID: 149833 RVA: 0x00A5540F File Offset: 0x00A5360F
		public Vector2D OutOfViewPortSize
		{
			get
			{
				return this.PropertyMap.TryGet(1, Vector2D.Create(0.0, 0.0), true).AsT1;
			}
			set
			{
				this.PropertyMap.Set(1, value);
			}
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x0602494A RID: 149834 RVA: 0x00A5542C File Offset: 0x00A5362C
		// (set) Token: 0x0602494B RID: 149835 RVA: 0x00A5546F File Offset: 0x00A5366F
		public Vector2D MapSize
		{
			get
			{
				return this.PropertyMap.TryGet(2, Vector2D.Create(0.0, 0.0), true).AsT1;
			}
			set
			{
				this.PropertyMap.Set(2, value);
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x0602494C RID: 149836 RVA: 0x00A55489 File Offset: 0x00A53689
		// (set) Token: 0x0602494D RID: 149837 RVA: 0x00A55491 File Offset: 0x00A53691
		public UKuroWorldMapUIParams UiParams
		{
			get
			{
				return this._uiParamsInner;
			}
			set
			{
				this._uiParamsInner = value;
			}
		}

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x0602494E RID: 149838 RVA: 0x00A5549A File Offset: 0x00A5369A
		// (set) Token: 0x0602494F RID: 149839 RVA: 0x00A554A2 File Offset: 0x00A536A2
		[Nullable(2)]
		public IWorldMapViewOpenParams OpenParams { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x06024950 RID: 149840 RVA: 0x00A554AC File Offset: 0x00A536AC
		// (set) Token: 0x06024951 RID: 149841 RVA: 0x00A554FB File Offset: 0x00A536FB
		public int MapId
		{
			get
			{
				PropertyMap<OneOf<int, string>, OneOf<Vector2D, FVector2D, int>> propertyMap = this.PropertyMap;
				OneOf<int, string> key = 3;
				IWorldMapViewOpenParams openParams = this.OpenParams;
				return propertyMap.TryGet(key, ((openParams != null) ? openParams.MapId : null).GetValueOrDefault(8), true).AsT3;
			}
			set
			{
				this.PropertyMap.Set(3, value);
			}
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x06024952 RID: 149842 RVA: 0x00A55518 File Offset: 0x00A53718
		public bool IsInPlayerMap
		{
			get
			{
				MapModel instance = MapModel.Instance;
				AreaConfig instance2 = AreaConfig.Instance;
				AreaModel instance3 = AreaModel.Instance;
				int currentAreaId = instance3.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.Extra));
				if (currentAreaId != 0)
				{
					Area? areaInfo = instance2.GetAreaInfo(currentAreaId);
					if (areaInfo != null && areaInfo.GetValueOrDefault().IsPlayerPosNeedCheck && areaInfo.Value.MapConfigId == this.MapId)
					{
						return true;
					}
				}
				int currentAreaId2 = instance3.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
				if (currentAreaId2 != 0)
				{
					Area? areaInfo2 = instance2.GetAreaInfo(currentAreaId2);
					if (areaInfo2 != null)
					{
						return areaInfo2.Value.MapConfigId == this.MapId;
					}
				}
				int? lastHighLevelArea = instance.LastHighLevelArea;
				if (lastHighLevelArea == null)
				{
					return instance.CurrentWorldMapConfigId == this.MapId;
				}
				Area? areaInfo3 = instance2.GetAreaInfo(instance2.GetLevelOneAreaId(lastHighLevelArea.Value));
				if (areaInfo3 != null)
				{
					return areaInfo3.Value.MapConfigId == this.MapId;
				}
				return instance.CurrentWorldMapConfigId == this.MapId;
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x06024953 RID: 149843 RVA: 0x00A55628 File Offset: 0x00A53828
		public bool IsInPlayerGravity
		{
			get
			{
				EMapGravityDirection currentPlayerGravity = MapModel.Instance.CurrentPlayerGravity;
				EMapGravityDirection? worldMapSelectGravity = WorldMapModel.Instance.WorldMapSelectGravity;
				return currentPlayerGravity == worldMapSelectGravity.GetValueOrDefault() & worldMapSelectGravity != null;
			}
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x06024954 RID: 149844 RVA: 0x00A5565B File Offset: 0x00A5385B
		// (set) Token: 0x06024955 RID: 149845 RVA: 0x00A55663 File Offset: 0x00A53863
		[Nullable(2)]
		public TWorldMapPlaySequenceFunction BoxTransitionPlaySequenceFunction { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x06024956 RID: 149846 RVA: 0x00A5566C File Offset: 0x00A5386C
		// (set) Token: 0x06024957 RID: 149847 RVA: 0x00A55674 File Offset: 0x00A53874
		[Nullable(2)]
		public UUITexture BoxScreenCaptureTexture { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x06024958 RID: 149848 RVA: 0x00A5567D File Offset: 0x00A5387D
		public WorldMapSecondaryUiComponent SecondaryUiComponent
		{
			get
			{
				return base.GetComponent<WorldMapSecondaryUiComponent>(EMapComponent.WorldMapSecondaryUi);
			}
		}

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x06024959 RID: 149849 RVA: 0x00A55686 File Offset: 0x00A53886
		public WorldMapInteractComponent InteractComponent
		{
			get
			{
				return base.GetComponent<WorldMapInteractComponent>(EMapComponent.WorldMapInteract);
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x0602495A RID: 149850 RVA: 0x00A5568F File Offset: 0x00A5388F
		public WorldMapMoveComponent MoveComponent
		{
			get
			{
				return base.GetComponent<WorldMapMoveComponent>(EMapComponent.WorldMapMove);
			}
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x0602495B RID: 149851 RVA: 0x00A55698 File Offset: 0x00A53898
		public WorldMapScaleComponent ScaleComponent
		{
			get
			{
				return base.GetComponent<WorldMapScaleComponent>(EMapComponent.WorldMapScale);
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x0602495C RID: 149852 RVA: 0x00A556A1 File Offset: 0x00A538A1
		public WorldMapPlayerComponent PlayerComponent
		{
			get
			{
				return base.GetComponent<WorldMapPlayerComponent>(EMapComponent.WorldMapPlayer);
			}
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x0602495D RID: 149853 RVA: 0x00A556AA File Offset: 0x00A538AA
		public WorldMapMultiFloorComponent MultiFloorComponent
		{
			get
			{
				return base.GetComponent<WorldMapMultiFloorComponent>(EMapComponent.WorldMapMultiFloor);
			}
		}

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x0602495E RID: 149854 RVA: 0x00A556B3 File Offset: 0x00A538B3
		public WorldMapQuickNavigateComponent QuickNavigateComponent
		{
			get
			{
				return base.GetComponent<WorldMapQuickNavigateComponent>(EMapComponent.WorldMapQuickNavigate);
			}
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x0602495F RID: 149855 RVA: 0x00A556BC File Offset: 0x00A538BC
		public WorldMapStreamingComponent WorldMapStreamingComponent
		{
			get
			{
				return base.GetComponent<WorldMapStreamingComponent>(EMapComponent.WorldMapStreaming);
			}
		}

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x06024960 RID: 149856 RVA: 0x00A556C5 File Offset: 0x00A538C5
		public WorldMapAlterMapComponent WorldMapAlterMapComponent
		{
			get
			{
				return base.GetComponent<WorldMapAlterMapComponent>(EMapComponent.WorldMapAlterMap);
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x06024961 RID: 149857 RVA: 0x00A556CF File Offset: 0x00A538CF
		public WorldMapExtraUiPanelComponent WorldMapExtraUiPanelComponent
		{
			get
			{
				return base.GetComponent<WorldMapExtraUiPanelComponent>(EMapComponent.WorldMapExtraUiPanel);
			}
		}

		// Token: 0x06024962 RID: 149858 RVA: 0x00A556D9 File Offset: 0x00A538D9
		protected override void OnInit()
		{
			this.Reset(true);
		}

		// Token: 0x06024963 RID: 149859 RVA: 0x00A556E4 File Offset: 0x00A538E4
		public void Reset(bool focus = true)
		{
			this.ScaleComponent.Initialize();
			this.InitSelfPlayerMark();
			if (!this.SecondaryUiComponent.IsSecondaryUiOpening)
			{
				IWorldMapViewOpenParams openParams = this.OpenParams;
				if (openParams != null)
				{
					bool? isNotFocusTween = openParams.IsNotFocusTween;
					if (isNotFocusTween != null && isNotFocusTween.GetValueOrDefault())
					{
						MarkItem markItem = this.Map.GetMarkItem(this.OpenParams.MarkType, this.OpenParams.MarkId.Value);
						if (markItem != null)
						{
							this.OpenParams.StartScale = new float?(this.ScaleComponent.MapScale);
							this.OpenParams.StartWorldPosition = Vector2D.Create(-markItem.UiPosition.X * (double)this.OpenParams.StartScale.Value, -markItem.UiPosition.Y * (double)this.OpenParams.StartScale.Value);
						}
					}
				}
				IWorldMapViewOpenParams openParams2 = this.OpenParams;
				if (openParams2 != null && openParams2.StartScale != null)
				{
					this.ScaleComponent.SetMapScale(this.OpenParams.StartScale.Value, EMapScaleSetType.Other, false, true);
				}
				IWorldMapViewOpenParams openParams3 = this.OpenParams;
				if (((openParams3 != null) ? openParams3.StartWorldPosition : null) == null)
				{
					IWorldMapViewOpenParams openParams4 = this.OpenParams;
					if (((openParams4 != null) ? openParams4.DebugWorldPosition : null) == null)
					{
						if (!MapModel.Instance.CurrentInWorld)
						{
							this.SetPlayerInstancePosition(focus);
							goto IL_206;
						}
						if (!this.IsInPlayerMap)
						{
							goto IL_206;
						}
						this.UpdateSelfPlayerMark();
						if (focus)
						{
							this.MoveComponent.FocusPlayer(this.PlayerComponent.PlayerUiPosition, false, EClampType.ClampToSafeArea);
							goto IL_206;
						}
						goto IL_206;
					}
				}
				if (focus)
				{
					IWorldMapViewOpenParams openParams5 = this.OpenParams;
					if (((openParams5 != null) ? openParams5.StartWorldPosition : null) != null)
					{
						this.MoveComponent.SetMapPosition(this.OpenParams.StartWorldPosition, false, EClampType.NotClamp, null, null, true, false);
					}
					else
					{
						IWorldMapViewOpenParams openParams6 = this.OpenParams;
						if (((openParams6 != null) ? openParams6.DebugWorldPosition : null) != null)
						{
							this.MoveComponent.PushMapByUiPosition(this.OpenParams.DebugWorldPosition, false, EClampType.ClampToDangerousArea);
						}
					}
				}
			}
			IL_206:
			this.WorldMapStreamingComponent.BindAll(this.Map.GetAllMapTileItems());
			this.WorldMapStreamingComponent.Update();
			this.OnPlayerMarkPositionChanged(0, null);
			this.UpdateMarkItems(null);
			this.SecondaryUiComponent.AllSecondaryPanelsUpdateMap();
		}

		// Token: 0x06024964 RID: 149860 RVA: 0x00A5593C File Offset: 0x00A53B3C
		public void RegisterComponents()
		{
			this.ViewPortSize = LGuiExtension.GetUiViewportSize();
			base.AddComponent<WorldMapExtraUiPanelComponent>(EMapComponent.WorldMapExtraUiPanel);
			base.AddComponent<WorldMapSecondaryUiComponent>(EMapComponent.WorldMapSecondaryUi);
			base.AddComponent<WorldMapInteractComponent>(EMapComponent.WorldMapInteract);
			base.AddComponent<WorldMapMoveComponent>(EMapComponent.WorldMapMove);
			base.AddComponent<WorldMapPlayerComponent>(EMapComponent.WorldMapPlayer);
			base.AddComponent<WorldMapMultiFloorComponent>(EMapComponent.WorldMapMultiFloor);
			base.AddComponent<WorldMapQuickNavigateComponent>(EMapComponent.WorldMapQuickNavigate);
			base.AddComponent<WorldMapStreamingComponent>(EMapComponent.WorldMapStreaming);
			base.AddComponent<WorldMapAlterMapComponent>(EMapComponent.WorldMapAlterMap);
			base.AddComponent<WorldMapScaleComponent>(EMapComponent.WorldMapScale).ScaleChangeEvent = new WorldMapScaleComponent.TScaleChangeEvent(this.OnWorldMapScaleChanged);
			EventSystem.Instance.Add(EEventName.OnMarkItemTrackStateChange, new Action<MarkItem>(this.OnMarkItemTrackStateChanged));
			EventSystem.Instance.Add(EEventName.OnMarkItemAutoPilotTrackStateChange, new Action<EMarkType, int>(this.OnMarkItemAutoPilotTrackStateChanged));
			EventSystem.Instance.Add<EMarkType, int, bool>(EEventName.MarkForceVisibleChanged, new Action<EMarkType, int, bool>(this.OnMarkForceVisibleChanged));
			EventSystem.Instance.Add<int, global::Vector>(EEventName.ScenePlayerLocationChanged, new Action<int, global::Vector>(this.OnPlayerMarkPositionChanged));
			EventSystem.Instance.Add(EEventName.OnMapMarkTaskComplete, new Action<EMarkType, int>(this.OnMarkTaskComplete));
			EventSystem.Instance.Add(EEventName.WorldMapPositionChanged, new Action(this.OnWorldMapPositionChanged));
			EventSystem.Instance.Add(EEventName.WorldMapUpdateMultiMap, new Action(this.OnWorldMapUpdateMultiMapChanged));
			EventSystem.Instance.Add<int>(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Add<EWorldMapScaleTier, EMapScaleSetType>(EEventName.WorldMapScaleTierChanged, new Action<EWorldMapScaleTier, EMapScaleSetType>(this.OnWorldMapScaleTierChanged));
		}

		// Token: 0x06024965 RID: 149861 RVA: 0x00A55AB4 File Offset: 0x00A53CB4
		protected override void OnDispose()
		{
			EventSystem.Instance.Remove(EEventName.OnMarkItemTrackStateChange, new Action<MarkItem>(this.OnMarkItemTrackStateChanged));
			EventSystem.Instance.Remove(EEventName.OnMarkItemAutoPilotTrackStateChange, new Action<EMarkType, int>(this.OnMarkItemAutoPilotTrackStateChanged));
			EventSystem.Instance.Remove(EEventName.MarkForceVisibleChanged, new Action<EMarkType, int, bool>(this.OnMarkForceVisibleChanged));
			EventSystem.Instance.Remove(EEventName.ScenePlayerLocationChanged, new <>f__AnonymousDelegate9<int, global::Vector>(this.OnPlayerMarkPositionChanged));
			EventSystem.Instance.Remove(EEventName.OnMapMarkTaskComplete, new Action<EMarkType, int>(this.OnMarkTaskComplete));
			EventSystem.Instance.Remove(EEventName.WorldMapPositionChanged, new Action(this.OnWorldMapPositionChanged));
			EventSystem.Instance.Remove(EEventName.WorldMapUpdateMultiMap, new Action(this.OnWorldMapUpdateMultiMapChanged));
			EventSystem.Instance.Remove(EEventName.WorldMapSelectMultiMap, new Action<int>(this.OnSubMapChanged));
			EventSystem.Instance.Remove(EEventName.WorldMapScaleTierChanged, new Action<EWorldMapScaleTier, EMapScaleSetType>(this.OnWorldMapScaleTierChanged));
			this.MapGamePlayRequestPreemptiveFrameQueue.Dispose();
			this.MapUpdateTaskFrameQueue.Dispose();
			this.Map = null;
			this.IsBoxTransitioning = false;
		}

		// Token: 0x06024966 RID: 149862 RVA: 0x00A55BE1 File Offset: 0x00A53DE1
		protected override void OnTick()
		{
			BaseMap map = this.Map;
			if (map != null)
			{
				map.Tick();
			}
			this.MapGamePlayRequestPreemptiveFrameQueue.Process();
			this.WorldMapStreamingComponent.RefreshViewportCache();
			this.MapUpdateTaskFrameQueue.Process();
		}

		// Token: 0x06024967 RID: 149863 RVA: 0x00A55C15 File Offset: 0x00A53E15
		public void CancelAllTasks()
		{
			this.MapGamePlayRequestPreemptiveFrameQueue.Dispose();
			this.MapUpdateTaskFrameQueue.Dispose();
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x06024968 RID: 149864 RVA: 0x00A55C2D File Offset: 0x00A53E2D
		// (set) Token: 0x06024969 RID: 149865 RVA: 0x00A55C35 File Offset: 0x00A53E35
		public bool IsBoxTransitioning { get; private set; }

		// Token: 0x0602496A RID: 149866 RVA: 0x00A55C40 File Offset: 0x00A53E40
		private void OnWorldMapScaleTierChanged(EWorldMapScaleTier tier, EMapScaleSetType type)
		{
			bool flag = type == EMapScaleSetType.Initialize || type == EMapScaleSetType.Navigate;
			if (flag)
			{
				return;
			}
			this.SwitchTierAsync(tier, null).Forget();
		}

		// Token: 0x0602496B RID: 149867 RVA: 0x00A55C6C File Offset: 0x00A53E6C
		[NullableContext(2)]
		public UniTask NavigateSwitchTierAsync(EWorldMapScaleTier tier, int areaId, MarkItem landingMark)
		{
			WorldMapUiEntity.<NavigateSwitchTierAsync>d__78 <NavigateSwitchTierAsync>d__;
			<NavigateSwitchTierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NavigateSwitchTierAsync>d__.<>4__this = this;
			<NavigateSwitchTierAsync>d__.tier = tier;
			<NavigateSwitchTierAsync>d__.areaId = areaId;
			<NavigateSwitchTierAsync>d__.landingMark = landingMark;
			<NavigateSwitchTierAsync>d__.<>1__state = -1;
			<NavigateSwitchTierAsync>d__.<>t__builder.Start<WorldMapUiEntity.<NavigateSwitchTierAsync>d__78>(ref <NavigateSwitchTierAsync>d__);
			return <NavigateSwitchTierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602496C RID: 149868 RVA: 0x00A55CC7 File Offset: 0x00A53EC7
		[NullableContext(2)]
		private UniTask SwitchTierAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			this.ScaleComponent.OnScaleTierChanged();
			return this.PlayBoxTransitionAsync(tier, landingMark);
		}

		// Token: 0x0602496D RID: 149869 RVA: 0x00A55CDC File Offset: 0x00A53EDC
		[NullableContext(2)]
		private UniTask PlayBoxTransitionAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			WorldMapUiEntity.<PlayBoxTransitionAsync>d__80 <PlayBoxTransitionAsync>d__;
			<PlayBoxTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBoxTransitionAsync>d__.<>4__this = this;
			<PlayBoxTransitionAsync>d__.tier = tier;
			<PlayBoxTransitionAsync>d__.landingMark = landingMark;
			<PlayBoxTransitionAsync>d__.<>1__state = -1;
			<PlayBoxTransitionAsync>d__.<>t__builder.Start<WorldMapUiEntity.<PlayBoxTransitionAsync>d__80>(ref <PlayBoxTransitionAsync>d__);
			return <PlayBoxTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602496E RID: 149870 RVA: 0x00A55D30 File Offset: 0x00A53F30
		[NullableContext(2)]
		private UniTask RebuildTilesAndMoveAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			WorldMapUiEntity.<RebuildTilesAndMoveAsync>d__81 <RebuildTilesAndMoveAsync>d__;
			<RebuildTilesAndMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildTilesAndMoveAsync>d__.<>4__this = this;
			<RebuildTilesAndMoveAsync>d__.tier = tier;
			<RebuildTilesAndMoveAsync>d__.landingMark = landingMark;
			<RebuildTilesAndMoveAsync>d__.<>1__state = -1;
			<RebuildTilesAndMoveAsync>d__.<>t__builder.Start<WorldMapUiEntity.<RebuildTilesAndMoveAsync>d__81>(ref <RebuildTilesAndMoveAsync>d__);
			return <RebuildTilesAndMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602496F RID: 149871 RVA: 0x00A55D84 File Offset: 0x00A53F84
		private void SetBoxTransitionMarkLayerActive(bool active)
		{
			BaseMap map = this.Map;
			if (map == null)
			{
				return;
			}
			map.MarkContainer.SetUIActive(active);
			AutoPilotLine autoPilotLine = map.AutoPilotLine;
			if (autoPilotLine != null)
			{
				autoPilotLine.SetUiActive(active);
			}
			if (active)
			{
				this.InitSelfPlayerMark();
				this.UpdateMarkItems(new bool?(true));
				MapRangePanel mapRangePanel = map.MapRangePanel;
				if (mapRangePanel == null)
				{
					return;
				}
				mapRangePanel.CheckExploreMarkRangeInfo();
				return;
			}
			else
			{
				map.SelfPlayerNode.SetUIActive(false);
				MapRangePanel mapRangePanel2 = map.MapRangePanel;
				if (mapRangePanel2 == null)
				{
					return;
				}
				mapRangePanel2.SetRangeComponentHide(false).Forget();
				return;
			}
		}

		// Token: 0x06024970 RID: 149872 RVA: 0x00A55E04 File Offset: 0x00A54004
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private static UniTask<UTexture2D> CaptureBoxTransitionShotAsync()
		{
			WorldMapUiEntity.<CaptureBoxTransitionShotAsync>d__83 <CaptureBoxTransitionShotAsync>d__;
			<CaptureBoxTransitionShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture2D>.Create();
			<CaptureBoxTransitionShotAsync>d__.<>1__state = -1;
			<CaptureBoxTransitionShotAsync>d__.<>t__builder.Start<WorldMapUiEntity.<CaptureBoxTransitionShotAsync>d__83>(ref <CaptureBoxTransitionShotAsync>d__);
			return <CaptureBoxTransitionShotAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024971 RID: 149873 RVA: 0x00A55E40 File Offset: 0x00A54040
		private void MoveToBoxTierArea(EWorldMapScaleTier tier)
		{
			IReadOnlyList<int> displayAreaList = WorldMapModel.Instance.GetDisplayAreaList(this.MapId);
			if (displayAreaList != null)
			{
				foreach (int areaId in displayAreaList)
				{
					Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
					if (areaInfo != null && areaInfo.Value.DeliveryMarkId != 0)
					{
						MarkItem markItem = this.Map.GetMarkItem((EMarkType)areaInfo.Value.DeliveryMarkType, areaInfo.Value.DeliveryMarkId);
						if (markItem != null)
						{
							this.MoveComponent.PushMap(markItem, false, EClampType.ClampToDangerousArea);
							return;
						}
					}
				}
			}
			ELogAuthor author = ELogAuthor.LYX;
			string message = "[地图系统]匣子切档没有可落点的区域标记";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("档位", tier);
			MapLogger.Warn(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06024972 RID: 149874 RVA: 0x00A55F28 File Offset: 0x00A54128
		private void OnWorldMapScaleChanged(float oldScale, float newScale, EMapScaleSetType type)
		{
			if (this.ClickedItem == null)
			{
				Vector2D targetPosition = null;
				Vector2D vector2D = Vector2D.Create(this.Map.GetRootItem().GetAnchorOffset());
				Vector2D tweenTarget = this.MoveComponent.TweenTarget;
				Vector2D vector2D2 = null;
				if (type - EMapScaleSetType.ZoomButton <= 4)
				{
					vector2D2 = this.GetScaleAnchoredPosition();
				}
				float num = (oldScale == 0f) ? 1f : (newScale / oldScale);
				Vector2D focusPosition;
				if (vector2D2 != null)
				{
					focusPosition = vector2D.Subtraction(vector2D2, vector2D).Multiply((double)num, vector2D).Addition(vector2D2, vector2D);
					if (tweenTarget != null)
					{
						targetPosition = tweenTarget.Subtraction(vector2D2, tweenTarget).Multiply((double)num, tweenTarget).Addition(vector2D2, tweenTarget);
					}
				}
				else
				{
					focusPosition = vector2D.Multiply((double)num, vector2D);
					if (tweenTarget != null)
					{
						targetPosition = tweenTarget.Multiply((double)num, vector2D);
					}
				}
				this.MoveComponent.SetMapPositionCauseByScaling(focusPosition, targetPosition, EClampType.ClampToDangerousArea);
			}
			else
			{
				this.MoveComponent.PushMap(this.ClickedItem, false, EClampType.ClampToDangerousArea);
			}
			BaseMap map = this.Map;
			if (map == null)
			{
				return;
			}
			AutoPilotLine autoPilotLine = map.AutoPilotLine;
			if (autoPilotLine == null)
			{
				return;
			}
			autoPilotLine.RefreshFindPathLine();
		}

		// Token: 0x06024973 RID: 149875 RVA: 0x00A56024 File Offset: 0x00A54224
		[NullableContext(2)]
		private Vector2D GetScaleAnchoredPosition()
		{
			TsBasePlayerController tsBasePlayerController = Global.PlayerController as TsBasePlayerController;
			if (tsBasePlayerController == null)
			{
				return null;
			}
			Vector2D vector2D = null;
			if (Info.Instance.IsInKeyBoard())
			{
				vector2D = Vector2D.Create(tsBasePlayerController.GetCursorPosition());
			}
			else if (Info.Instance.IsInTouch())
			{
				vector2D = this.InteractComponent.MultiTouchOriginCenter;
			}
			if (vector2D == null)
			{
				return null;
			}
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			if (canvasScaler == null)
			{
				return null;
			}
			ULGUICanvasScaler ulguicanvasScaler = canvasScaler;
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			FVector2D fvector2D2 = ulguicanvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
			Vector2D viewportSize = LGuiExtension.GetViewportSize();
			viewportSize.Set((double)fvector2D2.X - viewportSize.X / 2.0, (double)fvector2D2.Y - viewportSize.Y / 2.0);
			return viewportSize;
		}

		// Token: 0x06024974 RID: 149876 RVA: 0x00A560E4 File Offset: 0x00A542E4
		public void InitSelfPlayerMark()
		{
			if (!this.WorldMapExtraUiPanelComponent.IsExtraUiViewOpened)
			{
				bool flag = this.IsInPlayerMap && WorldMapModel.Instance.IsPlayerInDisplayArea(this.MapId);
				UUIItem selfPlayerNode = this.Map.SelfPlayerNode;
				selfPlayerNode.SetUIActive(flag);
				if (flag)
				{
					selfPlayerNode.SetAsLastHierarchy();
				}
				this.UpdateSelfPlayerGravity();
				return;
			}
			BaseMap map = this.Map;
			if (map == null)
			{
				return;
			}
			map.SelfPlayerNode.SetUIActive(this.WorldMapExtraUiPanelComponent.IsShowPlayerMark);
		}

		// Token: 0x06024975 RID: 149877 RVA: 0x00A56160 File Offset: 0x00A54360
		private void UpdateSelfPlayerGravity()
		{
			bool flag = WorldMapModel.Instance.IsGravityMap(this.MapId);
			UUIItem playerArrow = this.Map.PlayerArrow;
			if (flag && !this.IsInPlayerGravity)
			{
				playerArrow.SetAlpha(0.4f);
				this.Map.SetPlayerGravityActive(true, MapModel.Instance.CurrentPlayerGravity);
				return;
			}
			playerArrow.SetAlpha(1f);
			this.Map.SetPlayerGravityActive(false, EMapGravityDirection.Down);
		}

		// Token: 0x06024976 RID: 149878 RVA: 0x00A561D0 File Offset: 0x00A543D0
		public void UpdateSelfPlayerMark()
		{
			if (this.WorldMapExtraUiPanelComponent.IsExtraUiViewOpened && !this.WorldMapExtraUiPanelComponent.IsShowPlayerMark)
			{
				return;
			}
			this.PlayerComponent.UpdatePlayerPosition();
			float playerRotation = this.PlayerComponent.PlayerRotation;
			Vector2D playerUiPosition = this.PlayerComponent.PlayerUiPosition;
			float mapScale = this.ScaleComponent.MapScale;
			UUIItem playerArrow = this.Map.PlayerArrow;
			FRotator frotator = new FRotator(0f, playerRotation, 0f);
			playerArrow.SetUIRelativeRotation(frotator);
			Vector2D mapUiPosition = this.MoveComponent.MapUiPosition;
			Vector2D vector2D = Vector2D.Create();
			playerUiPosition.Multiply((double)mapScale, vector2D).Addition(mapUiPosition, vector2D);
			ValueTuple<Vector2D, bool> valueTuple = this.ClampToMarkEdge(vector2D);
			Vector2D item = valueTuple.Item1;
			bool item2 = valueTuple.Item2;
			UUIItem playerOutOfBoundIndicator = this.Map.PlayerOutOfBoundIndicator;
			if (item2)
			{
				this.PlayerComponent.PlayerOutOfBound = true;
				Vector2D vector2D2 = item.Subtraction(mapUiPosition, item).Division((double)mapScale, item);
				this.Map.SelfPlayerNode.SetAnchorOffset(vector2D2.ToUeVector2D(false));
				float inYaw = (float)(Math.Atan2(vector2D.Y, vector2D.X) * 57.2957763671875 - 90.0);
				UUIItem uuiitem = playerOutOfBoundIndicator;
				frotator = new FRotator(0f, inYaw, 0f);
				uuiitem.SetUIRelativeRotation(frotator);
			}
			else
			{
				this.PlayerComponent.PlayerOutOfBound = false;
				this.Map.SelfPlayerNode.SetAnchorOffset(this.PlayerComponent.PlayerUiPosition.ToUeVector2D(false));
			}
			playerOutOfBoundIndicator.SetUIActive(item2);
		}

		// Token: 0x06024977 RID: 149879 RVA: 0x00A56348 File Offset: 0x00A54548
		private void SetPlayerInstancePosition(bool focus = true)
		{
			this.UpdateSelfPlayerMark();
			if (focus)
			{
				Vector2D lastBigScenePlayerUiPosition = MapUtil.GetLastBigScenePlayerUiPosition();
				this.MoveComponent.FocusPlayer(lastBigScenePlayerUiPosition, false, EClampType.ClampToSafeArea);
			}
		}

		// Token: 0x06024978 RID: 149880 RVA: 0x00A56374 File Offset: 0x00A54574
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<Vector2D, bool> ClampToMarkEdge(Vector2D offset)
		{
			Vector2D markEdgeSize = this.MarkEdgeSize;
			if (Math.Abs(offset.X) < markEdgeSize.X && Math.Abs(offset.Y) < markEdgeSize.Y)
			{
				return new ValueTuple<Vector2D, bool>(offset, false);
			}
			Vector2D vector2D = Vector2D.Create();
			if (Math.Abs(offset.X / offset.Y) > markEdgeSize.X / markEdgeSize.Y)
			{
				offset.Multiply(markEdgeSize.X / Math.Abs(offset.X), vector2D);
			}
			else
			{
				offset.Multiply(markEdgeSize.Y / Math.Abs(offset.Y), vector2D);
			}
			return new ValueTuple<Vector2D, bool>(vector2D, true);
		}

		// Token: 0x06024979 RID: 149881 RVA: 0x00A5641A File Offset: 0x00A5461A
		private void OnMarkItemTrackStateChanged(MarkItem markItem)
		{
			if (!markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, true);
			}
		}

		// Token: 0x0602497A RID: 149882 RVA: 0x00A5642C File Offset: 0x00A5462C
		private void OnMarkItemAutoPilotTrackStateChanged(EMarkType markType, int markId)
		{
			MarkItem markItem = this.Map.GetMarkItem(markType, markId);
			if (markItem != null && !markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, true);
			}
		}

		// Token: 0x0602497B RID: 149883 RVA: 0x00A5645C File Offset: 0x00A5465C
		private void OnMarkForceVisibleChanged(EMarkType markType, int markId, bool visible)
		{
			this.UpdateMarkItems(null);
		}

		// Token: 0x0602497C RID: 149884 RVA: 0x00A56478 File Offset: 0x00A54678
		private void OnSubMapChanged(int selectMultiMapId)
		{
			this.UpdateMarkItems(null);
		}

		// Token: 0x0602497D RID: 149885 RVA: 0x00A56494 File Offset: 0x00A54694
		public void UpdateMarkItems(bool? forceViewUpdate = null)
		{
			this.UpdateSelfPlayerMark();
			this.WorldMapStreamingComponent.RefreshViewportCache();
			foreach (Dictionary<int, MarkItem> dictionary in this.Map.GetAllMarkItems().Values)
			{
				foreach (MarkItem markItem in dictionary.Values)
				{
					this.QueueExecutionUpdateSingleMarkItem(markItem, forceViewUpdate.GetValueOrDefault());
				}
			}
			this.ScaleComponent.FlushScaleDirty();
		}

		// Token: 0x0602497E RID: 149886 RVA: 0x00A56550 File Offset: 0x00A54750
		public UniTask UpdateMarkItemsAsync()
		{
			WorldMapUiEntity.<UpdateMarkItemsAsync>d__98 <UpdateMarkItemsAsync>d__;
			<UpdateMarkItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMarkItemsAsync>d__.<>4__this = this;
			<UpdateMarkItemsAsync>d__.<>1__state = -1;
			<UpdateMarkItemsAsync>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateMarkItemsAsync>d__98>(ref <UpdateMarkItemsAsync>d__);
			return <UpdateMarkItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602497F RID: 149887 RVA: 0x00A56594 File Offset: 0x00A54794
		private void OnMarkTaskComplete(EMarkType markType, int markId)
		{
			MarkItem markItem = this.Map.GetMarkItem(markType, markId);
			if (markItem != null && !markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, false);
			}
		}

		// Token: 0x06024980 RID: 149888 RVA: 0x00A565C2 File Offset: 0x00A547C2
		private bool MarkItemUpdateCheck(MarkItem markItem)
		{
			return markItem.PermanentUpdate || this.WorldMapStreamingComponent.HandleStreamingUpdate(markItem);
		}

		// Token: 0x06024981 RID: 149889 RVA: 0x00A565DC File Offset: 0x00A547DC
		private void QueueExecutionUpdateSingleMarkItem(MarkItem markItem, bool forceViewUpdate = false)
		{
			WorldMapScaleComponent scaleComponent = this.ScaleComponent;
			bool isScaleDirty = scaleComponent.IsScaleDirty;
			if (isScaleDirty || markItem.PermanentUpdate)
			{
				this.UpdateSingleMarkItem(markItem, true);
				return;
			}
			if (!this.WorldMapStreamingComponent.IsInStreamingRange(markItem))
			{
				markItem.SetShowMarkView(false);
				markItem.CreateOrCycleView();
				return;
			}
			UpdateSingleMarkItemParam param = new UpdateSingleMarkItemParam
			{
				MapUiPosition = this.MoveComponent.MapUiPosition,
				MapScale = scaleComponent.MapScale,
				PlayerWorldPosition = this.PlayerComponent.PlayerWorldPosition,
				IsDragging = this.InteractComponent.IsDragging,
				IsScaleDirty = isScaleDirty,
				ForceViewUpdate = forceViewUpdate
			};
			MapMarkPreemptiveFrameTask task = new MapMarkPreemptiveFrameTask
			{
				Priority = 0,
				Execute = delegate
				{
					if (!markItem.IsDestroy)
					{
						this.UpdateSingleMarkItemInternal(markItem, param).Forget();
					}
				},
				MarkId = markItem.MarkId,
				MarkType = markItem.MarkType
			};
			this.MapUpdateTaskFrameQueue.AddTask(task);
		}

		// Token: 0x06024982 RID: 149890 RVA: 0x00A566FC File Offset: 0x00A548FC
		public void UpdateSingleMarkItem(MarkItem markItem, bool forceViewUpdate = false)
		{
			WorldMapScaleComponent scaleComponent = this.ScaleComponent;
			UpdateSingleMarkItemParam param = new UpdateSingleMarkItemParam
			{
				MapUiPosition = this.MoveComponent.MapUiPosition,
				MapScale = scaleComponent.MapScale,
				PlayerWorldPosition = this.PlayerComponent.PlayerWorldPosition,
				IsDragging = this.InteractComponent.IsDragging,
				IsScaleDirty = scaleComponent.IsScaleDirty,
				ForceViewUpdate = forceViewUpdate
			};
			this.UpdateSingleMarkItemInternal(markItem, param).Forget();
		}

		// Token: 0x06024983 RID: 149891 RVA: 0x00A56778 File Offset: 0x00A54978
		public UniTask UpdateSingleMarkItemAsync(MarkItem markItem, bool forceViewUpdate = false)
		{
			WorldMapUiEntity.<UpdateSingleMarkItemAsync>d__103 <UpdateSingleMarkItemAsync>d__;
			<UpdateSingleMarkItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateSingleMarkItemAsync>d__.<>4__this = this;
			<UpdateSingleMarkItemAsync>d__.markItem = markItem;
			<UpdateSingleMarkItemAsync>d__.forceViewUpdate = forceViewUpdate;
			<UpdateSingleMarkItemAsync>d__.<>1__state = -1;
			<UpdateSingleMarkItemAsync>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateSingleMarkItemAsync>d__103>(ref <UpdateSingleMarkItemAsync>d__);
			return <UpdateSingleMarkItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024984 RID: 149892 RVA: 0x00A567CC File Offset: 0x00A549CC
		private UniTask UpdateSingleMarkItemInternal(MarkItem markItem, UpdateSingleMarkItemParam param)
		{
			WorldMapUiEntity.<UpdateSingleMarkItemInternal>d__104 <UpdateSingleMarkItemInternal>d__;
			<UpdateSingleMarkItemInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateSingleMarkItemInternal>d__.<>4__this = this;
			<UpdateSingleMarkItemInternal>d__.markItem = markItem;
			<UpdateSingleMarkItemInternal>d__.param = param;
			<UpdateSingleMarkItemInternal>d__.<>1__state = -1;
			<UpdateSingleMarkItemInternal>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateSingleMarkItemInternal>d__104>(ref <UpdateSingleMarkItemInternal>d__);
			return <UpdateSingleMarkItemInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06024985 RID: 149893 RVA: 0x00A56820 File Offset: 0x00A54A20
		[NullableContext(2)]
		private void OnPlayerMarkPositionChanged(int _1 = 0, global::Vector _2 = null)
		{
			if (this.Map == null)
			{
				return;
			}
			Dictionary<int, MarkItem> markItemsByType = this.Map.GetMarkItemsByType(EMarkType.OtherPlayers, true);
			if (markItemsByType == null || markItemsByType.Count == 0)
			{
				return;
			}
			foreach (MarkItem markItem in markItemsByType.Values)
			{
				this.UpdateSingleMarkItem(markItem, false);
			}
		}

		// Token: 0x06024986 RID: 149894 RVA: 0x00A56898 File Offset: 0x00A54A98
		private void OnWorldMapPositionChanged()
		{
			this.WorldMapStreamingComponent.Update();
			this.UpdateMarkItems(new bool?(true));
		}

		// Token: 0x06024987 RID: 149895 RVA: 0x00A568B1 File Offset: 0x00A54AB1
		private void OnWorldMapUpdateMultiMapChanged()
		{
			this.MultiFloorComponent.UpdateMultiMap();
		}

		// Token: 0x04014573 RID: 83315
		private const float RAD_2_DEG = 57.295776f;

		// Token: 0x04014574 RID: 83316
		private const float DEG_PI_4 = 90f;

		// Token: 0x04014575 RID: 83317
		[Nullable(2)]
		private BaseMap _mapInner;

		// Token: 0x04014576 RID: 83318
		[Nullable(2)]
		private UKuroWorldMapUIParams _uiParamsInner;

		// Token: 0x04014578 RID: 83320
		[Nullable(2)]
		public MarkItem ClickedItem;

		// Token: 0x0401457B RID: 83323
		private readonly MapGamePlayRequestPreemptiveFrameQueue MapGamePlayRequestPreemptiveFrameQueue = new MapGamePlayRequestPreemptiveFrameQueue(200, 0);

		// Token: 0x0401457C RID: 83324
		private readonly MapUpdateTaskPreemptiveFrameQueue MapUpdateTaskFrameQueue = new MapUpdateTaskPreemptiveFrameQueue(1500, 0);

		// Token: 0x0401457E RID: 83326
		[Nullable(2)]
		public Vector2D MarkEdgeSize;

		// Token: 0x02009427 RID: 37927
		[NullableContext(0)]
		public static class EPropertyType
		{
			// Token: 0x0402E557 RID: 189783
			public const int ViewPortSize = 0;

			// Token: 0x0402E558 RID: 189784
			public const int OutOfViewPortSize = 1;

			// Token: 0x0402E559 RID: 189785
			public const int MapSize = 2;

			// Token: 0x0402E55A RID: 189786
			public const int MapId = 3;
		}
	}
}
