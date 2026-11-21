using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001618 RID: 5656
	public enum MoveStatus
	{
		// Token: 0x0400ACB0 RID: 44208
		[OriginalName("MoveStatusStop")]
		Stop,
		// Token: 0x0400ACB1 RID: 44209
		[OriginalName("MoveStatusMoving")]
		Moving,
		// Token: 0x0400ACB2 RID: 44210
		[OriginalName("MoveStatusInterrupt")]
		Interrupt,
		// Token: 0x0400ACB3 RID: 44211
		[OriginalName("MoveStatusSwitch")]
		Switch
	}
}
