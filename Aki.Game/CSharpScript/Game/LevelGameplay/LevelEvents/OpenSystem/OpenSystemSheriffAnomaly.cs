using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D92 RID: 23954
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffAnomaly : OpenSystemBase
	{
		// Token: 0x0603A5B7 RID: 239031 RVA: 0x0107C73B File Offset: 0x0107A93B
		public OpenSystemSheriffAnomaly(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5B8 RID: 239032 RVA: 0x0107C744 File Offset: 0x0107A944
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSheriffAnomaly.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSheriffAnomaly.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5B9 RID: 239033 RVA: 0x0107C787 File Offset: 0x0107A987
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffReportPop);
		}
	}
}
