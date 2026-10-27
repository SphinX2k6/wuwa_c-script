using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034AF RID: 13487
[NullableContext(1)]
[Nullable(0)]
public class CombatScriptSet
{
	// Token: 0x0601D60B RID: 120331 RVA: 0x00831E19 File Offset: 0x00830019
	public virtual string OnFilterCmd()
	{
		return "CombatScriptHelper.GetCombatScriptBaseByName('" + base.GetType().Name + "').Introduction;";
	}

	// Token: 0x0400E767 RID: 59239
	public string Introduction = "";

	// Token: 0x0400E768 RID: 59240
	public List<CombatScriptUnit> CombatScriptUnits = new List<CombatScriptUnit>();
}
