using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020003BC RID: 956
[NullableContext(1)]
[Nullable(0)]
public class FormationAttributeConfig : IFormationAttributeConfig
{
	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x0600344B RID: 13387 RVA: 0x00136498 File Offset: 0x00134698
	// (set) Token: 0x0600344C RID: 13388 RVA: 0x001364A0 File Offset: 0x001346A0
	public FormationProperty? RawConfig { get; set; }

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x0600344D RID: 13389 RVA: 0x001364A9 File Offset: 0x001346A9
	// (set) Token: 0x0600344E RID: 13390 RVA: 0x001364B1 File Offset: 0x001346B1
	public int?[] ForbidIncreaseTags { get; set; }

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x0600344F RID: 13391 RVA: 0x001364BA File Offset: 0x001346BA
	// (set) Token: 0x06003450 RID: 13392 RVA: 0x001364C2 File Offset: 0x001346C2
	public int?[] ForbidDecreaseTags { get; set; }
}
