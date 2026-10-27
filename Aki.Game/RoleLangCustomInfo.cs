using System;
using System.Runtime.CompilerServices;

// Token: 0x02002859 RID: 10329
[NullableContext(1)]
[Nullable(0)]
public class RoleLangCustomInfo : IRoleLangCustomInfo
{
	// Token: 0x17001C69 RID: 7273
	// (get) Token: 0x06015484 RID: 87172 RVA: 0x0055FFC6 File Offset: 0x0055E1C6
	// (set) Token: 0x06015485 RID: 87173 RVA: 0x0055FFCE File Offset: 0x0055E1CE
	public int RoleId { get; set; }

	// Token: 0x17001C6A RID: 7274
	// (get) Token: 0x06015486 RID: 87174 RVA: 0x0055FFD7 File Offset: 0x0055E1D7
	// (set) Token: 0x06015487 RID: 87175 RVA: 0x0055FFDF File Offset: 0x0055E1DF
	public int LangIndex { get; set; }

	// Token: 0x17001C6B RID: 7275
	// (get) Token: 0x06015488 RID: 87176 RVA: 0x0055FFE8 File Offset: 0x0055E1E8
	// (set) Token: 0x06015489 RID: 87177 RVA: 0x0055FFF0 File Offset: 0x0055E1F0
	public string LangCode { get; set; }
}
