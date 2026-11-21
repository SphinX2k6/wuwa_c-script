using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02004476 RID: 17526
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoadWaysMgr
	{
		// Token: 0x0602C471 RID: 181361 RVA: 0x00C71CD4 File Offset: 0x00C6FED4
		public MapRoadWaysMgr(MapRoadWaysMgrParams param)
		{
			this.MapId = param.MapId;
			this.InstanceDungeonId = param.InstanceDungeonId;
			this.Container = param.Container;
			EventSystem.Instance.Add(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnMapSetup));
			EventSystem.Instance.Add<int>(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Add<IReadOnlyDictionary<int, bool>>(EEventName.MapOpenFogFullUpdate, new Action<IReadOnlyDictionary<int, bool>>(this.OnMapOpenFogFullUpdate));
		}

		// Token: 0x0602C472 RID: 181362 RVA: 0x00C71D96 File Offset: 0x00C6FF96
		private void OnMapOpenFogChange(int i)
		{
			this.OnMapSetup();
		}

		// Token: 0x0602C473 RID: 181363 RVA: 0x00C71D9E File Offset: 0x00C6FF9E
		private void OnMapOpenFogFullUpdate(IReadOnlyDictionary<int, bool> readOnlyDictionary)
		{
			this.OnMapSetup();
		}

		// Token: 0x0602C474 RID: 181364 RVA: 0x00C71DA6 File Offset: 0x00C6FFA6
		public void OnMapSetup()
		{
			this.ClearRoadWays();
			this.LoadAllMapRoadWays().Forget();
		}

		// Token: 0x0602C475 RID: 181365 RVA: 0x00C71DBC File Offset: 0x00C6FFBC
		private void ClearRoadWays()
		{
			foreach (MapRoadWayView mapRoadWayView in this.RoadWays)
			{
				mapRoadWayView.SetUiActive(false);
				this.RoadWaysPool.Add(mapRoadWayView);
			}
			this.RoadWays.Clear();
		}

		// Token: 0x0602C476 RID: 181366 RVA: 0x00C71E28 File Offset: 0x00C70028
		private UniTask LoadAllMapRoadWays()
		{
			MapRoadWaysMgr.<LoadAllMapRoadWays>d__13 <LoadAllMapRoadWays>d__;
			<LoadAllMapRoadWays>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAllMapRoadWays>d__.<>4__this = this;
			<LoadAllMapRoadWays>d__.<>1__state = -1;
			<LoadAllMapRoadWays>d__.<>t__builder.Start<MapRoadWaysMgr.<LoadAllMapRoadWays>d__13>(ref <LoadAllMapRoadWays>d__);
			return <LoadAllMapRoadWays>d__.<>t__builder.Task;
		}

		// Token: 0x0602C477 RID: 181367 RVA: 0x00C71E6C File Offset: 0x00C7006C
		private unsafe bool CheckRoadWayValid(MapRoadWays config)
		{
			if (config.RoadBuildId > 0)
			{
				InfrastructureModel instance = InfrastructureModel.Instance;
				InfrastructureDefine.IInfrRoadData infrRoadData = (instance != null) ? instance.GetRoadDataByRoadId(config.RoadBuildId) : null;
				if (infrRoadData == null || infrRoadData.Status != InfrStatusPb.InfrStatusComplete)
				{
					return false;
				}
			}
			InstanceDungeon? config2 = InstanceDungeonConfig.Instance.GetConfig(this.InstanceDungeonId);
			int? num = (config2 != null) ? new int?(config2.GetValueOrDefault().MapConfigId) : null;
			int i = this.MapId;
			if ((num.GetValueOrDefault() == i & num != null) && !WorldMapConfig.Instance.IsMapInWorld(this.InstanceDungeonId) && !config.GetShowDungeonListBytes().Contains(this.InstanceDungeonId))
			{
				return false;
			}
			Span<int> fogIdArrayBytes = config.GetFogIdArrayBytes();
			for (i = 0; i < fogIdArrayBytes.Length; i++)
			{
				int fogId = *fogIdArrayBytes[i];
				if (!MapModel.Instance.CheckFogUnlocked(fogId, null))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602C478 RID: 181368 RVA: 0x00C71F6C File Offset: 0x00C7016C
		private UniTask LoadMapRoadWay(int mapId, string roadWayTexPath, float[] anchorOffset, float scale)
		{
			MapRoadWaysMgr.<LoadMapRoadWay>d__15 <LoadMapRoadWay>d__;
			<LoadMapRoadWay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMapRoadWay>d__.<>4__this = this;
			<LoadMapRoadWay>d__.mapId = mapId;
			<LoadMapRoadWay>d__.roadWayTexPath = roadWayTexPath;
			<LoadMapRoadWay>d__.anchorOffset = anchorOffset;
			<LoadMapRoadWay>d__.scale = scale;
			<LoadMapRoadWay>d__.<>1__state = -1;
			<LoadMapRoadWay>d__.<>t__builder.Start<MapRoadWaysMgr.<LoadMapRoadWay>d__15>(ref <LoadMapRoadWay>d__);
			return <LoadMapRoadWay>d__.<>t__builder.Task;
		}

		// Token: 0x0602C479 RID: 181369 RVA: 0x00C71FD0 File Offset: 0x00C701D0
		public void OnChangeWorldMap(int mapId)
		{
			this.MapId = mapId;
			this.OnMapSetup();
		}

		// Token: 0x0602C47A RID: 181370 RVA: 0x00C71FE0 File Offset: 0x00C701E0
		public void Dispose()
		{
			foreach (MapRoadWayView mapRoadWayView in this.RoadWays)
			{
				mapRoadWayView.Destroy(null);
			}
			this.RoadWays.Clear();
			foreach (MapRoadWayView mapRoadWayView2 in this.RoadWaysPool)
			{
				mapRoadWayView2.Destroy(null);
			}
			this.RoadWaysPool.Clear();
			EventSystem.Instance.Remove(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnMapSetup));
			EventSystem.Instance.Remove(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Remove(EEventName.MapOpenFogFullUpdate, new Action<IReadOnlyDictionary<int, bool>>(this.OnMapOpenFogFullUpdate));
		}

		// Token: 0x04017CDA RID: 97498
		private int MapId;

		// Token: 0x04017CDB RID: 97499
		private readonly int InstanceDungeonId;

		// Token: 0x04017CDC RID: 97500
		private readonly UUIItem Container;

		// Token: 0x04017CDD RID: 97501
		private readonly List<MapRoadWayView> RoadWays = new List<MapRoadWayView>();

		// Token: 0x04017CDE RID: 97502
		private readonly List<MapRoadWayView> RoadWaysPool = new List<MapRoadWayView>();

		// Token: 0x04017CDF RID: 97503
		private readonly Vector2D AnchorOffset = Vector2D.Create();

		// Token: 0x04017CE0 RID: 97504
		private readonly global::Vector Scale = global::Vector.Create();

		// Token: 0x04017CE1 RID: 97505
		private readonly string RoadWayPrefabPath = "/Game/Aki/UI/UIResources/UiWorldMap/Prefabs/UiItem_MapRoadWay_Prefab.UiItem_MapRoadWay_Prefab";
	}
}
