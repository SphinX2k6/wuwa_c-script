using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A3C RID: 19004
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMapModel
	{
		// Token: 0x17007A4A RID: 31306
		// (get) Token: 0x06031567 RID: 202087 RVA: 0x00B71579 File Offset: 0x00B6F779
		// (set) Token: 0x06031568 RID: 202088 RVA: 0x00B71581 File Offset: 0x00B6F781
		public int MapId
		{
			get
			{
				return this.MapIdInner;
			}
			set
			{
				this.MapIdInner = value;
			}
		}

		// Token: 0x17007A4B RID: 31307
		// (get) Token: 0x06031569 RID: 202089 RVA: 0x00B7158C File Offset: 0x00B6F78C
		public global::Vector CampPosition
		{
			get
			{
				if (this.PhantomRoutes.Count == 0)
				{
					return global::Vector.Create(0.0, 0.0, 0.0);
				}
				List<global::Vector> list = null;
				using (Dictionary<int, List<global::Vector>>.ValueCollection.Enumerator enumerator = this.PhantomRoutes.Values.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						list = enumerator.Current;
					}
				}
				if (list == null || list.Count == 0)
				{
					return global::Vector.Create(0.0, 0.0, 0.0);
				}
				return list[list.Count - 1];
			}
		}

		// Token: 0x0603156A RID: 202090 RVA: 0x00B7164C File Offset: 0x00B6F84C
		public static TrapDefenseMapModel Create()
		{
			return new TrapDefenseMapModel();
		}

		// Token: 0x0603156B RID: 202091 RVA: 0x00B71654 File Offset: 0x00B6F854
		public TrapDefenseMarkItem GetDynamicMarkInfoByMarkId(int markId)
		{
			TrapDefenseMarkItem result;
			this.DynamicMarks.TryGetValue(markId, out result);
			return result;
		}

		// Token: 0x0603156C RID: 202092 RVA: 0x00B71674 File Offset: 0x00B6F874
		public List<T> GetDynamicMarksByMarkType<[Nullable(0)] T>(TrapDefenseDefine.ETrapDefenseMarkType markType) where T : TrapDefenseMarkItem
		{
			List<TrapDefenseMarkItem> list;
			if (this.MarksByType.TryGetValue(markType, out list))
			{
				List<T> list2 = new List<T>();
				foreach (TrapDefenseMarkItem trapDefenseMarkItem in list)
				{
					list2.Add((T)((object)trapDefenseMarkItem));
				}
				return list2;
			}
			return new List<T>();
		}

		// Token: 0x0603156D RID: 202093 RVA: 0x00B716E4 File Offset: 0x00B6F8E4
		public Dictionary<int, TrapDefenseMarkItem> GetAllDynamicMarkInfo()
		{
			return this.DynamicMarks;
		}

		// Token: 0x0603156E RID: 202094 RVA: 0x00B716EC File Offset: 0x00B6F8EC
		public void SetDynamicMarkInfoByMarkId(TrapDefenseMarkItem info)
		{
			this.DynamicMarks[info.MarkId] = info;
			if (!this.MarksByType.ContainsKey(info.MarkType))
			{
				this.MarksByType[info.MarkType] = new List<TrapDefenseMarkItem>();
			}
			this.MarksByType[info.MarkType].Add(info);
		}

		// Token: 0x0603156F RID: 202095 RVA: 0x00B7174C File Offset: 0x00B6F94C
		public void RemoveDynamicMarkInfoByMarkId(int markId)
		{
			TrapDefenseMarkItem trapDefenseMarkItem;
			if (this.DynamicMarks.TryGetValue(markId, out trapDefenseMarkItem))
			{
				this.DynamicMarks.Remove(markId);
				List<TrapDefenseMarkItem> list;
				if (this.MarksByType.TryGetValue(trapDefenseMarkItem.MarkType, out list))
				{
					list.Remove(trapDefenseMarkItem);
				}
				EventSystem.Instance.Emit<int>(EEventName.TrapDefenseMapMarkRemoved, markId);
			}
		}

		// Token: 0x06031570 RID: 202096 RVA: 0x00B717A4 File Offset: 0x00B6F9A4
		public void ClearDynamicMarks()
		{
			this.DynamicMarks.Clear();
			this.MarksByType.Clear();
		}

		// Token: 0x06031571 RID: 202097 RVA: 0x00B717BC File Offset: 0x00B6F9BC
		public void AddMark(ITrapDefenseMarkInfo createInfo)
		{
			TrapDefenseMarkItem trapDefenseMarkItem;
			if (!this.DynamicMarks.TryGetValue(createInfo.MarkId, out trapDefenseMarkItem))
			{
				switch (createInfo.MarkType)
				{
				case TrapDefenseDefine.ETrapDefenseMarkType.Player:
					trapDefenseMarkItem = new TrapDefensePlayerMarkItem(createInfo.MarkId, createInfo.ExtraParam);
					break;
				case TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint:
					trapDefenseMarkItem = new TrapDefensePhantomPointMarkItem(createInfo.MarkId, createInfo.ExtraParam);
					break;
				case TrapDefenseDefine.ETrapDefenseMarkType.Phantom:
					trapDefenseMarkItem = new TrapDefenseMonsterMarkItem(createInfo.MarkId, createInfo.ExtraParam);
					break;
				case TrapDefenseDefine.ETrapDefenseMarkType.Camp:
					trapDefenseMarkItem = new TrapDefenseCampMarkItem(createInfo.MarkId, createInfo.ExtraParam);
					break;
				default:
					return;
				}
				this.DynamicMarks[createInfo.MarkId] = trapDefenseMarkItem;
				if (!this.MarksByType.ContainsKey(createInfo.MarkType))
				{
					this.MarksByType[createInfo.MarkType] = new List<TrapDefenseMarkItem>();
				}
				this.MarksByType[createInfo.MarkType].Add(trapDefenseMarkItem);
			}
		}

		// Token: 0x06031572 RID: 202098 RVA: 0x00B718A4 File Offset: 0x00B6FAA4
		public void CreateMarks()
		{
			List<ITrapDefenseMarkInfo> list = new List<ITrapDefenseMarkInfo>();
			list.Add(new TrapDefenseMarkInfo
			{
				MarkId = 0,
				MarkType = TrapDefenseDefine.ETrapDefenseMarkType.Player
			});
			list.Add(new TrapDefenseMarkInfo
			{
				MarkId = 1,
				MarkType = TrapDefenseDefine.ETrapDefenseMarkType.Camp
			});
			foreach (KeyValuePair<int, List<global::Vector>> keyValuePair in this.PhantomRoutes)
			{
				int key = keyValuePair.Key;
				List<global::Vector> value = keyValuePair.Value;
				list.Add(new TrapDefenseMarkInfo
				{
					MarkId = key + 10000,
					MarkType = TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint,
					ExtraParam = new object[]
					{
						key,
						value
					}
				});
			}
			foreach (ITrapDefenseMarkInfo createInfo in list)
			{
				this.AddMark(createInfo);
			}
		}

		// Token: 0x06031573 RID: 202099 RVA: 0x00B719BC File Offset: 0x00B6FBBC
		public void InitMapData()
		{
			TrapDefenseLevelData curInstToLevelData = TrapDefenseModel.Instance.GetCurInstToLevelData();
			if (curInstToLevelData == null)
			{
				return;
			}
			if (curInstToLevelData.Config.WorldKillZ != 0)
			{
				if (KscEnv.Instance.KscWorld != null)
				{
					KscEnv.Instance.KscWorld.SetWorldAttr(EKSC_WorldAttrType.WorldKillZ, curInstToLevelData.Config.WorldKillZ);
				}
				else
				{
					KscEnv.Instance.CacheWorldKillZ((float)curInstToLevelData.Config.WorldKillZ);
				}
			}
			if (curInstToLevelData.Config.ObstacleSegments() != null)
			{
				TArray<FKSC_Segment> tarray = new TArray<FKSC_Segment>();
				foreach (IntArray intArray in curInstToLevelData.Config.ObstacleSegmentsIter())
				{
					if (intArray.ArrayInt() != null && intArray.ArrayIntLength == 4)
					{
						tarray.Add(new FKSC_Segment(new FVector((float)intArray.ArrayInt(0), (float)intArray.ArrayInt(1), 0f), new FVector((float)intArray.ArrayInt(2), (float)intArray.ArrayInt(3), 0f)));
					}
					else
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.TowerDefense;
						ELogAuthor author = ELogAuthor.ZWY;
						string message = "[塔防地图] 初始化障碍物配置错误";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", curInstToLevelData.Config.Name);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
				if (KscEnv.Instance.KscWorld != null)
				{
					KscEnv.Instance.KscWorld.SetObstacleSegments(tarray);
				}
				else
				{
					KscEnv.Instance.CacheObstacleSegments(tarray);
				}
			}
			this.InitSplineData();
			if (!this.MapChanged)
			{
				this.MapId = TrapDefenseModel.Instance.GetCurrentBatchData().Value.MapId;
			}
			this.ClearDynamicMarks();
			this.CreateMarks();
		}

		// Token: 0x06031574 RID: 202100 RVA: 0x00B71B70 File Offset: 0x00B6FD70
		public void ChangeMap(int mapId)
		{
			this.MapId = mapId;
			this.MapChanged = true;
		}

		// Token: 0x06031575 RID: 202101 RVA: 0x00B71B80 File Offset: 0x00B6FD80
		public void InitSplineData()
		{
			TrapDefenseLevelData curInstToLevelData = TrapDefenseModel.Instance.GetCurInstToLevelData();
			int[] array = ((curInstToLevelData != null) ? curInstToLevelData.Config.SplineList() : null) ?? Array.Empty<int>();
			this.PhantomRoutes.Clear();
			this.ClearAllSpline();
			foreach (int num in array)
			{
				USplineComponent splineComponent = this.GetSplineComponent(num);
				List<global::Vector> list = new List<global::Vector>();
				float splineLength = splineComponent.GetSplineLength();
				FVectorDouble fvectorDouble = splineComponent.D_GetLocationAtDistanceAlongSpline(0f, ESplineCoordinateSpace.World);
				FVectorDouble fvectorDouble2 = splineComponent.D_GetLocationAtDistanceAlongSpline(splineLength, ESplineCoordinateSpace.World);
				list.Add(global::Vector.Create(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z));
				list.Add(global::Vector.Create(fvectorDouble2.X, fvectorDouble2.Y, fvectorDouble2.Z));
				this.PhantomRoutes[num] = list;
			}
		}

		// Token: 0x06031576 RID: 202102 RVA: 0x00B71C58 File Offset: 0x00B6FE58
		public void UpdateEnemyPositions(List<FKSC_MiniMapContext> positions)
		{
			List<TrapDefenseMonsterMarkItem> dynamicMarksByMarkType = this.GetDynamicMarksByMarkType<TrapDefenseMonsterMarkItem>(TrapDefenseDefine.ETrapDefenseMarkType.Phantom);
			for (int i = 0; i < positions.Count; i++)
			{
				if (i < dynamicMarksByMarkType.Count)
				{
					FVectorDouble location = positions[i].Location;
					dynamicMarksByMarkType[i].SetWorldPosition((float)location.X, (float)location.Y, (float)location.Z);
					dynamicMarksByMarkType[i].EnemyType = (ETrapDefenseEnemyType)positions[i].EnemyType;
				}
				else
				{
					this.AddMark(new TrapDefenseMarkInfo
					{
						MarkId = this.DynamicMarks.Count + 20000,
						MarkType = TrapDefenseDefine.ETrapDefenseMarkType.Phantom,
						ExtraParam = positions[i].EnemyType
					});
				}
			}
			List<TrapDefenseMonsterMarkItem> list = new List<TrapDefenseMonsterMarkItem>();
			for (int j = positions.Count; j < dynamicMarksByMarkType.Count; j++)
			{
				list.Add(dynamicMarksByMarkType[j]);
			}
			foreach (TrapDefenseMonsterMarkItem trapDefenseMonsterMarkItem in list)
			{
				this.RemoveDynamicMarkInfoByMarkId(trapDefenseMonsterMarkItem.MarkId);
			}
		}

		// Token: 0x06031577 RID: 202103 RVA: 0x00B71D8C File Offset: 0x00B6FF8C
		public USplineComponent GetSplineComponent(int splineId)
		{
			if (this.SplineComMap.ContainsKey(splineId))
			{
				return this.SplineComMap[splineId];
			}
			this.LoadSplineComponent(splineId);
			return this.SplineComMap[splineId];
		}

		// Token: 0x06031578 RID: 202104 RVA: 0x00B71DBC File Offset: 0x00B6FFBC
		public Dictionary<int, USplineComponent> GetAllSplineComponent()
		{
			return this.SplineComMap;
		}

		// Token: 0x06031579 RID: 202105 RVA: 0x00B71DC4 File Offset: 0x00B6FFC4
		private void LoadSplineComponent(int splineId)
		{
			if (this.SplineComMap.ContainsKey(splineId))
			{
				return;
			}
			USplineComponent value = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, this.SplineUid, EIdType.SimpleCombatPreviewId);
			this.SplineComMap[splineId] = value;
			this.SplineUidMap[splineId] = this.SplineUid;
			this.SplineUid++;
		}

		// Token: 0x0603157A RID: 202106 RVA: 0x00B71E20 File Offset: 0x00B70020
		public void ClearAllSpline()
		{
			foreach (KeyValuePair<int, USplineComponent> keyValuePair in this.SplineComMap)
			{
				USplineComponent value = keyValuePair.Value;
				int key = keyValuePair.Key;
				int num;
				this.SplineUidMap.TryGetValue(key, out num);
				GameSplineModel.Instance.ReleaseSpline(key, (long)num, EIdType.SimpleCombatPreviewId);
			}
			this.SplineComMap.Clear();
			this.SplineUidMap.Clear();
			this.SplineUid = 0;
		}

		// Token: 0x0603157B RID: 202107 RVA: 0x00B71EB8 File Offset: 0x00B700B8
		public void ClearMapChanged()
		{
			this.MapChanged = false;
		}

		// Token: 0x0401A5D0 RID: 107984
		private int MapIdInner;

		// Token: 0x0401A5D1 RID: 107985
		private bool MapChanged;

		// Token: 0x0401A5D2 RID: 107986
		private Dictionary<int, TrapDefenseMarkItem> DynamicMarks = new Dictionary<int, TrapDefenseMarkItem>();

		// Token: 0x0401A5D3 RID: 107987
		private Dictionary<TrapDefenseDefine.ETrapDefenseMarkType, List<TrapDefenseMarkItem>> MarksByType = new Dictionary<TrapDefenseDefine.ETrapDefenseMarkType, List<TrapDefenseMarkItem>>();

		// Token: 0x0401A5D4 RID: 107988
		public Dictionary<int, List<global::Vector>> PhantomRoutes = new Dictionary<int, List<global::Vector>>();

		// Token: 0x0401A5D5 RID: 107989
		public Dictionary<int, USplineComponent> SplineComMap = new Dictionary<int, USplineComponent>();

		// Token: 0x0401A5D6 RID: 107990
		private Dictionary<int, int> SplineUidMap = new Dictionary<int, int>();

		// Token: 0x0401A5D7 RID: 107991
		private int SplineUid;
	}
}
