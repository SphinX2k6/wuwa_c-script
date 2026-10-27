using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C13 RID: 27667
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRoguelikeActivity : OpenSystemBase
	{
		// Token: 0x0604444D RID: 279629 RVA: 0x010D255B File Offset: 0x010D075B
		public OpenSystemRoguelikeActivity(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604444E RID: 279630 RVA: 0x010D2564 File Offset: 0x010D0764
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

		// Token: 0x0604444F RID: 279631 RVA: 0x010D25A7 File Offset: 0x010D07A7
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
