using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BEF RID: 27631
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiMainView : OpenSystemBase
	{
		// Token: 0x060443E1 RID: 279521 RVA: 0x010D1613 File Offset: 0x010CF813
		public OpenSystemHonamiMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443E2 RID: 279522 RVA: 0x010D161C File Offset: 0x010CF81C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStorySmallLoadingView);
		}

		// Token: 0x060443E3 RID: 279523 RVA: 0x010D1628 File Offset: 0x010CF828
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiMainView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiMainView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
