using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D90 RID: 23952
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRoleDescription : OpenSystemBase
	{
		// Token: 0x0603A5B1 RID: 239025 RVA: 0x0107C692 File Offset: 0x0107A892
		public OpenSystemRoleDescription(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5B2 RID: 239026 RVA: 0x0107C69C File Offset: 0x0107A89C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRoleDescription.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRoleDescription.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5B3 RID: 239027 RVA: 0x0107C6DF File Offset: 0x0107A8DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RoleNewJoinTipView);
		}
	}
}
