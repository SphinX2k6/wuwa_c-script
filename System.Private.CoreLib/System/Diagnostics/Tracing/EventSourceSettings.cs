using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F1 RID: 2289
	[Flags]
	public enum EventSourceSettings
	{
		// Token: 0x04001FEE RID: 8174
		Default = 0,
		// Token: 0x04001FEF RID: 8175
		ThrowOnEventWriteErrors = 1,
		// Token: 0x04001FF0 RID: 8176
		EtwManifestEventFormat = 4,
		// Token: 0x04001FF1 RID: 8177
		EtwSelfDescribingEventFormat = 8
	}
}
