using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090B RID: 2315
	[EventData]
	internal sealed class IncrementingEventCounterPayloadType
	{
		// Token: 0x06008D2F RID: 36143 RVA: 0x0015BCC4 File Offset: 0x00159EC4
		public IncrementingEventCounterPayloadType(IncrementingCounterPayload payload)
		{
			this.Payload = payload;
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06008D30 RID: 36144 RVA: 0x0015BCD3 File Offset: 0x00159ED3
		// (set) Token: 0x06008D31 RID: 36145 RVA: 0x0015BCDB File Offset: 0x00159EDB
		public IncrementingCounterPayload Payload { get; set; }
	}
}
