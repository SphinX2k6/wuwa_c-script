using System;

// Token: 0x0200293C RID: 10556
public class RedDotMoraleBuff : RedDotBase
{
	// Token: 0x0601A8D8 RID: 108760 RVA: 0x0082F536 File Offset: 0x0082D736
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}
}
