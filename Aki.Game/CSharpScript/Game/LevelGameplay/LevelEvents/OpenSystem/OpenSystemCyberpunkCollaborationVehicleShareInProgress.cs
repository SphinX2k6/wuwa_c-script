using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD3 RID: 27603
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCyberpunkCollaborationVehicleShareInProgress : OpenSystemBase
	{
		// Token: 0x0604438E RID: 279438 RVA: 0x010D0BA3 File Offset: 0x010CEDA3
		public OpenSystemCyberpunkCollaborationVehicleShareInProgress(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604438F RID: 279439 RVA: 0x010D0BAC File Offset: 0x010CEDAC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemCyberpunkCollaborationVehicleShareInProgress.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemCyberpunkCollaborationVehicleShareInProgress.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044390 RID: 279440 RVA: 0x010D0BE7 File Offset: 0x010CEDE7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoonTogetherMainView);
		}
	}
}
