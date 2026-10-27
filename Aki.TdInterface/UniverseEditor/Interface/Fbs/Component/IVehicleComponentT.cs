using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0C RID: 23308
	public class IVehicleComponentT
	{
		// Token: 0x1700AFE6 RID: 45030
		// (get) Token: 0x06027D1C RID: 163100 RVA: 0x0057A442 File Offset: 0x00578642
		// (set) Token: 0x06027D1D RID: 163101 RVA: 0x0057A44A File Offset: 0x0057864A
		public bool Disabled { get; set; }

		// Token: 0x1700AFE7 RID: 45031
		// (get) Token: 0x06027D1E RID: 163102 RVA: 0x0057A453 File Offset: 0x00578653
		// (set) Token: 0x06027D1F RID: 163103 RVA: 0x0057A45B File Offset: 0x0057865B
		public string Config { get; set; }

		// Token: 0x1700AFE8 RID: 45032
		// (get) Token: 0x06027D20 RID: 163104 RVA: 0x0057A464 File Offset: 0x00578664
		// (set) Token: 0x06027D21 RID: 163105 RVA: 0x0057A46C File Offset: 0x0057866C
		public IVehicleTypedMotorConfigT VehicleTypedConfig { get; set; }

		// Token: 0x1700AFE9 RID: 45033
		// (get) Token: 0x06027D22 RID: 163106 RVA: 0x0057A475 File Offset: 0x00578675
		// (set) Token: 0x06027D23 RID: 163107 RVA: 0x0057A47D File Offset: 0x0057867D
		public List<int> VehicleBornTag { get; set; }

		// Token: 0x1700AFEA RID: 45034
		// (get) Token: 0x06027D24 RID: 163108 RVA: 0x0057A486 File Offset: 0x00578686
		// (set) Token: 0x06027D25 RID: 163109 RVA: 0x0057A48E File Offset: 0x0057868E
		public List<int> VehicleRiddenTag { get; set; }

		// Token: 0x1700AFEB RID: 45035
		// (get) Token: 0x06027D26 RID: 163110 RVA: 0x0057A497 File Offset: 0x00578697
		// (set) Token: 0x06027D27 RID: 163111 RVA: 0x0057A49F File Offset: 0x0057869F
		public List<int> RoleRiddingTag { get; set; }

		// Token: 0x1700AFEC RID: 45036
		// (get) Token: 0x06027D28 RID: 163112 RVA: 0x0057A4A8 File Offset: 0x005786A8
		// (set) Token: 0x06027D29 RID: 163113 RVA: 0x0057A4B0 File Offset: 0x005786B0
		public IPassengerTeleportConfigT TeleportPlayersWhenDestroyed { get; set; }

		// Token: 0x1700AFED RID: 45037
		// (get) Token: 0x06027D2A RID: 163114 RVA: 0x0057A4B9 File Offset: 0x005786B9
		// (set) Token: 0x06027D2B RID: 163115 RVA: 0x0057A4C1 File Offset: 0x005786C1
		public List<TVehicleFeatureUnion> VehicleFeatures { get; set; }

		// Token: 0x1700AFEE RID: 45038
		// (get) Token: 0x06027D2C RID: 163116 RVA: 0x0057A4CA File Offset: 0x005786CA
		// (set) Token: 0x06027D2D RID: 163117 RVA: 0x0057A4D2 File Offset: 0x005786D2
		public EVehicleSeatCount SeatCount { get; set; }

		// Token: 0x1700AFEF RID: 45039
		// (get) Token: 0x06027D2E RID: 163118 RVA: 0x0057A4DB File Offset: 0x005786DB
		// (set) Token: 0x06027D2F RID: 163119 RVA: 0x0057A4E3 File Offset: 0x005786E3
		public EVehicleSeat DriverSeat { get; set; }

		// Token: 0x1700AFF0 RID: 45040
		// (get) Token: 0x06027D30 RID: 163120 RVA: 0x0057A4EC File Offset: 0x005786EC
		// (set) Token: 0x06027D31 RID: 163121 RVA: 0x0057A4F4 File Offset: 0x005786F4
		public List<IVehiclePassengerConfigT> DefaultPassengers { get; set; }

		// Token: 0x1700AFF1 RID: 45041
		// (get) Token: 0x06027D32 RID: 163122 RVA: 0x0057A4FD File Offset: 0x005786FD
		// (set) Token: 0x06027D33 RID: 163123 RVA: 0x0057A505 File Offset: 0x00578705
		public byte NullMask { get; set; }

		// Token: 0x06027D34 RID: 163124 RVA: 0x0057A510 File Offset: 0x00578710
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
