using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F4 RID: 5620
	public enum MailLevel
	{
		// Token: 0x0400BEA3 RID: 48803
		[OriginalName("None")]
		None,
		// Token: 0x0400BEA4 RID: 48804
		[OriginalName("General")]
		General,
		// Token: 0x0400BEA5 RID: 48805
		[OriginalName("Important")]
		Important,
		// Token: 0x0400BEA6 RID: 48806
		[OriginalName("Administration")]
		Administration
	}
}
