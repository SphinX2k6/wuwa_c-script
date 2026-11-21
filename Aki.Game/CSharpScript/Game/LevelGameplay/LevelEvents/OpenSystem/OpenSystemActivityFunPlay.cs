using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D3E RID: 23870
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivityFunPlay : OpenSystemBase
	{
		// Token: 0x0603A4BC RID: 238780 RVA: 0x0107A547 File Offset: 0x01078747
		public OpenSystemActivityFunPlay(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4BD RID: 238781 RVA: 0x0107A550 File Offset: 0x01078750
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemActivityFunPlay.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemActivityFunPlay.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4BE RID: 238782 RVA: 0x0107A58B File Offset: 0x0107878B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ActivityFunPlayView);
		}
	}
}
