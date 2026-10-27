using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDC RID: 27612
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDropCatchInMainStory : OpenSystemBase
	{
		// Token: 0x060443A9 RID: 279465 RVA: 0x010D0F9E File Offset: 0x010CF19E
		public OpenSystemDropCatchInMainStory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443AA RID: 279466 RVA: 0x010D0FA8 File Offset: 0x010CF1A8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDropCatchInMainStory.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDropCatchInMainStory.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443AB RID: 279467 RVA: 0x010D0FEC File Offset: 0x010CF1EC
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
