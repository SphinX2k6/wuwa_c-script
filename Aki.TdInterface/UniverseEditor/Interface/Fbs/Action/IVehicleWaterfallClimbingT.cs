using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753C RID: 30012
	public class IVehicleWaterfallClimbingT
	{
		// Token: 0x1700E3BD RID: 58301
		// (get) Token: 0x060369B8 RID: 223672 RVA: 0x0076B473 File Offset: 0x00769673
		// (set) Token: 0x060369B9 RID: 223673 RVA: 0x0076B47B File Offset: 0x0076967B
		public int SplineEntityId { get; set; }

		// Token: 0x1700E3BE RID: 58302
		// (get) Token: 0x060369BA RID: 223674 RVA: 0x0076B484 File Offset: 0x00769684
		// (set) Token: 0x060369BB RID: 223675 RVA: 0x0076B48C File Offset: 0x0076968C
		public IVehicleWaterfallClimbGravityConfigT ChangeGravity { get; set; }

		// Token: 0x060369BC RID: 223676 RVA: 0x0076B495 File Offset: 0x00769695
		public IVehicleWaterfallClimbingT()
		{
			this.SplineEntityId = 0;
			this.ChangeGravity = null;
		}
	}
}
