using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D95 RID: 23957
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShipTower : OpenSystemBase
	{
		// Token: 0x0603A5C1 RID: 239041 RVA: 0x0107C859 File Offset: 0x0107AA59
		public OpenSystemShipTower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5C2 RID: 239042 RVA: 0x0107C864 File Offset: 0x0107AA64
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemShipTower.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemShipTower.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5C3 RID: 239043 RVA: 0x0107C8A7 File Offset: 0x0107AAA7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShipTowerView);
		}
	}
}
