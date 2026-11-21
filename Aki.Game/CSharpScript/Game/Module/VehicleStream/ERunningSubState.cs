using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x0200381A RID: 14362
	public enum ERunningSubState
	{
		// Token: 0x04014A63 RID: 84579
		None,
		// Token: 0x04014A64 RID: 84580
		Normal,
		// Token: 0x04014A65 RID: 84581
		BrakingByObstruction,
		// Token: 0x04014A66 RID: 84582
		BrakingByIntersection,
		// Token: 0x04014A67 RID: 84583
		WaitingModelBuffer,
		// Token: 0x04014A68 RID: 84584
		SlowDownByTurn,
		// Token: 0x04014A69 RID: 84585
		SlowDownByUphillSlope,
		// Token: 0x04014A6A RID: 84586
		SlowDownByDownhillSlope
	}
}
