using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F7 RID: 5623
	public enum MarkState
	{
		// Token: 0x0400BF21 RID: 48929
		[OriginalName("MarkNormal")]
		MarkNormal,
		// Token: 0x0400BF22 RID: 48930
		[OriginalName("MarkDisable")]
		MarkDisable,
		// Token: 0x0400BF23 RID: 48931
		[OriginalName("MarkComplete")]
		MarkComplete
	}
}
