using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D7C RID: 23932
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMowingTower : OpenSystemBase
	{
		// Token: 0x0603A575 RID: 238965 RVA: 0x0107BE3F File Offset: 0x0107A03F
		public OpenSystemMowingTower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A576 RID: 238966 RVA: 0x0107BE48 File Offset: 0x0107A048
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMowingTower.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMowingTower.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A577 RID: 238967 RVA: 0x0107BE8B File Offset: 0x0107A08B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MowingTowerMainView);
		}
	}
}
