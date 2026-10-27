using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C19 RID: 27673
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSheriffAnomaly : OpenSystemBase
	{
		// Token: 0x0604445F RID: 279647 RVA: 0x010D27E7 File Offset: 0x010D09E7
		public OpenSystemSheriffAnomaly(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044460 RID: 279648 RVA: 0x010D27F0 File Offset: 0x010D09F0
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

		// Token: 0x06044461 RID: 279649 RVA: 0x010D2833 File Offset: 0x010D0A33
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SheriffReportPop);
		}
	}
}
