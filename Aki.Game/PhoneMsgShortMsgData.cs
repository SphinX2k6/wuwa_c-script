using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019F4 RID: 6644
public class PhoneMsgShortMsgData
{
	// Token: 0x060105FA RID: 67066 RVA: 0x004C85CC File Offset: 0x004C67CC
	public PhoneMsgShortMsgData(int shortMsgId)
	{
		this.ShortMsgId = shortMsgId;
	}

	// Token: 0x0400911A RID: 37146
	public readonly int ShortMsgId;

	// Token: 0x0400911B RID: 37147
	public bool IsRead;

	// Token: 0x0400911C RID: 37148
	public bool IsReceived;

	// Token: 0x0400911D RID: 37149
	public long UnLockTime;

	// Token: 0x0400911E RID: 37150
	public int LatestProgress;

	// Token: 0x0400911F RID: 37151
	[Nullable(1)]
	public Dictionary<int, int> SelectedOptionsDict = new Dictionary<int, int>();
}
