using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD5 RID: 27605
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoBrawlSettleFailure : OpenSystemBase
	{
		// Token: 0x06044394 RID: 279444 RVA: 0x010D0C43 File Offset: 0x010CEE43
		public OpenSystemDangoBrawlSettleFailure(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044395 RID: 279445 RVA: 0x010D0C4C File Offset: 0x010CEE4C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoBrawlSettleFailure.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoBrawlSettleFailure.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044396 RID: 279446 RVA: 0x010D0C87 File Offset: 0x010CEE87
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoBrawlFailSettleView);
		}
	}
}
