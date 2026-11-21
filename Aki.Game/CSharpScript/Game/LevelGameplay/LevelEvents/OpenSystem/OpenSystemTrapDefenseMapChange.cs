using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA0 RID: 23968
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTrapDefenseMapChange : OpenSystemBase
	{
		// Token: 0x0603A5E5 RID: 239077 RVA: 0x0107CD3A File Offset: 0x0107AF3A
		public OpenSystemTrapDefenseMapChange(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5E6 RID: 239078 RVA: 0x0107CD44 File Offset: 0x0107AF44
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTrapDefenseMapChange.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTrapDefenseMapChange.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5E7 RID: 239079 RVA: 0x0107CD7F File Offset: 0x0107AF7F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TrapDefenseEventTerrainChangeTips);
		}
	}
}
