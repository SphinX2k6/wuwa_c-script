using System;

// Token: 0x02001024 RID: 4132
public class GuessJokerRemoveMiddleCardsAction : GuessJokerActionBase
{
	// Token: 0x06006A28 RID: 27176 RVA: 0x00154C1F File Offset: 0x00152E1F
	public GuessJokerRemoveMiddleCardsAction(float duration = 0f)
	{
		if (duration != 0f)
		{
			this.Duration = duration;
			return;
		}
		this.Duration = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCardRemoveTime.ToString());
	}

	// Token: 0x06006A29 RID: 27177 RVA: 0x00154C54 File Offset: 0x00152E54
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
