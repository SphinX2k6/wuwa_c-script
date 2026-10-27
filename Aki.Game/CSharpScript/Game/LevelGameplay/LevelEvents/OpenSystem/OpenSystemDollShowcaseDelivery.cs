using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD8 RID: 27608
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDollShowcaseDelivery : OpenSystemBase
	{
		// Token: 0x0604439D RID: 279453 RVA: 0x010D0DC4 File Offset: 0x010CEFC4
		public OpenSystemDollShowcaseDelivery(LevelEventOpenSystem levelEventOpenSystem) : base(levelEventOpenSystem)
		{
		}

		// Token: 0x0604439E RID: 279454 RVA: 0x010D0DD0 File Offset: 0x010CEFD0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDollShowcaseDelivery.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDollShowcaseDelivery.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604439F RID: 279455 RVA: 0x010D0E13 File Offset: 0x010CF013
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DollGrabDeliveryView);
		}
	}
}
