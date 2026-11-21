using System;
using System.Collections.Generic;
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
	// Token: 0x0200446A RID: 17514
	[NullableContext(1)]
	[Nullable(0)]
	public class MapModel : ModelBase
	{
		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x0602C2D1 RID: 180945 RVA: 0x00C679F1 File Offset: 0x00C65BF1
		// (set) Token: 0x0602C2D2 RID: 180946 RVA: 0x00C679F9 File Offset: 0x00C65BF9
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

		// Token: 0x0602C2D3 RID: 180947 RVA: 0x00C67A04 File Offset: 0x00C65C04
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

		// Token: 0x0602C2D4 RID: 180948 RVA: 0x00C67AFF File Offset: 0x00C65CFF
		protected override bool OnChangeMode()
		{
			TrackModel.Instance.ClearTrackData();
			this.SetCurTrackMark(null);
			return true;
		}

		// Token: 0x0602C2D5 RID: 180949 RVA: 0x00C67B14 File Offset: 0x00C65D14
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

		// Token: 0x0602C2D6 RID: 180950 RVA: 0x00C67C69 File Offset: 0x00C65E69
		[NullableContext(2)]
		public Dictionary<int, bool> GetUnlockedTeleportMap()
		{
			return this.UnlockedTeleports;
		}

		// Token: 0x0602C2D7 RID: 180951 RVA: 0x00C67C71 File Offset: 0x00C65E71
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

		// Token: 0x0602C2D8 RID: 180952 RVA: 0x00C67C88 File Offset: 0x00C65E88
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

		// Token: 0x0602C2D9 RID: 180953 RVA: 0x00C67CB9 File Offset: 0x00C65EB9
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, DynamicMarkCreateInfo> GetMarkByType(EMarkType markType)
		{
			return this.DynamicMarks.GetValueOrDefault(markType);
		}

		// Token: 0x0602C2DA RID: 180954 RVA: 0x00C67CC8 File Offset: 0x00C65EC8
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

		// Token: 0x0602C2DB RID: 180955 RVA: 0x00C67D14 File Offset: 0x00C65F14
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

		// Token: 0x0602C2DC RID: 180956 RVA: 0x00C67D98 File Offset: 0x00C65F98
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

		// Token: 0x0602C2DD RID: 180957 RVA: 0x00C67E40 File Offset: 0x00C66040
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

		// Token: 0x0602C2DE RID: 180958 RVA: 0x00C67E48 File Offset: 0x00C66048
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

		// Token: 0x0602C2DF RID: 180959 RVA: 0x00C67EB4 File Offset: 0x00C660B4
		[NullableContext(2)]
		public void SetCurTrackMark(TrackMapMarkParams trackMark)
		{
			this.CurTrackParams = trackMark;
		}

		// Token: 0x0602C2E0 RID: 180960 RVA: 0x00C67EC0 File Offset: 0x00C660C0
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

		// Token: 0x0602C2E1 RID: 180961 RVA: 0x00C67FF1 File Offset: 0x00C661F1
		[NullableContext(2)]
		public TrackMapMarkParams GetCurTrackMark()
		{
			return this.CurTrackParams;
		}

		// Token: 0x0602C2E2 RID: 180962 RVA: 0x00C67FF9 File Offset: 0x00C661F9
		public void CreateServerSaveMark(DynamicMarkCreateInfo info)
		{
			this.CreateDynamicMark(info);
		}

		// Token: 0x0602C2E3 RID: 180963 RVA: 0x00C68004 File Offset: 0x00C66204
		public int CreateDyMarkByEntity(int entityId, EMarkType markType, int configId, int mapId)
		{
			Dictionary<int, DynamicMarkCreateInfo> valueOrDefault = this.DynamicMarks.GetValueOrDefault(markType);
			if (valueOrDefault != null)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo = null;
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo2 in valueOrDefault.Values)
				{
					if ((TTrackTarget_Int)dynamicMarkCreateInfo2.TrackTarget == entityId)
					{
						dynamicMarkCreateInfo = dynamicMarkCreateInfo2;
						break;
					}
				}
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

		// Token: 0x0602C2E4 RID: 180964 RVA: 0x00C680EC File Offset: 0x00C662EC
		public void CreateTempMapMark(int mapMarkId)
		{
			this.AddPendingTempMapMarkList(mapMarkId);
			EventSystem.Instance.Emit<int>(EEventName.CreateTempMapMark, mapMarkId);
		}

		// Token: 0x0602C2E5 RID: 180965 RVA: 0x00C68106 File Offset: 0x00C66306
		public HashSet<int> GetPendingAddTempMapMarkList()
		{
			return this.PendingAddTempMapMarkList;
		}

		// Token: 0x0602C2E6 RID: 180966 RVA: 0x00C6810E File Offset: 0x00C6630E
		public void ClearPendingAddTempMapMarkList()
		{
			HashSet<int> pendingAddTempMapMarkList = this.PendingAddTempMapMarkList;
			if (pendingAddTempMapMarkList == null)
			{
				return;
			}
			pendingAddTempMapMarkList.Clear();
		}

		// Token: 0x0602C2E7 RID: 180967 RVA: 0x00C68120 File Offset: 0x00C66320
		public void AddPendingTempMapMarkList(int mapMarkId)
		{
			HashSet<int> pendingAddTempMapMarkList = this.PendingAddTempMapMarkList;
			if (pendingAddTempMapMarkList == null)
			{
				return;
			}
			pendingAddTempMapMarkList.Add(mapMarkId);
		}

		// Token: 0x0602C2E8 RID: 180968 RVA: 0x00C68134 File Offset: 0x00C66334
		public int CreateMapMark(DynamicMarkCreateInfo info)
		{
			info.MarkId = new int?(this.SpawnDynamicMarkId());
			this.CreateDynamicMark(info);
			return info.MarkId.Value;
		}

		// Token: 0x0602C2E9 RID: 180969 RVA: 0x00C68168 File Offset: 0x00C66368
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

		// Token: 0x0602C2EA RID: 180970 RVA: 0x00C68240 File Offset: 0x00C66440
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

		// Token: 0x0602C2EB RID: 180971 RVA: 0x00C6831C File Offset: 0x00C6651C
		public void RemoveFishingShipMarkAndCache()
		{
			this.CacheEntityMapMarkInfo.Clear();
			this.RemoveMapMarkByType(EMarkType.FishingShip);
		}

		// Token: 0x0602C2EC RID: 180972 RVA: 0x00C68334 File Offset: 0x00C66534
		public void SyncLocalShipLocationToCacheInfo()
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.FishingShip);
			if (markByType != null)
			{
				foreach (DynamicMarkCreateInfo dynamicMarkCreateInfo in markByType.Values)
				{
					List<MarkDefine.FishingShipMarkCacheInfo> list = new List<MarkDefine.FishingShipMarkCacheInfo>();
					foreach (MarkDefine.FishingShipMarkCacheInfo fishingShipMarkCacheInfo in this.CacheEntityMapMarkInfo)
					{
						int templateId = fishingShipMarkCacheInfo.TemplateId;
						int? num = dynamicMarkCreateInfo.EntityConfigId;
						if (templateId == num.GetValueOrDefault() & num != null)
						{
							int instanceId = fishingShipMarkCacheInfo.InstanceId;
							num = dynamicMarkCreateInfo.InstanceDungeonId;
							if (instanceId == num.GetValueOrDefault() & num != null)
							{
								list.Add(fishingShipMarkCacheInfo);
							}
						}
					}
					global::Vector trackPositionByTrackTargetConfig = MapUtil.GetTrackPositionByTrackTargetConfig(dynamicMarkCreateInfo.TrackTarget, dynamicMarkCreateInfo.MapId, null);
					if (list.Count > 0)
					{
						using (List<MarkDefine.FishingShipMarkCacheInfo>.Enumerator enumerator2 = list.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								MarkDefine.FishingShipMarkCacheInfo fishingShipMarkCacheInfo2 = enumerator2.Current;
								fishingShipMarkCacheInfo2.PositionX = trackPositionByTrackTargetConfig.X;
								fishingShipMarkCacheInfo2.PositionY = trackPositionByTrackTargetConfig.Y;
								fishingShipMarkCacheInfo2.PositionZ = trackPositionByTrackTargetConfig.Z;
							}
							continue;
						}
					}
					this.CacheEntityMapMarkInfo.Add(new MarkDefine.FishingShipMarkCacheInfo
					{
						InstanceId = dynamicMarkCreateInfo.InstanceDungeonId.GetValueOrDefault(),
						TemplateId = dynamicMarkCreateInfo.EntityConfigId.GetValueOrDefault(),
						PositionX = trackPositionByTrackTargetConfig.X,
						PositionY = trackPositionByTrackTargetConfig.Y,
						PositionZ = trackPositionByTrackTargetConfig.Z
					});
				}
			}
		}

		// Token: 0x0602C2ED RID: 180973 RVA: 0x00C68524 File Offset: 0x00C66724
		private bool IsNeedCheckSamePosition(DynamicMarkCreateInfo markInfo)
		{
			return markInfo.MarkType != EMarkType.Quest && markInfo.MarkType != EMarkType.TemporaryTeleport && markInfo.MarkType != EMarkType.TreasureBoxDetector && markInfo.MarkType != EMarkType.Custom;
		}

		// Token: 0x0602C2EE RID: 180974 RVA: 0x00C68554 File Offset: 0x00C66754
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

		// Token: 0x0602C2EF RID: 180975 RVA: 0x00C685E8 File Offset: 0x00C667E8
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

		// Token: 0x0602C2F0 RID: 180976 RVA: 0x00C68660 File Offset: 0x00C66860
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

		// Token: 0x0602C2F1 RID: 180977 RVA: 0x00C6871C File Offset: 0x00C6691C
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

		// Token: 0x0602C2F2 RID: 180978 RVA: 0x00C68780 File Offset: 0x00C66980
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

		// Token: 0x0602C2F3 RID: 180979 RVA: 0x00C68910 File Offset: 0x00C66B10
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

		// Token: 0x0602C2F4 RID: 180980 RVA: 0x00C68978 File Offset: 0x00C66B78
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

		// Token: 0x0602C2F5 RID: 180981 RVA: 0x00C68A1C File Offset: 0x00C66C1C
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

		// Token: 0x0602C2F6 RID: 180982 RVA: 0x00C68ABC File Offset: 0x00C66CBC
		[NullableContext(0)]
		public ValueTuple<int, EMarkType>? GetSoundBoxDetectMark()
		{
			Dictionary<int, DynamicMarkCreateInfo> markByType = this.GetMarkByType(EMarkType.SoundBox);
			if (markByType != null && markByType.Count > 0)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo = null;
				using (Dictionary<int, DynamicMarkCreateInfo>.ValueCollection.Enumerator enumerator = markByType.Values.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						dynamicMarkCreateInfo = enumerator.Current;
					}
				}
				return new ValueTuple<int, EMarkType>?(new ValueTuple<int, EMarkType>(dynamicMarkCreateInfo.MarkId.Value, dynamicMarkCreateInfo.MarkType));
			}
			Dictionary<int, DynamicMarkCreateInfo> markByType2 = this.GetMarkByType(EMarkType.CalmingWindBell);
			if (markByType2 != null && markByType2.Count > 0)
			{
				DynamicMarkCreateInfo dynamicMarkCreateInfo2 = null;
				using (Dictionary<int, DynamicMarkCreateInfo>.ValueCollection.Enumerator enumerator = markByType2.Values.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						dynamicMarkCreateInfo2 = enumerator.Current;
					}
				}
				return new ValueTuple<int, EMarkType>?(new ValueTuple<int, EMarkType>(dynamicMarkCreateInfo2.MarkId.Value, dynamicMarkCreateInfo2.MarkType));
			}
			return null;
		}

		// Token: 0x0602C2F7 RID: 180983 RVA: 0x00C68BC4 File Offset: 0x00C66DC4
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

		// Token: 0x0602C2F8 RID: 180984 RVA: 0x00C68D78 File Offset: 0x00C66F78
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

		// Token: 0x0602C2F9 RID: 180985 RVA: 0x00C68DD4 File Offset: 0x00C66FD4
		private bool IsFogUnlock(MapMark markConfig)
		{
			return markConfig.FogShow == 1 || this.CheckFogUnlocked(markConfig.FogHide, null);
		}

		// Token: 0x0602C2FA RID: 180986 RVA: 0x00C68E04 File Offset: 0x00C67004
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

		// Token: 0x0602C2FB RID: 180987 RVA: 0x00C68E44 File Offset: 0x00C67044
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

		// Token: 0x0602C2FC RID: 180988 RVA: 0x00C68F30 File Offset: 0x00C67130
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

		// Token: 0x0602C2FD RID: 180989 RVA: 0x00C69010 File Offset: 0x00C67210
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

		// Token: 0x0602C2FE RID: 180990 RVA: 0x00C69108 File Offset: 0x00C67308
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

		// Token: 0x0602C2FF RID: 180991 RVA: 0x00C691A0 File Offset: 0x00C673A0
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

		// Token: 0x0602C300 RID: 180992 RVA: 0x00C691FC File Offset: 0x00C673FC
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

		// Token: 0x0602C301 RID: 180993 RVA: 0x00C6924C File Offset: 0x00C6744C
		public int SpawnDynamicMarkId()
		{
			int num = this.DynamicMarkId - 1;
			this.DynamicMarkId = num;
			return num;
		}

		// Token: 0x0602C302 RID: 180994 RVA: 0x00C6926C File Offset: 0x00C6746C
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

		// Token: 0x0602C303 RID: 180995 RVA: 0x00C69358 File Offset: 0x00C67558
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

		// Token: 0x0602C304 RID: 180996 RVA: 0x00C693D0 File Offset: 0x00C675D0
		public bool IsTeleportLocked(int markId)
		{
			return this.GetMarkExtraShowState(markId).ShowFlag == MapMarkShowFlag.ShowDisable || !this.CheckTeleportUnlocked(markId);
		}

		// Token: 0x0602C305 RID: 180997 RVA: 0x00C693EF File Offset: 0x00C675EF
		public bool IsMarkDisable(int markId, bool isGamePlayHide)
		{
			return markId == 0 || this.GetMarkExtraShowState(markId).ShowFlag == MapMarkShowFlag.ShowDisable || isGamePlayHide;
		}

		// Token: 0x0602C306 RID: 180998 RVA: 0x00C69408 File Offset: 0x00C67608
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

		// Token: 0x0602C307 RID: 180999 RVA: 0x00C694DE File Offset: 0x00C676DE
		[NullableContext(2)]
		public Dictionary<int, bool> GetAllUnlockedFogs()
		{
			return this.UnlockedFogs;
		}

		// Token: 0x0602C308 RID: 181000 RVA: 0x00C694E6 File Offset: 0x00C676E6
		public bool GetFogIsUnlocked(int fogId)
		{
			Dictionary<int, bool> unlockedFogs = this.UnlockedFogs;
			return unlockedFogs != null && unlockedFogs.GetValueOrDefault(fogId);
		}

		// Token: 0x0602C309 RID: 181001 RVA: 0x00C694FA File Offset: 0x00C676FA
		[NullableContext(2)]
		public Dictionary<int, bool> GetAllUnlockedAreas()
		{
			return this.UnlockedAreas;
		}

		// Token: 0x0602C30A RID: 181002 RVA: 0x00C69502 File Offset: 0x00C67702
		public void AddUnlockedFogs(int fogId)
		{
			this.UnlockedFogs[fogId] = true;
			this.AddUnlockedAreaByFog(fogId);
			HonamiStoryModel.Instance.CurrentUnlockFogId = fogId;
			EventSystem.Instance.Emit<int>(EEventName.MapOpenFogChange, fogId);
		}

		// Token: 0x0602C30B RID: 181003 RVA: 0x00C69534 File Offset: 0x00C67734
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

		// Token: 0x0602C30C RID: 181004 RVA: 0x00C695B8 File Offset: 0x00C677B8
		private void AddUnlockedAreaByFog(int fogId)
		{
			MapFog? mapFogConfig = WorldMapConfig.Instance.GetMapFogConfig(fogId);
			if (mapFogConfig != null)
			{
				this.UnlockedAreas[mapFogConfig.Value.AreaId] = true;
			}
		}

		// Token: 0x0602C30D RID: 181005 RVA: 0x00C695F5 File Offset: 0x00C677F5
		public bool CheckAreasUnlocked(int areaId, bool zeroAsUnlock = true)
		{
			if (areaId == 0 && zeroAsUnlock)
			{
				return true;
			}
			Dictionary<int, bool> unlockedAreas = this.UnlockedAreas;
			return unlockedAreas != null && unlockedAreas.GetValueOrDefault(areaId);
		}

		// Token: 0x0602C30E RID: 181006 RVA: 0x00C69614 File Offset: 0x00C67814
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

		// Token: 0x0602C30F RID: 181007 RVA: 0x00C69684 File Offset: 0x00C67884
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

		// Token: 0x0602C310 RID: 181008 RVA: 0x00C696D5 File Offset: 0x00C678D5
		public void SetUnlockMultiMapIds(List<int> ids)
		{
			this.UnlockMultiMapIds = ids;
			EventSystem.Instance.Emit(EEventName.MultiMapUnlockChanged);
		}

		// Token: 0x0602C311 RID: 181009 RVA: 0x00C696EE File Offset: 0x00C678EE
		public void AddUnlockMultiMapIds(IEnumerable<int> ids)
		{
			this.UnlockMultiMapIds = NoLinq.UnionToList<int>(this.UnlockMultiMapIds, ids, null);
			EventSystem.Instance.Emit(EEventName.MultiMapUnlockChanged);
		}

		// Token: 0x0602C312 RID: 181010 RVA: 0x00C69713 File Offset: 0x00C67913
		public void SetUnlockMapBlockIds(List<int> ids)
		{
			this.UnlockMapBlockIds = ids;
			EventSystem.Instance.Emit(EEventName.MiniMapForceUpdate);
		}

		// Token: 0x0602C313 RID: 181011 RVA: 0x00C6972C File Offset: 0x00C6792C
		public void AddUnlockMapBlockIds(IEnumerable<int> ids)
		{
			this.UnlockMapBlockIds = NoLinq.UnionToList<int>(this.UnlockMapBlockIds, ids, null);
			EventSystem.Instance.Emit(EEventName.MiniMapForceUpdate);
		}

		// Token: 0x0602C314 RID: 181012 RVA: 0x00C69751 File Offset: 0x00C67951
		public bool CheckUnlockMultiMapIds(int id)
		{
			List<int> unlockMultiMapIds = this.UnlockMultiMapIds;
			return unlockMultiMapIds != null && unlockMultiMapIds.Contains(id);
		}

		// Token: 0x0602C315 RID: 181013 RVA: 0x00C69768 File Offset: 0x00C67968
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

		// Token: 0x0602C316 RID: 181014 RVA: 0x00C69860 File Offset: 0x00C67A60
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

		// Token: 0x0602C317 RID: 181015 RVA: 0x00C698CC File Offset: 0x00C67ACC
		public void AddEntityIdToPendingList(int entityId, int markId)
		{
			this.PendingAddEntityList[entityId] = markId;
		}

		// Token: 0x0602C318 RID: 181016 RVA: 0x00C698DB File Offset: 0x00C67ADB
		public void RemoveEntityIdToPendingList(int entityId)
		{
			this.PendingAddEntityList.Remove(entityId);
		}

		// Token: 0x0602C319 RID: 181017 RVA: 0x00C698EA File Offset: 0x00C67AEA
		[NullableContext(2)]
		public Dictionary<int, int> GetEntityPendingList()
		{
			return this.PendingAddEntityList;
		}

		// Token: 0x0602C31A RID: 181018 RVA: 0x00C698F4 File Offset: 0x00C67AF4
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

		// Token: 0x0602C31B RID: 181019 RVA: 0x00C69997 File Offset: 0x00C67B97
		public global::Vector GetLastSafeLocation()
		{
			return this.LastSafeLocation;
		}

		// Token: 0x0602C31C RID: 181020 RVA: 0x00C6999F File Offset: 0x00C67B9F
		public bool IsInUnopenedAreaPullback()
		{
			return GameModeModel.Instance.WorldDone && !GameModeModel.Instance.IsTeleport && this.CurrentInWorld && UnopenedAreaController.Instance.CheckInPullback();
		}

		// Token: 0x0602C31D RID: 181021 RVA: 0x00C699D1 File Offset: 0x00C67BD1
		public void SetMarkExtraShowState(int markId, bool needFocus, MapMarkShowFlag showFlag)
		{
			this.MarkExtraShowStateReference[markId] = new MarkShowState
			{
				Id = markId,
				NeedFocus = needFocus,
				ShowFlag = showFlag
			};
			EventSystem.Instance.Emit<int>(EEventName.OnMarkItemShowStateChange, markId);
		}

		// Token: 0x0602C31E RID: 181022 RVA: 0x00C69A0C File Offset: 0x00C67C0C
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

		// Token: 0x0602C31F RID: 181023 RVA: 0x00C69A74 File Offset: 0x00C67C74
		public void UpdateCompleteMarks(int[] markIdList)
		{
			this.CompleteMarks.Clear();
			foreach (int item in markIdList)
			{
				this.CompleteMarks.Add(item);
			}
		}

		// Token: 0x0602C320 RID: 181024 RVA: 0x00C69AB0 File Offset: 0x00C67CB0
		public void SetCompleteMarkState(int[] markIdList)
		{
			foreach (int item in markIdList)
			{
				this.CompleteMarks.Add(item);
			}
		}

		// Token: 0x0602C321 RID: 181025 RVA: 0x00C69ADE File Offset: 0x00C67CDE
		public bool IsCompleteMark(int markId)
		{
			return this.CompleteMarks.Contains(markId);
		}

		// Token: 0x0602C322 RID: 181026 RVA: 0x00C69AEC File Offset: 0x00C67CEC
		public bool IsMarkForbidGravityTeleport(int markId, EMarkType markType)
		{
			return OnlineModel.Instance.GetIsTeamModel() && this.GetMarkMapGravity(markId, markType) == EMapGravityDirection.Up && WorldMapModel.Instance.IsGravityMap(this.GetMarkMapConfigId(markId, markType)) && this.MapMarkConfigIsCanTeleport(markId);
		}

		// Token: 0x0602C323 RID: 181027 RVA: 0x00C69B28 File Offset: 0x00C67D28
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

		// Token: 0x0602C324 RID: 181028 RVA: 0x00C69B74 File Offset: 0x00C67D74
		public bool MapMarkIsCanTeleport(int markId)
		{
			return this.MapMarkConfigIsCanTeleport(markId) && !this.IsTeleportLocked(markId);
		}

		// Token: 0x0602C325 RID: 181029 RVA: 0x00C69B8C File Offset: 0x00C67D8C
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

		// Token: 0x0602C326 RID: 181030 RVA: 0x00C69C18 File Offset: 0x00C67E18
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

		// Token: 0x0602C327 RID: 181031 RVA: 0x00C69CB0 File Offset: 0x00C67EB0
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

		// Token: 0x0602C328 RID: 181032 RVA: 0x00C69CE8 File Offset: 0x00C67EE8
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

		// Token: 0x0602C329 RID: 181033 RVA: 0x00C69D18 File Offset: 0x00C67F18
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

		// Token: 0x0602C32A RID: 181034 RVA: 0x00C69DD4 File Offset: 0x00C67FD4
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

		// Token: 0x0602C32B RID: 181035 RVA: 0x00C69E40 File Offset: 0x00C68040
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

		// Token: 0x0602C32C RID: 181036 RVA: 0x00C69E92 File Offset: 0x00C68092
		public bool IsMarkUnlockedByServer(int markId)
		{
			Dictionary<int, bool> serverUnlockedMarksMap = this.ServerUnlockedMarksMap;
			return serverUnlockedMarksMap != null && serverUnlockedMarksMap.GetValueOrDefault(markId);
		}

		// Token: 0x0602C32D RID: 181037 RVA: 0x00C69EA6 File Offset: 0x00C680A6
		public void SetMarkServerOpenState(int markId, bool state)
		{
			this.ServerUnlockedMarksMap[markId] = state;
		}

		// Token: 0x0602C32E RID: 181038 RVA: 0x00C69EB8 File Offset: 0x00C680B8
		public string GetMarkAreaText(int mapId, int entityId)
		{
			LevelEntityConfig? levelEntityConfig;
			int areaId = (MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(mapId, entityId) != null) ? levelEntityConfig.GetValueOrDefault().AreaId : 0;
			return this.GetMarkAreaTextByAreaId(areaId);
		}

		// Token: 0x0602C32F RID: 181039 RVA: 0x00C69EF8 File Offset: 0x00C680F8
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

		// Token: 0x0602C330 RID: 181040 RVA: 0x00C6A040 File Offset: 0x00C68240
		public void UpdateBoxSlotInfo(TreasureBoxSlotInfo treasureBoxSlotInfo)
		{
			this.TreasureBoxSlotRawDataMap[treasureBoxSlotInfo.MarkId] = treasureBoxSlotInfo;
		}

		// Token: 0x0602C331 RID: 181041 RVA: 0x00C6A054 File Offset: 0x00C68254
		public void RemoveBoxSlotInfo(long slotId)
		{
			if (this.TreasureBoxSlotRawDataMap == null)
			{
				return;
			}
			foreach (TreasureBoxSlotInfo treasureBoxSlotInfo in this.TreasureBoxSlotRawDataMap.Values)
			{
				if (treasureBoxSlotInfo.DetectionSlotId == slotId)
				{
					this.TreasureBoxSlotRawDataMap.Remove(treasureBoxSlotInfo.MarkId);
					break;
				}
			}
		}

		// Token: 0x0602C332 RID: 181042 RVA: 0x00C6A0CC File Offset: 0x00C682CC
		public void FullUpdateBoxSlotInfo(RepeatedField<TreasureBoxSlotInfo> allTreasureBoxSlotInfo)
		{
			this.TreasureBoxSlotRawDataMap.Clear();
			foreach (TreasureBoxSlotInfo treasureBoxSlotInfo in allTreasureBoxSlotInfo)
			{
				this.UpdateBoxSlotInfo(treasureBoxSlotInfo);
			}
		}

		// Token: 0x0602C333 RID: 181043 RVA: 0x00C6A120 File Offset: 0x00C68320
		[NullableContext(2)]
		public TreasureBoxSlotInfo GetBoxSlotInfoByMarkId(int markId)
		{
			if (this.TreasureBoxSlotRawDataMap == null)
			{
				return null;
			}
			TreasureBoxSlotInfo result = null;
			foreach (TreasureBoxSlotInfo treasureBoxSlotInfo in this.TreasureBoxSlotRawDataMap.Values)
			{
				if (treasureBoxSlotInfo.MarkId == markId)
				{
					result = treasureBoxSlotInfo;
					break;
				}
			}
			return result;
		}

		// Token: 0x0602C334 RID: 181044 RVA: 0x00C6A18C File Offset: 0x00C6838C
		public void FullUpdateTreasureChestCount(IEnumerable<TreasureChestCountData> infoList)
		{
			this.TreasureChestCountMap.Clear();
			foreach (TreasureChestCountData treasureChestCountData in infoList)
			{
				this.TreasureChestCountMap[new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(treasureChestCountData.TargetType, treasureChestCountData.TargetId, treasureChestCountData.StatType)] = treasureChestCountData;
			}
			EventSystem.Instance.Emit<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, null);
		}

		// Token: 0x0602C335 RID: 181045 RVA: 0x00C6A214 File Offset: 0x00C68414
		public void IncrementTreasureChestCount(TreasureChestStatType statType, IEnumerable<int> instanceIds, IEnumerable<int> areaIds)
		{
			HashSet<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>> hashSet = new HashSet<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>>();
			foreach (int item in instanceIds)
			{
				hashSet.Add(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(TreasureChestCountTargetType.Instance, item, statType));
			}
			foreach (int item2 in areaIds)
			{
				hashSet.Add(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(TreasureChestCountTargetType.Area, item2, statType));
			}
			foreach (ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType> key in hashSet)
			{
				TreasureChestCountData treasureChestCountData;
				if (this.TreasureChestCountMap.TryGetValue(key, out treasureChestCountData))
				{
					TreasureChestCountData treasureChestCountData2 = treasureChestCountData;
					int currentCount = treasureChestCountData2.CurrentCount;
					treasureChestCountData2.CurrentCount = currentCount + 1;
				}
			}
			bool flag = false;
			foreach (TreasureChestCountData treasureChestCountData3 in this.GetCurTreasureChestCountList())
			{
				if (hashSet.Contains(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(treasureChestCountData3.TargetType, treasureChestCountData3.TargetId, treasureChestCountData3.StatType)))
				{
					flag = true;
					break;
				}
			}
			EventSystem.Instance.Emit<TreasureChestStatType?>(EEventName.OnTreasureChestCountChanged, flag ? new TreasureChestStatType?(statType) : null);
		}

		// Token: 0x0602C336 RID: 181046 RVA: 0x00C6A394 File Offset: 0x00C68594
		[NullableContext(2)]
		public TreasureChestCountData GetTreasureChestCount(TreasureChestCountTargetType targetType, int targetId, TreasureChestStatType statType)
		{
			return this.TreasureChestCountMap.GetValueOrDefault(new ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>(targetType, targetId, statType));
		}

		// Token: 0x0602C337 RID: 181047 RVA: 0x00C6A3AC File Offset: 0x00C685AC
		public List<TreasureChestCountData> GetTreasureChestCountList(TreasureChestCountTargetType targetType, int targetId)
		{
			List<TreasureChestCountData> list = new List<TreasureChestCountData>();
			foreach (TreasureChestStatType statType in MapDefine.TreasureChestStatTypeDisplayOrder)
			{
				TreasureChestCountData treasureChestCount = this.GetTreasureChestCount(targetType, targetId, statType);
				if (treasureChestCount != null)
				{
					list.Add(treasureChestCount);
				}
			}
			return list;
		}

		// Token: 0x0602C338 RID: 181048 RVA: 0x00C6A414 File Offset: 0x00C68614
		public List<TreasureChestCountData> GetCurTreasureChestCountList()
		{
			TreasureChestCountTargetType targetType;
			int targetId;
			int[] array;
			if (!this.TryGetCurTreasureChestTarget(out targetType, out targetId, out array))
			{
				return new List<TreasureChestCountData>();
			}
			List<TreasureChestCountData> list = new List<TreasureChestCountData>();
			foreach (TreasureChestCountData treasureChestCountData in this.GetTreasureChestCountList(targetType, targetId))
			{
				if (Array.IndexOf<int>(array, (int)treasureChestCountData.StatType) >= 0)
				{
					list.Add(treasureChestCountData);
				}
			}
			return list;
		}

		// Token: 0x0602C339 RID: 181049 RVA: 0x00C6A498 File Offset: 0x00C68698
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

		// Token: 0x0602C33A RID: 181050 RVA: 0x00C6A5C8 File Offset: 0x00C687C8
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

		// Token: 0x0602C33B RID: 181051 RVA: 0x00C6A624 File Offset: 0x00C68824
		public void RemoveTemporaryTeleportInfo(int markId)
		{
			if (this.TemporaryTeleportInfoRawDataMap == null)
			{
				return;
			}
			foreach (TemporaryTeleportInfo temporaryTeleportInfo in this.TemporaryTeleportInfoRawDataMap.Values)
			{
				if (temporaryTeleportInfo.MarkId == markId)
				{
					this.TemporaryTeleportInfoRawDataMap.Remove(temporaryTeleportInfo.MarkId);
					break;
				}
			}
		}

		// Token: 0x0602C33C RID: 181052 RVA: 0x00C6A69C File Offset: 0x00C6889C
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

		// Token: 0x0602C33D RID: 181053 RVA: 0x00C6A6F8 File Offset: 0x00C688F8
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

		// Token: 0x0602C33E RID: 181054 RVA: 0x00C6A730 File Offset: 0x00C68930
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

		// Token: 0x0602C33F RID: 181055 RVA: 0x00C6A7BC File Offset: 0x00C689BC
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
				return WorldMapModel.Instance.GetEntityPosition(entranceEntityId, dungeonEntranceConfig.Value.MapConfigId, false);
			}
			return null;
		}

		// Token: 0x0602C340 RID: 181056 RVA: 0x00C6A854 File Offset: 0x00C68A54
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
			return WorldMapModel.Instance.GetEntityPosition(pbDataId, dungeonConfig.Value.MapConfigId, false);
		}

		// Token: 0x0602C341 RID: 181057 RVA: 0x00C6A8C0 File Offset: 0x00C68AC0
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

		// Token: 0x0602C342 RID: 181058 RVA: 0x00C6A9B4 File Offset: 0x00C68BB4
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

		// Token: 0x0602C343 RID: 181059 RVA: 0x00C6AA4C File Offset: 0x00C68C4C
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

		// Token: 0x0602C344 RID: 181060 RVA: 0x00C6AAB4 File Offset: 0x00C68CB4
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

		// Token: 0x0602C345 RID: 181061 RVA: 0x00C6ABBC File Offset: 0x00C68DBC
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

		// Token: 0x0602C346 RID: 181062 RVA: 0x00C6ACC4 File Offset: 0x00C68EC4
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

		// Token: 0x0602C347 RID: 181063 RVA: 0x00C6AD10 File Offset: 0x00C68F10
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

		// Token: 0x0602C348 RID: 181064 RVA: 0x00C6AE78 File Offset: 0x00C69078
		public static int? GetEntityConfigAreaId(int mapId, int entityId)
		{
			if (MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(mapId, entityId) == null)
			{
				return null;
			}
			LevelEntityConfig? levelEntityConfig;
			return new int?(levelEntityConfig.GetValueOrDefault().AreaId);
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x0602C349 RID: 181065 RVA: 0x00C6AEBC File Offset: 0x00C690BC
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

		// Token: 0x0602C34A RID: 181066 RVA: 0x00C6AF20 File Offset: 0x00C69120
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

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x0602C34B RID: 181067 RVA: 0x00C6AF98 File Offset: 0x00C69198
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

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x0602C34C RID: 181068 RVA: 0x00C6B024 File Offset: 0x00C69224
		public bool CurrentInWorld
		{
			get
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				return WorldMapConfig.Instance.IsDungeonInWorld(instanceId);
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x0602C34D RID: 181069 RVA: 0x00C6B048 File Offset: 0x00C69248
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

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x0602C34E RID: 181070 RVA: 0x00C6B0A0 File Offset: 0x00C692A0
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

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x0602C34F RID: 181071 RVA: 0x00C6B0C9 File Offset: 0x00C692C9
		public bool IsPlayerInStandardGravity
		{
			get
			{
				return this.CurrentPlayerGravity == EMapGravityDirection.Down;
			}
		}

		// Token: 0x0602C350 RID: 181072 RVA: 0x00C6B0D4 File Offset: 0x00C692D4
		public int GetInstanceIdByWorldMapId(int worldMapInstanceId)
		{
			if (worldMapInstanceId == this.CurrentWorldMapConfigId || !WorldMapConfig.Instance.IsMapInWorld(worldMapInstanceId))
			{
				return CreatureModel.Instance.GetInstanceId();
			}
			return worldMapInstanceId;
		}

		// Token: 0x0602C351 RID: 181073 RVA: 0x00C6B0F8 File Offset: 0x00C692F8
		public void AddTrackMarkId(int markId)
		{
			this.RemoteTrackingMarkSet.Add(markId);
		}

		// Token: 0x0602C352 RID: 181074 RVA: 0x00C6B107 File Offset: 0x00C69307
		public void RemoveTrackMarkId(int markId)
		{
			this.RemoteTrackingMarkSet.Remove(markId);
		}

		// Token: 0x0602C353 RID: 181075 RVA: 0x00C6B116 File Offset: 0x00C69316
		public void ClearTrackMarkId()
		{
			this.RemoteTrackingMarkSet.Clear();
		}

		// Token: 0x0602C354 RID: 181076 RVA: 0x00C6B123 File Offset: 0x00C69323
		public bool IsMarkTracking(int markId)
		{
			return this.RemoteTrackingMarkSet.Contains(markId);
		}

		// Token: 0x0602C355 RID: 181077 RVA: 0x00C6B134 File Offset: 0x00C69334
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

		// Token: 0x0602C356 RID: 181078 RVA: 0x00C6B18D File Offset: 0x00C6938D
		public void ClearMarkHideInfo()
		{
			this.SystemMarkHideInfoMap.Clear();
		}

		// Token: 0x0602C357 RID: 181079 RVA: 0x00C6B19C File Offset: 0x00C6939C
		public string GetMarkHideInfoKey(int mapId, int entityId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(mapId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602C358 RID: 181080 RVA: 0x00C6B1D8 File Offset: 0x00C693D8
		public bool IsMarkHideByServer(int mapId, int entityId)
		{
			string markHideInfoKey = this.GetMarkHideInfoKey(mapId, entityId);
			return this.SystemMarkHideInfoMap.ContainsKey(markHideInfoKey);
		}

		// Token: 0x0602C359 RID: 181081 RVA: 0x00C6B1FC File Offset: 0x00C693FC
		[NullableContext(2)]
		public string GetMarkHideReason(int mapId, int entityId)
		{
			string markHideInfoKey = this.GetMarkHideInfoKey(mapId, entityId);
			SystemMarkHideInfoPb systemMarkHideInfoPb;
			if (this.SystemMarkHideInfoMap.TryGetValue(markHideInfoKey, out systemMarkHideInfoPb) && systemMarkHideInfoPb.HideInfo != null)
			{
				return this.ParseHideReason(systemMarkHideInfoPb.HideInfo);
			}
			return null;
		}

		// Token: 0x0602C35A RID: 181082 RVA: 0x00C6B238 File Offset: 0x00C69438
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

		// Token: 0x0602C35B RID: 181083 RVA: 0x00C6B318 File Offset: 0x00C69518
		public void InitTeleportMarkQueryCache()
		{
			foreach (MapMark mapMark in MapConfig.Instance.GetConfigMarkMap().Values)
			{
				if (mapMark.ObjectType == 15 || mapMark.ObjectType == 5 || mapMark.ObjectType == 6 || mapMark.ObjectType == 10 || mapMark.ObjectType == 19 || mapMark.EnableQuickTransfer == 1)
				{
					global::Vector vector = global::Vector.Create();
					MapUtil.GetConfigPosition(mapMark.EntityConfigId, vector, mapMark.RelativeDungeonId, false);
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

		// Token: 0x0602C35C RID: 181084 RVA: 0x00C6B490 File Offset: 0x00C69690
		public QueryNearestTeleporterResult QueryNearestTeleporter(int targetMarkId, EMarkType targetMarkType, global::Vector playerPosition)
		{
			MapModel.<>c__DisplayClass181_0 CS$<>8__locals1 = new MapModel.<>c__DisplayClass181_0();
			CS$<>8__locals1.targetMarkId = targetMarkId;
			CS$<>8__locals1.<>4__this = this;
			MapModel.<>c__DisplayClass181_0 CS$<>8__locals2 = CS$<>8__locals1;
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
			MapModel.<>c__DisplayClass181_0 CS$<>8__locals3 = CS$<>8__locals1;
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

		// Token: 0x0602C35D RID: 181085 RVA: 0x00C6B58C File Offset: 0x00C6978C
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

		// Token: 0x0602C35E RID: 181086 RVA: 0x00C6B674 File Offset: 0x00C69874
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

		// Token: 0x0602C35F RID: 181087 RVA: 0x00C6B934 File Offset: 0x00C69B34
		private static int GetEffectiveMultiMapId(int multiMapId, int[] connectMultiMapIds)
		{
			if (multiMapId == 0 && connectMultiMapIds.Length != 0)
			{
				return connectMultiMapIds[0];
			}
			return multiMapId;
		}

		// Token: 0x0602C360 RID: 181088 RVA: 0x00C6B944 File Offset: 0x00C69B44
		public EMarkType? GetEntityIdToMarkType(int entityId)
		{
			Dictionary<int, EMarkType> entityIdToMarkType = this.EntityIdToMarkType;
			if (entityIdToMarkType == null)
			{
				return null;
			}
			return new EMarkType?(entityIdToMarkType.GetValueOrDefault(entityId));
		}

		// Token: 0x0602C361 RID: 181089 RVA: 0x00C6B970 File Offset: 0x00C69B70
		public void AddEntityIdToMarkType(int entityId, EMarkType markType)
		{
			this.EntityIdToMarkType[entityId] = markType;
		}

		// Token: 0x0602C362 RID: 181090 RVA: 0x00C6B97F File Offset: 0x00C69B7F
		public void RemoveEntityIdToMarkType(int entityId)
		{
			Dictionary<int, EMarkType> entityIdToMarkType = this.EntityIdToMarkType;
			if (entityIdToMarkType == null)
			{
				return;
			}
			entityIdToMarkType.Remove(entityId);
		}

		// Token: 0x0602C363 RID: 181091 RVA: 0x00C6B993 File Offset: 0x00C69B93
		public void UpdateHonamiScanMarkInfo(int markId, MarkState state)
		{
			this.HonamiScanMarkInfo[markId] = state;
			EventSystem.Instance.Emit<int>(EEventName.OnHonamiScanMarkInfoUpdate, markId);
		}

		// Token: 0x0602C364 RID: 181092 RVA: 0x00C6B9B3 File Offset: 0x00C69BB3
		public MarkState GetHonamiScanMarkInfo(int markId)
		{
			return this.HonamiScanMarkInfo.GetValueOrDefault(markId, MarkState.MarkDisable);
		}

		// Token: 0x0602C365 RID: 181093 RVA: 0x00C6B9C2 File Offset: 0x00C69BC2
		public void ClearHonamiScanMarkInfo()
		{
			this.HonamiScanMarkInfo.Clear();
		}

		// Token: 0x0602C366 RID: 181094 RVA: 0x00C6B9CF File Offset: 0x00C69BCF
		public void InitExtraUiMarkType(EMapType mapType)
		{
			if (this.ExtraMarkTypeMap != null)
			{
				this.ExtraMarkTypeMap[mapType] = new HashSet<EMarkType>();
			}
		}

		// Token: 0x0602C367 RID: 181095 RVA: 0x00C6B9EA File Offset: 0x00C69BEA
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

		// Token: 0x0602C368 RID: 181096 RVA: 0x00C6BA26 File Offset: 0x00C69C26
		public bool HasExtraUiMarkType(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			return ((extraMarkTypeMap != null) ? extraMarkTypeMap.GetValueOrDefault(mapType) : null) != null;
		}

		// Token: 0x0602C369 RID: 181097 RVA: 0x00C6BA40 File Offset: 0x00C69C40
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

		// Token: 0x0602C36A RID: 181098 RVA: 0x00C6BA8A File Offset: 0x00C69C8A
		public void ClearExtraUiMarkType(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<EMarkType>> extraMarkTypeMap = this.ExtraMarkTypeMap;
			if (extraMarkTypeMap == null)
			{
				return;
			}
			extraMarkTypeMap.Remove(mapType);
		}

		// Token: 0x0602C36B RID: 181099 RVA: 0x00C6BA9E File Offset: 0x00C69C9E
		public void InitExtraUiMarkId(EMapType mapType)
		{
			if (this.ExtraMarkIdMap != null)
			{
				this.ExtraMarkIdMap[mapType] = new HashSet<int>();
			}
		}

		// Token: 0x0602C36C RID: 181100 RVA: 0x00C6BAB9 File Offset: 0x00C69CB9
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

		// Token: 0x0602C36D RID: 181101 RVA: 0x00C6BAF5 File Offset: 0x00C69CF5
		public bool HasExtraUiMarkId(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			return ((extraMarkIdMap != null) ? extraMarkIdMap.GetValueOrDefault(mapType) : null) != null;
		}

		// Token: 0x0602C36E RID: 181102 RVA: 0x00C6BB10 File Offset: 0x00C69D10
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

		// Token: 0x0602C36F RID: 181103 RVA: 0x00C6BB5A File Offset: 0x00C69D5A
		public void ClearExtraUiMarkId(EMapType mapType)
		{
			Dictionary<EMapType, HashSet<int>> extraMarkIdMap = this.ExtraMarkIdMap;
			if (extraMarkIdMap == null)
			{
				return;
			}
			extraMarkIdMap.Remove(mapType);
		}

		// Token: 0x0602C370 RID: 181104 RVA: 0x00C6BB6E File Offset: 0x00C69D6E
		public void SetExtraUiTileRange(EMapType mapType, ITileNum tileRange)
		{
			if (this.ExtraUiTileRange != null)
			{
				this.ExtraUiTileRange[mapType] = tileRange;
			}
		}

		// Token: 0x0602C371 RID: 181105 RVA: 0x00C6BB85 File Offset: 0x00C69D85
		public void ClearExtraUiTileRange(EMapType mapType)
		{
			Dictionary<EMapType, ITileNum> extraUiTileRange = this.ExtraUiTileRange;
			if (extraUiTileRange == null)
			{
				return;
			}
			extraUiTileRange.Remove(mapType);
		}

		// Token: 0x0602C372 RID: 181106 RVA: 0x00C6BB99 File Offset: 0x00C69D99
		public bool HasExtraUiTileRange(EMapType mapType)
		{
			Dictionary<EMapType, ITileNum> extraUiTileRange = this.ExtraUiTileRange;
			return extraUiTileRange != null && extraUiTileRange.ContainsKey(mapType);
		}

		// Token: 0x0602C373 RID: 181107 RVA: 0x00C6BBB0 File Offset: 0x00C69DB0
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

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x0602C374 RID: 181108 RVA: 0x00C6BC2E File Offset: 0x00C69E2E
		public static MapModel Instance
		{
			get
			{
				return MapModel._Instance;
			}
		}

		// Token: 0x0602C375 RID: 181109 RVA: 0x00C6BC35 File Offset: 0x00C69E35
		public static MapModel GetOrCreateInstance()
		{
			if (MapModel._Instance == null)
			{
				MapModel.CreateInstance();
			}
			return MapModel._Instance;
		}

		// Token: 0x0602C376 RID: 181110 RVA: 0x00C6BC49 File Offset: 0x00C69E49
		public static bool CreateInstance()
		{
			if (MapModel._Instance != null)
			{
				return true;
			}
			MapModel._Instance = new MapModel();
			return true;
		}

		// Token: 0x0602C377 RID: 181111 RVA: 0x00C6BC5F File Offset: 0x00C69E5F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C378 RID: 181112 RVA: 0x00C6BC61 File Offset: 0x00C69E61
		public static void ResetStaticDefaultValue()
		{
			MapModel._Instance = null;
		}

		// Token: 0x0602C379 RID: 181113 RVA: 0x00C6BC69 File Offset: 0x00C69E69
		static MapModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapModel.CreateStaticDefaultValue), new Action(MapModel.ResetStaticDefaultValue));
		}

		// Token: 0x04017C74 RID: 97396
		private int DynamicMarkId;

		// Token: 0x04017C75 RID: 97397
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<EMarkType, Dictionary<int, DynamicMarkCreateInfo>> DynamicMarks;

		// Token: 0x04017C76 RID: 97398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, Dictionary<int, bool>> MarkVisibleStateRecord;

		// Token: 0x04017C77 RID: 97399
		[Nullable(2)]
		private Dictionary<int, long> SceneGamePlayRefQuestMap;

		// Token: 0x04017C78 RID: 97400
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, int[]> OccupationResourceRefPlayMap;

		// Token: 0x04017C79 RID: 97401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, DynamicMarkCreateInfo> DynamicMarksSearchMap;

		// Token: 0x04017C7A RID: 97402
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedTeleports;

		// Token: 0x04017C7B RID: 97403
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedFogs;

		// Token: 0x04017C7C RID: 97404
		[Nullable(2)]
		private Dictionary<int, bool> UnlockedAreas;

		// Token: 0x04017C7D RID: 97405
		[Nullable(2)]
		private TrackMapMarkParams CurTrackParams;

		// Token: 0x04017C7E RID: 97406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IMarkShowState> MarkExtraShowStateReference;

		// Token: 0x04017C7F RID: 97407
		private HashSet<int> CompleteMarks = new HashSet<int>();

		// Token: 0x04017C80 RID: 97408
		[Nullable(2)]
		private Dictionary<int, int> PendingAddEntityList;

		// Token: 0x04017C81 RID: 97409
		[Nullable(2)]
		private HashSet<int> PendingAddTempMapMarkList;

		// Token: 0x04017C82 RID: 97410
		[Nullable(2)]
		private Dictionary<int, bool> ServerUnlockedMarksMap;

		// Token: 0x04017C83 RID: 97411
		private List<int> UnlockMultiMapIds = new List<int>();

		// Token: 0x04017C84 RID: 97412
		public List<int> UnlockMapBlockIds = new List<int>();

		// Token: 0x04017C85 RID: 97413
		public readonly global::Vector LastSafeLocation = global::Vector.Create();

		// Token: 0x04017C86 RID: 97414
		[Nullable(2)]
		public Circle CacheEnrichmentAreaWorldMapCircle;

		// Token: 0x04017C87 RID: 97415
		public int CacheEnrichmentAreaEntityId;

		// Token: 0x04017C88 RID: 97416
		public Dictionary<int, MarkState> HonamiScanMarkInfo = new Dictionary<int, MarkState>();

		// Token: 0x04017C89 RID: 97417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, TreasureBoxSlotInfo> TreasureBoxSlotRawDataMap;

		// Token: 0x04017C8A RID: 97418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, TemporaryTeleportInfo> TemporaryTeleportInfoRawDataMap;

		// Token: 0x04017C8B RID: 97419
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>, TreasureChestCountData> TreasureChestCountMap = new Dictionary<ValueTuple<TreasureChestCountTargetType, int, TreasureChestStatType>, TreasureChestCountData>();

		// Token: 0x04017C8C RID: 97420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<EMapLifeEventListenerType, IMapLifeEventTriggerParam> MapLifeEventListenerTriggerMap;

		// Token: 0x04017C8D RID: 97421
		private readonly List<MarkDefine.FishingShipMarkCacheInfo> CacheEntityMapMarkInfo = new List<MarkDefine.FishingShipMarkCacheInfo>();

		// Token: 0x04017C8E RID: 97422
		private readonly HashSet<int> RemoteTrackingMarkSet = new HashSet<int>();

		// Token: 0x04017C8F RID: 97423
		private Dictionary<string, SystemMarkHideInfoPb> SystemMarkHideInfoMap = new Dictionary<string, SystemMarkHideInfoPb>();

		// Token: 0x04017C90 RID: 97424
		[Nullable(2)]
		private Dictionary<int, EMarkType> EntityIdToMarkType;

		// Token: 0x04017C91 RID: 97425
		public int? LastHighLevelAreaInner;

		// Token: 0x04017C92 RID: 97426
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, HashSet<EMarkType>> ExtraMarkTypeMap;

		// Token: 0x04017C93 RID: 97427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, HashSet<int>> ExtraMarkIdMap;

		// Token: 0x04017C94 RID: 97428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMapType, ITileNum> ExtraUiTileRange;

		// Token: 0x04017C95 RID: 97429
		private readonly Dictionary<int, HashSet<MapTeleportQueryInfo>> MarkQueryInfoInGrid = new Dictionary<int, HashSet<MapTeleportQueryInfo>>();

		// Token: 0x04017C96 RID: 97430
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		private readonly TrimLru<int, List<ValueTuple<MapTeleportQueryInfo, double>>> MarkQueryInfoCache = new TrimLru<int, List<ValueTuple<MapTeleportQueryInfo, double>>>(3, false);

		// Token: 0x04017C97 RID: 97431
		[Nullable(2)]
		private static MapModel _Instance;
	}
}
