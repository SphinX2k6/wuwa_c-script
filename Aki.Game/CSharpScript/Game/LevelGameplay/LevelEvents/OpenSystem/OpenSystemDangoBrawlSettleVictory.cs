using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D4F RID: 23887
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoBrawlSettleVictory : OpenSystemBase
	{
		// Token: 0x0603A4EF RID: 238831 RVA: 0x0107ABE7 File Offset: 0x01078DE7
		public OpenSystemDangoBrawlSettleVictory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4F0 RID: 238832 RVA: 0x0107ABF0 File Offset: 0x01078DF0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoBrawlSettleVictory.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoBrawlSettleVictory.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4F1 RID: 238833 RVA: 0x0107AC2B File Offset: 0x01078E2B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoBrawlSuccessSettleView);
		}
	}
}
