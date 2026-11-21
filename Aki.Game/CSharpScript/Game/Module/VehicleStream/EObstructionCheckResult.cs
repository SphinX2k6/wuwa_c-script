using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x0200381D RID: 14365
	[EnumExtensions]
	public enum EObstructionCheckResult
	{
		// Token: 0x04014A75 RID: 84597
		None,
		// Token: 0x04014A76 RID: 84598
		TraceBlock,
		// Token: 0x04014A77 RID: 84599
		CheckPlayerBlock,
		// Token: 0x04014A78 RID: 84600
		SameRoadwayVehicleBlock,
		// Token: 0x04014A79 RID: 84601
		NextRoadwayVehicleBlock
	}
}
