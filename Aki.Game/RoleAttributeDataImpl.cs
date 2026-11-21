using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D3E RID: 7486
[NullableContext(1)]
[Nullable(0)]
public class RoleAttributeDataImpl : IRoleAttributeData
{
	// Token: 0x17001B8D RID: 7053
	// (get) Token: 0x060128F9 RID: 76025 RVA: 0x0057B870 File Offset: 0x00579A70
	// (set) Token: 0x060128FA RID: 76026 RVA: 0x0057B878 File Offset: 0x00579A78
	public string Name { get; set; }

	// Token: 0x17001B8E RID: 7054
	// (get) Token: 0x060128FB RID: 76027 RVA: 0x0057B881 File Offset: 0x00579A81
	// (set) Token: 0x060128FC RID: 76028 RVA: 0x0057B889 File Offset: 0x00579A89
	public int Level { get; set; }

	// Token: 0x17001B8F RID: 7055
	// (get) Token: 0x060128FD RID: 76029 RVA: 0x0057B892 File Offset: 0x00579A92
	// (set) Token: 0x060128FE RID: 76030 RVA: 0x0057B89A File Offset: 0x00579A9A
	public int BreakLevel { get; set; }

	// Token: 0x17001B90 RID: 7056
	// (get) Token: 0x060128FF RID: 76031 RVA: 0x0057B8A3 File Offset: 0x00579AA3
	// (set) Token: 0x06012900 RID: 76032 RVA: 0x0057B8AB File Offset: 0x00579AAB
	public int Exp { get; set; }
}
