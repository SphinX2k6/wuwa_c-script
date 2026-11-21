using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B1 RID: 5809
	public enum RoverRogueGainDataType
	{
		// Token: 0x0400C58E RID: 50574
		[OriginalName("RoverRogueGainUnknown")]
		RoverRogueGainUnknown,
		// Token: 0x0400C58F RID: 50575
		[OriginalName("RoverRogueGainBless")]
		RoverRogueGainBless,
		// Token: 0x0400C590 RID: 50576
		[OriginalName("RoverRogueGainRoleEnhance")]
		RoverRogueGainRoleEnhance,
		// Token: 0x0400C591 RID: 50577
		[OriginalName("RoverRogueGainLootItem")]
		RoverRogueGainLootItem,
		// Token: 0x0400C592 RID: 50578
		[OriginalName("RoverRogueGainItem")]
		RoverRogueGainItem
	}
}
