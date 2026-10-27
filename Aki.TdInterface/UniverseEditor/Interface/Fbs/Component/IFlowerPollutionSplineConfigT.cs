using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005286 RID: 21126
	public class IFlowerPollutionSplineConfigT
	{
		// Token: 0x17009ADF RID: 39647
		// (get) Token: 0x0602269D RID: 140957 RVA: 0x004C5401 File Offset: 0x004C3601
		// (set) Token: 0x0602269E RID: 140958 RVA: 0x004C5409 File Offset: 0x004C3609
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x0602269F RID: 140959 RVA: 0x004C5412 File Offset: 0x004C3612
		public IFlowerPollutionSplineConfigT()
		{
			this.SplineEntityIds = null;
		}
	}
}
