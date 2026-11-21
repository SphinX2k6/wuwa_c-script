using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B7 RID: 5559
	public enum PhantomCollectRewardType
	{
		// Token: 0x0400A9B2 RID: 43442
		[OriginalName("PhantomsCollect")]
		PhantomsCollect,
		// Token: 0x0400A9B3 RID: 43443
		[OriginalName("DataDock")]
		DataDock,
		// Token: 0x0400A9B4 RID: 43444
		[OriginalName("PhantomSideQuest")]
		PhantomSideQuest,
		// Token: 0x0400A9B5 RID: 43445
		[OriginalName("Max")]
		Max
	}
}
