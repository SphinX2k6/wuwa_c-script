using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D59 RID: 7513
[NullableContext(1)]
[Nullable(0)]
public class RoleDevRootTabData : IRoleDevRootTabData
{
	// Token: 0x17001BB6 RID: 7094
	// (get) Token: 0x06012958 RID: 76120 RVA: 0x0057BE62 File Offset: 0x0057A062
	// (set) Token: 0x06012959 RID: 76121 RVA: 0x0057BE6A File Offset: 0x0057A06A
	public ERoleDevTabType TabIndex { get; set; }

	// Token: 0x17001BB7 RID: 7095
	// (get) Token: 0x0601295A RID: 76122 RVA: 0x0057BE73 File Offset: 0x0057A073
	// (set) Token: 0x0601295B RID: 76123 RVA: 0x0057BE7B File Offset: 0x0057A07B
	public string TabName { get; set; }

	// Token: 0x17001BB8 RID: 7096
	// (get) Token: 0x0601295C RID: 76124 RVA: 0x0057BE84 File Offset: 0x0057A084
	// (set) Token: 0x0601295D RID: 76125 RVA: 0x0057BE8C File Offset: 0x0057A08C
	public bool TabIsUpgrade { get; set; }

	// Token: 0x17001BB9 RID: 7097
	// (get) Token: 0x0601295E RID: 76126 RVA: 0x0057BE95 File Offset: 0x0057A095
	// (set) Token: 0x0601295F RID: 76127 RVA: 0x0057BE9D File Offset: 0x0057A09D
	public bool TabIsFinish { get; set; }
}
