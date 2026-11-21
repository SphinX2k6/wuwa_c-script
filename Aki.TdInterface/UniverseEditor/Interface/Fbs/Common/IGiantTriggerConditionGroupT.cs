using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006420 RID: 25632
	public class IGiantTriggerConditionGroupT
	{
		// Token: 0x1700BD4F RID: 48463
		// (get) Token: 0x0602B8D6 RID: 178390 RVA: 0x005EE54B File Offset: 0x005EC74B
		// (set) Token: 0x0602B8D7 RID: 178391 RVA: 0x005EE553 File Offset: 0x005EC753
		public EGiantConditionCount Type { get; set; }

		// Token: 0x1700BD50 RID: 48464
		// (get) Token: 0x0602B8D8 RID: 178392 RVA: 0x005EE55C File Offset: 0x005EC75C
		// (set) Token: 0x0602B8D9 RID: 178393 RVA: 0x005EE564 File Offset: 0x005EC764
		public List<TGiantTriggerConditionUnion> Conditions { get; set; }

		// Token: 0x0602B8DA RID: 178394 RVA: 0x005EE56D File Offset: 0x005EC76D
		public IGiantTriggerConditionGroupT()
		{
			this.Type = EGiantConditionCount.All;
			this.Conditions = null;
		}
	}
}
