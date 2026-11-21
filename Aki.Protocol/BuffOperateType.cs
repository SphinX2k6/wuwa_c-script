using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200160A RID: 5642
	public enum BuffOperateType
	{
		// Token: 0x0400AC54 RID: 44116
		[OriginalName("AddBuff")]
		AddBuff,
		// Token: 0x0400AC55 RID: 44117
		[OriginalName("RemoveBuff")]
		RemoveBuff,
		// Token: 0x0400AC56 RID: 44118
		[OriginalName("UndoBuff")]
		UndoBuff
	}
}
