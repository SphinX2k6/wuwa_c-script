using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004595 RID: 17813
	public class WuYinQuBattleStateFighting3 : WuYinQuBattleStateFighting1
	{
		// Token: 0x0602DF00 RID: 188160 RVA: 0x00A900BC File Offset: 0x00A8E2BC
		[NullableContext(1)]
		public WuYinQuBattleStateFighting3(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x0602DF01 RID: 188161 RVA: 0x00A900C7 File Offset: 0x00A8E2C7
		[NullableContext(2)]
		protected override PDA_WuYinQuBattleFightingData_C GetFightingData()
		{
			return this.Owner.WuYinQuFightingData.WuYinQuFightingData3;
		}

		// Token: 0x0602DF02 RID: 188162 RVA: 0x00A900DC File Offset: 0x00A8E2DC
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.当前状态 = "战斗阶段3";
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗阶段3", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602DF03 RID: 188163 RVA: 0x00A9011C File Offset: 0x00A8E31C
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			base.OnExit(lastState);
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段3", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
