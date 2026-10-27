using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048A9 RID: 18601
	[EnumExtensions]
	public enum EMoveCheckResult
	{
		// Token: 0x0401A214 RID: 107028
		None,
		// Token: 0x0401A215 RID: 107029
		TraceBlock,
		// Token: 0x0401A216 RID: 107030
		CheckPlayerBlock,
		// Token: 0x0401A217 RID: 107031
		SameRoadwayVehicleBlock,
		// Token: 0x0401A218 RID: 107032
		NextRoadwayVehicleBlock,
		// Token: 0x0401A219 RID: 107033
		Intersection,
		// Token: 0x0401A21A RID: 107034
		CrossPlayer,
		// Token: 0x0401A21B RID: 107035
		CrossSameRoadwayVehicle,
		// Token: 0x0401A21C RID: 107036
		CrossNextRoadwayVehicle,
		// Token: 0x0401A21D RID: 107037
		HeadOverRoadOnWaitIntersection
	}
}
