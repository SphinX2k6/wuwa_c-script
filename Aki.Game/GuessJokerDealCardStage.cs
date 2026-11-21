using System;
using System.Runtime.CompilerServices;

// Token: 0x020004F5 RID: 1269
public class GuessJokerDealCardStage : GuessJokerStageBase
{
	// Token: 0x06003E60 RID: 15968 RVA: 0x0016064C File Offset: 0x0015E84C
	[NullableContext(1)]
	public GuessJokerDealCardStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E61 RID: 15969 RVA: 0x00160658 File Offset: 0x0015E858
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
