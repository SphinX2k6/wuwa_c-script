using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001692 RID: 5778
	public enum RecallState
	{
		// Token: 0x0400C500 RID: 50432
		[OriginalName("RecallStateNotStart")]
		NotStart,
		// Token: 0x0400C501 RID: 50433
		[OriginalName("RecallStateProgress")]
		Progress,
		// Token: 0x0400C502 RID: 50434
		[OriginalName("RecallStateFinish")]
		Finish,
		// Token: 0x0400C503 RID: 50435
		[OriginalName("RecallStateDelete")]
		Delete
	}
}
