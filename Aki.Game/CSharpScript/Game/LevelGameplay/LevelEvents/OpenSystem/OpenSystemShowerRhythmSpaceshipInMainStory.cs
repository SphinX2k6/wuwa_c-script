using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D98 RID: 23960
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShowerRhythmSpaceshipInMainStory : OpenSystemBase
	{
		// Token: 0x0603A5CA RID: 239050 RVA: 0x0107C963 File Offset: 0x0107AB63
		public OpenSystemShowerRhythmSpaceshipInMainStory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5CB RID: 239051 RVA: 0x0107C96C File Offset: 0x0107AB6C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams, GeneralContext context)
		{
			return new EUiViewName?(EUiViewName.RhythmShipChoseLevelView);
		}

		// Token: 0x0603A5CC RID: 239052 RVA: 0x0107C978 File Offset: 0x0107AB78
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemShowerRhythmSpaceshipInMainStory.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemShowerRhythmSpaceshipInMainStory.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
