using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020004E7 RID: 1255
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerAiDrawCardTask : GuessJokerTaskBase
{
	// Token: 0x06003E11 RID: 15889 RVA: 0x0015E941 File Offset: 0x0015CB41
	public GuessJokerAiDrawCardTask(JokerGuessDrawCardAction data)
	{
		this.CardId = data.DrawCard;
		this.SkillId = data.PreSkill;
	}

	// Token: 0x06003E12 RID: 15890 RVA: 0x0015E964 File Offset: 0x0015CB64
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

	// Token: 0x06003E13 RID: 15891 RVA: 0x0015EA78 File Offset: 0x0015CC78
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

	// Token: 0x06003E14 RID: 15892 RVA: 0x0015EAB8 File Offset: 0x0015CCB8
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

	// Token: 0x06003E15 RID: 15893 RVA: 0x0015EB78 File Offset: 0x0015CD78
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

	// Token: 0x06003E16 RID: 15894 RVA: 0x0015EC44 File Offset: 0x0015CE44
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

	// Token: 0x06003E17 RID: 15895 RVA: 0x0015EDAC File Offset: 0x0015CFAC
	private List<GuessJokerActionBase> GetDefaultGetCardActions()
	{
		List<GuessJokerActionBase> list = new List<GuessJokerActionBase>();
		GuessJokerGamePlayView gamePlayView = GuessJokerGamePlayModel.Instance.GetGamePlayView();
		GuessJokerCardData cardDataById = GuessJokerGamePlayModel.Instance.GetCardDataById(this.CardId);
		bool flag = cardDataById != null && cardDataById.IsJoker();
		bool flag2 = cardDataById != null && cardDataById.IsBlank();
		list.Add(new GuessJokerCallbackAction(delegate()
		{
			GuessJokerGamePlayModel.Instance.UpdateCardBelongPlayerType(new <>z__ReadOnlySingleElementList<int>(this.CardId), new EGuessJokerPlayerType?(EGuessJokerPlayerType.Ai));
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

	// Token: 0x040031AC RID: 12716
	private readonly int CardId;

	// Token: 0x040031AD RID: 12717
	private readonly int SkillId;
}
