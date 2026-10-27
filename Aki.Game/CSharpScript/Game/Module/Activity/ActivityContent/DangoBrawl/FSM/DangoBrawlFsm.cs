using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM
{
	// Token: 0x02006889 RID: 26761
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlFsm : CommonFsmManager<ActivityGameplayTurnStateBase<EDangoBrawlFsmState>, EDangoBrawlFsmState>
	{
		// Token: 0x06042CEB RID: 273643 RVA: 0x01043224 File Offset: 0x01041424
		protected unsafe override void InitState()
		{
			base.RegisterState(EDangoBrawlFsmState.GameStart, new DangoBrawlGameStartState());
			base.RegisterState(EDangoBrawlFsmState.ShopState, new DangoBrawlShopState());
			base.RegisterState(EDangoBrawlFsmState.TrashTalkState, new DangoBrawlTrashTalkState());
			base.RegisterState(EDangoBrawlFsmState.LoadingBattle, new DangoBrawlLoadingBattleState());
			base.RegisterState(EDangoBrawlFsmState.FightingState, new DangoBrawlFightingState());
			base.RegisterState(EDangoBrawlFsmState.RoundSettle, new DangoBrawlRoundSettleState());
			base.RegisterState(EDangoBrawlFsmState.FinalSettle, new DangoBrawlFinalSettleState());
			base.RegisterState(EDangoBrawlFsmState.GameExit, new DangoBrawlGameExitState());
			EDangoBrawlFsmState from = EDangoBrawlFsmState.None;
			int num = 1;
			List<EDangoBrawlFsmState> list = new List<EDangoBrawlFsmState>(num);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list, num);
			Span<EDangoBrawlFsmState> span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list);
			int num2 = 0;
			*span[num2] = EDangoBrawlFsmState.GameStart;
			base.RegisterTransition(from, list);
			EDangoBrawlFsmState from2 = EDangoBrawlFsmState.GameStart;
			num2 = 2;
			List<EDangoBrawlFsmState> list2 = new List<EDangoBrawlFsmState>(num2);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list2, num2);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list2);
			num = 0;
			*span[num] = EDangoBrawlFsmState.ShopState;
			num++;
			*span[num] = EDangoBrawlFsmState.LoadingBattle;
			base.RegisterTransition(from2, list2);
			EDangoBrawlFsmState from3 = EDangoBrawlFsmState.ShopState;
			num = 3;
			List<EDangoBrawlFsmState> list3 = new List<EDangoBrawlFsmState>(num);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list3, num);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list3);
			num2 = 0;
			*span[num2] = EDangoBrawlFsmState.FightingState;
			num2++;
			*span[num2] = EDangoBrawlFsmState.TrashTalkState;
			num2++;
			*span[num2] = EDangoBrawlFsmState.FinalSettle;
			base.RegisterTransition(from3, list3);
			EDangoBrawlFsmState from4 = EDangoBrawlFsmState.TrashTalkState;
			num2 = 1;
			List<EDangoBrawlFsmState> list4 = new List<EDangoBrawlFsmState>(num2);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list4, num2);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list4);
			num = 0;
			*span[num] = EDangoBrawlFsmState.FightingState;
			base.RegisterTransition(from4, list4);
			EDangoBrawlFsmState from5 = EDangoBrawlFsmState.LoadingBattle;
			num = 1;
			List<EDangoBrawlFsmState> list5 = new List<EDangoBrawlFsmState>(num);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list5, num);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list5);
			num2 = 0;
			*span[num2] = EDangoBrawlFsmState.FightingState;
			base.RegisterTransition(from5, list5);
			EDangoBrawlFsmState from6 = EDangoBrawlFsmState.FightingState;
			num2 = 3;
			List<EDangoBrawlFsmState> list6 = new List<EDangoBrawlFsmState>(num2);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list6, num2);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list6);
			num = 0;
			*span[num] = EDangoBrawlFsmState.RoundSettle;
			num++;
			*span[num] = EDangoBrawlFsmState.ShopState;
			num++;
			*span[num] = EDangoBrawlFsmState.FinalSettle;
			base.RegisterTransition(from6, list6);
			EDangoBrawlFsmState from7 = EDangoBrawlFsmState.RoundSettle;
			num = 2;
			List<EDangoBrawlFsmState> list7 = new List<EDangoBrawlFsmState>(num);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list7, num);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list7);
			num2 = 0;
			*span[num2] = EDangoBrawlFsmState.ShopState;
			num2++;
			*span[num2] = EDangoBrawlFsmState.FinalSettle;
			base.RegisterTransition(from7, list7);
			EDangoBrawlFsmState from8 = EDangoBrawlFsmState.FinalSettle;
			num2 = 1;
			List<EDangoBrawlFsmState> list8 = new List<EDangoBrawlFsmState>(num2);
			CollectionsMarshal.SetCount<EDangoBrawlFsmState>(list8, num2);
			span = CollectionsMarshal.AsSpan<EDangoBrawlFsmState>(list8);
			num = 0;
			*span[num] = EDangoBrawlFsmState.GameExit;
			base.RegisterTransition(from8, list8);
		}
	}
}
