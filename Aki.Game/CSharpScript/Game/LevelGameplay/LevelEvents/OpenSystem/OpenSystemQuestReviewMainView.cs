using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0A RID: 27658
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestReviewMainView : OpenSystemBase
	{
		// Token: 0x06044433 RID: 279603 RVA: 0x010D222B File Offset: 0x010D042B
		public OpenSystemQuestReviewMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044434 RID: 279604 RVA: 0x010D2234 File Offset: 0x010D0434
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestReviewMainView);
		}

		// Token: 0x06044435 RID: 279605 RVA: 0x010D2240 File Offset: 0x010D0440
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
