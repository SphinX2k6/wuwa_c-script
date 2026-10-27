using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C09 RID: 27657
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemQuestMultiLineView : OpenSystemBase
	{
		// Token: 0x06044430 RID: 279600 RVA: 0x010D21CB File Offset: 0x010D03CB
		public OpenSystemQuestMultiLineView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044431 RID: 279601 RVA: 0x010D21D4 File Offset: 0x010D03D4
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

		// Token: 0x06044432 RID: 279602 RVA: 0x010D221F File Offset: 0x010D041F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.QuestMultiLineView);
		}
	}
}
