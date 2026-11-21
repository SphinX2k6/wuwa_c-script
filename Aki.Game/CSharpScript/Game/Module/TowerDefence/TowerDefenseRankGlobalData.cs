using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AC0 RID: 15040
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankGlobalData
	{
		// Token: 0x17004EFB RID: 20219
		// (get) Token: 0x06026A50 RID: 158288 RVA: 0x00AD3192 File Offset: 0x00AD1392
		public bool IsOpenAnonymousName
		{
			get
			{
				return this.IsOpenAnonymousNameInternal;
			}
		}

		// Token: 0x06026A51 RID: 158289 RVA: 0x00AD319A File Offset: 0x00AD139A
		public void SetIsOpenAnonymousName(bool isOpen)
		{
			this.IsOpenAnonymousNameInternal = isOpen;
		}

		// Token: 0x06026A52 RID: 158290 RVA: 0x00AD31A3 File Offset: 0x00AD13A3
		private int SortNormalPassData(TowerDefenseRankItemData aData, TowerDefenseRankItemData bData)
		{
			return bData.PassScore - aData.PassScore;
		}

		// Token: 0x06026A53 RID: 158291 RVA: 0x00AD31B2 File Offset: 0x00AD13B2
		private int SortDifficultPassData(TowerDefenseRankItemData aData, TowerDefenseRankItemData bData)
		{
			return aData.PassScore - bData.PassScore;
		}

		// Token: 0x06026A54 RID: 158292 RVA: 0x00AD31C4 File Offset: 0x00AD13C4
		private void RefreshPassDataRank(int instanceId, List<TowerDefenseRankItemData> allDataList, List<TowerDefenseRankItemData> refDataList)
		{
			TowerDefenceInstance? towerDefenseInstanceByInstance = InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId);
			Comparison<TowerDefenseRankItemData> comparison = towerDefenseInstanceByInstance.Value.IsDifficult ? new Comparison<TowerDefenseRankItemData>(this.SortDifficultPassData) : new Comparison<TowerDefenseRankItemData>(this.SortNormalPassData);
			refDataList.Clear();
			int towerDefenseRankListSize = InstanceDungeonConfig.Instance.GetTowerDefenseRankListSize();
			allDataList.Sort(comparison);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			while (num3 < allDataList.Count && num3 < towerDefenseRankListSize)
			{
				TowerDefenseRankItemData towerDefenseRankItemData = allDataList[num3];
				if (!towerDefenseRankItemData.IsEmpty)
				{
					if (num3 == 0)
					{
						num++;
						num2 = towerDefenseRankItemData.PassScore;
					}
					else if (towerDefenseInstanceByInstance.Value.IsDifficult ? (towerDefenseRankItemData.PassScore > num2) : (towerDefenseRankItemData.PassScore < num2))
					{
						num++;
						num2 = towerDefenseRankItemData.PassScore;
					}
					towerDefenseRankItemData.Rank = num;
					refDataList.Add(towerDefenseRankItemData);
				}
				num3++;
			}
		}

		// Token: 0x06026A55 RID: 158293 RVA: 0x00AD32B8 File Offset: 0x00AD14B8
		private TowerDefenseRankItemData CreateOwnSinglePassData(int instanceId)
		{
			TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(false, InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId).Value.IsDifficult, TowerDefencePassInfo.Create());
			this.SetSelfSinglePassData(towerDefenseRankItemData, instanceId);
			return towerDefenseRankItemData;
		}

		// Token: 0x06026A56 RID: 158294 RVA: 0x00AD32F8 File Offset: 0x00AD14F8
		private TowerDefenseRankItemData CreateOwnMultiPassData(int instanceId)
		{
			TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(true, InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId).Value.IsDifficult, TowerDefencePassInfo.Create());
			this.SetSelfMultiPassData(towerDefenseRankItemData, instanceId);
			return towerDefenseRankItemData;
		}

		// Token: 0x06026A57 RID: 158295 RVA: 0x00AD3338 File Offset: 0x00AD1538
		private void RefreshOwnPassData(int instanceId)
		{
			TowerDefenseRankItemData towerDefenseRankItemData;
			if (!this.AllOwnSinglePassDataMap.TryGetValue(instanceId, out towerDefenseRankItemData))
			{
				towerDefenseRankItemData = this.CreateOwnSinglePassData(instanceId);
			}
			this.OwnSinglePassData = towerDefenseRankItemData;
			this.OwnSinglePassData.IsInRank = this.SinglePassDataList.Contains(towerDefenseRankItemData);
			TowerDefenseRankItemData towerDefenseRankItemData2;
			if (!this.AllOwnMultiPassData.TryGetValue(instanceId, out towerDefenseRankItemData2))
			{
				towerDefenseRankItemData2 = this.CreateOwnMultiPassData(instanceId);
			}
			this.OwnMultiPassData = towerDefenseRankItemData2;
			this.OwnMultiPassData.IsInRank = this.MultiPassDataList.Contains(towerDefenseRankItemData2);
		}

		// Token: 0x06026A58 RID: 158296 RVA: 0x00AD33B4 File Offset: 0x00AD15B4
		private List<TowerDefenseRankItemData> GetOrAddSinglePassData(int instanceId)
		{
			List<TowerDefenseRankItemData> list;
			if (!this.AllSinglePassDataMap.TryGetValue(instanceId, out list))
			{
				list = new List<TowerDefenseRankItemData>();
				this.AllSinglePassDataMap.Add(instanceId, list);
			}
			return list;
		}

		// Token: 0x06026A59 RID: 158297 RVA: 0x00AD33E8 File Offset: 0x00AD15E8
		private List<TowerDefenseRankItemData> GetOrAddMultiPassData(int instanceId)
		{
			List<TowerDefenseRankItemData> list;
			if (!this.AllMultiPassDataMap.TryGetValue(instanceId, out list))
			{
				list = new List<TowerDefenseRankItemData>();
				this.AllMultiPassDataMap.Add(instanceId, list);
			}
			return list;
		}

		// Token: 0x06026A5A RID: 158298 RVA: 0x00AD3419 File Offset: 0x00AD1619
		public void RefreshAllPassDataRank(int instanceId)
		{
			this.RefreshPassDataRank(instanceId, this.GetOrAddSinglePassData(instanceId), this.SinglePassDataList);
			this.RefreshPassDataRank(instanceId, this.GetOrAddMultiPassData(instanceId), this.MultiPassDataList);
			this.RefreshOwnPassData(instanceId);
			this.RefreshSelfRankItemDataName(instanceId);
		}

		// Token: 0x06026A5B RID: 158299 RVA: 0x00AD3454 File Offset: 0x00AD1654
		public void SetFriendServerData(IReadOnlyList<OneTowerDefencePassInfo> friendPassDataList)
		{
			this.AllSinglePassDataMap.Clear();
			this.AllMultiPassDataMap.Clear();
			if (friendPassDataList.Count > 0)
			{
				foreach (OneTowerDefencePassInfo oneTowerDefencePassInfo in friendPassDataList)
				{
					TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(oneTowerDefencePassInfo.ChallengeId);
					TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(!oneTowerDefencePassInfo.IsSingle, towerDefenseConfigById.Value.IsDifficult, oneTowerDefencePassInfo.PassInfo);
					if (!towerDefenseRankItemData.IsSelfInData)
					{
						if (towerDefenseRankItemData.IsOnline)
						{
							this.GetOrAddMultiPassData(towerDefenseConfigById.Value.InstanceId).Add(towerDefenseRankItemData);
						}
						else
						{
							this.GetOrAddSinglePassData(towerDefenseConfigById.Value.InstanceId).Add(towerDefenseRankItemData);
						}
					}
				}
			}
		}

		// Token: 0x06026A5C RID: 158300 RVA: 0x00AD3540 File Offset: 0x00AD1740
		private void RemoveAllSelfPassData(Dictionary<int, List<TowerDefenseRankItemData>> dataMap)
		{
			foreach (KeyValuePair<int, List<TowerDefenseRankItemData>> keyValuePair in dataMap)
			{
				List<TowerDefenseRankItemData> value = keyValuePair.Value;
				for (int i = value.Count - 1; i >= 0; i--)
				{
					if (value[i].IsSelfInData)
					{
						value.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x06026A5D RID: 158301 RVA: 0x00AD35B8 File Offset: 0x00AD17B8
		private void SetSelfSinglePassData(TowerDefenseRankItemData itemData, int instanceId)
		{
			itemData.IsSelf = true;
			this.AllOwnSinglePassDataMap[instanceId] = itemData;
		}

		// Token: 0x06026A5E RID: 158302 RVA: 0x00AD35CE File Offset: 0x00AD17CE
		private void SetSelfMultiPassData(TowerDefenseRankItemData itemData, int instanceId)
		{
			itemData.IsSelf = true;
			this.AllOwnMultiPassData[instanceId] = itemData;
		}

		// Token: 0x06026A5F RID: 158303 RVA: 0x00AD35E4 File Offset: 0x00AD17E4
		public void SetSelfServerData(IReadOnlyList<OneTowerDefencePassInfo> selfPassDataList)
		{
			this.RemoveAllSelfPassData(this.AllSinglePassDataMap);
			this.RemoveAllSelfPassData(this.AllMultiPassDataMap);
			if (selfPassDataList.Count > 0)
			{
				foreach (OneTowerDefencePassInfo oneTowerDefencePassInfo in selfPassDataList)
				{
					TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(oneTowerDefencePassInfo.ChallengeId);
					TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(!oneTowerDefencePassInfo.IsSingle, towerDefenseConfigById.Value.IsDifficult, oneTowerDefencePassInfo.PassInfo);
					if (towerDefenseRankItemData.IsOnline)
					{
						this.SetSelfMultiPassData(towerDefenseRankItemData, towerDefenseConfigById.Value.InstanceId);
						List<TowerDefenseRankItemData> orAddMultiPassData = this.GetOrAddMultiPassData(towerDefenseConfigById.Value.InstanceId);
						if (orAddMultiPassData != null)
						{
							orAddMultiPassData.Add(towerDefenseRankItemData);
						}
					}
					else
					{
						this.SetSelfSinglePassData(towerDefenseRankItemData, towerDefenseConfigById.Value.InstanceId);
						List<TowerDefenseRankItemData> orAddSinglePassData = this.GetOrAddSinglePassData(towerDefenseConfigById.Value.InstanceId);
						if (orAddSinglePassData != null)
						{
							orAddSinglePassData.Add(towerDefenseRankItemData);
						}
					}
				}
			}
		}

		// Token: 0x06026A60 RID: 158304 RVA: 0x00AD3704 File Offset: 0x00AD1904
		public void RefreshSelfRankItemDataName(int instanceId)
		{
			List<TowerDefenseRankItemData> list;
			if (this.AllSinglePassDataMap.TryGetValue(instanceId, out list))
			{
				foreach (TowerDefenseRankItemData towerDefenseRankItemData in list)
				{
					if (towerDefenseRankItemData.IsSelfInData)
					{
						towerDefenseRankItemData.RefreshPlayerName(this.IsOpenAnonymousName);
					}
				}
			}
			List<TowerDefenseRankItemData> list2;
			if (this.AllMultiPassDataMap.TryGetValue(instanceId, out list2))
			{
				foreach (TowerDefenseRankItemData towerDefenseRankItemData2 in list2)
				{
					if (towerDefenseRankItemData2.IsSelfInData)
					{
						towerDefenseRankItemData2.RefreshPlayerName(this.IsOpenAnonymousName);
					}
				}
			}
		}

		// Token: 0x06026A61 RID: 158305 RVA: 0x00AD37CC File Offset: 0x00AD19CC
		public List<TowerDefenseRankItemData> GetRankDataListByTabType(TowerDefenceDefine.ETabType tabType)
		{
			if (tabType == TowerDefenceDefine.ETabType.Single)
			{
				return this.SinglePassDataList;
			}
			return this.MultiPassDataList;
		}

		// Token: 0x06026A62 RID: 158306 RVA: 0x00AD37DE File Offset: 0x00AD19DE
		public TowerDefenseRankItemData GetSelfRankDataByTabType(TowerDefenceDefine.ETabType tabType)
		{
			if (tabType == TowerDefenceDefine.ETabType.Single)
			{
				return this.OwnSinglePassData;
			}
			return this.OwnMultiPassData;
		}

		// Token: 0x06026A63 RID: 158307 RVA: 0x00AD37F0 File Offset: 0x00AD19F0
		public string GetBestRecordText(int instanceId)
		{
			this.RefreshOwnPassData(instanceId);
			bool isEmpty = this.OwnSinglePassData.IsEmpty;
			bool isEmpty2 = this.OwnMultiPassData.IsEmpty;
			int passTime = this.OwnSinglePassData.PassTime;
			int passTime2 = this.OwnMultiPassData.PassTime;
			int num = 0;
			if (!isEmpty && !isEmpty2)
			{
				num = Math.Min(passTime, passTime2);
			}
			else if (!isEmpty)
			{
				num = passTime;
			}
			else if (!isEmpty2)
			{
				num = passTime2;
			}
			return TimeUtil.Instance.GetTimeDataFormat((double)num);
		}

		// Token: 0x06026A64 RID: 158308 RVA: 0x00AD3863 File Offset: 0x00AD1A63
		public bool HasOwnRecord(int instanceId)
		{
			this.RefreshOwnPassData(instanceId);
			return !this.OwnSinglePassData.IsEmpty || !this.OwnMultiPassData.IsEmpty;
		}

		// Token: 0x06026A65 RID: 158309 RVA: 0x00AD388C File Offset: 0x00AD1A8C
		public bool IsOwnSingleBestScore(int instanceId)
		{
			bool isEmpty = this.OwnSinglePassData.IsEmpty;
			bool isEmpty2 = this.OwnMultiPassData.IsEmpty;
			if (isEmpty == isEmpty2 && isEmpty)
			{
				return true;
			}
			if (isEmpty != isEmpty2)
			{
				return isEmpty2;
			}
			int passScore = this.OwnSinglePassData.PassScore;
			int passScore2 = this.OwnMultiPassData.PassScore;
			if (!InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId).Value.IsDifficult)
			{
				return passScore >= passScore2;
			}
			return passScore <= passScore2;
		}

		// Token: 0x06026A66 RID: 158310 RVA: 0x00AD3908 File Offset: 0x00AD1B08
		public bool IsOwnSingleBestRecord(int instanceId)
		{
			bool isEmpty = this.OwnSinglePassData.IsEmpty;
			bool isEmpty2 = this.OwnMultiPassData.IsEmpty;
			if (isEmpty == isEmpty2 && isEmpty)
			{
				return true;
			}
			if (isEmpty != isEmpty2)
			{
				return isEmpty2;
			}
			int passTime = this.OwnSinglePassData.PassTime;
			int passTime2 = this.OwnMultiPassData.PassTime;
			return passTime <= passTime2;
		}

		// Token: 0x04015287 RID: 86663
		private bool IsOpenAnonymousNameInternal;

		// Token: 0x04015288 RID: 86664
		private Dictionary<int, List<TowerDefenseRankItemData>> AllSinglePassDataMap = new Dictionary<int, List<TowerDefenseRankItemData>>();

		// Token: 0x04015289 RID: 86665
		private List<TowerDefenseRankItemData> SinglePassDataList = new List<TowerDefenseRankItemData>();

		// Token: 0x0401528A RID: 86666
		private Dictionary<int, List<TowerDefenseRankItemData>> AllMultiPassDataMap = new Dictionary<int, List<TowerDefenseRankItemData>>();

		// Token: 0x0401528B RID: 86667
		private List<TowerDefenseRankItemData> MultiPassDataList = new List<TowerDefenseRankItemData>();

		// Token: 0x0401528C RID: 86668
		private Dictionary<int, TowerDefenseRankItemData> AllOwnSinglePassDataMap = new Dictionary<int, TowerDefenseRankItemData>();

		// Token: 0x0401528D RID: 86669
		private Dictionary<int, TowerDefenseRankItemData> AllOwnMultiPassData = new Dictionary<int, TowerDefenseRankItemData>();

		// Token: 0x0401528E RID: 86670
		private TowerDefenseRankItemData OwnSinglePassData;

		// Token: 0x0401528F RID: 86671
		private TowerDefenseRankItemData OwnMultiPassData;
	}
}
