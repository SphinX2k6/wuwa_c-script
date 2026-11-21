using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002364 RID: 9060
public class BulletChildInfo
{
	// Token: 0x06016554 RID: 91476 RVA: 0x00680324 File Offset: 0x0067E524
	public void SetIsNumberNotEnough(bool value)
	{
		this.IsNumberNotEnough = value;
	}

	// Token: 0x06016555 RID: 91477 RVA: 0x0068032D File Offset: 0x0067E52D
	public void SetIsActiveSummonChildBullet(bool value)
	{
		this.IsActiveSummonChildBullet = value;
	}

	// Token: 0x0400BCA4 RID: 48292
	public bool IsNumberNotEnough;

	// Token: 0x0400BCA5 RID: 48293
	public bool IsActiveSummonChildBullet;

	// Token: 0x0400BCA6 RID: 48294
	public bool HaveSpecialChildrenBullet;

	// Token: 0x0400BCA7 RID: 48295
	[Nullable(2)]
	public List<int> HaveSummonedBulletNumber;
}
