using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005596 RID: 21910
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FishingModel : ModelBase
	{
		// Token: 0x060364B0 RID: 222384 RVA: 0x00F2510F File Offset: 0x00F2330F
		public void SetFishingLevelUpInfo(FishingLevelUpData data)
		{
			if (this.LastFishingLevelUpDataInternal == null)
			{
				this.LastFishingLevelUpDataInternal = data;
				return;
			}
			this.LastFishingLevelUpDataInternal.CurrentLevel = data.CurrentLevel;
		}

		// Token: 0x060364B1 RID: 222385 RVA: 0x00F25132 File Offset: 0x00F23332
		[NullableContext(2)]
		public FishingLevelUpData GetFishingLevelUpInfo()
		{
			return this.LastFishingLevelUpDataInternal;
		}

		// Token: 0x060364B2 RID: 222386 RVA: 0x00F2513A File Offset: 0x00F2333A
		public void ClearLastFishingExp()
		{
			this.LastFishingLevelUpDataInternal = null;
		}

		// Token: 0x060364B3 RID: 222387 RVA: 0x00F25144 File Offset: 0x00F23344
		protected override bool OnInit()
		{
			this.FishingReputationItemId = ConfigCommonParamById.GetIntConfig("FishingSailingExpItemId").Value;
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("FishingShipFixCost");
			this.FishingShipFixItem = intArrayConfig[0];
			this.FishingShipFixCost = ConfigCommonParamById.GetIntConfig("FishingShipFixCostCount").Value;
			this.TempFishingPointLimit = ConfigCommonParamById.GetIntConfig("FishingMaxBaitCount").GetValueOrDefault();
			this.FishingSlotCountTech = ConfigCommonParamById.GetIntConfig("FishingSlotCountTech").GetValueOrDefault();
			this.FishingBagRedPercentage = ConfigCommonParamById.GetIntConfig("FishingBagRedPercentage").GetValueOrDefault();
			this.InitTechNodeMap();
			return true;
		}

		// Token: 0x060364B4 RID: 222388 RVA: 0x00F251E8 File Offset: 0x00F233E8
		private void InitTechNodeMap()
		{
			foreach (FishingTech fishingTech in FishingConfig.Instance.GetFishingTechList())
			{
				if (fishingTech.Type == 4 || fishingTech.Type == 5)
				{
					List<IFishingTechNode> list;
					if (!this.RoleTechNodeMap.TryGetValue(fishingTech.Type, out list))
					{
						list = new List<IFishingTechNode>();
					}
					FishingTechNode item = new FishingTechNode
					{
						ConfigId = fishingTech.Id,
						NodeType = (EFishingTechNodeType)fishingTech.Type,
						Area = fishingTech.Area,
						PreNode = fishingTech.PreNode
					};
					list.Add(item);
					this.RoleTechNodeMap[fishingTech.Type] = list;
				}
				else
				{
					List<IFishingTechNode> list2;
					if (!this.NormalTechNodeMap.TryGetValue(fishingTech.Area, out list2))
					{
						list2 = new List<IFishingTechNode>();
					}
					FishingTechNode item2 = new FishingTechNode
					{
						ConfigId = fishingTech.Id,
						NodeType = (EFishingTechNodeType)fishingTech.Type,
						Area = fishingTech.Area,
						PreNode = fishingTech.PreNode
					};
					list2.Add(item2);
					this.NormalTechNodeMap[fishingTech.Area] = list2;
				}
			}
		}

		// Token: 0x060364B5 RID: 222389 RVA: 0x00F25340 File Offset: 0x00F23540
		public int GetFishingReputationLevelByItemCount(int itemCount)
		{
			IEnumerable<FishingReputation> allFishingReputation = FishingConfig.Instance.GetAllFishingReputation();
			int num = 1;
			foreach (FishingReputation fishingReputation in allFishingReputation)
			{
				if (itemCount >= fishingReputation.Exp && num <= fishingReputation.Level)
				{
					num = fishingReputation.Level;
				}
			}
			return num;
		}

		// Token: 0x060364B6 RID: 222390 RVA: 0x00F253AC File Offset: 0x00F235AC
		public int GetConfigMaxFishingReputationLevel()
		{
			IEnumerable<FishingReputation> allFishingReputation = FishingConfig.Instance.GetAllFishingReputation();
			int num = 0;
			foreach (FishingReputation fishingReputation in allFishingReputation)
			{
				if (num <= fishingReputation.Level)
				{
					num = fishingReputation.Level;
				}
			}
			return num;
		}

		// Token: 0x060364B7 RID: 222391 RVA: 0x00F2540C File Offset: 0x00F2360C
		private void SetCageData(int sceneId, IEnumerable<OneFishCage> cages)
		{
			Dictionary<int, DockyardCageData> dictionary;
			if (!this.CageDataMapMap.TryGetValue(sceneId, out dictionary))
			{
				dictionary = new Dictionary<int, DockyardCageData>();
			}
			foreach (OneFishCage oneFishCage in cages)
			{
				DockyardCageData value = new DockyardCageData(oneFishCage);
				dictionary[oneFishCage.Id] = value;
			}
			this.CageDataMapMap[sceneId] = dictionary;
		}

		// Token: 0x060364B8 RID: 222392 RVA: 0x00F25484 File Offset: 0x00F23684
		public void SetCageDataMapFromServer(Dictionary<int, SceneFishCageInfo> dataMap)
		{
			this.CageDataMapMap.Clear();
			foreach (int num in dataMap.Keys)
			{
				RepeatedField<OneFishCage> cages = dataMap[num].Cages;
				this.SetCageData(num, cages);
			}
		}

		// Token: 0x060364B9 RID: 222393 RVA: 0x00F254F0 File Offset: 0x00F236F0
		public void AddCageDataFromServer(int sceneId, OneFishCage cageInfo)
		{
			Dictionary<int, DockyardCageData> dictionary;
			if (!this.CageDataMapMap.TryGetValue(sceneId, out dictionary))
			{
				dictionary = new Dictionary<int, DockyardCageData>();
			}
			dictionary[cageInfo.Id] = new DockyardCageData(cageInfo);
			this.CageDataMapMap[sceneId] = dictionary;
		}

		// Token: 0x060364BA RID: 222394 RVA: 0x00F25534 File Offset: 0x00F23734
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByCage(int configId, int uniqueId)
		{
			DockyardCageData cageDataByConfigId = this.GetCageDataByConfigId(configId);
			if (cageDataByConfigId == null)
			{
				return null;
			}
			return cageDataByConfigId.GetData(uniqueId);
		}

		// Token: 0x060364BB RID: 222395 RVA: 0x00F25558 File Offset: 0x00F23758
		[NullableContext(2)]
		public DockyardCageData GetCageDataByConfigId(int configId)
		{
			int id = GameModeModel.Instance.InstanceDungeon.Value.Id;
			Dictionary<int, DockyardCageData> dictionary;
			if (!this.CageDataMapMap.TryGetValue(id, out dictionary))
			{
				return null;
			}
			DockyardCageData result;
			if (dictionary.TryGetValue(configId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364BC RID: 222396 RVA: 0x00F255A4 File Offset: 0x00F237A4
		public List<DockyardItemBlockOriginalData> GetCageDataList(int entityId)
		{
			DockyardCageData cageDataByConfigId = this.GetCageDataByConfigId(entityId);
			if (cageDataByConfigId == null)
			{
				return new List<DockyardItemBlockOriginalData>();
			}
			return cageDataByConfigId.GetDataList();
		}

		// Token: 0x060364BD RID: 222397 RVA: 0x00F255C8 File Offset: 0x00F237C8
		private void CreateInteractData(HandInInfo data)
		{
			Dictionary<int, DockyardItemBlockOriginalData> dictionary;
			if (!this.InteractDataMapMap.TryGetValue(data.Id, out dictionary))
			{
				dictionary = new Dictionary<int, DockyardItemBlockOriginalData>();
			}
			foreach (FishingItemInfo data2 in data.FishingItems)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(data2);
				dictionary[dockyardItemBlockOriginalData.IncId] = dockyardItemBlockOriginalData;
			}
			this.InteractDataMapMap[data.Id] = dictionary;
		}

		// Token: 0x060364BE RID: 222398 RVA: 0x00F25650 File Offset: 0x00F23850
		public void SetInteractData(IEnumerable<HandInInfo> dataList)
		{
			foreach (HandInInfo data in dataList)
			{
				this.CreateInteractData(data);
			}
		}

		// Token: 0x060364BF RID: 222399 RVA: 0x00F25698 File Offset: 0x00F23898
		public void UpdateInteractData(HandInInfo data)
		{
			Dictionary<int, DockyardItemBlockOriginalData> dictionary;
			if (!this.InteractDataMapMap.TryGetValue(data.Id, out dictionary))
			{
				dictionary = new Dictionary<int, DockyardItemBlockOriginalData>();
			}
			dictionary.Clear();
			foreach (FishingItemInfo data2 in data.FishingItems)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(data2);
				dictionary[dockyardItemBlockOriginalData.IncId] = dockyardItemBlockOriginalData;
			}
			this.InteractDataMapMap[data.Id] = dictionary;
		}

		// Token: 0x060364C0 RID: 222400 RVA: 0x00F25724 File Offset: 0x00F23924
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByInteract(int configId, int uniqueId)
		{
			Dictionary<int, DockyardItemBlockOriginalData> dictionary;
			if (!this.InteractDataMapMap.TryGetValue(configId, out dictionary))
			{
				return null;
			}
			DockyardItemBlockOriginalData result;
			if (dictionary.TryGetValue(uniqueId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364C1 RID: 222401 RVA: 0x00F25754 File Offset: 0x00F23954
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, DockyardItemBlockOriginalData> GetDataMapByInteract(int configId)
		{
			Dictionary<int, DockyardItemBlockOriginalData> result;
			if (this.InteractDataMapMap.TryGetValue(configId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364C2 RID: 222402 RVA: 0x00F25774 File Offset: 0x00F23974
		public void SetAllFishingPointData(Dictionary<int, SceneFishPointInfo> dataMap)
		{
			this.ClearAllFishingPointData();
			foreach (int num in dataMap.Keys)
			{
				RepeatedField<OneFishPointInfo> fishPoints = dataMap[num].FishPoints;
				RepeatedField<TempFishPointInfo> tempFishPoints = dataMap[num].TempFishPoints;
				HashSet<int> hashSet;
				if (!this.FishingPointSceneId2PbEntityId.TryGetValue(num, out hashSet))
				{
					hashSet = new HashSet<int>();
					this.FishingPointSceneId2PbEntityId[num] = hashSet;
				}
				foreach (OneFishPointInfo fishPoint in fishPoints)
				{
					this.SetOneFishingPointData(num, hashSet, fishPoint);
				}
				foreach (TempFishPointInfo fishPoint2 in tempFishPoints)
				{
					this.SetTempFishingPointData(num, fishPoint2);
				}
			}
		}

		// Token: 0x060364C3 RID: 222403 RVA: 0x00F25888 File Offset: 0x00F23A88
		private void ClearAllFishingPointData()
		{
			this.FishingPointDataPbEntityIdMap.Clear();
			this.FishingPointSceneId2PbEntityId.Clear();
			this.FishingPointId2EntityId.Clear();
			this.TempFishingPointDataMap.Clear();
		}

		// Token: 0x060364C4 RID: 222404 RVA: 0x00F258B8 File Offset: 0x00F23AB8
		public void RefreshFishingPointData(int sceneId, OneFishPointInfo fishPoint)
		{
			HashSet<int> hashSet;
			if (!this.FishingPointSceneId2PbEntityId.TryGetValue(sceneId, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.FishingPointSceneId2PbEntityId[sceneId] = hashSet;
			}
			this.SetOneFishingPointData(sceneId, hashSet, fishPoint);
		}

		// Token: 0x060364C5 RID: 222405 RVA: 0x00F258F4 File Offset: 0x00F23AF4
		private void SetOneFishingPointData(int sceneId, HashSet<int> pbEntityIdSet, OneFishPointInfo fishPoint)
		{
			int entityConfigId = fishPoint.EntityConfigId;
			FishingPointData fishingPointData;
			if (!this.FishingPointDataPbEntityIdMap.TryGetValue(entityConfigId, out fishingPointData))
			{
				fishingPointData = new FishingPointData();
				fishingPointData.SceneId = sceneId;
				pbEntityIdSet.Add(entityConfigId);
				this.FishingPointDataPbEntityIdMap[entityConfigId] = fishingPointData;
				this.FishingPointId2EntityId[fishPoint.Id] = entityConfigId;
			}
			fishingPointData.Refresh(fishPoint);
			this.RefreshFishPointEntity(entityConfigId, fishingPointData);
		}

		// Token: 0x060364C6 RID: 222406 RVA: 0x00F2595C File Offset: 0x00F23B5C
		public void RemoveOneFishingPointData(int sceneId, OneFishPointInfo fishPoint)
		{
			int entityConfigId = fishPoint.EntityConfigId;
			FishingPointData fishingPointData;
			if (this.FishingPointDataPbEntityIdMap.TryGetValue(entityConfigId, out fishingPointData))
			{
				fishingPointData.Refresh(fishPoint);
				this.RefreshFishPointEntity(entityConfigId, fishingPointData);
			}
			if (this.FishingPointDataPbEntityIdMap.Remove(entityConfigId))
			{
				HashSet<int> hashSet;
				if (this.FishingPointSceneId2PbEntityId.TryGetValue(sceneId, out hashSet))
				{
					hashSet.Remove(entityConfigId);
				}
				this.FishingPointId2EntityId.Remove(fishPoint.Id);
			}
		}

		// Token: 0x060364C7 RID: 222407 RVA: 0x00F259C8 File Offset: 0x00F23BC8
		private void RefreshFishPointEntity(int pbEntityId, FishingPointData fishData)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbEntityId);
			if (entityByPbDataId != null && entityByPbDataId.Valid)
			{
				SceneItemFishingPointComponent component = entityByPbDataId.Entity.GetComponent<SceneItemFishingPointComponent>();
				if (component == null)
				{
					return;
				}
				component.RefreshFishingPoint(fishData);
			}
		}

		// Token: 0x060364C8 RID: 222408 RVA: 0x00F25A04 File Offset: 0x00F23C04
		[NullableContext(2)]
		public FishingPointData GetFishingPointDataById(int configId)
		{
			int key;
			if (!this.FishingPointId2EntityId.TryGetValue(configId, out key))
			{
				return null;
			}
			FishingPointData result;
			if (this.FishingPointDataPbEntityIdMap.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364C9 RID: 222409 RVA: 0x00F25A38 File Offset: 0x00F23C38
		public int GetFishingPointEntityIdByConfigId(int configId)
		{
			int result;
			if (this.FishingPointId2EntityId.TryGetValue(configId, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x060364CA RID: 222410 RVA: 0x00F25A58 File Offset: 0x00F23C58
		public bool GetFishingPointHaveFinishingIdByConfigId(int configId)
		{
			int key;
			FishingPointData fishingPointData;
			return !this.FishingPointId2EntityId.TryGetValue(configId, out key) || !this.FishingPointDataPbEntityIdMap.TryGetValue(key, out fishingPointData) || fishingPointData.CurrentCount <= 0;
		}

		// Token: 0x060364CB RID: 222411 RVA: 0x00F25A98 File Offset: 0x00F23C98
		[NullableContext(2)]
		public FishingPointData GetFishingPointDataByPbEntityId(int pbEntityId)
		{
			FishingPointData result;
			if (this.FishingPointDataPbEntityIdMap.TryGetValue(pbEntityId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364CC RID: 222412 RVA: 0x00F25AB8 File Offset: 0x00F23CB8
		public List<FishingPointData> GetAllFishingPointDataBySceneId(int sceneId)
		{
			List<FishingPointData> list = new List<FishingPointData>();
			HashSet<int> hashSet;
			if (!this.FishingPointSceneId2PbEntityId.TryGetValue(sceneId, out hashSet))
			{
				return list;
			}
			foreach (int key in hashSet)
			{
				FishingPointData item;
				if (this.FishingPointDataPbEntityIdMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060364CD RID: 222413 RVA: 0x00F25B30 File Offset: 0x00F23D30
		public void SetTempFishingPointData(int sceneId, TempFishPointInfo fishPoint)
		{
			long entityId = fishPoint.EntityId;
			TempFishingPointData tempFishingPointData;
			if (!this.TempFishingPointDataMap.TryGetValue(entityId, out tempFishingPointData))
			{
				tempFishingPointData = new TempFishingPointData();
				tempFishingPointData.SceneId = sceneId;
				this.TempFishingPointDataMap[entityId] = tempFishingPointData;
			}
			tempFishingPointData.Refresh(fishPoint);
		}

		// Token: 0x060364CE RID: 222414 RVA: 0x00F25B78 File Offset: 0x00F23D78
		public void RemoveTempFishingPointData(TempFishPointInfo fishPoint)
		{
			long entityId = fishPoint.EntityId;
			this.TempFishingPointDataMap.Remove(entityId);
		}

		// Token: 0x060364CF RID: 222415 RVA: 0x00F25B9C File Offset: 0x00F23D9C
		[NullableContext(2)]
		public TempFishingPointData GetTempFishingPointDataByCreatureDataId(long creatureDataId)
		{
			TempFishingPointData result;
			if (this.TempFishingPointDataMap.TryGetValue(creatureDataId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060364D0 RID: 222416 RVA: 0x00F25BBC File Offset: 0x00F23DBC
		public int GetTempFishingPointLimit()
		{
			return this.TempFishingPointLimit;
		}

		// Token: 0x060364D1 RID: 222417 RVA: 0x00F25BC4 File Offset: 0x00F23DC4
		public int GetTempFishingPointNum()
		{
			return this.TempFishingPointDataMap.Count;
		}

		// Token: 0x060364D2 RID: 222418 RVA: 0x00F25BD4 File Offset: 0x00F23DD4
		public void SetFishingTechData(IEnumerable<FishingTechInfo> dataList)
		{
			this.FishingTechDataMap.Clear();
			foreach (FishingTechInfo fishingTechInfo in dataList)
			{
				int nodeId = fishingTechInfo.NodeId;
				foreach (int techEffectId in FishingConfig.Instance.GetFishingTechById(nodeId).Effect())
				{
					FishingTechEffect? fishingTechEffect = new FishingTechEffect?(FishingConfig.Instance.GetFishingTechEffectById(techEffectId));
					if (fishingTechEffect != null && this.NeedCheckEffectType.Contains(fishingTechEffect.Value.Type))
					{
						HashSet<int> hashSet;
						if (!this.EffectType2TechIdsMap.TryGetValue(fishingTechEffect.Value.Type, out hashSet))
						{
							hashSet = new HashSet<int>();
							this.EffectType2TechIdsMap[fishingTechEffect.Value.Type] = hashSet;
						}
						hashSet.Add(nodeId);
					}
				}
				this.FishingTechDataMap[nodeId] = fishingTechInfo;
				EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, fishingTechInfo.NodeId);
			}
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.MainRole);
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.Phoebe);
		}

		// Token: 0x060364D3 RID: 222419 RVA: 0x00F25D2C File Offset: 0x00F23F2C
		public void UpdateFishingTechData(FishingTechInfo data)
		{
			this.FishingTechDataMap[data.NodeId] = data;
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRefresh, data.NodeId);
		}

		// Token: 0x060364D4 RID: 222420 RVA: 0x00F25D58 File Offset: 0x00F23F58
		public bool GetFishingTechUnlock(int techId)
		{
			FishingTechInfo valueOrDefault = this.FishingTechDataMap.GetValueOrDefault(techId);
			return (FishingConfig.Instance.GetFishingTechById(techId).UnlockCondition <= 0 || (valueOrDefault != null && valueOrDefault.Unlock)) && ((valueOrDefault != null) ? valueOrDefault.Level : 0) > 0;
		}

		// Token: 0x060364D5 RID: 222421 RVA: 0x00F25DAC File Offset: 0x00F23FAC
		public bool GetFishingTechUnlockByEffectType(EFishingTechType type)
		{
			IReadOnlyList<FishingTech> fishingTechList = FishingConfig.Instance.GetFishingTechList();
			IReadOnlyList<FishingTechEffect> fishingTechEffectByType = FishingConfig.Instance.GetFishingTechEffectByType((int)type);
			if (fishingTechEffectByType.Count <= 0)
			{
				return false;
			}
			int id = fishingTechEffectByType[0].Id;
			foreach (FishingTech fishingTech in fishingTechList)
			{
				if (Array.IndexOf<int>(fishingTech.Effect(), id) >= 0)
				{
					return this.GetFishingTechUnlock(fishingTech.Id);
				}
			}
			return false;
		}

		// Token: 0x060364D6 RID: 222422 RVA: 0x00F25E4C File Offset: 0x00F2404C
		public int GetFishingCurrentLevelTechEffectByEffectType(EFishingTechType type)
		{
			IReadOnlyList<FishingTech> fishingTechList = FishingConfig.Instance.GetFishingTechList();
			IReadOnlyList<FishingTechEffect> fishingTechEffectByType = FishingConfig.Instance.GetFishingTechEffectByType((int)type);
			if (fishingTechEffectByType.Count <= 0)
			{
				return 0;
			}
			int id = fishingTechEffectByType[0].Id;
			foreach (FishingTech fishingTech in fishingTechList)
			{
				if (Array.IndexOf<int>(fishingTech.Effect(), id) >= 0)
				{
					FishingTechInfo fishingTechInfo;
					this.FishingTechDataMap.TryGetValue(fishingTech.Id, out fishingTechInfo);
					int num = (fishingTechInfo != null) ? fishingTechInfo.Level : 0;
					if (num <= 0)
					{
						return 0;
					}
					return fishingTech.Effect(num - 1);
				}
			}
			return 0;
		}

		// Token: 0x17006962 RID: 26978
		// (get) Token: 0x060364D7 RID: 222423 RVA: 0x00F25F18 File Offset: 0x00F24118
		public int UnlockFishingTechCount
		{
			get
			{
				int num = 0;
				using (Dictionary<int, FishingTechInfo>.ValueCollection.Enumerator enumerator = this.FishingTechDataMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Level > 0)
						{
							num++;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x17006963 RID: 26979
		// (get) Token: 0x060364D8 RID: 222424 RVA: 0x00F25F78 File Offset: 0x00F24178
		public int AllFishingTechCount
		{
			get
			{
				return FishingConfig.Instance.GetFishingTechList().Count;
			}
		}

		// Token: 0x060364D9 RID: 222425 RVA: 0x00F25F8C File Offset: 0x00F2418C
		public bool GetTechNodeCanLevelUp(int nodeId)
		{
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(nodeId);
			FishingTechInfo fishingTechInfo;
			this.FishingTechDataMap.TryGetValue(nodeId, out fishingTechInfo);
			if (((fishingTechInfo != null) ? fishingTechInfo.Level : 0) >= fishingTechById.EffectLength || !this.GetNodePreNodeUnlock(nodeId))
			{
				return false;
			}
			int techEffectId = fishingTechById.Effect(fishingTechInfo.Level);
			foreach (KeyValuePair<int, int> keyValuePair in FishingConfig.Instance.GetFishingTechEffectById(techEffectId).Consume())
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060364DA RID: 222426 RVA: 0x00F26054 File Offset: 0x00F24254
		public bool GetRoleTechNodeCanLevelUp(EFishingTechNodeType type)
		{
			foreach (KeyValuePair<int, FishingTechInfo> keyValuePair in this.FishingTechDataMap)
			{
				int key = keyValuePair.Key;
				FishingTechInfo value = keyValuePair.Value;
				FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(key);
				if (fishingTechById.Type == (int)type && value.Level < fishingTechById.EffectLength && this.GetNodePreNodeUnlock(key))
				{
					int techEffectId = fishingTechById.Effect(value.Level);
					foreach (KeyValuePair<int, int> keyValuePair2 in FishingConfig.Instance.GetFishingTechEffectById(techEffectId).Consume())
					{
						if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair2.Key, 0) >= keyValuePair2.Value)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060364DB RID: 222427 RVA: 0x00F26168 File Offset: 0x00F24368
		public void RefreshTechCanLevelUp()
		{
			foreach (KeyValuePair<int, FishingTechInfo> keyValuePair in this.FishingTechDataMap)
			{
				int key = keyValuePair.Key;
				FishingTechInfo value = keyValuePair.Value;
				FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(key);
				if (value.Level < fishingTechById.EffectLength && this.GetNodePreNodeUnlock(key))
				{
					int techEffectId = fishingTechById.Effect(value.Level);
					foreach (KeyValuePair<int, int> keyValuePair2 in FishingConfig.Instance.GetFishingTechEffectById(techEffectId).Consume())
					{
						if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair2.Key, 0) >= keyValuePair2.Value)
						{
							EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRedDotRefresh, key);
						}
					}
				}
			}
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.MainRole);
			EventSystem.Instance.Emit<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, EFishingTechNodeType.Phoebe);
		}

		// Token: 0x060364DC RID: 222428 RVA: 0x00F2629C File Offset: 0x00F2449C
		public int GetTechNodeCurrentLevel(int nodeId)
		{
			FishingTechInfo fishingTechInfo;
			this.FishingTechDataMap.TryGetValue(nodeId, out fishingTechInfo);
			if (fishingTechInfo == null)
			{
				return 0;
			}
			return fishingTechInfo.Level;
		}

		// Token: 0x060364DD RID: 222429 RVA: 0x00F262C4 File Offset: 0x00F244C4
		public int GetTechNodeMaxLevel(int nodeId)
		{
			return FishingConfig.Instance.GetFishingTechById(nodeId).EffectLength;
		}

		// Token: 0x060364DE RID: 222430 RVA: 0x00F262E4 File Offset: 0x00F244E4
		[NullableContext(2)]
		public IFishingTechNode GetFirstNode()
		{
			List<IFishingTechNode> list;
			if (!this.NormalTechNodeMap.TryGetValue(0, out list))
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.LJQ, "捕鱼活动获取首科技节点失败，请检查科技树配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return list[0];
		}

		// Token: 0x060364DF RID: 222431 RVA: 0x00F26328 File Offset: 0x00F24528
		[NullableContext(2)]
		public IFishingTechNode GetLastNode()
		{
			List<IFishingTechNode> list;
			if (!this.NormalTechNodeMap.TryGetValue(4, out list))
			{
				Log.Instance.Error(ELogModule.Activity, ELogAuthor.LJQ, "捕鱼活动获取尾科技节点失败，请检查科技树配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return list[0];
		}

		// Token: 0x060364E0 RID: 222432 RVA: 0x00F2636C File Offset: 0x00F2456C
		public IFishingTechNode GetFirstUnlockNode()
		{
			IFishingTechNode result = null;
			foreach (List<IFishingTechNode> list in this.NormalTechNodeMap.Values)
			{
				foreach (IFishingTechNode fishingTechNode in list)
				{
					if (fishingTechNode.NodeType != EFishingTechNodeType.Secondary)
					{
						FishingTechInfo fishingTechInfo;
						this.FishingTechDataMap.TryGetValue(fishingTechNode.ConfigId, out fishingTechInfo);
						if (fishingTechInfo == null || fishingTechInfo.Level <= 0)
						{
							return fishingTechNode;
						}
						result = fishingTechNode;
					}
				}
			}
			return result;
		}

		// Token: 0x060364E1 RID: 222433 RVA: 0x00F2642C File Offset: 0x00F2462C
		[NullableContext(2)]
		public IFishingTechNode GetNormalTechNodeById(int nodeId)
		{
			foreach (List<IFishingTechNode> list in this.NormalTechNodeMap.Values)
			{
				foreach (IFishingTechNode fishingTechNode in list)
				{
					if (fishingTechNode.ConfigId == nodeId)
					{
						return fishingTechNode;
					}
				}
			}
			return null;
		}

		// Token: 0x060364E2 RID: 222434 RVA: 0x00F264C4 File Offset: 0x00F246C4
		[NullableContext(2)]
		public IFishingTechNode GetRoleTechNodeById(int nodeId)
		{
			foreach (List<IFishingTechNode> list in this.RoleTechNodeMap.Values)
			{
				foreach (IFishingTechNode fishingTechNode in list)
				{
					if (fishingTechNode.ConfigId == nodeId)
					{
						return fishingTechNode;
					}
				}
			}
			return null;
		}

		// Token: 0x060364E3 RID: 222435 RVA: 0x00F2655C File Offset: 0x00F2475C
		public bool GetNodePreNodeUnlock(int nodeId)
		{
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(nodeId);
			if (fishingTechById.PreNode != 0)
			{
				return this.GetFishingTechUnlock(fishingTechById.PreNode);
			}
			if (FishingConfig.Instance.GetFishingTechById(nodeId).UnlockCondition <= 0)
			{
				return true;
			}
			FishingTechInfo fishingTechInfo;
			this.FishingTechDataMap.TryGetValue(nodeId, out fishingTechInfo);
			return fishingTechInfo != null && fishingTechInfo.Unlock;
		}

		// Token: 0x060364E4 RID: 222436 RVA: 0x00F265C0 File Offset: 0x00F247C0
		public bool GetNodeLevelUpItemEnough(int nodeId)
		{
			FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(nodeId);
			FishingTechInfo fishingTechInfo;
			this.FishingTechDataMap.TryGetValue(nodeId, out fishingTechInfo);
			int techEffectId;
			if (fishingTechInfo != null && fishingTechInfo.Level == 0)
			{
				techEffectId = fishingTechById.Effect(0);
			}
			else
			{
				techEffectId = fishingTechById.Effect(fishingTechInfo.Level);
			}
			foreach (KeyValuePair<int, int> keyValuePair in FishingConfig.Instance.GetFishingTechEffectById(techEffectId).Consume())
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17006964 RID: 26980
		// (get) Token: 0x060364E5 RID: 222437 RVA: 0x00F26680 File Offset: 0x00F24880
		public bool IsInDock
		{
			get
			{
				return this.DockIdInternal > 0;
			}
		}

		// Token: 0x17006965 RID: 26981
		// (get) Token: 0x060364E6 RID: 222438 RVA: 0x00F2668B File Offset: 0x00F2488B
		// (set) Token: 0x060364E7 RID: 222439 RVA: 0x00F26693 File Offset: 0x00F24893
		public int DockId
		{
			get
			{
				return this.DockIdInternal;
			}
			set
			{
				this.DockIdInternal = value;
				EventSystem.Instance.Emit<int>(EEventName.FishingRefreshDockId, this.DockIdInternal);
			}
		}

		// Token: 0x060364E8 RID: 222440 RVA: 0x00F266B2 File Offset: 0x00F248B2
		public FishingShipData GetShipData()
		{
			return this.ShipData;
		}

		// Token: 0x060364E9 RID: 222441 RVA: 0x00F266BA File Offset: 0x00F248BA
		public void SaveLocalSailingIsFix(bool isAutoFix)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SailingIsFix, isAutoFix);
		}

		// Token: 0x060364EA RID: 222442 RVA: 0x00F266C8 File Offset: 0x00F248C8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"occupyGridCount",
			"maxGridCount"
		})]
		public ValueTuple<int, int> GetShipCapacityInfoTuple(int entityId)
		{
			int backpackUseSize = DockyardModel.Instance.BackpackUseSize;
			int backpackSize = DockyardModel.Instance.BackpackSize;
			return new ValueTuple<int, int>(backpackUseSize, backpackSize);
		}

		// Token: 0x060364EB RID: 222443 RVA: 0x00F266F0 File Offset: 0x00F248F0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"occupyGridCount",
			"maxGridCount"
		})]
		public ValueTuple<int, int> GetShipCageCapacityInfoTuple(int configId)
		{
			DockyardCageData cageDataByConfigId = this.GetCageDataByConfigId(configId);
			if (cageDataByConfigId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Fishing;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[捕鱼系统]->获取笼子容量错误，未找到对应实体的笼子数据。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", configId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new ValueTuple<int, int>(0, 0);
			}
			OneFishCage data = cageDataByConfigId.Data;
			int count = data.Items.Count;
			int maxCount = data.MaxCount;
			return new ValueTuple<int, int>(count, maxCount);
		}

		// Token: 0x060364EC RID: 222444 RVA: 0x00F26760 File Offset: 0x00F24960
		public long GetShipCageNextHarvestTimeStamp(int configId)
		{
			DockyardCageData cageDataByConfigId = this.GetCageDataByConfigId(configId);
			if (cageDataByConfigId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Fishing;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[捕鱼系统]->获取笼子容量错误，未找到对应实体的笼子数据。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", configId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0L;
			}
			return cageDataByConfigId.Data.NextUpdateTime;
		}

		// Token: 0x060364ED RID: 222445 RVA: 0x00F267B8 File Offset: 0x00F249B8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"occupyGridCount",
			"maxGridCount"
		})]
		public ValueTuple<int, int> GetFishingPointCapacityInfoTuple(int entityId)
		{
			FishingPointData fishingPointDataByPbEntityId = this.GetFishingPointDataByPbEntityId(entityId);
			if (fishingPointDataByPbEntityId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Fishing;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[捕鱼系统]->获取捕鱼点容量错误，未找到对应捕鱼点数据。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new ValueTuple<int, int>(0, 0);
			}
			int currentCount = fishingPointDataByPbEntityId.CurrentCount;
			int maxCount = fishingPointDataByPbEntityId.MaxCount;
			return new ValueTuple<int, int>(currentCount, maxCount);
		}

		// Token: 0x060364EE RID: 222446 RVA: 0x00F2681C File Offset: 0x00F24A1C
		public unsafe string GetFishingPointAppearTimeLocalKey(int entityId)
		{
			int showItem = FishingConfig.Instance.GetFishingPointConfigByEntityId(entityId).Value.ShowItem;
			EFishingAppearTimeType time = (EFishingAppearTimeType)FishingConfig.Instance.GetFishingItemConfig(showItem).Value.Time;
			if (time == EFishingAppearTimeType.WholeDay)
			{
				return "Fishing_WholeDay";
			}
			if (time == EFishingAppearTimeType.DayOnly)
			{
				return "Fishing_OnlyDay";
			}
			if (time == EFishingAppearTimeType.NightOnly)
			{
				return "Fishing_OnlyNight";
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Fishing;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[捕鱼系统]->获取鱼点的出没时间文本Key错误。";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("展示道具", showItem);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("出没时间", time);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return string.Empty;
		}

		// Token: 0x060364EF RID: 222447 RVA: 0x00F26904 File Offset: 0x00F24B04
		public string GetFishingPointNameLocalKey(int entityId)
		{
			int showItem = FishingConfig.Instance.GetFishingPointConfigByEntityId(entityId).Value.ShowItem;
			return FishingConfig.Instance.GetFishingItemConfig(showItem).Value.Name;
		}

		// Token: 0x060364F0 RID: 222448 RVA: 0x00F2694C File Offset: 0x00F24B4C
		public string GetFishingPointTechNameLocalKey(int entityId)
		{
			int unlockTech = FishingConfig.Instance.GetFishingPointConfigByEntityId(entityId).Value.UnlockTech;
			return FishingConfig.Instance.GetFishingTagConfig(unlockTech).Value.Name;
		}

		// Token: 0x060364F1 RID: 222449 RVA: 0x00F26994 File Offset: 0x00F24B94
		public bool IsOnShipVehicle()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			return characterDriveVehicleComponent != null && characterDriveVehicleComponent.IsOnVehicle;
		}

		// Token: 0x060364F2 RID: 222450 RVA: 0x00F269D0 File Offset: 0x00F24BD0
		public void SetHandBookData(FishingIllustratedInfo info)
		{
			foreach (OneFishingIllustratedInfo oneFishingIllustratedInfo in info.IllustratedList)
			{
				if (oneFishingIllustratedInfo.Id > 0)
				{
					FishingHandBook value = new FishingHandBook
					{
						Id = oneFishingIllustratedInfo.Id,
						MaxSize = oneFishingIllustratedInfo.MaxSize,
						MinSize = oneFishingIllustratedInfo.MinSize
					};
					this.FishingItemHandBookDataMap[oneFishingIllustratedInfo.Id] = value;
				}
			}
			foreach (FishingIllustratedRewardInfo fishingIllustratedRewardInfo in info.RewardedId)
			{
				FishingReward value2 = new FishingReward
				{
					Id = fishingIllustratedRewardInfo.Id,
					IsFinished = fishingIllustratedRewardInfo.IsFinished,
					IsTaken = fishingIllustratedRewardInfo.IsTaken,
					Current = fishingIllustratedRewardInfo.Current,
					Target = fishingIllustratedRewardInfo.Target
				};
				this.FishingItemHandBookRewardMap[fishingIllustratedRewardInfo.Id] = value2;
			}
			EventSystem.Instance.Emit(EEventName.FishingRefreshHandBookRewardView);
			FishingModel.Instance.FishingItemHandBookUnlockTraceList = new List<int>(info.UnlockDetections);
		}

		// Token: 0x060364F3 RID: 222451 RVA: 0x00F26B14 File Offset: 0x00F24D14
		public void RefreshHandBookData(OneFishingIllustratedInfo data)
		{
			if (data.Id <= 0)
			{
				return;
			}
			FishingHandBook value = new FishingHandBook
			{
				Id = data.Id,
				MaxSize = data.MaxSize,
				MinSize = data.MinSize
			};
			this.FishingItemHandBookDataMap[data.Id] = value;
		}

		// Token: 0x060364F4 RID: 222452 RVA: 0x00F26B68 File Offset: 0x00F24D68
		public List<int> GetFishingItemIdList()
		{
			List<int> list = new List<int>();
			foreach (FishingItem fishingItem in FishingConfig.Instance.GetAllFishingItemConfig())
			{
				if (fishingItem.IllustratedNum > 0)
				{
					list.Add(fishingItem.Id);
				}
			}
			return list;
		}

		// Token: 0x060364F5 RID: 222453 RVA: 0x00F26BD0 File Offset: 0x00F24DD0
		public List<IFishingHandBookItemData> GetFishingItemList()
		{
			List<IFishingHandBookItemData> list = new List<IFishingHandBookItemData>();
			foreach (FishingItem fishingItem in FishingConfig.Instance.GetAllFishingItemConfig())
			{
				if (fishingItem.IllustratedNum > 0)
				{
					FishingHandBookItemData item = new FishingHandBookItemData
					{
						Id = fishingItem.Id,
						Type = fishingItem.Category,
						Area = new List<int>(fishingItem.Area()),
						Tech = new List<int>(fishingItem.Tech()),
						Time = fishingItem.Time,
						HandBookId = fishingItem.IllustratedNum
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x17006966 RID: 26982
		// (get) Token: 0x060364F6 RID: 222454 RVA: 0x00F26C90 File Offset: 0x00F24E90
		public int AllFishingItemCount
		{
			get
			{
				int num = 0;
				foreach (FishingItem fishingItem in FishingConfig.Instance.GetAllFishingItemConfig())
				{
					if (fishingItem.IllustratedNum > 0)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x17006967 RID: 26983
		// (get) Token: 0x060364F7 RID: 222455 RVA: 0x00F26CEC File Offset: 0x00F24EEC
		public int UnLockFishingItemCount
		{
			get
			{
				return this.FishingItemHandBookDataMap.Count;
			}
		}

		// Token: 0x060364F8 RID: 222456 RVA: 0x00F26CFC File Offset: 0x00F24EFC
		public List<EFishingSize> GetSizeIsGoldSize(int itemId)
		{
			List<EFishingSize> list = new List<EFishingSize>();
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(itemId);
			if (fishingItemConfig.Value.SizeWeightLength < 3)
			{
				return list;
			}
			IFishingHandBook fishingHandBook;
			if (!this.FishingItemHandBookDataMap.TryGetValue(itemId, out fishingHandBook))
			{
				return list;
			}
			IntArray? intArray = fishingItemConfig.Value.SizeWeight(0);
			if (fishingHandBook.MinSize <= intArray.Value.ArrayInt(1))
			{
				list.Add(EFishingSize.Silver);
			}
			IntArray? intArray2 = fishingItemConfig.Value.SizeWeight(2);
			if (fishingHandBook.MaxSize >= intArray2.Value.ArrayInt(0))
			{
				list.Add(EFishingSize.Golden);
			}
			return list;
		}

		// Token: 0x060364F9 RID: 222457 RVA: 0x00F26DA8 File Offset: 0x00F24FA8
		public int GetHandBookRewardHaveTakenCount()
		{
			int num = 0;
			using (Dictionary<int, IFishingReward>.ValueCollection.Enumerator enumerator = this.FishingItemHandBookRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsTaken)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060364FA RID: 222458 RVA: 0x00F26E08 File Offset: 0x00F25008
		public void RefreshHandBookDataReward(FishingIllustratedRewardInfo data)
		{
			FishingReward value = new FishingReward
			{
				Id = data.Id,
				IsFinished = data.IsFinished,
				IsTaken = data.IsTaken,
				Current = data.Current,
				Target = data.Target
			};
			this.FishingItemHandBookRewardMap[data.Id] = value;
			EventSystem.Instance.Emit(EEventName.FishingRefreshHandBookRewardView);
		}

		// Token: 0x060364FB RID: 222459 RVA: 0x00F26E7C File Offset: 0x00F2507C
		public bool GetHandBookRewardRedDotState()
		{
			foreach (IFishingReward fishingReward in this.FishingItemHandBookRewardMap.Values)
			{
				if (fishingReward.IsFinished && !fishingReward.IsTaken)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060364FC RID: 222460 RVA: 0x00F26EE4 File Offset: 0x00F250E4
		public bool IsAllHandBookRewardTaken()
		{
			using (Dictionary<int, IFishingReward>.ValueCollection.Enumerator enumerator = this.FishingItemHandBookRewardMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsTaken)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x17006968 RID: 26984
		// (get) Token: 0x060364FD RID: 222461 RVA: 0x00F26F44 File Offset: 0x00F25144
		public static FishingModel Instance
		{
			get
			{
				return FishingModel._Instance;
			}
		}

		// Token: 0x060364FE RID: 222462 RVA: 0x00F26F4B File Offset: 0x00F2514B
		public static FishingModel GetOrCreateInstance()
		{
			if (FishingModel._Instance == null)
			{
				FishingModel.CreateInstance();
			}
			return FishingModel._Instance;
		}

		// Token: 0x060364FF RID: 222463 RVA: 0x00F26F5F File Offset: 0x00F2515F
		public static bool CreateInstance()
		{
			if (FishingModel._Instance != null)
			{
				return true;
			}
			FishingModel._Instance = new FishingModel();
			return true;
		}

		// Token: 0x06036500 RID: 222464 RVA: 0x00F26F75 File Offset: 0x00F25175
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036501 RID: 222465 RVA: 0x00F26F77 File Offset: 0x00F25177
		public static void ResetStaticDefaultValue()
		{
			FishingModel._Instance = null;
		}

		// Token: 0x06036502 RID: 222466 RVA: 0x00F26F7F File Offset: 0x00F2517F
		static FishingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingModel.CreateStaticDefaultValue), new Action(FishingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CA81 RID: 117377
		public int FishingReputationItemId;

		// Token: 0x0401CA82 RID: 117378
		public int FishingShipFixItem;

		// Token: 0x0401CA83 RID: 117379
		public int FishingShipFixCost;

		// Token: 0x0401CA84 RID: 117380
		public Dictionary<int, List<IFishingTechNode>> NormalTechNodeMap = new Dictionary<int, List<IFishingTechNode>>();

		// Token: 0x0401CA85 RID: 117381
		public Dictionary<int, List<IFishingTechNode>> RoleTechNodeMap = new Dictionary<int, List<IFishingTechNode>>();

		// Token: 0x0401CA86 RID: 117382
		[Nullable(2)]
		private FishingLevelUpData LastFishingLevelUpDataInternal;

		// Token: 0x0401CA87 RID: 117383
		public int FishingSlotCountTech;

		// Token: 0x0401CA88 RID: 117384
		public int FishingBagRedPercentage;

		// Token: 0x0401CA89 RID: 117385
		private Dictionary<int, Dictionary<int, DockyardCageData>> CageDataMapMap = new Dictionary<int, Dictionary<int, DockyardCageData>>();

		// Token: 0x0401CA8A RID: 117386
		private Dictionary<int, Dictionary<int, DockyardItemBlockOriginalData>> InteractDataMapMap = new Dictionary<int, Dictionary<int, DockyardItemBlockOriginalData>>();

		// Token: 0x0401CA8B RID: 117387
		private Dictionary<int, FishingPointData> FishingPointDataPbEntityIdMap = new Dictionary<int, FishingPointData>();

		// Token: 0x0401CA8C RID: 117388
		private Dictionary<int, HashSet<int>> FishingPointSceneId2PbEntityId = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CA8D RID: 117389
		private Dictionary<int, int> FishingPointId2EntityId = new Dictionary<int, int>();

		// Token: 0x0401CA8E RID: 117390
		private int TempFishingPointLimit;

		// Token: 0x0401CA8F RID: 117391
		private Dictionary<long, TempFishingPointData> TempFishingPointDataMap = new Dictionary<long, TempFishingPointData>();

		// Token: 0x0401CA90 RID: 117392
		private Dictionary<int, FishingTechInfo> FishingTechDataMap = new Dictionary<int, FishingTechInfo>();

		// Token: 0x0401CA91 RID: 117393
		private HashSet<int> NeedCheckEffectType = new HashSet<int>(new int[]
		{
			11,
			10
		});

		// Token: 0x0401CA92 RID: 117394
		public Dictionary<int, HashSet<int>> EffectType2TechIdsMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CA93 RID: 117395
		private int DockIdInternal;

		// Token: 0x0401CA94 RID: 117396
		private FishingShipData ShipData = new FishingShipData();

		// Token: 0x0401CA95 RID: 117397
		public ESailTime LocalSailingTime;

		// Token: 0x0401CA96 RID: 117398
		public Dictionary<int, IFishingHandBook> FishingItemHandBookDataMap = new Dictionary<int, IFishingHandBook>();

		// Token: 0x0401CA97 RID: 117399
		public Dictionary<int, IFishingReward> FishingItemHandBookRewardMap = new Dictionary<int, IFishingReward>();

		// Token: 0x0401CA98 RID: 117400
		public List<int> FishingItemHandBookUnlockTraceList = new List<int>();

		// Token: 0x0401CA99 RID: 117401
		public List<int> RoleTalkIds;

		// Token: 0x0401CA9A RID: 117402
		public List<int> UnlockPort = new List<int>();

		// Token: 0x0401CA9B RID: 117403
		public int CurrentShipSkin;

		// Token: 0x0401CA9C RID: 117404
		public List<int> UnlockShipSkin = new List<int>();

		// Token: 0x0401CA9D RID: 117405
		[Nullable(2)]
		private static FishingModel _Instance;
	}
}
