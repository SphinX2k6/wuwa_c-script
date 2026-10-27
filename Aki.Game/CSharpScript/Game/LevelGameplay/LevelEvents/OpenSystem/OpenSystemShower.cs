using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1E RID: 27678
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShower : OpenSystemBase
	{
		// Token: 0x0604446F RID: 279663 RVA: 0x010D29B7 File Offset: 0x010D0BB7
		public OpenSystemShower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044470 RID: 279664 RVA: 0x010D29C0 File Offset: 0x010D0BC0
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShowerInviteView);
		}

		// Token: 0x06044471 RID: 279665 RVA: 0x010D29CC File Offset: 0x010D0BCC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemShower.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemShower.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
