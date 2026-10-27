using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD2 RID: 27602
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCyberpunkCollaborationVehicleShare : OpenSystemBase
	{
		// Token: 0x0604438B RID: 279435 RVA: 0x010D0B49 File Offset: 0x010CED49
		public OpenSystemCyberpunkCollaborationVehicleShare(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604438C RID: 279436 RVA: 0x010D0B54 File Offset: 0x010CED54
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemCyberpunkCollaborationVehicleShare.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemCyberpunkCollaborationVehicleShare.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604438D RID: 279437 RVA: 0x010D0B97 File Offset: 0x010CED97
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoonTogetherInviteView);
		}
	}
}
