using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C3 RID: 18627
	public class IVersionControlSaveConfig_CommitTasksT
	{
		// Token: 0x17008733 RID: 34611
		// (get) Token: 0x0601D1E6 RID: 119270 RVA: 0x0041CAA8 File Offset: 0x0041ACA8
		// (set) Token: 0x0601D1E7 RID: 119271 RVA: 0x0041CAB0 File Offset: 0x0041ACB0
		public int SwarmId { get; set; }

		// Token: 0x17008734 RID: 34612
		// (get) Token: 0x0601D1E8 RID: 119272 RVA: 0x0041CAB9 File Offset: 0x0041ACB9
		// (set) Token: 0x0601D1E9 RID: 119273 RVA: 0x0041CAC1 File Offset: 0x0041ACC1
		public int ChangeListId { get; set; }

		// Token: 0x17008735 RID: 34613
		// (get) Token: 0x0601D1EA RID: 119274 RVA: 0x0041CACA File Offset: 0x0041ACCA
		// (set) Token: 0x0601D1EB RID: 119275 RVA: 0x0041CAD2 File Offset: 0x0041ACD2
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT SwarmRequestStatus { get; set; }

		// Token: 0x17008736 RID: 34614
		// (get) Token: 0x0601D1EC RID: 119276 RVA: 0x0041CADB File Offset: 0x0041ACDB
		// (set) Token: 0x0601D1ED RID: 119277 RVA: 0x0041CAE3 File Offset: 0x0041ACE3
		public List<string> SwarmPassDiffFiles { get; set; }

		// Token: 0x17008737 RID: 34615
		// (get) Token: 0x0601D1EE RID: 119278 RVA: 0x0041CAEC File Offset: 0x0041ACEC
		// (set) Token: 0x0601D1EF RID: 119279 RVA: 0x0041CAF4 File Offset: 0x0041ACF4
		public List<string> SwarmPassOccupiedFiles { get; set; }

		// Token: 0x17008738 RID: 34616
		// (get) Token: 0x0601D1F0 RID: 119280 RVA: 0x0041CAFD File Offset: 0x0041ACFD
		// (set) Token: 0x0601D1F1 RID: 119281 RVA: 0x0041CB05 File Offset: 0x0041AD05
		public bool IsUpdatingSwarmPassFiles { get; set; }

		// Token: 0x17008739 RID: 34617
		// (get) Token: 0x0601D1F2 RID: 119282 RVA: 0x0041CB0E File Offset: 0x0041AD0E
		// (set) Token: 0x0601D1F3 RID: 119283 RVA: 0x0041CB16 File Offset: 0x0041AD16
		public List<string> Files { get; set; }

		// Token: 0x1700873A RID: 34618
		// (get) Token: 0x0601D1F4 RID: 119284 RVA: 0x0041CB1F File Offset: 0x0041AD1F
		// (set) Token: 0x0601D1F5 RID: 119285 RVA: 0x0041CB27 File Offset: 0x0041AD27
		public long Timestamp { get; set; }

		// Token: 0x0601D1F6 RID: 119286 RVA: 0x0041CB30 File Offset: 0x0041AD30
		public IVersionControlSaveConfig_CommitTasksT()
		{
			this.SwarmId = 0;
			this.ChangeListId = 0;
			this.SwarmRequestStatus = null;
			this.SwarmPassDiffFiles = null;
			this.SwarmPassOccupiedFiles = null;
			this.IsUpdatingSwarmPassFiles = false;
			this.Files = null;
			this.Timestamp = 0L;
		}
	}
}
