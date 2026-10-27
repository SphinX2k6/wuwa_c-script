using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2D RID: 27693
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemVillageInfrDelivery : OpenSystemBase
	{
		// Token: 0x060444A0 RID: 279712 RVA: 0x010D308A File Offset: 0x010D128A
		public OpenSystemVillageInfrDelivery(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060444A1 RID: 279713 RVA: 0x010D3094 File Offset: 0x010D1294
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

		// Token: 0x060444A2 RID: 279714 RVA: 0x010D30D7 File Offset: 0x010D12D7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VillageInfrWorldBuildView);
		}
	}
}
