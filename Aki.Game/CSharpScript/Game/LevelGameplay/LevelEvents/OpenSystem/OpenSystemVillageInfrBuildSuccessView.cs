using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2C RID: 27692
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVillageInfrBuildSuccessView : OpenSystemBase
	{
		// Token: 0x0604449D RID: 279709 RVA: 0x010D300D File Offset: 0x010D120D
		public OpenSystemVillageInfrBuildSuccessView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604449E RID: 279710 RVA: 0x010D3018 File Offset: 0x010D1218
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

		// Token: 0x0604449F RID: 279711 RVA: 0x010D305B File Offset: 0x010D125B
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
