using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C02 RID: 27650
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMowBuffDistribute : OpenSystemBase
	{
		// Token: 0x0604441A RID: 279578 RVA: 0x010D1E9B File Offset: 0x010D009B
		public OpenSystemMowBuffDistribute(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604441B RID: 279579 RVA: 0x010D1EA4 File Offset: 0x010D00A4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMowBuffDistribute.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMowBuffDistribute.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604441C RID: 279580 RVA: 0x010D1EDF File Offset: 0x010D00DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.BossRushBuffInGameView);
		}
	}
}
