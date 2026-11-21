using System;
using Aki.Protocol;

// Token: 0x020004EE RID: 1262
public class GuessJokerSettleTask : GuessJokerTaskBase
{
	// Token: 0x06003E30 RID: 15920 RVA: 0x0015FD3F File Offset: 0x0015DF3F
	public GuessJokerSettleTask(JokerGuessActor winner)
	{
		GuessJokerGamePlayModel.Instance.SetWinner(winner);
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x0015FD52 File Offset: 0x0015DF52
	protected override void OnExecute()
	{
		GuessJokerGamePlayModel.Instance.ChangeState(EGuessJokerCardStateType.SettleStage);
		base.FinishTask();
	}
}
