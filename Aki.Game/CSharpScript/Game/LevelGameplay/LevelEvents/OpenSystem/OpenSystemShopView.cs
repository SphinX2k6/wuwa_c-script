using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1D RID: 27677
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShopView : OpenSystemBase
	{
		// Token: 0x0604446C RID: 279660 RVA: 0x010D295F File Offset: 0x010D0B5F
		public OpenSystemShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604446D RID: 279661 RVA: 0x010D2968 File Offset: 0x010D0B68
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemShopView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemShopView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604446E RID: 279662 RVA: 0x010D29AB File Offset: 0x010D0BAB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShopView);
		}
	}
}
