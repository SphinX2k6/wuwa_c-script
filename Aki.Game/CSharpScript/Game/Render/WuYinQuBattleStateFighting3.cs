using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034BD RID: 13501
	public class WuYinQuBattleStateFighting3 : WuYinQuBattleStateFighting1
	{
		// Token: 0x060225EA RID: 140778 RVA: 0x009BC2DC File Offset: 0x009BA4DC
		[NullableContext(1)]
		public WuYinQuBattleStateFighting3(WuYinQuBattleActor Owner, EWuYinQuBattleState State, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine = null) : base(Owner, State, StateMachine)
		{
		}

		// Token: 0x060225EB RID: 140779 RVA: 0x009BC2E7 File Offset: 0x009BA4E7
		[NullableContext(2)]
		protected override PDA_WuYinQuBattleFightingData_C GetFightingData()
		{
			return this.Owner.WuYinQuFightingData.WuYinQuFightingData3;
		}

		// Token: 0x060225EC RID: 140780 RVA: 0x009BC2FC File Offset: 0x009BA4FC
		protected override void OnEnter(EWuYinQuBattleState? lastState)
		{
			base.OnEnter(lastState);
			this.Owner.当前状态 = "战斗阶段3";
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "进入战斗阶段3", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060225ED RID: 140781 RVA: 0x009BC33C File Offset: 0x009BA53C
		protected override void OnExit(EWuYinQuBattleState lastState)
		{
			base.OnExit(lastState);
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "退出战斗阶段3", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
