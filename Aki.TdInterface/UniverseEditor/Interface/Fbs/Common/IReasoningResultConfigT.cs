using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648F RID: 25743
	public class IReasoningResultConfigT
	{
		// Token: 0x1700BDEC RID: 48620
		// (get) Token: 0x0602BC07 RID: 179207 RVA: 0x005F3DC9 File Offset: 0x005F1FC9
		// (set) Token: 0x0602BC08 RID: 179208 RVA: 0x005F3DD1 File Offset: 0x005F1FD1
		public List<int> ClueCombination { get; set; }

		// Token: 0x1700BDED RID: 48621
		// (get) Token: 0x0602BC09 RID: 179209 RVA: 0x005F3DDA File Offset: 0x005F1FDA
		// (set) Token: 0x0602BC0A RID: 179210 RVA: 0x005F3DE2 File Offset: 0x005F1FE2
		public List<string> ReasoningStateId { get; set; }

		// Token: 0x1700BDEE RID: 48622
		// (get) Token: 0x0602BC0B RID: 179211 RVA: 0x005F3DEB File Offset: 0x005F1FEB
		// (set) Token: 0x0602BC0C RID: 179212 RVA: 0x005F3DF3 File Offset: 0x005F1FF3
		public List<string> ResultDesc { get; set; }

		// Token: 0x1700BDEF RID: 48623
		// (get) Token: 0x0602BC0D RID: 179213 RVA: 0x005F3DFC File Offset: 0x005F1FFC
		// (set) Token: 0x0602BC0E RID: 179214 RVA: 0x005F3E04 File Offset: 0x005F2004
		public int NextQuestionId { get; set; }

		// Token: 0x1700BDF0 RID: 48624
		// (get) Token: 0x0602BC0F RID: 179215 RVA: 0x005F3E0D File Offset: 0x005F200D
		// (set) Token: 0x0602BC10 RID: 179216 RVA: 0x005F3E15 File Offset: 0x005F2015
		public int CaseProgressId { get; set; }

		// Token: 0x1700BDF1 RID: 48625
		// (get) Token: 0x0602BC11 RID: 179217 RVA: 0x005F3E1E File Offset: 0x005F201E
		// (set) Token: 0x0602BC12 RID: 179218 RVA: 0x005F3E26 File Offset: 0x005F2026
		public int EndingId { get; set; }

		// Token: 0x1700BDF2 RID: 48626
		// (get) Token: 0x0602BC13 RID: 179219 RVA: 0x005F3E2F File Offset: 0x005F202F
		// (set) Token: 0x0602BC14 RID: 179220 RVA: 0x005F3E37 File Offset: 0x005F2037
		public byte NullMask { get; set; }

		// Token: 0x0602BC15 RID: 179221 RVA: 0x005F3E40 File Offset: 0x005F2040
		public IReasoningResultConfigT()
		{
			this.ClueCombination = null;
			this.ReasoningStateId = null;
			this.ResultDesc = null;
			this.NextQuestionId = 0;
			this.CaseProgressId = 0;
			this.EndingId = 0;
			this.NullMask = 0;
		}
	}
}
