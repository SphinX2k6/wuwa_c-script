using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E08 RID: 11784
public class BulletChildInfo
{
	// Token: 0x06018C93 RID: 101523 RVA: 0x0065A150 File Offset: 0x00658350
	public void SetIsNumberNotEnough(bool value)
	{
		this.IsNumberNotEnough = value;
	}

	// Token: 0x06018C94 RID: 101524 RVA: 0x0065A159 File Offset: 0x00658359
	public void SetIsActiveSummonChildBullet(bool value)
	{
		this.IsActiveSummonChildBullet = value;
	}

	// Token: 0x0400B916 RID: 47382
	public bool IsNumberNotEnough;

	// Token: 0x0400B917 RID: 47383
	public bool IsActiveSummonChildBullet;

	// Token: 0x0400B918 RID: 47384
	public bool HaveSpecialChildrenBullet;

	// Token: 0x0400B919 RID: 47385
	[Nullable(2)]
	public List<int> HaveSummonedBulletNumber;
}
