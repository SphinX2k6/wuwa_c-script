using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002843 RID: 10307
public class VehicleRideSharingInfo
{
	// Token: 0x0601A098 RID: 106648 RVA: 0x008078B8 File Offset: 0x00805AB8
	[NullableContext(1)]
	public VehicleRideSharingInfo(VehiclePassengerUpdateNotify data)
	{
		this.PlayerId = data.PlayerId;
		this.RoleId = data.RoleId;
		this.RoleCreatureId = data.EntityId;
		this.Seat = data.SeatId;
	}

	// Token: 0x0400E45A RID: 58458
	public int PlayerId;

	// Token: 0x0400E45B RID: 58459
	public int RoleId;

	// Token: 0x0400E45C RID: 58460
	public long RoleCreatureId;

	// Token: 0x0400E45D RID: 58461
	public int Seat = -1;
}
