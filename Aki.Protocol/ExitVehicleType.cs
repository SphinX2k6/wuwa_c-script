using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A1 RID: 5537
	public enum ExitVehicleType
	{
		// Token: 0x0400A81C RID: 43036
		[OriginalName("ExitVehicleTypeLaunch")]
		Launch,
		// Token: 0x0400A81D RID: 43037
		[OriginalName("ExitVehicleTypeNormal")]
		Normal,
		// Token: 0x0400A81E RID: 43038
		[OriginalName("ExitVehicleTypeDelayShow")]
		DelayShow,
		// Token: 0x0400A81F RID: 43039
		[OriginalName("ExitVehicleTypeSeatStandUp")]
		SeatStandUp,
		// Token: 0x0400A820 RID: 43040
		[OriginalName("ExitVehicleTypeAllRole")]
		AllRole
	}
}
