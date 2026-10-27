using System;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

// Token: 0x02001022 RID: 4130
public class GuessJokerNpcPerformAction : GuessJokerActionBase
{
	// Token: 0x06006A13 RID: 27155 RVA: 0x00154540 File Offset: 0x00152740
	public GuessJokerNpcPerformAction(ENpcPokerChangeTimingType changeTiming, int relatedCardId = 0, float duration = 0f)
	{
		this.ChangeTiming = changeTiming;
		this.RelatedCardId = relatedCardId;
		if (duration != 0f)
		{
			this.Duration = duration;
			return;
		}
		this.Duration = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerMaxPerformTime.ToString());
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x00154590 File Offset: 0x00152790
	protected override void OnStart()
	{
		if (GuessJokerGamePlayModel.Instance == null)
		{
			this.Done = true;
			return;
		}
		EPokerStateType epokerStateType = GuessJokerUtils.CalculateNpcState(this.ChangeTiming, this.RelatedCardId);
		this.State = epokerStateType;
		this.PushRelatedPlotAction();
		GuessJokerGamePlayModel.Instance.SetNpcPokerState(epokerStateType);
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x001545D8 File Offset: 0x001527D8
	private void PushRelatedPlotAction()
	{
		GuessJokerPlotAction guessJokerPlotAction = null;
		switch (this.State)
		{
		case EPokerStateType.DrawCardNormal:
			guessJokerPlotAction = new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.AiNormalDrawCard, null);
			break;
		case EPokerStateType.DrawCardThinking:
			guessJokerPlotAction = new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.AiThinkingDrawCard, null);
			break;
		case EPokerStateType.GetCardHappy:
			guessJokerPlotAction = new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.GetCardHappy, null);
			break;
		case EPokerStateType.GetCardSad:
			guessJokerPlotAction = new GuessJokerPlotAction(EGuessJokerPlayerType.Ai, EGuessJokerPlotTiming.GetCardSad, null);
			break;
		}
		if (guessJokerPlotAction != null)
		{
			GuessJokerGamePlayModel.Instance.PushPlotActions(new GuessJokerPlotAction[]
			{
				guessJokerPlotAction
			});
		}
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x0015466C File Offset: 0x0015286C
	private unsafe void OnGuessJokerFinishPokerPerformAction(EPokerStateType state)
	{
		if (state != this.State)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "OnGuessJokerFinishPokerPerformAction state is not match";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("notify state", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.State", this.State);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "OnGuessJokerFinishPokerPerformAction!!", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.Done = true;
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x0015470E File Offset: 0x0015290E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GuessJokerFinishPokerPerformAction, new Action<EPokerStateType>(this.OnGuessJokerFinishPokerPerformAction));
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x0015472C File Offset: 0x0015292C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GuessJokerFinishPokerPerformAction, new Action<EPokerStateType>(this.OnGuessJokerFinishPokerPerformAction));
	}

	// Token: 0x040030E2 RID: 12514
	private readonly ENpcPokerChangeTimingType ChangeTiming;

	// Token: 0x040030E3 RID: 12515
	private readonly int RelatedCardId;

	// Token: 0x040030E4 RID: 12516
	private EPokerStateType State;
}
