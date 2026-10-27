using System;

// Token: 0x02001680 RID: 5760
public class RedDotActivityEntrance : RedDotBase
{
	// Token: 0x0600A2FF RID: 41727 RVA: 0x00240487 File Offset: 0x0023E687
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
