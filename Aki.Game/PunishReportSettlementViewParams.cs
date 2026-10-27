using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;

// Token: 0x02001D8C RID: 7564
[NullableContext(1)]
[Nullable(0)]
public class PunishReportSettlementViewParams
{
	// Token: 0x0600E55E RID: 58718 RVA: 0x0036056E File Offset: 0x0035E76E
	public PunishReportSettlementViewParams(int treeConfigId, List<EPunishReportTargetState> states)
	{
	}

	// Token: 0x04006A2C RID: 27180
	public int TreeConfigId = treeConfigId;

	// Token: 0x04006A2D RID: 27181
	public List<EPunishReportTargetState> States = states;
}
