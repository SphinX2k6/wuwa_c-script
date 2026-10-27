using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004869 RID: 18537
	public class VillageInfrLimitTaskData
	{
		// Token: 0x06030862 RID: 198754 RVA: 0x00B44700 File Offset: 0x00B42900
		public VillageInfrLimitTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x1700792B RID: 31019
		// (get) Token: 0x06030863 RID: 198755 RVA: 0x00B44718 File Offset: 0x00B42918
		private InfrV2Reward Config
		{
			get
			{
				return VillageInfrConfig.Instance.GetInfrActivityTaskConfig(this.ConfigId).Value;
			}
		}

		// Token: 0x1700792C RID: 31020
		// (get) Token: 0x06030864 RID: 198756 RVA: 0x00B44740 File Offset: 0x00B42940
		public int TaskReward
		{
			get
			{
				return this.Config.DropId;
			}
		}

		// Token: 0x06030865 RID: 198757 RVA: 0x00B4475B File Offset: 0x00B4295B
		[NullableContext(1)]
		public void UpdateData(ConditionTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = data.Status;
		}

		// Token: 0x06030866 RID: 198758 RVA: 0x00B44781 File Offset: 0x00B42981
		public bool CanReceive()
		{
			return this.Status == ConditionTaskState.ConditionTaskFinish;
		}

		// Token: 0x0401A0F3 RID: 106739
		public int ConfigId;

		// Token: 0x0401A0F4 RID: 106740
		public int Current;

		// Token: 0x0401A0F5 RID: 106741
		public int Target = 1;

		// Token: 0x0401A0F6 RID: 106742
		public int Index;

		// Token: 0x0401A0F7 RID: 106743
		public ConditionTaskState Status;
	}
}
