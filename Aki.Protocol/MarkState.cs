using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200166A RID: 5738
	public enum MarkState
	{
		// Token: 0x0400C41B RID: 50203
		[OriginalName("MarkNormal")]
		MarkNormal,
		// Token: 0x0400C41C RID: 50204
		[OriginalName("MarkDisable")]
		MarkDisable,
		// Token: 0x0400C41D RID: 50205
		[OriginalName("MarkComplete")]
		MarkComplete
	}
}
