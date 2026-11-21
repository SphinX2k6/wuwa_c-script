using System;

// Token: 0x02001002 RID: 4098
public class FloroRanchDayEndTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A367 RID: 41831 RVA: 0x002FEF1A File Offset: 0x002FD11A
	protected override void OnExecute()
	{
		FloroRanchEntityActionSystem.DayEnd();
		base.Complete(null);
	}
}
