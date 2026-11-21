using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034BC RID: 13500
	public class WuYinQuBattleStateFighting2 : WuYinQuBattleStateFighting1
	{
		// Token: 0x060225E6 RID: 140774 RVA: 0x009BC24D File Offset: 0x009BA44D
		[NullableContext(1)]
		public WuYinQuBattleStateFighting2(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225E7 RID: 140775 RVA: 0x009BC258 File Offset: 0x009BA458
		[NullableContext(2)]
		protected override PDA_WuYinQuBattleFightingData_C GetFightingData()
		{
			return this.Owner.WuYinQuFightingData.WuYinQuFightingData2;
		}

		// Token: 0x060225E8 RID: 140776 RVA: 0x009BC26C File Offset: 0x009BA46C
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.当前状态 = "战斗阶段2";
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗阶段2", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060225E9 RID: 140777 RVA: 0x009BC2AC File Offset: 0x009BA4AC
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			base.OnExit(lastState);
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段2", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
