using System;

// Token: 0x020028D7 RID: 10455
public class RedDotBattlePassTask : RedDotBase
{
	// Token: 0x0601A713 RID: 108307 RVA: 0x0082BE24 File Offset: 0x0082A024
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}
}
