using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EE RID: 22510
	public class IFlowerPollutionSplineConfigT
	{
		// Token: 0x1700A2DD RID: 41693
		// (get) Token: 0x06024637 RID: 149047 RVA: 0x004FFF71 File Offset: 0x004FE171
		// (set) Token: 0x06024638 RID: 149048 RVA: 0x004FFF79 File Offset: 0x004FE179
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x06024639 RID: 149049 RVA: 0x004FFF82 File Offset: 0x004FE182
		public IFlowerPollutionSplineConfigT()
		{
			this.SplineEntityIds = null;
		}
	}
}
