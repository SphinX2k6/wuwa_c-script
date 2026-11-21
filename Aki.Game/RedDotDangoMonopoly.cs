using System;

// Token: 0x020028F1 RID: 10481
public class RedDotDangoMonopoly : RedDotBase
{
	// Token: 0x0601A78A RID: 108426 RVA: 0x0082CD78 File Offset: 0x0082AF78
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601A78B RID: 108427 RVA: 0x0082CD8E File Offset: 0x0082AF8E
	protected override void AddCheckEvent()
	{
	}

	// Token: 0x0601A78C RID: 108428 RVA: 0x0082CD90 File Offset: 0x0082AF90
	protected override void RemoveCheckEvent()
	{
	}

	// Token: 0x0601A78D RID: 108429 RVA: 0x0082CD92 File Offset: 0x0082AF92
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}
