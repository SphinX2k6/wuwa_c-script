using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003820 RID: 14368
	[EnumExtensions]
	public enum EMoveCheckResult
	{
		// Token: 0x04014A87 RID: 84615
		None,
		// Token: 0x04014A88 RID: 84616
		TraceBlock,
		// Token: 0x04014A89 RID: 84617
		CheckPlayerBlock,
		// Token: 0x04014A8A RID: 84618
		SameRoadwayVehicleBlock,
		// Token: 0x04014A8B RID: 84619
		NextRoadwayVehicleBlock,
		// Token: 0x04014A8C RID: 84620
		Intersection,
		// Token: 0x04014A8D RID: 84621
		CrossPlayer,
		// Token: 0x04014A8E RID: 84622
		CrossSameRoadwayVehicle,
		// Token: 0x04014A8F RID: 84623
		CrossNextRoadwayVehicle,
		// Token: 0x04014A90 RID: 84624
		HeadOverRoadOnWaitIntersection
	}
}
