using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.UnopenedArea;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Map
{
	// Token: 0x02005487 RID: 21639
	[NullableContext(1)]
	[Nullable(0)]
	public class MapModel : ModelBase
	{
		// Token: 0x17008472 RID: 33906
		// (get) Token: 0x06037388 RID: 226184 RVA: 0x00D18538 File Offset: 0x00D16738
		// (set) Token: 0x06037389 RID: 226185 RVA: 0x00D18540 File Offset: 0x00D16740
		public int? LastHighLevelArea
		{
			get
			{
				return this.LastHighLevelAreaInner;
			}
			set
			{
				this.LastHighLevelAreaInner = value;
			}
		}

		// Token: 0x0603738A RID: 226186 RVA: 0x00D1854C File Offset: 0x00D1674C
		protected override bool OnInit()
		{
			this.DynamicMarks = new Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>>();
			this.UnlockedTeleports = new Dictionary<int, bool>();
			this.UnlockedFogs = new Dictionary<int, bool>();
			this.UnlockedAreas = new Dictionary<int, bool>();
			this.PendingAddEntityList = new Dictionary<int, int>();
			this.PendingAddTempMapMarkList = new HashSet<int>();
			this.MarkExtraShowStateReference = new Dictionary<int, IMarkShowState>();
			this.DynamicMarksSearchMap = new Dictionary<int, DynamicMarkCreateInfo>();
			this.MarkVisibleStateRecord = new Dictionary<int, Dictionary<int, bool>>();
			this.SceneGamePlayRefQuestMap = new Dictionary<int, long>();
			this.OccupationResourceRefPlayMap = new Dictionary<string, int[]>();
			this.ServerUnlockedMarksMap = new Dictionary<int, bool>();
			this.MapLifeEventListenerTriggerMap = new Dictionary<EMapLifeEventListenerType, IMapLifeEventTriggerParam>();
			this.TreasureBoxSlotRawDataMap = new Dictionary<int, TreasureBoxSlotInfo>();
			this.TemporaryTeleportInfoRawDataMap = new Dictionary<int, TemporaryTeleportInfo>();
			this.UnlockMapBlockIds = new List<int>();
			this.SystemMarkHideInfoMap = new Dictionary<string, SystemMarkHideInfoPb>();
			this.EntityIdToMarkType = new Dictionary<int, EMarkType>();
			this.ExtraMarkTypeMap = new Dictionary<EMapType, HashSet<EMarkType>>();
			this.ExtraMarkIdMap = new Dictionary<EMapType, HashSet<int>>();
			this.ExtraUiTileRange = new Dictionary<EMapType, ITileNum>();
			this.InitTeleportMarkQueryCache();
			return true;
		}

		// Token: 0x0603738B RID: 226187 RVA: 0x00D18647 File Offset: 0x00D16847
		protected override bool OnChangeMode()
		{
			TrackModel.Instance.ClearTrackData();
			this.SetCurTrackMark(null);
			return true;
		}

		// Token: 0x0603738C RID: 226188 RVA: 0x00D1865C File Offset: 0x00D1685C
		protected override bool OnClear()
		{
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dynamicMarks = this.DynamicMarks;
			if (dynamicMarks != null)
			{
				dynamicMarks.Clear();
			}
			Dictionary<int, bool> unlockedTeleports = this.UnlockedTeleports;
			if (unlockedTeleports != null)
			{
				unlockedTeleports.Clear();
			}
			Dictionary<int, bool> unlockedFogs = this.UnlockedFogs;
			if (unlockedFogs != null)
			{
				unlockedFogs.Clear();
			}
			Dictionary<int, bool> unlockedAreas = this.UnlockedAreas;
			if (unlockedAreas != null)
			{
				unlockedAreas.Clear();
			}
			Dictionary<int, int> pendingAddEntityList = this.PendingAddEntityList;
			if (pendingAddEntityList != null)
			{
				pendingAddEntityList.Clear();
			}
			HashSet<int> pendingAddTempMapMarkList = this.PendingAddTempMapMarkList;
			if (pendingAddTempMapMarkList != null)
			{
				pendingAddTempMapMarkList.Clear();
			}
			Dictionary<int, Dictionary<int, bool>> markVisibleStateRecord = this.MarkVisibleStateRecord;
			if (markVisibleStateRecord != null)
			{
				markVisibleStateRecord.Clear();
			}
			Dictionary<int, long> sceneGamePlayRefQuestMap = this.SceneGamePlayRefQuestMap;
			if (sceneGamePlayRefQuestMap != null)
			{
				sceneGamePlayRefQuestMap.Clear();
			}
			Dictionary<string, int[]> occupationResourceRefPlayMap = this.OccupationResourceRefPlayMap;
			if (occupationResourceRefPlayMap != null)
			{
				occupationResourceRefPlayMap.Clear();
			}
			Dictionary<int, bool> serverUnlockedMarksMap = this.ServerUnlockedMarksMap;
			if (serverUnlockedMarksMap != null)
			{
				serverUnlockedMarksMap.Clear();
			}
			Dictionary<int, TreasureBoxSlotInfo> treasureBoxSlotRawDataMap = this.TreasureBoxSlotRawDataMap;
			if (treasureBoxSlotRawDataMap != null)
			{
				treasureBoxSlotRawDataMap.Clear();
			}
			Dictionary<int, TemporaryTeleportInfo> temporaryTeleportInfoRawDataMap = this.TemporaryTeleportInfoRawDataMap;
			if (temporaryTeleportInfoRawDataMap != null)
			{
				temporaryTeleportInfoRawDataMap.Clear();
			}
			this.TreasureChestCountMap.Clear();
			this.SystemMarkHideInfoMap.Clear();
			Dictionary<int, EMarkType> entityIdToMarkType = this.EntityIdToMarkType;
			if (entityIdToMarkType != null)
			{
				entityIdToMarkType.Clear();
			}
			this.DynamicMarks = null;
			this.UnlockedTeleports = null;
			this.UnlockedFogs = null;
			this.UnlockedAreas = null;
			this.PendingAddEntityList = null;
			this.PendingAddTempMapMarkList = null;
			this.CurTrackParams = null;
			this.CacheEnrichmentAreaWorldMapCircle = null;
			this.CacheEnrichmentAreaEntityId = 0;
			this.ExtraMarkTypeMap = null;
			this.ExtraMarkIdMap = null;
			this.ExtraUiTileRange = null;
			return true;
		}

		// Token: 0x0603738D RID: 226189 RVA: 0x00D187B1 File Offset: 0x00D169B1
		[NullableContext(2)]
		public Dictionary<int, bool> GetUnlockedTeleportMap()
		{
			return this.UnlockedTeleports;
		}

		// Token: 0x0603738E RID: 226190 RVA: 0x00D187B9 File Offset: 0x00D169B9
		[NullableContext(2)]
		public DynamicMarkCreateInfo GetDynamicMark(int markId)
		{
			Dictionary<int, DynamicMarkCreateInfo> dynamicMarksSearchMap = this.DynamicMarksSearchMap;
			if (dynamicMarksSearchMap == null)
			{
				return null;
			}
			return dynamicMarksSearchMap.GetValueOrDefault(markId);
		}

		// Token: 0x0603738F RID: 226191 RVA: 0x00D187D0 File Offset: 0x00D169D0
		[NullableContext(2)]
		public DynamicMarkCreateInfo GetMark(EMarkType markType, int markId)
		{
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dynamicMarks = this.DynamicMarks;
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (dynamicMarks != null && dynamicMarks.TryGetValue(markType, out dictionary))
			{
				DynamicMarkCreateInfo result;
				dictionary.TryGetValue(markId, out result);
				return result;
			}
			return null;
		}

		// Token: 0x06037390 RID: 226192 RVA: 0x00D18801 File Offset: 0x00D16A01
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, DynamicMarkCreateInfo> GetMarkByType(EMarkType markType)
		{
			return this.DynamicMarks.GetValueOrDefault(markType);
		}

		// Token: 0x06037391 RID: 226193 RVA: 0x00D18810 File Offset: 0x00D16A10
		public int GetMarkCountByType(EMarkType markType)
		{
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dynamicMarks = this.DynamicMarks;
			int? num;
			if (dynamicMarks == null)
			{
				num = null;
			}
			else
			{
				Dictionary<int, DynamicMarkCreateInfo> valueOrDefault = dynamicMarks.GetValueOrDefault(markType);
				num = ((valueOrDefault != null) ? new int?(valueOrDefault.Count) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x06037392 RID: 226194 RVA: 0x00D1885C File Offset: 0x00D16A5C
		public TTrackTarget GetConfigMarkTrackTarget(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark != null)
			{
				if (configMark.Value.EntityConfigId > 0)
				{
					return configMark.Value.EntityConfigId;
				}
				if (configMark.Value.MarkVector != null)
				{
					return global::Vector.Create(configMark.Value.MarkVector);
				}
			}
			return 0;
		}

		// Token: 0x06037393 RID: 226195 RVA: 0x00D188E0 File Offset: 0x00D16AE0
		[NullableContext(2)]
		public QuestMarkCreateInfo GetMarkByQuestId(int questId)
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.Quest);
			if (markByType != null)
			{
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in markByType.Values)
				{
					QuestMarkCreateInfo questMarkCreateInfo = (QuestMarkCreateInfo)dynamicMarkCreateInfo;
					if (questMarkCreateInfo.NodeId != 0)
					{
						long treeId = questMarkCreateInfo.TreeId;
						BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeId), false);
						if (behaviorTree != null && behaviorTree.TreeConfigId == questId)
						{
							return questMarkCreateInfo;
						}
					}
					else if (questMarkCreateInfo.TreeId == (long)questId)
					{
						return questMarkCreateInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06037394 RID: 226196 RVA: 0x00D18988 File Offset: 0x00D16B88
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> GetAllDynamicMarks()
		{
			return this.DynamicMarks;
		}

		// Token: 0x06037395 RID: 226197 RVA: 0x00D18990 File Offset: 0x00D16B90
		[NullableContext(2)]
		public DynamicMarkCreateInfo GetDynamicMarkInfoById(int markId)
		{
			DynamicMarkCreateInfo result = null;
			if (this.DynamicMarks != null)
			{
				using (Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>>.ValueCollection.Enumerator enumerator = this.DynamicMarks.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DynamicMarkCreateInfo dynamicMarkCreateInfo;
						if (enumerator.Current.TryGetValue(markId, out dynamicMarkCreateInfo))
						{
							result = dynamicMarkCreateInfo;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06037396 RID: 226198 RVA: 0x00D189FC File Offset: 0x00D16BFC
		[NullableContext(2)]
		public void SetCurTrackMark(TrackMapMarkParams trackMark)
		{
			this.CurTrackParams = trackMark;
		}

		// Token: 0x06037397 RID: 226199 RVA: 0x00D18A08 File Offset: 0x00D16C08
		[NullableContext(2)]
		public bool IsEqualToCurTrack(TrackMapMarkParams trackMark)
		{
			int? num = (trackMark != null) ? new int?(trackMark.MarkId) : null;
			TrackMapMarkParams curTrackParams = this.CurTrackParams;
			int? num2 = (curTrackParams != null) ? new int?(curTrackParams.MarkId) : null;
			if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
			{
				EMarkType? emarkType = (trackMark != null) ? new EMarkType?(trackMark.MarkType) : null;
				TrackMapMarkParams curTrackParams2 = this.CurTrackParams;
				EMarkType? emarkType2 = (curTrackParams2 != null) ? new EMarkType?(curTrackParams2.MarkType) : null;
				if (emarkType.GetValueOrDefault() == emarkType2.GetValueOrDefault() & emarkType != null == (emarkType2 != null))
				{
					bool? flag = (trackMark != null) ? new bool?(trackMark.Track) : null;
					TrackMapMarkParams curTrackParams3 = this.CurTrackParams;
					bool? flag2 = (curTrackParams3 != null) ? new bool?(curTrackParams3.Track) : null;
					if (flag.GetValueOrDefault() == flag2.GetValueOrDefault() & flag != null == (flag2 != null))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06037398 RID: 226200 RVA: 0x00D18B39 File Offset: 0x00D16D39
		[NullableContext(2)]
		public TrackMapMarkParams GetCurTrackMark()
		{
			return this.CurTrackParams;
		}

		// Token: 0x06037399 RID: 226201 RVA: 0x00D18B41 File Offset: 0x00D16D41
		public void CreateServerSaveMark(DynamicMarkCreateInfo info)
		{
			this.CreateDynamicMark(info);
		}

		// Token: 0x0603739A RID: 226202 RVA: 0x00D18B4C File Offset: 0x00D16D4C
		public int CreateDyMarkByEntity(int entityId, EMarkType markType, int configId, int mapId)
		{
			Dictionary<int, DynamicMarkCreateInfo> valueOrDefault = this.DynamicMarks.GetValueOrDefault(markType);
			if (valueOrDefault != null)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo = valueOrDefault.Values.FirstOrDefault((DynamicMarkCreateInfo mark) => (TTrackTarget_Int)mark.TrackTarget == entityId);
				if (dynamicMarkCreateInfo != null)
				{
					return dynamicMarkCreateInfo.MarkId.Value;
				}
			}
			DynamicMarkCreateInfo info = new DynamicMarkCreateInfo(new DynamicMarkCreateParams
			{
				TrackTarget = entityId,
				MarkConfigId = configId,
				MarkType = markType,
				DestroyOnUnTrack = new bool?(true),
				MapAndDungeonInfo = new MapAndDungeonInfo
				{
					MapConfigId = new int?(mapId)
				},
				EntityConfigId = new int?(entityId)
			});
			return this.CreateMapMark(info);
		}

		// Token: 0x0603739B RID: 226203 RVA: 0x00D18C07 File Offset: 0x00D16E07
		public void CreateTempMapMark(int mapMarkId)
		{
			this.AddPendingTempMapMarkList(mapMarkId);
			EventSystem.Instance.Emit<int>(EEventName.CreateTempMapMark, mapMarkId);
		}

		// Token: 0x0603739C RID: 226204 RVA: 0x00D18C21 File Offset: 0x00D16E21
		public HashSet<int> GetPendingAddTempMapMarkList()
		{
			return this.PendingAddTempMapMarkList;
		}

		// Token: 0x0603739D RID: 226205 RVA: 0x00D18C29 File Offset: 0x00D16E29
		public void ClearPendingAddTempMapMarkList()
		{
			HashSet<int> pendingAddTempMapMarkList = this.PendingAddTempMapMarkList;
			if (pendingAddTempMapMarkList == null)
			{
				return;
			}
			pendingAddTempMapMarkList.Clear();
		}

		// Token: 0x0603739E RID: 226206 RVA: 0x00D18C3B File Offset: 0x00D16E3B
		public void AddPendingTempMapMarkList(int mapMarkId)
		{
			HashSet<int> pendingAddTempMapMarkList = this.PendingAddTempMapMarkList;
			if (pendingAddTempMapMarkList == null)
			{
				return;
			}
			pendingAddTempMapMarkList.Add(mapMarkId);
		}

		// Token: 0x0603739F RID: 226207 RVA: 0x00D18C50 File Offset: 0x00D16E50
		public int CreateMapMark(DynamicMarkCreateInfo info)
		{
			info.MarkId = new int?(this.SpawnDynamicMarkId());
			this.CreateDynamicMark(info);
			return info.MarkId.Value;
		}

		// Token: 0x060373A0 RID: 226208 RVA: 0x00D18C84 File Offset: 0x00D16E84
		public void CacheMapFishingShipMark(EntityMapMarkInfoPb[] entityMapMarkInfo)
		{
			this.CacheEntityMapMarkInfo.Clear();
			foreach (EntityMapMarkInfoPb entityMapMarkInfoPb in entityMapMarkInfo)
			{
				List<MarkDefine.FishingShipMarkCacheInfo> cacheEntityMapMarkInfo = this.CacheEntityMapMarkInfo;
				MarkDefine.FishingShipMarkCacheInfo fishingShipMarkCacheInfo = new MarkDefine.FishingShipMarkCacheInfo();
				fishingShipMarkCacheInfo.InstanceId = entityMapMarkInfoPb.InstId;
				fishingShipMarkCacheInfo.TemplateId = entityMapMarkInfoPb.TemplateId;
				Aki.Protocol.Vector location = entityMapMarkInfoPb.Location;
				fishingShipMarkCacheInfo.PositionX = (double)((location != null) ? location.X : 0f);
				Aki.Protocol.Vector location2 = entityMapMarkInfoPb.Location;
				fishingShipMarkCacheInfo.PositionY = (double)((location2 != null) ? location2.Y : 0f);
				Aki.Protocol.Vector location3 = entityMapMarkInfoPb.Location;
				fishingShipMarkCacheInfo.PositionZ = (double)((location3 != null) ? location3.Z : 0f);
				cacheEntityMapMarkInfo.Add(fishingShipMarkCacheInfo);
				ELogAuthor author = ELogAuthor.LYX;
				string message = "标记系统->CacheMapFishingShipMark";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkInfo", entityMapMarkInfoPb);
				MapLogger.Debug(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.TryRecreateShipMark();
		}

		// Token: 0x060373A1 RID: 226209 RVA: 0x00D18D5C File Offset: 0x00D16F5C
		public void TryRecreateShipMark()
		{
			if (this.GetMarkCountByType(EMarkType.FishingShip) > 0)
			{
				return;
			}
			foreach (MarkDefine.FishingShipMarkCacheInfo fishingShipMarkCacheInfo in this.CacheEntityMapMarkInfo)
			{
				FishingShipMarkCreateInfo info = new FishingShipMarkCreateInfo(new DynamicMarkCreateParams
				{
					TrackTarget = global::Vector.Create(fishingShipMarkCacheInfo.PositionX, fishingShipMarkCacheInfo.PositionY, fishingShipMarkCacheInfo.PositionZ),
					MarkConfigId = 8,
					MarkType = EMarkType.FishingShip,
					TrackSource = new ETrackSource?(ETrackSource.MapMark),
					EntityConfigId = new int?(fishingShipMarkCacheInfo.TemplateId),
					MapAndDungeonInfo = new MapAndDungeonInfo
					{
						DungeonId = new int?(fishingShipMarkCacheInfo.InstanceId)
					}
				});
				this.CreateMapMark(info);
			}
		}

		// Token: 0x060373A2 RID: 226210 RVA: 0x00D18E38 File Offset: 0x00D17038
		public void RemoveFishingShipMarkAndCache()
		{
			this.CacheEntityMapMarkInfo.Clear();
			this.RemoveMapMarkByType(EMarkType.FishingShip);
		}

		// Token: 0x060373A3 RID: 226211 RVA: 0x00D18E50 File Offset: 0x00D17050
		public void SyncLocalShipLocationToCacheInfo()
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.FishingShip);
			if (markByType != null)
			{
				using (Dictionary<int, DynamicMarkCreateInfo>.ValueCollection.Enumerator enumerator = markByType.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DynamicMarkCreateInfo markInfo = enumerator.Current;
						List<MarkDefine.FishingShipMarkCacheInfo> list = this.CacheEntityMapMarkInfo.Where(delegate(MarkDefine.FishingShipMarkCacheInfo value)
						{
							int templateId = value.TemplateId;
							int? num = markInfo.EntityConfigId;
							if (templateId == num.GetValueOrDefault() & num != null)
							{
								int instanceId = value.InstanceId;
								num = markInfo.InstanceDungeonId;
								return instanceId == num.GetValueOrDefault() & num != null;
							}
							return false;
						}).ToList<MarkDefine.FishingShipMarkCacheInfo>();
						global::Vector trackPositionByTrackTargetConfig = MapUtil.GetTrackPositionByTrackTargetConfig(markInfo.TrackTarget, markInfo.MapId, null);
						if (list.Count > 0)
						{
							using (List<MarkDefine.FishingShipMarkCacheInfo>.Enumerator enumerator2 = list.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									MarkDefine.FishingShipMarkCacheInfo fishingShipMarkCacheInfo = enumerator2.Current;
									fishingShipMarkCacheInfo.PositionX = trackPositionByTrackTargetConfig.X;
									fishingShipMarkCacheInfo.PositionY = trackPositionByTrackTargetConfig.Y;
									fishingShipMarkCacheInfo.PositionZ = trackPositionByTrackTargetConfig.Z;
								}
								continue;
							}
						}
						this.CacheEntityMapMarkInfo.Add(new MarkDefine.FishingShipMarkCacheInfo
						{
							InstanceId = markInfo.InstanceDungeonId.GetValueOrDefault(),
							TemplateId = markInfo.EntityConfigId.GetValueOrDefault(),
							PositionX = trackPositionByTrackTargetConfig.X,
							PositionY = trackPositionByTrackTargetConfig.Y,
							PositionZ = trackPositionByTrackTargetConfig.Z
						});
					}
				}
			}
		}

		// Token: 0x060373A4 RID: 226212 RVA: 0x00D18FE0 File Offset: 0x00D171E0
		private bool IsNeedCheckSamePosition(DynamicMarkCreateInfo markInfo)
		{
			return markInfo.MarkType != EMarkType.Quest && markInfo.MarkType != EMarkType.TemporaryTeleport && markInfo.MarkType != EMarkType.TreasureBoxDetector && markInfo.MarkType != EMarkType.Custom;
		}

		// Token: 0x060373A5 RID: 226213 RVA: 0x00D19010 File Offset: 0x00D17210
		public void ResetDynamicMarkData()
		{
			Dictionary<int, IMarkShowState> markExtraShowStateReference = this.MarkExtraShowStateReference;
			if (markExtraShowStateReference != null)
			{
				markExtraShowStateReference.Clear();
			}
			Dictionary<int, bool> serverUnlockedMarksMap = this.ServerUnlockedMarksMap;
			if (serverUnlockedMarksMap != null)
			{
				serverUnlockedMarksMap.Clear();
			}
			Dictionary<int, DynamicMarkCreateInfo> valueOrDefault = this.DynamicMarks.GetValueOrDefault(EMarkType.Quest);
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dynamicMarks = this.DynamicMarks;
			Dictionary<int, DynamicMarkCreateInfo> markCreateInfoList = (dynamicMarks != null) ? dynamicMarks.GetValueOrDefault(EMarkType.Entity) : null;
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> exploreEntityDynamicMarks = this.GetExploreEntityDynamicMarks();
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dynamicMarks2 = this.DynamicMarks;
			if (dynamicMarks2 != null)
			{
				dynamicMarks2.Clear();
			}
			Dictionary<int, DynamicMarkCreateInfo> dynamicMarksSearchMap = this.DynamicMarksSearchMap;
			if (dynamicMarksSearchMap != null)
			{
				dynamicMarksSearchMap.Clear();
			}
			this.AddDynamicMarkDataList(EMarkType.Quest, valueOrDefault);
			this.AddDynamicMarkDataList(EMarkType.Entity, markCreateInfoList);
			this.AddExploreEntityDynamicMarks(exploreEntityDynamicMarks);
		}

		// Token: 0x060373A6 RID: 226214 RVA: 0x00D190A4 File Offset: 0x00D172A4
		private void AddDynamicMarkDataList(EMarkType markType, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<int, DynamicMarkCreateInfo> markCreateInfoList)
		{
			if (markCreateInfoList != null)
			{
				this.DynamicMarks[markType] = markCreateInfoList;
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in markCreateInfoList.Values)
				{
					this.DynamicMarksSearchMap[dynamicMarkCreateInfo.MarkId.Value] = dynamicMarkCreateInfo;
				}
			}
		}

		// Token: 0x060373A7 RID: 226215 RVA: 0x00D1911C File Offset: 0x00D1731C
		private void AddExploreEntityDynamicMarks(Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> exploreEntityDynamicMarks)
		{
			foreach (KeyValuePair<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> keyValuePair in exploreEntityDynamicMarks)
			{
				this.DynamicMarks[keyValuePair.Key] = keyValuePair.Value;
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in keyValuePair.Value.Values)
				{
					this.DynamicMarksSearchMap[dynamicMarkCreateInfo.MarkId.Value] = dynamicMarkCreateInfo;
				}
			}
		}

		// Token: 0x060373A8 RID: 226216 RVA: 0x00D191D8 File Offset: 0x00D173D8
		private Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> GetExploreEntityDynamicMarks()
		{
			Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> dictionary = new Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>>();
			Dictionary<int, DynamicMarkCreateInfo> valueOrDefault = this.DynamicMarks.GetValueOrDefault(EMarkType.SightSpot);
			if (valueOrDefault != null)
			{
				dictionary[EMarkType.SightSpot] = valueOrDefault;
			}
			valueOrDefault = this.DynamicMarks.GetValueOrDefault(EMarkType.FlyingHunter);
			if (valueOrDefault != null)
			{
				dictionary[EMarkType.FlyingHunter] = valueOrDefault;
			}
			valueOrDefault = this.DynamicMarks.GetValueOrDefault(EMarkType.Frostbite);
			if (valueOrDefault != null)
			{
				dictionary[EMarkType.Frostbite] = valueOrDefault;
			}
			return dictionary;
		}

		// Token: 0x060373A9 RID: 226217 RVA: 0x00D1923C File Offset: 0x00D1743C
		private void CreateDynamicMark(DynamicMarkCreateInfo info)
		{
			if (this.DynamicMarks == null)
			{
				return;
			}
			ELogAuthor author = ELogAuthor.LYX;
			string message = "标记系统->CreateDynamicMark";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DynamicMarkCreateInfo", info);
			MapLogger.Debug(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(info.MarkType, out dictionary))
			{
				dictionary = new Dictionary<int, DynamicMarkCreateInfo>();
				this.DynamicMarks[info.MarkType] = dictionary;
			}
			DynamicMarkCreateInfo dynamicMarkCreateInfo = null;
			foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo2 in dictionary.Values)
			{
				if (this.IsNeedCheckSamePosition(info))
				{
					TTrackTarget_Vector ttrackTarget_Vector = dynamicMarkCreateInfo2.TrackTarget as TTrackTarget_Vector;
					if (ttrackTarget_Vector != null)
					{
						TTrackTarget_Vector ttrackTarget_Vector2 = info.TrackTarget as TTrackTarget_Vector;
						if (ttrackTarget_Vector2 != null && ttrackTarget_Vector == ttrackTarget_Vector2)
						{
							dynamicMarkCreateInfo = dynamicMarkCreateInfo2;
						}
					}
				}
				int? markId = dynamicMarkCreateInfo2.MarkId;
				int? markId2 = info.MarkId;
				if (markId.GetValueOrDefault() == markId2.GetValueOrDefault() & markId != null == (markId2 != null))
				{
					dynamicMarkCreateInfo = dynamicMarkCreateInfo2;
				}
			}
			if (dynamicMarkCreateInfo != null)
			{
				ELogAuthor author2 = ELogAuthor.LYX;
				string message2 = "标记系统->existMarkInfo";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DynamicMarkCreateInfo", info);
				MapLogger.Debug(author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.RemoveMapMark(new EMarkType?(dynamicMarkCreateInfo.MarkType), dynamicMarkCreateInfo.MarkId);
			}
			dictionary[info.MarkId.Value] = info;
			this.DynamicMarksSearchMap[info.MarkId.Value] = info;
			EventSystem.Instance.Emit<DynamicMarkCreateInfo>(EEventName.CreateMapMark, info);
		}

		// Token: 0x060373AA RID: 226218 RVA: 0x00D193CC File Offset: 0x00D175CC
		public void SetTrackMark(EMarkType markType, int markId, bool value)
		{
			EventSystem.Instance.Emit<EMarkType, int, bool>(EEventName.TrackMapMark, markType, markId, value);
			if (value)
			{
				return;
			}
			if (this.DynamicMarks == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(markType, out dictionary))
			{
				return;
			}
			DynamicMarkCreateInfo dynamicMarkCreateInfo;
			if (dictionary.TryGetValue(markId, out dynamicMarkCreateInfo) && dynamicMarkCreateInfo != null && dynamicMarkCreateInfo.DestroyOnUnTrack)
			{
				this.RemoveMapMark(new EMarkType?(markType), new int?(markId));
			}
		}

		// Token: 0x060373AB RID: 226219 RVA: 0x00D19434 File Offset: 0x00D17634
		public bool IsMarkIdExist(EMarkType type, int markId)
		{
			if (this.DynamicMarks == null || type == EMarkType.None || markId == 0)
			{
				return false;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (this.DynamicMarks.TryGetValue(type, out dictionary))
			{
				return dictionary.ContainsKey(markId);
			}
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf != null)
			{
				if (oneOf.Value.IsT1)
				{
					return oneOf.Value.AsT1.ObjectType == (int)type;
				}
				if (oneOf.Value.IsT2)
				{
					return oneOf.Value.AsT2.ObjectType == (int)type;
				}
			}
			return false;
		}

		// Token: 0x060373AC RID: 226220 RVA: 0x00D194D8 File Offset: 0x00D176D8
		public EMarkType? GetMarkTypeByMarkId(int markId)
		{
			DynamicMarkCreateInfo dynamicMark = this.GetDynamicMark(markId);
			if (dynamicMark != null)
			{
				return new EMarkType?(dynamicMark.MarkType);
			}
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf != null)
			{
				if (oneOf.Value.IsT1)
				{
					return new EMarkType?((EMarkType)oneOf.Value.AsT1.ObjectType);
				}
				if (oneOf.Value.IsT2)
				{
					return new EMarkType?((EMarkType)oneOf.Value.AsT2.ObjectType);
				}
			}
			return null;
		}

		// Token: 0x060373AD RID: 226221 RVA: 0x00D19578 File Offset: 0x00D17778
		[NullableContext(0)]
		public ValueTuple<int, EMarkType>? GetSoundBoxDetectMark()
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.SoundBox);
			if (markByType != null && markByType.Count > 0)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo = markByType.Values.First<DynamicMarkCreateInfo>();
				return new ValueTuple<int, EMarkType>?(new ValueTuple<int, EMarkType>(dynamicMarkCreateInfo.MarkId.Value, dynamicMarkCreateInfo.MarkType));
			}
			Dictionary<int, DynamicMarkCreateInfo> markByType2 = this.GetMarkByType(EMarkType.CalmingWindBell);
			if (markByType2 != null && markByType2.Count > 0)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo2 = markByType2.Values.First<DynamicMarkCreateInfo>();
				return new ValueTuple<int, EMarkType>?(new ValueTuple<int, EMarkType>(dynamicMarkCreateInfo2.MarkId.Value, dynamicMarkCreateInfo2.MarkType));
			}
			return null;
		}

		// Token: 0x060373AE RID: 226222 RVA: 0x00D19614 File Offset: 0x00D17814
		[NullableContext(0)]
		public ValueTuple<int, EMarkType>? GetSoundBoxDetectMarkCalc()
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.SoundBox);
			Dictionary<int, DynamicMarkCreateInfo> markByType2 = this.GetMarkByType(EMarkType.CalmingWindBell);
			if ((markByType == null || markByType.Count == 0) && (markByType2 == null || markByType2.Count == 0))
			{
				return null;
			}
			int currentWorldMapConfigId = this.CurrentWorldMapConfigId;
			List<DynamicMarkCreateInfo> list = new List<DynamicMarkCreateInfo>();
			if (markByType != null)
			{
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in markByType.Values)
				{
					if (dynamicMarkCreateInfo.MapId == currentWorldMapConfigId)
					{
						list.Add(dynamicMarkCreateInfo);
					}
				}
			}
			if (markByType2 != null)
			{
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo2 in markByType2.Values)
				{
					if (dynamicMarkCreateInfo2.MapId == currentWorldMapConfigId)
					{
						list.Add(dynamicMarkCreateInfo2);
					}
				}
			}
			if (list.Count > 0)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo3 = list[0];
				double num = double.MaxValue;
				global::Vector playerPosition = WorldMapModel.Instance.GetPlayerPosition();
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo4 in list)
				{
					global::Vector v = global::Vector.Create(((TTrackTarget_Vector)dynamicMarkCreateInfo4.TrackTarget).Value);
					double num2 = global::Vector.Dist(playerPosition, v);
					if (num2 < num)
					{
						num = num2;
						dynamicMarkCreateInfo3 = dynamicMarkCreateInfo4;
					}
				}
				return new ValueTuple<int, EMarkType>?(new ValueTuple<int, EMarkType>(dynamicMarkCreateInfo3.MarkId.Value, dynamicMarkCreateInfo3.MarkType));
			}
			return this.GetSoundBoxDetectMark();
		}

		// Token: 0x060373AF RID: 226223 RVA: 0x00D197C8 File Offset: 0x00D179C8
		public bool IsConfigMarkIdUnlock(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null)
			{
				return false;
			}
			if (!this.IsMarkIdExist((EMarkType)configMark.Value.ObjectType, markId))
			{
				return false;
			}
			bool flag = this.IsFogUnlock(configMark.Value);
			bool flag2 = this.IsConditionUnlock(configMark.Value);
			return flag && flag2;
		}

		// Token: 0x060373B0 RID: 226224 RVA: 0x00D19824 File Offset: 0x00D17A24
		private bool IsFogUnlock(MapMark markConfig)
		{
			return markConfig.FogShow == 1 || this.CheckFogUnlocked(markConfig.FogHide, null);
		}

		// Token: 0x060373B1 RID: 226225 RVA: 0x00D19854 File Offset: 0x00D17A54
		private bool IsConditionUnlock(MapMark markConfig)
		{
			int showCondition = markConfig.ShowCondition;
			int markId = markConfig.MarkId;
			if (showCondition < 0)
			{
				return this.GetMarkExtraShowState(markId).ShowFlag > MapMarkShowFlag.Hide;
			}
			return showCondition == 0 || this.IsMarkUnlockedByServer(markId);
		}

		// Token: 0x060373B2 RID: 226226 RVA: 0x00D19894 File Offset: 0x00D17A94
		public unsafe void RemoveMapMark(EMarkType? markType, int? markId)
		{
			if (this.DynamicMarks == null || markType == null || markId == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(markType.Value, out dictionary) || dictionary == null)
			{
				return;
			}
			this.RemoveTrackMarkId(markId.Value);
			bool flag = dictionary.Remove(markId.Value);
			Dictionary<int, DynamicMarkCreateInfo> dynamicMarksSearchMap = this.DynamicMarksSearchMap;
			if (dynamicMarksSearchMap != null)
			{
				dynamicMarksSearchMap.Remove(markId.Value);
			}
			if (!flag)
			{
				return;
			}
			ELogAuthor author = ELogAuthor.LYX;
			string message = "标记系统->RemoveMapMark";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markType", markType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("markId", markId);
			MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit<EMarkType, int>(EEventName.RemoveMapMark, markType.Value, markId.Value);
		}

		// Token: 0x060373B3 RID: 226227 RVA: 0x00D19980 File Offset: 0x00D17B80
		public void RemoveMapMarkByType(EMarkType markType)
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(markType);
			if (markByType != null && markByType.Count > 0)
			{
				HashSet<int> hashSet = new HashSet<int>();
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in markByType.Values)
				{
					if (dynamicMarkCreateInfo.MarkId != null)
					{
						hashSet.Add(dynamicMarkCreateInfo.MarkId.Value);
					}
				}
				foreach (int value in hashSet)
				{
					this.RemoveMapMark(new EMarkType?(markType), new int?(value));
				}
			}
		}

		// Token: 0x060373B4 RID: 226228 RVA: 0x00D19A60 File Offset: 0x00D17C60
		public void RemoveMapMarksByConfigId(EMarkType? markType, int? markConfigId)
		{
			if (this.DynamicMarks == null || markType == null || markConfigId == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(markType.Value, out dictionary) || dictionary == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, DynamicMarkCreateInfo> keyValuePair in dictionary)
			{
				EMarkType markType2 = keyValuePair.Value.MarkType;
				EMarkType? emarkType = markType;
				if (markType2 == emarkType.GetValueOrDefault() & emarkType != null)
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (int value in list)
			{
				this.RemoveMapMark(markType, new int?(value));
			}
		}

		// Token: 0x060373B5 RID: 226229 RVA: 0x00D19B58 File Offset: 0x00D17D58
		public void RemoveDynamicMapMark(int? markId)
		{
			if (markId != null)
			{
				Dictionary<int, DynamicMarkCreateInfo> dynamicMarksSearchMap = this.DynamicMarksSearchMap;
				DynamicMarkCreateInfo dynamicMarkCreateInfo;
				if (dynamicMarksSearchMap != null && dynamicMarksSearchMap.TryGetValue(markId.Value, out dynamicMarkCreateInfo))
				{
					this.RemoveMapMark((dynamicMarkCreateInfo != null) ? new EMarkType?(dynamicMarkCreateInfo.MarkType) : null, (dynamicMarkCreateInfo != null) ? dynamicMarkCreateInfo.MarkId : null);
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "找不到mark id:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060373B6 RID: 226230 RVA: 0x00D19BF0 File Offset: 0x00D17DF0
		public void UpdateCustomMarkInfo(int markId, global::Vector newVector)
		{
			if (this.DynamicMarks == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(EMarkType.Custom, out dictionary))
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "找不到markId", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			DynamicMarkCreateInfo dynamicMarkCreateInfo;
			if (dictionary.TryGetValue(markId, out dynamicMarkCreateInfo))
			{
				dynamicMarkCreateInfo.TrackTarget = newVector;
			}
		}

		// Token: 0x060373B7 RID: 226231 RVA: 0x00D19C4C File Offset: 0x00D17E4C
		public void ReplaceCustomMarkIcon(int markId, int newConfigId)
		{
			if (this.DynamicMarks == null)
			{
				return;
			}
			Dictionary<int, DynamicMarkCreateInfo> dictionary;
			if (!this.DynamicMarks.TryGetValue(EMarkType.Custom, out dictionary))
			{
				return;
			}
			DynamicMarkCreateInfo dynamicMarkCreateInfo;
			if (!dictionary.TryGetValue(markId, out dynamicMarkCreateInfo))
			{
				return;
			}
			dynamicMarkCreateInfo.MarkConfigId = newConfigId;
			EventSystem.Instance.Emit<EMarkType, int, int>(EEventName.MapReplaceMarkResponse, EMarkType.Custom, markId, newConfigId);
		}

		// Token: 0x060373B8 RID: 226232 RVA: 0x00D19C9C File Offset: 0x00D17E9C
		public int SpawnDynamicMarkId()
		{
			int num = this.DynamicMarkId - 1;
			this.DynamicMarkId = num;
			return num;
		}

		// Token: 0x060373B9 RID: 226233 RVA: 0x00D19CBC File Offset: 0x00D17EBC
		public void UnlockTeleports(int[] ids, bool clearCache = false)
		{
			if (clearCache)
			{
				Dictionary<int, bool> unlockedTeleports = this.UnlockedTeleports;
				if (unlockedTeleports != null)
				{
					unlockedTeleports.Clear();
				}
			}
			if (ids.Length == 0)
			{
				return;
			}
			List<Teleporter> list = new List<Teleporter>();
			for (int i = 0; i < ids.Length; i++)
			{
				Teleporter? config = ConfigTeleporterById.GetConfig(ids[i], true);
				if (config != null)
				{
					list.Add(config.Value);
				}
			}
			foreach (Teleporter teleporter in list)
			{
				if (teleporter.TeleportEntityConfigId > 0)
				{
					CreatureController.Instance.ChangeLockTagByTeleportPbDataId(teleporter.TeleportEntityConfigId, GameplayTagDefine.EGameplayTagId["物体.物体阶段.已解锁"]);
				}
				this.UnlockedTeleports[teleporter.Id] = true;
				EventSystem.Instance.Emit<int>(EEventName.UnlockTeleport, teleporter.Id);
			}
		}

		// Token: 0x060373BA RID: 226234 RVA: 0x00D19DA8 File Offset: 0x00D17FA8
		public bool CheckTeleportUnlocked(int id)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(id);
			if (configMark != null && configMark.GetValueOrDefault().MarkFuncType == 1)
			{
				return this.GetMarkExtraShowState(id).ShowFlag == MapMarkShowFlag.ShowNormal;
			}
			if (configMark != null && configMark.Value.InstanceDungeonId != 0)
			{
				return this.IsInstanceTeleportUnlock(id);
			}
			return this.UnlockedTeleports.GetValueOrDefault(id, false);
		}

		// Token: 0x060373BB RID: 226235 RVA: 0x00D19E20 File Offset: 0x00D18020
		public bool IsTeleportLocked(int markId)
		{
			return this.GetMarkExtraShowState(markId).ShowFlag == MapMarkShowFlag.ShowDisable || !this.CheckTeleportUnlocked(markId);
		}

		// Token: 0x060373BC RID: 226236 RVA: 0x00D19E40 File Offset: 0x00D18040
		public bool IsInstanceTeleportUnlock(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null || configMark.Value.InstanceDungeonId == 0)
			{
				return false;
			}
			if (!MapConfig.Instance.GetIsInstanceTeleporterExist(markId))
			{
				return false;
			}
			InstEntityTeleporter? instEntityTeleportConfigById = MapConfig.Instance.GetInstEntityTeleportConfigById(markId);
			if (instEntityTeleportConfigById == null)
			{
				return false;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(instEntityTeleportConfigById.Value.EntityConfigId);
			if (entityByPbDataId == null)
			{
				return false;
			}
			WorldEntity entity = entityByPbDataId.Entity;
			int? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				SceneItemStateComponent component = entity.GetComponent<SceneItemStateComponent>();
				num = ((component != null) ? new int?(component.StateTagId) : null);
			}
			int? num2 = num;
			int num3 = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"];
			return num2.GetValueOrDefault() == num3 & num2 != null;
		}

		// Token: 0x060373BD RID: 226237 RVA: 0x00D19F16 File Offset: 0x00D18116
		[NullableContext(2)]
		public Dictionary<int, bool> GetAllUnlockedFogs()
		{
			return this.UnlockedFogs;
		}

		// Token: 0x060373BE RID: 226238 RVA: 0x00D19F1E File Offset: 0x00D1811E
		public bool GetFogIsUnlocked(int fogId)
		{
			Dictionary<int, bool> unlockedFogs = this.UnlockedFogs;
			return unlockedFogs != null && unlockedFogs.GetValueOrDefault(fogId);
		}

		// Token: 0x060373BF RID: 226239 RVA: 0x00D19F32 File Offset: 0x00D18132
		[NullableContext(2)]
		public Dictionary<int, bool> GetAllUnlockedAreas()
		{
			return this.UnlockedAreas;
		}

		// Token: 0x060373C0 RID: 226240 RVA: 0x00D19F3A File Offset: 0x00D1813A
		public void AddUnlockedFogs(int fogId)
		{
			this.UnlockedFogs[fogId] = true;
			this.AddUnlockedAreaByFog(fogId);
			HonamiStoryModel.Instance.CurrentUnlockFogId = fogId;
			EventSystem.Instance.Emit<int>(EEventName.MapOpenFogChange, fogId);
		}

		// Token: 0x060373C1 RID: 226241 RVA: 0x00D19F6C File Offset: 0x00D1816C
		public void FullUpdateUnlockedFogs(RepeatedField<int> unlockFogIds)
		{
			this.UnlockedFogs.Clear();
			this.UnlockedAreas.Clear();
			foreach (int num in unlockFogIds)
			{
				this.UnlockedFogs[num] = true;
				this.AddUnlockedAreaByFog(num);
			}
			EventSystem.Instance.Emit<IReadOnlyDictionary<int, bool>>(EEventName.MapOpenFogFullUpdate, this.UnlockedFogs);
		}

		// Token: 0x060373C2 RID: 226242 RVA: 0x00D19FF0 File Offset: 0x00D181F0
		private void AddUnlockedAreaByFog(int fogId)
		{
			MapFog? mapFogConfig = WorldMapConfig.Instance.GetMapFogConfig(fogId);
			if (mapFogConfig != null)
			{
				this.UnlockedAreas[mapFogConfig.Value.AreaId] = true;
			}
		}

		// Token: 0x060373C3 RID: 226243 RVA: 0x00D1A02D File Offset: 0x00D1822D
		public bool CheckAreasUnlocked(int areaId, bool zeroAsUnlock = true)
		{
			if (areaId == 0 && zeroAsUnlock)
			{
				return true;
			}
			Dictionary<int, bool> unlockedAreas = this.UnlockedAreas;
			return unlockedAreas != null && unlockedAreas.GetValueOrDefault(areaId);
		}

		// Token: 0x060373C4 RID: 226244 RVA: 0x00D1A04C File Offset: 0x00D1824C
		public bool CheckFogUnlocked(int fogId, int? dungeonId = null)
		{
			if (fogId == 0)
			{
				return true;
			}
			if (dungeonId != null && !WorldMapConfig.Instance.IsMapInWorld(dungeonId.Value))
			{
				InstanceDungeon? instanceDungeon;
				return InstanceDungeonConfig.Instance.GetConfig(dungeonId.Value) != null && instanceDungeon.GetValueOrDefault().IsFogFullUnlock;
			}
			Dictionary<int, bool> unlockedFogs = this.UnlockedFogs;
			return unlockedFogs != null && unlockedFogs.GetValueOrDefault(fogId);
		}

		// Token: 0x060373C5 RID: 226245 RVA: 0x00D1A0BC File Offset: 0x00D182BC
		public bool IsMarkFogUnlock(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null)
			{
				return false;
			}
			MapMark value = configMark.Value;
			return value.FogShow == 1 || this.CheckFogUnlocked(value.FogHide, new int?(value.RelativeDungeonId));
		}

		// Token: 0x060373C6 RID: 226246 RVA: 0x00D1A10D File Offset: 0x00D1830D
		public void SetUnlockMultiMapIds(List<int> ids)
		{
			this.UnlockMultiMapIds = ids;
			EventSystem.Instance.Emit(EEventName.MultiMapUnlockChanged);
		}

		// Token: 0x060373C7 RID: 226247 RVA: 0x00D1A126 File Offset: 0x00D18326
		public void AddUnlockMultiMapIds(List<int> ids)
		{
			this.UnlockMultiMapIds = this.UnlockMultiMapIds.Union(ids).ToList<int>();
			EventSystem.Instance.Emit(EEventName.MultiMapUnlockChanged);
		}

		// Token: 0x060373C8 RID: 226248 RVA: 0x00D1A14F File Offset: 0x00D1834F
		public void SetUnlockMapBlockIds(List<int> ids)
		{
			this.UnlockMapBlockIds = ids;
			EventSystem.Instance.Emit(EEventName.MiniMapForceUpdate);
		}

		// Token: 0x060373C9 RID: 226249 RVA: 0x00D1A168 File Offset: 0x00D18368
		public void AddUnlockMapBlockIds(List<int> ids)
		{
			this.UnlockMapBlockIds = this.UnlockMapBlockIds.Union(ids).ToList<int>();
			EventSystem.Instance.Emit(EEventName.MiniMapForceUpdate);
		}

		// Token: 0x060373CA RID: 226250 RVA: 0x00D1A191 File Offset: 0x00D18391
		public bool CheckUnlockMultiMapIds(int id)
		{
			List<int> unlockMultiMapIds = this.UnlockMultiMapIds;
			return unlockMultiMapIds != null && unlockMultiMapIds.Contains(id);
		}

		// Token: 0x060373CB RID: 226251 RVA: 0x00D1A1A8 File Offset: 0x00D183A8
		public int CheckUnlockMapBlockIds(string block, EMapGravityDirection gravity, int mapId)
		{
			int result = 0;
			List<BlockSwitch> list = new List<BlockSwitch>();
			foreach (int id in this.UnlockMapBlockIds)
			{
				BlockSwitch? unlockMapTileConfigById = MapConfig.Instance.GetUnlockMapTileConfigById(id);
				if (unlockMapTileConfigById != null && unlockMapTileConfigById.Value.Block == block && unlockMapTileConfigById.Value.GravityFlip == (int)gravity && unlockMapTileConfigById.Value.MapConfigId == mapId)
				{
					list.Add(unlockMapTileConfigById.Value);
				}
			}
			if (list.Count > 0)
			{
				list.Sort((BlockSwitch a, BlockSwitch b) => b.Priority.CompareTo(a.Priority));
				result = list[0].Id;
			}
			return result;
		}

		// Token: 0x060373CC RID: 226252 RVA: 0x00D1A2A0 File Offset: 0x00D184A0
		public int CheckIsInMultiMapWithAreaId(int areaId)
		{
			int result = 0;
			foreach (MultiMap multiMap in MapConfig.Instance.GetAllSubMapConfig())
			{
				if (multiMap.GetAreaBytes().Contains(areaId))
				{
					result = multiMap.Id;
					break;
				}
			}
			return result;
		}

		// Token: 0x060373CD RID: 226253 RVA: 0x00D1A30C File Offset: 0x00D1850C
		public void AddEntityIdToPendingList(int entityId, int markId)
		{
			this.PendingAddEntityList[entityId] = markId;
		}

		// Token: 0x060373CE RID: 226254 RVA: 0x00D1A31B File Offset: 0x00D1851B
		public void RemoveEntityIdToPendingList(int entityId)
		{
			this.PendingAddEntityList.Remove(entityId);
		}

		// Token: 0x060373CF RID: 226255 RVA: 0x00D1A32A File Offset: 0x00D1852A
		[NullableContext(2)]
		public Dictionary<int, int> GetEntityPendingList()
		{
			return this.PendingAddEntityList;
		}

		// Token: 0x060373D0 RID: 226256 RVA: 0x00D1A334 File Offset: 0x00D18534
		public bool IsInMapPolygon(global::Vector playerPosition)
		{
			if (!this.CurrentInWorld)
			{
				return true;
			}
			if (this.LastSafeLocation.IsNearlyZero(9.999999747378752E-05))
			{
				this.LastSafeLocation.DeepCopy(playerPosition);
			}
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			int mapId = (instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MapConfigId : 0;
			instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			int dungeonId = (instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().Id : 0;
			bool flag = UnopenedAreaController.Instance.OnCheckUnopenedArea(playerPosition, mapId, dungeonId);
			if (flag)
			{
				this.LastSafeLocation.DeepCopy(playerPosition);
			}
			return flag;
		}

		// Token: 0x060373D1 RID: 226257 RVA: 0x00D1A3D7 File Offset: 0x00D185D7
		public global::Vector GetLastSafeLocation()
		{
			return this.LastSafeLocation;
		}

		// Token: 0x060373D2 RID: 226258 RVA: 0x00D1A3DF File Offset: 0x00D185DF
		public bool IsInUnopenedAreaPullback()
		{
			return GameModeModel.Instance.WorldDone && !GameModeModel.Instance.IsTeleport && this.CurrentInWorld && UnopenedAreaController.Instance.CheckInPullback();
		}

		// Token: 0x060373D3 RID: 226259 RVA: 0x00D1A411 File Offset: 0x00D18611
		public bool SetMarkExtraShowState(int markId, bool needFocus, MapMarkShowFlag showFlag)
		{
			this.MarkExtraShowStateReference[markId] = new MarkShowState
			{
				Id = markId,
				NeedFocus = needFocus,
				ShowFlag = showFlag
			};
			EventSystem.Instance.Emit<int>(EEventName.OnMarkItemShowStateChange, markId);
			return needFocus;
		}

		// Token: 0x060373D4 RID: 226260 RVA: 0x00D1A44C File Offset: 0x00D1864C
		public IMarkShowState GetMarkExtraShowState(int markId)
		{
			Dictionary<int, IMarkShowState> markExtraShowStateReference = this.MarkExtraShowStateReference;
			IMarkShowState markShowState = (markExtraShowStateReference != null) ? markExtraShowStateReference.GetValueOrDefault(markId) : null;
			if (markShowState == null)
			{
				markShowState = new MarkShowState
				{
					Id = markId,
					NeedFocus = false,
					ShowFlag = MapMarkShowFlag.Hide
				};
			}
			EMarkType? markTypeByMarkId = this.GetMarkTypeByMarkId(markId);
			if (markTypeByMarkId != null && this.IsMarkForbidGravityTeleport(markId, markTypeByMarkId.Value))
			{
				markShowState.ShowFlag = MapMarkShowFlag.ShowDisable;
			}
			return markShowState;
		}

		// Token: 0x060373D5 RID: 226261 RVA: 0x00D1A4B4 File Offset: 0x00D186B4
		public void UpdateCompleteMarks(int[] markIdList)
		{
			this.CompleteMarks.Clear();
			foreach (int item in markIdList)
			{
				this.CompleteMarks.Add(item);
			}
		}

		// Token: 0x060373D6 RID: 226262 RVA: 0x00D1A4F0 File Offset: 0x00D186F0
		public void SetCompleteMarkState(int[] markIdList)
		{
			foreach (int item in markIdList)
			{
				this.CompleteMarks.Add(item);
			}
		}

		// Token: 0x060373D7 RID: 226263 RVA: 0x00D1A51E File Offset: 0x00D1871E
		public bool IsCompleteMark(int markId)
		{
			return this.CompleteMarks.Contains(markId);
		}

		// Token: 0x060373D8 RID: 226264 RVA: 0x00D1A52C File Offset: 0x00D1872C
		public bool IsMarkForbidGravityTeleport(int markId, EMarkType markType)
		{
			return OnlineModel.Instance.GetIsTeamModel() && this.GetMarkMapGravity(markId, markType) == EMapGravityDirection.Up && WorldMapModel.Instance.IsGravityMap(this.GetMarkMapConfigId(markId, markType)) && this.MapMarkConfigIsCanTeleport(markId);
		}

		// Token: 0x060373D9 RID: 226265 RVA: 0x00D1A568 File Offset: 0x00D18768
		public bool MapMarkConfigIsCanTeleport(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null)
			{
				return false;
			}
			MapMark value = configMark.Value;
			return value.ObjectType == 6 || value.ObjectType == 5 || value.EnableQuickTransfer == 1;
		}

		// Token: 0x060373DA RID: 226266 RVA: 0x00D1A5B4 File Offset: 0x00D187B4
		public bool MapMarkIsCanTeleport(int markId)
		{
			return this.MapMarkConfigIsCanTeleport(markId) && !this.IsTeleportLocked(markId);
		}

		// Token: 0x060373DB RID: 226267 RVA: 0x00D1A5CC File Offset: 0x00D187CC
		public MapBorder? GetCurMapBorderConfig(int mapId, int instanceDungeonId, EMapType mapType, EMapGravityDirection gravity)
		{
			MapBorder? curMapBorderByFilterFunc = this.GetCurMapBorderByFilterFunc(delegate(MapBorder config)
			{
				bool flag = config.InstanceDungeonId == instanceDungeonId && config.GravityFlip == (int)gravity;
				if (config.InstanceDungeonIdMapType != 0)
				{
					return flag && config.InstanceDungeonIdMapType == (int)mapType;
				}
				return flag;
			});
			if (curMapBorderByFilterFunc != null)
			{
				return new MapBorder?(curMapBorderByFilterFunc.Value);
			}
			curMapBorderByFilterFunc = this.GetCurMapBorderByFilterFunc((MapBorder config) => config.MapId == mapId && config.GravityFlip == (int)gravity && config.InstanceDungeonId == 0);
			MapBorder? result = curMapBorderByFilterFunc;
			if (result == null)
			{
				return MapConfig.Instance.GetMapBorderConfig(1, mapId);
			}
			return result;
		}

		// Token: 0x060373DC RID: 226268 RVA: 0x00D1A658 File Offset: 0x00D18858
		public MapBorder? GetCurMapBorderByFilterFunc(Func<MapBorder, bool> filterFunc)
		{
			MapBorder? result = null;
			IReadOnlyList<MapBorder> mapBorderConfigList = MapConfig.Instance.GetMapBorderConfigList();
			if (mapBorderConfigList != null)
			{
				foreach (MapBorder mapBorder in mapBorderConfigList)
				{
					int conditionId = mapBorder.ConditionId;
					if (filterFunc(mapBorder))
					{
						bool flag = conditionId == 0 || LevelGeneralController.Instance.CheckCondition(conditionId.ToString(), null, false, Array.Empty<object>());
						if (!flag)
						{
							break;
						}
						result = new MapBorder?(mapBorder);
					}
				}
			}
			return result;
		}

		// Token: 0x060373DD RID: 226269 RVA: 0x00D1A6F0 File Offset: 0x00D188F0
		public void ForceSetMarkVisible(EMarkType markType, int markId, bool visible)
		{
			Dictionary<int, bool> dictionary;
			if (!this.MarkVisibleStateRecord.TryGetValue((int)markType, out dictionary))
			{
				dictionary = new Dictionary<int, bool>();
				this.MarkVisibleStateRecord[(int)markType] = dictionary;
			}
			dictionary[markId] = visible;
		}

		// Token: 0x060373DE RID: 226270 RVA: 0x00D1A728 File Offset: 0x00D18928
		public bool GetMarkForceVisible(EMarkType markType, int markId)
		{
			bool result = true;
			Dictionary<int, bool> dictionary;
			bool flag;
			if (this.MarkVisibleStateRecord.TryGetValue((int)markType, out dictionary) && dictionary.TryGetValue(markId, out flag))
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x060373DF RID: 226271 RVA: 0x00D1A758 File Offset: 0x00D18958
		public void AddOccupationInfo(OccupationPbInfo info)
		{
			NewOccupationConfig? newOccupationConfig = QuestNewConfig.Instance.GetNewOccupationConfig(info.ResourceName);
			if (newOccupationConfig == null || string.IsNullOrEmpty(newOccupationConfig.Value.OccupationData) || newOccupationConfig.Value.OccupationData == "Empty")
			{
				return;
			}
			OccupationData occupationData = Json.Parse<OccupationData>(newOccupationConfig.Value.OccupationData, null);
			if (occupationData == null)
			{
				return;
			}
			int[] levelPlayIds = occupationData.LevelPlayIds;
			foreach (int key in levelPlayIds)
			{
				this.SceneGamePlayRefQuestMap[key] = info.IncId;
			}
			this.OccupationResourceRefPlayMap[info.ResourceName] = levelPlayIds;
		}

		// Token: 0x060373E0 RID: 226272 RVA: 0x00D1A814 File Offset: 0x00D18A14
		public void RemoveOccupationInfo(string resource)
		{
			Dictionary<string, int[]> occupationResourceRefPlayMap = this.OccupationResourceRefPlayMap;
			if (occupationResourceRefPlayMap == null || !occupationResourceRefPlayMap.ContainsKey(resource))
			{
				return;
			}
			int[] array = this.OccupationResourceRefPlayMap[resource];
			Dictionary<string, int[]> occupationResourceRefPlayMap2 = this.OccupationResourceRefPlayMap;
			if (occupationResourceRefPlayMap2 != null)
			{
				occupationResourceRefPlayMap2.Remove(resource);
			}
			foreach (int key in array)
			{
				Dictionary<int, long> sceneGamePlayRefQuestMap = this.SceneGamePlayRefQuestMap;
				if (sceneGamePlayRefQuestMap != null)
				{
					sceneGamePlayRefQuestMap.Remove(key);
				}
			}
		}

		// Token: 0x060373E1 RID: 226273 RVA: 0x00D1A880 File Offset: 0x00D18A80
		public WorldLevelPlayOccupationResult IsLevelPlayOccupied(int levelPlayId)
		{
			Dictionary<int, long> sceneGamePlayRefQuestMap = this.SceneGamePlayRefQuestMap;
			long? questId = (sceneGamePlayRefQuestMap != null) ? sceneGamePlayRefQuestMap.GetValueOrNull(levelPlayId) : null;
			return new WorldLevelPlayOccupationResult
			{
				IsOccupied = (questId != null && questId.Value != 0L),
				QuestId = questId
			};
		}

		// Token: 0x060373E2 RID: 226274 RVA: 0x00D1A8D2 File Offset: 0x00D18AD2
		public bool IsMarkUnlockedByServer(int markId)
		{
			Dictionary<int, bool> serverUnlockedMarksMap = this.ServerUnlockedMarksMap;
			return serverUnlockedMarksMap != null && serverUnlockedMarksMap.GetValueOrDefault(markId);
		}

		// Token: 0x060373E3 RID: 226275 RVA: 0x00D1A8E6 File Offset: 0x00D18AE6
		public void SetMarkServerOpenState(int markId, bool state)
		{
			this.ServerUnlockedMarksMap[markId] = state;
		}

		// Token: 0x060373E4 RID: 226276 RVA: 0x00D1A8F8 File Offset: 0x00D18AF8
		public string GetMarkAreaText(int mapId, int entityId)
		{
			LevelEntityConfig? levelEntityConfig;
			int areaId = (MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(mapId, entityId) != null) ? levelEntityConfig.GetValueOrDefault().AreaId : 0;
			return this.GetMarkAreaTextByAreaId(areaId);
		}

		// Token: 0x060373E5 RID: 226277 RVA: 0x00D1A938 File Offset: 0x00D18B38
		public string GetMarkAreaTextByAreaId(int areaId)
		{
			int parentAreaId = AreaConfig.Instance.GetParentAreaId(areaId);
			Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			string text = (areaInfo != null) ? AreaConfig.Instance.GetAreaLocalName(areaInfo.Value.Title) : "";
			Aki.Config.Area? areaInfo2 = AreaConfig.Instance.GetAreaInfo(parentAreaId);
			string value = (areaInfo2 != null) ? AreaConfig.Instance.GetAreaLocalName(areaInfo2.Value.Title) : "";
			string text2 = (areaInfo != null) ? InfluenceConfig.Instance.GetCountryTitle(areaInfo.Value.CountryId) : "";
			int num = (areaInfo2 != null) ? areaInfo2.GetValueOrDefault().Level : 0;
			if ((areaInfo2 != null && areaInfo2.GetValueOrDefault().Father == 0) || num <= 0)
			{
				return text2 + "-" + text;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("-");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060373E6 RID: 226278 RVA: 0x00D1AA80 File Offset: 0x00D18C80
		public void UpdateBoxSlotInfo(TreasureBoxSlotInfo treasureBoxSlotInfo)
		{
			this.TreasureBoxSlotRawDataMap[treasureBoxSlotInfo.MarkId] = treasureBoxSlotInfo;
		}

		// Token: 0x060373E7 RID: 226279 RVA: 0x00D1AA94 File Offset: 0x00D18C94
		public void RemoveBoxSlotInfo(long slotId)
		{
			if (this.TreasureBoxSlotRawDataMap == null)
			{
				return;
			}
			foreach (TreasureBoxSlotInfo treasureBoxSlotInfo in this.TreasureBoxSlotRawDataMap.Values.ToList<TreasureBoxSlotInfo>())
			{
				if (treasureBoxSlotInfo.DetectionSlotId == slotId)
				{
					this.TreasureBoxSlotRawDataMap.Remove(treasureBoxSlotInfo.MarkId);
					break;
				}
			}
		}

		// Token: 0x060373E8 RID: 226280 RVA: 0x00D1AB10 File Offset: 0x00D18D10
		public void FullUpdateBoxSlotInfo(RepeatedField<TreasureBoxSlotInfo> allTreasureBoxSlotInfo)
		{
			this.TreasureBoxSlotRawDataMap.Clear();
			foreach (TreasureBoxSlotInfo treasureBoxSlotInfo in allTreasureBoxSlotInfo)
			{
				this.UpdateBoxSlotInfo(treasureBoxSlotInfo);
			}
		}

		// Token: 0x060373E9 RID: 226281 RVA: 0x00D1AB64 File Offset: 0x00D18D64
		[NullableContext(2)]
		public TreasureBoxSlotInfo GetBoxSlotInfoByMarkId(int markId)
		{
			if (this.TreasureBoxSlotRawDataMap == null)
			{
				return null;
			}
			return this.TreasureBoxSlotRawDataMap.Values.FirstOrDefault((TreasureBoxSlotInfo slotInfo) => slotInfo.MarkId == markId);
		}

		// Token: 0x060373EA RID: 226282 RVA: 0x00D1ABA4 File Offset: 0x00D18DA4
		public void FullUpdateTreasureChestCount(IEnumerable<TreasureChestCountData> infoList)
		{
			this.TreasureChestCountMap.Clear();
			foreach (TreasureChestCountData treasureChestCountData in infoList)
			{
				this.TreasureChestCountMap[new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(treasureChestCountData.TargetType, treasureChestCountData.TargetId, treasureChestCountData.StatType)] = treasureChestCountData;
			}
			EventSystem.Instance.Emit<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, null);
		}

		// Token: 0x060373EB RID: 226283 RVA: 0x00D1AC2C File Offset: 0x00D18E2C
		public void IncrementTreasureChestCount(TreasureChestStatType statType, IEnumerable<int> instanceIds, IEnumerable<int> areaIds)
		{
			HashSet<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>> keys = (from id in instanceIds
			select new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(TreasureChestCountTargetType.Instance, id, statType)).Concat(from id in areaIds
			select new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(TreasureChestCountTargetType.Area, id, statType)).ToHashSet<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>>();
			foreach (ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType> key in keys)
			{
				TreasureChestCountData treasureChestCountData;
				if (this.TreasureChestCountMap.TryGetValue(key, out treasureChestCountData))
				{
					TreasureChestCountData treasureChestCountData2 = treasureChestCountData;
					int currentCount = treasureChestCountData2.CurrentCount;
					treasureChestCountData2.CurrentCount = currentCount + 1;
				}
			}
			bool flag = this.GetCurTreasureChestCountList().Any((TreasureChestCountData info) => keys.Contains(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(info.TargetType, info.TargetId, info.StatType)));
			EventSystem.Instance.Emit<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, flag ? new TreasureChestStatType?(statType) : null);
		}

		// Token: 0x060373EC RID: 226284 RVA: 0x00D1AD20 File Offset: 0x00D18F20
		[NullableContext(2)]
		public TreasureChestCountData GetTreasureChestCount(TreasureChestCountTargetType targetType, int targetId, TreasureChestStatType statType)
		{
			return this.TreasureChestCountMap.GetValueOrDefault(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(targetType, targetId, statType));
		}

		// Token: 0x060373ED RID: 226285 RVA: 0x00D1AD38 File Offset: 0x00D18F38
		public List<TreasureChestCountData> GetTreasureChestCountList(TreasureChestCountTargetType targetType, int targetId)
		{
			return (from statType in MapDefine.TreasureChestStatTypeDisplayOrder
			select this.GetTreasureChestCount(targetType, targetId, statType) into info
			where info != null
			select info).ToList<TreasureChestCountData>();
		}

		// Token: 0x060373EE RID: 226286 RVA: 0x00D1ADC4 File Offset: 0x00D18FC4
		public List<TreasureChestCountData> GetCurTreasureChestCountList()
		{
			int[] statTypes;
			TreasureChestCountTargetType targetType;
			int targetId;
			if (!this.TryGetCurTreasureChestTarget(out targetType, out targetId, out statTypes))
			{
				return new List<TreasureChestCountData>();
			}
			return (from info in this.GetTreasureChestCountList(targetType, targetId)
			where statTypes.Contains((int)info.StatType)
			select info).ToList<TreasureChestCountData>();
		}

		// Token: 0x060373EF RID: 226287 RVA: 0x00D1AE10 File Offset: 0x00D19010
		private bool TryGetCurTreasureChestTarget(out TreasureChestCountTargetType targetType, out int targetId, out int[] statTypes)
		{
			if (WorldMapModel.Instance.IsPlayerInInstanceDungeon())
			{
				InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				targetType = TreasureChestCountTargetType.Instance;
				targetId = ((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().Id : 0);
				statTypes = (((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().GetTreasureChestStatTypesArray() : null) ?? Array.Empty<int>());
				return targetId != 0 && statTypes.Length != 0;
			}
			targetType = TreasureChestCountTargetType.Area;
			targetId = 0;
			statTypes = Array.Empty<int>();
			Aki.Config.Area? areaInfo = AreaModel.Instance.AreaInfo;
			if (areaInfo == null)
			{
				return false;
			}
			foreach (int num in AreaModel.Instance.GetAllAreaIdInheritable(areaInfo.Value))
			{
				Aki.Config.Area? area;
				int[] array = ((AreaConfig.Instance.GetAreaInfo(num) != null) ? area.GetValueOrDefault().GetTreasureChestStatTypesArray() : null) ?? Array.Empty<int>();
				if (array.Length != 0)
				{
					targetId = num;
					statTypes = array;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060373F0 RID: 226288 RVA: 0x00D1AF40 File Offset: 0x00D19140
		public void UpdateTemporaryTeleportInfo(TemporaryTeleportInfo temporaryTeleportInfo)
		{
			this.TemporaryTeleportInfoRawDataMap[temporaryTeleportInfo.MarkId] = temporaryTeleportInfo;
			DynamicMarkCreateInfo dynamicMark = this.GetDynamicMark(temporaryTeleportInfo.MarkId);
			if (dynamicMark != null)
			{
				dynamicMark.TeleportId = new int?((int)temporaryTeleportInfo.TemporaryTeleportId);
				if (temporaryTeleportInfo.Area > 0)
				{
					dynamicMark.AreaId = new int?(temporaryTeleportInfo.Area);
				}
			}
		}

		// Token: 0x060373F1 RID: 226289 RVA: 0x00D1AF9C File Offset: 0x00D1919C
		public void RemoveTemporaryTeleportInfo(int markId)
		{
			if (this.TemporaryTeleportInfoRawDataMap == null)
			{
				return;
			}
			foreach (TemporaryTeleportInfo temporaryTeleportInfo in this.TemporaryTeleportInfoRawDataMap.Values.ToList<TemporaryTeleportInfo>())
			{
				if (temporaryTeleportInfo.MarkId == markId)
				{
					this.TemporaryTeleportInfoRawDataMap.Remove(temporaryTeleportInfo.MarkId);
					break;
				}
			}
		}

		// Token: 0x060373F2 RID: 226290 RVA: 0x00D1B018 File Offset: 0x00D19218
		public void FullUpdateTemporaryTeleportInfo(RepeatedField<TemporaryTeleportInfo> allTemporaryTeleportInfo)
		{
			Dictionary<int, TemporaryTeleportInfo> temporaryTeleportInfoRawDataMap = this.TemporaryTeleportInfoRawDataMap;
			if (temporaryTeleportInfoRawDataMap != null)
			{
				temporaryTeleportInfoRawDataMap.Clear();
			}
			foreach (TemporaryTeleportInfo temporaryTeleportInfo in allTemporaryTeleportInfo)
			{
				this.UpdateTemporaryTeleportInfo(temporaryTeleportInfo);
			}
		}

		// Token: 0x060373F3 RID: 226291 RVA: 0x00D1B074 File Offset: 0x00D19274
		public int GetDungeonMapConfigId(int dungeonId)
		{
			if (dungeonId == 0)
			{
				return dungeonId;
			}
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(dungeonId);
			if (dungeonConfig == null)
			{
				return dungeonId;
			}
			return dungeonConfig.Value.MapConfigId;
		}

		// Token: 0x060373F4 RID: 226292 RVA: 0x00D1B0AC File Offset: 0x00D192AC
		public int? GetDungeonLocateWorldMapId(int dungeonId)
		{
			if (dungeonId == 0)
			{
				return null;
			}
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(dungeonId);
			if (dungeonConfig == null)
			{
				return null;
			}
			if (dungeonConfig.Value.InstSubType == 12)
			{
				InstanceDungeon? dungeonEntranceConfig = this.GetDungeonEntranceConfig(dungeonConfig.Value);
				if (dungeonEntranceConfig != null)
				{
					return new int?(dungeonEntranceConfig.Value.MapConfigId);
				}
			}
			return new int?(dungeonConfig.Value.MapConfigId);
		}

		// Token: 0x060373F5 RID: 226293 RVA: 0x00D1B138 File Offset: 0x00D19338
		[NullableContext(2)]
		public global::Vector GetDungeonLocateWorldMapLocation(int dungeonId)
		{
			if (dungeonId == 0)
			{
				return null;
			}
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(dungeonId);
			if (dungeonConfig == null)
			{
				return null;
			}
			if (dungeonConfig.Value.InstSubType != 12)
			{
				return null;
			}
			InstanceDungeon? dungeonEntranceConfig = this.GetDungeonEntranceConfig(dungeonConfig.Value);
			if (dungeonEntranceConfig != null)
			{
				int entranceEntityId = dungeonConfig.Value.EntranceEntities(0).Value.EntranceEntityId;
				return WorldMapModel.Instance.GetEntityPosition(entranceEntityId, dungeonEntranceConfig.Value.MapConfigId);
			}
			return null;
		}

		// Token: 0x060373F6 RID: 226294 RVA: 0x00D1B1CC File Offset: 0x00D193CC
		[NullableContext(2)]
		public global::Vector GetDungeonExitLocation(int dungeonId)
		{
			if (dungeonId == 0)
			{
				return null;
			}
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(dungeonId);
			if (dungeonConfig == null)
			{
				return null;
			}
			if (dungeonConfig.Value.InstSubType != 12)
			{
				return null;
			}
			int pbDataId = dungeonConfig.Value.ExitEntities(0);
			return WorldMapModel.Instance.GetEntityPosition(pbDataId, dungeonConfig.Value.MapConfigId);
		}

		// Token: 0x060373F7 RID: 226295 RVA: 0x00D1B238 File Offset: 0x00D19438
		public unsafe InstanceDungeon? GetDungeonEntranceConfig(InstanceDungeon config)
		{
			if (config.EntranceEntitiesLength < 1)
			{
				object key = config.Id;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "世界副本查找入口实体失败->实体列表为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("副本Id", config.Id);
				MapLogger.ErrorOnce(key, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int dungeonId = config.EntranceEntities(0).Value.DungeonId;
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(dungeonId);
			if (dungeonConfig == null)
			{
				object key2 = config.Id;
				ELogAuthor author2 = ELogAuthor.LYX;
				string message2 = "世界副本查找入口实体失败->入口副本配置为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("副本Id", config.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entranceDungeonId", dungeonId);
				MapLogger.ErrorOnce(key2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return dungeonConfig;
		}

		// Token: 0x060373F8 RID: 226296 RVA: 0x00D1B32C File Offset: 0x00D1952C
		public int GetMarkMapConfigId(int markId, EMarkType markType)
		{
			DynamicMarkCreateInfo mark = this.GetMark(markType, markId);
			if (mark != null)
			{
				return mark.MapId;
			}
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf != null && oneOf.GetValueOrDefault().IsT1)
			{
				return oneOf.Value.AsT1.MapId;
			}
			if (oneOf != null && oneOf.GetValueOrDefault().IsT2)
			{
				return oneOf.Value.AsT2.MapId;
			}
			return 8;
		}

		// Token: 0x060373F9 RID: 226297 RVA: 0x00D1B3C4 File Offset: 0x00D195C4
		public EMapGravityDirection GetMarkMapGravity(int markId, EMarkType markType)
		{
			DynamicMarkCreateInfo mark = this.GetMark(markType, markId);
			if (mark != null)
			{
				return mark.MapGravity;
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			int? num = (configMark != null) ? new int?(configMark.GetValueOrDefault().GravityFlip) : null;
			if (num != null)
			{
				return (EMapGravityDirection)num.Value;
			}
			return EMapGravityDirection.Down;
		}

		// Token: 0x060373FA RID: 226298 RVA: 0x00D1B42C File Offset: 0x00D1962C
		public int GetMarkAreaId(int markId, EMarkType markType)
		{
			DynamicMarkCreateInfo mark = this.GetMark(markType, markId);
			if (mark == null)
			{
				OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
				int? num;
				if (oneOf != null)
				{
					OneOf<MapMark, DynamicMapMark> valueOrDefault = oneOf.GetValueOrDefault();
					if (valueOrDefault.IsT1)
					{
						num = MapModel.GetEntityConfigAreaId(oneOf.Value.AsT1.MapId, oneOf.Value.AsT1.EntityConfigId);
						goto IL_F2;
					}
					if (valueOrDefault.IsT2)
					{
						num = MapModel.GetEntityConfigAreaId(oneOf.Value.AsT2.MapId, oneOf.Value.AsT2.EntityConfigId);
						goto IL_F2;
					}
				}
				num = new int?(0);
				IL_F2:
				return num.GetValueOrDefault();
			}
			int valueOrDefault2 = mark.AreaId.GetValueOrDefault();
			if (valueOrDefault2 != 0)
			{
				return valueOrDefault2;
			}
			return MapModel.GetEntityConfigAreaId(mark.MapId, mark.EntityConfigId.GetValueOrDefault()).GetValueOrDefault();
		}

		// Token: 0x060373FB RID: 226299 RVA: 0x00D1B534 File Offset: 0x00D19734
		[NullableContext(2)]
		public int ResolveWorldMapMarkAreaId(int mapId, int areaId, TTrackTarget trackTarget)
		{
			if (areaId != 0)
			{
				return areaId;
			}
			if (mapId != 912)
			{
				return 0;
			}
			TTrackTarget_Vector ttrackTarget_Vector = trackTarget as TTrackTarget_Vector;
			global::Vector vector;
			if (ttrackTarget_Vector == null)
			{
				TTrackTarget_Vector2D ttrackTarget_Vector2D = trackTarget as TTrackTarget_Vector2D;
				if (ttrackTarget_Vector2D == null)
				{
					vector = null;
				}
				else
				{
					vector = global::Vector.Create(ttrackTarget_Vector2D.Value.X, ttrackTarget_Vector2D.Value.Y, 0.0);
				}
			}
			else
			{
				vector = ttrackTarget_Vector.Value;
			}
			global::Vector vector2 = vector;
			if (vector2 == null)
			{
				return 0;
			}
			ITilePosition tilePosition = MapUtil.GetTilePosition(vector2, 0f);
			MapConfig instance = MapConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(tilePosition.X);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(tilePosition.Y);
			FogTextureConfig? tileConfig = instance.GetTileConfig(defaultInterpolatedStringHandler.ToStringAndClear(), mapId, EMapGravityDirection.Down);
			if (tileConfig == null || string.IsNullOrEmpty(tileConfig.Value.MapTilePath))
			{
				return 0;
			}
			int[] tileLoadFilterByAreaArray = tileConfig.Value.GetTileLoadFilterByAreaArray();
			if (tileLoadFilterByAreaArray == null || tileLoadFilterByAreaArray.Length <= 0)
			{
				return 0;
			}
			return tileLoadFilterByAreaArray[0];
		}

		// Token: 0x060373FC RID: 226300 RVA: 0x00D1B63C File Offset: 0x00D1983C
		public int? GetPlayerMarkAreaId(int playerId)
		{
			ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(playerId);
			if (scenePlayerData != null)
			{
				return new int?(scenePlayerData.GetAreaId());
			}
			OtherScenePlayerData otherScenePlayerDataByPlayerId = OnlineModel.Instance.GetOtherScenePlayerDataByPlayerId(playerId);
			if (otherScenePlayerDataByPlayerId == null)
			{
				return null;
			}
			return new int?(otherScenePlayerDataByPlayerId.Area);
		}

		// Token: 0x060373FD RID: 226301 RVA: 0x00D1B688 File Offset: 0x00D19888
		public int GetWorldMapMarkAreaId(int markId, EMarkType markType)
		{
			if (markType == EMarkType.OtherPlayers)
			{
				return this.GetPlayerMarkAreaId(markId).GetValueOrDefault();
			}
			int markAreaId = this.GetMarkAreaId(markId, markType);
			if (markAreaId != 0)
			{
				return markAreaId;
			}
			int markMapConfigId = this.GetMarkMapConfigId(markId, markType);
			if (markMapConfigId != 912)
			{
				return 0;
			}
			DynamicMarkCreateInfo mark = this.GetMark(markType, markId);
			TTrackTarget trackTarget = (mark != null) ? mark.TrackTarget : null;
			if (mark != null)
			{
				return this.ResolveWorldMapMarkAreaId(markMapConfigId, 0, trackTarget);
			}
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf != null && oneOf.GetValueOrDefault().IsT1)
			{
				MapMark asT = oneOf.Value.AsT1;
				if (asT.EntityConfigId == 0)
				{
					IntVector? markVector = asT.MarkVector;
					if (markVector != null)
					{
						IntVector valueOrDefault = markVector.GetValueOrDefault();
						trackTarget = global::Vector.Create((double)valueOrDefault.X, (double)valueOrDefault.Y, (double)valueOrDefault.Z);
					}
				}
			}
			else if (oneOf != null)
			{
				OneOf<MapMark, DynamicMapMark> valueOrDefault2 = oneOf.GetValueOrDefault();
				if (valueOrDefault2.IsT2)
				{
					DynamicMapMark asT2 = valueOrDefault2.AsT2;
					if (asT2.EntityConfigId == 0)
					{
						IntVector? markVector = asT2.MarkVector;
						if (markVector != null)
						{
							IntVector valueOrDefault3 = markVector.GetValueOrDefault();
							trackTarget = global::Vector.Create((double)valueOrDefault3.X, (double)valueOrDefault3.Y, (double)valueOrDefault3.Z);
						}
					}
				}
			}
			return this.ResolveWorldMapMarkAreaId(markMapConfigId, 0, trackTarget);
		}

		// Token: 0x060373FE RID: 226302 RVA: 0x00D1B7F0 File Offset: 0x00D199F0
		public static int? GetEntityConfigAreaId(int mapId, int entityId)
		{
			if (MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(mapId, entityId) == null)
			{
				return null;
			}
			LevelEntityConfig? levelEntityConfig;
			return new int?(levelEntityConfig.GetValueOrDefault().AreaId);
		}

		// Token: 0x17008473 RID: 33907
		// (get) Token: 0x060373FF RID: 226303 RVA: 0x00D1B834 File Offset: 0x00D19A34
		public int CurrentMapConfigId
		{
			get
			{
				InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				if (instanceDungeon == null || instanceDungeon.GetValueOrDefault().ViewMapId != 0)
				{
					return instanceDungeon.Value.ViewMapId;
				}
				if (instanceDungeon == null)
				{
					return 0;
				}
				return instanceDungeon.GetValueOrDefault().MapConfigId;
			}
		}

		// Token: 0x06037400 RID: 226304 RVA: 0x00D1B898 File Offset: 0x00D19A98
		public int GetDungeonWorldMapConfigId(int instanceDungeonId)
		{
			InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(instanceDungeonId);
			if (dungeonConfig != null && dungeonConfig.Value.ViewMapId != 0)
			{
				return dungeonConfig.Value.ViewMapId;
			}
			int? dungeonLocateWorldMapId = this.GetDungeonLocateWorldMapId(instanceDungeonId);
			if (dungeonLocateWorldMapId != null)
			{
				return dungeonLocateWorldMapId.GetValueOrDefault();
			}
			if (dungeonConfig == null)
			{
				return 0;
			}
			return dungeonConfig.GetValueOrDefault().MapConfigId;
		}

		// Token: 0x17008474 RID: 33908
		// (get) Token: 0x06037401 RID: 226305 RVA: 0x00D1B910 File Offset: 0x00D19B10
		public int CurrentWorldMapConfigId
		{
			get
			{
				InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				if (instanceDungeon == null || instanceDungeon.GetValueOrDefault().ViewMapId != 0)
				{
					return instanceDungeon.Value.ViewMapId;
				}
				int? dungeonLocateWorldMapId = this.GetDungeonLocateWorldMapId(instanceDungeon.Value.Id);
				if (dungeonLocateWorldMapId != null)
				{
					return dungeonLocateWorldMapId.GetValueOrDefault();
				}
				if (instanceDungeon == null)
				{
					return 0;
				}
				return instanceDungeon.GetValueOrDefault().MapConfigId;
			}
		}

		// Token: 0x17008475 RID: 33909
		// (get) Token: 0x06037402 RID: 226306 RVA: 0x00D1B99C File Offset: 0x00D19B9C
		public bool CurrentInWorld
		{
			get
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				return WorldMapConfig.Instance.IsDungeonInWorld(instanceId);
			}
		}

		// Token: 0x17008476 RID: 33910
		// (get) Token: 0x06037403 RID: 226307 RVA: 0x00D1B9C0 File Offset: 0x00D19BC0
		public EMapGravityDirection CurrentPlayerGravity
		{
			get
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
				bool? flag;
				if (characterActorComponent == null)
				{
					flag = null;
				}
				else
				{
					BaseMoveComponent moveComp = characterActorComponent.MoveComp;
					flag = ((moveComp != null) ? new bool?(moveComp.IsStandardGravity) : null);
				}
				bool? flag2 = flag;
				if (!flag2.GetValueOrDefault())
				{
					return EMapGravityDirection.Up;
				}
				return EMapGravityDirection.Down;
			}
		}

		// Token: 0x17008477 RID: 33911
		// (get) Token: 0x06037404 RID: 226308 RVA: 0x00D1BA18 File Offset: 0x00D19C18
		[Nullable(2)]
		public global::Vector CurrentPlayerGravityDirection
		{
			[NullableContext(2)]
			get
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
				if (characterActorComponent == null)
				{
					return null;
				}
				BaseMoveComponent moveComp = characterActorComponent.MoveComp;
				if (moveComp == null)
				{
					return null;
				}
				return moveComp.GravityDirect;
			}
		}

		// Token: 0x17008478 RID: 33912
		// (get) Token: 0x06037405 RID: 226309 RVA: 0x00D1BA41 File Offset: 0x00D19C41
		public bool IsPlayerInStandardGravity
		{
			get
			{
				return this.CurrentPlayerGravity == EMapGravityDirection.Down;
			}
		}

		// Token: 0x06037406 RID: 226310 RVA: 0x00D1BA4C File Offset: 0x00D19C4C
		public int GetInstanceIdByWorldMapId(int worldMapInstanceId)
		{
			if (worldMapInstanceId == this.CurrentWorldMapConfigId || !WorldMapConfig.Instance.IsMapInWorld(worldMapInstanceId))
			{
				return CreatureModel.Instance.GetInstanceId();
			}
			return worldMapInstanceId;
		}

		// Token: 0x06037407 RID: 226311 RVA: 0x00D1BA70 File Offset: 0x00D19C70
		public void AddTrackMarkId(int markId)
		{
			this.RemoteTrackingMarkSet.Add(markId);
		}

		// Token: 0x06037408 RID: 226312 RVA: 0x00D1BA7F File Offset: 0x00D19C7F
		public void RemoveTrackMarkId(int markId)
		{
			this.RemoteTrackingMarkSet.Remove(markId);
		}

		// Token: 0x06037409 RID: 226313 RVA: 0x00D1BA8E File Offset: 0x00D19C8E
		public void ClearTrackMarkId()
		{
			this.RemoteTrackingMarkSet.Clear();
		}

		// Token: 0x0603740A RID: 226314 RVA: 0x00D1BA9B File Offset: 0x00D19C9B
		public bool IsMarkTracking(int markId)
		{
			return this.RemoteTrackingMarkSet.Contains(markId);
		}

		// Token: 0x0603740B RID: 226315 RVA: 0x00D1BAAC File Offset: 0x00D19CAC
		public void UpdateMarkHideInfo(SystemMarkHideInfoPb hideInfo)
		{
			string markHideInfoKey = this.GetMarkHideInfoKey(hideInfo.MapId, hideInfo.EntityConfigId);
			if (string.IsNullOrEmpty(hideInfo.HideInfo))
			{
				this.SystemMarkHideInfoMap.Remove(markHideInfoKey);
			}
			else
			{
				this.SystemMarkHideInfoMap[markHideInfoKey] = hideInfo;
			}
			EventSystem.Instance.Emit(EEventName.OnMarkItemUpdateMarkHideInfo);
		}

		// Token: 0x0603740C RID: 226316 RVA: 0x00D1BB05 File Offset: 0x00D19D05
		public void ClearMarkHideInfo()
		{
			this.SystemMarkHideInfoMap.Clear();
		}

		// Token: 0x0603740D RID: 226317 RVA: 0x00D1BB14 File Offset: 0x00D19D14
		public string GetMarkHideInfoKey(int mapId, int entityId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603740E RID: 226318 RVA: 0x00D1BB50 File Offset: 0x00D19D50
		public bool IsMarkHideByServer(int mapId, int entityId)
		{
			string markHideInfoKey = this.GetMarkHideInfoKey(mapId, entityId);
			return this.SystemMarkHideInfoMap.ContainsKey(markHideInfoKey);
		}

		// Token: 0x0603740F RID: 226319 RVA: 0x00D1BB74 File Offset: 0x00D19D74
		[NullableContext(2)]
		public string GetMarkHideReason(int mapId, int entityId)
		{
			string markHideInfoKey = this.GetMarkHideInfoKey(mapId, entityId);
			SystemMarkHideInfoPb systemMarkHideInfoPb;
			if (this.SystemMarkHideInfoMap.TryGetValue(markHideInfoKey, out systemMarkHideInfoPb) && systemMarkHideInfoPb != null && systemMarkHideInfoPb.HideInfo != null)
			{
				return this.ParseHideReason(systemMarkHideInfoPb.HideInfo);
			}
			return null;
		}

		// Token: 0x06037410 RID: 226320 RVA: 0x00D1BBB4 File Offset: 0x00D19DB4
		[return: Nullable(2)]
		public string ParseHideReason(string hideInfo)
		{
			if (hideInfo.ToLower() == "d")
			{
				return TextConfig.Instance.GetMultiText("Mark_Occupied_Not_Refresh_Text", Array.Empty<string>());
			}
			string[] array = hideInfo.Split('_', StringSplitOptions.None);
			if (array.Length < 2)
			{
				return null;
			}
			string a = array[0].ToLower();
			int num = int.Parse(array[1]);
			if (a == "q")
			{
				string questName = QuestNewModel.Instance.GetQuestName(num);
				return TextConfig.Instance.GetMultiText("Mark_Quest_Occupied_Text", new string[]
				{
					questName
				});
			}
			if (a == "l")
			{
				global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(num);
				if (levelPlayInfo != null)
				{
					string multiText = TextConfig.Instance.GetMultiText(levelPlayInfo.NameKey, Array.Empty<string>());
					return TextConfig.Instance.GetMultiText("Mark_Play_Occupied_Text", new string[]
					{
						multiText
					});
				}
			}
			return null;
		}

		// Token: 0x06037411 RID: 226321 RVA: 0x00D1BC94 File Offset: 0x00D19E94
		public void InitTeleportMarkQueryCache()
		{
			foreach (MapMark mapMark in MapConfig.Instance.GetConfigMarkMap().Values)
			{
				if (mapMark.ObjectType == 15 || mapMark.ObjectType == 5 || mapMark.ObjectType == 6 || mapMark.ObjectType == 10 || mapMark.ObjectType == 19 || mapMark.EnableQuickTransfer == 1)
				{
					global::Vector vector = global::Vector.Create();
					MapUtil.GetConfigPosition(mapMark.EntityConfigId, vector, mapMark.RelativeDungeonId);
					MapTeleportQueryInfo item = new MapTeleportQueryInfo
					{
						MarkId = mapMark.MarkId,
						MarkType = (EMarkType)mapMark.ObjectType,
						MapId = mapMark.MapId,
						InstanceDungeonId = mapMark.RelativeDungeonId,
						Gravity = (EMapGravityDirection)mapMark.GravityFlip,
						MultiMapId = mapMark.MultiMapFloorId,
						ConnectMultiMapIds = (mapMark.GetConnetMultiMapFloorIdArray() ?? Array.Empty<int>()),
						WorldPosition = vector
					};
					int key = MapUtil.ConvertWorldPositionToIndex(vector);
					HashSet<MapTeleportQueryInfo> hashSet;
					if (!this.MarkQueryInfoInGrid.TryGetValue(key, out hashSet))
					{
						HashSet<MapTeleportQueryInfo> value = new HashSet<MapTeleportQueryInfo>
						{
							item
						};
						this.MarkQueryInfoInGrid[key] = value;
					}
					else
					{
						hashSet.Add(item);
					}
				}
			}
		}

		// Token: 0x06037412 RID: 226322 RVA: 0x00D1BE0C File Offset: 0x00D1A00C
		public QueryNearestTeleporterResult QueryNearestTeleporter(int targetMarkId, EMarkType targetMarkType, global::Vector playerPosition)
		{
			MapModel.<>c__DisplayClass180_0 CS$<>8__locals1 = new MapModel.<>c__DisplayClass180_0();
			CS$<>8__locals1.targetMarkId = targetMarkId;
			CS$<>8__locals1.<>4__this = this;
			MapModel.<>c__DisplayClass180_0 CS$<>8__locals2 = CS$<>8__locals1;
			DynamicMarkCreateInfo mark = this.GetMark(targetMarkType, CS$<>8__locals1.targetMarkId);
			int? num = (mark != null) ? mark.InstanceDungeonId : null;
			int targetDungeonId;
			if (num == null)
			{
				MapMark? configMark = MapConfig.Instance.GetConfigMark(CS$<>8__locals1.targetMarkId);
				targetDungeonId = ((configMark != null) ? configMark.GetValueOrDefault().RelativeDungeonId : 0);
			}
			else
			{
				targetDungeonId = num.GetValueOrDefault();
			}
			CS$<>8__locals2.targetDungeonId = targetDungeonId;
			MapModel.<>c__DisplayClass180_0 CS$<>8__locals3 = CS$<>8__locals1;
			DynamicMarkCreateInfo mark2 = this.GetMark(targetMarkType, CS$<>8__locals1.targetMarkId);
			EMapGravityDirection targetGravity;
			if (mark2 == null)
			{
				MapMark? configMark = MapConfig.Instance.GetConfigMark(CS$<>8__locals1.targetMarkId);
				if (configMark != null)
				{
					int gravityFlip = configMark.GetValueOrDefault().GravityFlip;
				}
				targetGravity = ((EMapGravityDirection?)null).GetValueOrDefault();
			}
			else
			{
				targetGravity = mark2.MapGravity;
			}
			CS$<>8__locals3.targetGravity = targetGravity;
			return this.QueryNearestTeleporterInternal(CS$<>8__locals1.targetMarkId, targetMarkType, playerPosition, delegate(MapTeleportQueryInfo queryInfo)
			{
				if (CS$<>8__locals1.targetMarkId == queryInfo.MarkId)
				{
					return false;
				}
				if (MapHelper.IsRecallContextMismatched(queryInfo.MarkId))
				{
					return false;
				}
				MapMark? configMark2 = MapConfig.Instance.GetConfigMark(queryInfo.MarkId);
				if (CS$<>8__locals1.targetDungeonId != queryInfo.InstanceDungeonId)
				{
					return false;
				}
				bool flag = CS$<>8__locals1.<>4__this.IsTeleportLocked(queryInfo.MarkId);
				bool flag2 = CS$<>8__locals1.<>4__this.IsMarkFogUnlock(queryInfo.MarkId);
				if (flag || !flag2)
				{
					return false;
				}
				if ((queryInfo.MarkType == EMarkType.SceneGameplay || queryInfo.MarkType == EMarkType.FixedSceneGameplay) && configMark2 != null)
				{
					global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(configMark2.Value.RelativeId);
					if (levelPlayInfo == null || levelPlayInfo.IsClose)
					{
						return false;
					}
					if (CS$<>8__locals1.<>4__this.IsLevelPlayOccupied(levelPlayInfo.Id).IsOccupied)
					{
						return false;
					}
				}
				return (queryInfo.MarkType == EMarkType.TemporaryTeleport || queryInfo.MarkType == EMarkType.BigTeleport || queryInfo.MarkType == EMarkType.SmallTeleport || queryInfo.MarkType == EMarkType.SceneGameplay || queryInfo.MarkType == EMarkType.FixedSceneGameplay) && (CS$<>8__locals1.targetGravity == EMapGravityDirection.All || queryInfo.Gravity == EMapGravityDirection.All || queryInfo.Gravity == CS$<>8__locals1.targetGravity);
			});
		}

		// Token: 0x06037413 RID: 226323 RVA: 0x00D1BF08 File Offset: 0x00D1A108
		private unsafe TTrackTarget GetMarkTrackTarget(int targetMarkId, EMarkType targetMarkType)
		{
			DynamicMarkCreateInfo mark = this.GetMark(targetMarkType, targetMarkId);
			TTrackTarget result = 0;
			if (mark == null)
			{
				MapMark? configMark = MapConfig.Instance.GetConfigMark(targetMarkId);
				if (configMark == null)
				{
					object key = targetMarkId;
					ELogAuthor author = ELogAuthor.LYX;
					string message = "查询标记追踪目标->目标的标记配置和数据都为空";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("trackTargetMarkId", targetMarkId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetMarkType", targetMarkType);
					MapLogger.ErrorOnce(key, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return result;
				}
				result = ((configMark.Value.EntityConfigId > 0) ? new TTrackTarget_Int(configMark.Value.EntityConfigId) : new TTrackTarget_Vector(global::Vector.Create(configMark.Value.MarkVector)));
			}
			else
			{
				result = mark.TrackTarget;
			}
			return result;
		}

		// Token: 0x06037414 RID: 226324 RVA: 0x00D1BFF0 File Offset: 0x00D1A1F0
		private QueryNearestTeleporterResult QueryNearestTeleporterInternal(int targetMarkId, EMarkType targetMarkType, global::Vector playerPosition, [Nullable(new byte[]
		{
			2,
			1
		})] Func<MapTeleportQueryInfo, bool> filterFunction = null)
		{
			TTrackTarget markTrackTarget = this.GetMarkTrackTarget(targetMarkId, targetMarkType);
			if (markTrackTarget as TTrackTarget_Int == 0)
			{
				return new QueryNearestTeleporterResult
				{
					TargetMarkId = targetMarkId,
					TargetMarkType = targetMarkType,
					FailedReason = new EQueryNearestTeleporterFailedReason?(EQueryNearestTeleporterFailedReason.NotFound)
				};
			}
			int markMapConfigId = this.GetMarkMapConfigId(targetMarkId, targetMarkType);
			global::Vector trackPositionByTrackTargetConfig = MapUtil.GetTrackPositionByTrackTargetConfig(markTrackTarget, markMapConfigId, null);
			List<ValueTuple<MapTeleportQueryInfo, double>> list = this.MarkQueryInfoCache.Get(targetMarkId);
			if (list == null)
			{
				list = new List<ValueTuple<MapTeleportQueryInfo, double>>();
				int num = ConfigCommonParamById.GetIntConfig("QuickTransferRange").Value * 100;
				HashSet<int> queryNearestIndexSet = MapUtil.GetQueryNearestIndexSet(trackPositionByTrackTargetConfig, (float)num);
				float num2 = (float)(num * num);
				foreach (int key in queryNearestIndexSet)
				{
					HashSet<MapTeleportQueryInfo> hashSet;
					if (this.MarkQueryInfoInGrid.TryGetValue(key, out hashSet))
					{
						foreach (MapTeleportQueryInfo mapTeleportQueryInfo in hashSet)
						{
							double num3 = global::Vector.DistSquared(mapTeleportQueryInfo.WorldPosition, trackPositionByTrackTargetConfig);
							if (num3 <= (double)num2)
							{
								list.Add(new ValueTuple<MapTeleportQueryInfo, double>(mapTeleportQueryInfo, num3));
							}
						}
					}
				}
				this.MarkQueryInfoCache.Put(targetMarkId, list, 1);
				MapMark? configMark = MapConfig.Instance.GetConfigMark(targetMarkId);
				int targetMultiMapId = (configMark != null) ? MapModel.GetEffectiveMultiMapId(configMark.Value.MultiMapFloorId, configMark.Value.GetConnetMultiMapFloorIdArray() ?? Array.Empty<int>()) : 0;
				bool isLayered = targetMultiMapId != 0;
				float num4 = (float)(ConfigCommonParamById.GetIntConfig("SameLayerQuickTransferRange").GetValueOrDefault() * 100);
				double sameLayerRangeSquared = (double)(num4 * num4);
				list.Sort(delegate([Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MapTeleportQueryInfo, double> a, [Nullable(new byte[]
				{
					0,
					1
				})] ValueTuple<MapTeleportQueryInfo, double> b)
				{
					if (isLayered)
					{
						int num7 = (a.Item2 <= sameLayerRangeSquared && MapModel.GetEffectiveMultiMapId(a.Item1.MultiMapId, a.Item1.ConnectMultiMapIds) == targetMultiMapId) ? 0 : 1;
						int num8 = (b.Item2 <= sameLayerRangeSquared && MapModel.GetEffectiveMultiMapId(b.Item1.MultiMapId, b.Item1.ConnectMultiMapIds) == targetMultiMapId) ? 0 : 1;
						if (num7 != num8)
						{
							return num7 - num8;
						}
					}
					return a.Item2.CompareTo(b.Item2);
				});
			}
			foreach (ValueTuple<MapTeleportQueryInfo, double> valueTuple in list)
			{
				MapTeleportQueryInfo item = valueTuple.Item1;
				if (filterFunction == null || filterFunction(item))
				{
					double num5 = global::Vector.DistSquared(playerPosition, trackPositionByTrackTargetConfig);
					double num6 = global::Vector.DistSquared(item.WorldPosition, trackPositionByTrackTargetConfig);
					if (num5 <= num6)
					{
						return new QueryNearestTeleporterResult
						{
							TargetMarkId = targetMarkId,
							TargetMarkType = targetMarkType,
							FailedReason = new EQueryNearestTeleporterFailedReason?(EQueryNearestTeleporterFailedReason.PlayerCloserToTarget)
						};
					}
					return new QueryNearestTeleporterResult
					{
						TargetMarkId = targetMarkId,
						TargetMarkType = targetMarkType,
						Info = item
					};
				}
			}
			return new QueryNearestTeleporterResult
			{
				TargetMarkId = targetMarkId,
				TargetMarkType = targetMarkType,
				FailedReason = new EQueryNearestTeleporterFailedReason?(EQueryNearestTeleporterFailedReason.NotFound)
			};
		}

		// Token: 0x06037415 RID: 226325 RVA: 0x00D1C2B0 File Offset: 0x00D1A4B0
		private static int GetEffectiveMultiMapId(int multiMapId, int[] connectMultiMapIds)
		{
			if (multiMapId == 0 && connectMultiMapIds.Length != 0)
			{
				return connectMultiMapIds[0];
			}
			return multiMapId;
		}

		// Token: 0x06037416 RID: 226326 RVA: 0x00D1C2C0 File Offset: 0x00D1A4C0
		public EMarkType? GetEntityIdToMarkType(int entityId)
		{
			Dictionary<int, EMarkType> entityIdToMarkType = this.EntityIdToMarkType;
			if (entityIdToMarkType == null)
			{
				return null;
			}
			return new EMarkType?(entityIdToMarkType.GetValueOrDefault(entityId));
		}

		// Token: 0x06037417 RID: 226327 RVA: 0x00D1C2EC File Offset: 0x00D1A4EC
		public void AddEntityIdToMarkType(int entityId, EMarkType markType)
		{
			this.EntityIdToMarkType[entityId] = markType;
		}

		// Token: 0x06037418 RID: 226328 RVA: 0x00D1C2FB File Offset: 0x00D1A4FB
		public void RemoveEntityIdToMarkType(int entityId)
		{
			Dictionary<int, EMarkType> entityIdToMarkType = this.EntityIdToMarkType;
			if (entityIdToMarkType == null)
			{
				return;
			}
			entityIdToMarkType.Remove(entityId);
		}

		// Token: 0x06037419 RID: 226329 RVA: 0x00D1C30F File Offset: 0x00D1A50F
		public void UpdateHonamiScanMarkInfo(int markId, MarkState state)
		{
			this.HonamiScanMarkInfo[markId] = state;
			EventSystem.Instance.Emit<int>(EEventName.OnHonamiScanMarkInfoUpdate, markId);
		}

		// Token: 0x0603741A RID: 226330 RVA: 0x00D1C32F File Offset: 0x00D1A52F
		public MarkState GetHonamiScanMarkInfo(int markId)
		{
			return this.HonamiScanMarkInfo.GetValueOrDefault(markId, MarkState.MarkDisable);
		}

		// Token: 0x0603741B RID: 226331 RVA: 0x00D1C33E File Offset: 0x00D1A53E
		public void ClearHonamiScanMarkInfo()
		{
			this.HonamiScanMarkInfo.Clear();
		}

		// Token: 0x0603741C RID: 226332 RVA: 0x00D1C34B File Offset: 0x00D1A54B
		public void InitExtraUiMarkType(EMapType mapType)
		{
			if (this.ExtraMarkTypeMap != null)
			{
				this.ExtraMarkTypeMap[mapType] = new HashSet<EMarkType>();
			}
		}

		// Token: 0x0603741D RID: 226333 RVA: 0x00D1C366 File Offset: 0x00D1A566
		public void AddExtraUiMarkType(EMapType mapType, EMarkType markType)
		{
			if (this.ExtraMarkTypeMap != null && !this.ExtraMarkTypeMap.ContainsKey(mapType))
			{
				this.InitExtraUiMarkType(mapType);
			}
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			if (extraMarkTypeMap == null)
			{
				return;
			}
			HashSet<EMarkType> valueOrDefault = extraMarkTypeMap.GetValueOrDefault(mapType);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.Add(markType);
		}

		// Token: 0x0603741E RID: 226334 RVA: 0x00D1C3A2 File Offset: 0x00D1A5A2
		public bool HasExtraUiMarkType(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			return ((extraMarkTypeMap != null) ? extraMarkTypeMap.GetValueOrDefault(mapType) : null) != null;
		}

		// Token: 0x0603741F RID: 226335 RVA: 0x00D1C3BC File Offset: 0x00D1A5BC
		public bool IsExtraUiMarkType(EMapType mapType, EMarkType markType)
		{
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			bool? flag;
			if (extraMarkTypeMap == null)
			{
				flag = null;
			}
			else
			{
				HashSet<EMarkType> valueOrDefault = extraMarkTypeMap.GetValueOrDefault(mapType);
				flag = ((valueOrDefault != null) ? new bool?(valueOrDefault.Contains(markType)) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x06037420 RID: 226336 RVA: 0x00D1C406 File Offset: 0x00D1A606
		public void ClearExtraUiMarkType(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			if (extraMarkTypeMap == null)
			{
				return;
			}
			extraMarkTypeMap.Remove(mapType);
		}

		// Token: 0x06037421 RID: 226337 RVA: 0x00D1C41A File Offset: 0x00D1A61A
		public void InitExtraUiMarkId(EMapType mapType)
		{
			if (this.ExtraMarkIdMap != null)
			{
				this.ExtraMarkIdMap[mapType] = new HashSet<int>();
			}
		}

		// Token: 0x06037422 RID: 226338 RVA: 0x00D1C435 File Offset: 0x00D1A635
		public void AddExtraUiMarkId(EMapType mapType, int markId)
		{
			if (this.ExtraMarkIdMap != null && !this.ExtraMarkIdMap.ContainsKey(mapType))
			{
				this.InitExtraUiMarkId(mapType);
			}
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			if (extraMarkIdMap == null)
			{
				return;
			}
			HashSet<int> valueOrDefault = extraMarkIdMap.GetValueOrDefault(mapType);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.Add(markId);
		}

		// Token: 0x06037423 RID: 226339 RVA: 0x00D1C471 File Offset: 0x00D1A671
		public bool HasExtraUiMarkId(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			return ((extraMarkIdMap != null) ? extraMarkIdMap.GetValueOrDefault(mapType) : null) != null;
		}

		// Token: 0x06037424 RID: 226340 RVA: 0x00D1C48C File Offset: 0x00D1A68C
		public bool IsExtraUiMarkId(EMapType mapType, int markId)
		{
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			bool? flag;
			if (extraMarkIdMap == null)
			{
				flag = null;
			}
			else
			{
				HashSet<int> valueOrDefault = extraMarkIdMap.GetValueOrDefault(mapType);
				flag = ((valueOrDefault != null) ? new bool?(valueOrDefault.Contains(markId)) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x06037425 RID: 226341 RVA: 0x00D1C4D6 File Offset: 0x00D1A6D6
		public void ClearExtraUiMarkId(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			if (extraMarkIdMap == null)
			{
				return;
			}
			extraMarkIdMap.Remove(mapType);
		}

		// Token: 0x06037426 RID: 226342 RVA: 0x00D1C4EA File Offset: 0x00D1A6EA
		public void SetExtraUiTileRange(EMapType mapType, ITileNum tileRange)
		{
			if (this.ExtraUiTileRange != null)
			{
				this.ExtraUiTileRange[mapType] = tileRange;
			}
		}

		// Token: 0x06037427 RID: 226343 RVA: 0x00D1C501 File Offset: 0x00D1A701
		public void ClearExtraUiTileRange(EMapType mapType)
		{
			Dictionary<EMapType, ITileNum> extraUiTileRange = this.ExtraUiTileRange;
			if (extraUiTileRange == null)
			{
				return;
			}
			extraUiTileRange.Remove(mapType);
		}

		// Token: 0x06037428 RID: 226344 RVA: 0x00D1C515 File Offset: 0x00D1A715
		public bool HasExtraUiTileRange(EMapType mapType)
		{
			Dictionary<EMapType, ITileNum> extraUiTileRange = this.ExtraUiTileRange;
			return extraUiTileRange != null && extraUiTileRange.ContainsKey(mapType);
		}

		// Token: 0x06037429 RID: 226345 RVA: 0x00D1C52C File Offset: 0x00D1A72C
		public bool IsInExtraUiTileRange(EMapType mapType, global::Vector uiPosition)
		{
			ITileNum tileNum;
			if (this.ExtraUiTileRange == null || !this.ExtraUiTileRange.TryGetValue(mapType, out tileNum))
			{
				return true;
			}
			int num = (int)Math.Ceiling(uiPosition.X / 850.0);
			int num2 = (int)Math.Ceiling(uiPosition.Y / 850.0);
			return num >= tileNum.MinX && num <= tileNum.MaxX && num2 >= tileNum.MinY && num2 <= tileNum.MaxY;
		}

		// Token: 0x17008479 RID: 33913
		// (get) Token: 0x0603742A RID: 226346 RVA: 0x00D1C5AA File Offset: 0x00D1A7AA
		public static MapModel Instance
		{
			get
			{
				return MapModel._Instance;
			}
		}

		// Token: 0x0603742B RID: 226347 RVA: 0x00D1C5B1 File Offset: 0x00D1A7B1
		public static MapModel GetOrCreateInstance()
		{
			if (MapModel._Instance == null)
			{
				MapModel.CreateInstance();
			}
			return MapModel._Instance;
		}

		// Token: 0x0603742C RID: 226348 RVA: 0x00D1C5C5 File Offset: 0x00D1A7C5
		public static bool CreateInstance()
		{
			if (MapModel._Instance != null)
			{
				return true;
			}
			MapModel._Instance = new MapModel();
			return true;
		}

		// Token: 0x0603742D RID: 226349 RVA: 0x00D1C5DB File Offset: 0x00D1A7DB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603742E RID: 226350 RVA: 0x00D1C5DD File Offset: 0x00D1A7DD
		public static void ResetStaticDefaultValue()
		{
			MapModel._Instance = null;
		}

		// Token: 0x0603742F RID: 226351 RVA: 0x00D1C5E5 File Offset: 0x00D1A7E5
		static MapModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapModel.CreateStaticDefaultValue), new Action(MapModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D1DB RID: 119259
		private int DynamicMarkId;

		// Token: 0x0401D1DC RID: 119260
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> DynamicMarks;

		// Token: 0x0401D1DD RID: 119261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, Dictionary<int, bool>> MarkVisibleStateRecord;

		// Token: 0x0401D1DE RID: 119262
		[Nullable(2)]
		private Dictionary<int, long> SceneGamePlayRefQuestMap;

		// Token: 0x0401D1DF RID: 119263
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, int[]> OccupationResourceRefPlayMap;

		// Token: 0x0401D1E0 RID: 119264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, DynamicMarkCreateInfo> DynamicMarksSearchMap;

		// Token: 0x0401D1E1 RID: 119265
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedTeleports;

		// Token: 0x0401D1E2 RID: 119266
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedFogs;

		// Token: 0x0401D1E3 RID: 119267
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedAreas;

		// Token: 0x0401D1E4 RID: 119268
		[Nullable(2)]
		private TrackMapMarkParams CurTrackParams;

		// Token: 0x0401D1E5 RID: 119269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IMarkShowState> MarkExtraShowStateReference;

		// Token: 0x0401D1E6 RID: 119270
		private HashSet<int> CompleteMarks = new HashSet<int>();

		// Token: 0x0401D1E7 RID: 119271
		[Nullable(2)]
		private Dictionary<int, int> PendingAddEntityList;

		// Token: 0x0401D1E8 RID: 119272
		[Nullable(2)]
		private HashSet<int> PendingAddTempMapMarkList;

		// Token: 0x0401D1E9 RID: 119273
		[Nullable(2)]
		private Dictionary<int, bool> ServerUnlockedMarksMap;

		// Token: 0x0401D1EA RID: 119274
		private List<int> UnlockMultiMapIds = new List<int>();

		// Token: 0x0401D1EB RID: 119275
		public List<int> UnlockMapBlockIds = new List<int>();

		// Token: 0x0401D1EC RID: 119276
		public readonly global::Vector LastSafeLocation = global::Vector.Create();

		// Token: 0x0401D1ED RID: 119277
		[Nullable(2)]
		public Circle CacheEnrichmentAreaWorldMapCircle;

		// Token: 0x0401D1EE RID: 119278
		public int CacheEnrichmentAreaEntityId;

		// Token: 0x0401D1EF RID: 119279
		public Dictionary<int, MarkState> HonamiScanMarkInfo = new Dictionary<int, MarkState>();

		// Token: 0x0401D1F0 RID: 119280
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, TreasureBoxSlotInfo> TreasureBoxSlotRawDataMap;

		// Token: 0x0401D1F1 RID: 119281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, TemporaryTeleportInfo> TemporaryTeleportInfoRawDataMap;

		// Token: 0x0401D1F2 RID: 119282
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>, TreasureChestCountData> TreasureChestCountMap = new Dictionary<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>, TreasureChestCountData>();

		// Token: 0x0401D1F3 RID: 119283
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<EMapLifeEventListenerType, IMapLifeEventTriggerParam> MapLifeEventListenerTriggerMap;

		// Token: 0x0401D1F4 RID: 119284
		private readonly List<MarkDefine.FishingShipMarkCacheInfo> CacheEntityMapMarkInfo = new List<MarkDefine.FishingShipMarkCacheInfo>();

		// Token: 0x0401D1F5 RID: 119285
		private readonly HashSet<int> RemoteTrackingMarkSet = new HashSet<int>();

		// Token: 0x0401D1F6 RID: 119286
		private Dictionary<string, SystemMarkHideInfoPb> SystemMarkHideInfoMap = new Dictionary<string, SystemMarkHideInfoPb>();

		// Token: 0x0401D1F7 RID: 119287
		[Nullable(2)]
		private Dictionary<int, EMarkType> EntityIdToMarkType;

		// Token: 0x0401D1F8 RID: 119288
		public int? LastHighLevelAreaInner;

		// Token: 0x0401D1F9 RID: 119289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, HashSet<EMarkType>> ExtraMarkTypeMap;

		// Token: 0x0401D1FA RID: 119290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, HashSet<int>> ExtraMarkIdMap;

		// Token: 0x0401D1FB RID: 119291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, ITileNum> ExtraUiTileRange;

		// Token: 0x0401D1FC RID: 119292
		private readonly Dictionary<int, HashSet<MapTeleportQueryInfo>> MarkQueryInfoInGrid = new Dictionary<int, HashSet<MapTeleportQueryInfo>>();

		// Token: 0x0401D1FD RID: 119293
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		private readonly TrimLru<int, List<ValueTuple<MapTeleportQueryInfo, double>>> MarkQueryInfoCache = new TrimLru<int, List<ValueTuple<MapTeleportQueryInfo, double>>>(3, false);

		// Token: 0x0401D1FE RID: 119294
		[Nullable(2)]
		private static MapModel _Instance;
	}
}
