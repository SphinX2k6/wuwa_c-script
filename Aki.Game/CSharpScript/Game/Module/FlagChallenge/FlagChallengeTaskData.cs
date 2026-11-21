using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A05 RID: 18949
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeTaskData
	{
		// Token: 0x0602F84E RID: 194638 RVA: 0x00D408A0 File Offset: 0x00D3EAA0
		public FlagChallengeTaskData(int id)
		{
			this.Id = id;
			this.TaskConfig = FlagChallengeConfig.Instance.GetTaskConfig(id).Value;
		}

		// Token: 0x0602F84F RID: 194639 RVA: 0x00D408D3 File Offset: 0x00D3EAD3
		public void Refresh(ConditionTask taskData)
		{
			this.TaskStatus = taskData.Status;
			this.TaskCurrent = taskData.Current;
			this.TaskTarget = taskData.Target;
		}

		// Token: 0x0602F850 RID: 194640 RVA: 0x00D408FC File Offset: 0x00D3EAFC
		public List<TItem> GetRewardList()
		{
			int dropId = this.TaskConfig.DropId;
			if (dropId <= 0)
			{
				return new List<TItem>();
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x0602F851 RID: 194641 RVA: 0x00D40930 File Offset: 0x00D3EB30
		public string GetRewardName()
		{
			return this.TaskConfig.RewardName;
		}

		// Token: 0x0602F852 RID: 194642 RVA: 0x00D4094C File Offset: 0x00D3EB4C
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

		// Token: 0x0602F853 RID: 194643 RVA: 0x00D409D1 File Offset: 0x00D3EBD1
		public void SetTaskStatus(ConditionTaskState status)
		{
			this.TaskStatus = status;
		}

		// Token: 0x0602F854 RID: 194644 RVA: 0x00D409DA File Offset: 0x00D3EBDA
		public ConditionTaskState GetTaskStatus()
		{
			return this.TaskStatus;
		}

		// Token: 0x0602F855 RID: 194645 RVA: 0x00D409E2 File Offset: 0x00D3EBE2
		public int GetTaskTarget()
		{
			return this.TaskTarget;
		}

		// Token: 0x0602F856 RID: 194646 RVA: 0x00D409EA File Offset: 0x00D3EBEA
		public bool CanReceiveReward()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x0602F857 RID: 194647 RVA: 0x00D409F5 File Offset: 0x00D3EBF5
		public bool IsTaskReceived()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x0602F858 RID: 194648 RVA: 0x00D40A00 File Offset: 0x00D3EC00
		public bool IsTaskRunning()
		{
			return this.TaskStatus == ConditionTaskState.ConditionTaskRunning;
		}

		// Token: 0x04019285 RID: 103045
		public readonly int Id;

		// Token: 0x04019286 RID: 103046
		public readonly FlagChallengeTask TaskConfig;

		// Token: 0x04019287 RID: 103047
		private ConditionTaskState TaskStatus;

		// Token: 0x04019288 RID: 103048
		private int TaskCurrent;

		// Token: 0x04019289 RID: 103049
		private int TaskTarget;
	}
}
