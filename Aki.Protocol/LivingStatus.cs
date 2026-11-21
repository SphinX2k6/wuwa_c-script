using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001608 RID: 5640
	public enum LivingStatus
	{
		// Token: 0x0400AC4A RID: 44106
		[OriginalName("Alive")]
		Alive,
		// Token: 0x0400AC4B RID: 44107
		[OriginalName("Dead")]
		Dead,
		// Token: 0x0400AC4C RID: 44108
		[OriginalName("Init")]
		Init,
		// Token: 0x0400AC4D RID: 44109
		[OriginalName("Dying")]
		Dying
	}
}
