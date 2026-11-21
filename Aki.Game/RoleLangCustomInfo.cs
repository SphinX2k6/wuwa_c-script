using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD4 RID: 7636
[NullableContext(1)]
[Nullable(0)]
public class RoleLangCustomInfo : IRoleLangCustomInfo
{
	// Token: 0x17001CC1 RID: 7361
	// (get) Token: 0x06012E82 RID: 77442 RVA: 0x0058AD22 File Offset: 0x00588F22
	// (set) Token: 0x06012E83 RID: 77443 RVA: 0x0058AD2A File Offset: 0x00588F2A
	public int RoleId { get; set; }

	// Token: 0x17001CC2 RID: 7362
	// (get) Token: 0x06012E84 RID: 77444 RVA: 0x0058AD33 File Offset: 0x00588F33
	// (set) Token: 0x06012E85 RID: 77445 RVA: 0x0058AD3B File Offset: 0x00588F3B
	public int LangIndex { get; set; }

	// Token: 0x17001CC3 RID: 7363
	// (get) Token: 0x06012E86 RID: 77446 RVA: 0x0058AD44 File Offset: 0x00588F44
	// (set) Token: 0x06012E87 RID: 77447 RVA: 0x0058AD4C File Offset: 0x00588F4C
	public string LangCode { get; set; }
}
