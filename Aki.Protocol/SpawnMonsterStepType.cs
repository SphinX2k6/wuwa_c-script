using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155F RID: 5471
	public enum SpawnMonsterStepType
	{
		// Token: 0x0400A628 RID: 42536
		[OriginalName("Prepare")]
		Prepare,
		// Token: 0x0400A629 RID: 42537
		[OriginalName("Active")]
		Active,
		// Token: 0x0400A62A RID: 42538
		[OriginalName("Refreshed")]
		Refreshed,
		// Token: 0x0400A62B RID: 42539
		[OriginalName("End")]
		End
	}
}
