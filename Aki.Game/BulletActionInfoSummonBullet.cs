using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D8B RID: 11659
[NullableContext(2)]
[Nullable(0)]
public class BulletActionInfoSummonBullet : BulletActionInfoBase
{
	// Token: 0x060187F3 RID: 100339 RVA: 0x0063C8D8 File Offset: 0x0063AAD8
	public BulletActionInfoSummonBullet(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060187F4 RID: 100340 RVA: 0x0063C8E8 File Offset: 0x0063AAE8
	public override void Clear()
	{
		this.ChildrenType = null;
		this.Victim = null;
		this.IsStayInCharacter = false;
		this.ParentImpactPoint = null;
		this.ParentLastPosition = null;
	}

	// Token: 0x0400B5A7 RID: 46503
	public EBulletChildrenType? ChildrenType;

	// Token: 0x0400B5A8 RID: 46504
	public Entity Victim;

	// Token: 0x0400B5A9 RID: 46505
	public bool IsStayInCharacter;

	// Token: 0x0400B5AA RID: 46506
	public Vector ParentImpactPoint;

	// Token: 0x0400B5AB RID: 46507
	public Vector ParentLastPosition;

	// Token: 0x0400B5AC RID: 46508
	public bool CreateOnAuthority = true;
}
