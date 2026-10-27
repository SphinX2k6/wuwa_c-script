using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001584 RID: 5508
	public enum DangoBrawlPhase
	{
		// Token: 0x0400A776 RID: 42870
		[OriginalName("EventSelect")]
		EventSelect,
		// Token: 0x0400A777 RID: 42871
		[OriginalName("Prepare")]
		Prepare,
		// Token: 0x0400A778 RID: 42872
		[OriginalName("Fighting")]
		Fighting,
		// Token: 0x0400A779 RID: 42873
		[OriginalName("FightRestore")]
		FightRestore
	}
}
