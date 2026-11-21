using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C0 RID: 13504
	public class WuYinQuBattleStateIdle : WuYinQuBattleStateBase
	{
		// Token: 0x060225F8 RID: 140792 RVA: 0x009BCC18 File Offset: 0x009BAE18
		[NullableContext(1)]
		public WuYinQuBattleStateIdle(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225F9 RID: 140793 RVA: 0x009BCC23 File Offset: 0x009BAE23
		protected override void OnStart()
		{
			this.OnEnter(new EWuYinQuBattleState?(EWuYinQuBattleState.Idle));
		}

		// Token: 0x060225FA RID: 140794 RVA: 0x009BCC34 File Offset: 0x009BAE34
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入idle状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Owner.当前状态 = "静止状态";
		}

		// Token: 0x060225FB RID: 140795 RVA: 0x009BCC6D File Offset: 0x009BAE6D
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x060225FC RID: 140796 RVA: 0x009BCC6F File Offset: 0x009BAE6F
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
		}
	}
}
