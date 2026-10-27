using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001046 RID: 4166
public class GuessJokerSettleStage : GuessJokerStageBase
{
	// Token: 0x06006AE0 RID: 27360 RVA: 0x0015824F File Offset: 0x0015644F
	[NullableContext(1)]
	public GuessJokerSettleStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006AE1 RID: 27361 RVA: 0x00158258 File Offset: 0x00156458
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
