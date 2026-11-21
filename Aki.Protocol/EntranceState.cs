using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001606 RID: 5638
	public enum EntranceState
	{
		// Token: 0x0400AC42 RID: 44098
		[OriginalName("NotUnlock")]
		NotUnlock,
		// Token: 0x0400AC43 RID: 44099
		[OriginalName("Unlockable")]
		Unlockable,
		// Token: 0x0400AC44 RID: 44100
		[OriginalName("Unlocked")]
		Unlocked,
		// Token: 0x0400AC45 RID: 44101
		[OriginalName("Closed")]
		Closed
	}
}
