using System;

// Token: 0x02001CE0 RID: 7392
public class DigitScroll
{
	// Token: 0x0600E00B RID: 57355 RVA: 0x00347B59 File Offset: 0x00345D59
	public void Init(float current, float target, float duration)
	{
		this.Current = current;
		this.Target = target;
		this.Duration = duration;
	}

	// Token: 0x0600E00C RID: 57356 RVA: 0x00347B70 File Offset: 0x00345D70
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

	// Token: 0x0600E00D RID: 57357 RVA: 0x00347BDC File Offset: 0x00345DDC
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

	// Token: 0x0600E00E RID: 57358 RVA: 0x00347C17 File Offset: 0x00345E17
	public void Reset(float target)
	{
		this.Current = target;
		this.Target = target;
		this.Speed = 0f;
	}

	// Token: 0x0600E00F RID: 57359 RVA: 0x00347C32 File Offset: 0x00345E32
	public bool IsFinished()
	{
		return this.Speed == 0f;
	}

	// Token: 0x0400671D RID: 26397
	public float Current;

	// Token: 0x0400671E RID: 26398
	public float Target;

	// Token: 0x0400671F RID: 26399
	public float Speed;

	// Token: 0x04006720 RID: 26400
	public float Duration = 1000f;
}
