using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x0200688B RID: 26763
	public class DangoBrawlFinalSettleState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042CF4 RID: 273652 RVA: 0x01043588 File Offset: 0x01041788
		public override void Enter(EDangoBrawlFsmState? prev)
		{
		}

		// Token: 0x06042CF5 RID: 273653 RVA: 0x0104358C File Offset: 0x0104178C
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlFinalSettleState.<EnterAsync>d__1 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.prev = prev;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlFinalSettleState.<EnterAsync>d__1>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042CF6 RID: 273654 RVA: 0x010435CF File Offset: 0x010417CF
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
