using System;

// Token: 0x02000575 RID: 1397
public class ActivityLinkageTabData
{
	// Token: 0x06004347 RID: 17223 RVA: 0x0017483C File Offset: 0x00172A3C
	public bool IsInShowTimeChange()
	{
		bool flag = false;
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if ((double)this.StartTimeStamp <= serverTimeStamp && serverTimeStamp <= (double)this.EndTimeStamp)
		{
			flag = true;
		}
		bool result = flag != this.IsInShowTime;
		this.IsInShowTime = flag;
		return result;
	}

	// Token: 0x0400347A RID: 13434
	public int TabId;

	// Token: 0x0400347B RID: 13435
	public long StartTimeStamp;

	// Token: 0x0400347C RID: 13436
	public long EndTimeStamp;

	// Token: 0x0400347D RID: 13437
	public bool IsReceive;

	// Token: 0x0400347E RID: 13438
	public bool IsInShowTime;
}
