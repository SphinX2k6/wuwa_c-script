using System;

// Token: 0x020031FF RID: 12799
public class NpcSeatInfo
{
	// Token: 0x0601B9C1 RID: 113089 RVA: 0x00794B24 File Offset: 0x00792D24
	public NpcSeatInfo(int npcEntityId, int seat)
	{
		this.NpcEntityId = npcEntityId;
		this.Seat = seat;
	}

	// Token: 0x0400D91C RID: 55580
	public readonly int NpcEntityId;

	// Token: 0x0400D91D RID: 55581
	public readonly int Seat = -1;

	// Token: 0x0400D91E RID: 55582
	public ENpcVehicleRideState RideState = ENpcVehicleRideState.MoveToVehicle;

	// Token: 0x0400D91F RID: 55583
	public int? TargetSplinePbDataId;
}
