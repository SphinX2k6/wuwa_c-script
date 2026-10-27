using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E9 RID: 5609
	public enum ArchiveType
	{
		// Token: 0x0400BDE4 RID: 48612
		[OriginalName("NoneArchive")]
		NoneArchive,
		// Token: 0x0400BDE5 RID: 48613
		[OriginalName("NormalArchive")]
		NormalArchive,
		// Token: 0x0400BDE6 RID: 48614
		[OriginalName("OverdueVersion")]
		OverdueVersion,
		// Token: 0x0400BDE7 RID: 48615
		[OriginalName("OverdueTime")]
		OverdueTime,
		// Token: 0x0400BDE8 RID: 48616
		[OriginalName("OverdueChangeSex")]
		OverdueChangeSex
	}
}
