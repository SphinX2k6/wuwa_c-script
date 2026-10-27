using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BEA RID: 27626
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGuessJokerGamePlayView : OpenSystemBase
	{
		// Token: 0x060443D2 RID: 279506 RVA: 0x010D145B File Offset: 0x010CF65B
		public OpenSystemGuessJokerGamePlayView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443D3 RID: 279507 RVA: 0x010D1464 File Offset: 0x010CF664
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemGuessJokerGamePlayView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemGuessJokerGamePlayView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443D4 RID: 279508 RVA: 0x010D14A8 File Offset: 0x010CF6A8
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
