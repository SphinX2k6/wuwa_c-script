using System;

// Token: 0x020000C8 RID: 200
public class TimeLimit
{
	// Token: 0x06000658 RID: 1624 RVA: 0x0002112F File Offset: 0x0001F32F
	public TimeLimit(long? microSecond = null)
	{
		if (microSecond != null)
		{
			this.TimeLimitMicroSecond = microSecond.Value;
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00021154 File Offset: 0x0001F354
	public void SetEnable(bool enabled)
	{
		this.Enabled = enabled;
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002115D File Offset: 0x0001F35D
	public double CurrentCost
	{
		get
		{
			return this.CurrentCostMicroSecond;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00021165 File Offset: 0x0001F365
	public void ResetCost()
	{
		this.CurrentCostMicroSecond = 0.0;
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002117F File Offset: 0x0001F37F
	// (set) Token: 0x0600065C RID: 1628 RVA: 0x00021176 File Offset: 0x0001F376
	public long Limit
	{
		get
		{
			return this.TimeLimitMicroSecond;
		}
		set
		{
			this.TimeLimitMicroSecond = value;
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00021187 File Offset: 0x0001F387
	public void AddCost(double newCostMicroSecond)
	{
		this.CurrentCostMicroSecond += newCostMicroSecond;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00021197 File Offset: 0x0001F397
	public bool IsTimeLimitExceeded()
	{
		return this.Enabled && this.TimeLimitMicroSecond > 0L && this.CurrentCostMicroSecond >= (double)this.TimeLimitMicroSecond;
	}

	// Token: 0x04000501 RID: 1281
	private double CurrentCostMicroSecond;

	// Token: 0x04000502 RID: 1282
	private long TimeLimitMicroSecond;

	// Token: 0x04000503 RID: 1283
	private bool Enabled = true;
}
