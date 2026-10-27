using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ED2 RID: 11986
[NullableContext(1)]
[Nullable(0)]
public class TriggerConfigData : ITriggerConfig
{
	// Token: 0x17002368 RID: 9064
	// (get) Token: 0x060199AD RID: 104877 RVA: 0x006A4F13 File Offset: 0x006A3113
	// (set) Token: 0x060199AE RID: 104878 RVA: 0x006A4F1B File Offset: 0x006A311B
	public string Type { get; set; } = string.Empty;

	// Token: 0x17002369 RID: 9065
	// (get) Token: 0x060199AF RID: 104879 RVA: 0x006A4F24 File Offset: 0x006A3124
	// (set) Token: 0x060199B0 RID: 104880 RVA: 0x006A4F2C File Offset: 0x006A312C
	public string[] Preset { get; set; } = Array.Empty<string>();

	// Token: 0x1700236A RID: 9066
	// (get) Token: 0x060199B1 RID: 104881 RVA: 0x006A4F35 File Offset: 0x006A3135
	// (set) Token: 0x060199B2 RID: 104882 RVA: 0x006A4F3D File Offset: 0x006A313D
	public string Params { get; set; } = string.Empty;

	// Token: 0x1700236B RID: 9067
	// (get) Token: 0x060199B3 RID: 104883 RVA: 0x006A4F46 File Offset: 0x006A3146
	// (set) Token: 0x060199B4 RID: 104884 RVA: 0x006A4F4E File Offset: 0x006A314E
	public string Formula { get; set; } = string.Empty;

	// Token: 0x1700236C RID: 9068
	// (get) Token: 0x060199B5 RID: 104885 RVA: 0x006A4F57 File Offset: 0x006A3157
	// (set) Token: 0x060199B6 RID: 104886 RVA: 0x006A4F5F File Offset: 0x006A315F
	public EExecuteType ExecuteType { get; set; }
}
