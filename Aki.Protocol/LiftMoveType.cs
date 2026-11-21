using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001601 RID: 5633
	public enum LiftMoveType
	{
		// Token: 0x0400AC2A RID: 44074
		[OriginalName("Default")]
		Default,
		// Token: 0x0400AC2B RID: 44075
		[OriginalName("Teleport")]
		Teleport,
		// Token: 0x0400AC2C RID: 44076
		[OriginalName("CustomSpeed")]
		CustomSpeed
	}
}
