using System;
using System.Runtime.CompilerServices;

// Token: 0x02002842 RID: 10306
[NullableContext(1)]
[Nullable(0)]
public class ScenePlayerVehicleInfo : EntityVehicleInfo
{
	// Token: 0x0601A095 RID: 106645 RVA: 0x00807849 File Offset: 0x00805A49
	public new ScenePlayerVehicleInfo DeepCopy()
	{
		return new ScenePlayerVehicleInfo
		{
			PlayerId = this.PlayerId,
			EntityCreatureId = this.EntityCreatureId,
			VehicleCreatureId = this.VehicleCreatureId,
			Seat = this.Seat
		};
	}

	// Token: 0x0601A096 RID: 106646 RVA: 0x00807880 File Offset: 0x00805A80
	public override bool Equals(EntityVehicleInfo info)
	{
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = info as ScenePlayerVehicleInfo;
		return scenePlayerVehicleInfo != null && this.PlayerId == scenePlayerVehicleInfo.PlayerId && base.Equals(info);
	}

	// Token: 0x0400E459 RID: 58457
	public int PlayerId;
}
