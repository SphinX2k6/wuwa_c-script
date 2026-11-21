using System;

// Token: 0x020004D9 RID: 1241
public class GuessJokerRoundStartTipAction : GuessJokerActionBase
{
	// Token: 0x06003DBF RID: 15807 RVA: 0x0015D5CD File Offset: 0x0015B7CD
	public GuessJokerRoundStartTipAction(EGuessJokerPlayerType playerType)
	{
		this.PlayerType = playerType;
	}

	// Token: 0x06003DC0 RID: 15808 RVA: 0x0015D5DC File Offset: 0x0015B7DC
	protected override void OnStart()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance != null && instance.HasShownRoundStartTip(this.PlayerType))
		{
			this.Done = true;
			return;
		}
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		GuessJokerGamePlayModel.Instance.MarkRoundStartTipShown(this.PlayerType);
		gamePlayView.ShowPlayerRoundStartTip(this.PlayerType, delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x04003185 RID: 12677
	private readonly EGuessJokerPlayerType PlayerType;
}
