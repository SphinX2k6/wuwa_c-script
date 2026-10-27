using System;

// Token: 0x020033F3 RID: 13299
public class RedDotPhantomArenaMapUnlock : RedDotBase
{
	// Token: 0x0601CCA3 RID: 117923 RVA: 0x0080A6DA File Offset: 0x008088DA
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601CCA4 RID: 117924 RVA: 0x0080A6E6 File Offset: 0x008088E6
	protected override bool IsMultiple()
	{
		return true;
	}
}
