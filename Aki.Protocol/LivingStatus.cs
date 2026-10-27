using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001596 RID: 5526
	public enum LivingStatus
	{
		// Token: 0x0400A7CB RID: 42955
		[OriginalName("Alive")]
		Alive,
		// Token: 0x0400A7CC RID: 42956
		[OriginalName("Dead")]
		Dead,
		// Token: 0x0400A7CD RID: 42957
		[OriginalName("Init")]
		Init,
		// Token: 0x0400A7CE RID: 42958
		[OriginalName("Dying")]
		Dying
	}
}
