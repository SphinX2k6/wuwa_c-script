using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001570 RID: 5488
	public enum BossRushBuffSelectionStatus
	{
		// Token: 0x0400A68F RID: 42639
		[OriginalName("BuffEmpty")]
		BuffEmpty,
		// Token: 0x0400A690 RID: 42640
		[OriginalName("BuffSelected")]
		BuffSelected,
		// Token: 0x0400A691 RID: 42641
		[OriginalName("BuffLocked")]
		BuffLocked,
		// Token: 0x0400A692 RID: 42642
		[OriginalName("BuffInactive")]
		BuffInactive
	}
}
