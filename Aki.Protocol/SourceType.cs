using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001592 RID: 5522
	public enum SourceType
	{
		// Token: 0x0400A7B8 RID: 42936
		[OriginalName("UnDefine")]
		UnDefine,
		// Token: 0x0400A7B9 RID: 42937
		[OriginalName("SourceEntity")]
		SourceEntity = 3,
		// Token: 0x0400A7BA RID: 42938
		[OriginalName("SourceQuest")]
		SourceQuest
	}
}
