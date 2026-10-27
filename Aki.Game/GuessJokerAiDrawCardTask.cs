using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001033 RID: 4147
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerAiDrawCardTask : GuessJokerTaskBase
{
	// Token: 0x06006A7C RID: 27260 RVA: 0x00156019 File Offset: 0x00154219
	public GuessJokerAiDrawCardTask(JokerGuessDrawCardAction data)
	{
		this.CardId = data.DrawCard;
		this.SkillId = data.PreSkill;
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x0015603C File Offset: 0x0015423C
	protected override void OnExecute()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		GuessJokerGamePlayView guessJokerGamePlayView = (instance != null) ? instance.GetGamePlayView() : null;
		if (guessJokerGamePlayView == null)
		{
			base.FinishTask();
			return;
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("【task】Ai抽牌：{0}，技能ID：{1}", this.CardId, this.SkillId), default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.SkillId == 0)
		{
			guessJokerGamePlayView.UpdateCurrentPlayer(EGuessJokerPlayerType.Ai);
		}
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		foreach (GuessJokerActionBase item in this.GetDrawCardActionsBySkill())
		{
			list.Add(item);
		}
		foreach (GuessJokerActionBase item2 in this.GetDefaultGetCardActions())
		{
			list.Add(item2);
		}
		GuessJokerGamePlayModel.Instance.PushActions(list.ToArray());
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x00156150 File Offset: 0x00154350
	private List<GuessJokerActionBase> GetDrawCardActionsBySkill()
	{
		if (this.SkillId == 151001)
		{
			return this.GetLuhesiDrawCardActions();
		}
		if (this.SkillId == 100001 || this.SkillId == 130401)
		{
			return this.GetPlayerDrawCardActions();
		}
		return this.GetDefaultDrawCardActions();
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x00156190 File Offset: 0x00154390
	private List<GuessJokerActionBase> GetDefaultDrawCardActions()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerBeDrawCard));
		if (GuessJokerGamePlayModel.Instance.RoundNumber >= 1 && this.SkillId == 0)
		{
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Ai));
		}
		list.Add(new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.ChooseCard, this.CardId, 0f));
		list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
		{
			gamePlayView.ShowAiSelectCardTip(true, complete);
		}));
		list.Add(new GuessJokerUpCardsAction(new int[]
		{
			this.CardId
		}, true));
		list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
		{
			gamePlayView.SetCardsSelect(this.CardId, complete);
		}));
		return list;
	}

	// Token: 0x06006A80 RID: 27264 RVA: 0x00156250 File Offset: 0x00154450
	private List<GuessJokerActionBase> GetPlayerDrawCardActions()
	{
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		list.Add(new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerBeDrawCard));
		list.Add(new GuessJokerShuffleCardsAction(ECardPositionType.PlayerBeDrawCard));
		if (GuessJokerGamePlayModel.Instance.RoundNumber >= 1 && this.SkillId == 0)
		{
			list.Add(new GuessJokerRoundStartTipAction(EGuessJokerPlayerType.Ai));
		}
		list.Add(new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.ChooseCard, this.CardId, 0f));
		list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
		{
			gamePlayView.ShowAiSelectCardTip(true, complete);
		}));
		list.Add(new GuessJokerUpCardsAction(new int[]
		{
			this.CardId
		}, true));
		list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
		{
			gamePlayView.SetCardsSelect(this.CardId, complete);
		}));
		return list;
	}

	// Token: 0x06006A81 RID: 27265 RVA: 0x0015631C File Offset: 0x0015451C
	private List<GuessJokerActionBase> GetLuhesiDrawCardActions()
	{
		int jokerCardId = GuessJokerGamePlayModel.Instance.GetJokerCardId();
		GuessJokerCardData cardDataById = GuessJokerGamePlayModel.Instance.GetCardDataById(jokerCardId);
		if (cardDataById != null && cardDataById.GetBelongPlayerType().GetValueOrDefault() == EGuessJokerPlayerType.Ai)
		{
			return this.GetDefaultDrawCardActions();
		}
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		return new List<GuessJokerActionBase>
		{
			new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerBeDrawCard),
			new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.ChooseCard, this.CardId, 0f),
			new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowAiSelectCardTip(true, complete);
			}),
			new GuessJokerGroupAction(new GuessJokerActionBase[]
			{
				new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
				{
					gamePlayView.SetCardsSelect(jokerCardId, complete);
				}),
				new GuessJokerUpCardsAction(new int[]
				{
					jokerCardId
				}, true)
			}),
			new GuessJokerCallbackAction(delegate()
			{
				GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
				{
					new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.ExecuteSkill, new int?(this.SkillId))
				});
			}),
			new GuessJokerWaitAction(500f),
			new GuessJokerGroupAction(new GuessJokerActionBase[]
			{
				new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
				{
					gamePlayView.SetCardsSelect(this.CardId, complete);
				}),
				new GuessJokerUpCardsAction(new int[]
				{
					jokerCardId
				}, false),
				new GuessJokerUpCardsAction(new int[]
				{
					this.CardId
				}, true)
			})
		};
	}

	// Token: 0x06006A82 RID: 27266 RVA: 0x00156484 File Offset: 0x00154684
	private List<GuessJokerActionBase> GetDefaultGetCardActions()
	{
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		GuessJokerCardData cardDataById = GuessJokerGamePlayModel.Instance.GetCardDataById(this.CardId);
		bool flag = cardDataById != null && cardDataById.IsJoker();
		bool flag2 = cardDataById != null && cardDataById.IsBlank();
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			GuessJokerGamePlayModel.Instance.UpdateCardBelongPlayerType(new int[]
			{
				this.CardId
			}, new EGuessJokerPlayerType?(EGuessJokerPlayerType.Ai));
			GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetAiDrawnCard(this.CardId);
		}));
		list.Add(new GuessJokerGroupAction(new GuessJokerActionBase[]
		{
			new GuessJokerMoveCardsAction(new int[]
			{
				this.CardId
			}, ECardPositionType.Middle),
			new GuessJokerCollectCardsAction(EGuessJokerPlayerType.Me, ECardPositionType.PlayerHand),
			new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowAiSelectCardTip(false, complete);
			})
		}));
		if (flag)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowDrawSpecialTip(true, false, EGuessJokerPlayerType.Ai, complete);
			}));
		}
		else if (flag2)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowDrawSpecialTip(true, true, EGuessJokerPlayerType.Ai, complete);
			}));
		}
		list.Add(new GuessJokerNpcPerformAction(ENpcPokerChangeTimingType.DrawCard, this.CardId, (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerNpcDrawCardWaitTime.ToString())));
		if (flag)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowDrawSpecialTip(false, false, EGuessJokerPlayerType.Ai, complete);
			}));
		}
		else if (flag2)
		{
			list.Add(new GuessJokerCallbackWithCompleteAction(delegate(Action complete)
			{
				gamePlayView.ShowDrawSpecialTip(false, true, EGuessJokerPlayerType.Ai, complete);
			}));
		}
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			GuessJokerGamePlayModel.Instance.UpdateNpcIdleState();
			this.FinishTask();
		}));
		return list;
	}

	// Token: 0x04003113 RID: 12563
	private readonly int CardId;

	// Token: 0x04003114 RID: 12564
	private readonly int SkillId;
}
