using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020047B9 RID: 18361
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapUiEntity : MapEntity
	{
		// Token: 0x17007878 RID: 30840
		// (get) Token: 0x06030172 RID: 196978 RVA: 0x00B25375 File Offset: 0x00B23575
		// (set) Token: 0x06030173 RID: 196979 RVA: 0x00B2537D File Offset: 0x00B2357D
		[Nullable(2)]
		public BaseMap Map
		{
			[NullableContext(2)]
			get
			{
				return this.MapInner;
			}
			[NullableContext(2)]
			set
			{
				this.MapInner = value;
				if (value == null)
				{
					return;
				}
				this.RecalculateMapSize();
			}
		}

		// Token: 0x06030174 RID: 196980 RVA: 0x00B25390 File Offset: 0x00B23590
		public void RecalculateMapSize()
		{
			Vector2D mapSizeOverride = this.Map.MapTileMgr.GetMapSizeOverride();
			if (mapSizeOverride != null)
			{
				this.MapSize = mapSizeOverride;
				return;
			}
			UUIItem rootItem = this.Map.GetRootItem();
			this.MapSize = Vector2D.Create((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		}

		// Token: 0x17007879 RID: 30841
		// (get) Token: 0x06030175 RID: 196981 RVA: 0x00B253E0 File Offset: 0x00B235E0
		// (set) Token: 0x06030176 RID: 196982 RVA: 0x00B25411 File Offset: 0x00B23611
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

		// Token: 0x1700787A RID: 30842
		// (get) Token: 0x06030177 RID: 196983 RVA: 0x00B2542C File Offset: 0x00B2362C
		// (set) Token: 0x06030178 RID: 196984 RVA: 0x00B2546F File Offset: 0x00B2366F
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

		// Token: 0x1700787B RID: 30843
		// (get) Token: 0x06030179 RID: 196985 RVA: 0x00B2548C File Offset: 0x00B2368C
		// (set) Token: 0x0603017A RID: 196986 RVA: 0x00B254CF File Offset: 0x00B236CF
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

		// Token: 0x1700787C RID: 30844
		// (get) Token: 0x0603017B RID: 196987 RVA: 0x00B254E9 File Offset: 0x00B236E9
		// (set) Token: 0x0603017C RID: 196988 RVA: 0x00B254F1 File Offset: 0x00B236F1
		public UKuroWorldMapUIParams UiParams
		{
			get
			{
				return this.UiParamsInner;
			}
			set
			{
				this.UiParamsInner = value;
			}
		}

		// Token: 0x1700787D RID: 30845
		// (get) Token: 0x0603017D RID: 196989 RVA: 0x00B254FA File Offset: 0x00B236FA
		// (set) Token: 0x0603017E RID: 196990 RVA: 0x00B25502 File Offset: 0x00B23702
		[Nullable(2)]
		public IWorldMapViewOpenParams OpenParams { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700787E RID: 30846
		// (get) Token: 0x0603017F RID: 196991 RVA: 0x00B2550C File Offset: 0x00B2370C
		// (set) Token: 0x06030180 RID: 196992 RVA: 0x00B2555B File Offset: 0x00B2375B
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

		// Token: 0x1700787F RID: 30847
		// (get) Token: 0x06030181 RID: 196993 RVA: 0x00B25578 File Offset: 0x00B23778
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

		// Token: 0x17007880 RID: 30848
		// (get) Token: 0x06030182 RID: 196994 RVA: 0x00B25688 File Offset: 0x00B23888
		public bool IsInPlayerGravity
		{
			get
			{
				EMapGravityDirection currentPlayerGravity = MapModel.Instance.CurrentPlayerGravity;
				EMapGravityDirection? worldMapSelectGravity = WorldMapModel.Instance.WorldMapSelectGravity;
				return currentPlayerGravity == worldMapSelectGravity.GetValueOrDefault() & worldMapSelectGravity != null;
			}
		}

		// Token: 0x17007881 RID: 30849
		// (get) Token: 0x06030183 RID: 196995 RVA: 0x00B256BB File Offset: 0x00B238BB
		// (set) Token: 0x06030184 RID: 196996 RVA: 0x00B256C3 File Offset: 0x00B238C3
		[Nullable(2)]
		public TWorldMapPlaySequenceFunction BoxTransitionPlaySequenceFunction { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007882 RID: 30850
		// (get) Token: 0x06030185 RID: 196997 RVA: 0x00B256CC File Offset: 0x00B238CC
		// (set) Token: 0x06030186 RID: 196998 RVA: 0x00B256D4 File Offset: 0x00B238D4
		[Nullable(2)]
		public UUITexture BoxScreenCaptureTexture { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007883 RID: 30851
		// (get) Token: 0x06030187 RID: 196999 RVA: 0x00B256DD File Offset: 0x00B238DD
		public WorldMapSecondaryUiComponent SecondaryUiComponent
		{
			get
			{
				return base.GetComponent<WorldMapSecondaryUiComponent>(EMapComponent.WorldMapSecondaryUi);
			}
		}

		// Token: 0x17007884 RID: 30852
		// (get) Token: 0x06030188 RID: 197000 RVA: 0x00B256E6 File Offset: 0x00B238E6
		public WorldMapInteractComponent InteractComponent
		{
			get
			{
				return base.GetComponent<WorldMapInteractComponent>(EMapComponent.WorldMapInteract);
			}
		}

		// Token: 0x17007885 RID: 30853
		// (get) Token: 0x06030189 RID: 197001 RVA: 0x00B256EF File Offset: 0x00B238EF
		public WorldMapMoveComponent MoveComponent
		{
			get
			{
				return base.GetComponent<WorldMapMoveComponent>(EMapComponent.WorldMapMove);
			}
		}

		// Token: 0x17007886 RID: 30854
		// (get) Token: 0x0603018A RID: 197002 RVA: 0x00B256F8 File Offset: 0x00B238F8
		public WorldMapScaleComponent ScaleComponent
		{
			get
			{
				return base.GetComponent<WorldMapScaleComponent>(EMapComponent.WorldMapScale);
			}
		}

		// Token: 0x17007887 RID: 30855
		// (get) Token: 0x0603018B RID: 197003 RVA: 0x00B25701 File Offset: 0x00B23901
		public WorldMapPlayerComponent PlayerComponent
		{
			get
			{
				return base.GetComponent<WorldMapPlayerComponent>(EMapComponent.WorldMapPlayer);
			}
		}

		// Token: 0x17007888 RID: 30856
		// (get) Token: 0x0603018C RID: 197004 RVA: 0x00B2570A File Offset: 0x00B2390A
		public WorldMapMultiFloorComponent MultiFloorComponent
		{
			get
			{
				return base.GetComponent<WorldMapMultiFloorComponent>(EMapComponent.WorldMapMultiFloor);
			}
		}

		// Token: 0x17007889 RID: 30857
		// (get) Token: 0x0603018D RID: 197005 RVA: 0x00B25713 File Offset: 0x00B23913
		public WorldMapQuickNavigateComponent QuickNavigateComponent
		{
			get
			{
				return base.GetComponent<WorldMapQuickNavigateComponent>(EMapComponent.WorldMapQuickNavigate);
			}
		}

		// Token: 0x1700788A RID: 30858
		// (get) Token: 0x0603018E RID: 197006 RVA: 0x00B2571C File Offset: 0x00B2391C
		public WorldMapStreamingComponent WorldMapStreamingComponent
		{
			get
			{
				return base.GetComponent<WorldMapStreamingComponent>(EMapComponent.WorldMapStreaming);
			}
		}

		// Token: 0x1700788B RID: 30859
		// (get) Token: 0x0603018F RID: 197007 RVA: 0x00B25725 File Offset: 0x00B23925
		public WorldMapAlterMapComponent WorldMapAlterMapComponent
		{
			get
			{
				return base.GetComponent<WorldMapAlterMapComponent>(EMapComponent.WorldMapAlterMap);
			}
		}

		// Token: 0x1700788C RID: 30860
		// (get) Token: 0x06030190 RID: 197008 RVA: 0x00B2572F File Offset: 0x00B2392F
		public WorldMapExtraUiPanelComponent WorldMapExtraUiPanelComponent
		{
			get
			{
				return base.GetComponent<WorldMapExtraUiPanelComponent>(EMapComponent.WorldMapExtraUiPanel);
			}
		}

		// Token: 0x06030191 RID: 197009 RVA: 0x00B25739 File Offset: 0x00B23939
		protected override void OnInit()
		{
			this.Reset(true);
		}

		// Token: 0x06030192 RID: 197010 RVA: 0x00B25744 File Offset: 0x00B23944
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

		// Token: 0x06030193 RID: 197011 RVA: 0x00B2599C File Offset: 0x00B23B9C
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

		// Token: 0x06030194 RID: 197012 RVA: 0x00B25B14 File Offset: 0x00B23D14
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

		// Token: 0x06030195 RID: 197013 RVA: 0x00B25C41 File Offset: 0x00B23E41
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

		// Token: 0x06030196 RID: 197014 RVA: 0x00B25C75 File Offset: 0x00B23E75
		public void CancelAllTasks()
		{
			this.MapGamePlayRequestPreemptiveFrameQueue.Dispose();
			this.MapUpdateTaskFrameQueue.Dispose();
		}

		// Token: 0x1700788D RID: 30861
		// (get) Token: 0x06030197 RID: 197015 RVA: 0x00B25C8D File Offset: 0x00B23E8D
		// (set) Token: 0x06030198 RID: 197016 RVA: 0x00B25C95 File Offset: 0x00B23E95
		public bool IsBoxTransitioning { get; private set; }

		// Token: 0x06030199 RID: 197017 RVA: 0x00B25CA0 File Offset: 0x00B23EA0
		private void OnWorldMapScaleTierChanged(EWorldMapScaleTier tier, EMapScaleSetType type)
		{
			bool flag = type == EMapScaleSetType.Initialize || type == EMapScaleSetType.Navigate;
			if (flag)
			{
				return;
			}
			this.SwitchTierAsync(tier, null).Forget();
		}

		// Token: 0x0603019A RID: 197018 RVA: 0x00B25CCC File Offset: 0x00B23ECC
		[NullableContext(2)]
		public UniTask NavigateSwitchTierAsync(EWorldMapScaleTier tier, int areaId, MarkItem landingMark)
		{
			WorldMapUiEntity.<NavigateSwitchTierAsync>d__74 <NavigateSwitchTierAsync>d__;
			<NavigateSwitchTierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NavigateSwitchTierAsync>d__.<>4__this = this;
			<NavigateSwitchTierAsync>d__.tier = tier;
			<NavigateSwitchTierAsync>d__.areaId = areaId;
			<NavigateSwitchTierAsync>d__.landingMark = landingMark;
			<NavigateSwitchTierAsync>d__.<>1__state = -1;
			<NavigateSwitchTierAsync>d__.<>t__builder.Start<WorldMapUiEntity.<NavigateSwitchTierAsync>d__74>(ref <NavigateSwitchTierAsync>d__);
			return <NavigateSwitchTierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603019B RID: 197019 RVA: 0x00B25D27 File Offset: 0x00B23F27
		[NullableContext(2)]
		private UniTask SwitchTierAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			this.ScaleComponent.OnScaleTierChanged();
			return this.PlayBoxTransitionAsync(tier, landingMark);
		}

		// Token: 0x0603019C RID: 197020 RVA: 0x00B25D3C File Offset: 0x00B23F3C
		[NullableContext(2)]
		private UniTask PlayBoxTransitionAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			WorldMapUiEntity.<PlayBoxTransitionAsync>d__76 <PlayBoxTransitionAsync>d__;
			<PlayBoxTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBoxTransitionAsync>d__.<>4__this = this;
			<PlayBoxTransitionAsync>d__.tier = tier;
			<PlayBoxTransitionAsync>d__.landingMark = landingMark;
			<PlayBoxTransitionAsync>d__.<>1__state = -1;
			<PlayBoxTransitionAsync>d__.<>t__builder.Start<WorldMapUiEntity.<PlayBoxTransitionAsync>d__76>(ref <PlayBoxTransitionAsync>d__);
			return <PlayBoxTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603019D RID: 197021 RVA: 0x00B25D90 File Offset: 0x00B23F90
		[NullableContext(2)]
		private UniTask RebuildTilesAndMoveAsync(EWorldMapScaleTier tier, MarkItem landingMark)
		{
			WorldMapUiEntity.<RebuildTilesAndMoveAsync>d__77 <RebuildTilesAndMoveAsync>d__;
			<RebuildTilesAndMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildTilesAndMoveAsync>d__.<>4__this = this;
			<RebuildTilesAndMoveAsync>d__.tier = tier;
			<RebuildTilesAndMoveAsync>d__.landingMark = landingMark;
			<RebuildTilesAndMoveAsync>d__.<>1__state = -1;
			<RebuildTilesAndMoveAsync>d__.<>t__builder.Start<WorldMapUiEntity.<RebuildTilesAndMoveAsync>d__77>(ref <RebuildTilesAndMoveAsync>d__);
			return <RebuildTilesAndMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603019E RID: 197022 RVA: 0x00B25DE4 File Offset: 0x00B23FE4
		private void SetBoxTransitionMarkLayerActive(bool active)
		{
			BaseMap map = this.Map;
			if (map == null)
			{
				return;
			}
			map.MarkContainer.SetUIActive(active);
			map.AutoPilotLine.SetUiActive(active);
			if (active)
			{
				this.InitSelfPlayerMark();
				this.UpdateMarkItems(new bool?(true));
				map.MapRangePanel.CheckExploreMarkRangeInfo();
				return;
			}
			map.SelfPlayerNode.SetUIActive(false);
			map.MapRangePanel.SetRangeComponentHide(false).Forget();
		}

		// Token: 0x0603019F RID: 197023 RVA: 0x00B25E54 File Offset: 0x00B24054
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private static UniTask<UTexture2D> CaptureBoxTransitionShotAsync()
		{
			WorldMapUiEntity.<CaptureBoxTransitionShotAsync>d__79 <CaptureBoxTransitionShotAsync>d__;
			<CaptureBoxTransitionShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UTexture2D>.Create();
			<CaptureBoxTransitionShotAsync>d__.<>1__state = -1;
			<CaptureBoxTransitionShotAsync>d__.<>t__builder.Start<WorldMapUiEntity.<CaptureBoxTransitionShotAsync>d__79>(ref <CaptureBoxTransitionShotAsync>d__);
			return <CaptureBoxTransitionShotAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060301A0 RID: 197024 RVA: 0x00B25E90 File Offset: 0x00B24090
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

		// Token: 0x060301A1 RID: 197025 RVA: 0x00B25F78 File Offset: 0x00B24178
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
			map.AutoPilotLine.RefreshFindPathLine();
		}

		// Token: 0x060301A2 RID: 197026 RVA: 0x00B26070 File Offset: 0x00B24270
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

		// Token: 0x060301A3 RID: 197027 RVA: 0x00B26130 File Offset: 0x00B24330
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

		// Token: 0x060301A4 RID: 197028 RVA: 0x00B261AC File Offset: 0x00B243AC
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

		// Token: 0x060301A5 RID: 197029 RVA: 0x00B2621C File Offset: 0x00B2441C
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

		// Token: 0x060301A6 RID: 197030 RVA: 0x00B26394 File Offset: 0x00B24594
		private void SetPlayerInstancePosition(bool focus = true)
		{
			this.UpdateSelfPlayerMark();
			if (focus)
			{
				Vector2D lastBigScenePlayerUiPosition = MapUtil.GetLastBigScenePlayerUiPosition();
				this.MoveComponent.FocusPlayer(lastBigScenePlayerUiPosition, false, EClampType.ClampToSafeArea);
			}
		}

		// Token: 0x060301A7 RID: 197031 RVA: 0x00B263C0 File Offset: 0x00B245C0
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
			Vector2D item = Vector2D.Create();
			if (Math.Abs(offset.X / offset.Y) > markEdgeSize.X / markEdgeSize.Y)
			{
				item = offset.Multiply(markEdgeSize.X / Math.Abs(offset.X), offset);
			}
			else
			{
				item = offset.Multiply(markEdgeSize.Y / Math.Abs(offset.Y), offset);
			}
			return new ValueTuple<Vector2D, bool>(item, true);
		}

		// Token: 0x060301A8 RID: 197032 RVA: 0x00B26466 File Offset: 0x00B24666
		private void OnMarkItemTrackStateChanged(MarkItem markItem)
		{
			if (!markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, true);
			}
		}

		// Token: 0x060301A9 RID: 197033 RVA: 0x00B26478 File Offset: 0x00B24678
		private void OnMarkItemAutoPilotTrackStateChanged(EMarkType markType, int markId)
		{
			MarkItem markItem = this.Map.GetMarkItem(markType, markId);
			if (markItem != null && !markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, true);
			}
		}

		// Token: 0x060301AA RID: 197034 RVA: 0x00B264A8 File Offset: 0x00B246A8
		private void OnMarkForceVisibleChanged(EMarkType markType, int markId, bool visible)
		{
			this.UpdateMarkItems(null);
		}

		// Token: 0x060301AB RID: 197035 RVA: 0x00B264C4 File Offset: 0x00B246C4
		private void OnSubMapChanged(int selectMultiMapId)
		{
			this.UpdateMarkItems(null);
		}

		// Token: 0x060301AC RID: 197036 RVA: 0x00B264E0 File Offset: 0x00B246E0
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

		// Token: 0x060301AD RID: 197037 RVA: 0x00B2659C File Offset: 0x00B2479C
		public UniTask UpdateMarkItemsAsync()
		{
			WorldMapUiEntity.<UpdateMarkItemsAsync>d__94 <UpdateMarkItemsAsync>d__;
			<UpdateMarkItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMarkItemsAsync>d__.<>4__this = this;
			<UpdateMarkItemsAsync>d__.<>1__state = -1;
			<UpdateMarkItemsAsync>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateMarkItemsAsync>d__94>(ref <UpdateMarkItemsAsync>d__);
			return <UpdateMarkItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060301AE RID: 197038 RVA: 0x00B265E0 File Offset: 0x00B247E0
		private void OnMarkTaskComplete(EMarkType markType, int markId)
		{
			MarkItem markItem = this.Map.GetMarkItem(markType, markId);
			if (markItem != null && !markItem.IsDestroy)
			{
				this.UpdateSingleMarkItem(markItem, false);
			}
		}

		// Token: 0x060301AF RID: 197039 RVA: 0x00B2660E File Offset: 0x00B2480E
		private bool MarkItemUpdateCheck(MarkItem markItem)
		{
			return markItem.PermanentUpdate || this.WorldMapStreamingComponent.HandleStreamingUpdate(markItem);
		}

		// Token: 0x060301B0 RID: 197040 RVA: 0x00B26628 File Offset: 0x00B24828
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
				markItem.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.MarkView, false);
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

		// Token: 0x060301B1 RID: 197041 RVA: 0x00B26750 File Offset: 0x00B24950
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

		// Token: 0x060301B2 RID: 197042 RVA: 0x00B267CC File Offset: 0x00B249CC
		public UniTask UpdateSingleMarkItemAsync(MarkItem markItem, bool forceViewUpdate = false)
		{
			WorldMapUiEntity.<UpdateSingleMarkItemAsync>d__99 <UpdateSingleMarkItemAsync>d__;
			<UpdateSingleMarkItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateSingleMarkItemAsync>d__.<>4__this = this;
			<UpdateSingleMarkItemAsync>d__.markItem = markItem;
			<UpdateSingleMarkItemAsync>d__.forceViewUpdate = forceViewUpdate;
			<UpdateSingleMarkItemAsync>d__.<>1__state = -1;
			<UpdateSingleMarkItemAsync>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateSingleMarkItemAsync>d__99>(ref <UpdateSingleMarkItemAsync>d__);
			return <UpdateSingleMarkItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060301B3 RID: 197043 RVA: 0x00B26820 File Offset: 0x00B24A20
		private UniTask UpdateSingleMarkItemInternal(MarkItem markItem, UpdateSingleMarkItemParam param)
		{
			WorldMapUiEntity.<UpdateSingleMarkItemInternal>d__100 <UpdateSingleMarkItemInternal>d__;
			<UpdateSingleMarkItemInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateSingleMarkItemInternal>d__.<>4__this = this;
			<UpdateSingleMarkItemInternal>d__.markItem = markItem;
			<UpdateSingleMarkItemInternal>d__.param = param;
			<UpdateSingleMarkItemInternal>d__.<>1__state = -1;
			<UpdateSingleMarkItemInternal>d__.<>t__builder.Start<WorldMapUiEntity.<UpdateSingleMarkItemInternal>d__100>(ref <UpdateSingleMarkItemInternal>d__);
			return <UpdateSingleMarkItemInternal>d__.<>t__builder.Task;
		}

		// Token: 0x060301B4 RID: 197044 RVA: 0x00B26874 File Offset: 0x00B24A74
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

		// Token: 0x060301B5 RID: 197045 RVA: 0x00B268EC File Offset: 0x00B24AEC
		private unsafe void CheckAndCreateGamePlayRequestTask(MarkItem markItem)
		{
			MarkCommonGamePlayStateComponent component = markItem.MarkItemEntity.GetComponent<MarkCommonGamePlayStateComponent>(EMapComponent.MarkCommonGamePlayState);
			if (component != null && component.NeedRequestGamePlayState())
			{
				int? relativeId = component.GetRelativeId();
				int? relativeDungeonId = component.GetRelativeDungeonId();
				if (relativeId == null || relativeDungeonId == null)
				{
					return;
				}
				MapGamePlayRequestPreemptiveFrameTask mapGamePlayRequestPreemptiveFrameTask = new MapGamePlayRequestPreemptiveFrameTask();
				mapGamePlayRequestPreemptiveFrameTask.Priority = 0;
				mapGamePlayRequestPreemptiveFrameTask.Execute = delegate()
				{
				};
				mapGamePlayRequestPreemptiveFrameTask.MarkId = markItem.MarkId;
				mapGamePlayRequestPreemptiveFrameTask.GamePlayId = relativeId.Value;
				mapGamePlayRequestPreemptiveFrameTask.InstId = relativeDungeonId.Value;
				MapGamePlayRequestPreemptiveFrameTask task = mapGamePlayRequestPreemptiveFrameTask;
				this.MapGamePlayRequestPreemptiveFrameQueue.AddTask(task);
				OneOf<MapMark, DynamicMapMark, TreasureBoxDetectorMark> config = markItem.MarkItemEntity.GetComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config;
				if (config.IsT1)
				{
					Span<int> associatedGameplayMarksBytes = config.AsT1.GetAssociatedGameplayMarksBytes();
					for (int i = 0; i < associatedGameplayMarksBytes.Length; i++)
					{
						int markId = *associatedGameplayMarksBytes[i];
						MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
						if (configMark != null)
						{
							MapGamePlayRequestPreemptiveFrameTask mapGamePlayRequestPreemptiveFrameTask2 = new MapGamePlayRequestPreemptiveFrameTask();
							mapGamePlayRequestPreemptiveFrameTask2.Priority = 0;
							mapGamePlayRequestPreemptiveFrameTask2.Execute = delegate()
							{
							};
							mapGamePlayRequestPreemptiveFrameTask2.MarkId = markItem.MarkId;
							mapGamePlayRequestPreemptiveFrameTask2.GamePlayId = configMark.Value.RelativeId;
							mapGamePlayRequestPreemptiveFrameTask2.InstId = configMark.Value.RelativeDungeonId;
							MapGamePlayRequestPreemptiveFrameTask task2 = mapGamePlayRequestPreemptiveFrameTask2;
							this.MapGamePlayRequestPreemptiveFrameQueue.AddTask(task2);
						}
					}
				}
				component.HasRequestGamePlay = true;
			}
		}

		// Token: 0x060301B6 RID: 197046 RVA: 0x00B26A8D File Offset: 0x00B24C8D
		private void OnWorldMapPositionChanged()
		{
			this.WorldMapStreamingComponent.Update();
			this.UpdateMarkItems(new bool?(true));
		}

		// Token: 0x060301B7 RID: 197047 RVA: 0x00B26AA6 File Offset: 0x00B24CA6
		private void OnWorldMapUpdateMultiMapChanged()
		{
			this.MultiFloorComponent.UpdateMultiMap();
		}

		// Token: 0x04019EC2 RID: 106178
		private const float RAD_2_DEG = 57.295776f;

		// Token: 0x04019EC3 RID: 106179
		private const float DEG_PI_4 = 90f;

		// Token: 0x04019EC4 RID: 106180
		[Nullable(2)]
		private BaseMap MapInner;

		// Token: 0x04019EC5 RID: 106181
		[Nullable(2)]
		private UKuroWorldMapUIParams UiParamsInner;

		// Token: 0x04019EC7 RID: 106183
		[Nullable(2)]
		public MarkItem ClickedItem;

		// Token: 0x04019ECA RID: 106186
		private readonly MapGamePlayRequestPreemptiveFrameQueue MapGamePlayRequestPreemptiveFrameQueue = new MapGamePlayRequestPreemptiveFrameQueue(200, 0);

		// Token: 0x04019ECB RID: 106187
		private readonly MapUpdateTaskPreemptiveFrameQueue MapUpdateTaskFrameQueue = new MapUpdateTaskPreemptiveFrameQueue(1500, 0);

		// Token: 0x04019ECD RID: 106189
		[Nullable(2)]
		public Vector2D MarkEdgeSize;

		// Token: 0x0200AA73 RID: 43635
		[NullableContext(0)]
		public static class EPropertyType
		{
			// Token: 0x04033DCB RID: 212427
			public const int ViewPortSize = 0;

			// Token: 0x04033DCC RID: 212428
			public const int OutOfViewPortSize = 1;

			// Token: 0x04033DCD RID: 212429
			public const int MapSize = 2;

			// Token: 0x04033DCE RID: 212430
			public const int MapId = 3;
		}
	}
}
