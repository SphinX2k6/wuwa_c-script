using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.RacingBets.Data
{
	// Token: 0x02004F2C RID: 20268
	[NullableContext(1)]
	[Nullable(0)]
	public class RacingBetsSeasonData : ActivityBaseData
	{
		// Token: 0x06033FC2 RID: 212930 RVA: 0x00C2FFC4 File Offset: 0x00C2E1C4
		protected override void PhraseEx(ActivityData data)
		{
			RacingBetsActivityData racingBetsData = data.RacingBetsData;
			if (racingBetsData == null)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "RacingBetsSeasonData初始化 无效activityInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.IsInit)
			{
				this.Refresh(racingBetsData);
				return;
			}
			this.SeasonConfig = RacingBetsConfig.Instance.GetRacingBetsSeasonConfig(base.Id).Value;
			this.InitMatchData(new List<RacingBetsGroupMatchesInfo>(racingBetsData.MatchInfos));
			this.RefreshPlayerData(racingBetsData.PlayerInfo);
			this.InitRewardData(new List<ConditionTaskData>(racingBetsData.TaskDatas));
			this.InitRankUpdateTime(racingBetsData.RankListUpdateTime);
			this.InitCloseSettleLegMatchIdList(new List<int>(racingBetsData.CloseSettleMenuLegMatchList));
			RacingBetsModel.Instance.CheckMatchRedDot();
			RacingBetsModel.Instance.CheckRankRedDot();
			this.IsInit = true;
			EventSystem.Instance.Emit<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, this);
		}

		// Token: 0x06033FC3 RID: 212931 RVA: 0x00C300A0 File Offset: 0x00C2E2A0
		private void Refresh(RacingBetsActivityData activityInfo)
		{
			this.RefreshMatchData(new List<RacingBetsGroupMatchesInfo>(activityInfo.MatchInfos));
			this.RefreshPlayerData(activityInfo.PlayerInfo);
			this.RefreshRewardData(new List<ConditionTaskData>(activityInfo.TaskDatas));
			this.InitRankUpdateTime(activityInfo.RankListUpdateTime);
			RacingBetsModel.Instance.CheckMatchRedDot();
			RacingBetsModel.Instance.CheckRankRedDot();
			EventSystem.Instance.Emit<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, this);
		}

		// Token: 0x06033FC4 RID: 212932 RVA: 0x00C3010C File Offset: 0x00C2E30C
		public void RefreshMatchInfo(RacingBetsMatchInfoResponse message)
		{
			this.RefreshMatchData(new List<RacingBetsGroupMatchesInfo>(message.MatchInfos));
		}

		// Token: 0x06033FC5 RID: 212933 RVA: 0x00C3011F File Offset: 0x00C2E31F
		protected override void OnActivityClose()
		{
			RacingBetsController.Instance.TryLeaveRacingBetsDungeon();
		}

		// Token: 0x06033FC6 RID: 212934 RVA: 0x00C3012C File Offset: 0x00C2E32C
		public override bool GetExDataRedPointShowState()
		{
			using (Dictionary<int, RacingBetsRewardData>.ValueCollection.Enumerator enumerator = this.RewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.CanReceiveReward())
					{
						return true;
					}
				}
			}
			RacingBetsLegMatchData curLegMatchData = this.GetCurLegMatchData();
			if (curLegMatchData == null)
			{
				return false;
			}
			ERacingBetsLegMatchState legMatchState = curLegMatchData.GetLegMatchState();
			if (legMatchState == ERacingBetsLegMatchState.BettingPeriod && curLegMatchData.BetDangoId == 0)
			{
				return true;
			}
			int player = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsWatchGameRecord, 0);
			if (legMatchState == ERacingBetsLegMatchState.MatchPeriod && curLegMatchData.Id > player)
			{
				return true;
			}
			int player2 = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsReplayGameRecord, 0);
			return legMatchState == ERacingBetsLegMatchState.EndOfMatch && curLegMatchData.Id > player2;
		}

		// Token: 0x06033FC7 RID: 212935 RVA: 0x00C301E4 File Offset: 0x00C2E3E4
		private void InitMatchData(List<RacingBetsGroupMatchesInfo> matchInfos)
		{
			if (matchInfos == null || matchInfos.Count <= 0)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "RacingBetsSeasonData初始化 无效matchInfos", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.GroupMatchMap.Clear();
			this.LegMatchMap.Clear();
			this.LegMatchList = new List<RacingBetsLegMatchData>();
			foreach (RacingBetsGroupMatchesInfo matchInfo in matchInfos)
			{
				RacingBetsGroupMatchData racingBetsGroupMatchData = new RacingBetsGroupMatchData();
				racingBetsGroupMatchData.Init(matchInfo);
				List<RacingBetsLegMatchData> legMatchList = racingBetsGroupMatchData.GetLegMatchList();
				this.GroupMatchMap.Add(racingBetsGroupMatchData.Id, racingBetsGroupMatchData);
				if (legMatchList == null || legMatchList.Count <= 0)
				{
					Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "RacingBetsSeasonData初始化 无效legMatchList", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					foreach (RacingBetsLegMatchData racingBetsLegMatchData in legMatchList)
					{
						this.LegMatchMap.Add(racingBetsLegMatchData.Id, racingBetsLegMatchData);
						this.LegMatchList.Add(racingBetsLegMatchData);
					}
				}
			}
			this.UpdateGroupMatchDangoSource();
			this.LegMatchList.Sort(delegate(RacingBetsLegMatchData a, RacingBetsLegMatchData b)
			{
				if (a.BetsStartTime >= b.BetsStartTime)
				{
					return (a.BetsStartTime > b.BetsStartTime) ? 1 : 0;
				}
				return -1;
			});
		}

		// Token: 0x06033FC8 RID: 212936 RVA: 0x00C30360 File Offset: 0x00C2E560
		private void UpdateGroupMatchDangoSource()
		{
			foreach (RacingBetsGroupMatchData racingBetsGroupMatchData in this.GroupMatchMap.Values)
			{
				int advancedNextGroupMatchId = racingBetsGroupMatchData.AdvancedNextGroupMatchId;
				if (advancedNextGroupMatchId != 0)
				{
					RacingBetsGroupMatchData groupMatchData = this.GetGroupMatchData(advancedNextGroupMatchId);
					if (groupMatchData != null)
					{
						groupMatchData.PushSourceAdvancedGroupMatchId(racingBetsGroupMatchData.Id);
					}
				}
				int loserNextGroupMatchId = racingBetsGroupMatchData.LoserNextGroupMatchId;
				if (loserNextGroupMatchId != 0)
				{
					RacingBetsGroupMatchData groupMatchData2 = this.GetGroupMatchData(loserNextGroupMatchId);
					if (groupMatchData2 != null)
					{
						groupMatchData2.PushSourceLossGroupMatchId(racingBetsGroupMatchData.Id);
					}
				}
			}
		}

		// Token: 0x06033FC9 RID: 212937 RVA: 0x00C303F8 File Offset: 0x00C2E5F8
		private void RefreshMatchData(List<RacingBetsGroupMatchesInfo> matchInfos)
		{
			if (matchInfos == null || matchInfos.Count <= 0)
			{
				Log.Instance.Error(ELogModule.RacingBets, ELogAuthor.LRC, "RacingBetsSeasonData刷新 无效matchInfos", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (RacingBetsGroupMatchesInfo racingBetsGroupMatchesInfo in matchInfos)
			{
				this.GetGroupMatchData(racingBetsGroupMatchesInfo.GroupMatchId).Refresh(racingBetsGroupMatchesInfo);
				foreach (RacingBetsLegMatchesInfo racingBetsLegMatchesInfo in racingBetsGroupMatchesInfo.LegMatchesInfo)
				{
					this.GetLegMatchData(racingBetsLegMatchesInfo.Id).Refresh(racingBetsLegMatchesInfo);
				}
			}
		}

		// Token: 0x06033FCA RID: 212938 RVA: 0x00C304C8 File Offset: 0x00C2E6C8
		public unsafe void RefreshPlayerData(RacingBetPlayerInfo playerInfo)
		{
			this.BetItemData = new TItem(new InventoryDefine.GetItemData(this.SeasonConfig.Id, 0), playerInfo.CurCash);
			this.AccumulateBetsCashCount = playerInfo.TotalCash;
			this.HitNum = playerInfo.HitNum;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RacingBetsSeasonData刷新玩家数据";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AccumulateBetsCashCount", this.AccumulateBetsCashCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HitNum", this.HitNum);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.RefreshBetsInfo(new List<RacingBetsGearInfo>(playerInfo.GearInfo));
		}

		// Token: 0x06033FCB RID: 212939 RVA: 0x00C3058C File Offset: 0x00C2E78C
		private void RefreshBetsInfo(List<RacingBetsGearInfo> betsInfo)
		{
			foreach (RacingBetsGearInfo racingBetsGearInfo in betsInfo)
			{
				this.GetLegMatchData(racingBetsGearInfo.LegMatchesId).RefreshBetInfo(racingBetsGearInfo);
			}
		}

		// Token: 0x06033FCC RID: 212940 RVA: 0x00C305E8 File Offset: 0x00C2E7E8
		private void InitRewardData(List<ConditionTaskData> taskDataList)
		{
			this.RewardDataMap.Clear();
			this.RewardGroupDataMap.Clear();
			foreach (ConditionTaskData conditionTaskData in taskDataList)
			{
				RacingBetsRewardData racingBetsRewardData = new RacingBetsRewardData(conditionTaskData.Id);
				racingBetsRewardData.Refresh(conditionTaskData);
				this.RewardDataMap.Add(conditionTaskData.Id, racingBetsRewardData);
				this.GetGroupRewardData(racingBetsRewardData.GetRewardType()).AddRewardData(racingBetsRewardData);
			}
		}

		// Token: 0x06033FCD RID: 212941 RVA: 0x00C3067C File Offset: 0x00C2E87C
		public void RefreshRewardData(List<ConditionTaskData> taskDataList)
		{
			foreach (ConditionTaskData conditionTaskData in taskDataList)
			{
				this.GetRewardData(conditionTaskData.Id).Refresh(conditionTaskData);
			}
		}

		// Token: 0x06033FCE RID: 212942 RVA: 0x00C306D8 File Offset: 0x00C2E8D8
		private void InitRankUpdateTime(RepeatedField<long> rankTimeList)
		{
			int count = rankTimeList.Count;
			this.RankListUpdateTime = new List<int>(count);
			for (int i = 0; i < count; i++)
			{
				this.RankListUpdateTime.Add((int)MathUtils.Instance.LongToNumber(rankTimeList[i]));
			}
		}

		// Token: 0x06033FCF RID: 212943 RVA: 0x00C30721 File Offset: 0x00C2E921
		private void InitCloseSettleLegMatchIdList(List<int> closeSettleLegMatchIdList)
		{
			this.CloseSettleLegMatchIdList = closeSettleLegMatchIdList;
		}

		// Token: 0x06033FD0 RID: 212944 RVA: 0x00C3072A File Offset: 0x00C2E92A
		public void AddCloseSettleLegMatchId(int legMatchId)
		{
			if (this.CloseSettleLegMatchIdList.Contains(legMatchId))
			{
				return;
			}
			this.CloseSettleLegMatchIdList.Add(legMatchId);
		}

		// Token: 0x06033FD1 RID: 212945 RVA: 0x00C30747 File Offset: 0x00C2E947
		public TItem GetBetItemData()
		{
			return this.BetItemData;
		}

		// Token: 0x06033FD2 RID: 212946 RVA: 0x00C3074F File Offset: 0x00C2E94F
		public RacingBetsSeason GetSeasonConfig()
		{
			return this.SeasonConfig;
		}

		// Token: 0x06033FD3 RID: 212947 RVA: 0x00C30757 File Offset: 0x00C2E957
		public int GetTotalBetCount()
		{
			return this.AccumulateBetsCashCount;
		}

		// Token: 0x06033FD4 RID: 212948 RVA: 0x00C30760 File Offset: 0x00C2E960
		[NullableContext(2)]
		public RacingBetsGroupMatchData GetGroupMatchData(int matchId)
		{
			RacingBetsGroupMatchData result;
			if (!this.GroupMatchMap.TryGetValue(matchId, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.BB;
				string message = "RacingBetsSeasonData 无效matchId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("matchId", matchId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return result;
		}

		// Token: 0x06033FD5 RID: 212949 RVA: 0x00C307B0 File Offset: 0x00C2E9B0
		[NullableContext(2)]
		public RacingBetsLegMatchData GetLegMatchData(int legMatchId)
		{
			RacingBetsLegMatchData result;
			if (!this.LegMatchMap.TryGetValue(legMatchId, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.BB;
				string message = "RacingBetsSeasonData 无效legMatchId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("legMatchId", legMatchId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return result;
		}

		// Token: 0x06033FD6 RID: 212950 RVA: 0x00C30800 File Offset: 0x00C2EA00
		[NullableContext(2)]
		public RacingBetsLegMatchData GetCurLegMatchData()
		{
			int curLegMatchDataIndex = this.GetCurLegMatchDataIndex();
			return this.GetLegMatchDataByIndex(curLegMatchDataIndex);
		}

		// Token: 0x06033FD7 RID: 212951 RVA: 0x00C3081C File Offset: 0x00C2EA1C
		public int GetCurLegMatchDataIndex()
		{
			for (int i = this.LegMatchList.Count - 1; i >= 0; i--)
			{
				ERacingBetsLegMatchState legMatchState = this.LegMatchList[i].GetLegMatchState();
				if (legMatchState != ERacingBetsLegMatchState.NotOpen && legMatchState != ERacingBetsLegMatchState.EndOfMatch && legMatchState != ERacingBetsLegMatchState.End)
				{
					return i;
				}
			}
			return this.LegMatchList.Count - 1;
		}

		// Token: 0x06033FD8 RID: 212952 RVA: 0x00C3086D File Offset: 0x00C2EA6D
		[NullableContext(2)]
		public RacingBetsLegMatchData GetLegMatchDataByIndex(int index)
		{
			if (index < 0 || index > this.LegMatchList.Count)
			{
				return null;
			}
			return this.LegMatchList[index];
		}

		// Token: 0x06033FD9 RID: 212953 RVA: 0x00C30890 File Offset: 0x00C2EA90
		[NullableContext(0)]
		public ValueTuple<int, int> GetCurLegMatchRankOpenTime()
		{
			int curLegMatchDataIndex = this.GetCurLegMatchDataIndex();
			if (curLegMatchDataIndex >= this.RankListUpdateTime.Count)
			{
				return new ValueTuple<int, int>(0, 0);
			}
			int item = this.RankListUpdateTime[curLegMatchDataIndex];
			int item2 = (curLegMatchDataIndex + 1 < this.RankListUpdateTime.Count) ? this.RankListUpdateTime[curLegMatchDataIndex + 1] : 0;
			return new ValueTuple<int, int>(item, item2);
		}

		// Token: 0x06033FDA RID: 212954 RVA: 0x00C308F0 File Offset: 0x00C2EAF0
		public int GetNextRankUpdateTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			foreach (int num in this.RankListUpdateTime)
			{
				if (serverTime < (double)num)
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x06033FDB RID: 212955 RVA: 0x00C30954 File Offset: 0x00C2EB54
		public bool CheckRankOpen()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (this.RankListUpdateTime.Count <= 0)
			{
				return false;
			}
			int num = this.RankListUpdateTime[0];
			return serverTime >= (double)num;
		}

		// Token: 0x06033FDC RID: 212956 RVA: 0x00C30994 File Offset: 0x00C2EB94
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RacingBetsLegMatchData> GetReverseLegMatchList()
		{
			if (this.LegMatchList == null || this.LegMatchList.Count <= 0)
			{
				return null;
			}
			List<RacingBetsLegMatchData> list = new List<RacingBetsLegMatchData>();
			for (int i = this.LegMatchList.Count - 1; i >= 0; i--)
			{
				list.Add(this.LegMatchList[i]);
			}
			return list;
		}

		// Token: 0x06033FDD RID: 212957 RVA: 0x00C309EC File Offset: 0x00C2EBEC
		public bool IsFinalLegMatch(int legMatchId)
		{
			RacingBetsLegMatchData legMatchData = this.GetLegMatchData(legMatchId);
			if (legMatchData == null)
			{
				return false;
			}
			int count = this.LegMatchList.Count;
			for (int i = 0; i < count; i++)
			{
				if (legMatchData == this.LegMatchList[i])
				{
					return i == count - 1;
				}
			}
			return false;
		}

		// Token: 0x06033FDE RID: 212958 RVA: 0x00C30A38 File Offset: 0x00C2EC38
		public int GetNextLegMatchIndex(int legMatchId)
		{
			for (int i = 0; i < this.LegMatchList.Count; i++)
			{
				if (this.LegMatchList[i].Id == legMatchId)
				{
					return i + 1;
				}
			}
			return -1;
		}

		// Token: 0x06033FDF RID: 212959 RVA: 0x00C30A74 File Offset: 0x00C2EC74
		[NullableContext(2)]
		public RacingBetsLegMatchData GetNextLegMatchData(int legMatchId)
		{
			int nextLegMatchIndex = this.GetNextLegMatchIndex(legMatchId);
			return this.GetLegMatchDataByIndex(nextLegMatchIndex);
		}

		// Token: 0x06033FE0 RID: 212960 RVA: 0x00C30A90 File Offset: 0x00C2EC90
		[NullableContext(2)]
		public RacingBetsLegMatchData GetEndOfMatchLegMatchData()
		{
			foreach (RacingBetsLegMatchData racingBetsLegMatchData in this.LegMatchList)
			{
				if (racingBetsLegMatchData.GetLegMatchState() == ERacingBetsLegMatchState.EndOfMatch)
				{
					return racingBetsLegMatchData;
				}
			}
			return null;
		}

		// Token: 0x06033FE1 RID: 212961 RVA: 0x00C30AEC File Offset: 0x00C2ECEC
		[NullableContext(2)]
		public RacingBetsRewardData GetRewardData(int rewardId)
		{
			RacingBetsRewardData result;
			if (!this.RewardDataMap.TryGetValue(rewardId, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.BB;
				string message = "RacingBetsSeasonData 无效rewardId";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rewardId", rewardId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return result;
		}

		// Token: 0x06033FE2 RID: 212962 RVA: 0x00C30B3C File Offset: 0x00C2ED3C
		public RacingBetsGroupRewardData GetGroupRewardData(ERacingBetsRewardType rewardType)
		{
			RacingBetsGroupRewardData racingBetsGroupRewardData;
			if (!this.RewardGroupDataMap.TryGetValue(rewardType, out racingBetsGroupRewardData))
			{
				racingBetsGroupRewardData = new RacingBetsGroupRewardData((int)rewardType);
				this.RewardGroupDataMap.Add(rewardType, racingBetsGroupRewardData);
				return racingBetsGroupRewardData;
			}
			return racingBetsGroupRewardData;
		}

		// Token: 0x06033FE3 RID: 212963 RVA: 0x00C30B70 File Offset: 0x00C2ED70
		public int GetHitNum()
		{
			return this.HitNum;
		}

		// Token: 0x06033FE4 RID: 212964 RVA: 0x00C30B78 File Offset: 0x00C2ED78
		public int GetCurrencyItemId()
		{
			return this.SeasonConfig.MoneyId;
		}

		// Token: 0x06033FE5 RID: 212965 RVA: 0x00C30B85 File Offset: 0x00C2ED85
		public int GetCurrencyCount()
		{
			return InventoryModel.Instance.GetCommonItemCount(this.SeasonConfig.MoneyId, 0);
		}

		// Token: 0x06033FE6 RID: 212966 RVA: 0x00C30B9D File Offset: 0x00C2ED9D
		public int GetBetCostCount(RacingBettingGear gearConfig)
		{
			return (int)Math.Ceiling((double)(this.GetCurrencyCount() * gearConfig.Odds) / 100.0);
		}

		// Token: 0x06033FE7 RID: 212967 RVA: 0x00C30BBE File Offset: 0x00C2EDBE
		public bool GetActivityTipNeedShowState()
		{
			return this.CheckIfInOpenTime() && this.CheckIfInShowTime() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x06033FE8 RID: 212968 RVA: 0x00C30BE9 File Offset: 0x00C2EDE9
		public bool CheckLegMatchIsCloseSettle(int legMatchId)
		{
			return this.CloseSettleLegMatchIdList.Contains(legMatchId);
		}

		// Token: 0x06033FE9 RID: 212969 RVA: 0x00C30BF8 File Offset: 0x00C2EDF8
		[NullableContext(2)]
		public RacingBetsLegMatchData GetLegMatchDataForMatchStateText()
		{
			RacingBetsLegMatchData curLegMatchData = this.GetCurLegMatchData();
			if (curLegMatchData == null)
			{
				return null;
			}
			ERacingBetsLegMatchState legMatchState = curLegMatchData.GetLegMatchState();
			if (this.IsFinalLegMatch(curLegMatchData.Id) && legMatchState == ERacingBetsLegMatchState.EndOfMatch)
			{
				return curLegMatchData;
			}
			RacingBetsLegMatchData endOfMatchLegMatchData = this.GetEndOfMatchLegMatchData();
			RacingBetsLegMatchData racingBetsLegMatchData = (legMatchState == ERacingBetsLegMatchState.BettingPeriod) ? curLegMatchData : null;
			if (endOfMatchLegMatchData == null || racingBetsLegMatchData == null || endOfMatchLegMatchData.Id == racingBetsLegMatchData.Id)
			{
				return curLegMatchData;
			}
			if (this.CheckLegMatchIsCloseSettle(endOfMatchLegMatchData.Id))
			{
				return racingBetsLegMatchData;
			}
			return endOfMatchLegMatchData;
		}

		// Token: 0x06033FEA RID: 212970 RVA: 0x00C30C64 File Offset: 0x00C2EE64
		public string GetMatchStateDisplayText()
		{
			RacingBetsLegMatchData legMatchDataForMatchStateText = this.GetLegMatchDataForMatchStateText();
			if (legMatchDataForMatchStateText == null)
			{
				return "";
			}
			return this.GetMatchStateDisplayTextForLeg(legMatchDataForMatchStateText);
		}

		// Token: 0x06033FEB RID: 212971 RVA: 0x00C30C88 File Offset: 0x00C2EE88
		public static string GetMatchStateDisplayTextForEntranceActivityId(int activityId)
		{
			RacingBetsSeasonData racingBetsSeasonData = ActivityModel.Instance.GetActivityById(activityId) as RacingBetsSeasonData;
			if (racingBetsSeasonData != null)
			{
				return racingBetsSeasonData.GetMatchStateDisplayText();
			}
			RacingBetsSeasonData racingBetsSeasonData2 = RacingBetsModel.Instance.GetRacingBetsSeasonData();
			return ((racingBetsSeasonData2 != null) ? racingBetsSeasonData2.GetMatchStateDisplayText() : null) ?? "";
		}

		// Token: 0x06033FEC RID: 212972 RVA: 0x00C30CD0 File Offset: 0x00C2EED0
		public string GetMatchStateDisplayTextForLeg(RacingBetsLegMatchData legMatchData)
		{
			ERacingBetsLegMatchState legMatchState = legMatchData.GetLegMatchState();
			bool isFinalMatch = this.IsFinalLegMatch(legMatchData.Id);
			string matchStateTimeTextKey = RacingBetsSeasonData.GetMatchStateTimeTextKey(legMatchState, isFinalMatch);
			if (string.IsNullOrEmpty(matchStateTimeTextKey))
			{
				return "";
			}
			double legRemindTime = legMatchData.GetLegRemindTime();
			if ((legMatchState != ERacingBetsLegMatchState.BettingPeriod && legMatchState != ERacingBetsLegMatchState.EndOfBetting) || legRemindTime <= 0.0)
			{
				return TextConfig.Instance.GetMultiTextByKey(matchStateTimeTextKey) ?? "";
			}
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(matchStateTimeTextKey);
			if (multiTextByKey == null)
			{
				return "";
			}
			string text = TimeUtil.Instance.GetRemainTimeDataFormat3(legRemindTime).CountDownText ?? "";
			return StringUtils.Format(multiTextByKey, new string[]
			{
				text
			});
		}

		// Token: 0x06033FED RID: 212973 RVA: 0x00C30D80 File Offset: 0x00C2EF80
		private static string GetMatchStateTimeTextKey(ERacingBetsLegMatchState state, bool isFinalMatch)
		{
			if (state == ERacingBetsLegMatchState.BettingPeriod)
			{
				return "Dango_ActivityPage_StatusTime_Bet";
			}
			if (state == ERacingBetsLegMatchState.EndOfBetting)
			{
				return "Dango_ActivityPage_StatusTime_Wait";
			}
			if (state == ERacingBetsLegMatchState.MatchPeriod)
			{
				return "Dango_ActivityPage_StatusTime_Race";
			}
			if (state != ERacingBetsLegMatchState.EndOfMatch)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RacingBets;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "当前比赛处于notOpen|end状态";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			if (!isFinalMatch)
			{
				return "Dango_ActivityPage_StatusTime_RaceEnd";
			}
			return "Dango_ActivityPage_StatusTime_FinalRaceEnd";
		}

		// Token: 0x0401B9C5 RID: 113093
		private const int OPEN_TIP_KEY = 1;

		// Token: 0x0401B9C6 RID: 113094
		private int AccumulateBetsCashCount;

		// Token: 0x0401B9C7 RID: 113095
		private TItem BetItemData;

		// Token: 0x0401B9C8 RID: 113096
		private RacingBetsSeason SeasonConfig;

		// Token: 0x0401B9C9 RID: 113097
		private int HitNum;

		// Token: 0x0401B9CA RID: 113098
		private readonly Dictionary<int, RacingBetsGroupMatchData> GroupMatchMap = new Dictionary<int, RacingBetsGroupMatchData>();

		// Token: 0x0401B9CB RID: 113099
		private readonly Dictionary<int, RacingBetsLegMatchData> LegMatchMap = new Dictionary<int, RacingBetsLegMatchData>();

		// Token: 0x0401B9CC RID: 113100
		private List<RacingBetsLegMatchData> LegMatchList = new List<RacingBetsLegMatchData>();

		// Token: 0x0401B9CD RID: 113101
		private readonly Dictionary<ERacingBetsRewardType, RacingBetsGroupRewardData> RewardGroupDataMap = new Dictionary<ERacingBetsRewardType, RacingBetsGroupRewardData>();

		// Token: 0x0401B9CE RID: 113102
		private readonly Dictionary<int, RacingBetsRewardData> RewardDataMap = new Dictionary<int, RacingBetsRewardData>();

		// Token: 0x0401B9CF RID: 113103
		private List<int> RankListUpdateTime = new List<int>();

		// Token: 0x0401B9D0 RID: 113104
		private List<int> CloseSettleLegMatchIdList = new List<int>();

		// Token: 0x0401B9D1 RID: 113105
		private bool IsInit;
	}
}
