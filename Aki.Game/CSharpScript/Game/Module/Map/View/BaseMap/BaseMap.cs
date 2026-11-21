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
	// Token: 0x02004470 RID: 17520
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseMap : UiPanelBase
	{
		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x0602C3B9 RID: 181177 RVA: 0x00C6D7E1 File Offset: 0x00C6B9E1
		// (set) Token: 0x0602C3BA RID: 181178 RVA: 0x00C6D7E9 File Offset: 0x00C6B9E9
		public int MapId { get; set; }

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x0602C3BB RID: 181179 RVA: 0x00C6D7F2 File Offset: 0x00C6B9F2
		// (set) Token: 0x0602C3BC RID: 181180 RVA: 0x00C6D7FA File Offset: 0x00C6B9FA
		public int InstanceDungeonId { get; set; }

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x0602C3BD RID: 181181 RVA: 0x00C6D803 File Offset: 0x00C6BA03
		[Nullable(2)]
		public MapRangePanel MapRangePanel
		{
			[NullableContext(2)]
			get
			{
				return this.MapRangePanelInner;
			}
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x0602C3BE RID: 181182 RVA: 0x00C6D80B File Offset: 0x00C6BA0B
		// (set) Token: 0x0602C3BF RID: 181183 RVA: 0x00C6D813 File Offset: 0x00C6BA13
		[Nullable(2)]
		public AutoPilotLine AutoPilotLine { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x0602C3C0 RID: 181184 RVA: 0x00C6D81C File Offset: 0x00C6BA1C
		public UUIItem MapRootItem
		{
			get
			{
				return this.RootItem;
			}
		}

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x0602C3C1 RID: 181185 RVA: 0x00C6D824 File Offset: 0x00C6BA24
		public EMapGravityDirection MapGravity
		{
			get
			{
				return this.MapGravityInternal;
			}
		}

		// Token: 0x0602C3C2 RID: 181186 RVA: 0x00C6D82C File Offset: 0x00C6BA2C
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

		// Token: 0x0602C3C3 RID: 181187 RVA: 0x00C6D8F4 File Offset: 0x00C6BAF4
		public void Tick()
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.Tick();
		}

		// Token: 0x0602C3C4 RID: 181188 RVA: 0x00C6D908 File Offset: 0x00C6BB08
		public UniTask ChangeMapAsync(int mapId, EMapGravityDirection gravity)
		{
			BaseMap.<ChangeMapAsync>d__38 <ChangeMapAsync>d__;
			<ChangeMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsync>d__.<>4__this = this;
			<ChangeMapAsync>d__.mapId = mapId;
			<ChangeMapAsync>d__.gravity = gravity;
			<ChangeMapAsync>d__.<>1__state = -1;
			<ChangeMapAsync>d__.<>t__builder.Start<BaseMap.<ChangeMapAsync>d__38>(ref <ChangeMapAsync>d__);
			return <ChangeMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3C5 RID: 181189 RVA: 0x00C6D95C File Offset: 0x00C6BB5C
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
			this.MapMarkDisposeTask = ((mapMarkMgr != null) ? new UniTask?(mapMarkMgr.DisposeAsync()) : null);
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

		// Token: 0x0602C3C6 RID: 181190 RVA: 0x00C6DA14 File Offset: 0x00C6BC14
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			BaseMap.<OnDestroyAsyncImplementImplement>d__40 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<BaseMap.<OnDestroyAsyncImplementImplement>d__40>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3C7 RID: 181191 RVA: 0x00C6DA58 File Offset: 0x00C6BC58
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

		// Token: 0x0602C3C8 RID: 181192 RVA: 0x00C6DC54 File Offset: 0x00C6BE54
		protected override UniTask OnBeforeStartAsync()
		{
			BaseMap.<OnBeforeStartAsync>d__42 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BaseMap.<OnBeforeStartAsync>d__42>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3C9 RID: 181193 RVA: 0x00C6DC98 File Offset: 0x00C6BE98
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

		// Token: 0x0602C3CA RID: 181194 RVA: 0x00C6DD4C File Offset: 0x00C6BF4C
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

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x0602C3CB RID: 181195 RVA: 0x00C6DEDB File Offset: 0x00C6C0DB
		public UUIItem MarkContainer
		{
			get
			{
				return base.GetItem(3);
			}
		}

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x0602C3CC RID: 181196 RVA: 0x00C6DEE4 File Offset: 0x00C6C0E4
		public UUIItem FogUnlockAnchorItem
		{
			get
			{
				return base.GetItem(10);
			}
		}

		// Token: 0x0602C3CD RID: 181197 RVA: 0x00C6DEEE File Offset: 0x00C6C0EE
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

		// Token: 0x0602C3CE RID: 181198 RVA: 0x00C6DF2C File Offset: 0x00C6C12C
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

		// Token: 0x0602C3CF RID: 181199 RVA: 0x00C6DF7C File Offset: 0x00C6C17C
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

		// Token: 0x0602C3D0 RID: 181200 RVA: 0x00C6DFEC File Offset: 0x00C6C1EC
		private UniTask SetUpWorldMapAsync()
		{
			BaseMap.<SetUpWorldMapAsync>d__52 <SetUpWorldMapAsync>d__;
			<SetUpWorldMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetUpWorldMapAsync>d__.<>4__this = this;
			<SetUpWorldMapAsync>d__.<>1__state = -1;
			<SetUpWorldMapAsync>d__.<>t__builder.Start<BaseMap.<SetUpWorldMapAsync>d__52>(ref <SetUpWorldMapAsync>d__);
			return <SetUpWorldMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3D1 RID: 181201 RVA: 0x00C6E02F File Offset: 0x00C6C22F
		public Dictionary<EMarkType, Dictionary<int, MarkItem>> GetAllMarkItems()
		{
			return this.MapMarkMgr.GetAllMarkItems();
		}

		// Token: 0x0602C3D2 RID: 181202 RVA: 0x00C6E03C File Offset: 0x00C6C23C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, MarkItem> GetMarkItemsByType(EMarkType markType, bool withCrossMap = true)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return null;
			}
			return mapMarkMgr.GetMarkItemsByType(markType, withCrossMap);
		}

		// Token: 0x0602C3D3 RID: 181203 RVA: 0x00C6E051 File Offset: 0x00C6C251
		public List<MarkItem> GetMarkItemsByClickPosition(Vector clickPosition, int cellRadius = 1)
		{
			return this.MapMarkMgr.GetMarkItemsByClickPosition(clickPosition, cellRadius);
		}

		// Token: 0x0602C3D4 RID: 181204 RVA: 0x00C6E060 File Offset: 0x00C6C260
		[NullableContext(2)]
		public MarkItem GetMarkItem(EMarkType markType, int markId)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return null;
			}
			return mapMarkMgr.GetMarkItem(markType, markId);
		}

		// Token: 0x0602C3D5 RID: 181205 RVA: 0x00C6E075 File Offset: 0x00C6C275
		public CustomMarkItem CreateCustomMark(DynamicMarkCreateInfo info)
		{
			return this.MapMarkMgr.CreateDynamicMark(info, true) as CustomMarkItem;
		}

		// Token: 0x0602C3D6 RID: 181206 RVA: 0x00C6E089 File Offset: 0x00C6C289
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

		// Token: 0x0602C3D7 RID: 181207 RVA: 0x00C6E099 File Offset: 0x00C6C299
		public List<MarkItem> GetTrackMenuMarkList()
		{
			return this.MapMarkMgr.GetTrackMenuMarkList();
		}

		// Token: 0x0602C3D8 RID: 181208 RVA: 0x00C6E0A6 File Offset: 0x00C6C2A6
		public List<MarkItem> GetNavigateMarkList()
		{
			return this.MapMarkMgr.GetNavigateMarkList();
		}

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x0602C3D9 RID: 181209 RVA: 0x00C6E0B4 File Offset: 0x00C6C2B4
		public Vector4? MapOffset
		{
			get
			{
				MapTileMgr mapTileMgr = this.MapTileMgr;
				if (mapTileMgr == null)
				{
					return null;
				}
				return new Vector4?(mapTileMgr.MapOffset);
			}
		}

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x0602C3DA RID: 181210 RVA: 0x00C6E0DF File Offset: 0x00C6C2DF
		public float FakeOffset
		{
			get
			{
				return this.MapTileMgr.FakeOffset;
			}
		}

		// Token: 0x0602C3DB RID: 181211 RVA: 0x00C6E0EC File Offset: 0x00C6C2EC
		public void ShowSubMapTile(int groupId, int layer, bool fastTween = false)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.ShowSubMapByPosition(groupId, layer, fastTween);
		}

		// Token: 0x0602C3DC RID: 181212 RVA: 0x00C6E101 File Offset: 0x00C6C301
		public void HideSubMapTile()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HideSubMap();
		}

		// Token: 0x0602C3DD RID: 181213 RVA: 0x00C6E113 File Offset: 0x00C6C313
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MapTileItem> GetAllMapTileItems()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return null;
			}
			return mapTileMgr.GetMapTileItems();
		}

		// Token: 0x0602C3DE RID: 181214 RVA: 0x00C6E126 File Offset: 0x00C6C326
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

		// Token: 0x0602C3DF RID: 181215 RVA: 0x00C6E139 File Offset: 0x00C6C339
		public int GetMultiMapAreaIdByPosition(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return 0;
			}
			return mapTileMgr.GetMultiMapAreaIdByPosition(position);
		}

		// Token: 0x0602C3E0 RID: 181216 RVA: 0x00C6E14D File Offset: 0x00C6C34D
		public int GetSubMapGroupByPosition(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return 0;
			}
			return mapTileMgr.GetSubMapGroupByPosition(position);
		}

		// Token: 0x0602C3E1 RID: 181217 RVA: 0x00C6E164 File Offset: 0x00C6C364
		public int GetWorldMapCenterAreaId()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			Vector vector = (mapTileMgr != null) ? mapTileMgr.GetWorldMapCenterPosition() : null;
			if (vector == null)
			{
				return 0;
			}
			return this.MapTileMgr.GetMultiMapAreaIdByPosition(vector);
		}

		// Token: 0x0602C3E2 RID: 181218 RVA: 0x00C6E195 File Offset: 0x00C6C395
		public void UpdateCurrentAreaMapGroupId(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateCurrentAreaMapGroupId(position);
		}

		// Token: 0x0602C3E3 RID: 181219 RVA: 0x00C6E1A8 File Offset: 0x00C6C3A8
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

		// Token: 0x0602C3E4 RID: 181220 RVA: 0x00C6E1D0 File Offset: 0x00C6C3D0
		public void HandleFogAreaOpen(int fogId)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HandleFogAreaOpen(fogId);
		}

		// Token: 0x0602C3E5 RID: 181221 RVA: 0x00C6E1E3 File Offset: 0x00C6C3E3
		public void HandleMapTileDelegate()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.HandleDelegate();
		}

		// Token: 0x0602C3E6 RID: 181222 RVA: 0x00C6E1F5 File Offset: 0x00C6C3F5
		public void UnBindMapTileDelegate()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UnBindDelegate();
		}

		// Token: 0x0602C3E7 RID: 181223 RVA: 0x00C6E208 File Offset: 0x00C6C408
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

		// Token: 0x0602C3E8 RID: 181224 RVA: 0x00C6E2F0 File Offset: 0x00C6C4F0
		[NullableContext(2)]
		public void SetClickRangeVisible(bool visible, Vector2D clickUiPosition = null)
		{
			if (clickUiPosition == null)
			{
				clickUiPosition = Vector2D.Create(0.0, 0.0);
			}
			this.PlaySequenceAndSetActive(visible, clickUiPosition).Forget<bool>();
		}

		// Token: 0x0602C3E9 RID: 181225 RVA: 0x00C6E31C File Offset: 0x00C6C51C
		[NullableContext(0)]
		private UniTask<bool> PlaySequenceAndSetActive(bool bActive, [Nullable(1)] Vector2D clickUiPosition)
		{
			BaseMap.<PlaySequenceAndSetActive>d__79 <PlaySequenceAndSetActive>d__;
			<PlaySequenceAndSetActive>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlaySequenceAndSetActive>d__.<>4__this = this;
			<PlaySequenceAndSetActive>d__.bActive = bActive;
			<PlaySequenceAndSetActive>d__.clickUiPosition = clickUiPosition;
			<PlaySequenceAndSetActive>d__.<>1__state = -1;
			<PlaySequenceAndSetActive>d__.<>t__builder.Start<BaseMap.<PlaySequenceAndSetActive>d__79>(ref <PlaySequenceAndSetActive>d__);
			return <PlaySequenceAndSetActive>d__.<>t__builder.Task;
		}

		// Token: 0x0602C3EA RID: 181226 RVA: 0x00C6E36F File Offset: 0x00C6C56F
		public bool InValidMapTile(Vector worldPosition)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			return mapTileMgr != null && mapTileMgr.InValidTile(worldPosition);
		}

		// Token: 0x0602C3EB RID: 181227 RVA: 0x00C6E383 File Offset: 0x00C6C583
		public void UpdateDraggableParams(ITileNum tileNum)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateDraggableParams(tileNum);
		}

		// Token: 0x0602C3EC RID: 181228 RVA: 0x00C6E396 File Offset: 0x00C6C596
		public void ResetDraggableParams()
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.ResetDraggableParams();
		}

		// Token: 0x0602C3ED RID: 181229 RVA: 0x00C6E3A8 File Offset: 0x00C6C5A8
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

		// Token: 0x0602C3EE RID: 181230 RVA: 0x00C6E3CB File Offset: 0x00C6C5CB
		[Conditional("DEBUG")]
		public void SetDebugMarkPosition(Vector2D position)
		{
		}

		// Token: 0x0602C3EF RID: 181231 RVA: 0x00C6E3CD File Offset: 0x00C6C5CD
		[Conditional("DEBUG")]
		public void SetDebugPath(TArray<FVector2D> debugPath)
		{
		}

		// Token: 0x0602C3F0 RID: 181232 RVA: 0x00C6E3CF File Offset: 0x00C6C5CF
		public void SetMarkUnFocal(EMarkType markType, int markId)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.RefreshMarkRenderOrderBySelect(markType, markId, false);
		}

		// Token: 0x0602C3F1 RID: 181233 RVA: 0x00C6E3E4 File Offset: 0x00C6C5E4
		public void SetMarkFocal(EMarkType markType, int markId)
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr == null)
			{
				return;
			}
			mapMarkMgr.RefreshMarkRenderOrderBySelect(markType, markId, true);
		}

		// Token: 0x0602C3F2 RID: 181234 RVA: 0x00C6E3F9 File Offset: 0x00C6C5F9
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

		// Token: 0x04017CA4 RID: 97444
		public UUIItem SelfPlayerNode;

		// Token: 0x04017CA5 RID: 97445
		public UUIItem PlayerArrow;

		// Token: 0x04017CA6 RID: 97446
		public UUIItem PlayerOutOfBoundIndicator;

		// Token: 0x04017CA7 RID: 97447
		public EMapType MapType = EMapType.WorldMap;

		// Token: 0x04017CA8 RID: 97448
		private readonly float MapDefaultScale = 1f;

		// Token: 0x04017CA9 RID: 97449
		private readonly float MarkScale = 1f;

		// Token: 0x04017CAA RID: 97450
		[Nullable(2)]
		private MapMarkMgr MapMarkMgr;

		// Token: 0x04017CAB RID: 97451
		[Nullable(2)]
		public MapTileMgr MapTileMgr;

		// Token: 0x04017CAC RID: 97452
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, UTexture> PreloadTiles;

		// Token: 0x04017CAD RID: 97453
		private readonly float ClickRange = 100f;

		// Token: 0x04017CAE RID: 97454
		private LevelSequencePlayer RangeItemLevelSequencePlayer;

		// Token: 0x04017CAF RID: 97455
		private bool LogicUiActive;

		// Token: 0x04017CB2 RID: 97458
		[Nullable(2)]
		private MapRangePanel MapRangePanelInner;

		// Token: 0x04017CB4 RID: 97460
		private EMapGravityDirection MapGravityInternal;

		// Token: 0x04017CB5 RID: 97461
		[Nullable(2)]
		private MarkGravityReverseIconComponent PlayerMapGravityComponent;

		// Token: 0x04017CB6 RID: 97462
		[Nullable(2)]
		private MapRoadWaysMgr MapRoadWaysMgr;

		// Token: 0x04017CB7 RID: 97463
		private UniTask? MapMarkDisposeTask;

		// Token: 0x0200A137 RID: 41271
		[NullableContext(0)]
		public static class EChildComponentType
		{
			// Token: 0x04032147 RID: 205127
			public const int Player = 0;

			// Token: 0x04032148 RID: 205128
			public const int PlayerArrow = 1;

			// Token: 0x04032149 RID: 205129
			public const int PlayerOutOfBoundIndicator = 2;

			// Token: 0x0403214A RID: 205130
			public const int MarkRoot = 3;

			// Token: 0x0403214B RID: 205131
			public const int TileContainer = 4;

			// Token: 0x0403214C RID: 205132
			public const int TileTexture = 5;

			// Token: 0x0403214D RID: 205133
			public const int ClickRangePrompt = 6;

			// Token: 0x0403214E RID: 205134
			public const int SubMapMaskItem = 7;

			// Token: 0x0403214F RID: 205135
			public const int SubMapTileItem = 8;

			// Token: 0x04032150 RID: 205136
			public const int TileTextureV2 = 9;

			// Token: 0x04032151 RID: 205137
			public const int FogUnlockAnchorItem = 10;

			// Token: 0x04032152 RID: 205138
			public const int DebugMark = 11;

			// Token: 0x04032153 RID: 205139
			public const int DebugPath = 12;

			// Token: 0x04032154 RID: 205140
			public const int RoadWayContainer = 13;
		}
	}
}
