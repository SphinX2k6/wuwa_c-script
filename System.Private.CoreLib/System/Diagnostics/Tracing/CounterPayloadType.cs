using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D3 RID: 2259
	[EventData]
	internal sealed class CounterPayloadType
	{
		// Token: 0x06008B6D RID: 35693 RVA: 0x00150CEF File Offset: 0x0014EEEF
		public CounterPayloadType(CounterPayload payload)
		{
			this.Payload = payload;
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06008B6E RID: 35694 RVA: 0x00150CFE File Offset: 0x0014EEFE
		// (set) Token: 0x06008B6F RID: 35695 RVA: 0x00150D06 File Offset: 0x0014EF06
		public CounterPayload Payload { get; set; }
	}
}
