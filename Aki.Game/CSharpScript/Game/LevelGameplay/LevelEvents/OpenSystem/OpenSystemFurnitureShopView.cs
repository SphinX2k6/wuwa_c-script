using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D5F RID: 23903
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFurnitureShopView : OpenSystemBase
	{
		// Token: 0x0603A51F RID: 238879 RVA: 0x0107B297 File Offset: 0x01079497
		public OpenSystemFurnitureShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A520 RID: 238880 RVA: 0x0107B2A0 File Offset: 0x010794A0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFurnitureShopView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFurnitureShopView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A521 RID: 238881 RVA: 0x0107B2DB File Offset: 0x010794DB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.FurnitureShopView);
		}
	}
}
