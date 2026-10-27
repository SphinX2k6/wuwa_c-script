using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE0 RID: 27616
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFishingCage : OpenSystemBase
	{
		// Token: 0x060443B5 RID: 279477 RVA: 0x010D113B File Offset: 0x010CF33B
		public OpenSystemFishingCage(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443B6 RID: 279478 RVA: 0x010D1144 File Offset: 0x010CF344
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFishingCage.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFishingCage.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443B7 RID: 279479 RVA: 0x010D1187 File Offset: 0x010CF387
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DockyardCageView);
		}
	}
}
