using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C3 RID: 18371
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardData<[Nullable(0)] T> : IRewardDataInterface where T : IRewardInfo
	{
		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x0602E266 RID: 189030 RVA: 0x00CDFF6C File Offset: 0x00CDE16C
		// (set) Token: 0x0602E267 RID: 189031 RVA: 0x00CDFF74 File Offset: 0x00CDE174
		[Nullable(2)]
		public IExtendRewardInfo ExtendRewardInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x0602E268 RID: 189032 RVA: 0x00CDFF7D File Offset: 0x00CDE17D
		// (set) Token: 0x0602E269 RID: 189033 RVA: 0x00CDFF85 File Offset: 0x00CDE185
		public Dictionary<int, RewardItemData> ItemConfigIdMap { get; set; } = new Dictionary<int, RewardItemData>();

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0602E26A RID: 189034 RVA: 0x00CDFF8E File Offset: 0x00CDE18E
		// (set) Token: 0x0602E26B RID: 189035 RVA: 0x00CDFF96 File Offset: 0x00CDE196
		public Dictionary<int, RewardItemData> ItemUniqueIdMap { get; set; } = new Dictionary<int, RewardItemData>();

		// Token: 0x0602E26C RID: 189036 RVA: 0x00CDFFA0 File Offset: 0x00CDE1A0
		[NullableContext(2)]
		public RewardData(T rewardInfo = default(T), IExtendRewardInfo extendRewardInfo = null)
		{
			if (rewardInfo != null)
			{
				this.RewardInfo = rewardInfo;
			}
			if (extendRewardInfo != null)
			{
				this.ExtendRewardInfo = extendRewardInfo;
				return;
			}
			this.ExtendRewardInfo = new ExtendRewardInfo
			{
				ItemList = new List<RewardItemData>()
			};
		}

		// Token: 0x0602E26D RID: 189037 RVA: 0x00CDFFF9 File Offset: 0x00CDE1F9
		public RewardData<T> InheritData([Nullable(2)] IRewardDataInterface copyRewardData)
		{
			if (copyRewardData == null)
			{
				return this;
			}
			this.ExtendRewardInfo = copyRewardData.ExtendRewardInfo;
			this.ItemConfigIdMap = copyRewardData.ItemConfigIdMap;
			this.ItemUniqueIdMap = copyRewardData.ItemUniqueIdMap;
			return this;
		}

		// Token: 0x0602E26E RID: 189038 RVA: 0x00CE0028 File Offset: 0x00CDE228
		public void SetItemList([Nullable(new byte[]
		{
			2,
			1
		})] List<RewardItemData> rewardItemList)
		{
			if (rewardItemList == null)
			{
				return;
			}
			this.ExtendRewardInfo.ItemList = rewardItemList;
			foreach (RewardItemData rewardItemData in rewardItemList)
			{
				int uniqueId = rewardItemData.UniqueId;
				if (uniqueId > 0)
				{
					this.ItemUniqueIdMap[uniqueId] = rewardItemData;
				}
				else
				{
					int configId = rewardItemData.ConfigId;
					if (configId > 0)
					{
						RewardItemData rewardItemData2;
						if (!this.ItemConfigIdMap.TryGetValue(configId, out rewardItemData2))
						{
							this.ItemConfigIdMap[configId] = rewardItemData;
							break;
						}
						rewardItemData2.Count += rewardItemData.Count;
					}
				}
			}
		}

		// Token: 0x0602E26F RID: 189039 RVA: 0x00CE00D8 File Offset: 0x00CDE2D8
		public void AddItem(RewardItemData rewardItemData)
		{
			List<RewardItemData> list = this.GetItemList();
			if (list == null)
			{
				list = new List<RewardItemData>();
			}
			int uniqueId = rewardItemData.UniqueId;
			if (uniqueId > 0)
			{
				list.Add(rewardItemData);
				this.ItemUniqueIdMap[uniqueId] = rewardItemData;
				return;
			}
			int configId = rewardItemData.ConfigId;
			if (configId > 0)
			{
				RewardItemData rewardItemData2;
				if (!this.ItemConfigIdMap.TryGetValue(configId, out rewardItemData2))
				{
					list.Add(rewardItemData);
					this.ItemConfigIdMap[configId] = rewardItemData;
					return;
				}
				rewardItemData2.Count += rewardItemData.Count;
			}
		}

		// Token: 0x0602E270 RID: 189040 RVA: 0x00CE0158 File Offset: 0x00CDE358
		public void AddItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (itemList == null)
			{
				return;
			}
			foreach (RewardItemData rewardItemData in itemList)
			{
				this.AddItem(rewardItemData);
			}
		}

		// Token: 0x0602E271 RID: 189041 RVA: 0x00CE01A4 File Offset: 0x00CDE3A4
		public void SetProgressQueue([Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null)
		{
			this.ExtendRewardInfo.ProgressQueue = progressQueue;
		}

		// Token: 0x0602E272 RID: 189042 RVA: 0x00CE01B2 File Offset: 0x00CDE3B2
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			this.ExtendRewardInfo.ExploreRecordInfo = exploreRecordInfo;
		}

		// Token: 0x0602E273 RID: 189043 RVA: 0x00CE01C0 File Offset: 0x00CDE3C0
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			this.ExtendRewardInfo.ExploreBarDataList = exploreBarDataList;
		}

		// Token: 0x0602E274 RID: 189044 RVA: 0x00CE01CE File Offset: 0x00CDE3CE
		public void SetButtonInfoList(List<IRewardExploreConfirmButton> buttonInfoList)
		{
			this.ExtendRewardInfo.ButtonInfoList = buttonInfoList;
		}

		// Token: 0x0602E275 RID: 189045 RVA: 0x00CE01DC File Offset: 0x00CDE3DC
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> friendDataList)
		{
			this.ExtendRewardInfo.ExploreFriendDataList = friendDataList;
		}

		// Token: 0x0602E276 RID: 189046 RVA: 0x00CE01EA File Offset: 0x00CDE3EA
		public void SetTargetReached(List<IRewardExploreTargetReached> targetReached)
		{
			this.ExtendRewardInfo.TargetReached = targetReached;
		}

		// Token: 0x0602E277 RID: 189047 RVA: 0x00CE01F8 File Offset: 0x00CDE3F8
		public void SetHalfAreaData(IRewardExploreScoreBelongHalfArea halfAreaData)
		{
			this.ExtendRewardInfo.ScoreHalfArea = halfAreaData;
		}

		// Token: 0x0602E278 RID: 189048 RVA: 0x00CE0206 File Offset: 0x00CDE406
		public void SetStateToggle(IRewardExploreToggle stateToggle)
		{
			this.ExtendRewardInfo.StateToggle = stateToggle;
		}

		// Token: 0x0602E279 RID: 189049 RVA: 0x00CE0214 File Offset: 0x00CDE414
		public void SetAccumulatedScoreData(AccumulatedScoreData scoreData)
		{
			this.ExtendRewardInfo.AccumulatedScoreData = scoreData;
		}

		// Token: 0x0602E27A RID: 189050 RVA: 0x00CE0222 File Offset: 0x00CDE422
		public void SetBabelTowerSuccessData(IBabelTowerSuccessData data)
		{
			this.ExtendRewardInfo.BabelTowerSuccessData = data;
		}

		// Token: 0x0602E27B RID: 189051 RVA: 0x00CE0230 File Offset: 0x00CDE430
		public void SetDangoAbyssSuccessData(IDangoAbyssSuccessData data)
		{
			this.ExtendRewardInfo.DangoAbyssSuccessData = data;
		}

		// Token: 0x0602E27C RID: 189052 RVA: 0x00CE023E File Offset: 0x00CDE43E
		public void SetHonamiTowerSuccessData(IHonamiTowerSuccessData data)
		{
			this.ExtendRewardInfo.HonamiTowerSuccessData = data;
		}

		// Token: 0x0602E27D RID: 189053 RVA: 0x00CE024C File Offset: 0x00CDE44C
		public void SetRoguelikeBossChallengeData(IRoguelikeBossChallengeData data)
		{
			this.ExtendRewardInfo.RoguelikeBossChallengeData = data;
		}

		// Token: 0x0602E27E RID: 189054 RVA: 0x00CE025A File Offset: 0x00CDE45A
		public void SetScoreReached(ReachTargetData scoreReached)
		{
			this.ExtendRewardInfo.ScoreReached = scoreReached;
		}

		// Token: 0x0602E27F RID: 189055 RVA: 0x00CE0268 File Offset: 0x00CDE468
		public void SetRewardInfo(T rewardInfo)
		{
			this.RewardInfo = rewardInfo;
		}

		// Token: 0x0602E280 RID: 189056 RVA: 0x00CE0271 File Offset: 0x00CDE471
		public T GetRewardInfo()
		{
			return this.RewardInfo;
		}

		// Token: 0x0602E281 RID: 189057 RVA: 0x00CE0279 File Offset: 0x00CDE479
		[NullableContext(2)]
		public IExtendRewardInfo GetExtendRewardInfo()
		{
			return this.ExtendRewardInfo;
		}

		// Token: 0x0602E282 RID: 189058 RVA: 0x00CE0281 File Offset: 0x00CDE481
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> GetItemList()
		{
			return this.ExtendRewardInfo.ItemList;
		}

		// Token: 0x0602E283 RID: 189059 RVA: 0x00CE0290 File Offset: 0x00CDE490
		[NullableContext(2)]
		public RewardItemData GetItemByConfigId(int configId)
		{
			RewardItemData result;
			this.ItemConfigIdMap.TryGetValue(configId, out result);
			return result;
		}

		// Token: 0x0602E284 RID: 189060 RVA: 0x00CE02B0 File Offset: 0x00CDE4B0
		[NullableContext(2)]
		public RewardItemData GetItemByUniqueId(int uniqueId)
		{
			RewardItemData result;
			this.ItemUniqueIdMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x04018988 RID: 100744
		[Nullable(2)]
		private T RewardInfo;
	}
}
