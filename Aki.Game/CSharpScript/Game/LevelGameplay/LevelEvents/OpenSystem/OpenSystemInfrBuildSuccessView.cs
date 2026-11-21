using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D6E RID: 23918
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInfrBuildSuccessView : OpenSystemBase
	{
		// Token: 0x0603A54B RID: 238923 RVA: 0x0107B839 File Offset: 0x01079A39
		public OpenSystemInfrBuildSuccessView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A54C RID: 238924 RVA: 0x0107B844 File Offset: 0x01079A44
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemInfrBuildSuccessView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemInfrBuildSuccessView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A54D RID: 238925 RVA: 0x0107B887 File Offset: 0x01079A87
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.InfrastructureMainView);
			}
			return new EUiViewName?((inParams.InfrActivityBuildStage.Type == EInfrActivityBuildStageType.Infrastructure) ? EUiViewName.InfrastructureMainView : EUiViewName.InfrRoadNetworkMainView);
		}
	}
}
