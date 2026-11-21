using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D83 RID: 23939
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestReviewMainView : OpenSystemBase
	{
		// Token: 0x0603A58B RID: 238987 RVA: 0x0107C17F File Offset: 0x0107A37F
		public OpenSystemQuestReviewMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A58C RID: 238988 RVA: 0x0107C188 File Offset: 0x0107A388
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestReviewMainView);
		}

		// Token: 0x0603A58D RID: 238989 RVA: 0x0107C194 File Offset: 0x0107A394
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemQuestReviewMainView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemQuestReviewMainView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
