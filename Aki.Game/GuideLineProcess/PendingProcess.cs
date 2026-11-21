using System;

namespace GuideLineProcess
{
	// Token: 0x02002F54 RID: 12116
	public class PendingProcess : IStaticVariableResetter
	{
		// Token: 0x0601CB69 RID: 117609 RVA: 0x008C3916 File Offset: 0x008C1B16
		public PendingProcess(EProcessType processType)
		{
			this.ProcessType = processType;
			this.ProcessId = ++PendingProcess.Id;
		}

		// Token: 0x0601CB6A RID: 117610 RVA: 0x008C3938 File Offset: 0x008C1B38
		static PendingProcess()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcess.CreateStaticDefaultValue), new Action(PendingProcess.ResetStaticDefaultValue));
		}

		// Token: 0x0601CB6B RID: 117611 RVA: 0x008C3957 File Offset: 0x008C1B57
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601CB6C RID: 117612 RVA: 0x008C3959 File Offset: 0x008C1B59
		public static void ResetStaticDefaultValue()
		{
			PendingProcess.Id = 0;
		}

		// Token: 0x0400F1C5 RID: 61893
		public static int Id;

		// Token: 0x0400F1C6 RID: 61894
		public int ProcessId;

		// Token: 0x0400F1C7 RID: 61895
		public bool Finished;

		// Token: 0x0400F1C8 RID: 61896
		public readonly EProcessType ProcessType;
	}
}
