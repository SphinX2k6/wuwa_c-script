using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED1 RID: 3793
public class TowerDefenseFollowerProxy
{
	// Token: 0x06005E57 RID: 24151 RVA: 0x00116D0E File Offset: 0x00114F0E
	public TowerDefenseFollowerProxy(int? proxyId = null)
	{
		this.ProxyId = proxyId;
	}

	// Token: 0x04002AE2 RID: 10978
	public int? ProxyId;

	// Token: 0x04002AE3 RID: 10979
	[Nullable(2)]
	public int[] SkillIds;

	// Token: 0x04002AE4 RID: 10980
	public int? PropertyId;
}
