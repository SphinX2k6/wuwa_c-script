using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200250D RID: 9485
public class PhoneMsgShortMsgData
{
	// Token: 0x0601313B RID: 78139 RVA: 0x004BA87C File Offset: 0x004B8A7C
	public PhoneMsgShortMsgData(int shortMsgId)
	{
		this.ShortMsgId = shortMsgId;
	}

	// Token: 0x04008FCD RID: 36813
	public readonly int ShortMsgId;

	// Token: 0x04008FCE RID: 36814
	public bool IsRead;

	// Token: 0x04008FCF RID: 36815
	public bool IsReceived;

	// Token: 0x04008FD0 RID: 36816
	public long UnLockTime;

	// Token: 0x04008FD1 RID: 36817
	public int LatestProgress;

	// Token: 0x04008FD2 RID: 36818
	[Nullable(1)]
	public Dictionary<int, int> SelectedOptionsDict = new Dictionary<int, int>();
}
