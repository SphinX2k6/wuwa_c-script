using System;

// Token: 0x02001029 RID: 4137
public class GuessJokerUpdateHpAction : GuessJokerActionBase
{
	// Token: 0x06006A33 RID: 27187 RVA: 0x00154FA7 File Offset: 0x001531A7
	public GuessJokerUpdateHpAction(EGuessJokerPlayerType playerType, int hp)
	{
		this.PlayerType = playerType;
		this.Hp = hp;
	}

	// Token: 0x06006A34 RID: 27188 RVA: 0x00154FC4 File Offset: 0x001531C4
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		gamePlayView.UpdateHp(this.PlayerType, delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x040030F2 RID: 12530
	public EGuessJokerPlayerType PlayerType = EGuessJokerPlayerType.Ai;

	// Token: 0x040030F3 RID: 12531
	public int Hp;
}
