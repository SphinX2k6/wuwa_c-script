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
	// Token: 0x02005493 RID: 21651
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoadWaysMgr
	{
		// Token: 0x0603751B RID: 226587 RVA: 0x00D22118 File Offset: 0x00D20318
		public MapRoadWaysMgr(MapRoadWaysMgrParams param)
		{
			this.MapId = param.MapId;
			this.InstanceDungeonId = param.InstanceDungeonId;
			this.Container = param.Container;
			EventSystem.Instance.Add(EEventName.InfrastructureRoadDataUpdate, new Action(this.OnMapSetup));
			EventSystem.Instance.Add<int>(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Add<IReadOnlyDictionary<int, bool>>(EEventName.MapOpenFogFullUpdate, new Action<IReadOnlyDictionary<int, bool>>(this.OnMapOpenFogFullUpdate));
		}

		// Token: 0x0603751C RID: 226588 RVA: 0x00D221DA File Offset: 0x00D203DA
		private void OnMapOpenFogChange(int i)
		{
			this.OnMapSetup();
		}

		// Token: 0x0603751D RID: 226589 RVA: 0x00D221E2 File Offset: 0x00D203E2
		private void OnMapOpenFogFullUpdate(IReadOnlyDictionary<int, bool> readOnlyDictionary)
		{
			this.OnMapSetup();
		}

		// Token: 0x0603751E RID: 226590 RVA: 0x00D221EA File Offset: 0x00D203EA
		public void OnMapSetup()
		{
			this.ClearRoadWays();
			this.LoadAllMapRoadWays().Forget();
		}

		// Token: 0x0603751F RID: 226591 RVA: 0x00D22200 File Offset: 0x00D20400
		private void ClearRoadWays()
		{
			foreach (MapRoadWayView mapRoadWayView in this.RoadWays)
			{
				mapRoadWayView.SetUiActive(false);
				this.RoadWaysPool.Add(mapRoadWayView);
			}
			this.RoadWays.Clear();
		}

		// Token: 0x06037520 RID: 226592 RVA: 0x00D2226C File Offset: 0x00D2046C
		private UniTask LoadAllMapRoadWays()
		{
			MapRoadWaysMgr.<LoadAllMapRoadWays>d__13 <LoadAllMapRoadWays>d__;
			<LoadAllMapRoadWays>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAllMapRoadWays>d__.<>4__this = this;
			<LoadAllMapRoadWays>d__.<>1__state = -1;
			<LoadAllMapRoadWays>d__.<>t__builder.Start<MapRoadWaysMgr.<LoadAllMapRoadWays>d__13>(ref <LoadAllMapRoadWays>d__);
			return <LoadAllMapRoadWays>d__.<>t__builder.Task;
		}

		// Token: 0x06037521 RID: 226593 RVA: 0x00D222B0 File Offset: 0x00D204B0
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

		// Token: 0x06037522 RID: 226594 RVA: 0x00D223B0 File Offset: 0x00D205B0
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

		// Token: 0x06037523 RID: 226595 RVA: 0x00D22414 File Offset: 0x00D20614
		public void OnChangeWorldMap(int mapId)
		{
			this.MapId = mapId;
			this.OnMapSetup();
		}

		// Token: 0x06037524 RID: 226596 RVA: 0x00D22424 File Offset: 0x00D20624
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

		// Token: 0x0401D23E RID: 119358
		private int MapId;

		// Token: 0x0401D23F RID: 119359
		private readonly int InstanceDungeonId;

		// Token: 0x0401D240 RID: 119360
		private readonly UUIItem Container;

		// Token: 0x0401D241 RID: 119361
		private readonly List<MapRoadWayView> RoadWays = new List<MapRoadWayView>();

		// Token: 0x0401D242 RID: 119362
		private readonly List<MapRoadWayView> RoadWaysPool = new List<MapRoadWayView>();

		// Token: 0x0401D243 RID: 119363
		private readonly Vector2D AnchorOffset = Vector2D.Create();

		// Token: 0x0401D244 RID: 119364
		private readonly global::Vector Scale = global::Vector.Create();

		// Token: 0x0401D245 RID: 119365
		private readonly string RoadWayPrefabPath = "/Game/Aki/UI/UIResources/UiWorldMap/Prefabs/UiItem_MapRoadWay_Prefab.UiItem_MapRoadWay_Prefab";
	}
}
