using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AA RID: 24746
	public class ITimeScheduleFixedPositionsT
	{
		// Token: 0x1700B7FF RID: 47103
		// (get) Token: 0x06029DFC RID: 171516 RVA: 0x005B76B7 File Offset: 0x005B58B7
		// (set) Token: 0x06029DFD RID: 171517 RVA: 0x005B76BF File Offset: 0x005B58BF
		public ETimeScheduleRefreshPositionType Type { get; set; }

		// Token: 0x1700B800 RID: 47104
		// (get) Token: 0x06029DFE RID: 171518 RVA: 0x005B76C8 File Offset: 0x005B58C8
		// (set) Token: 0x06029DFF RID: 171519 RVA: 0x005B76D0 File Offset: 0x005B58D0
		public List<IPosAT> Positions { get; set; }

		// Token: 0x06029E00 RID: 171520 RVA: 0x005B76D9 File Offset: 0x005B58D9
		public ITimeScheduleFixedPositionsT()
		{
			this.Type = ETimeScheduleRefreshPositionType.FixedPositions;
			this.Positions = null;
		}
	}
}
