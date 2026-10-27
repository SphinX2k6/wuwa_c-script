using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C08 RID: 27656
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestMultiLineTipsView : OpenSystemBase
	{
		// Token: 0x0604442D RID: 279597 RVA: 0x010D2168 File Offset: 0x010D0368
		public OpenSystemQuestMultiLineTipsView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604442E RID: 279598 RVA: 0x010D2174 File Offset: 0x010D0374
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemQuestMultiLineTipsView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemQuestMultiLineTipsView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604442F RID: 279599 RVA: 0x010D21BF File Offset: 0x010D03BF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestMultiLineTipsView);
		}
	}
}
