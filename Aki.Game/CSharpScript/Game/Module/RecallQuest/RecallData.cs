using System;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02004F18 RID: 20248
	public class RecallData
	{
		// Token: 0x06033EB5 RID: 212661 RVA: 0x00C2B1C4 File Offset: 0x00C293C4
		public RecallData(int recallId, ERecallStatus status)
		{
			this.RecallId = recallId;
			this.Status = status;
		}

		// Token: 0x0401B972 RID: 113010
		public int RecallId;

		// Token: 0x0401B973 RID: 113011
		public ERecallStatus Status;
	}
}
