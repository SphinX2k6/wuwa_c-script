using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A3 RID: 5539
	public enum VehicleShareReason
	{
		// Token: 0x0400A825 RID: 43045
		[OriginalName("VehicleShareReason_ClientRequest")]
		ClientRequest,
		// Token: 0x0400A826 RID: 43046
		[OriginalName("VehicleShareReason_ChangeFormation")]
		ChangeFormation,
		// Token: 0x0400A827 RID: 43047
		[OriginalName("VehicleShareReason_GetOff")]
		GetOff,
		// Token: 0x0400A828 RID: 43048
		[OriginalName("VehicleShareReason_RebackScene")]
		RebackScene,
		// Token: 0x0400A829 RID: 43049
		[OriginalName("VehicleShareReason_CharacterDie")]
		CharacterDie,
		// Token: 0x0400A82A RID: 43050
		[OriginalName("VehicleShareReason_Command")]
		Command
	}
}
