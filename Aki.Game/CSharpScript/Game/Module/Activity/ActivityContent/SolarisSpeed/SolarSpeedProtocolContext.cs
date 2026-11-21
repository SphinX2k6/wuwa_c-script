using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005028 RID: 20520
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedProtocolContext : ActivityBaseData
	{
		// Token: 0x060335E5 RID: 210405 RVA: 0x00E66ACB File Offset: 0x00E64CCB
		public SolarSpeedProtocolContext(SolarSpeedModel model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x060335E6 RID: 210406 RVA: 0x00E66AFB File Offset: 0x00E64CFB
		public void Dispose()
		{
			this.LevelMsgCache.Clear();
			this.TaskMsgCache.Clear();
		}

		// Token: 0x060335E7 RID: 210407 RVA: 0x00E66B14 File Offset: 0x00E64D14
		protected override void PhraseEx(ActivityData data)
		{
			TeamParkourLevelActivityInfo teamParkourLevelActivityInfo = data.TeamParkourLevelActivityInfo;
			if (teamParkourLevelActivityInfo != null)
			{
				this.ParseActivityInfo(teamParkourLevelActivityInfo);
			}
		}

		// Token: 0x060335E8 RID: 210408 RVA: 0x00E66B32 File Offset: 0x00E64D32
		public override bool GetExDataRedPointShowState()
		{
			return this.AttachedModel.HasRewardRedDot || this.AttachedModel.HasLevelRedDot;
		}

		// Token: 0x060335E9 RID: 210409 RVA: 0x00E66B50 File Offset: 0x00E64D50
		private void ParseActivityInfo(TeamParkourLevelActivityInfo data)
		{
			this.LevelMsgCache.Clear();
			this.TaskMsgCache.Clear();
			foreach (TeamParkourLevelPlayInfo teamParkourLevelPlayInfo in data.TeamParkourLevelPlayInfos)
			{
				this.LevelMsgCache[teamParkourLevelPlayInfo.LevelId] = teamParkourLevelPlayInfo;
			}
			if (data.ActivityTaskDatas != null)
			{
				foreach (ActivityTask activityTask in data.ActivityTaskDatas.ActivityTasks)
				{
					this.TaskMsgCache[activityTask.Id] = activityTask;
				}
			}
		}

		// Token: 0x060335EA RID: 210410 RVA: 0x00E66C14 File Offset: 0x00E64E14
		public void ParseTeamParkourTaskNotify(TeamParkourTaskNotify msg)
		{
			ActivityTask activityTask = msg.ActivityTask;
			if (activityTask == null)
			{
				return;
			}
			this.TaskMsgCache[activityTask.Id] = activityTask;
		}

		// Token: 0x060335EB RID: 210411 RVA: 0x00E66C40 File Offset: 0x00E64E40
		public void ParseTeamParkourSettleNotify(TeamParkourSettleNotify msg)
		{
			this.ResetTeamParkourSettleCache();
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (PlayerSettleInfo playerSettleInfo in msg.PlayerSettleInfos)
			{
				this.PlayerSettleMsgCache[playerSettleInfo.PlayerId] = playerSettleInfo;
				int? num = id;
				int playerId = playerSettleInfo.PlayerId;
				if (num.GetValueOrDefault() == playerId & num != null)
				{
					this.CurrentRankPointsCache = playerSettleInfo.RankPoints;
					this.CurrentDistancePointsCache = playerSettleInfo.DistancePoints;
					TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
					if (this.LevelMsgCache.TryGetValue(msg.LevelId, out teamParkourLevelPlayInfo))
					{
						if (teamParkourLevelPlayInfo.Ranking == 0 || playerSettleInfo.Ranking < teamParkourLevelPlayInfo.Ranking)
						{
							teamParkourLevelPlayInfo.Ranking = playerSettleInfo.Ranking;
						}
						int num2 = playerSettleInfo.RankPoints + playerSettleInfo.DistancePoints;
						if (num2 > teamParkourLevelPlayInfo.Score)
						{
							teamParkourLevelPlayInfo.Score = num2;
						}
						if (teamParkourLevelPlayInfo.TimeCost == 0)
						{
							teamParkourLevelPlayInfo.TimeCost = playerSettleInfo.ConsumeTime;
						}
						else if (playerSettleInfo.ConsumeTime != 0 && playerSettleInfo.ConsumeTime < teamParkourLevelPlayInfo.TimeCost)
						{
							teamParkourLevelPlayInfo.TimeCost = playerSettleInfo.ConsumeTime;
						}
					}
				}
			}
		}

		// Token: 0x060335EC RID: 210412 RVA: 0x00E66D94 File Offset: 0x00E64F94
		public void ResetTeamParkourSettleCache()
		{
			this.CurrentRankPointsCache = 0;
			this.CurrentDistancePointsCache = 0;
			this.PlayerSettleMsgCache.Clear();
		}

		// Token: 0x060335ED RID: 210413 RVA: 0x00E66DB0 File Offset: 0x00E64FB0
		public int GetScoreById(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.Score;
		}

		// Token: 0x060335EE RID: 210414 RVA: 0x00E66DD8 File Offset: 0x00E64FD8
		public int GetRankingById(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.Ranking;
		}

		// Token: 0x060335EF RID: 210415 RVA: 0x00E66E00 File Offset: 0x00E65000
		public int GetStartTime(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.StartTime;
		}

		// Token: 0x060335F0 RID: 210416 RVA: 0x00E66E28 File Offset: 0x00E65028
		public int GetLapRecord(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.TimeCost;
		}

		// Token: 0x060335F1 RID: 210417 RVA: 0x00E66E50 File Offset: 0x00E65050
		public int GetCurrentProgressById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Current;
		}

		// Token: 0x060335F2 RID: 210418 RVA: 0x00E66E78 File Offset: 0x00E65078
		public int GetCurrentProgressTargetById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Target;
		}

		// Token: 0x060335F3 RID: 210419 RVA: 0x00E66EA0 File Offset: 0x00E650A0
		public ActivityTaskState? GetTaskStateById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return null;
			}
			return new ActivityTaskState?(activityTask.Status);
		}

		// Token: 0x060335F4 RID: 210420 RVA: 0x00E66ED4 File Offset: 0x00E650D4
		public void SetTaskStateRewardedById(int id)
		{
			ActivityTask activityTask;
			if (this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				activityTask.Status = ActivityTaskState.ActivityTaskTaken;
			}
		}

		// Token: 0x0401B4BD RID: 111805
		private readonly SolarSpeedModel AttachedModel;

		// Token: 0x0401B4BE RID: 111806
		private readonly Dictionary<int, TeamParkourLevelPlayInfo> LevelMsgCache = new Dictionary<int, TeamParkourLevelPlayInfo>();

		// Token: 0x0401B4BF RID: 111807
		private readonly Dictionary<int, ActivityTask> TaskMsgCache = new Dictionary<int, ActivityTask>();

		// Token: 0x0401B4C0 RID: 111808
		public int CurrentRankPointsCache;

		// Token: 0x0401B4C1 RID: 111809
		public int CurrentDistancePointsCache;

		// Token: 0x0401B4C2 RID: 111810
		public readonly Dictionary<int, PlayerSettleInfo> PlayerSettleMsgCache = new Dictionary<int, PlayerSettleInfo>();
	}
}
