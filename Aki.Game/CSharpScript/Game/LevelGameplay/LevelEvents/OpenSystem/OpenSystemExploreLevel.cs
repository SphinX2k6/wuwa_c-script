using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDD RID: 27613
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemExploreLevel : OpenSystemBase
	{
		// Token: 0x060443AC RID: 279468 RVA: 0x010D1002 File Offset: 0x010CF202
		public OpenSystemExploreLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443AD RID: 279469 RVA: 0x010D100C File Offset: 0x010CF20C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemExploreLevel.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemExploreLevel.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443AE RID: 279470 RVA: 0x010D1047 File Offset: 0x010CF247
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ExploreLevelView);
		}
	}
}
