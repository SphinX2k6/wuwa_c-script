using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A43 RID: 14915
	public class IBvbCardFilterGroupT
	{
		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x0601431A RID: 82714 RVA: 0x002F3BDF File Offset: 0x002F1DDF
		// (set) Token: 0x0601431B RID: 82715 RVA: 0x002F3BE7 File Offset: 0x002F1DE7
		public EVarConditionType GroupType { get; set; }

		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x0601431C RID: 82716 RVA: 0x002F3BF0 File Offset: 0x002F1DF0
		// (set) Token: 0x0601431D RID: 82717 RVA: 0x002F3BF8 File Offset: 0x002F1DF8
		public List<IBvbCardFilterBase_UnionUnion> Conditions { get; set; }

		// Token: 0x0601431E RID: 82718 RVA: 0x002F3C01 File Offset: 0x002F1E01
		public IBvbCardFilterGroupT()
		{
			this.GroupType = EVarConditionType.All;
			this.Conditions = null;
		}
	}
}
