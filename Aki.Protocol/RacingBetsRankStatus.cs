using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001569 RID: 5481
	public enum RacingBetsRankStatus
	{
		// Token: 0x0400A658 RID: 42584
		[OriginalName("Rank")]
		Rank,
		// Token: 0x0400A659 RID: 42585
		[OriginalName("Top1")]
		Top1,
		// Token: 0x0400A65A RID: 42586
		[OriginalName("Top50")]
		Top50,
		// Token: 0x0400A65B RID: 42587
		[OriginalName("UnRank")]
		UnRank
	}
}
