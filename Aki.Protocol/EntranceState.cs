using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001594 RID: 5524
	public enum EntranceState
	{
		// Token: 0x0400A7C3 RID: 42947
		[OriginalName("NotUnlock")]
		NotUnlock,
		// Token: 0x0400A7C4 RID: 42948
		[OriginalName("Unlockable")]
		Unlockable,
		// Token: 0x0400A7C5 RID: 42949
		[OriginalName("Unlocked")]
		Unlocked,
		// Token: 0x0400A7C6 RID: 42950
		[OriginalName("Closed")]
		Closed
	}
}
