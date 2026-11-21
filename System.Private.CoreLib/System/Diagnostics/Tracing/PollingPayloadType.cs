using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200090F RID: 2319
	[EventData]
	internal sealed class PollingPayloadType
	{
		// Token: 0x06008D3E RID: 36158 RVA: 0x0015C134 File Offset: 0x0015A334
		public PollingPayloadType(CounterPayload payload)
		{
			this.Payload = payload;
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0015C143 File Offset: 0x0015A343
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x0015C14B File Offset: 0x0015A34B
		public CounterPayload Payload { get; set; }
	}
}
