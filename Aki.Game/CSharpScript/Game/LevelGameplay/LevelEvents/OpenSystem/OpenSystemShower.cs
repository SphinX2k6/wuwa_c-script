using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D97 RID: 23959
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShower : OpenSystemBase
	{
		// Token: 0x0603A5C7 RID: 239047 RVA: 0x0107C90B File Offset: 0x0107AB0B
		public OpenSystemShower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5C8 RID: 239048 RVA: 0x0107C914 File Offset: 0x0107AB14
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShowerInviteView);
		}

		// Token: 0x0603A5C9 RID: 239049 RVA: 0x0107C920 File Offset: 0x0107AB20
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
