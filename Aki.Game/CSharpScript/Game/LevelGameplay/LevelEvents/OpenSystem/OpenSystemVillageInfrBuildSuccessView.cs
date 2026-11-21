using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA5 RID: 23973
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVillageInfrBuildSuccessView : OpenSystemBase
	{
		// Token: 0x0603A5F5 RID: 239093 RVA: 0x0107CF61 File Offset: 0x0107B161
		public OpenSystemVillageInfrBuildSuccessView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5F6 RID: 239094 RVA: 0x0107CF6C File Offset: 0x0107B16C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemVillageInfrBuildSuccessView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemVillageInfrBuildSuccessView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5F7 RID: 239095 RVA: 0x0107CFAF File Offset: 0x0107B1AF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.VillageInfrMainView);
			}
			return new EUiViewName?((inParams.VillageInfrBuildStage.Type == EVillageInfrBuildType.Tree) ? EUiViewName.VillageInfrMainView : EUiViewName.VillageInfrBuildFinishTipView);
		}
	}
}
