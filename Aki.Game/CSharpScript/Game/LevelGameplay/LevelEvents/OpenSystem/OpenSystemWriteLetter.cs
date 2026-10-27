using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C30 RID: 27696
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWriteLetter : OpenSystemBase
	{
		// Token: 0x060444A9 RID: 279721 RVA: 0x010D31CB File Offset: 0x010D13CB
		public OpenSystemWriteLetter(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060444AA RID: 279722 RVA: 0x010D31D4 File Offset: 0x010D13D4
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

		// Token: 0x060444AB RID: 279723 RVA: 0x010D321F File Offset: 0x010D141F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LetterBackupDisplayView);
		}
	}
}
