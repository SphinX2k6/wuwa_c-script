using System;

// Token: 0x02000BCE RID: 3022
public class BuffItemData
{
	// Token: 0x06007E3C RID: 32316 RVA: 0x0026EBFE File Offset: 0x0026CDFE
	public BuffItemData(int itemConfigId, double endCdTimeStamp, double totalCdTime)
	{
		this.ItemConfigIdInternal = itemConfigId;
		this.TotalCdTime = totalCdTime;
		this.SetEndCdTimeStamp(endCdTimeStamp);
	}

	// Token: 0x17000E27 RID: 3623
	// (get) Token: 0x06007E3D RID: 32317 RVA: 0x0026EC1B File Offset: 0x0026CE1B
	public int ItemConfigId
	{
		get
		{
			return this.ItemConfigIdInternal;
		}
	}

	// Token: 0x17000E28 RID: 3624
	// (get) Token: 0x06007E3E RID: 32318 RVA: 0x0026EC23 File Offset: 0x0026CE23
	public double EndCdTimeStamp
	{
		get
		{
			return this.EndCdTimeStampInternal;
		}
	}

	// Token: 0x06007E3F RID: 32319 RVA: 0x0026EC2B File Offset: 0x0026CE2B
	public void SetEndCdTimeStamp(double endCdTimeStamp)
	{
		this.EndCdTimeStampInternal = endCdTimeStamp / (double)TimeUtil.Instance.InverseMillisecond;
		this.StartCdTimeStampInternal = TimeUtil.Instance.GetServerTime();
		this.StartCdWorldTime = Time.Instance.WorldTimeSeconds;
	}

	// Token: 0x06007E40 RID: 32320 RVA: 0x0026EC60 File Offset: 0x0026CE60
	public void SetTotalCdTime(double totalCdTime)
	{
		this.TotalCdTime = totalCdTime;
	}

	// Token: 0x06007E41 RID: 32321 RVA: 0x0026EC69 File Offset: 0x0026CE69
	public double GetBuffItemRemainCdTime()
	{
		return Math.Max(this.EndCdTimeStampInternal - (Time.Instance.WorldTimeSeconds - this.StartCdWorldTime + this.StartCdTimeStampInternal), 0.0);
	}

	// Token: 0x06007E42 RID: 32322 RVA: 0x0026EC98 File Offset: 0x0026CE98
	public double GetBuffItemTotalCdTime()
	{
		return this.TotalCdTime;
	}

	// Token: 0x04004DF9 RID: 19961
	private readonly int ItemConfigIdInternal;

	// Token: 0x04004DFA RID: 19962
	private double EndCdTimeStampInternal;

	// Token: 0x04004DFB RID: 19963
	private double StartCdTimeStampInternal;

	// Token: 0x04004DFC RID: 19964
	private double StartCdWorldTime;

	// Token: 0x04004DFD RID: 19965
	private double TotalCdTime;
}
