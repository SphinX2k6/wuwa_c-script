using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034BA RID: 13498
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public abstract class WuYinQuBattleStateBase : StateBase<WuYinQuBattleActor, EWuYinQuBattleState>
	{
		// Token: 0x060225DD RID: 140765 RVA: 0x009BC105 File Offset: 0x009BA305
		protected WuYinQuBattleStateBase(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225DE RID: 140766
		protected abstract override void OnEnter(EWuYinQuBattleState? lastState);

		// Token: 0x060225DF RID: 140767
		protected abstract override void OnUpdate(float delta);

		// Token: 0x060225E0 RID: 140768
		protected abstract override void OnExit(EWuYinQuBattleState lastState);
	}
}
