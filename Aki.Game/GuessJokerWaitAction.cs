using System;

// Token: 0x020004DE RID: 1246
public class GuessJokerWaitAction : GuessJokerActionBase
{
	// Token: 0x06003DCB RID: 15819 RVA: 0x0015D930 File Offset: 0x0015BB30
	public GuessJokerWaitAction(float waitTime)
	{
		this.Duration = waitTime;
	}

	// Token: 0x06003DCC RID: 15820 RVA: 0x0015D93F File Offset: 0x0015BB3F
	protected override void OnStart()
	{
	}
}
