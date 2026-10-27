using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4C RID: 24140
	public class IReasoningQuestionConfigT
	{
		// Token: 0x1700B479 RID: 46201
		// (get) Token: 0x06029537 RID: 169271 RVA: 0x005AA747 File Offset: 0x005A8947
		// (set) Token: 0x06029538 RID: 169272 RVA: 0x005AA74F File Offset: 0x005A894F
		public int QuestionId { get; set; }

		// Token: 0x1700B47A RID: 46202
		// (get) Token: 0x06029539 RID: 169273 RVA: 0x005AA758 File Offset: 0x005A8958
		// (set) Token: 0x0602953A RID: 169274 RVA: 0x005AA760 File Offset: 0x005A8960
		public List<IReasoningResultConfigT> ResultConfigs { get; set; }

		// Token: 0x0602953B RID: 169275 RVA: 0x005AA769 File Offset: 0x005A8969
		public IReasoningQuestionConfigT()
		{
			this.QuestionId = 0;
			this.ResultConfigs = null;
		}
	}
}
