using System;
using System.Runtime.CompilerServices;

// Token: 0x02001602 RID: 5634
[NullableContext(1)]
[Nullable(0)]
public class RoleDevelopSkillRecommendClickLogEvent : PlayerCommonLogData
{
	// Token: 0x170014FE RID: 5374
	// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x00418110 File Offset: 0x00416310
	// (set) Token: 0x0600DE2E RID: 56878 RVA: 0x00418118 File Offset: 0x00416318
	public override string event_id { get; set; } = "1919";

	// Token: 0x04007E34 RID: 32308
	public int i_role_id;

	// Token: 0x04007E35 RID: 32309
	public int i_operation;
}
