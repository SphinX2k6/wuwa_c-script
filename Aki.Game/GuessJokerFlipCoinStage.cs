using System;
using System.Runtime.CompilerServices;

// Token: 0x020004F6 RID: 1270
public class GuessJokerFlipCoinStage : GuessJokerStageBase
{
	// Token: 0x06003E62 RID: 15970 RVA: 0x00160698 File Offset: 0x0015E898
	[NullableContext(1)]
	public GuessJokerFlipCoinStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x001606A4 File Offset: 0x0015E8A4
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
