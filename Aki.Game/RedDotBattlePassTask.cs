using System;

// Token: 0x02003365 RID: 13157
public class RedDotBattlePassTask : RedDotBase
{
	// Token: 0x0601CA1B RID: 117275 RVA: 0x00805860 File Offset: 0x00803A60
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}
}
