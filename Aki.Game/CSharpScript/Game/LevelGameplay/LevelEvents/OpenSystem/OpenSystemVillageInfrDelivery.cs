using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA6 RID: 23974
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVillageInfrDelivery : OpenSystemBase
	{
		// Token: 0x0603A5F8 RID: 239096 RVA: 0x0107CFDE File Offset: 0x0107B1DE
		public OpenSystemVillageInfrDelivery(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5F9 RID: 239097 RVA: 0x0107CFE8 File Offset: 0x0107B1E8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemVillageInfrDelivery.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemVillageInfrDelivery.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5FA RID: 239098 RVA: 0x0107D02B File Offset: 0x0107B22B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VillageInfrWorldBuildView);
		}
	}
}
