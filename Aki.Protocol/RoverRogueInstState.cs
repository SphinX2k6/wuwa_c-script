using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200163D RID: 5693
	public enum RoverRogueInstState
	{
		// Token: 0x0400C093 RID: 49299
		[OriginalName("RoverRogueInstNotStart")]
		RoverRogueInstNotStart,
		// Token: 0x0400C094 RID: 49300
		[OriginalName("RoverRogueInstRunning")]
		RoverRogueInstRunning,
		// Token: 0x0400C095 RID: 49301
		[OriginalName("RoverRogueInstFinished")]
		RoverRogueInstFinished,
		// Token: 0x0400C096 RID: 49302
		[OriginalName("RoverRogueInstQuit")]
		RoverRogueInstQuit,
		// Token: 0x0400C097 RID: 49303
		[OriginalName("RoverRogueInstDead")]
		RoverRogueInstDead
	}
}
