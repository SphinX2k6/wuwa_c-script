using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D5C RID: 23900
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemForging : OpenSystemBase
	{
		// Token: 0x0603A516 RID: 238870 RVA: 0x0107B19F File Offset: 0x0107939F
		public OpenSystemForging(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A517 RID: 238871 RVA: 0x0107B1A8 File Offset: 0x010793A8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemForging.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemForging.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A518 RID: 238872 RVA: 0x0107B1E3 File Offset: 0x010793E3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ForgingRootView);
		}
	}
}
