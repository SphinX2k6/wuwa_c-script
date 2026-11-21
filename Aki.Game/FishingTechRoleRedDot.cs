using System;

// Token: 0x020028FC RID: 10492
public class FishingTechRoleRedDot : RedDotBase
{
	// Token: 0x0601A7B9 RID: 108473 RVA: 0x0082D169 File Offset: 0x0082B369
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingTech);
	}
}
