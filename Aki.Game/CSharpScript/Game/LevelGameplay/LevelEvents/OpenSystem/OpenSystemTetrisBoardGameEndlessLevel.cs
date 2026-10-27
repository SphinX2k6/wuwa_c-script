using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C25 RID: 27685
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTetrisBoardGameEndlessLevel : OpenSystemBase
	{
		// Token: 0x06044484 RID: 279684 RVA: 0x010D2BFF File Offset: 0x010D0DFF
		public OpenSystemTetrisBoardGameEndlessLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044485 RID: 279685 RVA: 0x010D2C08 File Offset: 0x010D0E08
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

		// Token: 0x06044486 RID: 279686 RVA: 0x010D2C4B File Offset: 0x010D0E4B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TetrisPlayView);
		}
	}
}
