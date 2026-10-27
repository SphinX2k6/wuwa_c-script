using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A6 RID: 5542
	public enum MoveStatus
	{
		// Token: 0x0400A831 RID: 43057
		[OriginalName("MoveStatusStop")]
		Stop,
		// Token: 0x0400A832 RID: 43058
		[OriginalName("MoveStatusMoving")]
		Moving,
		// Token: 0x0400A833 RID: 43059
		[OriginalName("MoveStatusInterrupt")]
		Interrupt,
		// Token: 0x0400A834 RID: 43060
		[OriginalName("MoveStatusSwitch")]
		Switch
	}
}
