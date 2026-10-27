using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD6 RID: 27606
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoBrawlSettleVictory : OpenSystemBase
	{
		// Token: 0x06044397 RID: 279447 RVA: 0x010D0C93 File Offset: 0x010CEE93
		public OpenSystemDangoBrawlSettleVictory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044398 RID: 279448 RVA: 0x010D0C9C File Offset: 0x010CEE9C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoBrawlSettleVictory.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoBrawlSettleVictory.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044399 RID: 279449 RVA: 0x010D0CD7 File Offset: 0x010CEED7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoBrawlSuccessSettleView);
		}
	}
}
