using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200165B RID: 5723
	public enum ArchiveType
	{
		// Token: 0x0400C2D8 RID: 49880
		[OriginalName("NoneArchive")]
		NoneArchive,
		// Token: 0x0400C2D9 RID: 49881
		[OriginalName("NormalArchive")]
		NormalArchive,
		// Token: 0x0400C2DA RID: 49882
		[OriginalName("OverdueVersion")]
		OverdueVersion,
		// Token: 0x0400C2DB RID: 49883
		[OriginalName("OverdueTime")]
		OverdueTime,
		// Token: 0x0400C2DC RID: 49884
		[OriginalName("OverdueChangeSex")]
		OverdueChangeSex
	}
}
