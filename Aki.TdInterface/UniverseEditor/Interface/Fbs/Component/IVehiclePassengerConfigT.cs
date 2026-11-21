using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200613D RID: 24893
	public class IVehiclePassengerConfigT
	{
		// Token: 0x1700B970 RID: 47472
		// (get) Token: 0x0602A3EA RID: 173034 RVA: 0x005C3D28 File Offset: 0x005C1F28
		// (set) Token: 0x0602A3EB RID: 173035 RVA: 0x005C3D30 File Offset: 0x005C1F30
		public int PassengerNpc { get; set; }

		// Token: 0x1700B971 RID: 47473
		// (get) Token: 0x0602A3EC RID: 173036 RVA: 0x005C3D39 File Offset: 0x005C1F39
		// (set) Token: 0x0602A3ED RID: 173037 RVA: 0x005C3D41 File Offset: 0x005C1F41
		public int Seat { get; set; }

		// Token: 0x0602A3EE RID: 173038 RVA: 0x005C3D4A File Offset: 0x005C1F4A
		public IVehiclePassengerConfigT()
		{
			this.PassengerNpc = 0;
			this.Seat = 0;
		}
	}
}
