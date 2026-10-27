using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034E1 RID: 13537
[NullableContext(1)]
[Nullable(0)]
public class SkillButtonDebugInfo
{
	// Token: 0x0601DA57 RID: 121431 RVA: 0x0084C058 File Offset: 0x0084A258
	public SkillButtonDebugInfo(int entityHandleId, List<string> button)
	{
		this.EntityHandleId = entityHandleId;
		this.Button = button;
	}

	// Token: 0x0400E8A6 RID: 59558
	public int EntityHandleId;

	// Token: 0x0400E8A7 RID: 59559
	public List<string> Button;
}
