using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C70 RID: 11376
[NullableContext(1)]
[Nullable(0)]
public class OrnamentModelContext : IOrnamentModelContext
{
	// Token: 0x17001FE1 RID: 8161
	// (get) Token: 0x06017C2F RID: 97327 RVA: 0x0060B907 File Offset: 0x00609B07
	// (set) Token: 0x06017C30 RID: 97328 RVA: 0x0060B90F File Offset: 0x00609B0F
	public int ModelId { get; set; }

	// Token: 0x17001FE2 RID: 8162
	// (get) Token: 0x06017C31 RID: 97329 RVA: 0x0060B918 File Offset: 0x00609B18
	// (set) Token: 0x06017C32 RID: 97330 RVA: 0x0060B920 File Offset: 0x00609B20
	public bool HideInUi { get; set; }

	// Token: 0x17001FE3 RID: 8163
	// (get) Token: 0x06017C33 RID: 97331 RVA: 0x0060B929 File Offset: 0x00609B29
	// (set) Token: 0x06017C34 RID: 97332 RVA: 0x0060B931 File Offset: 0x00609B31
	public List<long> OrnamentUiBuff { get; set; }

	// Token: 0x17001FE4 RID: 8164
	// (get) Token: 0x06017C35 RID: 97333 RVA: 0x0060B93A File Offset: 0x00609B3A
	// (set) Token: 0x06017C36 RID: 97334 RVA: 0x0060B942 File Offset: 0x00609B42
	public List<string> EquipTags { get; set; }
}
