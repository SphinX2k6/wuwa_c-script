using System;

// Token: 0x020010C1 RID: 4289
public class ActivityLinkageTabData
{
	// Token: 0x06006FB1 RID: 28593 RVA: 0x0016BE80 File Offset: 0x0016A080
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

	// Token: 0x040033E1 RID: 13281
	public int TabId;

	// Token: 0x040033E2 RID: 13282
	public long StartTimeStamp;

	// Token: 0x040033E3 RID: 13283
	public long EndTimeStamp;

	// Token: 0x040033E4 RID: 13284
	public bool IsReceive;

	// Token: 0x040033E5 RID: 13285
	public bool IsInShowTime;
}
