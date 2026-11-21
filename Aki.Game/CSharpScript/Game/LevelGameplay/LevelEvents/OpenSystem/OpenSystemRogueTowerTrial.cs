using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8F RID: 23951
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueTowerTrial : OpenSystemBase
	{
		// Token: 0x0603A5AE RID: 239022 RVA: 0x0107C637 File Offset: 0x0107A837
		public OpenSystemRogueTowerTrial(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5AF RID: 239023 RVA: 0x0107C640 File Offset: 0x0107A840
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueTowerTrial.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueTowerTrial.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5B0 RID: 239024 RVA: 0x0107C67C File Offset: 0x0107A87C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
