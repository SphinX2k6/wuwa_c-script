using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E55 RID: 24149
	public class IReignsEndingConditionT
	{
		// Token: 0x1700B496 RID: 46230
		// (get) Token: 0x060295B7 RID: 169399 RVA: 0x005AB847 File Offset: 0x005A9A47
		// (set) Token: 0x060295B8 RID: 169400 RVA: 0x005AB84F File Offset: 0x005A9A4F
		public EReignsEndingConditionType ConditionType { get; set; }

		// Token: 0x1700B497 RID: 46231
		// (get) Token: 0x060295B9 RID: 169401 RVA: 0x005AB858 File Offset: 0x005A9A58
		// (set) Token: 0x060295BA RID: 169402 RVA: 0x005AB860 File Offset: 0x005A9A60
		public List<ICompareReignsPropertyT> Conditions { get; set; }

		// Token: 0x060295BB RID: 169403 RVA: 0x005AB869 File Offset: 0x005A9A69
		public IReignsEndingConditionT()
		{
			this.ConditionType = EReignsEndingConditionType.All;
			this.Conditions = null;
		}
	}
}
