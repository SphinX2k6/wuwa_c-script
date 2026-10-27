using System;

// Token: 0x02001025 RID: 4133
public class GuessJokerRoundStartTipAction : GuessJokerActionBase
{
	// Token: 0x06006A2A RID: 27178 RVA: 0x00154CA5 File Offset: 0x00152EA5
	public GuessJokerRoundStartTipAction(EGuessJokerPlayerType playerType)
	{
		this.PlayerType = playerType;
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x00154CB4 File Offset: 0x00152EB4
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

	// Token: 0x040030EC RID: 12524
	private readonly EGuessJokerPlayerType PlayerType;
}
