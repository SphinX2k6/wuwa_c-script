using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F07 RID: 3847
[NullableContext(1)]
[Nullable(0)]
public class FormationAttributeConfig : IFormationAttributeConfig
{
	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x060060B3 RID: 24755 RVA: 0x0012DB94 File Offset: 0x0012BD94
	// (set) Token: 0x060060B4 RID: 24756 RVA: 0x0012DB9C File Offset: 0x0012BD9C
	public FormationProperty? RawConfig { get; set; }

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x060060B5 RID: 24757 RVA: 0x0012DBA5 File Offset: 0x0012BDA5
	// (set) Token: 0x060060B6 RID: 24758 RVA: 0x0012DBAD File Offset: 0x0012BDAD
	public int?[] ForbidIncreaseTags { get; set; }

	// Token: 0x1700078C RID: 1932
	// (get) Token: 0x060060B7 RID: 24759 RVA: 0x0012DBB6 File Offset: 0x0012BDB6
	// (set) Token: 0x060060B8 RID: 24760 RVA: 0x0012DBBE File Offset: 0x0012BDBE
	public int?[] ForbidDecreaseTags { get; set; }
}
