using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D84 RID: 23940
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestReviewTipsView : OpenSystemBase
	{
		// Token: 0x0603A58E RID: 238990 RVA: 0x0107C1D7 File Offset: 0x0107A3D7
		public OpenSystemQuestReviewTipsView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A58F RID: 238991 RVA: 0x0107C1E0 File Offset: 0x0107A3E0
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestReviewTipsView);
		}

		// Token: 0x0603A590 RID: 238992 RVA: 0x0107C1EC File Offset: 0x0107A3EC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemQuestReviewTipsView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemQuestReviewTipsView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
