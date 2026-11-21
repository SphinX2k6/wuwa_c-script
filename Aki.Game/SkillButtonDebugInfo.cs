using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A55 RID: 10837
[NullableContext(1)]
[Nullable(0)]
public class SkillButtonDebugInfo
{
	// Token: 0x0601B761 RID: 112481 RVA: 0x00874264 File Offset: 0x00872464
	public SkillButtonDebugInfo(int entityHandleId, List<string> button)
	{
		this.EntityHandleId = entityHandleId;
		this.Button = button;
	}

	// Token: 0x0400ED5D RID: 60765
	public int EntityHandleId;

	// Token: 0x0400ED5E RID: 60766
	public List<string> Button;
}
