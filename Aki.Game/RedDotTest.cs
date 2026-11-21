using System;

// Token: 0x0200297A RID: 10618
public class RedDotTest : RedDotBase
{
	// Token: 0x0601AA03 RID: 109059 RVA: 0x00831929 File Offset: 0x0082FB29
	protected override void AddCheckEvent()
	{
	}

	// Token: 0x0601AA04 RID: 109060 RVA: 0x0083192B File Offset: 0x0082FB2B
	protected override void RemoveCheckEvent()
	{
	}

	// Token: 0x0601AA05 RID: 109061 RVA: 0x0083192D File Offset: 0x0082FB2D
	protected override bool OnCheck(int uId = 0)
	{
		return true;
	}
}
