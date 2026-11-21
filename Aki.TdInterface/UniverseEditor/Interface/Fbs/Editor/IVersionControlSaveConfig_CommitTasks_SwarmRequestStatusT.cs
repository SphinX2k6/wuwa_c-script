using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D2B RID: 19755
	public class IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT
	{
		// Token: 0x17008D86 RID: 36230
		// (get) Token: 0x0601E9F7 RID: 125431 RVA: 0x00449593 File Offset: 0x00447793
		// (set) Token: 0x0601E9F8 RID: 125432 RVA: 0x0044959B File Offset: 0x0044779B
		public int SwarmState { get; set; }

		// Token: 0x17008D87 RID: 36231
		// (get) Token: 0x0601E9F9 RID: 125433 RVA: 0x004495A4 File Offset: 0x004477A4
		// (set) Token: 0x0601E9FA RID: 125434 RVA: 0x004495AC File Offset: 0x004477AC
		public string SwarmRequestInvalidMsg { get; set; }

		// Token: 0x0601E9FB RID: 125435 RVA: 0x004495B5 File Offset: 0x004477B5
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT()
		{
			this.SwarmState = 0;
			this.SwarmRequestInvalidMsg = null;
		}
	}
}
