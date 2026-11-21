using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D4 RID: 20692
	public class IConditionGroupT
	{
		// Token: 0x17009447 RID: 37959
		// (get) Token: 0x060207FD RID: 133117 RVA: 0x00482823 File Offset: 0x00480A23
		// (set) Token: 0x060207FE RID: 133118 RVA: 0x0048282B File Offset: 0x00480A2B
		public EConditionCount Type { get; set; }

		// Token: 0x17009448 RID: 37960
		// (get) Token: 0x060207FF RID: 133119 RVA: 0x00482834 File Offset: 0x00480A34
		// (set) Token: 0x06020800 RID: 133120 RVA: 0x0048283C File Offset: 0x00480A3C
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x06020801 RID: 133121 RVA: 0x00482845 File Offset: 0x00480A45
		public IConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
