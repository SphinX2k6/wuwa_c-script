using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048A3 RID: 18595
	public enum ERunningSubState
	{
		// Token: 0x0401A1F0 RID: 106992
		None,
		// Token: 0x0401A1F1 RID: 106993
		Normal,
		// Token: 0x0401A1F2 RID: 106994
		BrakingByObstruction,
		// Token: 0x0401A1F3 RID: 106995
		BrakingByIntersection,
		// Token: 0x0401A1F4 RID: 106996
		WaitingModelBuffer,
		// Token: 0x0401A1F5 RID: 106997
		SlowDownByTurn,
		// Token: 0x0401A1F6 RID: 106998
		SlowDownByUphillSlope,
		// Token: 0x0401A1F7 RID: 106999
		SlowDownByDownhillSlope
	}
}
