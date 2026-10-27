using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C2 RID: 16578
	public class IRoleTowerChallengeTitleKillProgressT
	{
		// Token: 0x170074F9 RID: 29945
		// (get) Token: 0x0601827C RID: 98940 RVA: 0x0037B2D2 File Offset: 0x003794D2
		// (set) Token: 0x0601827D RID: 98941 RVA: 0x0037B2DA File Offset: 0x003794DA
		public ERoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x0601827E RID: 98942 RVA: 0x0037B2E3 File Offset: 0x003794E3
		public IRoleTowerChallengeTitleKillProgressT()
		{
			this.Type = ERoleTowerChallengeTitleType.KillProgress;
		}
	}
}
