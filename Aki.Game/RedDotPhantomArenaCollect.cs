using System;

// Token: 0x02002961 RID: 10593
public class RedDotPhantomArenaCollect : RedDotBase
{
	// Token: 0x0601A98C RID: 108940 RVA: 0x00830BC1 File Offset: 0x0082EDC1
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601A98D RID: 108941 RVA: 0x00830BCD File Offset: 0x0082EDCD
	protected override bool IsMultiple()
	{
		return true;
	}
}
