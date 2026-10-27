using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007539 RID: 30009
	public class IVehicleWaterfallClimbGravityConfigT
	{
		// Token: 0x1700E3B8 RID: 58296
		// (get) Token: 0x060369A2 RID: 223650 RVA: 0x0076B208 File Offset: 0x00769408
		// (set) Token: 0x060369A3 RID: 223651 RVA: 0x0076B210 File Offset: 0x00769410
		public int SafePositionEntityId { get; set; }

		// Token: 0x1700E3B9 RID: 58297
		// (get) Token: 0x060369A4 RID: 223652 RVA: 0x0076B219 File Offset: 0x00769419
		// (set) Token: 0x060369A5 RID: 223653 RVA: 0x0076B221 File Offset: 0x00769421
		public EWorldAxisType GravityDirection { get; set; }

		// Token: 0x060369A6 RID: 223654 RVA: 0x0076B22A File Offset: 0x0076942A
		public IVehicleWaterfallClimbGravityConfigT()
		{
			this.SafePositionEntityId = 0;
			this.GravityDirection = EWorldAxisType.PositiveX;
		}
	}
}
