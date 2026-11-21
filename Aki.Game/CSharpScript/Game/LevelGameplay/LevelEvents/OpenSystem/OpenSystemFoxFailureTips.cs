using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D5D RID: 23901
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFoxFailureTips : OpenSystemBase
	{
		// Token: 0x0603A519 RID: 238873 RVA: 0x0107B1EF File Offset: 0x010793EF
		public OpenSystemFoxFailureTips(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A51A RID: 238874 RVA: 0x0107B1F8 File Offset: 0x010793F8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFoxFailureTips.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFoxFailureTips.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A51B RID: 238875 RVA: 0x0107B233 File Offset: 0x01079433
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FoxFailureTipsView);
		}
	}
}
