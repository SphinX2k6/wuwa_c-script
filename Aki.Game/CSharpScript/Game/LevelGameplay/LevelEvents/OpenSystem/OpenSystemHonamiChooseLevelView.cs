using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D66 RID: 23910
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiChooseLevelView : OpenSystemBase
	{
		// Token: 0x0603A533 RID: 238899 RVA: 0x0107B4C7 File Offset: 0x010796C7
		public OpenSystemHonamiChooseLevelView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A534 RID: 238900 RVA: 0x0107B4D0 File Offset: 0x010796D0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiChooseLevelView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiChooseLevelView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A535 RID: 238901 RVA: 0x0107B50B File Offset: 0x0107970B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryLevelInfoView);
		}
	}
}
