using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA3 RID: 23971
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVersionPreheat : OpenSystemBase
	{
		// Token: 0x0603A5EE RID: 239086 RVA: 0x0107CE3B File Offset: 0x0107B03B
		public OpenSystemVersionPreheat(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5EF RID: 239087 RVA: 0x0107CE44 File Offset: 0x0107B044
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemVersionPreheat.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemVersionPreheat.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5F0 RID: 239088 RVA: 0x0107CE87 File Offset: 0x0107B087
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VersionPreheatVoteView);
		}
	}
}
