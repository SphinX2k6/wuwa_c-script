using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA9 RID: 23977
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWriteLetter : OpenSystemBase
	{
		// Token: 0x0603A601 RID: 239105 RVA: 0x0107D11F File Offset: 0x0107B31F
		public OpenSystemWriteLetter(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A602 RID: 239106 RVA: 0x0107D128 File Offset: 0x0107B328
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemWriteLetter.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemWriteLetter.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A603 RID: 239107 RVA: 0x0107D173 File Offset: 0x0107B373
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LetterBackupDisplayView);
		}
	}
}
