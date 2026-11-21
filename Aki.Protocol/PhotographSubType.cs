using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001657 RID: 5719
	public enum PhotographSubType
	{
		// Token: 0x0400C2C7 RID: 49863
		[OriginalName("None")]
		None,
		// Token: 0x0400C2C8 RID: 49864
		[OriginalName("PhotographSub")]
		PhotographSub = 7,
		// Token: 0x0400C2C9 RID: 49865
		[OriginalName("Role")]
		Role,
		// Token: 0x0400C2CA RID: 49866
		[OriginalName("Quest")]
		Quest
	}
}
