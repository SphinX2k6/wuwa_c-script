using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;

// Token: 0x0200124E RID: 4686
[NullableContext(1)]
[Nullable(0)]
public class PunishReportSettlementViewParams
{
	// Token: 0x0600B97C RID: 47484 RVA: 0x0036C1C2 File Offset: 0x0036A3C2
	public PunishReportSettlementViewParams(int treeConfigId, List<EPunishReportTargetState> states)
	{
	}

	// Token: 0x04006B0D RID: 27405
	public int TreeConfigId = treeConfigId;

	// Token: 0x04006B0E RID: 27406
	public List<EPunishReportTargetState> States = states;
}
