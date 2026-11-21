using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A23 RID: 10787
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptSet
{
	// Token: 0x0601B30A RID: 111370 RVA: 0x00859239 File Offset: 0x00857439
	public virtual string OnFilterCmd()
	{
		return "CombatScriptHelper.GetCombatScriptBaseByName('" + base.GetType().Name + "').Introduction;";
	}

	// Token: 0x0400EC1B RID: 60443
	public string Introduction = "";

	// Token: 0x0400EC1C RID: 60444
	public List<CombatScriptUnit> CombatScriptUnits = new List<CombatScriptUnit>();
}
