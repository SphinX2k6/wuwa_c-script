using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001037 RID: 4151
public class GuessJokerPlayerPlayCardTask : GuessJokerTaskBase
{
	// Token: 0x06006A90 RID: 27280 RVA: 0x00156E25 File Offset: 0x00155025
	public GuessJokerPlayerPlayCardTask()
	{
		this.TaskType = EGuessJokerTaskType.Interactive;
	}

	// Token: 0x06006A91 RID: 27281 RVA: 0x00156E34 File Offset: 0x00155034
	protected override void OnExecute()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(true);
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "【task】玩家出牌", default(ReadOnlySpan<ValueTuple<string, object>>));
		List<IPlayCardInfo> playerPlayCardIdList = GuessJokerGamePlayModel.Instance.GetPlayerPlayCardIdList();
		List<int> playCardList = new List<int>();
		int normalCardPairCount = 0;
		for (int i = 0; i < playerPlayCardIdList.Count; i++)
		{
			IPlayCardInfo playCardInfo = playerPlayCardIdList[i];
			for (int j = 0; j < playCardInfo.CardIdList.Length; j++)
			{
				playCardList.Add(playCardInfo.CardIdList[j]);
			}
			int normalCardPairCount2 = normalCardPairCount;
			normalCardPairCount = normalCardPairCount2 + 1;
		}
		if (normalCardPairCount == 0)
		{
			if (GuessJokerGamePlayModel.Instance.RoundNumber != 0 || GuessJokerGamePlayModel.Instance.ShowInitialNoPairTip)
			{
				GuessJokerController.Instance.OpenGuessJokerFloatTipsView("GuessJoker_Player_NoPlayCard", null);
			}
			GuessJokerGamePlayModel.Instance.PushActions(new <>z__ReadOnlyArray<GuessJokerActionBase>(new GuessJokerActionBase[]
			{
				new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerHand),
				new GuessJokerCallbackAction(delegate()
				{
					this.SetRequestFinished(true);
					GuessJokerController.Instance.RequestJokerGuessPlayCard(Array.Empty<int>(), new Action(this.FinishWithShuffleCheck));
				})
			}));
			return;
		}
		Action<Action> <>9__5;
		Action <>9__6;
		gamePlayView.SetPlayerPlayCardInteractiveCallback(delegate(int[] selectedPlayCardList)
		{
			if (!this.CanSendRequest())
			{
				Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "出牌请求进行中，忽略重复点击", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SetRequestFinished(true);
			GuessJokerController.Instance.RequestJokerGuessPlayCard(selectedPlayCardList, delegate
			{
				if (selectedPlayCardList.Length == 0)
				{
					GuessJokerController.Instance.OpenGuessJokerFloatTipsView("GuessJoker_Player_GiveUpPlayCard", null);
				}
				GuessJokerGamePlayModel.Instance.UpdateCardBelongPlayerType(selectedPlayCardList.ToArray<int>(), null);
				bool flag = GuessJokerGamePlayModel.Instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Me).Count == 0;
				List<GuessJokerActionBase> list2 = new List<GuessJokerActionBase>();
				list2.Add(new GuessJokerGroupAction(new GuessJokerActionBase[]
				{
					new GuessJokerMoveCardsAction(selectedPlayCardList, ECardPositionType.Middle),
					new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerHand)
				}));
				if (flag)
				{
					List<GuessJokerActionBase> list3 = list2;
					Action<Action> callback;
					if ((callback = <>9__5) == null)
					{
						callback = (<>9__5 = delegate(Action complete)
						{
							gamePlayView.ShowWinLoseReasonTip(EGuessJokerPlayerType.Me, "GuessJoker_PlayAllCardsTipText", true, delegate
							{
								complete();
								this.FinishTask();
							});
						});
					}
					list3.Add(new GuessJokerCallbackWithCompleteAction(callback));
				}
				else
				{
					list2.Add(new GuessJokerRemoveMiddleCardsAction(0f));
					List<GuessJokerActionBase> list4 = list2;
					Action callback2;
					if ((callback2 = <>9__6) == null)
					{
						callback2 = (<>9__6 = delegate()
						{
							gamePlayView.SetPositionPanelCardsDark(ECardPositionType.PlayerHand, false, null);
							GuessJokerGamePlayModel.Instance.UpdateNpcIdleState();
							gamePlayView.SetPlayerCardClickCallback(null);
							this.FinishWithShuffleCheck();
						});
					}
					list4.Add(new GuessJokerCallbackAction(callback2));
				}
				GuessJokerGamePlayModel.Instance.PushActions(list2.ToArray());
			});
		});
		bool roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber != 0;
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		if (!roundNumber)
		{
			gamePlayView.UpdateCurrentPlayer(EGuessJokerPlayerType.Me);
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Me));
		}
		list.Add(new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerPlay));
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			gamePlayView.SetPositionPanelCardsDark(ECardPositionType.PlayerPlay, true, playCardList.ToArray());
		}));
		list.Add(new GuessJokerUpCardsAction(playCardList.ToArray(), true));
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			gamePlayView.ShowPlayerButtons(normalCardPairCount);
		}));
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
	}

	// Token: 0x06006A92 RID: 27282 RVA: 0x0015701C File Offset: 0x0015521C
	private void FinishWithShuffleCheck()
	{
		if (GuessJokerGamePlayModel.Instance.HasPlayerNewCardInHand())
		{
			GuessJokerGamePlayModel.Instance.PushActions(new GuessJokerActionBase[]
			{
				new GuessJokerShuffleCardsAction(ECardPositionType.PlayerHand),
				new GuessJokerCallbackAction(delegate()
				{
					GuessJokerGamePlayModel.Instance.ClearPlayerDrawnCard();
					base.FinishTask();
				})
			});
			return;
		}
		GuessJokerGamePlayModel.Instance.ClearPlayerDrawnCard();
		base.FinishTask();
	}

	// Token: 0x06006A93 RID: 27283 RVA: 0x00157073 File Offset: 0x00155273
	protected override void OnComplete()
	{
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(false);
	}
}
