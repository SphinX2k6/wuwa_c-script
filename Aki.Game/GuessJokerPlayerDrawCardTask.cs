using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02001036 RID: 4150
public class GuessJokerPlayerDrawCardTask : GuessJokerTaskBase
{
	// Token: 0x06006A8B RID: 27275 RVA: 0x00156AD6 File Offset: 0x00154CD6
	public GuessJokerPlayerDrawCardTask()
	{
		this.TaskType = EGuessJokerTaskType.Interactive;
	}

	// Token: 0x06006A8C RID: 27276 RVA: 0x00156AE8 File Offset: 0x00154CE8
	protected override void OnExecute()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(true);
		gamePlayView.UpdateCurrentPlayer(EGuessJokerPlayerType.Me);
		gamePlayView.SetPlayerCardClickCallback(delegate(int cardId, int prevSelectedCardId, bool isSelected)
		{
			if (this.IsFinished())
			{
				Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "任务已完成，忽略点击", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (isSelected)
			{
				this.OnPlayerDrawCard(cardId);
				return;
			}
			this.OnPlayerChooseCard(cardId, prevSelectedCardId);
		});
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Ai, ECardPositionType.AiBeDrawCard));
		if (GuessJokerGamePlayModel.Instance.RoundNumber >= 1)
		{
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Me));
		}
		list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
		{
			gamePlayView.ShowPlayerDrawCardTip(true, complete);
		}));
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			GuessJokerPositionPanelBase positionPanel = gamePlayView.GetPositionPanel(ECardPositionType.AiBeDrawCard);
			if (positionPanel == null)
			{
				return;
			}
			positionPanel.SetCardsClickableExcept(true, 0);
		}));
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
		if (GuessJokerGamePlayModel.Instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai).Count > 1)
		{
			GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
			{
				new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.PlayerStartDrawCard, null)
			});
		}
	}

	// Token: 0x06006A8D RID: 27277 RVA: 0x00156BF0 File Offset: 0x00154DF0
	private void OnPlayerChooseCard(int cardId, int prevSelectedCardId)
	{
		if (this.HasPlayerDrawn)
		{
			Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "已经抽过牌，忽略选牌操作", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			return;
		}
		GuessJokerPositionPanelBase aiPanel = gamePlayView.GetPositionPanel(ECardPositionType.AiBeDrawCard);
		if (aiPanel == null)
		{
			return;
		}
		gamePlayView.SetCardChoose(cardId, true);
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			aiPanel.SetCardsClickableExcept(false, 0);
		}));
		list.Add(new GuessJokerGroupAction(new GuessJokerActionBase[]
		{
			new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.BeChooseCard, cardId, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCardUpTime.ToString())),
			new GuessJokerUpCardsAction(new int[]
			{
				cardId
			}, true),
			new GuessJokerUpCardsAction(new int[]
			{
				prevSelectedCardId
			}, false)
		}));
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			aiPanel.SetCardsClickableExcept(true, 0);
		}));
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
		if (GuessJokerGamePlayModel.Instance.GetHandCardsByPlayer(EGuessJokerPlayerType.Ai).Count > 1)
		{
			GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
			{
				new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.PlayerChooseCard, null)
			});
		}
	}

	// Token: 0x06006A8E RID: 27278 RVA: 0x00156D2C File Offset: 0x00154F2C
	private void OnPlayerDrawCard(int cardId)
	{
		if (this.HasPlayerDrawn)
		{
			Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "已经抽过牌，忽略重复点击", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!base.CanSendRequest())
		{
			Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "抽卡请求进行中，忽略重复点击", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		if (gamePlayView == null)
		{
			return;
		}
		GuessJokerPositionPanelBase aiPanel = gamePlayView.GetPositionPanel(ECardPositionType.AiBeDrawCard);
		if (aiPanel == null)
		{
			return;
		}
		base.SetRequestFinished(true);
		this.HasPlayerDrawn = true;
		GuessJokerCardItem cardItemById = gamePlayView.GetCardItemById(cardId);
		if (cardItemById != null)
		{
			cardItemById.SetToggleState(true);
		}
		Action<Action> <>9__2;
		Action<Action> <>9__4;
		Action<Action> <>9__5;
		Action<Action> <>9__7;
		Action<Action> <>9__8;
		Action <>9__11;
		GuessJokerController.Instance.RequestJokerGuessDrawCard(cardId, delegate(int actualCardId)
		{
			int finalCardId = cardId;
			if (actualCardId != cardId)
			{
				aiPanel.SwapCardPositionsSilently(cardId, actualCardId);
				finalCardId = actualCardId;
			}
			GuessJokerCardData cardDataById = GuessJokerGamePlayModel.Instance.GetCardDataById(finalCardId);
			bool flag = cardDataById != null && cardDataById.IsJoker();
			bool flag2 = cardDataById != null && cardDataById.IsBlank();
			GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
			if (instance != null)
			{
				instance.UpdateCardBelongPlayerType(new int[]
				{
					finalCardId
				}, new EGuessJokerPlayerType?(EGuessJokerPlayerType.Me));
			}
			EGuessJokerPlotTiming plotTiming = GuessJokerUtils.GetPlayerGetCardState(finalCardId);
			GuessJokerGamePlayModel instance2 = GuessJokerGamePlayModel.Instance;
			if (instance2 != null)
			{
				instance2.SetPlayerDrawnCard(finalCardId);
			}
			aiPanel.SetCardsClickableExcept(false, finalCardId);
			gamePlayView.ClearChooseCard();
			GuessJokerCardItem cardItemById2 = gamePlayView.GetCardItemById(finalCardId);
			if (cardItemById2 != null)
			{
				cardItemById2.SetClickEnable(false);
			}
			List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.SetCardsSelect(finalCardId, complete);
			}));
			List<GuessJokerActionBase> list2 = list;
			Action<Action> callback;
			if ((callback = <>9__2) == null)
			{
				callback = (<>9__2 = delegate(Action complete)
				{
					gamePlayView.ShowPlayerDrawCardTip(false, complete);
				});
			}
			list2.Add(new GuessJokerCallbackWithCompleteAction(callback));
			list.Add(new GuessJokerGroupAction(new GuessJokerActionBase[]
			{
				new GuessJokerShowCardsAction(new int[]
				{
					finalCardId
				}, true, 0f),
				new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.BeDrawCard, finalCardId, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerNpcDrawCardWaitTime.ToString())),
				new GuessJokerMoveCardsAction(new int[]
				{
					finalCardId
				}, ECardPositionType.Middle),
				new GuessJokerCallbackAction(delegate()
				{
					GuessJokerGamePlayModel instance3 = GuessJokerGamePlayModel.Instance;
					if (instance3 == null)
					{
						return;
					}
					instance3.PushPlotActions(new GuessJokerPlotAction[]
					{
						new GuessJokerPlotAction(EGuessJokerPlayerType.Me, plotTiming, null)
					});
				}),
				new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Ai, ECardPositionType.AiHand)
			}));
			if (flag)
			{
				List<GuessJokerActionBase> list3 = list;
				Action<Action> callback2;
				if ((callback2 = <>9__4) == null)
				{
					callback2 = (<>9__4 = delegate(Action complete)
					{
						gamePlayView.ShowDrawSpecialTip(true, false, EGuessJokerPlayerType.Me, complete);
					});
				}
				list3.Add(new GuessJokerCallbackWithCompleteAction(callback2));
				List<GuessJokerActionBase> list4 = list;
				Action<Action> callback3;
				if ((callback3 = <>9__5) == null)
				{
					callback3 = (<>9__5 = delegate(Action complete)
					{
						gamePlayView.ShowDrawSpecialTip(false, false, EGuessJokerPlayerType.Me, complete);
					});
				}
				list4.Add(new GuessJokerCallbackWithCompleteAction(callback3));
				list.Add(new GuessJokerCallbackAction(delegate()
				{
					EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerDrawJoker");
				}));
			}
			else if (flag2)
			{
				List<GuessJokerActionBase> list5 = list;
				Action<Action> callback4;
				if ((callback4 = <>9__7) == null)
				{
					callback4 = (<>9__7 = delegate(Action complete)
					{
						gamePlayView.ShowDrawSpecialTip(true, true, EGuessJokerPlayerType.Me, complete);
					});
				}
				list5.Add(new GuessJokerCallbackWithCompleteAction(callback4));
				List<GuessJokerActionBase> list6 = list;
				Action<Action> callback5;
				if ((callback5 = <>9__8) == null)
				{
					callback5 = (<>9__8 = delegate(Action complete)
					{
						gamePlayView.ShowDrawSpecialTip(false, true, EGuessJokerPlayerType.Me, complete);
					});
				}
				list6.Add(new GuessJokerCallbackWithCompleteAction(callback5));
				list.Add(new GuessJokerCallbackAction(delegate()
				{
					EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerDrawChange");
				}));
			}
			list.Add(new GuessJokerCallbackAction(delegate()
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerAfterDraw");
			}));
			List<GuessJokerActionBase> list7 = list;
			Action callback6;
			if ((callback6 = <>9__11) == null)
			{
				callback6 = (<>9__11 = delegate()
				{
					gamePlayView.HidePlayerButtons();
					GuessJokerGamePlayModel.Instance.UpdateNpcIdleState();
					this.FinishTask();
				});
			}
			list7.Add(new GuessJokerCallbackAction(callback6));
			GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
		});
	}

	// Token: 0x06006A8F RID: 27279 RVA: 0x00156E18 File Offset: 0x00155018
	protected override void OnComplete()
	{
		GuessJokerGamePlayModel.Instance.SetNpcEnterInteractiveStage(false);
	}

	// Token: 0x0400311A RID: 12570
	private bool HasPlayerDrawn;
}
