using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1D RID: 32029
	public class IVehicleNewSplineStopTargetT
	{
		// Token: 0x1700EFC2 RID: 61378
		// (get) Token: 0x06039D1B RID: 236827 RVA: 0x007CD16F File Offset: 0x007CB36F
		// (set) Token: 0x06039D1C RID: 236828 RVA: 0x007CD177 File Offset: 0x007CB377
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700EFC3 RID: 61379
		// (get) Token: 0x06039D1D RID: 236829 RVA: 0x007CD180 File Offset: 0x007CB380
		// (set) Token: 0x06039D1E RID: 236830 RVA: 0x007CD188 File Offset: 0x007CB388
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x06039D1F RID: 236831 RVA: 0x007CD191 File Offset: 0x007CB391
		public IVehicleNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.TargetVehicle = null;
		}
	}
}
