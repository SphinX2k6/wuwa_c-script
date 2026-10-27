using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE7 RID: 19431
	public class IConditionGroupT
	{
		// Token: 0x17008D23 RID: 36131
		// (get) Token: 0x0601EC17 RID: 125975 RVA: 0x0044F1BB File Offset: 0x0044D3BB
		// (set) Token: 0x0601EC18 RID: 125976 RVA: 0x0044F1C3 File Offset: 0x0044D3C3
		public EConditionCount Type { get; set; }

		// Token: 0x17008D24 RID: 36132
		// (get) Token: 0x0601EC19 RID: 125977 RVA: 0x0044F1CC File Offset: 0x0044D3CC
		// (set) Token: 0x0601EC1A RID: 125978 RVA: 0x0044F1D4 File Offset: 0x0044D3D4
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x0601EC1B RID: 125979 RVA: 0x0044F1DD File Offset: 0x0044D3DD
		public IConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
