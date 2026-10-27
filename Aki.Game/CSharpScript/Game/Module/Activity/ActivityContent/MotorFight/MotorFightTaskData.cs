using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006404 RID: 25604
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTaskData
	{
		// Token: 0x0604068F RID: 263823 RVA: 0x00F94FC5 File Offset: 0x00F931C5
		public MotorFightTaskData(MotorFightTask config)
		{
			this.Config = config;
			this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
		}

		// Token: 0x17009469 RID: 37993
		// (get) Token: 0x06040690 RID: 263824 RVA: 0x00F94FFD File Offset: 0x00F931FD
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x1700946A RID: 37994
		// (get) Token: 0x06040691 RID: 263825 RVA: 0x00F95008 File Offset: 0x00F93208
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x1700946B RID: 37995
		// (get) Token: 0x06040692 RID: 263826 RVA: 0x00F95013 File Offset: 0x00F93213
		public bool IsDoing
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x1700946C RID: 37996
		// (get) Token: 0x06040693 RID: 263827 RVA: 0x00F95020 File Offset: 0x00F93220
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x1700946D RID: 37997
		// (get) Token: 0x06040694 RID: 263828 RVA: 0x00F9503C File Offset: 0x00F9323C
		public string TaskName
		{
			get
			{
				return this.Config.TaskName;
			}
		}

		// Token: 0x040217E4 RID: 137188
		private readonly MotorFightTask Config;

		// Token: 0x040217E5 RID: 137189
		public int Current;

		// Token: 0x040217E6 RID: 137190
		public int Target;

		// Token: 0x040217E7 RID: 137191
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x040217E8 RID: 137192
		public List<TItem> RewardList = new List<TItem>();
	}
}
