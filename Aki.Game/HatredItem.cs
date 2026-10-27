using System;

// Token: 0x020000E8 RID: 232
public class HatredItem
{
	// Token: 0x17000259 RID: 601
	// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0004840E File Offset: 0x0004660E
	public bool InDecreasing
	{
		get
		{
			return this.NextDecreaseTime > 0.0;
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00048421 File Offset: 0x00046621
	public float HatredValueActual
	{
		get
		{
			return this.HatredValue + this.TauntValue;
		}
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00048430 File Offset: 0x00046630
	public void AfterTriggerHatredDecrease()
	{
		if (Time.Instance.WorldTime > this.DecreaseEndTime)
		{
			this.NextDecreaseTime = 0.0;
			return;
		}
		this.NextDecreaseTime += 1000.0;
	}

	// Token: 0x04000ABA RID: 2746
	public float HatredValue;

	// Token: 0x04000ABB RID: 2747
	public float TauntValue;

	// Token: 0x04000ABC RID: 2748
	public double DisengageTime = -1.0;

	// Token: 0x04000ABD RID: 2749
	public double DecreaseCdEndTime;

	// Token: 0x04000ABE RID: 2750
	public double DecreaseEndTime;

	// Token: 0x04000ABF RID: 2751
	public double NextDecreaseTime;

	// Token: 0x04000AC0 RID: 2752
	public double EarliestClearTime;

	// Token: 0x04000AC1 RID: 2753
	public bool InMaxArea;
}
