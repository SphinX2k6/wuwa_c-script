using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001606 RID: 5638
	public enum PayUpdateType
	{
		// Token: 0x0400BF76 RID: 49014
		[OriginalName("None")]
		None,
		// Token: 0x0400BF77 RID: 49015
		[OriginalName("Daily")]
		Daily,
		// Token: 0x0400BF78 RID: 49016
		[OriginalName("Weekly")]
		Weekly,
		// Token: 0x0400BF79 RID: 49017
		[OriginalName("Monthly")]
		Monthly,
		// Token: 0x0400BF7A RID: 49018
		[OriginalName("Forever")]
		Forever
	}
}
