using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BB RID: 16827
	public class ICompareVarConditionInQuestFailedT
	{
		// Token: 0x1700724C RID: 29260
		// (get) Token: 0x06017436 RID: 95286 RVA: 0x00352233 File Offset: 0x00350433
		// (set) Token: 0x06017437 RID: 95287 RVA: 0x0035223B File Offset: 0x0035043B
		public EConditionCount Count { get; set; }

		// Token: 0x1700724D RID: 29261
		// (get) Token: 0x06017438 RID: 95288 RVA: 0x00352244 File Offset: 0x00350444
		// (set) Token: 0x06017439 RID: 95289 RVA: 0x0035224C File Offset: 0x0035044C
		public List<ICompareVarInChildQuestT> Conditions { get; set; }

		// Token: 0x0601743A RID: 95290 RVA: 0x00352255 File Offset: 0x00350455
		public ICompareVarConditionInQuestFailedT()
		{
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
