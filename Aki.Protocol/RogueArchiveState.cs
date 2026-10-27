using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162D RID: 5677
	public enum RogueArchiveState
	{
		// Token: 0x0400C046 RID: 49222
		[OriginalName("CantSave")]
		CantSave,
		// Token: 0x0400C047 RID: 49223
		[OriginalName("CanSave")]
		CanSave,
		// Token: 0x0400C048 RID: 49224
		[OriginalName("Saved")]
		Saved
	}
}
