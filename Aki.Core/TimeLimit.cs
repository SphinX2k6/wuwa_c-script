using System;

// Token: 0x020000C6 RID: 198
public class TimeLimit
{
	// Token: 0x06000617 RID: 1559 RVA: 0x00020C03 File Offset: 0x0001EE03
	public TimeLimit(long? microSecond = null)
	{
		if (microSecond != null)
		{
			this.TimeLimitMicroSecond = microSecond.Value;
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00020C28 File Offset: 0x0001EE28
	public void SetEnable(bool enabled)
	{
		this.Enabled = enabled;
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000619 RID: 1561 RVA: 0x00020C31 File Offset: 0x0001EE31
	public double CurrentCost
	{
		get
		{
			return this.CurrentCostMicroSecond;
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00020C39 File Offset: 0x0001EE39
	public void ResetCost()
	{
		this.CurrentCostMicroSecond = 0.0;
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x00020C53 File Offset: 0x0001EE53
	// (set) Token: 0x0600061B RID: 1563 RVA: 0x00020C4A File Offset: 0x0001EE4A
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

	// Token: 0x0600061D RID: 1565 RVA: 0x00020C5B File Offset: 0x0001EE5B
	public void AddCost(double newCostMicroSecond)
	{
		this.CurrentCostMicroSecond += newCostMicroSecond;
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00020C6B File Offset: 0x0001EE6B
	public bool IsTimeLimitExceeded()
	{
		return this.Enabled && this.TimeLimitMicroSecond > 0L && this.CurrentCostMicroSecond >= (double)this.TimeLimitMicroSecond;
	}

	// Token: 0x040004F3 RID: 1267
	private double CurrentCostMicroSecond;

	// Token: 0x040004F4 RID: 1268
	private long TimeLimitMicroSecond;

	// Token: 0x040004F5 RID: 1269
	private bool Enabled = true;
}
