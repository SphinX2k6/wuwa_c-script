using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007527 RID: 29991
	public class IVehicleNewSplineStopTargetT
	{
		// Token: 0x1700E398 RID: 58264
		// (get) Token: 0x06036905 RID: 223493 RVA: 0x00769EC7 File Offset: 0x007680C7
		// (set) Token: 0x06036906 RID: 223494 RVA: 0x00769ECF File Offset: 0x007680CF
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700E399 RID: 58265
		// (get) Token: 0x06036907 RID: 223495 RVA: 0x00769ED8 File Offset: 0x007680D8
		// (set) Token: 0x06036908 RID: 223496 RVA: 0x00769EE0 File Offset: 0x007680E0
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x06036909 RID: 223497 RVA: 0x00769EE9 File Offset: 0x007680E9
		public IVehicleNewSplineStopTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.TargetVehicle = null;
		}
	}
}
