using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001604 RID: 5636
	public enum SourceType
	{
		// Token: 0x0400AC37 RID: 44087
		[OriginalName("UnDefine")]
		UnDefine,
		// Token: 0x0400AC38 RID: 44088
		[OriginalName("SourceEntity")]
		SourceEntity = 3,
		// Token: 0x0400AC39 RID: 44089
		[OriginalName("SourceQuest")]
		SourceQuest
	}
}
