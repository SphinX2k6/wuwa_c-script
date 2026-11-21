using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001662 RID: 5730
	public enum KurotatoRoleSaveState
	{
		// Token: 0x0400C386 RID: 50054
		[OriginalName("Undefine")]
		Undefine,
		// Token: 0x0400C387 RID: 50055
		[OriginalName("NotSaved")]
		NotSaved,
		// Token: 0x0400C388 RID: 50056
		[OriginalName("ClientSaved")]
		ClientSaved,
		// Token: 0x0400C389 RID: 50057
		[OriginalName("ServerSaved")]
		ServerSaved
	}
}
