using System;

// Token: 0x0200102A RID: 4138
public class GuessJokerWaitAction : GuessJokerActionBase
{
	// Token: 0x06006A36 RID: 27190 RVA: 0x00155008 File Offset: 0x00153208
	public GuessJokerWaitAction(float waitTime)
	{
		this.Duration = waitTime;
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x00155017 File Offset: 0x00153217
	protected override void OnStart()
	{
	}
}
