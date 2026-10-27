using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E5 RID: 5605
	public enum PhotographSubType
	{
		// Token: 0x0400BDD3 RID: 48595
		[OriginalName("None")]
		None,
		// Token: 0x0400BDD4 RID: 48596
		[OriginalName("PhotographSub")]
		PhotographSub = 7,
		// Token: 0x0400BDD5 RID: 48597
		[OriginalName("Role")]
		Role,
		// Token: 0x0400BDD6 RID: 48598
		[OriginalName("Quest")]
		Quest
	}
}
