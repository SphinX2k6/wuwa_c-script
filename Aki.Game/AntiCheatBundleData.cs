using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BA0 RID: 2976
[NullableContext(1)]
[Nullable(0)]
public class AntiCheatBundleData : PlayerCommonLogData
{
	// Token: 0x17000E10 RID: 3600
	// (get) Token: 0x06007C0F RID: 31759 RVA: 0x00267772 File Offset: 0x00265972
	// (set) Token: 0x06007C10 RID: 31760 RVA: 0x0026777A File Offset: 0x0026597A
	public override string event_id { get; set; } = "8";

	// Token: 0x04004C67 RID: 19559
	public string s_bundle_id = "";

	// Token: 0x04004C68 RID: 19560
	public string s_version = "";
}
