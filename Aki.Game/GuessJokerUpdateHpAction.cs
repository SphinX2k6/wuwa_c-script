using System;

// Token: 0x020004DD RID: 1245
public class GuessJokerUpdateHpAction : GuessJokerActionBase
{
	// Token: 0x06003DC8 RID: 15816 RVA: 0x0015D8CF File Offset: 0x0015BACF
	public GuessJokerUpdateHpAction(EGuessJokerPlayerType playerType, int hp)
	{
		this.PlayerType = playerType;
		this.Hp = hp;
	}

	// Token: 0x06003DC9 RID: 15817 RVA: 0x0015D8EC File Offset: 0x0015BAEC
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

	// Token: 0x0400318B RID: 12683
	public EGuessJokerPlayerType PlayerType = EGuessJokerPlayerType.Ai;

	// Token: 0x0400318C RID: 12684
	public int Hp;
}
