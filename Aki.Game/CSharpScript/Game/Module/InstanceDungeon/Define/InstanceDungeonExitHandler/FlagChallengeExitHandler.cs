using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058EB RID: 22763
	public class FlagChallengeExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D0C RID: 236812 RVA: 0x00DBB962 File Offset: 0x00DB9B62
		public override bool Checker()
		{
			return FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon;
		}

		// Token: 0x06039D0D RID: 236813 RVA: 0x00DBB96E File Offset: 0x00DB9B6E
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			FlagChallengeBattleController.Instance.OpenPauseView();
		}
	}
}
