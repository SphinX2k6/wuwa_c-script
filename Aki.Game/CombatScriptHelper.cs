using System;

// Token: 0x020034AD RID: 13485
public class CombatScriptHelper : CombatScriptHelperBase
{
	// Token: 0x0601D607 RID: 120327 RVA: 0x00831D74 File Offset: 0x0082FF74
	public override void OnInit()
	{
		this.CombatScripts.Add(new AnimHelp());
	}
}
