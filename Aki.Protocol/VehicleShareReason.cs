using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001615 RID: 5653
	public enum VehicleShareReason
	{
		// Token: 0x0400ACA4 RID: 44196
		[OriginalName("VehicleShareReason_ClientRequest")]
		ClientRequest,
		// Token: 0x0400ACA5 RID: 44197
		[OriginalName("VehicleShareReason_ChangeFormation")]
		ChangeFormation,
		// Token: 0x0400ACA6 RID: 44198
		[OriginalName("VehicleShareReason_GetOff")]
		GetOff,
		// Token: 0x0400ACA7 RID: 44199
		[OriginalName("VehicleShareReason_RebackScene")]
		RebackScene,
		// Token: 0x0400ACA8 RID: 44200
		[OriginalName("VehicleShareReason_CharacterDie")]
		CharacterDie,
		// Token: 0x0400ACA9 RID: 44201
		[OriginalName("VehicleShareReason_Command")]
		Command
	}
}
