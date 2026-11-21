using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C72 RID: 31858
	public class ITriggeredVehicleT
	{
		// Token: 0x1700EE86 RID: 61062
		// (get) Token: 0x0603970F RID: 235279 RVA: 0x007C1272 File Offset: 0x007BF472
		// (set) Token: 0x06039710 RID: 235280 RVA: 0x007C127A File Offset: 0x007BF47A
		public ETargetVehicle Type { get; set; }

		// Token: 0x06039711 RID: 235281 RVA: 0x007C1283 File Offset: 0x007BF483
		public ITriggeredVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
