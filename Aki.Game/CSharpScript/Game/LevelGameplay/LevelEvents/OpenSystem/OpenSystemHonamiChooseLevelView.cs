using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BED RID: 27629
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiChooseLevelView : OpenSystemBase
	{
		// Token: 0x060443DB RID: 279515 RVA: 0x010D1573 File Offset: 0x010CF773
		public OpenSystemHonamiChooseLevelView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443DC RID: 279516 RVA: 0x010D157C File Offset: 0x010CF77C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiChooseLevelView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiChooseLevelView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443DD RID: 279517 RVA: 0x010D15B7 File Offset: 0x010CF7B7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryLevelInfoView);
		}
	}
}
