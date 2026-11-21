using System;

// Token: 0x0200276E RID: 10094
public class NpcSeatInfo
{
	// Token: 0x06019546 RID: 103750 RVA: 0x007BD170 File Offset: 0x007BB370
	public NpcSeatInfo(int npcEntityId, int seat)
	{
		this.NpcEntityId = npcEntityId;
		this.Seat = seat;
	}

	// Token: 0x0400DDBA RID: 56762
	public readonly int NpcEntityId;

	// Token: 0x0400DDBB RID: 56763
	public readonly int Seat = -1;

	// Token: 0x0400DDBC RID: 56764
	public ENpcVehicleRideState RideState = ENpcVehicleRideState.MoveToVehicle;

	// Token: 0x0400DDBD RID: 56765
	public int? TargetSplinePbDataId;
}
