using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000917 RID: 2327
	public enum EventOpcode
	{
		// Token: 0x040020B3 RID: 8371
		Info,
		// Token: 0x040020B4 RID: 8372
		Start,
		// Token: 0x040020B5 RID: 8373
		Stop,
		// Token: 0x040020B6 RID: 8374
		DataCollectionStart,
		// Token: 0x040020B7 RID: 8375
		DataCollectionStop,
		// Token: 0x040020B8 RID: 8376
		Extension,
		// Token: 0x040020B9 RID: 8377
		Reply,
		// Token: 0x040020BA RID: 8378
		Resume,
		// Token: 0x040020BB RID: 8379
		Suspend,
		// Token: 0x040020BC RID: 8380
		Send,
		// Token: 0x040020BD RID: 8381
		Receive = 240
	}
}
