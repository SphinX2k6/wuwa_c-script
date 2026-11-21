using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D68 RID: 23912
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiMainView : OpenSystemBase
	{
		// Token: 0x0603A539 RID: 238905 RVA: 0x0107B567 File Offset: 0x01079767
		public OpenSystemHonamiMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A53A RID: 238906 RVA: 0x0107B570 File Offset: 0x01079770
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStorySmallLoadingView);
		}

		// Token: 0x0603A53B RID: 238907 RVA: 0x0107B57C File Offset: 0x0107977C
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
