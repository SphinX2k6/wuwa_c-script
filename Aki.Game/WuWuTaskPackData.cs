using System;

// Token: 0x0200166F RID: 5743
public class WuWuTaskPackData
{
	// Token: 0x17000DA5 RID: 3493
	// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x0023C0C8 File Offset: 0x0023A2C8
	public bool IsUnlock
	{
		get
		{
			return (double)this.UnlockTime <= TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x040049C3 RID: 18883
	public int TaskPackId;

	// Token: 0x040049C4 RID: 18884
	public long UnlockTime;

	// Token: 0x040049C5 RID: 18885
	public bool HadReward;

	// Token: 0x040049C6 RID: 18886
	public int PrePackCfgId;
}
