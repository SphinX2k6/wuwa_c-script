using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map
{
	// Token: 0x02005484 RID: 21636
	[NullableContext(1)]
	[Nullable(0)]
	public class MapConfig : ConfigBase
	{
		// Token: 0x0603733E RID: 226110 RVA: 0x00D16C84 File Offset: 0x00D14E84
		protected override bool OnInit()
		{
			this.MarkHasFunctionMap = new Dictionary<int, bool>();
			this.MapFogConfigMap = new Dictionary<string, bool>();
			IReadOnlyList<MapMarkRelativeSubType> configList = ConfigMapMarkRelativeSubTypeAll.GetConfigList(true);
			if (configList != null)
			{
				foreach (MapMarkRelativeSubType mapMarkRelativeSubType in configList)
				{
					this.MarkHasFunctionMap[mapMarkRelativeSubType.FunctionId] = true;
				}
			}
			IReadOnlyList<FogBlock> configList2 = ConfigFogBlockAll.GetConfigList(true);
			if (configList2 != null)
			{
				foreach (FogBlock fogBlock in configList2)
				{
					Dictionary<string, bool> mapFogConfigMap = this.MapFogConfigMap;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted(fogBlock.Block);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(fogBlock.MapId);
					mapFogConfigMap[defaultInterpolatedStringHandler.ToStringAndClear()] = true;
				}
			}
			IReadOnlyList<TaskMark> configList3 = ConfigTaskMarkAll.GetConfigList(true);
			if (configList3 != null)
			{
				this.TaskMarkMap = new Dictionary<int, TaskMark>();
				foreach (TaskMark value in configList3)
				{
					this.TaskMarkMap[value.QuestId] = value;
				}
			}
			IReadOnlyList<MonsterDetection> configList4 = ConfigMonsterDetectionAll.GetConfigList(true);
			if (configList4 != null)
			{
				this.MonsterDetectionMap = new Dictionary<int, MonsterDetection>();
				foreach (MonsterDetection value2 in configList4)
				{
					this.MonsterDetectionMap[value2.MarkId] = value2;
				}
			}
			IReadOnlyList<MapMark> configList5 = ConfigMapMarkAll.GetConfigList(true);
			if (configList5 != null)
			{
				this.MapMarkMap = new Dictionary<int, MapMark>();
				foreach (MapMark value3 in configList5)
				{
					this.MapMarkMap[value3.MarkId] = value3;
				}
			}
			IReadOnlyList<DynamicMapMark> configList6 = ConfigDynamicMapMarkAll.GetConfigList(true);
			if (configList6 != null)
			{
				this.DynamicMarkMap = new Dictionary<int, DynamicMapMark>();
				foreach (DynamicMapMark value4 in configList6)
				{
					this.DynamicMarkMap[value4.MarkId] = value4;
				}
			}
			this.InitWorldMapNavigateMap();
			this.InitFogTextureConfigMapping();
			this.InitMapBorderConfigMapping();
			this.InitMultiMapConfigMapping();
			this.InitInstanceTeleporterIdList();
			return true;
		}

		// Token: 0x0603733F RID: 226111 RVA: 0x00D16F24 File Offset: 0x00D15124
		protected override bool OnClear()
		{
			Dictionary<int, bool> markHasFunctionMap = this.MarkHasFunctionMap;
			if (markHasFunctionMap != null)
			{
				markHasFunctionMap.Clear();
			}
			Dictionary<string, bool> mapFogConfigMap = this.MapFogConfigMap;
			if (mapFogConfigMap != null)
			{
				mapFogConfigMap.Clear();
			}
			Dictionary<int, TaskMark> taskMarkMap = this.TaskMarkMap;
			if (taskMarkMap != null)
			{
				taskMarkMap.Clear();
			}
			Dictionary<int, MapMark> mapMarkMap = this.MapMarkMap;
			if (mapMarkMap != null)
			{
				mapMarkMap.Clear();
			}
			Dictionary<int, DynamicMapMark> dynamicMarkMap = this.DynamicMarkMap;
			if (dynamicMarkMap != null)
			{
				dynamicMarkMap.Clear();
			}
			Dictionary<int, IWorldMapNavigate> worldMapNavigateAreaMapInner = this.WorldMapNavigateAreaMapInner;
			if (worldMapNavigateAreaMapInner != null)
			{
				worldMapNavigateAreaMapInner.Clear();
			}
			Dictionary<int, IWorldMapNavigateCountry> worldMapNavigateCountryMapInner = this.WorldMapNavigateCountryMapInner;
			if (worldMapNavigateCountryMapInner != null)
			{
				worldMapNavigateCountryMapInner.Clear();
			}
			Dictionary<int, MonsterDetection> monsterDetectionMap = this.MonsterDetectionMap;
			if (monsterDetectionMap != null)
			{
				monsterDetectionMap.Clear();
			}
			this.SearchLevelEntityConfigFailureLogSet.Clear();
			Dictionary<string, FogTextureConfig> fogTextureConfigMap = this.FogTextureConfigMap;
			if (fogTextureConfigMap != null)
			{
				fogTextureConfigMap.Clear();
			}
			this.MarkHasFunctionMap = null;
			this.MapFogConfigMap = null;
			this.MapBorderMapping.Clear();
			this.MultiMapConfigMapping.Clear();
			this.MultiMapConfigArray.Clear();
			this.AreaIdToMultiMapIdMapping.Clear();
			this.SubMapAreaSetMapping.Clear();
			this.InstanceTeleporterIdList.Clear();
			return true;
		}

		// Token: 0x06037340 RID: 226112 RVA: 0x00D17028 File Offset: 0x00D15228
		private void InitWorldMapNavigateMap()
		{
			this.WorldMapNavigateAreaMapInner = new Dictionary<int, IWorldMapNavigate>();
			this.WorldMapNavigateCountryMapInner = new Dictionary<int, IWorldMapNavigateCountry>();
			IReadOnlyList<Aki.Config.Area> worldMapNavigateMap = ConfigAreaByLevel.GetConfigList(2, true) ?? new List<Aki.Config.Area>();
			this.SetWorldMapNavigateMap(worldMapNavigateMap);
		}

		// Token: 0x06037341 RID: 226113 RVA: 0x00D17064 File Offset: 0x00D15264
		private void InitFogTextureConfigMapping()
		{
			IReadOnlyList<FogTextureConfig> allTileConfig = this.GetAllTileConfig();
			if (allTileConfig != null)
			{
				foreach (FogTextureConfig value in allTileConfig)
				{
					string tileConfigKey = this.GetTileConfigKey(value.Block, value.MapId, (EMapGravityDirection)value.GravityFlip);
					this.FogTextureConfigMap[tileConfigKey] = value;
				}
			}
		}

		// Token: 0x06037342 RID: 226114 RVA: 0x00D170D8 File Offset: 0x00D152D8
		private void InitMapBorderConfigMapping()
		{
			IReadOnlyList<MapBorder> mapBorderConfigList = this.GetMapBorderConfigList();
			if (mapBorderConfigList != null)
			{
				foreach (MapBorder value in mapBorderConfigList)
				{
					string mapBorderConfigKey = this.GetMapBorderConfigKey(value.BorderId, value.MapId);
					this.MapBorderMapping[mapBorderConfigKey] = value;
				}
			}
		}

		// Token: 0x06037343 RID: 226115 RVA: 0x00D17148 File Offset: 0x00D15348
		private unsafe void InitMultiMapConfigMapping()
		{
			IReadOnlyList<MultiMap> configList = ConfigMultiMapAll.GetConfigList(true);
			if (configList != null)
			{
				foreach (MultiMap multiMap in configList)
				{
					this.MultiMapConfigMapping[multiMap.Id] = multiMap;
					this.MultiMapConfigArray.Add(multiMap);
					HashSet<int> hashSet = new HashSet<int>();
					Span<int> areaBytes = multiMap.GetAreaBytes();
					for (int i = 0; i < areaBytes.Length; i++)
					{
						int num = *areaBytes[i];
						if (!this.AreaIdToMultiMapIdMapping.ContainsKey(num))
						{
							this.AreaIdToMultiMapIdMapping[num] = multiMap.Id;
						}
						hashSet.Add(num);
					}
					this.SubMapAreaSetMapping[multiMap.Id] = hashSet;
				}
			}
		}

		// Token: 0x06037344 RID: 226116 RVA: 0x00D1722C File Offset: 0x00D1542C
		private void InitInstanceTeleporterIdList()
		{
			foreach (InstEntityTeleporter instEntityTeleporter in (ConfigInstEntityTeleporterAll.GetConfigList(true) ?? Array.Empty<InstEntityTeleporter>()))
			{
				this.InstanceTeleporterIdList.Add(instEntityTeleporter.Id);
			}
		}

		// Token: 0x06037345 RID: 226117 RVA: 0x00D17290 File Offset: 0x00D15490
		private void SetWorldMapNavigateMap(IReadOnlyList<Aki.Config.Area> areaList)
		{
			foreach (Aki.Config.Area area in areaList)
			{
				WorldMapNavigateImpl worldMapNavigateImpl = new WorldMapNavigateImpl
				{
					AreaId = area.AreaId,
					StateId = new int?(area.StateId),
					CountryId = area.CountryId,
					MarkId = area.DeliveryMarkId,
					MarkType = (EMarkType)area.DeliveryMarkType,
					SortIndex = area.SortIndex,
					MapConfigId = area.MapConfigId
				};
				this.WorldMapNavigateAreaMapInner[area.AreaId] = worldMapNavigateImpl;
				IWorldMapNavigateCountry worldMapNavigateCountry;
				if (!this.WorldMapNavigateCountryMapInner.TryGetValue(area.CountryId, out worldMapNavigateCountry))
				{
					worldMapNavigateCountry = new WorldMapNavigateCountryImpl
					{
						StateMap = null,
						AreaNavigateList = new List<IWorldMapNavigate>()
					};
					this.WorldMapNavigateCountryMapInner[area.CountryId] = worldMapNavigateCountry;
					WorldMapNavigateCountryData item = new WorldMapNavigateCountryData
					{
						CountryId = area.CountryId,
						NavigateCountry = worldMapNavigateCountry
					};
					this.WorldMapNavigateCountryListInner.Add(item);
					this.WorldMapNavigateCountryListInner.Sort(delegate(IWorldMapNavigateCountryData a, IWorldMapNavigateCountryData b)
					{
						Country? countryConfig = InfluenceConfig.Instance.GetCountryConfig(a.CountryId);
						int num = (countryConfig != null) ? countryConfig.GetValueOrDefault().SortIndex : 0;
						countryConfig = InfluenceConfig.Instance.GetCountryConfig(b.CountryId);
						int value = (countryConfig != null) ? countryConfig.GetValueOrDefault().SortIndex : 0;
						return num.CompareTo(value);
					});
				}
				int valueOrDefault = worldMapNavigateImpl.StateId.GetValueOrDefault();
				if (valueOrDefault != 0)
				{
					if (worldMapNavigateCountry.StateMap == null)
					{
						worldMapNavigateCountry.StateMap = new Dictionary<int, IWorldMapNavigateState>();
					}
					if (!worldMapNavigateCountry.StateMap.ContainsKey(valueOrDefault))
					{
						worldMapNavigateCountry.StateMap[valueOrDefault] = new WorldMapNavigateState
						{
							StateId = valueOrDefault,
							SortIndex = ExploreProgressConfig.Instance.GetStateConfigByStateId(valueOrDefault).Value.SortIndex,
							AreaNavigateList = new List<IWorldMapNavigate>()
						};
					}
					worldMapNavigateCountry.StateMap[valueOrDefault].AreaNavigateList.Add(worldMapNavigateImpl);
				}
				worldMapNavigateCountry.AreaNavigateList.Add(worldMapNavigateImpl);
			}
			foreach (IWorldMapNavigateCountry worldMapNavigateCountry2 in this.WorldMapNavigateCountryMapInner.Values)
			{
				List<IWorldMapNavigate> areaNavigateList = worldMapNavigateCountry2.AreaNavigateList;
				Comparison<IWorldMapNavigate> comparison;
				if ((comparison = MapConfig.<>O.<0>__CompareNavigate) == null)
				{
					comparison = (MapConfig.<>O.<0>__CompareNavigate = new Comparison<IWorldMapNavigate>(MapConfig.CompareNavigate));
				}
				areaNavigateList.Sort(comparison);
				if (worldMapNavigateCountry2.StateMap != null)
				{
					foreach (IWorldMapNavigateState worldMapNavigateState in worldMapNavigateCountry2.StateMap.Values)
					{
						List<IWorldMapNavigate> areaNavigateList2 = worldMapNavigateState.AreaNavigateList;
						Comparison<IWorldMapNavigate> comparison2;
						if ((comparison2 = MapConfig.<>O.<0>__CompareNavigate) == null)
						{
							comparison2 = (MapConfig.<>O.<0>__CompareNavigate = new Comparison<IWorldMapNavigate>(MapConfig.CompareNavigate));
						}
						areaNavigateList2.Sort(comparison2);
					}
				}
			}
		}

		// Token: 0x06037346 RID: 226118 RVA: 0x00D1758C File Offset: 0x00D1578C
		private static int CompareNavigate(IWorldMapNavigate a, IWorldMapNavigate b)
		{
			int sortIndex = a.SortIndex;
			int sortIndex2 = b.SortIndex;
			if (sortIndex != sortIndex2)
			{
				return sortIndex.CompareTo(sortIndex2);
			}
			return a.AreaId.CompareTo(b.AreaId);
		}

		// Token: 0x1700846E RID: 33902
		// (get) Token: 0x06037347 RID: 226119 RVA: 0x00D175C8 File Offset: 0x00D157C8
		public Dictionary<int, IWorldMapNavigate> WorldMapNavigateAreaMap
		{
			get
			{
				return this.WorldMapNavigateAreaMapInner;
			}
		}

		// Token: 0x1700846F RID: 33903
		// (get) Token: 0x06037348 RID: 226120 RVA: 0x00D175D0 File Offset: 0x00D157D0
		public Dictionary<int, IWorldMapNavigateCountry> WorldMapNavigateCountryMap
		{
			get
			{
				return this.WorldMapNavigateCountryMapInner;
			}
		}

		// Token: 0x17008470 RID: 33904
		// (get) Token: 0x06037349 RID: 226121 RVA: 0x00D175D8 File Offset: 0x00D157D8
		public List<IWorldMapNavigateCountryData> WorldMapNavigateCountryList
		{
			get
			{
				return this.WorldMapNavigateCountryListInner;
			}
		}

		// Token: 0x0603734A RID: 226122 RVA: 0x00D175E0 File Offset: 0x00D157E0
		public WorldMapNavigateBundle GetFullNavigateBundle()
		{
			return new WorldMapNavigateBundle
			{
				CountryList = this.WorldMapNavigateCountryListInner,
				CountryMap = this.WorldMapNavigateCountryMapInner,
				AreaMap = this.WorldMapNavigateAreaMapInner
			};
		}

		// Token: 0x0603734B RID: 226123 RVA: 0x00D1760C File Offset: 0x00D1580C
		public WorldMapNavigateBundle BuildRecallFilteredNavigateBundle(HashSet<int> dungeonIds)
		{
			HashSet<int> mapConfigIds = new HashSet<int>();
			foreach (int id in dungeonIds)
			{
				int? instanceMapConfigId = InstanceDungeonConfig.Instance.GetInstanceMapConfigId(id);
				if (instanceMapConfigId != null)
				{
					mapConfigIds.Add(instanceMapConfigId.Value);
				}
			}
			WorldMapNavigateBundle worldMapNavigateBundle = new WorldMapNavigateBundle();
			Func<IWorldMapNavigate, bool> <>9__0;
			Func<IWorldMapNavigate, bool> <>9__1;
			foreach (IWorldMapNavigateCountryData worldMapNavigateCountryData in this.WorldMapNavigateCountryListInner)
			{
				IWorldMapNavigateCountry navigateCountry = worldMapNavigateCountryData.NavigateCountry;
				IEnumerable<IWorldMapNavigate> areaNavigateList = navigateCountry.AreaNavigateList;
				Func<IWorldMapNavigate, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((IWorldMapNavigate a) => mapConfigIds.Contains(a.MapConfigId)));
				}
				List<IWorldMapNavigate> list = areaNavigateList.Where(predicate).ToList<IWorldMapNavigate>();
				if (list.Count != 0)
				{
					WorldMapNavigateCountryImpl worldMapNavigateCountryImpl = new WorldMapNavigateCountryImpl
					{
						AreaNavigateList = list,
						StateMap = null
					};
					if (navigateCountry.StateMap != null)
					{
						foreach (KeyValuePair<int, IWorldMapNavigateState> keyValuePair in navigateCountry.StateMap)
						{
							IEnumerable<IWorldMapNavigate> areaNavigateList2 = keyValuePair.Value.AreaNavigateList;
							Func<IWorldMapNavigate, bool> predicate2;
							if ((predicate2 = <>9__1) == null)
							{
								predicate2 = (<>9__1 = ((IWorldMapNavigate a) => mapConfigIds.Contains(a.MapConfigId)));
							}
							List<IWorldMapNavigate> list2 = areaNavigateList2.Where(predicate2).ToList<IWorldMapNavigate>();
							if (list2.Count != 0)
							{
								WorldMapNavigateCountryImpl worldMapNavigateCountryImpl2 = worldMapNavigateCountryImpl;
								if (worldMapNavigateCountryImpl2.StateMap == null)
								{
									worldMapNavigateCountryImpl2.StateMap = new Dictionary<int, IWorldMapNavigateState>();
								}
								worldMapNavigateCountryImpl.StateMap[keyValuePair.Key] = new WorldMapNavigateState
								{
									StateId = keyValuePair.Value.StateId,
									SortIndex = keyValuePair.Value.SortIndex,
									AreaNavigateList = list2
								};
							}
						}
					}
					worldMapNavigateBundle.CountryList.Add(new WorldMapNavigateCountryData
					{
						CountryId = worldMapNavigateCountryData.CountryId,
						NavigateCountry = worldMapNavigateCountryImpl
					});
					worldMapNavigateBundle.CountryMap[worldMapNavigateCountryData.CountryId] = worldMapNavigateCountryImpl;
					foreach (IWorldMapNavigate worldMapNavigate in list)
					{
						worldMapNavigateBundle.AreaMap[worldMapNavigate.AreaId] = worldMapNavigate;
					}
				}
			}
			return worldMapNavigateBundle;
		}

		// Token: 0x0603734C RID: 226124 RVA: 0x00D178E0 File Offset: 0x00D15AE0
		public TaskMark? GetTaskMarkConfig(int markId)
		{
			return ConfigTaskMarkByMarkId.GetConfig(markId, true);
		}

		// Token: 0x0603734D RID: 226125 RVA: 0x00D178EC File Offset: 0x00D15AEC
		public TaskMark? GetTaskMarkConfigByQuestId(int questId)
		{
			Dictionary<int, TaskMark> taskMarkMap = this.TaskMarkMap;
			if (taskMarkMap == null)
			{
				return null;
			}
			return taskMarkMap.GetValueOrNull(questId);
		}

		// Token: 0x0603734E RID: 226126 RVA: 0x00D17914 File Offset: 0x00D15B14
		public MonsterDetection? GetMonsterDetectionConfig(int markId)
		{
			Dictionary<int, MonsterDetection> monsterDetectionMap = this.MonsterDetectionMap;
			if (monsterDetectionMap == null)
			{
				return null;
			}
			return monsterDetectionMap.GetValueOrNull(markId);
		}

		// Token: 0x0603734F RID: 226127 RVA: 0x00D1793C File Offset: 0x00D15B3C
		[NullableContext(2)]
		public IReadOnlyList<MapMark> GetConfigMarks(int mapId)
		{
			IReadOnlyList<MapMark> configList = ConfigMapMarkByMapId.GetConfigList(mapId, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "GetConfigMarks-> 找不到MapMark对应MapId的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mapId", mapId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return configList;
		}

		// Token: 0x06037350 RID: 226128 RVA: 0x00D17980 File Offset: 0x00D15B80
		public MapMark? GetConfigMark(int markId)
		{
			Dictionary<int, MapMark> mapMarkMap = this.MapMarkMap;
			if (mapMarkMap == null)
			{
				return null;
			}
			return mapMarkMap.GetValueOrNull(markId);
		}

		// Token: 0x06037351 RID: 226129 RVA: 0x00D179A7 File Offset: 0x00D15BA7
		public Dictionary<int, MapMark> GetConfigMarkMap()
		{
			return this.MapMarkMap;
		}

		// Token: 0x06037352 RID: 226130 RVA: 0x00D179B0 File Offset: 0x00D15BB0
		public DynamicMapMark? GetDynamicConfigMark(int markId)
		{
			DynamicMapMark? config = ConfigDynamicMapMarkByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到DynamicMapMark表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06037353 RID: 226131 RVA: 0x00D179FC File Offset: 0x00D15BFC
		[NullableContext(0)]
		public OneOf<MapMark, DynamicMapMark>? SearchMarkConfig(int markId)
		{
			MapMark value;
			if (this.MapMarkMap != null && this.MapMarkMap.TryGetValue(markId, out value))
			{
				return new OneOf<MapMark, DynamicMapMark>?(value);
			}
			DynamicMapMark value2;
			if (this.DynamicMarkMap != null && this.DynamicMarkMap.TryGetValue(markId, out value2))
			{
				return new OneOf<MapMark, DynamicMapMark>?(value2);
			}
			return null;
		}

		// Token: 0x06037354 RID: 226132 RVA: 0x00D17A5C File Offset: 0x00D15C5C
		[NullableContext(0)]
		public OneOf<MapMark, DynamicMapMark>? SearchMapConfigByType(int markId, EMarkType markType)
		{
			MapMark value;
			if (this.MapMarkMap != null && this.MapMarkMap.TryGetValue(markId, out value) && value.ObjectType == (int)markType)
			{
				return new OneOf<MapMark, DynamicMapMark>?(value);
			}
			DynamicMapMark value2;
			if (this.DynamicMarkMap != null && this.DynamicMarkMap.TryGetValue(markId, out value2) && value2.ObjectType == (int)markType)
			{
				return new OneOf<MapMark, DynamicMapMark>?(value2);
			}
			return null;
		}

		// Token: 0x06037355 RID: 226133 RVA: 0x00D17AD0 File Offset: 0x00D15CD0
		public int? SearchMarkInstanceDungeonId(int markId, EMarkType markType)
		{
			if (markType == EMarkType.Custom)
			{
				return null;
			}
			OneOf<MapMark, DynamicMapMark>? oneOf = this.SearchMapConfigByType(markId, markType);
			if (oneOf != null)
			{
				if (oneOf.Value.IsT1)
				{
					return new int?(oneOf.Value.AsT1.RelativeDungeonId);
				}
				if (oneOf.Value.IsT2)
				{
					return new int?(oneOf.Value.AsT2.InstanceDungeonId);
				}
			}
			return null;
		}

		// Token: 0x06037356 RID: 226134 RVA: 0x00D17B64 File Offset: 0x00D15D64
		public Teleporter? GetTeleportConfigById(int teleportId)
		{
			Teleporter? config = ConfigTeleporterById.GetConfig(teleportId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到Teleporter表的配置,Id = ";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("teleportId", teleportId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06037357 RID: 226135 RVA: 0x00D17BB0 File Offset: 0x00D15DB0
		public InstEntityTeleporter? GetInstEntityTeleportConfigById(int instEntityTeleportId)
		{
			InstEntityTeleporter? config = ConfigInstEntityTeleporterById.GetConfig(instEntityTeleportId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到InstEntityTeleporter表的配置,EntityId = ";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstEntityTeleportId", instEntityTeleportId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06037358 RID: 226136 RVA: 0x00D17BFB File Offset: 0x00D15DFB
		public bool GetIsInstanceTeleporterExist(int instEntityTeleportId)
		{
			return this.InstanceTeleporterIdList.Contains(instEntityTeleportId);
		}

		// Token: 0x06037359 RID: 226137 RVA: 0x00D17C0C File Offset: 0x00D15E0C
		public TemporaryTeleportMark? GetTemporaryTeleportMarkConfigById(int markId)
		{
			TemporaryTeleportMark? config = ConfigTemporaryTeleportMarkByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到TemporaryTeleportMark表的配置,Id = ";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603735A RID: 226138 RVA: 0x00D17C58 File Offset: 0x00D15E58
		private string GetTileConfigKey(string blockIndex, int mapId, EMapGravityDirection mapGravity)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(blockIndex);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<EMapGravityDirection>(mapGravity);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603735B RID: 226139 RVA: 0x00D17CA8 File Offset: 0x00D15EA8
		public FogTextureConfig? GetTileConfig(string blockIndex, int mapId, EMapGravityDirection mapGravity)
		{
			string tileConfigKey = this.GetTileConfigKey(blockIndex, mapId, mapGravity);
			FogTextureConfig value;
			if (this.FogTextureConfigMap.TryGetValue(tileConfigKey, out value))
			{
				return new FogTextureConfig?(value);
			}
			return null;
		}

		// Token: 0x0603735C RID: 226140 RVA: 0x00D17CDF File Offset: 0x00D15EDF
		[NullableContext(2)]
		public IReadOnlyList<FogTextureConfig> GetAllTileConfig()
		{
			return ConfigFogTextureConfigAll.GetConfigList(true);
		}

		// Token: 0x0603735D RID: 226141 RVA: 0x00D17CE7 File Offset: 0x00D15EE7
		[NullableContext(2)]
		public IReadOnlyList<FogTextureConfig> GetAllTileConfigByMapId(int mapId)
		{
			return ConfigFogTextureConfigByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x0603735E RID: 226142 RVA: 0x00D17CF0 File Offset: 0x00D15EF0
		public BlockSwitch? GetUnlockMapTileConfigById(int id)
		{
			return ConfigBlockSwitchById.GetConfig(id, true);
		}

		// Token: 0x0603735F RID: 226143 RVA: 0x00D17CFC File Offset: 0x00D15EFC
		public List<MultiMap> GetSubMapConfigByGroupId(int groupId)
		{
			List<MultiMap> list = new List<MultiMap>();
			foreach (MultiMap item in this.MultiMapConfigArray)
			{
				if (item.GroupId == groupId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06037360 RID: 226144 RVA: 0x00D17D60 File Offset: 0x00D15F60
		public MultiMap? GetSubMapConfigById(int id)
		{
			MultiMap value;
			if (this.MultiMapConfigMapping.TryGetValue(id, out value))
			{
				return new MultiMap?(value);
			}
			return null;
		}

		// Token: 0x06037361 RID: 226145 RVA: 0x00D17D8D File Offset: 0x00D15F8D
		public List<MultiMap> GetAllSubMapConfig()
		{
			return this.MultiMapConfigArray;
		}

		// Token: 0x06037362 RID: 226146 RVA: 0x00D17D98 File Offset: 0x00D15F98
		public MultiMap? GetSubMapConfigByAreaId(int areaId)
		{
			if (areaId == 0)
			{
				return null;
			}
			int id;
			if (this.AreaIdToMultiMapIdMapping.TryGetValue(areaId, out id))
			{
				return this.GetSubMapConfigById(id);
			}
			return null;
		}

		// Token: 0x06037363 RID: 226147 RVA: 0x00D17DD4 File Offset: 0x00D15FD4
		public bool IsAreaInSubMap(int multiMapId, int areaId)
		{
			HashSet<int> hashSet;
			return this.SubMapAreaSetMapping.TryGetValue(multiMapId, out hashSet) && hashSet.Contains(areaId);
		}

		// Token: 0x06037364 RID: 226148 RVA: 0x00D17DFC File Offset: 0x00D15FFC
		public CustomMark? GetCustomMarkConfig(int id)
		{
			CustomMark? config = ConfigCustomMarkByMarkId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到CustomMark表的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06037365 RID: 226149 RVA: 0x00D17E48 File Offset: 0x00D16048
		public FogBlock? GetFogBlockConfig(string blockIndex, int mapId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(blockIndex);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			string key = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.MapFogConfigMap != null && this.MapFogConfigMap.ContainsKey(key))
			{
				return ConfigFogBlockByBlockAndMapId.GetConfig(blockIndex, mapId, true);
			}
			return null;
		}

		// Token: 0x06037366 RID: 226150 RVA: 0x00D17EAA File Offset: 0x00D160AA
		public string GetLocalText(string textKey)
		{
			return ConfigMultiTextLang.GetLocalTextNew(textKey, null) ?? "";
		}

		// Token: 0x06037367 RID: 226151 RVA: 0x00D17EBC File Offset: 0x00D160BC
		public LevelEntityConfig? GetEntityConfigByMapIdAndEntityId(int mapId, int entityId)
		{
			if (entityId == 0)
			{
				return null;
			}
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				mapId = RecallQuestModel.Instance.GetMapId(new int?(mapId));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.SearchLevelEntityConfigFailureLogSet.Contains(item))
			{
				return null;
			}
			LevelEntityConfig? config = ConfigLevelEntityConfigByMapIdAndEntityId.GetConfig(mapId, entityId, true);
			if (config == null)
			{
				this.SearchLevelEntityConfigFailureLogSet.Add(item);
			}
			return config;
		}

		// Token: 0x06037368 RID: 226152 RVA: 0x00D17F5C File Offset: 0x00D1615C
		private string GetMapBorderConfigKey(int borderId, int mapId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(borderId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037369 RID: 226153 RVA: 0x00D17F98 File Offset: 0x00D16198
		public MapBorder? GetMapBorderConfig(int borderId, int mapId)
		{
			string mapBorderConfigKey = this.GetMapBorderConfigKey(borderId, mapId);
			return this.MapBorderMapping.GetValueOrNull(mapBorderConfigKey);
		}

		// Token: 0x0603736A RID: 226154 RVA: 0x00D17FBA File Offset: 0x00D161BA
		[NullableContext(2)]
		public IReadOnlyList<MapBorder> GetMapBorderConfigList()
		{
			return ConfigMapBorderAll.GetConfigList(true);
		}

		// Token: 0x0603736B RID: 226155 RVA: 0x00D17FC2 File Offset: 0x00D161C2
		public int? GetMapDissolveTime()
		{
			return ConfigCommonParamById.GetIntConfig("MapDissolveTime");
		}

		// Token: 0x0603736C RID: 226156 RVA: 0x00D17FD0 File Offset: 0x00D161D0
		public SoundBoxMark? GetSoundBoxMarkConfig(int markId)
		{
			SoundBoxMark? config = ConfigSoundBoxMarkByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到SoundBoxMark表的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603736D RID: 226157 RVA: 0x00D1801C File Offset: 0x00D1621C
		public TreasureBoxMark? GetTreasureBoxMarkConfig(int markId)
		{
			TreasureBoxMark? config = ConfigTreasureBoxMarkByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到TreasureBoxMark表的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603736E RID: 226158 RVA: 0x00D18068 File Offset: 0x00D16268
		public TreasureBoxDetectorMark? GetTreasureBoxDetectorMarkConfig(int markId)
		{
			TreasureBoxDetectorMark? config = ConfigTreasureBoxDetectorMarkByMarkId.GetConfig(markId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LK;
				string message = "找不到TreasureBoxDetectorMark表的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603736F RID: 226159 RVA: 0x00D180B4 File Offset: 0x00D162B4
		public MapMarkRelativeSubType? GetMapMarkFuncTypeConfigByFuncId(int functionType)
		{
			if (this.MarkHasFunctionMap != null && this.MarkHasFunctionMap.ContainsKey(functionType))
			{
				return ConfigMapMarkRelativeSubTypeByFunctionId.GetConfig(functionType, true);
			}
			return null;
		}

		// Token: 0x06037370 RID: 226160 RVA: 0x00D180E8 File Offset: 0x00D162E8
		public MapMarkRelativeSubType? GetMapMarkFuncTypeConfigById(int id)
		{
			return ConfigMapMarkRelativeSubTypeById.GetConfig(id, true);
		}

		// Token: 0x06037371 RID: 226161 RVA: 0x00D180F4 File Offset: 0x00D162F4
		public string GetUiResourcePathById(string key)
		{
			if (StringUtils.IsEmpty(key))
			{
				return "";
			}
			UiResource? config = ConfigUiResourceById.GetConfig(key, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "找不到UiResource表的配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			return config.Value.Path;
		}

		// Token: 0x06037372 RID: 226162 RVA: 0x00D1815C File Offset: 0x00D1635C
		[NullableContext(2)]
		public IReadOnlyList<MultiMapAreaConfig> GetMultiMapAreaConfigList()
		{
			return ConfigMultiMapAreaConfigAll.GetConfigList(true);
		}

		// Token: 0x06037373 RID: 226163 RVA: 0x00D18164 File Offset: 0x00D16364
		[NullableContext(2)]
		public IReadOnlyList<EnrichmentAreaConfig> GetEnrichmentAreaConfigByItemId(int itemId)
		{
			return ConfigEnrichmentAreaConfigByItemId.GetConfigList(itemId, true);
		}

		// Token: 0x06037374 RID: 226164 RVA: 0x00D18170 File Offset: 0x00D16370
		public EnrichmentAreaConfig? GetEnrichmentAreaConfigByEnrichmentId(int enrichmentId)
		{
			IReadOnlyList<EnrichmentAreaConfig> configList = ConfigEnrichmentAreaConfigByEnrichmentId.GetConfigList(enrichmentId, true);
			if (configList != null && configList.Count > 0)
			{
				return new EnrichmentAreaConfig?(configList[0]);
			}
			return null;
		}

		// Token: 0x06037375 RID: 226165 RVA: 0x00D181A7 File Offset: 0x00D163A7
		public MapMark? GetMapMarkByRelativeId(int relativeId, int instanceDungeonId)
		{
			return ConfigMapMarkByRelativeId.GetConfig(relativeId, instanceDungeonId, true);
		}

		// Token: 0x06037376 RID: 226166 RVA: 0x00D181B1 File Offset: 0x00D163B1
		public MapMark? GetMapMarkByEntityConfigId(int entityId)
		{
			return ConfigMapMarkByEntityConfigId.GetConfig(entityId, true);
		}

		// Token: 0x06037377 RID: 226167 RVA: 0x00D181BA File Offset: 0x00D163BA
		[NullableContext(2)]
		public IReadOnlyList<MapMark> GetMapMarkListByInstanceDungeonId(int instanceDungeonId)
		{
			return ConfigMapMarkByInstanceDungeonId.GetConfigList(instanceDungeonId, true);
		}

		// Token: 0x06037378 RID: 226168 RVA: 0x00D181C3 File Offset: 0x00D163C3
		public MapPeriodicActivity? GetMapPeriodicActivityConfig(EMapPeriodicActivityId id)
		{
			return ConfigMapPeriodicActivityById.GetConfig((int)id, true);
		}

		// Token: 0x06037379 RID: 226169 RVA: 0x00D181CC File Offset: 0x00D163CC
		[NullableContext(2)]
		public IReadOnlyList<MapPeriodicActivity> GetMapPeriodicActivityListConfigs()
		{
			return ConfigMapPeriodicActivityAll.GetConfigList(true);
		}

		// Token: 0x0603737A RID: 226170 RVA: 0x00D181D4 File Offset: 0x00D163D4
		[NullableContext(2)]
		public IReadOnlyList<MapRoadWays> GetMapRoadWaysByMapId(int mapId)
		{
			return ConfigMapRoadWaysByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x0603737B RID: 226171 RVA: 0x00D181DD File Offset: 0x00D163DD
		[NullableContext(2)]
		public IReadOnlyList<MapFog> GetMapFogByAreaId(int areaId)
		{
			return ConfigMapFogByAreaId.GetConfigList(areaId, true);
		}

		// Token: 0x17008471 RID: 33905
		// (get) Token: 0x0603737C RID: 226172 RVA: 0x00D181E6 File Offset: 0x00D163E6
		public static MapConfig Instance
		{
			get
			{
				return MapConfig._Instance;
			}
		}

		// Token: 0x0603737D RID: 226173 RVA: 0x00D181ED File Offset: 0x00D163ED
		public static MapConfig GetOrCreateInstance()
		{
			if (MapConfig._Instance == null)
			{
				MapConfig.CreateInstance();
			}
			return MapConfig._Instance;
		}

		// Token: 0x0603737E RID: 226174 RVA: 0x00D18201 File Offset: 0x00D16401
		public static bool CreateInstance()
		{
			if (MapConfig._Instance != null)
			{
				return true;
			}
			MapConfig._Instance = new MapConfig();
			return true;
		}

		// Token: 0x0603737F RID: 226175 RVA: 0x00D18217 File Offset: 0x00D16417
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037380 RID: 226176 RVA: 0x00D18219 File Offset: 0x00D16419
		public static void ResetStaticDefaultValue()
		{
			MapConfig._Instance = null;
		}

		// Token: 0x06037381 RID: 226177 RVA: 0x00D18221 File Offset: 0x00D16421
		static MapConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapConfig.CreateStaticDefaultValue), new Action(MapConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D1C6 RID: 119238
		private readonly Dictionary<string, FogTextureConfig> FogTextureConfigMap = new Dictionary<string, FogTextureConfig>();

		// Token: 0x0401D1C7 RID: 119239
		[Nullable(2)]
		private Dictionary<int, bool> MarkHasFunctionMap;

		// Token: 0x0401D1C8 RID: 119240
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, bool> MapFogConfigMap;

		// Token: 0x0401D1C9 RID: 119241
		[Nullable(2)]
		private Dictionary<int, TaskMark> TaskMarkMap;

		// Token: 0x0401D1CA RID: 119242
		[Nullable(2)]
		private Dictionary<int, MapMark> MapMarkMap;

		// Token: 0x0401D1CB RID: 119243
		[Nullable(2)]
		private Dictionary<int, DynamicMapMark> DynamicMarkMap;

		// Token: 0x0401D1CC RID: 119244
		[Nullable(2)]
		private Dictionary<int, MonsterDetection> MonsterDetectionMap;

		// Token: 0x0401D1CD RID: 119245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IWorldMapNavigate> WorldMapNavigateAreaMapInner;

		// Token: 0x0401D1CE RID: 119246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IWorldMapNavigateCountry> WorldMapNavigateCountryMapInner;

		// Token: 0x0401D1CF RID: 119247
		private readonly List<IWorldMapNavigateCountryData> WorldMapNavigateCountryListInner = new List<IWorldMapNavigateCountryData>();

		// Token: 0x0401D1D0 RID: 119248
		private readonly HashSet<string> SearchLevelEntityConfigFailureLogSet = new HashSet<string>();

		// Token: 0x0401D1D1 RID: 119249
		private readonly Dictionary<string, MapBorder> MapBorderMapping = new Dictionary<string, MapBorder>();

		// Token: 0x0401D1D2 RID: 119250
		private readonly Dictionary<int, MultiMap> MultiMapConfigMapping = new Dictionary<int, MultiMap>();

		// Token: 0x0401D1D3 RID: 119251
		private readonly List<MultiMap> MultiMapConfigArray = new List<MultiMap>();

		// Token: 0x0401D1D4 RID: 119252
		private readonly Dictionary<int, int> AreaIdToMultiMapIdMapping = new Dictionary<int, int>();

		// Token: 0x0401D1D5 RID: 119253
		private readonly Dictionary<int, HashSet<int>> SubMapAreaSetMapping = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401D1D6 RID: 119254
		private readonly HashSet<int> InstanceTeleporterIdList = new HashSet<int>();

		// Token: 0x0401D1D7 RID: 119255
		[StaticVariableRuleIgnore]
		public static bool EnableAsyncMiniMap;

		// Token: 0x0401D1D8 RID: 119256
		[Nullable(2)]
		private static MapConfig _Instance;

		// Token: 0x0200B6F4 RID: 46836
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040376CC RID: 227020
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IWorldMapNavigate> <0>__CompareNavigate;
		}
	}
}
