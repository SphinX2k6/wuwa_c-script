using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037E0 RID: 14304
	public class VillageInfrLimitTaskData
	{
		// Token: 0x0602538E RID: 152462 RVA: 0x00A7F49C File Offset: 0x00A7D69C
		public VillageInfrLimitTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x0602538F RID: 152463 RVA: 0x00A7F4B4 File Offset: 0x00A7D6B4
		private InfrV2Reward Config
		{
			get
			{
				return VillageInfrConfig.Instance.GetInfrActivityTaskConfig(this.ConfigId).Value;
			}
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x06025390 RID: 152464 RVA: 0x00A7F4DC File Offset: 0x00A7D6DC
		public int TaskReward
		{
			get
			{
				return this.Config.DropId;
			}
		}

		// Token: 0x06025391 RID: 152465 RVA: 0x00A7F4F7 File Offset: 0x00A7D6F7
		[NullableContext(1)]
		public void UpdateData(ConditionTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = data.Status;
		}

		// Token: 0x06025392 RID: 152466 RVA: 0x00A7F51D File Offset: 0x00A7D71D
		public bool CanReceive()
		{
			return this.Status == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x04014966 RID: 84326
		public int ConfigId;

		// Token: 0x04014967 RID: 84327
		public int Current;

		// Token: 0x04014968 RID: 84328
		public int Target = 1;

		// Token: 0x04014969 RID: 84329
		public int Index;

		// Token: 0x0401496A RID: 84330
		public ConditionTaskState Status;
	}
}
