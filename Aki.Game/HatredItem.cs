using System;

// Token: 0x020000E8 RID: 232
public class HatredItem
{
	// Token: 0x1700025C RID: 604
	// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00048FAA File Offset: 0x000471AA
	public bool InDecreasing
	{
		get
		{
			return this.NextDecreaseTime > 0.0;
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00048FBD File Offset: 0x000471BD
	public float HatredValueActual
	{
		get
		{
			return this.HatredValue + this.TauntValue;
		}
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00048FCC File Offset: 0x000471CC
	public void AfterTriggerHatredDecrease()
	{
		if (Time.Instance.WorldTime > this.DecreaseEndTime)
		{
			this.NextDecreaseTime = 0.0;
			return;
		}
		this.NextDecreaseTime += 1000.0;
	}

	// Token: 0x04000AC2 RID: 2754
	public float HatredValue;

	// Token: 0x04000AC3 RID: 2755
	public float TauntValue;

	// Token: 0x04000AC4 RID: 2756
	public double DisengageTime = -1.0;

	// Token: 0x04000AC5 RID: 2757
	public double DecreaseCdEndTime;

	// Token: 0x04000AC6 RID: 2758
	public double DecreaseEndTime;

	// Token: 0x04000AC7 RID: 2759
	public double NextDecreaseTime;

	// Token: 0x04000AC8 RID: 2760
	public double EarliestClearTime;

	// Token: 0x04000AC9 RID: 2761
	public bool InMaxArea;
}
