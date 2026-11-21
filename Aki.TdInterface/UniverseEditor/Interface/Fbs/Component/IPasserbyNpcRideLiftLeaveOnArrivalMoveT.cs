using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAF RID: 23727
	public class IPasserbyNpcRideLiftLeaveOnArrivalMoveT
	{
		// Token: 0x1700AE50 RID: 44624
		// (get) Token: 0x060275F7 RID: 161271 RVA: 0x00563D50 File Offset: 0x00561F50
		// (set) Token: 0x060275F8 RID: 161272 RVA: 0x00563D58 File Offset: 0x00561F58
		public EPasserbyNpcLiftMoveType Type { get; set; }

		// Token: 0x1700AE51 RID: 44625
		// (get) Token: 0x060275F9 RID: 161273 RVA: 0x00563D61 File Offset: 0x00561F61
		// (set) Token: 0x060275FA RID: 161274 RVA: 0x00563D69 File Offset: 0x00561F69
		public int LiftEntityId { get; set; }

		// Token: 0x1700AE52 RID: 44626
		// (get) Token: 0x060275FB RID: 161275 RVA: 0x00563D72 File Offset: 0x00561F72
		// (set) Token: 0x060275FC RID: 161276 RVA: 0x00563D7A File Offset: 0x00561F7A
		public IPasserbyNpcLiftStopExitTimingT ExitTiming { get; set; }

		// Token: 0x1700AE53 RID: 44627
		// (get) Token: 0x060275FD RID: 161277 RVA: 0x00563D83 File Offset: 0x00561F83
		// (set) Token: 0x060275FE RID: 161278 RVA: 0x00563D8B File Offset: 0x00561F8B
		public List<IPasserbyNpcFloorSplineT> FloorSplines { get; set; }

		// Token: 0x060275FF RID: 161279 RVA: 0x00563D94 File Offset: 0x00561F94
		public IPasserbyNpcRideLiftLeaveOnArrivalMoveT()
		{
			this.Type = EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
			this.LiftEntityId = 0;
			this.ExitTiming = null;
			this.FloorSplines = null;
		}
	}
}
