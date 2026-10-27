using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BEB RID: 27627
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGuessJokerSelectRoleView : OpenSystemBase
	{
		// Token: 0x060443D5 RID: 279509 RVA: 0x010D14BE File Offset: 0x010CF6BE
		public OpenSystemGuessJokerSelectRoleView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443D6 RID: 279510 RVA: 0x010D14C8 File Offset: 0x010CF6C8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemGuessJokerSelectRoleView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemGuessJokerSelectRoleView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443D7 RID: 279511 RVA: 0x010D1504 File Offset: 0x010CF704
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
