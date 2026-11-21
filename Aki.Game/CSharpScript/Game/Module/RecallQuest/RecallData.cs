using System;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02003EE1 RID: 16097
	public class RecallData
	{
		// Token: 0x06028D20 RID: 167200 RVA: 0x00B74838 File Offset: 0x00B72A38
		public RecallData(int recallId, ERecallStatus status)
		{
			this.RecallId = recallId;
			this.Status = status;
		}

		// Token: 0x04016345 RID: 90949
		public int RecallId;

		// Token: 0x04016346 RID: 90950
		public ERecallStatus Status;
	}
}
