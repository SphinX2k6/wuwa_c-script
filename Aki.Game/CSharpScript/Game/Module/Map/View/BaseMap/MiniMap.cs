using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.SubView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x0200548F RID: 21647
	[NullableContext(1)]
	[Nullable(0)]
	public class MiniMap : UiPanelBase
	{
		// Token: 0x1700848D RID: 33933
		// (get) Token: 0x060374AE RID: 226478 RVA: 0x00D1ED63 File Offset: 0x00D1CF63
		// (set) Token: 0x060374AF RID: 226479 RVA: 0x00D1ED6B File Offset: 0x00D1CF6B
		public int MapId { get; set; }

		// Token: 0x1700848E RID: 33934
		// (get) Token: 0x060374B0 RID: 226480 RVA: 0x00D1ED74 File Offset: 0x00D1CF74
		// (set) Token: 0x060374B1 RID: 226481 RVA: 0x00D1ED7C File Offset: 0x00D1CF7C
		public int InstanceDungeonId { get; set; }

		// Token: 0x1700848F RID: 33935
		// (get) Token: 0x060374B2 RID: 226482 RVA: 0x00D1ED85 File Offset: 0x00D1CF85
		public EMapGravityDirection MapGravity
		{
			get
			{
				return MapModel.Instance.CurrentPlayerGravity;
			}
		}

		// Token: 0x060374B3 RID: 226483 RVA: 0x00D1ED94 File Offset: 0x00D1CF94
		public MiniMap(EMapType mapType, int instanceId, float mapDefaultScale, float? markScale = null, Dictionary<string, UTexture> preloadTiles = null)
		{
			this.MapType = mapType;
			this.InstanceDungeonId = instanceId;
			this.MapId = MapModel.Instance.GetDungeonMapConfigId(instanceId);
			this.MapDefaultScale = mapDefaultScale;
			this.MarkScale = markScale.GetValueOrDefault(1f);
			this.PreloadTiles = preloadTiles;
		}

		// Token: 0x060374B4 RID: 226484 RVA: 0x00D1EE14 File Offset: 0x00D1D014
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
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
			this.MapSoundBoxSfxMgr = null;
			MapRangePanel mapRangePanel = this.MapRangePanel;
			if (mapRangePanel != null)
			{
				mapRangePanel.Destroy();
			}
			this.MapRangePanel = null;
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

		// Token: 0x060374B5 RID: 226485 RVA: 0x00D1EEA8 File Offset: 0x00D1D0A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060374B6 RID: 226486 RVA: 0x00D1EFD8 File Offset: 0x00D1D1D8
		protected override void OnStart()
		{
			this.SetMapScale(this.MapDefaultScale);
			this.InitAssistants(this.MarkScale);
			this.BindEvents();
			this.RootItem.SetUIActive(false);
			this.RootItem.SetHierarchyIndex(0);
			this.MapRangePanel = new MapRangePanel(this);
			this.MapRangePanel.CheckExploreMarkRangeInfo();
			this.AutoPilotLine = new AutoPilotLine(this);
			AutoPilotLine autoPilotLine = this.AutoPilotLine;
			if (autoPilotLine == null)
			{
				return;
			}
			autoPilotLine.CheckAutoPilotLineInfo();
		}

		// Token: 0x060374B7 RID: 226487 RVA: 0x00D1F058 File Offset: 0x00D1D258
		private void InitAssistants(float markScale)
		{
			UUIItem item = base.GetItem(0);
			UUIItem item2 = base.GetItem(1);
			UUITexture texture = base.GetTexture(2);
			UUIItem item3 = base.GetItem(3);
			UUITexture texture2 = base.GetTexture(4);
			texture.SetUIActive(false);
			if (MiniMapStatic.Instance.MapMaterialVersion == 2)
			{
				texture = base.GetTexture(6);
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
			}
			UUIItem item4 = base.GetItem(5);
			MapMarkMgrParams param = new MapMarkMgrParams
			{
				MapType = this.MapType,
				MapId = this.MapId,
				InstanceDungeonId = this.InstanceDungeonId,
				MarkContainer = item,
				MarkScale = markScale
			};
			this.MapMarkMgr = new MapMarkMgr(param);
			this.MapMarkMgr.Initialize();
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
				MapVersion = MiniMapStatic.Instance.MapMaterialVersion,
				PreloadTiles = this.PreloadTiles,
				SubMapMask = item4
			};
			this.MapTileMgr = new MapTileMgr(tileMgrParams);
			this.MapTileMgr.Initialize();
			this.MapSoundBoxSfxMgr = new MapSoundBoxSfxMgr();
			this.MapRoadWaysMgr = new MapRoadWaysMgr(new MapRoadWaysMgrParams
			{
				MapId = this.MapId,
				InstanceDungeonId = this.InstanceDungeonId,
				Container = base.GetItem(7)
			});
		}

		// Token: 0x060374B8 RID: 226488 RVA: 0x00D1F1DE File Offset: 0x00D1D3DE
		private void BindEvents()
		{
			if (GameModeModel.Instance.WorldDone)
			{
				this.SetUp();
				return;
			}
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.SetUp));
		}

		// Token: 0x060374B9 RID: 226489 RVA: 0x00D1F20F File Offset: 0x00D1D40F
		protected void UnBindEvents()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.SetUp)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.SetUp));
			}
		}

		// Token: 0x060374BA RID: 226490 RVA: 0x00D1F24C File Offset: 0x00D1D44C
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

		// Token: 0x060374BB RID: 226491 RVA: 0x00D1F2BC File Offset: 0x00D1D4BC
		public void MiniMapUpdateMarkItems(Vector2D anchorOffset, float realScale, Vector playerLocation)
		{
			MiniMap.<>c__DisplayClass31_0 CS$<>8__locals1 = new MiniMap.<>c__DisplayClass31_0();
			CS$<>8__locals1.playerLocation = playerLocation;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.realScale = realScale;
			CS$<>8__locals1.anchorOffset = anchorOffset;
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr != null)
			{
				mapMarkMgr.UpdateNearbyMarkItem(CS$<>8__locals1.playerLocation, new Action<MarkItem>(CS$<>8__locals1.<MiniMapUpdateMarkItems>g__UpdateFunction|0), new Action<MarkItem>(CS$<>8__locals1.<MiniMapUpdateMarkItems>g__OnExitFunction|1));
			}
			MapRangePanel mapRangePanel = this.MapRangePanel;
			if (mapRangePanel == null)
			{
				return;
			}
			mapRangePanel.MiniMapUpdate();
		}

		// Token: 0x060374BC RID: 226492 RVA: 0x00D1F32C File Offset: 0x00D1D52C
		private static void SetMarkItemPosition(MarkItem markItem, Vector2D position)
		{
			MarkItemView view = markItem.View;
			if (view != null && !view.IsCreating)
			{
				UUIItem rootItem = view.GetRootItem();
				if (rootItem != null && rootItem.IsValid() && markItem.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.MarkView, false))
				{
					rootItem.SetAnchorOffset(position.ToUeVector2D(false));
					return;
				}
			}
			else
			{
				markItem.GetRootItemAsync().ContinueWith(delegate(UUIItem markUiItem)
				{
					if (markUiItem != null && markUiItem.IsValid() && markItem.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.MarkView, false))
					{
						markUiItem.SetAnchorOffset(position.ToUeVector2D(false));
					}
				}).Forget();
			}
		}

		// Token: 0x060374BD RID: 226493 RVA: 0x00D1F3C3 File Offset: 0x00D1D5C3
		public void Tick()
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr != null)
			{
				mapMarkMgr.Tick();
			}
			AutoPilotLine autoPilotLine = this.AutoPilotLine;
			if (autoPilotLine == null)
			{
				return;
			}
			autoPilotLine.OnMiniMapTick();
		}

		// Token: 0x060374BE RID: 226494 RVA: 0x00D1F3E6 File Offset: 0x00D1D5E6
		public void UpdateMinimapTiles(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateMinimapTiles(position);
		}

		// Token: 0x060374BF RID: 226495 RVA: 0x00D1F3F9 File Offset: 0x00D1D5F9
		public void SetMapScale(float scale)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.D_SetWorldScale3D(new FVectorDouble((double)scale, (double)scale, (double)scale));
		}

		// Token: 0x060374C0 RID: 226496 RVA: 0x00D1F416 File Offset: 0x00D1D616
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

		// Token: 0x060374C1 RID: 226497 RVA: 0x00D1F42C File Offset: 0x00D1D62C
		public UniTask ChangeMapAsync(int mapId)
		{
			MiniMap.<ChangeMapAsync>d__37 <ChangeMapAsync>d__;
			<ChangeMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsync>d__.<>4__this = this;
			<ChangeMapAsync>d__.mapId = mapId;
			<ChangeMapAsync>d__.<>1__state = -1;
			<ChangeMapAsync>d__.<>t__builder.Start<MiniMap.<ChangeMapAsync>d__37>(ref <ChangeMapAsync>d__);
			return <ChangeMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060374C2 RID: 226498 RVA: 0x00D1F477 File Offset: 0x00D1D677
		public UUIItem MarkContainer()
		{
			return base.GetItem(0);
		}

		// Token: 0x0401D220 RID: 119328
		public EMapType MapType;

		// Token: 0x0401D223 RID: 119331
		[Nullable(2)]
		private MapMarkMgr MapMarkMgr;

		// Token: 0x0401D224 RID: 119332
		[Nullable(2)]
		public MapTileMgr MapTileMgr;

		// Token: 0x0401D225 RID: 119333
		[Nullable(2)]
		private MapSoundBoxSfxMgr MapSoundBoxSfxMgr;

		// Token: 0x0401D226 RID: 119334
		private readonly Dictionary<string, UTexture> PreloadTiles;

		// Token: 0x0401D227 RID: 119335
		private readonly float MapDefaultScale = 1f;

		// Token: 0x0401D228 RID: 119336
		private readonly float MarkScale = 1f;

		// Token: 0x0401D229 RID: 119337
		[Nullable(2)]
		private MapRangePanel MapRangePanel;

		// Token: 0x0401D22A RID: 119338
		private AutoPilotLine AutoPilotLine;

		// Token: 0x0401D22B RID: 119339
		[Nullable(2)]
		private MapRoadWaysMgr MapRoadWaysMgr;

		// Token: 0x0401D22C RID: 119340
		private readonly Vector2D CachedMarkItemUi2dPosition = Vector2D.Create();

		// Token: 0x0401D22D RID: 119341
		private readonly Vector2D CachedOffset = Vector2D.Create();

		// Token: 0x0200B70C RID: 46860
		[NullableContext(0)]
		public static class EChildComponentType
		{
			// Token: 0x04037727 RID: 227111
			public const int MarkRoot = 0;

			// Token: 0x04037728 RID: 227112
			public const int TileContainer = 1;

			// Token: 0x04037729 RID: 227113
			public const int TileTexture = 2;

			// Token: 0x0403772A RID: 227114
			public const int SubMapTileContainer = 3;

			// Token: 0x0403772B RID: 227115
			public const int SubMapTileTexture = 4;

			// Token: 0x0403772C RID: 227116
			public const int SubMapMask = 5;

			// Token: 0x0403772D RID: 227117
			public const int TileTextureV2 = 6;

			// Token: 0x0403772E RID: 227118
			public const int RoadWayContainer = 7;
		}
	}
}
