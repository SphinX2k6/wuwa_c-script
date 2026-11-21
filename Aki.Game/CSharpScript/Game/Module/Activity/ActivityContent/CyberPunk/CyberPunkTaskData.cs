using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005801 RID: 22529
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskData
	{
		// Token: 0x0603799F RID: 227743 RVA: 0x00F8A72F File Offset: 0x00F8892F
		public void Refresh(ConditionTask task)
		{
			this.Id = task.Id;
			this.Current = task.Current;
			this.Target = task.Target;
			this.Status = task.Status;
			this.InitRewardList();
			this.InitQuestName();
		}

		// Token: 0x060379A0 RID: 227744 RVA: 0x00F8A770 File Offset: 0x00F88970
		public void InitRewardList()
		{
			EdgeRunnerReward? config = ConfigEdgeRunnerRewardById.GetConfig(this.Id, true);
			if (config != null && config.Value.DropId > 0)
			{
				this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.Value.DropId);
				return;
			}
			this.RewardList = new List<TItem>();
		}

		// Token: 0x060379A1 RID: 227745 RVA: 0x00F8A7D0 File Offset: 0x00F889D0
		public void InitQuestName()
		{
			EdgeRunnerReward? config = ConfigEdgeRunnerRewardById.GetConfig(this.Id, true);
			this.QuestName = (((config != null) ? config.GetValueOrDefault().Desc : null) ?? "");
		}

		// Token: 0x060379A2 RID: 227746 RVA: 0x00F8A814 File Offset: 0x00F88A14
		public void SetClaimed()
		{
			this.Status = ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x060379A3 RID: 227747 RVA: 0x00F8A820 File Offset: 0x00F88A20
		public string GetProgressText()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Target);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060379A4 RID: 227748 RVA: 0x00F8A863 File Offset: 0x00F88A63
		public bool IsFinished()
		{
			return this.Status == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x060379A5 RID: 227749 RVA: 0x00F8A86E File Offset: 0x00F88A6E
		public bool IsClaimed()
		{
			return this.Status == ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x060379A6 RID: 227750 RVA: 0x00F8A879 File Offset: 0x00F88A79
		public bool IsActive()
		{
			return this.Status == ConditionTaskState.ConditionTaskRunning;
		}

		// Token: 0x0401D525 RID: 120101
		public int Id;

		// Token: 0x0401D526 RID: 120102
		public int Current;

		// Token: 0x0401D527 RID: 120103
		public int Target = 1;

		// Token: 0x0401D528 RID: 120104
		public ConditionTaskState Status;

		// Token: 0x0401D529 RID: 120105
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401D52A RID: 120106
		public string QuestName = "";
	}
}
