using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015FA RID: 5626
	public enum DangoBrawlPhase
	{
		// Token: 0x0400AC03 RID: 44035
		[OriginalName("EventSelect")]
		EventSelect,
		// Token: 0x0400AC04 RID: 44036
		[OriginalName("Prepare")]
		Prepare,
		// Token: 0x0400AC05 RID: 44037
		[OriginalName("Fighting")]
		Fighting,
		// Token: 0x0400AC06 RID: 44038
		[OriginalName("FightRestore")]
		FightRestore
	}
}
