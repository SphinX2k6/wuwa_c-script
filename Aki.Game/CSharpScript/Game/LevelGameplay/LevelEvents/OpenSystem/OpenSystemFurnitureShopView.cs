using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE6 RID: 27622
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFurnitureShopView : OpenSystemBase
	{
		// Token: 0x060443C7 RID: 279495 RVA: 0x010D1343 File Offset: 0x010CF543
		public OpenSystemFurnitureShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443C8 RID: 279496 RVA: 0x010D134C File Offset: 0x010CF54C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFurnitureShopView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFurnitureShopView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443C9 RID: 279497 RVA: 0x010D1387 File Offset: 0x010CF587
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FurnitureShopView);
		}
	}
}
