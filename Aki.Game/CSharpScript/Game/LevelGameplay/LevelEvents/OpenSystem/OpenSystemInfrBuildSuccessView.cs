using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF5 RID: 27637
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInfrBuildSuccessView : OpenSystemBase
	{
		// Token: 0x060443F3 RID: 279539 RVA: 0x010D18E5 File Offset: 0x010CFAE5
		public OpenSystemInfrBuildSuccessView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443F4 RID: 279540 RVA: 0x010D18F0 File Offset: 0x010CFAF0
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

		// Token: 0x060443F5 RID: 279541 RVA: 0x010D1933 File Offset: 0x010CFB33
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
