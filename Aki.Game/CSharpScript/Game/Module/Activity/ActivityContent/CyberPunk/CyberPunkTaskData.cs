using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068B1 RID: 26801
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskData
	{
		// Token: 0x06042E47 RID: 273991 RVA: 0x01049107 File Offset: 0x01047307
		public void Refresh(ConditionTask task)
		{
			this.Id = task.Id;
			this.Current = task.Current;
			this.Target = task.Target;
			this.Status = task.Status;
			this.InitRewardList();
			this.InitQuestName();
		}

		// Token: 0x06042E48 RID: 273992 RVA: 0x01049148 File Offset: 0x01047348
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

		// Token: 0x06042E49 RID: 273993 RVA: 0x010491A8 File Offset: 0x010473A8
		public void InitQuestName()
		{
			EdgeRunnerReward? config = ConfigEdgeRunnerRewardById.GetConfig(this.Id, true);
			this.QuestName = (((config != null) ? config.GetValueOrDefault().Desc : null) ?? "");
		}

		// Token: 0x06042E4A RID: 273994 RVA: 0x010491EC File Offset: 0x010473EC
		public void SetClaimed()
		{
			this.Status = ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x06042E4B RID: 273995 RVA: 0x010491F8 File Offset: 0x010473F8
		public string GetProgressText()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Target);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042E4C RID: 273996 RVA: 0x0104923B File Offset: 0x0104743B
		public bool IsFinished()
		{
			return this.Status == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x06042E4D RID: 273997 RVA: 0x01049246 File Offset: 0x01047446
		public bool IsClaimed()
		{
			return this.Status == ConditionTaskState.ConditionTaskTaken;
		}

		// Token: 0x06042E4E RID: 273998 RVA: 0x01049251 File Offset: 0x01047451
		public bool IsActive()
		{
			return this.Status == ConditionTaskState.ConditionTaskRunning;
		}

		// Token: 0x04022CC9 RID: 142537
		public int Id;

		// Token: 0x04022CCA RID: 142538
		public int Current;

		// Token: 0x04022CCB RID: 142539
		public int Target = 1;

		// Token: 0x04022CCC RID: 142540
		public ConditionTaskState Status;

		// Token: 0x04022CCD RID: 142541
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x04022CCE RID: 142542
		public string QuestName = "";
	}
}
