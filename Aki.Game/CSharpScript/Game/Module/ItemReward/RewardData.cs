using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057EC RID: 22508
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardData<[Nullable(0)] T> : IRewardDataInterface where T : IRewardInfo
	{
		// Token: 0x17008A09 RID: 35337
		// (get) Token: 0x06039352 RID: 234322 RVA: 0x00D91124 File Offset: 0x00D8F324
		// (set) Token: 0x06039353 RID: 234323 RVA: 0x00D9112C File Offset: 0x00D8F32C
		[Nullable(2)]
		public IExtendRewardInfo ExtendRewardInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008A0A RID: 35338
		// (get) Token: 0x06039354 RID: 234324 RVA: 0x00D91135 File Offset: 0x00D8F335
		// (set) Token: 0x06039355 RID: 234325 RVA: 0x00D9113D File Offset: 0x00D8F33D
		public Dictionary<int, RewardItemData> ItemConfigIdMap { get; set; } = new Dictionary<int, RewardItemData>();

		// Token: 0x17008A0B RID: 35339
		// (get) Token: 0x06039356 RID: 234326 RVA: 0x00D91146 File Offset: 0x00D8F346
		// (set) Token: 0x06039357 RID: 234327 RVA: 0x00D9114E File Offset: 0x00D8F34E
		public Dictionary<int, RewardItemData> ItemUniqueIdMap { get; set; } = new Dictionary<int, RewardItemData>();

		// Token: 0x06039358 RID: 234328 RVA: 0x00D91158 File Offset: 0x00D8F358
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

		// Token: 0x06039359 RID: 234329 RVA: 0x00D911B1 File Offset: 0x00D8F3B1
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

		// Token: 0x0603935A RID: 234330 RVA: 0x00D911E0 File Offset: 0x00D8F3E0
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

		// Token: 0x0603935B RID: 234331 RVA: 0x00D91290 File Offset: 0x00D8F490
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

		// Token: 0x0603935C RID: 234332 RVA: 0x00D91310 File Offset: 0x00D8F510
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

		// Token: 0x0603935D RID: 234333 RVA: 0x00D9135C File Offset: 0x00D8F55C
		public void SetProgressQueue([Nullable(new byte[]
		{
			2,
			1
		})] List<IRewardProgress> progressQueue = null)
		{
			this.ExtendRewardInfo.ProgressQueue = progressQueue;
		}

		// Token: 0x0603935E RID: 234334 RVA: 0x00D9136A File Offset: 0x00D8F56A
		public void SetExploreRecordInfo(IRewardExploreRecord exploreRecordInfo)
		{
			this.ExtendRewardInfo.ExploreRecordInfo = exploreRecordInfo;
		}

		// Token: 0x0603935F RID: 234335 RVA: 0x00D91378 File Offset: 0x00D8F578
		public void SetExploreBarDataList(List<IRewardExploreBar> exploreBarDataList)
		{
			this.ExtendRewardInfo.ExploreBarDataList = exploreBarDataList;
		}

		// Token: 0x06039360 RID: 234336 RVA: 0x00D91386 File Offset: 0x00D8F586
		public void SetButtonInfoList(List<IRewardExploreConfirmButton> buttonInfoList)
		{
			this.ExtendRewardInfo.ButtonInfoList = buttonInfoList;
		}

		// Token: 0x06039361 RID: 234337 RVA: 0x00D91394 File Offset: 0x00D8F594
		public void SetExploreFriendDataList(List<IRewardExploreFriendData> friendDataList)
		{
			this.ExtendRewardInfo.ExploreFriendDataList = friendDataList;
		}

		// Token: 0x06039362 RID: 234338 RVA: 0x00D913A2 File Offset: 0x00D8F5A2
		public void SetTargetReached(List<IRewardExploreTargetReached> targetReached)
		{
			this.ExtendRewardInfo.TargetReached = targetReached;
		}

		// Token: 0x06039363 RID: 234339 RVA: 0x00D913B0 File Offset: 0x00D8F5B0
		public void SetHalfAreaData(IRewardExploreScoreBelongHalfArea halfAreaData)
		{
			this.ExtendRewardInfo.ScoreHalfArea = halfAreaData;
		}

		// Token: 0x06039364 RID: 234340 RVA: 0x00D913BE File Offset: 0x00D8F5BE
		public void SetStateToggle(IRewardExploreToggle stateToggle)
		{
			this.ExtendRewardInfo.StateToggle = stateToggle;
		}

		// Token: 0x06039365 RID: 234341 RVA: 0x00D913CC File Offset: 0x00D8F5CC
		public void SetAccumulatedScoreData(AccumulatedScoreData scoreData)
		{
			this.ExtendRewardInfo.AccumulatedScoreData = scoreData;
		}

		// Token: 0x06039366 RID: 234342 RVA: 0x00D913DA File Offset: 0x00D8F5DA
		public void SetBabelTowerSuccessData(IBabelTowerSuccessData data)
		{
			this.ExtendRewardInfo.BabelTowerSuccessData = data;
		}

		// Token: 0x06039367 RID: 234343 RVA: 0x00D913E8 File Offset: 0x00D8F5E8
		public void SetDangoAbyssSuccessData(IDangoAbyssSuccessData data)
		{
			this.ExtendRewardInfo.DangoAbyssSuccessData = data;
		}

		// Token: 0x06039368 RID: 234344 RVA: 0x00D913F6 File Offset: 0x00D8F5F6
		public void SetHonamiTowerSuccessData(IHonamiTowerSuccessData data)
		{
			this.ExtendRewardInfo.HonamiTowerSuccessData = data;
		}

		// Token: 0x06039369 RID: 234345 RVA: 0x00D91404 File Offset: 0x00D8F604
		public void SetRoguelikeBossChallengeData(IRoguelikeBossChallengeData data)
		{
			this.ExtendRewardInfo.RoguelikeBossChallengeData = data;
		}

		// Token: 0x0603936A RID: 234346 RVA: 0x00D91412 File Offset: 0x00D8F612
		public void SetScoreReached(ReachTargetData scoreReached)
		{
			this.ExtendRewardInfo.ScoreReached = scoreReached;
		}

		// Token: 0x0603936B RID: 234347 RVA: 0x00D91420 File Offset: 0x00D8F620
		public void SetRewardInfo(T rewardInfo)
		{
			this.RewardInfo = rewardInfo;
		}

		// Token: 0x0603936C RID: 234348 RVA: 0x00D91429 File Offset: 0x00D8F629
		public T GetRewardInfo()
		{
			return this.RewardInfo;
		}

		// Token: 0x0603936D RID: 234349 RVA: 0x00D91431 File Offset: 0x00D8F631
		[NullableContext(2)]
		public IExtendRewardInfo GetExtendRewardInfo()
		{
			return this.ExtendRewardInfo;
		}

		// Token: 0x0603936E RID: 234350 RVA: 0x00D91439 File Offset: 0x00D8F639
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RewardItemData> GetItemList()
		{
			return this.ExtendRewardInfo.ItemList;
		}

		// Token: 0x0603936F RID: 234351 RVA: 0x00D91448 File Offset: 0x00D8F648
		[NullableContext(2)]
		public RewardItemData GetItemByConfigId(int configId)
		{
			RewardItemData result;
			this.ItemConfigIdMap.TryGetValue(configId, out result);
			return result;
		}

		// Token: 0x06039370 RID: 234352 RVA: 0x00D91468 File Offset: 0x00D8F668
		[NullableContext(2)]
		public RewardItemData GetItemByUniqueId(int uniqueId)
		{
			RewardItemData result;
			this.ItemUniqueIdMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x0401DEF1 RID: 122609
		[Nullable(2)]
		private T RewardInfo;
	}
}
