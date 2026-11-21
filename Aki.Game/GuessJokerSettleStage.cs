using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020004FA RID: 1274
public class GuessJokerSettleStage : GuessJokerStageBase
{
	// Token: 0x06003E75 RID: 15989 RVA: 0x00160B77 File Offset: 0x0015ED77
	[NullableContext(1)]
	public GuessJokerSettleStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E76 RID: 15990 RVA: 0x00160B80 File Offset: 0x0015ED80
	protected override void OnEnter()
	{
		bool flag = GuessJokerGamePlayModel.Instance.GetWinner() == EGuessJokerPlayerType.Ai;
		EGuessJokerPlotTiming timing = flag ? EGuessJokerPlotTiming.Win : EGuessJokerPlotTiming.Lose;
		EUiViewName name = flag ? EUiViewName.GuessJokerSettleFailView : EUiViewName.GuessJokerSettleWinView;
		UiManager.Instance.OpenView(name, null, delegate(bool _, int _)
		{
			GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
			{
				new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, timing, null)
			});
		});
		GuessJokerGamePlayModel.Instance.SettleGameClear();
	}
}
