using System;
using System.Runtime.CompilerServices;

// Token: 0x02001042 RID: 4162
public class GuessJokerFlipCoinStage : GuessJokerStageBase
{
	// Token: 0x06006ACD RID: 27341 RVA: 0x00157D70 File Offset: 0x00155F70
	[NullableContext(1)]
	public GuessJokerFlipCoinStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006ACE RID: 27342 RVA: 0x00157D7C File Offset: 0x00155F7C
	protected override void OnEnter()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView != null)
		{
			gamePlayView.ShowFlipCoinEffect(true, delegate
			{
				gamePlayView.SetFlipCoinClickEnable();
			});
		}
	}
}
