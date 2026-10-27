using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004592 RID: 17810
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class WuYinQuBattleStateBase : StateBase<WuYinQuBattleActor, EWuYinQuBattleState>
	{
		// Token: 0x0602DEF3 RID: 188147 RVA: 0x00A8FEE5 File Offset: 0x00A8E0E5
		protected WuYinQuBattleStateBase(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DEF4 RID: 188148
		protected abstract override void OnEnter(EWuYinQuBattleState? lastState);

		// Token: 0x0602DEF5 RID: 188149
		protected abstract override void OnUpdate(float delta);

		// Token: 0x0602DEF6 RID: 188150
		protected abstract override void OnExit(EWuYinQuBattleState lastState);
	}
}
