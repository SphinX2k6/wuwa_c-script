using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048A6 RID: 18598
	[EnumExtensions]
	public enum EObstructionCheckResult
	{
		// Token: 0x0401A202 RID: 107010
		None,
		// Token: 0x0401A203 RID: 107011
		TraceBlock,
		// Token: 0x0401A204 RID: 107012
		CheckPlayerBlock,
		// Token: 0x0401A205 RID: 107013
		SameRoadwayVehicleBlock,
		// Token: 0x0401A206 RID: 107014
		NextRoadwayVehicleBlock
	}
}
