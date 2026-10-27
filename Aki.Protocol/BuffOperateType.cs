using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001598 RID: 5528
	public enum BuffOperateType
	{
		// Token: 0x0400A7D5 RID: 42965
		[OriginalName("AddBuff")]
		AddBuff,
		// Token: 0x0400A7D6 RID: 42966
		[OriginalName("RemoveBuff")]
		RemoveBuff,
		// Token: 0x0400A7D7 RID: 42967
		[OriginalName("UndoBuff")]
		UndoBuff
	}
}
