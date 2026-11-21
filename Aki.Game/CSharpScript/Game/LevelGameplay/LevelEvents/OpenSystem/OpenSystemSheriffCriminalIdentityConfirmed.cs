using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D93 RID: 23955
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffCriminalIdentityConfirmed : OpenSystemBase
	{
		// Token: 0x0603A5BA RID: 239034 RVA: 0x0107C793 File Offset: 0x0107A993
		public OpenSystemSheriffCriminalIdentityConfirmed(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5BB RID: 239035 RVA: 0x0107C79C File Offset: 0x0107A99C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSheriffCriminalIdentityConfirmed.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSheriffCriminalIdentityConfirmed.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5BC RID: 239036 RVA: 0x0107C7DF File Offset: 0x0107A9DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffCriminalIdentityConfirmedView);
		}
	}
}
