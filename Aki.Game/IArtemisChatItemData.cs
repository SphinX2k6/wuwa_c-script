using System;
using System.Runtime.CompilerServices;

// Token: 0x020010F2 RID: 4338
[NullableContext(1)]
public interface IArtemisChatItemData
{
	// Token: 0x1700098E RID: 2446
	// (get) Token: 0x0600711E RID: 28958
	string Content { get; }

	// Token: 0x1700098F RID: 2447
	// (get) Token: 0x0600711F RID: 28959
	string PicturePath { get; }

	// Token: 0x17000990 RID: 2448
	// (get) Token: 0x06007120 RID: 28960
	bool IsLock { get; }

	// Token: 0x17000991 RID: 2449
	// (get) Token: 0x06007121 RID: 28961
	bool IsShowEffect { get; }
}
