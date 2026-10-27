using System;

// Token: 0x02002D8C RID: 11660
public class BulletActionInfoDestroyBullet : BulletActionInfoBase
{
	// Token: 0x060187F5 RID: 100341 RVA: 0x0063C912 File Offset: 0x0063AB12
	public BulletActionInfoDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187F6 RID: 100342 RVA: 0x0063C91B File Offset: 0x0063AB1B
	public override void Clear()
	{
		this.SummonChild = false;
		this.DestroyEffectImmediately = false;
		this.DestroyReason = null;
	}

	// Token: 0x0400B5AD RID: 46509
	public bool SummonChild;

	// Token: 0x0400B5AE RID: 46510
	public bool DestroyEffectImmediately;

	// Token: 0x0400B5AF RID: 46511
	public EBulletDestroyReason? DestroyReason;
}
