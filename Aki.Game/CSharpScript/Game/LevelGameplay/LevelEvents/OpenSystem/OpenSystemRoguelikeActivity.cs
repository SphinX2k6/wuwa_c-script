using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8C RID: 23948
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRoguelikeActivity : OpenSystemBase
	{
		// Token: 0x0603A5A5 RID: 239013 RVA: 0x0107C4AF File Offset: 0x0107A6AF
		public OpenSystemRoguelikeActivity(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5A6 RID: 239014 RVA: 0x0107C4B8 File Offset: 0x0107A6B8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRoguelikeActivity.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRoguelikeActivity.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5A7 RID: 239015 RVA: 0x0107C4FB File Offset: 0x0107A6FB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.RoguelikeActivityView);
			}
			if (inParams.BoardId == 100)
			{
				return new EUiViewName?(EUiViewName.WeeklyRogueActivityView);
			}
			return new EUiViewName?(EUiViewName.RoguelikeActivityView);
		}
	}
}
