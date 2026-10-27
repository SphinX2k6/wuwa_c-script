using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A82 RID: 6786
[NullableContext(1)]
public interface ICdnServerAddress
{
	// Token: 0x17001066 RID: 4198
	// (get) Token: 0x0600C7FE RID: 51198
	string GachaDetailServerAddressPrefix { get; }

	// Token: 0x17001067 RID: 4199
	// (get) Token: 0x0600C7FF RID: 51199
	string GachaDetailServerId { get; }

	// Token: 0x17001068 RID: 4200
	// (get) Token: 0x0600C800 RID: 51200
	string GachaRecordServerAddressPrefix { get; }

	// Token: 0x17001069 RID: 4201
	// (get) Token: 0x0600C801 RID: 51201
	string GachaRecordServerId { get; }

	// Token: 0x1700106A RID: 4202
	// (get) Token: 0x0600C802 RID: 51202
	string NoticeServerPrefixAddress { get; }

	// Token: 0x1700106B RID: 4203
	// (get) Token: 0x0600C803 RID: 51203
	string MarqueeServerId { get; }

	// Token: 0x1700106C RID: 4204
	// (get) Token: 0x0600C804 RID: 51204
	string GachaInfoServerPrefixAddress { get; }

	// Token: 0x1700106D RID: 4205
	// (get) Token: 0x0600C805 RID: 51205
	string GachaInfoServerId { get; }
}
