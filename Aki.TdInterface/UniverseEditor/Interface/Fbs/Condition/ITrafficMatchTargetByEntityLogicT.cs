using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CFE RID: 19710
	public class ITrafficMatchTargetByEntityLogicT
	{
		// Token: 0x17008F04 RID: 36612
		// (get) Token: 0x0601F49C RID: 128156 RVA: 0x0045D723 File Offset: 0x0045B923
		// (set) Token: 0x0601F49D RID: 128157 RVA: 0x0045D72B File Offset: 0x0045B92B
		public ETrafficMatchTargetType Type { get; set; }

		// Token: 0x17008F05 RID: 36613
		// (get) Token: 0x0601F49E RID: 128158 RVA: 0x0045D734 File Offset: 0x0045B934
		// (set) Token: 0x0601F49F RID: 128159 RVA: 0x0045D73C File Offset: 0x0045B93C
		public List<EEntityLogic> EntityLogicTypes { get; set; }

		// Token: 0x0601F4A0 RID: 128160 RVA: 0x0045D745 File Offset: 0x0045B945
		public ITrafficMatchTargetByEntityLogicT()
		{
			this.Type = ETrafficMatchTargetType.MatchByEntityLogic;
			this.EntityLogicTypes = null;
		}
	}
}
