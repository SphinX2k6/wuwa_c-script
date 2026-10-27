using System;

// Token: 0x0200338A RID: 13194
public class FishingTechRoleRedDot : RedDotBase
{
	// Token: 0x0601CAC1 RID: 117441 RVA: 0x00806BA5 File Offset: 0x00804DA5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingTech);
	}
}
