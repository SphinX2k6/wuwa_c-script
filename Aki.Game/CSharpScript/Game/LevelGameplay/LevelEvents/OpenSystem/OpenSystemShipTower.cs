using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1C RID: 27676
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShipTower : OpenSystemBase
	{
		// Token: 0x06044469 RID: 279657 RVA: 0x010D2905 File Offset: 0x010D0B05
		public OpenSystemShipTower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604446A RID: 279658 RVA: 0x010D2910 File Offset: 0x010D0B10
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

		// Token: 0x0604446B RID: 279659 RVA: 0x010D2953 File Offset: 0x010D0B53
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShipTowerView);
		}
	}
}
