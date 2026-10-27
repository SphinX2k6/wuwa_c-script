using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004598 RID: 17816
	public class WuYinQuBattleStateIdle : WuYinQuBattleStateBase
	{
		// Token: 0x0602DF0E RID: 188174 RVA: 0x00A909F8 File Offset: 0x00A8EBF8
		[NullableContext(1)]
		public WuYinQuBattleStateIdle(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DF0F RID: 188175 RVA: 0x00A90A03 File Offset: 0x00A8EC03
		protected override void OnStart()
		{
			this.OnEnter(new EWuYinQuBattleState?(EWuYinQuBattleState.Idle));
		}

		// Token: 0x0602DF10 RID: 188176 RVA: 0x00A90A14 File Offset: 0x00A8EC14
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入idle状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Owner.当前状态 = "静止状态";
		}

		// Token: 0x0602DF11 RID: 188177 RVA: 0x00A90A4D File Offset: 0x00A8EC4D
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x0602DF12 RID: 188178 RVA: 0x00A90A4F File Offset: 0x00A8EC4F
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
		}
	}
}
