using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048D8 RID: 18648
	public class InfrastructureLimitTaskData
	{
		// Token: 0x0602EC7F RID: 191615 RVA: 0x00D0BC06 File Offset: 0x00D09E06
		public InfrastructureLimitTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x0602EC80 RID: 191616 RVA: 0x00D0BC1C File Offset: 0x00D09E1C
		private InfrActivityTask Config
		{
			get
			{
				return InfrastructureConfig.Instance.GetInfrActivityTaskConfig(this.ConfigId).Value;
			}
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x0602EC81 RID: 191617 RVA: 0x00D0BC44 File Offset: 0x00D09E44
		public int TaskReward
		{
			get
			{
				return this.Config.TaskReward;
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x0602EC82 RID: 191618 RVA: 0x00D0BC60 File Offset: 0x00D09E60
		public int JumpId
		{
			get
			{
				return this.Config.JumpId;
			}
		}

		// Token: 0x0602EC83 RID: 191619 RVA: 0x00D0BC7B File Offset: 0x00D09E7B
		[NullableContext(1)]
		public void UpdateData(ActivityTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = data.Status;
		}

		// Token: 0x04018D78 RID: 101752
		public int ConfigId;

		// Token: 0x04018D79 RID: 101753
		public int Current;

		// Token: 0x04018D7A RID: 101754
		public int Target = 1;

		// Token: 0x04018D7B RID: 101755
		public int Index;

		// Token: 0x04018D7C RID: 101756
		public ActivityTaskState Status;
	}
}
