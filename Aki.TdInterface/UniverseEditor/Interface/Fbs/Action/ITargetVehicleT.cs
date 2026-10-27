using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007365 RID: 29541
	public class ITargetVehicleT
	{
		// Token: 0x1700E051 RID: 57425
		// (get) Token: 0x060359E4 RID: 219620 RVA: 0x0074D436 File Offset: 0x0074B636
		// (set) Token: 0x060359E5 RID: 219621 RVA: 0x0074D43E File Offset: 0x0074B63E
		public ETargetVehicle Type { get; set; }

		// Token: 0x060359E6 RID: 219622 RVA: 0x0074D447 File Offset: 0x0074B647
		public ITargetVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}
