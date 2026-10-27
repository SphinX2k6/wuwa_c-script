using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C18 RID: 27672
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemScratchTicketMain : OpenSystemBase
	{
		// Token: 0x0604445C RID: 279644 RVA: 0x010D2797 File Offset: 0x010D0997
		public OpenSystemScratchTicketMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604445D RID: 279645 RVA: 0x010D27A0 File Offset: 0x010D09A0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemScratchTicketMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemScratchTicketMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604445E RID: 279646 RVA: 0x010D27DB File Offset: 0x010D09DB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ScratchTicketMainView);
		}
	}
}
