using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D7F RID: 23935
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhotographView : OpenSystemBase
	{
		// Token: 0x0603A57E RID: 238974 RVA: 0x0107BFB2 File Offset: 0x0107A1B2
		public OpenSystemPhotographView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A57F RID: 238975 RVA: 0x0107BFBC File Offset: 0x0107A1BC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemPhotographView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemPhotographView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A580 RID: 238976 RVA: 0x0107BFFF File Offset: 0x0107A1FF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.PhotographView);
		}
	}
}
