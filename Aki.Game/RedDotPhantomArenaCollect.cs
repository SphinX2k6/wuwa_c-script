using System;

// Token: 0x020033EF RID: 13295
public class RedDotPhantomArenaCollect : RedDotBase
{
	// Token: 0x0601CC94 RID: 117908 RVA: 0x0080A5FD File Offset: 0x008087FD
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601CC95 RID: 117909 RVA: 0x0080A609 File Offset: 0x00808809
	protected override bool IsMultiple()
	{
		return true;
	}
}
