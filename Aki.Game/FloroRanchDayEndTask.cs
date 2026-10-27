using System;

// Token: 0x02001B43 RID: 6979
public class FloroRanchDayEndTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF56 RID: 53078 RVA: 0x002F3E42 File Offset: 0x002F2042
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.DayEnd();
		base.Complete(null);
	}
}
