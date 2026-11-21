using System;
using System.Runtime.CompilerServices;

// Token: 0x02002841 RID: 10305
[NullableContext(1)]
[Nullable(0)]
public class EntityVehicleInfo
{
	// Token: 0x0601A092 RID: 106642 RVA: 0x008077E1 File Offset: 0x008059E1
	public EntityVehicleInfo DeepCopy()
	{
		return new EntityVehicleInfo
		{
			EntityCreatureId = this.EntityCreatureId,
			VehicleCreatureId = this.VehicleCreatureId,
			Seat = this.Seat
		};
	}

	// Token: 0x0601A093 RID: 106643 RVA: 0x0080780C File Offset: 0x00805A0C
	public virtual bool Equals(EntityVehicleInfo info)
	{
		return this.EntityCreatureId == info.EntityCreatureId && this.VehicleCreatureId == info.VehicleCreatureId && this.Seat == info.Seat;
	}

	// Token: 0x0400E455 RID: 58453
	public long EntityCreatureId;

	// Token: 0x0400E456 RID: 58454
	public long VehicleCreatureId;

	// Token: 0x0400E457 RID: 58455
	public int Seat = -1;

	// Token: 0x0400E458 RID: 58456
	public ELeaveVehicleType ExitType;
}
