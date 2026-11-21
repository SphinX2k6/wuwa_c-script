using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001667 RID: 5735
	public enum MailLevel
	{
		// Token: 0x0400C39A RID: 50074
		[OriginalName("None")]
		None,
		// Token: 0x0400C39B RID: 50075
		[OriginalName("General")]
		General,
		// Token: 0x0400C39C RID: 50076
		[OriginalName("Important")]
		Important,
		// Token: 0x0400C39D RID: 50077
		[OriginalName("Administration")]
		Administration
	}
}
