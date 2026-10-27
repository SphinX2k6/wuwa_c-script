using System;
using System.Runtime.CompilerServices;

// Token: 0x020032D1 RID: 13009
[NullableContext(1)]
[Nullable(0)]
public class ScenePlayerVehicleInfo : EntityVehicleInfo
{
	// Token: 0x0601C41C RID: 115740 RVA: 0x007E0BC1 File Offset: 0x007DEDC1
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

	// Token: 0x0601C41D RID: 115741 RVA: 0x007E0BF8 File Offset: 0x007DEDF8
	public override bool Equals(EntityVehicleInfo info)
	{
		ScenePlayerVehicleInfo scenePlayerVehicleInfo = info as ScenePlayerVehicleInfo;
		return scenePlayerVehicleInfo != null && this.PlayerId == scenePlayerVehicleInfo.PlayerId && base.Equals(info);
	}

	// Token: 0x0400DFB6 RID: 57270
	public int PlayerId;
}
