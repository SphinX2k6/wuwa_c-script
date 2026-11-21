using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B4 RID: 5812
	public enum RoverRogueInstState
	{
		// Token: 0x0400C59E RID: 50590
		[OriginalName("RoverRogueInstNotStart")]
		RoverRogueInstNotStart,
		// Token: 0x0400C59F RID: 50591
		[OriginalName("RoverRogueInstRunning")]
		RoverRogueInstRunning,
		// Token: 0x0400C5A0 RID: 50592
		[OriginalName("RoverRogueInstFinished")]
		RoverRogueInstFinished,
		// Token: 0x0400C5A1 RID: 50593
		[OriginalName("RoverRogueInstQuit")]
		RoverRogueInstQuit,
		// Token: 0x0400C5A2 RID: 50594
		[OriginalName("RoverRogueInstDead")]
		RoverRogueInstDead
	}
}
