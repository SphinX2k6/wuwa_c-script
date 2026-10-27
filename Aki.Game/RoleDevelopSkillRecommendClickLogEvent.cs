using System;
using System.Runtime.CompilerServices;

// Token: 0x0200212A RID: 8490
[NullableContext(1)]
[Nullable(0)]
public class RoleDevelopSkillRecommendClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014D0 RID: 5328
	// (get) Token: 0x060109BA RID: 68026 RVA: 0x0040B9C8 File Offset: 0x00409BC8
	// (set) Token: 0x060109BB RID: 68027 RVA: 0x0040B9D0 File Offset: 0x00409BD0
	public override string event_id { get; set; } = "1919";

	// Token: 0x04007D24 RID: 32036
	public int i_role_id;

	// Token: 0x04007D25 RID: 32037
	public int i_operation;
}
