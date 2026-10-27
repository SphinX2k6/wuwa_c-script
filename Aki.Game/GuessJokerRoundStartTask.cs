using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001039 RID: 4153
public class GuessJokerRoundStartTask : GuessJokerTaskBase
{
	// Token: 0x06006A99 RID: 27289 RVA: 0x001572CC File Offset: 0x001554CC
	[NullableContext(1)]
	public GuessJokerRoundStartTask(JokerGuessRoundInfo data)
	{
		this.RoundNumber = data.RoundNum;
		this.BlankCardChangeId = data.ChangeResult;
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x001572EC File Offset: 0x001554EC
	protected override void OnExecute()
	{
		GuessJokerRoundStartTask.<>c__DisplayClass3_0 CS$<>8__locals1 = new GuessJokerRoundStartTask.<>c__DisplayClass3_0();
		CS$<>8__locals1.<>4__this = this;
		GuessJokerRoundStartTask.<>c__DisplayClass3_0 CS$<>8__locals2 = CS$<>8__locals1;
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		CS$<>8__locals2.gamePlayView = ((instance != null) ? instance.GetGamePlayView() : null);
		if (CS$<>8__locals1.gamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("回合开始：{0} 白板变化：{1}", this.RoundNumber, this.BlankCardChangeId), default(ReadOnlySpan<ValueTuple<string, object>>));
		CS$<>8__locals1.hasBlankCard = (GuessJokerGamePlayModel.Instance.GetBlankCardData() != null);
		GuessJokerGamePlayModel.Instance.NextRound();
		if (this.BlankCardChangeId > 0 & CS$<>8__locals1.hasBlankCard)
		{
			GuessJokerCardData blankCardData = GuessJokerGamePlayModel.Instance.GetBlankCardData();
			if (blankCardData != null)
			{
				blankCardData.ChangeBlankValue(this.BlankCardChangeId);
			}
		}
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		if (GuessJokerGamePlayModel.Instance.RoundNumber == 1)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				CS$<>8__locals1.gamePlayView.ShowInitialRoundTip(false, complete);
			}));
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				CS$<>8__locals1.gamePlayView.ShowOfficialRoundStartTip(delegate
				{
					complete();
					List<GuessJokerPlotAction> list2 = new List<GuessJokerPlotAction>();
					if (GuessJokerGamePlayModel.Instance.FirstPlayerTurn == EGuessJokerPlayerType.Ai)
					{
						list2.Add(new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.FirstPlay, null));
						list2.Add(new GuessJokerPlotAction(EGuessJokerPlayerType.Me, EGuessJokerPlotTiming.SecondPlay, null));
					}
					else
					{
						list2.Add(new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.SecondPlay, null));
						list2.Add(new GuessJokerPlotAction(EGuessJokerPlayerType.Me, EGuessJokerPlotTiming.FirstPlay, null));
					}
					GuessJokerGamePlayModel.Instance.PushPlotActions(list2.ToArray());
				});
			}));
		}
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			CS$<>8__locals1.gamePlayView.ClearAllCardsChecking();
			GuessJokerGamePlayModel.Instance.UpdateNpcIdleState();
			if (CS$<>8__locals1.hasBlankCard)
			{
				CS$<>8__locals1.gamePlayView.BlankCardAnimPlay();
				CS$<>8__locals1.gamePlayView.PlayGamePlayViewSequence("LevelChange", new Action(CS$<>8__locals1.<>4__this.FinishTask));
				return;
			}
			CS$<>8__locals1.gamePlayView.UpdateRoundNumber();
			CS$<>8__locals1.<>4__this.FinishTask();
		}));
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
	}

	// Token: 0x04003120 RID: 12576
	private readonly int RoundNumber;

	// Token: 0x04003121 RID: 12577
	private readonly int BlankCardChangeId;
}
