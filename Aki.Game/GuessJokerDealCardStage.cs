using System;
using System.Runtime.CompilerServices;

// Token: 0x02001041 RID: 4161
public class GuessJokerDealCardStage : GuessJokerStageBase
{
	// Token: 0x06006ACB RID: 27339 RVA: 0x00157D24 File Offset: 0x00155F24
	[NullableContext(1)]
	public GuessJokerDealCardStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006ACC RID: 27340 RVA: 0x00157D30 File Offset: 0x00155F30
	protected override void OnEnter()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView != null)
		{
			gamePlayView.DealCards(delegate
			{
				GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
				if (instance != null && instance.IsExit)
				{
					return;
				}
				GuessJokerGamePlayModel.Instance.ChangeState(EGuessJokerCardStateType.FlipCoin);
			});
		}
	}
}
