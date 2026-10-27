using System;
using System.Runtime.CompilerServices;

// Token: 0x020032D0 RID: 13008
[NullableContext(1)]
[Nullable(0)]
public class EntityVehicleInfo
{
	// Token: 0x0601C419 RID: 115737 RVA: 0x007E0B59 File Offset: 0x007DED59
	public EntityVehicleInfo DeepCopy()
	{
		return new EntityVehicleInfo
		{
			EntityCreatureId = this.EntityCreatureId,
			VehicleCreatureId = this.VehicleCreatureId,
			Seat = this.Seat
		};
	}

	// Token: 0x0601C41A RID: 115738 RVA: 0x007E0B84 File Offset: 0x007DED84
	public virtual bool Equals(EntityVehicleInfo info)
	{
		return this.EntityCreatureId == info.EntityCreatureId && this.VehicleCreatureId == info.VehicleCreatureId && this.Seat == info.Seat;
	}

	// Token: 0x0400DFB2 RID: 57266
	public long EntityCreatureId;

	// Token: 0x0400DFB3 RID: 57267
	public long VehicleCreatureId;

	// Token: 0x0400DFB4 RID: 57268
	public int Seat = -1;

	// Token: 0x0400DFB5 RID: 57269
	public ELeaveVehicleType ExitType;
}
