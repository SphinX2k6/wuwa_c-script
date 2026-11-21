using System;

// Token: 0x020004D8 RID: 1240
public class GuessJokerRemoveMiddleCardsAction : GuessJokerActionBase
{
	// Token: 0x06003DBD RID: 15805 RVA: 0x0015D547 File Offset: 0x0015B747
	public GuessJokerRemoveMiddleCardsAction(float duration = 0f)
	{
		if (duration != 0f)
		{
			this.Duration = duration;
			return;
		}
		this.Duration = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCardRemoveTime.ToString());
	}

	// Token: 0x06003DBE RID: 15806 RVA: 0x0015D57C File Offset: 0x0015B77C
	protected override void OnStart()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			this.Done = true;
			return;
		}
		gamePlayView.RemoveCardFromMiddleArea(delegate
		{
			if (GuessJokerGamePlayModel.Instance.CheckBlankCardDisable())
			{
				gamePlayView.SetBlankCardDisable();
			}
			this.Done = true;
		});
	}
}
