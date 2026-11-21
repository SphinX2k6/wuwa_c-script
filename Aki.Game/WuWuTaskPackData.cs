using System;

// Token: 0x02000B27 RID: 2855
public class WuWuTaskPackData
{
	// Token: 0x17000DC6 RID: 3526
	// (get) Token: 0x060075C3 RID: 30147 RVA: 0x00245F64 File Offset: 0x00244164
	public bool IsUnlock
	{
		get
		{
			return (double)this.UnlockTime <= TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x04004A69 RID: 19049
	public int TaskPackId;

	// Token: 0x04004A6A RID: 19050
	public long UnlockTime;

	// Token: 0x04004A6B RID: 19051
	public bool HadReward;

	// Token: 0x04004A6C RID: 19052
	public int PrePackCfgId;
}
