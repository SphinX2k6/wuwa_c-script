using System;
using System.Runtime.CompilerServices;

// Token: 0x020016E8 RID: 5864
[NullableContext(1)]
[Nullable(0)]
public class AntiCheatBundleData : PlayerCommonLogData
{
	// Token: 0x17000DEF RID: 3567
	// (get) Token: 0x0600A82F RID: 43055 RVA: 0x0025D352 File Offset: 0x0025B552
	// (set) Token: 0x0600A830 RID: 43056 RVA: 0x0025D35A File Offset: 0x0025B55A
	public override string event_id { get; set; } = "8";

	// Token: 0x04004BC0 RID: 19392
	public string s_bundle_id = "";

	// Token: 0x04004BC1 RID: 19393
	public string s_version = "";
}
