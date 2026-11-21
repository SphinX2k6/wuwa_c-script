using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D96 RID: 23958
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShopView : OpenSystemBase
	{
		// Token: 0x0603A5C4 RID: 239044 RVA: 0x0107C8B3 File Offset: 0x0107AAB3
		public OpenSystemShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5C5 RID: 239045 RVA: 0x0107C8BC File Offset: 0x0107AABC
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

		// Token: 0x0603A5C6 RID: 239046 RVA: 0x0107C8FF File Offset: 0x0107AAFF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ShopView);
		}
	}
}
