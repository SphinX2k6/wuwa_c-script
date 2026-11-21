using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C3 RID: 18627
	public class FlagChallengeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC2F RID: 191535 RVA: 0x00D0A8BA File Offset: 0x00D08ABA
		public override bool Checker()
		{
			return FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x0602EC30 RID: 191536 RVA: 0x00D0A8C6 File Offset: 0x00D08AC6
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			FlagChallengeBattleController.Instance.OpenPauseView();
		}
	}
}
