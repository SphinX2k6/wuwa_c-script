using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E1E RID: 15902
	public class IBvbCardFilterGroupT
	{
		// Token: 0x17006B67 RID: 27495
		// (get) Token: 0x06015636 RID: 87606 RVA: 0x00316DCB File Offset: 0x00314FCB
		// (set) Token: 0x06015637 RID: 87607 RVA: 0x00316DD3 File Offset: 0x00314FD3
		public EVarConditionType GroupType { get; set; }

		// Token: 0x17006B68 RID: 27496
		// (get) Token: 0x06015638 RID: 87608 RVA: 0x00316DDC File Offset: 0x00314FDC
		// (set) Token: 0x06015639 RID: 87609 RVA: 0x00316DE4 File Offset: 0x00314FE4
		public List<IBvbCardFilterBase_UnionUnion> Conditions { get; set; }

		// Token: 0x0601563A RID: 87610 RVA: 0x00316DED File Offset: 0x00314FED
		public IBvbCardFilterGroupT()
		{
			this.GroupType = EVarConditionType.All;
			this.Conditions = null;
		}
	}
}
