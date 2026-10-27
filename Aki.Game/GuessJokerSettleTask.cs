using System;
using Aki.Protocol;

// Token: 0x0200103A RID: 4154
public class GuessJokerSettleTask : GuessJokerTaskBase
{
	// Token: 0x06006A9B RID: 27291 RVA: 0x00157417 File Offset: 0x00155617
	public GuessJokerSettleTask(JokerGuessActor winner)
	{
		GuessJokerGamePlayModel.Instance.SetWinner(winner);
	}

	// Token: 0x06006A9C RID: 27292 RVA: 0x0015742A File Offset: 0x0015562A
	protected override void OnExecute()
	{
		GuessJokerGamePlayModel.Instance.ChangeState(EGuessJokerCardStateType.SettleStage);
		base.FinishTask();
	}
}
