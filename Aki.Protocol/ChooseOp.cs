using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016DB RID: 5851
	public enum ChooseOp
	{
		// Token: 0x0400C672 RID: 50802
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C673 RID: 50803
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C674 RID: 50804
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
