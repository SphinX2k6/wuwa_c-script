using System;

// Token: 0x0200291B RID: 10523
public class RedDotInfluenceReputation : RedDotBase
{
	// Token: 0x0601A844 RID: 108612 RVA: 0x0082E341 File Offset: 0x0082C541
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
