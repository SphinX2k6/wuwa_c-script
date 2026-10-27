using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C6 RID: 18630
	public class IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT
	{
		// Token: 0x1700873E RID: 34622
		// (get) Token: 0x0601D20A RID: 119306 RVA: 0x0041CDF7 File Offset: 0x0041AFF7
		// (set) Token: 0x0601D20B RID: 119307 RVA: 0x0041CDFF File Offset: 0x0041AFFF
		public int SwarmState { get; set; }

		// Token: 0x1700873F RID: 34623
		// (get) Token: 0x0601D20C RID: 119308 RVA: 0x0041CE08 File Offset: 0x0041B008
		// (set) Token: 0x0601D20D RID: 119309 RVA: 0x0041CE10 File Offset: 0x0041B010
		public string SwarmRequestInvalidMsg { get; set; }

		// Token: 0x0601D20E RID: 119310 RVA: 0x0041CE19 File Offset: 0x0041B019
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT()
		{
			this.SwarmState = 0;
			this.SwarmRequestInvalidMsg = null;
		}
	}
}
