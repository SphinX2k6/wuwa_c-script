using System;
using System.Runtime.CompilerServices;

// Token: 0x020022E5 RID: 8933
[NullableContext(2)]
[Nullable(0)]
public class BulletActionInfoSummonBullet : BulletActionInfoBase
{
	// Token: 0x06016095 RID: 90261 RVA: 0x00662610 File Offset: 0x00660810
	public BulletActionInfoSummonBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016096 RID: 90262 RVA: 0x00662620 File Offset: 0x00660820
	public override void Clear()
	{
		this.ChildrenType = null;
		this.Victim = null;
		this.IsStayInCharacter = false;
		this.ParentImpactPoint = null;
		this.ParentLastPosition = null;
	}

	// Token: 0x0400B91C RID: 47388
	public EBulletChildrenType? ChildrenType;

	// Token: 0x0400B91D RID: 47389
	public Entity Victim;

	// Token: 0x0400B91E RID: 47390
	public bool IsStayInCharacter;

	// Token: 0x0400B91F RID: 47391
	public Vector ParentImpactPoint;

	// Token: 0x0400B920 RID: 47392
	public Vector ParentLastPosition;

	// Token: 0x0400B921 RID: 47393
	public bool CreateOnAuthority = true;
}
