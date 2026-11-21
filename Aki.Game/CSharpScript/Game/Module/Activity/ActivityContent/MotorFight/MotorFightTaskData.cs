using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005382 RID: 21378
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTaskData
	{
		// Token: 0x06035350 RID: 217936 RVA: 0x00EDBF65 File Offset: 0x00EDA165
		public MotorFightTaskData(MotorFightTask config)
		{
			this.Config = config;
			this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
		}

		// Token: 0x170067CB RID: 26571
		// (get) Token: 0x06035351 RID: 217937 RVA: 0x00EDBF9D File Offset: 0x00EDA19D
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x06035352 RID: 217938 RVA: 0x00EDBFA8 File Offset: 0x00EDA1A8
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x06035353 RID: 217939 RVA: 0x00EDBFB3 File Offset: 0x00EDA1B3
		public bool IsDoing
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x170067CE RID: 26574
		// (get) Token: 0x06035354 RID: 217940 RVA: 0x00EDBFC0 File Offset: 0x00EDA1C0
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170067CF RID: 26575
		// (get) Token: 0x06035355 RID: 217941 RVA: 0x00EDBFDC File Offset: 0x00EDA1DC
		public string TaskName
		{
			get
			{
				return this.Config.TaskName;
			}
		}

		// Token: 0x0401C113 RID: 114963
		private readonly MotorFightTask Config;

		// Token: 0x0401C114 RID: 114964
		public int Current;

		// Token: 0x0401C115 RID: 114965
		public int Target;

		// Token: 0x0401C116 RID: 114966
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401C117 RID: 114967
		public List<TItem> RewardList = new List<TItem>();
	}
}
