using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001034 RID: 4148
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerAiPlayCardTask : GuessJokerTaskBase
{
	// Token: 0x06006A83 RID: 27267 RVA: 0x001565EC File Offset: 0x001547EC
	public GuessJokerAiPlayCardTask(JokerGuessPlayCardAction data)
	{
		if (data.PlayCard != null)
		{
			foreach (int item in data.PlayCard.CardIds)
			{
				this.CardIdList.Add(item);
			}
		}
	}

	// Token: 0x06006A84 RID: 27268 RVA: 0x0015665C File Offset: 0x0015485C
	protected override void OnExecute()
	{
		int roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber;
		if (this.CardIdList.Count == 0)
		{
			if (roundNumber != 0 || GuessJokerGamePlayModel.Instance.ShowInitialNoPairTip)
			{
				GuessJokerController.Instance.OpenGuessJokerFloatTipsView("GuessJoker_Ai_NoPlayCard", null);
			}
			this.FinishWithShuffleCheck();
			return;
		}
		GuessJokerGamePlayView gameplayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("Ai出牌：{0}", string.Join<int>(",", this.CardIdList)), default(ReadOnlySpan<ValueTuple<string, object>>));
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		if (roundNumber == 0)
		{
			gameplayView.UpdateCurrentPlayer(EGuessJokerPlayerType.Ai);
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Ai));
		}
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance != null)
		{
			instance.UpdateCardBelongPlayerType(this.CardIdList.ToArray(), null);
		}
		bool flag = GuessJokerGamePlayModel.Instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai).Count == 0;
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			gameplayView.SetPositionPanelCardsDark(ECardPositionType.PlayerHand, true, null);
		}));
		list.Add(new GuessJokerShowCardsAction(this.CardIdList.ToArray(), true, 0f));
		list.Add(new GuessJokerCallbackAction(delegate()
		{
		}));
		list.Add(new GuessJokerGroupAction(new GuessJokerActionBase[]
		{
			new GuessJokerMoveCardsAction(this.CardIdList.ToArray(), ECardPositionType.Middle),
			new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Ai, ECardPositionType.AiHand)
		}));
		if (flag)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gameplayView.ShowWinLoseReasonTip(EGuessJokerPlayerType.Ai, "GuessJoker_PlayAllCardsTipText", true, delegate
				{
					complete();
					this.FinishTask();
				});
			}));
		}
		else
		{
			list.Add(new GuessJokerRemoveMiddleCardsAction(0f));
			list.Add(new GuessJokerCallbackAction(delegate()
			{
				gameplayView.SetPositionPanelCardsDark(ECardPositionType.PlayerHand, false, null);
			}));
			list.Add(new GuessJokerCallbackAction(delegate()
			{
				GuessJokerGamePlayModel.Instance.UpdateNpcIdleState();
				this.FinishWithShuffleCheck();
			}));
		}
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
	}

	// Token: 0x06006A85 RID: 27269 RVA: 0x0015684C File Offset: 0x00154A4C
	private void FinishWithShuffleCheck()
	{
		if (GuessJokerGamePlayModel.Instance.HasAiNewCardInHand())
		{
			GuessJokerGamePlayModel.Instance.PushActions(new GuessJokerActionBase[]
			{
				new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Ai, ECardPositionType.AiHand),
				new GuessJokerShuffleCardsAction(ECardPositionType.AiHand),
				new GuessJokerCallbackAction(delegate()
				{
					GuessJokerGamePlayModel.Instance.ClearAiDrawnCard();
					base.FinishTask();
				})
			});
			return;
		}
		GuessJokerGamePlayModel.Instance.ClearAiDrawnCard();
		base.FinishTask();
	}

	// Token: 0x04003115 RID: 12565
	public List<int> CardIdList = new List<int>();
}
