using System;
using System.Runtime.CompilerServices;

// Token: 0x020019DB RID: 6619
[NullableContext(2)]
[Nullable(0)]
public class VisionSkinViewOpenParam : IVisionSkinViewOpenParam
{
	// Token: 0x170018FE RID: 6398
	// (get) Token: 0x06010523 RID: 66851 RVA: 0x004C3B78 File Offset: 0x004C1D78
	// (set) Token: 0x06010524 RID: 66852 RVA: 0x004C3B80 File Offset: 0x004C1D80
	public int? UniqueId { get; set; }

	// Token: 0x170018FF RID: 6399
	// (get) Token: 0x06010525 RID: 66853 RVA: 0x004C3B89 File Offset: 0x004C1D89
	// (set) Token: 0x06010526 RID: 66854 RVA: 0x004C3B91 File Offset: 0x004C1D91
	public int[] ShowItemIdList { get; set; }
}
