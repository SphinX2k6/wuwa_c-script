using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006495 RID: 25749
	public class IReignsEndingConditionT
	{
		// Token: 0x1700BDFF RID: 48639
		// (get) Token: 0x0602BC53 RID: 179283 RVA: 0x005F46EF File Offset: 0x005F28EF
		// (set) Token: 0x0602BC54 RID: 179284 RVA: 0x005F46F7 File Offset: 0x005F28F7
		public EReignsEndingConditionType ConditionType { get; set; }

		// Token: 0x1700BE00 RID: 48640
		// (get) Token: 0x0602BC55 RID: 179285 RVA: 0x005F4700 File Offset: 0x005F2900
		// (set) Token: 0x0602BC56 RID: 179286 RVA: 0x005F4708 File Offset: 0x005F2908
		public List<ICompareReignsPropertyT> Conditions { get; set; }

		// Token: 0x0602BC57 RID: 179287 RVA: 0x005F4711 File Offset: 0x005F2911
		public IReignsEndingConditionT()
		{
			this.ConditionType = EReignsEndingConditionType.All;
			this.Conditions = null;
		}
	}
}
