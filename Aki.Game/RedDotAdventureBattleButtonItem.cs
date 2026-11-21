using System;

// Token: 0x020028C4 RID: 10436
public class RedDotAdventureBattleButtonItem : RedDotBase
{
	// Token: 0x0601A6B9 RID: 108217 RVA: 0x0082B31E File Offset: 0x0082951E
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
