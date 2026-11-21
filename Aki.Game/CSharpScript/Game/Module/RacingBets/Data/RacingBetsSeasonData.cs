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
	// Token: 0x02003EF5 RID: 16117
	[NullableContext(1)]
	[Nullable(0)]
	public class RacingBetsSeasonData : ActivityBaseData
	{
		// Token: 0x06028E30 RID: 167472 RVA: 0x00B7976C File Offset: 0x00B7796C
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

		// Token: 0x06028E31 RID: 167473 RVA: 0x00B79848 File Offset: 0x00B77A48
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

		// Token: 0x06028E32 RID: 167474 RVA: 0x00B798B4 File Offset: 0x00B77AB4
		public void RefreshMatchInfo(RacingBetsMatchInfoResponse message)
		{
			this.RefreshMatchData(new List<RacingBetsGroupMatchesInfo>(message.MatchInfos));
		}

		// Token: 0x06028E33 RID: 167475 RVA: 0x00B798C7 File Offset: 0x00B77AC7
		protected override void OnActivityClose()
		{
			RacingBetsController.Instance.TryLeaveRacingBetsDungeon();
		}

		// Token: 0x06028E34 RID: 167476 RVA: 0x00B798D4 File Offset: 0x00B77AD4
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

		// Token: 0x06028E35 RID: 167477 RVA: 0x00B7998C File Offset: 0x00B77B8C
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

		// Token: 0x06028E36 RID: 167478 RVA: 0x00B79B08 File Offset: 0x00B77D08
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

		// Token: 0x06028E37 RID: 167479 RVA: 0x00B79BA0 File Offset: 0x00B77DA0
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

		// Token: 0x06028E38 RID: 167480 RVA: 0x00B79C70 File Offset: 0x00B77E70
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

		// Token: 0x06028E39 RID: 167481 RVA: 0x00B79D34 File Offset: 0x00B77F34
		private void RefreshBetsInfo(List<RacingBetsGearInfo> betsInfo)
		{
			foreach (RacingBetsGearInfo racingBetsGearInfo in betsInfo)
			{
				this.GetLegMatchData(racingBetsGearInfo.LegMatchesId).RefreshBetInfo(racingBetsGearInfo);
			}
		}

		// Token: 0x06028E3A RID: 167482 RVA: 0x00B79D90 File Offset: 0x00B77F90
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

		// Token: 0x06028E3B RID: 167483 RVA: 0x00B79E24 File Offset: 0x00B78024
		public void RefreshRewardData(IEnumerable<ConditionTaskData> taskDataList)
		{
			foreach (ConditionTaskData conditionTaskData in taskDataList)
			{
				this.GetRewardData(conditionTaskData.Id).Refresh(conditionTaskData);
			}
		}

		// Token: 0x06028E3C RID: 167484 RVA: 0x00B79E78 File Offset: 0x00B78078
		private void InitRankUpdateTime(RepeatedField<long> rankTimeList)
		{
			int count = rankTimeList.Count;
			this.RankListUpdateTime = new List<int>(count);
			for (int i = 0; i < count; i++)
			{
				this.RankListUpdateTime.Add((int)MathUtils.Instance.LongToNumber(rankTimeList[i]));
			}
		}

		// Token: 0x06028E3D RID: 167485 RVA: 0x00B79EC1 File Offset: 0x00B780C1
		private void InitCloseSettleLegMatchIdList(List<int> closeSettleLegMatchIdList)
		{
			this.CloseSettleLegMatchIdList = closeSettleLegMatchIdList;
		}

		// Token: 0x06028E3E RID: 167486 RVA: 0x00B79ECA File Offset: 0x00B780CA
		public void AddCloseSettleLegMatchId(int legMatchId)
		{
			if (this.CloseSettleLegMatchIdList.Contains(legMatchId))
			{
				return;
			}
			this.CloseSettleLegMatchIdList.Add(legMatchId);
		}

		// Token: 0x06028E3F RID: 167487 RVA: 0x00B79EE7 File Offset: 0x00B780E7
		public TItem GetBetItemData()
		{
			return this.BetItemData;
		}

		// Token: 0x06028E40 RID: 167488 RVA: 0x00B79EEF File Offset: 0x00B780EF
		public RacingBetsSeason GetSeasonConfig()
		{
			return this.SeasonConfig;
		}

		// Token: 0x06028E41 RID: 167489 RVA: 0x00B79EF7 File Offset: 0x00B780F7
		public int GetTotalBetCount()
		{
			return this.AccumulateBetsCashCount;
		}

		// Token: 0x06028E42 RID: 167490 RVA: 0x00B79F00 File Offset: 0x00B78100
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

		// Token: 0x06028E43 RID: 167491 RVA: 0x00B79F50 File Offset: 0x00B78150
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

		// Token: 0x06028E44 RID: 167492 RVA: 0x00B79FA0 File Offset: 0x00B781A0
		[NullableContext(2)]
		public RacingBetsLegMatchData GetCurLegMatchData()
		{
			int curLegMatchDataIndex = this.GetCurLegMatchDataIndex();
			return this.GetLegMatchDataByIndex(curLegMatchDataIndex);
		}

		// Token: 0x06028E45 RID: 167493 RVA: 0x00B79FBC File Offset: 0x00B781BC
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

		// Token: 0x06028E46 RID: 167494 RVA: 0x00B7A00D File Offset: 0x00B7820D
		[NullableContext(2)]
		public RacingBetsLegMatchData GetLegMatchDataByIndex(int index)
		{
			if (index < 0 || index > this.LegMatchList.Count)
			{
				return null;
			}
			return this.LegMatchList[index];
		}

		// Token: 0x06028E47 RID: 167495 RVA: 0x00B7A030 File Offset: 0x00B78230
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

		// Token: 0x06028E48 RID: 167496 RVA: 0x00B7A090 File Offset: 0x00B78290
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

		// Token: 0x06028E49 RID: 167497 RVA: 0x00B7A0F4 File Offset: 0x00B782F4
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

		// Token: 0x06028E4A RID: 167498 RVA: 0x00B7A134 File Offset: 0x00B78334
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

		// Token: 0x06028E4B RID: 167499 RVA: 0x00B7A18C File Offset: 0x00B7838C
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

		// Token: 0x06028E4C RID: 167500 RVA: 0x00B7A1D8 File Offset: 0x00B783D8
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

		// Token: 0x06028E4D RID: 167501 RVA: 0x00B7A214 File Offset: 0x00B78414
		[NullableContext(2)]
		public RacingBetsLegMatchData GetNextLegMatchData(int legMatchId)
		{
			int nextLegMatchIndex = this.GetNextLegMatchIndex(legMatchId);
			return this.GetLegMatchDataByIndex(nextLegMatchIndex);
		}

		// Token: 0x06028E4E RID: 167502 RVA: 0x00B7A230 File Offset: 0x00B78430
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

		// Token: 0x06028E4F RID: 167503 RVA: 0x00B7A28C File Offset: 0x00B7848C
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

		// Token: 0x06028E50 RID: 167504 RVA: 0x00B7A2DC File Offset: 0x00B784DC
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

		// Token: 0x06028E51 RID: 167505 RVA: 0x00B7A310 File Offset: 0x00B78510
		public int GetHitNum()
		{
			return this.HitNum;
		}

		// Token: 0x06028E52 RID: 167506 RVA: 0x00B7A318 File Offset: 0x00B78518
		public int GetCurrencyItemId()
		{
			return this.SeasonConfig.MoneyId;
		}

		// Token: 0x06028E53 RID: 167507 RVA: 0x00B7A325 File Offset: 0x00B78525
		public int GetCurrencyCount()
		{
			return InventoryModel.Instance.GetCommonItemCount(this.SeasonConfig.MoneyId, 0);
		}

		// Token: 0x06028E54 RID: 167508 RVA: 0x00B7A33D File Offset: 0x00B7853D
		public int GetBetCostCount(RacingBettingGear gearConfig)
		{
			return (int)Math.Ceiling((double)(this.GetCurrencyCount() * gearConfig.Odds) / 100.0);
		}

		// Token: 0x06028E55 RID: 167509 RVA: 0x00B7A35E File Offset: 0x00B7855E
		public bool GetActivityTipNeedShowState()
		{
			return this.CheckIfInOpenTime() && this.CheckIfInShowTime() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, 0, 0) == 0;
		}

		// Token: 0x06028E56 RID: 167510 RVA: 0x00B7A389 File Offset: 0x00B78589
		public bool CheckLegMatchIsCloseSettle(int legMatchId)
		{
			return this.CloseSettleLegMatchIdList.Contains(legMatchId);
		}

		// Token: 0x06028E57 RID: 167511 RVA: 0x00B7A398 File Offset: 0x00B78598
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

		// Token: 0x06028E58 RID: 167512 RVA: 0x00B7A404 File Offset: 0x00B78604
		public string GetMatchStateDisplayText()
		{
			RacingBetsLegMatchData legMatchDataForMatchStateText = this.GetLegMatchDataForMatchStateText();
			if (legMatchDataForMatchStateText == null)
			{
				return "";
			}
			return this.GetMatchStateDisplayTextForLeg(legMatchDataForMatchStateText);
		}

		// Token: 0x06028E59 RID: 167513 RVA: 0x00B7A428 File Offset: 0x00B78628
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

		// Token: 0x06028E5A RID: 167514 RVA: 0x00B7A470 File Offset: 0x00B78670
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

		// Token: 0x06028E5B RID: 167515 RVA: 0x00B7A520 File Offset: 0x00B78720
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

		// Token: 0x0401639A RID: 91034
		private const int OPEN_TIP_KEY = 1;

		// Token: 0x0401639B RID: 91035
		private int AccumulateBetsCashCount;

		// Token: 0x0401639C RID: 91036
		private TItem BetItemData;

		// Token: 0x0401639D RID: 91037
		private RacingBetsSeason SeasonConfig;

		// Token: 0x0401639E RID: 91038
		private int HitNum;

		// Token: 0x0401639F RID: 91039
		private readonly Dictionary<int, RacingBetsGroupMatchData> GroupMatchMap = new Dictionary<int, RacingBetsGroupMatchData>();

		// Token: 0x040163A0 RID: 91040
		private readonly Dictionary<int, RacingBetsLegMatchData> LegMatchMap = new Dictionary<int, RacingBetsLegMatchData>();

		// Token: 0x040163A1 RID: 91041
		private List<RacingBetsLegMatchData> LegMatchList = new List<RacingBetsLegMatchData>();

		// Token: 0x040163A2 RID: 91042
		private readonly Dictionary<ERacingBetsRewardType, RacingBetsGroupRewardData> RewardGroupDataMap = new Dictionary<ERacingBetsRewardType, RacingBetsGroupRewardData>();

		// Token: 0x040163A3 RID: 91043
		private readonly Dictionary<int, RacingBetsRewardData> RewardDataMap = new Dictionary<int, RacingBetsRewardData>();

		// Token: 0x040163A4 RID: 91044
		private List<int> RankListUpdateTime = new List<int>();

		// Token: 0x040163A5 RID: 91045
		private List<int> CloseSettleLegMatchIdList = new List<int>();

		// Token: 0x040163A6 RID: 91046
		private bool IsInit;
	}
}
