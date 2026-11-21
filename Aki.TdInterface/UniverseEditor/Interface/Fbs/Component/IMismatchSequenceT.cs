using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEA RID: 23274
	public class IMismatchSequenceT
	{
		// Token: 0x1700A9CD RID: 43469
		// (get) Token: 0x0602639A RID: 156570 RVA: 0x0053CE83 File Offset: 0x0053B083
		// (set) Token: 0x0602639B RID: 156571 RVA: 0x0053CE8B File Offset: 0x0053B08B
		public EItemFoundationMatchType FoundationType { get; set; }

		// Token: 0x1700A9CE RID: 43470
		// (get) Token: 0x0602639C RID: 156572 RVA: 0x0053CE94 File Offset: 0x0053B094
		// (set) Token: 0x0602639D RID: 156573 RVA: 0x0053CE9C File Offset: 0x0053B09C
		public string MatchSequence { get; set; }

		// Token: 0x0602639E RID: 156574 RVA: 0x0053CEA5 File Offset: 0x0053B0A5
		public IMismatchSequenceT()
		{
			this.FoundationType = EItemFoundationMatchType.Branch;
			this.MatchSequence = null;
		}
	}
}
