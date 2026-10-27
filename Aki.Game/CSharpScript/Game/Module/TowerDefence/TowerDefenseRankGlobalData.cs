using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B18 RID: 19224
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankGlobalData
	{
		// Token: 0x17007B4E RID: 31566
		// (get) Token: 0x06031CC0 RID: 203968 RVA: 0x00B8F126 File Offset: 0x00B8D326
		public bool IsOpenAnonymousName
		{
			get
			{
				return this.IsOpenAnonymousNameInternal;
			}
		}

		// Token: 0x06031CC1 RID: 203969 RVA: 0x00B8F12E File Offset: 0x00B8D32E
		public void SetIsOpenAnonymousName(bool isOpen)
		{
			this.IsOpenAnonymousNameInternal = isOpen;
		}

		// Token: 0x06031CC2 RID: 203970 RVA: 0x00B8F137 File Offset: 0x00B8D337
		private int SortNormalPassData(TowerDefenseRankItemData aData, TowerDefenseRankItemData bData)
		{
			return bData.PassScore - aData.PassScore;
		}

		// Token: 0x06031CC3 RID: 203971 RVA: 0x00B8F146 File Offset: 0x00B8D346
		private int SortDifficultPassData(TowerDefenseRankItemData aData, TowerDefenseRankItemData bData)
		{
			return aData.PassScore - bData.PassScore;
		}

		// Token: 0x06031CC4 RID: 203972 RVA: 0x00B8F158 File Offset: 0x00B8D358
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

		// Token: 0x06031CC5 RID: 203973 RVA: 0x00B8F24C File Offset: 0x00B8D44C
		private TowerDefenseRankItemData CreateOwnSinglePassData(int instanceId)
		{
			TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(false, InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId).Value.IsDifficult, TowerDefencePassInfo.Create());
			this.SetSelfSinglePassData(towerDefenseRankItemData, instanceId);
			return towerDefenseRankItemData;
		}

		// Token: 0x06031CC6 RID: 203974 RVA: 0x00B8F28C File Offset: 0x00B8D48C
		private TowerDefenseRankItemData CreateOwnMultiPassData(int instanceId)
		{
			TowerDefenseRankItemData towerDefenseRankItemData = new TowerDefenseRankItemData(true, InstanceDungeonConfig.Instance.GetTowerDefenseInstanceByInstance(instanceId).Value.IsDifficult, TowerDefencePassInfo.Create());
			this.SetSelfMultiPassData(towerDefenseRankItemData, instanceId);
			return towerDefenseRankItemData;
		}

		// Token: 0x06031CC7 RID: 203975 RVA: 0x00B8F2CC File Offset: 0x00B8D4CC
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

		// Token: 0x06031CC8 RID: 203976 RVA: 0x00B8F348 File Offset: 0x00B8D548
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

		// Token: 0x06031CC9 RID: 203977 RVA: 0x00B8F37C File Offset: 0x00B8D57C
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

		// Token: 0x06031CCA RID: 203978 RVA: 0x00B8F3AD File Offset: 0x00B8D5AD
		public void RefreshAllPassDataRank(int instanceId)
		{
			this.RefreshPassDataRank(instanceId, this.GetOrAddSinglePassData(instanceId), this.SinglePassDataList);
			this.RefreshPassDataRank(instanceId, this.GetOrAddMultiPassData(instanceId), this.MultiPassDataList);
			this.RefreshOwnPassData(instanceId);
			this.RefreshSelfRankItemDataName(instanceId);
		}

		// Token: 0x06031CCB RID: 203979 RVA: 0x00B8F3E8 File Offset: 0x00B8D5E8
		public void SetFriendServerData(List<OneTowerDefencePassInfo> friendPassDataList)
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

		// Token: 0x06031CCC RID: 203980 RVA: 0x00B8F4D8 File Offset: 0x00B8D6D8
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

		// Token: 0x06031CCD RID: 203981 RVA: 0x00B8F550 File Offset: 0x00B8D750
		private void SetSelfSinglePassData(TowerDefenseRankItemData itemData, int instanceId)
		{
			itemData.IsSelf = true;
			this.AllOwnSinglePassDataMap[instanceId] = itemData;
		}

		// Token: 0x06031CCE RID: 203982 RVA: 0x00B8F566 File Offset: 0x00B8D766
		private void SetSelfMultiPassData(TowerDefenseRankItemData itemData, int instanceId)
		{
			itemData.IsSelf = true;
			this.AllOwnMultiPassData[instanceId] = itemData;
		}

		// Token: 0x06031CCF RID: 203983 RVA: 0x00B8F57C File Offset: 0x00B8D77C
		public void SetSelfServerData(List<OneTowerDefencePassInfo> selfPassDataList)
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

		// Token: 0x06031CD0 RID: 203984 RVA: 0x00B8F6A0 File Offset: 0x00B8D8A0
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

		// Token: 0x06031CD1 RID: 203985 RVA: 0x00B8F768 File Offset: 0x00B8D968
		public List<TowerDefenseRankItemData> GetRankDataListByTabType(TowerDefenceDefine.ETabType tabType)
		{
			if (tabType == TowerDefenceDefine.ETabType.Single)
			{
				return this.SinglePassDataList;
			}
			return this.MultiPassDataList;
		}

		// Token: 0x06031CD2 RID: 203986 RVA: 0x00B8F77A File Offset: 0x00B8D97A
		public TowerDefenseRankItemData GetSelfRankDataByTabType(TowerDefenceDefine.ETabType tabType)
		{
			if (tabType == TowerDefenceDefine.ETabType.Single)
			{
				return this.OwnSinglePassData;
			}
			return this.OwnMultiPassData;
		}

		// Token: 0x06031CD3 RID: 203987 RVA: 0x00B8F78C File Offset: 0x00B8D98C
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

		// Token: 0x06031CD4 RID: 203988 RVA: 0x00B8F7FF File Offset: 0x00B8D9FF
		public bool HasOwnRecord(int instanceId)
		{
			this.RefreshOwnPassData(instanceId);
			return !this.OwnSinglePassData.IsEmpty || !this.OwnMultiPassData.IsEmpty;
		}

		// Token: 0x06031CD5 RID: 203989 RVA: 0x00B8F828 File Offset: 0x00B8DA28
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

		// Token: 0x06031CD6 RID: 203990 RVA: 0x00B8F8A4 File Offset: 0x00B8DAA4
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

		// Token: 0x0401A935 RID: 108853
		private bool IsOpenAnonymousNameInternal;

		// Token: 0x0401A936 RID: 108854
		private Dictionary<int, List<TowerDefenseRankItemData>> AllSinglePassDataMap = new Dictionary<int, List<TowerDefenseRankItemData>>();

		// Token: 0x0401A937 RID: 108855
		private List<TowerDefenseRankItemData> SinglePassDataList = new List<TowerDefenseRankItemData>();

		// Token: 0x0401A938 RID: 108856
		private Dictionary<int, List<TowerDefenseRankItemData>> AllMultiPassDataMap = new Dictionary<int, List<TowerDefenseRankItemData>>();

		// Token: 0x0401A939 RID: 108857
		private List<TowerDefenseRankItemData> MultiPassDataList = new List<TowerDefenseRankItemData>();

		// Token: 0x0401A93A RID: 108858
		private Dictionary<int, TowerDefenseRankItemData> AllOwnSinglePassDataMap = new Dictionary<int, TowerDefenseRankItemData>();

		// Token: 0x0401A93B RID: 108859
		private Dictionary<int, TowerDefenseRankItemData> AllOwnMultiPassData = new Dictionary<int, TowerDefenseRankItemData>();

		// Token: 0x0401A93C RID: 108860
		private TowerDefenseRankItemData OwnSinglePassData;

		// Token: 0x0401A93D RID: 108861
		private TowerDefenseRankItemData OwnMultiPassData;
	}
}
