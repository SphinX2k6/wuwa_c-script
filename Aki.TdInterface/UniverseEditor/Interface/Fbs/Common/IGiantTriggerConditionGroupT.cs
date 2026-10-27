using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE3 RID: 24035
	public class IGiantTriggerConditionGroupT
	{
		// Token: 0x1700B3E9 RID: 46057
		// (get) Token: 0x0602924C RID: 168524 RVA: 0x005A581B File Offset: 0x005A3A1B
		// (set) Token: 0x0602924D RID: 168525 RVA: 0x005A5823 File Offset: 0x005A3A23
		public EGiantConditionCount Type { get; set; }

		// Token: 0x1700B3EA RID: 46058
		// (get) Token: 0x0602924E RID: 168526 RVA: 0x005A582C File Offset: 0x005A3A2C
		// (set) Token: 0x0602924F RID: 168527 RVA: 0x005A5834 File Offset: 0x005A3A34
		public List<TGiantTriggerConditionUnion> Conditions { get; set; }

		// Token: 0x06029250 RID: 168528 RVA: 0x005A583D File Offset: 0x005A3A3D
		public IGiantTriggerConditionGroupT()
		{
			this.Type = EGiantConditionCount.All;
			this.Conditions = null;
		}
	}
}
