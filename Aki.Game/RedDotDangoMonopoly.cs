using System;

// Token: 0x0200337F RID: 13183
public class RedDotDangoMonopoly : RedDotBase
{
	// Token: 0x0601CA92 RID: 117394 RVA: 0x008067B4 File Offset: 0x008049B4
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601CA93 RID: 117395 RVA: 0x008067CA File Offset: 0x008049CA
	protected override void AddCheckEvent()
	{
	}

	// Token: 0x0601CA94 RID: 117396 RVA: 0x008067CC File Offset: 0x008049CC
	protected override void RemoveCheckEvent()
	{
	}

	// Token: 0x0601CA95 RID: 117397 RVA: 0x008067CE File Offset: 0x008049CE
	protected override bool OnCheck(int uId = 0)
	{
		return false;
	}
}
