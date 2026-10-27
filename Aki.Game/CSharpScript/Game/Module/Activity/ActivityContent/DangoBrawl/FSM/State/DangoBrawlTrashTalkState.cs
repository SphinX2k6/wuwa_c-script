using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.FSM.State
{
	// Token: 0x02006891 RID: 26769
	public class DangoBrawlTrashTalkState : ActivityGameplayTurnStateBase<EDangoBrawlFsmState>
	{
		// Token: 0x06042D11 RID: 273681 RVA: 0x01043A44 File Offset: 0x01041C44
		public override UniTask ExitAsync(EDangoBrawlFsmState? next)
		{
			DangoBrawlTrashTalkState.<ExitAsync>d__0 <ExitAsync>d__;
			<ExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitAsync>d__.<>1__state = -1;
			<ExitAsync>d__.<>t__builder.Start<DangoBrawlTrashTalkState.<ExitAsync>d__0>(ref <ExitAsync>d__);
			return <ExitAsync>d__.<>t__builder.Task;
		}
	}
}
