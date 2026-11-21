using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D85 RID: 23941
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRegionalTerminal : OpenSystemBase
	{
		// Token: 0x0603A591 RID: 238993 RVA: 0x0107C22F File Offset: 0x0107A42F
		public OpenSystemRegionalTerminal(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A592 RID: 238994 RVA: 0x0107C238 File Offset: 0x0107A438
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRegionalTerminal.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRegionalTerminal.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A593 RID: 238995 RVA: 0x0107C27C File Offset: 0x0107A47C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
