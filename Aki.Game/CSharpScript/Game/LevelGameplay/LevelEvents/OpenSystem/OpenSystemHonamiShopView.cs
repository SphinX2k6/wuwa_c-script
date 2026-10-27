using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF1 RID: 27633
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiShopView : OpenSystemBase
	{
		// Token: 0x060443E7 RID: 279527 RVA: 0x010D16CB File Offset: 0x010CF8CB
		public OpenSystemHonamiShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443E8 RID: 279528 RVA: 0x010D16D4 File Offset: 0x010CF8D4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiShopView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiShopView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443E9 RID: 279529 RVA: 0x010D1717 File Offset: 0x010CF917
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryShopView);
		}
	}
}
