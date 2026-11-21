using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue;
using CSharpScript.Game.Module.Map.View.SubView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap
{
	// Token: 0x02004472 RID: 17522
	[NullableContext(1)]
	[Nullable(0)]
	public class MiniMap : UiPanelBase
	{
		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x0602C3FA RID: 181242 RVA: 0x00C6E4D3 File Offset: 0x00C6C6D3
		// (set) Token: 0x0602C3FB RID: 181243 RVA: 0x00C6E4DB File Offset: 0x00C6C6DB
		public int MapId { get; set; }

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x0602C3FC RID: 181244 RVA: 0x00C6E4E4 File Offset: 0x00C6C6E4
		// (set) Token: 0x0602C3FD RID: 181245 RVA: 0x00C6E4EC File Offset: 0x00C6C6EC
		public int InstanceDungeonId { get; set; }

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x0602C3FE RID: 181246 RVA: 0x00C6E4F5 File Offset: 0x00C6C6F5
		public EMapGravityDirection MapGravity
		{
			get
			{
				return MapModel.Instance.CurrentPlayerGravity;
			}
		}

		// Token: 0x0602C3FF RID: 181247 RVA: 0x00C6E504 File Offset: 0x00C6C704
		public MiniMap(EMapType mapType, int instanceId, float mapDefaultScale, float? markScale = null, Dictionary<string, UTexture> preloadTiles = null)
		{
			this.MapType = mapType;
			this.InstanceDungeonId = instanceId;
			this.MapId = MapModel.Instance.GetDungeonMapConfigId(instanceId);
			this.MapDefaultScale = mapDefaultScale;
			this.MarkScale = markScale.GetValueOrDefault(1f);
			this.PreloadTiles = preloadTiles;
		}

		// Token: 0x0602C400 RID: 181248 RVA: 0x00C6E594 File Offset: 0x00C6C794
		protected override void OnBeforeDestroy()
		{
			this.UnBindEvents();
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			this.MapMarkDisposeTask = ((mapMarkMgr != null) ? new UniTask?(mapMarkMgr.DisposeAsync()) : null);
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
			this.MapGamePlayRequestPreemptiveFrameQueue.Dispose();
		}

		// Token: 0x0602C401 RID: 181249 RVA: 0x00C6E648 File Offset: 0x00C6C848
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			MiniMap.<OnDestroyAsyncImplementImplement>d__27 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<MiniMap.<OnDestroyAsyncImplementImplement>d__27>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602C402 RID: 181250 RVA: 0x00C6E68C File Offset: 0x00C6C88C
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

		// Token: 0x0602C403 RID: 181251 RVA: 0x00C6E7BC File Offset: 0x00C6C9BC
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

		// Token: 0x0602C404 RID: 181252 RVA: 0x00C6E83C File Offset: 0x00C6CA3C
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

		// Token: 0x0602C405 RID: 181253 RVA: 0x00C6E9C2 File Offset: 0x00C6CBC2
		private void BindEvents()
		{
			if (GameModeModel.Instance.WorldDone)
			{
				this.SetUp();
				return;
			}
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.SetUp));
		}

		// Token: 0x0602C406 RID: 181254 RVA: 0x00C6E9F3 File Offset: 0x00C6CBF3
		protected void UnBindEvents()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.SetUp)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.SetUp));
			}
		}

		// Token: 0x0602C407 RID: 181255 RVA: 0x00C6EA30 File Offset: 0x00C6CC30
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

		// Token: 0x0602C408 RID: 181256 RVA: 0x00C6EAA0 File Offset: 0x00C6CCA0
		public void MiniMapUpdateMarkItems(Vector2D anchorOffset, float realScale, Vector playerLocation)
		{
			MiniMap.<>c__DisplayClass34_0 CS$<>8__locals1 = new MiniMap.<>c__DisplayClass34_0();
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

		// Token: 0x0602C409 RID: 181257 RVA: 0x00C6EB10 File Offset: 0x00C6CD10
		private static void SetMarkItemPosition(MarkItem markItem, Vector2D position)
		{
			MarkItemView view = markItem.View;
			if (view != null && !view.IsCreating)
			{
				UUIItem rootItem = view.GetRootItem();
				if (rootItem != null && rootItem.IsValid() && markItem.ShowMarkView)
				{
					rootItem.SetAnchorOffset(position.ToUeVector2D(false));
					return;
				}
			}
			else
			{
				markItem.GetRootItemAsync().ContinueWith(delegate(UUIItem markUiItem)
				{
					if (markUiItem != null && markUiItem.IsValid() && markItem.ShowMarkView)
					{
						markUiItem.SetAnchorOffset(position.ToUeVector2D(false));
					}
				}).Forget();
			}
		}

		// Token: 0x0602C40A RID: 181258 RVA: 0x00C6EB9B File Offset: 0x00C6CD9B
		public void Tick()
		{
			MapMarkMgr mapMarkMgr = this.MapMarkMgr;
			if (mapMarkMgr != null)
			{
				mapMarkMgr.Tick();
			}
			this.MapGamePlayRequestPreemptiveFrameQueue.Process();
			AutoPilotLine autoPilotLine = this.AutoPilotLine;
			if (autoPilotLine == null)
			{
				return;
			}
			autoPilotLine.OnMiniMapTick();
		}

		// Token: 0x0602C40B RID: 181259 RVA: 0x00C6EBC9 File Offset: 0x00C6CDC9
		public void UpdateMinimapTiles(Vector position)
		{
			MapTileMgr mapTileMgr = this.MapTileMgr;
			if (mapTileMgr == null)
			{
				return;
			}
			mapTileMgr.UpdateMinimapTiles(position);
		}

		// Token: 0x0602C40C RID: 181260 RVA: 0x00C6EBDC File Offset: 0x00C6CDDC
		public void SetMapScale(float scale)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.D_SetWorldScale3D(new FVectorDouble((double)scale, (double)scale, (double)scale));
		}

		// Token: 0x0602C40D RID: 181261 RVA: 0x00C6EBF9 File Offset: 0x00C6CDF9
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

		// Token: 0x0602C40E RID: 181262 RVA: 0x00C6EC10 File Offset: 0x00C6CE10
		public UniTask ChangeMapAsync(int mapId)
		{
			MiniMap.<ChangeMapAsync>d__40 <ChangeMapAsync>d__;
			<ChangeMapAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsync>d__.<>4__this = this;
			<ChangeMapAsync>d__.mapId = mapId;
			<ChangeMapAsync>d__.<>1__state = -1;
			<ChangeMapAsync>d__.<>t__builder.Start<MiniMap.<ChangeMapAsync>d__40>(ref <ChangeMapAsync>d__);
			return <ChangeMapAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C40F RID: 181263 RVA: 0x00C6EC5B File Offset: 0x00C6CE5B
		public UUIItem MarkContainer()
		{
			return base.GetItem(0);
		}

		// Token: 0x04017CBA RID: 97466
		public EMapType MapType;

		// Token: 0x04017CBD RID: 97469
		[Nullable(2)]
		private MapMarkMgr MapMarkMgr;

		// Token: 0x04017CBE RID: 97470
		[Nullable(2)]
		public MapTileMgr MapTileMgr;

		// Token: 0x04017CBF RID: 97471
		[Nullable(2)]
		private MapSoundBoxSfxMgr MapSoundBoxSfxMgr;

		// Token: 0x04017CC0 RID: 97472
		private readonly Dictionary<string, UTexture> PreloadTiles;

		// Token: 0x04017CC1 RID: 97473
		private readonly float MapDefaultScale = 1f;

		// Token: 0x04017CC2 RID: 97474
		private readonly float MarkScale = 1f;

		// Token: 0x04017CC3 RID: 97475
		[Nullable(2)]
		private MapRangePanel MapRangePanel;

		// Token: 0x04017CC4 RID: 97476
		[Nullable(2)]
		private AutoPilotLine AutoPilotLine;

		// Token: 0x04017CC5 RID: 97477
		[Nullable(2)]
		private MapRoadWaysMgr MapRoadWaysMgr;

		// Token: 0x04017CC6 RID: 97478
		private readonly MapGamePlayRequestPreemptiveFrameQueue MapGamePlayRequestPreemptiveFrameQueue = new MapGamePlayRequestPreemptiveFrameQueue(200, 0);

		// Token: 0x04017CC7 RID: 97479
		private UniTask? MapMarkDisposeTask;

		// Token: 0x04017CC8 RID: 97480
		private readonly Vector2D CachedMarkItemUi2dPosition = Vector2D.Create();

		// Token: 0x04017CC9 RID: 97481
		private readonly Vector2D CachedOffset = Vector2D.Create();

		// Token: 0x0200A13F RID: 41279
		[NullableContext(0)]
		public static class EChildComponentType
		{
			// Token: 0x04032173 RID: 205171
			public const int MarkRoot = 0;

			// Token: 0x04032174 RID: 205172
			public const int TileContainer = 1;

			// Token: 0x04032175 RID: 205173
			public const int TileTexture = 2;

			// Token: 0x04032176 RID: 205174
			public const int SubMapTileContainer = 3;

			// Token: 0x04032177 RID: 205175
			public const int SubMapTileTexture = 4;

			// Token: 0x04032178 RID: 205176
			public const int SubMapMask = 5;

			// Token: 0x04032179 RID: 205177
			public const int TileTextureV2 = 6;

			// Token: 0x0403217A RID: 205178
			public const int RoadWayContainer = 7;
		}
	}
}
