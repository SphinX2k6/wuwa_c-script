using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D7B RID: 23931
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMowBuffDistribute : OpenSystemBase
	{
		// Token: 0x0603A572 RID: 238962 RVA: 0x0107BDEF File Offset: 0x01079FEF
		public OpenSystemMowBuffDistribute(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A573 RID: 238963 RVA: 0x0107BDF8 File Offset: 0x01079FF8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMowBuffDistribute.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMowBuffDistribute.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A574 RID: 238964 RVA: 0x0107BE33 File Offset: 0x0107A033
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.BossRushBuffInGameView);
		}
	}
}
