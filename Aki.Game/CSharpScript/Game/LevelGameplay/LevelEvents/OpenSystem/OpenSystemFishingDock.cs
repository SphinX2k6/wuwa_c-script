using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE1 RID: 27617
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFishingDock : OpenSystemBase
	{
		// Token: 0x060443B8 RID: 279480 RVA: 0x010D1193 File Offset: 0x010CF393
		public OpenSystemFishingDock(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443B9 RID: 279481 RVA: 0x010D119C File Offset: 0x010CF39C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFishingDock.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFishingDock.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443BA RID: 279482 RVA: 0x010D11DF File Offset: 0x010CF3DF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FishingDockView);
		}
	}
}
