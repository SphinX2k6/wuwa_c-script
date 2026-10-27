using System;
using System.Runtime.CompilerServices;

// Token: 0x02001040 RID: 4160
[Nullable(new byte[]
{
	0,
	1
})]
public class GuessJokerStageFsm : GuessJokerFsmBase<EGuessJokerCardStateType, GuessJokerStageBase>
{
	// Token: 0x06006AC8 RID: 27336 RVA: 0x00157C2C File Offset: 0x00155E2C
	protected override void InitStateInstance()
	{
		this.CurrentStateType = EGuessJokerCardStateType.None;
		base.RegisterState(EGuessJokerCardStateType.GameStart, new GuessJokerGameStartStage(this));
		base.RegisterState(EGuessJokerCardStateType.DealCards, new GuessJokerDealCardStage(this));
		base.RegisterState(EGuessJokerCardStateType.FlipCoin, new GuessJokerFlipCoinStage(this));
		base.RegisterState(EGuessJokerCardStateType.RoundPlay, new GuessJokerRoundPlayStage(this));
		base.RegisterState(EGuessJokerCardStateType.SettleStage, new GuessJokerSettleStage(this));
		base.RegisterState(EGuessJokerCardStateType.GameExit, new GuessJokerGameExitStage(this));
	}

	// Token: 0x06006AC9 RID: 27337 RVA: 0x00157C90 File Offset: 0x00155E90
	protected unsafe override bool CheckCanChangeState(EGuessJokerCardStateType curStateType, EGuessJokerCardStateType nextStateType)
	{
		EGuessJokerCardStateType[] array;
		if (!GuessJokerDefine.GetGuessJokerCardStageTransitionMap().TryGetValue(curStateType, out array) || array == null || Array.IndexOf<EGuessJokerCardStateType>(array, nextStateType) < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerStageFsm 检查状态转换失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("curStateType", curStateType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("nextStateType", nextStateType);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return true;
	}
}
