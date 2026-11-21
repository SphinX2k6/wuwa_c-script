using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D63 RID: 23907
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemGuessJokerGamePlayView : OpenSystemBase
	{
		// Token: 0x0603A52A RID: 238890 RVA: 0x0107B3AF File Offset: 0x010795AF
		public OpenSystemGuessJokerGamePlayView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A52B RID: 238891 RVA: 0x0107B3B8 File Offset: 0x010795B8
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

		// Token: 0x0603A52C RID: 238892 RVA: 0x0107B3FC File Offset: 0x010795FC
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
