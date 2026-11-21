using System;
using System.Runtime.CompilerServices;

// Token: 0x02000386 RID: 902
public class TowerDefenseFollowerProxy
{
	// Token: 0x060031EE RID: 12782 RVA: 0x0011E9EA File Offset: 0x0011CBEA
	public TowerDefenseFollowerProxy(int? proxyId = null)
	{
		this.ProxyId = proxyId;
	}

	// Token: 0x04002B7D RID: 11133
	public int? ProxyId;

	// Token: 0x04002B7E RID: 11134
	[Nullable(2)]
	public int[] SkillIds;

	// Token: 0x04002B7F RID: 11135
	public int? PropertyId;
}
