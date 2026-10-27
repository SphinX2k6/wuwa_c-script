using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B27 RID: 23335
	public class IVehiclePassengerConfigT
	{
		// Token: 0x1700B028 RID: 45096
		// (get) Token: 0x06027E26 RID: 163366 RVA: 0x0057C2D4 File Offset: 0x0057A4D4
		// (set) Token: 0x06027E27 RID: 163367 RVA: 0x0057C2DC File Offset: 0x0057A4DC
		public int PassengerNpc { get; set; }

		// Token: 0x1700B029 RID: 45097
		// (get) Token: 0x06027E28 RID: 163368 RVA: 0x0057C2E5 File Offset: 0x0057A4E5
		// (set) Token: 0x06027E29 RID: 163369 RVA: 0x0057C2ED File Offset: 0x0057A4ED
		public int Seat { get; set; }

		// Token: 0x06027E2A RID: 163370 RVA: 0x0057C2F6 File Offset: 0x0057A4F6
		public IVehiclePassengerConfigT()
		{
			this.PassengerNpc = 0;
			this.Seat = 0;
		}
	}
}
