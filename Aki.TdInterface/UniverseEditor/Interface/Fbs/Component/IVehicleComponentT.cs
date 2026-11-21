using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006122 RID: 24866
	public class IVehicleComponentT
	{
		// Token: 0x1700B92E RID: 47406
		// (get) Token: 0x0602A2E0 RID: 172768 RVA: 0x005C1E96 File Offset: 0x005C0096
		// (set) Token: 0x0602A2E1 RID: 172769 RVA: 0x005C1E9E File Offset: 0x005C009E
		public bool Disabled { get; set; }

		// Token: 0x1700B92F RID: 47407
		// (get) Token: 0x0602A2E2 RID: 172770 RVA: 0x005C1EA7 File Offset: 0x005C00A7
		// (set) Token: 0x0602A2E3 RID: 172771 RVA: 0x005C1EAF File Offset: 0x005C00AF
		public string Config { get; set; }

		// Token: 0x1700B930 RID: 47408
		// (get) Token: 0x0602A2E4 RID: 172772 RVA: 0x005C1EB8 File Offset: 0x005C00B8
		// (set) Token: 0x0602A2E5 RID: 172773 RVA: 0x005C1EC0 File Offset: 0x005C00C0
		public IVehicleTypedMotorConfigT VehicleTypedConfig { get; set; }

		// Token: 0x1700B931 RID: 47409
		// (get) Token: 0x0602A2E6 RID: 172774 RVA: 0x005C1EC9 File Offset: 0x005C00C9
		// (set) Token: 0x0602A2E7 RID: 172775 RVA: 0x005C1ED1 File Offset: 0x005C00D1
		public List<int> VehicleBornTag { get; set; }

		// Token: 0x1700B932 RID: 47410
		// (get) Token: 0x0602A2E8 RID: 172776 RVA: 0x005C1EDA File Offset: 0x005C00DA
		// (set) Token: 0x0602A2E9 RID: 172777 RVA: 0x005C1EE2 File Offset: 0x005C00E2
		public List<int> VehicleRiddenTag { get; set; }

		// Token: 0x1700B933 RID: 47411
		// (get) Token: 0x0602A2EA RID: 172778 RVA: 0x005C1EEB File Offset: 0x005C00EB
		// (set) Token: 0x0602A2EB RID: 172779 RVA: 0x005C1EF3 File Offset: 0x005C00F3
		public List<int> RoleRiddingTag { get; set; }

		// Token: 0x1700B934 RID: 47412
		// (get) Token: 0x0602A2EC RID: 172780 RVA: 0x005C1EFC File Offset: 0x005C00FC
		// (set) Token: 0x0602A2ED RID: 172781 RVA: 0x005C1F04 File Offset: 0x005C0104
		public IPassengerTeleportConfigT TeleportPlayersWhenDestroyed { get; set; }

		// Token: 0x1700B935 RID: 47413
		// (get) Token: 0x0602A2EE RID: 172782 RVA: 0x005C1F0D File Offset: 0x005C010D
		// (set) Token: 0x0602A2EF RID: 172783 RVA: 0x005C1F15 File Offset: 0x005C0115
		public List<TVehicleFeatureUnion> VehicleFeatures { get; set; }

		// Token: 0x1700B936 RID: 47414
		// (get) Token: 0x0602A2F0 RID: 172784 RVA: 0x005C1F1E File Offset: 0x005C011E
		// (set) Token: 0x0602A2F1 RID: 172785 RVA: 0x005C1F26 File Offset: 0x005C0126
		public EVehicleSeatCount SeatCount { get; set; }

		// Token: 0x1700B937 RID: 47415
		// (get) Token: 0x0602A2F2 RID: 172786 RVA: 0x005C1F2F File Offset: 0x005C012F
		// (set) Token: 0x0602A2F3 RID: 172787 RVA: 0x005C1F37 File Offset: 0x005C0137
		public EVehicleSeat DriverSeat { get; set; }

		// Token: 0x1700B938 RID: 47416
		// (get) Token: 0x0602A2F4 RID: 172788 RVA: 0x005C1F40 File Offset: 0x005C0140
		// (set) Token: 0x0602A2F5 RID: 172789 RVA: 0x005C1F48 File Offset: 0x005C0148
		public List<IVehiclePassengerConfigT> DefaultPassengers { get; set; }

		// Token: 0x1700B939 RID: 47417
		// (get) Token: 0x0602A2F6 RID: 172790 RVA: 0x005C1F51 File Offset: 0x005C0151
		// (set) Token: 0x0602A2F7 RID: 172791 RVA: 0x005C1F59 File Offset: 0x005C0159
		public byte NullMask { get; set; }

		// Token: 0x0602A2F8 RID: 172792 RVA: 0x005C1F64 File Offset: 0x005C0164
		public IVehicleComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.VehicleTypedConfig = null;
			this.VehicleBornTag = null;
			this.VehicleRiddenTag = null;
			this.RoleRiddingTag = null;
			this.TeleportPlayersWhenDestroyed = null;
			this.VehicleFeatures = null;
			this.SeatCount = EVehicleSeatCount.None;
			this.DriverSeat = EVehicleSeat.Seat0;
			this.DefaultPassengers = null;
			this.NullMask = 0;
		}
	}
}
