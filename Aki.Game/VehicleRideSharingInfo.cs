using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020032D2 RID: 13010
public class VehicleRideSharingInfo
{
	// Token: 0x0601C41F RID: 115743 RVA: 0x007E0C30 File Offset: 0x007DEE30
	[NullableContext(1)]
	public VehicleRideSharingInfo(VehiclePassengerUpdateNotify data)
	{
		this.PlayerId = data.PlayerId;
		this.RoleId = data.RoleId;
		this.RoleCreatureId = data.EntityId;
		this.Seat = data.SeatId;
	}

	// Token: 0x0400DFB7 RID: 57271
	public int PlayerId;

	// Token: 0x0400DFB8 RID: 57272
	public int RoleId;

	// Token: 0x0400DFB9 RID: 57273
	public long RoleCreatureId;

	// Token: 0x0400DFBA RID: 57274
	public int Seat = -1;
}
