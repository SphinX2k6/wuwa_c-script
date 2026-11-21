using System;

// Token: 0x02002965 RID: 10597
public class RedDotPhantomArenaMapUnlock : RedDotBase
{
	// Token: 0x0601A99B RID: 108955 RVA: 0x00830C9E File Offset: 0x0082EE9E
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601A99C RID: 108956 RVA: 0x00830CAA File Offset: 0x0082EEAA
	protected override bool IsMultiple()
	{
		return true;
	}
}
