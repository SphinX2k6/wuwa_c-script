using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile;
using CSharpScript.Game.Module.Map.View.SubView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x0200548D RID: 21645
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMap : UiPanelBase
	{
		// Token: 0x17008482 RID: 33922
		// (get) Token: 0x0603746F RID: 226415 RVA: 0x00D1E106 File Offset: 0x00D1C306
		// (set) Token: 0x06037470 RID: 226416 RVA: 0x00D1E10E File Offset: 0x00D1C30E
		public int MapId { get; set; }

		// Token: 0x17008483 RID: 33923
		// (get) Token: 0x06037471 RID: 226417 RVA: 0x00D1E117 File Offset: 0x00D1C317
		// (set) Token: 0x06037472 RID: 226418 RVA: 0x00D1E11F File Offset: 0x00D1C31F
		public int InstanceDungeonId { get; set; }

		// Token: 0x17008484 RID: 33924
		// (get) Token: 0x06037473 RID: 226419 RVA: 0x00D1E128 File Offset: 0x00D1C328
		public MapRangePanel MapRangePanel
		{
			get
			{
				return this.MapRangePanelInner;
			}
		}

		// Token: 0x17008485 RID: 33925
		// (get) Token: 0x06037474 RID: 226420 RVA: 0x00D1E130 File Offset: 0x00D1C330
		// (set) Token: 0x06037475 RID: 226421 RVA: 0x00D1E138 File Offset: 0x00D1C338
		public AutoPilotLine AutoPilotLine { get; private set; }

		// Token: 0x17008486 RID: 33926
		// (get) Token: 0x06037476 RID: 226422 RVA: 0x00D1E141 File Offset: 0x00D1C341
		public UUIItem MapRootItem
		{
			get
			{
				return this.RootItem;
			}
		}

		// Token: 0x17008487 RID: 33927
		// (get) Token: 0x06037477 RID: 226423 RVA: 0x00D1E149 File Offset: 0x00D1C349
		public EMapGravityDirection MapGravity
		{
			get
			{
				return this.MapGravityInternal;
			}
		}

		// Token: 0x06037478 RID: 226424 RVA: 0x00D1E154 File Offset: 0x00D1C354
		public BaseMap(MapConstructorParams mapParams)
		{
			this.InstanceDungeonId = mapParams.InstanceId;
			this.MapId = MapModel.Instance.GetDungeonWorldMapConfigId(mapParams.InstanceId);
			this.MapType = mapParams.MapType;
			this.MapDefaultScale = mapParams.MapDefaultScale;
			this.MarkScale = mapParams.MarkScale.GetValueOrDefault(1f);
			this.ClickRange = mapParams.ClickRange.GetValueOrDefault(100f);
			this.PreloadTiles = mapParams.PreloadTiles;
			this.MapGravityInternal = mapParams.Gravity.GetValueOrDefault(EMapGravityDirection.Down);
		}

		// Token: 0x06037479 RID: 226425 RVA: 0x00D1E21C File Offset: 0x00D1C41C
		public void Tick()
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.Tick();
		}

		// Token: 0x0603747A RID: 226426 RVA: 0x00D1E230 File Offset: 0x00D1C430
		public UniTask ChangeMapAsync(int mapId, EMapGravityDirection gravity)
		{
			BaseMap.<ChangeMapAsync>d__37 <ChangeMapAsync>d__;
			<ChangeMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsync>d__.<>4__this = this;
			<ChangeMapAsync>d__.mapId = mapId;
			<ChangeMapAsync>d__.gravity = gravity;
			<ChangeMapAsync>d__.<>1__state = -1;
			<ChangeMapAsync>d__.<>t__builder.Start<BaseMap.<ChangeMapAsync>d__37>(ref <ChangeMapAsync>d__);
			return <ChangeMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603747B RID: 226427 RVA: 0x00D1E284 File Offset: 0x00D1C484
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			MarkGravityReverseIconComponent playerMapGravityComponent = this.PlayerMapGravityComponent;
			if (playerMapGravityComponent != null)
			{
				playerMapGravityComponent.RecycleToPool();
			}
			this.PlayerMapGravityComponent = null;
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr != null)
			{
				mapMarkMgr.Dispose();
			}
			this.MapMarkMgr = null;
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr != null)
			{
				mapTileMgr.Dispose();
			}
			this.MapTileMgr = null;
			MapRangePanel mapRangePanelInner = this.MapRangePanelInner;
			if (mapRangePanelInner != null)
			{
				mapRangePanelInner.Destroy();
			}
			this.MapRangePanelInner = null;
			AutoPilotLine autoPilotLine = this.AutoPilotLine;
			if (autoPilotLine != null)
			{
				autoPilotLine.Destroy();
			}
			this.AutoPilotLine = null;
			MapRoadWaysMgr mapRoadWaysMgr = this.MapRoadWaysMgr;
			if (mapRoadWaysMgr != null)
			{
				mapRoadWaysMgr.Dispose();
			}
			this.MapRoadWaysMgr = null;
		}

		// Token: 0x0603747C RID: 226428 RVA: 0x00D1E328 File Offset: 0x00D1C528
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603747D RID: 226429 RVA: 0x00D1E524 File Offset: 0x00D1C724
		protected override UniTask OnBeforeStartAsync()
		{
			BaseMap.<OnBeforeStartAsync>d__40 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BaseMap.<OnBeforeStartAsync>d__40>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603747E RID: 226430 RVA: 0x00D1E568 File Offset: 0x00D1C768
		protected override void OnStart()
		{
			this.PlayerOutOfBoundIndicator = base.GetItem(2);
			this.PlayerArrow = base.GetItem(1);
			this.RootItem.SetHierarchyIndex(0);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetWidth(this.ClickRange * 2f);
			}
			if (item != null)
			{
				item.SetHeight(this.ClickRange * 2f);
			}
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RangeItemLevelSequencePlayer = new LevelSequencePlayer(item);
			this.MapRangePanelInner = new MapRangePanel(this);
			this.MapRangePanelInner.CheckExploreMarkRangeInfo();
			this.AutoPilotLine = new AutoPilotLine(this);
			this.AutoPilotLine.CheckAutoPilotLineInfo();
		}

		// Token: 0x0603747F RID: 226431 RVA: 0x00D1E61C File Offset: 0x00D1C81C
		private void InitAssistants(float markScale)
		{
			UUIItem item = base.GetItem(3);
			UUIItem item2 = base.GetItem(4);
			UUITexture texture = base.GetTexture(5);
			if (BaseMapStatic.Instance.MapMaterialVersion == 2)
			{
				texture = base.GetTexture(9);
			}
			UUIItem item3 = base.GetItem(7);
			UUITexture texture2 = base.GetTexture(8);
			MapMarkMgrParams param = new MapMarkMgrParams
			{
				MapType = this.MapType,
				MapId = this.MapId,
				InstanceDungeonId = this.InstanceDungeonId,
				MarkContainer = item,
				MarkScale = markScale,
				Gravity = new EMapGravityDirection?(this.MapGravityInternal)
			};
			this.MapMarkMgr = new MapMarkMgr(param);
			this.MapMarkMgr.Initialize();
			UUIItem item4 = base.GetItem(10);
			MapTileMgrParams tileMgrParams = new MapTileMgrParams
			{
				MapRootItem = this.RootItem,
				TileContainer = item2,
				TileTexture = texture,
				SubMapContainer = item3,
				SubMapTexture = texture2,
				MapType = this.MapType,
				MapId = this.MapId,
				InstanceDungeonId = this.InstanceDungeonId,
				MapVersion = BaseMapStatic.Instance.MapMaterialVersion,
				PreloadTiles = this.PreloadTiles,
				FogUnlockItem = item4,
				Gravity = new EMapGravityDirection?(this.MapGravityInternal)
			};
			this.MapTileMgr = new MapTileMgr(tileMgrParams);
			this.MapTileMgr.Initialize();
			this.MapRoadWaysMgr = new MapRoadWaysMgr(new MapRoadWaysMgrParams
			{
				MapId = this.MapId,
				InstanceDungeonId = this.InstanceDungeonId,
				Container = base.GetItem(13)
			});
		}

		// Token: 0x17008488 RID: 33928
		// (get) Token: 0x06037480 RID: 226432 RVA: 0x00D1E7AB File Offset: 0x00D1C9AB
		public UUIItem MarkContainer
		{
			get
			{
				return base.GetItem(3);
			}
		}

		// Token: 0x17008489 RID: 33929
		// (get) Token: 0x06037481 RID: 226433 RVA: 0x00D1E7B4 File Offset: 0x00D1C9B4
		public UUIItem FogUnlockAnchorItem
		{
			get
			{
				return base.GetItem(10);
			}
		}

		// Token: 0x06037482 RID: 226434 RVA: 0x00D1E7BE File Offset: 0x00D1C9BE
		private void BindEvents()
		{
			if (this.MapType == EMapType.WorldMap)
			{
				return;
			}
			if (GameModeModel.Instance.WorldDone)
			{
				this.SetUp();
				return;
			}
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.SetUp));
		}

		// Token: 0x06037483 RID: 226435 RVA: 0x00D1E7FC File Offset: 0x00D1C9FC
		protected void UnBindEvents()
		{
			if (this.MapType == EMapType.WorldMap)
			{
				return;
			}
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.SetUp)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.SetUp));
			}
		}

		// Token: 0x06037484 RID: 226436 RVA: 0x00D1E84C File Offset: 0x00D1CA4C
		private void SetUp()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr != null)
			{
				mapTileMgr.OnMapSetUp();
			}
			MapTileMgr mapTileMgr2 = this.MapTileMgr;
			if (mapTileMgr2 != null)
			{
				mapTileMgr2.LoadMapBorder().Forget();
			}
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr != null)
			{
				mapMarkMgr.OnMapSetup(null);
			}
			MapRoadWaysMgr mapRoadWaysMgr = this.MapRoadWaysMgr;
			if (mapRoadWaysMgr != null)
			{
				mapRoadWaysMgr.OnMapSetup();
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06037485 RID: 226437 RVA: 0x00D1E8BC File Offset: 0x00D1CABC
		private UniTask SetUpWorldMapAsync()
		{
			BaseMap.<SetUpWorldMapAsync>d__50 <SetUpWorldMapAsync>d__;
			<SetUpWorldMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetUpWorldMapAsync>d__.<>4__this = this;
			<SetUpWorldMapAsync>d__.<>1__state = -1;
			<SetUpWorldMapAsync>d__.<>t__builder.Start<BaseMap.<SetUpWorldMapAsync>d__50>(ref <SetUpWorldMapAsync>d__);
			return <SetUpWorldMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037486 RID: 226438 RVA: 0x00D1E8FF File Offset: 0x00D1CAFF
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllMarkItems()
		{
			return this.MapMarkMgr.GetAllMarkItems();
		}

		// Token: 0x06037487 RID: 226439 RVA: 0x00D1E90C File Offset: 0x00D1CB0C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, MarkItem> GetMarkItemsByType(EMarkType markType, bool withCrossMap = true)
		{
			return this.MapMarkMgr.GetMarkItemsByType(markType, withCrossMap);
		}

		// Token: 0x06037488 RID: 226440 RVA: 0x00D1E91B File Offset: 0x00D1CB1B
		public List<MarkItem> GetMarkItemsByClickPosition(Vector clickPosition, int cellRadius = 1)
		{
			return this.MapMarkMgr.GetMarkItemsByClickPosition(clickPosition, cellRadius);
		}

		// Token: 0x06037489 RID: 226441 RVA: 0x00D1E92A File Offset: 0x00D1CB2A
		[NullableContext(2)]
		public MarkItem GetMarkItem(EMarkType markType, int markId)
		{
			return this.MapMarkMgr.GetMarkItem(markType, markId);
		}

		// Token: 0x0603748A RID: 226442 RVA: 0x00D1E939 File Offset: 0x00D1CB39
		public CustomMarkItem CreateCustomMark(DynamicMarkCreateInfo info)
		{
			return this.MapMarkMgr.CreateDynamicMark(info, true) as CustomMarkItem;
		}

		// Token: 0x0603748B RID: 226443 RVA: 0x00D1E94D File Offset: 0x00D1CB4D
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public List<ValueTuple<MarkItem, double>> FindNearbyMarkItems(MarkItem markItem, float searchRadius, TFilterMarkFunction filterFunction = null)
		{
			return this.MapMarkMgr.FindNearbyMarkItems(markItem, searchRadius, filterFunction);
		}

		// Token: 0x0603748C RID: 226444 RVA: 0x00D1E95D File Offset: 0x00D1CB5D
		public List<MarkItem> GetTrackMenuMarkList()
		{
			return this.MapMarkMgr.GetTrackMenuMarkList();
		}

		// Token: 0x0603748D RID: 226445 RVA: 0x00D1E96A File Offset: 0x00D1CB6A
		public List<MarkItem> GetNavigateMarkList()
		{
			return this.MapMarkMgr.GetNavigateMarkList();
		}

		// Token: 0x1700848A RID: 33930
		// (get) Token: 0x0603748E RID: 226446 RVA: 0x00D1E977 File Offset: 0x00D1CB77
		public Vector4? MapOffset
		{
			get
			{
				return new Vector4?(this.MapTileMgr.MapOffset);
			}
		}

		// Token: 0x1700848B RID: 33931
		// (get) Token: 0x0603748F RID: 226447 RVA: 0x00D1E989 File Offset: 0x00D1CB89
		public float FakeOffset
		{
			get
			{
				return this.MapTileMgr.FakeOffset;
			}
		}

		// Token: 0x06037490 RID: 226448 RVA: 0x00D1E996 File Offset: 0x00D1CB96
		public void ShowSubMapTile(int groupId, int layer, bool fastTween = false)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.ShowSubMapByPosition(groupId, layer, fastTween);
		}

		// Token: 0x06037491 RID: 226449 RVA: 0x00D1E9AB File Offset: 0x00D1CBAB
		public void HideSubMapTile()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HideSubMap();
		}

		// Token: 0x06037492 RID: 226450 RVA: 0x00D1E9BD File Offset: 0x00D1CBBD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MapTileItem> GetAllMapTileItems()
		{
			return this.MapTileMgr.GetMapTileItems();
		}

		// Token: 0x06037493 RID: 226451 RVA: 0x00D1E9CA File Offset: 0x00D1CBCA
		[NullableContext(2)]
		public Vector GetWorldMapCenterPosition()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return null;
			}
			return mapTileMgr.GetWorldMapCenterPosition();
		}

		// Token: 0x06037494 RID: 226452 RVA: 0x00D1E9DD File Offset: 0x00D1CBDD
		public int GetMultiMapAreaIdByPosition(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return 0;
			}
			return mapTileMgr.GetMultiMapAreaIdByPosition(position);
		}

		// Token: 0x06037495 RID: 226453 RVA: 0x00D1E9F1 File Offset: 0x00D1CBF1
		public int GetSubMapGroupByPosition(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return 0;
			}
			return mapTileMgr.GetSubMapGroupByPosition(position);
		}

		// Token: 0x06037496 RID: 226454 RVA: 0x00D1EA08 File Offset: 0x00D1CC08
		public int GetWorldMapCenterAreaId()
		{
			Vector worldMapCenterPosition = this.MapTileMgr.GetWorldMapCenterPosition();
			if (worldMapCenterPosition == null)
			{
				return 0;
			}
			return this.MapTileMgr.GetMultiMapAreaIdByPosition(worldMapCenterPosition);
		}

		// Token: 0x06037497 RID: 226455 RVA: 0x00D1EA32 File Offset: 0x00D1CC32
		public void UpdateCurrentAreaMapGroupId(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateCurrentAreaMapGroupId(position);
		}

		// Token: 0x06037498 RID: 226456 RVA: 0x00D1EA48 File Offset: 0x00D1CC48
		public void SetMapScale(float scale)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			FVector fvector = new FVector(scale, scale, scale);
			rootItem.SetUIRelativeScale3D(fvector);
		}

		// Token: 0x06037499 RID: 226457 RVA: 0x00D1EA70 File Offset: 0x00D1CC70
		public void HandleFogAreaOpen(int fogId)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HandleFogAreaOpen(fogId);
		}

		// Token: 0x0603749A RID: 226458 RVA: 0x00D1EA83 File Offset: 0x00D1CC83
		public void HandleMapTileDelegate()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HandleDelegate();
		}

		// Token: 0x0603749B RID: 226459 RVA: 0x00D1EA95 File Offset: 0x00D1CC95
		public void UnBindMapTileDelegate()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UnBindDelegate();
		}

		// Token: 0x0603749C RID: 226460 RVA: 0x00D1EAA8 File Offset: 0x00D1CCA8
		public void HandleSceneGamePlayMarkItemOpen(EMarkType markType, int relativeType, int subRelativeType)
		{
			Dictionary<int, MarkItem> markItemsByType = this.GetMarkItemsByType(markType, true);
			if (markItemsByType == null)
			{
				return;
			}
			foreach (KeyValuePair<int, MarkItem> keyValuePair in markItemsByType)
			{
				MarkItem markItem = keyValuePair.Value;
				ConfigMarkItem configMarkItem = markItem as ConfigMarkItem;
				if (configMarkItem != null && configMarkItem.MarkConfig != null && configMarkItem.MarkConfig.Value.RelativeSubType == subRelativeType)
				{
					markItem.IsCanShowView = true;
					markItem.ViewUpdateAsync(GeneralLogicTreeUtil.Instance.GetPlayerLocation(), false, false).ContinueWith(delegate()
					{
						MarkItemView view = markItem.View;
						if (view == null)
						{
							return;
						}
						view.PlayUnlockSequence().Forget();
					}).Forget();
				}
			}
		}

		// Token: 0x0603749D RID: 226461 RVA: 0x00D1EB88 File Offset: 0x00D1CD88
		[NullableContext(2)]
		public void SetClickRangeVisible(bool visible, Vector2D clickUiPosition = null)
		{
			if (clickUiPosition == null)
			{
				clickUiPosition = Vector2D.Create(0.0, 0.0);
			}
			this.PlaySequenceAndSetActive(visible, clickUiPosition).Forget<bool>();
		}

		// Token: 0x0603749E RID: 226462 RVA: 0x00D1EBB4 File Offset: 0x00D1CDB4
		[NullableContext(0)]
		private UniTask<bool> PlaySequenceAndSetActive(bool bActive, [Nullable(1)] Vector2D clickUiPosition)
		{
			BaseMap.<PlaySequenceAndSetActive>d__77 <PlaySequenceAndSetActive>d__;
			<PlaySequenceAndSetActive>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlaySequenceAndSetActive>d__.<>4__this = this;
			<PlaySequenceAndSetActive>d__.bActive = bActive;
			<PlaySequenceAndSetActive>d__.clickUiPosition = clickUiPosition;
			<PlaySequenceAndSetActive>d__.<>1__state = -1;
			<PlaySequenceAndSetActive>d__.<>t__builder.Start<BaseMap.<PlaySequenceAndSetActive>d__77>(ref <PlaySequenceAndSetActive>d__);
			return <PlaySequenceAndSetActive>d__.<>t__builder.Task;
		}

		// Token: 0x0603749F RID: 226463 RVA: 0x00D1EC07 File Offset: 0x00D1CE07
		public bool InValidMapTile(Vector worldPosition)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			return mapTileMgr != null && mapTileMgr.InValidTile(worldPosition);
		}

		// Token: 0x060374A0 RID: 226464 RVA: 0x00D1EC1B File Offset: 0x00D1CE1B
		public void UpdateDraggableParams(ITileNum tileNum)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateDraggableParams(tileNum);
		}

		// Token: 0x060374A1 RID: 226465 RVA: 0x00D1EC2E File Offset: 0x00D1CE2E
		public void ResetDraggableParams()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.ResetDraggableParams();
		}

		// Token: 0x060374A2 RID: 226466 RVA: 0x00D1EC40 File Offset: 0x00D1CE40
		public void SetPlayerGravityActive(bool active, EMapGravityDirection gravity = EMapGravityDirection.Down)
		{
			if (gravity != EMapGravityDirection.Down)
			{
				this.PlayerMapGravityComponent.Gravity = gravity;
			}
			MarkGravityReverseIconComponent playerMapGravityComponent = this.PlayerMapGravityComponent;
			if (playerMapGravityComponent == null)
			{
				return;
			}
			playerMapGravityComponent.SetActive(active);
		}

		// Token: 0x060374A3 RID: 226467 RVA: 0x00D1EC63 File Offset: 0x00D1CE63
		[Conditional("DEBUG")]
		public void SetDebugMarkPosition(Vector2D position)
		{
		}

		// Token: 0x060374A4 RID: 226468 RVA: 0x00D1EC65 File Offset: 0x00D1CE65
		[Conditional("DEBUG")]
		public void SetDebugPath(TArray<FVector2D> debugPath)
		{
		}

		// Token: 0x060374A5 RID: 226469 RVA: 0x00D1EC67 File Offset: 0x00D1CE67
		public void SetMarkUnFocal(EMarkType markType, int markId)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.RefreshMarkRenderOrderBySelect(markType, markId, false);
		}

		// Token: 0x060374A6 RID: 226470 RVA: 0x00D1EC7C File Offset: 0x00D1CE7C
		public void SetMarkFocal(EMarkType markType, int markId)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.RefreshMarkRenderOrderBySelect(markType, markId, true);
		}

		// Token: 0x060374A7 RID: 226471 RVA: 0x00D1EC91 File Offset: 0x00D1CE91
		[return: Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		public List<ValueTuple<MarkItem, double>> FindNearbyMarkItemsByPosition(Vector position, float searchRadius, [Nullable(new byte[]
		{
			2,
			1
		})] Func<MarkItem, bool> filterFunction = null)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return null;
			}
			MapMarkContainer mapMarkContainer = mapMarkMgr.MapMarkContainer;
			if (mapMarkContainer == null)
			{
				return null;
			}
			return mapMarkContainer.FindNearbyMarkItemsByPosition(position, searchRadius, filterFunction);
		}

		// Token: 0x0401D20B RID: 119307
		public UUIItem SelfPlayerNode;

		// Token: 0x0401D20C RID: 119308
		public UUIItem PlayerArrow;

		// Token: 0x0401D20D RID: 119309
		public UUIItem PlayerOutOfBoundIndicator;

		// Token: 0x0401D20E RID: 119310
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x0401D20F RID: 119311
		private readonly float MapDefaultScale = 1f;

		// Token: 0x0401D210 RID: 119312
		private readonly float MarkScale = 1f;

		// Token: 0x0401D211 RID: 119313
		private MapMarkMgr MapMarkMgr;

		// Token: 0x0401D212 RID: 119314
		public MapTileMgr MapTileMgr;

		// Token: 0x0401D213 RID: 119315
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, UTexture> PreloadTiles;

		// Token: 0x0401D214 RID: 119316
		private readonly float ClickRange = 100f;

		// Token: 0x0401D215 RID: 119317
		private LevelSequencePlayer RangeItemLevelSequencePlayer;

		// Token: 0x0401D216 RID: 119318
		private bool LogicUiActive;

		// Token: 0x0401D219 RID: 119321
		private MapRangePanel MapRangePanelInner;

		// Token: 0x0401D21B RID: 119323
		private EMapGravityDirection MapGravityInternal;

		// Token: 0x0401D21C RID: 119324
		[Nullable(2)]
		private MarkGravityReverseIconComponent PlayerMapGravityComponent;

		// Token: 0x0401D21D RID: 119325
		[Nullable(2)]
		private MapRoadWaysMgr MapRoadWaysMgr;

		// Token: 0x0200B705 RID: 46853
		[NullableContext(0)]
		public static class EChildComponentType
		{
			// Token: 0x040376FF RID: 227071
			public const int Player = 0;

			// Token: 0x04037700 RID: 227072
			public const int PlayerArrow = 1;

			// Token: 0x04037701 RID: 227073
			public const int PlayerOutOfBoundIndicator = 2;

			// Token: 0x04037702 RID: 227074
			public const int MarkRoot = 3;

			// Token: 0x04037703 RID: 227075
			public const int TileContainer = 4;

			// Token: 0x04037704 RID: 227076
			public const int TileTexture = 5;

			// Token: 0x04037705 RID: 227077
			public const int ClickRangePrompt = 6;

			// Token: 0x04037706 RID: 227078
			public const int SubMapMaskItem = 7;

			// Token: 0x04037707 RID: 227079
			public const int SubMapTileItem = 8;

			// Token: 0x04037708 RID: 227080
			public const int TileTextureV2 = 9;

			// Token: 0x04037709 RID: 227081
			public const int FogUnlockAnchorItem = 10;

			// Token: 0x0403770A RID: 227082
			public const int DebugMark = 11;

			// Token: 0x0403770B RID: 227083
			public const int DebugPath = 12;

			// Token: 0x0403770C RID: 227084
			public const int RoadWayContainer = 13;
		}
	}
}
