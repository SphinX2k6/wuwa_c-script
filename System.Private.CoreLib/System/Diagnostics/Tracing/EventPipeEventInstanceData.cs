using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D5 RID: 2261
	internal struct EventPipeEventInstanceData
	{
		// Token: 0x04001F5D RID: 8029
		internal IntPtr ProviderID;

		// Token: 0x04001F5E RID: 8030
		internal uint EventID;

		// Token: 0x04001F5F RID: 8031
		internal uint ThreadID;

		// Token: 0x04001F60 RID: 8032
		internal long TimeStamp;

		// Token: 0x04001F61 RID: 8033
		internal Guid ActivityId;

		// Token: 0x04001F62 RID: 8034
		internal Guid ChildActivityId;

		// Token: 0x04001F63 RID: 8035
		internal IntPtr Payload;

		// Token: 0x04001F64 RID: 8036
		internal uint PayloadLength;
	}
}
