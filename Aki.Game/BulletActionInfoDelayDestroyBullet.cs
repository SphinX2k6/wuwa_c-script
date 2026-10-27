using System;

// Token: 0x02002D8E RID: 11662
public class BulletActionInfoDelayDestroyBullet : BulletActionInfoBase
{
	// Token: 0x060187F9 RID: 100345 RVA: 0x0063C9AA File Offset: 0x0063ABAA
	public BulletActionInfoDelayDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187FA RID: 100346 RVA: 0x0063C9B3 File Offset: 0x0063ABB3
	public override void Clear()
	{
		this.DelayTime = 0f;
		this.SummonChild = false;
		this.IgnoreBulletActorTimeScale = false;
	}

	// Token: 0x0400B5B9 RID: 46521
	public float DelayTime;

	// Token: 0x0400B5BA RID: 46522
	public bool SummonChild;

	// Token: 0x0400B5BB RID: 46523
	public bool IgnoreBulletActorTimeScale;
}
