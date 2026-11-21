using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020006E3 RID: 1763
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyTaskTabData : IDangoMonopolyTaskTabData
{
	// Token: 0x17000ABC RID: 2748
	// (get) Token: 0x0600516D RID: 20845 RVA: 0x001B3A02 File Offset: 0x001B1C02
	// (set) Token: 0x0600516E RID: 20846 RVA: 0x001B3A0A File Offset: 0x001B1C0A
	public EDangoMonopolyTaskType TaskType { get; set; }

	// Token: 0x17000ABD RID: 2749
	// (get) Token: 0x0600516F RID: 20847 RVA: 0x001B3A13 File Offset: 0x001B1C13
	// (set) Token: 0x06005170 RID: 20848 RVA: 0x001B3A1B File Offset: 0x001B1C1B
	public string TaskTypeName { get; set; } = "";

	// Token: 0x17000ABE RID: 2750
	// (get) Token: 0x06005171 RID: 20849 RVA: 0x001B3A24 File Offset: 0x001B1C24
	// (set) Token: 0x06005172 RID: 20850 RVA: 0x001B3A2C File Offset: 0x001B1C2C
	public IReadOnlyList<DangoMonopolyTaskData> TaskList { get; set; } = Array.Empty<DangoMonopolyTaskData>();

	// Token: 0x17000ABF RID: 2751
	// (get) Token: 0x06005173 RID: 20851 RVA: 0x001B3A35 File Offset: 0x001B1C35
	// (set) Token: 0x06005174 RID: 20852 RVA: 0x001B3A3D File Offset: 0x001B1C3D
	public long EndTime { get; set; }
}
