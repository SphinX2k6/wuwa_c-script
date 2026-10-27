using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006618 RID: 26136
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FishingModel : ModelBase
	{
		// Token: 0x060417EB RID: 268267 RVA: 0x00FDE07B File Offset: 0x00FDC27B
		public void SetFishingLevelUpInfo(FishingLevelUpData data)
		{
			if (this.LastFishingLevelUpDataInternal == null)
			{
				this.LastFishingLevelUpDataInternal = data;
				return;
			}
			this.LastFishingLevelUpDataInternal.CurrentLevel = data.CurrentLevel;
		}

		// Token: 0x060417EC RID: 268268 RVA: 0x00FDE09E File Offset: 0x00FDC29E
		[NullableContext(2)]
		public FishingLevelUpData GetFishingLevelUpInfo()
		{
			return this.LastFishingLevelUpDataInternal;
		}

		// Token: 0x060417ED RID: 268269 RVA: 0x00FDE0A6 File Offset: 0x00FDC2A6
		public void ClearLastFishingExp()
		{
			this.LastFishingLevelUpDataInternal = null;
		}

		// Token: 0x060417EE RID: 268270 RVA: 0x00FDE0B0 File Offset: 0x00FDC2B0
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

		// Token: 0x060417EF RID: 268271 RVA: 0x00FDE154 File Offset: 0x00FDC354
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

		// Token: 0x060417F0 RID: 268272 RVA: 0x00FDE2AC File Offset: 0x00FDC4AC
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

		// Token: 0x060417F1 RID: 268273 RVA: 0x00FDE318 File Offset: 0x00FDC518
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

		// Token: 0x060417F2 RID: 268274 RVA: 0x00FDE378 File Offset: 0x00FDC578
		private void SetCageData(int sceneId, List<OneFishCage> cages)
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

		// Token: 0x060417F3 RID: 268275 RVA: 0x00FDE3F8 File Offset: 0x00FDC5F8
		public void SetCageDataMapFromServer(Dictionary<int, SceneFishCageInfo> dataMap)
		{
			this.CageDataMapMap.Clear();
			foreach (int num in dataMap.Keys)
			{
				RepeatedField<OneFishCage> cages = dataMap[num].Cages;
				this.SetCageData(num, cages.ToList<OneFishCage>());
			}
		}

		// Token: 0x060417F4 RID: 268276 RVA: 0x00FDE46C File Offset: 0x00FDC66C
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

		// Token: 0x060417F5 RID: 268277 RVA: 0x00FDE4B0 File Offset: 0x00FDC6B0
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

		// Token: 0x060417F6 RID: 268278 RVA: 0x00FDE4D4 File Offset: 0x00FDC6D4
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

		// Token: 0x060417F7 RID: 268279 RVA: 0x00FDE520 File Offset: 0x00FDC720
		public List<DockyardItemBlockOriginalData> GetCageDataList(int entityId)
		{
			DockyardCageData cageDataByConfigId = this.GetCageDataByConfigId(entityId);
			if (cageDataByConfigId == null)
			{
				return new List<DockyardItemBlockOriginalData>();
			}
			return cageDataByConfigId.GetDataList();
		}

		// Token: 0x060417F8 RID: 268280 RVA: 0x00FDE544 File Offset: 0x00FDC744
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

		// Token: 0x060417F9 RID: 268281 RVA: 0x00FDE5CC File Offset: 0x00FDC7CC
		public void SetInteractData(List<HandInInfo> dataList)
		{
			foreach (HandInInfo data in dataList)
			{
				this.CreateInteractData(data);
			}
		}

		// Token: 0x060417FA RID: 268282 RVA: 0x00FDE61C File Offset: 0x00FDC81C
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

		// Token: 0x060417FB RID: 268283 RVA: 0x00FDE6A8 File Offset: 0x00FDC8A8
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

		// Token: 0x060417FC RID: 268284 RVA: 0x00FDE6D8 File Offset: 0x00FDC8D8
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

		// Token: 0x060417FD RID: 268285 RVA: 0x00FDE6F8 File Offset: 0x00FDC8F8
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

		// Token: 0x060417FE RID: 268286 RVA: 0x00FDE80C File Offset: 0x00FDCA0C
		private void ClearAllFishingPointData()
		{
			this.FishingPointDataPbEntityIdMap.Clear();
			this.FishingPointSceneId2PbEntityId.Clear();
			this.FishingPointId2EntityId.Clear();
			this.TempFishingPointDataMap.Clear();
		}

		// Token: 0x060417FF RID: 268287 RVA: 0x00FDE83C File Offset: 0x00FDCA3C
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

		// Token: 0x06041800 RID: 268288 RVA: 0x00FDE878 File Offset: 0x00FDCA78
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

		// Token: 0x06041801 RID: 268289 RVA: 0x00FDE8E0 File Offset: 0x00FDCAE0
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

		// Token: 0x06041802 RID: 268290 RVA: 0x00FDE94C File Offset: 0x00FDCB4C
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

		// Token: 0x06041803 RID: 268291 RVA: 0x00FDE988 File Offset: 0x00FDCB88
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

		// Token: 0x06041804 RID: 268292 RVA: 0x00FDE9BC File Offset: 0x00FDCBBC
		public int GetFishingPointEntityIdByConfigId(int configId)
		{
			int result;
			if (this.FishingPointId2EntityId.TryGetValue(configId, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06041805 RID: 268293 RVA: 0x00FDE9DC File Offset: 0x00FDCBDC
		public bool GetFishingPointHaveFinishingIdByConfigId(int configId)
		{
			int key;
			FishingPointData fishingPointData;
			return !this.FishingPointId2EntityId.TryGetValue(configId, out key) || !this.FishingPointDataPbEntityIdMap.TryGetValue(key, out fishingPointData) || fishingPointData.CurrentCount <= 0;
		}

		// Token: 0x06041806 RID: 268294 RVA: 0x00FDEA1C File Offset: 0x00FDCC1C
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

		// Token: 0x06041807 RID: 268295 RVA: 0x00FDEA3C File Offset: 0x00FDCC3C
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

		// Token: 0x06041808 RID: 268296 RVA: 0x00FDEAB4 File Offset: 0x00FDCCB4
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

		// Token: 0x06041809 RID: 268297 RVA: 0x00FDEAFC File Offset: 0x00FDCCFC
		public void RemoveTempFishingPointData(TempFishPointInfo fishPoint)
		{
			long entityId = fishPoint.EntityId;
			this.TempFishingPointDataMap.Remove(entityId);
		}

		// Token: 0x0604180A RID: 268298 RVA: 0x00FDEB20 File Offset: 0x00FDCD20
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

		// Token: 0x0604180B RID: 268299 RVA: 0x00FDEB40 File Offset: 0x00FDCD40
		public int GetTempFishingPointLimit()
		{
			return this.TempFishingPointLimit;
		}

		// Token: 0x0604180C RID: 268300 RVA: 0x00FDEB48 File Offset: 0x00FDCD48
		public int GetTempFishingPointNum()
		{
			return this.TempFishingPointDataMap.Count;
		}

		// Token: 0x0604180D RID: 268301 RVA: 0x00FDEB58 File Offset: 0x00FDCD58
		public void SetFishingTechData(List<FishingTechInfo> dataList)
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

		// Token: 0x0604180E RID: 268302 RVA: 0x00FDECB8 File Offset: 0x00FDCEB8
		public void UpdateFishingTechData(FishingTechInfo data)
		{
			this.FishingTechDataMap[data.NodeId] = data;
			EventSystem.Instance.Emit<int>(EEventName.OnFishingTechNodeRefresh, data.NodeId);
		}

		// Token: 0x0604180F RID: 268303 RVA: 0x00FDECE4 File Offset: 0x00FDCEE4
		public bool GetFishingTechUnlock(int techId)
		{
			FishingTechInfo valueOrDefault = this.FishingTechDataMap.GetValueOrDefault(techId);
			return (FishingConfig.Instance.GetFishingTechById(techId).UnlockCondition <= 0 || (valueOrDefault != null && valueOrDefault.Unlock)) && ((valueOrDefault != null) ? valueOrDefault.Level : 0) > 0;
		}

		// Token: 0x06041810 RID: 268304 RVA: 0x00FDED38 File Offset: 0x00FDCF38
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
				if (fishingTech.Effect().Contains(id))
				{
					return this.GetFishingTechUnlock(fishingTech.Id);
				}
			}
			return false;
		}

		// Token: 0x06041811 RID: 268305 RVA: 0x00FDEDD8 File Offset: 0x00FDCFD8
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
				if (fishingTech.Effect().Contains(id))
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

		// Token: 0x17009600 RID: 38400
		// (get) Token: 0x06041812 RID: 268306 RVA: 0x00FDEEA4 File Offset: 0x00FDD0A4
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

		// Token: 0x17009601 RID: 38401
		// (get) Token: 0x06041813 RID: 268307 RVA: 0x00FDEF04 File Offset: 0x00FDD104
		public int AllFishingTechCount
		{
			get
			{
				return FishingConfig.Instance.GetFishingTechList().Count;
			}
		}

		// Token: 0x06041814 RID: 268308 RVA: 0x00FDEF18 File Offset: 0x00FDD118
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

		// Token: 0x06041815 RID: 268309 RVA: 0x00FDEFE0 File Offset: 0x00FDD1E0
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

		// Token: 0x06041816 RID: 268310 RVA: 0x00FDF0F4 File Offset: 0x00FDD2F4
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

		// Token: 0x06041817 RID: 268311 RVA: 0x00FDF228 File Offset: 0x00FDD428
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

		// Token: 0x06041818 RID: 268312 RVA: 0x00FDF250 File Offset: 0x00FDD450
		public int GetTechNodeMaxLevel(int nodeId)
		{
			return FishingConfig.Instance.GetFishingTechById(nodeId).EffectLength;
		}

		// Token: 0x06041819 RID: 268313 RVA: 0x00FDF270 File Offset: 0x00FDD470
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

		// Token: 0x0604181A RID: 268314 RVA: 0x00FDF2B4 File Offset: 0x00FDD4B4
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

		// Token: 0x0604181B RID: 268315 RVA: 0x00FDF2F8 File Offset: 0x00FDD4F8
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

		// Token: 0x0604181C RID: 268316 RVA: 0x00FDF3B8 File Offset: 0x00FDD5B8
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

		// Token: 0x0604181D RID: 268317 RVA: 0x00FDF450 File Offset: 0x00FDD650
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

		// Token: 0x0604181E RID: 268318 RVA: 0x00FDF4E8 File Offset: 0x00FDD6E8
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

		// Token: 0x0604181F RID: 268319 RVA: 0x00FDF54C File Offset: 0x00FDD74C
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

		// Token: 0x17009602 RID: 38402
		// (get) Token: 0x06041820 RID: 268320 RVA: 0x00FDF60C File Offset: 0x00FDD80C
		public bool IsInDock
		{
			get
			{
				return this.DockIdInternal > 0;
			}
		}

		// Token: 0x17009603 RID: 38403
		// (get) Token: 0x06041821 RID: 268321 RVA: 0x00FDF617 File Offset: 0x00FDD817
		// (set) Token: 0x06041822 RID: 268322 RVA: 0x00FDF61F File Offset: 0x00FDD81F
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

		// Token: 0x06041823 RID: 268323 RVA: 0x00FDF63E File Offset: 0x00FDD83E
		public FishingShipData GetShipData()
		{
			return this.ShipData;
		}

		// Token: 0x06041824 RID: 268324 RVA: 0x00FDF646 File Offset: 0x00FDD846
		public void SaveLocalSailingIsFix(bool isAutoFix)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SailingIsFix, isAutoFix);
		}

		// Token: 0x06041825 RID: 268325 RVA: 0x00FDF654 File Offset: 0x00FDD854
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

		// Token: 0x06041826 RID: 268326 RVA: 0x00FDF67C File Offset: 0x00FDD87C
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

		// Token: 0x06041827 RID: 268327 RVA: 0x00FDF6EC File Offset: 0x00FDD8EC
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

		// Token: 0x06041828 RID: 268328 RVA: 0x00FDF744 File Offset: 0x00FDD944
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

		// Token: 0x06041829 RID: 268329 RVA: 0x00FDF7A8 File Offset: 0x00FDD9A8
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

		// Token: 0x0604182A RID: 268330 RVA: 0x00FDF890 File Offset: 0x00FDDA90
		public string GetFishingPointNameLocalKey(int entityId)
		{
			int showItem = FishingConfig.Instance.GetFishingPointConfigByEntityId(entityId).Value.ShowItem;
			return FishingConfig.Instance.GetFishingItemConfig(showItem).Value.Name;
		}

		// Token: 0x0604182B RID: 268331 RVA: 0x00FDF8D8 File Offset: 0x00FDDAD8
		public string GetFishingPointTechNameLocalKey(int entityId)
		{
			int unlockTech = FishingConfig.Instance.GetFishingPointConfigByEntityId(entityId).Value.UnlockTech;
			return FishingConfig.Instance.GetFishingTagConfig(unlockTech).Value.Name;
		}

		// Token: 0x0604182C RID: 268332 RVA: 0x00FDF920 File Offset: 0x00FDDB20
		public bool IsOnShipVehicle()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			return characterDriveVehicleComponent != null && characterDriveVehicleComponent.IsOnVehicle;
		}

		// Token: 0x0604182D RID: 268333 RVA: 0x00FDF95C File Offset: 0x00FDDB5C
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
			FishingModel.Instance.FishingItemHandBookUnlockTraceList = info.UnlockDetections.ToList<int>();
		}

		// Token: 0x0604182E RID: 268334 RVA: 0x00FDFAA0 File Offset: 0x00FDDCA0
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

		// Token: 0x0604182F RID: 268335 RVA: 0x00FDFAF4 File Offset: 0x00FDDCF4
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

		// Token: 0x06041830 RID: 268336 RVA: 0x00FDFB5C File Offset: 0x00FDDD5C
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
						Area = fishingItem.Area().ToList<int>(),
						Tech = fishingItem.Tech().ToList<int>(),
						Time = fishingItem.Time,
						HandBookId = fishingItem.IllustratedNum
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x17009604 RID: 38404
		// (get) Token: 0x06041831 RID: 268337 RVA: 0x00FDFC1C File Offset: 0x00FDDE1C
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

		// Token: 0x17009605 RID: 38405
		// (get) Token: 0x06041832 RID: 268338 RVA: 0x00FDFC78 File Offset: 0x00FDDE78
		public int UnLockFishingItemCount
		{
			get
			{
				return this.FishingItemHandBookDataMap.Count;
			}
		}

		// Token: 0x06041833 RID: 268339 RVA: 0x00FDFC88 File Offset: 0x00FDDE88
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

		// Token: 0x06041834 RID: 268340 RVA: 0x00FDFD34 File Offset: 0x00FDDF34
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

		// Token: 0x06041835 RID: 268341 RVA: 0x00FDFD94 File Offset: 0x00FDDF94
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

		// Token: 0x06041836 RID: 268342 RVA: 0x00FDFE08 File Offset: 0x00FDE008
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

		// Token: 0x06041837 RID: 268343 RVA: 0x00FDFE70 File Offset: 0x00FDE070
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

		// Token: 0x17009606 RID: 38406
		// (get) Token: 0x06041838 RID: 268344 RVA: 0x00FDFED0 File Offset: 0x00FDE0D0
		public static FishingModel Instance
		{
			get
			{
				return FishingModel._Instance;
			}
		}

		// Token: 0x06041839 RID: 268345 RVA: 0x00FDFED7 File Offset: 0x00FDE0D7
		public static FishingModel GetOrCreateInstance()
		{
			if (FishingModel._Instance == null)
			{
				FishingModel.CreateInstance();
			}
			return FishingModel._Instance;
		}

		// Token: 0x0604183A RID: 268346 RVA: 0x00FDFEEB File Offset: 0x00FDE0EB
		public static bool CreateInstance()
		{
			if (FishingModel._Instance != null)
			{
				return true;
			}
			FishingModel._Instance = new FishingModel();
			return true;
		}

		// Token: 0x0604183B RID: 268347 RVA: 0x00FDFF01 File Offset: 0x00FDE101
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604183C RID: 268348 RVA: 0x00FDFF03 File Offset: 0x00FDE103
		public static void ResetStaticDefaultValue()
		{
			FishingModel._Instance = null;
		}

		// Token: 0x0604183D RID: 268349 RVA: 0x00FDFF0B File Offset: 0x00FDE10B
		static FishingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingModel.CreateStaticDefaultValue), new Action(FishingModel.ResetStaticDefaultValue));
		}

		// Token: 0x04022150 RID: 139600
		public int FishingReputationItemId;

		// Token: 0x04022151 RID: 139601
		public int FishingShipFixItem;

		// Token: 0x04022152 RID: 139602
		public int FishingShipFixCost;

		// Token: 0x04022153 RID: 139603
		public Dictionary<int, List<IFishingTechNode>> NormalTechNodeMap = new Dictionary<int, List<IFishingTechNode>>();

		// Token: 0x04022154 RID: 139604
		public Dictionary<int, List<IFishingTechNode>> RoleTechNodeMap = new Dictionary<int, List<IFishingTechNode>>();

		// Token: 0x04022155 RID: 139605
		[Nullable(2)]
		private FishingLevelUpData LastFishingLevelUpDataInternal;

		// Token: 0x04022156 RID: 139606
		public int FishingSlotCountTech;

		// Token: 0x04022157 RID: 139607
		public int FishingBagRedPercentage;

		// Token: 0x04022158 RID: 139608
		private Dictionary<int, Dictionary<int, DockyardCageData>> CageDataMapMap = new Dictionary<int, Dictionary<int, DockyardCageData>>();

		// Token: 0x04022159 RID: 139609
		private Dictionary<int, Dictionary<int, DockyardItemBlockOriginalData>> InteractDataMapMap = new Dictionary<int, Dictionary<int, DockyardItemBlockOriginalData>>();

		// Token: 0x0402215A RID: 139610
		private Dictionary<int, FishingPointData> FishingPointDataPbEntityIdMap = new Dictionary<int, FishingPointData>();

		// Token: 0x0402215B RID: 139611
		private Dictionary<int, HashSet<int>> FishingPointSceneId2PbEntityId = new Dictionary<int, HashSet<int>>();

		// Token: 0x0402215C RID: 139612
		private Dictionary<int, int> FishingPointId2EntityId = new Dictionary<int, int>();

		// Token: 0x0402215D RID: 139613
		private int TempFishingPointLimit;

		// Token: 0x0402215E RID: 139614
		private Dictionary<long, TempFishingPointData> TempFishingPointDataMap = new Dictionary<long, TempFishingPointData>();

		// Token: 0x0402215F RID: 139615
		private Dictionary<int, FishingTechInfo> FishingTechDataMap = new Dictionary<int, FishingTechInfo>();

		// Token: 0x04022160 RID: 139616
		private HashSet<int> NeedCheckEffectType = new HashSet<int>(new int[]
		{
			11,
			10
		});

		// Token: 0x04022161 RID: 139617
		public Dictionary<int, HashSet<int>> EffectType2TechIdsMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04022162 RID: 139618
		private int DockIdInternal;

		// Token: 0x04022163 RID: 139619
		private FishingShipData ShipData = new FishingShipData();

		// Token: 0x04022164 RID: 139620
		public ESailTime LocalSailingTime;

		// Token: 0x04022165 RID: 139621
		public Dictionary<int, IFishingHandBook> FishingItemHandBookDataMap = new Dictionary<int, IFishingHandBook>();

		// Token: 0x04022166 RID: 139622
		public Dictionary<int, IFishingReward> FishingItemHandBookRewardMap = new Dictionary<int, IFishingReward>();

		// Token: 0x04022167 RID: 139623
		public List<int> FishingItemHandBookUnlockTraceList = new List<int>();

		// Token: 0x04022168 RID: 139624
		public List<int> RoleTalkIds;

		// Token: 0x04022169 RID: 139625
		public List<int> UnlockPort = new List<int>();

		// Token: 0x0402216A RID: 139626
		public int CurrentShipSkin;

		// Token: 0x0402216B RID: 139627
		public List<int> UnlockShipSkin = new List<int>();

		// Token: 0x0402216C RID: 139628
		[Nullable(2)]
		private static FishingModel _Instance;
	}
}
