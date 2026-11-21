using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D82 RID: 23938
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestMultiLineView : OpenSystemBase
	{
		// Token: 0x0603A588 RID: 238984 RVA: 0x0107C11F File Offset: 0x0107A31F
		public OpenSystemQuestMultiLineView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A589 RID: 238985 RVA: 0x0107C128 File Offset: 0x0107A328
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemQuestMultiLineView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemQuestMultiLineView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A58A RID: 238986 RVA: 0x0107C173 File Offset: 0x0107A373
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestMultiLineView);
		}
	}
}
