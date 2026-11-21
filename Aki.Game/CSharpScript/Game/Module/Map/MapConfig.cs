using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map
{
	// Token: 0x02004467 RID: 17511
	[NullableContext(1)]
	[Nullable(0)]
	public class MapConfig : ConfigBase
	{
		// Token: 0x0602C287 RID: 180871 RVA: 0x00C660DC File Offset: 0x00C642DC
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

		// Token: 0x0602C288 RID: 180872 RVA: 0x00C6637C File Offset: 0x00C6457C
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

		// Token: 0x0602C289 RID: 180873 RVA: 0x00C66480 File Offset: 0x00C64680
		private void InitWorldMapNavigateMap()
		{
			this.WorldMapNavigateAreaMapInner = new Dictionary<int, IWorldMapNavigate>();
			this.WorldMapNavigateCountryMapInner = new Dictionary<int, IWorldMapNavigateCountry>();
			IReadOnlyList<Aki.Config.Area> worldMapNavigateMap = ConfigAreaByLevel.GetConfigList(2, true) ?? new List<Aki.Config.Area>();
			this.SetWorldMapNavigateMap(worldMapNavigateMap);
		}

		// Token: 0x0602C28A RID: 180874 RVA: 0x00C664BC File Offset: 0x00C646BC
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

		// Token: 0x0602C28B RID: 180875 RVA: 0x00C66530 File Offset: 0x00C64730
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

		// Token: 0x0602C28C RID: 180876 RVA: 0x00C665A0 File Offset: 0x00C647A0
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

		// Token: 0x0602C28D RID: 180877 RVA: 0x00C66684 File Offset: 0x00C64884
		private void InitInstanceTeleporterIdList()
		{
			foreach (InstEntityTeleporter instEntityTeleporter in (ConfigInstEntityTeleporterAll.GetConfigList(true) ?? Array.Empty<InstEntityTeleporter>()))
			{
				this.InstanceTeleporterIdList.Add(instEntityTeleporter.Id);
			}
		}

		// Token: 0x0602C28E RID: 180878 RVA: 0x00C666E8 File Offset: 0x00C648E8
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

		// Token: 0x0602C28F RID: 180879 RVA: 0x00C669E4 File Offset: 0x00C64BE4
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

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x0602C290 RID: 180880 RVA: 0x00C66A20 File Offset: 0x00C64C20
		public Dictionary<int, IWorldMapNavigate> WorldMapNavigateAreaMap
		{
			get
			{
				return this.WorldMapNavigateAreaMapInner;
			}
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x0602C291 RID: 180881 RVA: 0x00C66A28 File Offset: 0x00C64C28
		public Dictionary<int, IWorldMapNavigateCountry> WorldMapNavigateCountryMap
		{
			get
			{
				return this.WorldMapNavigateCountryMapInner;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x0602C292 RID: 180882 RVA: 0x00C66A30 File Offset: 0x00C64C30
		public List<IWorldMapNavigateCountryData> WorldMapNavigateCountryList
		{
			get
			{
				return this.WorldMapNavigateCountryListInner;
			}
		}

		// Token: 0x0602C293 RID: 180883 RVA: 0x00C66A38 File Offset: 0x00C64C38
		public WorldMapNavigateBundle GetFullNavigateBundle()
		{
			return new WorldMapNavigateBundle
			{
				CountryList = this.WorldMapNavigateCountryListInner,
				CountryMap = this.WorldMapNavigateCountryMapInner,
				AreaMap = this.WorldMapNavigateAreaMapInner
			};
		}

		// Token: 0x0602C294 RID: 180884 RVA: 0x00C66A64 File Offset: 0x00C64C64
		public WorldMapNavigateBundle BuildRecallFilteredNavigateBundle(HashSet<int> dungeonIds)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int id in dungeonIds)
			{
				int? instanceMapConfigId = InstanceDungeonConfig.Instance.GetInstanceMapConfigId(id);
				if (instanceMapConfigId != null)
				{
					hashSet.Add(instanceMapConfigId.Value);
				}
			}
			WorldMapNavigateBundle worldMapNavigateBundle = new WorldMapNavigateBundle();
			foreach (IWorldMapNavigateCountryData worldMapNavigateCountryData in this.WorldMapNavigateCountryListInner)
			{
				IWorldMapNavigateCountry navigateCountry = worldMapNavigateCountryData.NavigateCountry;
				List<IWorldMapNavigate> list = new List<IWorldMapNavigate>();
				foreach (IWorldMapNavigate worldMapNavigate in navigateCountry.AreaNavigateList)
				{
					if (hashSet.Contains(worldMapNavigate.MapConfigId))
					{
						list.Add(worldMapNavigate);
					}
				}
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
							List<IWorldMapNavigate> list2 = new List<IWorldMapNavigate>();
							foreach (IWorldMapNavigate worldMapNavigate2 in keyValuePair.Value.AreaNavigateList)
							{
								if (hashSet.Contains(worldMapNavigate2.MapConfigId))
								{
									list2.Add(worldMapNavigate2);
								}
							}
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
					foreach (IWorldMapNavigate worldMapNavigate3 in list)
					{
						worldMapNavigateBundle.AreaMap[worldMapNavigate3.AreaId] = worldMapNavigate3;
					}
				}
			}
			return worldMapNavigateBundle;
		}

		// Token: 0x0602C295 RID: 180885 RVA: 0x00C66D90 File Offset: 0x00C64F90
		public TaskMark? GetTaskMarkConfig(int markId)
		{
			return ConfigTaskMarkByMarkId.GetConfig(markId, true);
		}

		// Token: 0x0602C296 RID: 180886 RVA: 0x00C66D9C File Offset: 0x00C64F9C
		public TaskMark? GetTaskMarkConfigByQuestId(int questId)
		{
			Dictionary<int, TaskMark> taskMarkMap = this.TaskMarkMap;
			if (taskMarkMap == null)
			{
				return null;
			}
			return taskMarkMap.GetValueOrNull(questId);
		}

		// Token: 0x0602C297 RID: 180887 RVA: 0x00C66DC4 File Offset: 0x00C64FC4
		public MonsterDetection? GetMonsterDetectionConfig(int markId)
		{
			Dictionary<int, MonsterDetection> monsterDetectionMap = this.MonsterDetectionMap;
			if (monsterDetectionMap == null)
			{
				return null;
			}
			return monsterDetectionMap.GetValueOrNull(markId);
		}

		// Token: 0x0602C298 RID: 180888 RVA: 0x00C66DEC File Offset: 0x00C64FEC
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

		// Token: 0x0602C299 RID: 180889 RVA: 0x00C66E30 File Offset: 0x00C65030
		public MapMark? GetConfigMark(int markId)
		{
			Dictionary<int, MapMark> mapMarkMap = this.MapMarkMap;
			if (mapMarkMap == null)
			{
				return null;
			}
			return mapMarkMap.GetValueOrNull(markId);
		}

		// Token: 0x0602C29A RID: 180890 RVA: 0x00C66E57 File Offset: 0x00C65057
		public Dictionary<int, MapMark> GetConfigMarkMap()
		{
			return this.MapMarkMap;
		}

		// Token: 0x0602C29B RID: 180891 RVA: 0x00C66E60 File Offset: 0x00C65060
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

		// Token: 0x0602C29C RID: 180892 RVA: 0x00C66EAC File Offset: 0x00C650AC
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

		// Token: 0x0602C29D RID: 180893 RVA: 0x00C66F0C File Offset: 0x00C6510C
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

		// Token: 0x0602C29E RID: 180894 RVA: 0x00C66F80 File Offset: 0x00C65180
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

		// Token: 0x0602C29F RID: 180895 RVA: 0x00C67014 File Offset: 0x00C65214
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

		// Token: 0x0602C2A0 RID: 180896 RVA: 0x00C67060 File Offset: 0x00C65260
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

		// Token: 0x0602C2A1 RID: 180897 RVA: 0x00C670AB File Offset: 0x00C652AB
		public bool GetIsInstanceTeleporterExist(int instEntityTeleportId)
		{
			return this.InstanceTeleporterIdList.Contains(instEntityTeleportId);
		}

		// Token: 0x0602C2A2 RID: 180898 RVA: 0x00C670BC File Offset: 0x00C652BC
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

		// Token: 0x0602C2A3 RID: 180899 RVA: 0x00C67108 File Offset: 0x00C65308
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

		// Token: 0x0602C2A4 RID: 180900 RVA: 0x00C67158 File Offset: 0x00C65358
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

		// Token: 0x0602C2A5 RID: 180901 RVA: 0x00C6718F File Offset: 0x00C6538F
		[NullableContext(2)]
		public IReadOnlyList<FogTextureConfig> GetAllTileConfig()
		{
			return ConfigFogTextureConfigAll.GetConfigList(true);
		}

		// Token: 0x0602C2A6 RID: 180902 RVA: 0x00C67197 File Offset: 0x00C65397
		[NullableContext(2)]
		public IReadOnlyList<FogTextureConfig> GetAllTileConfigByMapId(int mapId)
		{
			return ConfigFogTextureConfigByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x0602C2A7 RID: 180903 RVA: 0x00C671A0 File Offset: 0x00C653A0
		public BlockSwitch? GetUnlockMapTileConfigById(int id)
		{
			return ConfigBlockSwitchById.GetConfig(id, true);
		}

		// Token: 0x0602C2A8 RID: 180904 RVA: 0x00C671AC File Offset: 0x00C653AC
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

		// Token: 0x0602C2A9 RID: 180905 RVA: 0x00C67210 File Offset: 0x00C65410
		public MultiMap? GetSubMapConfigById(int id)
		{
			MultiMap value;
			if (this.MultiMapConfigMapping.TryGetValue(id, out value))
			{
				return new MultiMap?(value);
			}
			return null;
		}

		// Token: 0x0602C2AA RID: 180906 RVA: 0x00C6723D File Offset: 0x00C6543D
		public List<MultiMap> GetAllSubMapConfig()
		{
			return this.MultiMapConfigArray;
		}

		// Token: 0x0602C2AB RID: 180907 RVA: 0x00C67248 File Offset: 0x00C65448
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

		// Token: 0x0602C2AC RID: 180908 RVA: 0x00C67284 File Offset: 0x00C65484
		public bool IsAreaInSubMap(int multiMapId, int areaId)
		{
			HashSet<int> hashSet;
			return this.SubMapAreaSetMapping.TryGetValue(multiMapId, out hashSet) && hashSet.Contains(areaId);
		}

		// Token: 0x0602C2AD RID: 180909 RVA: 0x00C672AC File Offset: 0x00C654AC
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

		// Token: 0x0602C2AE RID: 180910 RVA: 0x00C672F8 File Offset: 0x00C654F8
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

		// Token: 0x0602C2AF RID: 180911 RVA: 0x00C6735A File Offset: 0x00C6555A
		public string GetLocalText(string textKey)
		{
			return ConfigMultiTextLang.GetLocalTextNew(textKey, null) ?? "";
		}

		// Token: 0x0602C2B0 RID: 180912 RVA: 0x00C6736C File Offset: 0x00C6556C
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

		// Token: 0x0602C2B1 RID: 180913 RVA: 0x00C6740C File Offset: 0x00C6560C
		private string GetMapBorderConfigKey(int borderId, int mapId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(borderId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602C2B2 RID: 180914 RVA: 0x00C67448 File Offset: 0x00C65648
		public MapBorder? GetMapBorderConfig(int borderId, int mapId)
		{
			string mapBorderConfigKey = this.GetMapBorderConfigKey(borderId, mapId);
			return this.MapBorderMapping.GetValueOrNull(mapBorderConfigKey);
		}

		// Token: 0x0602C2B3 RID: 180915 RVA: 0x00C6746A File Offset: 0x00C6566A
		[NullableContext(2)]
		public IReadOnlyList<MapBorder> GetMapBorderConfigList()
		{
			return ConfigMapBorderAll.GetConfigList(true);
		}

		// Token: 0x0602C2B4 RID: 180916 RVA: 0x00C67472 File Offset: 0x00C65672
		public int? GetMapDissolveTime()
		{
			return ConfigCommonParamById.GetIntConfig("MapDissolveTime");
		}

		// Token: 0x0602C2B5 RID: 180917 RVA: 0x00C67480 File Offset: 0x00C65680
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

		// Token: 0x0602C2B6 RID: 180918 RVA: 0x00C674CC File Offset: 0x00C656CC
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

		// Token: 0x0602C2B7 RID: 180919 RVA: 0x00C67518 File Offset: 0x00C65718
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

		// Token: 0x0602C2B8 RID: 180920 RVA: 0x00C67564 File Offset: 0x00C65764
		public MapMarkRelativeSubType? GetMapMarkFuncTypeConfigByFuncId(int functionType)
		{
			if (this.MarkHasFunctionMap != null && this.MarkHasFunctionMap.ContainsKey(functionType))
			{
				return ConfigMapMarkRelativeSubTypeByFunctionId.GetConfig(functionType, true);
			}
			return null;
		}

		// Token: 0x0602C2B9 RID: 180921 RVA: 0x00C67598 File Offset: 0x00C65798
		public MapMarkRelativeSubType? GetMapMarkFuncTypeConfigById(int id)
		{
			return ConfigMapMarkRelativeSubTypeById.GetConfig(id, true);
		}

		// Token: 0x0602C2BA RID: 180922 RVA: 0x00C675A4 File Offset: 0x00C657A4
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

		// Token: 0x0602C2BB RID: 180923 RVA: 0x00C6760C File Offset: 0x00C6580C
		[NullableContext(2)]
		public IReadOnlyList<MultiMapAreaConfig> GetMultiMapAreaConfigList()
		{
			return ConfigMultiMapAreaConfigAll.GetConfigList(true);
		}

		// Token: 0x0602C2BC RID: 180924 RVA: 0x00C67614 File Offset: 0x00C65814
		[NullableContext(2)]
		public IReadOnlyList<EnrichmentAreaConfig> GetEnrichmentAreaConfigByItemId(int itemId)
		{
			return ConfigEnrichmentAreaConfigByItemId.GetConfigList(itemId, true);
		}

		// Token: 0x0602C2BD RID: 180925 RVA: 0x00C67620 File Offset: 0x00C65820
		public EnrichmentAreaConfig? GetEnrichmentAreaConfigByEnrichmentId(int enrichmentId)
		{
			IReadOnlyList<EnrichmentAreaConfig> configList = ConfigEnrichmentAreaConfigByEnrichmentId.GetConfigList(enrichmentId, true);
			if (configList != null && configList.Count > 0)
			{
				return new EnrichmentAreaConfig?(configList[0]);
			}
			return null;
		}

		// Token: 0x0602C2BE RID: 180926 RVA: 0x00C67657 File Offset: 0x00C65857
		public MapMark? GetMapMarkByRelativeId(int relativeId, int instanceDungeonId)
		{
			return ConfigMapMarkByRelativeId.GetConfig(relativeId, instanceDungeonId, true);
		}

		// Token: 0x0602C2BF RID: 180927 RVA: 0x00C67661 File Offset: 0x00C65861
		public MapMark? GetMapMarkByEntityConfigId(int entityId)
		{
			return ConfigMapMarkByEntityConfigId.GetConfig(entityId, true);
		}

		// Token: 0x0602C2C0 RID: 180928 RVA: 0x00C6766A File Offset: 0x00C6586A
		[NullableContext(2)]
		public IReadOnlyList<MapMark> GetMapMarkListByInstanceDungeonId(int instanceDungeonId)
		{
			return ConfigMapMarkByInstanceDungeonId.GetConfigList(instanceDungeonId, true);
		}

		// Token: 0x0602C2C1 RID: 180929 RVA: 0x00C67673 File Offset: 0x00C65873
		public MapPeriodicActivity? GetMapPeriodicActivityConfig(EMapPeriodicActivityId id)
		{
			return ConfigMapPeriodicActivityById.GetConfig((int)id, true);
		}

		// Token: 0x0602C2C2 RID: 180930 RVA: 0x00C6767C File Offset: 0x00C6587C
		[NullableContext(2)]
		public IReadOnlyList<MapPeriodicActivity> GetMapPeriodicActivityListConfigs()
		{
			return ConfigMapPeriodicActivityAll.GetConfigList(true);
		}

		// Token: 0x0602C2C3 RID: 180931 RVA: 0x00C67684 File Offset: 0x00C65884
		[NullableContext(2)]
		public IReadOnlyList<MapRoadWays> GetMapRoadWaysByMapId(int mapId)
		{
			return ConfigMapRoadWaysByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x0602C2C4 RID: 180932 RVA: 0x00C6768D File Offset: 0x00C6588D
		[NullableContext(2)]
		public IReadOnlyList<MapFog> GetMapFogByAreaId(int areaId)
		{
			return ConfigMapFogByAreaId.GetConfigList(areaId, true);
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x0602C2C5 RID: 180933 RVA: 0x00C67696 File Offset: 0x00C65896
		public static MapConfig Instance
		{
			get
			{
				return MapConfig._Instance;
			}
		}

		// Token: 0x0602C2C6 RID: 180934 RVA: 0x00C6769D File Offset: 0x00C6589D
		public static MapConfig GetOrCreateInstance()
		{
			if (MapConfig._Instance == null)
			{
				MapConfig.CreateInstance();
			}
			return MapConfig._Instance;
		}

		// Token: 0x0602C2C7 RID: 180935 RVA: 0x00C676B1 File Offset: 0x00C658B1
		public static bool CreateInstance()
		{
			if (MapConfig._Instance != null)
			{
				return true;
			}
			MapConfig._Instance = new MapConfig();
			return true;
		}

		// Token: 0x0602C2C8 RID: 180936 RVA: 0x00C676C7 File Offset: 0x00C658C7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C2C9 RID: 180937 RVA: 0x00C676C9 File Offset: 0x00C658C9
		public static void ResetStaticDefaultValue()
		{
			MapConfig._Instance = null;
		}

		// Token: 0x0602C2CA RID: 180938 RVA: 0x00C676D1 File Offset: 0x00C658D1
		static MapConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapConfig.CreateStaticDefaultValue), new Action(MapConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04017C5F RID: 97375
		private readonly Dictionary<string, FogTextureConfig> FogTextureConfigMap = new Dictionary<string, FogTextureConfig>();

		// Token: 0x04017C60 RID: 97376
		[Nullable(2)]
		private Dictionary<int, bool> MarkHasFunctionMap;

		// Token: 0x04017C61 RID: 97377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, bool> MapFogConfigMap;

		// Token: 0x04017C62 RID: 97378
		[Nullable(2)]
		private Dictionary<int, TaskMark> TaskMarkMap;

		// Token: 0x04017C63 RID: 97379
		[Nullable(2)]
		private Dictionary<int, MapMark> MapMarkMap;

		// Token: 0x04017C64 RID: 97380
		[Nullable(2)]
		private Dictionary<int, DynamicMapMark> DynamicMarkMap;

		// Token: 0x04017C65 RID: 97381
		[Nullable(2)]
		private Dictionary<int, MonsterDetection> MonsterDetectionMap;

		// Token: 0x04017C66 RID: 97382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IWorldMapNavigate> WorldMapNavigateAreaMapInner;

		// Token: 0x04017C67 RID: 97383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IWorldMapNavigateCountry> WorldMapNavigateCountryMapInner;

		// Token: 0x04017C68 RID: 97384
		private readonly List<IWorldMapNavigateCountryData> WorldMapNavigateCountryListInner = new List<IWorldMapNavigateCountryData>();

		// Token: 0x04017C69 RID: 97385
		private readonly HashSet<string> SearchLevelEntityConfigFailureLogSet = new HashSet<string>();

		// Token: 0x04017C6A RID: 97386
		private readonly Dictionary<string, MapBorder> MapBorderMapping = new Dictionary<string, MapBorder>();

		// Token: 0x04017C6B RID: 97387
		private readonly Dictionary<int, MultiMap> MultiMapConfigMapping = new Dictionary<int, MultiMap>();

		// Token: 0x04017C6C RID: 97388
		private readonly List<MultiMap> MultiMapConfigArray = new List<MultiMap>();

		// Token: 0x04017C6D RID: 97389
		private readonly Dictionary<int, int> AreaIdToMultiMapIdMapping = new Dictionary<int, int>();

		// Token: 0x04017C6E RID: 97390
		private readonly Dictionary<int, HashSet<int>> SubMapAreaSetMapping = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017C6F RID: 97391
		private readonly HashSet<int> InstanceTeleporterIdList = new HashSet<int>();

		// Token: 0x04017C70 RID: 97392
		[StaticVariableRuleIgnore]
		public static bool EnableAsyncMiniMap;

		// Token: 0x04017C71 RID: 97393
		[Nullable(2)]
		private static MapConfig _Instance;

		// Token: 0x0200A12C RID: 41260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032121 RID: 205089
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IWorldMapNavigate> <0>__CompareNavigate;
		}
	}
}
