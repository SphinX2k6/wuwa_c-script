using System;

// Token: 0x02002A21 RID: 10785
public class CombatScriptHelper : CombatScriptHelperBase
{
	// Token: 0x0601B306 RID: 111366 RVA: 0x00859194 File Offset: 0x00857394
	public override void OnInit()
	{
		this.CombatScripts.Add(new AnimHelp());
	}
}
