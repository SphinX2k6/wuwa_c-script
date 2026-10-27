using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020058FF RID: 22783
	public class InfrastructureLimitTaskData
	{
		// Token: 0x06039D59 RID: 236889 RVA: 0x00DBCC0E File Offset: 0x00DBAE0E
		public InfrastructureLimitTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x17008AC6 RID: 35526
		// (get) Token: 0x06039D5A RID: 236890 RVA: 0x00DBCC24 File Offset: 0x00DBAE24
		private InfrActivityTask Config
		{
			get
			{
				return InfrastructureConfig.Instance.GetInfrActivityTaskConfig(this.ConfigId).Value;
			}
		}

		// Token: 0x17008AC7 RID: 35527
		// (get) Token: 0x06039D5B RID: 236891 RVA: 0x00DBCC4C File Offset: 0x00DBAE4C
		public int TaskReward
		{
			get
			{
				return this.Config.TaskReward;
			}
		}

		// Token: 0x17008AC8 RID: 35528
		// (get) Token: 0x06039D5C RID: 236892 RVA: 0x00DBCC68 File Offset: 0x00DBAE68
		public int JumpId
		{
			get
			{
				return this.Config.JumpId;
			}
		}

		// Token: 0x06039D5D RID: 236893 RVA: 0x00DBCC83 File Offset: 0x00DBAE83
		[NullableContext(1)]
		public void UpdateData(ActivityTask data)
		{
			this.Current = data.Current;
			this.Target = data.Target;
			this.Status = data.Status;
		}

		// Token: 0x0401E2DB RID: 123611
		public int ConfigId;

		// Token: 0x0401E2DC RID: 123612
		public int Current;

		// Token: 0x0401E2DD RID: 123613
		public int Target = 1;

		// Token: 0x0401E2DE RID: 123614
		public int Index;

		// Token: 0x0401E2DF RID: 123615
		public ActivityTaskState Status;
	}
}
