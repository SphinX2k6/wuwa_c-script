using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D28 RID: 19752
	public class IVersionControlSaveConfig_CommitTasksT
	{
		// Token: 0x17008D7B RID: 36219
		// (get) Token: 0x0601E9D3 RID: 125395 RVA: 0x00449244 File Offset: 0x00447444
		// (set) Token: 0x0601E9D4 RID: 125396 RVA: 0x0044924C File Offset: 0x0044744C
		public int SwarmId { get; set; }

		// Token: 0x17008D7C RID: 36220
		// (get) Token: 0x0601E9D5 RID: 125397 RVA: 0x00449255 File Offset: 0x00447455
		// (set) Token: 0x0601E9D6 RID: 125398 RVA: 0x0044925D File Offset: 0x0044745D
		public int ChangeListId { get; set; }

		// Token: 0x17008D7D RID: 36221
		// (get) Token: 0x0601E9D7 RID: 125399 RVA: 0x00449266 File Offset: 0x00447466
		// (set) Token: 0x0601E9D8 RID: 125400 RVA: 0x0044926E File Offset: 0x0044746E
		public IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusT SwarmRequestStatus { get; set; }

		// Token: 0x17008D7E RID: 36222
		// (get) Token: 0x0601E9D9 RID: 125401 RVA: 0x00449277 File Offset: 0x00447477
		// (set) Token: 0x0601E9DA RID: 125402 RVA: 0x0044927F File Offset: 0x0044747F
		public List<string> SwarmPassDiffFiles { get; set; }

		// Token: 0x17008D7F RID: 36223
		// (get) Token: 0x0601E9DB RID: 125403 RVA: 0x00449288 File Offset: 0x00447488
		// (set) Token: 0x0601E9DC RID: 125404 RVA: 0x00449290 File Offset: 0x00447490
		public List<string> SwarmPassOccupiedFiles { get; set; }

		// Token: 0x17008D80 RID: 36224
		// (get) Token: 0x0601E9DD RID: 125405 RVA: 0x00449299 File Offset: 0x00447499
		// (set) Token: 0x0601E9DE RID: 125406 RVA: 0x004492A1 File Offset: 0x004474A1
		public bool IsUpdatingSwarmPassFiles { get; set; }

		// Token: 0x17008D81 RID: 36225
		// (get) Token: 0x0601E9DF RID: 125407 RVA: 0x004492AA File Offset: 0x004474AA
		// (set) Token: 0x0601E9E0 RID: 125408 RVA: 0x004492B2 File Offset: 0x004474B2
		public List<string> Files { get; set; }

		// Token: 0x17008D82 RID: 36226
		// (get) Token: 0x0601E9E1 RID: 125409 RVA: 0x004492BB File Offset: 0x004474BB
		// (set) Token: 0x0601E9E2 RID: 125410 RVA: 0x004492C3 File Offset: 0x004474C3
		public long Timestamp { get; set; }

		// Token: 0x0601E9E3 RID: 125411 RVA: 0x004492CC File Offset: 0x004474CC
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
