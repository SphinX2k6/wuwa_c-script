using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D5 RID: 5589
	public enum SpawnMonsterStepType
	{
		// Token: 0x0400AAB5 RID: 43701
		[OriginalName("Prepare")]
		Prepare,
		// Token: 0x0400AAB6 RID: 43702
		[OriginalName("Active")]
		Active,
		// Token: 0x0400AAB7 RID: 43703
		[OriginalName("Refreshed")]
		Refreshed,
		// Token: 0x0400AAB8 RID: 43704
		[OriginalName("End")]
		End
	}
}
