using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F06 RID: 3846
[NullableContext(1)]
public interface IFormationAttributeConfig
{
	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x060060AD RID: 24749
	// (set) Token: 0x060060AE RID: 24750
	FormationProperty? RawConfig { get; set; }

	// Token: 0x17000788 RID: 1928
	// (get) Token: 0x060060AF RID: 24751
	// (set) Token: 0x060060B0 RID: 24752
	int?[] ForbidIncreaseTags { get; set; }

	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x060060B1 RID: 24753
	// (set) Token: 0x060060B2 RID: 24754
	int?[] ForbidDecreaseTags { get; set; }
}
