using System;

// Token: 0x020022E8 RID: 8936
public class BulletActionInfoDelayDestroyBullet : BulletActionInfoBase
{
	// Token: 0x0601609B RID: 90267 RVA: 0x006626E2 File Offset: 0x006608E2
	public BulletActionInfoDelayDestroyBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601609C RID: 90268 RVA: 0x006626EB File Offset: 0x006608EB
	public override void Clear()
	{
		this.DelayTime = 0f;
		this.SummonChild = false;
		this.IgnoreBulletActorTimeScale = false;
	}

	// Token: 0x0400B92E RID: 47406
	public float DelayTime;

	// Token: 0x0400B92F RID: 47407
	public bool SummonChild;

	// Token: 0x0400B930 RID: 47408
	public bool IgnoreBulletActorTimeScale;
}
