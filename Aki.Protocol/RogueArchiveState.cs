using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A0 RID: 5792
	public enum RogueArchiveState
	{
		// Token: 0x0400C540 RID: 50496
		[OriginalName("CantSave")]
		CantSave,
		// Token: 0x0400C541 RID: 50497
		[OriginalName("CanSave")]
		CanSave,
		// Token: 0x0400C542 RID: 50498
		[OriginalName("Saved")]
		Saved
	}
}
