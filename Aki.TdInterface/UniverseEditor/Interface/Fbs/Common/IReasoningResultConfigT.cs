using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4F RID: 24143
	public class IReasoningResultConfigT
	{
		// Token: 0x1700B483 RID: 46211
		// (get) Token: 0x0602956B RID: 169323 RVA: 0x005AAF21 File Offset: 0x005A9121
		// (set) Token: 0x0602956C RID: 169324 RVA: 0x005AAF29 File Offset: 0x005A9129
		public List<int> ClueCombination { get; set; }

		// Token: 0x1700B484 RID: 46212
		// (get) Token: 0x0602956D RID: 169325 RVA: 0x005AAF32 File Offset: 0x005A9132
		// (set) Token: 0x0602956E RID: 169326 RVA: 0x005AAF3A File Offset: 0x005A913A
		public List<string> ReasoningStateId { get; set; }

		// Token: 0x1700B485 RID: 46213
		// (get) Token: 0x0602956F RID: 169327 RVA: 0x005AAF43 File Offset: 0x005A9143
		// (set) Token: 0x06029570 RID: 169328 RVA: 0x005AAF4B File Offset: 0x005A914B
		public List<string> ResultDesc { get; set; }

		// Token: 0x1700B486 RID: 46214
		// (get) Token: 0x06029571 RID: 169329 RVA: 0x005AAF54 File Offset: 0x005A9154
		// (set) Token: 0x06029572 RID: 169330 RVA: 0x005AAF5C File Offset: 0x005A915C
		public int NextQuestionId { get; set; }

		// Token: 0x1700B487 RID: 46215
		// (get) Token: 0x06029573 RID: 169331 RVA: 0x005AAF65 File Offset: 0x005A9165
		// (set) Token: 0x06029574 RID: 169332 RVA: 0x005AAF6D File Offset: 0x005A916D
		public int CaseProgressId { get; set; }

		// Token: 0x1700B488 RID: 46216
		// (get) Token: 0x06029575 RID: 169333 RVA: 0x005AAF76 File Offset: 0x005A9176
		// (set) Token: 0x06029576 RID: 169334 RVA: 0x005AAF7E File Offset: 0x005A917E
		public int EndingId { get; set; }

		// Token: 0x1700B489 RID: 46217
		// (get) Token: 0x06029577 RID: 169335 RVA: 0x005AAF87 File Offset: 0x005A9187
		// (set) Token: 0x06029578 RID: 169336 RVA: 0x005AAF8F File Offset: 0x005A918F
		public byte NullMask { get; set; }

		// Token: 0x06029579 RID: 169337 RVA: 0x005AAF98 File Offset: 0x005A9198
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
