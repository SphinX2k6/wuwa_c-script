using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D4B RID: 23883
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCyberpunkCollaborationVehicleShare : OpenSystemBase
	{
		// Token: 0x0603A4E3 RID: 238819 RVA: 0x0107AA9D File Offset: 0x01078C9D
		public OpenSystemCyberpunkCollaborationVehicleShare(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4E4 RID: 238820 RVA: 0x0107AAA8 File Offset: 0x01078CA8
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

		// Token: 0x0603A4E5 RID: 238821 RVA: 0x0107AAEB File Offset: 0x01078CEB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoonTogetherInviteView);
		}
	}
}
