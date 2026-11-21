using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D17 RID: 32023
	public class IVehicleMoveWithPathLineT
	{
		// Token: 0x1700EFB3 RID: 61363
		// (get) Token: 0x06039CD3 RID: 236755 RVA: 0x007CC571 File Offset: 0x007CA771
		// (set) Token: 0x06039CD4 RID: 236756 RVA: 0x007CC579 File Offset: 0x007CA779
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700EFB4 RID: 61364
		// (get) Token: 0x06039CD5 RID: 236757 RVA: 0x007CC582 File Offset: 0x007CA782
		// (set) Token: 0x06039CD6 RID: 236758 RVA: 0x007CC58A File Offset: 0x007CA78A
		public int SplineEntityId { get; set; }

		// Token: 0x1700EFB5 RID: 61365
		// (get) Token: 0x06039CD7 RID: 236759 RVA: 0x007CC593 File Offset: 0x007CA793
		// (set) Token: 0x06039CD8 RID: 236760 RVA: 0x007CC59B File Offset: 0x007CA79B
		public TVehicleControlTypeUnion ControlType { get; set; }

		// Token: 0x06039CD9 RID: 236761 RVA: 0x007CC5A4 File Offset: 0x007CA7A4
		public IVehicleMoveWithPathLineT()
		{
			this.TargetVehicle = null;
			this.SplineEntityId = 0;
			this.ControlType = null;
		}
	}
}
