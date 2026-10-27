using System;

namespace GuideLineProcess
{
	// Token: 0x020044C7 RID: 17607
	public class PendingProcess : IStaticVariableResetter
	{
		// Token: 0x0602D62B RID: 185899 RVA: 0x00A3DCB6 File Offset: 0x00A3BEB6
		public PendingProcess(EProcessType processType)
		{
			this.ProcessType = processType;
			this.ProcessId = ++PendingProcess.Id;
		}

		// Token: 0x0602D62C RID: 185900 RVA: 0x00A3DCD8 File Offset: 0x00A3BED8
		static PendingProcess()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcess.CreateStaticDefaultValue), new Action(PendingProcess.ResetStaticDefaultValue));
		}

		// Token: 0x0602D62D RID: 185901 RVA: 0x00A3DCF7 File Offset: 0x00A3BEF7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D62E RID: 185902 RVA: 0x00A3DCF9 File Offset: 0x00A3BEF9
		public static void ResetStaticDefaultValue()
		{
			PendingProcess.Id = 0;
		}

		// Token: 0x0401841D RID: 99357
		public static int Id;

		// Token: 0x0401841E RID: 99358
		public int ProcessId;

		// Token: 0x0401841F RID: 99359
		public bool Finished;

		// Token: 0x04018420 RID: 99360
		public readonly EProcessType ProcessType;
	}
}
