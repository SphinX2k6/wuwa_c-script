using System;

// Token: 0x02001716 RID: 5910
public class BuffItemData
{
	// Token: 0x0600AA59 RID: 43609 RVA: 0x002646AE File Offset: 0x002628AE
	public BuffItemData(int itemConfigId, double endCdTimeStamp, double totalCdTime)
	{
		this.ItemConfigIdInternal = itemConfigId;
		this.TotalCdTime = totalCdTime;
		this.SetEndCdTimeStamp(endCdTimeStamp);
	}

	// Token: 0x17000E06 RID: 3590
	// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x002646CB File Offset: 0x002628CB
	public int ItemConfigId
	{
		get
		{
			return this.ItemConfigIdInternal;
		}
	}

	// Token: 0x17000E07 RID: 3591
	// (get) Token: 0x0600AA5B RID: 43611 RVA: 0x002646D3 File Offset: 0x002628D3
	public double EndCdTimeStamp
	{
		get
		{
			return this.EndCdTimeStampInternal;
		}
	}

	// Token: 0x0600AA5C RID: 43612 RVA: 0x002646DB File Offset: 0x002628DB
	public void SetEndCdTimeStamp(double endCdTimeStamp)
	{
		this.EndCdTimeStampInternal = endCdTimeStamp / (double)TimeUtil.Instance.InverseMillisecond;
		this.StartCdTimeStampInternal = TimeUtil.Instance.GetServerTime();
		this.StartCdWorldTime = Time.Instance.WorldTimeSeconds;
	}

	// Token: 0x0600AA5D RID: 43613 RVA: 0x00264710 File Offset: 0x00262910
	public void SetTotalCdTime(double totalCdTime)
	{
		this.TotalCdTime = totalCdTime;
	}

	// Token: 0x0600AA5E RID: 43614 RVA: 0x00264719 File Offset: 0x00262919
	public double GetBuffItemRemainCdTime()
	{
		return Math.Max(this.EndCdTimeStampInternal - (Time.Instance.WorldTimeSeconds - this.StartCdWorldTime + this.StartCdTimeStampInternal), 0.0);
	}

	// Token: 0x0600AA5F RID: 43615 RVA: 0x00264748 File Offset: 0x00262948
	public double GetBuffItemTotalCdTime()
	{
		return this.TotalCdTime;
	}

	// Token: 0x04004D51 RID: 19793
	private readonly int ItemConfigIdInternal;

	// Token: 0x04004D52 RID: 19794
	private double EndCdTimeStampInternal;

	// Token: 0x04004D53 RID: 19795
	private double StartCdTimeStampInternal;

	// Token: 0x04004D54 RID: 19796
	private double StartCdWorldTime;

	// Token: 0x04004D55 RID: 19797
	private double TotalCdTime;
}
