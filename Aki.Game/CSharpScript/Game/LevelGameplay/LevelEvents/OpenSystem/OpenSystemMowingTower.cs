using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C03 RID: 27651
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMowingTower : OpenSystemBase
	{
		// Token: 0x0604441D RID: 279581 RVA: 0x010D1EEB File Offset: 0x010D00EB
		public OpenSystemMowingTower(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604441E RID: 279582 RVA: 0x010D1EF4 File Offset: 0x010D00F4
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

		// Token: 0x0604441F RID: 279583 RVA: 0x010D1F37 File Offset: 0x010D0137
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MowingTowerMainView);
		}
	}
}
