using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021C9 RID: 8649
[NullableContext(1)]
[Nullable(0)]
public class OrnamentModelContext : IOrnamentModelContext
{
	// Token: 0x17002032 RID: 8242
	// (get) Token: 0x060154A1 RID: 87201 RVA: 0x006313AF File Offset: 0x0062F5AF
	// (set) Token: 0x060154A2 RID: 87202 RVA: 0x006313B7 File Offset: 0x0062F5B7
	public int ModelId { get; set; }

	// Token: 0x17002033 RID: 8243
	// (get) Token: 0x060154A3 RID: 87203 RVA: 0x006313C0 File Offset: 0x0062F5C0
	// (set) Token: 0x060154A4 RID: 87204 RVA: 0x006313C8 File Offset: 0x0062F5C8
	public bool HideInUi { get; set; }

	// Token: 0x17002034 RID: 8244
	// (get) Token: 0x060154A5 RID: 87205 RVA: 0x006313D1 File Offset: 0x0062F5D1
	// (set) Token: 0x060154A6 RID: 87206 RVA: 0x006313D9 File Offset: 0x0062F5D9
	public List<long> OrnamentUiBuff { get; set; }

	// Token: 0x17002035 RID: 8245
	// (get) Token: 0x060154A7 RID: 87207 RVA: 0x006313E2 File Offset: 0x0062F5E2
	// (set) Token: 0x060154A8 RID: 87208 RVA: 0x006313EA File Offset: 0x0062F5EA
	public List<string> EquipTags { get; set; }
}
