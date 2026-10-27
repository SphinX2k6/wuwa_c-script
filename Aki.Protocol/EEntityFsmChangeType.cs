using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B2 RID: 5554
	public enum EEntityFsmChangeType
	{
		// Token: 0x0400BC6C RID: 48236
		[OriginalName("Enter")]
		Enter,
		// Token: 0x0400BC6D RID: 48237
		[OriginalName("Exit")]
		Exit,
		// Token: 0x0400BC6E RID: 48238
		[OriginalName("BindStart")]
		BindStart = 3,
		// Token: 0x0400BC6F RID: 48239
		[OriginalName("BindEnd")]
		BindEnd,
		// Token: 0x0400BC70 RID: 48240
		[OriginalName("Task")]
		Task
	}
}
