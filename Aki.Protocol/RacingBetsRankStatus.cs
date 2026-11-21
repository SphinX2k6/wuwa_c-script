using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015DF RID: 5599
	public enum RacingBetsRankStatus
	{
		// Token: 0x0400AAE5 RID: 43749
		[OriginalName("Rank")]
		Rank,
		// Token: 0x0400AAE6 RID: 43750
		[OriginalName("Top1")]
		Top1,
		// Token: 0x0400AAE7 RID: 43751
		[OriginalName("Top50")]
		Top50,
		// Token: 0x0400AAE8 RID: 43752
		[OriginalName("UnRank")]
		UnRank
	}
}
