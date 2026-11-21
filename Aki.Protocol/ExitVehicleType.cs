using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001613 RID: 5651
	public enum ExitVehicleType
	{
		// Token: 0x0400AC9B RID: 44187
		[OriginalName("ExitVehicleTypeLaunch")]
		Launch,
		// Token: 0x0400AC9C RID: 44188
		[OriginalName("ExitVehicleTypeNormal")]
		Normal,
		// Token: 0x0400AC9D RID: 44189
		[OriginalName("ExitVehicleTypeDelayShow")]
		DelayShow,
		// Token: 0x0400AC9E RID: 44190
		[OriginalName("ExitVehicleTypeSeatStandUp")]
		SeatStandUp,
		// Token: 0x0400AC9F RID: 44191
		[OriginalName("ExitVehicleTypeAllRole")]
		AllRole
	}
}
