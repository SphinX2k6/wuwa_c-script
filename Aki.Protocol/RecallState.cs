using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200161F RID: 5663
	public enum RecallState
	{
		// Token: 0x0400C006 RID: 49158
		[OriginalName("RecallStateNotStart")]
		NotStart,
		// Token: 0x0400C007 RID: 49159
		[OriginalName("RecallStateProgress")]
		Progress,
		// Token: 0x0400C008 RID: 49160
		[OriginalName("RecallStateFinish")]
		Finish,
		// Token: 0x0400C009 RID: 49161
		[OriginalName("RecallStateDelete")]
		Delete
	}
}
