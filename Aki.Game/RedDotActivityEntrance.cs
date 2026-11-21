using System;

// Token: 0x02000B38 RID: 2872
public class RedDotActivityEntrance : RedDotBase
{
	// Token: 0x060076DD RID: 30429 RVA: 0x0024A413 File Offset: 0x00248613
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}
}
