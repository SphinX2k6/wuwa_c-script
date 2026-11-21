using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000919 RID: 2329
	[Flags]
	public enum EventKeywords : long
	{
		// Token: 0x040020C5 RID: 8389
		None = 0L,
		// Token: 0x040020C6 RID: 8390
		All = -1L,
		// Token: 0x040020C7 RID: 8391
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x040020C8 RID: 8392
		WdiContext = 562949953421312L,
		// Token: 0x040020C9 RID: 8393
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x040020CA RID: 8394
		Sqm = 2251799813685248L,
		// Token: 0x040020CB RID: 8395
		AuditFailure = 4503599627370496L,
		// Token: 0x040020CC RID: 8396
		AuditSuccess = 9007199254740992L,
		// Token: 0x040020CD RID: 8397
		CorrelationHint = 4503599627370496L,
		// Token: 0x040020CE RID: 8398
		EventLogClassic = 36028797018963968L
	}
}
