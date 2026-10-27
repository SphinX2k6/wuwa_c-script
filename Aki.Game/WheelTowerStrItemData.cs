using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015F2 RID: 5618
[NullableContext(1)]
[Nullable(0)]
internal class WheelTowerStrItemData
{
	// Token: 0x17000D83 RID: 3459
	// (get) Token: 0x06009E93 RID: 40595 RVA: 0x0022A1A4 File Offset: 0x002283A4
	// (set) Token: 0x06009E94 RID: 40596 RVA: 0x0022A1AC File Offset: 0x002283AC
	public string RoleName { get; set; } = string.Empty;

	// Token: 0x17000D84 RID: 3460
	// (get) Token: 0x06009E95 RID: 40597 RVA: 0x0022A1B5 File Offset: 0x002283B5
	// (set) Token: 0x06009E96 RID: 40598 RVA: 0x0022A1BD File Offset: 0x002283BD
	public List<string> DescList { get; set; } = new List<string>();
}
