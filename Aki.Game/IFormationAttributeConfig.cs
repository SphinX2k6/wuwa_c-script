using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020003BB RID: 955
[NullableContext(1)]
public interface IFormationAttributeConfig
{
	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x06003445 RID: 13381
	// (set) Token: 0x06003446 RID: 13382
	FormationProperty? RawConfig { get; set; }

	// Token: 0x170007AA RID: 1962
	// (get) Token: 0x06003447 RID: 13383
	// (set) Token: 0x06003448 RID: 13384
	int?[] ForbidIncreaseTags { get; set; }

	// Token: 0x170007AB RID: 1963
	// (get) Token: 0x06003449 RID: 13385
	// (set) Token: 0x0600344A RID: 13386
	int?[] ForbidDecreaseTags { get; set; }
}
