using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x020057DB RID: 22491
	public class DangoBrawlFinalSettleState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x0603784C RID: 227404 RVA: 0x00F84B08 File Offset: 0x00F82D08
		public override void Enter(EDangoBrawlFsmState? prev)
		{
		}

		// Token: 0x0603784D RID: 227405 RVA: 0x00F84B0C File Offset: 0x00F82D0C
		public override UniTask EnterAsync(EDangoBrawlFsmState? prev)
		{
			DangoBrawlFinalSettleState.<EnterAsync>d__1 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.prev = prev;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<DangoBrawlFinalSettleState.<EnterAsync>d__1>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603784E RID: 227406 RVA: 0x00F84B4F File Offset: 0x00F82D4F
		public override void Exit(EDangoBrawlFsmState? next)
		{
		}
	}
}
