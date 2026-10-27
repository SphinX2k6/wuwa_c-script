using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0B RID: 27659
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestReviewTipsView : OpenSystemBase
	{
		// Token: 0x06044436 RID: 279606 RVA: 0x010D2283 File Offset: 0x010D0483
		public OpenSystemQuestReviewTipsView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044437 RID: 279607 RVA: 0x010D228C File Offset: 0x010D048C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestReviewTipsView);
		}

		// Token: 0x06044438 RID: 279608 RVA: 0x010D2298 File Offset: 0x010D0498
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
