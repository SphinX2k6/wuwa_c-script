using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001641 RID: 5697
	public enum StepState
	{
		// Token: 0x0400C0AE RID: 49326
		[OriginalName("NotInit")]
		NotInit,
		// Token: 0x0400C0AF RID: 49327
		[OriginalName("WaitConfirm")]
		WaitConfirm,
		// Token: 0x0400C0B0 RID: 49328
		[OriginalName("WaitEffect")]
		WaitEffect,
		// Token: 0x0400C0B1 RID: 49329
		[OriginalName("EffectInterrupt")]
		EffectInterrupt
	}
}
