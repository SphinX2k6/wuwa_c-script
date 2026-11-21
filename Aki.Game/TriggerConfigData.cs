using System;
using System.Runtime.CompilerServices;

// Token: 0x02002425 RID: 9253
[NullableContext(1)]
[Nullable(0)]
public class TriggerConfigData : ITriggerConfig
{
	// Token: 0x17002418 RID: 9240
	// (get) Token: 0x060172A7 RID: 94887 RVA: 0x006CB0DF File Offset: 0x006C92DF
	// (set) Token: 0x060172A8 RID: 94888 RVA: 0x006CB0E7 File Offset: 0x006C92E7
	public string Type { get; set; } = string.Empty;

	// Token: 0x17002419 RID: 9241
	// (get) Token: 0x060172A9 RID: 94889 RVA: 0x006CB0F0 File Offset: 0x006C92F0
	// (set) Token: 0x060172AA RID: 94890 RVA: 0x006CB0F8 File Offset: 0x006C92F8
	public string[] Preset { get; set; } = Array.Empty<string>();

	// Token: 0x1700241A RID: 9242
	// (get) Token: 0x060172AB RID: 94891 RVA: 0x006CB101 File Offset: 0x006C9301
	// (set) Token: 0x060172AC RID: 94892 RVA: 0x006CB109 File Offset: 0x006C9309
	public string Params { get; set; } = string.Empty;

	// Token: 0x1700241B RID: 9243
	// (get) Token: 0x060172AD RID: 94893 RVA: 0x006CB112 File Offset: 0x006C9312
	// (set) Token: 0x060172AE RID: 94894 RVA: 0x006CB11A File Offset: 0x006C931A
	public string Formula { get; set; } = string.Empty;

	// Token: 0x1700241C RID: 9244
	// (get) Token: 0x060172AF RID: 94895 RVA: 0x006CB123 File Offset: 0x006C9323
	// (set) Token: 0x060172B0 RID: 94896 RVA: 0x006CB12B File Offset: 0x006C932B
	public EExecuteType ExecuteType { get; set; }
}
