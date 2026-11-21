using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D32 RID: 32050
	public class IVehicleWaterfallClimbingT
	{
		// Token: 0x1700EFE7 RID: 61415
		// (get) Token: 0x06039DCE RID: 237006 RVA: 0x007CE71B File Offset: 0x007CC91B
		// (set) Token: 0x06039DCF RID: 237007 RVA: 0x007CE723 File Offset: 0x007CC923
		public int SplineEntityId { get; set; }

		// Token: 0x1700EFE8 RID: 61416
		// (get) Token: 0x06039DD0 RID: 237008 RVA: 0x007CE72C File Offset: 0x007CC92C
		// (set) Token: 0x06039DD1 RID: 237009 RVA: 0x007CE734 File Offset: 0x007CC934
		public IVehicleWaterfallClimbGravityConfigT ChangeGravity { get; set; }

		// Token: 0x06039DD2 RID: 237010 RVA: 0x007CE73D File Offset: 0x007CC93D
		public IVehicleWaterfallClimbingT()
		{
			this.SplineEntityId = 0;
			this.ChangeGravity = null;
		}
	}
}
