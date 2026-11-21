using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B8 RID: 5816
	public enum StepState
	{
		// Token: 0x0400C5B9 RID: 50617
		[OriginalName("NotInit")]
		NotInit,
		// Token: 0x0400C5BA RID: 50618
		[OriginalName("WaitConfirm")]
		WaitConfirm,
		// Token: 0x0400C5BB RID: 50619
		[OriginalName("WaitEffect")]
		WaitEffect,
		// Token: 0x0400C5BC RID: 50620
		[OriginalName("EffectInterrupt")]
		EffectInterrupt
	}
}
