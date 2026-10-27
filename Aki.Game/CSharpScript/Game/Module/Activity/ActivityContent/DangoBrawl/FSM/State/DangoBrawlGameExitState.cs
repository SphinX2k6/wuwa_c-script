using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x0200688C RID: 26764
	public class DangoBrawlGameExitState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042CF8 RID: 273656 RVA: 0x010435D9 File Offset: 0x010417D9
		public override void Enter(EDangoBrawlFsmState? prev)
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				DangoBrawlModel.Instance.DestroyBattleManager();
			}, null, null);
		}

		// Token: 0x06042CF9 RID: 273657 RVA: 0x01043607 File Offset: 0x01041807
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
