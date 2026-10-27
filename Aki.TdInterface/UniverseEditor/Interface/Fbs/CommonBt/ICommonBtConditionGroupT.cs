using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAC RID: 24236
	public class ICommonBtConditionGroupT
	{
		// Token: 0x1700B51D RID: 46365
		// (get) Token: 0x06029862 RID: 170082 RVA: 0x005B067B File Offset: 0x005AE87B
		// (set) Token: 0x06029863 RID: 170083 RVA: 0x005B0683 File Offset: 0x005AE883
		public EConditionCount Type { get; set; }

		// Token: 0x1700B51E RID: 46366
		// (get) Token: 0x06029864 RID: 170084 RVA: 0x005B068C File Offset: 0x005AE88C
		// (set) Token: 0x06029865 RID: 170085 RVA: 0x005B0694 File Offset: 0x005AE894
		public List<ICommonBtConditionInfoT> Conditions { get; set; }

		// Token: 0x06029866 RID: 170086 RVA: 0x005B069D File Offset: 0x005AE89D
		public ICommonBtConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
