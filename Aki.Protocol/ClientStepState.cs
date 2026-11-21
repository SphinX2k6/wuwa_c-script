using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B7 RID: 5815
	public enum ClientStepState
	{
		// Token: 0x0400C5B5 RID: 50613
		[OriginalName("NoStep")]
		NoStep,
		// Token: 0x0400C5B6 RID: 50614
		[OriginalName("SpecialEffect")]
		SpecialEffect,
		// Token: 0x0400C5B7 RID: 50615
		[OriginalName("EventPloting")]
		EventPloting
	}
}
