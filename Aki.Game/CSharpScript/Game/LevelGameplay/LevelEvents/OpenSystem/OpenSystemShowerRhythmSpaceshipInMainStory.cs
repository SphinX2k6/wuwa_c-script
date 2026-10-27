using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C1F RID: 27679
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemShowerRhythmSpaceshipInMainStory : OpenSystemBase
	{
		// Token: 0x06044472 RID: 279666 RVA: 0x010D2A0F File Offset: 0x010D0C0F
		public OpenSystemShowerRhythmSpaceshipInMainStory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044473 RID: 279667 RVA: 0x010D2A18 File Offset: 0x010D0C18
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams, GeneralContext context)
		{
			return new EUiViewName?(EUiViewName.RhythmShipChoseLevelView);
		}

		// Token: 0x06044474 RID: 279668 RVA: 0x010D2A24 File Offset: 0x010D0C24
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
