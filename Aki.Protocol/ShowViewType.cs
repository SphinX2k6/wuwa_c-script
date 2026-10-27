using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001643 RID: 5699
	public enum ShowViewType
	{
		// Token: 0x0400C0C2 RID: 49346
		[OriginalName("None")]
		None,
		// Token: 0x0400C0C3 RID: 49347
		[OriginalName("GridTake")]
		GridTake,
		// Token: 0x0400C0C4 RID: 49348
		[OriginalName("RogueResAddRole")]
		RogueResAddRole,
		// Token: 0x0400C0C5 RID: 49349
		[OriginalName("PhantomEntryUnlock")]
		PhantomEntryUnlock,
		// Token: 0x0400C0C6 RID: 49350
		[OriginalName("RoleBuffUnlock")]
		RoleBuffUnlock,
		// Token: 0x0400C0C7 RID: 49351
		[OriginalName("InstResult")]
		InstResult,
		// Token: 0x0400C0C8 RID: 49352
		[OriginalName("RoleBond")]
		RoleBond,
		// Token: 0x0400C0C9 RID: 49353
		[OriginalName("AddToken")]
		AddToken
	}
}
