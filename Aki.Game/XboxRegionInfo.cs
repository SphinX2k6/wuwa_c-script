using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E29 RID: 3625
[NullableContext(1)]
[Nullable(0)]
public class XboxRegionInfo
{
	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x06005700 RID: 22272 RVA: 0x000FA291 File Offset: 0x000F8491
	// (set) Token: 0x06005701 RID: 22273 RVA: 0x000FA299 File Offset: 0x000F8499
	public int Code { get; set; }

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x06005702 RID: 22274 RVA: 0x000FA2A2 File Offset: 0x000F84A2
	// (set) Token: 0x06005703 RID: 22275 RVA: 0x000FA2AA File Offset: 0x000F84AA
	public int SdkLoginCode { get; set; }

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x06005704 RID: 22276 RVA: 0x000FA2B3 File Offset: 0x000F84B3
	// (set) Token: 0x06005705 RID: 22277 RVA: 0x000FA2BB File Offset: 0x000F84BB
	public string Region { get; set; } = "";
}
