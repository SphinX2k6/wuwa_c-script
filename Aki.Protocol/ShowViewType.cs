using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016BA RID: 5818
	public enum ShowViewType
	{
		// Token: 0x0400C5CD RID: 50637
		[OriginalName("None")]
		None,
		// Token: 0x0400C5CE RID: 50638
		[OriginalName("GridTake")]
		GridTake,
		// Token: 0x0400C5CF RID: 50639
		[OriginalName("RogueResAddRole")]
		RogueResAddRole,
		// Token: 0x0400C5D0 RID: 50640
		[OriginalName("PhantomEntryUnlock")]
		PhantomEntryUnlock,
		// Token: 0x0400C5D1 RID: 50641
		[OriginalName("RoleBuffUnlock")]
		RoleBuffUnlock,
		// Token: 0x0400C5D2 RID: 50642
		[OriginalName("InstResult")]
		InstResult,
		// Token: 0x0400C5D3 RID: 50643
		[OriginalName("RoleBond")]
		RoleBond,
		// Token: 0x0400C5D4 RID: 50644
		[OriginalName("AddToken")]
		AddToken
	}
}
