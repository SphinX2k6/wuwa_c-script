using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C27 RID: 27687
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTrapDefenseMapChange : OpenSystemBase
	{
		// Token: 0x0604448D RID: 279693 RVA: 0x010D2DE6 File Offset: 0x010D0FE6
		public OpenSystemTrapDefenseMapChange(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604448E RID: 279694 RVA: 0x010D2DF0 File Offset: 0x010D0FF0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTrapDefenseMapChange.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTrapDefenseMapChange.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604448F RID: 279695 RVA: 0x010D2E2B File Offset: 0x010D102B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TrapDefenseEventTerrainChangeTips);
		}
	}
}
