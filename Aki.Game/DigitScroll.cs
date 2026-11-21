using System;

// Token: 0x020011A2 RID: 4514
public class DigitScroll
{
	// Token: 0x0600B428 RID: 46120 RVA: 0x00353581 File Offset: 0x00351781
	public void Init(float current, float target, float duration)
	{
		this.Current = current;
		this.Target = target;
		this.Duration = duration;
	}

	// Token: 0x0600B429 RID: 46121 RVA: 0x00353598 File Offset: 0x00351798
	public float Tick(float delta)
	{
		if (this.Speed != 0f)
		{
			this.Current += this.Speed * delta;
			if (this.Current >= this.Target == this.Speed > 0f)
			{
				this.Current = this.Target;
				this.Speed = 0f;
			}
		}
		return this.Current;
	}

	// Token: 0x0600B42A RID: 46122 RVA: 0x00353604 File Offset: 0x00351804
	public float SetTarget(float target)
	{
		if (this.Target == target)
		{
			return 0f;
		}
		this.Target = target;
		float num = target - this.Current;
		this.Speed = num / this.Duration;
		return num;
	}

	// Token: 0x0600B42B RID: 46123 RVA: 0x0035363F File Offset: 0x0035183F
	public void Reset(float target)
	{
		this.Current = target;
		this.Target = target;
		this.Speed = 0f;
	}

	// Token: 0x0600B42C RID: 46124 RVA: 0x0035365A File Offset: 0x0035185A
	public bool IsFinished()
	{
		return this.Speed == 0f;
	}

	// Token: 0x040067FC RID: 26620
	public float Current;

	// Token: 0x040067FD RID: 26621
	public float Target;

	// Token: 0x040067FE RID: 26622
	public float Speed;

	// Token: 0x040067FF RID: 26623
	public float Duration = 1000f;
}
