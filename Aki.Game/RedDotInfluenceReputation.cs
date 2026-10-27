using System;

// Token: 0x020033A9 RID: 13225
public class RedDotInfluenceReputation : RedDotBase
{
	// Token: 0x0601CB4C RID: 117580 RVA: 0x00807D7D File Offset: 0x00805F7D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
