using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D91 RID: 23953
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemScratchTicketMain : OpenSystemBase
	{
		// Token: 0x0603A5B4 RID: 239028 RVA: 0x0107C6EB File Offset: 0x0107A8EB
		public OpenSystemScratchTicketMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5B5 RID: 239029 RVA: 0x0107C6F4 File Offset: 0x0107A8F4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemScratchTicketMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemScratchTicketMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5B6 RID: 239030 RVA: 0x0107C72F File Offset: 0x0107A92F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ScratchTicketMainView);
		}
	}
}
