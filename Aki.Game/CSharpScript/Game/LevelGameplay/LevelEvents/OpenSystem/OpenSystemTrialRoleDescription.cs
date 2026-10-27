using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C28 RID: 27688
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTrialRoleDescription : OpenSystemBase
	{
		// Token: 0x06044490 RID: 279696 RVA: 0x010D2E37 File Offset: 0x010D1037
		public OpenSystemTrialRoleDescription(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044491 RID: 279697 RVA: 0x010D2E40 File Offset: 0x010D1040
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTrialRoleDescription.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTrialRoleDescription.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044492 RID: 279698 RVA: 0x010D2E83 File Offset: 0x010D1083
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.JoinTeamView);
		}
	}
}
