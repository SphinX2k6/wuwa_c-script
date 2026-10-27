using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F0 RID: 5616
	public enum KurotatoRoleSaveState
	{
		// Token: 0x0400BE92 RID: 48786
		[OriginalName("Undefine")]
		Undefine,
		// Token: 0x0400BE93 RID: 48787
		[OriginalName("NotSaved")]
		NotSaved,
		// Token: 0x0400BE94 RID: 48788
		[OriginalName("ClientSaved")]
		ClientSaved,
		// Token: 0x0400BE95 RID: 48789
		[OriginalName("ServerSaved")]
		ServerSaved
	}
}
