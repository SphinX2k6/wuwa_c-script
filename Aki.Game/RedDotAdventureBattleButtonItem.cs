using System;

// Token: 0x02003352 RID: 13138
public class RedDotAdventureBattleButtonItem : RedDotBase
{
	// Token: 0x0601C9C1 RID: 117185 RVA: 0x00804D5A File Offset: 0x00802F5A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
