using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8B RID: 23947
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueResMain : OpenSystemBase
	{
		// Token: 0x0603A5A2 RID: 239010 RVA: 0x0107C45F File Offset: 0x0107A65F
		public OpenSystemRogueResMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5A3 RID: 239011 RVA: 0x0107C468 File Offset: 0x0107A668
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueResMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueResMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5A4 RID: 239012 RVA: 0x0107C4A3 File Offset: 0x0107A6A3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RogueSeasonEntranceView);
		}
	}
}
