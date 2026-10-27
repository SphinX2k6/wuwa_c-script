using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A29 RID: 23081
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeTaskData
	{
		// Token: 0x0603A905 RID: 239877 RVA: 0x00DF031C File Offset: 0x00DEE51C
		public FlagChallengeTaskData(int id)
		{
			this.Id = id;
			this.TaskConfig = FlagChallengeConfig.Instance.GetTaskConfig(id).Value;
		}

		// Token: 0x0603A906 RID: 239878 RVA: 0x00DF034F File Offset: 0x00DEE54F
		public void Refresh(ConditionTask taskData)
		{
			this.TaskStatus = taskData.Status;
			this.TaskCurrent = taskData.Current;
			this.TaskTarget = taskData.Target;
		}

		// Token: 0x0603A907 RID: 239879 RVA: 0x00DF0378 File Offset: 0x00DEE578
		public List<TItem> GetRewardList()
		{
			int dropId = this.TaskConfig.DropId;
			if (dropId <= 0)
			{
				return new List<TItem>();
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x0603A908 RID: 239880 RVA: 0x00DF03AC File Offset: 0x00DEE5AC
		public string GetRewardName()
		{
			return this.TaskConfig.RewardName;
		}

		// Token: 0x0603A909 RID: 239881 RVA: 0x00DF03C8 File Offset: 0x00DEE5C8
		public string GetProgressText()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (this.TaskStatus == ConditionTaskState.ConditionTaskRunning)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskCurrent);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0603A90A RID: 239882 RVA: 0x00DF044D File Offset: 0x00DEE64D
		public void SetTaskStatus(ConditionTaskState status)
		{
			this.TaskStatus = status;
		}

		// Token: 0x0603A90B RID: 239883 RVA: 0x00DF0456 File Offset: 0x00DEE656
		public ConditionTaskState GetTaskStatus()
		{
			return this.TaskStatus;
		}

		// Token: 0x0603A90C RID: 239884 RVA: 0x00DF045E File Offset: 0x00DEE65E
		public int GetTaskTarget()
		{
			return this.TaskTarget;
		}

		// Token: 0x0603A90D RID: 239885 RVA: 0x00DF0466 File Offset: 0x00DEE666
		public bool CanReceiveReward()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x0603A90E RID: 239886 RVA: 0x00DF0471 File Offset: 0x00DEE671
		public bool IsTaskReceived()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x0603A90F RID: 239887 RVA: 0x00DF047C File Offset: 0x00DEE67C
		public bool IsTaskRunning()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskRunning;
		}

		// Token: 0x0401E7DE RID: 124894
		public readonly int Id;

		// Token: 0x0401E7DF RID: 124895
		public readonly FlagChallengeTask TaskConfig;

		// Token: 0x0401E7E0 RID: 124896
		private ConditionTaskState TaskStatus;

		// Token: 0x0401E7E1 RID: 124897
		private int TaskCurrent;

		// Token: 0x0401E7E2 RID: 124898
		private int TaskTarget;
	}
}
