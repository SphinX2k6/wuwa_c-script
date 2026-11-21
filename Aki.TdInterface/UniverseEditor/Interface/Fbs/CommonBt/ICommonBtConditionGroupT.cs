using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064EF RID: 25839
	public class ICommonBtConditionGroupT
	{
		// Token: 0x1700BE88 RID: 48776
		// (get) Token: 0x0602BF0A RID: 179978 RVA: 0x005F961F File Offset: 0x005F781F
		// (set) Token: 0x0602BF0B RID: 179979 RVA: 0x005F9627 File Offset: 0x005F7827
		public EConditionCount Type { get; set; }

		// Token: 0x1700BE89 RID: 48777
		// (get) Token: 0x0602BF0C RID: 179980 RVA: 0x005F9630 File Offset: 0x005F7830
		// (set) Token: 0x0602BF0D RID: 179981 RVA: 0x005F9638 File Offset: 0x005F7838
		public List<ICommonBtConditionInfoT> Conditions { get; set; }

		// Token: 0x0602BF0E RID: 179982 RVA: 0x005F9641 File Offset: 0x005F7841
		public ICommonBtConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
