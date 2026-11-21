using System;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

// Token: 0x020004D6 RID: 1238
public class GuessJokerNpcPerformAction : GuessJokerActionBase
{
	// Token: 0x06003DA8 RID: 15784 RVA: 0x0015CE68 File Offset: 0x0015B068
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

	// Token: 0x06003DA9 RID: 15785 RVA: 0x0015CEB8 File Offset: 0x0015B0B8
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

	// Token: 0x06003DAA RID: 15786 RVA: 0x0015CF00 File Offset: 0x0015B100
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

	// Token: 0x06003DAB RID: 15787 RVA: 0x0015CF94 File Offset: 0x0015B194
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

	// Token: 0x06003DAC RID: 15788 RVA: 0x0015D036 File Offset: 0x0015B236
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GuessJokerFinishPokerPerformAction, new Action<EPokerStateType>(this.OnGuessJokerFinishPokerPerformAction));
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x0015D054 File Offset: 0x0015B254
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GuessJokerFinishPokerPerformAction, new Action<EPokerStateType>(this.OnGuessJokerFinishPokerPerformAction));
	}

	// Token: 0x0400317B RID: 12667
	private readonly ENpcPokerChangeTimingType ChangeTiming;

	// Token: 0x0400317C RID: 12668
	private readonly int RelatedCardId;

	// Token: 0x0400317D RID: 12669
	private EPokerStateType State;
}
