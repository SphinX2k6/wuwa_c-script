using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060AA RID: 24746
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedProtocolContext : ActivityBaseData
	{
		// Token: 0x0603E921 RID: 256289 RVA: 0x00F1FD07 File Offset: 0x00F1DF07
		public SolarSpeedProtocolContext(SolarSpeedModel model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x0603E922 RID: 256290 RVA: 0x00F1FD37 File Offset: 0x00F1DF37
		public void Dispose()
		{
			this.LevelMsgCache.Clear();
			this.TaskMsgCache.Clear();
		}

		// Token: 0x0603E923 RID: 256291 RVA: 0x00F1FD50 File Offset: 0x00F1DF50
		protected override void PhraseEx(ActivityData data)
		{
			TeamParkourLevelActivityInfo teamParkourLevelActivityInfo = data.TeamParkourLevelActivityInfo;
			if (teamParkourLevelActivityInfo != null)
			{
				this.ParseActivityInfo(teamParkourLevelActivityInfo);
			}
		}

		// Token: 0x0603E924 RID: 256292 RVA: 0x00F1FD6E File Offset: 0x00F1DF6E
		public override bool GetExDataRedPointShowState()
		{
			return this.AttachedModel.HasRewardRedDot || this.AttachedModel.HasLevelRedDot;
		}

		// Token: 0x0603E925 RID: 256293 RVA: 0x00F1FD8C File Offset: 0x00F1DF8C
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

		// Token: 0x0603E926 RID: 256294 RVA: 0x00F1FE50 File Offset: 0x00F1E050
		public void ParseTeamParkourTaskNotify(TeamParkourTaskNotify msg)
		{
			ActivityTask activityTask = msg.ActivityTask;
			if (activityTask == null)
			{
				return;
			}
			this.TaskMsgCache[activityTask.Id] = activityTask;
		}

		// Token: 0x0603E927 RID: 256295 RVA: 0x00F1FE7C File Offset: 0x00F1E07C
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

		// Token: 0x0603E928 RID: 256296 RVA: 0x00F1FFD0 File Offset: 0x00F1E1D0
		public void ResetTeamParkourSettleCache()
		{
			this.CurrentRankPointsCache = 0;
			this.CurrentDistancePointsCache = 0;
			this.PlayerSettleMsgCache.Clear();
		}

		// Token: 0x0603E929 RID: 256297 RVA: 0x00F1FFEC File Offset: 0x00F1E1EC
		public int GetScoreById(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.Score;
		}

		// Token: 0x0603E92A RID: 256298 RVA: 0x00F20014 File Offset: 0x00F1E214
		public int GetRankingById(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.Ranking;
		}

		// Token: 0x0603E92B RID: 256299 RVA: 0x00F2003C File Offset: 0x00F1E23C
		public int GetStartTime(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.StartTime;
		}

		// Token: 0x0603E92C RID: 256300 RVA: 0x00F20064 File Offset: 0x00F1E264
		public int GetLapRecord(int id)
		{
			TeamParkourLevelPlayInfo teamParkourLevelPlayInfo;
			if (!this.LevelMsgCache.TryGetValue(id, out teamParkourLevelPlayInfo))
			{
				return 0;
			}
			return teamParkourLevelPlayInfo.TimeCost;
		}

		// Token: 0x0603E92D RID: 256301 RVA: 0x00F2008C File Offset: 0x00F1E28C
		public int GetCurrentProgressById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Current;
		}

		// Token: 0x0603E92E RID: 256302 RVA: 0x00F200B4 File Offset: 0x00F1E2B4
		public int GetCurrentProgressTargetById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return 0;
			}
			return activityTask.Target;
		}

		// Token: 0x0603E92F RID: 256303 RVA: 0x00F200DC File Offset: 0x00F1E2DC
		public ActivityTaskState? GetTaskStateById(int id)
		{
			ActivityTask activityTask;
			if (!this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				return null;
			}
			return new ActivityTaskState?(activityTask.Status);
		}

		// Token: 0x0603E930 RID: 256304 RVA: 0x00F20110 File Offset: 0x00F1E310
		public void SetTaskStateRewardedById(int id)
		{
			ActivityTask activityTask;
			if (this.TaskMsgCache.TryGetValue(id, out activityTask))
			{
				activityTask.Status = ActivityTaskState.ActivityTaskTaken;
			}
		}

		// Token: 0x04020B90 RID: 134032
		private readonly SolarSpeedModel AttachedModel;

		// Token: 0x04020B91 RID: 134033
		private readonly Dictionary<int, TeamParkourLevelPlayInfo> LevelMsgCache = new Dictionary<int, TeamParkourLevelPlayInfo>();

		// Token: 0x04020B92 RID: 134034
		private readonly Dictionary<int, ActivityTask> TaskMsgCache = new Dictionary<int, ActivityTask>();

		// Token: 0x04020B93 RID: 134035
		public int CurrentRankPointsCache;

		// Token: 0x04020B94 RID: 134036
		public int CurrentDistancePointsCache;

		// Token: 0x04020B95 RID: 134037
		public readonly Dictionary<int, PlayerSettleInfo> PlayerSettleMsgCache = new Dictionary<int, PlayerSettleInfo>();
	}
}
