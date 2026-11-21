using System;

// Token: 0x020022E6 RID: 8934
public class BulletActionInfoDestroyBullet : BulletActionInfoBase
{
	// Token: 0x06016097 RID: 90263 RVA: 0x0066264A File Offset: 0x0066084A
	public BulletActionInfoDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016098 RID: 90264 RVA: 0x00662653 File Offset: 0x00660853
	public override void Clear()
	{
		this.SummonChild = false;
		this.DestroyEffectImmediately = false;
		this.DestroyReason = null;
	}

	// Token: 0x0400B922 RID: 47394
	public bool SummonChild;

	// Token: 0x0400B923 RID: 47395
	public bool DestroyEffectImmediately;

	// Token: 0x0400B924 RID: 47396
	public EBulletDestroyReason? DestroyReason;
}
