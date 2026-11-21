using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648C RID: 25740
	public class IReasoningQuestionConfigT
	{
		// Token: 0x1700BDE2 RID: 48610
		// (get) Token: 0x0602BBD3 RID: 179155 RVA: 0x005F35EF File Offset: 0x005F17EF
		// (set) Token: 0x0602BBD4 RID: 179156 RVA: 0x005F35F7 File Offset: 0x005F17F7
		public int QuestionId { get; set; }

		// Token: 0x1700BDE3 RID: 48611
		// (get) Token: 0x0602BBD5 RID: 179157 RVA: 0x005F3600 File Offset: 0x005F1800
		// (set) Token: 0x0602BBD6 RID: 179158 RVA: 0x005F3608 File Offset: 0x005F1808
		public List<IReasoningResultConfigT> ResultConfigs { get; set; }

		// Token: 0x0602BBD7 RID: 179159 RVA: 0x005F3611 File Offset: 0x005F1811
		public IReasoningQuestionConfigT()
		{
			this.QuestionId = 0;
			this.ResultConfigs = null;
		}
	}
}
