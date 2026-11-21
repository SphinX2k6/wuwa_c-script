using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9E RID: 23966
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTetrisBoardGameEndlessLevel : OpenSystemBase
	{
		// Token: 0x0603A5DC RID: 239068 RVA: 0x0107CB53 File Offset: 0x0107AD53
		public OpenSystemTetrisBoardGameEndlessLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5DD RID: 239069 RVA: 0x0107CB5C File Offset: 0x0107AD5C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTetrisBoardGameEndlessLevel.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTetrisBoardGameEndlessLevel.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5DE RID: 239070 RVA: 0x0107CB9F File Offset: 0x0107AD9F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TetrisPlayView);
		}
	}
}
