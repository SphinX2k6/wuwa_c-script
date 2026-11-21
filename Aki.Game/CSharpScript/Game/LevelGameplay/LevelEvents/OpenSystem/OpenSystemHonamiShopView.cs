using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D6A RID: 23914
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiShopView : OpenSystemBase
	{
		// Token: 0x0603A53F RID: 238911 RVA: 0x0107B61F File Offset: 0x0107981F
		public OpenSystemHonamiShopView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A540 RID: 238912 RVA: 0x0107B628 File Offset: 0x01079828
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

		// Token: 0x0603A541 RID: 238913 RVA: 0x0107B66B File Offset: 0x0107986B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryShopView);
		}
	}
}
