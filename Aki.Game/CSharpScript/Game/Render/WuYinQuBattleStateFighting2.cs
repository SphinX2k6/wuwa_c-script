using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004594 RID: 17812
	public class WuYinQuBattleStateFighting2 : WuYinQuBattleStateFighting1
	{
		// Token: 0x0602DEFC RID: 188156 RVA: 0x00A9002D File Offset: 0x00A8E22D
		[NullableContext(1)]
		public WuYinQuBattleStateFighting2(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DEFD RID: 188157 RVA: 0x00A90038 File Offset: 0x00A8E238
		[NullableContext(2)]
		protected override PDA_WuYinQuBattleFightingData_C GetFightingData()
		{
			return this.Owner.WuYinQuFightingData.WuYinQuFightingData2;
		}

		// Token: 0x0602DEFE RID: 188158 RVA: 0x00A9004C File Offset: 0x00A8E24C
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.当前状态 = "战斗阶段2";
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗阶段2", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602DEFF RID: 188159 RVA: 0x00A9008C File Offset: 0x00A8E28C
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			base.OnExit(lastState);
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段2", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
