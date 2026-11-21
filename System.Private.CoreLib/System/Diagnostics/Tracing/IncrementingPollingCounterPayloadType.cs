using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090D RID: 2317
	[EventData]
	internal sealed class IncrementingPollingCounterPayloadType
	{
		// Token: 0x06008D38 RID: 36152 RVA: 0x0015BF20 File Offset: 0x0015A120
		public IncrementingPollingCounterPayloadType(IncrementingCounterPayload payload)
		{
			this.Payload = payload;
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x0015BF2F File Offset: 0x0015A12F
		// (set) Token: 0x06008D3A RID: 36154 RVA: 0x0015BF37 File Offset: 0x0015A137
		public IncrementingCounterPayload Payload { get; set; }
	}
}
