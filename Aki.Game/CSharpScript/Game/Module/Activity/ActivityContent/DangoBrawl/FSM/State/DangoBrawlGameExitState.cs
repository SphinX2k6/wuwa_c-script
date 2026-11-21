using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DC RID: 22492
	public class DangoBrawlGameExitState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06037850 RID: 227408 RVA: 0x00F84B59 File Offset: 0x00F82D59
		public override void Enter(EDangoBrawlFsmState? prev)
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				DangoBrawlModel.Instance.DestroyBattleManager();
			}, null, null);
		}

		// Token: 0x06037851 RID: 227409 RVA: 0x00F84B87 File Offset: 0x00F82D87
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
