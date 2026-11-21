using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D88 RID: 23944
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueEventSelect : OpenSystemBase
	{
		// Token: 0x0603A599 RID: 239001 RVA: 0x0107C334 File Offset: 0x0107A534
		public OpenSystemRogueEventSelect(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A59A RID: 239002 RVA: 0x0107C340 File Offset: 0x0107A540
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueEventSelect.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueEventSelect.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A59B RID: 239003 RVA: 0x0107C37B File Offset: 0x0107A57B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RoguelikeRandomEventView);
		}
	}
}
