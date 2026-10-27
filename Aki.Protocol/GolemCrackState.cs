using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015DF RID: 5599
	public enum GolemCrackState
	{
		// Token: 0x0400BDB1 RID: 48561
		[OriginalName("GolemCrackLocked")]
		GolemCrackLocked,
		// Token: 0x0400BDB2 RID: 48562
		[OriginalName("GolemCrackUnlocked")]
		GolemCrackUnlocked,
		// Token: 0x0400BDB3 RID: 48563
		[OriginalName("GolemCrackFinished")]
		GolemCrackFinished
	}
}
